Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports C1.Win.C1FlexGrid

Public Class ConsultarProductos
    Const T_PRODUCTO = 0
    Const T_CODIGO = 1
    Const T_SERVICIO = 2
    Private Sub ConsultarRepciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Titulos()
    End Sub
    Sub Titulos()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 3
        xTabla.Cols(T_PRODUCTO).Caption = "Producto"
        xTabla.Cols(T_CODIGO).Caption = "Codigo"
        xTabla.Cols(T_SERVICIO).Caption = ""
        xTabla.Cols(T_PRODUCTO).Width = 410
        xTabla.Cols(T_CODIGO).Width = 120
        xTabla.Cols(T_SERVICIO).Width = 0
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(bCancelar)
    End Sub

    Private Sub xTabla_DoubleClick(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles xTabla.DoubleClick
        If xTabla.Rows.Count - 1 > 0 Then
            IngresoOT.xCodigoR.Text = xTabla.GetData(xTabla.Row, T_CODIGO).ToString
            IngresoOT.xProductoR.Text = xTabla.GetData(xTabla.Row, T_PRODUCTO).ToString
            IngresoOT.xTecnico.Focus()
            Close()
        End If
    End Sub

    Private Sub xTabla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTabla.KeyPress
        If e.KeyChar = vbCr Then
            xTabla_DoubleClick()
        End If
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Cursor = Cursors.WaitCursor
        Dim wRec = SQL("SELECT Recepcion, Codigo,max(Fecha) FechaOT FROM OT WHERE Cliente = " & Val(xCliente.Text) &
                  " AND (Recepcion Like '%" & xDescripcion.Text.Trim & "%' OR Codigo LIKE '%" & xDescripcion.Text.Trim & "%')" &
                  " GROUP BY Recepcion, Codigo ORDER BY FechaOT DESC")

        If wRec.Rows.Count > 0 Then
            Titulos()
            For Each wR As DataRow In wRec.Rows
                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_CODIGO, wR.GetText("Codigo"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_PRODUCTO, wR.GetText("Recepcion"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_SERVICIO, wR.GetText("FechaOT"))
            Next
            xTabla.Row = 1
            xTabla.Focus()
        Else
            Mensaje("No se han encontrado registros.")
            xDescripcion.Focus()
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub xCliente_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.F3 Then
            bBuscarC.Buscar_Click()
        End If
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.NextControl(xDescripcion)
    End Sub



End Class