Imports System.ComponentModel
Imports MarketONE

Public Class TransformacionArticulos
    Const T_ELIMINAR = 0
    Const T_ARTICULOS = 1
    Const T_DESCRIPCIONS = 2
    Const T_CANTIDADS = 3
    Const T_ARTICULOE = 4
    Const T_DESCRIPCIONE = 5
    Const T_CANTIDADE = 6
    Const T_CANTIDADPAQUETE = 7
    Private Sub xLocal_Validating(sender As Object, e As CancelEventArgs) Handles xLocal.Validating
        If xLocal.Text.Trim <> "" Then
            cLocal.SelectedValue = xLocal.Text.Trim
            If cLocal.Text = W_SELECCIONAR Then
                MsgError("Local no encontrado")
                xLocal.Clear()
                xLocal.Focus()
            End If
        End If
    End Sub
    Private Sub xLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xLocal.KeyPress
        e.NextControl(xBodega)
    End Sub

    Private Sub xBodega_Validating(sender As Object, e As CancelEventArgs) Handles xBodega.Validating
        If xBodega.Text.Trim <> "" Then
            cBodega.SelectedValue = xBodega.Text.Trim
            If cBodega.Text = W_SELECCIONAR Then
                MsgError("Bodega no encontrado")
                xBodega.Clear()
                xBodega.Focus()
            End If
        End If
    End Sub
    Private Sub xBodega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBodega.KeyPress
        e.NextControl(xArticuloS)
    End Sub

    Private Sub xArticuloS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticuloS.KeyPress
        e.NextControl(xCantidadS)
    End Sub

    Private Sub xArticuloS_Validating(sender As Object, e As CancelEventArgs) Handles xArticuloS.Validating
        If cLocal.Text.Trim = "" Then
            MsgError("Debe seleccionar un local")
            xLocal.Focus()
            Exit Sub
        End If
        If cBodega.Text.Trim = "" Then
            MsgError("Debe seleccionar una bodega")
            xBodega.Focus()
            Exit Sub
        End If

        If xArticuloS.Text.Trim <> "" Then
            Dim wArt = SQL("SELECT A.Produccion,A.Descripcion, S.Stock FROM Articulos A JOIN Stocks S ON A.Articulo = S.Articulo AND" &
                      " S.Local = '" & cLocal.SelectedValue.ToString & "' AND S.Bodega = '" & cBodega.SelectedValue.ToString & "'" &
                      " WHERE A.Articulo = '" & xArticuloS.Text.Trim & "'").Top

            If wArt IsNot Nothing Then
                If wArt.GetInt("Stock") < 1 Then
                    MsgError("Artículo sin stock")
                    xDescripcionS.Clear()
                    xArticuloS.Clear()
                    xArticuloS.Focus()
                    Exit Sub
                End If
                xDescripcionS.Text = wArt.GetText("Descripcion")
                xStockS.Text = wArt.GetText("Stock")
                oPropia.Checked = wArt.GetBool("Produccion")

            Else
                MsgError("Artículo no encontrado")
                xArticuloS.Clear()
                xArticuloS.Focus()
            End If
        End If
    End Sub
    Private Sub xCantidadS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCantidadS.KeyPress
        ValidarDigitos(e)
        e.NextControl(xArticuloE)
    End Sub

    Private Sub xArticuloE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticuloE.KeyPress
        e.NextControl(xStockEntrada)
    End Sub

    Private Sub cLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cLocal.SelectedIndexChanged
        If cLocal.Text.Trim <> "" Then
            xLocal.Text = cLocal.SelectedValue.ToString
            cBodega.LoadItemsObj("Bodegas", "Bodega", "NombreBodega", "WHERE Local = " & xLocal.Text)
        End If
    End Sub

    Private Sub cBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBodega.SelectedIndexChanged
        If cBodega.Text.Trim <> "" Then
            xBodega.Text = cBodega.SelectedValue.ToString
        End If
    End Sub


    Private Sub xArticuloE_Validating(sender As Object, e As CancelEventArgs) Handles xArticuloE.Validating
        If xArticuloE.Text.Trim <> "" Then
            Dim wArt = SQL("SELECT Descripcion FROM Articulos WHERE Articulo = '" & xArticuloE.Text.Trim & "'").Top
            If wArt IsNot Nothing Then
                xDescripcionE.Text = wArt.GetText("Descripcion")
            Else
                MsgError("Artículo no encontrado")
                xDescripcionE.Clear()
                xArticuloE.Clear()
                xArticuloE.Focus()
            End If
        End If
    End Sub
    Private Sub xCantidadE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xStockEntrada.KeyPress
        ValidarDigitos(e)
        ' e.NextControl(bCargar)
    End Sub


    Private Sub xCantidadS_Validating(sender As Object, e As CancelEventArgs) Handles xCantidadS.Validating
        If xCantidadS.Text.Trim <> "" And xStockS.Text <> "" Then
            If Val(xCantidadS.Text) > Val(xStockS.Text) Then
                MsgError("La cantidad ingresada supera el stock disponible")
                xCantidadS.Clear()
                xCantidadS.Focus()
            End If
        End If
    End Sub


    Sub LimpiarCarga()
        xArticuloE.Clear()
        xDescripcionE.Clear()
        xStockEntrada.Clear()
    End Sub



    Private Sub bProcesar_Click(sender As Object, e As EventArgs) Handles bProcesar.Click

    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        'Titulos()
        xLocal.Focus()
    End Sub


    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub TransformarArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
    End Sub

    Private Sub xBarra_Validating(sender As Object, e As CancelEventArgs) Handles xBarra.Validating
        If xBarra.Text = "" Then Exit Sub
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wBarra = DC.T_Barras.FirstOrDefault(Function(x) x.Barra = xBarra.Text.Trim)
        If wBarra IsNot Nothing Then
            xPaqueteS.Text = wBarra.Unidades.ToString
            xCantidadS.Focus()
        End If
    End Sub
