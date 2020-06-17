Public Class ConsultaDescuento
    Implements iFormulario
    Const T_FECHA = 0
    Const T_LOCAL = 1
    Const T_POS = 2
    Const T_USUARIO = 3
    Const T_DOCUMENTO = 4
    Const T_TICKET = 5
    Const T_ARTICULO = 6
    Const T_DESCRIPCION = 7
    Const T_TOTALORIGINAL = 8
    Const T_DESCUENTO = 9

    Sub Titulos()
        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 10

        xTabla.Cols(T_FECHA).Width = 80
        xTabla.Cols(T_LOCAL).Width = 41
        xTabla.Cols(T_POS).Width = 40
        xTabla.Cols(T_USUARIO).Width = 53
        xTabla.Cols(T_DOCUMENTO).Width = 139
        xTabla.Cols(T_TICKET).Width = 74
        xTabla.Cols(T_ARTICULO).Width = 110
        xTabla.Cols(T_DESCRIPCION).Width = 293
        xTabla.Cols(T_TOTALORIGINAL).Width = 87
        xTabla.Cols(T_DESCUENTO).Width = 85

        xTabla.Cols(T_FECHA).Caption = "Fecha"
        xTabla.Cols(T_LOCAL).Caption = "Local"
        xTabla.Cols(T_POS).Caption = "Caja"
        xTabla.Cols(T_USUARIO).Caption = "Usuario"
        xTabla.Cols(T_DOCUMENTO).Caption = "Documento"
        xTabla.Cols(T_TICKET).Caption = "Ticket"
        xTabla.Cols(T_ARTICULO).Caption = "Artìculo"
        xTabla.Cols(T_DESCRIPCION).Caption = "Descripciòn"
        xTabla.Cols(T_TOTALORIGINAL).Caption = "Total Origianl"
        xTabla.Cols(T_DESCUENTO).Caption = "Descuento"
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
    Private Sub ConsultaDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        cFormaPago.LoadItemsObj("FPagos", "FPago", "DescFPago")
        cDocumento.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", " WHERE TipoDoc = 'BV' Or TipoDoc = 'FV'")
        Auditoria(Text, A_INGRESO, "", "")
    End Sub

    Private Sub xCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xPOS.KeyPress
        ValidarDigitos(e)
        e.NextControl(xVendedor)
    End Sub
    Private Sub xVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xVendedor.KeyPress
        e.NextControl(xArticulo)
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
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub xDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDocumento.KeyPress
        ValidarDigitos(e)
        e.NextControl(bImprimir)
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click, bConsultar.Click
        Dim wFiltros = ""
        Dim wButton As Button = DirectCast(sender, Button)

        If dDesde.Value > dHasta.Value Then
            MsgError("La fecha inicial no pueder ser mayor a la final")
            Exit Sub
        End If
        If dHasta.Value < dDesde.Value Then
            MsgError("La fecha final no puede ser menor a la ficha inicial")
            Exit Sub
        End If

        If cLocal.Text <> "" Then wFiltros += " AND V.Local = '" & cLocal.SelectedValue.ToString & "'"
        If xPOS.Text.Trim <> "" Then wFiltros += " AND V.Caja = '" & xPOS.Text.Trim & "'"
        If xVendedor.Text.Trim <> "" Then wFiltros += " AND V.Usuario = '" & xVendedor.Text.Trim & "'"
        If xArticulo.Text.Trim <> "" Then wFiltros += " AND TD.Articulo = '" & xArticulo.Text.Trim & "'"
        If xTicket.Text.Trim <> "" Then wFiltros += " AND V.Ticket = '" & xTicket.Text.Trim & "'"
        If cFormaPago.Text <> "" Then wFiltros += " AND V.FPago = '" & cFormaPago.SelectedValue.ToString & "'"
        If cDocumento.Text <> "" Then wFiltros += " AND V.TipoDoc = '" & cDocumento.SelectedValue.ToString & "'"
        If xDocumento.Text.Trim <> "" Then wFiltros += " AND V.NumDoc = '" & xDocumento.Text.Trim & "'"

        Cursor = Cursors.WaitCursor

        Dim wVen = SQL("SELECT V.Fecha,V.Local,V.Caja,V.Usuario,F.DescFPago,V.TipoDoc ,V.NumDoc,V.Ticket,TD.articulo,A.Descripcion, TG.Total,V.Descuento  From Ventas V" &
                     " JOIN TikGen TG ON V.Ticket = TG.Ticket" &
                     " JOIN TikDet TD ON TG.Ticket = TD.Ticket" &
                     " JOIN Articulos A ON TD.Articulo = A.Articulo" &
                     " JOIN FPagos F ON V.FPago = F.FPago" &
                     " WHERE V.Fecha BETWEEN '" & dDesde.Value & "' AND '" & dHasta.Value & "' " & wFiltros)


        If wVen.Rows.Count > 0 Then
            tBarraProgreso.Value = 0
            tBarraProgreso.Maximum = wVen.Rows.Count
            tBarraProgreso.Visible = True
            tMensajeBarra.Text = "Cargando Datos..."
            If wButton.Text = "Consultar" Then
                xTabla.Redraw = False
                Titulos()
                Dim wTotal As Double
                For Each wV As DataRow In wVen.Rows
                    xTabla.AddItem("")
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, FormatDateTime(wV.GetDate("Fecha"), DateFormat.ShortDate))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, wV.GetText("Local"))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_POS, wV.GetText("Caja"))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_USUARIO, wV.GetText("Usuario"))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_DOCUMENTO, wV.GetText("DescFPago") & "-" & wV.GetText("NumDoc"))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_TICKET, wV.GetText("Ticket"))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, wV.GetText("Articulo"))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wV.GetText("Descripcion"))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_TOTALORIGINAL, wV.GetText("Total"))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_DESCUENTO, wV.GetText("Descuento"))
                    wTotal += wV.GetNum("Descuento")
                    tBarraProgreso.Value += 1
                    DoEvents()
                Next
                xTotal.Text = FormatNumber(wTotal, 0,,, TriState.True)
            Else
                Dim wLista = New List(Of DescuentoListado)
                For Each wV As DataRow In wVen.Rows
                    wLista.Add(New DescuentoListado With {.Articulo = wV.GetText("Articulo"),
                                                         .POS = wV.GetNum("Caja"),
                                                         .Descripcion = wV.GetText("Descripcion"),
                                                         .Descuento = wV.GetNum("Descuento"),
                                                         .Documento = wV.GetNum("NumDoc"),
                                                         .Fecha = wV.GetDate("Fecha"),
                                                         .FPago = wV.GetText("DescFPago"),
                                                         .Local = wV.GetNum("Local"),
                                                         .Tickets = wV.GetNum("Ticket"),
                                                         .TotalOriginal = wV.GetNum("Total"),
                                                         .Usuario = wV.GetText("Usuario"),
                                                         .TipoDoc = wV.GetText("TipoDoc")})
                    tBarraProgreso.Value += 1
                    DoEvents()
                Next
                tMensajeBarra.Text = "Generando Reporte..."
                Dim wListParametrosLocal = ParametroLocal()
                Dim wReporte As New ReporteDescuento
                wReporte.Database.Tables("MarketONE_DescuentoListado").SetDataSource(wLista)
                wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wListParametrosLocal)
                VisorReportes.WinDeco1.TituloVentana = "Listado de Descuentos"
                VisorReportes.MostrarReporte(wReporte)
                VisorReportes.Show()
                VisorReportes.BringToFront()
                Auditoria(Me.Text, A_IMPRIMIO, "", "")
            End If
        Else
            MsgError("No se encuentrar registros con los filtros ingresados.")
        End If
        xTabla.Redraw = True
        tMensajeBarra.Text = "Listo"
        tBarraProgreso.Visible = False
        Cursor = Cursors.Arrow
    End Sub
End Class