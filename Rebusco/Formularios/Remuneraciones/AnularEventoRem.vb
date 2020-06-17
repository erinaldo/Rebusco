Public Class AnularEventoRem
    Private Sub AnularEventoRem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Auditoria(Me.Text, "Anular Evento de Remuneración")
    End Sub

    Private Sub xBoucher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBoucher.KeyPress
        ValidarDigitos(e)
        e.NextControl(xFecha)
    End Sub

    Private Sub xBoucher_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xBoucher.Validating
        If xBoucher.Text = "" Then Exit Sub

        Dim wRem = SQL("Select * from Sueldos_Detalles where Id = " & Val(xBoucher.Text)).Top
        If wRem Is Nothing Then
            MsgError("Boucher No Encontrado")
            bLimpiar_Click()
            Exit Sub
        End If
        If wRem.GetNum("Estado") = 1 Then
            MsgError("Boucher ya procesado, Imposible de Anular.")
            bLimpiar_Click()
            Exit Sub
        End If

        xFecha.Text = FormatDateTime(wRem.GetDate("Fecha"), DateFormat.ShortDate)
        Dim wUsr = SQL("Select NombreUsr from Usuarios where Usuario = '" & wRem.GetText("Usuario") & "'").Top
        If wUsr IsNot Nothing Then
            xFuncionario.Text = wUsr.GetText("NombreUsr")
        Else
            xFuncionario.Text = ""
        End If
        Dim wEvR = SQL("Select * from EventosRem where EventoRem = " & wRem.GetNum("EventoRem")).Top
        If wEvR IsNot Nothing Then
            xEvento.Text = wEvR.GetText("DescEventoRem")
        Else
            xEvento.Text = ""
        End If
        xMonto.Text = FormatNumber(wRem.GetNum("Monto"), 0,,, TriState.True)
        xGlosa.Text = wRem.GetText("Glosa")
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        xBoucher.Focus()
    End Sub

    Private Sub bAnular_Click(sender As Object, e As EventArgs) Handles bAnular.Click
        If xBoucher.Text.Trim = "" Then
            MsgError("Falta N° Boucher")
            Exit Sub
        End If
        If xFecha.Text = "" Then
            MsgError("Faltan Datos")
            Exit Sub
        End If

        If Pregunta("Desea Anular Boucher") Then

            If Not SQLUpdate("Delete Sueldos_Detalles where Id = " & Val(xBoucher.Text.Trim)) Then
                MsgError("Boucher no pudo ser Anulado.")
            Else
                Mensaje("Boucher Anulado")
            End If

            Auditoria(Text, "Anular Evento de Remuneración", xFuncionario.Text, xBoucher.Text.Trim)
            bLimpiar_Click()
            Exit Sub
        End If
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub
End Class