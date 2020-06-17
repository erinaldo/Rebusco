Imports System.ComponentModel

Public Class ManEventosRem
    Private Sub ManEventosRem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bLimpiar_Click()
        Auditoria(Me.Text, A_INGRESADO, "", "")
        CargarAcciones()
    End Sub
    Sub CargarAcciones()
        Dim wListaTipoMov = New List(Of ItemCombo) From
            {
            New ItemCombo With {.ID = "+", .Desc = "SUMAR"},
            New ItemCombo With {.ID = "-", .Desc = "RESTAR"},
            New ItemCombo With {.ID = "=", .Desc = "IGUALAR"}
            }
        cAccion.DisplayMember = "Desc"
        cAccion.ValueMember = "ID"
        cAccion.DataSource = wListaTipoMov
    End Sub
    Private Sub xTipoMov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xEvento.KeyPress
        ValidarDigitos(e)
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xEvento_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xEvento.Validating
        Try
            If xEvento.Text.Trim <> "" Then
                Dim wEven = SQL("SELECT * FROM EventosRem WHERE EventoRem = " & xEvento.Text.Trim & "").Top
                If wEven IsNot Nothing Then
                    xDescripcion.Text = wEven.GetText("DesceventoRem")
                    cAccion.SelectedValue = wEven.GetText("CalculoRem")
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

        If xEvento.Text = "" Then
            MsgError("Ingrese Evento de Remuneración")
            xEvento.Focus()
            Exit Sub
        End If
        If xDescripcion.Text = "" Then
            MsgError("Ingrese Descripción")
            xDescripcion.Focus()
            Exit Sub
        End If
        If cAccion.Text = "" Then
            MsgError("Ingrese Acción")
            cAccion.Focus()
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wEve As New T_EventosRem
        Dim qEven = DC.T_EventosRem.FirstOrDefault(Function(x) x.EventoRem = CInt(xEvento.Text))

        If qEven IsNot Nothing Then wEve = qEven

        wEve.EventoRem = CInt(xEvento.Text.Trim)
        wEve.DescEventoRem = xDescripcion.Text.Trim
        wEve.CalculoRem = cAccion.SelectedValue.ToString()

        If qEven Is Nothing Then
            DC.T_EventosRem.InsertOnSubmit(wEve)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
        End If

        DC.SubmitChanges()
        Mensaje(wMensaje(0))
        Auditoria(Me.Text, wMensaje(1), "", "")
        bLimpiar_Click()
        Cursor = Cursors.Arrow
    End Sub



    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        bNuevo_Click()
        bGuardar.Text = "Guardar"
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Try
            If xEvento.Text.Trim <> "" Then
                Dim wValidar = SQL("SELECT * FROM EVENTOSREM WHERE EVENTO =" & Val(xEvento.Text)).Top
                If wValidar Is Nothing Then
                    MsgError("El evento que indica no se encuentra creado.")
                    Exit Sub
                End If
                If ValidarEliminar("EventoRem", xEvento.Text.Trim, "EventosRem") Then
                    MsgError("No se puede eliminar el Evento de Remuneración")
                Else
                    SQL("DELETE FROM EventosRem WHERE EventoRem = " & xEvento.Text.Trim & "")
                    Mensaje("Evento eliminada correctamente")
                    Auditoria(Me.Text, A_ELIMINADO, xEvento.Text.Trim, xDescripcion.Text.Trim)
                    bLimpiar_Click()
                    xEvento.Focus()
                End If
            End If
        Catch ex As Exception
            MsgError(ex.Message)
        End Try
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(cAccion)
    End Sub
    Private Sub ManTipoMov_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        xEvento.Focus()
    End Sub
    Private Sub cLocal_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.NextControl(bGuardar)
    End Sub
    Private Sub bNuevo_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bNuevo.Click
        xEvento.Text = SiguienteCorrelativo("EventosRem", "EventoRem").ToString()
        xDescripcion.Clear()
        cAccion.SelectedIndex = -1
    End Sub
End Class