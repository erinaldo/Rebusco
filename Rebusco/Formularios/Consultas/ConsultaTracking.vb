Imports System.ComponentModel
Imports MarketONE

Public Class ConsultaTracking
    Implements iFormulario

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub ListadoArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Auditoria(Text, A_INGRESADO, "", "")
        sTracking.DataSource = New List(Of TrackingConsulta)
    End Sub

    Private Sub ConsultaTracking_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        cLocal.SelectedValue = G_LOCALACTUAL.ToString()
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", " WHERE Emision = 1 OR TipoDoc = 'MV'")
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
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

            Informacion("Artículo no encontrado")
            xDescripcion.Clear()
            xArticulo.Clear()
            xArticulo.Focus()
        Else
            xArticulo.AutoCompletarActivo = False
            xDescripcion.Text = xArticulo.DescEncontrada
            xArticulo.AutoCompletarActivo = True
        End If
    End Sub

    Private Sub xArticulo_ItemSeleccionado(wDescripcion As String) Handles xArticulo.ItemSeleccionado
        xDescripcion.Text = wDescripcion
        bConsultar.Focus()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        cLocal.SelectedIndex = 0
        xNumdoc.Clear()
        cTipoDoc.SelectedIndex = 0
        xArticulo.Clear()
        xDescripcion.Clear()
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
        sTracking.DataSource = New List(Of TrackingConsulta)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click

        dDesde.Value = FechaDesde(dDesde.Value)
        dHasta.Value = FechaHasta(dHasta.Value)

        sTracking.DataSource = New List(Of TrackingConsulta)

        Cursor = Cursors.WaitCursor

        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim Tracking = DC.T_Tracking.Where(Function(x) x.FechaEvento >= dDesde.Value And x.FechaEvento <= dHasta.Value)

        If cTipoDoc.SelectedIndex > 0 Then
            Tracking = Tracking.Where(Function(x) x.TipoDoc = cTipoDoc.SelectedValue.ToString())

            If xNumdoc.ToDecimal > 0 Then
                Dim numero = xNumdoc.ToDecimal
                Tracking = Tracking.Where(Function(x) x.NumDoc = numero)
            End If

        End If

        If cLocal.SelectedIndex > 0 Then
            Tracking = Tracking.Where(Function(x) x.Local = cLocal.SelectedValue.ToString().ToDecimal)
        End If

        If cBodega.SelectedIndex > 0 Then
            Tracking = Tracking.Where(Function(x) x.Local = cBodega.SelectedValue.ToString().ToDecimal)
        End If

        If xArticulo.Text.ToDecimal > 0 Then
            Dim art = xArticulo.Text.ToDecimal
            Tracking = Tracking.Where(Function(x) x.Articulo = art)
        End If

        Dim bodegas = DC.T_Bodegas.ToList()
        Dim locales = DC.T_Locales.ToList()
        Dim tiposDoc = DC.T_TipoDoc.ToList()

        Dim resultado = New List(Of TrackingConsulta)

        For Each Trk In Tracking

            Dim item = New TrackingConsulta()
            item.Tracking = Trk.Tracking
            item.FechaEvento = Trk.FechaEvento
            item.Evento = Trk.Evento
            item.DescEvento = Trk.DescripcionEvento
            item.Local = Trk.Local
            item.NombreLocal = If(locales.FirstOrDefault(Function(x) x.Local = Trk.Local)?.NombreLocal, "")
            item.Bodega = Trk.Bodega
            item.NombreBodega = If(bodegas.FirstOrDefault(Function(x) x.Bodega = Trk.Bodega)?.NombreBodega, "")
            item.TipoDoc = If(tiposDoc.FirstOrDefault(Function(x) x.TipoDoc = Trk.TipoDoc)?.DescTipoDoc, "")
            item.NumDoc = Trk.NumDoc
            item.FechaDoc = Trk.FechaRegistroReferencia
            item.Articulo = Trk.Articulo
            item.SKU = Trk.SKU
            item.Descripcion = Trk.Descripcion
            item.Cantidad = Trk.Cantidad
            item.Cliente = Trk.Cliente
            Dim cli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = Trk.Cliente)
            item.Rut = If(cli?.Rut, "")
            item.NombreCliente = If(cli?.Nombre, "")
            item.Observacion = Trk.Observacion
            item.Modulo = Trk.Modulo
            item.Usuario = If(DC.T_Usuarios.FirstOrDefault(Function(x) x.Usuario = Trk.Usuario)?.NombreUsr, "")
            resultado.Add(item)

        Next

        sTracking.DataSource = resultado
        xTabla.Refresh()

        Cursor = Cursors.Default

    End Sub

    Private Sub sTracking_ListChanged(sender As Object, e As ListChangedEventArgs) Handles sTracking.ListChanged
        lTotal.Text = sTracking.Count.ToString()
    End Sub

    Private Sub oDatosCliente_CheckedChanged(sender As Object, e As EventArgs) Handles oDatosCliente.CheckedChanged
        colCliente.Visible = oDatosCliente.Checked
        colNombreCliente.Visible = oDatosCliente.Checked
        colRut.Visible = oDatosCliente.Checked
    End Sub

    Private Sub oDatosDocumento_CheckedChanged(sender As Object, e As EventArgs) Handles oDatosDocumento.CheckedChanged
        colTipoDocumento.Visible = oDatosDocumento.Checked
        colNumeroDoc.Visible = oDatosDocumento.Checked
        colFechaDocumento.Visible = oDatosDocumento.Checked

    End Sub

    Private Sub oIdentificadores_CheckedChanged(sender As Object, e As EventArgs) Handles oIdentificadores.CheckedChanged
        colTracking.Visible = oIdentificadores.Checked
        colEvento.Visible = oIdentificadores.Checked
        colBodega.Visible = oIdentificadores.Checked
        colLocal.Visible = oIdentificadores.Checked
    End Sub

    Private Sub cLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cLocal.SelectedIndexChanged
        If cLocal.SelectedIndex <= 0 Then
            cBodega.DataSource = New List(Of ItemCombo)
            Exit Sub
        End If
        cBodega.LoadItemsObj("Bodegas", "Bodega", "NombreBodega", $" WHERE local = {cLocal.SelectedValue.ToString.ToDecimal}", True)
        If cBodega.Items.Count > 0 Then cBodega.SelectedIndex = 1
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        If e.KeyChar = vbCr Then bConsultar.Focus()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        If xTabla.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim wLista = CType(sTracking.DataSource, List(Of TrackingConsulta))

        Try
            Dim wPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            fDialogo.InitialDirectory = wPath
            fDialogo.FileName = "Listado de Tracking.xlsx"
            If fDialogo.ShowDialog = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                DoEvents()
                wPath = fDialogo.FileName
            Else
                Exit Sub
            End If
            Dim Stream = ExcelWorkbookService.GenerateExcel(Of TrackingConsulta)(wLista, "Listado de Tracking")
            My.Computer.FileSystem.WriteAllBytes(wPath, Stream.ToArray, False)

            Mensaje("Archivo generado correctamente", "Exportar listado")
        Catch ex As Exception
            MsgError("Hubo un error al intentar exportar el listado." & vbCrLf & ex.Message)
        Finally
            Cursor = Cursors.Arrow
        End Try
    End Sub
