Imports System.ComponentModel

Public Class CambioFPago

    Private Sub CambioFPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal", "Order by Local")
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", "Order by DescTipoDoc")
        cFPagoNueva.LoadItemsObj("FPagos", "FPago", "DescFPago", "Order by DescFPago")
        If cLocal.Items.Count = 2 Then
            cLocal.SelectedIndex = 1
        End If
        Auditoria(Text, A_INGRESADO, "", "")
    End Sub

    Private Sub cTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cTipoDoc.SelectedIndexChanged
        If cTipoDoc.Text.Trim = "" Then Exit Sub
        Dim wDoc = SQL("Select * from TipoDoc where DescTipoDoc = '" & cTipoDoc.Text.Trim & "'").Top
        If wDoc Is Nothing Then
            MsgError("Documento No Encontrado")
            cTipoDoc.Text = ""
            Exit Sub
        End If
        cTipoDoc.SelectedValue = wDoc.GetText("TipoDoc")

    End Sub

    Private Sub cLocal_selectedindexchanged(sender As Object, e As EventArgs) Handles cLocal.SelectedIndexChanged
        Dim wLoc = SQL("select Local from Locales where Nombrelocal = '" & cLocal.Text & "'").Top
        If wloc IsNot Nothing Then
            cLocal.SelectedValue = wLoc.GetText("Local")
        End If
    End Sub

    Private Sub bCambiar_click(sender As Object, e As EventArgs) Handles bCambiar.Click
        If cLocal.Text.Trim = "" Then
            MsgError("Falta Local")
            Exit Sub
        End If
        If xFPago.Text.Trim = "" Then
            MsgError("Falta Forma de Pago nueva")
            Exit Sub
        End If
        If cTipoDoc.Text.Trim = "" Then
            MsgError("Falta Tipo de Documento")
            Exit Sub
        End If
        If xNumero.Text.Trim = "" Then
            MsgError("Falta Número Documento")
            Exit Sub
        End If


        If Not Pregunta("Desea cambiar Forma de Pago") Then
            Exit Sub
        End If

        Dim wDocG = SQL("Select * from DocumentosG where Local = " & Val(cLocal.SelectedValue.ToString) &
                        " and Tipodoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & Val(xNumero.Text))
        If wDocG.Rows.Count = 0 Then
            MsgError("Documento No Encontrado")
            Exit Sub
        End If

        Dim wFP = SQL("Select * from FPagos where FPago = '" & (cFPagoNueva.SelectedValue.ToString) & "'")
        If wFP.Rows.Count = 0 Then
            MsgError("Forma de Pago a cambiar, No Encontrada")
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wDGs As New T_DocumentosG
        Dim DCg = DC.T_DocumentosG.FirstOrDefault(Function(x) x.Local = Val(cLocal.SelectedValue.ToString) And
                                                                x.TipoDoc = cTipoDoc.SelectedValue.ToString And
                                                                x.Numero = Val(xNumero.Text))
        If DCg IsNot Nothing Then
            Dim witemnew = DCg.Clonar
            DCg.FPago = cFPagoNueva.SelectedValue.ToString
            DC.SubmitChanges()

            Auditoria(Me.Text, "Cambio Forma de Pago", cTipoDoc.SelectedValue.ToString, xNumero.Text)

            Cursor = Cursors.Arrow
            Mensaje("Cambio Realizado")
        Else
            MsgError("No se Encontró Documento")
        End If
    End Sub

    Private Sub Salir_click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bBuscarCli_click(sender As Object, e As EventArgs) Handles bBuscarCli.Click
        Buscar_Datos_Doc()
    End Sub

    Private Sub xNumero_keypress(sender As Object, e As KeyPressEventArgs) Handles xNumero.KeyPress
        If e.KeyChar = vbCr Then
            Buscar_Datos_Doc()
        End If
    End Sub

    Private Sub Buscar_Datos_Doc()

        If cLocal.Text = "" Then
            MsgError("falta local")
            Exit Sub
        End If
        If cTipoDoc.Text = "" Then
            MsgError("Falta Tipo de Documento")
            Exit Sub
        End If
        If Val(xNumero.Text) = 0 Then
            xNumero.Clear()
            MsgError("Falta Número de Documento")
            Exit Sub
        End If

        Dim wDocG = SQL("Select * from DocumentosG where Local = " & Val(cLocal.SelectedValue.ToString) &
                        " and Tipodoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & Val(xNumero.Text)).Top
        If wDocG Is Nothing Then
            MsgError("Documento No Encontrado")
            xNumero.Focus()
            Exit Sub
        Else
            xFPago.Text = ""

            Dim wFPa = SQL("Select * from FPagos where FPago = '" & wDocG.GetText("FPago") & "'").Top
            If wFPa Is Nothing Then
                xFPago.Text = ""
            Else
                xFPago.Text = Trim(wFPa.GetText("DescFPago"))
            End If
        End If
    End Sub


End Class
