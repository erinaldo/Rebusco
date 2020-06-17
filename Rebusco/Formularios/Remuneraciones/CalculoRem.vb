Public Class CalculoRem
    Const T_EMPLEADO = 0
    Const T_LIQUIDACION = 1

    Sub Titulos()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 2

        xTabla.Cols(T_EMPLEADO).Caption = "Empleado"
        xTabla.Cols(T_LIQUIDACION).Caption = "Liquidación"

        xTabla.Cols(T_EMPLEADO).Width = 258
        xTabla.Cols(T_LIQUIDACION).Width = 80
    End Sub

    Private Sub CalculoRem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wNumeroMes As Integer = 1
        cAño.AñosMes("A")
        cMes.AñosMes("M")

        If Now.Month = 1 Then
            cMes.SelectedValue = Now.AddMonths(-1).Month.ToString
            cAño.Text = Val(Year(Now) - 1).ToString
        Else
            cMes.SelectedValue = Now.AddMonths(-1).Month.ToString
            cAño.Text = Val(Year(Now)).ToString
        End If

        Auditoria(Text, A_INGRESADO, "", "")
    End Sub

    Private Sub bCalcular_Click(sender As Object, e As EventArgs) Handles bCalcular.Click
        Dim xAño As Integer, xMes As Integer

        If Not Pregunta("¿Calcular Liquidaciones de Sueldo?" & vbCrLf & "Año: " & cAño.Text & vbCrLf & "Mes: " & cMes.Text) Then
            Exit Sub
        End If

        xAño = CInt(cAño.SelectedValue.ToString)
        xMes = (cMes.SelectedIndex)

        xMensaje.Text = ""
        bCalcular.Enabled = False
        Auditoria(Me.Name, "Cálculo de Remuneración", xAño.ToString, xMes.ToString)
        Procesar_Remuneraciones(xAño, xMes)
        bCalcular.Enabled = True
    End Sub

    Sub Procesar_Remuneraciones(xAño As Integer, xMes As Integer)
        Dim wFechaInicio As DateTime
        Dim wFechaFinal As DateTime
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim Dias_Trabajados As Integer
        Dim TBase As Double, TGratificacion As Double, TAguinaldos As Double
        Dim TVariables, TCesantia As Double, TBonos As Double, TBonos2 As Double, xUF As Double
        Dim TAnticipos As Double, TCreditos As Double, TSeguros As Double, TDescuentos As Double, TAhorros As Double ', TCargas As Double
        Dim TColacion As Double, TMovilizacion As Double, Total_General As Double

        'Verificar que se haya ingresado la UF/UTM
        Dim wUFS = SQL("Select * from UFs where Año = " & xAño.ToString & " and Mes = " & xMes.ToString).Top
        If wUFS Is Nothing Then
            MsgError("No se pueden procesar remuneraciones por no existir el ingreso de la UF para ese mes.")
            Exit Sub
        End If

        Dim UFGlobal As Double = wUFS.GetNum("UF")
        Dim UTMGlobal As Double = wUFS.GetNum("UTM")

        wFechaInicio = IniFinFecha(1, CDate("01/" & xMes.ToString & "/" & xAño.ToString))
        wFechaFinal = IniFinFecha(2, CDate("01/" & xMes.ToString & "/" & xAño.ToString))

        'Eliminar Remuneraciones no canceladas en el periodo
        SQL("Delete Sueldos where Estado = 0 and Año = " & xAño.ToString & " and Mes = " & xMes.ToString)

        Total_General = 0
        Dim wUsr = SQL("Select * from Usuarios where Funcionario = 1 Order by Usuario")
        Titulos()

        For Each wU As DataRow In wUsr.Rows
            'Saltarse el Funcionario que ya se le cancelo ese mes su liquidacion
            Dim wSue = SQL("Select Usuario from Sueldos where Estado=1 and Año = " & xAño.ToString & " and Mes = " & xMes.ToString & " and Usuario = '" & wU.GetText("Usuario") & "'")
            If wSue IsNot Nothing Then
                Dias_Trabajados = 30
                TVariables = 0 : TBonos = 0 : TBonos2 = 0 : TAguinaldos = 0 : TMovilizacion = 0 : TColacion = 0
                TAnticipos = 0 : TDescuentos = 0 : TCreditos = 0 : TSeguros = 0 : TAhorros = 0 : TCesantia = 0 'se utilizará cargas desde el usuario: TCargas = 0
                'Recorrer Eventos del Mes
                Dim wRem = SQL("Select * from Sueldos_Detalles where Fecha >= '" & wFechaInicio & "' and Fecha <= '" & wFechaFinal & "' and Estado = 0 and Usuario = '" & wU.GetText("Usuario") & "'")
                If wRem.Rows.Count > 0 Then
                    For Each wR As DataRow In wRem.Rows
                        DoEvents()

                        If wR.GetNum("EventoRem") = 0 Then 'Sin Evento
                            'Procedimiento es una Observacion
                        End If
                        If wR.GetNum("EventoRem") = 1 Then TVariables = TVariables + wR.GetNum("Monto")   'Orden de Transporte (Variable)
                        If wR.GetNum("EventoRem") = 2 Then TBonos = TBonos + wR.GetNum("Monto") 'Bono
                        If wR.GetNum("EventoRem") = 3 Then TBonos2 = TBonos2 + wR.GetNum("Monto") 'Ajuste Sencillo
                        If wR.GetNum("EventoRem") = 4 Then TAnticipos = TAnticipos + wR.GetNum("Monto") 'Anticipo 1
                        If wR.GetNum("EventoRem") = 5 Then TAnticipos = TAnticipos + wR.GetNum("Monto") 'Anticipo 2
                        If wR.GetNum("EventoRem") = 6 Then TAnticipos = TAnticipos + wR.GetNum("Monto") 'Anticipo 3
                        If wR.GetNum("EventoRem") = 7 Then TDescuentos = TDescuentos + wR.GetNum("Monto") 'Descuento 1
                        If wR.GetNum("EventoRem") = 8 Then TDescuentos = TDescuentos + wR.GetNum("Monto") 'Descuento 2
                        If wR.GetNum("EventoRem") = 9 Then TDescuentos = TDescuentos + wR.GetNum("Monto") 'Descuento 3
                        If wR.GetNum("EventoRem") = 10 Then TCreditos = TCreditos + wR.GetNum("Monto") 'Prestamo 1
                        If wR.GetNum("EventoRem") = 11 Then TCreditos = TCreditos + wR.GetNum("Monto") 'Prestamo 2
                        If wR.GetNum("EventoRem") = 12 Then TCreditos = TCreditos + wR.GetNum("Monto") 'Prestamo 3
                        If wR.GetNum("EventoRem") = 13 Then TAnticipos = TAnticipos + wR.GetNum("Monto") 'Otros Anticipos
                        If wR.GetNum("EventoRem") = 14 Then TDescuentos = TDescuentos + wR.GetNum("Monto") 'Otros Descuentos
                        If wR.GetNum("EventoRem") = 15 Then TCreditos = TCreditos + wR.GetNum("Monto") 'Otros Prestamos
                        If wR.GetNum("EventoRem") = 16 Then TBonos = TBonos + wR.GetNum("Monto") 'Otros Bonos
                        If wR.GetNum("EventoRem") = 17 Then TAhorros = TAhorros + wR.GetNum("Monto") 'Ahorro Voluntario
                        If wR.GetNum("EventoRem") = 18 Then TSeguros = TSeguros + wR.GetNum("Monto") 'Seguro de Vida
                        If wR.GetNum("EventoRem") = 19 Then TCesantia = TCesantia + wR.GetNum("Monto") 'Seguro de Cesantia
                        If wR.GetNum("EventoRem") = 20 Then Dias_Trabajados = Dias_Trabajados - wR.GetInt("Monto") 'Descontar Dia
                        If wR.GetNum("EventoRem") = 21 Then TAguinaldos = TAguinaldos + wR.GetNum("Monto") 'Aguinaldo
                        If wR.GetNum("EventoRem") = 23 Then TVariables = TVariables + wR.GetNum("Monto") 'Aguinaldo Especial
                        If wR.GetNum("EventoRem") = 25 Then TMovilizacion = TMovilizacion + wR.GetNum("Monto") 'Bono de Movilizacion
                        If wR.GetNum("EventoRem") = 26 Then TColacion = TColacion + wR.GetNum("Monto") 'Bono de Colacion
                    Next
                End If

                ' Crear Sueldo
                If Dias_Trabajados >= 0 Then
                    Dim wSueldos As New T_Sueldos

                    wSueldos.Año = xAño
                    wSueldos.Mes = xMes
                    wSueldos.Usuario = wU.GetText("Usuario")

                    wSueldos.Estado = "0"
                    If Dias_Trabajados > 0 Then
                        wSueldos.Base = CInt(Math.Round(wU.GetNum("Base") / 30 * Dias_Trabajados, 0))
                    Else
                        wSueldos.Base = 0
                    End If

                    wSueldos.Bruto = wU.GetInt("Bruto")
                    wSueldos.Dias = Dias_Trabajados
                    TBase = ((wU.GetNum("Base") / 30) * Dias_Trabajados)
                    TGratificacion = Math.Round((TBase * wU.GetNum("Gratificacion") / 100))
                    wSueldos.TImponible = CInt(TBase + TGratificacion + TBonos + TBonos2 + TAguinaldos)
                    wSueldos.Gratificacion = wU.GetInt("Gratificacion")
                    wSueldos.TGratificacion = CInt(TGratificacion)
                    wSueldos.Colacion = wU.GetInt("Colacion")
                    wSueldos.TColacion = CInt((wU.GetInt("Colacion") * Dias_Trabajados) + TColacion)

                    wSueldos.Movilizacion = wU.GetInt("Movilizacion")
                    wSueldos.TMovilizacion = CInt(wU.GetInt("Movilizacion") * Dias_Trabajados) + CInt(TMovilizacion)

                    wSueldos.Cargas = wU.GetInt("Cargas")
                    wSueldos.TCargas = wU.GetInt("MontoCargas")
                    wSueldos.TVariables = CInt(TVariables)
                    wSueldos.TBonos = CInt(TBonos)
                    wSueldos.TBonos2 = CInt(TBonos2)
                    wSueldos.TAguinaldos = CInt(TAguinaldos)

                    wSueldos.AFP = wU.GetInt("AFP")
                    Dim wAFP = SQL("SELECT * FROM AFPs WHERE AFP = " & wU.GetInt("AFP")).Top
                    If wAFP IsNot Nothing Then
                        wSueldos.PorcentajeAFP = wAFP.GetNum("PorcentajeAFP")
                        wSueldos.NAFP = wAFP.GetText("NombreAFP")
                    Else
                        wSueldos.PorcentajeAFP = 0
                    End If

                    wSueldos.TAFP = CInt(Math.Round(wSueldos.TImponible * (wSueldos.PorcentajeAFP / 100)))
                    wSueldos.Salud = wU.GetInt("Salud")

                    Dim wUF = SQL("Select * from UFs where Año = " & xAño.ToString & " And Mes = " & xMes.ToString).Top
                    If wUF IsNot Nothing Then wSueldos.UF = wUF.GetNum("UF")

                    wSueldos.SIS = wU.GetInt("SIS")

                    If wU.GetNum("Pactado") > 0 Then
                        xUF = 0
                        wUF = SQL("Select * from UFs where Año = " & xAño.ToString & " And Mes = " & xMes.ToString).Top
                        If wUF IsNot Nothing Then
                            xUF = wUF.GetNum("UF")
                        End If
                        wSueldos.PorcentajeSalud = wU.GetNum("Pactado")

                        Dim wSal = SQL("SELECT Salud FROM Salud WHERE Salud = " & wU.GetInt("Salud")).Top
                        If wSal IsNot Nothing Then wSueldos.NSalud = wSal.GetText("NombreSalud")

                        wSueldos.TSalud = CInt(wSueldos.PorcentajeSalud * xUF)
                    Else

                        Dim wSal = SQL("SELECT * FROM Salud WHERE Salud = " & wU.GetInt("Salud")).Top
                        If wSal IsNot Nothing Then
                            wSueldos.NSalud = wSal.GetText("NombreSalud")
                            wSueldos.PorcentajeSalud = wSal.GetNum("PorcentajeSalud")
                            wSueldos.NSalud = wSal.GetText("NombreSalud")
                        Else
                            wSueldos.PorcentajeSalud = 0
                        End If
                        wSueldos.TSalud = CInt(Math.Round(wSueldos.TImponible * (wSueldos.PorcentajeSalud / 100)))
                    End If

                    wSueldos.Anticipos = CInt(TAnticipos)
                    wSueldos.Descuentos = CInt(TDescuentos)
                    wSueldos.Creditos = CInt(TCreditos)
                    wSueldos.Seguros = CInt(TSeguros)
                    If TCesantia > 0 Then
                        wSueldos.AFC = CInt(TCesantia)
                    Else

                        If wU.GetDate("vigencia") = CDate("01/01/3000") Then
                            wSueldos.AFC = CInt(Math.Round(wSueldos.TImponible * 0.006))
                        Else
                            wSueldos.AFC = 0
                        End If
                    End If

                    wSueldos.Ahorros = CInt(TAhorros)
                    wSueldos.ImpuestoUnico = CInt(CalculoImpuestoUnico(wSueldos.TImponible, wSueldos.TAFP, wSueldos.TSalud, wSueldos.AFC, UTMGlobal))
                    wSueldos.TDescuentos = CInt(wSueldos.TAFP + wSueldos.TSalud + TAnticipos + TCreditos + TDescuentos + TSeguros + TAhorros + wSueldos.AFC + wSueldos.ImpuestoUnico)

                    'En Wikets Software se regala la movilizacion para compensar el valor del impuesto unico
                    If G_IDCLIENTE = Clientes.Wikets Then
                        wSueldos.Movilizacion = wSueldos.ImpuestoUnico + wSueldos.Movilizacion
                        wSueldos.TMovilizacion = wSueldos.ImpuestoUnico + wSueldos.TMovilizacion
                    Else
                        'Para otros clientes se calcula la movilizacion
                        wSueldos.Movilizacion = wU.GetInt("Movilizacion")
                        wSueldos.TMovilizacion = CInt((wU.GetNum("Movilizacion") * Dias_Trabajados) + TMovilizacion)
                    End If
                    wSueldos.THaberes = CInt(wSueldos.TImponible + wSueldos.TColacion + wSueldos.TMovilizacion + wSueldos.TCargas + TVariables)

                    wSueldos.TLiquido = wSueldos.THaberes - wSueldos.TDescuentos

                    wSueldos.Cancelado = False
                    wSueldos.ModoPago = ""
                    wSueldos.FechaPago = Now
                    wSueldos.UsuarioPago = UsuarioActual
                    wSueldos.Empresa = wU.GetInt("Empresa")
                    DC.T_Sueldos.InsertOnSubmit(wSueldos)

                    Total_General += wSueldos.TLiquido
                    xTabla.AddItem("")
                    xTabla.SetData(xTabla.Rows.Count - 1, T_EMPLEADO, wU.GetText("NombreUsr"))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_LIQUIDACION, Format(wSueldos.TLiquido, "###,###,###"))
                    xMensaje.Text = xMensaje.Text & Trim(wU.GetText("NombreUsr")) & " $" & Format(wSueldos.TLiquido, "###,###,###") & vbCrLf
                Else
                    MsgError("Error en días trabajados, la cantidad es negativa (Solucionar y recalcular Remuneraciones). Usuario:" & wU.GetText("usuario"))
                    Exit Sub
                End If

            End If
        Next
        DC.SubmitChanges()
        xTabla.AddItem("")
        xTabla.AddItem("")
        xTabla.SetData(xTabla.Rows.Count - 1, T_EMPLEADO, "TOTAL SUELDOS")
        xTabla.SetData(xTabla.Rows.Count - 1, T_LIQUIDACION, Format(Total_General, "###,###,###"))
        xTabla.FondoCelda(xTabla.Rows.Count - 1, C_AMARILLO_CELDA)

        xMensaje.Text = xMensaje.Text & "--------------------------------------------------------" & vbCrLf
        xMensaje.Text = xMensaje.Text & "Total Sueldos: " & " $" & Format(Total_General, "###,###,###") & vbCrLf
    End Sub


    Function CalculoImpuestoUnico(wTotalImponible As Double, wAFP As Double, wSalud As Double, wSeguros As Double, wUTMGlobal As Double) As Double
        Dim ValorImpuestoUnico As Double
        Dim FactorImpuestoUnico As Double
        Dim ValorDescuentoImpuestoUnico As Double
        Dim Valor_a_Usar As Double
        Dim Valor_Tope As Double

        Valor_a_Usar = wTotalImponible - wAFP - wSalud

        Dim TIU = SQL("SELECT * FROM ImpuestoUnico ORDER By Tope Asc")
        For Each wT As DataRow In TIU.Rows
            Valor_Tope = wT.GetNum("Tope") * wUTMGlobal
            If Valor_a_Usar <= Valor_Tope Then
                FactorImpuestoUnico = wT.GetNum("Factor")
                ValorDescuentoImpuestoUnico = wT.GetNum("Rebaja") * wUTMGlobal
                Exit For
            End If
        Next

        'Si no encontro ningun rango, es porque supera el tope maximo, para ello se calcula con el valor maximo que haya en la tabla
        If FactorImpuestoUnico = 0 Then
            Dim wTIU = SQL("SELECT * FROM ImpuestoUnico ORDER BY Tope Desc").Top

            Valor_Tope = wTIU.GetNum("Tope") * wUTMGlobal
            If Valor_a_Usar > Valor_Tope Then
                FactorImpuestoUnico = wTIU.GetNum("Factor")
                ValorDescuentoImpuestoUnico = wTIU.GetNum("Rebaja") * wUTMGlobal
            End If
        End If

        ValorImpuestoUnico = ((wTotalImponible - wAFP - wSalud - 0) * FactorImpuestoUnico) - ValorDescuentoImpuestoUnico
        If ValorImpuestoUnico < 0 Then
            ValorImpuestoUnico = 0
        End If

        Return ValorImpuestoUnico
    End Function

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub
End Class