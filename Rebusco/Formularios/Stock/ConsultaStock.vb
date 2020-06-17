Imports System.ComponentModel
Imports MarketONE



Public Class ConsultaStock
    Implements iFormulario

    Const T_STOCK = 2

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub
    Private Sub bBuscar_Click(sender As Object, e As EventArgs)
        Dim wQuery As String
        wQuery = "SELECT Articulo as 'Artículo', Descripcion as 'Descripción' From Articulos"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Descripcion", Me, "Artículos", xArticulo)
    End Sub

    Private Sub ModificarStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Titulos()
        cBodega.LoadItemsObj("Bodegas", "Bodega", "NombreBodega", " Order by NombreBodega")
        If cBodega.Items.Count = 2 Then
            cBodega.SelectedIndex = 1
        End If
        Auditoria(Me.Text, A_INGRESADO, "", "0")

        sStock.DataSource = New List(Of DatosStock)

    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(cBodega)
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
                ConsultarStock()
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
            ConsultarStock()
        End If
    End Sub

    Private Sub ConsultarStock(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bConsultar.Click

        sStock.DataSource = New List(Of DatosStock)

        If xArticulo.Text.Trim = "" Then
            MsgError("No ha ingresado artículo a consultar")
            xArticulo.Focus()
            Exit Sub
        End If
        If Not G_SUPERVISOR Then
            MsgError("No tiene permisos de Supervisor para visualizar el stock")
            Exit Sub
        End If

        Dim bodega = cBodega.SelectedValue.ToString.ToDecimal()

        Cursor = Cursors.WaitCursor
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim Bodegas = DC.T_Bodegas.Where(Function(x) x.Bodega > 0)
        If cBodega.Text.Trim <> "" Then
            Bodegas = Bodegas.Where(Function(x) x.Bodega = bodega)
        End If

        Dim locales = DC.T_Locales.ToList()

        Dim resultado = New List(Of DatosStock)

        For Each bod In Bodegas
            Dim stock = DC.T_Stocks.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.ToDecimal And
                                                         x.Bodega = bod.Bodega And
                                                         x.Local = bod.Local)
            If stock Is Nothing Then
                Stocks(xArticulo.Text.ToDecimal(), bod.Bodega, bod.Local, 0, ModoInventario.Crear)
                Tracking.Ingresar(Tracking.Eventos.StockCreado, Now, 0, "", 0, Now, xArticulo.Text.ToDecimal(), 0, bod.Bodega, bod.Local, "", Me.Text)
            End If


            Dim item = New DatosStock()
            item.Local = bod.Local
            item.Bodega = bod.Bodega
            item.NombreLocal = If(locales.FirstOrDefault(Function(x) x.Local = bod.Local)?.NombreLocal, "")
            item.NombreBodega = bod.NombreBodega
            item.Stock = If(stock Is Nothing, 0, stock.Stock)
            item.StockOriginal = item.Stock
            item.Modificado = False

            resultado.Add(item)

        Next

        sStock.DataSource = resultado

        xTabla.Focus()
        If sStock.Count > 0 Then
            xTabla.CurrentCell = xTabla.Rows(0).Cells(2)
        End If

        Cursor = Cursors.Arrow
        Auditoria(Text, "Consultar", "", "")
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        xArticulo.Focus()
        sStock.DataSource = New List(Of DatosStock)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub ActualizarStock(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bActualizar.Click

        Dim stock = CType(sStock.DataSource, List(Of DatosStock))
        If Not stock.Any Then Return

        If Not G_SUPERVISOR Then
            MsgError("Usuario sin autorización para modificar stocks", "Modificación denegada")
            Exit Sub
        End If

        If Not stock.Any(Function(x) x.Modificado) Then
            Informacion("No se han modificado valores de stock", "Sin modificación")
            Exit Sub
        End If

        If Not Pregunta("¿Desea modificar el stock?") Then Exit Sub

        For Each stk In stock

            If Not stk.Modificado Then Continue For

            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim stockArt = DC.T_Stocks.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.ToDecimal And
                                                              x.Local = stk.Local And
                                                              x.Bodega = stk.Bodega)

            If stock IsNot Nothing Then
                Stocks(stockArt.Articulo, stk.Bodega, stk.Local, stk.Stock, ModoInventario.Igualar)
                Tracking.Ingresar(Tracking.Eventos.StockEstablecido, Now, 0, "", 0, Now, stockArt.Articulo, stk.Stock, stk.Bodega, stk.Local, "", Me.Text)
            Else

                Stocks(stockArt.Articulo, stk.Bodega, stk.Local, stk.Stock, ModoInventario.Crear)
                Tracking.Ingresar(Tracking.Eventos.StockCreado, Now, 0, "", 0, Now, xArticulo.Text.ToDecimal(), stk.Stock, stk.Bodega, stk.Local, "", Me.Text)
            End If

        Next

        Mensaje($"Stock de artículo {xArticulo.Text} modificado correctamente", "Stock modificado")

        ConsultarStock()

        xArticulo.SelectAll()
        xArticulo.Focus()
        Cursor = Cursors.Arrow


    End Sub

    Private Sub xTablaStock_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles xTabla.CellEndEdit
        Dim stk = CType(xTabla.CurrentRow.DataBoundItem, DatosStock)
        If stk.Stock = stk.StockOriginal Then
            stk.Modificado = False
        Else
            stk.Modificado = True
        End If
    End Sub

    Private Sub xTabla_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles xTabla.CellValidating
        If xTabla.EditingControl Is Nothing Then Return
        Dim val = xTabla.EditingControl.Text.ToDecimal(2)
        If val < 0 Then
            xTabla.EditingControl.Text = "0"
            e.Cancel = True
        End If
    End Sub

    Private Sub xTabla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles xTabla.CellFormatting
        If xTabla.Rows.Count = 0 Or e.ColumnIndex > 0 Then Exit Sub
        Dim stk = CType(xTabla.Rows(e.RowIndex).DataBoundItem, DatosStock)
        If stk.Modificado Then
            xTabla.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 182)
        Else
            xTabla.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    Private Sub xTabla_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles xTabla.EditingControlShowing
        If {T_STOCK}.Contains(xTabla.CurrentCell.ColumnIndex) Then
            RemoveHandler e.Control.KeyPress, AddressOf xEditor_KeyPress
            AddHandler e.Control.KeyPress, AddressOf xEditor_KeyPress
        End If
    End Sub

    Private Sub xEditor_KeyPress(sender As Object, e As KeyPressEventArgs)
        ValidarDigitosDecimal(e)
    End Sub


    Private Sub xArticulo_ItemSeleccionado(wDescripcion As String) Handles xArticulo.ItemSeleccionado
        xDescripcion.Text = wDescripcion
        bConsultar.Focus()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.F5
                ActualizarStock()
        End Select
        Return False
    End Function
End Class

Public Class DatosStock
    <Browsable(False)>
    Public Property Local As Decimal
    <Browsable(False)>
    Public Property Bodega As Decimal
    <DisplayName("Local")>
    Public Property NombreLocal As String
    <DisplayName("Bodega")>
    Public Property NombreBodega As String
    Public Property Stock As Decimal
    <Browsable(False)>
    Public Property StockOriginal As Decimal
    Public Property Modificado As Boolean
End Class