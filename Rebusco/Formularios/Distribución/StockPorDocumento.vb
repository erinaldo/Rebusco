Public Class StockPorDocumento

    Private Sub xNumDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNumDoc.KeyPress
        ValidarDigitos(e)
        e.NextControl(cBodegaIngreso)
    End Sub

    Private Sub xNumDoc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xNumDoc.Validating
        If xNumDoc.Text.Trim = "" Then Exit Sub
        Cursor = Cursors.WaitCursor
        Dim wDoc = SQL("SELECT DG.Numero, Lo.Local,Bo.Bodega, Lo.NombreLocal, Bo.NombreBodega, DG.StockTraspasado" &
                       " FROM DocumentosG DG" &
                       " JOIN Locales Lo ON DG.Local = Lo.Local" &
                       " JOIN Bodegas Bo ON DG.Bodega = Bo.Bodega " &
                       " WHERE DG.Numero = " & xNumDoc.Text.Trim & "And DG.TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "'" &
                       " AND DG.Local = " & G_LOCALACTUAL).Top

        If wDoc IsNot Nothing Then

            If CBool(wDoc.GetText("StockTraspasado")) Then
                MsgError("Este documento ya fue ingresado en Stock")
                LimpiarCampos(Me)
                xNumDoc.Focus()
                Exit Sub
            End If

            Dim wBodD = SQL("SELECT * FROM Bodegas  WHERE Local = " & Val(wDoc.GetText("Local")) & "" &
                            " AND Despacho = 1").Top
            If wBodD IsNot Nothing Then
                xBodega.Text = wBodD.GetText("NombreBodega")
                xLocal.Text = wDoc.GetText("NombreLocal")
                xLocal.Tag = wDoc.GetText("Local")
                xBodega.Tag = wBodD.GetText("Bodega")
                cBodegaIngreso.LoadItemsObj("Bodegas", "Bodega", "NombreBodega", " WHERE Local = " & Val(wDoc.GetText("Local")) & "" &
                                        " AND Movil = 1")
            Else
                MsgError("El local no tiene bodega de Despacho")
                Exit Sub
            End If

        Else
            MsgError("Documento no existente")
            xNumDoc.Clear()
            xNumDoc.Focus()
        End If
        Cursor = Cursors.Arrow
    End Sub
    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        xNumDoc.Focus()
        cTipoDoc.SelectedValue = "GD"
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If xNumDoc.Text.Trim = "" Then
            MsgError("Debe indicar número de documento")
            Exit Sub
        End If
        If cBodegaIngreso.Text = "" Then
            MsgError("Debe indicar Bodega")
            cBodegaIngreso.Focus()
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Dim wDocs = SQL("SELECT Articulo, Cantidad FROM DocumentosD WHERE Local = " & G_LOCALACTUAL & " and TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & xNumDoc.Text.Trim & "")
        If wDocs.Rows.Count > 0 Then
            For Each wDoc As DataRow In wDocs.Rows
                Dim wStock = SQL("SELECT * FROM Stocks WHERE Local = " & Val(xLocal.Tag) & "" &
                           " AND Bodega = " & Val(xBodega.Tag) & "" &
                           " AND Stock >= " & Val(wDoc.GetText("Cantidad")) & "" &
                           " AND Articulo = '" & wDoc.GetText("Articulo") & "'").Top

                If wStock Is Nothing Then
                    Dim wArt = SQL("SELECT Descripcion FROM Articulos WHERE Articulo = '" & wDoc.GetText("Articulo") & "'").Top
                    MsgError("El Artículo " & wArt.GetText("Descripcion") & " no tiene existencia")
                    Exit Sub
                End If

            Next

            For Each wDoc As DataRow In wDocs.Rows
                'Agregar a Bodega Seleccionada
                Dim articulo = wDoc.GetText("Articulo").ToDecimal
                Dim cantidad = wDoc.GetText("Cantidad").ToDecimal
                Stocks(articulo, CInt(cBodegaIngreso.SelectedValue.ToString), CInt(xLocal.Tag), cantidad, ModoInventario.Incrementar)
                Stocks(articulo, CInt(xBodega.Tag), CInt(xLocal.Tag), cantidad, ModoInventario.Disminuir)

                Tracking.Ingresar(Tracking.Eventos.StockIncrementado, Now, 0, "", 0, Now, articulo, cantidad, CInt(cBodegaIngreso.SelectedValue.ToString), CInt(xLocal.Tag), "", Me.Text)
                Tracking.Ingresar(Tracking.Eventos.StockDisminuido, Now, 0, "", 0, Now, articulo, cantidad, CInt(xBodega.Tag), CInt(xLocal.Tag), "", Me.Text)
            Next
            SQL("UPDATE DocumentosG SET StockTraspasado = 1 WHERE Numero = " & Val(xNumDoc.Text) & " AND TipoDoc = 'GD' AND Local = " & G_LOCALACTUAL)
            Mensaje("Stocks Ingresados Correctamente")
            Auditoria(Text, A_GUARDADO, xBodega.Text, cBodegaIngreso.Text)
            LimpiarCampos(Me)
            xNumDoc.Focus()
            Exit Sub
        Else
            MsgError("Número de documento no existente")
        End If
        Cursor = Cursors.Arrow
    End Sub
    Private Sub bVisualizar_Click(sender As Object, e As EventArgs) Handles bVisualizar.Click
        Dim wFiltros = ""
        Dim wQuery = ""
        Dim wTipoDoc As String = ""

        Cursor = Cursors.WaitCursor

        If cTipoDoc.Text = "" Then
            MsgError("Ingrese Tipo de Documento")
            cTipoDoc.Focus()
            Exit Sub
        End If

        If xNumDoc.Text.Trim = "" Then
            MsgError("Ingrese Número de Documento")
            xNumDoc.Focus()
            Exit Sub
        End If

        Dim wDocG = SQL("Select Numero from DocumentosG where Local = " & G_LOCALACTUAL & " and TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & Val(xNumDoc.Text)).Top

        If wDocG Is Nothing Then
            MsgError("Documento No Encontrado")
            Exit Sub
        End If

        Auditoria(Text, A_IMPRESO, CStr(xNumDoc.Text))
        G_TIPOCOPIA = {1}.ToList
        bVisualizar.Enabled = False
        Imprimir_Documento(G_LOCALACTUAL, cTipoDoc.SelectedValue.ToString.Trim, Val(xNumDoc.Text), cTipoDoc.Text, G_TIPOCOPIA)
        bVisualizar.Enabled = True
        Cursor = Cursors.Arrow

    End Sub

    Private Sub StockPorDocumento_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc")
        cTipoDoc.SelectedValue = "GD"
        Auditoria(Text, A_INGRESADO, "", "")
    End Sub
End Class