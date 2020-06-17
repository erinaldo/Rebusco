Imports System.ComponentModel
Imports MarketONE

Public Class ConsultaArticulos
    Implements iFormulario
    Const T_ARTICULO As Integer = 0
    Const T_SKU As Integer = 1
    Const T_DESCRIPCION As Integer = 2
    Const T_UNIDAD As Integer = 3
    Const T_FAMILIA As Integer = 4
    Const T_BARRA As Integer = 5
    Const T_NOMBRECLIENTE As Integer = 6

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub ListadoArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cFamilia.LoadItemsObj("Familias", "Familia", "DescFamilia", "Order by DescFamilia")

        Dim wListaOrden As New List(Of ItemCombo)
        wListaOrden.Add(New ItemCombo With {.ID = "", .Desc = ""})
        wListaOrden.Add(New ItemCombo With {.ID = "0", .Desc = "Código"})
        wListaOrden.Add(New ItemCombo With {.ID = "1", .Desc = "Descripción"})
        wListaOrden.Add(New ItemCombo With {.ID = "2", .Desc = "Barra"})

        COrden.DisplayMember = "Desc"
        COrden.ValueMember = "ID"
        COrden.DataSource = wListaOrden

    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.NextControl(cFamilia)
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
            ''xArticulo.Text = xArticulo.IdEncontrado
            xDescripcion.Text = xArticulo.DescEncontrada
            xArticulo.AutoCompletarActivo = True
        End If
    End Sub

    Private Sub xArticulo_ItemSeleccionado(wDescripcion As String) Handles xArticulo.ItemSeleccionado
        xDescripcion.Text = wDescripcion
        cFamilia.Focus()
    End Sub

    Private Sub bBuscarA_Click(sender As Object, e As EventArgs) Handles bBuscarA.Click
        Dim wQuery As String
        wQuery = "SELECT Articulo ,Descripcion From Articulos"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Descripcion", Me, "Artículos", xArticulo)
    End Sub

    Private Sub Busqueda(wTipo As String)

        Cursor = Cursors.WaitCursor
        Dim DC = New RebuscoDataContext(P_CONEXION)

        Dim wArt = DC.T_Articulos().ToList

        If cFamilia.Text.Trim <> "" Then
            wArt = wArt.Where(Function(x) x.Familia = CInt(cFamilia.SelectedValue)).ToList
        End If

        If xArticulo.Text.Trim <> "" Then
            wArt = wArt.Where(Function(x) x.Articulo = xArticulo.Text.ToDecimal).ToList
        Else
            If COrden.Text = "Código" Then
                If oAsc.Checked Then
                    wArt = wArt.OrderBy(Function(x) x.Articulo).ToList
                Else
                    wArt = wArt.OrderByDescending(Function(x) x.Articulo).ToList
                End If
            End If
            If COrden.Text = "Descripción" Then
                If oAsc.Checked Then
                    wArt = wArt.OrderBy(Function(x) x.Descripcion).ToList
                Else
                    wArt = wArt.OrderByDescending(Function(x) x.Descripcion).ToList
                End If

            End If
            'If COrden.Text = "Barra" Then wArt = wArt.OrderBy(Function(x) x).ToList
            'If oSoloBarra.Checked Then wArt = wArt.Where(Function(x) x.Barra <> "").ToList
            If oSoloActivos.Checked Then wArt = wArt.Where(Function(x) x.ActivoFijo = True).ToList
        End If

        If wArt.Any Then
            Titulos()
            Dim wListaFamilias = DC.T_Familias().ToList
            Dim wListaUnidades = DC.T_Unidades().ToList
            Dim wListaClientes = DC.T_Parametros().ToList

            If wTipo = "C" Then
                xTabla.Redraw = False

                For Each wA In wArt
                    xTabla.AddItem("")
                    xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, wA.Articulo)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_SKU, wA.SKU)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wA.Descripcion)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_UNIDAD, wListaUnidades.FirstOrDefault(Function(x) x.Unidad = wA.Unidad).DescUnidad)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FAMILIA, wListaFamilias.FirstOrDefault(Function(x) x.Familia = wA.Familia).DescFamilia)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_NOMBRECLIENTE, wListaClientes.FirstOrDefault(Function(x) x.Cliente = wA.Cliente).Empresa)

                    DoEvents()
                Next

                xTabla.Redraw = True
            Else
                Dim wLista As New List(Of ArticulosReporte)

                For Each wA In wArt
                    wLista.Add(New ArticulosReporte With {.Articulos = wA.Articulo.ToString,
                                                         .Descripcion = wA.Descripcion,
                                                         .Unidad = wListaUnidades.FirstOrDefault(Function(x) x.Unidad = wA.Unidad).DescUnidad,
                                                         .Cliente = wListaClientes.FirstOrDefault(Function(x) x.Cliente = wA.Cliente).Empresa,
                                                         .Familia = wListaFamilias.FirstOrDefault(Function(x) x.Familia = wA.Familia).DescFamilia,
                                                         .SKU = wA.SKU})
                    DoEvents()
                Next

                Dim wReporte As New ReporteArticulos
                Dim wListaParametros = ParametroReporte()
                wReporte.Database.Tables("MarKetONE_ArticulosReporte").SetDataSource(wLista)
                wReporte.Database.Tables("MarKetONE_ParametrosReporte").SetDataSource(wListaParametros)
                VisorReportes.MostrarReporte(wReporte)
                VisorReportes.Show()
                VisorReportes.BringToFront()
            End If
        Else
            MsgError("No se encuentran datos para los filtros seleccionados")
        End If
        Cursor = Cursors.Default
    End Sub
    Sub Titulos()

        xTabla.Cols.Count = 7
        xTabla.Rows.Count = 1

        xTabla.Cols(T_ARTICULO).Width = 120
        xTabla.Cols(T_SKU).Width = 100
        xTabla.Cols(T_DESCRIPCION).Width = 515
        xTabla.Cols(T_FAMILIA).Width = 100
        xTabla.Cols(T_UNIDAD).Width = 100
        xTabla.Cols(T_BARRA).Width = 100
        xTabla.Cols(T_NOMBRECLIENTE).Width = 200

        xTabla.Cols(T_ARTICULO).Caption = "Artículos"
        xTabla.Cols(T_SKU).Caption = "SKU"
        xTabla.Cols(T_DESCRIPCION).Caption = "Descripción"
        xTabla.Cols(T_FAMILIA).Caption = "Familia"
        xTabla.Cols(T_UNIDAD).Caption = "Unidad"
        xTabla.Cols(T_BARRA).Caption = "Barra"
        xTabla.Cols(T_NOMBRECLIENTE).Caption = "Cliente"

        xTabla.Cols(T_ARTICULO).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        Busqueda("C")
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Busqueda("I")
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

End Class