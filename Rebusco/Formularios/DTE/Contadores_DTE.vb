Imports IDAutomation
Imports DTEBoxCliente
Imports DocumentoDTE

Public Class Contadores_DTE
    Dim qRecibidos As String = ""
    Dim qEmitidos As String = ""
    Dim cClave As String = ""
    Dim cCliente As Double = 0

    Private Sub ContadoresDTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        bTotales.Visible = True
        oAcumular.Visible = False
        If UsuarioActual = "PED" Then
            gDatosCliente.Enabled = True
            bBuscarCli.Visible = True
            oAcumular.Visible = True
        End If
    End Sub

    Private Sub Limpiar()
        dDesde.Value = IniFinFecha(1, DateAdd(DateInterval.Month, -1, Now))
        dHasta.Value = IniFinFecha(2, DateAdd(DateInterval.Month, -1, Now))
        xRut.Text = Formatea_Rut(FE_Rut_Emisor, 1)
        xNombre.Text = FE_Razon_Social

        xRecibidos.Text = ""
        xEmitidos.Text = ""
        xTotal.Text = ""
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        Encontrar_Cliente()
        If xNombre.Text.Trim = "" Then
            MsgError("Falta Cliente")
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        bConsultar.Enabled = False

        If oAcumular.Checked Then
            Consultar_Datos_Detalles()
        Else
            Consultar_Datos_Individual()
        End If

        Cursor = Cursors.Arrow
        bConsultar.Enabled = True
    End Sub

    Sub Consultar_Datos_Detalles()
        Dim DTE_Consulta As String, tRecibidos As Double, tEmitidos As Double, xDoc As String
        Dim PageSize As Integer = 200 'El tamaño máximo de página permitido es de 300 

        xEmitidos.Text = "0"
        xRecibidos.Text = "0"
        xTotal.Text = "0" : xBEr.Text = "" : xBEe.Text = ""
        xBVr.Text = "" : xFCr.Text = "" : xFEr.Text = "" : xFVr.Text = "" : xGDr.Text = "" : xNCr.Text = "" : xNDr.Text = "" : xOCr.Text = ""
        xBVe.Text = "" : xFCe.Text = "" : xFEe.Text = "" : xFVe.Text = "" : xGDe.Text = "" : xNCe.Text = "" : xNDe.Text = "" : xOCe.Text = ""
        tEmitidos = 0 : tRecibidos = 0
        qEmitidos = "" : qRecibidos = ""

        DoEvents()

        If FE_Llave.Trim = "" Then
            MsgError("No es Cliente Facturación Electrónica por Wikets")
            Exit Sub
        End If

        'Configgurar DTE
        Dim ServicioDTE As DTEBoxCliente.Servicio
        ServicioDTE = New DTEBoxCliente.Servicio(FE_DTE, FE_Llave)

        Dim AmbienteDTE As DTEBoxCliente.Ambiente
        AmbienteDTE = CType(DTE.FE_Ambiente, DTEBoxCliente.Ambiente)

        If dHasta.Value > Date.Now Then
            dHasta.Value = Date.Now
        End If
        Dim FechaDesde As String = FE_Fecha(dDesde.Value)
        Dim FechaHasta As String = FE_Fecha(dHasta.Value)


        'Buscar Emitidos
        Dim DTE_GrupoEmitidos As DTEBoxCliente.GrupoBusqueda = DTEBoxCliente.GrupoBusqueda.Emitidos

        ' DTE_Consulta = "(TipoDTE:33 or TipoDTE:34 or TipoDTE:39 or TipoDTE:52 or TipoDTE:56 or TipoDTE:61) "
        ' DTE_Consulta += " AND (FchEmis:[" + FechaDesde + " TO " + FechaHasta + "]) "
        DTE_Consulta = "RUTEmisor:" + Formatea_Rut(xRut.Text, 0) + " "
        DTE_Consulta += " AND FchEmis:[" + FechaDesde + " TO " + FechaHasta + "] "

        tEmitidos = 0
        Dim ResultadoDTEe As ResultadoDocumentos = ServicioDTE.BuscarDocumentos(AmbienteDTE, DTE_GrupoEmitidos, DTE_Consulta, 0, PageSize)

        If (ResultadoDTEe.ResultadoServicio.Estado = 0) Then
            If (ResultadoDTEe.TotalDocumentos > 0) Then
                Dim TotalPaginas As Integer = ResultadoDTEe.TotalPages
                Dim Pagina As Integer = 0

                While ((Pagina < TotalPaginas) And (ResultadoDTEe.ResultadoServicio.Estado = 0))
                    For Each doc As ResumenDTE In ResultadoDTEe.ResumenDtes
                        'DoEvents()
                        xDoc = ""
                        If doc.TipoDTE = "39" Then xDoc = "BV" : xBVe.Text = (Val(xBVe.Text) + 1).ToString
                        If doc.TipoDTE = "46" Then xDoc = "FC" : xFCe.Text = (Val(xFCe.Text) + 1).ToString
                        If doc.TipoDTE = "34" Then xDoc = "FE" : xFEe.Text = (Val(xFEe.Text) + 1).ToString
                        If doc.TipoDTE = "33" Then xDoc = "FV" : xFVe.Text = (Val(xFVe.Text) + 1).ToString
                        If doc.TipoDTE = "52" Then xDoc = "GD" : xGDe.Text = (Val(xGDe.Text) + 1).ToString
                        If doc.TipoDTE = "61" Then xDoc = "NC" : xNCe.Text = (Val(xNCe.Text) + 1).ToString
                        If doc.TipoDTE = "56" Then xDoc = "ND" : xNDe.Text = (Val(xNDe.Text) + 1).ToString
                        If doc.TipoDTE = "801" Then xDoc = "OC" : xOCe.Text = (Val(xOCe.Text) + 1).ToString
                        If xDoc = "" Then xBEe.Text = (Val(xBEe.Text) + 1).ToString
                        If oAcumular.Checked Then
                            qEmitidos &= xDoc & vbTab & doc.Folio & vbTab & Formatea_Rut(doc.RUTRecep, 1) & vbTab & Format(doc.FchEmis, "dd/MM/yyyy") & vbTab & "$" & vbTab & doc.MntTotal & vbCrLf
                        End If
                        tEmitidos += 1
                    Next
                    Pagina = Pagina + 1
                    If (Pagina < TotalPaginas) Then
                        ResultadoDTEe = ServicioDTE.BuscarDocumentos(AmbienteDTE, DTE_GrupoEmitidos, DTE_Consulta, Pagina, PageSize)
                    End If
                End While

                tEmitidos = ResultadoDTEe.TotalDocumentos
            End If
        Else
            ' Si la llamada no fue satisfactoria
            Cursor = Cursors.Arrow
            MsgError(ResultadoDTEe.ResultadoServicio.Descripcion)
        End If


        'Buscar Recibidos
        Dim DTE_GrupoRecibidos As DTEBoxCliente.GrupoBusqueda = DTEBoxCliente.GrupoBusqueda.Recibidos

        'DTE_Consulta = "(TipoDTE:33 or TipoDTE:34 or TipoDTE:39 or TipoDTE:52 or TipoDTE:56 or TipoDTE:61) "
        DTE_Consulta = "RUTRecep:" + Formatea_Rut(xRut.Text, 0) + " "
        DTE_Consulta += " AND FchEmis:[" + FechaDesde + " TO " + FechaHasta + "] "

        tRecibidos = 0
        Dim ResultadoDTEr As ResultadoDocumentos = ServicioDTE.BuscarDocumentos(AmbienteDTE, DTE_GrupoRecibidos, DTE_Consulta, 0, PageSize)
        If (ResultadoDTEr.ResultadoServicio.Estado = 0) Then
            If (ResultadoDTEr.TotalDocumentos > 0) Then
                Dim TotalPaginas As Integer = ResultadoDTEr.TotalPages
                Dim Pagina As Integer = 0

                While ((Pagina < TotalPaginas) And (ResultadoDTEr.ResultadoServicio.Estado = 0))
                    For Each doc As ResumenDTE In ResultadoDTEr.ResumenDtes
                        'DoEvents()
                        xDoc = ""
                        If doc.TipoDTE = "39" Then xDoc = "BV" : xBVr.Text = (Val(xBVr.Text) + 1).ToString
                        If doc.TipoDTE = "46" Then xDoc = "FC" : xFCr.Text = (Val(xFCr.Text) + 1).ToString
                        If doc.TipoDTE = "34" Then xDoc = "FE" : xFEr.Text = (Val(xFEr.Text) + 1).ToString
                        If doc.TipoDTE = "33" Then xDoc = "FV" : xFVr.Text = (Val(xFVr.Text) + 1).ToString
                        If doc.TipoDTE = "52" Then xDoc = "GD" : xGDr.Text = (Val(xGDr.Text) + 1).ToString
                        If doc.TipoDTE = "61" Then xDoc = "NC" : xNCr.Text = (Val(xNCr.Text) + 1).ToString
                        If doc.TipoDTE = "56" Then xDoc = "ND" : xNDr.Text = (Val(xNDr.Text) + 1).ToString
                        If doc.TipoDTE = "801" Then xDoc = "OC" : xOCr.Text = (Val(xOCr.Text) + 1).ToString
                        If xDoc = "" Then xBEr.Text = (Val(xBEr.Text) + 1).ToString
                        If oAcumular.Checked Then
                            qRecibidos &= xDoc & vbTab & doc.Folio & vbTab & Formatea_Rut(doc.RUTEmisor, 1) & vbTab & Format(doc.FchEmis, "dd/MM/yyyy") & vbTab & "$" & vbTab & doc.MntTotal & vbCrLf
                        End If
                    Next
                    Pagina = Pagina + 1
                    If (Pagina < TotalPaginas) Then
                        ResultadoDTEr = ServicioDTE.BuscarDocumentos(AmbienteDTE, DTE_GrupoRecibidos, DTE_Consulta, Pagina, PageSize)
                    End If
                End While

                tRecibidos = ResultadoDTEr.TotalDocumentos
            End If
        Else
            ' Si la llamada no fue satisfactoria
            Cursor = Cursors.Arrow
            MsgError(ResultadoDTEr.ResultadoServicio.Descripcion)
        End If

        xRecibidos.Text = Format(tRecibidos, "###,###,##0")
        xEmitidos.Text = Format(tEmitidos, "###,###,##0")
        xTotal.Text = Format(tRecibidos + tEmitidos, "###,###,##0")

    End Sub


    Sub Consultar_Datos_Individual()
        Dim tRecibidos As Double, tEmitidos As Double

        xEmitidos.Text = "0"
        xRecibidos.Text = "0"
        xTotal.Text = "0" : xBEr.Text = "" : xBEe.Text = ""
        xBVr.Text = "" : xFCr.Text = "" : xFEr.Text = "" : xFVr.Text = "" : xGDr.Text = "" : xNCr.Text = "" : xNDr.Text = "" : xOCr.Text = ""
        xBVe.Text = "" : xFCe.Text = "" : xFEe.Text = "" : xFVe.Text = "" : xGDe.Text = "" : xNCe.Text = "" : xNDe.Text = "" : xOCe.Text = ""
        qEmitidos = "" : qRecibidos = ""

        DoEvents()

        If FE_Llave.Trim = "" Then
            MsgError("No es Cliente Facturación Electrónica por Wikets")
            Exit Sub
        End If

        'Emitidos
        xBVe.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "E", Codigo_DTE_Consulta("BV"), Formatea_Rut(xRut.Text, 0)).ToString
        xBEe.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "E", Codigo_DTE_Consulta("BE"), Formatea_Rut(xRut.Text, 0)).ToString
        xFVe.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "E", Codigo_DTE_Consulta("FV"), Formatea_Rut(xRut.Text, 0)).ToString
        xFEe.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "E", Codigo_DTE_Consulta("FE"), Formatea_Rut(xRut.Text, 0)).ToString
        xFCe.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "E", Codigo_DTE_Consulta("FC"), Formatea_Rut(xRut.Text, 0)).ToString
        xGDe.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "E", Codigo_DTE_Consulta("GD"), Formatea_Rut(xRut.Text, 0)).ToString
        xNCe.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "E", Codigo_DTE_Consulta("NC"), Formatea_Rut(xRut.Text, 0)).ToString
        xNDe.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "E", Codigo_DTE_Consulta("ND"), Formatea_Rut(xRut.Text, 0)).ToString
        xOCe.Text = "0"
        tEmitidos = CDbl(xBVe.Text) + CDbl(xBEe.Text) + CDbl(xFVe.Text) + CDbl(xFEe.Text) + CDbl(xFCe.Text) + CDbl(xGDe.Text) + CDbl(xNCe.Text) + CDbl(xNDe.Text)

        'Recibidos
        xBVr.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "R", Codigo_DTE_Consulta("BV"), Formatea_Rut(xRut.Text, 0)).ToString
        xBEr.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "R", Codigo_DTE_Consulta("BE"), Formatea_Rut(xRut.Text, 0)).ToString
        xFVr.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "R", Codigo_DTE_Consulta("FV"), Formatea_Rut(xRut.Text, 0)).ToString
        xFEr.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "R", Codigo_DTE_Consulta("FE"), Formatea_Rut(xRut.Text, 0)).ToString
        xFCr.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "R", Codigo_DTE_Consulta("FC"), Formatea_Rut(xRut.Text, 0)).ToString
        xGDr.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "R", Codigo_DTE_Consulta("GD"), Formatea_Rut(xRut.Text, 0)).ToString
        xNCr.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "R", Codigo_DTE_Consulta("NC"), Formatea_Rut(xRut.Text, 0)).ToString
        xNDr.Text = Buscar_Documentos_DTE(dDesde.Value, dHasta.Value, "R", Codigo_DTE_Consulta("ND"), Formatea_Rut(xRut.Text, 0)).ToString
        xOCr.Text = "0"
        tRecibidos = CDbl(xBVr.Text) + CDbl(xBEr.Text) + CDbl(xFVr.Text) + CDbl(xFEr.Text) + CDbl(xFCr.Text) + CDbl(xGDr.Text) + CDbl(xNCr.Text) + CDbl(xNDr.Text)


        xRecibidos.Text = Format(tRecibidos, "###,###,##0")
        xEmitidos.Text = Format(tEmitidos, "###,###,##0")
        xTotal.Text = Format(tRecibidos + tEmitidos, "###,###,##0")

        If xBVe.Text = "0" Then xBVe.Text = ""
        If xBEe.Text = "0" Then xBEe.Text = ""
        If xFVe.Text = "0" Then xFVe.Text = ""
        If xFEe.Text = "0" Then xFEe.Text = ""
        If xFCe.Text = "0" Then xFCe.Text = ""
        If xGDe.Text = "0" Then xGDe.Text = ""
        If xNCe.Text = "0" Then xNCe.Text = ""
        If xNDe.Text = "0" Then xNDe.Text = ""

        If xBVr.Text = "0" Then xBVr.Text = ""
        If xBEr.Text = "0" Then xBEr.Text = ""
        If xFVr.Text = "0" Then xFVr.Text = ""
        If xFEr.Text = "0" Then xFEr.Text = ""
        If xFCr.Text = "0" Then xFCr.Text = ""
        If xGDr.Text = "0" Then xGDr.Text = ""
        If xNCr.Text = "0" Then xNCr.Text = ""
        If xNDr.Text = "0" Then xNDr.Text = ""

    End Sub

    Private Function Buscar_Documentos_DTE(wDesde As Date, wHasta As Date, wModo As String, wTipoDoc As Integer, wRut As String) As Integer
        Dim DTE_Consulta As String
        Dim PageSize As Integer = 200 'El tamaño máximo de página permitido es de 300 

        'Configurar DTE
        Dim ServicioDTE As DTEBoxCliente.Servicio
        ServicioDTE = New DTEBoxCliente.Servicio(FE_DTE, FE_Llave)

        Dim AmbienteDTE As DTEBoxCliente.Ambiente
        AmbienteDTE = CType(DTE.FE_Ambiente, DTEBoxCliente.Ambiente)

        If wHasta > Date.Now Then
            wHasta = Date.Now
        End If
        Dim FechaDesde As String = FE_Fecha(wDesde)
        Dim FechaHasta As String = FE_Fecha(wHasta)

        'wModo
        'R = Recibidos  
        'E = Emitidos

        Buscar_Documentos_DTE = 0
        If wModo = "E" Then
            'Buscar Emitidos
            Dim DTE_GrupoEmitidos As DTEBoxCliente.GrupoBusqueda = DTEBoxCliente.GrupoBusqueda.Emitidos
            DTE_Consulta = "RUTEmisor:" + wRut + " "
            DTE_Consulta += " AND TipoDTE:" + wTipoDoc.ToString + " "
            DTE_Consulta += " AND FchEmis:[" + FechaDesde + " TO " + FechaHasta + "] "

            'DTE_Consulta = "RUTEmisor:76235899-9 AND TipoDTE:33 AND FchEmis:[2019-12-01 TO 2019-12-31]"
            Dim ResultadoDTEe As ResultadoDocumentos = ServicioDTE.BuscarDocumentos(AmbienteDTE, DTE_GrupoEmitidos, DTE_Consulta, 0, PageSize)
            If (ResultadoDTEe.ResultadoServicio.Estado = 0) Then
                Buscar_Documentos_DTE = ResultadoDTEe.TotalDocumentos
            Else
                'Si la llamada no fue satisfactoria
                Cursor = Cursors.Arrow
                MsgError(ResultadoDTEe.ResultadoServicio.Descripcion)
            End If
        Else
            'Buscar Recibidos
            Dim DTE_GrupoRecibidos As DTEBoxCliente.GrupoBusqueda = DTEBoxCliente.GrupoBusqueda.Recibidos
            DTE_Consulta = "RUTRecep:" + wRut + " "
            DTE_Consulta += " AND TipoDTE:" + wTipoDoc.ToString + " "
            DTE_Consulta += " AND FchEmis:[" + FechaDesde + " TO " + FechaHasta + "] "

            Dim ResultadoDTEr As ResultadoDocumentos = ServicioDTE.BuscarDocumentos(AmbienteDTE, DTE_GrupoRecibidos, DTE_Consulta, 0, PageSize)
            If (ResultadoDTEr.ResultadoServicio.Estado = 0) Then
                Buscar_Documentos_DTE = ResultadoDTEr.TotalDocumentos
            Else
                'Si la llamada no fue satisfactoria
                Cursor = Cursors.Arrow
                MsgError(ResultadoDTEr.ResultadoServicio.Descripcion)
            End If
        End If

        DoEvents()
        Return Buscar_Documentos_DTE
    End Function

    Private Sub bEmitidos_Click(sender As Object, e As EventArgs) Handles bEmitidos.Click
        Dim qVentana As New VentanaResultados
        If xEmitidos.Text <> "" Then
            qVentana.xTexto.Text = qEmitidos
            qVentana.Show()
            qVentana.BringToFront()
        End If
    End Sub

    Private Sub bRecibidos_Click(sender As Object, e As EventArgs) Handles bRecibidos.Click
        Dim qVentana As New VentanaResultados
        If xRecibidos.Text <> "" Then
            qVentana.xTexto.Text = qRecibidos
            qVentana.Show()
            qVentana.BringToFront()
        End If
    End Sub

    Private Sub bTotales_Click(sender As Object, e As EventArgs) Handles bTotales.Click
        Dim qVentana As New VentanaResultados
        Dim qCalculo As String = ""
        Dim wUF As Double, wValorDoc As Double, wValorBol As Double
        Dim tDocum As Double, tBole As Double, ValorBoleta As Double


        If xTotal.Text = "" Then Exit Sub
        If xBVe.Text = "" Then xBVe.Text = "0"

        tBole = CDec(xBVe.Text)
        tDocum = CDec(xTotal.Text) - tBole

        qCalculo += "CONSUMO DE FOLIOS PERÍODO " & dDesde.Text & " al " & dHasta.Text & vbCrLf & vbCrLf
        qCalculo += "Documentos Electrónicos Emitidos  = " & xEmitidos.Text & vbCrLf
        qCalculo += "Documentos Electrónicos Recibidos = " & xRecibidos.Text & vbCrLf
        qCalculo += "Total de Documentos Electrónicos  = " & tDocum & vbCrLf
        If tBole > 0 Then
            qCalculo += "Total de Boletas Electrónicas  = " & tBole & vbCrLf
        End If
        qCalculo += "Total de General de Documentos Electrónicos  = " & xTotal.Text & vbCrLf
        qCalculo += vbCrLf

        Dim SwapUF = SQL("Select * from UFs where Año = " & Year(dHasta.Value) & " And Mes = " & Month(dHasta.Value)).Top
        If SwapUF Is Nothing Then
            MsgError("No se encuentra valor UF del mes a consultar")
            Exit Sub
        End If
        qCalculo += "Valor U.F. " & Nombre_Mes(SwapUF.GetInt("Mes")) & "/" & SwapUF.GetInt("Año") & ": " & Format(SwapUF.GetInt("UF"), "###,###,###.##") & vbCrLf
        wUF = SwapUF.GetNum("UF")

        'NOTA: La tabla de valores puede depender del cliente que tenga una clave definida y y una tabla de valores específica para el.
        'Sacar Valor de boletas
        ValorBoleta = 0
        Dim SwapV = SQL("Select Top 1 * from Valores where Cliente = " & cCliente & " and Rango = 1").Top
        If SwapV IsNot Nothing Then
            ValorBoleta = SwapV.GetNum("Valor")
        Else
            If tBole > 0 Then
                MsgError("No se encuentra valor para boletas electrónicas y posee boletas emitidas")
            End If
        End If

        'Sacar Valor de Documentos electrónicos segun el tramo
        Dim Swap = SQL("Select Top 1 * from Valores where Cliente = " & cCliente & " and Rango >= " & tDocum.ToString & " And Rango > 1 order by Rango").Top
        If Swap Is Nothing Then
            MsgError("No se encuentra rango para la cantidad solicitada en tabla de valores")
            Exit Sub
        End If
        qCalculo += "Valor Tramo Documentos: " & Format(Swap.GetNum("Valor"), "###,###,###.##") & " U.F." & vbCrLf
        If tBole > 0 Then
            qCalculo += "Valor Unitario Boleta Electrónica: " & Format(ValorBoleta, "##0.00000") & " U.F." & vbCrLf
        End If

        Dim wValor = Swap.GetNum("Valor")
        qCalculo += vbCrLf
        'wValor = Swap("Valor").Value / Swap("Rango").Value
        'qCalculo += "Valor Unidad: " & Format((wValor * wUF), "###,###,###.##") & vbCrLf
        'qCalculo += "TOTAL: " & Format((wValor * wUF * Val(xTotal.Text)), "###,###,###.##") & vbCrLf
        If tBole > 0 Then
            wValorDoc = wValor * wUF
            wValorBol = ValorBoleta * tBole * wUF
            qCalculo += "TOTAL Documentos: " & Format(wValorDoc, "###,###,###.##") & vbCrLf
            qCalculo += "TOTAL Boletas: " & Format(wValorBol, "###,###,###.##") & vbCrLf
            qCalculo += "TOTAL NETO: " & Format((wValorDoc + wValorBol), "###,###,###.##") & vbCrLf
        Else
            qCalculo += "TOTAL NETO: " & Format((wValor * wUF), "###,###,###.##") & vbCrLf
        End If

        qVentana.xTexto.Text = qCalculo
        qVentana.Show()
        qVentana.BringToFront()
    End Sub

    Private Sub xRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xRut.KeyPress
        If e.KeyChar = vbCr Then
            Encontrar_Cliente()
        End If
    End Sub

    Sub Encontrar_Cliente()
        Dim Swap = SQL("Select Cliente,Rut,Nombre,Clave from Clientes where Rut ='" + xRut.Text + "'").Top
        If Swap IsNot Nothing Then
            xNombre.Text = Swap.GetText("Nombre").Trim
            cClave = Swap.GetText("Clave").Trim
            cCliente = Swap.GetNum("Cliente")
        Else
            xNombre.Text = ""
            cClave = ""
            cCliente = 0
        End If
    End Sub

