Imports System.ComponentModel

Public Class ManPOS
    Private Sub ManPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bNuevo_Click()
        cTipoPOS.LoadItemsObj("TipoPOS", "TipoPOS", "DescTipoPOS")
        Auditoria(Me.Text, A_INGRESADO, "", "")
    End Sub
    Private Sub xPOS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xPOS.KeyPress
        ValidarDigitos(e)
        e.NextControl(xNombre)
    End Sub

    Private Sub xPOS_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xPOS.Validating
        Try
            If xPOS.Text.Trim = "" Then Exit Sub
            Dim wPOS = SQL("SELECT * FROM POS WHERE POS = '" & xPOS.Text.Trim & "'").Top

            If wPOS IsNot Nothing Then
                xNombre.Text = wPOS.GetText("NombrePOS")
                cTipoPOS.SelectedValue = wPOS.GetText("TipoPOS")
                xNSerie.Text = wPOS.GetText("NSerie")
                xCaja.Text = wPOS.GetText("Caja")
                dFechaVenc.Value = wPOS.GetDate("FechaVigencia")
                oActivo.Checked = wPOS.GetBool("Activo")
                bGuardar.Text = "Modificar"
            Else
                xNombre.Focus()
                bGuardar.Text = "Guardar"
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub xCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCaja.KeyPress
        ValidarDigitos(e)
        e.NextControl(xNSerie)
    End Sub
    Private Sub xNSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNSerie.KeyPress
        ValidarDigitos(e)
        e.NextControl(dFechaVenc)
    End Sub
    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim wMensaje As String() = {MSG_MODIFICADO, A_MODIFICADO}

        If xPOS.Text = "" Then
            MsgError("Ingrese N° POS único")
            xPOS.Focus()
            Exit Sub
        End If
        If xNombre.Text = "" Then
            MsgError("Ingrese Nombre del POS")
            xNombre.Focus()
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wPOS As New T_POS
        Dim qPOS = DC.T_POS.FirstOrDefault(Function(x) x.POS = CInt(xPOS.Text))

        If qPOS IsNot Nothing Then wPOS = qPOS

        wPOS.POS = xPOS.Text.ToDecimal
        wPOS.NombrePOS = xNombre.Text.Trim
        wPOS.TipoPOS = CChar(cTipoPOS.SelectedValue.ToString)
        wPOS.NSerie = xNSerie.Text.Trim
        wPOS.FechaVigencia = CDate(Format(dFechaVenc.Value, "dd/MM/yyyy"))
        wPOS.Activo = oActivo.Checked

        If qPOS Is Nothing Then
            DC.T_POS.InsertOnSubmit(wPOS)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
        End If

        DC.SubmitChanges()
        Mensaje(wMensaje(0))
        Auditoria(Me.Text, wMensaje(1), xPOS.Text.Trim, xNombre.Text.Trim)
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
            If xPOS.Text.Trim <> "" Then
                SQL("DELETE FROM POS WHERE POS = '" & xPOS.Text.Trim & "'")
                Mensaje("POS eliminado correctamente")
                Auditoria(Me.Text, A_ELIMINADO, xPOS.Text.Trim, xNombre.Text.Trim)
                bNuevo_Click()
                xPOS.Focus()
            End If
        Catch ex As Exception
            MsgError(ex.Message)
        End Try
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNombre.KeyPress
        If e.KeyChar = vbCr Then
            e.NextControl(cTipoPOS)
        End If
    End Sub
    Private Sub ManPOS_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        xPOS.Focus()
    End Sub

    Private Sub bNuevo_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bNuevo.Click
        LimpiarCampos(Me)
        xPOS.Text = SiguienteCorrelativo("POS", "POS").ToString
        dFechaVenc.Value = Date.Now
        oActivo.Checked = False
        bGuardar.Text = "Guardar"
        xPOS.Focus()
    End Sub
End Class