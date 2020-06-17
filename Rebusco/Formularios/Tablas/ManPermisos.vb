Public Class ManPermisos
    Implements iFormulario
    Const T_CHECK = 0
    Const T_MODULO = 1
    Const T_TEXTO = 2
    Private Sub ManPermisos_Load(sender As Object, e As EventArgs) Handles Me.Load
        cAccesoUsuario.LoadItemsObj("Accesos", "Acceso", "NombreAcceso", " WHERE Acceso <=" & G_ACCESOUSUARIO)
        cAccesoUsuarioImportar.LoadItemsObj("Accesos", "Acceso", "NombreAcceso", " WHERE Acceso <=" & G_ACCESOUSUARIO)
        Auditoria(Text, "Ingreso", "", "")
    End Sub
    Sub Titulos()

        xTablaModulos.Redraw = False
        xTablaModulos.Clear()
        xTablaModulos.Rows.Count = 1
        xTablaModulos.Cols.Count = 3

        xTablaModulos.Cols(T_CHECK).Width = 50
        xTablaModulos.Cols(T_TEXTO).Width = 415
        xTablaModulos.Cols(T_MODULO).Width = 0

        xTablaModulos.Cols(T_CHECK).Caption = "Marcar"
        xTablaModulos.Cols(T_MODULO).Caption = "Módulo"
        xTablaModulos.Cols(T_TEXTO).Caption = "Texto"

        xTablaModulos.Cols(T_CHECK).DataType = GetType(Boolean)
        xTablaModulos.Redraw = True
    End Sub

    Sub TitulosHabilitados()

        xTablaHabilitados.Redraw = False
        xTablaHabilitados.Clear()
        xTablaHabilitados.Rows.Count = 1
        xTablaHabilitados.Cols.Count = 3

        xTablaHabilitados.Cols(T_CHECK).Width = 50
        xTablaHabilitados.Cols(T_TEXTO).Width = 432
        xTablaHabilitados.Cols(T_MODULO).Width = 0

        xTablaHabilitados.Cols(T_CHECK).Caption = "Marcar"
        xTablaHabilitados.Cols(T_MODULO).Caption = "Módulo"
        xTablaHabilitados.Cols(T_TEXTO).Caption = "Texto"

        xTablaHabilitados.Cols(T_CHECK).DataType = GetType(Boolean)
        xTablaHabilitados.Redraw = True
    End Sub

    Private Sub bCargarA_Click(sender As Object, e As EventArgs) Handles bCargarA.Click
        Dim wCampo As String = If(oAccesoA.Checked, "Acceso", "Usuario")
        bCargarA.Enabled = False
        bImportarI.Enabled = False
        CargarModulosNew(wCampo)
        bCargarA.Enabled = True
        bImportarI.Enabled = True
    End Sub

    Private Sub bImportarI_Click(sender As Object, e As EventArgs) Handles bImportarI.Click
        Dim wCampo As String = If(oAccesoI.Checked, "Acceso", "Usuario")
        bCargarA.Enabled = False
        bImportarI.Enabled = False
        CargarModulosNew(wCampo)
        bCargarA.Enabled = True
        bImportarI.Enabled = True
    End Sub
    Private Sub CargarModulosNew(wTipo As String)
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Cursor = Cursors.WaitCursor
        TitulosHabilitados()
        Titulos()
        Dim wModulos = DC.T_Modulos.ToList()
        If wTipo = "Usuario" Then
            Dim wPermisosCedibles = DC.T_PermisosUsuario.Where(Function(x) x.Usuario = xCodigoCargar.Text.Trim).Select(Function(x) x.Modulo).ToList
            If wPermisosCedibles.Any Then
                tEstado.Text = "Cargando Permisos, espere por favor..."
                pBarraProgreso.Visible = True
                pBarraProgreso.Value = 0
                Dim wModulosSinPermiso = DC.T_Modulos.Where(Function(x) Not wPermisosCedibles.Contains(x.Modulo))
                If wModulosSinPermiso.Any Then
                    tEstado.Text = "Cargando Módulos, espere por favor..."
                    pBarraProgreso.Maximum = wModulosSinPermiso.Count
                    For Each wP In wModulosSinPermiso
                        xTablaModulos.AddItem("")
                        xTablaModulos.SetData(xTablaModulos.Rows.Count - 1, T_CHECK, False)
                        xTablaModulos.SetData(xTablaModulos.Rows.Count - 1, T_MODULO, wP.Modulo)
                        xTablaModulos.SetData(xTablaModulos.Rows.Count - 1, T_TEXTO, wP.Texto)
                        pBarraProgreso.Value += 1
                        DoEvents()
                    Next
                End If

                Dim wPermisosAsignados = DC.T_PermisosUsuario.Where(Function(x) x.Usuario = xCodigoCargar.Text)
                If wPermisosAsignados.Any Then
                    pBarraProgreso.Value = 0
                    tEstado.Text = "Cargando Permisos Asignados, espere por favor..."
                    pBarraProgreso.Maximum = wPermisosAsignados.Count
                    For Each wP In wPermisosAsignados
                        Dim wTextoModulo = wModulos.FirstOrDefault(Function(x) x.Modulo = wP.Modulo)
                        xTablaHabilitados.AddItem("")
                        xTablaHabilitados.SetData(xTablaHabilitados.Rows.Count - 1, T_CHECK, False)
                        xTablaHabilitados.SetData(xTablaHabilitados.Rows.Count - 1, T_MODULO, wP.Modulo)
                        xTablaHabilitados.SetData(xTablaHabilitados.Rows.Count - 1, T_TEXTO, If(wTextoModulo IsNot Nothing, wTextoModulo.Texto, ""))
                        pBarraProgreso.Value += 1
                        DoEvents()
                    Next
                End If
            End If
        ElseIf wTipo = "Acceso" Then
            Dim wPermisosAcceso = DC.T_PermisosAcceso.Where(Function(x) x.Acceso = CInt(xCodigoImportar.Text)).Select(Function(x) x.Modulo).ToList
            If wPermisosAcceso.Any Then
                tEstado.Text = "Cargando Permisos, espere por favor..."
                pBarraProgreso.Visible = True
                pBarraProgreso.Value = 0
                Dim wPermisosModulos = DC.T_PermisosAcceso.Where(Function(x) x.Acceso <= G_ACCESOUSUARIO And Not wPermisosAcceso.Contains(x.Modulo))
                If wPermisosModulos.Any Then
                    tEstado.Text = "Cargando Módulos, espere por favor..."
                    pBarraProgreso.Maximum = wPermisosModulos.Count
                    For Each wP In wPermisosModulos
                        Dim wTextoModulo = wModulos.FirstOrDefault(Function(x) x.Modulo = wP.Modulo)
                        xTablaModulos.AddItem("")
                        xTablaModulos.SetData(xTablaModulos.Rows.Count - 1, T_CHECK, False)
                        xTablaModulos.SetData(xTablaModulos.Rows.Count - 1, T_MODULO, wP.Modulo)
                        xTablaModulos.SetData(xTablaModulos.Rows.Count - 1, T_TEXTO, If(wTextoModulo IsNot Nothing, wTextoModulo.Texto, ""))
                        pBarraProgreso.Value += 1
                        DoEvents()
                    Next
                End If
                Dim wPermisosAsignados = DC.T_PermisosAcceso.Where(Function(x) x.Acceso = CInt(xCodigoImportar.Text))
                If wPermisosAsignados.Any Then
                    tEstado.Text = "Cargando Permisos Asignados, espere por favor..."
                    pBarraProgreso.Maximum = wPermisosAsignados.Count
                    For Each wP In wPermisosAsignados
                        Dim wTextoModulo = wModulos.FirstOrDefault(Function(x) x.Modulo = wP.Modulo)
                        xTablaHabilitados.AddItem("")
                        xTablaHabilitados.SetData(xTablaHabilitados.Rows.Count - 1, T_CHECK, False)
                        xTablaHabilitados.SetData(xTablaHabilitados.Rows.Count - 1, T_MODULO, wP.Modulo)
                        xTablaHabilitados.SetData(xTablaHabilitados.Rows.Count - 1, T_TEXTO, If(wTextoModulo IsNot Nothing, wTextoModulo.Texto, ""))
                        pBarraProgreso.Value += 1
                        DoEvents()
                    Next
                End If
            End If
        End If

        If xTablaModulos.Rows.Count = 1 Then
         '   CargarModulos()
        End If
        tEstado.Text = "Listo"
        pBarraProgreso.Visible = False
        Cursor = Cursors.Arrow
    End Sub

    Private Sub xCodigoCargar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCodigoCargar.KeyPress
        e.NextControl(bCargarA)
        If oAccesoA.Checked Then
            ValidarDigitos(e)
        End If
    End Sub

    Private Sub xCodigoImportar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCodigoImportar.KeyPress
        e.NextControl(bImportarI)
        If oAccesoI.Checked Then
            ValidarDigitos(e)
        End If
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        bGuardar.Enabled = False
        GuardarPermisos()
        If oAccesoA.Checked Then bAplicarTodo.Enabled = True
        bGuardar.Enabled = True
    End Sub
    Private Sub GuardarPermisos()

        Cursor = Cursors.WaitCursor

        Dim wTabla As String = If(oAccesoA.Checked, "PermisosAcceso", "PermisosUsuario")
        Dim wCampo As String = If(oAccesoA.Checked, "Acceso", "Usuario")
        Dim wCodigo As String = If(xCodigoImportar.Text <> "", xCodigoImportar.Text, xCodigoCargar.Text.Trim)
        Dim wTexto As String = If(xCodigoImportar.Text <> "", cAccesoUsuarioImportar.Text, cAccesoUsuario.Text)

        If xTablaHabilitados.Rows.Count = 1 Then Exit Sub

        SQL("DELETE FROM " & wTabla & " WHERE " & wCampo & " = '" & wCodigo & "'")
        Dim DC = New MarketONEDataContext(P_CONEXION)

        For wFila As Integer = 1 To xTablaHabilitados.Rows.Count - 1
            If wTabla = "PermisosAcceso" Then
                Dim wPermiso As New T_PermisosAcceso
                wPermiso.Acceso = wCodigo.ToDecimal
                wPermiso.Modulo = CInt(xTablaHabilitados.GetData(wFila, T_MODULO).ToString)
                DC.T_PermisosAcceso.InsertOnSubmit(wPermiso)
            ElseIf wTabla = "PermisosUsuario" Then
                Dim wPermiso As New T_PermisosUsuario
                wPermiso.Usuario = wCodigo
                wPermiso.Modulo = CInt(xTablaHabilitados.GetData(wFila, T_MODULO).ToString)
                DC.T_PermisosUsuario.InsertOnSubmit(wPermiso)
            End If
        Next
        DC.SubmitChanges()
        Mensaje("Se han establecido los Módulos Habilitados para el " & wCampo & " " & wTexto)

        If wCampo = "Acceso" Then
            Dim Usr = SQL("SELECT * FROM (SELECT Usuario, (SELECT COUNT(*) FROM PermisosUsuario WHERE Usuario = Usuarios.Usuario) " &
                      "AS 'CantPermisos' FROM Usuarios WHERE Acceso = " & wCodigo & ") AS Usr WHERE CantPermisos = 0")
            If Usr.Rows.Count > 0 Then
                For Each wU As DataRow In Usr.Rows
                    SQL("INSERT INTO PermisosUsuario (Usuario, Modulo) " &
                        "SELECT '" & wU.GetText("Usuario") & "' AS Usuario, Modulo FROM PermisosAcceso WHERE Acceso = " & wCodigo)
                Next
                Mensaje("Se han actualizado " & Usr.Rows.Count & " Usuarios con el Acceso " & wTexto & "." &
                        " Estos usuarios no tenían permisos establecidos.")
            End If
        End If
        Auditoria(Text, A_MODIFICADO, xCodigoCargar.Text.Trim, cAccesoUsuario.SelectedValue.ToString)
        Cursor = Cursors.Arrow

    End Sub
    Private Sub bHabilitar_Click(sender As Object, e As EventArgs) Handles bHabilitar.Click
        Dim wFilaTraspaso As Integer
        Dim wFilasTraspasadas As New Stack(Of Integer)

        xTablaHabilitados.Redraw = False
        xTablaModulos.Redraw = False
        Cursor = Cursors.WaitCursor

        If xTablaModulos.Rows.Count > 1 Then
            For wFila As Integer = 1 To xTablaModulos.Rows.Count - 1
                If CBool(xTablaModulos.GetData(wFila, T_CHECK)) Then
                    xTablaHabilitados.AddItem("")
                    wFilaTraspaso = xTablaHabilitados.Rows.Count - 1
                    xTablaHabilitados.SetData(wFilaTraspaso, T_CHECK, False)
                    xTablaHabilitados.SetData(wFilaTraspaso, T_TEXTO, xTablaModulos.GetData(wFila, T_TEXTO))
                    xTablaHabilitados.SetData(wFilaTraspaso, T_MODULO, xTablaModulos.GetData(wFila, T_MODULO))
                    wFilasTraspasadas.Push(wFila)
                End If
            Next

            For Each wFilaEliminar As Integer In wFilasTraspasadas
                xTablaModulos.RemoveItem(wFilaEliminar)
            Next

        End If
        xTablaHabilitados.Redraw = True
        xTablaModulos.Redraw = True
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bDeshabilitar_Click(sender As Object, e As EventArgs) Handles bDeshabilitar.Click
        Dim wFilaTraspaso As Integer
        Dim wFilasTraspasadas As New Stack(Of Integer)

        xTablaHabilitados.Redraw = False
        xTablaModulos.Redraw = False
        Cursor = Cursors.WaitCursor

        If xTablaHabilitados.Rows.Count > 1 Then
            For wFila As Integer = 1 To xTablaHabilitados.Rows.Count - 1
                If CBool(xTablaHabilitados.GetData(wFila, T_CHECK)) Then
                    xTablaModulos.AddItem("")
                    wFilaTraspaso = xTablaModulos.Rows.Count - 1
                    xTablaModulos.SetData(wFilaTraspaso, T_CHECK, False)
                    xTablaModulos.SetData(wFilaTraspaso, T_TEXTO, xTablaHabilitados.GetData(wFila, T_TEXTO))
                    xTablaModulos.SetData(wFilaTraspaso, T_MODULO, xTablaHabilitados.GetData(wFila, T_MODULO))
                    wFilasTraspasadas.Push(wFila)
                End If
            Next

            For Each wFilaEliminar As Integer In wFilasTraspasadas
                xTablaHabilitados.RemoveItem(wFilaEliminar)
            Next

        End If

        xTablaHabilitados.Redraw = True
        xTablaModulos.Redraw = True
        Cursor = Cursors.Arrow
    End Sub

    Private Sub xTablaModulos_Click(sender As Object, e As EventArgs) Handles xTablaModulos.Click
        If xTablaModulos.Rows.Count > 1 AndAlso xTablaModulos.Row > 0 Then
            Dim wCheck = (xTablaModulos.GetData(xTablaModulos.Row, T_CHECK))
            xTablaModulos.SetData(xTablaModulos.Row, T_CHECK, Not True)
        End If
    End Sub

    Private Sub xTablaHabilitados_Click(sender As Object, e As EventArgs) Handles xTablaHabilitados.Click
        If xTablaHabilitados.Rows.Count > 1 AndAlso xTablaHabilitados.Row > 0 Then
            Dim wCheck = (xTablaHabilitados.GetData(xTablaHabilitados.Row, T_CHECK))
            xTablaHabilitados.SetData(xTablaHabilitados.Row, T_CHECK, Not True)
        End If
    End Sub

    Private Sub xTablaModulos_DoubleClick(sender As Object, e As EventArgs) Handles xTablaModulos.DoubleClick
        Dim wFila As Integer
        If xTablaModulos.Rows.Count > 1 AndAlso xTablaModulos.Row > 0 Then
            xTablaHabilitados.AddItem("")
            wFila = xTablaHabilitados.Rows.Count - 1
            xTablaHabilitados.SetData(wFila, T_CHECK, False)
            xTablaHabilitados.SetData(wFila, T_MODULO, xTablaModulos.GetData(xTablaModulos.Row, T_MODULO))
            xTablaHabilitados.SetData(wFila, T_TEXTO, xTablaModulos.GetData(xTablaModulos.Row, T_TEXTO))
            xTablaModulos.RemoveItem(xTablaModulos.Row)

        End If
    End Sub

    Private Sub xTablaHabilitados_DoubleClick(sender As Object, e As EventArgs) Handles xTablaHabilitados.DoubleClick
        Dim wFila As Integer
        If xTablaHabilitados.Rows.Count > 1 AndAlso xTablaHabilitados.Row > 0 Then
            xTablaModulos.AddItem("")
            wFila = xTablaModulos.Rows.Count - 1
            xTablaModulos.SetData(wFila, T_CHECK, False)
            xTablaModulos.SetData(wFila, T_MODULO, xTablaHabilitados.GetData(xTablaHabilitados.Row, T_MODULO))
            xTablaModulos.SetData(wFila, T_TEXTO, xTablaHabilitados.GetData(xTablaHabilitados.Row, T_TEXTO))
            xTablaHabilitados.RemoveItem(xTablaHabilitados.Row)
        End If
    End Sub

    Private Sub bMarcarModulos_Click(sender As Object, e As EventArgs) Handles bMarcarModulos.Click
        If xTablaModulos.Rows.Count = 1 Then Exit Sub
        For wFila As Integer = 1 To xTablaModulos.Rows.Count - 1
            xTablaModulos.SetData(wFila, T_CHECK, True)
        Next
    End Sub

    Private Sub bMarcarHabilitados_Click(sender As Object, e As EventArgs) Handles bMarcarHabilitados.Click
        If xTablaHabilitados.Rows.Count = 1 Then Exit Sub
        For wFila As Integer = 1 To xTablaHabilitados.Rows.Count - 1
            xTablaHabilitados.SetData(wFila, T_CHECK, True)
        Next
    End Sub

    Private Sub bDesmarcarModulos_Click(sender As Object, e As EventArgs) Handles bDesmarcarModulos.Click
        If xTablaModulos.Rows.Count = 1 Then Exit Sub
        For wFila As Integer = 1 To xTablaModulos.Rows.Count - 1
            xTablaModulos.SetData(wFila, T_CHECK, False)
        Next
    End Sub

    Private Sub bDesmarcarHab_Click(sender As Object, e As EventArgs) Handles bDesmarcarHab.Click
        If xTablaHabilitados.Rows.Count = 1 Then Exit Sub
        For wFila As Integer = 1 To xTablaHabilitados.Rows.Count - 1
            xTablaHabilitados.SetData(wFila, T_CHECK, False)
        Next
    End Sub

    Private Sub bBuscarModulos_Click(sender As Object, e As EventArgs) Handles bBuscarModulos.Click

        If xTablaModulos.Rows.Count <= 1 Then Exit Sub
        Dim wFilaBuscada = xTablaModulos.BuscarFila(xBuscarMod.Text, T_TEXTO, xTablaModulos.Selection.BottomRow)
        If xTablaModulos.Selection.BottomRow = wFilaBuscada Then
            Buscar(xTablaModulos, xTablaModulos.Row + 1, xBuscarMod.Text, T_TEXTO)
        Else
            Buscar(xTablaModulos, 0, xBuscarMod.Text, T_TEXTO)
        End If
        bBuscarModulos.Focus()
    End Sub
    Private Sub Buscar(ByVal wTabla As C1.Win.C1FlexGrid.C1FlexGrid, ByVal wInicio As Integer, ByVal wTexto As String, ByVal wColumna As Integer)
        Dim wFilaBuscada = wTabla.BuscarFila(wTexto, T_TEXTO, wInicio)

        If wTabla.Selection.BottomRow = wTabla.Rows.Count - 1 Then
            Buscar(wTabla, 0, wTexto, wColumna)
        End If

        If wTabla.Selection.BottomRow = wFilaBuscada Then
            Buscar(wTabla, wTabla.Row + 1, wTexto, wColumna)
            Exit Sub
        End If

        If wFilaBuscada > 0 Then
            wTabla.Select(wFilaBuscada, T_CHECK)
        Else
            wTabla.Select(1, T_CHECK)
        End If
    End Sub

    Private Sub bAplicarTodo_Click(sender As Object, e As EventArgs) Handles bAplicarTodo.Click
        If Not oAccesoA.Checked Then Exit Sub

        Dim wTexto As String = cAccesoUsuario.Text

        If Not Pregunta("¿Desea aplicar los permisos a todos los usuarios del Acceso " & wTexto & "?") Then Exit Sub

        bAplicarTodo.Enabled = False
        bGuardar.Enabled = False
        Cursor = Cursors.WaitCursor

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wUsr = DC.T_Usuarios.Select(Function(x) x.Usuario).Distinct
        If wUsr.Any Then
            For Each wU In wUsr
                SQL("DELETE FROM PermisosUSuario WHERE Usuario = '" & wU & "'")
                SQL("INSERT INTO PermisosUsuario (Usuario, Modulo) " &
                    "Select '" & wU & "' AS Usuario, Modulo FROM PermisosAcceso WHERE Acceso = " & xCodigoCargar.Text.Trim)
            Next
            Mensaje("Se han actualizado " & wUsr.Count & " Usuarios con el Acceso " & cAccesoUsuario.Text)
        End If

        bAplicarTodo.Enabled = False
        bGuardar.Enabled = True
        Cursor = Cursors.Arrow
        Auditoria(Text, "Asigno mismo permisos", xCodigoCargar.Text.Trim, cAccesoUsuario.SelectedValue.ToString)
    End Sub

    Private Sub bManUsuario_Click(sender As Object, e As EventArgs) Handles bManUsuario.Click
        Dim wCodigo As String = xCodigoCargar.Text

        ManUsuarios.ShowDialog()

        xCodigoImportar.Clear()
        If oAccesoA.Checked Then
            cAccesoUsuario.LoadItemsObj("Accesos", "Acceso", "NombreAcceso")
        Else
            cAccesoUsuario.LoadItemsObj("Usuarios", "Usuario", "NombreUsr")
        End If

        If oAccesoI.Checked Then
            cAccesoUsuarioImportar.LoadItemsObj("Accesos", "Acceso", "NombreAcceso")
        Else
            cAccesoUsuarioImportar.LoadItemsObj("Usuarios", "Usuario", "NombreUsr")
        End If
        BringToFront()
    End Sub

    Private Sub bManAcceso_Click(sender As Object, e As EventArgs) Handles bManAcceso.Click
        Dim wCodigo As String = xCodigoCargar.Text

        ManAccesos.ShowDialog()
        If oAccesoA.Checked Then
            cAccesoUsuario.LoadItemsObj("Accesos", "Acceso", "NombreAcceso")
        End If
        xCodigoImportar.Clear()
        BringToFront()
    End Sub

    Private Sub oAccesoA_CheckedChanged(sender As Object, e As EventArgs) Handles oAccesoA.CheckedChanged, oUsuarioA.CheckedChanged
        If oAccesoA.Checked Then
            cAccesoUsuario.LoadItemsObj("Accesos", "Acceso", "NombreAcceso", " WHERE Acceso <=" & G_ACCESOUSUARIO)
        ElseIf oUsuarioA.Checked Then
            cAccesoUsuario.LoadItemsObj("Usuarios", "Usuario", "NombreUsr", " WHERE Acceso <=" & G_ACCESOUSUARIO)
            bAplicarTodo.Visible = False
        End If
        xCodigoCargar.Clear()
    End Sub

    Private Sub oAccesoI_CheckedChanged(sender As Object, e As EventArgs) Handles oAccesoI.CheckedChanged, oUsuarioI.CheckedChanged
        If oAccesoI.Checked Then
            cAccesoUsuarioImportar.LoadItemsObj("Accesos", "Acceso", "NombreAcceso", " WHERE Acceso <=" & G_ACCESOUSUARIO)
        ElseIf oUsuarioI.Checked Then
            cAccesoUsuarioImportar.LoadItemsObj("Usuarios", "Usuario", "NombreUsr", " WHERE Acceso <=" & G_ACCESOUSUARIO)
            bAplicarTodo.Visible = False
        End If
        xCodigoImportar.Clear()
    End Sub

    Private Sub xBuscarMod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBuscarMod.KeyPress
        e.NextControl(bBuscarModulos)
    End Sub

    Private Sub xBuscarHab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBuscarHab.KeyPress
        e.NextControl(xBuscarHab)
    End Sub

    Private Sub xCodigoCargar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xCodigoCargar.Validating
        If xCodigoCargar.Text.Trim <> "" Then
            cAccesoUsuario.SelectedValue = xCodigoCargar.Text.Trim
            If cAccesoUsuario.Text = W_SELECCIONAR Then
                If oAccesoA.Checked Then MsgError("Acceso no encontrado")
                If oUsuarioA.Checked Then MsgError("Usuario no encontrado")
                xCodigoCargar.Clear()
                xCodigoCargar.Focus()
            End If
        End If
    End Sub

    Private Sub cAccesoUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cAccesoUsuario.SelectedIndexChanged
        If cAccesoUsuario.Text <> "" Then
            xCodigoCargar.Text = cAccesoUsuario.SelectedValue.ToString
        Else
            xCodigoCargar.Clear()
        End If
    End Sub

    Private Sub xCodigoImportar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xCodigoImportar.Validating
        If xCodigoImportar.Text.Trim <> "" Then
            cAccesoUsuarioImportar.SelectedValue = xCodigoImportar.Text.Trim
            If cAccesoUsuarioImportar.Text = W_SELECCIONAR Then
                If oAccesoI.Checked Then MsgError("Acceso no encontrado")
                If oUsuarioI.Checked Then MsgError("Usuario no encontrado")
                xCodigoImportar.Clear()
                xCodigoImportar.Focus()
            End If
        End If
    End Sub

    Private Sub cAccesoUsuarioImportar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cAccesoUsuarioImportar.SelectedIndexChanged
        If cAccesoUsuarioImportar.Text <> "" Then
            xCodigoImportar.Text = cAccesoUsuarioImportar.SelectedValue.ToString
        Else
            xCodigoImportar.Clear()
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bBuscarA_Click(sender As Object, e As EventArgs) Handles bBuscarA.Click
        Dim wQuery As String
        If oAccesoA.Checked Then
            wQuery = "SELECT Acceso , NombreAcceso as 'Descripción' From Accesos"
            Buscador.Show()
            Buscador.Configurar(wQuery, "Acceso", Me, "Accesos", xCodigoCargar)
        ElseIf oUsuarioA.Checked Then
            wQuery = "SELECT Usuario , NombreUsr as 'Nombre Usuario' From Usuarios"
            Buscador.Show()
            Buscador.Configurar(wQuery, "Usuario", Me, "Usuarios", xCodigoCargar)
        End If
    End Sub
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub bBuscarI_Click(sender As Object, e As EventArgs) Handles bBuscarI.Click
        Dim wQuery As String
        If oAccesoI.Checked Then
            wQuery = "SELECT Acceso , NombreAcceso as 'Descripción' From Accesos"
            Buscador.Show()
            Buscador.Configurar(wQuery, "Acceso", Me, "Accesos", xCodigoImportar)
        ElseIf oUsuarioI.Checked Then
            wQuery = "SELECT Usuario , NombreUsr as 'Nombre Usuario' From Usuarios"
            Buscador.Show()
            Buscador.Configurar(wQuery, "Usuario", Me, "Usuarios", xCodigoImportar)
        End If
    End Sub

    Sub CargarModulos()
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wMod = DC.T_Modulos()
        If wMod.Any Then
            Titulos()
            For Each wM In wMod
                xTablaModulos.AddItem("")
                xTablaModulos.SetData(xTablaModulos.Rows.Count - 1, T_MODULO, wM.Modulo)
                xTablaModulos.SetData(xTablaModulos.Rows.Count - 1, T_TEXTO, wM.Texto)
            Next
        End If
    End Sub

    Private Sub bBuscarHabilitado_Click(sender As Object, e As EventArgs) Handles bBuscarHabilitado.Click

    End Sub
End Class