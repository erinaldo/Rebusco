Imports System.ComponentModel

Public Class ManAccesos
    Private Sub ManUnidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos(Me)
        bGuardar.Text = "Guardar"
        xAcceso.Focus()
        Auditoria(Me.Text, A_INGRESADO, "", "")
    End Sub
    Private Sub xTipoMov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xAcceso.KeyPress
        ValidarDigitos(e)
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xAcceso_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xAcceso.Validating
        Try
            If xAcceso.Text.Trim <> "" Then
                Dim wAcc = SQL("SELECT * FROM Accesos WHERE Acceso = '" & xAcceso.Text.Trim & "'").Top
                If wAcc IsNot Nothing Then
                    xDescripcion.Text = wAcc.GetText("NombreAcceso")
                    bGuardar.Text = "Modificar"
                Else
                    xDescripcion.Focus()
                    bGuardar.Text = "Guardar"
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

        Dim wMensaje As String = "Registro Modificado Correctamente"
        If xAcceso.Text = "" Then
            MsgError("Ingrese Numero Acceso")
            xAcceso.Focus()
            Exit Sub
        End If
        If xDescripcion.Text = "" Then
            MsgError("Ingrese Descripción")
            xDescripcion.Focus()
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wAcc As New T_Accesos
        Dim qAcc = DC.T_Accesos.FirstOrDefault(Function(x) x.Acceso = CInt(xAcceso.Text))

        If qAcc IsNot Nothing Then wAcc = qAcc
        wAcc.NombreAcceso = xDescripcion.Text.Trim

        If qAcc Is Nothing Then
            DC.T_Accesos.InsertOnSubmit(wAcc)
            wMensaje = "Registro Guardado Correctamente"
        End If

        DC.SubmitChanges()
        Mensaje(wMensaje)
        Auditoria(Me.Text, A_GUARDADO, xAcceso.Text, xDescripcion.Text)
        bLimpiar_Click()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        bGuardar.Text = "Guardar"
        xAcceso.Focus()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Try
            If xAcceso.Text.Trim <> "" Then
                If ValidarEliminar("Acceso", xAcceso.Text.Trim, "Accesos") Then
                    MsgError("No se puede eliminar el Acceso")
                Else
                    SQL("DELETE FROM Accesos WHERE Acceso = '" & xAcceso.Text.Trim & "'")
                    Mensaje("Acceso eliminado correctamente")
                    Auditoria(Me.Text, A_ELIMINADO, xAcceso.Text, xDescripcion.Text)
                    bLimpiar_Click()
                End If
            End If
        Catch ex As Exception
            MsgError(ex.Message)
        End Try
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(bGuardar)
    End Sub
    Private Sub ManTipoMov_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        xAcceso.Focus()
    End Sub
End Class