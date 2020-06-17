Public Class ConsultaAuditoria
    Implements iFormulario
    Const T_ID = 0
    Const T_LUGAR = 1
    Const T_FECHA = 2
    Const T_HORA = 3
    Const T_LOCAL = 4
    Const T_USUARIO = 5
    Const T_PROCESO = 6
    Const T_EVENTO = 7

    Private Sub ConsultaAuditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Titulos()
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        CargarCombos()
    End Sub
    Sub CargarCombos()
        cProceso.Items.Clear()
        cEvento.Items.Clear()
        Dim wAud As New List(Of ItemCombo)
        Dim DC = New RebuscoDataContext(P_CONEXION)

        wAud.Add(New ItemCombo With {.ID = "0", .Desc = ""})
        wAud.AddRange(DC.T_Auditoria.Where(Function(x) x.Proceso <> "").OrderBy(Function(x) x.Proceso) _
                                  .Select(Function(x) New ItemCombo With {.ID = x.Proceso, .Desc = x.Proceso}).Distinct.ToList)
        If wAud.Any Then
            cProceso.DisplayMember = "Desc"
            cProceso.ValueMember = "ID"
            cProceso.DataSource = wAud
        End If

        wAud = New List(Of ItemCombo)
        wAud.Add(New ItemCombo With {.ID = "0", .Desc = ""})
        wAud.AddRange(DC.T_Auditoria.Select(Function(x) New ItemCombo With {.ID = x.Evento, .Desc = x.Evento}).Distinct.ToList)
        If wAud.Any Then
            cEvento.DisplayMember = "Desc"
            cEvento.ValueMember = "ID"
            cEvento.DataSource = wAud
        End If
    End Sub
    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
        Titulos()
    End Sub
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub
    Private Sub bBuscarV_Click(sender As Object, e As EventArgs) Handles bBuscarV.Click
        Dim wQuery As String
        wQuery = "SELECT Usuario as 'Vendedor', NombreUsr as 'Nombre' From Usuarios"
        Buscador.Show()
        Buscador.Configurar(wQuery, "NombreUsr", Me, "Usuarios", xUsuario)
    End Sub
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub
    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        Dim wFiltros = ""

        If cLocal.Text <> "" Then wFiltros += " AND Local = '" & cLocal.SelectedValue.ToString & "'"
        If xUsuario.Text.Trim <> "" Then wFiltros += " AND Usuario = '" & xUsuario.Text.Trim & "'"
        If cProceso.Text <> "" Then wFiltros += " AND Proceso = '" & cProceso.Text & "'"
        If cEvento.Text <> "" Then wFiltros += " AND Evento = '" & cEvento.Text & "'"



        Dim Aud = SQL("SELECT * FROM Auditoria WHERE Fecha BETWEEN '" & dDesde.Value & "' AND '" & dHasta.Value & "' " & wFiltros)

        If Aud.Rows.Count > 0 Then
            Titulos()
            For Each wA As DataRow In Aud.Rows
                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_ID, wA.GetText("ID"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_LUGAR, wA.GetText("Lugar"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, FormatDateTime(wA.GetDate("Fecha"), DateFormat.ShortDate))
                xTabla.SetData(xTabla.Rows.Count - 1, T_HORA, wA.GetText("Hora"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, wA.GetText("Local"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_USUARIO, wA.GetText("Usuario"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_PROCESO, wA.GetText("Proceso"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_EVENTO, wA.GetText("Evento"))
            Next
        Else
            MsgError("No se encuentran registros")
        End If


    End Sub
    Sub Titulos()

        xTabla.Redraw = False
        xTabla.Clear()
        xTabla.Cols.Count = 8
        xTabla.Rows.Count = 1

        xTabla.Cols(T_ID).Caption = "ID"
        xTabla.Cols(T_LUGAR).Caption = "Lugar"
        xTabla.Cols(T_FECHA).Caption = "Fecha"
        xTabla.Cols(T_HORA).Caption = "Hora"
        xTabla.Cols(T_LOCAL).Caption = "Local"
        xTabla.Cols(T_USUARIO).Caption = "Usuario"
        xTabla.Cols(T_PROCESO).Caption = "Proceso"
        xTabla.Cols(T_EVENTO).Caption = "Evento"

        xTabla.Cols(T_ID).Width = 50
        xTabla.Cols(T_LUGAR).Width = 70
        xTabla.Cols(T_FECHA).Width = 70
        xTabla.Cols(T_HORA).Width = 60
        xTabla.Cols(T_LOCAL).Width = 50
        xTabla.Cols(T_USUARIO).Width = 70
        xTabla.Cols(T_PROCESO).Width = 300
        xTabla.Cols(T_EVENTO).Width = 200
        xTabla.Redraw = True

    End Sub

    Private Sub xUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xUsuario.Validating
        If xUsuario.Text.Trim = "" Then
            xNombre.Clear()
            Exit Sub
        End If

        Dim wVen = SQL("SELECT NombreUsr FROM Usuarios WHERE Usuario = '" & xUsuario.Text.Trim & "'").Top
        If wVen IsNot Nothing Then
            xNombre.Text = wVen.GetText("NombreUsr")
        Else
            MsgError("Usuario no registrado")
            xUsuario.Clear()
            xNombre.Clear()
            xUsuario.Focus()
        End If
    End Sub

    Private Sub xUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xUsuario.KeyPress
        e.NextControl(cProceso)
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Dim wFiltros As String = ""

        If cLocal.Text <> "" Then wFiltros += " AND Local = '" & cLocal.SelectedValue.ToString & "'"
        If xUsuario.Text.Trim <> "" Then wFiltros += " AND Usuario = '" & xUsuario.Text.Trim & "'"
        If cProceso.Text <> "" Then wFiltros += " AND Proceso = '" & cProceso.Text & "'"
        If cEvento.Text <> "" Then wFiltros += " AND Evento = '" & cEvento.Text & "'"

        Dim wAud = SQL("SELECT * FROM Auditoria WHERE Fecha BETWEEN '" & dDesde.Value & "' AND '" & dHasta.Value & "' " & wFiltros)

        If wAud.Rows.Count > 0 Then
            Dim Lista = New List(Of AuditoriaReporte)
            Dim wListParametrosLocal = ParametroLocal()
            Dim wReporte As New ReporteAuditoria
            For Each wA As DataRow In wAud.Rows
                Lista.Add(New AuditoriaReporte With {.Evento = wA.GetText("Evento"),
                                                     .Fecha = wA.GetDate("Fecha"),
                                                     .Hora = wA.GetDate("Hora"),
                                                     .ID = wA.GetNum("ID"),
                                                     .Local = wA.GetNum("Local"),
                                                     .Lugar = wA.GetText("Lugar"),
                                                     .Proceos = wA.GetText("Proceso"),
                                                     .Usuario = wA.GetText("Usuario")})
            Next

            wReporte.Database.Tables("SisVen_AuditoriaReporte").SetDataSource(Lista)
            wReporte.Database.Tables("SisVen_ParametrosReporte").SetDataSource(wListParametrosLocal)
            VisorReportes.WinDeco1.TituloVentana = "Reporte de Auditoria"
            VisorReportes.MostrarReporte(wReporte)
            VisorReportes.Show()
            VisorReportes.BringToFront()
            Auditoria(Me.Text, A_IMPRESO, "", "")
        Else
            MsgError("No se encuentran datos para la selección indicada")
        End If

        Cursor = Cursors.Arrow
    End Sub
End Class