Public Class ConsultaBoleta
    Public wTipoDocumento As String
    Private Sub ConsultaBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xTabla.Clear()
        xTabla.Rows.Count = 1
    End Sub

    Sub CargarDatos(ByVal wNumDoc As Double, ByVal wDocumento As String)

        Dim wFila As Integer = 0
        bBuscar.Enabled = False

        Dim TkG = SQL("SELECT td.Articulo,a.Descripcion,td.Barra," &
          " td.Cantidad,td.PVenta,(td.Cantidad*td.PVenta) as Total" &
          " FROM Ventas v " &
          " INNER JOIN TikDet td on v.Ticket=td.Ticket " &
          " INNER JOIN Articulos a on td.Articulo=a.Articulo " &
          " WHERE NumDoc=" & wNumDoc & " and TipoDoc='" & wDocumento & "' and v.Local=" & G_LOCALACTUAL & "")

        xTabla.Clear()
        xTabla.Rows.Count = 1

        If TkG.Rows.Count = 0 Then
            xTabla.Rows.Count = 0
            MsgError("No hay datos para mostrar")
            bBuscar.Enabled = True
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        xTabla.Cols.Count = TkG.Rows.Count

        For wColumna = 0 To TkG.Columns.Count
            xTabla.SetData(0, wColumna, TkG.Columns.Item(wColumna).Caption)
            xTabla.Cols(wColumna).Width = 10
        Next

        wFila = 1

        Dim wTotales As Double
        For Each wRow As DataRow In TkG.Rows
            DoEvents()
            xTabla.AddItem("")
            For Col = 0 To xTabla.Cols.Count - 1
                If Col = xTabla.Cols.Count - 1 Then
                    wTotales += Val(wRow.GetText("Total").ToString)
                End If
                xTabla.SetData(wFila, Col, wRow.Item(Col).ToString.Trim)
            Next Col
        Next
        xTotal.Text = wTotales.ToString
        xTabla.AjustarColumnas
        bBuscar.Enabled = True
        xTabla.Redraw = True
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        If xBoleta.Text.Trim = "" Then Exit Sub
        CargarDatos(Val(xBoleta.Text), wTipoDocumento)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub xBoleta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBoleta.KeyPress, xTotal.KeyPress
        ValidarDigitos(e)
        If e.KeyChar = Chr(13) Then
            bBuscar.Focus()
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        xBoleta.Clear()
        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTotal.Text = "0"
        xBoleta.Focus()
    End Sub
End Class