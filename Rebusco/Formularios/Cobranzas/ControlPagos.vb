Imports System.ComponentModel
Imports C1.Win.C1FlexGrid

Public Class ControlPagos
    Implements iFormulario
    Const T_OK = 0
    Const T_LOCAL = 1
    Const T_DOCUMENTO = 2
    Const T_NUMERO = 3
    Const T_CLIENTE = 4
    Const T_FECHAEMI = 5
    Const T_MONTO = 6
    Const T_FPAGO = 7
    Const T_FECHAVEN = 8
    Const T_ESTADO = 9
    Const T_FECHACAN = 10
    Const T_OBSER = 11
    Const T_CHEQUE = 12
    Const T_CUENTA = 13
    Const T_BANCO = 14
    Const T_TITULAR = 15
    Const T_ID = 16
    Const T_MODIF = 17

    Dim cEst As New ComboBox
    Dim cBancos As New ComboBox
    Dim cCuentas As New ComboBox
    Dim FiltroOpcion As String

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub
    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bBuscarA_Click(sender As Object, e As EventArgs) Handles bBuscarA.Click
        Dim wQuery As String
        wQuery = "SELECT Cliente as 'Cliente', Nombre as 'Nombre Cliente' From Clientes"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Nombre", Me, "Clientes", xCliente)
    End Sub

    Private Sub xCliente_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xCliente.Validating
        If xCliente.Text <> "" Then
            If Not IsNumeric(xCliente.Text) Then
                Dim wCl = SQL("SELECT Cliente FROM Clientes WHERE Fantasia = '" & xCliente.Text.Trim & "'").Top
                If wCl IsNot Nothing Then
                    xCliente.Text = wCl.GetText("Cliente")
                Else
                    xCliente.Text = ""
                    xNombre.Text = ""
                    xCliente.Focus()
                End If
            End If

            Dim wCli = SQL("SELECT NOMBRE FROM CLIENTES WHERE CLIENTE = " & Val(xCliente.Text) & "").Top
            If wCli IsNot Nothing Then
                xNombre.Text = wCli.GetText("Nombre")
            Else
                MsgError("Cliente no existe")
                xCliente.Clear()
                xCliente.Focus()
            End If
        End If
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        'ValidarDigitos(e)
        e.NextControl(cTipoDoc)
    End Sub

    Private Sub xNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNumero.KeyPress
        ValidarDigitos(e)
        e.NextControl(dDesde)
    End Sub

    Private Sub xVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xVendedor.KeyPress
        e.NextControl(bConsultaMes)
    End Sub

    Private Sub cTipoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cTipoDoc.KeyPress
        e.NextControl(xNumero)
    End Sub

    Private Sub dDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dDesde.KeyPress
        e.NextControl(dHasta)
    End Sub

    Private Sub dHasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dHasta.KeyPress
        e.NextControl(cFormaPago)
    End Sub
    Private Sub cEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cEstado.KeyPress
        e.NextControl(xVendedor)
    End Sub

    Private Sub xVendedor_Validating(sender As Object, e As CancelEventArgs) Handles xVendedor.Validating
        If xVendedor.Text <> "" Then
            Dim wVen = SQL("SELECT NombreUsr FROM Usuarios WHERE Usuario = '" & xVendedor.Text & "'").Top
            If wVen IsNot Nothing Then
                xVNombre.Text = wVen.GetText("Nombreusr")
            Else
                MsgError("Vendedor no encontrado")
                xVNombre.Clear()
                xVNombre.Focus()
            End If
        End If
    End Sub
    Sub Titulos()

        xTabla.Redraw = False

        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 18

        xTabla.Cols(T_OK).Width = 30
        xTabla.Cols(T_LOCAL).Width = 40
        xTabla.Cols(T_DOCUMENTO).Width = 110
        xTabla.Cols(T_NUMERO).Width = 70
        xTabla.Cols(T_CLIENTE).Width = 300
        xTabla.Cols(T_FECHAEMI).Width = 80
        xTabla.Cols(T_MONTO).Width = 80
        xTabla.Cols(T_FPAGO).Width = 100
        xTabla.Cols(T_FECHAVEN).Width = 80
        xTabla.Cols(T_ESTADO).Width = 100
        xTabla.Cols(T_FECHACAN).Width = 80
        xTabla.Cols(T_OBSER).Width = 200
        xTabla.Cols(T_CHEQUE).Width = 150
        xTabla.Cols(T_CUENTA).Width = 120
        xTabla.Cols(T_BANCO).Width = 150
        xTabla.Cols(T_TITULAR).Width = 180
        xTabla.Cols(T_ID).Width = 0
        xTabla.Cols(T_MODIF).Width = 0

        xTabla.Cols(T_OK).Caption = "OK"
        xTabla.Cols(T_LOCAL).Caption = "Local"
        xTabla.Cols(T_DOCUMENTO).Caption = "Documento"
        xTabla.Cols(T_NUMERO).Caption = "Número"
        xTabla.Cols(T_CLIENTE).Caption = "Cliente"
        xTabla.Cols(T_FECHAEMI).Caption = "Fecha Emi."
        xTabla.Cols(T_MONTO).Caption = "Monto"
        xTabla.Cols(T_FPAGO).Caption = "F.Pago"
        xTabla.Cols(T_FECHAVEN).Caption = "Fecha Ven."
        xTabla.Cols(T_ESTADO).Caption = "Estado"
        xTabla.Cols(T_FECHACAN).Caption = "Fecha Can."
        xTabla.Cols(T_OBSER).Caption = "Observaciones"
        xTabla.Cols(T_CHEQUE).Caption = "Cheque"
        xTabla.Cols(T_CUENTA).Caption = "Cuenta"
        xTabla.Cols(T_BANCO).Caption = "Banco"
        xTabla.Cols(T_TITULAR).Caption = "Titular"
        xTabla.Cols(T_ID).Caption = "ID"
        xTabla.Cols(T_MODIF).Caption = "MODIF"

        xTabla.Cols(T_OK).DataType = GetType(Boolean)
        xTabla.Cols(T_MONTO).DataType = GetType(Double)
        xTabla.Cols(T_MONTO).Format = "N0"

        xTabla.Cols(T_OK).TextAlignFixed = TextAlignEnum.CenterCenter
        xTabla.Cols(T_MONTO).TextAlignFixed = TextAlignEnum.RightCenter
        xTabla.Cols(T_NUMERO).TextAlignFixed = TextAlignEnum.RightCenter
        xTabla.Cols(T_FECHACAN).TextAlignFixed = TextAlignEnum.CenterCenter
        xTabla.Cols(T_FECHAVEN).TextAlignFixed = TextAlignEnum.CenterCenter
        xTabla.Cols(T_FECHAEMI).TextAlignFixed = TextAlignEnum.CenterCenter
        xTabla.Cols(T_LOCAL).TextAlignFixed = TextAlignEnum.CenterCenter

        xTabla.Cols(T_OK).TextAlign = TextAlignEnum.CenterCenter
        xTabla.Cols(T_FECHACAN).TextAlign = TextAlignEnum.CenterCenter
        xTabla.Cols(T_FECHAVEN).TextAlign = TextAlignEnum.CenterCenter
        xTabla.Cols(T_FECHAEMI).TextAlign = TextAlignEnum.CenterCenter
        xTabla.Cols(T_LOCAL).TextAlign = TextAlignEnum.CenterCenter

        Dim cFechaEmi As New DateTimePicker
        cFechaEmi.Format = DateTimePickerFormat.Short
        xTabla.Cols(T_FECHAEMI).Editor = cFechaEmi

        Dim cFechaVen As New DateTimePicker
        cFechaVen.Format = DateTimePickerFormat.Short
        xTabla.Cols(T_FECHAVEN).Editor = cFechaVen

        Dim cFechaCan As New DateTimePicker
        cFechaCan.Format = DateTimePickerFormat.Short
        xTabla.Cols(T_FECHACAN).Editor = cFechaCan

        Dim cFPagos As New ComboBox
        cFPagos.DropDownStyle = ComboBoxStyle.DropDownList
        LoadComboGrilla(cFPagos, "FPagos", "FPago", "DescFPago")
        xTabla.Cols(T_FPAGO).Editor = cFPagos

        cEst.DropDownStyle = ComboBoxStyle.DropDownList
        LoadComboGrilla(cEst, "Estados", "Estado", "DescEstado", " WHERE Tipo = 'P'")
        xTabla.Cols(T_ESTADO).Editor = cEst
        AddHandler cEst.SelectedIndexChanged, AddressOf ComboGrilla_SelectedIndexChanged

        cBancos.DropDownStyle = ComboBoxStyle.DropDownList
        LoadComboGrilla(cBancos, "Bancos", "Banco", "DescBanco")
        xTabla.Cols(T_BANCO).Editor = cBancos
        AddHandler cBancos.SelectedIndexChanged, AddressOf ComboGrilla_SelectedIndexChanged

        cCuentas.DropDownStyle = ComboBoxStyle.DropDownList
        cCuentas.Items.Clear()
        cCuentas.Items.Add("AHORRO")
        cCuentas.Items.Add("CORRIENTE")
        xTabla.Cols(T_CUENTA).Editor = cCuentas
        AddHandler cCuentas.SelectedIndexChanged, AddressOf ComboGrilla_SelectedIndexChanged

        xTabla.Redraw = True
    End Sub

    Private Sub Mostrar_Datos(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bMostrar.Click, bDeudas.Click, bConsultaMes.Click
        If sender IsNot Nothing Then FiltroOpcion = CType(sender, Button).Tag.ToString

        Dim Filtros As String = ""
        Dim wFila As Integer, wTipoDocs As String
        Dim wNeto As New Double, wIva As New Double, wTotal As New Double

        xNeto.Text = "0"
        xIva.Text = "0"
        xTotal.Text = "0"
        xCantSeleccionado.Text = ""
        xTotalSeleccionado.Text = ""
        cEstado.Text = ""
        xRegistro.Text = "0"
        Titulos()

        Filtros = " (1=1) "
        If xCliente.Text.Trim <> "" Then
            Filtros += " AND C.Cliente = " & Val(xCliente.Text.Trim) & ""
        End If

        If FiltroOpcion = "Mes" Then
            dDesde.Value = IniFinFecha(1, Now)
            dHasta.Value = IniFinFecha(2, Now)
        End If

        If FiltroOpcion = "Adeudado" Then
            wTipoDocs = " DP.TipoDoc in ('BV','FV','NC','ND','FE','BE') "
            Filtros += " AND " + wTipoDocs
            cTipoDoc.Text = "Factura de Venta"
            dDesde.Value = IniFinFecha(1, CDate("01/01/2000"))
            dHasta.Value = IniFinFecha(2, Now.Date)
            xCliente.Clear()
            xNombre.Clear()
            xNumero.Clear()
            cFormaPago.SelectedIndex = -1
            cEstado.Text = "Pendiente"
            xVendedor.Clear()
            xVNombre.Clear()
        Else
            If cTipoDoc.Text <> "" Then
                wTipoDocs = "DP.TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "'"
                Filtros += " AND " + wTipoDocs
            End If
        End If

        If xNumero.Text <> "" Then Filtros &= " AND DP.NUMERO = " & Val(xNumero.Text.Trim) & ""
        If xVendedor.Text.Trim <> "" Then Filtros &= " AND DP.Vendedor = '" & xVendedor.Text.Trim & "'"
        If cFormaPago.Text <> "" Then Filtros &= " AND DP.FPago = '" & cFormaPago.SelectedValue.ToString & "'"
        If cLocal.Text <> "" Then Filtros &= " AND DP.Local = " & cLocal.SelectedValue.ToString
        If cEstado.Text <> "" Then
            Filtros += " AND DP.Estado = '" & cEstado.SelectedValue.ToString & "'"
        End If

        Filtros += " AND Fecha BETWEEN '" & dDesde.Value & "' AND '" & dHasta.Value & "'"

        Dim wDocPs = SQL("SELECT DP.*,T.DescTipoDoc,C.Nombre, F.DescFPago, B.DescBanco, E.DescEstado FROM DocumentosP  DP" &
                         " JOIN TipoDoc T ON DP.TipoDoc = T.TipoDoc" &
                         " JOIN Clientes C ON DP.Cliente = C.Cliente" &
                         " JOIN FPagos F ON DP.FPago = F.FPago" &
                         " JOIN Estados E ON DP.Estado = E.Estado and E.Tipo = 'P'" &
                         " LEFT JOIN Bancos B ON DP.Banco = B.Banco" &
                         " WHERE " & Filtros & " ORDER BY DP.Local,DP.TipoDoc,DP.Numero")

        If wDocPs.Rows.Count > 0 Then
            Habilitar_Botones(False)
            wFila = 1
            xTabla.Redraw = False
            tBarraProgreso.Value = 0
            Cursor = Cursors.WaitCursor
            tBarraProgreso.Maximum = wDocPs.Rows.Count
            tMensajeBarra.Text = "Cargando Pagos, por favor espere..."
            DoEvents()

            For Each wDocP As DataRow In wDocPs.Rows
                DoEvents()
                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, wDocP.GetText("Local"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_DOCUMENTO, wDocP.GetText("DescTipoDoc"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_NUMERO, wDocP.GetText("Numero"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_CLIENTE, wDocP.GetText("Nombre"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_FECHAEMI, CDate(Mid(wDocP.GetText("Fecha"), 1, 10)))

                wTotal += Val(wDocP.GetText("Monto")) * If(wDocP.GetText("TipoDoc") = "NC", -1, 1)

                xTabla.SetData(xTabla.Rows.Count - 1, T_MONTO, Val(wDocP.GetText("Monto")) * If(wDocP.GetText("TipoDoc") = "NC", -1, 1))
                xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGO, wDocP.GetText("DescFPago"))

                xTabla.SetData(xTabla.Rows.Count - 1, T_FECHAVEN, CDate(Mid(wDocP.GetText("FechaPago"), 1, 10)))
                If CDate(Mid(wDocP.GetText("FechaCanc"), 1, 10)) <> CDate("01/01/2000") Then
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FECHACAN, CDate(wDocP.GetText("FechaCanc")))
                End If

                xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, wDocP.GetText("DescEstado"))

                xTabla.SetData(xTabla.Rows.Count - 1, T_OBSER, wDocP.GetText("Obs"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_CHEQUE, wDocP.GetText("NumeroPago"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_CUENTA, wDocP.GetText("Cuenta"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_BANCO, wDocP.GetText("DescBanco"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_TITULAR, wDocP.GetText("Titular"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_ID, wDocP.GetText("ID"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_MODIF, 0)

                If CDate(wDocP.GetText("FechaPago")) <= Now.Date Then
                    xTabla.FondoCelda(xTabla.Rows.Count - 1, C_AMARILLO_CELDA)
                End If
                tBarraProgreso.Value += 1
                DoEvents()
            Next

            xTabla.Redraw = True
            xNeto.Text = FormatNumber(wTotal / (1 + (G_IVA / 100)), 0)
            If xNeto.Text.Trim = "" Then xNeto.Text = "0"
            xIva.Text = FormatNumber(wTotal - CDbl(xNeto.Text), 0)
            xTotal.Text = FormatNumber(wTotal, 0)
            xRegistro.Text = (xTabla.Rows.Count - 1).ToString
            Habilitar_Botones(True)
            tMensajeBarra.Text = "Listo"
        Else
            'tMensajeBarra.Text = "No se encuentran datos con los filtros ingresados"
            MsgError("No se encuentran datos con el filtro ingresado")
        End If
        Cursor = Cursors.Arrow
        tBarraProgreso.Visible = False
        xTabla.Focus()
    End Sub

    Private Sub xTabla_Click(sender As Object, e As EventArgs) Handles xTabla.Click
        If xTabla.Rows.Count > 1 AndAlso xTabla.Row > 0 Then

            If xTabla.Col = T_OK Then
                Dim wCheck = Not CBool((xTabla.GetData(xTabla.Row, T_OK)))
                xTabla.SetData(xTabla.Row, T_OK, wCheck)
            ElseIf xTabla.Col = T_ESTADO Then
                xTabla.StartEditing(xTabla.Row, T_ESTADO)
            ElseIf xTabla.Col = T_FECHACAN Then
                Dim wEst = SQL("SELECT Estado From Estados" &
                               " WHERE DescEstado = '" & xTabla.GetData(xTabla.Row, T_ESTADO).ToString & "' and Tipo='P'").Top
                If wEst IsNot Nothing Then
                    If wEst.GetText("Estado") = "C" Then xTabla.StartEditing(xTabla.Row, T_FECHACAN)
                End If
            ElseIf xTabla.Col = T_ESTADO Then
                xTabla.StartEditing(xTabla.Row, T_ESTADO)
            ElseIf xTabla.Col = T_FPAGO Then
                xTabla.StartEditing(xTabla.Row, T_FPAGO)
            ElseIf xTabla.Col = T_OBSER Then
                xTabla.StartEditing(xTabla.Row, T_OBSER)
            ElseIf xTabla.Col = T_CHEQUE Then
                xTabla.StartEditing(xTabla.Row, T_CHEQUE)
            ElseIf xTabla.Col = T_BANCO Then
                xTabla.StartEditing(xTabla.Row, T_BANCO)
            ElseIf xTabla.Col = T_TITULAR Then
                xTabla.StartEditing(xTabla.Row, T_TITULAR)
            ElseIf xTabla.Col = T_CUENTA Then
                xTabla.StartEditing(xTabla.Row, T_CUENTA)
            End If
        End If

        Dim Total As New Integer
        Dim Cont As New Integer

        For wFila As Integer = 1 To xTabla.Rows.Count - 1
            If CBool(xTabla.GetData(wFila, 0)) = True Then
                Total += CInt(xTabla.GetData(wFila, T_MONTO))
                Cont += 1
            End If
        Next

        xTotalSeleccionado.Text = FormatNumber(Total, 0)
        xCantSeleccionado.Text = Cont.ToString

    End Sub

    Private Sub cTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cTipoDoc.SelectedIndexChanged
        If cTipoDoc.Text <> W_SELECCIONAR Then
            xNumero.Focus()
        End If
    End Sub
    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim ConError As Integer = 2

        If xTabla.Rows.Count - 1 > 0 Then
            If Pregunta("¿Desea guardar cambios en pagos?") Then
                Habilitar_Botones(False)
                tMensajeBarra.Text = "Guardando Pagos, espere por favor..."
                tBarraProgreso.Maximum = xTabla.Rows.Count - 1
                tBarraProgreso.Value = 0
                Cursor = Cursors.WaitCursor
                For Each wRow As Row In xTabla.Rows
                    If wRow.Index = 0 Then Continue For

                    If Val(wRow.Item(T_MODIF)) = 1 Then
                        ConError = 0
                        Dim DC = New RebuscoDataContext(P_CONEXION)
                        Dim wDocP = DC.T_DocumentosP.FirstOrDefault(Function(x) x.ID = Val(wRow.Item(T_ID)))
                        If wDocP IsNot Nothing Then
                            wDocP.Fecha = CDate(wRow.Item(T_FECHAEMI))

                            Dim wEst = DC.T_Estados.FirstOrDefault(Function(x) x.DescEstado = wRow.Item(T_ESTADO).ToString And x.Tipo = "P")
                            If Not IsDate(wRow.Item(T_FECHACAN)) Then
                                If wRow.Item(T_OBSER).ToString.Trim <> "" Then
                                    wDocP.Obs = wRow.Item(T_OBSER).ToString
                                    wDocP.Usuario = UsuarioActual
                                    DC.SubmitChanges()
                                Else
                                    MsgError("Falta Fecha de Cancelación: " & vbCrLf & wRow.Item(T_DOCUMENTO).ToString & " " & wRow.Item(T_NUMERO).ToString)
                                    ConError = 1
                                    Exit For
                                End If
                            Else
                                If wEst IsNot Nothing AndAlso wEst.Estado = "C" Then
                                    wDocP.FechaCanc = CDate(wRow.Item(T_FECHACAN))
                                End If
                                wDocP.FPago = DC.T_FPagos.FirstOrDefault(Function(x) x.DescFPago = wRow.Item(T_FPAGO).ToString).FPago.ToString
                                wDocP.Estado = DC.T_Estados.FirstOrDefault(Function(x) x.DescEstado = wRow.Item(T_ESTADO).ToString And x.Tipo = "P").Estado.ToString
                                wDocP.Obs = wRow.Item(T_OBSER).ToString
                                wDocP.NumeroPago = wRow.Item(T_CHEQUE).ToString
                                wDocP.Cuenta = wRow.Item(T_CUENTA).ToString
                                wDocP.Banco = DC.T_Bancos.FirstOrDefault(Function(x) x.DescBanco = wRow.Item(T_BANCO).ToString).Banco
                                wDocP.Titular = wRow.Item(T_TITULAR).ToString
                                wDocP.Usuario = UsuarioActual
                                DC.SubmitChanges()
                            End If
                            tBarraProgreso.Value += 1
                        End If
                    End If
                Next
                Habilitar_Botones(True)

                If ConError = 0 Then
                    Mensaje("Pagos actualizados correctamente")
                End If
                If ConError = 1 Then
                    Mensaje("Actualización de pagos incompleta")
                End If
                If ConError = 2 Then
                    Mensaje("No habían pagos marcados para actualizar")
                End If

                Auditoria(Me.Text, A_MODIFICADO, cTipoDoc.Text.Trim, cLocal.Text.Trim)
                Mostrar_Datos()
                Cursor = Cursors.Arrow
            End If
        Else
            MsgError("No hay datos ingresados para modificar")
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        Titulos()
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
    End Sub

    Private Sub bListado_Click(sender As Object, e As EventArgs) Handles bListado.Click
        Dim wReporte As New ReportePagos
        Dim wFiltro As String = " (1=1) "
        Cursor = Cursors.WaitCursor
        'wQuery = "SELECT Td.DescTipoDoc,Dp.Numero,Cl.Rut,Cl.Nombre,Dp.Monto, Fp.DescFPago, Es.DescEstado, Dp.FechaCanc, Dp.Obs  FROM DocumentosP Dp" &
        '         " JOIN TipoDoc Td ON DP.TipoDoc = Td.TipoDoc" &
        '         " JOIN Clientes Cl ON Dp.CLiente = Cl.CLiente" &
        '         " JOIN FPagos Fp ON Dp.FPago = Fp.FPago" &
        '         " JOIN Estados Es ON Dp.Estado = Es.Estado and Es.Tipo = 'P' " &
        '         " WHERE Dp.FechaCanc BETWEEN '" & dDesde.Value & "' AND '" & dHasta.Value & "'"


        If xCliente.Text <> "" Then wFiltro &= " AND " & " C.Cliente   = '" & xCliente.Text.Trim & "'"
        If cTipoDoc.Text <> "" Then wFiltro &= " AND " & " T.TipoDoc   = '" & cTipoDoc.SelectedValue.ToString & "'"
        If xNumero.Text <> "" Then wFiltro &= " AND " & " DP.Numero   = '" & xNumero.Text.Trim & "'"
        If cFormaPago.Text <> "" Then wFiltro &= " AND " & " F.FPago   = '" & cFormaPago.SelectedValue.ToString & "'"
        If cEstado.Text <> "" Then wFiltro &= " AND " & " E.Estado   = '" & cEstado.SelectedValue.ToString & "'"
        If xVendedor.Text <> "" Then wFiltro &= " AND " & " DP.Vendedor   = '" & xVendedor.Text.Trim & "'"

        wFiltro &= " AND Fecha BETWEEN '" & dDesde.Value & "' AND '" & dHasta.Value & "'"

        Dim wDocPs = SQL("SELECT DP.*,T.DescTipoDoc,C.Nombre, F.DescFPago, B.DescBanco, E.DescEstado, C.Rut" &
                         " FROM DocumentosP  DP" &
                         " JOIN TipoDoc T ON DP.TipoDoc = T.TipoDoc" &
                         " JOIN Clientes C ON DP.Cliente = C.Cliente" &
                         " JOIN FPagos F ON DP.FPago = F.FPago" &
                         " JOIN Estados E ON DP.Estado = E.Estado And E.Tipo = 'P'" &
                         " JOIN Bancos B ON DP.Banco = B.Banco" &
                         " WHERE " & wFiltro & " ORDER BY DP.Local,DP.TipoDoc,DP.Numero")

        Habilitar_Botones(False)
        Dim lista = New List(Of PagosReporte)
        'Dim wDocPs = SQL(wQuery)
        For Each wDocP As DataRow In wDocPs.Rows
            lista.Add(New PagosReporte With {.TipoDoc = wDocP.GetText("DescTipoDoc"),
                                            .Numero = Val(wDocP.GetText("Numero")),
                                            .Rut = wDocP.GetText("Rut"),
                                            .NombreCliente = wDocP.GetText("Nombre"),
                                            .Monto = Val(wDocP.GetText("Monto")) * If(wDocP.GetText("TipoDoc") = "NC", -1, 1), ' Val(wDocP.GetText("Monto")),
                                            .FPago = wDocP.GetText("DescFPago"),
                                            .Estado = wDocP.GetText("DescEstado"),
                                            .FechaCanc = CDate(wDocP.GetText("FechaCanc")),
                                            .Obs = wDocP.GetText("Obs")})
        Next

        Dim wParametros = ParametroReporte()
        If lista.Count > 0 Then
            wReporte.Database.Tables(0).SetDataSource(lista)
            wReporte.Database.Tables(1).SetDataSource(wParametros)
            wReporte.SetParameterValue("Desde", dDesde.Value)
            wReporte.SetParameterValue("Hasta", dHasta.Value)
            VisorReportes.MostrarReporte(wReporte)
            VisorReportes.WinDeco1.TituloVentana = "Reporte de Pagos"
            VisorReportes.Show()
            VisorReportes.BringToFront()
            Habilitar_Botones(True)
        Else
            MsgError("No se encuentran datos para la selección indicada")
            Close()
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub ComboGrilla_SelectedIndexChanged(sender As Object, e As EventArgs)
        If xTabla.Row > 0 And xTabla.Rows.Count > 0 Then
            If cEst.SelectedIndex <> -1 Then
                Dim wEst = SQL("SELECT Estado From Estados" &
                               " WHERE DescEstado = '" & xTabla.GetData(xTabla.Row, T_ESTADO).ToString & "' and Tipo='P'").Top

                If wEst IsNot Nothing AndAlso wEst.GetText("Estado") <> "C" Then
                    xTabla.SetData(xTabla.Row, T_FECHACAN, "")
                Else
                    xTabla.SetData(xTabla.Row, T_FECHACAN, Now.ToShortDateString)
                End If
            End If
        End If
    End Sub

    Private Sub Habilitar_Botones(qOpcion As Boolean)
        If qOpcion Then
            Cursor = Cursors.Arrow
        Else
            Cursor = Cursors.WaitCursor
        End If
        bDeudas.Enabled = qOpcion
        bConsultaMes.Enabled = qOpcion
        bListado.Enabled = qOpcion
        bMostrar.Enabled = qOpcion
        bGuardar.Enabled = qOpcion
    End Sub
    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub xTabla_KeyPressEdit(sender As Object, e As KeyPressEditEventArgs) Handles xTabla.KeyPressEdit

    End Sub

    Private Sub xTabla_StartEdit(sender As Object, e As RowColEventArgs) Handles xTabla.StartEdit
        'Marcar que la celda fue modificada para porteriormente solo procesar las modificadas
        xTabla.SetData(xTabla.Row, T_MODIF, 1)
    End Sub

    Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs) Handles xTabla.DoubleClick
        Dim wTipoDoc As String
        If xTabla.Col = T_NUMERO Or xTabla.Col = T_CLIENTE Or xTabla.Col = T_DOCUMENTO Then
            Dim DC = New RebuscoDataContext(P_CONEXION)
            wTipoDoc = DC.T_TipoDoc.FirstOrDefault(Function(x) x.DescTipoDoc = xTabla.GetData(xTabla.Row, T_DOCUMENTO).ToString).TipoDoc
            If Not Abrir_Documento(DTE.Ruta_Archivo_Fiscal(gPDF, Val(xTabla.GetData(xTabla.Row, T_LOCAL).ToString), wTipoDoc, Val(xTabla.GetData(xTabla.Row, T_NUMERO).ToString), 0)) Then
                If Pregunta("¿Desea generar nuevamente el documento?") Then
                    G_TIPOCOPIA = {1, 2, 3}.ToList
                    Imprimir_Documento(Val(xTabla.GetData(xTabla.Row, T_LOCAL).ToString), wTipoDoc, Val(xTabla.GetData(xTabla.Row, T_NUMERO)), xTabla.GetData(xTabla.Row, T_DOCUMENTO).ToString, G_TIPOCOPIA)
                End If
            End If
        End If
    End Sub
    Private Sub bCopiar_Click(sender As Object, e As EventArgs) Handles bCopiar.Click
        Dim CopyPaste As String = ""
        'xTabla.ClipboardCopyMode = ClipboardCopyModeEnum.DataAndAllHeaders
        'xTabla.Copy()
        Try
            For Fil = 0 To xTabla.Rows.Count
                For Col = T_OK To T_TITULAR
                    CopyPaste = CopyPaste + CStr(xTabla.GetData(Fil, Col)) + vbTab
                    DoEvents()
                Next Col
                CopyPaste = CopyPaste + vbNewLine
            Next Fil
        Catch ex As Exception
        End Try


        Clipboard.Clear()
        Clipboard.SetText(CopyPaste)
        Mensaje("Datos Copiados")
    End Sub

    Private Sub bDirectorio_Click(sender As Object, e As EventArgs) Handles bDirectorio.Click
        Abrir_Documento(Directorio_PDF)
    End Sub

    Private Sub cFormaPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cFormaPago.KeyPress
        e.NextControl(cEstado)
    End Sub

    Private Sub ControlPagos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Titulos()
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", "WHERE Pagos = 1")
        cFormaPago.LoadItemsObj("FPagos", "FPago", "DescFPago")
        cEstado.LoadItemsObj("Estados", "Estado", "DescEstado", " WHERE Tipo = 'P'")

        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")


        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
        xNeto.Text = "0"
        xIva.Text = "0"
        xTotal.Text = "0"
        xCantSeleccionado.Text = "0"
        xTotalSeleccionado.Text = "0"
        Auditoria(Me.Text, A_GUARDADO, "", "0")
        tBarraProgreso.Visible = False
        tMensajeBarra.Text = "Listo"
    End Sub

    Private Sub bBuscarV_Click(sender As Object, e As EventArgs) Handles bBuscarV.Click
        Dim wQuery As String
        wQuery = "SELECT Usuario , NombreUsr as 'Nombre Usuario' From Usuarios"
        Buscador.Show()
        Buscador.Configurar(wQuery, "NombreUsr", Me, "Vendedores", xVendedor)
    End Sub

    Private Sub xVendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles xVendedor.KeyDown
        If e.KeyCode = Keys.F3 Then
            bBuscarV_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub xCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles xCliente.KeyDown
        If e.KeyCode = Keys.F3 Then
            bBuscarA_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub sBarra_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles sBarra.ItemClicked

    End Sub

    Private Sub xCliente_TextChanged(sender As Object, e As EventArgs) Handles xCliente.TextChanged

    End Sub

    Private Sub xTabla_MouseUp(sender As Object, e As MouseEventArgs) Handles xTabla.MouseUp

    End Sub
End Class