End Class

Public Class TrackingConsulta

    Public Property Tracking As Decimal
    <DisplayName("Fecha")>
    Public Property FechaEvento As DateTime
    <DisplayName("Evento")>
    Public Property Evento As Decimal
    <DisplayName("Tipo")>
    Public Property DescEvento As String
    <DisplayName("Artículo")>
    Public Property Articulo As Decimal
    <DisplayName("SKU")>
    Public Property SKU As String
    <DisplayName("Descripción")>
    Public Property Descripcion As String
    <DisplayName("Cantidad")>
    Public Property Cantidad As Decimal
    <DisplayName("Local")>
    Public Property Local As Decimal
    <DisplayName("Nombre Local")>
    Public Property NombreLocal As String
    <DisplayName("Bodega")>
    Public Property Bodega As Decimal
    <DisplayName("Nombre bodega")>
    Public Property NombreBodega As String
    <DisplayName("Fecha doc.")>
    Public Property FechaDoc As DateTime
    <DisplayName("Tipo doc.")>
    Public Property TipoDoc As String
    <DisplayName("Número")>
    Public Property NumDoc As Decimal
    <DisplayName("Cliente")>
    Public Property Cliente As Decimal
    <DisplayName("Rut")>
    Public Property Rut As String
    <DisplayName("Nombre Cliente")>
    Public Property NombreCliente As String
    <DisplayName("Usuario")>
    Public Property Usuario As String
    <DisplayName("Módulo")>
    Public Property Modulo As String
    <DisplayName("Observación")>
    Public Property Observacion As String

End Class