Imports System.ComponentModel

Public Class ManLocales
    Implements iFormulario

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub ManLocales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cCiudades.LoadItemsObj("Comunas", "Codigo", "NombreComuna", "Order By NombreComuna")
        cComunas.LoadItemsObj("Comunas", "Codigo", "NombreComuna", "Order By NombreComuna")
        bNuevo_Click()
        Auditoria(Me.Text, A_INGRESADO, "", "")
        xLocal.Focus()
    End Sub

    Private Sub bNuevo_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bNuevo.Click
        LimpiarCampos(Me)
        xLocal.Text = SiguienteCorrelativo("Locales", "Local").ToString()
        xTab.SelectTab(0)
        xNombre.Focus()
        bGuardar.Text = "Guardar"
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Dim wQuery As String = "SELECT Local, NombreLocal FROM Locales"
        Buscador.Show()
        Buscador.Configurar(wQuery, "NombreLocal", Me, "Locales", xLocal)
    End Sub

    Private Sub xLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xLocal.KeyPress
        ValidarDigitos(e)
        e.NextControl(xNombre)
    End Sub
    Private Sub xLocal_Validating(sender As Object, e As CancelEventArgs) Handles xLocal.Validating
        If xLocal.Text.Trim = "" Then Exit Sub
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wLocal = DC.T_Locales.FirstOrDefault(Function(x) x.Local = xLocal.Text.ToDecimal)

        If wLocal IsNot Nothing Then
            xNombre.Text = wLocal.NombreLocal
            xCliente.Text = wLocal.Cliente.ToString
            xCliente.Validate
            xRut.Text = wLocal.RutLocal
            xGiroLocal.Text = wLocal.GiroLocal
            xDireccion.Text = wLocal.DirLocal
            cCiudades.SelectedValue = wLocal.Comuna.ToString()
            cComunas.SelectedValue = wLocal.Comuna.ToString
            xTelefono.Text = wLocal.TelefonosLocal
            oVenta.Checked = wLocal.EnvioPrecios
            oPrecio.Checked = wLocal.CargadeVentas
            oElectronica.Checked = wLocal.FElectronica
            xIP.Text = wLocal.IP_DTE
            xClave.Text = wLocal.Llave
            xNumeroR.Text = wLocal.NResolucion.ToString
            dFechaR.Value = wLocal.FResolucion
            xAteco.Text = wLocal.ATECO
            xSII.Text = wLocal.SII
            oFV.Checked = wLocal.FV_Elect
            oGD.Checked = wLocal.GD_Elect
            oNC.Checked = wLocal.NC_Elect
            oFE.Checked = wLocal.FE_Elect
            oND.Checked = wLocal.ND_Elect
            oFC.Checked = wLocal.FC_Elect
            oBO.Checked = wLocal.BV_Elect
            oBE.Checked = wLocal.BE_Elect
            oEnvioAuto.Checked = wLocal.Envio_Automatico
            If wLocal.Logo IsNot Nothing Then pLogo.Image = ArrayImagen(wLocal.Logo)
            If wLocal.LogoVoucher IsNot Nothing Then pLogoVoucher.Image = ArrayImagen(wLocal.LogoVoucher)

            bGuardar.Text = "Modificar"
        Else
            bGuardar.Text = "Guardar"
            bNuevo_Click()
        End If
    End Sub

    Private Sub xClientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        ValidarDigitos(e)
        e.NextControl(xRut)
    End Sub

    Private Sub xClientes_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xCliente.Validating
        If xCliente.Text <> "" Then
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wCliente = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = xCliente.Text.ToDecimal)
            If wCliente IsNot Nothing Then
                xNombreCliente.Text = wCliente.Nombre
            End If
        End If
    End Sub

    Private Sub bBuscarC_Click(sender As Object, e As EventArgs) Handles bBuscarC.Click
        Dim wQuery = "Select Cliente,Nombre FROM Clientes"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Nombre", Me, "Clientes", xCliente)
    End Sub
    Private Sub xNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNombre.KeyPress
        e.NextControl(xCliente)
    End Sub

    Private Sub xRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xRut.KeyPress
        e.NextControl(xGiroLocal)
    End Sub

    Private Sub xGiroLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xGiroLocal.KeyPress
        e.NextControl(xDireccion)
    End Sub

    Private Sub xDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDireccion.KeyPress
        e.NextControl(cCiudades)
    End Sub

    Private Sub cCiudades_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cCiudades.KeyPress
        e.NextControl(cComunas)
    End Sub

    Private Sub cComunas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cComunas.KeyPress
        e.NextControl(xTelefono)
    End Sub
    Private Sub xIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xIP.KeyPress
        e.NextControl(xClave)
    End Sub

    Private Sub xClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xClave.KeyPress
        e.NextControl(xNumeroR)
    End Sub

    Private Sub xNumeroR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNumeroR.KeyPress
        e.NextControl(dFechaR)
    End Sub

    Private Sub dFechaR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dFechaR.KeyPress
        e.NextControl(xAteco)
    End Sub

    Private Sub xAteco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xAteco.KeyPress
        e.NextControl(xSII)
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        bNuevo_Click()
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If xLocal.Text.Trim <> "" Then
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wLocalBorrar = DC.T_Locales.FirstOrDefault(Function(x) x.Local = xLocal.Text.ToDecimal())
            If wLocalBorrar Is Nothing Then
                MsgError("El local no se encuentra registrado")
                Exit Sub
            End If
            If ValidarEliminar("Local", xLocal.Text, "Locales") Then
                MsgError("No se puede eliminar el Local")
            Else
                SQL("DELETE FROM Locales WHERE Local = '" & xLocal.Text.Trim & "'")
                Mensaje("Local eliminada correctamente")
                Auditoria(Me.Text, A_ELIMINADO, xLocal.Text.Trim, xNombre.Text.Trim)
                bNuevo_Click()
            End If
        End If
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim wMensaje As String() = {MSG_MODIFICADO, A_MODIFICADO}
        For Each wControl As Control In gPrincipal.Controls
            If wControl.GetType Is GetType(TextBox) Or wControl.GetType Is GetType(ComboBox) Then
                If wControl.Text = "" Then
                    MsgError("Indique " & wControl.Tag.ToString)
                    wControl.Focus()
                    Exit Sub
                End If
            End If
        Next
        'If oElectronica.Checked Then
        '    For Each wControl As Control In gElectronica.Controls
        '        If wControl.GetType Is GetType(TextBox) Or wControl.GetType Is GetType(ComboBox) Then
        '            If wControl.Text = "" Then
        '                MsgError("Indique " & wControl.Tag.ToString)
        '                wControl.Focus()
        '                Exit Sub
        '            End If
        '        End If
        '    Next
        'End If
        Cursor = Cursors.WaitCursor
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wLocal As New T_Locales
        Dim qLocal = DC.T_Locales.FirstOrDefault(Function(x) x.Local = CInt(xLocal.Text))

        If qLocal IsNot Nothing Then wLocal = qLocal

        wLocal.NombreLocal = Trim(xNombre.Text)
        wLocal.Cliente = CInt(xCliente.Text)
        wLocal.RutLocal = Trim(xRut.Text)
        wLocal.GiroLocal = Trim(xGiroLocal.Text)
        wLocal.DirLocal = Trim(xDireccion.Text)
        wLocal.Comuna = cComunas.SelectedValue.ToString
        wLocal.TelefonosLocal = Trim(xTelefono.Text)
        wLocal.EnvioPrecios = oPrecio.Checked
        wLocal.CargadeVentas = oVenta.Checked

        wLocal.FElectronica = oElectronica.Checked
        wLocal.IP_DTE = Trim(xIP.Text)
        wLocal.FV_Elect = oFV.Checked
        wLocal.GD_Elect = oGD.Checked
        wLocal.NC_Elect = oNC.Checked
        wLocal.FE_Elect = oFE.Checked
        wLocal.ND_Elect = oND.Checked
        wLocal.FC_Elect = oFC.Checked
        wLocal.BV_Elect = oBO.Checked
        wLocal.BE_Elect = oBE.Checked
        wLocal.Llave = Trim(xClave.Text)
        wLocal.NResolucion = CInt(xNumeroR.Text)
        wLocal.FResolucion = CDate(FormatDateTime(dFechaR.Value, DateFormat.ShortDate))
        wLocal.ATECO = Trim(xAteco.Text)

        If pLogo.Image IsNot Nothing Then wLocal.Logo = CType(ImagenArray(pLogo.Image), Byte())
        wLocal.SII = Trim(xSII.Text)
        wLocal.Envio_Automatico = oEnvioAuto.Checked

        If pLogoVoucher.Image IsNot Nothing Then wLocal.LogoVoucher = (CType(ImagenArray(pLogoVoucher.Image), Byte()))

        If qLocal Is Nothing Then
            DC.T_Locales.InsertOnSubmit(wLocal)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
        End If
        DC.SubmitChanges()
        Mensaje(wMensaje(0))
        Auditoria(Me.Text, wMensaje(1), xLocal.Text, xNombre.Text)
        bNuevo_Click()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bCargar_Click(sender As Object, e As EventArgs) Handles bCargar.Click
        fLogo.Filter = "Imagen |*.bmp;*.jpg ;*.gif;*.png"
        fLogo.FileName = ""
        If fLogo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim img = fLogo.FileName
            pLogo.Image = System.Drawing.Bitmap.FromFile(img)
            img = Nothing
        End If
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub oElectronica_CheckedChanged(sender As Object, e As EventArgs) Handles oElectronica.CheckedChanged
        If oElectronica.Checked Then
            gElectronica.Enabled = True
        Else
            gElectronica.Enabled = False
        End If
    End Sub

    Private Sub ManLocales_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'xLocal.Focus()
    End Sub

    Private Sub bCargarLogoVoucher_Click(sender As Object, e As EventArgs) Handles bCargarLogoVoucher.Click
        oLogoVoucher.Filter = "Imagen |*.bmp;*.jpg ;*.gif;*.png"
        oLogoVoucher.FileName = ""
        If oLogoVoucher.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim img = oLogoVoucher.FileName
            pLogoVoucher.Image = System.Drawing.Bitmap.FromFile(img)
            img = Nothing
        End If
    End Sub
End Class