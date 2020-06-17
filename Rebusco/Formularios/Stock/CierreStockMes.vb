Public Class CierreStockMes
    Private Sub CierreStockMes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dFechaCierre.Value = Now
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

        If dFechaCierre.Value <> IniFinFecha(2, Now) Then
            If Not Pregunta("ATENCIÓN: Fecha ingresada no corresponde para cerrar mes." + vbCrLf + "Desea Cerrar de todos modos.") Then
                Exit Sub
            End If
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wStockC = DC.T_Stocks_Cierre.Where(Function(x) x.FechaCierre = dFechaCierre.Value)

        If wStockC.Any Then
            MsgError("Cierre de mes ya ha sido creado." + vbCrLf + "Imposible Cerrar nuevamente para ese dia")
            Exit Sub
        End If

        If Pregunta("¿Desea cerrar el Mes?") Then
            Cursor = Cursors.WaitCursor
            Dim wStock = DC.T_Stocks()
            If wStock.Any Then
                For Each wS In wStock
                    Dim wStockCierre As New T_Stocks_Cierre
                    wStockCierre.Articulo = wS.Articulo
                    wStockCierre.Local = wS.Local
                    wStockCierre.Bodega = wS.Bodega
                    wStockCierre.Stock = wS.Stock
                    wStockCierre.FechaCierre = dFechaCierre.Value
                    DC.T_Stocks_Cierre.InsertOnSubmit(wStockCierre)
                Next
            End If
            DC.SubmitChanges()
            Cursor = Cursors.Arrow
            Call Auditoria(Text, "Cerrar Stocks", "Fecha de Cierre", dFechaCierre.Value.ToString)
            Mensaje("Cierre de Stock realizado correctamente")
        End If
    End Sub
End Class