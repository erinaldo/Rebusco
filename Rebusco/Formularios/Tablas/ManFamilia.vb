Imports System.ComponentModel

Public Class ManFamilia
    Private Sub ManFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bNuevo_Click()
        Auditoria(Me.Text, A_INGRESADO, "", "")
    End Sub

    Private Sub bNuevo_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bNuevo.Click
        Try
            LimpiarCampos(Me)
            xFamilia.Text = SiguienteCorrelativo("Familias", "Familia").ToString
            xDescripcion.Focus()
            bGuardar.Text = "Guardar"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub xFamilia_KeyPress(Optional sender As Object = Nothing, Optional e As KeyPressEventArgs = Nothing) Handles xFamilia.KeyPress
        ValidarDigitos(e)
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xFamilia_Validating(sender As Object, e As CancelEventArgs) Handles xFamilia.Validating
        Try
            If Val(xFamilia.Text) > 0 Then
                Dim wFam = SQL("SELECT DescFamilia FROM Familias WHERE Familia = '" & xFamilia.Text & "'").Top

                If wFam IsNot Nothing Then
                    xDescripcion.Text = wFam.GetText("DescFamilia")
                    bGuardar.Text = "Modificar"
                Else
                    MsgError("Familia no encontrada")
                    bNuevo_Click()
                    xDescripcion.Focus()
                    bGuardar.Text = "Guardar"
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim wMensaje As String() = {MSG_MODIFICADO, A_MODIFICADO}

        If xFamilia.Text = "" Then
            MsgError("Ingrese Familia")
            xFamilia.Focus()
            Exit Sub
        End If
        If xDescripcion.Text = "" Then
            MsgError("Ingrese Descripción")
            xDescripcion.Focus()
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wFam As New T_Familias
        Dim qFam = DC.T_Familias.FirstOrDefault(Function(x) x.Familia = CInt(xFamilia.Text))

        If qFam IsNot Nothing Then wFam = qFam
        wFam.Familia = xFamilia.Text.ToDecimal()
        wFam.DescFamilia = xDescripcion.Text.Trim

        If qFam Is Nothing Then
            DC.T_Familias.InsertOnSubmit(wFam)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
        End If
        DC.SubmitChanges()
        Mensaje(wMensaje(0))
        Auditoria(Me.Text, wMensaje(1), xFamilia.Text.Trim, xDescripcion.Text.Trim)
        bNuevo_Click()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        bNuevo_Click()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Try
            If IsNumeric(xFamilia.Text) Then
                Dim wValidar = SQL("SELECT * FROM FAMILIAS WHERE FAMILIA = " & Val(xFamilia.Text)).Top
                If wValidar Is Nothing Then
                    MsgError("La familia que desea eliminar no existe")
                    Exit Sub
                End If
                Dim wArt = SQL("SELECT TOP 1 Familia FROM Articulos WHERE Familia =" & Val(xFamilia.Text) & "").Top
                If wArt Is Nothing Then
                    SQL("DELETE FROM Familias WHERE Familia = " & Val(xFamilia.Text) & "")
                    Mensaje("Familia eliminada correctamente")
                    Auditoria(Me.Text, A_ELIMINADO, xFamilia.Text.Trim, xDescripcion.Text.Trim)
                    bNuevo_Click()
                Else
                    MsgError("No se puede eliminar esta familia, esta siendo usada en Artículo")
                End If
            End If
        Catch ex As Exception
            MsgError(ex.Message)
        End Try
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(bGuardar)
    End Sub
End Class