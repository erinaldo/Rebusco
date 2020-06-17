Public Class CambioProducto
    Const T_CHECK As Integer = 0
    Const T_ARTICULO As Integer = 1
    Const T_DESCRIPCION As Integer = 2
    Const T_PRECIO As Integer = 3
    Const T_CANTIDAD As Integer = 4
    Const T_TOTAL As Integer = 5
    Private Sub CambioProducto_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Titulos()
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc")
    End Sub
    Sub Mostrar_Doc()
        Dim wTotal As Double = 0
        Dim Pos As Integer = 1

        gCambios.Enabled = False
        Titulos()
        Dim wDocG = SQL("Select * from DocumentosG where TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & Val(xNumDoc.Text)).Top
        If wDocG Is Nothing Then
            MsgError("Error Documento no encontrado")
            Exit Sub
        End If
        Dim wDocDs = SQL("Select D.*, A.Descripcion from DocumentosD D JOIN Articulos A ON D.Articulo = A.Articulo" &
                         " where D.TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "' and D.Numero = " & Val(xNumDoc.Text))
        If wDocDs.Rows.Count = 0 Then
            MsgError("Error Detalles del documento no encontrados")
            Exit Sub
        End If

        For Each wDocD As DataRow In wDocDs.Rows
            DoEvents()
            xTabla.AddItem("")
            xTabla.SetData(xTabla.Rows.Count - 1, T_CHECK, UNCHECK)
            xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, wDocD.GetText("Articulo"))
            Dim DC = New MarketONEDataContext(P_CONEXION)

            If wDocD.GetText("Descripcion") <> "" Then
                xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wDocD.GetText("Descripcion"))
            Else
                xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wDocD.GetText("Glosa"))
            End If
            xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDAD, wDocD.GetText("Cantidad"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_PRECIO, wDocD.GetText("Precio"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, CDbl(wDocD.GetText("Cantidad")) * CDbl(wDocD.GetText("Precio")))
            wTotal = wTotal + (CDbl(wDocD.GetText("Cantidad")) * CDbl(wDocD.GetText("Precio")))
        Next

        xTotal.Text = Format(wTotal, "###,###,###")

    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
    Sub Titulos()
        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 7

        xTabla.Cols(T_CHECK).Caption = ""
        xTabla.Cols(T_ARTICULO).Caption = "Artículo"
        xTabla.Cols(T_DESCRIPCION).Caption = "Descripción"
        xTabla.Cols(T_CANTIDAD).Caption = "Cantidad"
        xTabla.Cols(T_PRECIO).Caption = "Precio"
        xTabla.Cols(T_TOTAL).Caption = "Total"

        'xTabla.Cols(0) = 0
        xTabla.Cols(T_CHECK).Width = 30
        xTabla.Cols(T_ARTICULO).Width = 130
        xTabla.Cols(T_DESCRIPCION).Width = 330
        xTabla.Cols(T_CANTIDAD).Width = 100
        xTabla.Cols(T_PRECIO).Width = 100
        xTabla.Cols(T_TOTAL).Width = 100

        xTabla.Cols(T_CHECK).DataType = GetType(Boolean)
        xTabla.Cols(T_ARTICULO).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter

    End Sub

    Private Sub xTabla_Click(sender As Object, e As EventArgs) Handles xTabla.Click
        For i As Integer = 1 To xTabla.Rows.Count - 1
            If xTabla.Row = i Then
                If CBool(xTabla.GetData(i, T_CHECK)) Then
                    xTabla.SetData(i, T_CHECK, False)
                Else
                    xTabla.SetData(i, T_CHECK, True)
                End If
            Else
                xTabla.SetData(i, T_CHECK, False)
            End If
        Next i


        gCambios.Enabled = False
        xArticulo.Clear()
        xDescripcion.Clear()

        For i As Integer = 1 To xTabla.Rows.Count - 1
            If CBool(xTabla.GetData(i, T_CHECK)) Then
                gCambios.Enabled = True
                xArticulo.Text = xTabla.GetData(i, T_ARTICULO).ToString
                xDescripcion.Text = xTabla.GetData(i, T_DESCRIPCION).ToString
            End If
        Next i
    End Sub

    Private Sub xArticulo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xArticulo.Validating
        If xArticulo.Text.Trim <> "" Then
            xArticulo.Text = ObtenerArticulo(xArticulo.Text)
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.ToDecimal)
            If wArt IsNot Nothing Then
                xDescripcion.Text = wArt.Descripcion
            Else
                xDescripcion.Clear()
            End If
        End If
    End Sub

    Private Sub xNumDoc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xNumDoc.Validating
        If Val(xNumDoc.Text) > 0 Then
            Mostrar_Doc()
        End If
    End Sub

    Private Sub xNumDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNumDoc.KeyPress
        ValidarDigitos(e)
        e.NextControl(xTabla)
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(xCantidadNuevo)
    End Sub

    Private Sub bCambiar_Click(sender As Object, e As EventArgs) Handles bCambiar.Click

    End Sub

    Private Sub xArticulo_TextChanged(sender As Object, e As EventArgs) Handles xArticulo.TextChanged

    End Sub
End Class