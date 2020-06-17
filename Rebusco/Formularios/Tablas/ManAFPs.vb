Imports System.ComponentModel

Public Class ManAFPs
    Private Sub ManUnidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bNuevo_Click()
        Auditoria(Me.Text, A_INGRESADO, "", "")
    End Sub
    Private Sub xAFPs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xAFPs.KeyPress
        ValidarDigitos(e)
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xAFPs_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xAFPs.Validating
        Try
            If xAFPs.Text.Trim <> "" Then
                Dim wAFP = SQL("SELECT * FROM AFPs WHERE AFP = '" & Val(xAFPs.Text) & "'").Top
                If wAFP IsNot Nothing Then
                    xDescripcion.Text = wAFP.GetText("NombreAFP")
                    xPorcentaje.Text = wAFP.GetText("PorcentajeAFP")
                    dFecha.Value = CDate("01/" & wAFP.GetText("Mes") & "/" & wAFP.GetText("Año"))
                    bGuardar.Text = "Modificar"
                Else
                    If xAFPs.Text = SiguienteCorrelativo("AFPs").ToString Then
                        xDescripcion.Focus()
                        Exit Sub
                    End If
                    MsgError("Registro no encontrado")
                    xAFPs.Clear()
                    xAFPs.Focus()
                    bGuardar.Text = "Guardar"
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

        Dim wMensaje As String() = {"Registro Modificado Correctamente", A_MODIFICADO}
        If xAFPs.Text = "" Then
            MsgError("Ingrese Numero de AFP")
            xAFPs.Focus()
            Exit Sub
        End If
        If xDescripcion.Text = "" Then
            MsgError("Ingrese Nombre de AFP")
            xDescripcion.Focus()
            Exit Sub
        End If
        If xPorcentaje.Text = "" Then
            MsgError("Ingrese Porcentaje de AFP")
            xPorcentaje.Focus()
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wAFP As New T_AFPs
        Dim qAFP = DC.T_AFPs.FirstOrDefault(Function(x) x.AFP = CInt(xAFPs.Text))

        If qAFP IsNot Nothing Then wAFP = qAFP

        wAFP.NombreAFP = xDescripcion.Text
        wAFP.PorcentajeAFP = xPorcentaje.Text.ToDecimal(2)
        wAFP.Mes = dFecha.Value.Month
        wAFP.Año = dFecha.Value.Year

        If qAFP Is Nothing Then
            DC.T_AFPs.InsertOnSubmit(wAFP)
            wMensaje = {"Registro Guardado Correctamente", A_GUARDADO}
        End If

        DC.SubmitChanges()
        Mensaje(wMensaje(0))
        bNuevo_Click()
        Auditoria(Me.Text, wMensaje(1), xAFPs.Text, xDescripcion.Text)
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
            If xAFPs.Text.Trim <> "" Then
                If ValidarEliminar("AFP", xAFPs.Text.Trim, "AFPs") Then
                    MsgError("No se puede eliminar el AFP")
                Else
                    SQL("DELETE FROM AFPs WHERE AFP = '" & Val(xAFPs.Text) & "'")
                    Mensaje("AFP eliminado correctamente")
                    Auditoria(Me.Text, A_ELIMINADO, xAFPs.Text, xDescripcion.Text)
                    bNuevo_Click()
                End If
            End If
        Catch ex As Exception
            MsgError(ex.Message)
        End Try
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(xPorcentaje)
    End Sub

    Private Sub ManAFPs_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        xAFPs.Focus()
    End Sub
    Private Sub xPorcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xPorcentaje.KeyPress
        'ValidarDigitos(e)
        If Not Char.IsPunctuation(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
            If Not e.KeyChar = Chr(8) Then
                e.Handled = True
            End If
        End If
        e.NextControl(bGuardar)
    End Sub

    Private Sub bNuevo_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bNuevo.Click
        LimpiarCampos(Me)
        xAFPs.Text = SiguienteCorrelativo("AFPs").ToString
        xDescripcion.Focus()
        bGuardar.Text = "Guardar"
    End Sub
End Class