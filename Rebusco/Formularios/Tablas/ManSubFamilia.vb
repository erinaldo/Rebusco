Imports System.ComponentModel

Public Class ManSubFamilia
    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        bNuevo_Click()
    End Sub

    Private Sub ManSubFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bNuevo_Click()
        cFamilia.LoadItemsObj("Familias", "Familia", "DescFamilia")
        Auditoria(Me.Text, A_INGRESADO, "", "")
    End Sub

    Private Sub cFamilia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cFamilia.SelectedIndexChanged
        If cFamilia.Text <> "" Then
            xFamilia.Text = cFamilia.SelectedValue.ToString
            xDescripcion.Focus()
        Else
            xFamilia.Clear()
        End If
    End Sub
    Private Sub bNuevo_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bNuevo.Click
        LimpiarCampos(Me)
        xSubFamilia.Text = SiguienteCorrelativo("SubFamilias", "SubFamilia").ToString
        xFamilia.Focus()
        bGuardar.Text = "Guardar"
    End Sub
    Private Sub xSubFamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xSubFamilia.KeyPress
        ValidarDigitos(e)
        e.NextControl(xFamilia)
    End Sub

    Private Sub xSubFamilia_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xSubFamilia.Validating
        Try
            If xSubFamilia.Text.Trim = "" Then Exit Sub
            Dim DC = New RebuscoDataContext(P_CONEXION)
            Dim wSFam = DC.T_SubFamilias.FirstOrDefault(Function(x) x.SubFamilia = CInt(xSubFamilia.Text))

            If wSFam IsNot Nothing Then
                cFamilia.SelectedValue = wSFam.Familia.ToString
                xDescripcion.Text = wSFam.DescSubFamilia.Trim
                bGuardar.Text = "Modificar"
            Else
                MsgError("SubFamilia no encontrada")
                bNuevo_Click()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub xFamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xFamilia.KeyPress
        ValidarDigitos(e)
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xFamilia_Validating(sender As Object, e As CancelEventArgs) Handles xFamilia.Validating
        If xFamilia.Text.Trim <> "" Then
            cFamilia.SelectedValue = xFamilia.Text.Trim
            If cFamilia.Text = "" Then
                MsgError("Local no encontrado")
                xFamilia.Clear()
                xFamilia.Focus()
            End If
        End If
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim wMensaje As String() = {MSG_MODIFICADO, A_MODIFICADO}

        If xSubFamilia.Text = "" Then
            MsgError("Ingrese SubFamilia")
            xSubFamilia.Focus()
            Exit Sub
        End If
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
        Dim wSFam As New T_SubFamilias
        Dim qSFam = DC.T_SubFamilias.FirstOrDefault(Function(x) x.SubFamilia = xSubFamilia.Text.ToDecimal)

        If qSFam IsNot Nothing Then wSFam = qSFam
        wSFam.SubFamilia = xSubFamilia.Text.ToDecimal()
        wSFam.Familia = CInt(cFamilia.SelectedValue.ToString)
        wSFam.DescSubFamilia = xDescripcion.Text.Trim

        If qSFam Is Nothing Then
            DC.T_SubFamilias.InsertOnSubmit(wSFam)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
        End If

        DC.SubmitChanges()
        Mensaje(wMensaje(0))
        Auditoria(Me.Text, wMensaje(1), xSubFamilia.Text.Trim, xDescripcion.Text.Trim)
        bNuevo_Click()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If xSubFamilia.Text <> "" Then
            If Val(xSubFamilia.Text) <> 0 Then

                Dim wValidar = SQL("SELECT * FROM SUBFAMILIAS WHERE SUBFAMILIA = " & xSubFamilia.Text).Top
                If wValidar Is Nothing Then
                    MsgError("La sub familia que desea eliminar no existe")
                    Exit Sub
                End If

                Dim wFam = SQL("SELECT * FROM ARTICULOS WHERE SUBFAMILIA = " & Val(xSubFamilia.Text) & "")
                If wFam.Rows.Count = 0 Then
                    SQL("DELETE FROM SUBFAMILIAS WHERE SUBFAMILIA = " & Val(xSubFamilia.Text) & "")
                    Mensaje("SubFamilia eliminada correctamente")
                    Auditoria(Me.Text, A_ELIMINADO, xSubFamilia.Text.Trim, xDescripcion.Text.Trim)
                    bNuevo_Click()
                Else
                    MsgError("Subfamilia utilizada en Articulo, no se puede eliminar")
                End If
            End If
        End If
    End Sub

End Class