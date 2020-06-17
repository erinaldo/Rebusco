Public Class Click_Collect
    Const T_ID = 0
    Const T_SHOW = 1
    Const T_TICKET = 2
    Const T_CLIENTE = 3
    Const T_LOCAL = 4
    Const T_DOR = 5
    Const T_TRANSACCION = 6
    Const T_ESTADO = 7
    Const T_FECHA = 8
    Const T_TOTAL = 9

    Dim wDesde, wHasta As Date
    Dim G_FORMDOCUMENTO As String = ""

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(wFormulario As String)
        InitializeComponent()
        G_FORMDOCUMENTO = wFormulario
    End Sub

    Private Sub Click_Collect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cDesde.Value = IniFinFecha(1, CDate("01/01/" + Year(Now).ToString))
        cHasta.Value = IniFinFecha(2, Now)
        cEstado.LoadItemsObj("Estados", "Estado", "DescEstado", " WHERE Tipo = 'W'")
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")

        oAutomatico.Checked = False

        Call Auditoria(Me.Name, "Ingresó al Módulo", UsuarioActual, CStr(G_LOCALACTUAL))
    End Sub

    Private Sub xTicket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTicket.KeyPress
        ValidarDigitos(e)
        e.NextControl(cLocal)
    End Sub

    Private Sub cEstados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cEstado.SelectedIndexChanged
        If cEstado.Text.Trim <> "" Then
            xCliente.Focus()
        End If
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        ValidarDigitos(e)
        e.NextControl(bMostrar)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs) Handles xTabla.DoubleClick
        'Mostrar los datos del Ticket
        If Val(xTabla.GetData(xTabla.Row, T_TICKET)) > 0 Then
            Timer.Enabled = False
            DatosTicket.xTicket.Text = xTabla.GetData(xTabla.Row, T_TICKET).ToString
            DatosTicket.Mostrar_Datos()
            DatosTicket.ShowDialog()
            DatosTicket.BringToFront()
            'If Not oAutomatico.Checked Then Consultar()
            Timer.Enabled = oAutomatico.Checked
        End If
    End Sub

    Private Sub bMostrar_Click(sender As Object, e As EventArgs) Handles bMostrar.Click
        Timer.Enabled = False
        Consultar()
    End Sub

    Sub Consultar()
        Dim wFiltro As String

        If cDesde.Value > cHasta.Value Then
            MsgError("La fecha inicial debe ser inferior a la final.")
            cDesde.Focus()
            Exit Sub
        End If
        wDesde = CDate(cDesde.Value.Date & " 00:00:00 ")
        wHasta = CDate(cHasta.Value.Date & " 23:59:59 ")

        Me.Cursor = Cursors.WaitCursor

        If cLocal.Text = "" Then
            wFiltro = "WHERE (1=1)  "
        Else
            wFiltro = "WHERE T.Local=" & Val(cLocal.SelectedValue.ToString) & " "
        End If


        wFiltro = If(wFiltro = "", " WHERE ", wFiltro & " AND") & " Fecha BETWEEN '" & wDesde & "' AND '" & wHasta & "'"

        If xNombreCliente.Text <> "" Then
            wFiltro = If(wFiltro = "", " WHERE ", wFiltro & " AND") & " T.Cliente ='" & Trim(xCliente.Text) & "' "
        End If

        If cEstado.Text <> "" Then
            wFiltro = If(wFiltro = "", " WHERE ", wFiltro & " AND") & " T.Estado='" & cEstado.SelectedValue.ToString & "' "
        End If

        If xTicket.Text <> "" Then
            wFiltro = " WHERE T.Ticket=" & Val(xTicket.Text)
        End If

        Dim wTik = SQL("SELECT T.Ticket, C.Nombre , E.DescEstado, T.Fecha, T.Total, T.Local, L.NombreLocal, T.DespachoRetiro, T.IDTransaccion" &
                 " FROM TikGen as T Left Join Clientes as C on T.Cliente=C.Cliente " &
                 " LEFT Join Estados as E on T.Estado = E.Estado and E.Tipo = 'W' " &
                 " LEFT Join Locales as L on T.Local = L.Local  " &
                 "  " & wFiltro &
                 " ORDER BY Fecha")

        If wTik.Rows.Count = 0 Then
            MsgError("No hay datos para mostrar")
            Titulos()
            xTicket.Focus()
            Exit Sub
        End If

        Titulos()
        For Each wT As DataRow In wTik.Rows
            xTabla.AddItem("")
            xTabla.SetCellImage(xTabla.Rows.Count - 1, T_SHOW, My.Resources.edit16)
            xTabla.SetData(xTabla.Rows.Count - 1, T_TICKET, Trim(wT.GetText("Ticket")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_CLIENTE, Trim(wT.GetText("Nombre")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, Trim(wT.GetText("DescEstado")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, FormatDateTime(wT.GetDate("Fecha"), DateFormat.GeneralDate))
            xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, Trim(wT.GetText("NombreLocal")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_DOR, IIf(Trim(wT.GetText("DespachoRetiro")) = "D", "Despacho", "Retiro"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, CDbl(wT.GetText("Total")).ToString("#,##0"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_TRANSACCION, wT.GetText("IdTransaccion"))
        Next

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        Titulos()
        cDesde.Value = IniFinFecha(1, CDate("01/01/" + Year(Now).ToString))
        cHasta.Value = IniFinFecha(2, Now)
        oAutomatico.Checked = False
    End Sub

    Sub Titulos()
        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 10

        xTabla.Cols(T_ID).Width = 0
        xTabla.Cols(T_SHOW).Width = 0
        xTabla.Cols(T_TICKET).Width = 70
        xTabla.Cols(T_CLIENTE).Width = 210
        xTabla.Cols(T_ESTADO).Width = 120
        xTabla.Cols(T_DOR).Width = 70
        xTabla.Cols(T_TRANSACCION).Width = 160
        xTabla.Cols(T_FECHA).Width = 130
        xTabla.Cols(T_TOTAL).Width = 0
        xTabla.Cols(T_LOCAL).Width = 120

        xTabla.Cols(T_ID).Caption = ""
        xTabla.Cols(T_SHOW).Caption = ""
        xTabla.Cols(T_TICKET).Caption = "Ticket"
        xTabla.Cols(T_CLIENTE).Caption = "Cliente"
        xTabla.Cols(T_ESTADO).Caption = "Estado"
        xTabla.Cols(T_DOR).Caption = "D/R"
        xTabla.Cols(T_TRANSACCION).Caption = "Transacción"
        xTabla.Cols(T_FECHA).Caption = "Fecha / Hora"
        xTabla.Cols(T_TOTAL).Caption = "Total"
        xTabla.Cols(T_LOCAL).Caption = "Local"

        xTabla.Cols(T_SHOW).ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter

    End Sub

    Private Sub cTecnicos_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then cEstado.Focus()
    End Sub

    Private Sub xCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles xCliente.KeyDown
        If e.KeyCode = Keys.F3 Then bBuscarC.Buscar_Click()
    End Sub

    Private Sub xCliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xCliente.Validating
        If xCliente.Text <> "" Then
            Dim wCli = SQL("SELECT Nombre FROM Clientes WHERE Cliente=" & Val(xCliente.Text) & "").Top
            If wCli Is Nothing Then
                MsgError("El Cliente ingresado no existe")
                xCliente.Focus()
            Else
                xNombreCliente.Text = Trim(wCli.GetText("Nombre"))
                Exit Sub
            End If
        End If
        xNombreCliente.Text = ""
    End Sub

    Private Sub xTiket_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xTicket.Validating
        If xTicket.Text.Trim = "" Then Exit Sub
        Dim wTk = SQL("SELECT * FROM TikGen WHERE Ticket=" & Val(xTicket.Text) & "").Top
        If wTk Is Nothing Then
            MsgError("Ticket no existe")
            xTicket.Focus()
        End If
    End Sub

    Private Sub cEstados_KeyDown(sender As Object, e As KeyEventArgs) Handles cEstado.KeyDown
        If e.KeyCode = Keys.Enter Then bMostrar.Focus()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Consultar()
    End Sub

    Private Sub xTabla_Click(sender As Object, e As EventArgs) Handles xTabla.Click

    End Sub

    Private Sub oAutomatico_CheckedChanged(sender As Object, e As EventArgs) Handles oAutomatico.CheckedChanged
        If oAutomatico.Checked Then
            oAutomatico.Text = "ON"
            oAutomatico.BackColor = Color.Yellow
            Timer.Enabled = True
            Timer.Interval = 60000  'Cada un minuto 
            bMostrar.Enabled = False
            Titulos()
            cDesde.Value = IniFinFecha(1, CDate("01/01/" + Year(Now).ToString))
            cHasta.Value = IniFinFecha(2, Now)
            Consultar()
        Else
            oAutomatico.Text = "OFF"
            oAutomatico.BackColor = Color.Transparent
            Timer.Enabled = False
            bMostrar.Enabled = True
        End If
    End Sub

End Class