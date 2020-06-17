Imports System.ComponentModel
Imports System.IO
Imports System.Linq

Public Class CambioPrecios

    Dim wFamilia, wSubFamilia, wUnidad As String

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        sArticulos.DataSource = New List(Of ArticuloPrecio)
        oTodos.Checked = True
    End Sub
    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
    Private Sub ManArticulos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LimpiarCampos(Me)
        cFamilia.LoadItemsObj("Familias", "Familia", "DescFamilia")
        cFamilia.SelectedIndex = 0
        Auditoria(Text, A_INGRESADO, "", "")

    End Sub

    Private Sub ManArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = True
        DoEvents()
        lLocal.Text = $"Local: {NombreLocalActual}"
    End Sub

    Private Sub sArticulos_ListChanged(sender As Object, e As ListChangedEventArgs) Handles sArticulos.ListChanged
        lTotal.Text = sArticulos.Count.ToString()
    End Sub

    Private Sub xTabla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles xTabla.CellFormatting
        If xTabla.Rows.Count = 0 Or e.ColumnIndex > 0 Then Exit Sub
        Dim art = CType(xTabla.Rows(e.RowIndex).DataBoundItem, ArticuloPrecio)

        If art.Modificado Then
            xTabla.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 182)
        Else
            If art.CostoMovimiento > 0 AndAlso art.Costo <> art.CostoMovimiento Then
                xTabla.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 182)
            Else
                xTabla.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            End If
        End If

    End Sub

    Private Sub xFamilia_Validating(Optional sender As Object = Nothing, Optional e As System.ComponentModel.CancelEventArgs = Nothing) Handles xFamilia.Validating
        ValidarDigitos(sender)

        If xFamilia.Text.Trim <> "" Then
            cFamilia.SelectedValue = xFamilia.Text.Trim
            If cFamilia.Text = "" Then
                xFamilia.Clear()
                xFamilia.Focus()
                Exit Sub
            End If
            cSubFamilia.LoadItemsObj("SubFamilias", "SubFamilia", "DescSubFamilia", $"WHERE Familia={xFamilia.Text}")
            cSubFamilia.SelectedIndex = -1
        Else
            cFamilia.SelectedIndex = -1
        End If
    End Sub

    Private Sub xSubFamilia_Validating(Optional sender As Object = Nothing, Optional e As System.ComponentModel.CancelEventArgs = Nothing) Handles xSubfamilia.Validating
        ValidarDigitos(sender)
        If Trim(xSubfamilia.Text) = "" Then
            cSubFamilia.SelectedIndex = -1
            Exit Sub
        End If

        If xSubfamilia.Text.Trim <> "" Then
            cSubFamilia.SelectedValue = xSubfamilia.Text.Trim
            If cSubFamilia.Text = "" Then
                xSubfamilia.Clear()
                xSubfamilia.Focus()
            End If
        End If
    End Sub

    Private Sub cFamilia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cFamilia.SelectedIndexChanged
        If cFamilia.Text <> "" Then
            xFamilia.Text = cFamilia.SelectedValue.ToString
            cSubFamilia.DataSource = Nothing
            cSubFamilia.Items.Clear()
            cSubFamilia.LoadItemsObj("SubFamilias", "SubFamilia", "DescSubFamilia", $"WHERE Familia={xFamilia.Text}", False, "0", "SIN SUB-FAMILIA")
            cSubFamilia.SelectedIndex = -1
        Else
            xFamilia.Clear()
        End If
    End Sub

    Private Sub cSubFamilia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cSubFamilia.SelectedIndexChanged
        If cSubFamilia.Text <> "" Then
            xSubfamilia.Text = cSubFamilia.SelectedValue.ToString
        Else
            xSubfamilia.Clear()
        End If
    End Sub


    Private Sub xSubfamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xSubfamilia.KeyPress
        e.NextControl(bConsultar)
    End Sub

    Private Sub xFamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xFamilia.KeyPress
        e.NextControl(xSubfamilia)
    End Sub

    Private Sub Consultar(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bConsultar.Click

        Cursor = Cursors.WaitCursor

        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim Articulos = DC.T_Articulos.AsQueryable()
        Dim CostosIngresos = DC.T_CostosIngresos.ToList()

        If xFamilia.Text <> "" Then
            Articulos = Articulos.Where(Function(x) x.Familia = xFamilia.Text.ToDecimal())
        End If

        If xSubfamilia.Text <> "" Then
            Articulos = Articulos.Where(Function(x) x.SubFamilia = xSubfamilia.Text.ToDecimal())
        End If

        If xArticulo.Text.ToDecimal > 0 Then
            Articulos = Articulos.Where(Function(x) x.Articulo = xArticulo.Text.ToDecimal)
        End If

        If oSinCosto.Checked Then
            Articulos = Articulos.Where(Function(x) x.Costo <= 0)
        End If

        If oSinPrecioVenta.Checked Then
            Articulos = Articulos.Where(Function(x) x.PVenta <= 0)
        End If

        Dim ArticulosConsulta = New List(Of ArticuloPrecio)

        Dim MovDet = DC.T_MovDet.ToList()

        For Each art In Articulos.OrderBy(Function(x) x.Descripcion)

            Dim articulo = New ArticuloPrecio()
            ValidateObj(articulo)

            articulo.Articulo = art.Articulo
            articulo.SKU = art.SKU.Trim()
            articulo.Descripcion = art.Descripcion.Trim()

            articulo.Costo = art.Costo
            articulo.Margen = If(art.Costo = 0 Or art.PVenta = 0, 0, (((Math.Round(art.PVenta / (1 + (G_IVA / 100)), 0, MidpointRounding.AwayFromZero) / art.Costo) - 1) * 100).ToDecimal())
            articulo.PrecioVenta = art.PVenta
            articulo.Modificado = False

            Dim costo = CostosIngresos.FirstOrDefault(Function(x) x.Articulo = art.Articulo)
            If costo IsNot Nothing Then
                articulo.CostoMovimiento = costo.Costo
            End If

            articulo.Original = articulo.Clonar()

            ArticulosConsulta.Add(articulo)

        Next

        If oPendienteCosto.Checked Then
            ArticulosConsulta = ArticulosConsulta.Where(Function(x) x.CostoMovimiento > 0 And x.Costo <> x.CostoMovimiento).ToList
        End If

        sArticulos.DataSource = Nothing
        sArticulos.DataSource = ArticulosConsulta

        Cursor = Cursors.Arrow

    End Sub

    Const T_COSTO = 4
    Const T_MARGEN = 5
    Const T_PVENTA = 6

    Private Sub xTabla_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles xTabla.CellValidating
        If xTabla.EditingControl Is Nothing Then Return
        Dim val = xTabla.EditingControl.Text.ToDecimal()
        If val < 0 Then
            xTabla.EditingControl.Text = "0"
            e.Cancel = True
        End If
    End Sub

    Private Sub xTabla_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles xTabla.CellEndEdit
        Dim art = CType(xTabla.CurrentRow.DataBoundItem, ArticuloPrecio)
        If e.ColumnIndex = T_MARGEN Then
            art.PrecioVenta = (art.Costo * (1 + (art.Margen / 100)) * (1 + (G_IVA / 100))).ToDecimal(0)
        End If

        If e.ColumnIndex = T_PVENTA Then
            If art.PrecioVenta = 0 Then
                art.Margen = 0
            End If
            If art.Costo = 0 Then
                art.Margen = 0
            Else
                art.Margen = (((Math.Round(art.PrecioVenta / (1 + (G_IVA / 100)), 0, MidpointRounding.AwayFromZero) / art.Costo) - 1) * 100).ToDecimal()
            End If
        End If

        If e.ColumnIndex = T_COSTO Then
            If art.Costo = 0 Then
                art.Margen = 0
            Else
                If art.Margen = 0 Then
                    art.PrecioVenta = (art.Costo * (1 + (G_IVA / 100))).ToDecimal(0)
                Else
                    art.PrecioVenta = (art.Costo * (1 + (art.Margen / 100)) * (1 + (G_IVA / 100))).ToDecimal(0)
                End If
            End If
        End If

        art.PrecioVenta = RedondeoPeso(art.PrecioVenta)

        If art.PrecioVenta = art.Original.PrecioVenta And
           art.Margen = art.Original.Margen And
           art.Costo = art.Original.Costo Then
            art.Modificado = False
        Else
            art.Modificado = True
        End If

    End Sub

    Private Sub xTabla_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles xTabla.EditingControlShowing
        If {T_MARGEN, T_COSTO, T_PVENTA}.Contains(xTabla.CurrentCell.ColumnIndex) Then
            RemoveHandler e.Control.KeyPress, AddressOf xEditor_KeyPress
            AddHandler e.Control.KeyPress, AddressOf xEditor_KeyPress
        End If
    End Sub

    Private Sub xEditor_KeyPress(sender As Object, e As KeyPressEventArgs)
        ValidarDigitos(e)
    End Sub



    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

        If sArticulos.DataSource Is Nothing Then Exit Sub

        Dim articulos = CType(sArticulos.DataSource, List(Of ArticuloPrecio))
        If Not articulos.Any Then Exit Sub

        articulos = articulos.Where(Function(x) x.Modificado = True).ToList

        If (Not articulos.Any) Then
            Informacion("No se han modificado Artículos. No hay cambios para guardar", "Sin cambios")
            Exit Sub
        End If

        If Not Pregunta($"¿Desea actualizar los valores asociados a {articulos.Count} artículos?", "Confirmar") Then
            Exit Sub
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)

        Cursor = Cursors.WaitCursor

        Dim articulosModificados = 0

        For Each art In articulos
            Dim articulo = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = art.Articulo)
            If articulo Is Nothing Then Continue For
            articulo.Costo = art.Costo
            articulo.PVenta = art.PrecioVenta
            articulosModificados += 1
        Next

        DC.SubmitChanges()

        Cursor = Cursors.Arrow

        Mensaje($"Se han modificado {articulosModificados} artículos", "Modificación exitosa")
        Consultar()
    End Sub

    Private Sub xArticulo_Validating(sender As Object, e As CancelEventArgs) Handles xArticulo.Validating
        If xArticulo.ListaVisible Then
            If xArticulo.ListaActiva Then
                Exit Sub
            Else
                xArticulo.OcultarLista()
            End If
        End If

        If Trim(xArticulo.Text) = "" Then
            xDescripcion.Clear()
            xSKU.Clear()
            Exit Sub
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)

        If xArticulo.DescEncontrada = "" Then

            Dim wIDArticulo = ObtenerArticulo(xArticulo.Text)
            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wIDArticulo.ToDecimal())

            If wArt IsNot Nothing Then
                xArticulo.AutoCompletarActivo = False
                xArticulo.Text = wArt.Articulo.ToString()
                xDescripcion.Text = wArt.Descripcion
                xSKU.Text = wArt.SKU.ToString.Trim
                xArticulo.AutoCompletarActivo = True
                Exit Sub
            End If

            Informacion("Artículo no encontrado")
            xDescripcion.Clear()
            xArticulo.Clear()
            xArticulo.Focus()

        Else
            xArticulo.AutoCompletarActivo = False
            xDescripcion.Text = xArticulo.DescEncontrada

            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.IdEncontrado.ToDecimal())
            If wArt IsNot Nothing Then
                xSKU.Text = wArt.SKU.ToString.Trim
            End If
            xArticulo.AutoCompletarActivo = True

        End If

        If xDescripcion.Text <> "" Then
            cSubFamilia.SelectedIndex = -1
            cFamilia.SelectedIndex = -1
        End If

    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(xFamilia)
    End Sub


End Class

Public Class ArticuloPrecio
    Implements ICloneable

    Public Property Articulo As Decimal
    Public Property SKU As String
    Public Property Descripcion As String
    Public Property CostoMovimiento As Decimal
    Public Property Costo As Decimal
    Public Property Margen As Decimal
    Public Property PrecioVenta As Decimal
    Public Property Original As ArticuloPrecio
    Public Property Modificado As Boolean

    Public Function Clone() As Object Implements ICloneable.Clone
        Return Me.MemberwiseClone()
    End Function

    Public Function Clonar() As ArticuloPrecio
        Return CType(Clone(), ArticuloPrecio)
    End Function
End Class