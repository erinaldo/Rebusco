Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class ConsultarDatoBicicleta
    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        Dim wDC = New MarketONEDataContext(P_CONEXION)
        Dim wConsulta = wDC.T_BuscarControlArticulos.AsQueryable()

        If xCliente.Text.Trim <> "" Then wConsulta = wConsulta.Where(Function(x) x.Cliente = xCliente.Text)
        If xArticulo.Text.Trim <> "" Then wConsulta = wConsulta.Where(Function(x) x.Articulo = xArticulo.Text.ToDecimal())
        If xSerie.Text.Trim <> "" Then wConsulta = wConsulta.Where(Function(x) x.Serie = xSerie.Text)

        If wConsulta.Any() Then
            Dim wDatosBi = wConsulta.Select(Function(x) New DatosControlArticulo With
                                            {
                                             .NumeroDocumento = x.Documento.ToDecimal(),
                                             .Articulo = x.Articulo,
                                             .DescripcionArticulo = x.Descripcion,
                                             .Cliente = x.Cliente.ToDecimal(),
                                             .NombreCliente = x.Nombre,
                                             .SKU = x.SKU,
                                             .Año = x.Año,
                                             .Color = x.Color,
                                             .Marca = x.Marca,
                                             .Modelo = x.Modelo,
                                             .Talla = x.Talla
                                             }).ToList()

            DatosBicicletaConsultaBindingSource.Load(wDatosBi)
        Else
            MsgError("No se encuentras datos para los filtros ingresados")
        End If

    End Sub

    Private Sub xTabla_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles xTabla.CellMouseDown
        If e.Button = MouseButtons.Right And e.RowIndex > -1 Then
            Dim xTabla = DirectCast(sender, DataGridView)
            xTabla.CurrentCell = xTabla.Item(e.ColumnIndex, e.RowIndex)

            MostrarMenu(xTabla, e.Location, mOpciones)
        End If

    End Sub

    Public Sub MostrarMenu(ByRef xTabla As DataGridView, ByRef wUbicacion As Point, ByRef mMenu As ContextMenuStrip)
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
            mMenu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub bVer_Click(sender As Object, e As EventArgs) Handles bVer.Click
        Dim articulo = CType(xTabla.CurrentRow.DataBoundItem, DatosControlArticulo)
        GenerarReporte(0, articulo.NumeroDocumento, articulo.Cliente)
    End Sub

    Sub GenerarReporte(wAccion As Decimal, wDocumento As Decimal, wCliente As Decimal)
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim wControlArticulo = DC.T_Control_Articulos.FirstOrDefault(Function(x) x.Documento = wDocumento.ToString() And
                                                                          x.Cliente = wCliente.ToString())
        If wControlArticulo Is Nothing Then
            MsgError("Error al generar la ficha técnica")
            Exit Sub
        End If

        Dim wDatosCliente = DC.T_Clientes.FirstOrDefault(Function(X) X.Cliente = wCliente)
        Dim wDatosBicicleta As New DatosBicicletaVenta
        Dim wDescripcionFPago = DC.T_FPagos.FirstOrDefault(Function(x) x.FPago = wControlArticulo.FPago)
        Dim wNombreLocal = DC.T_Locales.FirstOrDefault(Function(x) x.Local = wControlArticulo.Local.ToDecimal)
        Dim wParametrosLocal = ParametroLocal()
        wDatosBicicleta.FPago = If(wDescripcionFPago?.DescFPago, "")
        wDatosBicicleta.Tienda = wNombreLocal.NombreLocal

        Dim wReporte As New ReporteControlArticulo
        wReporte.Database.Tables("MarketONE_T_Clientes").SetDataSource({wDatosCliente}.ToList())
        wReporte.Database.Tables("MarketONE_T_Control_Articulos").SetDataSource({wControlArticulo}.ToList())
        wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wParametrosLocal)
        wReporte.Database.Tables("MarketONE_DatosBicicletaVenta").SetDataSource({wDatosBicicleta}.ToList())

        If wAccion = 0 Then
            VisorReportes.Visor.ReportSource = wReporte
            VisorReportes.Show()
            VisorReportes.BringToFront()
        Else
            wReporte.PrintToPrinter(1, False, 0, 0)
        End If

    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Dim articulo = CType(xTabla.CurrentRow.DataBoundItem, DatosControlArticulo)
        GenerarReporte(1, articulo.NumeroDocumento, articulo.Cliente)
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
    Private Sub xArticulo_ItemSeleccionado(wDescripcion As String) Handles xArticulo.ItemSeleccionado
        xDescripcion.Text = wDescripcion
        xSerie.Focus()
    End Sub

    Private Sub xCliente_Validating(sender As Object, e As CancelEventArgs) Handles xCliente.Validating
        Dim wPatronRut = New Regex("^(\d{2}\.\d{3}\.\d{3}-)([kK]{1}$|\d{1}$)")
        If xCliente.ListaVisible Then
            If xCliente.ListaActiva Then
                Exit Sub
            Else
                xCliente.OcultarLista()
            End If
        End If

        If Trim(xCliente.Text) = "" Then
            xNombre.Clear()
            Exit Sub
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)


        Dim Cli As T_Clientes = Nothing

        xNombre.Clear()

        If xCliente.DescEncontrada = "" Then

            Dim rut = FormatoRut(xCliente.Text.Replace(",", "."))
            If wPatronRut.IsMatch(rut) Then
                Cli = DC.T_Clientes.FirstOrDefault(Function(x) x.Rut = rut)
            End If

            If Cli Is Nothing Then
                If IsNumeric(xCliente.Text) Then
                    Cli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = xCliente.Text.Trim.ToDecimal)
                End If
            End If

            If Cli Is Nothing Then
                Cli = DC.T_Clientes.FirstOrDefault(Function(x) x.Fantasia = xCliente.Text.Trim)
            End If
        Else
            Cli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = xCliente.Text.ToDecimal)
        End If

        xCliente.AutoCompletarActivo = False
        If Cli IsNot Nothing Then
            xCliente.Text = Cli.Cliente.ToString
            xNombre.Text = Cli.Nombre
        Else
            xCliente.Clear()
            xNombre.Clear()
        End If
        xCliente.AutoCompletarActivo = True
    End Sub

    Private Sub xCliente_ItemSeleccionado(wDescripcion As String) Handles xCliente.ItemSeleccionado
        xNombre.Text = wDescripcion
        xArticulo.Focus()
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        e.NextControl(xArticulo)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        DatosBicicletaConsultaBindingSource.DataSource = Nothing
    End Sub

    Private Sub xSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xSerie.KeyPress
        e.NextControl(bConsultar)
    End Sub
End Class

Public Class DatosControlArticulo
    <Browsable(False)>
    Public Property NumeroDocumento As Decimal
    <Browsable(False)>
    Public Property Cliente As Decimal
    <DisplayName("Cliente")>
    Public Property NombreCliente As String
    <Browsable(False)>
    Public Property Articulo As Decimal
    <DisplayName("Descripción Artículo")>
    Public Property DescripcionArticulo As String
    Public Property SKU As String
    Public Property Marca As String
    Public Property Modelo As String
    Public Property Color As String
    Public Property Talla As String
    Public Property Año As Decimal

End Class