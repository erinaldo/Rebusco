Public Class ImprimirPlanillaRem
    Private Sub ImprimirPlanillaRem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cAño.AñosMes("A")
        cMes.AñosMes("M")

        If Now.Month = 1 Then
            cMes.SelectedValue = Now.AddMonths(-1).Month.ToString
            cAño.Text = Val(Year(Now) - 1).ToString
        Else
            cMes.SelectedValue = Now.AddMonths(-1).Month.ToString
            cAño.Text = Val(Year(Now)).ToString
        End If

        cEmpresa.LoadItemsObj("Locales", "Local", "NombreLocal", " WHERE Local IN (SELECT DISTINCT Local FROM usuarios WHERE funcionario=1)")
        If cEmpresa.Items.Count = 2 Then
            cEmpresa.SelectedIndex = 1
        End If
        Auditoria(Text, A_INGRESADO, "", "")
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        cAño.Focus()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If cAño.Text = "" Then
            MsgError("Indique Año")
            cAño.Focus()
            Exit Sub
        End If
        If cMes.Text = "" Then
            MsgError("Indique Mes")
            cMes.Focus()
            Exit Sub
        End If
        If cEmpresa.Text = "" Then
            MsgError("Indique Empresa")
            cEmpresa.Focus()
            Exit Sub
        End If


        Dim wRem = SQL("SELECT S.*, M.ModoPago,M.DescModoPago,U.NombreUsr" &
                   " FROM Sueldos S JOIN ModoPagos M ON S.ModoPago = M.ModoPago" &
                   " JOIN Usuarios U ON S.Usuario = U.Usuario" &
                   " WHERE S.Año = " & cAño.Text.Trim & " And S.Mes = " & cMes.SelectedValue.ToString & " And" &
                   " S.Empresa = " & cEmpresa.SelectedValue.ToString)


        Dim Lista = New List(Of LiquidacionesReporte)
        For Each wR As DataRow In wRem.Rows
            Lista.Add(New LiquidacionesReporte With {.AFC = wR.GetNum("AFC"),
                                                     .Ahorro = wR.GetNum("Ahorros"),
                                                     .Anticipos = wR.GetNum("Anticipos"),
                                                     .Base = wR.GetNum("Base"),
                                                     .Creditos = wR.GetNum("Creditos"),
                                                     .DescModoPago = wR.GetText("DescModoPago"),
                                                     .Descuentos = wR.GetNum("Descuentos"),
                                                     .Funcionario = wR.GetText("NombreUsr"),
                                                     .ModoPago = wR.GetText("ModoPago"),
                                                     .Seguros = wR.GetNum("Seguros"),
                                                     .TAFP = wR.GetNum("TAFP"),
                                                     .TAguinaldos = wR.GetNum("TAguinaldos"),
                                                     .TBonos = wR.GetNum("TBonos"),
                                                     .TCargas = wR.GetNum("TCargas"),
                                                     .TColacion = wR.GetNum("TColacion"),
                                                     .TDescuentos = wR.GetNum("TDescuentos"),
                                                     .TGratificacion = wR.GetNum("TGratificacion"),
                                                     .THaberes = wR.GetNum("THAberes"),
                                                     .TImponible = wR.GetNum("TImponible"),
                                                     .TLiquido = wR.GetNum("TLiquido"),
                                                     .TMovilizacion = wR.GetNum("TMovilizacion"),
                                                     .TSalud = wR.GetNum("TSalud"),
                                                     .TVariables = wR.GetNum("TVariables"),
                                                     .Dia = wR.GetNum("Dias")})

        Next

        If Lista.Count > 0 Then
            Dim ListLocal = ParametroLocal()
            If ListLocal IsNot Nothing Then ListLocal.First().Periodo = cMes.Text.ToLower & " de " & cAño.Text
            Dim wReporte As New ReporteLiquidaciones
            wReporte.Database.Tables("MarketONE_LiquidacionesReporte").SetDataSource(Lista)
            wReporte.Database.Tables("MarketONE_LocalesParametro").SetDataSource(ListLocal)
            VisorReportes.MostrarReporte(wReporte)
            VisorReportes.Show()
            VisorReportes.BringToFront()
        Else
            Mensaje("No se encuentran datos para la selección indicada")
            Close()
        End If
        Auditoria(Text, A_IMPRESO, "", "")
    End Sub
End Class