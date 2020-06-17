Imports System.ComponentModel

Public Class BuscadorArticulo
    Public G_FORMULARIO As iFormulario
    Public G_CONTROL As Control
    Public G_QUERY As String
    Public G_INDICE As String
    Public G_BODEGAS As New List(Of ColumnasBodega)
    Public G_CONSULTAR As Boolean
    Sub New()
        InitializeComponent()
    End Sub
    Sub New(wConsultar As Boolean)
        InitializeComponent()
        G_CONSULTAR = wConsultar
        cFamilia.LoadItemsObj("Familias", "Familia", "DescFamilia")
    End Sub

    Public Sub Configurar(wFormulario As iFormulario, wControl As Control)
        G_FORMULARIO = wFormulario
        G_CONTROL = wControl
        cFamilia.LoadItemsObj("Familias", "Familia", "DescFamilia")
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click

        Cursor = Cursors.WaitCursor
        bBuscar.Enabled = False
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wListadoGeneral = DC.T_BusquedaArticulo.ToList()
        Dim wStocks = wListadoGeneral
        Dim wLocales = DC.T_Locales.ToList()
        If cFamilia.Text <> "" Then wStocks = wStocks.Where(Function(x) x.Familia = cFamilia.SelectedValue.ToString.ToDecimal).ToList()

        wStocks = wStocks.Where(Function(x) x.Articulo.ToString.Contains(xBuscar.Text.Trim) Or
                                            x.Descripcion.ToUpper.Contains(xBuscar.Text.ToUpper.Trim) Or
                                            x.SKU.Contains(xBuscar.Text.Trim)).ToList()

        If Not wStocks.Any And xBuscar.Text.Trim <> "" Then
            Dim wBarra = DC.T_Barras.FirstOrDefault(Function(x) x.Barra = xBuscar.Text.Trim)
            If wBarra IsNot Nothing Then
                wStocks = wListadoGeneral.Where(Function(x) x.Articulo = wBarra.Articulo).ToList()
            End If
        End If

        If wStocks.Any Then
            Dim datatable = New DataTable()
            Dim column = New DataColumn()
            Dim listalocal = DC.T_Locales.ToList
            Dim listaarticulo = DC.T_Articulos.ToList()
            column = New DataColumn("Artículo")
            datatable.Columns.Add(column)
            column = New DataColumn("SKU")
            datatable.Columns.Add(column)
            column = New DataColumn("Descripción")
            datatable.Columns.Add(column)
            column = New DataColumn("PVenta")
            datatable.Columns.Add(column)

            For Each local In wLocales
                column = New DataColumn With {.ColumnName = local.NombreLocal, .DefaultValue = 0}
                datatable.Columns.Add(column)
            Next

            For Each art In wStocks.GroupBy(Function(x) x.Articulo)
                Dim datarow As DataRow = datatable.NewRow

                datarow("Artículo") = art.First().Articulo
                datarow("Descripción") = art.First().Descripcion
                datarow("SKU") = art.First().SKU
                datarow("PVenta") = art.First().PVenta

                For Each stock In art
                    Dim wNombreLocal = wLocales.FirstOrDefault(Function(x) x.Local = stock.Local)
                    If wNombreLocal IsNot Nothing Then
                        datarow(wNombreLocal.NombreLocal) = stock.Stock
                    End If
                Next

                datatable.Rows.Add(datarow)
            Next

            xTabla.DataSource = datatable
            xTabla.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            xTabla.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            xTabla.Columns(2).Width = 400
            xTabla.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            For i = 3 To xTabla.Columns.Count - 1
                xTabla.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        End If
        xTabla.Focus()
        Cursor = Cursors.Default
        bBuscar.Enabled = True

    End Sub

    Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs) Handles xTabla.DoubleClick
        If G_CONSULTAR Then Exit Sub
        If xTabla.Rows.Count > 0 Then
            G_FORMULARIO.CargarRegistro(G_CONTROL, xTabla.CurrentRow.Cells.Item(0).Value.ToString)
            Close()
        End If
    End Sub



    Private Sub xTabla_MouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles xTabla.CellMouseDown
        If e.Button = MouseButtons.Right And e.RowIndex > -1 Then
            Dim xTabla = DirectCast(sender, DataGridView)
            xTabla.CurrentCell = xTabla.Item(e.ColumnIndex, e.RowIndex)
            MostrarMenuCopiar(xTabla, e.Location, mMenuTabla, bCopiar)
        End If
    End Sub
    Public Sub MostrarMenuCopiar(ByRef xTabla As DataGridView, ByRef wUbicacion As Point, ByRef mMenu As ContextMenuStrip, ByRef bCopiar As ToolStripMenuItem)
        Dim wData As String = ""

        If xTabla.Rows.Count < 1 Then Exit Sub
        If xTabla.CurrentCell.Value Is Nothing Then
            wData = ""
        Else
            wData = xTabla.CurrentCell.Value.ToString
            If wData = "True" Or wData = "False" Then
                wData = ""
            End If
        End If

        If wData <> "" Then
            bCopiar.Text = "Copiar " & wData.Trim.Substring(0, If(wData.Length > 22, 22, wData.Length))
            bCopiar.Tag = wData.Trim
            mMenu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub xBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBuscar.KeyPress
        e.NextControl(bBuscar)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub xTabla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTabla.KeyPress

    End Sub

    Private Sub xTabla_KeyDown(sender As Object, e As KeyEventArgs) Handles xTabla.KeyDown
        If xTabla.Rows.Count = 0 Then Exit Sub
        If G_CONSULTAR Then Exit Sub
        If e.KeyCode = Keys.Enter AndAlso xTabla.Rows.Count > 1 Then
            G_FORMULARIO.CargarRegistro(G_CONTROL, xTabla.CurrentRow.Cells.Item(0).Value.ToString)
            Close()
        End If
    End Sub
End Class
Public Class StockArticulos
    <DisplayName("Artículo")>
    <Browsable(True)>
    Public Property Articulo As Decimal

    <DisplayName("SKU")>
    <Browsable(True)>
    Public Property SKU As String

    <DisplayName("Descripción")>
    <Browsable(True)>
    Public Property Descripcion As String

    <DisplayName("Precio")>
    <Browsable(True)>
    Public Property PVenta As Decimal
End Class
Public Class ColumnasBodega
    Public Property Columna As Integer
    Public Property Bodega As Decimal
    Public Property NombreBodega As String
End Class