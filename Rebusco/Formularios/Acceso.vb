Imports System.Runtime.InteropServices

Friend Class Acceso

    Private Sub Acceso_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        If gServidores.Visible Then
            Me.Height = 430
        Else
            Me.Height = 330
        End If
        Visible = True
        DoEvents()
    End Sub

    Private Sub Acceso_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim resultado = Settings.GetSettings()
        If resultado <> "" Then
            MsgError($"No se puede utilizar MarketONE {vbCrLf}{resultado}.", "Error crítico")
            End
        End If

        Cursor = Cursors.WaitCursor
        DoEvents()

        CargarServidores()
        lEmpresa.Text = CONFIGURACION.Empresa
        lIP.Text = CONFIGURACION.IPServidor


        Dim task = ProbarConexionServidor(CONFIGURACION.IPServidor, CONFIGURACION.Base)

        If Not task.Result Then
            Cursor = Cursors.Arrow
            MsgError($"Error al conectar con la base de datos." & vbCrLf &
                     $"{CONFIGURACION.IPServidor} : {CONFIGURACION.Base}", "Error crítico")
            End
        End If

        If Not ObtenerParametros() Then
            Cursor = Cursors.Arrow
            MsgError("Error al obtener parámetros del sistema (Base de datos).", "Error crítico")
            End
        End If

        If Not CargarLocales() Then
            Cursor = Cursors.Arrow
            MsgError("Error al cargar locales.", "Error crítico")
            End
        End If

        Cursor = Cursors.Arrow



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

        AddHandler cServidor.SelectedIndexChanged, AddressOf cServidor_SelectedIndexChanged

    End Sub

    Private Function CargarLocales() As Boolean
        Try
            Dim DC = New RebuscoDataContext(P_CONEXION)
            Dim locales = DC.T_Locales.Select(Function(x) New With {.ID = CStr(x.Local), .Desc = x.NombreLocal}).ToList
            If Not locales.Any Then Return False
            cLocal.ValueMember = "ID"
            cLocal.DisplayMember = "Desc"
            cLocal.DataSource = locales
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub cServidor_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cServidor.Text = "" Then Exit Sub

        Cursor = Cursors.WaitCursor
        Dim servidor = cServidor.SelectedValue.ToString
        Dim base = $"Rebusco"

        Dim Task = ProbarConexionServidor(servidor, base)

        If Task.Result Then
            lIP.Text = servidor
            CONFIGURACION.IPServidor = servidor
            CONFIGURACION.Base = base
            CONFIGURACION.Empresa = cServidor.Text

            If Not ObtenerParametros() Then
                MsgError("Error al obtener parámetros del sistema (Base de datos).", "Error crítico")
                End
            End If

            If Not CargarLocales() Then
                MsgError("Error al cargar locales.", "Error crítico")
                End
            End If
        Else

            If Task.IsCompleted Then
                MsgError("Los parámetros de conexión son incorrectos." & vbCrLf &
                     $"{servidor} : {base}", "Error de conexión")
            Else
                MsgError("Se agotó el tiempo de respuesta con el servidor seleccionado." & vbCrLf &
                     $"{servidor} : {base}", "Error de conexión")
            End If

            RemoveHandler cServidor.SelectedIndexChanged, AddressOf cServidor_SelectedIndexChanged
            cServidor.SelectedValue = CONFIGURACION.IPServidor
            AddHandler cServidor.SelectedIndexChanged, AddressOf cServidor_SelectedIndexChanged

        End If
        lEmpresa.Text = CONFIGURACION.Empresa
        Cursor = Cursors.Default
    End Sub

    Private Sub xUsuario_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles xUsuario.Validating
        Try
            If xUsuario.Text.Trim <> "" Then
                Dim Bases = New RebuscoDataContext(P_CONEXION)
                Dim wUsr = Bases.T_Usuarios.FirstOrDefault(Function(x) x.Usuario = xUsuario.Text.Trim)

                If wUsr IsNot Nothing Then
                    If wUsr.Acceso = 9 Then
                        cLocal.Enabled = True
                        gServidores.Visible = True
                        Me.Height = 430
                    Else
                        cLocal.Enabled = False
                        gServidores.Visible = False
                        Me.Height = 330
                    End If

                    If wUsr.Local > 0 Then
                        Dim wLoc = Bases.T_Locales.FirstOrDefault(Function(x) x.Local = wUsr.Local)
                        If wLoc IsNot Nothing Then cLocal.SelectedValue = wLoc.Local.ToString
                    End If

                End If
            End If
        Catch ex As Exception
            Mensaje(ex.Message)
        End Try
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAceptar.Click
        Try
            G_DEMO = oDemo.Checked

            If xUsuario.Text = "" Then
                MsgError("Falta ingresar un Usuario")
                xUsuario.Focus()
                Exit Sub
            End If

            If xClave.Text = "" Then
                MsgError("Falta ingresar una Clave")
                xClave.Focus()
                Exit Sub
            End If

            If cLocal.Text = "" Then
                MsgError("Debe seleccionar un Local.")
                cLocal.Focus()
                Exit Sub
            End If

            Dim DC = New RebuscoDataContext(P_CONEXION)

            Dim wUsr = DC.T_Usuarios.FirstOrDefault(Function(x) x.Usuario = xUsuario.Text.Trim)
            If wUsr IsNot Nothing Then
                Dim wClave = DesEncriptar(wUsr.Clave)
                If UCase(xClave.Text) = UCase(wClave) Then
                    Dim LocalAsignado As Decimal = 0
                    If wUsr.Local = 0 Then
                        Dim xLoc = DC.T_Locales.FirstOrDefault(Function(x) x.NombreLocal = cLocal.Text.Trim)
                        If xLoc IsNot Nothing Then
                            LocalAsignado = xLoc.Local
                        Else
                            MsgError("El local asignado al usuario no esta registrado")
                            Exit Sub
                        End If
                    Else
                        LocalAsignado = wUsr.Local
                    End If

                    Dim wLoc = DC.T_Locales.FirstOrDefault(Function(x) x.Local = LocalAsignado)

                    If wLoc IsNot Nothing Then
                        LocalUsuario = wLoc.Local
                        Ubicacion = wLoc.Local
                        NombreLocalActual = wLoc.NombreLocal
                    Else
                        MsgError("El local asignado al usuario no esta registrado")
                        Exit Sub
                    End If

                    UsuarioActual = wUsr.Usuario
                    NombreUsuarioActual = wUsr.NombreUsr
                    ClienteUsuarioActual = wUsr.Empresa
                    G_LOCALACTUAL = cLocal.SelectedValue.ToString.ToInteger()
                    G_ACCESOUSUARIO = wUsr.Acceso

                    If G_ACCESOUSUARIO > 5 Then
                        G_SUPERVISOR = True
                    Else
                        G_SUPERVISOR = False
                    End If

                    Dim CLI = DC.T_Clientes.FirstOrDefault(Function(x) x.Rut = wLoc.RutLocal.Replace(",", "."))
                    If CLI Is Nothing Then
                        MsgError("El Rut asociado al Local no es válido, o no existe el Cliente.")
                        Exit Sub
                    End If

                    G_CLIENTEACTUAL = CLI.Cliente
                    G_FANTASIACLIENTE = CLI.Fantasia

                    If wUsr.Acceso = 9 Then
                        G_PROGRAMADOR = True
                    Else
                        G_PROGRAMADOR = False
                    End If

                    Auditoria(Me.Text, "Acceso al Sistema", xUsuario.Text, "0")
                    Me.Hide()
                    Menu_Principal.Show()

                Else
                    Auditoria(Me.Text, "Clave Incorrecta", xUsuario.Text, xClave.Text)
                    MsgError("La Clave es Incorrecta")
                    xClave.Text = ""
                    xClave.Focus()
                End If
            Else
                Auditoria(Me.Text, "Usuario No Existe", xUsuario.Text, xClave.Text)
                MsgError("El Usuario ingresado no Existe")
                xUsuario.Text = ""
                xClave.Text = ""
                xUsuario.Focus()
            End If
        Catch ex As Exception
            MsgError(ex.Message)
        End Try
    End Sub

    Private Sub Acceso_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Using pen As New Pen(Color.FromArgb(1, 26, 103))
            Dim rect As Rectangle = DisplayRectangle
            rect.Width -= 1
            rect.Height -= 1
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub cLocal_KeyDown(sender As Object, e As KeyEventArgs) Handles cLocal.KeyDown, cServidor.KeyDown
        If e.KeyCode = Keys.Enter Then
            bAceptar.Focus()
        End If
    End Sub


    <DllImport("user32")>
    Private Shared Function GetWindowDC(hwnd As IntPtr) As IntPtr
    End Function

    <DllImport("user32")>
    Private Shared Function ReleaseDC(hwnd As IntPtr, hdc As IntPtr) As IntPtr
    End Function

    <DebuggerStepThrough()>
    Private Sub Panel_OnPaint(sender As Object, e As PaintEventArgs) Handles gUsuario.Paint
        Try
            Dim wGroup As GroupBox = CType(sender, GroupBox)
            Dim hdc As IntPtr = GetWindowDC(wGroup.Handle)
            Dim g As Graphics = Graphics.FromHdc(hdc)


            Dim wListaControles = New List(Of Control) From {
                xUsuario,
                xClave
            }

            For Each wControl In wListaControles

                DrawRoundedRectangle(g, New Rectangle(wControl.Location.X - 3, wControl.Location.Y - 3,
                                                      wControl.ClientRectangle.Width + 3, wControl.ClientRectangle.Height + 5),
                                     New Pen(Color.FromArgb(133, 157, 178), 1), 3)

            Next

            g.Dispose()
            ReleaseDC(wGroup.Handle, hdc)
        Catch ex As Exception
        End Try

    End Sub


    Private Sub cServidor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cServidor.KeyPress
        e.NextControl(xUsuario)
    End Sub

    Private Sub cLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cLocal.KeyPress
        e.NextControl(xUsuario)
    End Sub

    Private Sub xUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xUsuario.KeyPress
        e.NextControl(xClave)
    End Sub

    Private Sub xClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xClave.KeyPress
        ValidarDigitos(e)
        e.NextControl(bAceptar)
    End Sub


End Class