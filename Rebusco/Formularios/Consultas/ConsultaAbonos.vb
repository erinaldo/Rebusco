Imports System.ComponentModel
Imports MarketONE

Public Class ConsultaAbonos
    Implements iFormulario
    Const T_NOMBRELOCAL = 0
    Const T_CLIENTE = 1
    Const T_FECHAABONO = 2
    Const T_MONTO = 3
    Const T_FPAGO = 4
    Const T_USUARIO = 5
    Const T_FECHAPAGO = 6
    Const T_DOCUMENTO = 7
    Const T_NUMERO = 8
    Const T_OBSERVACION = 9

    Sub Titulos()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 10

        xTabla.Cols(T_NOMBRELOCAL).Width = 130
        xTabla.Cols(T_CLIENTE).Width = 350
        xTabla.Cols(T_FECHAABONO).Width = 90
        xTabla.Cols(T_MONTO).Width = 80
        xTabla.Cols(T_FPAGO).Width = 120
        xTabla.Cols(T_USUARIO).Width = 300
        xTabla.Cols(T_FECHAPAGO).Width = 90
        xTabla.Cols(T_DOCUMENTO).Width = 120
        xTabla.Cols(T_NUMERO).Width = 90
        xTabla.Cols(T_OBSERVACION).Width = 120

        xTabla.Cols(T_NOMBRELOCAL).Caption = "Local"
        xTabla.Cols(T_CLIENTE).Caption = "Cliente"
        xTabla.Cols(T_FECHAABONO).Caption = "Fecha Abono"
        xTabla.Cols(T_MONTO).Caption = "Monto"
        xTabla.Cols(T_FPAGO).Caption = "Forma de Pago"
        xTabla.Cols(T_USUARIO).Caption = "Usuario"
        xTabla.Cols(T_FECHAPAGO).Caption = "Fecha Pago"
        xTabla.Cols(T_DOCUMENTO).Caption = "Documento"
        xTabla.Cols(T_NUMERO).Caption = "Número"
        xTabla.Cols(T_OBSERVACION).Caption = "Observación"

    End Sub
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub ConsultaAbonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc")
        cFPagos.LoadItemsObj("Fpagos", "Fpago", "DescFPago")
    End Sub

    Private Sub xNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNumero.KeyPress
        e.NextControl(cFPagos)
        ValidarDigitos(e)
    End Sub

    Private Sub dDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dDesde.KeyPress
        e.NextControl(dHasta)
    End Sub

    Private Sub dHasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dHasta.KeyPress
        e.NextControl(cLocal)
    End Sub

    Private Sub cLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cLocal.KeyPress
        e.NextControl(cTipoDoc)
    End Sub

    Private Sub cTipoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cTipoDoc.KeyPress
        e.NextControl(xNumero)
    End Sub

    Private Sub cFago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cFPagos.KeyPress
        e.NextControl(xNombreCliente)
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.NextControl(xVendedor)
        ValidarDigitos(e)
    End Sub

    Private Sub xVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xVendedor.KeyPress
        e.NextControl(bConsultar)
    End Sub

#Region "AutoCompletar"
    Private Sub xCliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xCliente.Validating
        If xCliente.ListaVisible Then
            If xCliente.ListaActiva Then
                Exit Sub
            Else
                xCliente.OcultarLista()
            End If
        End If

        If Trim(xCliente.Text) = "" Then
            xNombreCliente.Clear()
            Exit Sub
        End If
        xNombreCliente.Text = xCliente.DescEncontrada
    End Sub
    Private Sub xCliente_ItemSeleccionado(wDescripcion As String) Handles xCliente.ItemSeleccionado
        xNombreCliente.Text = wDescripcion
        xVendedor.Focus()
    End Sub

    Private Sub xVendedor_Validating(sender As Object, e As CancelEventArgs) Handles xVendedor.Validating

        If xVendedor.ListaVisible Then
            If xVendedor.ListaActiva Then
                Exit Sub
            Else
                xVendedor.OcultarLista()
            End If
        End If

        If Trim(xVendedor.Text) = "" Then
            xNombreVendedor.Clear()
            Exit Sub
        End If
        xNombreVendedor.Text = xVendedor.DescEncontrada
    End Sub

    Private Sub xVendedor_ItemSeleccionado(wDescripcion As String) Handles xVendedor.ItemSeleccionado
        xNombreVendedor.Text = wDescripcion
        bConsultar.Focus()
    End Sub

