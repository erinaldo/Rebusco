Imports System.ComponentModel
Public Class AnularDocumentoElectronico
    Private Sub AnulacionDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal", " WHERE FElectronica = 1 Order by Local")
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", " WHERE Cod_SII > 0 and Anula <>'' Order by DescTipoDoc")
        If cLocal.Items.Count = 2 Then
            cLocal.SelectedIndex = 1
        End If
        cFecha.Value = Date.Now
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

        If wDoc.GetText("Anula") = "" Then
            MsgError("Documento sin Tipo de Anulación")
            cTipoDoc.Text = ""
            xAnula.Text = ""
            xAnula.Tag = ""
            Exit Sub
        End If

        wDoc = SQL("Select * from TipoDoc where TipoDoc = '" & wDoc.GetText("Anula") & "'").Top
        If wDoc Is Nothing Then
            MsgError("Error al encontrar Tipo de Documento de Anulación")
            cTipoDoc.Text = ""
            Exit Sub
        End If

        xAnula.Tag = wDoc.GetText("TipoDoc")
        xAnula.Text = wDoc.GetText("DescTipoDoc")

        xFolio.Text = BuscarCorrelativo(ModoCorrelativo.Consultar, xAnula.Tag.ToString, cFecha.Value, CInt(G_POS.ToText)).ToString()
    End Sub


    Private Sub cLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cLocal.SelectedIndexChanged
        Dim wLoc = SQL("Select Local from Locales where NombreLocal = '" & cLocal.Text & "'").Top
        If wLoc IsNot Nothing Then
            cLocal.SelectedValue = wLoc.GetText("Local")
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        cFecha.Value = Date.Now
        LimpiarCampos(Me)
        cLocal.Focus()
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim CorrelativoNuevo As Double

        If cLocal.Text.Trim = "" Then
            MsgError("Falta Local")
            Exit Sub
        End If
        If xNombre.Text.Trim = "" Then
            MsgError("Falta Cliente")
            Exit Sub
        End If
        If cTipoDoc.Text.Trim = "" Then
            MsgError("Falta Tipo de Documento")
            Exit Sub
        End If
        If xAnula.Text.Trim = "" Then
            MsgError("Falta Documento de Anulación")
            Exit Sub
        End If
        If cFecha.Value < CDate(xFecha.Text) Then
            MsgError("No puede Anular un documento con fecha anterior a la creación del documento")
            Exit Sub
        End If

        If Not Pregunta("Desea Anular Documento") Then
            Exit Sub
        End If

        Dim wDocG = SQL("Select * from DocumentosG where Local = " & Val(cLocal.SelectedValue.ToString) &
                        " and TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & Val(xNumero.Text))
        If wDocG.Rows.Count = 0 Then
            MsgError("Documento a Anular No Encontrado")
            Exit Sub
        End If
        Dim wDocD = SQL("Select * from DocumentosD where Local = " & Val(cLocal.SelectedValue.ToString) &
                        " and TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & Val(xNumero.Text)).Top
        If wDocD Is Nothing Then
            MsgError("Documento a Anular sin detalles")
            Exit Sub
        End If
        Dim wDocP = SQL("Select * from DocumentosP where Local = " & Val(cLocal.SelectedValue.ToString) &
                        " and TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & Val(xNumero.Text)).Top


        Dim wDocS = SQL("Select * from DocumentosR where Local = " & Val(cLocal.SelectedValue.ToString) &
                        " and TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & Val(xNumero.Text) &
                        " and TipoDocRef = '" & xAnula.Tag.ToString & "'")
        If wDocS.Rows.Count > 0 Then
            MsgError("Documento a Anular ya tiene una anulación previa.  Realice la operación por Emisión de Documentos")
            Exit Sub
        End If

        CorrelativoNuevo = BuscarCorrelativo(ModoCorrelativo.Actualizar, xAnula.Tag.ToString, cFecha.Value, CInt(G_POS.ToText))
        xFolio.Text = CStr(CorrelativoNuevo)

        'Verificar que el documento nuevo no exista
        Dim wDG = SQL("Select Top 1 Numero from DocumentosG where Local = " & Val(cLocal.SelectedValue.ToString) &
                      " and TipoDoc = '" & xAnula.Tag.ToString & "' and Numero = " & Val(xFolio.Text))
        If wDG.Rows.Count > 0 Then
            MsgError("Documento Nuevo: " & vbCrLf & xAnula.ToString.Trim & " N° " & xFolio.Text & vbCrLf & "Ya existe, favor de volver a intentar.")
            Exit Sub
        End If


        'Clonar Documento
        Cursor = Cursors.WaitCursor
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wDGs As New T_DocumentosG
        Dim DCG = DC.T_DocumentosG.FirstOrDefault(Function(x) x.Local = Val(cLocal.SelectedValue.ToString) And
                                                                x.TipoDoc = cTipoDoc.SelectedValue.ToString And
                                                                x.Numero = Val(xNumero.Text))
        If DCG IsNot Nothing Then
            Dim wItemNew = DCG.Clonar
            wItemNew.TipoDoc = xAnula.Tag.ToString
            wItemNew.Numero = CInt(CorrelativoNuevo)
            wItemNew.Fecha = CDate(Format(cFecha.Value, "dd/MM/yyyy hh:mm:ss"))

            wItemNew.Motivo = CChar("A")
            wItemNew.STATUS_DTE = EstadosSII.No_Enviado
            wItemNew.TED = ""

            If DTE.Es_Electronico(xAnula.Tag.ToString) Then
                wItemNew.DTE = True
            Else
                wItemNew.DTE = False
            End If

            DC.T_DocumentosG.InsertOnSubmit(wItemNew)
            DC.SubmitChanges()

            'Agregar Documento de Referencia
            Dim wTipoDocRef = DC.T_TipoDoc.FirstOrDefault(Function(x) x.TipoDoc = cTipoDoc.SelectedValue.ToString)
            Dim wTributario As Boolean = False

            If wTipoDocRef IsNot Nothing Then
                wTributario = wTipoDocRef.Contable
            End If

            Dim wDocR As New T_DocumentosR With {
                .Local = G_LOCALACTUAL,
                .TipoDoc = wItemNew.TipoDoc,
                .Numero = wItemNew.Numero,
                .TipoDocRef = cTipoDoc.SelectedValue.ToString,
                .NumDocRef = xNumero.Text.ToString,
                .FechaRef = DCG.Fecha,
                .Tributario = wTributario
            }
            DC.T_DocumentosR.InsertOnSubmit(wDocR)
            DC.SubmitChanges()
        End If

        'Detalles
        Dim wDD = DC.T_DocumentosD.Where(Function(x) x.Local = Val(cLocal.SelectedValue.ToString) And
                                                      x.TipoDoc = cTipoDoc.SelectedValue.ToString And
                                                      x.Numero = Val(xNumero.Text))
        If wDD.Any Then
            For Each wD In wDD
                Dim wNewItem = wD.Clonar()
                wNewItem.TipoDoc = xAnula.Tag.ToString
                wNewItem.Numero = CInt(CorrelativoNuevo)
                DC.T_DocumentosD.InsertOnSubmit(wNewItem)
                DC.SubmitChanges()
            Next
        Else
            MsgError("Documento a Anular sin detalles")
        End If

        'Pagos
        Dim wDP = DC.T_DocumentosP.Where(Function(x) x.Local = Val(cLocal.SelectedValue.ToString) And
                                                      x.TipoDoc = cTipoDoc.SelectedValue.ToString And
                                                      x.Numero = Val(xNumero.Text))
        If wDP.Any Then
            For Each wD In wDP
                Dim wNewItem = wD.Clonar
                wNewItem.TipoDoc = xAnula.Tag.ToString
                wNewItem.Numero = CInt(CorrelativoNuevo)
                wNewItem.Fecha = cFecha.Value
                DC.T_DocumentosP.InsertOnSubmit(wNewItem)
                DC.SubmitChanges()
            Next
        End If

        Try
            'Parametrizar con datos del Local
            If Not DTE.Parametros_DTE(Val(cLocal.SelectedValue.ToString)) Then
                MsgError("Error al sacar parámetros del Local.")
                Exit Sub
            Else
                'Generar TED
                Dim wC = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = Val(xCliente.Text))
                Dim wNombre = wC.Nombre.Trim
                Dim wDGC = DC.T_DocumentosG.FirstOrDefault(Function(x) x.Local = Val(cLocal.SelectedValue.ToString) And x.TipoDoc = xAnula.Tag.ToString And x.Numero = Val(xFolio.Text))
                Dim wPrimeraLinea = Primera_Linea(Val(cLocal.SelectedValue.ToString), xAnula.Tag.ToString, Val(xFolio.Text))

                If Not DTE.Generar_TED(CInt(Val(cLocal.SelectedValue.ToString)), xAnula.Tag.ToString, CorrelativoNuevo, CDate(xFecha.Text), DTE.Rut_DTE(DCG.Rut), wNombre, DCG.Total, wPrimeraLinea).Estado Then
                    MsgError("Error al Generar TED.")
                Else
                    'Envio al DTE
                    If DTE.Emitir_DTE(G_LOCALACTUAL, xAnula.Tag.ToString, CorrelativoNuevo) Then
                        Mensaje("Documento Enviado Exitosamente.")
                    Else
                        MsgError("Error al enviar documento.")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgError("Error al Generar/Enviar Documento Electrónico" & vbCrLf & ex.Message.ToString)
        End Try


        Auditoria(Me.Text, "Anulación Documento Contable", cTipoDoc.SelectedValue.ToString, xNumero.Text)
        Auditoria(Me.Text, "Documento Contable Emitido", xAnula.Tag.ToString, CStr(CorrelativoNuevo))

        Cursor = Cursors.Arrow
        Mensaje("Documento Anulado con:" & vbCrLf & xAnula.Text & vbCrLf & "N° " & CorrelativoNuevo.ToString)

        DoEvents()
        G_TIPOCOPIA = {1}.ToList
        If Pregunta("¿Desea ver el Documento Generado?") Then
            Imprimir_Documento(Val(cLocal.SelectedValue.ToString), xAnula.Tag.ToString, Val(CorrelativoNuevo), cTipoDoc.Text, G_TIPOCOPIA)
        End If
        LimpiarCampos(Me)

    End Sub


    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Close()
    End Sub

    Private Sub bBuscarCli_Validating(sender As Object, e As CancelEventArgs) Handles bBuscarCli.Validating

    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        e.NextControl(xRut)
    End Sub

    Private Sub bBuscarCli_Click(sender As Object, e As EventArgs) Handles bBuscarCli.Click
        Buscar_Datos_Doc()
    End Sub

    Private Sub xNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNumero.KeyPress
        If e.KeyChar = vbCr Then
            Buscar_Datos_Doc()
        End If
    End Sub

    Private Sub Buscar_Datos_Doc()

        If cLocal.Text = "" Then
            MsgError("Falta Local")
            Exit Sub
        End If
        If cTipoDoc.Text = "" Then
            MsgError("Falta Tipo de Documento a Anular")
            Exit Sub
        End If
        If Val(xNumero.Text) = 0 Then
            xNumero.Clear()
            MsgError("Falta Número de Documento a Anular")
            Exit Sub
        End If

        Dim wDocG = SQL("Select * from DocumentosG where Local = " & Val(cLocal.SelectedValue.ToString) &
                        " and TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & Val(xNumero.Text)).Top
        If wDocG Is Nothing Then
            MsgError("Documento a Anular No Encontrado")
            xNumero.Focus()
            Exit Sub
        Else
            xCliente.Text = Trim(wDocG.GetText("Cliente"))
            xFecha.Text = Format(wDocG.GetDate("Fecha"), "dd/MM/yyyy")
            xMonto.Text = Format(wDocG.GetNum("Total"), "###,###,###")

            'Poner la Fecha de anulación el mismo dia de emisión de la factura
            cFecha.Text = Format(wDocG.GetDate("Fecha"), "dd/MM/yyyy")

            'Verificar que el documento nuevo no exista
            Dim wCC = SQL("Select * from Correlativos where Local = " & Val(cLocal.SelectedValue.ToString) &
                      " and TipoDoc = '" & xAnula.Tag.ToString & "'").Top
            If wDocG Is Nothing Then
                MsgError("Error al obtener datos del correlativo")
                Exit Sub
            Else
                If cFecha.Value < wCC.GetDate("FechaCAF") Then
                    'Si la fecha a anular es menor a la fecha del CAF, solo se puede poner fecha del CAF como mínimo.
                    cFecha.Value = wCC.GetDate("FechaCAF")
                End If
            End If

            xCliente.Text = Trim(wDocG.GetText("Cliente"))
            xFecha.Text = Format(wDocG.GetDate("Fecha"), "dd/MM/yyyy")
                xMonto.Text = Format(wDocG.GetNum("Total"), "###,###,###")







                Dim wCli = SQL("Select * from Clientes where Cliente = " & Val(wDocG.GetText("Cliente"))).Top
            If wCli Is Nothing Then
                xRut.Clear()
            Else
                xRut.Text = Trim(wCli.GetText("Rut"))
                xNombre.Text = Trim(wCli.GetText("Nombre"))
            End If
        End If
    End Sub

    Private Sub xNumero_TextChanged(sender As Object, e As EventArgs) Handles xNumero.TextChanged

    End Sub
End Class

