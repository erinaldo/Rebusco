Imports System.ComponentModel

Public Class ManUsuarios



    Private Sub Limpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        bGuardar.Text = "Guardar"
        xRut.Clear()
        xCodigo.Focus()
    End Sub
    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub ManUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cAcceso.LoadItemsObj("Accesos", "Acceso", "NombreAcceso", " WHERE Acceso <= " & G_ACCESOUSUARIO)
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        xCodigo.Focus()
        Auditoria(Text, A_INGRESADO, "", "0")
    End Sub

    Private Sub xAcceso_Validating(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles xAcceso.Validating
        If xAcceso.Text.Trim <> "" Then
            cAcceso.SelectedValue = xAcceso.Text.Trim
            If cAcceso.Text = "" Then
                MsgError("Acceso no encontrado")
                xAcceso.Clear()
                xAcceso.Focus()
            End If
        End If
    End Sub
    Private Sub xLocal_Validating(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles xLocal.Validating
        If xLocal.Text.Trim <> "" Then
            cLocal.SelectedValue = xLocal.Text.Trim
            If cLocal.Text = "" Then
                xLocal.Clear()
                xLocal.Focus()
            End If
        End If
    End Sub
    Private Sub cLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cLocal.SelectedIndexChanged
        If cLocal.Text <> "" Then
            xLocal.Text = cLocal.SelectedValue.ToString
        Else
            xLocal.Clear()
        End If
    End Sub

    Private Sub cAcceso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cAcceso.SelectedIndexChanged
        If cAcceso.Text <> "" Then
            xAcceso.Text = cAcceso.SelectedValue.ToString
        Else
            xAcceso.Clear()
        End If
    End Sub

    Public Sub xCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCodigo.KeyPress
        e.NextControl(xNombreUsr)
    End Sub


    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If Pregunta("¿Desea eliminar este usuario?") Then
            If xCodigo.Text = "" Then
                MsgError("Debe Especificar el Usuario")
                xCodigo.Focus()
            Else
                Dim wUsr = SQL("SELECT Usuario FROM Usuarios WHERE usuario='" & xCodigo.Text.Trim & "' except SELECT Usuario FROM Auditoria").Top
                If wUsr IsNot Nothing Then
                    SQL("DELETE FROM Usuarios WHERE Usuario" & xCodigo.Text.Trim)
                    Auditoria(Text, A_ELIMINADO, xCodigo.Text, xNombreUsr.Text)
                    Limpiar_Click()
                    Mensaje("Registro Eliminado Correctamente")
                Else
                    MsgError("No Puedes eliminar este Usuario ya que se esta siendo Utilizado")
                    xCodigo.Focus()
                    Exit Sub
                End If
            End If
        End If
    End Sub


    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

        Dim wMensaje As String() = {MSG_MODIFICADO, A_MODIFICADO}
        If xNombreUsr.Text = "" Then
            MsgError("Debes Especificar un Nombre")
            xNombreUsr.Focus()
            Exit Sub
        End If

        If Not VerificarRut(xRut.Text) Then
            MsgError("Rut Incorrecto")
            xRut.Focus()
            Exit Sub
        End If
        If xRut.Text = "" Then
            MsgError("Debes Especificar un Rut")
            xRut.Focus()
            Exit Sub
        End If

        If Val(xAcceso.Text) = 0 Then
            MsgError("Debe especificar Acceso al Usuario")
            Exit Sub
        End If

        If xClave.Text = "" Then
            MsgError("Debes especificar una Contraseña")
            xClave.Focus()
            Exit Sub
        End If

        If xLocal.Text = "" Or cLocal.Text = "" Then
            MsgError("Ingrese Local")
            xLocal.Focus()
            Exit Sub
        End If

        If Val(xCliente.Text) = 0 Then
            xCliente.Text = "0"
        End If

        Cursor = Cursors.WaitCursor
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wUsr As New T_Usuarios

        Validacion.ValidateObj(wUsr)
        Dim qUsr = DC.T_Usuarios.FirstOrDefault(Function(x) x.Usuario = xCodigo.Text.Trim)

        If qUsr IsNot Nothing Then wUsr = qUsr

        wUsr.Usuario = Trim(xCodigo.Text)
        wUsr.NombreUsr = Trim(xNombreUsr.Text)
        wUsr.Rut = Trim(xRut.Text)
        wUsr.Acceso = cAcceso.SelectedValue.ToString.ToDecimal()
        wUsr.Clave = Encriptar(xClave.Text)
        wUsr.Local = CInt(xLocal.Text)
        wUsr.Base = 0
        wUsr.Bruto = 0
        wUsr.Funcionario = If(oFuncionario.Checked, True, False)
        wUsr.AFP = 0
        wUsr.Salud = 0
        wUsr.Vigencia = CDate("01/01/3000 00:00:00.000")
        wUsr.Gratificacion = 0
        wUsr.Movilizacion = 0
        wUsr.Cargas = 0
        wUsr.Pactado = 0
        wUsr.Empresa = CInt(xCliente.Text)
        wUsr.MaxDescuento = xDescuento.Value

        If qUsr Is Nothing Then
            DC.T_Usuarios.InsertOnSubmit(wUsr)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
        End If

        DC.SubmitChanges()
        ActualizarPermisosUsuario(xCodigo.Text, Val(xAcceso.Text))
        Mensaje(wMensaje(0))
        Auditoria(Me.Text, wMensaje(1), xCodigo.Text, xNombreUsr.Text)
        Cursor = Cursors.Arrow
        Limpiar_Click()
    End Sub


    Private Sub ActualizarPermisosUsuario(ByVal wUsuario As String, ByVal wAcceso As Double)

        Dim wUsr = SQL("SELECT Distinct Usuario FROM Usuarios WHERE Usuario = '" & wUsuario & "'").Top
        If wUsr IsNot Nothing Then
            SQL("DELETE FROM PermisosUSuario WHERE Usuario = '" & wUsuario & "'")
            SQL("INSERT INTO PermisosUsuario (Usuario, Modulo) " &
                "SELECT '" & wUsuario & "' AS Usuario, Modulo FROM PermisosAcceso WHERE Acceso = " & wAcceso)
        End If

    End Sub

    Private Sub xRut_Validating(sender As Object, e As EventArgs) Handles xRut.Validating
        If Not VerificarRut(xRut.Text) Then
            MsgError("Rut Incorrecto")
            xRut.Focus()
            Exit Sub
        End If
    End Sub

    Public Sub xCodigo_Validating(sender As Object, e As EventArgs) Handles xCodigo.Validating
        If xCodigo.Text.Trim = "" Then Exit Sub

        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wUsr = DC.T_Usuarios.FirstOrDefault(Function(x) x.Usuario = xCodigo.Text.Trim)

        If wUsr IsNot Nothing Then
            xNombreUsr.Text = wUsr.NombreUsr
            xRut.Text = wUsr.Rut
            xAcceso.Text = wUsr.Acceso.ToString
            xAcceso_Validating()
            xLocal.Text = wUsr.Local.ToString
            xLocal_Validating()
            xCliente.Text = wUsr.Empresa.ToString
            xCliente_Validating()
            xClave.Text = DesEncriptar(wUsr.Clave)
            xDescuento.Value = wUsr.MaxDescuento
            oFuncionario.Checked = wUsr.Funcionario
            bGuardar.Text = "Modificar"
        Else
            bGuardar.Text = "Guardar"
        End If
    End Sub

    Private Sub xNombreUsr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNombreUsr.KeyPress
        If e.KeyChar = vbCr Then
            xRut.Focus()
        End If
    End Sub

    Private Sub xRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xRut.KeyPress
        If e.KeyChar = vbCr Then
            xAcceso.Focus()
        End If
    End Sub

    Private Sub xAcceso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xAcceso.KeyPress
        ValidarDigitos(e)
        If e.KeyChar = vbCr Then
            xLocal.Focus()
        End If
    End Sub

    Private Sub xClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xClave.KeyPress
        ValidarDigitos(e)
        If e.KeyChar = vbCr Then
            xCliente.Focus()
        End If
    End Sub

    Private Sub xLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xLocal.KeyPress
        ValidarDigitos(e)
        If e.KeyChar = vbCr Then
            xClave.Focus()
        End If
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        ValidarDigitos(e)
        If e.KeyChar = vbCr Then
            bGuardar.Focus()
        End If
    End Sub

    Private Sub xRut_Enter(sender As Object, e As EventArgs) Handles xRut.Enter
        xRut.SelectAll()
    End Sub

    Private Sub xCliente_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xCliente.Validating
        ValidarDigitos(sender)
        If xCliente.ToDecimal <= 0 Then Exit Sub

        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = CInt(xCliente.Text))

        If wCli IsNot Nothing Then
            xNombreCliente.Text = wCli.Nombre
        Else
            MsgError("Cliente no registrado")
            xCliente.Clear()
            xNombreCliente.Clear()
            xCliente.Focus()
        End If
    End Sub
End Class