End Class


'Cadena que representa la consulta de búsqueda. Puede utilizar el asistente de construcción de consultas del portal. (Mis consultas)
'Dim consulta As String = "TipoDTE:33"

'Dim pageSize As Integer = 10 'El tamaño máximo de página permitido es de 300 
'Dim resultado As ResultadoDocumentos = servicio.BuscarDocumentos(ambiente, grupo, consulta, 0, pageSize)
'If (resultado.ResultadoServicio.Estado = 0) Then
'If (resultado.TotalDocumentos > 0) Then
'Dim pages As Integer = resultado.TotalPages
'Dim page As Integer = 0
'Dim count As Integer = 0

'Do Until ((pages < page) And (resultado.ResultadoServicio.Estado = 0))
'Console.WriteLine(("Pagina: " + Convert.ToString(page)))
'Console.WriteLine("-------------------------------------------------------")
'For Each doc As ResumenDTE In resultado.ResumenDtes
'Dim folio As String = ""
'Dim rutEmisor As String = ""
'folio = doc.Folio.ToString
'rutEmisor = doc.RUTEmisor
'count += 1
'Console.WriteLine(count.ToString + " - " + folio + " - " + rutEmisor)
'Next
'Console.WriteLine(resultado.Xml)
'page = (page + 1)
'If (page < pages) Then
'resultado = servicio.BuscarDocumentos(ambiente, grupo, consulta, page, pageSize)
'End If
'Loop
'Else
'Console.WriteLine("No se encontraron documentos.")
'End If
'Else
'' Si la llamada no fue satisfactoria
'Console.WriteLine(resultado.ResultadoServicio.Descripcion)
'Console.WriteLine(resultado.ResultadoServicio.ErrorInterno.InnerException.Message)
'End If

