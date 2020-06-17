Imports System.ComponentModel

Public Class ManTipoDoc
    Private Sub ManTipoDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bLimpiar_Click()
        bGuardar.Text = "Guardar"
        xTipoDoc.Focus()
        Auditoria(Me.Text, A_INGRESADO, "", "")
        cDocAnula.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc")
    End Sub
    Private Sub xFamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTipoDoc.KeyPress
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xTipoDoc_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xTipoDoc.Validating
        Try
            If xTipoDoc.Text.Trim <> "" Then
                Dim wTipoDoc = SQL("SELECT * FROM TipoDoc WHERE TipoDoc = '" & xTipoDoc.Text.Trim & "'").Top

                If wTipoDoc IsNot Nothing Then
                    xDescripcion.Text = wTipoDoc.GetText("DescTipoDoc")
                    xNombre.Text = wTipoDoc.GetText("Nombre_Documento")
                    xModo.Text = wTipoDoc.GetText("Modo")
                    xCODSII.Text = wTipoDoc.GetText("Cod_SII")
                    xFiltro.Text = wTipoDoc.GetText("Filtro")
                    cDocAnula.SelectedValue = wTipoDoc.GetText("Anula")
                    oContable.Checked = wTipoDoc.GetBool("Contable")
                    oElectronica.Checked = wTipoDoc.GetBool("Electronica")
                    oFacturable.Checked = wTipoDoc.GetBool("Facturable")
                    oEmision.Checked = wTipoDoc.GetBool("Emision")
                    oPagos.Checked = wTipoDoc.GetBool("Pagos")
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

        If xTipoDoc.Text = "" Then
            MsgError("Ingrese Familia")
            xTipoDoc.Focus()
            Exit Sub
        End If
        If xDescripcion.Text = "" Then
            MsgError("Ingrese Descripción")
            xDescripcion.Focus()
            Exit Sub
        End If
        If xModo.Text = "" Then
            MsgError("Ingrese Modulo")
            xModo.Focus()
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wTipoDoc As New T_TipoDoc
        Dim qTipoDoc = DC.T_TipoDoc.FirstOrDefault(Function(x) x.TipoDoc = xTipoDoc.Text.Trim)

        If qTipoDoc IsNot Nothing Then wTipoDoc = qTipoDoc


        wTipoDoc.TipoDoc = xTipoDoc.Text.Trim
        wTipoDoc.DescTipoDoc = xDescripcion.Text.Trim
        wTipoDoc.Modo = xModo.Text.Trim
        wTipoDoc.Nombre_Documento = xNombre.Text
        wTipoDoc.Filtro = xFiltro.Text
        wTipoDoc.Anula = cDocAnula.SelectedValue.ToString
        wTipoDoc.Electronica = oElectronica.Checked
        wTipoDoc.Contable = oContable.Checked
        wTipoDoc.Facturable = oFacturable.Checked
        wTipoDoc.Emision = oEmision.Checked
        wTipoDoc.Pagos = oPagos.Checked

        If qTipoDoc Is Nothing Then
            DC.T_TipoDoc.InsertOnSubmit(wTipoDoc)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
        End If

        DC.SubmitChanges()
        Mensaje(wMensaje(0))
        Auditoria(Me.Text, wMensaje(1), xTipoDoc.Text.Trim, xDescripcion.Text.Trim)
        bLimpiar_Click()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        xTipoDoc.Focus()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Try
            If xTipoDoc.Text.Trim <> "" Then
                If ValidarEliminar("TipoDoc", xTipoDoc.Text.Trim, "TipoDoc") Then
                    MsgError("No se puede eliminar el Tipo de Documento")
                Else
                    SQL("DELETE FROM TIPODOC WHERE TIPODOC = '" & xTipoDoc.Text.Trim & "'")
                    Mensaje("Tipo de documento eliminado correctamente")
                    Auditoria(Me.Text, A_ELIMINADO, xTipoDoc.Text.Trim, xDescripcion.Text.Trim)
                    bLimpiar_Click()
                    xTipoDoc.Focus()
                End If
            End If
        Catch ex As Exception
            MsgError(ex.Message)
        End Try
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(xModo)
    End Sub

    Private Sub xModulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xModo.KeyPress
        e.NextControl(bGuardar)
    End Sub
End Class