End Class

'Private Sub bCargar_Click(sender As Object, e As EventArgs)
'    If xArticuloE.Text.Trim = "" Then
'        MsgError("Debe ingresar artículo de salida")
'        xArticuloS.Focus()
'        Exit Sub
'    End If
'    If xArticuloE.Text.Trim = "" Then
'        MsgError("Debe ingresar artículo de entrada")
'        xArticuloE.Focus()
'        Exit Sub
'    End If

'    If xCantidadS.Text.Trim = "" Then
'        MsgError("Debe ingresar cantidad en artículo de Salida")
'        xCantidadS.Focus()
'        Exit Sub
'    End If
'    If xCantidadE.Text.Trim = "" Then
'        MsgError("Debe ingresar cantidad en artículo de Entrada")
'        xCantidadE.Focus()
'        Exit Sub
'    End If

'    If xTabla.Rows.Count = 1 Then
'        Titulos()
'    End If

'    If ValidarGrilla() Then
'        xTabla.AddItem("")
'        xTabla.SetCellImage(xTabla.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
'        xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULOS, xArticuloS.Text.Trim)
'        xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCIONS, xDescripcionS.Text)
'        xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDADS, xCantidadS.Text)
'        xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULOE, xArticuloE.Text.Trim)
'        xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCIONE, xDescripcionE.Text)
'        xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDADE, xCantidadE.Text)
'        LimpiarCarga()
'        xArticuloE.Focus()
'    End If
'End Sub

'Sub Titulos()
'    xTabla.Redraw = False

'    xTabla.Clear()
'    xTabla.Rows.Count = 1
'    xTabla.Cols.Count = 7

'    xTabla.Cols(T_ELIMINAR).Width = 50
'    xTabla.Cols(T_Articulos).Width = 100
'    xTabla.Cols(T_DESCRIPCIONS).Width = 233
'    xTabla.Cols(T_CANTIDADS).Width = 80
'    xTabla.Cols(T_ARTICULOE).Width = 100
'    xTabla.Cols(T_DESCRIPCIONE).Width = 233
'    xTabla.Cols(T_CANTIDADE).Width = 80

'    xTabla.Cols(T_ELIMINAR).Caption = "Eliminar"
'    xTabla.Cols(T_Articulos).Caption = "Artículo Salida"
'    xTabla.Cols(T_DESCRIPCIONS).Caption = "Descripción"
'    xTabla.Cols(T_CANTIDADS).Caption = "Cantidad"

'    xTabla.Cols(T_ARTICULOE).Caption = "Artículo Entrada"
'    xTabla.Cols(T_DESCRIPCIONE).Caption = "Descripción"
'    xTabla.Cols(T_CANTIDADE).Caption = "Cantidad"

'    xTabla.Redraw = True
'End Sub

'Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs)
'    If xTabla.Rows.Count - 1 > 0 And xTabla.Col = 0 Then
'        xTabla.RemoveItem(xTabla.Row)
'    End If
'End Sub

'Private Function ValidarGrilla() As Boolean
'    Dim wCantidadGrila As New Double

'    For Each wRow As C1.Win.C1FlexGrid.Row In xTabla.Rows
'        If wRow.Index = 1 Then Continue For
'        If wRow.Item(T_ARTICULOS).ToString = xArticuloS.Text Then
'            wCantidadGrila += Val(wRow.Item(T_CANTIDADE).ToString)
'        End If
'    Next
'    If wCantidadGrila <> 0 Then
'        wCantidadGrila += Val(xCantidadE.Text)

'        If wCantidadGrila > Val(xStockS.Text) Then
'            MsgError("Lo ingresado pasa la cantidad ya cargada")
'            xCantidadE.Focus()
'            Return False
'        End If
'    End If
'    Return True

'End Function