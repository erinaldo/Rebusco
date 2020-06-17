Public Class ConsultaVentaBoleta
    Implements iFormulario
    Const T_FECHA = 0
    Const T_LOCAL = 1
    Const T_POS = 2
    Const T_USUARIO = 3
    Const T_FORMAPAGO = 4
    Const T_DOCUMENTO = 5
    Const T_TICKET = 6
    Const T_ARTICULO = 7
    Const T_DESCRIPCION = 8
    Const T_CANTIDAD = 9
    Const T_PRECIO = 10
    Const T_TOTAL = 11

    Sub Titulos()
        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 12

        xTabla.Cols(T_FECHA).Width = 70
        xTabla.Cols(T_LOCAL).Width = 43
        xTabla.Cols(T_POS).Width = 44
        xTabla.Cols(T_USUARIO).Width = 55
        xTabla.Cols(T_FORMAPAGO).Width = 119
        xTabla.Cols(T_DOCUMENTO).Width = 70
        xTabla.Cols(T_TICKET).Width = 70
        xTabla.Cols(T_ARTICULO).Width = 112
        xTabla.Cols(T_DESCRIPCION).Width = 287
        xTabla.Cols(T_CANTIDAD).Width = 44
        xTabla.Cols(T_PRECIO).Width = 78
        xTabla.Cols(T_TOTAL).Width = 81

        xTabla.Cols(T_FECHA).Caption = "Fecha"
        xTabla.Cols(T_LOCAL).Caption = "Local"
        xTabla.Cols(T_POS).Caption = "Caja"
        xTabla.Cols(T_USUARIO).Caption = "Usuario"
        xTabla.Cols(T_FORMAPAGO).Caption = "F.Pago"
        xTabla.Cols(T_DOCUMENTO).Caption = "Documento"
        xTabla.Cols(T_TICKET).Caption = "Ticket"
        xTabla.Cols(T_ARTICULO).Caption = "Artìculo"
        xTabla.Cols(T_DESCRIPCION).Caption = "Descripciòn"
        xTabla.Cols(T_CANTIDAD).Caption = "Cant."
        xTabla.Cols(T_PRECIO).Caption = "Precio"
        xTabla.Cols(T_TOTAL).Caption = "Sub-Total"

    End Sub
    Private Sub ConsultaVentaBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        cFormaPago.LoadItemsObj("FPagos", "FPago", "DescFPago")
    End Sub

    Private Sub xCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCaja.KeyPress
        ValidarDigitos(e)
        e.NextControl(xVendedor)
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(xTicket)
    End Sub

    Private Sub xTicket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTicket.KeyPress
        ValidarDigitos(e)
        e.NextControl(cFormaPago)
    End Sub

    Private Sub xVendedor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xVendedor.Validating
        If xVendedor.Text.Trim = "" Then
            xNombre.Clear()
            Exit Sub
        End If

        Dim wVen = SQL("SELECT NombreUsr FROM Usuarios WHERE Usuario = '" & xVendedor.Text.Trim & "'").Top
        If wVen IsNot Nothing Then
            xNombre.Text = wVen.GetText("NombreUsr")
        Else
            MsgError("Vendedor no registrado")
            xVendedor.Clear()
            xNombre.Clear()
            xVendedor.Focus()
        End If
    End Sub

    Private Sub xArticulo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xArticulo.Validating
        If xArticulo.Text.Trim = "" Then
            xDescripcion.Clear()
            Exit Sub
        End If

        Dim wArt = SQL("SELECT Descripcion FROM Articulos WHERE Articulo = '" & xArticulo.Text.Trim & "'").Top

        If wArt IsNot Nothing Then
            xDescripcion.Text = wArt.GetText("Descripcion")
        Else
            MsgError("Artículo no registrado")
            xArticulo.Clear()
            xDescripcion.Clear()
            xArticulo.Focus()
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click, bConsultar.Click
        Dim wfiltros = ""
        Dim wButton As Button = DirectCast(sender, Button)

        If dDesde.Value > dHasta.Value Then
            MsgError("Fecha inicio no puede ser mayor a final")
            Exit Sub
        End If
        If dHasta.Value < dDesde.Value Then
            MsgError("La fecha final no pueder menor al la inicial")
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        wfiltros = " WHERE Fecha BETWEEN '" & dDesde.Value & "' AND '" & dHasta.Value & "'"

        If cLocal.Text <> "" Then
            wfiltros &= If(wfiltros = "", " WHERE ", " AND ") & " L.Local = " & cLocal.SelectedValue.ToString
        End If
        If xCaja.Text.Trim <> "" Then
            wfiltros &= If(wfiltros = "", " WHERE ", " AND ") & " V.Caja = " & xCaja.Text.Trim
        End If
        If xVendedor.Text.Trim <> "" Then
            wfiltros &= If(wfiltros = "", " WHERE ", " AND ") & " V.Usuario = '" & xVendedor.Text.Trim & "'"
        End If
        If xArticulo.Text.Trim <> "" Then
            wfiltros &= If(wfiltros = "", " WHERE ", " AND ") & " A.Articulo = '" & xArticulo.Text.Trim & "'"
        End If
        If xTicket.Text.Trim <> "" Then
            wfiltros &= If(wfiltros = "", " WHERE ", " AND ") & " V.Ticket = " & xTicket.Text.Trim
        End If
        If cFormaPago.Text <> "" Then
            wfiltros &= If(wfiltros = "", " WHERE ", " AND ") & " F.FPago = '" & cFormaPago.SelectedValue.ToString & "'"
        End If

        Dim wVen = SQL("SELECT V.Fecha,L.Local,V.Caja,U.Usuario,F.DescFPago,V.NumDoc," &
                     "V.Ticket,TD.Articulo,A.Descripcion,TD.Cantidad,TD.PVenta" &
                     " FROM Ventas V" &
                     " JOIN Locales L ON V.Local = L.Local" &
                     " JOIN Usuarios U On V.Usuario = U.Usuario" &
                     " JOIN FPagos F ON V.FPago = F.FPago" &
                     " JOIN TikDet  TD ON V.Ticket = TD.Ticket" &
                     " JOIN Articulos A ON TD.Articulo = A.Articulo " & wfiltros)


        If wVen.Rows.Count > 0 Then
            tBarraProgreso.Visible = True
            tMensajeBarra.Text = "Cargado Datos..."
            tBarraProgreso.Maximum = wVen.Rows.Count
            tBarraProgreso.Value = 0
            Dim wLista = New List(Of VentasBoletaListado)
            Dim wListParametrosLocal = ParametroLocal()
            For Each wV As DataRow In wVen.Rows
                wLista.Add(New VentasBoletaListado With {.Articulo = wV.GetText("Articulo"),
                                                    .POS = wV.GetNum("Caja"),
                                                    .Cantidad = wV.GetNum("Cantidad"),
                                                    .Descripcion = wV.GetText("Descripcion"),
                                                    .Fecha = wV.GetDate("Fecha"),
                                                    .Fpago = wV.GetText("DescFPago"),
                                                    .Local = wV.GetNum("Local"),
                                                    .NumDoc = wV.GetNum("NumDoc"),
                                                    .PVenta = wV.GetNum("PVenta"),
                                                    .Ticket = wV.GetNum("Ticket"),
                                                    .Usuario = wV.GetText("Usuario")})
                tBarraProgreso.Value += 1
                DoEvents()
            Next

            If wButton.Text = "Consultar" Then
                tMensajeBarra.Text = "Llenando Tabla..."
                tBarraProgreso.Maximum = wVen.Rows.Count
                tBarraProgreso.Value = 0
                Titulos()
                xTabla.Redraw = False
                Dim wTotal As Double
                For Each wL In wLista
                    xTabla.AddItem("")
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, FormatDateTime(wL.Fecha, DateFormat.ShortDate))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, wL.Local)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_POS, wL.POS)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_USUARIO, wL.Usuario)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FORMAPAGO, wL.Fpago)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_DOCUMENTO, wL.NumDoc)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_TICKET, wL.Ticket)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, wL.Articulo)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wL.Descripcion)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDAD, wL.Cantidad)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_PRECIO, wL.PVenta)
                    Dim wSubTotal = wL.Cantidad * wL.PVenta
                    xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, wSubTotal)
                    wTotal += wSubTotal
                    tBarraProgreso.Value += 1
                    DoEvents()
                Next
                xTabla.Redraw = True
                xTotal.Text = FormatNumber(wTotal, 0,,, TriState.True)
                tCantidadR.Text = "Cantidad de Registro " & xTabla.Rows.Count - 1
            Else
                tMensajeBarra.Text = "Generando Reporte..."
                DoEvents()
                Dim wReporte As New ReporteVentasBoleta
                wReporte.Database.Tables("MarketONE_VentasBoletaListado").SetDataSource(wLista)
                wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wListParametrosLocal)
                VisorReportes.WinDeco1.TituloVentana = "Listado de Ventas con Boletas"
                VisorReportes.MostrarReporte(wReporte)
                VisorReportes.Show()
                VisorReportes.BringToFront()
                Auditoria(Me.Text, A_IMPRIMIO, "", "")
            End If
        Else
            MsgError("No se encuentra registros para los filtros indicados")
        End If
        Cursor = Cursors.Arrow
        tMensajeBarra.Text = "Listo"
        tBarraProgreso.Visible = False
    End Sub

    Private Sub xVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xVendedor.KeyPress
        e.NextControl(xArticulo)
    End Sub

    Private Sub bBuscarV_Click(sender As Object, e As EventArgs) Handles bBuscarV.Click
        Dim wQuery As String
        wQuery = "SELECT Usuario as 'Vendedor', NombreUsr as 'Nombre' From Usuarios"
        Buscador.Show()
        Buscador.Configurar(wQuery, "NombreUsr", Me, "Vendedores", xVendedor)
    End Sub

    Private Sub bBuscarA_Click(sender As Object, e As EventArgs) Handles bBuscarA.Click
        Dim wQuery As String
        wQuery = "SELECT Articulo as 'Artículo', Descripcion as 'Descripción' From Articulos"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Descripcion", Me, "Artículos", xArticulo)
    End Sub
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub
End Class