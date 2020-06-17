Imports System.ComponentModel

Public Class ManTipoMov
    Implements iFormulario
    Private Sub ManTipoMov_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bLimpiar_Click()
        CargarAcciones()
        Auditoria(Me.Text, A_INGRESADO, "", "")
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
    Private Sub xTipoMov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTipoMov.KeyPress
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xTipoMov_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xTipoMov.Validating
        Try
            If xTipoMov.Text.Trim <> "" Then
                Dim wTipoM = SQL("SELECT * FROM TipoMov WHERE TipoMov = '" & xTipoMov.Text.Trim & "'").Top
                If wTipoM IsNot Nothing Then
                    xDescripcion.Text = wTipoM.GetText("DescTipo")
                    cAccion.SelectedValue = wTipoM.GetText("Ajuste")
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

        If xTipoMov.Text = "" Then
            MsgError("Ingrese Tipo Movimiento")
            xTipoMov.Focus()
            Exit Sub
        End If
        If xDescripcion.Text = "" Then
            MsgError("Ingrese Descripción")
            xDescripcion.Focus()
        End If
        If cAccion.SelectedIndex = -1 Then
            MsgError("Ingrese Acción")
            cAccion.Focus()
        End If
        Cursor = Cursors.WaitCursor
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wTipoM As New T_TipoMov
        Dim qTipoM = DC.T_TipoMov.FirstOrDefault(Function(x) x.TipoMov = xTipoMov.Text.Trim)

        If qTipoM IsNot Nothing Then wTipoM = qTipoM

        wTipoM.TipoMov = xTipoMov.Text.Trim
        wTipoM.DescTipo = xDescripcion.Text.Trim
        wTipoM.Ajuste = cAccion.SelectedValue.ToString()
        wTipoM.Visible = oActivo.Checked

        If qTipoM Is Nothing Then
            DC.T_TipoMov.InsertOnSubmit(wTipoM)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
        End If

        DC.SubmitChanges()
        Mensaje(wMensaje(0))
        Auditoria(Me.Text, wMensaje(1), xTipoMov.Text.Trim, xDescripcion.Text.Trim)
        bLimpiar_Click()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Limpiar()
        xTipoMov.Clear()
        xDescripcion.Clear()
        cAccion.SelectedIndex = -1

    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        bGuardar.Text = "Guardar"
        xTipoMov.Focus()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Try
            If xTipoMov.Text.Trim <> "" Then
                If ValidarEliminar("TipoMov", xTipoMov.Text.Trim, "TipoMov") Then
                    MsgError("No se puede eliminar el Tipo de Movimiento")
                Else
                    SQL("DELETE FROM TIPOMOV WHERE TIPOMOV = '" & xTipoMov.Text.Trim & "'")
                    Mensaje("Tipo de Movimiento eliminada correctamente")
                    Auditoria(Me.Text, A_ELIMINADO, xTipoMov.Text.Trim, xDescripcion.Text.Trim)
                    Limpiar()
                    xTipoMov.Focus()
                End If
                End If
        Catch ex As Exception
            MsgError(ex.Message)
        End Try
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(cAccion)
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Dim wQuery = "SELECT TipoMov as Movimiento, DescTipo as Descripción FROM TipoMov"
        Buscador.Show()
        Buscador.Configurar(wQuery, "DescTipo", Me, "Tipo de Movimiento", xTipoMov)
    End Sub
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub
    Private Sub ManTipoMov_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        xTipoMov.Focus()
    End Sub
End Class