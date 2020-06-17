Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports C1.Win.C1FlexGrid

Public Class ConsultarAtenciones
    Const T_OT = 0
    Const T_PRODUCTO = 1
    Const T_CODIGO = 2
    Const T_SERVICIO = 3

    Private Sub ConsultarRepciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Titulos()
    End Sub
    Sub Titulos()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 4
        xTabla.Cols(T_OT).Caption = "OT"
        xTabla.Cols(T_PRODUCTO).Caption = "Producto"
        xTabla.Cols(T_CODIGO).Caption = "Código"
        xTabla.Cols(T_SERVICIO).Caption = "Último Servicio"

        xTabla.Cols(T_OT).Width = 80
        xTabla.Cols(T_PRODUCTO).Width = 410
        xTabla.Cols(T_CODIGO).Width = 120
        xTabla.Cols(T_SERVICIO).Width = 120
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(bBuscar)
    End Sub

    Private Sub xTabla_DoubleClick(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles xTabla.DoubleClick
        If xTabla.Rows.Count - 1 > 0 Then
            Dim Ing_OT As New IngresoOT
            Ing_OT.Show()
            Ing_OT.xOT.Text = xTabla.GetData(xTabla.Row, T_OT).ToString
            Ing_OT.xCodigoR.Text = xTabla.GetData(xTabla.Row, T_CODIGO).ToString
            Ing_OT.xProductoR.Text = xTabla.GetData(xTabla.Row, T_PRODUCTO).ToString
            Ing_OT.xOT.Focus()
            Ing_OT.xOT.Validate()
        End If
    End Sub

    Private Sub xTabla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTabla.KeyPress
        If e.KeyChar = vbCr Then
            xTabla_DoubleClick()
        End If
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Cursor = Cursors.WaitCursor
        Dim wRec = SQL("SELECT OT, Recepcion, Codigo, max(Fecha) FechaOT FROM OT WHERE Cliente = " & Val(xCliente.Text) &
                  " AND (Recepcion Like '%" & xDescripcion.Text.Trim & "%' OR Codigo LIKE '%" & xDescripcion.Text.Trim & "%')" &
                  " GROUP BY Recepcion, Codigo, OT ORDER BY OT DESC")

        If wRec.Rows.Count > 0 Then
            Titulos()
            For Each wR As DataRow In wRec.Rows
                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_OT, wR.GetText("OT"))
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

    Private Sub xCliente_ItemSeleccionado(wDescripcion As String) Handles xCliente.ItemSeleccionado
        xNombre.Text = wDescripcion
        xDescripcion.Focus()
    End Sub

    Private Sub xCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles xCliente.KeyDown
        If e.KeyCode = Keys.F3 Then
            bBuscarC.Buscar_Click()
        End If
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        e.NextControl(xDescripcion)
    End Sub

    Private Sub xCliente_Validating(sender As Object, e As CancelEventArgs) Handles xCliente.Validating
        Dim wPatronRut = New Regex("^(\d{2}\.\d{3}\.\d{3}-)([kK]{1}$|\d{1}$)")

        If xCliente.ListaVisible Then
            If xCliente.ListaActiva Then
                Exit Sub
            Else
                xCliente.OcultarLista()
            End If
        End If

        If Trim(xCliente.Text) = "" Then
            xNombre.Clear()
            Exit Sub
        End If
        If xCliente.DescEncontrada = "" Then
            Dim DC = New MarketONEDataContext(P_CONEXION)
            If wPatronRut.IsMatch(xCliente.Text.Replace(",", ".")) Then
                Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Rut = xCliente.Text.Replace(",", "."))
                If wCli IsNot Nothing Then
                    xCliente.AutoCompletarActivo = False
                    xCliente.Text = wCli.Cliente.ToString()
                    xNombre.Text = wCli.Nombre
                    xCliente.AutoCompletarActivo = True
                End If
            ElseIf Val(xCliente.Text) <> 0 Then
                Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = CInt(xCliente.Text.Trim))
                If wCli IsNot Nothing Then
                    xNombre.Text = wCli.Nombre
                End If
            Else
                Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Fantasia = xCliente.Text.Trim)
                If wCli IsNot Nothing Then
                    xCliente.Text = wCli.Cliente.ToString
                    xNombre.Text = wCli.Nombre
                End If
            End If
        Else
            xNombre.Text = xCliente.DescEncontrada
        End If
    End Sub

    Private Sub xDescripcion_TextChanged(sender As Object, e As EventArgs) Handles xDescripcion.TextChanged

    End Sub
End Class