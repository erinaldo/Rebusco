
Public Class Principal

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripManager.Renderer = New Styles.CustomRenderer()
        Visible = True
        DoEvents()
        Text &= $" {VERSION}"
        CargarImpresoras()
        ActualizarStatus.Start()
    End Sub

    Private Sub Principal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CargarServidores()
        MostrarParametros()
        IndicadoresBGW.RunWorkerAsync()
    End Sub

    Sub MostrarParametros()

        Try
            gParametros.Visible = False
            Cursor = Cursors.WaitCursor
            DoEvents()


            If Not ObtenerParametros() Then
                MsgError("Error al obtener parámetros del sistema (Base de datos).", "Error crítico")
                End
            End If

            If Not CargarLocales() Then
                MsgError("Error al cargar locales.", "Error crítico")
                End
            End If

            Imagen.Image = G_LOGO
            DTE.Parametros_DTE(G_LOCALACTUAL)

            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim PAR = DC.T_Parametros().FirstOrDefault()
            If PAR Is Nothing Then
                End
            End If

            lUsuario.Text = NombreUsuarioActual
            lVersion.Text = $"{VERSION} {FechaDespliegue}"
            lConexion.Text = CONFIGURACION.IPServidor
            lLocal.Text = NombreLocalActual
            lBase.Text = CONFIGURACION.Base
            lDTE.Text = DTE.FE_IP
            lAmbiente.Text = IIf(G_DEMO, "DEMO", IIf(DTE.FE_Ambiente = 80, "Producción", "Homologación")).ToString

            Dim Loc = SQL("Select Top 1 Clave from Parametros").Top
            lKey.Text = Loc.GetText("Clave")
            G_IDCLIENTE = Loc.GetText("Clave")


            'Menu Principal por Contrato. Habilitar módulos contratados
            If PAR.Documentos Then
                mMenuDocumentos.Visible = True
                bEmitirDocumentos.Visible = True
            Else
                mMenuDocumentos.Visible = False
                bEmitirDocumentos.Visible = False
            End If
            If PAR.Ventas Then
                mMenuVentas.Visible = True
                bVentaLocal.Visible = True
                bCuadraturaCajas.Visible = True
            Else
                mMenuVentas.Visible = False
                bVentaLocal.Visible = False
                bCuadraturaCajas.Visible = False
            End If
            If PAR.DTE Then mMenuDTE.Visible = True Else mMenuDTE.Visible = False
            If PAR.Web Then
                mMenuWeb.Visible = True
                bClick_Collect.Visible = True
            Else
                mMenuWeb.Visible = False
                bClick_Collect.Visible = False
            End If
            If PAR.Distribucion Then
                mMenuDistribucion.Visible = True
                bStockDocumentos.Visible = True
            Else
                mMenuDistribucion.Visible = False
                bStockDocumentos.Visible = False
            End If
            If PAR.Servicios Then
                mMenuServicios.Visible = True
                bServicioTecnico.Visible = True
                bIngresoOT.Visible = True
            Else
                mMenuServicios.Visible = False
                bServicioTecnico.Visible = False
                bIngresoOT.Visible = False
            End If
            If PAR.Cobranzas Then
                mMenuCobranzas.Visible = True
                bControlPagos.Visible = True
            Else
                mMenuCobranzas.Visible = False
                bControlPagos.Visible = False
            End If
            If PAR.Stocks Then
                mMenuStocks.Visible = True
                bConsultaStocks.Visible = True
                bMovimientos.Visible = True
            Else
                mMenuStocks.Visible = False
                bConsultaStocks.Visible = False
                bMovimientos.Visible = False
            End If
            If PAR.Remuneraciones Then mMenuRemuneraciones.Visible = True Else mMenuRemuneraciones.Visible = False
            If PAR.Consultas Then
                mMenuConsultas.Visible = True
                bBuscarArticulo.Visible = True
            Else
                mMenuConsultas.Visible = False
                bBuscarArticulo.Visible = False
            End If
            If PAR.Tablas Then mMenuTablas.Visible = True Else mMenuTablas.Visible = False


            If G_IDCLIENTE = Clientes.Wikets Then
                bVentaLocal.Visible = False
                bStockDocumentos.Visible = False
                bCuadraturaCajas.Visible = False
            End If

            Dim bod = ObtenerTipoBodega(G_LOCALACTUAL, "P")
            G_BODEGA = bod.Key
            NombreBodegaActual = bod.Value
            lBodega.Text = bod.Value


            cLocal.Enabled = (LocalUsuario = 0 Or G_ACCESOUSUARIO = 9)

            AplicarPermisosUsuario()

            If UsuarioActual = "RIC" Then bTest.Visible = True

        Catch ex As Exception
            MsgError(ex.Message, "Excepción al iniciar")
            End
        End Try
        Cursor = Cursors.Arrow
        gParametros.Visible = True
    End Sub


    Private Function CargarLocales() As Boolean
        Try
            RemoveHandler cLocal.SelectedIndexChanged, AddressOf cLocal_SelectedIndexChanged
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim locales = DC.T_Locales.Select(Function(x) New ItemCombo With {.ID = CStr(x.Local), .Desc = x.NombreLocal}).ToList
            If Not locales.Any Then Return False
            cLocal.ValueMember = "ID"
            cLocal.DisplayMember = "Desc"
            cLocal.DataSource = locales
            cLocal.SelectedValue = G_LOCALACTUAL.ToString()
            NombreLocalActual = cLocal.Text.Trim()
            AddHandler cLocal.SelectedIndexChanged, AddressOf cLocal_SelectedIndexChanged
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub cLocal_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cLocal.Text <> "" Then
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim seleccionado = cLocal.SelectedValue.ToString.ToDecimal()
            Dim wLoc = DC.T_Locales.FirstOrDefault(Function(x) x.Local = seleccionado)
            If wLoc IsNot Nothing Then
                G_LOCALACTUAL = wLoc.Local
                NombreLocalActual = wLoc.NombreLocal
                lLocal.Text = wLoc.NombreLocal
                Dim bod = ObtenerTipoBodega(G_LOCALACTUAL, "P")
                G_BODEGA = bod.Key
                lBodega.Text = bod.Value
            End If
        End If
    End Sub

    Private Sub Salir_click(sender As System.Object, e As System.EventArgs) Handles mMenuSalir.Click
        If Not Pregunta("¿Desea salir de MarketONE?") Then
            Exit Sub
        End If
        End
    End Sub

    Private Sub Menu_Principal_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Pregunta("¿Desea salir de MarketONE?") Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub Imagen_Click(sender As Object, e As EventArgs) Handles Imagen.Click

        If Not G_PROGRAMADOR Then Exit Sub

        Dim BuscarImagen As OpenFileDialog = New OpenFileDialog()

        Try
            If Not G_PROGRAMADOR Then Exit Sub
            If Not Pregunta("¿Deseas Cambiar el Logo?") Then Exit Sub

            BuscarImagen.Title = "Imagen a Subir (4x2 cm. aprox.)"
            BuscarImagen.InitialDirectory = Application.LocalUserAppDataPath
            BuscarImagen.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif"
            BuscarImagen.RestoreDirectory = True

            If Not BuscarImagen.ShowDialog() = DialogResult.OK Then Exit Sub

            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wPar = DC.T_Parametros.FirstOrDefault()
            If wPar IsNot Nothing Then
                wPar.Logo1 = DTE.Leer_JPG(BuscarImagen.FileName)
                DC.SubmitChanges()
                Dim MatrizImagen() As Byte = CType(wPar.Logo1, Byte())
                Dim ImagenMemoria As New IO.MemoryStream(MatrizImagen)
                Imagen.Image = Image.FromStream(ImagenMemoria)
            Else
                MsgError("Error al leer parámetros del sistema")
            End If

            Dim wLocal = DC.T_Locales()

            For Each wL In wLocal
                wL.Logo = DTE.Leer_JPG(BuscarImagen.FileName)
                DC.SubmitChanges()
            Next
        Catch ex As Exception
            MsgError("Error al Cargar imagen" + vbCrLf + ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub mConsultaTipoDoc_Click(sender As Object, e As EventArgs) Handles mConsultaDocumentos.Click
        Dim wConsulta As New ConsultaTabla
        wConsulta.ConsultaTabla("Tipo de Documentos", "TipoDocumento")
        wConsulta.Show()
        wConsulta.BringToFront()
    End Sub

    Private Sub mConsulta_Unidades_Medidas_Click(sender As Object, e As EventArgs) Handles mConsultaUnidadMedidas.Click
        Dim wConsulta As New ConsultaTabla
        wConsulta.ConsultaTabla("Unidades de Medida", "Unidades")
        wConsulta.Show()
        wConsulta.BringToFront()
    End Sub

    Private Sub mConsulta_de_Tipo_de_Movimientos_Click(sender As Object, e As EventArgs) Handles mConsultaTipoMov.Click
        Dim wConsulta As New ConsultaTabla
        wConsulta.ConsultaTabla("Tipo de Movimientos", "TipoMovimiento")
        wConsulta.Show()
        wConsulta.BringToFront()
    End Sub

    Private Sub mConsulta_Usuarios_Click(sender As Object, e As EventArgs) Handles mConsulta_Usuarios.Click
        Dim wConsulta As New ConsultaTabla
        wConsulta.ConsultaTabla("Usuarios", "Usuarios")
        wConsulta.Show()
        wConsulta.BringToFront()
    End Sub

    Private Sub mConsulta_Accesos_Click(sender As Object, e As EventArgs) Handles mConsultaTipoAcceso.Click
        Dim wConsulta As New ConsultaTabla
        wConsulta.ConsultaTabla("Accesos", "Accesos")
        wConsulta.Show()
        wConsulta.BringToFront()
    End Sub

    Private Sub mConsulta_Ciudades_Click(sender As Object, e As EventArgs)
        Dim wConsulta As New ConsultaTabla
        wConsulta.ConsultaTabla("Ciudades", "Ciudades")
        wConsulta.Show()
        wConsulta.BringToFront()
    End Sub

    Private Sub ConsultaDeEstadosDeClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim wConsulta As New ConsultaTabla
        wConsulta.ConsultaTabla("Estado de Clientes", "EstadoClientes")
        wConsulta.Show()
        wConsulta.BringToFront()
    End Sub

    Private Sub AplicarPermisosUsuario()

        Try

            Dim ItemsVisibles As New List(Of ToolStripMenuItem)
            Dim MenusVisibles As New List(Of ToolStripMenuItem)

            'Obtener listado de módulos habilitados.
            Dim Per = SQL("Select Modulo, M.Menu, (SELECT COUNT(*) FROM PermisosUsuario " &
               " R WHERE R.Modulo = M.Modulo And Usuario = '" & UsuarioActual & "') " &
               " AS 'Habilitado' FROM Modulos M")

            'Mostrar módulos habilitados / Ocultar y desactivar módulos deshabilitados
            For Each wRow As DataRow In Per.Rows
                Dim wMenuItem As String = wRow.GetText("Menu")

                Dim wHabilitado = (wRow.GetInt("Habilitado") = 1)
                'Console.WriteLine(wMenuItem.Substring(0, 1).ToLower)
                Select Case wMenuItem.Substring(0, 1).ToLower
                    Case "m" 'Menú - Item
                        Dim wItem As ToolStripMenuItem = BuscarItem(Barra, wMenuItem)

                        If Not wHabilitado Then
                            If wItem IsNot Nothing Then wItem.Visible = False : wItem.Enabled = False
                        Else
                            If wItem IsNot Nothing Then
                                ItemsVisibles.Add(wItem)
                                wItem.Visible = True : wItem.Enabled = True
                            End If
                        End If
                    Case "b" 'Botón
                        Dim wBoton As Button = BuscarBoton(Me, wMenuItem)
                        If Not wHabilitado Then
                            If wBoton IsNot Nothing Then wBoton.Visible = False : wBoton.Enabled = False
                        Else
                            If wBoton IsNot Nothing Then wBoton.Visible = True : wBoton.Enabled = True
                        End If
                    'Funcionalidades
                    Case "f"
                        Select Case wMenuItem
                            Case "fCambiarLocal"
                                'F_CAMBIAR_LOCAL = wHabilitado
                            Case "fCambiarServidor"
                                'F_CAMBIO_SERVIDOR = wHabilitado
                            Case "fVerValorizacion"
                                F_VERVALORIZACION = wHabilitado
                            Case "fVerCosto"
                                F_VERCOSTO = wHabilitado
                        End Select
                End Select
            Next



            'Determinar menus que contienen ítems habilitados.
            For Each wItem As ToolStripMenuItem In ItemsVisibles
                While wItem.OwnerItem IsNot Nothing
                    wItem = CType(wItem.OwnerItem, ToolStripMenuItem)
                    If MenusVisibles.Contains(wItem) Then Continue While
                    MenusVisibles.Add(wItem)
                    If wItem.Visible Then Continue While
                End While
                If wItem.OwnerItem Is Nothing And Not MenusVisibles.Contains(wItem) Then
                    MenusVisibles.Add(wItem)
                End If
            Next

            'Remover separadores continuos.
            For Each wMenu As ToolStripMenuItem In MenusVisibles
                Dim wSeparadorAnterior As Boolean = False

                Dim wSubItems As New List(Of ToolStripItem)

                For Each wItem As ToolStripItem In wMenu.DropDownItems
                    wSubItems.Add(wItem)
                Next

                wSubItems = wSubItems.Where(Function(x) x.Enabled = True).ToList

                Dim wIndice As Integer = 0
                For Each wSubItem As ToolStripItem In wSubItems
                    wIndice += 1

                    If wSubItem.Text <> "" Then 'Not wSubItem.GetType Is GetType(ToolStripSeparator)
                        wSeparadorAnterior = False
                        Continue For
                    End If

                    If wSeparadorAnterior Then
                        wSubItems(wIndice - 2).Visible = False : wSubItems(wIndice - 2).Enabled = False
                    End If

                    wSeparadorAnterior = True
                    If wIndice = wSubItems.Count Or wIndice = 1 Then
                        wSubItem.Visible = False : wSubItem.Enabled = False
                    End If

                Next

                wSubItems = wSubItems.Where(Function(x) x.Enabled = True).ToList
                If wSubItems.Count > 0 AndAlso wSubItems(0).Text = "" Then
                    wSubItems(0).Enabled = False : wSubItems(0).Visible = False
                End If
            Next

            'Ocultar Menus que no tienen Items habilitados
            For Each wItem As ToolStripMenuItem In MenusVisibles
                If wItem.DropDownItems.Count > 0 Then
                    Dim wMostrar As Boolean = False
                    For Each wSubItem As ToolStripItem In wItem.DropDownItems
                        If wSubItem.Text <> "" And wSubItem.Enabled Then
                            wMostrar = True
                            Exit For
                        End If
                    Next
                    wItem.Visible = wMostrar : wItem.Enabled = wMostrar
                End If
            Next

        Catch ex As Exception
        End Try
    End Sub
    Public Function BuscarBoton(ByVal Parent As Control, wNombre As String) As Button
        Dim wControles As Control() = Parent.Controls.Find(wNombre, True)
        If wControles.Any Then
            Return DirectCast(Parent.Controls.Find(wNombre, True)(0), Button)
        End If
        Return Nothing
    End Function

    Private Sub bTest_Click(sender As Object, e As EventArgs) Handles bTest.Click
        Test.Show()
    End Sub

    Private Sub mIngresoDeDocumentos_Click(sender As Object, e As EventArgs) Handles mIngresoDeDocumentos.Click
        EmisionDocumentos.Show()
        EmisionDocumentos.BringToFront()
    End Sub

    Private Sub mImpresiónDeDocumentos_Click(sender As Object, e As EventArgs) Handles mImpresiónDeDocumentos.Click
        ImprimirDocumentos.Show()
        ImprimirDocumentos.BringToFront()
    End Sub

    Private Sub mAnulaionDeDocumentosElectronicos_Click(sender As Object, e As EventArgs) Handles mAnulaionDeDocumentosElectronicos.Click
        AnularDocumentoElectronico.Show()
        AnularDocumentoElectronico.BringToFront()
    End Sub

    Private Sub mAnulacionDeDocumentosNoElectronicos_Click(sender As Object, e As EventArgs) Handles mAnulacionDeDocumentosNoElectronicos.Click
        AnularDocumento.Show()
        AnularDocumento.BringToFront()
    End Sub

    Private Sub mConsultaDeOT_Click(sender As Object, e As EventArgs) Handles mConsultaDeOT.Click
        ConsultaOT.Show()
        ConsultaOT.BringToFront()
    End Sub

    Private Sub mRepuestoParaOT_Click(sender As Object, e As EventArgs) Handles mRepuestoParaOT.Click
        ConsultaRepuestosOT.Show()
        ConsultaRepuestosOT.BringToFront()
    End Sub

    Private Sub mAnulaciónDeOT_Click(sender As Object, e As EventArgs) Handles mAnulaciónDeOT.Click
        AnularOT.Show()
        AnularOT.BringToFront()
    End Sub

    Private Sub mRepuestosPendientes_Click(sender As Object, e As EventArgs) Handles mRepuestosPendientes.Click
        Abastecimiento.Show()
        Abastecimiento.BringToFront()
    End Sub

    Private Sub mStocksPorDocumento_Click(sender As Object, e As EventArgs) Handles mStocksPorDocumento.Click
        StockPorDocumento.Show()
        StockPorDocumento.BringToFront()
    End Sub

    Private Sub mMovimientoDeStocksPOS_Click(sender As Object, e As EventArgs) Handles mMovimientoDeStocksPOS.Click
        MovimientoStockPOS.Show()
        MovimientoStockPOS.BringToFront()
    End Sub

    Private Sub mListadosDeMovimientos_Click(sender As Object, e As EventArgs) Handles mListadosDeMovimientos.Click
        ListadoMovimientos.Show()
        ListadoMovimientos.BringToFront()
    End Sub

    Private Sub mImprimirMovimientos_Click(sender As Object, e As EventArgs) Handles mImprimirMovimientos.Click
        ImprimirMovimiento.Show()
        ImprimirDocumentos.BringToFront()
    End Sub

    Private Sub mModificarStocks_Click(sender As Object, e As EventArgs) Handles mModificarStocks.Click
        ConsultaStock.Show()
        ConsultaStock.BringToFront()
    End Sub

    Private Sub mMovimientos_Click(sender As Object, e As EventArgs) Handles mMovimientos.Click
        Movimientos.Show()
        Movimientos.BringToFront()
    End Sub

    Private Sub mListadoDeTomaDeInventario_Click(sender As Object, e As EventArgs) Handles mListadoDeTomaDeInventario.Click
        ListadoTomaInventario.Show()
        ListadoTomaInventario.BringToFront()
    End Sub

    Private Sub mListadoDeStocks_Click(sender As Object, e As EventArgs) Handles mListadoDeStocks.Click
        ListadoStock.Show()
        ListadoStock.BringToFront()
    End Sub

    Private Sub mTransformarArtículo_Click(sender As Object, e As EventArgs) Handles mTransformarArtículo.Click
        TransformacionArticulos.Show()
        TransformacionArticulos.BringToFront()
    End Sub

    Private Sub mEnvíoDTE_Click(sender As Object, e As EventArgs) Handles mEnvíoDTE.Click
        EnviarDTE.Show()
        EnviarDTE.BringToFront()
    End Sub

    Private Sub mConsultarDocumentosAlDTE_Click(sender As Object, e As EventArgs) Handles mConsultarDocumentosAlDTE.Click
        ConsultarDTE.Show()
        ConsultarDTE.BringToFront()
    End Sub

    Private Sub mControlDTE_Click(sender As Object, e As EventArgs) Handles mControlDTE.Click
        ControlDTEEmitidos.Show()
        ControlDTEEmitidos.BringToFront()
    End Sub

    Private Sub mCargaDeArchivosCAFDeSII_Click(sender As Object, e As EventArgs) Handles mCargaDeArchivosCAFDeSII.Click
        CargaCAF.Show()
        CargaCAF.BringToFront()
    End Sub

    Private Sub mManCliente_Click(sender As Object, e As EventArgs) Handles mManCliente.Click
        ManCliente.Show()
        ManCliente.BringToFront()
    End Sub

    Private Sub mMantenciónDeAccesos_Click(sender As Object, e As EventArgs) Handles mMantenciónDeAccesos.Click
        ManAccesos.Show()
        ManAccesos.BringToFront()
    End Sub

    Private Sub mManAFP_Click(sender As Object, e As EventArgs) Handles mManAFP.Click
        ManAFPs.Show()
        ManAFPs.BringToFront()
    End Sub

    Private Sub mManBodega_Click(sender As Object, e As EventArgs) Handles mManBodega.Click
        ManBodega.Show()
        ManBodega.BringToFront()
    End Sub

    Private Sub mPermisos_Click(sender As Object, e As EventArgs) Handles mPermisos.Click
        ManPermisos.Show()
        ManPermisos.BringToFront()
    End Sub

    Private Sub mConsultaAuditoria_Click(sender As Object, e As EventArgs) Handles mConsultaAuditoria.Click
        ConsultaAuditoria.Show()
        ConsultaAuditoria.BringToFront()
    End Sub

    Private Sub mManArticulo_Click(sender As Object, e As EventArgs) Handles mManArticulo.Click
        ManArticulos.Show()
        ManArticulos.BringToFront()
    End Sub

    Private Sub mManUnidadesMedidas_Click(sender As Object, e As EventArgs) Handles mManUnidadesMedidas.Click
        ManUnidades.Show()
        ManUnidades.BringToFront()
    End Sub

    Private Sub mManFamilia_Click(sender As Object, e As EventArgs) Handles mManFamilia.Click
        ManFamilia.Show()
        ManFamilia.BringToFront()
    End Sub

    Private Sub mMantenciónDeSubFamilias_Click(sender As Object, e As EventArgs) Handles mMantenciónDeSubFamilias.Click
        ManSubFamilia.Show()
        ManSubFamilia.BringToFront()
    End Sub

    Private Sub mManLocal_Click(sender As Object, e As EventArgs) Handles mManLocal.Click
        ManLocales.Show()
        ManLocales.BringToFront()
    End Sub

    Private Sub mManMovimiento_Click(sender As Object, e As EventArgs) Handles mManMovimiento.Click
        ManTipoMov.Show()
        ManTipoMov.BringToFront()
    End Sub

    Private Sub mManUsuarios_Click(sender As Object, e As EventArgs) Handles mManUsuarios.Click
        ManUsuarios.Show()
        ManUsuarios.BringToFront()
    End Sub
    Private Sub mManEventos_Click(sender As Object, e As EventArgs) Handles mManEventos.Click
        ManEventosRem.Show()
        ManEventosRem.BringToFront()
    End Sub

    Private Sub mCalculoDeRemuneraciones_Click(sender As Object, e As EventArgs) Handles mCalculoDeRemuneraciones.Click
        CalculoRem.Show()
        CalculoRem.BringToFront()
    End Sub

    Private Sub mCambioDeProducto_Click(sender As Object, e As EventArgs) Handles mCambioDeProducto.Click
        CambioProducto.Show()
        CambioProducto.BringToFront()
    End Sub

    Private Sub mAnularMovimiento_Click(sender As Object, e As EventArgs) Handles mAnularMovimiento.Click
        AnularMovimiento.Show()
        AnularMovimiento.BringToFront()
    End Sub

    Private Sub mCierreDeStocksMensual_Click(sender As Object, e As EventArgs) Handles mCierreDeStocksMensual.Click
        CierreStockMes.Show()
        CierreStockMes.BringToFront()
    End Sub

    Public Function BuscarItem(ByVal Parent As MenuStrip, wNombre As String) As ToolStripMenuItem
        Dim wItem As ToolStripMenuItem
        Dim wSubItem As ToolStripMenuItem
        For Each wItem In Parent.Items.OfType(Of ToolStripMenuItem)

            If TypeOf wItem IsNot ToolStripMenuItem Then Continue For

            If wItem.Name = wNombre Then
                Return wItem
            End If
            If wItem.HasDropDownItems Then
                wSubItem = BuscarItem(wItem, wNombre)
                If wSubItem IsNot Nothing Then Return wSubItem
            End If
        Next
        Return Nothing
    End Function

    Public Function BuscarItem(ByVal Parent As ToolStripMenuItem, wNombre As String) As ToolStripMenuItem
        Dim wItem As ToolStripMenuItem
        Dim wSubItem As ToolStripMenuItem
        For Each wItem In Parent.DropDownItems.OfType(Of ToolStripMenuItem)

            If TypeOf wItem IsNot ToolStripMenuItem Then Continue For

            If wItem.Name = wNombre Then
                Return wItem
            End If
            If wItem.HasDropDownItems Then
                wSubItem = BuscarItem(wItem, wNombre)
                If wSubItem IsNot Nothing Then Return wSubItem
            End If
        Next
        Return Nothing
    End Function

    Private Sub mConsultaBodega_Click(sender As Object, e As EventArgs) Handles mConsultaBodega.Click
        ConsultaBodegas.Show()
        ConsultaBodegas.BringToFront()
    End Sub

    Private Sub mConsultaCorrelativo_Click(sender As Object, e As EventArgs) Handles mConsultaCorrelativo.Click
        ConsultaCorrelativos.Show()
        ConsultaCorrelativos.BringToFront()
    End Sub

    Private Sub mConsultaDeEstados_Click(sender As Object, e As EventArgs) Handles mConsultaDeEstados.Click
        ConsultaEstados.Show()
        ConsultaEstados.BringToFront()
    End Sub

    Private Sub mConsultaEventosRem_Click(sender As Object, e As EventArgs) Handles mConsultaEventosRem.Click
        ConsultaEventosRem.Show()
        ConsultaEventosRem.BringToFront()
    End Sub

    Private Sub ConsultaDeFamiliasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeFamiliasToolStripMenuItem.Click
        ConsultaFamilias.Show()
        ConsultaFamilias.BringToFront()
    End Sub

    Private Sub mConsultaFPagos_Click(sender As Object, e As EventArgs) Handles mConsultaFPagos.Click
        Dim wConsulta As New ConsultaTabla
        wConsulta.ConsultaTabla("Forma de Pagos", "FormaPagos")
        wConsulta.Show()
        wConsulta.BringToFront()
    End Sub

    Private Sub mConsultaAbonos_Click(sender As Object, e As EventArgs) Handles mConsultaAbonos.Click
        ConsultaAbonos.Show()
        ConsultaAbonos.BringToFront()
    End Sub

    Private Sub mConsultaArticulos_Click(sender As Object, e As EventArgs) Handles mConsultaArticulos.Click
        ConsultaArticulos.Show()
        ConsultaArticulos.BringToFront()
    End Sub

    Private Sub mCierreDeRemuneraciones_Click(sender As Object, e As EventArgs) Handles mCierreDeRemuneraciones.Click
        CierreRemuneraciones.Show()
        CierreRemuneraciones.BringToFront()
    End Sub

    Private Sub mAnularEventosDeRemuneraciones_Click(sender As Object, e As EventArgs) Handles mAnularEventosDeRemuneraciones.Click
        AnularEventoRem.Show()
        AnularEventoRem.BringToFront()
    End Sub

    Private Sub mIngresoDeEventos_Click(sender As Object, e As EventArgs) Handles mIngresoDeEventos.Click
        IngresoEventosRem.Show()
        IngresoEventosRem.BringToFront()
    End Sub

    Private Sub mCréditosDePersonal_Click(sender As Object, e As EventArgs) Handles mCréditosDePersonal.Click
        CreditoPersona.Show()
        CreditoPersona.BringToFront()
    End Sub

    Private Sub mImprimirLiquidaciónDeSueldos_Click(sender As Object, e As EventArgs) Handles mImprimirLiquidaciónDeSueldos.Click
        ImprimirLiquidaciones.Show()
        ImprimirLiquidaciones.BringToFront()
    End Sub

    Private Sub mImprimirPlanillaDeRemuneraciones_Click(sender As Object, e As EventArgs) Handles mImprimirPlanillaDeRemuneraciones.Click
        ImprimirPlanillaRem.Show()
        ImprimirPlanillaRem.BringToFront()
    End Sub

    Private Sub mImprimirEventosDeRemuneraciones_Click(sender As Object, e As EventArgs) Handles mImprimirEventosDeRemuneraciones.Click
        ImprimirEventosRem.Show()
        ImprimirEventosRem.BringToFront()
    End Sub

    Private Sub ConsultaDePreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDePreciosToolStripMenuItem.Click
        ConsultaPrecios.Show()
        ConsultaPrecios.BringToFront()
    End Sub

    Private Sub mContadoresDTE_Click(sender As Object, e As EventArgs) Handles mContadoresDTE.Click
        Contadores_DTE.Show()
        Contadores_DTE.BringToFront()
    End Sub

    Private Sub mControlDTEProveedor_Click(sender As Object, e As EventArgs) Handles mControlDTEProveedor.Click
        ControlDTEProveedores.Show()
        ControlDTEProveedores.BringToFront()
    End Sub

    Private Sub bMovimientos_Click(sender As Object, e As EventArgs)
        Movimientos.Show()
        Movimientos.BringToFront()
    End Sub

    Private Sub IndicadoresBGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles IndicadoresBGW.RunWorkerCompleted
        Dim valores As ValoresIndicadores = CType(e.Result, ValoresIndicadores)

        If valores Is Nothing Then Return
        Dim G_UTM = valores.UTM
        Dim G_DOLAR = valores.Dolar
        Dim G_UF = valores.UF
        Dim G_UF_MES = valores.UF_MES

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wUF As New T_UFs
        Dim qUF = DC.T_UFs.FirstOrDefault(Function(x) x.Año = Now.Year And x.Mes = Now.Month)
        If qUF IsNot Nothing Then wUF = qUF
        wUF.Año = Now.Year
        wUF.Año = Now.Month
        wUF.UF = G_UF_MES
        wUF.UTM = G_UTM

        If qUF Is Nothing Then
            DC.T_UFs.InsertOnSubmit(wUF)
        End If
        DC.SubmitChanges()
    End Sub

    Private Sub IndicadoresBGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles IndicadoresBGW.DoWork
        Try

            Return


            Dim Valores As New ValoresIndicadores

            Valores.UTM = Val(Indicadores.GetUTM().UTMs.UTM.Valor.Replace(".", ""))
            Valores.Dolar = Val(Indicadores.GetDolar().Dolares.Dolar.Valor.Replace(".", "").Replace(",", "."))
            Valores.UF = Val(Indicadores.GetUF().UFs.UF.Valor.Replace(".", "").Replace(",", "."))
            Dim lastday = New DateTime(Now.Year, Now.Month, DateTime.DaysInMonth(Now.Year, Now.Month))
            Valores.UF_MES = Val(Indicadores.GetUF(lastday).UFs.UF.Valor.Replace(".", "").Replace(",", "."))

            e.Result = Valores

        Catch ex As Exception
            e.Result = Nothing
        End Try

    End Sub

    Private Sub mManUf_Click(sender As Object, e As EventArgs) Handles mManUf.Click
        ManUF.Show()
        ManUF.BringToFront()
    End Sub

    Private Sub mManCorrelativo_Click(sender As Object, e As EventArgs) Handles mManCorrelativo.Click
        ManCorrelativos.Show()
        ManCorrelativos.BringToFront()
    End Sub

    Private Sub mMantenciónDePOS_Click(sender As Object, e As EventArgs) Handles mMantenciónDePOS.Click
        ManPOS.Show()
        ManPOS.BringToFront()
    End Sub

    Private Sub mImpresiónDeEtiquetas_Click(sender As Object, e As EventArgs) Handles mImpresiónDeEtiquetas.Click
        GenerarEtiquetas.Show()
        GenerarEtiquetas.BringToFront()
    End Sub

    Private Sub mGenerarArchivoParaBancos_Click(sender As Object, e As EventArgs) Handles mGenerarArchivoParaBancos.Click
        GenerarArchivoBanco.Show()
        GenerarArchivoBanco.BringToFront()
    End Sub

    Private Sub LimpiarBodegasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarBodegasToolStripMenuItem.Click
        LimpiarStocksBodega.Show()
        LimpiarStocksBodega.BringToFront()
    End Sub

    Private Sub mManPrevisionSalud_Click(sender As Object, e As EventArgs) Handles mManPrevisionSalud.Click
        ManPrevisionSalud.Show()
        ManPrevisionSalud.BringToFront()
    End Sub

    Private Sub ControlCorrelativosFiscalesCOFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsumoFoliosToolStripMenuItem.Click
        ConsumoFolios.Show()
        ConsumoFolios.BringToFront()
    End Sub

    Private Sub bConsultarStock_Click(sender As Object, e As EventArgs)
        ConsultaStock.Show()
        ConsultaStock.BringToFront()
    End Sub

    Private Sub ConsultaDeDocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeDocumentosToolStripMenuItem.Click
        ConsultaDocumento.Show()
        ConsultaDocumento.BringToFront()
    End Sub

    Private Sub StatusServicioTécnicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusServicioTécnicoToolStripMenuItem.Click
        Status_ST.Show()
        Status_ST.BringToFront()
    End Sub

    Private Sub VentasporCajaToolStripMenuItem(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        Cuadratura
    End Sub

    Sub Cuadratura()
        VentasCaja.Show()
        VentasCaja.BringToFront()
        VentasCaja.bImprimir.Enabled = True
        VentasCaja.bConsultar.Enabled = True
        If G_ACCESOUSUARIO >= 5 Then
            VentasCaja.cLocal.Enabled = True
        Else
            VentasCaja.cLocal.Enabled = False
        End If
    End Sub

    Private Sub ConsultaDeAtencionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeAtencionesToolStripMenuItem.Click
        ConsultarAtenciones.Show()
        ConsultarAtenciones.BringToFront()
    End Sub

    Private Sub CambioDeFormaDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioDeFormaDePagoToolStripMenuItem.Click
        CambioFPago.Show()
        CambioFPago.BringToFront()
    End Sub

    Private Sub mCambioPrecio_Click(sender As Object, e As EventArgs) Handles mCambioPrecio.Click
        CambioPrecios.Show()
        CambioPrecios.BringToFront()
    End Sub

    Private Sub mControlDeBicicletas_Click(sender As Object, e As EventArgs) Handles mControlDeBicicletas.Click
        ConsultarDatoBicicleta.Show()
        ConsultarDatoBicicleta.BringToFront()
    End Sub

    Private Sub bVerConfig_Click(sender As Object, e As EventArgs) Handles bVerConfig.Click
        Informacion("El archivo Json de configuración contiene los parámetros básicos para el funcionamiento del sistema." & vbCrLf & vbCrLf &
                    "Antes de realizar modificaciones realice un respaldo de sus contenido." & vbCrLf & vbCrLf &
                    "Luego de realizar modificaciones en este archivo, guárdelo, cierre MarketONE y ejecútelo nuevamente.")
        CONFIGURACION.Open()
    End Sub

    Public Sub CargarServidores()

        cServidor.ValueMember = "ID"
        cServidor.DisplayMember = "Desc"
        Dim servidores = New List(Of ItemCombo)
        For Each ser In CONFIGURACION.ServidoresEmpresas
            Dim item = New ItemCombo(ser.IP, ser.Empresa)
            servidores.Add(item)
        Next

        cServidor.DataSource = servidores
        cServidor.SelectedValue = CONFIGURACION.IPServidor

        CargarBases()

        AddHandler cServidor.SelectedIndexChanged, AddressOf CargarBases

    End Sub

    Private Sub CargarBases(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing)
        'Cargar bases de datos MarketONE_ disponibles en combo inferior        
        cBase.Items.Clear()

        Dim servidor = cServidor.SelectedValue.ToString()

        Cursor = Cursors.WaitCursor

        Dim task = ProbarConexionServidor(servidor, "master")

        Dim restablecerBase = False

        If Not task.Result Then

            If task.IsCompleted Then
                MsgError("Los parámetros de conexión son incorrectos. " & vbCrLf &
                         "Es posible que la dirección del servidor esté inaccesible." & vbCrLf &
                     $"{servidor}", "Error de conexión")
            Else
                MsgError("Se agotó el tiempo de respuesta con el servidor seleccionado." & vbCrLf &
                     $"{servidor}", "Error de conexión")
            End If

            RemoveHandler cServidor.SelectedIndexChanged, AddressOf CargarBases
            cServidor.SelectedValue = CONFIGURACION.IPServidor
            AddHandler cServidor.SelectedIndexChanged, AddressOf CargarBases

            servidor = CONFIGURACION.IPServidor

            restablecerBase = True
            'Cursor = Cursors.Default
            'Exit Sub
        End If

        RemoveHandler cBase.SelectedIndexChanged, AddressOf cBase_SelectedIndexChanged

        Using con = New SqlClient.SqlConnection(String.Format(PATRONCONEXION, servidor, "master"))
            con.Open()
            Dim query = "SELECT name as Nombre FROM   master.sys.databases  " &
                        "WHERE Cast(CASE WHEN name  " &
                        "IN ('master', 'model', 'msdb', 'tempdb', 'ReportServer', 'ReportServerTempDB')  " &
                        "THEN 1 ELSE is_distributor END AS bit) = 0 " &
                        "AND Name LIKE '%MarketONE%' ORDER BY name"
            Using cmd = New SqlClient.SqlCommand(query, con)
                Dim dt = New DataTable()
                Using adap As New SqlClient.SqlDataAdapter(cmd)
                    adap.Fill(dt)
                End Using
                If dt.Rows.Count > 0 Then
                    For Each bas As DataRow In dt.Rows
                        cBase.Items.Add(bas.GetValue("Nombre").ToString())
                    Next

                End If
            End Using
        End Using

        If cBase.Items.Count > 0 Then
            If restablecerBase Or sender Is Nothing Then cBase.Text = CONFIGURACION.Base
            AddHandler cBase.SelectedIndexChanged, AddressOf cBase_SelectedIndexChanged
        End If

            Cursor = Cursors.Default
    End Sub


    Private Sub cBase_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cServidor.Text = "" Then Exit Sub

        Cursor = Cursors.WaitCursor
        Dim servidor = cServidor.SelectedValue.ToString()
        Dim base = cBase.Text

        Dim task = ProbarConexionServidor(servidor, base)

        If task.Result Then

            CONFIGURACION.IPServidor = servidor
            CONFIGURACION.Base = base
            CONFIGURACION.Empresa = base.Replace("MarketONE_", "")

            MostrarParametros()

        Else

            If task.IsCompleted Then
                MsgError("Los parámetros de conexión son incorrectos. " & vbCrLf &
                         "Es posible que la dirección del servidor esté inaccesible " &
                         "o no se pueda abrir la base de datos seleccionada." & vbCrLf &
                     $"{servidor} : {base}", "Error de conexión")
            Else
                MsgError("Se agotó el tiempo de respuesta con el servidor seleccionado" & vbCrLf &
                     $"{servidor} : {base}", "Error de conexión")
            End If

            RemoveHandler cServidor.SelectedIndexChanged, AddressOf CargarBases
            cServidor.SelectedValue = CONFIGURACION.IPServidor
            AddHandler cServidor.SelectedIndexChanged, AddressOf CargarBases

        End If

        Cursor = Cursors.Default
    End Sub

    Private Sub mConsultaTracking_Click(sender As Object, e As EventArgs) Handles mConsultaTracking.Click
        ConsultaTracking.Show()
        ConsultaTracking.BringToFront()
    End Sub

    Private Sub CargarImpresoras()
        RemoveHandler cImpresoras.SelectedIndexChanged, AddressOf cImpresoras_SelectedIndexChanged
        Dim impresoras As New List(Of String)
        For Each imp As String In Printing.PrinterSettings.InstalledPrinters
            impresoras.Add(imp)
        Next
        cImpresoras.DataSource = impresoras
        cImpresoras.Text = PrinterEx.Default_PrinterName
        AddHandler cImpresoras.SelectedIndexChanged, AddressOf cImpresoras_SelectedIndexChanged
    End Sub
    Private Sub cImpresoras_SelectedIndexChanged(sender As Object, e As EventArgs)
        PrinterEx.Default_PrinterName = cImpresoras.Text
    End Sub

    Private Sub ActualizarStatus_Tick(sender As Object, e As EventArgs) Handles ActualizarStatus.Tick
        CargarImpresoras()
    End Sub

    Private Sub mConsultaDeKardex_Click(sender As Object, e As EventArgs) Handles mConsultaDeKardex.Click
        ConsultaKardex.Show()
        ConsultaKardex.BringToFront()
    End Sub

    Private Sub WinDeco1_Load(sender As Object, e As EventArgs) Handles WinDeco1.Load

    End Sub

    Private Sub ClickCollectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClickCollectToolStripMenuItem.Click
        Click_Collect.Show()
        Click_Collect.BringToFront()
    End Sub

    Private Sub bClick_Collect_Click(sender As Object, e As EventArgs) Handles bClick_Collect.Click
        Click_Collect.Show()
        Click_Collect.BringToFront()
    End Sub

    Private Sub AnulaciónDeTicketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnulaciónDeTicketsToolStripMenuItem.Click
        AnularTik.Show()
        AnularTik.BringToFront()
    End Sub

    Private Sub bConsultaStocks_Click(sender As Object, e As EventArgs) Handles bConsultaStocks.Click
        ConsultaStock.Show()
        ConsultaStock.BringToFront()
    End Sub

    Private Sub bVentaLocal_Click(sender As Object, e As EventArgs) Handles bVentaLocal.Click
        VentaLocal.Show()
        VentaLocal.BringToFront()
    End Sub

    Private Sub bEmitirDocumentos_Click(sender As Object, e As EventArgs) Handles bEmitirDocumentos.Click
        EmisionDocumentos.Show()
        EmisionDocumentos.BringToFront()
    End Sub

    Private Sub bCuadraturaCajas_Click(sender As Object, e As EventArgs) Handles bCuadraturaCajas.Click
        Cuadratura()
    End Sub

    Private Sub bControlPagos_Click(sender As Object, e As EventArgs) Handles bControlPagos.Click
        ControlPagos.Show()
        ControlPagos.BringToFront()
    End Sub

    Private Sub mControlPagos_Click(sender As Object, e As EventArgs) Handles mControlPagos.Click
        ControlPagos.Show()
        ControlPagos.BringToFront()
    End Sub

    Private Sub mVentaSucursal_Click(sender As Object, e As EventArgs) Handles mVentaLocal.Click
        VentaLocal.Show()
        VentaLocal.BringToFront()
    End Sub

    Private Sub bStockDocumentos_Click(sender As Object, e As EventArgs) Handles bStockDocumentos.Click
        StockPorDocumento.Show()
        StockPorDocumento.BringToFront()
    End Sub

    Private Sub bMovimientos_Click_1(sender As Object, e As EventArgs) Handles bMovimientos.Click
        Movimientos.Show()
        Movimientos.BringToFront()
    End Sub

    Private Sub bServicioTecnico_Click(sender As Object, e As EventArgs) Handles bServicioTecnico.Click
        ServicioTecnico.Show()
        ServicioTecnico.BringToFront()
    End Sub

    Private Sub bBuscarArticulo_Click(sender As Object, e As EventArgs) Handles bBuscarArticulo.Click
        Dim wBuscador = New BuscadorArticulo(True)
        wBuscador.ShowDialog()
    End Sub

    Private Sub bIngresoOT_Click(sender As Object, e As EventArgs) Handles bIngresoOT.Click
        IngresoOT.Show()
        IngresoOT.BringToFront()
    End Sub

    Private Sub mIngresoDeOT_Click(sender As Object, e As EventArgs) Handles mIngresoDeOT.Click
        IngresoOT.Show()
        IngresoOT.BringToFront()
    End Sub

    Private Sub cServidor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cServidor.SelectedIndexChanged

    End Sub
End Class


'Sub CargarServidores()

'    Cursor = Cursors.WaitCursor

'    Dim seleccionado = False
'    For Each ser In CONFIGURACION.ServidoresEmpresas
'        Dim radio As New RadioButton
'        radio.FlatStyle = FlatStyle.Flat
'        radio.AutoSize = False
'        radio.BackColor = Color.White
'        radio.Cursor = Cursors.Hand
'        radio.Appearance = Appearance.Button
'        radio.UseVisualStyleBackColor = False
'        radio.ImageAlign = ContentAlignment.MiddleLeft
'        radio.TextImageRelation = TextImageRelation.ImageBeforeText
'        radio.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 146, 213)
'        radio.FlatAppearance.MouseDownBackColor = Color.FromArgb(71, 103, 150)
'        radio.FlatAppearance.CheckedBackColor = Color.FromArgb(10, 87, 139)
'        radio.FlatAppearance.BorderColor = Color.FromArgb(10, 87, 139)
'        radio.ForeColor = Color.FromArgb(29, 73, 140)
'        radio.Size = New Size(171, 31)
'        radio.Text = ser.Empresa
'        radio.Tag = ser.IP
'        radio.Cursor = Cursors.Hand

'        AddHandler radio.CheckedChanged, AddressOf wCheck_CheckedChanged

'        If Not seleccionado AndAlso ser.IP = CONFIGURACION.IPServidor Then
'            radio.Image = My.Resources.database_check
'            radio.Checked = True
'            seleccionado = True
'        Else
'            radio.Image = My.Resources.database_delete2
'            radio.Checked = False
'        End If

'        pServidores.Controls.Add(radio)
'    Next

'    Cursor = Cursors.Arrow

'End Sub

'Dim UltimoServidor As RadioButton

'Private Sub wCheck_CheckedChanged(sender As Object, e As EventArgs)

'    Dim ServidorSeleccionado As RadioButton = DirectCast(sender, RadioButton)

'    Dim servidor = ServidorSeleccionado.Tag.ToString
'    ServidorSeleccionado.ForeColor = If(ServidorSeleccionado.Checked, Color.White, Color.FromArgb(29, 73, 140))
'    ServidorSeleccionado.Image = If(ServidorSeleccionado.Checked, My.Resources.Resources.database_check,
'                                                    My.Resources.Resources.database_delete2)

'    If Not ServidorSeleccionado.Checked Then Return

'    DoEvents()
'    Cursor = Cursors.WaitCursor

'    Dim task = Threading.Tasks.Task.Factory.StartNew(Function() ProbarConexion(servidor, CONFIGURACION.Base))
'    task.Wait(P_TIEMPOCONEXION)

'    If task.Result Then
'        CONFIGURACION.IPServidor = ServidorSeleccionado.Tag.ToString
'        UltimoServidor = ServidorSeleccionado
'        MostrarParametros()
'    Else

'        If task.IsCompleted Then
'            MsgError("Los parámetros de conexión son incorrectos" & vbCrLf &
'                     $"{servidor} : {CONFIGURACION.Base}", "Error de conexión")
'        Else
'            MsgError("Se agotó el tiempo de respuesta con el servidor seleccionado" & vbCrLf &
'                     $"{servidor} : {CONFIGURACION.Base}", "Error de conexión")
'        End If

'        RemoveHandler UltimoServidor.CheckedChanged, AddressOf wCheck_CheckedChanged
'        UltimoServidor.Checked = True
'        UltimoServidor.ForeColor = Color.White
'        UltimoServidor.Image = My.Resources.Resources.database_check
'        AddHandler UltimoServidor.CheckedChanged, AddressOf wCheck_CheckedChanged
'    End If
'    Cursor = Cursors.Default
'End Sub


