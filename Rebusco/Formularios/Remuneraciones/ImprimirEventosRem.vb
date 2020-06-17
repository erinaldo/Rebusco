Public Class ImprimirEventosRem
    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        dDesde.Value = IniFinFecha(1, DateAdd(DateInterval.Month, -1, Now))
        dHasta.Value = IniFinFecha(2, DateAdd(DateInterval.Month, -1, Now))
    End Sub

    Private Sub ImprimirEventosRem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cFuncionario.LoadItemsObj("Usuarios", "Usuario", "Nombreusr", " WHERE Funcionario = 1 Order by NombreUsr")
        cEvento.LoadItemsObj("EventosRem", "EventoRem", "DescEventoRem", " ORDER BY CalculoRem,DescEventoRem")

        dDesde.Value = IniFinFecha(1, DateAdd(DateInterval.Month, -1, Now))
        dHasta.Value = IniFinFecha(2, DateAdd(DateInterval.Month, -1, Now))
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If dDesde.Value > dHasta.Value Then
            MsgError("La fecha inicio no puede ser mayor a la final")
            Exit Sub
        End If
        If dHasta.Value < dDesde.Value Then
            MsgError("La fecha final no puede ser menor a la de inicio")
            Exit Sub
        End If

        Dim wfiltro = ""

        If cFuncionario.Text <> "" Then wfiltro = " AND Us.Usuario = '" & cFuncionario.SelectedValue.ToString & "'"
        If cEvento.Text <> "" Then wfiltro += " AND ER.EventoRem = '" & cEvento.SelectedValue.ToString & "'"

        Dim wEventos = SQL("Select ER.CalculoRem,SD.ID,SD.Fecha,SD.Estado, Us.NombreUsr,ER.DescEventoRem,SD.UsuarioRem,SD.Monto,SD.Glosa" &
        " FROM EventosRem ER" &
        " Join Sueldos_Detalles SD ON ER.EventoRem = SD.EventoRem " &
        " Join Usuarios Us ON SD.Usuario = Us.Usuario" &
        " Join Usuarios Ur ON SD.UsuarioRem = Ur.Usuario" &
        " WHERE Fecha BETWEEN '" & dDesde.Value & "' AND '" & dHasta.Value & "' " & wfiltro)

        Dim wListaRem = New List(Of EventosRemListado)
        For Each wR As DataRow In wEventos.Rows
            wListaRem.Add(New EventosRemListado With {.CalculoRem = wR.GetText("CalculoRem"),
                                                  .DescEvento = wR.GetText("DescEventoRem"),
                                                  .Estado = wR.GetNum("Estado"),
                                                  .Fecha = wR.GetDate("Fecha"),
                                                  .Funcionario = wR.GetText("NombreUsr"),
                                                  .Glosa = wR.GetText("Glosa"),
                                                  .ID = wR.GetText("ID"),
                                                  .Usuario = wR.GetText("UsuarioRem"),
                                                  .Monto = wR.GetNum("Monto")})
        Next

        If wListaRem.Any Then
            Dim wReporte As New EventosRem
            Dim wParametrosLocal = ParametroLocal()
            wReporte.Database.Tables("MarketONE_EventosRemListado").SetDataSource(wListaRem)
            wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wParametrosLocal)
            VisorReportes.MostrarReporte(wReporte)
            VisorReportes.WinDeco1.TituloVentana = "Listado Eventos de Remuneración"
            VisorReportes.Show()
        Else
            MsgError("No se encuentras registros para los filtros indicados")
        End If


    End Sub
End Class