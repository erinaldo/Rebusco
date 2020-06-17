Public Class NumeroPOS
    Public ID_POS As Decimal
    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        ID_POS = xPOS.ToDecimal
        DialogResult = DialogResult.OK
    End Sub

    Private Sub xPOS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xPOS.KeyPress
        ValidarDigitos(e)
        e.NextControl(bAceptar)
    End Sub

    Private Sub NumeroPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xPOS.Focus()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class