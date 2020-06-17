Imports System.Collections
Imports System.Collections.Generic

Public Class VentasCaja
    Const T_LOCAL = 0
    Const T_POS = 1
    Const T_TIPODOC = 2
    Const T_FPAGOS = 3
    Const T_TOTAL = 4
    Sub Titulos()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 5

        xTabla.Cols(T_LOCAL).Width = 150
        xTabla.Cols(T_TIPODOC).Width = 0
        xTabla.Cols(T_POS).Width = 100
        xTabla.Cols(T_FPAGOS).Width = 250
        xTabla.Cols(T_TOTAL).Width = 140

        xTabla.Cols(T_LOCAL).Caption = "Local"
        xTabla.Cols(T_POS).Caption = "POS"
        xTabla.Cols(T_TIPODOC).Caption = "Tipo Doc."
        xTabla.Cols(T_FPAGOS).Caption = "Forma Pago"
        xTabla.Cols(T_TOTAL).Caption = "Total"

    End Sub
    Private Sub CuadraturaCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cDesde.Value = IniFinFecha(1, Date.Now)
        cHasta.Value = IniFinFecha(2, Date.Now)
        MostrarCuadratura(False)
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        cLocal.SelectedIndex = 0
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        cDesde.Value = IniFinFecha(1, Date.Now)
        cHasta.Value = IniFinFecha(2, Date.Now)
        cLocal.SelectedIndex = 0
        xPOS.Clear()
        cLocal.Focus()
    End Sub
    Public Sub MostrarCuadratura(ByVal wMostrar As Boolean)
        Invalidate()
        StartPosition = FormStartPosition.CenterScreen
        DoEvents()
    End Sub
    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        MostrarCuadratura(True)
        BotonesActivados(False)
        Me.Cursor = Cursors.WaitCursor
        If oDoc.Checked Then
            Calcular_Cuadratura_DOC()
        Else
            Calcular_Cuadratura_CAJA()
        End If
        Me.Cursor = Cursors.Default
        BotonesActivados(True)
    End Sub
    Sub BotonesActivados(ByVal wEstado As Boolean)
        bSalir.Enabled = wEstado
        bLimpiar.Enabled = wEstado
        bConsultar.Enabled = wEstado
        bImprimir.Enabled = wEstado
    End Sub

    Sub Calcular_Cuadratura_DOC()

        Titulos()
        Dim wNumPOS = SQL("SELECT DISTINCT POS FROM DocumentosG WHERE POS IS NOT NULL")
        Dim wDesde = cDesde.Value.Date & " 00:00:00"
        Dim wHasta = cHasta.Value.Date & " 23:59:00"
        Dim wFiltro = " G.Fecha Between '" & wDesde & "' And '" & wHasta & "' "

        For Each wRow As DataRow In wNumPOS.Rows
            Dim wSum = SQL("Select Sum(G.Total) as Caja,G.FPago,FP.DescFPago ,G.TipoDoc,TD.DescTipoDoc,G.Local," &
                       " LO.NombreLocal,G.POS" &
                       " FROM DocumentosG G" &
                       " JOIN FPagos FP ON G.FPago = FP.FPago" &
                       " JOIN TipoDoc TD ON G.TipoDoc = TD.TipoDoc" &
                       " JOIN Locales LO ON G.Local = LO.Local" &
                       " where G.Local = 1  And " & wFiltro &
                       " And G.TipoDoc in ('FV','NC','ND','FE','BV','BE','BM') AND G.POS = " & wRow.GetText("POS") & "" &
                       " Group By G.FPago,G.TipoDoc,FP.DescFPago,TD.DescTipoDoc, LO.NombreLocal ,G.Local,G.POS" &
                       " Order by G.POS,G.FPago,G.TipoDoc")

            If wSum.Rows.Count > 0 Then
                Dim wTipoDocI = {"FV", "ND", "FE", "BV", "BE", "BM"}
                Dim wTipoDocE = {"NC"}
                Dim wNombreLocal = wSum.Top.GetText("NombreLocal")
                Dim wCheque = 0
                Dim wDeposito = 0
                Dim wEfectivo = 0
                Dim wTarjetaBancaria = 0
                Dim wCheque30 = 0
                Dim wVariosPago = 0
                Dim wTransferencia = 0
                Dim wCredito = 0
                Dim wRedCompra = 0

                For Each wRowS As DataRow In wSum.Rows

                    If wRowS.GetText("FPago") = "B" And wTipoDocI.Contains(wRowS.GetText("TipoDoc")) Then
                        wTransferencia += CInt(wRowS.GetText("Caja"))
                    ElseIf wRowS.GetText("FPago") = "B" And wTipoDocE.Contains(wRowS.GetText("TipoDoc")) Then
                        wTransferencia -= CInt(wRowS.GetText("Caja"))
                    End If

                    If wRowS.GetText("FPago") = "C" And wTipoDocI.Contains(wRowS.GetText("TipoDoc")) Then
                        wCheque += CInt(wRowS.GetText("Caja"))
                    ElseIf wRowS.GetText("FPago") = "C" And wTipoDocE.Contains(wRowS.GetText("TipoDoc")) Then
                        wCheque -= CInt(wRowS.GetText("Caja"))
                    End If

                    If wRowS.GetText("FPago") = "D" And wTipoDocI.Contains(wRowS.GetText("TipoDoc")) Then
                        wDeposito += CInt(wRowS.GetText("Caja"))
                    ElseIf wRowS.GetText("FPago") = "D" And wTipoDocE.Contains(wRowS.GetText("TipoDoc")) Then
                        wDeposito -= CInt(wRowS.GetText("Caja"))
                    End If

                    If wRowS.GetText("FPago") = "E" And wTipoDocI.Contains(wRowS.GetText("TipoDoc")) Then
                        wEfectivo += CInt(wRowS.GetText("Caja"))
                    ElseIf wRowS.GetText("FPago") = "E" And wTipoDocE.Contains(wRowS.GetText("TipoDoc")) Then
                        wEfectivo -= CInt(wRowS.GetText("Caja"))
                    End If

                    If wRowS.GetText("FPago") = "R" And wTipoDocI.Contains(wRowS.GetText("TipoDoc")) Then
                        wRedCompra += CInt(wRowS.GetText("Caja"))
                    ElseIf wRowS.GetText("FPago") = "R" And wTipoDocE.Contains(wRowS.GetText("TipoDoc")) Then
                        wRedCompra -= CInt(wRowS.GetText("Caja"))
                    End If

                    If wRowS.GetText("FPago") = "T" And wTipoDocI.Contains(wRowS.GetText("TipoDoc")) Then
                        wTarjetaBancaria += CInt(wRowS.GetText("Caja"))
                    ElseIf wRowS.GetText("FPago") = "T" And wTipoDocE.Contains(wRowS.GetText("TipoDoc")) Then
                        wTarjetaBancaria -= CInt(wRowS.GetText("Caja"))
                    End If

                    If wRowS.GetText("FPago") = "V" And wTipoDocI.Contains(wRowS.GetText("TipoDoc")) Then
                        wVariosPago += CInt(wRowS.GetText("Caja"))
                    ElseIf wRowS.GetText("FPago") = "V" And wTipoDocE.Contains(wRowS.GetText("TipoDoc")) Then
                        wVariosPago -= CInt(wRowS.GetText("Caja"))
                    End If

                    If wRowS.GetText("FPago") = "X" And wTipoDocI.Contains(wRowS.GetText("TipoDoc")) Then
                        wCredito += CInt(wRowS.GetText("Caja"))
                    ElseIf wRowS.GetText("FPago") = "X" And wTipoDocE.Contains(wRowS.GetText("TipoDoc")) Then
                        wCredito -= CInt(wRowS.GetText("Caja"))
                    End If

                    If wRowS.GetText("FPago") = "3" And wTipoDocI.Contains(wRowS.GetText("TipoDoc")) Then
                        wCheque30 += CInt(wRowS.GetText("Caja"))
                    ElseIf wRowS.GetText("FPago") = "3" And wTipoDocE.Contains(wRowS.GetText("TipoDoc")) Then
                        wCheque30 -= CInt(wRowS.GetText("Caja"))
                    End If
                Next

                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, wNombreLocal)
                xTabla.SetData(xTabla.Rows.Count - 1, T_POS, wNumPOS.Top.GetText("POS"))

                xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGOS, "Cheque 30 días")
                xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, IIf(wCheque30 = 0, 0, Format(wCheque30, "###,###,###")))

                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGOS, "Transferencia")
                xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, IIf(wTransferencia = 0, 0, Format(wTransferencia, "###,###,###")))

                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGOS, "Cheque")
                xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, IIf(wCheque = 0, 0, Format(wCheque, "###,###,###")))

                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGOS, "Depósito")
                xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, IIf(wDeposito = 0, 0, Format(wDeposito, "###,###,###")))

                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGOS, "Efectivo")
                xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, IIf(wEfectivo = 0, 0, Format(wEfectivo, "###,###,###")))

                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGOS, "RedCompra")
                xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, IIf(wRedCompra = 0, 0, Format(wRedCompra, "###,###,###")))

                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGOS, "Tarjeta Bancaria")
                xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, IIf(wTarjetaBancaria = 0, 0, Format(wTarjetaBancaria, "###,###,###")))

                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGOS, "Credito")
                xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, IIf(wCredito = 0, 0, Format(wCredito, "###,###,###")))

                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGOS, "Varios Pagos")
                xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, IIf(wVariosPago = 0, 0, Format(wVariosPago, "###,###,###")))

                Dim wTotalPagos = Format(wRedCompra + wCredito + wCheque30 + wTransferencia + wCheque + wDeposito + wEfectivo + wTarjetaBancaria + wVariosPago, "###,###,###")
                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGOS, "Total")
                xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, wTotalPagos)
                xTabla.FondoCelda(xTabla.Rows.Count - 1, C_AMARILLO_CELDA)
            End If
        Next


        'Dim wNumeroCaja = 0
        'Loc = SQL("Select Local,NombreLocal from Locales " & wFiltro & " Order by Local")

        'xCuadratura.Clear()

        'While Not Loc.EOF

        '    Dim wLocales As Double = Loc.Fields("Local").Value
        '    xCuadratura.Text = xCuadratura.Text & "LOCAL: " & Trim(Loc.Fields("NombreLocal").Value) & vbCrLf & vbCrLf
        '    DocG = SQL("SELECT Distinct Top 1 POS FROM DocumentosG WHERE Local=" & wLocales & " Order By POS Desc")
        '    If DocG.EOF Then
        '        wNumeroPos = 0
        '    Else
        '        wNumeroPos = DocG.Fields("POS").Value
        '    End If
        '    wTotalVendido = 0
        '    Titulos()
        '    For wNumeroCaja = 0 To wNumeroPos
        '        If xPOS.Text <> "" And Val(xPOS.Text) > 0 Then
        '            wNumeroCaja = Val(xPOS.Text)
        '        End If

        '        Caj = SQL("Select Sum(G.Total) as TCaja,G.FPago,FP.DescFPago ,G.TipoDoc,TD.DescTipoDoc,G.Local, LO.NombreLocal,G.POS " &
        '                  " from DocumentosG G" &
        '                  " JOIN FPagos FP ON G.FPago = FP.FPago" &
        '                  " JOIN TipoDoc TD ON G.TipoDoc = TD.TipoDoc" &
        '                  " JOIN Locales LO ON G.Local = LO.Local" &
        '                  " where G.Local = " & wLocales & " " &
        '                  " And G.Fecha Between '" & cDesde.Text & " 00:00:00 " & "' " &
        '                  " And '" & cHasta.Text & " 23:59:00 " & "' " &
        '                  " And G.TipoDoc in ('FV','NC','ND','FE','BV','BE') " &
        '                  " And G.POS=" & wNumeroCaja & "" &
        '                  " Group By G.FPago,G.TipoDoc,FP.DescFPago,TD.DescTipoDoc, LO.NombreLocal ,G.Local,G.POS" &
        '                  " Order by G.FPago,G.TipoDoc")

        '        xCuadratura.Text = xCuadratura.Text & "POS " & wNumeroCaja & ": " & vbCrLf

        '        If Caj.RecordCount > 0 Then

        '            Dim ValorP As Double
        '            wFPago = ""
        '            While Not Caj.EOF
        '                xTabla.AddItem("")
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, Caj.Fields("NombreLocal").Value)
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, Caj.Fields("POS").Value)
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, Caj.Fields("DescFPago").Value)

        '                If Buscar("FPagos", "FPago", Caj.Fields("FPago").Value) Then
        '                    If Trim(Swap.Fields("DescFPago").Value) <> wFPago And wFPago <> "" Then
        '                        xCuadratura.Text = xCuadratura.Text & wFPago & ":" + vbTab & Format(ValorP, "###,###,###") & vbCrLf
        '                        ValorP = 0
        '                    End If
        '                    wFPago = Trim(Swap.Fields("DescFPago").Value)
        '                End If
        '                If Caj("TipoDoc").Value = "FV" Or Caj("TipoDoc").Value = "ND" Or Caj("TipoDoc").Value = "BV" Or Caj("TipoDoc").Value = "BE" Or Caj("TipoDoc").Value = "FE" Then
        '                    ValorP += Caj.Fields("TCaja").Value
        '                    wTotalVendido += Caj.Fields("TCaja").Value
        '                End If
        '                If Caj("TipoDoc").Value = "NC" Then
        '                    ValorP -= Caj.Fields("TCaja").Value
        '                    wTotalVendido -= Caj.Fields("TCaja").Value
        '                End If
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, Format(ValorP, "###,###,###"))
        '                Caj.MoveNext()
        '            End While
        '            xCuadratura.Text = xCuadratura.Text & wFPago & ":" + vbTab & Format(ValorP, "###,###,###") & vbCrLf
        '        End If

        '        If Trim(xPOS.Text) <> "" Or Val(xPOS.Text) = 0 Then Exit For
        '    Next
        '    wFiltro = ""
        '    If xPOS.Text <> "" And Val(xPOS.Text) > 0 Then
        '        wFiltro = " And POS=" & Val(xPOS.Text) & ""
        '    End If

        '    Caj = SQL("Select Coalesce(Count(TipoDoc),0) as Cantidades from DocumentosG " &
        '                  " where Local = " & wLocales & " " &
        '                  " And Fecha Between '" & cDesde.Text & " 00:00:00 " & "' " &
        '                  " And '" & cHasta.Text & " 23:59:00 " & "' AND (1=1) " & wFiltro & "" &
        '                  " And TipoDoc in ('FV','NC','ND','FE','BV','BE') " &
        '                  " And POS=" & wNumeroCaja)

        '    wTotalCuadratura = IIf(wTotalVendido = 0, 0, Format(wTotalVendido, "###,###,###"))
        '    xCuadratura.Text = xCuadratura.Text & "-------------------------------" & vbCrLf
        '    xCuadratura.Text = xCuadratura.Text & "TOTAL $:" + vbTab & wTotalCuadratura & vbCrLf
        '    xCuadratura.Text = xCuadratura.Text & "N° Documentos:" + vbTab & CStr(Caj("Cantidades").Value) & vbCrLf
        '    xCuadratura.Text += vbCrLf + vbCrLf

        '    Loc.MoveNext()
        '    DoEvents()
        'End While
    End Sub

    Sub Calcular_Cuadratura_CAJA()
        'Dim wFPago As String
        'Dim wNumeroCaja As Integer
        'Dim wNumeroPos As Integer
        'Dim wTotalVendido As Double
        'Dim wTotalCuadratura As String
        'Dim wFiltro As String = IIf(cLocal.Text = "Seleccionar", "", " WHERE NombreLocal='" & Trim(cLocal.Text) & "'")
        'Loc = SQL("Select Local,NombreLocal from Locales " & wFiltro & " Order by Local")

        'While Not Loc.EOF
        '    Dim wLocales As Double = Loc.Fields("Local").Value
        '    'xCuadratura.Text = xCuadratura.Text & "LOCAL: " & Trim(Loc.Fields("NombreLocal").Value) & vbCrLf & vbCrLf
        '    Cli = SQL("SELECT Distinct Top 1 Caja FROM Ventas WHERE Local=" & wLocales & " Order By Caja Desc")
        '    If Cli.EOF Then
        '        wNumeroPos = 1
        '    Else
        '        wNumeroPos = Cli.Fields("Caja").Value
        '    End If
        '    For wNumeroCaja = 1 To wNumeroPos
        '        If xPOS.Text <> "" And Val(xPOS.Text) > 0 Then
        '            wNumeroCaja = Val(xPOS.Text)
        '        End If
        '        Caj = SQL("Select Sum(Total) as TCaja,Fpago from Ventas " &
        '                      " where Local = " & wLocales & " " &
        '                      " And Fecha Between '" & cDesde.Text & " 00:00:00 " & "' " &
        '                      " And '" & cHasta.Text & " 23:59:00 " & "' " &
        '                      " And Caja=" & wNumeroCaja & " Group By FPago")
        '        xCuadratura.Text = xCuadratura.Text & "Caja " & wNumeroCaja & ": " & vbCrLf

        '        While Not Caj.EOF
        '            If Buscar("FPagos", "FPago", Caj.Fields("FPago").Value) Then
        '                wFPago = Trim(Swap.Fields("DescFPago").Value)
        '            Else
        '                wFPago = " "
        '            End If
        '            xCuadratura.Text = xCuadratura.Text & wFPago & ": " & Format(Caj.Fields("TCaja").Value, "###,###,###") & vbCrLf
        '            Caj.MoveNext()
        '        End While

        '        xCuadratura.Text = xCuadratura.Text & vbCrLf
        '        If Trim(xPOS.Text) <> "" Or Val(xPOS.Text) = 0 Then Exit For
        '    Next
        '    wFiltro = ""
        '    If xPOS.Text <> "" And Val(xPOS.Text) > 0 Then
        '        wFiltro = " And Caja=" & Val(xPOS.Text) & ""
        '    End If

        '    Caj = SQL("Select Coalesce(Sum(Total),0) as Final from Ventas " &
        '                  " where Local = " & wLocales & " " &
        '                  " And Fecha Between '" & cDesde.Text & " 00:00:00 " & "' " &
        '                  " And '" & cHasta.Text & " 23:59:00 " & "' AND Caja<>0 " & wFiltro & "")

        '    wTotalVendido = Val(Caj.Fields("Final").Value)
        '    wTotalCuadratura = IIf(wTotalVendido = 0, 0, Format(wTotalVendido, "###,###,###"))
        '    xCuadratura.Text = xCuadratura.Text & "-----------------------------------" & vbCrLf
        '    xCuadratura.Text = xCuadratura.Text & "TOTAL : " & wTotalCuadratura & vbCrLf & vbCrLf
        '    Loc.MoveNext()
        '    DoEvents()
        'End While
    End Sub
    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wDocumentos = DC.T_DocumentosG.Where(Function(x) x.Fecha.Date >= cDesde.Value.Date And x.Fecha.Date <= cHasta.Value.Date)

        Dim wFPagos = DC.T_FPagos.Select(Function(x) New CuadraturaCajaReporte With
            {
              .FPago = x.FPago,
              .Descripcion = x.DescFPago,
              .Cantidad = 0
            }).ToList()

        For Each wDocumento In wDocumentos.GroupBy(Function(x) x.FPago)
            Dim wFormaPagoMonto = wFPagos.FirstOrDefault(Function(x) x.FPago = wDocumento.First().FPago)
            If wFormaPagoMonto IsNot Nothing Then
                wFormaPagoMonto.Cantidad = wDocumento.Sum(Function(x) x.Total).ToString.ToDecimal()
            End If
        Next

        Dim wRangoFecha = New RangoFecha With {.FechaDesde = cDesde.Value, .FechaHasta = cHasta.Value}
        Dim wParametros = New DocumentoReporte()

        Dim wReporte = New ReporteCuadraturaCaja
        Dim wPageMargins = New CrystalDecisions.Shared.PageMargins With {
                            .bottomMargin = 2, '2
                            .leftMargin = 0,
                            .rightMargin = 0,
                            .topMargin = -0
                        }
        wReporte.PrintOptions.ApplyPageMargins(wPageMargins)
        wReporte.PrintOptions.PrinterName = P_IMPRESORAVOUCHER
        wReporte.Database.Tables("MarketONE_CuadraturaCajaReporte").SetDataSource(wFPagos)
        wReporte.Database.Tables("MarketONE_RangoFecha").SetDataSource({wRangoFecha}.ToList())
        wReporte.Database.Tables("ReporteImprimirDocumento").SetDataSource({wParametros}.ToList())
        wReporte.PrintToPrinter(1, False, 0, 0)
    End Sub
End Class