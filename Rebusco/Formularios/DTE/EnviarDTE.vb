Public Class EnviarDTE

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub EnviarDTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal", " WHERE FElectronica = 1 Order by Local")
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", " WHERE Cod_SII > 0 Order by DescTipoDoc")
        Auditoria(Text, A_INGRESADO, "", "")
        If cLocal.Items.Count = 2 Then
            cLocal.SelectedIndex = 1
        End If
    End Sub

    Private Sub Enviar_Click(sender As Object, e As EventArgs) Handles bEnviar.Click
        Dim wLocal As Decimal, wTipoDoc As String, wPrimeraLinea As String

        If cLocal.Text.Trim = "" Then
            MsgError("Falta Local")
            Exit Sub
        End If
        If cTipoDoc.Text.Trim = "" Then
            MsgError("Falta Tipo Documento")
            Exit Sub
        End If
        If Val(xNumero.Text.Trim) = 0 Then
            MsgError("Falta Número de Documento")
            Exit Sub
        End If

        Dim wLoc = SQL("Select * from Locales WHERE NombreLocal = '" & cLocal.Text.Trim & "'").Top
        If wLoc IsNot Nothing Then
            wLocal = wLoc.GetInt("Local")
        Else
            MsgError("Local Incorrecto")
            Exit Sub
        End If

        Dim wDoc = SQL("Select * from TipoDoc WHERE DescTipoDoc = '" & cTipoDoc.Text.Trim & "'").Top
        If wDoc IsNot Nothing Then
            wTipoDoc = wDoc.GetText("TipoDoc")
        Else
            MsgError("Tipo Documento Incorrecto")
            Exit Sub
        End If

        Dim wDocG = SQL("Select * from DocumentosG WHERE Local = " & Val(wLocal) & " and TipoDoc = '" & wTipoDoc & "' and Numero = " & Val(xNumero.Text)).Top
        If wDocG Is Nothing Then
            MsgError("Documento no encontrado")
            Exit Sub
        End If
        Dim wDocD = SQL("Select * from DocumentosD WHERE Local = " & Val(wLocal) & " and TipoDoc = '" & wTipoDoc & "' and Numero = " & Val(xNumero.Text)).Top
        If wDocG Is Nothing Then
            MsgError("Detalles del Documento no encontrados")
            Exit Sub
        End If

        wPrimeraLinea = Primera_Linea(wLocal, wTipoDoc, xNumero.Text.ToDouble)

        Dim wCli = SQL("Select * from Clientes WHERE Cliente = " & Val(wDocG.GetText("Cliente"))).Top
        If wCli Is Nothing Then
            MsgError("Cliente del documento no encontrado")
            Exit Sub
        End If

        'Parametrizar FE con datos del Local
        If Not DTE.Parametros_DTE(wLocal) Then
            MsgError("Error al sacar parámetros del Local")
            Exit Sub
        End If
        xStatus.Text = "DTE Parametrizado"

        Cursor = Cursors.WaitCursor
        bEnviar.Enabled = False

        If DTE.Es_Electronico(wTipoDoc) Then
            'Generar TED
            If Not DTE.Generar_TED(CInt(wLocal), wTipoDoc, Val(xNumero.Text), CDate(wDocG.GetText("Fecha")), DTE.Rut_DTE(wDocG.GetText("Rut")), wCli.GetText("Nombre"), Val(wDocG.GetText("Total")), wPrimeraLinea).Estado Then
                Cursor = Cursors.Arrow
                bEnviar.Enabled = True
                MsgError("Error al Generar TED")
                Exit Sub
            End If
            xStatus.Text = xStatus.Text & vbCrLf & "TED Generado"


            If DTE.Emitir_DTE(wLocal, wTipoDoc, Val(xNumero.Text)) Then
                Cursor = Cursors.Arrow
                bEnviar.Enabled = True
                xStatus.Text = xStatus.Text & vbCrLf & DTE.MensajeDTE
                xStatus.Text = xStatus.Text & vbCrLf & "Documento Enviado"
                Mensaje("Documento Enviado Exitosamente" & vbCrLf & "Debe esperar unos minutos para tener la respuesta del estado de este documento.")
                Auditoria(Text, "Documento Enviado", xNumero.Text.Trim, cTipoDoc.Text)
            Else
                Cursor = Cursors.Arrow
                bEnviar.Enabled = True
                xStatus.Text = xStatus.Text & vbCrLf & DTE.MensajeDTE
                xStatus.Text = xStatus.Text & vbCrLf & "Error al enviar Documento"
                MsgError("Error al enviar documento")
                Auditoria(Text, "Error al enviar documento", xNumero.Text.Trim, cTipoDoc.Text)
            End If
        Else
            Cursor = Cursors.Arrow
            bEnviar.Enabled = True
            MsgError("Documento no es electrónico, no se envía al DTE")
            Auditoria(Text, "Documento no es electrónico", xNumero.Text.Trim, cTipoDoc.Text)
        End If
        Cursor = Cursors.Arrow
        bEnviar.Enabled = True
    End Sub

End Class