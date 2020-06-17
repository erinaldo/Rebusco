Imports C1.Win.C1FlexGrid

Public Class VentaSucursal
    Const T_ELIMINAR = 0
    Const T_ARTICULO = 1
    Const T_DESCRIPCION = 2
    Const T_BARRA = 3
    Const T_CANTIDAD = 4
    Const T_PRECIO = 5
    Const T_TOTAL = 6

    Dim wVisor As New VisorReportes
    Dim wArrayArticulo As List(Of String)
    Dim wSumarAbono As Double
    Dim wUltimoArticulo As String = ""
    Dim wTipoDocumento As String = ""
    Dim wPrimeraPalabraDocumento() As String
    Sub Titulos()
        xTabla.Clear()
        xTabla.Cols.Count = 7
        xTabla.Rows.Count = 1

        xTabla.Cols(T_ELIMINAR).Width = 100
        xTabla.Cols(T_ARTICULO).Width = 100
        xTabla.Cols(T_DESCRIPCION).Width = 100
        xTabla.Cols(T_BARRA).Width = 100
        xTabla.Cols(T_CANTIDAD).Width = 100
        xTabla.Cols(T_PRECIO).Width = 100
        xTabla.Cols(T_TOTAL).Width = 100

        xTabla.Cols(T_ELIMINAR).Caption = " "
        xTabla.Cols(T_ARTICULO).Caption = "Artículo"
        xTabla.Cols(T_DESCRIPCION).Caption = "Descripción"
        xTabla.Cols(T_BARRA).Caption = "Barra"
        xTabla.Cols(T_CANTIDAD).Caption = "Cantidad"
        xTabla.Cols(T_PRECIO).Caption = "Precio"
        xTabla.Cols(T_TOTAL).Caption = "Total"
        xTabla.AjustarColumnas
    End Sub

    Private Sub VentaSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                cFormaPago.Focus()
            Case Keys.F2
                xArticulo.Focus()
            Case Keys.F3
                cDocumento.Focus()
            Case Keys.F4
                bLimpiar_Click(Nothing, Nothing)
            Case Keys.F5
                RepiteArticulo()
            Case Keys.F6
                EliminarArticulo()
            Case Keys.F7
                xDescuento.Text = "0"
                xAbono.Text = CDbl(xTotal.Text).ToString
            Case Keys.F8
                bBuscar_Click(Nothing, Nothing)
            Case Keys.F9
                xAbono.Focus()
            Case Keys.F10
                bEmitir_Click(Nothing, Nothing)
            Case Keys.F11
                If Pregunta("¿Desea Salir del Módulo?") Then
                    Close()
                    Principal.BringToFront()
                End If
            Case Else

        End Select
    End Sub
    Sub RepiteArticulo()
        Dim wIndice As Integer = xTabla.Rows.Count - 1
        If wIndice = 0 Then
            MsgError("No hay artículos agregados en la Tabla")
            Exit Sub
        End If
        xArticulo.Text = wUltimoArticulo
        xArticulo_Validating(Nothing, Nothing)
        xCantidad.Focus()
    End Sub

    Sub EliminarArticulo()
        Dim wFila As Integer
        If xTabla.Rows.Count - 1 = 0 Then
            MsgError("No hay artículos agregados en la Tabla")
            Exit Sub
        End If
        wFila = xTabla.Rows.Count - 1
        xTabla.RemoveItem(wFila)
        ObtenerTotales(False)
    End Sub

    Function ObtenerCorrelativo(ByVal wTipoDoc As String, Optional wCambiar As Boolean = False) As Double
        wTipoDoc = If(wTipoDocumento = "", "B", wTipoDocumento)
        Dim wCorrelativo As Double
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim gCor = DC.T_Correlativos.FirstOrDefault(Function(x) x.Local = LocalActual And
                                                         x.TipoDoc = wTipoDoc And
                                                         x.POS = G_POS)


        If gCor Is Nothing Then
            Dim wCor As New T_Correlativos
            wCor.Local = LocalActual
            wCor.POS = CInt(G_POS)
            wCor.TipoDoc = wTipoDoc
            wCor.Correlativo = 1
            DC.T_Correlativos.InsertOnSubmit(wCor)
            DC.SubmitChanges()
            Return 1
        End If

        wCorrelativo = gCor.Correlativo

        If wCambiar Then
            gCor.Correlativo = gCor.Correlativo + 1
            DC.SubmitChanges()
        End If
        Return wCorrelativo
    End Function

    Sub CargarVendedor()
        Dim wUsr = SQL("SELECT NombreUsr FROM Usuarios WHERE Usuario='" & Trim(UsuarioActual) & "'").Top
        If wUsr Is Nothing Then
            MsgError("El Vendedor ingresado no es válido" & vbCrLf & "Favor de cambiar vendedor")
            Close()
        End If
        xVendedor.Text = wUsr.GetText("NombreUsr")
    End Sub

    Public Sub xArticulo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xArticulo.Validating
        If Trim(xArticulo.Text) = "" Then Exit Sub
        xArticulo.Text = ObtenerArticulo(xArticulo.Text)
        Dim wArt = SQL("SELECT Descripcion FROM Articulos WHERE Articulo='" & Trim(xArticulo.Text) & "'").Top
        If wArt Is Nothing Then
            MsgError("Artículo ingresado no existe")
            xArticulo.Clear()
            xDescripcion.Clear()
            xArticulo.Focus()
            Exit Sub
        End If
        xDescripcion.Text = wArt.GetText("Descripcion")
        xCantidad.Text = "1"
        xCantidad.Focus()
    End Sub

    Private Sub xCantidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xCantidad.Validating
        ValidarDigitos(CType(sender, KeyPressEventArgs))
    End Sub

    Sub AgregarATabla()
        Dim wFila As Integer
        Dim wCantidad, wTotal, wPrecio As Double
        Dim wBarra As String = ""

        wFila = xTabla.FindRow(xArticulo.Text, 1, T_ARTICULO, False)
        If wFila > 0 Then
            wCantidad = Val(xTabla.GetData(wFila, T_CANTIDAD).ToString) + Val(xCantidad.Text)
            wPrecio = Val(xTabla.GetData(wFila, T_PRECIO).ToString)
            wBarra = xTabla.GetData(wFila, T_BARRA).ToString
            wTotal = wCantidad * wPrecio
            xTabla.RemoveItem(wFila)
        Else
            Dim wArt = SQL("SELECT a.Descripcion,Coalesce(b.Barra,'') as Barra,a.PVenta,a.Estado " &
                      " FROM Articulos a " &
                      " LEFT JOIN Barras b on a.Articulo=b.Articulo " &
                      " WHERE A.Articulo='" & Trim(xArticulo.Text) & "'").Top

            If wArt Is Nothing Then
                MsgError("El Artículo ingresado no existe")
                Exit Sub
            End If

            If wArt.GetText("Estado") = "X" Then
                MsgError("El Artículo ingresado está bloqueado")
                Exit Sub
            End If

            If wArt.GetNum("PVenta") <= 0 Then
                MsgError("No se pueden agregar artículos con Precio de Venta menor o igual a 0")
                Exit Sub
            End If

            wPrecio = wArt.GetNum("PVenta")
            wCantidad = Val(xCantidad.Text)
            wTotal = wCantidad * wPrecio
            wBarra = wArt.GetText("Barra")
        End If
        wFila = xTabla.Rows.Count

        xTabla.AddItem("")
        xTabla.SetCellImage(wFila, T_ELIMINAR, My.Resources.delete)
        xTabla.SetData(wFila, T_ARTICULO, Trim(xArticulo.Text))
        xTabla.SetData(wFila, T_DESCRIPCION, Trim(xDescripcion.Text))
        xTabla.SetData(wFila, T_BARRA, wBarra)
        xTabla.SetData(wFila, T_CANTIDAD, wCantidad)
        xTabla.SetData(wFila, T_PRECIO, wPrecio)
        xTabla.SetData(wFila, T_TOTAL, wTotal)

        wUltimoArticulo = Trim(xArticulo.Text)
        ObtenerTotales(False)
        xTabla.AjustarColumnas
    End Sub
    Sub ObtenerTotales(ByVal wValidaTabla As Boolean)
        Dim wTotal, wSaldo, wSubTotal, wCantidad, wPrecio As Double
        If xTotal.Text = "" Then xTotal.Text = "0"
        If xSubTotal.Text = "" Then xSubTotal.Text = "0"
        If xAbono.Text = "" Then xAbono.Text = "0"
        If xDescuento.Text = "" Then xDescuento.Text = "0"
        If xAbonado.Text = "" Then xAbonado.Text = "0"
        If xSaldo.Text = "" Then xSaldo.Text = "0"

        For i = 1 To xTabla.Rows.Count - 1
            If wValidaTabla Then
                wCantidad = Val(xTabla.GetData(i, T_CANTIDAD).ToString)
                wPrecio = Val(xTabla.GetData(i, T_PRECIO).ToString)
                xTabla.SetData(i, T_TOTAL, wCantidad * wPrecio)
            End If
            wTotal += Val(xTabla.GetData(i, T_TOTAL).ToString)
        Next

        xTotal.Text = IIf(wTotal = 0, 0, Format(wTotal, "###,###")).ToString
        xAbonado.Text = IIf(wSumarAbono = 0, 0, Format(wSumarAbono, "###,###")).ToString
        wSubTotal = wTotal - CDbl(xAbonado.Text) - Val(xDescuento.Text)
        xSubTotal.Text = IIf(wSubTotal = 0, 0, Format(wSubTotal, "###,###")).ToString
        xAbono.Text = IIf(wSubTotal = 0, 0, Format(wSubTotal, "###,###")).ToString

        wSaldo = Val(xSubTotal.Text) - Val(xAbono.Text)
        xSaldo.Text = IIf(wSaldo = 0, 0, Format(wSaldo, "###,###")).ToString
        xCantidadTabla.Text = (xTabla.Rows.Count - 1).ToString
    End Sub

    Private Sub xCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCantidad.KeyPress
        If e.KeyChar = ChrW(13) Then
            If Val(xCantidad.Text) <= 0 Then
                MsgError("La Cantidad no puede ser 0")
                xCantidad.Focus()
                Exit Sub
            End If
            If Trim(xArticulo.Text) = "" Or Trim(xDescripcion.Text) = "" Then
                MsgError("Falta ingresar un Artículo")
                xArticulo.Focus()
                Exit Sub
            End If
            AgregarATabla()
            xArticulo.Clear()
            xDescripcion.Clear()
            xCantidad.Text = "1"
            xArticulo.Focus()
        End If
    End Sub

    Private Sub xDescuento_TextChanged(sender As Object, e As EventArgs) Handles xDescuento.TextChanged
        ValidarDigitos(sender)
        If Val(xDescuento.Text) <= -1 Or xTabla.Rows.Count - 1 = 0 Then Exit Sub
        ObtenerTotales(False)
    End Sub

    Private Sub xDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescuento.KeyPress
        ValidarDigitos(e)
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.NextControl(CType(sender, Control))
        End If
    End Sub

    Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs) Handles xTabla.DoubleClick
        If xTabla.Rows.Count - 1 = 0 Then Exit Sub
        If xTabla.ColSel = T_CANTIDAD Then
            xTabla.StartEditing()
        End If

        If xTabla.ColSel = T_ELIMINAR Then
            If Pregunta("¿Desea quitar este Artículo de la Tabla?") Then
                xTabla.RemoveItem(xTabla.RowSel)
                ObtenerTotales(False)
            End If
        End If
    End Sub

    Private Sub xTabla_AfterEdit(sender As Object, e As RowColEventArgs) Handles xTabla.AfterEdit
        xTabla.AjustarColumnas
    End Sub

    Private Sub xTabla_ValidateEdit(sender As Object, e As ValidateEditEventArgs) Handles xTabla.ValidateEdit
        If xTabla.Rows.Count - 1 = 0 Then Exit Sub
        Dim wValorAnterior = xTabla.GetData(xTabla.RowSel, T_CANTIDAD).ToString

        If xTabla.ColSel = T_CANTIDAD Then
            Dim wCantidad = xTabla.Editor.Text '
            If Not IsNumeric(wCantidad) Then
                MsgError("El dato ingresado debe ser numérico")
                xTabla.Editor.Text = wValorAnterior
                Exit Sub
            Else
                If Val(wCantidad) = 0 Then
                    MsgError("No puedes ingresar cantidad 0")
                    xTabla.Editor.Text = wValorAnterior
                    Exit Sub
                End If
                xTabla.SetData(xTabla.RowSel, T_CANTIDAD, wCantidad)
                ObtenerTotales(True)
            End If
        End If
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        'Modulo = "VentaSucursal"
        'BuscarArticulos.ShowDialog()
    End Sub

    Private Sub bCargar_Click(sender As Object, e As EventArgs) Handles bCargar.Click
        Dim wTicket As String = ""

        While Not IsNumeric(wTicket)
            InputPersonalizado.Inputbox("Ingrese el N° de Ticket a Cargar", "Cargar Ticket", "", Me.Icon)
            If InputPersonalizado.Response = MsgBoxResult.Cancel Then
                wTicket = ""
                Exit Sub
            Else
                wTicket = InputPersonalizado.RetornoTexto
            End If
            If wTicket.Trim = "" Then
                MsgError("El Campo Ticket no puede estar vacío ")
                Continue While
            Else
                If Not IsNumeric(wTicket) Then
                    MsgError("El Dato ingresado debe ser numérico")
                    Continue While
                End If
            End If
        End While
        CargarTicket(CInt(wTicket))
    End Sub

    Sub CargarTicket(ByVal wTicket As Integer)
        Dim Tkg = SQL("SELECT * FROM TikGen WHERE Ticket=" & wTicket & "").Top
        If Tkg Is Nothing Then
            MsgError("El Ticket ingresado no Existe")
            Exit Sub
        End If
        Dim wTkds = SQL("SELECT t.Articulo,a.Descripcion,t.Barra,t.Cantidad,t.PVenta, (t.Cantidad*t.PVenta) as Total " &
                  " FROM TikDet t INNER JOIN Articulos a on t.Articulo=a.Articulo " &
                  " WHERE Ticket=" & wTicket & "")
        If wTkds.Rows.Count = 0 Then
            MsgError("Ticket sin Arttículos asociados")
            Exit Sub
        End If

        Titulos()
        xArticulo.Clear()
        xDescripcion.Clear()
        xCantidad.Text = "1"
        xArticulo.Focus()
        BloquearBotones(False)
        For Each wTkd As DataRow In wTkds.Rows
            DoEvents()
            xTabla.AddItem("")
            xTabla.SetCellImage(xTabla.Rows.Count - 1, T_ELIMINAR, My.Resources.delete)
            xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, wTkd.GetText("Articulo"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wTkd.GetText("Descripcion"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_BARRA, wTkd.GetText("Barra"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDAD, wTkd.GetText("Cantidad"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_PRECIO, wTkd.GetText("PVenta"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, wTkd.GetText("Total"))
        Next
        xTabla.AjustarColumnas
        ObtenerTotales(False)
        BloquearBotones(True)
    End Sub

    Sub BloquearBotones(ByVal wEstado As Boolean)
        bCargar.Enabled = wEstado
        bimprimir.Enabled = wEstado
        bBuscar.Enabled = wEstado
        bEmitir.Enabled = wEstado
        bLimpiar.Enabled = wEstado
        bCambiarCorrelativo.Enabled = wEstado
        bConsultaBoleta.Enabled = wEstado
        bCuadraturaCaja.Enabled = wEstado
        bVentaEspecial.Enabled = wEstado
        Me.KeyPreview = wEstado
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos()
    End Sub

    Sub LimpiarCampos()
        BloquearBotones(True)
        xArticulo.Clear()
        xDescripcion.Clear()
        xCantidad.Text = "1"
        Titulos()
        xCantidadTabla.Text = "0"
        xTotal.Text = "0"
        xAbonado.Text = "0"
        xDescuento.Text = "0"
        xSubTotal.Text = "0"
        xAbono.Text = "0"
        xSaldo.Text = "0"
        cDocumento.SelectedIndex = 0
        xBoleta.Text = ObtenerCorrelativo(wTipoDocumento).ToString
        xArticulo.Focus()
    End Sub

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click
        Dim wTicket As String = ""
        While wTicket = "" Or Val(wTicket) = 0
            InputPersonalizado.Inputbox("Ingrese un Ticket a Re Imprimir", "Ticket a Re Imprimir", "", Me.Icon, True)
            If InputPersonalizado.Response = MsgBoxResult.Cancel Then
                wTicket = ""
                Exit Sub
            Else
                wTicket = InputPersonalizado.RetornoTexto
            End If
            If wTicket.Trim = "" Then
                Continue While
            Else
                If Not IsNumeric(wTicket) Then
                    MsgError("El Dato ingresado debe ser numérico")
                    Continue While
                End If
            End If
        End While


        Dim wReporte As New ReporteVale

        Dim wLista = New List(Of ValeReporte)
        Dim wTikGs = SQL("SELECT tg.Ticket,tg.Fecha,u.NombreUsr,td.Articulo,td.Cantidad," &
                   " td.PVenta,a.Descripcion,(td.Cantidad*td.PVenta) as Total " &
                   " FROM TikGen tg " &
                   " INNER JOIN TikDet td on tg.Ticket=td.Ticket " &
                   " INNER JOIN Articulos a on td.Articulo=a.Articulo " &
                   " INNER JOIN Usuarios u on tg.Usuario=u.Usuario " &
                   " WHERE td.Ticket=" & wTicket)

        For Each wTikG As DataRow In wTikGs.Rows
            wLista.Add(New ValeReporte With {.Ticket = wTikG.GetInt("Ticket"),
                                              .Fecha = wTikG.GetDate("Fecha"),
                                              .NombreUsr = wTikG.GetText("NombreUsr"),
                                              .Articulo = wTikG.GetText("Articulo"),
                                              .Cantidad = wTikG.GetInt("Cantidad"),
                                              .PVenta = wTikG.GetInt("PVenta"),
                                              .Descripcion = wTikG.GetText("Descripcion"),
                                              .Total = wTikG.GetInt("Total")})
        Next

        If wLista.Count > 0 Then
            wReporte.Database.Tables(0).SetDataSource(wLista)
            wReporte.PrintToPrinter(1, False, 0, 0)
        Else
            Mensaje("No hay datos para imprimir")
        End If


    End Sub

    Private Sub bEmitir_Click(sender As Object, e As EventArgs) Handles bEmitir.Click
        If xTabla.Rows.Count - 1 = 0 Then
            MsgError("No hay artículos agregados en la Tabla")
            xArticulo.Focus()
            Exit Sub
        End If

        If Not ValidarVenta() Then
            Exit Sub
        End If

        If xTotal.Text = "" Then xTotal.Text = "0"
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wTick As New T_TikGen
        wTick.Fecha = Now
        wTick.Local = LocalActual
        wTick.Usuario = UsuarioActual
        wTick.Total = CInt(Val(xTotal.Text))
        wTick.Estado = CChar("E")
        DC.T_TikGen.InsertOnSubmit(wTick)
        DC.SubmitChanges()
        Dim wTicket = wTick.Ticket

        For Each wRow As C1.Win.C1FlexGrid.Row In xTabla.Rows
            If wRow.Index = 0 Then Continue For
            Dim wTkD As New T_TikDet
            wTkD.Ticket = wTicket
            wTkD.Articulo = wRow.Item(T_ARTICULO).ToString.ToDecimal
            wTkD.Barra = wRow.Item(T_BARRA).ToString
            wTkD.Cantidad = Val(wRow.Item(T_CANTIDAD).ToString)
            wTkD.PVenta = Val(wRow.Item(T_PRECIO).ToString)
            DC.T_TikDet.InsertOnSubmit(wTkD)
        Next
        Realizar_Venta(True, CStr(wTicket))
        Auditoria(Me.Text, A_IMPRESO, "", "0")
    End Sub

    Sub Realizar_Venta(ByVal wVentaNormal As Boolean, ByVal wTicket As String)
        Dim wCorrelativo As Decimal
        If Val(wTicket) = 0 Then
            MsgError("Error al generar boleta")
            Exit Sub
        End If

        If wVentaNormal Then
            If Not Pregunta("¿Desea Emitir " & Trim(cDocumento.Text) & " ?") Then
                Exit Sub
            End If
        Else
            If Not Pregunta("¿Desea Emitir Venta Sin Boleta?") Then
                Exit Sub
            End If
        End If

        If wVentaNormal Then
            wCorrelativo = CInt(ObtenerCorrelativo(wTipoDocumento, True))
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim wTickG = DC.T_TikGen.FirstOrDefault(Function(x) x.Ticket = CInt(Val(wTicket)))
        If wTickG Is Nothing Then
            MsgError("Error al generar la Venta")
            Exit Sub
        End If

        wTickG.Estado = CChar("V")
        If Val(xTotal.Text) = Val(xAbono.Text) Then
            wTickG.Credito = False
        Else
            wTickG.Credito = True
        End If
        DC.SubmitChanges()

        Dim wVen As New T_Ventas

        wVen.Ticket = CInt(wTicket)
        wVen.Fecha = Now
        wVen.Usuario = UsuarioActual
        wVen.Local = LocalActual
        wVen.Caja = CInt(G_POS)
        If wVentaNormal Then
            wVen.TipoDoc = Mid(cDocumento.Text, 1, 1)
            wVen.NumDoc = wCorrelativo
            wVen.FPago = Mid(cFormaPago.Text, 1, 1)
        Else
            wVen.TipoDoc = "S"
            wVen.NumDoc = 0
            wVen.FPago = "G"
        End If
        wVen.SubTotal = CInt(Val(xSubTotal.Text))
        wVen.Descuento = CInt(Val(xDescuento.Text))
        wVen.Total = CDbl(xAbono.Text)
        DC.T_Ventas.InsertOnSubmit(wVen)
        DC.SubmitChanges()
        If wVentaNormal Then
            ImprimirBoleta(wTicket)
        End If

        If Val(xAbonado.Text) = 0 Then
            For i = 1 To xTabla.Rows.Count - 1
                Stocks(Trim(xTabla.GetData(i, T_ARTICULO).ToString).ToDecimal, CInt(LocalActual), CInt(LocalActual), Val(xTabla.GetData(i, T_CANTIDAD).ToString), "-")
            Next
        End If

        Mensaje(Trim(cDocumento.Text) & " " & wCorrelativo)

        If wVentaNormal Then
            xBoleta.Text = ObtenerCorrelativo(wTipoDocumento).ToString
        End If
        LimpiarCampos()
    End Sub

    Sub ImprimirBoleta(ByVal wTickets As String)


        ' ModuloReporte = "ReporteBoleta"
        Dim Lista = New List(Of BoletaReporte)
        Dim wTiks = SQL("Select Ticket, Fecha, NumDoc, Total FROM Ventas WHERE Ticket=" & wTickets)

        For Each wTick As DataRow In wTiks.Rows
            Lista.Add(New BoletaReporte With {.NumDoc = wTick.GetInt("NumDoc"),
                                              .Ticket = wTick.GetInt("Ticket"),
                                              .Fecha = wTick.GetDate("FECHA"),
                                              .Total = wTick.GetInt("TOTAL")})
        Next

        If Lista.Count > 0 Then
            Dim wReporte As New ReporteBoleta
            wReporte.Database.Tables(0).SetDataSource(Lista)
            wReporte.PrintToPrinter(1, False, 0, 0)
        Else
            Mensaje("Error al imprimir el ticket")
        End If

    End Sub

    Function ValidarVenta() As Boolean
        If xDescuento.Text = "" Then xDescuento.Text = "0"
        If xAbonado.Text = "" Then xAbonado.Text = "0"

        If Val(xTotal.Text) = 0 Then
            MsgError("No se puede generar una boleta con total 0")
            Return False
        End If
        If Trim(cFormaPago.Text) = "" Then
            MsgError("Falta ingresar una Forma de Pago")
            Return False
        End If
        Dim wFPago = SQL("Select FPago, DescFPago FROM FPagos WHERE DescFPago='" & Trim(cFormaPago.Text) & "'").Top
        If wFPago Is Nothing Then
            MsgError("Forma de Pago no válida")
            cFormaPago.Focus()
            Return False
        End If
        If Trim(cDocumento.Text) = "" Then
            MsgError("Falta ingresar un Documento")
            cDocumento.Focus()
            Return False
        End If
        If Val(xDescuento.Text) < 0 Then
            MsgError("El Descuento no puede tener valor negativo")
            Return False
        End If
        If Val(xSubTotal.Text) < 0 Then
            MsgError("El Sub Total no puede tener valor negativo")
            Return False
        End If

        If Val(xAbono.Text) <= 0 Then
            MsgError("Falta ingresar el Monto a Cancelar")
            xAbonado.Focus()
            Return False
        End If
        If CDbl(xAbono.Text) > CDbl(xSubTotal.Text) Then
            MsgError("Error en el Pago")
            xAbono.Focus()
            Return False
        End If
        If CDbl(xSaldo.Text) < 0 Or CDbl(xSaldo.Text) > CDbl(xTotal.Text) Then
            MsgError("Error en el Monto de la venta")
            Return False
        End If

        If G_POS = 0 Then
            CambiarCaja()
        End If
        If G_POS = 0 Then
            Return False
        End If
        Return True
    End Function
    Sub CambiarCaja()
        Dim wPOS As String

        While G_POS = 0
            InputPersonalizado.Inputbox("Ingrese el número de la Caja", "Número de Caja", "", Me.Icon, True)
            If InputPersonalizado.Response = MsgBoxResult.Cancel Then
                wPOS = ""
            Else
                wPOS = InputPersonalizado.RetornoTexto
            End If
            If wPOS.Trim = "" Then
                G_POS = 0
                My.Settings.P_POS = G_POS.ToString
                My.Settings.Save()
                Exit Sub
            Else
                If Not IsNumeric(wPOS) Then
                    MsgError("El Dato ingresado debe ser numérico")
                    Continue While
                End If
            End If
            G_POS = Convert.ToDecimal(wPOS)
            My.Settings.P_POS = G_POS.ToString
            My.Settings.Save()
        End While
    End Sub

    Function CambiaCorrelativo(cLocal As Integer, cCaja As Integer, cTipoDoc As String, Boleta As Double) As Double
        Dim wCorrelativo As String = ""

        wCorrelativo = "1"
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim wCorr = DC.T_Correlativos.First(Function(x) x.Local = cLocal And
                                                         x.POS = cCaja And x.TipoDoc = cTipoDoc)

        If wCorr IsNot Nothing Then
            wCorrelativo = If(wCorr.Correlativo = 0, 1, Val(wCorr.Correlativo)).ToString
        Else
            wCorr.Correlativo = 1
            wCorr.Local = cLocal
            wCorr.POS = cCaja
            wCorr.TipoDoc = cTipoDoc
            DC.SubmitChanges()
            wCorrelativo = "1"
        End If

        InputPersonalizado.Inputbox("Correlativo", "Cambio de Correlativo - Caja:  " & Val(cCaja), wCorrelativo, Me.Icon, True)
        If InputPersonalizado.Response = MsgBoxResult.Cancel Then
            MsgError("No se cambió el correlativo.")
            CambiaCorrelativo = Val(Boleta)
            Exit Function
        End If
        wCorrelativo = InputPersonalizado.RetornoTexto

        Dim UpwCorr = SQL("Update Correlativos Set Correlativo = " & Val(wCorrelativo) & " " &
                  " Where Local = " & Val(cLocal) & " And Caja = " & Val(cCaja) & " And TipoDoc = '" & cTipoDoc & "'").Top
        Mensaje("Correlativo Actualizado " & Val(wCorrelativo))
        CambiaCorrelativo = Val(wCorrelativo)
    End Function

    Private Sub bCambiarCorrelativo_Click(sender As Object, e As EventArgs) Handles bCambiarCorrelativo.Click
        xBoleta.Text = CambiaCorrelativo(LocalActual, CInt(G_POS), wTipoDocumento, Val(xBoleta.Text)).ToString
        xArticulo.Focus()
    End Sub

    Private Sub cDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cDocumento.SelectedIndexChanged
        If Trim(cDocumento.Text) = "" Then Exit Sub

        Dim Doc = SQL("SELECT TipoDoc FROM TipoDoc WHERE DescTipoDoc='" & Trim(cDocumento.Text) & "' and TipoDoc in ('F','B')").Top
        If Doc Is Nothing Then
            MsgError("Documento seleccionado incorrecto")
            cDocumento.SelectedIndex = 0
            Exit Sub
        End If
        wTipoDocumento = Doc.GetText("TipoDoc")
        xBoleta.Text = ObtenerCorrelativo(wTipoDocumento).ToString
        wPrimeraPalabraDocumento = Split(cDocumento.Text, " ")
        bConsultaBoleta.Text = "Consultar " & wPrimeraPalabraDocumento(0)
    End Sub

    Private Sub bConsultaBoleta_Click(sender As Object, e As EventArgs) Handles bConsultaBoleta.Click
        ConsultaBoleta.WinDeco1.TituloVentana = bConsultaBoleta.Text
        ConsultaBoleta.lDocumento.Text = wPrimeraPalabraDocumento(0)
        ConsultaBoleta.wTipoDocumento = wTipoDocumento
        ConsultaBoleta.ShowDialog()
    End Sub

    Private Sub bCuadraturaCaja_Click(sender As Object, e As EventArgs) Handles bCuadraturaCaja.Click
        If ADMINISTRADOR Then
            VentasCaja.ShowDialog()
        Else
            MsgError("No tienes los permisos suficientes para ejecutar esta opción")
        End If
    End Sub

    Private Sub VentaSucursal_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        If G_POS = 0 Then
            CambiarCaja()
        End If
        If G_POS = 0 Then
            Close()
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        DoEvents()
        xCaja.Text = G_POS.ToString
        Titulos()
        CargarVendedor()
        cFormaPago.LoadItemsObj("FPagos", "Fpago", "DescFPago")
        cFormaPago.SelectedIndex = -1
        cDocumento.LoadItemsObj("TipoDoc", "DescTipoDoc", "TipoDoc", " WHERE TipoDoc in ('F','B')")
        cDocumento.SelectedIndex = -1
        xBoleta.Text = ObtenerCorrelativo(wTipoDocumento).ToString
        xCantidadTabla.Text = (xTabla.Rows.Count - 1).ToString
        Cursor = Cursors.Default
    End Sub

    Private Sub VentaSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Auditoria(Me.Text, A_INGRESADO, "", "0")
    End Sub

    Private Sub xArticulo_TextChanged(sender As Object, e As EventArgs) Handles xArticulo.TextChanged

    End Sub
End Class