Imports System.ComponentModel

Public Class ListadoMovimientos
    Implements iFormulario

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub xLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xLocal.KeyPress
        e.NextControl(xBodega)
    End Sub

    Private Sub xLocal_Validating(sender As Object, e As CancelEventArgs) Handles xLocal.Validating
        If xLocal.Text.Trim <> "" Then
            cLocal.SelectedValue = xLocal.Text.Trim
            If cLocal.Text = W_SELECCIONAR Then
                MsgError("Local no encontrado")
                xLocal.Clear()
                xLocal.Focus()
            End If
            xBodega.Focus()
        End If
    End Sub

    Private Sub cLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cLocal.SelectedIndexChanged
        If cLocal.Text.Trim <> "" Then
            xLocal.Text = cLocal.SelectedValue.ToString
            xBodega.Focus()
        Else
            xLocal.Clear()
        End If
    End Sub

    Private Sub xBodega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBodega.KeyPress
        e.NextControl(cTipoMov)
    End Sub

    Private Sub xBodega_Validating(sender As Object, e As CancelEventArgs) Handles xBodega.Validating
        If xBodega.Text.Trim <> "" Then
            cBodega.SelectedValue = xBodega.Text.Trim
            If cBodega.Text = W_SELECCIONAR Then
                MsgError("Local no encontrado")
                xBodega.Clear()
                xBodega.Focus()
            End If
            cTipoMov.Focus()
        End If
    End Sub

    Private Sub cBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBodega.SelectedIndexChanged
        If cBodega.Text.Trim <> "" Then
            xBodega.Text = cBodega.SelectedValue.ToString
            cTipoMov.Focus()
        Else
            xBodega.Clear()
        End If
    End Sub

    Private Sub cTipoMov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cTipoMov.SelectedIndexChanged
        cTipoDoc.Focus()
    End Sub

    Private Sub cTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cTipoDoc.SelectedIndexChanged
        dDesde.Focus()
    End Sub

    Private Sub xUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xUsuario.KeyPress
        e.NextControl(xResponsable)
    End Sub

    Private Sub xUsuario_Validating(sender As Object, e As CancelEventArgs) Handles xUsuario.Validating
        If xUsuario.Text.Trim <> "" Then
            Dim wUsr = SQL("SELECT  NombreUsr FROM Usuarios WHERE Usuario = '" & xUsuario.Text.Trim & "'").Top
            If wUsr IsNot Nothing Then
                xNombreUsuario.Text = wUsr.GetText("NombreUsr")
            Else
                MsgError("Usuario no encontrado")
                xUsuario.Clear()
                xNombreUsuario.Clear()
                xUsuario.Focus()
            End If
        End If
    End Sub

    Private Sub bBuscarU_Click(sender As Object, e As EventArgs) Handles bBuscarU.Click
        Dim wQuery = "SELECT Usuario, Nombreusr as Nombre FROM Usuarios"
        Buscador.Show()
        Buscador.Configurar(wQuery, "NombreUsr", Me, "Usuario", xUsuario)
    End Sub

    Private Sub xResponsable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xResponsable.KeyPress
        e.NextControl(bImprimir)
    End Sub

    Private Sub xResponsable_Validating(sender As Object, e As CancelEventArgs) Handles xResponsable.Validating
        If xResponsable.Text.Trim <> "" Then
            Dim wUsr = SQL("SELECT NombreUsr FROM Usuarios WHERE Usuario = '" & xResponsable.Text.Trim & "'").Top
            If wUsr IsNot Nothing Then
                xNombreResponsable.Text = wUsr.GetText("NombreUsr")
            Else
                MsgError("Usuario responsable no encontrado")
                xResponsable.Clear()
                xNombreResponsable.Clear()
                xResponsable.Focus()
            End If
        End If
    End Sub
    Private Sub bBuscarR_Click(sender As Object, e As EventArgs) Handles bBuscarR.Click
        Dim wQuery = "SELECT Usuario, Nombreusr as Nombre FROM Usuarios"
        Buscador.Show()
        Buscador.Configurar(wQuery, "NombreUsr", Me, "Usuario", xResponsable)
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Dim wFiltros = ""
        Cursor = Cursors.WaitCursor
        Dim wMovGs = SQL("SELECT MG.Movimiento,MG.Fecha,TM.DescTipo,TD.DescTipoDoc ,L.NombreLocal,B.NombreBodega,U.NombreUsr as UsrCreador,UR.NombreUsr as UsrResponsable," &
                     " E.DescEstado,MG.NumDoc,MG.ObsTra,MG.Total" &
                     " FROM MovGen MG" &
                     " JOIN TipoMov TM ON MG.TipoMov = TM.TipoMov" &
                     " LEFT JOIN TipoDoc TD ON MG.TipoDoc = TD.TipoDoc" &
                     " JOIN Locales L On MG.Local = L.Local" &
                     " JOIN Bodegas B ON MG.Bodega = B.Bodega" &
                     " JOIN Usuarios U ON MG.Usuario = U.Usuario" &
                     " JOIN Usuarios UR ON MG.Responsable = UR.Usuario" &
                     " JOIN Estados E ON MG.Estado = E.Estado And E.Tipo = 'V'" &
                     " WHERE Fecha BETWEEN '" & dDesde.Value & "' AND '" & dHasta.Value & "'")

        If xLocal.Text.Trim <> "" Then wFiltros += " AND L.Local = '" & xLocal.Text.Trim & "'"
        If xBodega.Text.Trim <> "" Then wFiltros += "AND B.Bodega = '" & xBodega.Text.Trim & "'"
        If cTipoMov.Text.Trim <> "" Then wFiltros += " AND TM.TipoMov = '" & cTipoMov.SelectedValue.ToString & "'"
        If cTipoDoc.Text.Trim <> "" Then wFiltros += " AND TD.TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "'"
        If xUsuario.Text.Trim <> "" Then wFiltros += " AND U.Usuario = '" & xUsuario.Text.Trim & "'"
        If xResponsable.Text.Trim <> "" Then wFiltros += " AND UR.Usuario = '" & xResponsable.Text.Trim & "'"
        'If cEstado.Text.Trim <> "" Then wFiltros += " AND E.Estado = '" & cEstado.SelectedValue.ToString & "'"


        Dim wLista = New List(Of MovimientosReporte)

        For Each wMovG As DataRow In wMovGs.Rows
            wLista.Add(New MovimientosReporte With {.Movimiento = CInt(wMovG.GetText("Movimiento")),
                                                   .Fecha = CDate(wMovG.GetText("Fecha")),
                                                   .DescTipoMov = wMovG.GetText("DescTipo"),
                                                   .DescTipoDoc = wMovG.GetText("DescTipoDoc"),
                                                   .NombreLocal = wMovG.GetText("NombreLocal"),
                                                   .NombreBodega = wMovG.GetText("NombreBodega"),
                                                   .NombreUsuario = wMovG.GetText("UsrCreador"),
                                                   .nombreResponsable = wMovG.GetText("UsrResponsable"),
                                                   .DescEstado = wMovG.GetText("DescEstado"),
                                                   .NumDoc = CInt(wMovG.GetText("NumDoc")),
                                                   .ObsTra = wMovG.GetText("ObsTra"),
                                                   .Total = CInt(wMovG.GetText("Total"))})
        Next

        If wLista.Count > 0 Then
            Dim wReporte As New ReporteMovimientos
            Dim wParamtros = ParametroReporte()
            wReporte.Database.Tables(1).SetDataSource(wLista)
            wReporte.Database.Tables(0).SetDataSource(wParamtros)
            wReporte.SetParameterValue("Desde", dDesde.Value)
            wReporte.SetParameterValue("Hasta", dHasta.Value)
            VisorReportes.MostrarReporte(wReporte)
            VisorReportes.WinDeco1.TituloVentana = "Listado de Movimientos"
            VisorReportes.Show()
            Auditoria(Me.Text, A_IMPRESO, "", "")
            Cursor = Cursors.Arrow
        Else
            Cursor = Cursors.Arrow
            MsgError("No se encuentran datos para la selección indicada")
            Cursor = Cursors.Arrow
        End If

    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub ListadoMovimientos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Cursor = Cursors.WaitCursor
        LoadItemsObj(cLocal, "Locales", "Local", "NombreLocal")
        LoadItemsObj(cBodega, "Bodegas", "Bodega", "NombreBodega")
        LoadItemsObj(cTipoDoc, "TipoDoc", "TipoDoc", "DescTipoDoc")
        LoadItemsObj(cTipoMov, "TipoMov", "TipoMov", "DescTipo")

        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
        Auditoria(Me.Text, A_INGRESADO, "", "")

        Cursor = Cursors.Arrow
    End Sub

    Private Sub ListadoMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wMovimientos = DC.T_ListadoMovimientosEncabezado.Where(Function(x) x.Fecha >= dDesde.Value.Date And x.Fecha <= dHasta.Value.Date)
        If Not wMovimientos.Any Then
            MsgError("No se encuentra registros para la fecha indicada")
            Exit Sub
        End If

        If cLocal.Text <> "" Then wMovimientos = wMovimientos.Where(Function(x) x.Local = cLocal.SelectedValue.ToString.ToDecimal())
        If cBodega.Text <> "" Then wMovimientos = wMovimientos.Where(Function(x) x.Bodega = cBodega.SelectedValue.ToString.ToDecimal())
        If cTipoMov.Text <> "" Then wMovimientos = wMovimientos.Where(Function(x) x.TipoMov = cTipoMov.SelectedValue.ToString)
        If cTipoDoc.Text <> "" Then wMovimientos = wMovimientos.Where(Function(x) x.TipoDoc = cTipoDoc.SelectedValue.ToString())
        If xResponsable.Text <> "" Then wMovimientos = wMovimientos.Where(Function(x) x.Responsable = xResponsable.Text.Trim())
        If xUsuario.Text <> "" Then wMovimientos = wMovimientos.Where(Function(x) x.Usuario = xUsuario.Text.Trim())

        If Not wMovimientos.Any() Then
            MsgError("No se encuentra movimientos para los filtros indicados")
            Exit Sub
        End If

        Dim wListaMovimiento As New List(Of MovEncabezado)
        For Each wMovimiento In wMovimientos
            Dim wEncabezado = New MovEncabezado With
                {
                    .Movimiento = wMovimiento.Movimiento,
                    .Fecha = wMovimiento.Fecha.ToShortDateString,
                    .TipoMov = wMovimiento.TipoMov.Trim(),
                    .DescripcionTipoMov = wMovimiento.DescTipoDoc.Trim(),
                    .Local = wMovimiento.Local,
                    .NombreLocal = wMovimiento.NombreLocal.Trim(),
                    .Bodega = wMovimiento.Bodega,
                    .NombreBodega = wMovimiento.NombreBodega.Trim(),
                    .Usuario = wMovimiento.Usuario.Trim(),
                    .NombreUsuario = wMovimiento.NombreUsuario.Trim(),
                    .Responsable = wMovimiento.Responsable.Trim(),
                    .NombreResponsable = wMovimiento.NombreResponsable.Trim(),
                    .TipoDocRef = wMovimiento.TipoDoc.Trim(),
                    .DescripcionTipoDocRef = wMovimiento.DescTipo.Trim(),
                    .NumDocRef = wMovimiento.NumDoc
                }
            wListaMovimiento.Add(wEncabezado)
        Next
        MovEncabezadoBindingSource.Load(wListaMovimiento)
    End Sub

    Private Sub xTablaMovimientos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles xTablaMovimientos.CellClick
        If e.RowIndex = -1 Then Exit Sub
        If xTablaMovimientos.Rows.Count = 0 Then Exit Sub
        Dim wMovimiento = CType(xTablaMovimientos.CurrentRow.DataBoundItem, MovEncabezado)
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wDetalle = DC.T_MovDet.Where(Function(x) x.Movimiento = wMovimiento.Movimiento And x.TipoMov = wMovimiento.TipoMov)
        If Not wDetalle.Any() Then
            MsgError("Error en movimiento, no se encuentra detalles")
        End If

        Dim wArticulos = DC.T_Articulos.ToList()
        lNumeroMov.Text = "Detalle movimiento : " & wMovimiento.Movimiento
        Dim wListaDetalle = New List(Of MovDetalle)

        For Each wArticulo In wDetalle
            Dim wDescripcionArticulo = ""
            Dim wValidarArticulo = wArticulos.FirstOrDefault(Function(x) x.Articulo = wArticulo.Articulo)
            If wValidarArticulo IsNot Nothing Then wDescripcionArticulo = wValidarArticulo.Descripcion
            Dim wItem = New MovDetalle With {
                .Movimiento = wMovimiento.Movimiento,
                .TipoMov = wMovimiento.TipoMov,
                .Articulo = wArticulo.Articulo,
                .Barra = wArticulo.Barra,
                .Cantidad = Convert.ToDecimal(wArticulo.Cantidad),
                .Precio = wArticulo.Precio.ToText(NumericFormat.Money),
                .Descripcion = wDescripcionArticulo.Trim()}
            wListaDetalle.Add(wItem)
        Next
        MovDetalleBindingSource.Load(wListaDetalle)
    End Sub

    Private Sub bImprimirMovimiento_Click(sender As Object, e As EventArgs) Handles bImprimirMovimiento.Click
        If xTabla.Rows.Count = 0 Then
            MsgError("Debe seleccionar un movimiento en la tabla movimientos")
            Exit Sub
        End If
        Dim wMovimiento = CType(xTablaMovimientos.CurrentRow.DataBoundItem, MovEncabezado)
        Cursor = Cursors.WaitCursor

        Dim wMovGs = SQL("Select MG.Movimiento,TM.DescTipo, MG.Fecha,L.Local,L.NombreLocal,B.Bodega,B.NombreBodega,UR.NombreUsr as UsrResponsable,UC.NombreUsr as UsrCreador,E.DescEstado," &
                      " TD.DescTipoDoc,MG.Numdoc,MG.ObsTra,A.Articulo,A.Descripcion,MD.Barra,MD.Cantidad,MD.Precio,A.SKU" &
                      " FROM MovGen MG" &
                      " JOIN TipoMov TM ON MG.TipoMov = TM.TipoMov" &
                      " JOIN Locales L ON MG.Local = L.Local" &
                      " JOIN Bodegas B ON MG.Bodega = B.Bodega" &
                      " JOIN Usuarios UR ON MG.Responsable = UR.Usuario" &
                      " JOIN Usuarios UC ON MG.Usuario = UC.Usuario" &
                      " JOIN Estados E ON MG.Estado = E.Estado and E.Tipo = 'V'" &
                      " LEFT JOIN TipoDoc TD ON MG.TipoDoc = TD.TipoDoc" &
                      " JOIN MovDet MD ON MG.Movimiento = MD.Movimiento" &
                      " JOIN Articulos A ON MD.Articulo = A.Articulo WHERE MG.Movimiento = '" & wMovimiento.Movimiento & "'")


        Dim wLista = New List(Of MovimientoReporte)
        For Each wMovG As DataRow In wMovGs.Rows
            wLista.Add(New MovimientoReporte With {.Movimiento = wMovG.GetInt("Movimiento"),
                                                      .TipoMov = wMovG.GetText("DescTipo"),
                                                      .Fecha = wMovG.GetDate("Fecha"),
                                                      .Local = wMovG.GetText("Local"),
                                                      .NombreLocal = wMovG.GetText("NombreLocal"),
                                                      .Bodega = wMovG.GetText("Bodega"),
                                                      .NombreBodega = wMovG.GetText("NombreBodega"),
                                                      .UsuarioC = wMovG.GetText("UsrResponsable"),
                                                      .UsuarioR = wMovG.GetText("UsrCreador"),
                                                      .Estado = wMovG.GetText("DescEstado"),
                                                      .TipoDoc = wMovG.GetText("DescTipoDoc"),
                                                      .NumDoc = wMovG.GetInt("NumDoc"),
                                                      .Observacion = wMovG.GetText("ObsTra"),
                                                      .Articulo = wMovG.GetText("Articulo"),
                                                      .SKU = wMovG.GetText("SKU"),
                                                      .Descripcion = wMovG.GetText("Descripcion"),
                                                      .Barra = wMovG.GetText("Barra"),
                                                      .Cantidad = wMovG.GetInt("Cantidad"),
                                                      .PVenta = wMovG.GetNum("Precio")})
        Next

        If wLista.Count > 0 Then
            Dim wReporte As New ReporteMovimiento
            Dim wparamtros = ParametroReporte()
            wReporte.Database.Tables(0).SetDataSource(wLista)
            wReporte.Database.Tables(1).SetDataSource(wparamtros)
            VisorReportes.MostrarReporte(wReporte)
            VisorReportes.WinDeco1.TituloVentana = "Movimiento"
            VisorReportes.Show()
            VisorReportes.BringToFront()
            Auditoria(Me.Text, A_IMPRESO, wMovimiento.Movimiento.ToString(), "")
            Cursor = Cursors.Arrow
        Else
            Cursor = Cursors.Arrow
            MsgError("No se encuentran datos para la selección indicada")
        End If

    End Sub
