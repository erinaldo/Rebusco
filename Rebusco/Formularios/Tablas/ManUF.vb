Public Class ManUF
    Private Sub ManUF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cAño.AñosMes("A")
        cMes.AñosMes("M")
        cAño.SelectedValue = Now.Year.ToString
        If Now.Month > 1 Then
            cMes.SelectedValue = Now.AddMonths(-1).Month.ToString
        Else
            cMes.SelectedValue = Now.Month.ToString
        End If
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim wMensaje As String() = {MSG_MODIFICADO, A_MODIFICADO}

        If Val(xUF.Text) = 0 Or Not IsNumeric(xUF.Text) Then
            MsgError("Debe ingresar el valor de la UF")
            xUF.Focus()
            Exit Sub
        End If
        If Val(xUTM.Text) = 0 Or Not IsNumeric(xUTM.Text) Then
            MsgError("Debe ingresar el valor de la UTM")
            xUTM.Focus()
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wUF As New T_UFs

        Dim qUF = DC.T_UFs.FirstOrDefault(Function(x) x.Año = cAño.Text.ToDecimal() And x.Mes = cMes.SelectedValue.ToString.ToDecimal())

        If qUF IsNot Nothing Then wUF = qUF

        wUF.Año = cAño.SelectedValue.ToString.ToDecimal()
        wUF.Mes = cMes.SelectedValue.ToString.ToDecimal()
        wUF.UF = xUF.Text.ToDecimal(2)
        wUF.UTM = xUTM.Text.ToDecimal(2)

        If qUF Is Nothing Then
            DC.T_UFs.InsertOnSubmit(wUF)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
        End If

        DC.SubmitChanges()
        Auditoria(Me.Name, wMensaje(1), Val(cAño.Text) & "-" & cMes.SelectedValue.ToString & "-" & xUF.Text, G_LOCALACTUAL.ToString)
        Interaction.MsgBox(wMensaje(0))
        bLimpiar_Click()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        xUF.Clear()
        xUTM.Clear()
        cMes.Focus()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub cMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cMes.SelectedIndexChanged
        cAño.Focus()
        BuscarGuardados()
    End Sub

    Private Sub cAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cAño.SelectedIndexChanged
        xUF.Focus()
        BuscarGuardados()
    End Sub

    Private Sub xUF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xUF.KeyPress
        e.NextControl(xUTM)
    End Sub

    Private Sub xUTM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xUTM.KeyPress
        e.NextControl(bGuardar)
    End Sub

    Private Sub BuscarGuardados()
        If cMes.SelectedValue Is Nothing Or cAño.SelectedValue Is Nothing Then
            Exit Sub
        End If
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wUF = DC.T_UFs.FirstOrDefault(Function(x) x.Año = Val(cAño.Text) And x.Mes = CInt(cMes.SelectedValue.ToString))

        If wUF Is Nothing Then
            xUF.Text = ""
            xUTM.Text = ""
        Else
            xUF.Text = Str(wUF.UF)
            xUTM.Text = Str(wUF.UTM)
        End If
    End Sub
End Class