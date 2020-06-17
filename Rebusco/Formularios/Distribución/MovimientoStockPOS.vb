Public Class MovimientoStockPOS
    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub
    Private Sub LlenarCombo()
        Dim wLista As New List(Of ItemCombo)
        Dim wBog = SQL("SELECT b.bodega, b.NombreBodega FROM Bodegas B" &
                       " JOIN Stocks S ON B.Bodega = s.Bodega" &
                       " WHERE Movil = 1 and s.Stock > 0 AND B.Local = " & G_LOCALACTUAL & "" &
                       " GROUP BY b.bodega, b.NombreBodega")

        For Each wB As DataRow In wBog.Rows
            wLista.Add(New ItemCombo With {.ID = wB.GetText("Bodega"),
                                             .Desc = wB.GetText("NombreBodega")})

        Next

        If wLista.Any Then
            cPOS.ValueMember = "ID"
            cPOS.DisplayMember = "Descripcion"
            cPOS.DataSource = wLista
        End If

        cBodegaDestino.LoadItemsObj("Bodegas", "Bodega", "NombreBodega", " WHERE Local = " & G_LOCALACTUAL & " AND Despacho = 1 Or Principal = 1 ")
    End Sub

    Private Sub Movimiento_de_Stock_de_POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombo()
        cPOS.LoadItemsObj("Bodegas", "Bodega", "NombreBodega", "")
        Auditoria(Me.Text, A_INGRESADO, "", "")
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If cPOS.Text = "" Then
            Exit Sub
        End If
        If cBodegaDestino.Text = "" Then
            Exit Sub
        End If
        Dim wStock = SQL("SELECT SUM(STOCK) as stock FROM STOCKS" &
                         " WHERE LOCAL = " & G_LOCALACTUAL & " AND BODEGA = " & Val(cPOS.SelectedValue.ToString)).Top

        If wStock Is Nothing Then
            MsgError("POS no tiene mercancia para devolver")
            Exit Sub
        Else
            If Val(wStock.GetText("Stock")) = 0 Then
                MsgError("POS con stock en cero(0)")
                Exit Sub
            End If
        End If
        Cursor = Cursors.WaitCursor
        Dim wStocs = SQL("SELECT * FROM STOCKS WHERE LOCAL = " & G_LOCALACTUAL & " AND BODEGA = " & Val(cPOS.SelectedValue.ToString))

        For Each wStk As DataRow In wStocs.Rows

            Dim articulo = wStk.GetText("Articulo").ToDecimal
            Dim cantidad = wStk.GetText("Stock").ToDecimal()

            Stocks(articulo, CInt(cPOS.SelectedValue.ToString), G_LOCALACTUAL, cantidad, ModoInventario.Disminuir)
            Stocks(articulo, CInt(cBodegaDestino.SelectedValue.ToString), G_LOCALACTUAL, cantidad, ModoInventario.Incrementar)

            Tracking.Ingresar(Tracking.Eventos.StockDisminuido, Now, 0, "", 0, Now, articulo, cantidad, CInt(cPOS.SelectedValue.ToString), G_LOCALACTUAL, "", Me.Text)
            Tracking.Ingresar(Tracking.Eventos.StockIncrementado, Now, 0, "", 0, Now, articulo, cantidad, CInt(cBodegaDestino.SelectedValue.ToString), G_LOCALACTUAL, "", Me.Text)
        Next

        Mensaje("Artículos cargados a Bodega " & cBodegaDestino.Text & " correctamente")
        Auditoria(Me.Text, A_INGRESADO, cPOS.Text, cBodegaDestino.Text)
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bVisualizar_Click(sender As Object, e As EventArgs) Handles bVisualizar.Click

        If cPOS.Text = "" Then
            MsgError("Debe seleccionar un POS")
            Exit Sub
        End If

        Dim wStock = SQL("SELECT SUM(STOCK) as stock FROM STOCKS" &
                         " WHERE LOCAL = " & G_LOCALACTUAL & " AND BODEGA = " & Val(cPOS.SelectedValue)).Top

        If wStock IsNot Nothing Then
            MsgError("POS no tiene mercancia para devolver")
            Exit Sub
        Else
            If Val(wStock.GetText("Stock")) = 0 Then
                MsgError("POS con stock en cero(0)")
                Exit Sub
            End If
        End If

        Dim wStocks = SQL("SELECT S.*, A.Descripcion, L.NombreLocal FROM STOCKS S" &
                     " JOIN Articulos A ON S.Articulo = A.Articulo " &
                     " JOIN Locales L ON S.Local = L.Local" &
                     " WHERE S.Local = " & G_LOCALACTUAL & " AND S.Bodega = " & Val(cPOS.SelectedValue.ToString))

        If wStocks.Rows.Count = 0 Then
            MsgError("POS no tiene artículos cargados")
        End If

        Dim wLista As New List(Of POSStock)
        For Each wS As DataRow In wStocks.Rows
            wLista.Add(New POSStock With {.Local = CInt(G_LOCALACTUAL),
                                         .POS = cPOS.Text,
                                         .Cantidad = Val(wS.GetText("Stock")),
                                         .Articulo = wS.GetText("Articulo"),
                                         .NombreArticulo = wS.GetText("Descripcion"),
                                         .Bodega = Val(cPOS.SelectedValue),
                                         .NombreLocal = wS.GetText("NombreLocal")})
        Next

        Dim wListParametros = ParametroReporte()
        Dim wListParametrosLocal = ParametroLocal()

        If wLista.Any Then
            Dim wReporte As New ReporteStockPOS
            wReporte.Database.Tables("SisVen_POSStock").SetDataSource(wLista)
            wReporte.Database.Tables("SisVen_ParametrosReporte").SetDataSource(wListParametros)
            wReporte.Database.Tables("SisVen_ParametrosLocal").SetDataSource(wListParametrosLocal)

            VisorReportes.MostrarReporte(wReporte)
            VisorReportes.WinDeco1.TituloVentana = "Stock de " & cPOS.Text
            VisorReportes.Show()
            VisorReportes.BringToFront()
            Auditoria(Me.Text, "Visualizar Documento", cPOS.Text, "0")
        Else
            MsgError("Error al generar el reporte")
        End If
    End Sub
End Class