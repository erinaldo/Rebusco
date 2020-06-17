Imports System.ComponentModel

Public Class ManUnidades

    Private Sub ManUnidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bLimpiar_Click()
        Auditoria(Me.Text, A_INGRESADO, "", "")
    End Sub
    Private Sub xTipoMov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xUnidad.KeyPress
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xUnidad_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xUnidad.Validating
        Try
            If xUnidad.Text.Trim <> "" Then
                Dim wUni = SQL("SELECT * FROM Unidades WHERE Unidad = '" & xUnidad.Text.Trim & "'").Top
                If wUni IsNot Nothing Then
                    xDescripcion.Text = wUni.GetText("DescUnidad")
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
        Dim wMensaje As String() = {MSG_MODIFICADO, A_MODIFICADO}

        If xUnidad.Text = "" Then
            MsgError("Ingrese Unidad")
            xUnidad.Focus()
            Exit Sub
        End If
        If xDescripcion.Text = "" Then
            MsgError("Ingrese Descripción")
            xDescripcion.Focus()
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wUni As New T_Unidades
        Dim qUni = DC.T_Unidades.FirstOrDefault(Function(x) x.Unidad = xUnidad.Text.Trim)

        If qUni IsNot Nothing Then wUni = qUni

        wUni.Unidad = xUnidad.Text.Trim
        wUni.DescUnidad = xDescripcion.Text.Trim

        If qUni Is Nothing Then
            DC.T_Unidades.InsertOnSubmit(wUni)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
        End If
        DC.SubmitChanges()
        Mensaje(wMensaje(0))
        Auditoria(Me.Text, wMensaje(1), xUnidad.Text.Trim, xDescripcion.Text.Trim)
        bLimpiar_Click()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        bGuardar.Text = "Guardar"
        xUnidad.Focus()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Try
            If xUnidad.Text.Trim <> "" Then
                Dim DC = New MarketONEDataContext(P_CONEXION)
                Dim wUnidad = DC.T_Unidades.FirstOrDefault(Function(x) x.Unidad = xUnidad.Text.Trim())

                If wUnidad Is Nothing Then
                    MsgError("La unidad ingresada no existe")
                    Exit Sub
                End If

                If ValidarEliminar("Unidad", xUnidad.Text.Trim, "Unidades") Then
                    MsgError("No se puede eliminar la Unidad")
                Else
                    SQL("DELETE FROM Unidades WHERE Unidad = '" & xUnidad.Text.Trim & "'")
                    Mensaje("Unidad eliminada correctamente")
                    Auditoria(Me.Text, A_ELIMINADO, xUnidad.Text.Trim, xDescripcion.Text.Trim)
                    bLimpiar_Click()
                    xUnidad.Focus()
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
        xUnidad.Focus()
    End Sub

    Private Sub SearchButton1_Click(sender As Object, e As EventArgs) Handles SearchButton1.Click

    End Sub
End Class