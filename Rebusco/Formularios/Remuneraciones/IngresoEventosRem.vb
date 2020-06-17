Public Class IngresoEventosRem
    Implements iFormulario
    Private Sub IngresoEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cEvento.LoadItemsObj("EventosRem", "EventoRem", "DescEventoRem", " ORDER BY CalculoRem,DescEventoRem")
        Auditoria(Me.Text, "Ingresar", "")
    End Sub

    Private Sub xMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMonto.KeyPress
        ValidarDigitos(e)
        e.NextControl(xGlosa)
    End Sub

    Private Sub xGlosa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xGlosa.KeyPress
        e.NextControl(bGuardar)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

        If Not IsDate(dFecha.Value) Then
            MsgError("Error en Fecha")
            Exit Sub
        End If

        If cEvento.Text = "" Then
            MsgError("Debe seleccionar un Evento")
            Exit Sub
        End If
        If Val(xMonto.Text) = 0 Then
            MsgError("Deve ingresar un Monto")
            Exit Sub
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wRem As New T_Sueldos_Detalles

        wRem.Fecha = dFecha.Value
        wRem.Usuario = xIDFuncionario.Text.Trim
        wRem.Estado = "0"
        wRem.EventoRem = CInt(cEvento.SelectedValue.ToString)
        wRem.Monto = Val(xMonto.Text.Trim)
        wRem.Glosa = xGlosa.Text.Trim
        wRem.UsuarioRem = UsuarioActual

        DC.T_Sueldos_Detalles.InsertOnSubmit(wRem)
        DC.SubmitChanges()

        Auditoria(Me.Text, A_GUARDADO, xIDFuncionario.Text.Trim, cEvento.Text.Trim)

        Mensaje("Datos Ingresados, Boucher N° : " & wRem.Id)
        LimpiarCampos(Me)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xIDFuncionario.KeyPress
        e.NextControl(cEvento)
    End Sub

    Private Sub xIDFuncionario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xIDFuncionario.Validating

        If xIDFuncionario.Text.Trim = "" Then Exit Sub

        Dim wUsr = SQL("SELECT NombreUsr From Usuarios WHERE Usuario = '" & xIDFuncionario.Text.Trim & "' AND Funcionario = 1").Top
        If wUsr IsNot Nothing Then
            xFuncionario.Text = wUsr.GetText("NombreUsr")
        Else
            MsgError("Funcionario no encontrado")
            xIDFuncionario.Clear()
            xFuncionario.Clear()
            xIDFuncionario.Focus()
        End If
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Dim wQuery = "SELECT Usuario, NombreUsr FROM Usuarios"
        Buscador.Show()
        Buscador.Configurar(wQuery, "NombreUsr", Me, "Usuarios", xIDFuncionario)
    End Sub
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub
End Class