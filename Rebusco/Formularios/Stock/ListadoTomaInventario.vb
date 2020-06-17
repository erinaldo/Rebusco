Public Class ListadoTomaInventario
    Private Sub ListadoTomaInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal", " ORDER BY Local")
        cBodega.LoadItemsObj("Bodegas", "Bodega", "NombreBodega", " ORDER BY Bodega")
        cFamilia.LoadItemsObj("Familias", "Familia", "DescFamilia", " ORDER BY DescFamilia")

        cOrdenar.SelectedIndex = 0
        Auditoria(Me.Text, A_INGRESADO, "", "0")
    End Sub

    Private Sub cFamilia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cFamilia.SelectedIndexChanged
        cOrdenar.Focus()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        rAsc.Checked = True
        cFamilia.Focus()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Dim wFiltros = ""
        Dim wQuery = ""

        If cLocal.Text.Trim = "" Then
            MsgError("No se puede sacar informe de todos los locales, debe especificar al menos un local")
            Exit Sub
        End If
        If cBodega.Text.Trim = "" Then
            MsgError("No se puede sacar informe de todas las bodegas, debe especificar al menos una bodega")
            Exit Sub
        End If

        Dim wBod = SQL("SELECT Bodega From Bodegas WHERE Local = " & cLocal.SelectedValue.ToString & " and Bodega = " & cBodega.SelectedValue.ToString).Top
        If wBod Is Nothing Then
            MsgError("Bodega no pertence al local seleccioando")
            Exit Sub
        End If


        Cursor = Cursors.WaitCursor
        wFiltros = " Where a.Articulo = s.Articulo and s.local = " + cLocal.SelectedValue.ToString + " and s.bodega=" + cBodega.SelectedValue.ToString
        If cFamilia.Text.Trim <> "" Then
            wFiltros += " and A.Familia = '" & cFamilia.SelectedValue.ToString & "'"
        End If

        If oExistencia.Checked Then
            wFiltros += " and S.Stock > 0 "
        End If

        'wFiltros = wFiltros & " Order by Familia,SubFamilia"
        If cOrdenar.Text.Trim <> "" Then
            If rAsc.Checked Then
                If cOrdenar.Text = "Artículo" Then wFiltros += " ORDER BY A.Articulo ASC"
                If cOrdenar.Text = "Descripción" Then wFiltros += " ORDER BY A.Descripcion ASC"
                If cOrdenar.Text = "Barra" Then wFiltros += " ORDER BY B.Barra ASC"
                If cOrdenar.Text = "Familia/SubFamilia" Then wFiltros += " ORDER BY A.Familia, A.SubFamilia ASC"
            Else
                If cOrdenar.Text = "Artículo" Then wFiltros += " ORDER BY A.Articulo DESC"
                If cOrdenar.Text = "Descripción" Then wFiltros += " ORDER BY A.Descripcion DESC"
                If cOrdenar.Text = "Barra" Then wFiltros += " ORDER BY B.Barra DESC"
                If cOrdenar.Text = "Familia/SubFamilia" Then wFiltros += " ORDER BY A.Familia DESC, A.SubFamilia DESC"
            End If
        End If

        Dim wArts = SQL("SELECT A.Articulo, A.Descripcion, A.SKU, S.Stock FROM Articulos as A, Stocks as S " & wFiltros)

        Dim wLista = New List(Of TomaInventarioReporte)
        For Each wArt As DataRow In wArts.Rows
            wLista.Add(New TomaInventarioReporte With {.Articulo = wArt.GetText("Articulo"),
                                                      .Descripcion = wArt.GetText("Descripcion"),
                                                      .SKU = wArt.GetText("SKU"),
                                                      .Stock = wArt.GetDecimal("Stock")})
        Next

        If wLista.Count > 0 Then
            Dim wReporte As New ReporteTomaInventario
            Dim wParametros = ParametroReporte()
            wReporte.Database.Tables("MarketONE_TomaInventarioReporte").SetDataSource(wLista)
            wReporte.Database.Tables("MarketONE_ParametrosReporte").SetDataSource(wParametros)
            VisorReportes.MostrarReporte(wReporte)
            VisorReportes.WinDeco1.TituloVentana = "Listado Toma de Inventario"
            VisorReportes.Show()
            Auditoria(Me.Text, A_IMPRESO, "", "0")
        Else
            Cursor = Cursors.Arrow
            MsgError("No se encuentran datos para la selección indicada")
            Close()
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub
End Class
Public Class TomaInventarioReporte
    Public Property Articulo As String
    Public Property Descripcion As String
    Public Property Barra As String
    Public Property SKU As String
    Public Property Stock As Double
End Class