#End Region

    Private Sub bBuscarV_Click(sender As Object, e As EventArgs) Handles bBuscarV.Click
        Dim wQuery As String
        wQuery = "SELECT Usuario , NombreUsr as 'Nombre Usuario' From Usuarios"
        Buscador.Show()
        Buscador.Configurar(wQuery, "NombreUsr", Me, "Vendedores", xVendedor)
    End Sub

    Private Sub bBuscarC_Click(sender As Object, e As EventArgs) Handles bBuscarC.Click
        Dim wQuery As String
        wQuery = "SELECT Cliente as 'Cliente', Nombre as 'Nombre Cliente' From Clientes"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Nombre", Me, "Clientes", xCliente)
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        ObtenerAbonos("C")
    End Sub
    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        ObtenerAbonos("I")
    End Sub
    Sub ObtenerAbonos(wTipo As String)
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wListaAbono = DC.T_Abonos.Where(Function(x) x.FechaAbono >= dDesde.Value And x.FechaAbono <= dHasta.Value).ToList

        If cLocal.Text <> "" Then wListaAbono = wListaAbono.Where(Function(x) x.Local = CInt(cLocal.SelectedValue.ToString)).ToList
        If cTipoDoc.Text <> "" Then wListaAbono = wListaAbono.Where(Function(x) x.TipoDoc = cTipoDoc.SelectedValue.ToString).ToList
        If cFPagos.Text <> "" Then wListaAbono = wListaAbono.Where(Function(x) x.FPago = cFPagos.SelectedValue.ToString).ToList
        If xCliente.Text.Trim <> "" Then wListaAbono = wListaAbono.Where(Function(x) x.Cliente = CInt(xCliente.Text.Trim)).ToList
        If xVendedor.Text <> "" Then wListaAbono = wListaAbono.Where(Function(x) x.Usuario = xVendedor.Text.Trim).ToList
        If xNumero.Text.Trim <> "" Then wListaAbono = wListaAbono.Where(Function(x) x.NumDoc = CInt(xNumero.Text.Trim)).ToList
        If oPagados.Checked Then wListaAbono = wListaAbono.Where(Function(x) x.Estado = "C").ToList

        If wListaAbono.Any Then
            Dim wListaClientes = DC.T_Clientes.ToList
            Dim wListaEstados = DC.T_Estados.Where(Function(x) x.Tipo = "P").ToList
            Dim wListaFPagos = DC.T_FPagos.ToList
            Dim wListaLocales = DC.T_Locales.ToList
            Dim wListaTipoDoc = DC.T_TipoDoc.ToList
            Dim wListaUsuarios = DC.T_Usuarios.ToList

            Titulos()
            xTabla.Redraw = False
            tMensajeBarra.Text = "Cargando..."
            tBarraProgreso.Maximum = wListaAbono.Count
            tBarraProgreso.Value = 0
            tBarraProgreso.Visible = True

            If wTipo = "C" Then
                For Each wA In wListaAbono
                    xTabla.AddItem("")
                    xTabla.SetData(xTabla.Rows.Count - 1, T_NOMBRELOCAL, wListaLocales.FirstOrDefault(Function(x) x.Local = wA.Local).NombreLocal)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_CLIENTE, wListaClientes.FirstOrDefault(Function(x) x.Cliente = wA.Cliente).Nombre)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FECHAABONO, FormatDateTime(wA.FechaAbono, DateFormat.ShortDate))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_MONTO, FormatNumber(wA.Monto, 0,,, TriState.True))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGO, wListaFPagos.FirstOrDefault(Function(x) x.FPago = wA.FPago).DescFPago)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_USUARIO, wListaUsuarios.FirstOrDefault(Function(x) x.Usuario = wA.Usuario).NombreUsr)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FECHAPAGO, FormatDateTime(wA.FechaPago, DateFormat.ShortDate))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_DOCUMENTO, wListaTipoDoc.FirstOrDefault(Function(x) x.TipoDoc = wA.TipoDoc).DescTipoDoc)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_NUMERO, wA.NumDoc)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_OBSERVACION, "")
                    tBarraProgreso.Value += 1
                    DoEvents()
                Next

                xTabla.Redraw = True
                tMensajeBarra.Text = "Listo"
                tBarraProgreso.Visible = False
                tCantidadR.Text = "Cantidad de Registros : " & wListaAbono.Count
            Else

                Dim wListaReporte As New List(Of AbonosReporte)
                tMensajeBarra.Text = "Cargando Informe..."
                tBarraProgreso.Maximum = wListaAbono.Count
                tBarraProgreso.Value = 0
                tBarraProgreso.Visible = True

                For Each wA In wListaAbono
                    wListaReporte.Add(New AbonosReporte With {.Documento = wListaTipoDoc.FirstOrDefault(Function(x) x.TipoDoc = wA.TipoDoc).DescTipoDoc,
                                                          .Estado = wListaEstados.FirstOrDefault(Function(x) x.Estado = wA.Estado).DescEstado,
                                                          .FechaAbono = wA.FechaAbono,
                                                          .FechaPago = wA.FechaPago,
                                                          .FPago = wListaFPagos.FirstOrDefault(Function(x) x.FPago = wA.FPago).DescFPago,
                                                          .Monto = wA.Monto,
                                                          .NombreCliente = wListaClientes.FirstOrDefault(Function(x) x.Cliente = wA.Cliente).Nombre,
                                                          .NombreLocal = wListaLocales.FirstOrDefault(Function(x) x.Local = wA.Local).NombreLocal,
                                                          .Numero = wA.NumDoc,
                                                          .Observacion = wA.Observaciones,
                                                          .RutCliente = wListaClientes.FirstOrDefault(Function(x) x.Cliente = wA.Cliente).Rut,
                                                          .Usuario = wA.Usuario})
                    tBarraProgreso.Value += 1
                    DoEvents()
                Next

                tMensajeBarra.Text = "Listo"
                tBarraProgreso.Visible = False
                tCantidadR.Text = "Cantidad de Registros : " & wListaAbono.Count

                Dim wReporte As New ReporteAbonos
                Dim wListaParametros = ParametroReporte()
                wReporte.Database.Tables("MarKetONE_RT_Abonos").SetDataSource(wListaReporte)
                wReporte.Database.Tables("MarKetONE_ParametrosReporte").SetDataSource(wListaParametros)
                VisorReportes.MostrarReporte(wReporte)
                VisorReportes.Show()
                VisorReportes.BringToFront()
            End If
            Else
                MsgError("No se encuentran registros para los filtros indicados")
        End If
    End Sub


End Class