Public Class AnularMovimiento
    Private Sub AnularMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cBodega.LoadItemsObj("Bodegas", "Bodega", "NombreBodega")

        If G_ACCESOUSUARIO > 7 Or G_LOCALACTUAL = 0 Then
            cBodega.Enabled = False
        End If

        If G_ACCESOUSUARIO = 9 Then
            oEliminar.Visible = True
        End If

    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bAnular_Click(sender As Object, e As EventArgs) Handles bAnular.Click

        If xMovimiento.Text.Trim = "" Then
            MsgError("Ingrese Nº de Movimiento")
            xMovimiento.Focus()
            Exit Sub
        End If

        If cBodega.Text = "" Then
            MsgError("Falta Local donde se Emitió el Movimiento")
            Exit Sub
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim MovGen = DC.T_MovGen.FirstOrDefault(Function(x) x.Movimiento = CInt(xMovimiento.Text))

        If MovGen Is Nothing Then
            MsgError("N° de Movimiento no existe")
            Exit Sub
        End If

        If MovGen.Local <> G_LOCALACTUAL Then
            MsgError("Movimiento pertence a otro local, debe anularse desde local origen")
            Exit Sub
        End If

        If MovGen.Estado = "N" Then
            MsgError("Movimiento Nº: " & xMovimiento.Text.Trim & vbCr & "Se Encuentra Anulado ")
            Exit Sub
        End If

        If Pregunta("¿Desea Anular el Documento?") Then
            'Anular Movimiento
            MovGen.Estado = "N"
            'Anular Detalle de Movimiento
            Dim wMovDet = DC.T_MovDet.Where(Function(x) x.Movimiento = CInt(xMovimiento.Text.Trim))
            Dim wTipoMov = DC.T_TipoMov.FirstOrDefault(Function(x) x.TipoMov = MovGen.TipoMov)
            If wTipoMov Is Nothing Then
                MsgError("Error en el Tipo de Documento del Movimiento")
                Exit Sub
            End If
            If wMovDet.Any Then
                For Each det In wMovDet

                    Dim art = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = det.Articulo)

                    'Invertir Movimiento
                    Dim wModoInventario As String = ModoInventario.Igualar
                    If wTipoMov.Ajuste = ModoInventario.Incrementar Then
                        wModoInventario = ModoInventario.Disminuir
                    End If
                    If wTipoMov.Ajuste = ModoInventario.Disminuir Then
                        wModoInventario = ModoInventario.Incrementar
                    End If
                    'Actualizar Stock
                    Stocks(det.Articulo, MovGen.Bodega, MovGen.Local, det.Cantidad, wModoInventario)

                    Dim eve = Tracking.Eventos.SinEvento
                    Select Case wModoInventario
                        Case ModoInventario.Incrementar
                            eve = Tracking.Eventos.StockIncrementado
                        Case ModoInventario.Disminuir
                            eve = Tracking.Eventos.StockDisminuido
                        Case ModoInventario.Igualar
                            eve = Tracking.Eventos.StockEstablecido
                    End Select
                    Tracking.Ingresar(eve, Now, 0, TiposDoc.Movimiento, MovGen.Movimiento, MovGen.Fecha, det.Articulo, det.Cantidad, MovGen.Bodega, MovGen.Local, "", Me.Text)


                    det.Cantidad = 0
                    det.Precio = 0
                Next

                If oEliminar.Checked Then
                    If Pregunta("Desea Eliminar el Registro del Movimiento") Then
                        DC.T_MovGen.DeleteOnSubmit(MovGen)
                        DC.T_MovDet.DeleteAllOnSubmit(wMovDet)
                        DC.SubmitChanges()
                        Mensaje("Documento N° " & xMovimiento.Text.Trim & " eliminado correctamente." & vbCr &
                               "Stock Actualizado.")
                    End If
                Else
                    DC.SubmitChanges()
                    Mensaje("Documento N° " & xMovimiento.Text.Trim & " anulado correctamente" & vbCr &
                           "Stock Actualizado.")
                End If
                xMovimiento.Text = ""
                cBodega.Text = ""
                oEliminar.Checked = False
            End If
        End If
        Auditoria(Text, A_ANULADO, "Movimiento", xMovimiento.Text.Trim)
    End Sub

    Private Sub xMovimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMovimiento.KeyPress
        ValidarDigitos(e)
        If e.KeyChar = vbCr Then
            bAnular.Focus()
        End If
    End Sub

    Private Sub cBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBodega.SelectedIndexChanged
        If cBodega.Text <> "" Then
            bAnular.Focus()
        End If
    End Sub

    Private Sub xMovimiento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xMovimiento.Validating
        If xMovimiento.Text.Trim = "" Then Exit Sub

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wMovG = DC.T_MovGen.FirstOrDefault(Function(x) x.Movimiento = CInt(xMovimiento.Text.Trim))
        If wMovG IsNot Nothing Then
            If wMovG.Estado = "N" Then
                MsgError("N° Movimiento ya se encuentra Anulado")
                xMovimiento.Clear()
                xMovimiento.Focus()
                cBodega.SelectedIndex = -1
                Exit Sub
            End If
            cBodega.SelectedValue = wMovG.Bodega.ToString
        End If
    End Sub

    Private Sub xMovimiento_GotFocus(sender As Object, e As EventArgs) Handles xMovimiento.GotFocus
        xMovimiento.SelectAll()
    End Sub

    Private Sub AnularMovimiento_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        xMovimiento.Focus()
    End Sub
End Class