Public Class CreditoPersona
    Private Sub CreditoPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cFuncionario.LoadItemsObj("Usuarios", "Usuario", "Nombreusr", " WHERE Funcionario = 1 Order by NombreUsr")
        Auditoria(Text, A_INGRESADO, UsuarioActual)
    End Sub

    Private Sub xMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMonto.KeyPress
        ValidarDigitos(e)
        e.NextControl(xCuota)
    End Sub

    Private Sub xCuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCuota.KeyPress
        ValidarDigitos(e)
        e.NextControl(xValorCuota)
    End Sub

    Private Sub xValorCuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xValorCuota.KeyPress
        ValidarDigitos(e)
        e.NextControl(xGlosa)
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If Not IsDate(dFechaCuota.Value) Then
            MsgError("Error en Fecha")
            Exit Sub
        End If

        If Val(xMonto.Text) = 0 Then
            MsgError("Deve ingrsar un Monto")
            Exit Sub
        End If

        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wSDT As New T_Sueldos_Detalles

        wSDT.Fecha = dFechaCuota.Value
        wSDT.Usuario = cFuncionario.SelectedValue.ToString
        wSDT.Estado = "0"
        wSDT.EventoRem = 22
        wSDT.Monto = Val(xMonto.Text.Trim)
        wSDT.Glosa = xGlosa.Text.Trim
        wSDT.UsuarioRem = UsuarioActual
        DC.T_Sueldos_Detalles.InsertOnSubmit(wSDT)
        DC.SubmitChanges()

        Dim wBoucher = Val(SiguienteCorrelativo("Sueldos_Detalles")) - 1
        Auditoria(Me.Text, "Crear Créditos para Personal", cFuncionario.SelectedValue.ToString, xMonto.Text)
        Mensaje("Datos Ingresados, Boucher N° : " & wSDT.Id)
        bLimpiar_Click()
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub
End Class