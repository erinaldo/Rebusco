Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports MarketONE
Imports OfficeOpenXml


Public Class ListadoStock
    Implements iFormulario
    Public G_BODEGAS As New List(Of LocalesStocks)
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub
    Private Sub ListadoStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocalBodega.LoadItemsObj("Locales", "Local", "NombreLocal", " ORDER BY Local")
        cFamilia.LoadItemsObj("Familias", "Familia", "DescFamilia", " ORDER BY Familia")

        cOrdenar.SelectedIndex = 0
        Auditoria(Text, A_INGRESADO, "", "")
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(cOrdenar)
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
            Exit Sub
        End If

        If xArticulo.DescEncontrada = "" Then
            Dim wIDArticulo = ObtenerArticulo(xArticulo.Text)
            Dim DC = New RebuscoDataContext(P_CONEXION)
            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wIDArticulo.ToDecimal())
            If wArt IsNot Nothing Then
                xArticulo.AutoCompletarActivo = False
                xArticulo.Text = wArt.Articulo.ToString()
                xDescripcion.Text = wArt.Descripcion
                xArticulo.AutoCompletarActivo = True
                Exit Sub
            End If

            'Dim wSer = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.ToDecimal)
            'If wSer IsNot Nothing Then
            '    xDescripcion.Text = wSer.Descripcion
            '    Exit Sub
            'End If
            Informacion("Artículo no encontrado")
            xDescripcion.Clear()
            xArticulo.Clear()
            xArticulo.Focus()
        Else
            xArticulo.AutoCompletarActivo = False
            'xArticulo.Text = xArticulo.IdEncontrado
            xDescripcion.Text = xArticulo.DescEncontrada
            xArticulo.AutoCompletarActivo = True
        End If
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Dim wBuscador = New BuscadorArticulo
        wBuscador.Configurar(Me, xArticulo)
        wBuscador.ShowDialog()
    End Sub
    Sub Limpiar()
        LimpiarCampos(Me)
        rAsc.Checked = True
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        Limpiar()
        xArticulo.Focus()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Dim wFiltro = ""
        Dim wQuery = ""
        Cursor = Cursors.WaitCursor
        If xArticulo.Text.Trim <> "" Then
            wFiltro += If(wFiltro = "", " WHERE ", " AND ") & "A.Articulo = '" & xArticulo.Text.Trim & "'"
        End If

        If cLocalBodega.Text.Trim <> "" Then
            If oLocal.Checked Then
                wFiltro += If(wFiltro = "", " WHERE ", " AND ") & "S.Local = '" & cLocalBodega.SelectedValue.ToString & "'"
            Else
                wFiltro += If(wFiltro = "", " WHERE ", " AND ") & "S.Bodega = '" & cLocalBodega.SelectedValue.ToString & "'"
            End If
        End If


        If rAsc.Checked Then
            If cOrdenar.Text <> W_SELECCIONAR Then
                If cOrdenar.Text = "Artículo" Then wFiltro += " ORDER BY A.Articulo ASC"
                If cOrdenar.Text = "Descripción" Then wFiltro += " ORDER BY A.Descripcion ASC"
            End If
        Else
            If cOrdenar.Text <> W_SELECCIONAR Then
                If cOrdenar.Text = "Artículo" Then wFiltro += " ORDER BY A.Articulo DESC"
                If cOrdenar.Text = "Descripción" Then wFiltro += " ORDER BY A.Descripcion DESC"
            End If
        End If

        Dim wStocks = SQL("SELECT A.Articulo, A.Descripcion,S.Stock, L.Local,L.NombreLocal, B.Bodega,B.NombreBodega From Articulos A" &
                 " JOIN Stocks S ON A.Articulo = S.Articulo" &
                 " JOIN Locales L On S.Local = L.Local" &
                 " JOIN Bodegas B ON S.Bodega = B.Bodega " & wFiltro)



        Dim Lista = New List(Of StockReporte)
        For Each wStock As DataRow In wStocks.Rows
            Lista.Add(New StockReporte With {.Local = wStock.GetInt("Local"),
                                             .NombreLocal = wStock.GetText("NombreLocal"),
                                             .Bodega = wStock.GetInt("Bodega"),
                                             .NombreBodega = wStock.GetText("NombreBodega"),
                                             .Articulo = wStock.GetText("Articulo"),
                                             .Descripcion = wStock.GetText("Descripcion"),
                                             .Stock = wStock.GetNum("Stock")})
        Next

        If Lista.Count > 0 Then
            Dim wReporte As New ReporteStocks
            Dim wParamtros = ParametroReporte()
            wReporte.Database.Tables(0).SetDataSource(Lista)
            wReporte.Database.Tables(1).SetDataSource(wParamtros)
            VisorReportes.MostrarReporte(wReporte)
            VisorReportes.WinDeco1.TituloVentana = "Listado de Stock"
            VisorReportes.Show()
            Auditoria(Text, A_IMPRESO, "", "")
        Else
            MsgError("No se encuentran datos para la selección indicada")
            Close()
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        If oLocal.Checked Then
            ConsultarPorLocal()
        Else
            ConsultaPorBodega()
        End If

    End Sub
    Private Sub ConsultarPorLocal()
        Cursor = Cursors.WaitCursor
        bConsultar.Enabled = False
        Dim DC = New RebuscoDataContext(P_CONEXION)

        Dim wStocks = DC.T_ListadoStockLocal.ToList()
        Dim wLocales = DC.T_Locales.ToList()
        If cLocalBodega.Text <> "" Then
            wStocks = wStocks.Where(Function(x) x.Local = cLocalBodega.SelectedValue.ToString.ToDecimal).ToList()
            wLocales = wLocales.Where(Function(x) x.Local = cLocalBodega.SelectedValue.ToString.ToDecimal()).ToList()
        End If

        If Not oStockPositivo.Checked Then wStocks = wStocks.Where(Function(x) x.Stock <= 0).ToList()
        If Not oStockNegativo.Checked Then wStocks = wStocks.Where(Function(x) x.Stock >= 0).ToList()
        If Not oStockCero.Checked Then wStocks = wStocks.Where(Function(x) x.Stock <> 0).ToList()
        If cFamilia.Text <> "" Then wStocks = wStocks.Where(Function(x) x.Familia = cFamilia.SelectedValue.ToString.ToDecimal()).ToList()
        If cSubFamilia.Text <> "" Then wStocks = wStocks.Where(Function(x) x.SubFamilia = cSubFamilia.SelectedValue.ToString.ToDecimal()).ToList()

        If oBajoStockMinimo.Checked Then wStocks = wStocks.Where(Function(x) x.Stock < x.StockMin).ToList()

        If xArticulo.Text.Trim <> "" Then wStocks = wStocks.Where(Function(x) x.Articulo = xArticulo.Text.ToDecimal).ToList()

        If rAsc.Checked Then
            If cOrdenar.Text.Trim <> "" Then
                If cOrdenar.Text.Trim = "Artículo" Then wStocks = wStocks.OrderBy(Function(x) x.Articulo).ToList()
                If cOrdenar.Text.Trim = "Descripción" Then wStocks = wStocks.OrderBy(Function(x) x.Descripcion).ToList()
                If cOrdenar.Text.Trim = "SKU" Then wStocks = wStocks.OrderBy(Function(x) x.SKU).ToList()
            End If
        Else
            If cOrdenar.Text.Trim <> "" Then
                If cOrdenar.Text.Trim = "Artículo" Then wStocks = wStocks.OrderByDescending(Function(x) x.Articulo).ToList()
                If cOrdenar.Text.Trim = "Descripción" Then wStocks = wStocks.OrderByDescending(Function(x) x.Descripcion).ToList()
                If cOrdenar.Text.Trim = "SKU" Then wStocks = wStocks.OrderByDescending(Function(x) x.SKU).ToList()
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
            column = New DataColumn("Costo")
            datatable.Columns.Add(column)
            column = New DataColumn("PVenta")
            datatable.Columns.Add(column)
            column = New DataColumn("Valorización")
            datatable.Columns.Add(column)

            For Each local In wLocales
                column = New DataColumn With {.ColumnName = local.NombreLocal, .DefaultValue = 0}
                datatable.Columns.Add(column)
            Next

            For Each art In wStocks.GroupBy(Function(x) x.Articulo)
                Dim datarow As DataRow = datatable.NewRow

                datarow("Artículo") = art.First().Articulo
                datarow("Descripción") = art.First().Descripcion
                datarow("SKU") = art.First().SKU.Replace("-", "~")
                datarow("Costo") = art.First().Costo
                datarow("PVenta") = art.First().PVenta
                datarow("Valorización") = art.First().Costo * art.Sum(Function(x) x.Stock)

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
            xTabla.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            xTabla.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            For i = 6 To xTabla.Columns.Count - 1
                xTabla.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            If Not F_VERVALORIZACION Then
                xTabla.Columns(3).Visible = False
                xTabla.Columns(4).Visible = False
                xTabla.Columns(5).Visible = False
            End If
        Else
            MsgError("No se encuentra Artículos con los filtros indicados")
            xTabla.DataSource = Nothing
        End If

        Cursor = Cursors.Default
        bConsultar.Enabled = True
    End Sub
    Private Sub ConsultaPorBodega()

        Cursor = Cursors.WaitCursor
        bConsultar.Enabled = False
        Dim DC = New RebuscoDataContext(P_CONEXION)

        Dim wStocks = DC.T_ListadoStockBodega.ToList()
        Dim wBodegas = DC.T_Bodegas.ToList()
        If cLocalBodega.Text <> "" Then
            wStocks = wStocks.Where(Function(x) x.Bodega = cLocalBodega.SelectedValue.ToString.ToDecimal).ToList()
            wBodegas = wBodegas.Where(Function(x) x.Bodega = cLocalBodega.SelectedValue.ToString.ToDecimal()).ToList()
        End If

        If Not oStockPositivo.Checked Then wStocks = wStocks.Where(Function(x) x.Stock <= 0).ToList()
        If Not oStockNegativo.Checked Then wStocks = wStocks.Where(Function(x) x.Stock >= 0).ToList()
        If Not oStockCero.Checked Then wStocks = wStocks.Where(Function(x) x.Stock <> 0).ToList()

        If cFamilia.Text <> "" Then wStocks = wStocks.Where(Function(x) x.Familia = cFamilia.SelectedValue.ToString.ToDecimal()).ToList()
        If cSubFamilia.Text <> "" Then wStocks = wStocks.Where(Function(x) x.SubFamilia = cSubFamilia.SelectedValue.ToString.ToDecimal()).ToList()

        If oBajoStockMinimo.Checked Then wStocks = wStocks.Where(Function(x) x.Stock < x.StockMin).ToList()

        If xArticulo.Text.Trim <> "" Then wStocks = wStocks.Where(Function(x) x.Articulo = xArticulo.Text.ToDecimal).ToList()

        If rAsc.Checked Then
            If cOrdenar.Text.Trim <> "" Then
                If cOrdenar.Text.Trim = "Artículo" Then wStocks = wStocks.OrderBy(Function(x) x.Articulo).ToList()
                If cOrdenar.Text.Trim = "Descripción" Then wStocks = wStocks.OrderBy(Function(x) x.Descripcion).ToList()
                If cOrdenar.Text.Trim = "SKU" Then wStocks = wStocks.OrderBy(Function(x) x.SKU).ToList()
            End If
        Else
            If cOrdenar.Text.Trim <> "" Then
                If cOrdenar.Text.Trim = "Artículo" Then wStocks = wStocks.OrderByDescending(Function(x) x.Articulo).ToList()
                If cOrdenar.Text.Trim = "Descripción" Then wStocks = wStocks.OrderByDescending(Function(x) x.Descripcion).ToList()
                If cOrdenar.Text.Trim = "SKU" Then wStocks = wStocks.OrderByDescending(Function(x) x.SKU).ToList()
            End If
        End If

        If wStocks.Any Then
            Dim datatable = New DataTable()
            Dim column = New DataColumn()
            Dim listalocal = DC.T_Bodegas.ToList
            Dim listaarticulo = DC.T_Articulos.ToList()
            column = New DataColumn("Artículo")
            datatable.Columns.Add(column)
            column = New DataColumn("SKU")
            datatable.Columns.Add(column)
            column = New DataColumn("Descripción")
            datatable.Columns.Add(column)
            column = New DataColumn("Costo")
            datatable.Columns.Add(column)
            column = New DataColumn("PVenta")
            datatable.Columns.Add(column)
            column = New DataColumn("Valorización")
            datatable.Columns.Add(column)

            For Each local In wBodegas
                column = New DataColumn With {.ColumnName = local.NombreBodega, .DefaultValue = 0}
                datatable.Columns.Add(column)
            Next

            For Each art In wStocks.GroupBy(Function(x) x.Articulo)
                Dim datarow As DataRow = datatable.NewRow

                datarow("Artículo") = art.First().Articulo
                datarow("Descripción") = art.First().Descripcion
                datarow("SKU") = art.First().SKU
                datarow("PVenta") = art.First().PVenta
                datarow("Costo") = art.First().Costo
                datarow("Valorización") = art.First().PVenta * art.Sum(Function(x) x.Stock)

                For Each stock In art
                    Dim wNombreBodega = wBodegas.FirstOrDefault(Function(x) x.Local = stock.Bodega)
                    If wNombreBodega IsNot Nothing Then
                        datarow(wNombreBodega.NombreBodega) = stock.Stock
                    End If
                Next
                datatable.Rows.Add(datarow)
            Next
            xTabla.DataSource = datatable
            xTabla.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            xTabla.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            xTabla.Columns(2).Width = 400
            xTabla.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            xTabla.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            For i = 5 To xTabla.Columns.Count - 1
                xTabla.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        End If
        If Not F_VERVALORIZACION Then
            xTabla.Columns(3).Visible = False
            xTabla.Columns(4).Visible = False
            xTabla.Columns(5).Visible = False
        End If
        Cursor = Cursors.Default
        bConsultar.Enabled = True
    End Sub
    Private Sub oBajoStockMinimo_CheckedChanged(sender As Object, e As EventArgs) Handles oBajoStockMinimo.CheckedChanged
        If Not oStockCero.Checked And Not oStockNegativo.Checked And Not oStockPositivo.Checked Then
            MsgError("Para ver el inventario mínimo debe tener seleccionado alguna de las opciones:" & vbCrLf &
                   "Stock Positivo" & vbCrLf &
                   "Stock Negativo" & vbCrLf &
                   "Stock Cero")
            oBajoStockMinimo.Checked = False
        End If
    End Sub

    Private Sub oLocal_CheckedChanged(sender As Object, e As EventArgs) Handles oLocal.CheckedChanged
        cLocalBodega.LoadItemsObj("Locales", "Local", "NombreLocal", " ORDER BY NombreLocal")
    End Sub

    Private Sub oBodega_CheckedChanged(sender As Object, e As EventArgs) Handles oBodega.CheckedChanged
        cLocalBodega.LoadItemsObj("Bodegas", "Bodega", "NombreBodega", " ORDER BY NombreBodega")
    End Sub

    Private Sub cFamilia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cFamilia.SelectedIndexChanged
        If cFamilia.Text <> "" Then
            cSubFamilia.LoadItemsObj("SubFamilias", "SubFamilia", "DescSubFamilia", " WHERE Familia = " & cFamilia.SelectedValue.ToString.ToDecimal)
        End If
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        exportCSV("Listado de Stock.csv")
    End Sub

    Private Sub exportCSV(ByRef sExportFileName As String)
        Dim filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, sExportFileName)
        If xTabla.Rows.Count = 0 Then MsgError("No hay datos para exportar") : Exit Sub
        Cursor = Cursors.WaitCursor
        Dim wSeparador As String = ";"
        Dim wConstructorString As New StringBuilder

        For wFilas As Integer = 0 To xTabla.Rows.Count - 1
            Dim wArrayFila As String() = New String(xTabla.Columns.Count - 1) {}
            If wFilas.Equals(0) Then
                For wTitulosColumna As Integer = 0 To xTabla.Columns.Count - 1
                    wArrayFila(wTitulosColumna) = xTabla.Columns(wTitulosColumna).HeaderText
                Next
                wConstructorString.AppendLine(String.Join(wSeparador, wArrayFila))
            End If
            For wColumnas As Integer = 0 To xTabla.Columns.Count - 1
                If Not xTabla.Rows(wFilas).IsNewRow Then
                    wArrayFila(wColumnas) = If(xTabla(wColumnas, wFilas).Value.ToString(), "")
                    'If (IsNothing(xTabla(wColumnas, wFilas).Value), "", xTabla(wColumnas, wFilas).Value.ToString) Then
                End If
            Next
            If Not xTabla.Rows(wFilas).IsNewRow Then
                wConstructorString.AppendLine(String.Join(wSeparador, wArrayFila))
            End If
        Next
        Try
            File.WriteAllText(filePath, wConstructorString.ToString, Encoding.UTF8)
            If Pregunta("¿Deseas abrir el archivo exportado?") Then Process.Start(filePath)
        Catch ex As Exception
            MsgError("Error al crear archivo: " & vbCrLf & filePath)
        End Try

        Cursor = Cursors.Default

    End Sub

    Private Sub xArticulo_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
Public Class StockConsulta
    <DisplayName("Artículo")>
    <Browsable(True)>
    Public Property Articulo As Decimal

    <DisplayName("SKU")>
    <Browsable(True)>
    Public Property SKU As String

    <DisplayName("Descripción")>
    <Browsable(True)>
    Public Property Descripcion As String

    <DisplayName("Costo")>
    <Browsable(True)>
    Public Property Costo As Decimal

    <DisplayName("Valorización")>
    <Browsable(True)>
    Public Property Valorizacion As Decimal
End Class
Public Class LocalesStocks
    Public Property Columna As Integer
    Public Property Local As Decimal
    Public Property NombreLocal As String
End Class