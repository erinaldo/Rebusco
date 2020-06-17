Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine

Public Class ConsultaDocumento
    Implements iFormulario

    Public G_FORMULARIO As iFormulario
    Public G_CONTROL As Control
    Public G_CARGAR_EXISTENTE As Boolean = False
    Public G_TIPODOC As String = ""

    Sub New()
        InitializeComponent()
    End Sub

    Public Sub Configurar(wFormulario As iFormulario, wControl As Control, TipoDoc As String)
        G_FORMULARIO = wFormulario
        G_CONTROL = wControl
        G_CARGAR_EXISTENTE = True
        G_TIPODOC = TipoDoc
    End Sub


    Private Sub ConsultaDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = True
        DoEvents()
        Auditoria(Text, A_INGRESADO, "", "")
    End Sub

    Private Sub ConsultaDocumento_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Cursor = Cursors.WaitCursor

        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        cLocal.SelectedValue = G_LOCALACTUAL.ToString()
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", " WHERE Emision = 1")
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
        cFormaPago.LoadItemsObj("FPagos", "FPago", "DescFPago")

        oSoloVentas.Checked = True
        sDocumentos.DataSource = New List(Of DocumentoListado)

        If G_CARGAR_EXISTENTE Then
            oSoloVentas.Checked = False
            cTipoDoc.SelectedValue = G_TIPODOC
            If cTipoDoc.SelectedIndex > 0 Then
                Consultar()
            End If
        End If

        Cursor = Cursors.Arrow
    End Sub

    Private Sub xNumDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNumdoc.KeyPress
        ValidarDigitos(e)
        e.NextControl(xCliente)
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        ValidarDigitos(e)
        e.NextControl(xVendedor)
    End Sub

    Private Sub xCliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xCliente.Validating
        If xCliente.Text.Trim = "" Then Exit Sub
        If Not IsNumeric(xCliente.Text) Then MsgError("El cliente ingresado es incorrecto," & vbCrLf & " favor solo ingresar números") : Exit Sub
        Dim wCLi = SQL("SELECT Nombre From Clientes WHERE Cliente = '" & xCliente.Text.Trim & "'").Top
        If wCLi IsNot Nothing Then
            xNombreC.Text = wCLi.GetText("Nombre")
        Else
            MsgError("Cliente no registrado")
            xCliente.Clear()
            xNombreC.Clear()
            xCliente.Focus()
        End If
    End Sub

    Private Sub xVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xVendedor.KeyPress
        e.NextControl(xTicket)
    End Sub

    Private Sub xVendedor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xVendedor.Validating
        If xVendedor.Text.Trim = "" Then Exit Sub

        Dim wVen = SQL("SELECT NOmbreUsr FROM Usuarios WHERE Usuario = '" & xVendedor.Text & "'").Top
        If wVen IsNot Nothing Then
            xNombreV.Text = wVen.GetText("NombreUsr")
        Else
            MsgError("Vendedor no registrado")
            xVendedor.Clear()
            xNombreV.Clear()
            xVendedor.Focus()
        End If
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(oDetalle)
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
            ''xArticulo.Text = xArticulo.IdEncontrado
            xDescripcion.Text = xArticulo.DescEncontrada
            xArticulo.AutoCompletarActivo = True
        End If
    End Sub

    Private Sub bBuscarV_Click(sender As Object, e As EventArgs) Handles bBuscarV.Click
        Dim wQuery As String
        wQuery = "SELECT Usuario as 'Vendedor', NombreUsr as 'Nombre' From Usuarios"
        Buscador.Show()
        Buscador.Configurar(wQuery, "NombreUsr", Me, "Vendedores", xVendedor)
    End Sub

    Private Sub bBuscarA_Click(sender As Object, e As EventArgs) Handles bBuscarA.Click
        Dim wQuery As String
        wQuery = "SELECT Articulo as 'Artículo', Descripcion as 'Descripción' From Articulos"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Descripcion", Me, "Artículos", xArticulo)
    End Sub

    Private Sub bBuscarC_Click(sender As Object, e As EventArgs) Handles bBuscarC.Click
        Dim wQuery As String
        wQuery = "SELECT Cliente as 'Cliente', Nombre as 'Nombre Cliente' From Clientes"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Nombre", Me, "Clientes", xCliente)
    End Sub
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub xTicket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTicket.KeyPress
        ValidarDigitos(e)
        e.NextControl(cFormaPago)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        oSoloVentas.Checked = True
        cLocal.SelectedValue = G_LOCALACTUAL.ToString()
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
        sDocumentos.DataSource = New List(Of DocumentoListado)
    End Sub

    Private Sub Consultar(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bConsultar.Click

        Dim DC = New MarketONEDataContext(P_CONEXION)

        bConsultar.Enabled = False

        xSubTotal.Clear()
        xDescuento.Clear()
        xNeto.Clear()
        xImpuesto.Clear()
        xTotal.Clear()

        dDesde.Value = FechaDesde(dDesde.Value)
        dHasta.Value = FechaHasta(dHasta.Value)


        Dim Documentos = DC.T_DocumentosG.Where(Function(x) x.Fecha >= dDesde.Value And x.Fecha <= dHasta.Value)

        If cLocal.SelectedIndex > 0 Then
            Documentos = Documentos.Where(Function(x) x.Local = cLocal.SelectedValue.ToString().ToDecimal)
        End If

        If oSoloVentas.Checked Then
            Dim docVentas = {"BV", "BC", "BE", "FV", "FE", "NC", "ND", "BM"}
            Documentos = Documentos.Where(Function(x) docVentas.Contains(x.TipoDoc))
        Else
            If cTipoDoc.SelectedIndex > 0 Then
                Documentos = Documentos.Where(Function(x) x.TipoDoc = cTipoDoc.SelectedValue.ToString())
            End If
        End If

        If xNumdoc.ToDecimal > 0 Then
            Dim numero = xNumdoc.ToDecimal
            Documentos = Documentos.Where(Function(x) x.Numero = numero)
        End If

        If xTicket.ToDecimal > 0 Then
            Dim ticket = xTicket.ToDecimal
            Documentos = Documentos.Where(Function(x) x.Numero = ticket)
        End If

        If xCliente.ToDecimal > 0 Then
            Dim cliente = xCliente.ToDecimal()
            Documentos = Documentos.Where(Function(x) x.Cliente = cliente)
        End If

        If xVendedor.TextLength > 0 Then
            Documentos = Documentos.Where(Function(x) x.Vendedor = xVendedor.Text)
        End If

        If cFormaPago.SelectedIndex > 0 Then
            Documentos = Documentos.Where(Function(x) x.FPago = cFormaPago.SelectedValue.ToString())
        End If

        If xArticulo.Text.ToDecimal > 0 Then
            Dim art = xArticulo.Text.ToDecimal
            Dim docFiltro = Documentos.Select(Function(x) x.Numero).ToList()
            Dim det = DC.T_DocumentosD.Where(Function(x) docFiltro.Contains(x.Numero) And x.Articulo = art).Select(Function(x) x.Numero).ToList()
            Documentos = Documentos.Where(Function(x) det.Contains(x.Numero))
        End If

        Cursor = Cursors.WaitCursor

        Dim clientes = DC.T_Clientes.ToList()
        Dim formaPagos = DC.T_FPagos.ToList()
        Dim usuarios = DC.T_Usuarios.ToList()
        Dim tipoDocs = DC.T_TipoDoc.ToList()

        Dim DocumentosCons = New List(Of DocumentoListado)

        Dim resultado = Documentos.ToList()

        If Not resultado.Any Then
            MsgError("No se han encontrado coincidencias con los filtros seleccionados.", "Sin resultados")
            sDocumentos.DataSource = New List(Of DocumentoListado)
            Cursor = Cursors.Arrow
            bConsultar.Enabled = True
            Exit Sub
        End If

        For Each doc In resultado
            Dim docCons = New DocumentoListado
            docCons.Local = doc.Local
            docCons.Rut = doc.Rut
            docCons.Cliente = doc.Cliente
            docCons.NombreCliente = clientes.FirstOrDefault(Function(x) x.Cliente = doc.Cliente).Nombre.ToUpper.Trim()
            docCons.Documento = doc.Numero
            docCons.Fecha = doc.Fecha
            docCons.Estado = doc.Estado
            docCons.FPago = doc.FPago
            docCons.DescFPago = If(formaPagos.FirstOrDefault(Function(x) x.FPago = doc.FPago)?.DescFPago, "").Trim
            docCons.Vendedor = If(usuarios.FirstOrDefault(Function(x) x.Usuario = doc.Vendedor)?.NombreUsr, "").Trim
            docCons.SubTotal = If(doc.FPago = "NC", doc.SubTotal * -1, doc.SubTotal)
            docCons.Descuento = If(doc.FPago = "NC", doc.Descuento * -1, doc.Descuento)
            docCons.Neto = If(doc.FPago = "NC", doc.Neto * -1, doc.Neto)
            docCons.Iva = If(doc.FPago = "NC", doc.IVA * -1, doc.IVA)
            docCons.Total = If(docCons.TipoDoc = "NC", doc.Total * -1, doc.Total)
            docCons.TipoDoc = doc.TipoDoc
            docCons.DescTipoDoc = tipoDocs.FirstOrDefault(Function(x) x.TipoDoc = doc.TipoDoc).DescTipoDoc.Trim
            DocumentosCons.Add(docCons)
        Next

        xSubTotal.Text = Documentos.Sum(Function(x) x.SubTotal).ToString("##,##")
        xDescuento.Text = Documentos.Sum(Function(x) x.Descuento).ToString("##,##")
        xNeto.Text = Documentos.Sum(Function(x) x.Neto).ToString("##,##")
        xImpuesto.Text = Documentos.Sum(Function(x) x.IVA).ToString("##,##")
        xTotal.Text = Documentos.Sum(Function(x) x.Total).ToString("##,##")

        Cursor = Cursors.Arrow
        bConsultar.Enabled = True

        sDocumentos.DataSource = DocumentosCons

    End Sub

    Private Sub bPortapapeles_Click_1(sender As Object, e As EventArgs) Handles bPortapapeles.Click


        Dim documentos = CType(sDocumentos.DataSource, List(Of DocumentoListado))
        If Not documentos.Any Then Exit Sub

        bPortapapeles.Enabled = False

        Dim Filas As New List(Of String)

        Filas.Add($"Local{vbTab}Tipo Doc.{vbTab}Documento{vbTab}Fecha{vbTab}Rut{vbTab}Cliente{vbTab}Forma Pago{vbTab}Vendedor{vbTab}Sub-total{vbTab}Descuento{vbTab}Neto{vbTab}IVA{vbTab}Total")

        For Each Doc In documentos

            Dim Fila = $"{Doc.Local}{vbTab}{Doc.DescTipoDoc}{vbTab}{Doc.Documento}{vbTab}{Doc.Fecha}{vbTab}{Doc.Rut}{vbTab}" &
                       $"{Doc.NombreCliente.ToUpper.Trim()}{vbTab}{Doc.DescFPago}{vbTab}{Doc.Vendedor}{vbTab}{Doc.SubTotal}{vbTab}{Doc.Descuento}{vbTab}{Doc.Neto}{vbTab}{Doc.Iva}{vbTab}{Doc.Total}"

            Filas.Add(Fila)
        Next

        Filas.Add($"{vbTab}{vbTab}{vbTab}{vbTab}{vbTab}{vbTab}{vbTab}{vbTab}" &
                  $"{documentos.Sum(Function(x) x.SubTotal)}{vbTab}{documentos.Sum(Function(x) x.Descuento) }{vbTab}" &
                  $"{documentos.Sum(Function(x) x.Neto)}{vbTab}{documentos.Sum(Function(x) x.Iva)}{vbTab}{documentos.Sum(Function(x) x.Total)}")

        Dim retorno = Filas.Aggregate(Function(x, y) x & vbCrLf & y)

        bPortapapeles.Enabled = True

        Clipboard.SetText(retorno)

        Mensaje("Datos copiados al portapapeles. Pegar en planilla Excel.", "Datos exportados")


    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click

        If xTabla.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim wLista = CType(sDocumentos.DataSource, List(Of DocumentoListado))

        Try
            Dim wPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            fDialogo.InitialDirectory = wPath
            fDialogo.FileName = "Listado de Documentos.xlsx"
            If fDialogo.ShowDialog = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                DoEvents()
                wPath = fDialogo.FileName
            Else
                Exit Sub
            End If
            Dim Stream = ExcelWorkbookService.GenerateExcel(Of DocumentoListado)(wLista, "Listado de Documentos")
            My.Computer.FileSystem.WriteAllBytes(wPath, Stream.ToArray, False)

            Mensaje("Archivo generado correctamente", "Exportar listado")
        Catch ex As Exception
            MsgError("Hubo un error al intentar exportar el listado." & vbCrLf & ex.Message)
        Finally
            Cursor = Cursors.Arrow
        End Try


    End Sub

    Private Sub oVentas_CheckedChanged(sender As Object, e As EventArgs) Handles oSoloVentas.CheckedChanged
        If oSoloVentas.Checked Then
            cTipoDoc.Text = ""
            cTipoDoc.Enabled = False
        Else
            cTipoDoc.Enabled = True
        End If
    End Sub

    Private Sub sDocumentos_ListChanged(sender As Object, e As ListChangedEventArgs) Handles sDocumentos.ListChanged
        lTotal.Text = sDocumentos.Count.ToString()
        Dim activo = sDocumentos.Count > 0

        bPortapapeles.Enabled = activo
        bImprimir.Enabled = activo
        oGeneral.Enabled = activo
        oDetalle.Enabled = activo

    End Sub

    Private Sub xTabla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles xTabla.CellFormatting
        If xTabla.Rows.Count = 0 Or e.ColumnIndex > 0 Then Exit Sub
        Dim doc = CType(xTabla.Rows(e.RowIndex).DataBoundItem, DocumentoListado)

        'Pintar notas de crédito de rojo!!
        'If art.Modificado Then
        '    xTabla.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 182)
        'Else
        '    If art.CostoMovimiento > 0 AndAlso art.Costo <> art.CostoMovimiento Then
        '        xTabla.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 182)
        '    Else
        '        xTabla.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        '    End If
        'End If
    End Sub

    Private Sub xTabla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles xTabla.CellDoubleClick
        If xTabla.Rows.Count = 0 Then Exit Sub

        Dim doc = CType(xTabla.Rows(e.RowIndex).DataBoundItem, DocumentoListado)

        If G_CARGAR_EXISTENTE And G_FORMULARIO IsNot Nothing Then
            G_FORMULARIO.CargarRegistro(G_CONTROL, doc.Documento.ToString())
            G_CARGAR_EXISTENTE = False
            Close()
            Exit Sub
        End If

        If FE_BV And doc.TipoDoc = "BV" Then
            'Si tiene impresora POS definida, imprimir en ella, caso contrario, imprimir por defecto.
            If Estatus_Impresora(P_IMPRESORAVOUCHER) Then
                ImprimirDocumento(doc.Documento, DocumentoPago.Boleta, 1)
            Else
                Imprimir_Documento(doc.Local, doc.TipoDoc, doc.Documento, doc.DescTipoDoc, {1}.ToList())
            End If
        Else
            Imprimir_Documento(doc.Local, doc.TipoDoc, doc.Documento, doc.DescTipoDoc, {1}.ToList())
        End If

    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Dim documentos = CType(sDocumentos.DataSource, List(Of DocumentoListado))
        If Not documentos.Any Then Exit Sub

        bImprimir.Enabled = False
        Cursor = Cursors.WaitCursor

        Dim wReporte = New ReportClass
        Dim wListParametrosLocal = ParametroLocal()

        If Not oDetalle.Checked Then
            wReporte = New ReporteDocumento
            wReporte.Database.Tables("MarketONE_DocumentoListado").SetDataSource(documentos)
        Else

            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim articulos = DC.T_Articulos.ToList()

            Dim documentosDet = New List(Of DocumentoListado)
            For Each doc In documentos
                Dim detalle = DC.T_DocumentosD.Where(Function(x) x.Numero = doc.Documento).ToList()
                If Not detalle.Any Then Continue For
                For Each det In detalle
                    Dim art = articulos.FirstOrDefault(Function(x) x.Articulo = det.Articulo)
                    Dim docDet = doc.Clonar()
                    docDet.Articulo = art.Articulo.ToText
                    docDet.Descripcion = art.Descripcion
                    docDet.Cantidad = det.Cantidad
                    docDet.Precio = det.PVenta
                    documentosDet.Add(docDet)
                Next
            Next

            If Not documentosDet.Any Then
                Cursor = Cursors.Arrow
                bImprimir.Enabled = True
                Exit Sub
            End If
            wReporte = New ReporteDocumentoDet
            wReporte.Database.Tables("MarketONE_DocumentoListado").SetDataSource(documentosDet)
        End If

        wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(ParametroLocal)

        Cursor = Cursors.Arrow
        bImprimir.Enabled = True

        VisorReportes.MostrarReporte(wReporte)
        VisorReportes.Show()
        VisorReportes.BringToFront()
        Auditoria(Me.Text, A_IMPRESO, "", "")

    End Sub






    'Public Sub ConsultarOld()
    '    Dim wFiltros = ""
    '    Dim wReporte = New ReportClass
    '    Dim gListadoDocumento = New List(Of DocumentoConsulta)
    '    Dim wButton As Button = New Button

    '    If dDesde.Value > dHasta.Value Then
    '        MsgError("La fecha inicial no pueder ser mayor a la final")
    '        Exit Sub
    '    End If
    '    If dHasta.Value < dDesde.Value Then
    '        MsgError("La fecha final no puede ser menor a la ficha inicial")
    '        Exit Sub
    '    End If

    '    bImprimir.Enabled = False
    '    Cursor = Cursors.WaitCursor

    '    If cLocal.Text <> "" Then wFiltros += " AND L.Local = '" & Val(cLocal.SelectedValue) & "'"
    '    If oVentas.Checked Then
    '        wFiltros += " AND DG.TipoDoc in ('BV','BC','BE','FV','FE','NC','ND','BM') "
    '    Else
    '        If cDocumento.Text <> "" Then wFiltros += " AND DG.TipoDoc = '" & cDocumento.SelectedValue.ToString & "'"
    '    End If

    '    If xNumdoc.Text.Trim <> "" Then wFiltros += " AND DG.Numero = '" & xNumdoc.Text.Trim & "'"
    '    If xCliente.Text.Trim <> "" Then wFiltros += " AND DG.CLiente = '" & xCliente.Text.Trim & "'"
    '    If xVendedor.Text.Trim <> "" Then wFiltros += " AND DG.Vendedor = '" & xVendedor.Text.Trim & "'"
    '    If xTicket.Text.Trim <> "" Then wFiltros += " AND DG.Ticket = '" & xTicket.Text.Trim & "'"
    '    If cFormaPago.Text <> "" Then wFiltros += " AND DG.FPago = '" & cFormaPago.SelectedValue.ToString & "'"
    '    If wButton.Text <> "Consultar" And oDetalle.Checked Then
    '        If xArticulo.Text.Trim <> "" Then wFiltros += " AND A.Articulo = '" & xArticulo.Text.Trim & "'"
    '    Else
    '        If xArticulo.Text.Trim <> "" Then wFiltros += " AND DG.Numero in (SELECT Numero FROM DocumentosD WHERE Articulo='" & xArticulo.Text.Trim & "' and dg.Numero=Numero)"
    '    End If

    '    If wButton.Text = "Consultar" Then
    '        Titulos()
    '        Dim wDoc = SQL("Select L.Local,C.CLiente,C.Nombre,DG.TipoDoc,DG.Numero,DG.Fecha,DG.Estado,DG.FPago,u.NombreUsr as Vendedor," &
    '                " DG.SubTotal,DG.Neto,DG.Descuento,DG.IVA,DG.Total,P.DescFPago, T.TipoDoc,T.DescTipoDoc,dg.Ticket" &
    '                " From DocumentosG DG" &
    '                " JOIN Locales L On DG.Local = L.Local" &
    '                " JOIN Clientes C On DG.Cliente = C.Cliente" &
    '                " JOIN FPagos P On DG.FPAgo = P.FPago" &
    '                " JOIN TipoDoc T ON DG.TipoDoc = T.TipoDoc" &
    '                " JOIN Usuarios u on DG.Vendedor=u.usuario" &
    '                " WHERE DG.Fecha BETWEEN '" & dDesde.Value & "' AND '" & dHasta.Value & "' " & wFiltros)

    '        If wDoc.Rows.Count > 0 Then
    '            'tMensajeBarra.Text = "Cargando Tabla..."
    '            'tBarraProgreso.Visible = True
    '            'tBarraProgreso.Maximum = wDoc.Rows.Count
    '            'tBarraProgreso.Value = 0
    '            Dim wSubTotal As Double
    '            Dim wDescuento As Double
    '            Dim wNeto As Double
    '            Dim wImpuesto As Double
    '            Dim wTotal As Double
    '            'xTabla2.Redraw = False
    '            Titulos()

    '            For Each wD As DataRow In wDoc.Rows
    '                'xTabla2.AddItem("")
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_LOCAL, wD.GetText("Local"))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_NUMERO, wD.GetText("Numero"))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_TICKET, wD.GetText("Ticket"))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_FECHA, FormatDateTime(wD.GetDate("Fecha"), DateFormat.ShortDate))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_NOMBRECLIENTE, wD.GetText("Nombre"))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_FORMAPAGO, wD.GetText("DescFpago"))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_VENDEDOR, wD.GetText("Vendedor"))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_SUBTOTAL, wD.GetText("SubTotal"))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_DESCUENTO, wD.GetText("Descuento"))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_NETO, wD.GetText("Neto"))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_IVA, wD.GetText("IVA"))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_TOTAL, wD.GetText("Total"))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_TIPODOC, wD.GetText("TipoDoc"))
    '                'xTabla2.SetData(xTabla2.Rows.Count - 1, T_DOCUMENTO, wD.GetText("DescTipoDoc"))

    '                'tBarraProgreso.Value += 1
    '                wSubTotal += If(wD.GetText("TipoDoc") = "NC", CDbl("-" & wD.GetNum("SubTotal")), wD.GetNum("SubTotal"))
    '                wDescuento += If(wD.GetText("TipoDoc") = "NC", CDbl("-" & wD.GetNum("Descuento")), wD.GetNum("Descuento"))
    '                wNeto += If(wD.GetText("TipoDoc") = "NC", CDbl("-" & wD.GetNum("Neto")), wD.GetNum("Neto"))
    '                wImpuesto += If(wD.GetText("TipoDoc") = "NC", CDbl("-" & wD.GetNum("IVA")), wD.GetNum("IVA"))
    '                wTotal += If(wD.GetText("TipoDoc") = "NC", CDbl("-" & wD.GetNum("Total")), wD.GetNum("Total"))
    '                DoEvents()

    '            Next
    '            xSubTotal.Text = FormatNumber(wSubTotal, 0,,, TriState.True)
    '            xDescuento.Text = FormatNumber(wDescuento, 0,,, TriState.True)
    '            xNeto.Text = FormatNumber(wNeto, 0,,, TriState.True)
    '            xImpuesto.Text = FormatNumber(wImpuesto, 0,,, TriState.True)
    '            xTotal.Text = FormatNumber(wTotal, 0,,, TriState.True)
    '            'xTabla2.AjustarColumnas
    '        Else
    '            Cursor = Cursors.Default
    '            MsgError("No se encuentra registros para los filtros indicados")
    '        End If
    '    Else
    '        If oDetalle.Checked Then

    '            Dim wDoc = SQL("SELECT L.Local,C.CLiente,C.Nombre,DG.TipoDoc,DG.Numero,DG.Fecha,DG.Estado,DG.FPago,DG.Vendedor," &
    '                " DG.SubTotal,DG.Neto,DG.Descuento,DG.IVA,DG.Total,A.Articulo ,A.Descripcion,DD.Cantidad,DD.pVenta,P.DescFPago" &
    '                " From DocumentosG DG" &
    '                " JOIN Locales L On DG.Local = L.Local" &
    '                " JOIN Clientes C ON DG.Cliente = C.Cliente" &
    '                " JOIN DocumentosD DD ON DG.Numero = DD.Numero" &
    '                " JOIN Articulos A ON DD.Articulo = A.Articulo " &
    '                " JOIN FPagos P ON DG.FPAgo = P.FPago" &
    '                " WHERE DG.Fecha BETWEEN '" & dDesde.Value & "' AND '" & dHasta.Value & "' " & wFiltros)

    '            wReporte = New ReporteDocumentoDet
    '            'tBarraProgreso.Visible = True
    '            'tBarraProgreso.Value = 0
    '            'tBarraProgreso.Maximum = wDoc.Rows.Count
    '            'tMensajeBarra.Text = "Cargando Datos..."

    '            For Each wD As DataRow In wDoc.Rows

    '                gListadoDocumento.Add(New DocumentoConsulta With {.Local = wD.GetNum("Local"),
    '                                                         .Cliente = wD.GetText("Cliente").ToDecimal,
    '                                                         .NombreCliente = wD.GetText("Nombre"),
    '                                                         .Documento = wD.GetDecimal("Numero"),
    '                                                         .Fecha = wD.GetDate("Fecha"),
    '                                                         .Estado = wD.GetText("Estado"),
    '                                                         .FPago = wD.GetText("FPAgo"),
    '                                                         .Vendedor = wD.GetText("Vendedor"),
    '                                                         .SubTotal = wD.GetNum("SubTotal"),
    '                                                         .Descuento = wD.GetNum("Descuento"),
    '                                                         .Neto = wD.GetNum("Neto"),
    '                                                         .Iva = wD.GetNum("IVA"),
    '                                                         .Total = wD.GetNum("Total"),
    '                                                         .Articulo = wD.GetText("Articulo"),
    '                                                         .Cantidad = wD.GetNum("Cantidad"),
    '                                                         .Descripcion = wD.GetText("Descripcion"),
    '                                                         .TipoDoc = wD.GetText("TipoDoc"),
    '                                                         .Precio = wD.GetNum("PVenta"),
    '                                                         .DescFPago = wD.GetText("DescFPago")})
    '                'tBarraProgreso.Value += 1
    '                DoEvents()
    '            Next

    '        Else
    '            Dim wDoc = SQL("Select L.Local,C.CLiente,C.Nombre,DG.TipoDoc,DG.Numero,DG.Fecha,DG.Estado,DG.FPago,DG.Vendedor," &
    '                " DG.SubTotal,DG.Neto,DG.Descuento,DG.IVA,DG.Total,P.DescFPago" &
    '                " From DocumentosG DG" &
    '                " JOIN Locales L On DG.Local = L.Local" &
    '                " JOIN Clientes C On DG.Cliente = C.Cliente" &
    '                " JOIN FPagos P On DG.FPAgo = P.FPago" &
    '                " WHERE DG.Fecha BETWEEN '" & dDesde.Value & "' AND '" & dHasta.Value & "' " & wFiltros)

    '            wReporte = New ReporteDocumento
    '            'tBarraProgreso.Visible = True
    '            'tBarraProgreso.Value = 0
    '            'tBarraProgreso.Maximum = wDoc.Rows.Count
    '            'tMensajeBarra.Text = "Cargando Datos..."
    '            For Each wD As DataRow In wDoc.Rows

    '                gListadoDocumento.Add(New DocumentoConsulta With {.Local = wD.GetNum("Local"),
    '                                                 .Cliente = wD.GetText("Cliente").ToDecimal,
    '                                                 .NombreCliente = wD.GetText("Nombre"),
    '                                                 .Documento = wD.GetDecimal("Numero"),
    '                                                 .Fecha = wD.GetDate("Fecha"),
    '                                                 .Estado = wD.GetText("Estado"),
    '                                                 .FPago = wD.GetText("FPAgo"),
    '                                                 .Vendedor = wD.GetText("Vendedor"),
    '                                                 .SubTotal = If(wD.GetText("TipoDoc") = "NC", CDbl("-" & wD.GetNum("SubTotal")), wD.GetNum("SubTotal")),
    '                                                 .Descuento = If(wD.GetText("TipoDoc") = "NC", CDbl("-" & wD.GetNum("Descuento")), wD.GetNum("Descuento")),
    '                                                 .Neto = If(wD.GetText("TipoDoc") = "NC", CDbl("-" & wD.GetNum("Neto")), wD.GetNum("Neto")),
    '                                                 .Iva = If(wD.GetText("TipoDoc") = "NC", CDbl("-" & wD.GetNum("IVA")), wD.GetNum("IVA")),
    '                                                 .Total = If(wD.GetText("TipoDoc") = "NC", CDbl("-" & wD.GetNum("Total")), wD.GetNum("Total")),
    '                                                 .TipoDoc = wD.GetText("TipoDoc"),
    '                                                 .DescFPago = wD.GetText("DescFPago")})
    '                'tBarraProgreso.Value += 1
    '                DoEvents()
    '            Next
    '        End If

    '        If gListadoDocumento.Count > 0 Then
    '            'tMensajeBarra.Text = "Generando Reporte..."
    '            DoEvents()
    '            Dim wListParametrosLocal = ParametroLocal()
    '            wReporte.Database.Tables("MarketONE_DocumentoListado").SetDataSource(gListadoDocumento)
    '            wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(ParametroLocal)
    '            VisorReportes.MostrarReporte(wReporte)
    '            VisorReportes.Show()
    '            VisorReportes.BringToFront()
    '            Auditoria(Me.Text, A_IMPRESO, "", "")
    '        Else
    '            Cursor = Cursors.Default
    '            MsgError("No se encuentra registros para los filtros indicados")
    '        End If
    '    End If

    '    'tBarraProgreso.Visible = False
    '    'tMensajeBarra.Text = "Listo"

    '    Cursor = Cursors.Default
    '    bImprimir.Enabled = True
    'End Sub
End Class