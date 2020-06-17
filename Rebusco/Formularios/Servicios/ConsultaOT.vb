Public Class ConsultaOT
    Const T_ID = 0
    Const T_SHOW = 1
    Const T_IMPRIMIR = 2
    Const T_SERVICIO = 3
    Const T_OT = 4
    Const T_CLIENTE = 5
    Const T_TECNICO = 6
    Const T_ESTADO = 7
    Const T_FECHAING = 8
    Const T_FECHAENT = 9
    Const T_TIPODOC = 10
    Const T_NUMDOC = 11
    Const T_FECHA = 12
    Const T_MONTO = 13
    Const T_MONTOOT = 14

    Dim wDesde, wHasta As Date
    Dim G_FORMDOCUMENTO As String = ""

    Sub New()
        InitializeComponent()
    End Sub
    Sub New(wFormulario As String)
        InitializeComponent()
        G_FORMDOCUMENTO = wFormulario
    End Sub

    Private Sub ConsultaOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cDesde.Value = IniFinFecha(1, Now.AddMonths(-1))
        cHasta.Value = IniFinFecha(2, Now)
        cTecnicos.LoadItemsObj("Usuarios", "Usuario", "NombreUsr", " WHERE Acceso = 3")
        cEstado.LoadItemsObj("Estados", "Estado", "DescEstado", " WHERE Tipo = 'O'")
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")

        If FE_BV Then
            oAutomatico.Checked = False
        Else
            oAutomatico.Checked = True
        End If

        Call Auditoria(Me.Name, "Ingresó al Módulo", UsuarioActual, CStr(G_LOCALACTUAL))
    End Sub

    Private Sub xTecnico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTecnico.KeyPress
        e.NextControl(cEstado)
    End Sub

    Private Sub xOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xOT.KeyPress
        ValidarDigitos(e)
        e.NextControl(xTecnico)
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

    Private Sub oFechaOT_CheckedChanged(sender As Object, e As EventArgs)
        Dim wRadioButton As RadioButton = DirectCast(sender, RadioButton)
        wRadioButton.ForeColor = If(wRadioButton.Checked, Color.White, Color.Black)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim wLCLientes = DC.T_Clientes.ToList()
        Dim wLTipoDoc = DC.T_TipoDoc.ToList()
        Dim wLEstados = DC.T_Estados.ToList()
        Dim wLUsuarios = DC.T_Usuarios.ToList()
        Dim wOTs = New List(Of T_OT)

        If oFechaOT.Checked Then
            wOTs = DC.T_OT.Where(Function(x) x.FechaEntrega >= cDesde.Value.Date And x.FechaEntrega <= cHasta.Value.Date).ToList()
        Else
            wOTs = DC.T_OT.Where(Function(x) x.Fecha >= cDesde.Value.Date And x.Fecha <= cHasta.Value.Date).ToList()
        End If

        If xOT.Text <> "" Then wOTs = wOTs.Where(Function(x) x.OT = xOT.ToDecimal).ToList()
        If xTecnico.Text <> "" Then wOTs = wOTs.Where(Function(x) x.OT = xOT.ToDecimal).ToList()
        If cEstado.Text <> "" Then wOTs.Where(Function(x) x.Estado = cEstado.SelectedValue.ToString).ToList()
        If xCliente.Text <> "" Then wOTs.Where(Function(x) x.Cliente = xCliente.ToDecimal).ToList()
        If cLocal.Text <> "" Then wOTs.Where(Function(x) x.Local = cLocal.SelectedValue.ToString.ToDecimal).ToList()

        Dim wListadoOT = New List(Of OTListado)
        If wOTs.Any Then
            For Each wOT In wOTs
                Dim wNombreCliente = ""
                Dim wCliente = wLCLientes.FirstOrDefault(Function(x) x.Cliente = wOT.Cliente)
                If wCliente IsNot Nothing Then wNombreCliente = wCliente.Nombre

                Dim wNombreTecnico = ""
                Dim wTecnico = wLUsuarios.FirstOrDefault(Function(x) x.Usuario = wOT.Tecnico)
                If wTecnico IsNot Nothing Then wNombreTecnico = wTecnico.NombreUsr

                Dim wDescripcionTipoDoc = ""
                Dim wTipoDoc = wLTipoDoc.FirstOrDefault(Function(x) x.TipoDoc = wOT.TipoDoc)
                If wTipoDoc IsNot Nothing Then wDescripcionTipoDoc = wTipoDoc.DescTipoDoc

                Dim wDescripcionEstado = ""
                Dim wEstadoOT = wLEstados.FirstOrDefault(Function(x) x.Estado = wOT.Estado)
                If wEstadoOT IsNot Nothing Then wDescripcionEstado = wEstadoOT.DescEstado


                wListadoOT.Add(New OTListado With {
                               .OT = wOT.OT,
                               .FechaOT = wOT.Fecha,
                               .FechaEntrega = wOT.FechaEntrega,
                               .Cliente = wOT.Cliente,
                               .NombreCliente = wNombreCliente,
                               .Tecnico = wOT.Tecnico,
                               .NombreTecnico = wNombreTecnico,
                               .TipoDoc = wOT.TipoDoc,
                               .TipoDocDesc = wDescripcionTipoDoc,
                               .Numdoc = wOT.NumDoc,
                               .Estado = wOT.Estado,
                               .EstadoDesc = wDescripcionEstado})
            Next

            Dim wReporte = New ListadoOT
            Dim wListaParametros = ParametroLocal()
            Dim wRangoFecha = {New RangoFecha With {.FechaDesde = cDesde.Value.Date, .FechaHasta = cHasta.Value.Date}}.ToList()
            wReporte.Database.Tables("MarketONE_OTListado").SetDataSource(wListadoOT)
            wReporte.Database.Tables("MarketONE_RangoFecha").SetDataSource(wRangoFecha)
            wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wListaParametros)

            If oAutomatico.Checked Then
                wReporte.PrintToPrinter(1, False, 0, 0)
            Else
                VisorReportes.MostrarReporte(wReporte)
                VisorReportes.Show()
                VisorReportes.BringToFront()
            End If

        Else
            MsgError("No se encuentra registros para los filtros indicados")
        End If
        '    Dim wDesde, wHasta, wFiltro As String, lFiltro As String

        '    'On Error GoTo Error
        '    Me.MousePointer = vbHourglass
        '    Salida.Reset

        '    wDesde = Format(cDesde.Value, "yyyy,mm,dd")
        '    wHasta = Format(cHasta.Value, "yyyy,mm,dd")

        '    Salida.Connect = ConectaReporte

        '    If Trim(cLocal) = "" Then
        '        lFiltro = " (1=1) "
        '    Else
        '    Set Swap = Sql("Select Local from Locales where NombreLocal = '" & Trim(cLocal) & "'")
        '    If Swap.RecordCount > 0 Then
        '            lFiltro = " {OT.Local} = " & NUM(Swap("Local")) & " "
        '        Else
        '            El_Error("Error en Local")
        '            Exit Sub
        '        End If
        '    End If

        '    If oFechaOT.Value Then
        '        wFiltro = lFiltro & " and {OT.Fecha} >= Date(" & wDesde & ") AND {OT.Fecha} <= Date(" & wHasta & ") "
        '    Else
        '        wFiltro = lFiltro & " and {OT.FechaCierre} >= Date(" & wDesde & ") AND {OT.FechaCierre} <= Date(" & wHasta & ") "
        '    End If

        '    If cEstado.Text <> "Todos" Then
        '        wFiltro = wFiltro & " AND ({Estados.DescEstado} = '" & Trim(cEstado.Text) & "')"
        '    End If

        '    If Val(xOT.Text) > 0 Then
        '        wFiltro = wFiltro & " AND ({OT.OT} = " & Val(xOT.Text) & ")"
        '    End If

        '    If Trim(xTecnico.Text) <> "" And Trim(cTecnicos.Text) <> "" Then
        '        wFiltro = wFiltro & " AND ({Usuarios.NombreUsr} = '" & Trim(cTecnicos.Text) & "')"
        '    End If

        '    If Trim(xCliente.Text) <> "" And Trim(xNombreCliente.Text) <> "" Then
        '        wFiltro = wFiltro & " AND ({Clientes.Nombre} = '" & Trim(xNombreCliente.Text) & "')"
        '    End If


        '    Salida.SelectionFormula = wFiltro
        '    Salida.ReportFileName = Ruta_Imprimir("ListadoOT.RPT")

        '    If oImprimir.Value Then
        '        Salida.Destination = crptToPrinter
        '    Else
        '        Salida.WindowState = crptMaximized
        '    End If

        '    Salida.DiscardSavedData = True
        '    Salida.Action = 1
        '    Me.MousePointer = vbDefault
        '    Call Auditoria(Me.Name, "Generó Reporte", xOT.Text, CDbl(LocalActual))
        '    Exit Sub
        '    Error
        'Me.MousePointer = vbDefault
        '    El_Error("No se pudo imprimir, asegurese que la impresora este conectada")
    End Sub

    Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs) Handles xTabla.DoubleClick

        If G_FORMDOCUMENTO <> "" Then
            Select Case G_FORMDOCUMENTO
                Case "EmisionDocumento"
                    VentaLocal.xNumDocRef.Text = xTabla.GetData(xTabla.RowSel, T_OT).ToString
                    VentaLocal.CargarDocumento()
                    Close()
            End Select
        End If

    End Sub

    Private Sub bAnulacionOT_Click(sender As Object, e As EventArgs) Handles bAnulacionOT.Click
        AnularOT.Show()
        AnularOT.BringToFront()
    End Sub

    Private Sub bMostrar_Click(sender As Object, e As EventArgs) Handles bMostrar.Click
        If cDesde.Value > cHasta.Value Then
            MsgError("La fecha inicial debe ser inferior a la final.")
            cDesde.Focus()
            Exit Sub
        End If
        wDesde = CDate(cDesde.Value.Date & " 00:00:00 ")
        wHasta = CDate(cHasta.Value.Date & " 23:59:59 ")
        Consultar()
        Auditoria(Me.Name, "Consultó OT", xOT.Text, CStr(G_LOCALACTUAL))
    End Sub

    Sub Consultar()
        Dim wFiltro As String

        If cLocal.Text = "" Then
            wFiltro = "WHERE (1=1)  "
        Else
            wFiltro = "WHERE o.Local=" & Val(cLocal.SelectedValue.ToString) & " "
        End If


        If xOT.Text <> "" Then
            wFiltro = If(wFiltro = "", " WHERE ", wFiltro & " AND") & " O.OT=" & Val(xOT.Text) & " "
        End If

        If oFechaOT.Checked Then
            wFiltro = If(wFiltro = "", " WHERE ", wFiltro & " AND") & " Fecha BETWEEN '" & wDesde & "' AND '" & wHasta & "'"
        Else
            wFiltro = If(wFiltro = "", " WHERE ", wFiltro & " AND") & " FechaCierre BETWEEN '" & wDesde & "' AND '" & wHasta & "'"
        End If


        If cTecnicos.Text <> "" Then
            wFiltro = If(wFiltro = "", " WHERE ", wFiltro & " AND") & " o.Tecnico ='" & Trim(xTecnico.Text) & "' "
        End If

        If xNombreCliente.Text <> "" Then
            wFiltro = If(wFiltro = "", " WHERE ", wFiltro & " AND") & " o.Cliente ='" & Trim(xCliente.Text) & "' "
        End If

        If cEstado.Text <> "" Then
            wFiltro = If(wFiltro = "", " WHERE ", wFiltro & " AND") & " o.Estado='" & cEstado.SelectedValue.ToString & "' "
        End If


        Dim wOT = SQL("SELECT o.OT,c.Nombre ,ISNULL(u.NombreUsr,'')as NombreUsr,e.DescEstado,o.Fecha,o.TotalOT,o.Local, " &
                 " o.FechaCierre,o.TipoDoc,o.NumDoc,ISNULL(t.DescTipoDoc,'') as DescTipoDoc  " &
                 " FROM OT o Inner Join Clientes c on o.Cliente=c.Cliente " &
                 " LEFT Join Usuarios u on o.Tecnico=u.Usuario " &
                 " LEFT Join Estados e on o.Estado=e.Estado and e.Tipo = 'O' " &
                 " LEFT Join TipoDoc t on o.TipoDoc=t.TipoDoc " &
                 "  " & wFiltro & "")



        If wOT.Rows.Count = 0 Then
            MsgError("No hay datos para mostrar")
            Titulos()
            xOT.Focus()
            Exit Sub
        End If

        Titulos()
        For Each wO As DataRow In wOT.Rows
            xTabla.AddItem("")
            xTabla.SetCellImage(xTabla.Rows.Count - 1, T_SHOW, My.Resources.edit16)
            xTabla.SetCellImage(xTabla.Rows.Count - 1, T_IMPRIMIR, My.Resources.print)
            xTabla.SetCellImage(xTabla.Rows.Count - 1, T_SERVICIO, My.Resources.Toolsb)
            xTabla.SetData(xTabla.Rows.Count - 1, T_OT, Trim(wO.GetText("OT")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_CLIENTE, Trim(wO.GetText("Nombre")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_TECNICO, Trim(wO.GetText("NombreUsr")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, Trim(wO.GetText("DescEstado")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_TIPODOC, Trim(wO.GetText("DescTipoDoc")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_NUMDOC, Trim(wO.GetText("NumDoc")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_FECHAING, FormatDateTime(wO.GetDate("Fecha"), DateFormat.ShortDate))

            'xTabla.Setdata(xTabla.Rows - 1, T_FECHAENT) = Trim(OT.Fields("FechaEntrega"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_FECHAENT, FormatDateTime(wO.GetDate("FechaCierre"), DateFormat.ShortDate))
            If Val(wO.GetText("NumDoc")) > 0 Then

                Dim wDocG = SQL("Select TipoDoc,Numero,Fecha,Total from DocumentosG where Local=" & Val(wO.GetText("Local")) & " and TipoDoc = '" & wO.GetText("TipoDoc") & "' and Numero=" & Val(wO.GetText("numdoc"))).Top
                If wDocG IsNot Nothing Then
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, FormatDateTime(wDocG.GetDate("Fecha"), DateFormat.ShortDate))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_MONTO, Trim(wDocG.GetText("Total")))
                End If
            End If
            xTabla.SetData(xTabla.Rows.Count - 1, T_MONTOOT, Trim(wO.GetText("TotalOT")))
            'Agregar iconos a la grilla
        Next
    End Sub

    Private Sub bIngresoOT_Click(sender As Object, e As EventArgs) Handles bIngresoOT.Click
        IngresoOT.Show()
        IngresoOT.BringToFront()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        Titulos()
        cDesde.Value = IniFinFecha(1, Now)
        cHasta.Value = IniFinFecha(2, Now)
    End Sub

    Sub Titulos()
        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 15

        xTabla.Cols(T_ID).Width = 0
        xTabla.Cols(T_SHOW).Width = 0 '60
        xTabla.Cols(T_IMPRIMIR).Width = 0 '60
        xTabla.Cols(T_SERVICIO).Width = 0 ' 60
        xTabla.Cols(T_OT).Width = 70
        xTabla.Cols(T_CLIENTE).Width = 230
        xTabla.Cols(T_TECNICO).Width = 160
        xTabla.Cols(T_ESTADO).Width = 120
        xTabla.Cols(T_TIPODOC).Width = 120
        xTabla.Cols(T_NUMDOC).Width = 90
        xTabla.Cols(T_FECHAING).Width = 70
        xTabla.Cols(T_FECHAENT).Width = 70
        xTabla.Cols(T_FECHA).Width = 90
        xTabla.Cols(T_MONTO).Width = 90
        xTabla.Cols(T_MONTOOT).Width = 90

        xTabla.Cols(T_ID).Caption = ""
        xTabla.Cols(T_SHOW).Caption = "Modificar"
        xTabla.Cols(T_IMPRIMIR).Caption = "Imprimir"
        xTabla.Cols(T_SERVICIO).Caption = "Servicio"
        xTabla.Cols(T_OT).Caption = "OT"
        xTabla.Cols(T_CLIENTE).Caption = "Cliente"
        xTabla.Cols(T_TECNICO).Caption = "Técnico"
        xTabla.Cols(T_ESTADO).Caption = "Estado"
        xTabla.Cols(T_TIPODOC).Caption = "Tipo Doc."
        xTabla.Cols(T_NUMDOC).Caption = "N° Documento"
        xTabla.Cols(T_FECHAING).Caption = "F. Ingreso"
        xTabla.Cols(T_FECHAENT).Caption = "F. Cierre"
        xTabla.Cols(T_FECHA).Caption = "F.Doc"
        xTabla.Cols(T_MONTO).Caption = "Monto Doc."
        xTabla.Cols(T_MONTOOT).Caption = "Monto OT"

        xTabla.Cols(T_SHOW).ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter
        xTabla.Cols(T_IMPRIMIR).ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter
        xTabla.Cols(T_SERVICIO).ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter
    End Sub

    Private Sub cTecnicos_KeyDown(sender As Object, e As KeyEventArgs) Handles cTecnicos.KeyDown
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

    Private Sub xOT_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xOT.Validating
        If xOT.Text.Trim = "" Then Exit Sub
        Dim wOT = SQL("SELECT * FROM OT WHERE OT=" & Val(xOT.Text) & "").Top
        If wOT Is Nothing Then
            MsgError("La OT ingresada no existe")
            xOT.Focus()
        End If
    End Sub

    Private Sub xTecnico_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xTecnico.Validating
        If xTecnico.Text = "" Then Exit Sub
        If xTecnico.Text.Trim <> "" Then
            cTecnicos.SelectedValue = xTecnico.Text.Trim
            If cTecnicos.Text = "" Then
                MsgError("Técnico no encontrado")
                xTecnico.Clear()
                xTecnico.Focus()
            End If
        End If
    End Sub

    Private Sub cTecnicos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cTecnicos.SelectedIndexChanged
        If cTecnicos.Text <> "" Then
            xTecnico.Text = cTecnicos.SelectedValue.ToString
        Else
            xTecnico.Clear()
        End If
    End Sub

    Private Sub cEstados_KeyDown(sender As Object, e As KeyEventArgs) Handles cEstado.KeyDown
        If e.KeyCode = Keys.Enter Then bMostrar.Focus()
    End Sub

#Region "Menu"
    Private Sub xTabla_MouseDown(sender As Object, e As MouseEventArgs) Handles xTabla.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim xTabla = DirectCast(sender, C1.Win.C1FlexGrid.C1FlexGrid)
            Dim wHit As C1.Win.C1FlexGrid.HitTestInfo = xTabla.HitTest(e.Location)
            xTabla.Row = wHit.Row
            xTabla.Col = wHit.Column
            mMenuTabla.Show(xTabla, wHit.Point)
        End If
    End Sub

    Private Sub mImprimirOT_Click(sender As Object, e As EventArgs) Handles mImprimirOT.Click
        If xTabla.Row = -1 Then Exit Sub
        Cursor = Cursors.WaitCursor
        Imprimir_OT(xTabla.GetData(xTabla.Row, T_OT).ToString.ToDouble, oAutomatico.Checked)
        Cursor = Cursors.Default
    End Sub
    Private Sub mModificar_Click(sender As Object, e As EventArgs) Handles mModificar.Click
        If xTabla.Row = -1 Then Exit Sub
        Cursor = Cursors.WaitCursor
        IngresoOT.Show()
        IngresoOT.xOT.Text = Trim(xTabla.GetData(xTabla.RowSel, T_OT).ToString)
        IngresoOT.xOT_Validating()
        Cursor = Cursors.Arrow
    End Sub


    Private Sub mServicio_Click(sender As Object, e As EventArgs) Handles mServicio.Click
        If xTabla.Row = -1 Then Exit Sub
        Cursor = Cursors.WaitCursor
        ServicioTecnico.Show()
        ServicioTecnico.xOT.Text = Trim(xTabla.GetData(xTabla.RowSel, T_OT).ToString)
        ServicioTecnico.Consultar()
        Cursor = Cursors.Arrow
    End Sub

#End Region
End Class