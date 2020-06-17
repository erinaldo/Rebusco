Public Class LimpiarStocksBodega
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub

    Private Sub LimpiarStocksBodega_Load(sender As Object, e As EventArgs) Handles Me.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        cFamilia.LoadItemsObj("Familias", "Familia", "DescFamilia")
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If cLocal.Text.Trim = "" Then
            MsgError("No se puede ejecutar la limpieza de todos los locales, debe especificar al menos un local")
            Exit Sub
        End If
        If cBodega.Text.Trim = "" Then
            MsgError("No se puede ejecutar la limpieza de todas las bodegas, debe especificar al menos una bodega")
            Exit Sub
        End If

        Dim DC = New RebuscoDataContext(P_CONEXION)

        If Not Pregunta("¿Desea dejar el Stock en 0 para el Local " & Trim(cLocal.Text) & ", Bodega: " & Trim(cBodega.Text) & "?") Then
            Exit Sub
        End If

        Dim bodega = cBodega.SelectedValue.ToString.ToDecimal()
        Dim local = cLocal.SelectedValue.ToString.ToDecimal()

        If cFamilia.Text = "" And cSubFamilia.Text = "" Then
            Me.Cursor = Cursors.WaitCursor
            SQL("UPDATE Stocks Set Stock=0 WHERE Local=" & local & " and Bodega=" & bodega & "")
            Tracking.Ingresar(Tracking.Eventos.StockRestablecido, Now, 0, "", 0, Now, 0, 0, bodega, local, "Todos los artículos", Me.Text)
            Me.Cursor = Cursors.Default
            Mensaje("Proceso Finalizado")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        If cFamilia.Text <> "" And cSubFamilia.Text = "" Then
            Dim wArticuloSoloFamilia = DC.T_Articulos.Where(Function(x) x.Familia = cFamilia.SelectedValue.ToString().ToDecimal())
            For Each wArticulo In wArticuloSoloFamilia
                Dim wStock = DC.T_Stocks.FirstOrDefault(Function(x) x.Articulo = wArticulo.Articulo And x.Local = cLocal.SelectedValue.ToString().ToDecimal() And
                                                             x.Bodega = cBodega.SelectedValue.ToString.ToDecimal())

                Stocks(wArticulo.Articulo.ToString.ToDecimal, cBodega.SelectedValue.ToString.ToDecimal(), cLocal.SelectedValue.ToString().ToDecimal(), 0, ModoInventario.Igualar)
                Tracking.Ingresar(Tracking.Eventos.StockRestablecido, Now, 0, "", 0, Now, wArticulo.Articulo, 0, bodega, local, "", Me.Text)
            Next
        ElseIf cFamilia.Text <> "" And cSubFamilia.Text <> "" Then
            Dim wArticuloSoloSubFamilia = DC.T_Articulos.Where(Function(x) x.Familia = cFamilia.SelectedValue.ToString().ToDecimal() And
                                                                            x.SubFamilia = cSubFamilia.SelectedValue.ToString.ToDecimal())
            For Each wArticulo In wArticuloSoloSubFamilia
                Dim wStock = DC.T_Stocks.FirstOrDefault(Function(x) x.Articulo = wArticulo.Articulo And x.Local = cLocal.SelectedValue.ToString().ToDecimal() And
                                                             x.Bodega = cBodega.SelectedValue.ToString.ToDecimal())

                Stocks(wArticulo.Articulo, cBodega.SelectedValue.ToString.ToDecimal(), cLocal.SelectedValue.ToString().ToDecimal(), 0, ModoInventario.Igualar)
                Tracking.Ingresar(Tracking.Eventos.StockRestablecido, Now, 0, "", 0, Now, wArticulo.Articulo, 0, bodega, local, "", Me.Text)

            Next
        End If
        Me.Cursor = Cursors.Default
        Mensaje("Proceso Finalizado")
    End Sub

    Private Sub cLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cLocal.SelectedIndexChanged
        If cLocal.Text <> "" Then
            cBodega.DataSource = Nothing
            cBodega.Items.Clear()
            cBodega.LoadItemsObj("Bodegas", "Bodega", "NombreBodega", "WHERE Local = " & cLocal.SelectedValue.ToString())
        End If
    End Sub

    Private Sub cFamilia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cFamilia.SelectedIndexChanged
        If cFamilia.Text <> "" Then
            cSubFamilia.DataSource = Nothing
            cSubFamilia.Items.Clear()
            cSubFamilia.LoadItemsObj("SubFamilias", "SubFamilia", "DescSubFamilia", "WHERE Familia = " & cFamilia.SelectedValue.ToString())
        End If
    End Sub
End Class