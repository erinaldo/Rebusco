Imports System.IO
Imports System.Linq

Public Class ManArticulos

    Const T_ELIMINAR = 0
    Const T_COPIAR = 1
    Const T_DIRECTORIOIMAGEN = 2
    Const T_COPIADO = 3
    Const T_NOMBREJPG = 4

    Dim wFamilia, wSubFamilia, wUnidad As String

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        Nuevo()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub ManArticulos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Nuevo()
        cUnidad.LoadItemsObj("Unidades", "Unidad", "DescUnidad")
        cUnidad.SelectedIndex = 0
        cFamilia.LoadItemsObj("Familias", "Familia", "DescFamilia")
        cFamilia.SelectedIndex = 0
        cEstado.LoadItemsObj("Estados", "Estado", "DescEstado", " WHERE Tipo='A'")
        cTipo.LoadItemsObj("TipoArticulo", "TipoArticulo", "Descripcion")
        cEstado.Text = "ACTIVO"
        Auditoria(Text, A_INGRESADO, "", "")
        xAño.Value = Now.Year
        'LimpiarCampos(Me)
        xIva.Text = G_IVA.ToString
        xArticulo.Focus()
        xArticulo.SelectAll()
    End Sub

    Private Sub ManArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = True
        DoEvents()
    End Sub

    Private Sub xUnidad_Validating(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles xUnidad.Validating
        If xUnidad.Text.Trim <> "" Then
            cUnidad.SelectedValue = xUnidad.Text.Trim
            If cUnidad.Text = "" Then
                xUnidad.Clear()
                xUnidad.Focus()
            End If
        End If
    End Sub

    Private Sub xFamilia_Validating(Optional sender As Object = Nothing, Optional e As System.ComponentModel.CancelEventArgs = Nothing) Handles xFamilia.Validating
        ValidarDigitos(sender)
        If xFamilia.Text.Trim <> "" Then
            cFamilia.SelectedValue = xFamilia.Text.Trim
            If cFamilia.Text = "" Then
                xFamilia.Clear()
                xFamilia.Focus()
                Exit Sub
            End If
            cSubFamilia.LoadItemsObj("SubFamilias", "SubFamilia", "DescSubFamilia", "WHERE Familia=" & Val(xFamilia.Text) & "")
            cSubFamilia.SelectedIndex = -1
        End If
    End Sub

    Private Sub xSubFamilia_Validating(Optional sender As Object = Nothing, Optional e As System.ComponentModel.CancelEventArgs = Nothing) Handles xSubfamilia.Validating
        ValidarDigitos(sender)
        If Trim(xSubfamilia.Text) = "" Then
            cSubFamilia.SelectedIndex = -1
            Exit Sub
        End If

        If xSubfamilia.Text.Trim <> "" Then
            cSubFamilia.SelectedValue = xSubfamilia.Text.Trim
            If cSubFamilia.Text = "" Then
                xSubfamilia.Clear()
                xSubfamilia.Focus()
            End If
        End If
    End Sub
    Private Sub cUnidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cUnidad.SelectedIndexChanged
        If cUnidad.Text <> "" Then
            xUnidad.Text = cUnidad.SelectedValue.ToString
        Else
            xUnidad.Clear()
        End If
    End Sub

    Private Sub cFamilia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cFamilia.SelectedIndexChanged
        If cFamilia.Text <> "" Then
            xFamilia.Text = cFamilia.SelectedValue.ToString
            cSubFamilia.DataSource = Nothing
            cSubFamilia.Items.Clear()
            cSubFamilia.LoadItemsObj("SubFamilias", "SubFamilia", "DescSubFamilia", "WHERE Familia=" & Val(xFamilia.Text) & "", False, "0", "SIN SUB-FAMILIA")
            cSubFamilia.SelectedIndex = -1
        Else
            xFamilia.Clear()
        End If
    End Sub

    Private Sub cSubFamilia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cSubFamilia.SelectedIndexChanged
        If cSubFamilia.Text <> "" Then
            xSubfamilia.Text = cSubFamilia.SelectedValue.ToString
        Else
            xSubfamilia.Clear()
        End If
    End Sub
    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim wMensaje As String() = {MSG_MODIFICADO, A_MODIFICADO}

        If Trim(xArticulo.Text) = "" Then
            MsgError("Debe ingresar un Artículo")
            xArticulo.Focus()
            Exit Sub
        End If
        If Trim(xDescripcion.Text) = "" Then
            MsgError("Debe ingresar una Descripción")
            xDescripcion.Focus()
            Exit Sub
        End If
        If Trim(xUnidad.Text) = "" Or Trim(cUnidad.Text) = "" Then
            MsgError("Debe ingresar una Unidad")
            xUnidad.Focus()
            Exit Sub
        End If
        If Trim(xFamilia.Text) = "" Or Trim(cFamilia.Text) = "" Then
            MsgError("Debe ingresar un tipo de Familia")
            xFamilia.Focus()
            Exit Sub
        End If
        If Trim(xSubfamilia.Text) = "" Or Trim(cSubFamilia.Text) = "" Then
            'If cSubFamilia.DataSource Is Nothing And cFamilia.Text = "" Then
            MsgError("Debe ingresar una Sub Familia")
            xSubfamilia.Focus()
            'End If
            Exit Sub
        End If
        If Val(xCosto.Text) <= 0 Then
            MsgError("Debe ingresar un Costo")
            xCosto.Focus()
            Exit Sub
        End If
        If Val(xPrecioVenta.Text) <= 0 Then
            MsgError("Debe ingresar un Precio de Venta")
            xPrecioVenta.Focus()
            Exit Sub
        End If
        If Trim(cEstado.Text) = "" Then
            MsgError("Debe ingresar un Estado para el Artículo")
            cEstado.Focus()
            Exit Sub
        End If
        If cTipo.Text = "" Then
            MsgError("Debe seleccionar tipo de artículo")
            cTipo.Focus()
            Exit Sub
        End If
        If xSKU.Text.Trim <> "" Then
            Dim wSKU = SQL("SELECT * FROM Articulos WHERE SKU = '" & xSKU.Text.Trim & "'").Top
            If wSKU IsNot Nothing Then
                If wSKU.GetText("Articulo") <> xArticulo.Text.Trim Then
                    MsgError("El SKU indicado pertenece a otro Artículo")
                    Exit Sub
                End If
            End If
        End If

        Cursor = Cursors.WaitCursor
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim art As New T_Articulos
        Dim qArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.ToDecimal)

        Dim wCorrelativo = SiguienteCorrelativo("Articulos", "Articulo").ToString

        If qArt IsNot Nothing Then art = qArt

        art.Descripcion = Trim(xDescripcion.Text)
        art.Unidad = Trim(xUnidad.Text)
        art.Familia = xFamilia.Text.ToDecimal
        art.SubFamilia = xSubfamilia.Text.ToDecimal
        art.Marca = xMarca.Text.ToUpper
        art.Cliente = Convert.ToDecimal(G_CLIENTEACTUAL)
        art.SKU = Trim(xSKU.Text)
        art.Modelo = xModelo.Text.ToUpper
        art.Costo = xCosto.Text.ToDecimal
        art.PVenta = xPrecioVenta.Text.ToDecimal
        art.Oferta = oOferta.Checked
        art.ActivoFijo = oActivoFijo.Checked
        art.MaxDescuento = xDescuento.Value
        art.ActivoFijo = oOferta.Checked
        art.Ano = xAño.Value
        art.Grupo = xGrupo.Text.ToUpper
        art.Categoria = xCategoria.Text.ToUpper
        art.Estado = cEstado.SelectedValue.ToString
        art.iIVA = xIva.Text.ToDecimal
        art.iEXE = oExento.Checked
        art.iMIN = xMinerales.Text.ToDecimal
        art.iBEB = xBebidas.Text.ToDecimal
        art.iVIN = xVinos.Text.ToDecimal
        art.iCER = xCervezas.Text.ToDecimal
        art.iLIC = xLicores.Text.ToDecimal
        art.iCAR = xCarne.Text.ToDecimal
        art.iHAR = xHarina.Text.ToDecimal
        art.iTAB = xTabaco.Text.ToDecimal
        art.iFEP = xPetroleo.Text.ToDecimal
        art.iLOG = xLogistica.Text.ToDecimal
        art.iOTRO = xOtro.Text.ToDecimal
        art.DetalleProducto = xDetalle.Text.Trim
        art.TipoArticulo = cTipo.SelectedValue.ToString
        art.Destacado = oProductoDestactado.Checked
        art.DestacadoComunidad = oDestacadoComunidad.Checked
        art.VisibleWeb = oVisibleWeb.Checked
        art.UsuarioModificacion = UsuarioActual
        art.FechaModificacion = Now


        Dim ArticuloNuevo As Boolean = False
        If qArt Is Nothing Then
            art.Articulo = wCorrelativo.ToDecimal()
            art.UsuarioCreacion = UsuarioActual
            art.FechaCreacion = Now
            DC.T_Articulos.InsertOnSubmit(art)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
            ArticuloNuevo = True
        End If

        DC.SubmitChanges()

        Cursor = Cursors.Default
        Auditoria(Me.Text, wMensaje(1), wCorrelativo, xDescripcion.Text)
        Mensaje(wMensaje(0))

        If ArticuloNuevo Then
            Tracking.Ingresar(Tracking.Eventos.ArticuloCreado, Now, 0, "", 0, Now, art.Articulo, 0, G_BODEGA, G_LOCALACTUAL, "", Me.Text)
        Else
            Tracking.Ingresar(Tracking.Eventos.ArticuloModificado, Now, 0, "", 0, Now, art.Articulo, 0, G_BODEGA, G_LOCALACTUAL, "", Me.Text)
        End If

        If ArticuloNuevo Then
            CrearStock(wCorrelativo)
            xArticulo.Focus()
            xArticulo.SelectAll()
            If Pregunta("Desea Ingresar Códigos de Barra") Then
                Call Ingreso_Barras(sender, e)
            End If
        Else
            Nuevo()
        End If

    End Sub

    Public Sub CrearStock(wArticulo As String)
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wLocales = DC.T_Locales.ToList()
        For Each wLocal In wLocales
            Dim wBodegas = DC.T_Bodegas.ToList()
            For Each wBodega In wBodegas
                Stocks(wArticulo.ToDecimal, wBodega.Bodega, wLocal.Local, 0, ModoInventario.Crear)
                Tracking.Ingresar(Tracking.Eventos.StockCreado, Now, 0, "", 0, Now, wArticulo.ToDecimal(), 0, wBodega.Bodega, wLocal.Local, "", Me.Text)
            Next
        Next
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If Trim(xArticulo.Text) = "" Then
            MsgError("No hay un Artículo cargado")
            xArticulo.Focus()
            Exit Sub
        End If
        Dim wArt = SQL("Select Articulo FROM Articulos WHERE Articulo='" & Trim(xArticulo.Text) & "'").Top
        If wArt Is Nothing Then
            MsgError("El Artículo ingresado no existe")
            Nuevo()
            xArticulo.Clear()
            xArticulo.Focus()
            Exit Sub
        End If
        wArt = SQL("SELECT Articulo FROM DocumentosD WHERE Articulo='" & Trim(xArticulo.Text) & "'").Top
        If wArt IsNot Nothing Then
            If Pregunta("¿Desea eliminar este Artículo?") Then
                SQL("DELETE Articulos WHERE Articulo='" & Trim(xArticulo.Text) & "'")
                Auditoria(Text, A_ELIMINADO, xArticulo.Text, xDescripcion.Text)
                Mensaje("Artículo Eliminado Correctamente")
                Nuevo()
                xArticulo.Clear()
                xArticulo.Focus()
            End If
        Else
            MsgError("No se Puede eliminar este Artículo, Se encuentra utilizado en otro registro")
            Exit Sub
        End If
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(xSKU)
    End Sub

    Private Sub xOtro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xVinos.KeyPress, xTabaco.KeyPress, xPetroleo.KeyPress, xLicores.KeyPress, xIva.KeyPress, xHarina.KeyPress, xCarne.KeyPress, xBebidas.KeyPress
        ValidarDigitos(e)
    End Sub

    Private Sub xOtro_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xVinos.Validating, xTabaco.Validating, xPetroleo.Validating, xLicores.Validating, xIva.Validating, xHarina.Validating, xCarne.Validating, xBebidas.Validating
        ValidarDigitos(sender, 2)
    End Sub

    Private Sub xCosto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xPrecioVenta.Validating, xCosto.Validating
        ValidarDigitos(sender)
    End Sub

    Private Sub xSubfamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xSubfamilia.KeyPress
        e.NextControl(xCosto)
    End Sub

    Private Sub xSKU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xSKU.KeyPress
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(xUnidad)
    End Sub

    Private Sub xUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xUnidad.KeyPress
        e.NextControl(xFamilia)
    End Sub

    Private Sub xFamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xFamilia.KeyPress
        e.NextControl(xSubfamilia)
    End Sub

    Private Sub xCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCosto.KeyPress
        e.NextControl(xMargen)
    End Sub

    Private Sub xPrecioVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xPrecioVenta.KeyPress
        e.NextControl(xDescuento)
    End Sub

    Private Sub xMaxDescuento_KeyPress(sender As Object, e As KeyPressEventArgs)
        ValidarDigitos(e)
        e.NextControl(xMarca)
    End Sub

    Private Sub xMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMarca.KeyPress
        e.NextControl(xModelo)
    End Sub

    Private Sub xModelo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xModelo.KeyPress
        e.NextControl(xCategoria)
    End Sub

    Private Sub xCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCategoria.KeyPress
        e.NextControl(xGrupo)
    End Sub

    Private Sub xGrupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xGrupo.KeyPress
        e.NextControl(xAño)
    End Sub

    Private Sub xAño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xAño.KeyPress
        e.NextControl(xDetalle)
    End Sub

    Private Sub bImagenes_Click(sender As Object, e As EventArgs) Handles bImagenes.Click
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim art = xArticulo.Text.ToDecimal
        If Not DC.T_Articulos.Any(Function(x) x.Articulo = art) Then
            MsgError("Este artículo no existe")
            Exit Sub
        End If

        If xArticulo.Text.Trim = "" Then Exit Sub
        Dim wForm As New CargarImagenes
        wForm.CargarDirectorio($"Cargar Imágenes de Artículo: {xArticulo.Text}", xArticulo.Text)
        wForm.ShowDialog()
    End Sub

    Private Sub Nuevo(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bNuevo.Click
        LimpiarCampos(Me)
        If oExento.Checked Then
            xIva.Text = "0"
        Else
            xIva.Text = G_IVA.ToString
        End If
        cEstado.Text = "ACTIVO"
        bGuardar.Text = "Guardar"
        oExento.Checked = False
        xArticulo.AutoCompletarActivo = False
        xArticulo.Text = SiguienteCorrelativo("Articulos", "Articulo").ToString
        xArticulo.Focus()
        xArticulo.SelectAll()
        xArticulo.AutoCompletarActivo = True
    End Sub

    Private Sub Ingreso_Barras(sender As Object, e As EventArgs) Handles bBarras.Click
        If xArticulo.Text.Trim = "" Then
            MsgError("Debe indicar artículo")
            Exit Sub
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wArticulo = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.ToDecimal)
        If wArticulo Is Nothing Then
            MsgError("El artículo no esta creado, guarde el artículo y luego ingrese las Barras")
            Exit Sub
        End If
        ManBarras.xArticulo.AutoCompletarActivo = False
        ManBarras.xArticulo.Text = xArticulo.Text.Trim
        ManBarras.xArticulo_Validating()
        ManBarras.xArticulo.AutoCompletarActivo = True
        ManBarras.ShowDialog()
    End Sub

    Private Sub xUnidad_TextChanged(sender As Object, e As EventArgs) Handles xUnidad.TextChanged

    End Sub

    Private Sub xFamilia_TextChanged(sender As Object, e As EventArgs) Handles xFamilia.TextChanged

    End Sub

    Private Sub xCosto_TextChanged(sender As Object, e As EventArgs) Handles xCosto.TextChanged

    End Sub

    Public Sub xArticulo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xArticulo.Validating
        Dim wEncontrado As Boolean = False
        Dim DC = New MarketONEDataContext(P_CONEXION)
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
            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wIDArticulo.ToDecimal())
            If wArt IsNot Nothing Then
                xArticulo.Text = wArt.Articulo.ToString()
                wEncontrado = True
            End If

        Else
            xArticulo.AutoCompletarActivo = False
            'xArticulo.Text = xArticulo.IdEncontrado
            xDescripcion.Text = xArticulo.DescEncontrada
            xArticulo.Text = xArticulo.IdEncontrado
            xArticulo.AutoCompletarActivo = True
            wEncontrado = True
        End If

        If wEncontrado Then
            xArticulo.AutoCompletarActivo = False
            Dim wArticulo = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.Trim.ToDecimal)
            xArticulo.Text = wArticulo.Articulo.ToString
            xDescripcion.Text = wArticulo.Descripcion
            xSKU.Text = wArticulo.SKU
            xUnidad.Text = wArticulo.Unidad
            xUnidad_Validating()
            xFamilia.Text = wArticulo.Familia.ToString
            xFamilia_Validating()
            xSubfamilia.Text = wArticulo.SubFamilia.ToString
            xSubFamilia_Validating()
            xCosto.Text = wArticulo.Costo.ToString
            xPrecioVenta.Text = wArticulo.PVenta.ToString
            xIva.Text = wArticulo.iIVA.ToString
            xMarca.Text = wArticulo.Marca
            xModelo.Text = wArticulo.Modelo
            xCategoria.Text = wArticulo.Categoria
            xGrupo.Text = wArticulo.Grupo
            xDetalle.Text = wArticulo.DetalleProducto
            cTipo.SelectedValue = wArticulo.TipoArticulo
            oOferta.Checked = wArticulo.Oferta
            oActivoFijo.Checked = wArticulo.ActivoFijo
            xAño.Value = wArticulo.Ano
            oExento.Checked = wArticulo.iEXE
            xMinerales.Text = wArticulo.iMIN.ToString
            xBebidas.Text = wArticulo.iBEB.ToString
            xVinos.Text = wArticulo.iVIN.ToString
            xCervezas.Text = wArticulo.iCER.ToString
            xLicores.Text = wArticulo.iLIC.ToString
            xCarne.Text = wArticulo.iCAR.ToString
            xHarina.Text = wArticulo.iHAR.ToString
            xTabaco.Text = wArticulo.iTAB.ToString
            xPetroleo.Text = wArticulo.iFEP.ToString
            xLogistica.Text = wArticulo.iLOG.ToString
            cEstado.SelectedValue = wArticulo.Estado
            xDescuento.Value = wArticulo.MaxDescuento
            oProductoDestactado.Checked = wArticulo.Destacado
            oDestacadoComunidad.Checked = wArticulo.DestacadoComunidad
            oVisibleWeb.Checked = wArticulo.VisibleWeb
            xArticulo.AutoCompletarActivo = True
            Exit Sub
        End If

        'Dim DC = New MarketONEDataContext(P_CONEXION)
        'Dim wEncontrado As Boolean = False
        'If xArticulo.ListaVisible Then
        '    If xArticulo.ListaActiva Then
        '        Exit Sub
        '    Else
        '        xArticulo.OcultarLista()
        '    End If
        'End If

        'If Trim(xArticulo.Text) = "" Then
        '    xDescripcion.Clear()
        '    Exit Sub
        'End If

        'Dim wArticulo = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.Trim.ToDecimal)
        'If xArticulo.DescEncontrada = "" Then
        '    If wArticulo IsNot Nothing Then
        '        wEncontrado = True
        '    Else
        '        wEncontrado = False
        '    End If
        'Else
        '    wEncontrado = True
        'End If

        'If wEncontrado Then
        '    xArticulo.Text = wArticulo.Articulo.ToString
        '    xDescripcion.Text = wArticulo.Descripcion
        '    xSKU.Text = wArticulo.SKU
        '    xUnidad.Text = wArticulo.Unidad
        '    xUnidad_Validating()
        '    xFamilia.Text = wArticulo.Familia.ToString
        '    xFamilia_Validating()
        '    xSubfamilia.Text = wArticulo.SubFamilia.ToString
        '    xSubFamilia_Validating()
        '    xCosto.Text = wArticulo.Costo.ToString
        '    xPrecioVenta.Text = wArticulo.PVenta.ToString
        '    xIva.Text = wArticulo.iIVA.ToString
        '    oExento.Checked = wArticulo.iEXE
        '    xMinerales.Text = wArticulo.iMIN.ToString
        '    xBebidas.Text = wArticulo.iBEB.ToString
        '    xVinos.Text = wArticulo.iVIN.ToString
        '    xCervezas.Text = wArticulo.iCER.ToString
        '    xLicores.Text = wArticulo.iLIC.ToString
        '    xCarne.Text = wArticulo.iCAR.ToString
        '    xHarina.Text = wArticulo.iHAR.ToString
        '    xTabaco.Text = wArticulo.iTAB.ToString
        '    xPetroleo.Text = wArticulo.iFEP.ToString
        '    xLogistica.Text = wArticulo.iLOG.ToString
        '    cEstado.SelectedValue = wArticulo.Estado
        'Else
        '    LimpiarCampos(Me, "xArticulo")
        'End If

    End Sub

    Private Sub xArticulo_ItemSeleccionado(wDescripcion As String) Handles xArticulo.ItemSeleccionado
        xSKU.Focus()
    End Sub

    Private Sub xCosto_GotFocus(sender As Object, e As EventArgs) Handles xCosto.GotFocus
        xCosto.SelectAll()
    End Sub

    Private Sub xMargen_GotFocus(sender As Object, e As EventArgs) Handles xMargen.GotFocus
        xMargen.SelectAll()
    End Sub

    Private Sub xPrecioVenta_GotFocus(sender As Object, e As EventArgs) Handles xPrecioVenta.GotFocus
        xPrecioVenta.SelectAll()
    End Sub

    Private Sub oExento_CheckedChanged(sender As Object, e As EventArgs) Handles oExento.CheckedChanged
        If oExento.Checked Then
            xIva.Text = "0"
        Else
            xIva.Text = G_IVA.ToString
        End If
    End Sub


    Private Sub xMargen_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xMargen.Validating
        Dim NuevoPrecio As Double
        Try
            NuevoPrecio = (CDbl(xCosto.Text) * (1 + CDbl(xMargen.Text) / 100))
            NuevoPrecio = (NuevoPrecio * (1 + CDbl(xIva.Text) / 100))
            NuevoPrecio = RedondeoPeso(NuevoPrecio)
            xPrecioVenta.Text = NuevoPrecio.ToString
        Catch ex As Exception
            xPrecioVenta.Text = "0"
        End Try
    End Sub

    Private Sub xMargen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMargen.KeyPress
        e.NextControl(xPrecioVenta)
    End Sub

End Class