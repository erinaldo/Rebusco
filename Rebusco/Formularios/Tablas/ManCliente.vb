Imports System.Text.RegularExpressions

Public Class ManCliente

    Implements iFormulario

    Public G_FORMULARIO As iFormulario
    Public G_CONTROL As Control
    Public G_CARGAR_NUEVO As Boolean = False
    Public G_EXISTENTE As Decimal = 0

    Public Sub Configurar(wFormulario As iFormulario, wControl As Control)
        G_FORMULARIO = wFormulario
        G_CONTROL = wControl
        G_CARGAR_NUEVO = True
    End Sub

    Public Sub ConfigurarExistente(wFormulario As iFormulario, wControl As Control, existente As Decimal)
        G_FORMULARIO = wFormulario
        G_CONTROL = wControl
        G_CARGAR_NUEVO = True
        G_EXISTENTE = existente
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        Nuevo()
    End Sub

    Private Sub ManCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cCiudad.LoadItemsObj("Comunas", "Codigo", "NombreComuna", "ORDER BY NombreComuna")
        cCiudad.SelectedIndex = 0
        cComuna.LoadItemsObj("Comunas", "Codigo", "NombreComuna", "ORDER BY NombreComuna")
        cComuna.SelectedIndex = 0
        cEstado.LoadItemsObj("Estados", "Estado", "DescEstado", "WHERE Tipo = 'A'")
        cFPago.LoadItemsObj("FPagos", "Fpago", "DescFPago", "ORDER BY Orden")
        cEstado.SelectedIndex = 1
        Auditoria(Text, A_INGRESADO, "", "")

        If G_ACCESOUSUARIO >= 8 Then
            xDescuento.Maximum = 100
            xDescuentoServ.Maximum = 100
        Else
            xDescuento.Maximum = P_MAXIMODESCUENTO
            xDescuentoServ.Maximum = P_MAXIMODESCUENTO
        End If

        If G_EXISTENTE > 0 Then
            xCliente.Text = G_EXISTENTE.ToText()
            CargarCliente()
            G_EXISTENTE = 0
        Else
            Nuevo()
        End If


    End Sub

    Private Sub cCiudad_ItemSeleccionado(wDescripcion As String)
        xComuna.Focus()
    End Sub

    Private Sub cCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cCiudad.SelectedIndexChanged
        If Trim(cCiudad.Text) = "" Then
            xCiudad.Clear()
            Exit Sub
        End If

        Dim wID = xCiudad.EncontrarID(cCiudad.Text)
        If wID = "" Then
            cCiudad.SelectedIndex = 0
            Exit Sub
        End If

        xCiudad.AutoCompletarActivo = False
        xCiudad.Text = wID
        xCiudad.AutoCompletarActivo = True
    End Sub

    Private Sub xCiudad_Validating(Optional sender As Object = Nothing, Optional e As System.ComponentModel.CancelEventArgs = Nothing) Handles xCiudad.Validating
        If xCiudad.ListaVisible Then
            If xCiudad.ListaActiva Then
                Exit Sub
            Else
                xCiudad.OcultarLista()
            End If
        End If

        If Trim(xCiudad.Text) = "" Then
            cCiudad.SelectedIndex = -1
            Exit Sub
        End If

        Dim wIndice = cCiudad.FindStringExact(xCiudad.DescEncontrada)
        If wIndice = -1 Then
            MsgError("La Ciudad ingresada no se encuentra")
            xCiudad.Clear()
            cCiudad.SelectedIndex = -1
            Exit Sub
        ElseIf wIndice = 0 Then
            cCiudad.SelectedValue = xCiudad.Text
            If cCiudad.Text = "" Then
                MsgError("Ciudad no encontrada")
                xCiudad.Clear()
                xCiudad.Focus()
                Exit Sub
            End If
            cComuna.LoadItemsObj("Comunas", "Codigo", "NombreComuna", "WHERE Codigo='" & Val(xCiudad.Text) & "'")
            cComuna.SelectedIndex = -1
        Else
            cCiudad.SelectedIndex = wIndice
            cComuna.LoadItemsObj("Comunas", "Codigo", "NombreComuna", "WHERE Codigo='" & Val(xCiudad.Text) & "'")
            cComuna.SelectedIndex = -1
        End If
    End Sub

    Private Sub xCiudad_ItemSeleccionado(wDescripcion As String) Handles xCiudad.ItemSeleccionado
        xComuna.Focus()
    End Sub

    Private Sub cComuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cComuna.SelectedIndexChanged
        If Trim(cComuna.Text) = "" Then
            xComuna.Clear()
            Exit Sub
        End If

        Dim wID = xComuna.EncontrarID(cComuna.Text)
        If wID = "" Then
            cComuna.SelectedIndex = 0
            Exit Sub
        End If

        xComuna.AutoCompletarActivo = False
        xComuna.Text = wID
        xComuna.AutoCompletarActivo = True
    End Sub


    Private Sub xComuna_Validating(Optional sender As Object = Nothing, Optional e As System.ComponentModel.CancelEventArgs = Nothing) Handles xComuna.Validating

        If xComuna.ListaVisible Then
            If xComuna.ListaActiva Then
                Exit Sub
            Else
                xComuna.OcultarLista()
            End If
        End If

        If Trim(xComuna.Text) = "" Then
            cComuna.SelectedIndex = -1
            Exit Sub
        End If

        Dim wIndice = cComuna.FindStringExact(xComuna.DescEncontrada)
        If wIndice = -1 Then
            MsgError("La Comuna ingresada no se encuentra")
            xComuna.Clear()
            cComuna.SelectedIndex = -1
            Exit Sub
        ElseIf wIndice = 0 Then
            cComuna.SelectedValue = xComuna.Text
            If cComuna.Text = "" Then
                MsgError("Comuna no encontrada")
                xComuna.Clear()
                xComuna.Focus()
                Exit Sub
            End If
        Else
            cComuna.SelectedIndex = wIndice
        End If

        ' cComuna.SelectedIndex = wIndice

    End Sub

    Private Sub xComuna_ItemSeleccionado(wDescripcion As String) Handles xComuna.ItemSeleccionado
        xEmail.Focus()
    End Sub

    Private Sub CargarCliente(Optional sender As Object = Nothing, Optional e As System.ComponentModel.CancelEventArgs = Nothing) Handles xCliente.Validating
        If xCliente.Text.Trim = "" Then Exit Sub

        If Not IsNumeric(xCliente.Text) Then
            Dim wCl = SQL("SELECT Cliente FROM Clientes WHERE Fantasia = '" & xCliente.Text.Trim & "'").Top
            If wCl IsNot Nothing Then
                xCliente.Text = wCl.GetText("Cliente")
            Else
                xCliente.Clear()
                xCliente.Focus()
            End If
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim Cli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = CInt(xCliente.Text))
        If Cli IsNot Nothing Then
            xNombre.Text = Cli.Nombre
            xRut.Text = Cli.Rut
            xGiro.Text = Cli.Giro
            xFantasia.Text = Cli.Fantasia
            xDireccion.Text = Cli.Direccion
            'xCiudad.Text = wCli.Ciudad
            'xCiudad_Validating()
            xCiudad.AutoCompletarActivo = False
            xComuna.AutoCompletarActivo = False
            cCiudad.SelectedValue = Cli.Ciudad.ToString
            cComuna.SelectedValue = Cli.Comuna.ToString
            xCiudad.AutoCompletarActivo = True
            xComuna.AutoCompletarActivo = True
            xContacto.Text = Cli.Contacto
            xEmail.Text = Cli.Email
            xTelefono.Text = Cli.Telefonos
            xCupoMax.Text = Cli.CupoMax.ToString
            xDescuento.Value = Cli.MaxDescuento
            xDescuentoServ.Value = Cli.MaxDescuentoServicios
            xVencimiento.Text = Cli.Vencimiento.ToString
            xGlosa.Text = Cli.Glosa.ToString
            cEstado.SelectedValue = Cli.Estado
            oComision.Checked = Cli.Comision
            oProveedor.Checked = Cli.Proveedor
            ' cFPago.Text = BuscarCampo("FPagos", "DescFPago", "FPago", wCli.FPago)
            cFPago.SelectedValue = Cli.FPago.ToString
            ' cEstado.Text = BuscarCampo("Estados", "DescEstado", "Estado", wCli.Estado)
            cEstado.SelectedValue = Cli.Estado.ToString
        Else
            If xCliente.Text = SiguienteCorrelativo("Clientes", "Cliente").ToString Then
                xNombre.Focus()
                Exit Sub
            End If
            MsgError("Cliente no existe")
            xCliente.Clear()
            xCliente.Focus()
            Nuevo()
            Exit Sub
        End If
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim wMensaje As String = "Registro modificado correctamente"

        If Val(xCliente.Text) <= 0 Then
            MsgError("Debe ingresar un cliente", "Falta cliente")
            xCliente.Focus()
            Exit Sub
        End If

        If Trim(xNombre.Text) = "" Then
            MsgError("Debe ingresar un nombre", "Falta nombre")
            xNombre.Focus()
            Exit Sub
        End If

        If Trim(xRut.Text) = ".   .   -" Then
            MsgError("Debe ingresar un rut", "Falta Rut")
            xRut.Focus()
            Exit Sub
        Else
            If Not VerificarRut(xRut.Text) Then
                MsgError("Rut incorrecto", "Error en Rut")
                xRut.Focus()
                Exit Sub
            End If
        End If

        If xGiro.Text = "" Then
            xGiro.Text = "PARTICLAR"
        End If

        If xDireccion.Text = "" Then
            MsgError("Debe ingresar una dirección", "Falta dirección")
            xDireccion.Focus()
            Exit Sub
        End If
        If xCiudad.Text = "" Then
            MsgError("Debe ingresar una ciudad", "Falta ciudad")
            cCiudad.Focus()
            Exit Sub
        End If
        If xComuna.Text = "" Then
            MsgError("Debe ingresar una comuna", "Falta comuna")
            cComuna.Focus()
            Exit Sub
        End If

        If cEstado.Text = "" Then
            MsgError("Debe ingresar un estado", "Falta estado")
            cEstado.Focus()
            Exit Sub
        End If

        xEmail.TrimText()
        If xEmail.Text <> "" Then
            Dim wPatron As New Regex("^[a-zA-Z0-9-]*(.[a-zA-Z0-9-]+)*(.[a-zA-Z0-9-]+)*(.[a-zA-Z0-9-]+)@[a-zA-Z0-9-]+(.[a-zA-Z0-9-]+)*(.[a-zA-Z]{2,4})$")
            If Not wPatron.IsMatch(xEmail.Text.Trim) Then
                MsgError("El email no cumple con el formato correcto.", "Error en email")
                Exit Sub
            End If
        End If

        If xCupoMax.Text.Trim = "" Then xCupoMax.Text = "0"
        If xVencimiento.Text.Trim = "" Then xVencimiento.Text = "0"
        If cFPago.Text.Trim = "" Then cFPago.Text = "EFECTIVO"

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim Cli As New T_Clientes
        Dim qCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = CInt(xCliente.Text))
        Cursor = Cursors.WaitCursor
        If qCli IsNot Nothing Then Cli = qCli

        Cli.Cliente = CInt(xCliente.Text)
        Cli.Nombre = xNombre.Text
        Cli.Rut = xRut.Text
        Cli.Fantasia = xFantasia.Text
        Cli.Direccion = xDireccion.Text
        Cli.Ciudad = xCiudad.Text
        Cli.Comuna = xComuna.Text
        Cli.Giro = xGiro.Text
        Cli.Telefonos = xTelefono.Text
        Cli.Contacto = xContacto.Text
        Cli.Tipo = ""
        Cli.Email = xEmail.Text
        Cli.CupoMax = CInt(xCupoMax.Text)
        Cli.MaxDescuento = xDescuento.Value
        Cli.MaxDescuentoServicios = xDescuentoServ.Value
        Cli.Vencimiento = CInt(xVencimiento.Text)
        Cli.Estado = CChar(cEstado.SelectedValue.ToString)
        Cli.FPago = CChar(cFPago.SelectedValue.ToString)
        Cli.Comision = oComision.Checked
        Cli.Proveedor = oProveedor.Checked
        Cli.Glosa = xGlosa.Text.Trim

        If qCli Is Nothing Then
            DC.T_Clientes.InsertOnSubmit(Cli)
            wMensaje = "Registro guardado Correctamente"
        End If

        DC.SubmitChanges()
        Mensaje(wMensaje)
        Auditoria(Text, A_INGRESADO, xCliente.Text.Trim, xNombre.Text.Trim)
        xCliente.Clear()
        Nuevo()
        xCliente.Focus()
        Cursor = Cursors.Arrow

        If G_CARGAR_NUEVO And G_FORMULARIO IsNot Nothing Then
            G_FORMULARIO.CargarRegistro(G_CONTROL, Cli.Cliente.ToString())
            G_CARGAR_NUEVO = False
            Close()
        End If
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If Trim(xCliente.Text) = "" Then
            Exit Sub
        End If
        Dim wCli = SQL("SELECT Cliente FROM Clientes WHERE Cliente=" & Val(xCliente.Text) & "").Top
        If wCli Is Nothing Then
            MsgError("El cliente ingresado no existe")
            LimpiarCampos(Me)
            xCliente.Clear()
            xCliente.Focus()
            Exit Sub
        End If
        wCli = SQL("SELECT TOP 1 Cliente FROM DocumentosG WHERE Cliente=" & Val(xCliente.Text) & "").Top

        If wCli IsNot Nothing Then
            MsgError("No se puede eliminar este cliente, se encuentra utilizado en otro registro")
            Exit Sub
        End If

        wCli = SQL("SELECT TOP 1 Cliente FROM DocumentosP WHERE Cliente=" & Val(xCliente.Text) & "").Top

        If wCli IsNot Nothing Then
            MsgError("No se puede eliminar este cliente, se encuentra utilizado en otro registro")
            Exit Sub
        Else
            If Pregunta("¿Desea eliminar este cliente?") Then
                SQL("DELETE Clientes WHERE Cliente=" & Val(xCliente.Text) & "")
                Auditoria(Text, "Eliminó Cliente", xCliente.Text.Trim, xNombre.Text.Trim)
                Mensaje("Cliente eliminado correctamente")
                Nuevo()
            End If
        End If
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        ValidarDigitos(e)
        e.NextControl(xNombre)
    End Sub

    Private Sub xCupoMax_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xVencimiento.Validating, xCupoMax.Validating
        ValidarDigitos(sender, 0)
    End Sub

    Private Sub xNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNombre.KeyPress
        e.NextControl(xRut)
    End Sub

    Private Sub xRut_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xRut.Validating
        If xRut.Text <> "  .   .   -" Then
            If Not VerificarRut(Trim(xRut.Text)) Then
                MsgError("El Rut es Incorrecto")
                xRut.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Dim wQuery = "Select Cliente,Nombre,Rut FROM Clientes"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Nombre", Me, "Clientes", xCliente)
    End Sub
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub Nuevo(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bNuevo.Click
        LimpiarCampos(Me)
        xRut.Text = "  .   .   - "
        xCliente.Text = SiguienteCorrelativo("Clientes", "Cliente").ToString
        xVencimiento.Text = "30"
        cEstado.Text = "ACTIVO"
        cFPago.Text = "EFECTIVO"
        xCupoMax.Text = "0"
        xDescuento.Value = xDescuento.Minimum
        xDescuentoServ.Value = xDescuento.Minimum
        xNombre.Focus()
    End Sub

    Private Sub xRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xRut.KeyPress
        e.NextControl(xGiro)
    End Sub

    Private Sub xGiro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xGiro.KeyPress
        e.NextControl(xFantasia)
    End Sub

    Private Sub xFantasia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xFantasia.KeyPress
        e.NextControl(xDireccion)
    End Sub

    Private Sub xDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDireccion.KeyPress
        e.NextControl(xCiudad)
    End Sub

    Private Sub xCiudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCiudad.KeyPress
        e.NextControl(xComuna)
    End Sub

    Private Sub xComuna_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xComuna.KeyPress
        e.NextControl(xEmail)
    End Sub

    Private Sub xContacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xContacto.KeyPress
        e.NextControl(xTelefono)
    End Sub

    Private Sub xEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xEmail.KeyPress
        e.NextControl(xContacto)
    End Sub

    Private Sub xTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTelefono.KeyPress
        e.NextControl(xCupoMax)
    End Sub

    Private Sub xCupoMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCupoMax.KeyPress
        e.NextControl(xVencimiento)
    End Sub

    Private Sub xVencimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xVencimiento.KeyPress
        e.NextControl(cEstado)
    End Sub

    Private Sub cEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cEstado.KeyPress
        e.NextControl(bGuardar)
    End Sub

    Private Sub xCiudad_TextChanged(sender As Object, e As EventArgs) Handles xCiudad.TextChanged

    End Sub
End Class