Imports System.Collections.Specialized
Imports C1.Win.C1FlexGrid

Public Class ModuloFPagos
    Const T_ELIMINAR = 0
    Const T_FPAGO = 1
    Const T_FECHA = 2
    Const T_NUMERO = 3
    Const T_CUENTA = 4
    Const T_BANCO = 5
    Const T_TITULAR = 6
    Const T_CLIENTE = 7
    Const T_MONTO = 8
    Const T_ESTADO = 9
    Const T_OBSERVACION = 10

    Const T_IDFPAGO = 11
    Const T_IDBANCO = 12
    Const T_IDESTADO = 13

    Dim xFila As Integer
    Dim xColumna As Integer
    Public gEstadoPago As Boolean

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

        Dim DC = New MarketONEDataContext(P_CONEXION)
        If xMonto.Text = "" Then xMonto.Text = "0"
        If xTotal.Text = "" Then xTotal.Text = "0"
        If xVendedor.Text = "" Then xVendedor.Text = UsuarioActual

        Calcular_Total()

        For Each wRow As C1.Win.C1FlexGrid.Row In xTabla.Rows
            If wRow.Index = 0 Then Continue For

            If wRow.Item(T_FPAGO).ToString = "" Then
                MsgError("No puede quedar un pago vacio")
                Exit Sub
            End If

            If Val(wRow.Item(T_MONTO).ToString) = 0 Then
                MsgError("No puede quedar un pago con monto 0")
                Exit Sub
            End If

            If wRow.Item(T_FECHA).ToString = "" Then
                MsgError("No puede quedar un pago sin fecha asignada")
                Exit Sub
            End If
        Next

        If xFaltantePago.Text.ToDecimal > 0 Then
            MsgError("Monto de pagos no coincide con el monto del documento.")
            Exit Sub
        End If

        'If xFaltantePago.ToDouble > 0 Then
        '    If Not Pregunta("¿Desea dejar el Documento como pendiente de pago?") Then
        '        Exit Sub
        '    End If
        'End If

        For Each wRow As C1.Win.C1FlexGrid.Row In xTabla.Rows
            If wRow.Index = 0 Then Continue For
            Dim wFecha As New DateTime()
            If wRow.Item(T_IDFPAGO).ToString = "C" Then
                wFecha = CDate(wRow.Item(T_FECHA).ToString)
            Else
                wFecha = New DateTime(2000, 1, 1)
            End If

            Dim wDocumentoP As New T_DocumentosP With
            {
                .Local = G_LOCALACTUAL,
                .TipoDoc = xIDTipoDoc.Text.Trim,
                .Numero = CInt(Val(xNumero.Text)),
                .Fecha = EmisionDocumentos.xFecha.Value,
                .Cliente = CInt(Val(xCliente.Text)),
                .Vendedor = xVendedor.Text,
                .Estado = wRow.Item(T_IDESTADO).ToString,
                .FPago = wRow.Item(T_IDFPAGO).ToString,
                .FechaPago = CDate(wRow.Item(T_FECHA).ToString),
                .NumeroPago = wRow.Item(T_NUMERO).ToString,
                .Cuenta = wRow.Item(T_CUENTA).ToString,
                .Banco = wRow.Item(T_BANCO).ToString,
                .Titular = wRow.Item(T_TITULAR).ToString,
                .Monto = CInt(Val(wRow.Item(T_MONTO).ToString)),
                .Obs = wRow.Item(T_OBSERVACION).ToString,
                .Usuario = UsuarioActual
            }

            DC.T_DocumentosP.InsertOnSubmit(wDocumentoP)
        Next

        DC.SubmitChanges()
        Auditoria(Me.Name, "Ingresó Pago", Trim(xTipoDoc.Text) & "-" & Trim(xNumero.Text), G_LOCALACTUAL.ToString)
        gEstadoPago = True
        EmisionDocumentos.Enabled = True

        DialogResult = DialogResult.OK
        Close()

    End Sub

    Private Sub ModuloFPagos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DialogResult = DialogResult.OK Then Exit Sub
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub bAgregar_Click(sender As Object, e As EventArgs) Handles bAgregar.Click

        If xTabla.Rows.Count > 1 Then
            Dim wCalculo As Double
            Dim wTotal As Decimal = xTotal.Text.ToDecimal
            Dim wRestante As Decimal = xFaltantePago.Text.ToDecimal
            Dim wMontoModificado As Double = 0

            For Each wRow As C1.Win.C1FlexGrid.Row In xTabla.Rows
                If xVouche.Text = wRow.Item(T_NUMERO).ToString And bAgregar.Text = "Agregar" Then
                    MsgError("Ya existe un pago con el mismo nùmero de Documento de pago")
                    Exit Sub
                End If
                wCalculo += Val(wRow.Item(T_MONTO).ToString)
            Next

            If bAgregar.Text = "Agregar" Then
                If Val(xTotal.Text.Replace(",", "")) = wCalculo Then
                    MsgError("La totalidad del pago esta completa, no puede agregar mas pagos")
                    Exit Sub
                End If
            End If

            If bAgregar.Text = "Modificar" Then
                wMontoModificado = Val(xTabla.GetData(xTabla.Row, T_MONTO))
                wCalculo = wCalculo - wMontoModificado
            End If

            Dim wDiferencia = wTotal - wCalculo

            If Val(xMonto.Text) > wDiferencia Then
                MsgError("El monto ingresado supera la cantidad faltante por cancelar")
                Exit Sub
            End If
        End If

        Dim wFila = 0
        If bAgregar.Text = "Agregar" Then
            xTabla.AddItem("")
            wFila = xTabla.Rows.Count - 1
            xTabla.SetCellImage(wFila, T_ELIMINAR, My.Resources.remove_table)
        Else
            wFila = xTabla.Row
        End If

        xTabla.SetData(wFila, T_FECHA, cFecha.Value)
        xTabla.SetData(wFila, T_FPAGO, cFPago.Text)
        xTabla.SetData(wFila, T_NUMERO, Val(xVouche.Text))
        xTabla.SetData(wFila, T_CUENTA, xCuenta.Text)
        xTabla.SetData(wFila, T_BANCO, cBanco.Text)
        xTabla.SetData(wFila, T_TITULAR, xTitular.Text)
        xTabla.SetData(wFila, T_CLIENTE, xCliente.Text)
        xTabla.SetData(wFila, T_MONTO, If(Val(xMonto.Text) = 0, xTotalPagar.Text, xMonto.Text))
        xTabla.SetData(wFila, T_ESTADO, cEstado.Text)
        xTabla.SetData(wFila, T_OBSERVACION, If(Val(xMonto.Text) = 0, "Cancelado Total", xObservacion.Text))

        xTabla.SetData(wFila, T_IDFPAGO, cFPago.SelectedValue.ToString)
        xTabla.SetData(wFila, T_IDBANCO, cBanco.SelectedValue.ToString)
        xTabla.SetData(wFila, T_IDESTADO, cEstado.SelectedValue.ToString)

        bAgregar.Text = "Agregar"
        Calcular_Total()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        EmisionDocumentos.Enabled = True
        gEstadoPago = False
        Close()
    End Sub

    Private Sub bPagoTotal_Click(sender As Object, e As EventArgs)
        If cFPago.Text = "" Then
            MsgError("Falta Forma de Pago")
            cFPago.Focus()
            Exit Sub
        End If
        If Trim(xMonto.Text) = "" Then xMonto.Text = "0"

        If Pregunta("Desea dejar un Registro de Pago Total del Documento") Then
            xTabla.AddItem("")
            xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, cFecha.Value)
            xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGO, cFPago.Text)
            xTabla.SetData(xTabla.Rows.Count - 1, T_NUMERO, 0)
            xTabla.SetData(xTabla.Rows.Count - 1, T_CUENTA, "")
            xTabla.SetData(xTabla.Rows.Count - 1, T_BANCO, "")
            xTabla.SetData(xTabla.Rows.Count - 1, T_TITULAR, "")
            xTabla.SetData(xTabla.Rows.Count - 1, T_CLIENTE, "")
            xTabla.SetData(xTabla.Rows.Count - 1, T_MONTO, CDbl(xMonto.Text))
            xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, "Cancelado")
            xTabla.SetData(xTabla.Rows.Count - 1, T_OBSERVACION, "Cancelado Total")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ModuloFPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = True
        DoEvents()
    End Sub

    Private Sub ModuloFPagos_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        cFPago.LoadItemsObj("FPagos", "FPago", "DescFPago", "WHERE FPago <> 'V'")
        cBanco.LoadItemsObj("Bancos", "Banco", "DescBanco")
        cEstado.LoadItemsObj("Estados", "Estado", "DescEstado", "WHERE Tipo = 'P'")
        cFecha.Value = Now
        Titulos()
        gEstadoPago = False
        Auditoria(Name, "Ingresó al Módulo", UsuarioActual, G_LOCALACTUAL.ToString)
        xFaltantePago.Text = xTotal.Text
        xCantidadPagos.Text = "0"
    End Sub

    Sub Titulos()
        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 14

        xTabla.Cols(T_ELIMINAR).Width = 60
        xTabla.Cols(T_FPAGO).Width = 120
        xTabla.Cols(T_FECHA).Width = 120
        xTabla.Cols(T_NUMERO).Width = 100
        xTabla.Cols(T_CUENTA).Width = 120
        xTabla.Cols(T_BANCO).Width = 120
        xTabla.Cols(T_TITULAR).Width = 150
        xTabla.Cols(T_CLIENTE).Width = 0
        xTabla.Cols(T_MONTO).Width = 120
        xTabla.Cols(T_ESTADO).Width = 120
        xTabla.Cols(T_OBSERVACION).Width = 300
        xTabla.Cols(T_IDFPAGO).Width = 0
        xTabla.Cols(T_IDBANCO).Width = 0
        xTabla.Cols(T_IDESTADO).Width = 0

        xTabla.Cols(T_ELIMINAR).Caption = "ID"
        xTabla.Cols(T_FPAGO).Caption = "F. Pago"
        xTabla.Cols(T_FECHA).Caption = "Fecha"
        xTabla.Cols(T_NUMERO).Caption = "Nùmero"
        xTabla.Cols(T_CUENTA).Caption = "Cuenta"
        xTabla.Cols(T_BANCO).Caption = "Banco"
        xTabla.Cols(T_TITULAR).Caption = "Titulo"
        xTabla.Cols(T_CLIENTE).Caption = "Cliente"
        xTabla.Cols(T_MONTO).Caption = "Monto"
        xTabla.Cols(T_ESTADO).Caption = "Estado"
        xTabla.Cols(T_OBSERVACION).Caption = "Observaciòn"
        xTabla.Cols(T_IDFPAGO).Caption = "IDFPAGO"
        xTabla.Cols(T_IDBANCO).Caption = "IDBANCO"
        xTabla.Cols(T_IDESTADO).Caption = "IDESTADO"

    End Sub

    Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs) Handles xTabla.DoubleClick
        If xTabla.Rows.Count > 1 Then
            If xTabla.Col = T_ELIMINAR Then
                xTabla.RemoveItem(xTabla.Row)
            End If
            Calcular_Total()
        End If
    End Sub

    Sub Calcular_Total(Optional wMontoModificado As Double = 0)
        Dim wCalculo As Double

        For Each wRow As C1.Win.C1FlexGrid.Row In xTabla.Rows
            If wRow.Index = 0 Then Continue For
            wCalculo += Val(wRow.Item(T_MONTO).ToString)
        Next

        xFaltantePago.Text = (xTotal.ToDouble - wCalculo).ToText(NumericFormat.Money)
        xTotalPagar.Text = wCalculo.ToText(NumericFormat.Money)
        xCantidadPagos.Text = (xTabla.Rows.Count - 1).ToString
        xTabla.Enabled = True
    End Sub

    Public Sub xVendedor_Validating(Optional sender As Object = Nothing, Optional e As System.ComponentModel.CancelEventArgs = Nothing) Handles xVendedor.Validating
        If xVendedor.Text = "" Then Exit Sub

        Dim wUsr = SQL("SELECT NombreUsr FROM Usuarios WHERE Usuario='" & Trim(xVendedor.Text) & "'").Top
        If wUsr IsNot Nothing Then
            xNombreVendedor.Text = wUsr.GetText("NombreUsr")
        Else
            MsgError("El vendedor indicado no existe")
            xVendedor.Clear()
            xNombreVendedor.Clear()
            xVendedor.Focus()
        End If
    End Sub

    Private Sub xVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xVendedor.KeyPress
        e.NextControl(cFPago)
    End Sub

    Private Sub xTabla_Click(sender As Object, e As EventArgs) Handles xTabla.Click
        If xTabla.Rows.Count > 1 And xTabla.Col <> T_ELIMINAR Then
            xVouche.Text = xTabla.GetData(xTabla.Row, T_NUMERO).ToString
            xMonto.Text = xTabla.GetData(xTabla.Row, T_MONTO).ToString
            cFPago.SelectedValue = xTabla.GetData(xTabla.Row, T_IDFPAGO).ToString
            cEstado.SelectedValue = xTabla.GetData(xTabla.Row, T_IDESTADO).ToString
            cBanco.SelectedValue = xTabla.GetData(xTabla.Row, T_IDBANCO).ToString
            xCuenta.Text = xTabla.GetData(xTabla.Row, T_CUENTA).ToString
            xTitular.Text = xTabla.GetData(xTabla.Row, T_TITULAR).ToString
            xObservacion.Text = xTabla.GetData(xTabla.Row, T_OBSERVACION).ToString
            xTabla.Enabled = False
            bAgregar.Text = "Modificar"
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        cFecha.Value = Now
        xVouche.Clear()
        xMonto.Clear()
        cFPago.SelectedIndex = -1
        cEstado.SelectedIndex = -1
        cBanco.SelectedIndex = -1
        xCuenta.Clear()
        xTitular.Clear()
        bAgregar.Text = "Agregar"
        xTabla.Enabled = False
    End Sub

    Public Sub xCliente_Validating(Optional sender As Object = Nothing, Optional e As System.ComponentModel.CancelEventArgs = Nothing) Handles xCliente.Validating
        If xCliente.Text.Trim = "" Then Exit Sub

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = CInt(Val(xCliente.Text)))
        If wCli IsNot Nothing Then
            xNombre.Text = wCli.Nombre
        End If
    End Sub

    Private Sub xVouche_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xVouche.KeyPress
        e.NextControl(xMonto)
    End Sub

    Private Sub xMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMonto.KeyPress
        e.NextControl(xObservacion)
    End Sub

    Private Sub xObservacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xObservacion.KeyPress
        e.NextControl(cFPago)
    End Sub

    Private Sub xCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCuenta.KeyPress
        e.NextControl(xTitular)
    End Sub

    Private Sub xTitular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTitular.KeyPress
        e.NextControl(bAgregar)
    End Sub
End Class