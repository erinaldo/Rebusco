Imports System.ComponentModel

Public Class ManEstados
    Private Sub ManBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cTipo.LoadItemsObj("TipoEstados", "Tipo", "DescTipo")
        bLimpiar_Click()
        Auditoria(Me.Text, A_INGRESADO, "", "")
    End Sub
    Private Sub xTipoMov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xEstado.KeyPress
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xEstado_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xEstado.Validating
        Try
            If xEstado.Text.Trim <> "" Then
                Dim wEst = SQL("SELECT * FROM Estados WHERE Estado = '" & xEstado.Text.Trim & "'").Top
                If wEst IsNot Nothing Then
                    xDescripcion.Text = wEst.GetText("DescEstado")
                    cTipo.SelectedValue = wEst.GetText("Tipo")
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

        If xEstado.Text = "" Then
            MsgError("Ingrese Estado")
            xEstado.Focus()
            Exit Sub
        End If
        If xDescripcion.Text = "" Then
            MsgError("Ingrese Descripción")
            xDescripcion.Focus()
            Exit Sub
        End If
        If cTipo.Text = "" Then
            MsgError("Ingrese Tipo")
            cTipo.Focus()
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wEst As New T_Estados
        Dim qEst = DC.T_Estados.FirstOrDefault(Function(x) x.Estado = xEstado.Text.Trim)

        If qEst IsNot Nothing Then wEst = qEst

        wEst.Estado = xEstado.Text.Trim
        wEst.DescEstado = xDescripcion.Text.Trim
        wEst.Tipo = CChar(cTipo.SelectedValue.ToString)

        If qEst Is Nothing Then
            DC.T_Estados.InsertOnSubmit(wEst)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
        End If

        DC.SubmitChanges()
        Mensaje(wMensaje(0))
        Auditoria(Me.Text, wMensaje(1), xEstado.Text.Trim, xDescripcion.Text.Trim)
        bLimpiar_Click()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        bGuardar.Text = "Guardar"
        xEstado.Focus()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Try
            If xEstado.Text.Trim <> "" Then
                If ValidarEliminar("Estado", xEstado.Text.Trim, "Estados") Then
                    MsgError("No se puede eliminar el Tipo de Movimiento")
                Else
                    SQL("DELETE FROM Estados WHERE Estado = '" & xEstado.Text.Trim & "'")
                    Mensaje("Estado eliminada correctamente")
                    Auditoria(Me.Text, A_ELIMINADO, xEstado.Text.Trim, xDescripcion.Text.Trim)
                    bLimpiar_Click()
                    xEstado.Focus()
                End If
            End If
        Catch ex As Exception
            MsgError(ex.Message)
        End Try
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(cTipo)
    End Sub

    Private Sub ManTipoMov_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        xEstado.Focus()
    End Sub
End Class