Imports CrystalDecisions.CrystalReports.Engine

Public Class ImprimirLiquidaciones
    Private Sub ImprimirLiquidaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub cEmrpesa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cEmpresa.SelectedIndexChanged
        If cEmpresa.Text <> "" Then
            cFuncionario.LoadItemsObj("USuarios", "Usuario", "NombreUsr", "WHERE Funcionario=1 and Empresa = " & cEmpresa.SelectedValue.ToString)
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click

        If cAño.Text = "" Then
            MsgError("Indique año")
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

        Cursor = Cursors.WaitCursor
        bImprimir.Enabled = False

        Dim wListaParametros = New List(Of ParametrosLocal)

        Dim wReporte As New ReportClass
        Dim wFuncionarioFiltro As String = ""
        If cFuncionario.Text <> "" Then
            wFuncionarioFiltro = " AND S.Usuario = '" & cFuncionario.SelectedValue.ToString & "'"
            wReporte = New Liquidacion_Sueldo
        Else
            wReporte = New ReporteLiquidacionesT
        End If
        Dim wLiquidaciones = SQL("SELECT S.año,S.Mes,S.TLiquido,S.Dias,S.PorcentajeSalud,S.Base,S.TGratificacion,S.TImponible,S.TColacion,S.TMovilizacion," &
                                 " S.PorcentajeSalud,Us.Vigencia, S.TCargas,S.Cargas,S.THaberes,S.TAFP,S.TSalud,S.Anticipos,S.Descuentos,S.TDescuentos,S.Ahorros," &
                                 " S.Seguros,S.Creditos,S.UF,S.NAFP,S.TBonos,S.TVariables, S.NSalud,S.PorcentajeAFP,S.AFC,S.TAguinaldos,S.TBonos2,Us.NombreUsr," &
                                 " Us.Rut,Us.Pactado,Cl.Nombre,Cl.Direccion,co.NombreComuna,ci.NombreComuna as NombreCiudad, S.ImpuestoUnico " &
                                 " FROM SUELDOS S" &
                                 " JOIN UFs UF ON S.UF = UF.UF" &
                                 " JOIN Usuarios Us ON S.Usuario = Us.Usuario" &
                                 " JOIN AFPs Af ON s.AFP = Af.AFP " &
                                 " JOIN Salud Sa ON S.Salud = Sa.Salud " &
                                 " JOIN Clientes Cl ON Us.Empresa = Cl.Cliente " &
                                 " JOIN Comunas Co ON Cl.Comuna = Co.Codigo  " &
                                 " JOIN Comunas Ci ON Cl.Ciudad = Ci.Codigo  " &
                                 " WHERE S.Año = " & cAño.Text & " AND S.Mes = " & cMes.SelectedValue.ToString & wFuncionarioFiltro)

        Dim wListaDatos = New List(Of LiquidacionReporte)

        For Each wL As DataRow In wLiquidaciones.Rows
            wListaDatos.Add(New LiquidacionReporte With {.Año = wL.GetText("Año"),
                                                   .Mes = wL.GetText("Mes"),
                                                   .AFC = wL.GetNum("AFC"),
                                                   .Ahorros = wL.GetNum("Ahorros"),
                                                   .Anticipados = wL.GetNum("Anticipos"),
                                                   .Base = wL.GetNum("Base"),
                                                   .Descuentos = wL.GetNum("Descuentos"),
                                                   .Dias = wL.GetText("Dias"),
                                                   .Direccion = wL.GetText("Direccion"),
                                                   .NAFP = wL.GetText("NAFP"),
                                                   .Nombre = wL.GetText("Nombre"),
                                                   .NombreCiudad = wL.GetText("NombreCiudad"),
                                                   .NombreComuna = wL.GetText("NombreComuna"),
                                                   .Nombreusr = wL.GetText("Nombreusr"),
                                                   .NSAlud = wL.GetText("NSAlud"),
                                                   .Pactado = wL.GetNum("Pactado"),
                                                   .PorcentajeAFP = wL.GetNum("PorcentajeAFP"),
                                                   .Rut = wL.GetText("Rut"),
                                                   .Seguros = wL.GetNum("Seguros"),
                                                   .TAFP = wL.GetNum("TAFP"),
                                                   .TAguinaldos = wL.GetNum("TAguinaldos"),
                                                   .TBonos2 = wL.GetNum("TBonos2"),
                                                   .TCargas = wL.GetNum("TCargas"),
                                                   .TColacion = wL.GetNum("TColacion"),
                                                   .TDescuentos = wL.GetNum("TDescuentos"),
                                                   .TGratificacion = wL.GetNum("TGratificacion"),
                                                   .THaberes = wL.GetNum("THaberes"),
                                                   .TImponible = wL.GetNum("TImponible"),
                                                   .TLiquido = wL.GetNum("TLiquido"),
                                                   .TMovilizacion = wL.GetNum("TMovilizacion"),
                                                   .TSalud = wL.GetNum("TSalud"),
                                                   .UF = wL.GetNum("UF"),
                                                   .Cargas = wL.GetNum("Cargas"),
                                                   .PorcentajeSalud = wL.GetNum("PorcentajeSalud"),
                                                   .TBonos = wL.GetNum("TBonos"),
                                                   .TVariables = wL.GetNum("TVariables"),
                                                   .Creditos = wL.GetNum("Creditos"),
                                                   .Vigencia = wL.GetDate("Vigencia"),
                                                   .Letras = Letras(wL.GetText("TLiquido")).ToUpper,
                                                   .ImpuestoUnico = wL.GetNum("ImpuestoUnico")})
        Next

        Dim wParamtrosLocal = ParametroLocal()

        wParamtrosLocal.First().Periodo = cMes.Text.ToLower & " de " & cAño.Text

        wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wParamtrosLocal)
        wReporte.Database.Tables("MarketONE_LiquidacionReporte").SetDataSource(wListaDatos)
        wReporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Directorio_PDF & "Sueldo " & cFuncionario.Text.Trim & " " & cMes.Text.Trim & " " & cAño.Text.Trim & ".pdf")
        VisorReportes.MostrarReporte(wReporte)
        VisorReportes.Show()
        VisorReportes.BringToFront()

        Cursor = Cursors.Arrow
        bImprimir.Enabled = True

    End Sub
End Class