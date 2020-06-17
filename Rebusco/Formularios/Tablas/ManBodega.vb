Imports System.ComponentModel

Public Class ManBodega
    Implements iFormulario
    Private Sub ManBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bNuevo_Click()
        LoadItemsObj(cLocal, "Locales", "Local", "NombreLocal")
        bGuardar.Text = "Guardar"
        xBodega.Focus()
        Auditoria(Me.Text, A_GUARDADO, "", "")
    End Sub
    Private Sub xBodega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBodega.KeyPress
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xBodega_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xBodega.Validating
        Try
            If xBodega.Text.Trim <> "" Then
                Dim wBod = SQL("SELECT * FROM Bodegas WHERE Bodega = '" & xBodega.Text.Trim & "'").Top
                If wBod IsNot Nothing Then
                    xDescripcion.Text = wBod.GetText("NombreBodega")
                    xLocal.Text = wBod.GetText("Local")
                    oPrincipal.Checked = wBod.GetBool("Principal")
                    oDespacho.Checked = wBod.GetBool("Despacho")
                    oMovil.Checked = wBod.GetBool("Movil")
                    bGuardar.Text = "Modificar"
                    xLocal_Validating()
                Else
                    xDescripcion.Focus()
                    bGuardar.Text = "Guardar"
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim wMensaje As String() = {"Registro Modificado Correctamente", A_MODIFICADO}

        If xBodega.Text = "" Then
            MsgError("Ingrese Bodega")
            xBodega.Focus()
            Exit Sub
        End If
        If xDescripcion.Text = "" Then
            MsgError("Ingrese Descripción")
            xDescripcion.Focus()
            Exit Sub
        End If
        If xLocal.Text = "" Then
            MsgError("Ingrese Local")
            xLocal.Focus()
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wBog As New T_Bodegas
        Dim qBog = DC.T_Bodegas.FirstOrDefault(Function(x) x.Bodega = CInt(xBodega.Text))

        If qBog IsNot Nothing Then wBog = qBog

        wBog.Bodega = xBodega.Text.ToDecimal()
        wBog.NombreBodega = xDescripcion.Text.Trim
        wBog.Local = CInt(xLocal.Text)
        wBog.Movil = oMovil.Checked
        wBog.Despacho = oDespacho.Checked
        wBog.Principal = oPrincipal.Checked

        If qBog Is Nothing Then
            wBog.Bodega = CInt(xBodega.Text)
            DC.T_Bodegas.InsertOnSubmit(wBog)
            wMensaje = {"Registro Guardado Correctamente", A_GUARDADO}
        End If
        DC.SubmitChanges()
        Mensaje(wMensaje(0))
        bNuevo_Click()
        Auditoria(Me.Text, wMensaje(1), xBodega.Text, xDescripcion.Text)
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
            If xBodega.Text.Trim <> "" Then
                Dim DC = New RebuscoDataContext(P_CONEXION)
                Dim wBodegaBorrar = DC.T_Bodegas.FirstOrDefault(Function(x) x.Bodega = xBodega.Text.ToDecimal())

                If wBodegaBorrar Is Nothing Then
                    MsgError("La bodega indicada no existe")
                    Exit Sub
                End If

                If ValidarEliminar("Bodega", xBodega.Text.Trim, "Bodegas") Then
                    MsgError("No se puede eliminar la bodega")
                Else
                    SQL("DELETE FROM BODEGAS WHERE BODEGA = '" & xBodega.Text.Trim & "'")
                    Mensaje("Tipo de Movimiento eliminado correctamente")
                    Auditoria(Me.Text, A_ELIMINADO, xBodega.Text, xDescripcion.Text)
                    bNuevo_Click()
                    xBodega.Focus()
                End If
            End If
        Catch ex As Exception
            MsgError(ex.Message)
        End Try
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(xLocal)
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs)
        Dim wQuery = "SELECT Bodega, NombreBodega as 'Nombre de Bodega' FROM Bodegas"
        Buscador.Show()
        Buscador.Configurar(wQuery, "NombreBodega", Me, "Bodegas", xBodega)
    End Sub
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
        xLocal_Validating()
    End Sub
    Private Sub ManTipoMov_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        xBodega.Focus()
    End Sub

    Private Sub xLocal_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xLocal.Validating
        If xLocal.Text.Trim <> "" Then
            cLocal.SelectedValue = xLocal.Text.Trim
            If cLocal.Text = "" Then
                xLocal.Clear()
                xLocal.Focus()
            End If
        End If
    End Sub

    Private Sub cLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cLocal.SelectedIndexChanged
        If cLocal.Text <> "" Then
            xLocal.Text = cLocal.SelectedValue.ToString
        Else
            xLocal.Clear()
        End If
    End Sub

    Private Sub xLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xLocal.KeyPress
        e.NextControl(cLocal)
    End Sub

    Private Sub cLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cLocal.KeyPress
        e.NextControl(bGuardar)
    End Sub

    Private Sub bNuevo_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bNuevo.Click
        LimpiarCampos(Me)
        xBodega.Text = SiguienteCorrelativo("Bodegas", "Bodega").ToString
        bGuardar.Text = "Guardar"
        xDescripcion.Focus()
    End Sub
End Class