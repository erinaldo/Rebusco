Imports System.ComponentModel

Public Class ConsultaPrecios
    Implements iFormulario
    Const T_ARTICULO = 0
    Const T_DESCRIPCION = 1
    Const T_MAYORISTA = 2
    Const T_PRECIOVENTA = 3

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub
    Private Sub ConsultaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cFamilia.LoadItemsObj("Familias", "Familia", "DescFamilia")
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
            Dim DC = New MarketONEDataContext(P_CONEXION)
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

    Private Sub bBuscarA_Click(sender As Object, e As EventArgs) Handles bBuscarA.Click
        Dim wBuscador = New BuscadorArticulo
        wBuscador.Configurar(Me, xArticulo)
        wBuscador.ShowDialog()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        Titulos()
    End Sub
    Sub Titulos()

        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 4

        xTabla.Cols(T_ARTICULO).Width = 150
        xTabla.Cols(T_DESCRIPCION).Width = 435
        xTabla.Cols(T_MAYORISTA).Width = 100
        xTabla.Cols(T_PRECIOVENTA).Width = 100

        xTabla.Cols(T_ARTICULO).Caption = "Artículo"
        xTabla.Cols(T_DESCRIPCION).Caption = "Descripción"
        xTabla.Cols(T_MAYORISTA).Caption = "Mayorista"
        xTabla.Cols(T_PRECIOVENTA).Caption = "Precio Venta"

        xTabla.Cols(T_ARTICULO).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click, bImprimir.Click
        Dim wButtom As Button = DirectCast(sender, Button)
        Cursor = Cursors.WaitCursor
        xTabla.Redraw = False

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wArt = DC.T_Articulos.ToList()

        If xArticulo.Text.Trim <> "" Then wArt = wArt.Where(Function(x) x.Articulo = xArticulo.Text.ToDecimal).ToList()
        If cFamilia.Text <> "" Then wArt = wArt.Where(Function(x) x.Familia = CInt(cFamilia.SelectedValue.ToString)).ToList()

        If wArt.Any Then
            If wButtom.Text = "Consultar" Then
                Titulos()
                tMensajeBarra.Text = "Cargando Datos..."
                tBarraProgreso.Value = 0
                tBarraProgreso.Maximum = wArt.Count
                tBarraProgreso.Visible = True

                For Each wA In wArt
                    xTabla.AddItem("")
                    xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, wA.Articulo)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wA.Descripcion)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_MAYORISTA, FormatNumber(wA.Costo, 0,,, TriState.True))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_PRECIOVENTA, FormatNumber(wA.PVenta, 0,,, TriState.True))
                    tBarraProgreso.Value += 1
                    DoEvents()
                Next
                tCantidadR.Text = "Cantidad de Registros " & wArt.Count
            ElseIf wButtom.Text = "Imprimir" Then
                Dim wListaPrecio = New List(Of ConsultaPrecioReporte)
                Dim wParametros = ParametroLocal()
                Dim wReporte As New ReportePrecios
                tMensajeBarra.Text = "Generando Reporte..."
                tBarraProgreso.Value = 0
                tBarraProgreso.Maximum = wArt.Count
                tBarraProgreso.Visible = True
                For Each wA In wArt
                    wListaPrecio.Add(New ConsultaPrecioReporte With {.Articulo = wA.Articulo.ToString,
                                                                    .Descripcion = wA.Descripcion,
                                                                    .Mayorista = wA.Costo,
                                                                    .PrecioVenta = wA.PVenta})
                    tBarraProgreso.Value += 1
                    DoEvents()
                Next
                wReporte.Database.Tables("MarketONE_ConsultaPrecioReporte").SetDataSource(wListaPrecio)
                wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wParametros)
                VisorReportes.MostrarReporte(wReporte)
                VisorReportes.Show()
                VisorReportes.BringToFront()
            End If
        Else
            MsgError("No se encuentra registros para los filtros indicados")
        End If

        Cursor = Cursors.Default
        xTabla.Redraw = True
        tBarraProgreso.Visible = False
        tMensajeBarra.Text = "Listo"

    End Sub

    Private Sub xArticulo_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class