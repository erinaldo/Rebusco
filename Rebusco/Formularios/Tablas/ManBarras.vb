Imports System.ComponentModel

Public Class ManBarras
    Private Sub xArticulo_ItemSeleccionado(wDescripcion As String) Handles xArticulo.ItemSeleccionado
        xSKU.Focus()
    End Sub
    Public Sub xArticulo_Validating(Optional sender As Object = Nothing, Optional e As System.ComponentModel.CancelEventArgs = Nothing) Handles xArticulo.Validating
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wEncontrado As Boolean = False
        If xArticulo.ListaVisible Then
            If xArticulo.ListaActiva Then
                Exit Sub
            Else
                xArticulo.OcultarLista()
            End If
        End If

        If Trim(xArticulo.Text) = "" Then
            xDescripcion.Clear()
            Exit Sub
        End If

        Dim wArticulo = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.Trim.ToDecimal)
        If xArticulo.DescEncontrada = "" Then
            If wArticulo IsNot Nothing Then
                wEncontrado = True
            Else
                wEncontrado = False
            End If
        Else
            wEncontrado = True
        End If

        If wEncontrado Then
            xArticulo.Text = wArticulo.Articulo.ToString
            xDescripcion.Text = wArticulo.Descripcion
            xSKU.Text = wArticulo.SKU
            CargarBarras()
        Else
            LimpiarCampos(Me, "xArticulo")
        End If

    End Sub
    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(xBarra)
    End Sub
    Private Sub CargarBarras()
        If xArticulo.Text <> "" Then
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wListaBarra As New List(Of BarraArticulo)
            Dim wBarras = DC.T_Barras.Where(Function(x) x.Articulo = xArticulo.Text.ToDecimal)
            If wBarras.Any Then
                For Each wB In wBarras
                    Dim wBarra = New BarraArticulo With
                        {
                            .Eliminar = My.Resources.remove_table,
                            .Articulo = xArticulo.Text.ToDecimal,
                            .Barra = wB.Barra,
                            .Unidades = wB.Unidades
                        }
                    wListaBarra.Add(wBarra)
                Next
                BarraArticuloBindingSource.Load(wListaBarra)
                xCantidadBarras.Text = wListaBarra.Count.ToString()
            End If
        End If
    End Sub

    Private Sub bAgregar_Click(sender As Object, e As EventArgs) Handles bAgregar.Click
        If xArticulo.Text.Trim = "" Then
            MsgError("Debe indicar artículo")
            xArticulo.Focus()
            Exit Sub
        End If
        If xBarra.Text.Trim = "" Then
            MsgError("Debe indicar código de barra")
            xBarra.Focus()
            Exit Sub
        End If
        If xUnidades.Text.Trim = "" Then
            MsgError("Debe indicar cantidad de unidades a la barra")
            xUnidades.Focus()
            Exit Sub
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wListaBarra = New List(Of BarraArticulo)
        If xTabla.Rows.Count > 0 Then wListaBarra = CType(BarraArticuloBindingSource.DataSource, List(Of BarraArticulo))

        Dim validarBarra = DC.T_Barras.FirstOrDefault(Function(x) x.Barra = xBarra.Text.Trim)
        If validarBarra IsNot Nothing Then
            MsgError("El número de barra ingresado ya existe para un artículo")
            Exit Sub
        End If

        Dim wBarra = New BarraArticulo With
            {
                .Eliminar = My.Resources.remove_table,
                .Articulo = xArticulo.Text.ToDecimal,
                .Barra = xBarra.Text.Trim,
                .Unidades = xUnidades.Text.ToDecimal
            }
        wListaBarra.Add(wBarra)
        BarraArticuloBindingSource.Load(wListaBarra)
        xBarra.Clear()
        xUnidades.Clear()
        xBarra.Focus()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        xArticulo.Clear()
        xSKU.Clear()
        xDescripcion.Clear()
        xCantidadBarras.Clear()
        xBarra.Clear()
        xUnidades.Clear()
        BarraArticuloBindingSource.DataSource = Nothing
        xArticulo.Focus()
    End Sub

    Private Sub xTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles xTabla.CellContentClick
        If e.RowIndex = -1 Then Exit Sub
        If e.ColumnIndex = 0 Then
            xTabla.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If xTabla.Rows.Count = 0 Then
            MsgError("Debe ingresar barras al articulo")
            Exit Sub
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wBarrasArticulo = DC.T_Barras.Where(Function(x) x.Articulo = xArticulo.Text.ToDecimal)
        If wBarrasArticulo.Any() Then
            DC.T_Barras.DeleteAllOnSubmit(wBarrasArticulo)
            DC.SubmitChanges()
        End If

        Dim wListaBarras = New List(Of BarraArticulo)
        wListaBarras = CType(BarraArticuloBindingSource.DataSource, List(Of BarraArticulo))
        For Each wBarra In wListaBarras
            Dim wBarraNueva = New T_Barras With {.Articulo = wBarra.Articulo, .Barra = wBarra.Barra, .Unidades = wBarra.Unidades}
            DC.T_Barras.InsertOnSubmit(wBarraNueva)
        Next
        DC.SubmitChanges()
        Mensaje("Barras guardadas correctamente")
    End Sub

    Private Sub xBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBarra.KeyPress
        e.NextControl(xUnidades)
    End Sub

    Private Sub xUnidades_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xUnidades.KeyPress
        If xUnidades.Text = "" Then Exit Sub
        e.NextControl(bAgregar)
    End Sub

    Private Sub xUnidades_TextChanged(sender As Object, e As EventArgs) Handles xUnidades.TextChanged

    End Sub
End Class
Public Class BarraArticulo
    <DisplayName("Eliminar")>
    <Browsable(True)>
    Public Property Eliminar As Image

    <DisplayName("Artículo")>
    <Browsable(False)>
    Public Property Articulo As Decimal

    <DisplayName("Barra")>
    <Browsable(True)>
    Public Property Barra As String

    <DisplayName("Unidades")>
    <Browsable(True)>
    Public Property Unidades As Decimal
End Class