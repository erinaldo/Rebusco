Public Class AnularDocumento
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub AnularDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        If cLocal.Items.Count = 2 Then
            cLocal.SelectedIndex = 1
        End If
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", " WHERE Cod_SII = 0 or Anula = '' Order by DescTipoDoc")
        Auditoria(Text, A_INGRESADO, "", "")
    End Sub

    Private Sub xDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDocumento.KeyPress
        ValidarDigitos(e)
        e.NextControl(bAnular)
    End Sub

    Private Sub bAnular_Click(sender As Object, e As EventArgs) Handles bAnular.Click
        Dim wDatos = ""
        Dim wModoInventario = ""

        If cLocal.Text.Trim = "" Then
            MsgError("Indique Local")
            cLocal.Focus()
            Exit Sub
        End If

        If cTipoDoc.Text.Trim = "" Then
            MsgError("Indique tipo documento")
            cTipoDoc.Focus()
            Exit Sub
        End If
        If xDocumento.Text.Trim = "" Then
            MsgError("Indique número de documento")
            xDocumento.Focus()
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wDocG = DC.T_DocumentosG.FirstOrDefault(Function(x) x.Local = CInt(cLocal.SelectedValue.ToString) And
                                                         x.TipoDoc = cTipoDoc.SelectedValue.ToString And
                                                         x.Numero = Val(xDocumento.Text))
        If wDocG Is Nothing Then
            MsgError("Documento no encontrado")
            Exit Sub
        Else
            wDatos = "Cliente: (" & (wDocG.Cliente) & ") "
            Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = wDocG.Cliente)
            If wCli IsNot Nothing Then
                wDatos = wDatos & " " & wDocG.Rut & " " & wCli.Nombre
            End If
            wDatos = wDatos & vbCrLf
            wDatos = wDatos & "Fecha: " & Format(wDocG.Fecha, "dd/mm/yyyy") & vbCrLf
            wDatos = wDatos & "Monto: " & Format(wDocG.Total, "###,###,###")
        End If

        If oEliminar.Checked Then
            If wDocG.Estado = "N" Then
                MsgError("Documento ya Anulado")
                Exit Sub
            End If
        End If

        If oEliminar.Checked Then
            If Not Pregunta("¿Desea anular y eliminar " & cTipoDoc.Text.Trim & " " & xDocumento.Text.Trim & vbCrLf & wDatos & "?") Then
                Exit Sub
            End If
        Else
            If Not Pregunta("¿Desea anular " & cTipoDoc.Text & " " & xDocumento.Text.Trim & vbCrLf & wDatos & "?") Then
                Exit Sub
            End If
        End If

        Call Auditoria(Me.Name, "Anular Evento de Documento", cTipoDoc.Text, xDocumento.Text.Trim)

        'Invertir Modo
        If wModoInventario = ModoInventario.Incrementar Then
            wModoInventario = ModoInventario.Disminuir
        Else
            If wModoInventario = ModoInventario.Disminuir Then
                wModoInventario = ModoInventario.Incrementar
            End If
        End If

        Dim wBodega As Decimal = If(wDocG.Bodega = 0, 0, wDocG.Bodega)

        wDocG.Estado = CChar("N")
        wDocG.Aprobado = False
        wDocG.SubTotal = 0
        wDocG.Descuento = 0
        wDocG.Neto = 0
        wDocG.IVA = 0
        wDocG.Total = 0
        DC.SubmitChanges()

        If oEliminar.Checked Then
            Dim wDel = DC.T_DocumentosG.FirstOrDefault(Function(x) x.Local = Val(cLocal.SelectedValue.ToString) And
                                                            x.TipoDoc = cTipoDoc.SelectedValue.ToString And
                                                            x.Numero = Val(xDocumento.Text))
            DC.T_DocumentosG.DeleteOnSubmit(wDel)
            DC.SubmitChanges()
        End If

        Dim local = cLocal.SelectedValue.ToString.ToDecimal()
        Dim tipodoc = cTipoDoc.SelectedValue.ToString
        Dim numdoc = xDocumento.Text.ToDecimal()

        Dim wDocD = DC.T_DocumentosD.Where(Function(x) x.Local = local And x.TipoDoc = tipodoc And x.Numero = numdoc)

        For Each det In wDocD
            Dim Stock = Stocks(det.Articulo, wBodega, cLocal.SelectedValue.ToString.ToDecimal, det.Cantidad.ToDecimal(), wModoInventario)
            Dim eve = Tracking.Eventos.SinEvento
            Select Case wModoInventario
                Case ModoInventario.Incrementar
                    eve = Tracking.Eventos.StockIncrementado
                Case ModoInventario.Disminuir
                    eve = Tracking.Eventos.StockDisminuido
                Case ModoInventario.Igualar
                    eve = Tracking.Eventos.StockEstablecido
            End Select
            Tracking.Ingresar(eve, Now, wDocG.Cliente, wDocG.TipoDoc, wDocG.Numero, wDocG.Fecha, det.Articulo, det.Cantidad.ToDecimal(), wBodega, cLocal.SelectedValue.ToString.ToDecimal, "", Me.Text)
        Next
        'Eliminar Detalles
        Dim wDD = DC.T_DocumentosD.FirstOrDefault(Function(x) x.Local = Val(cLocal.SelectedValue.ToString) And
                                                              x.TipoDoc = cTipoDoc.SelectedValue.ToString And
                                                              x.Numero = Val(xDocumento.Text))
        If wDD IsNot Nothing Then
            DC.T_DocumentosD.DeleteOnSubmit(wDD)
        End If

        Dim wDP = DC.T_DocumentosP.FirstOrDefault(Function(x) x.Local = Val(cLocal.SelectedValue.ToString) And
                                                              x.TipoDoc = cTipoDoc.SelectedValue.ToString And
                                                              x.Numero = Val(xDocumento.Text))

        DC.SubmitChanges()
        If oEliminar.Checked Then
            Mensaje("Documento Anulado y Eliminado")
            Auditoria(Text, "Anulado y Eliminado", xDocumento.Text.Trim, cTipoDoc.Text)
        Else
            Mensaje("Documento Anulado")
            Auditoria(Text, "Anulado", xDocumento.Text.Trim, cTipoDoc.Text)
        End If
        Cursor = Cursors.WaitCursor
        LimpiarCampos(Me)

    End Sub

    Private Sub oEliminar_CheckedChanged(sender As Object, e As EventArgs)
        Dim wCheckBox As CheckBox = DirectCast(sender, CheckBox)
        wCheckBox.ForeColor = If(wCheckBox.Checked, Color.White, Color.FromArgb(29, 73, 140))

        wCheckBox.Image = If(wCheckBox.Checked, My.Resources.Resources.check16true_b,
                                                    My.Resources.Resources.check16false_b)
    End Sub
End Class