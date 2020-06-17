Imports System.ComponentModel

Public Class ManPrevisionSalud
    Private Sub bNuevo_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bNuevo.Click
        LimpiarCampos(Me)
        bGuardar.Text = "Guardar"
        xCodigo.Text = SiguienteCorrelativo("Salud", "Salud").ToString()
        xDescripcion.Focus()
    End Sub

    Private Sub xCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCodigo.KeyPress
        ValidarDigitos(e)
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xCodigo_Validating(sender As Object, e As CancelEventArgs) Handles xCodigo.Validating
        If xCodigo.Text.Trim = "" Then Exit Sub
        Dim wDC = New RebuscoDataContext(P_CONEXION)
        Dim wSalud = wDC.T_Salud.FirstOrDefault(Function(x) x.Salud = xCodigo.Text.ToDecimal())
        If wSalud Is Nothing Then
            MsgError("Prevesión de salud no existe")
            xCodigo.Clear()
            xDescripcion.Clear()
            xPorcentaje.Clear()
            xCodigo.Focus()
            bGuardar.Text = "Guardar"
            Exit Sub
        End If
        xDescripcion.Text = wSalud.NombreSalud
        xPorcentaje.Text = wSalud.PorcentajeSalud.ToString()
        bGuardar.Text = "Modificar"
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(xPorcentaje)
    End Sub

    Private Sub xPorcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xPorcentaje.KeyPress
        ValidarDigitos(e)
        e.NextControl(bGuardar)
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        bNuevo_Click()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Try
            If xCodigo.Text.Trim <> "" Then
                Dim wDC = New RebuscoDataContext(P_CONEXION)
                Dim wSaludBorrar = wDC.T_Salud.FirstOrDefault(Function(x) x.Salud = xCodigo.Text.ToDecimal())

                If wSaludBorrar Is Nothing Then
                    MsgError("La previsión de salud indicada no existe")
                    Exit Sub
                End If

                If ValidarEliminar("Salud", xCodigo.Text.Trim, "Salud") Then
                    MsgError("No se puede eliminar la previsión de salud")
                Else
                    SQL("DELETE FROM SALUD WHERE SALUD = '" & xCodigo.Text.Trim & "'")
                    Mensaje("Tipo de Movimiento eliminado correctamente")
                    Auditoria(Me.Text, A_ELIMINADO, xCodigo.Text, xDescripcion.Text)
                    bNuevo_Click()
                End If
            End If
        Catch ex As Exception
            MsgError(ex.Message)
        End Try
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim wDC = New RebuscoDataContext(P_CONEXION)
        Dim wMensaje As String() = {"Registro Modificado Correctamente", A_MODIFICADO}

        If xCodigo.Text.Trim() = "" Then
            MsgError("Debe indicar número de previsión")
            xCodigo.Focus()
            Exit Sub
        End If

        If xDescripcion.Text.Trim() = "" Then
            MsgError("Debe indicar descripción a la previsión")
            xDescripcion.Focus()
            Exit Sub
        End If

        If xPorcentaje.Text.Trim() = "" Then
            MsgError("Debe indicar porcentaje de la previsión")
            xPorcentaje.Focus()
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        Dim wSalud = New T_Salud
        Validacion.ValidateObj(wSalud)
        Dim qSalud = wDC.T_Salud.FirstOrDefault(Function(x) x.Salud = xCodigo.Text.ToDecimal())
        If qSalud IsNot Nothing Then wSalud = qSalud

        wSalud.Salud = xCodigo.Text.ToDecimal()
        wSalud.NombreSalud = xDescripcion.Text.Trim()
        wSalud.PorcentajeSalud = xPorcentaje.Text.ToDecimal(2)

        If qSalud Is Nothing Then
            wDC.T_Salud.InsertOnSubmit(wSalud)
            wMensaje = {"Registro Guardado Correctamente", A_GUARDADO}
        End If
        wDC.SubmitChanges()
        Mensaje(wMensaje(0))
        bNuevo_Click()
        Auditoria(Me.Text, wMensaje(1), xCodigo.Text, xDescripcion.Text)
        Cursor = Cursors.Default
    End Sub
End Class