End Class
Public Class MovEncabezado
    <DisplayName("Movimiento")>
    Public Property Movimiento As Decimal
    Public Property Fecha As String
    <Browsable(False)>
    Public Property TipoMov As String
    <DisplayName("Tipo Movimiento")>
    Public Property DescripcionTipoMov As String
    <Browsable(False)>
    Public Property Local As Decimal
    <DisplayName("Local")>
    Public Property NombreLocal As String
    <Browsable(False)>
    Public Property Bodega As Decimal
    <DisplayName("Bodega")>
    Public Property NombreBodega As String
    <Browsable(False)>
    Public Property Usuario As String
    <DisplayName("Usuario Creador")>
    Public Property NombreUsuario As String
    <Browsable(False)>
    Public Property Responsable As String
    <DisplayName("Usuario Responsable")>
    Public Property NombreResponsable As String
    <Browsable(False)>
    Public Property TipoDocRef As String
    <DisplayName("Tipo Doc. Referencia")>
    Public Property DescripcionTipoDocRef As String
    <DisplayName("Documento Ref")>
    Public Property NumDocRef As Decimal
End Class
Public Class MovDetalle
    <Browsable(False)>
    Public Property Movimiento As Decimal
    <Browsable(False)>
    Public Property TipoMov As String
    <DisplayName("Artículo")>
    Public Property Articulo As Decimal
    <DisplayName("Descripción")>
    Public Property Descripcion As String
    Public Property Barra As String
    Public Property Cantidad As Decimal
    Public Property Precio As String
End Class