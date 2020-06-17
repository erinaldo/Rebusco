Imports System.ComponentModel

Public Class ConsultaVentas
    Implements iFormulario
    Const T_FECHA = 0
    Const T_OT = 1
    Const T_TICKET = 2
    Const T_TIPODOC = 3
    Const T_NUMDOC = 4
    Const T_NOMBRECLIENTE = 5
    Const T_ARTICULO = 6
    Const T_DESCRIPCION = 7
    Const T_POS = 8
    Const T_USUARIO = 9
    Const T_PRECIO = 10

    Const T_ARTICULORESUMEN = 0
    Const T_DESCRIPCIONRESUME = 1
    Const T_CANTIDADRESUMEN = 2
    Const T_PRECIORESUMEN = 3

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub
    Sub Titulos_Resumen()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 4

        xTabla.Cols(T_ARTICULORESUMEN).Width = 200
        xTabla.Cols(T_DESCRIPCIONRESUME).Width = 805
        xTabla.Cols(T_CANTIDADRESUMEN).Width = 60
        xTabla.Cols(T_PRECIORESUMEN).Width = 90

        xTabla.Cols(T_ARTICULORESUMEN).Caption = "Artículo"
        xTabla.Cols(T_DESCRIPCIONRESUME).Caption = "Descripción"
        xTabla.Cols(T_CANTIDADRESUMEN).Caption = "Cantidad"
        xTabla.Cols(T_PRECIORESUMEN).Caption = "Precio Venta"

        xTabla.Cols(T_ARTICULORESUMEN).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
    End Sub
    Sub Titulos_General()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 11

        xTabla.Cols(T_FECHA).Width = 70
        xTabla.Cols(T_OT).Width = 60
        xTabla.Cols(T_TICKET).Width = 70
        xTabla.Cols(T_TIPODOC).Width = 110
        xTabla.Cols(T_NUMDOC).Width = 60
        xTabla.Cols(T_NOMBRECLIENTE).Width = 160
        xTabla.Cols(T_ARTICULO).Width = 120
        xTabla.Cols(T_DESCRIPCION).Width = 305
        xTabla.Cols(T_POS).Width = 40
        xTabla.Cols(T_PRECIO).Width = 80
        xTabla.Cols(T_USUARIO).Width = 80

        xTabla.Cols(T_FECHA).Caption = "Fecha"
        xTabla.Cols(T_OT).Caption = "OT"
        xTabla.Cols(T_TICKET).Caption = "Ticket"
        xTabla.Cols(T_TIPODOC).Caption = "Documento"
        xTabla.Cols(T_NUMDOC).Caption = "Número"
        xTabla.Cols(T_NOMBRECLIENTE).Caption = "Cliente"
        xTabla.Cols(T_ARTICULO).Caption = "Artículo"
        xTabla.Cols(T_DESCRIPCION).Caption = "Descripción"
        xTabla.Cols(T_POS).Caption = "Caja"
        xTabla.Cols(T_PRECIO).Caption = "Precio"
        xTabla.Cols(T_USUARIO).Caption = "Vendedor"

        xTabla.Cols(T_ARTICULO).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
    End Sub
    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        'Cursor = Cursors.WaitCursor

        'If oResumen.Checked Then

        'Else
        '    Dim wDC = New MarketONEDataContext(P_CONEXION)

        '    Dim wVistaReporte = wDC.T_ReporteVentas.Where(Function(x) x.Fecha >= dDesde.Value And x.Fecha <= dHasta.Value).ToList
        '    If xCliente.Text <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.Cliente = CInt(xCliente.Text)).ToList
        '    If xArticulo.Text <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.Articulo = xArticulo.ToDecimal).ToList
        '    If cFamilia.Text <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.Familia = CInt(cFamilia.SelectedValue.ToString)).ToList
        '    If cTipoDoc.Text <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.TipoDoc = cTipoDoc.SelectedValue.ToString).ToList
        '    If xNumero.Text.Trim <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.NumDoc = CInt(xNumero.Text.Trim)).ToList
        '    If xCaja.Text.Trim <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.Caja = CInt(xCaja.Text.Trim)).ToList
        '    If oSoloOT.Checked Then wVistaReporte = wVistaReporte.Where(Function(x) x.OT <> 0).ToList
        '    If xOT.Text.Trim <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.OT = CInt(xOT.Text.Trim)).ToList
        '    If xVendedor.Text.Trim <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.Usuario = xVendedor.Text.Trim).ToList
        '    If cLocal.Text <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.Local = CInt(cLocal.SelectedValue.ToString)).ToList

        '    If wVistaReporte.Any Then
        '        Titulos_General()
        '        Dim wVentas = wVistaReporte.GroupBy(Function(x) x.Ticket).ToList
        '        For Each wV In wVentas
        '            Dim wSubTotal As Double = 0
        '            For Each wT In wV.OrderBy(Function(x) x.Ticket).ToList
        '                xTabla.AddItem("")
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, wT.Fecha.ToShortDateString)
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_OT, wT.OT)
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_TICKET, wT.Ticket)
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_TIPODOC, wT.DescTipoDoc)
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_NUMDOC, wT.NumDoc)
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_NOMBRECLIENTE, wT.Nombre)
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, wT.Articulo)
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wT.Descripcion)
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_POS, wT.Caja)
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_USUARIO, wT.Usuario)
        '                xTabla.SetData(xTabla.Rows.Count - 1, T_PRECIO, FormatNumber(wT.PVenta, 0,,, TriState.True))

        '                wSubTotal += wT.PVenta
        '            Next
        '            xTabla.AddItem("")
        '            xTabla.SetData(xTabla.Rows.Count - 1, T_USUARIO, "Sub Total")
        '            xTabla.SetData(xTabla.Rows.Count - 1, T_PRECIO, FormatNumber(wSubTotal, 0,,, TriState.True))
        '            xTabla.FondoCelda(xTabla.Rows.Count - 1, C_AMARILLO_CELDA)
        '            xTabla.FuenteCelda(xTabla.Rows.Count - 1, T_PRECIO, C_AMARILLO_CELDA, Color.Black, True)
        '            xTabla.AddItem("")
        '        Next
        '    Else
        '        MsgError("No se encuentran registros para los filtros indicados")
        '    End If
        'End If
        'Cursor = Cursors.Default
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click, bConsultar.Click
        Dim wButton As Button = DirectCast(sender, Button)
        Cursor = Cursors.WaitCursor
        xTabla.Redraw = False
        If oResumen.Checked Then
            Dim wFiltroQuery As String = " And tg.Fecha between '" & dDesde.Value & "' and '" & dHasta.Value & "'"

            If Trim(xCliente.Text) <> "" Then wFiltroQuery = wFiltroQuery & " and v.Cliente = " & Val(xCliente.Text) & ""
            If Trim(xArticulo.Text) <> "" Then wFiltroQuery = wFiltroQuery & " and td.Articulo = '" & Trim(xArticulo.Text) & "'"
            If Trim(xOT.Text) <> "" Then wFiltroQuery = wFiltroQuery & " and V.OT = '" & Trim(xOT.Text) & "'"
            If Trim(xVendedor.Text) <> "" Then wFiltroQuery = wFiltroQuery & " and v.Usuario = '" & Trim(xVendedor.Text) & "'"
            If Trim(cLocal.Text) <> "" Then wFiltroQuery = wFiltroQuery & " and l.Local = " & cLocal.SelectedValue.ToString

            Dim wVen = SQL("SELECT td.Articulo,a.Descripcion,td.PVenta,'S' as Tipo,v.Local,l.NombreLocal,SUM(td.PVenta) as Precio,sum(td.Cantidad) as Cantidad " &
                    " ,'Resumen Servicios' as Resumen FROM TikGen tg INNER JOIN TikDet td on tg.Ticket=td.Ticket " &
                    " INNER JOIN Ventas v on v.Ticket=tg.Ticket " &
                    " INNER JOIN Articulos a on td.Articulo=a.Articulo " &
                    " INNER JOIN Familias f on a.Familia=f.Familia " &
                    " INNER JOIN Locales l on v.Local=l.Local " &
                    " Where a.Familia = 6 And V.OT <> 0  " & wFiltroQuery & "  Group by td.Articulo,a.Descripcion,td.PVenta,v.Local,l.NombreLocal" &
                    " Union All ( " &
                    " SELECT td.Articulo,a.Descripcion,td.PVenta,'R' as Tipo,v.Local,l.NombreLocal,SUM(td.PVenta) as Precio,sum(td.Cantidad) as Cantidad  " &
                    " ,'Resumen Repuestos' as Resumen FROM TikGen tg INNER JOIN TikDet td on tg.Ticket=td.Ticket " &
                    " INNER JOIN Ventas v on v.Ticket=tg.Ticket " &
                    " INNER JOIN DocumentosG G on v.Ticket=tg.Ticket " &
                    " INNER JOIN Articulos a on td.Articulo=a.Articulo " &
                    " INNER JOIN Familias f on a.Familia=f.Familia " &
                    " INNER JOIN Locales l on v.Local=l.Local " &
                    " Where a.Familia <> 6 And V.OT <> 0 " & wFiltroQuery & "  Group by td.Articulo,a.Descripcion,td.PVenta,v.Local,l.NombreLocal) " &
                    " Union All " &
                    " (SELECT td.Articulo,a.Descripcion,td.PVenta, 'V' as Tipo,v.Local,l.NombreLocal,SUM(td.PVenta) as Precio,sum(td.Cantidad) as Cantidad  " &
                    " ,'Resumen Ventas' as Resumen FROM TikGen tg INNER JOIN TikDet td on tg.Ticket=td.Ticket " &
                    " INNER JOIN Ventas v on v.Ticket=tg.Ticket " &
                    " INNER JOIN Articulos a on td.Articulo=a.Articulo " &
                    " INNER JOIN Familias f on a.Familia=f.Familia " &
                    " INNER JOIN Locales l on v.Local=l.Local " &
                    " Where V.OT = 0 " & wFiltroQuery & "  Group by td.Articulo,a.Descripcion,td.PVenta,v.Local,l.NombreLocal)")

            If wVen.Rows.Count > 0 Then
                tMensajeBarra.Text = "Cargando Datos..."
                tBarraProgreso.Visible = True
                tBarraProgreso.Value = 0
                tBarraProgreso.Maximum = wVen.Rows.Count

                Dim wListaVentaResumen As New List(Of VentasGeneralReporte)
                For Each wV As DataRow In wVen.Rows
                    wListaVentaResumen.Add(New VentasGeneralReporte With {.Articulo = wV.GetText("Articulo"),
                                                                     .Descripcio = wV.GetText("Descripcion"),
                                                                     .Cantidad = wV.GetNum("Cantidad"),
                                                                     .PVenta = wV.GetNum("Precio"),
                                                                     .Tipo = wV.GetText("Tipo"),
                                                                     .Local = wV.GetText("Local"),
                                                                     .NombreLocal = wV.GetText("NombreLocal"),
                                                                     .Usuario = UsuarioActual,
                                                                     .TipoResumen = wV.GetText("Resumen")})
                    tBarraProgreso.Value += 1
                    DoEvents()
                Next

                If wButton.Text = "Imprimir" Then
                    tMensajeBarra.Text = "Generando Reporte..."
                    DoEvents()
                    Dim wParametros = ParametroLocal()
                    Dim wFechaRango = {New RangoFecha With {.FechaDesde = dDesde.Value, .FechaHasta = dHasta.Value}}.ToList
                    Dim wReporte = New ReporteVentasResumido
                    wReporte.Database.Tables("MarketONE_VentasGeneralReporte").SetDataSource(wListaVentaResumen)
                    wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wParametros)
                    wReporte.Database.Tables("MarketONE_RangoFecha").SetDataSource(wFechaRango)
                    VisorReportes.MostrarReporte(wReporte)
                    VisorReportes.Show()
                    VisorReportes.BringToFront()
                Else
                    tMensajeBarra.Text = "Cargando Datos..."
                    Dim wTipoServicios = wListaVentaResumen.GroupBy(Function(x) x.Tipo)
                    Titulos_Resumen()
                    tBarraProgreso.Visible = True
                    tBarraProgreso.Value = 0
                    tBarraProgreso.Maximum = wTipoServicios.Count
                    Dim wTotal As Double = 0
                    For Each wTipo In wTipoServicios
                        Dim wSubTotal As Double = 0
                        xTabla.AddItem("")
                        xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULORESUMEN, wTipo.FirstOrDefault().NombreLocal)
                        xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCIONRESUME, wTipo.FirstOrDefault().TipoResumen)
                        xTabla.FondoCelda(xTabla.Rows.Count - 1, C_GRIS_INASISTIDA)
                        For Each wV In wTipo
                            xTabla.AddItem("")
                            xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULORESUMEN, wV.Articulo)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCIONRESUME, wV.Descripcio)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDADRESUMEN, wV.Cantidad)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_PRECIORESUMEN, FormatNumber(wV.PVenta, 0,,, TriState.True))
                            wSubTotal += wV.PVenta
                        Next
                        wTotal += wSubTotal
                        xTabla.AddItem("")
                        xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDADRESUMEN, "Sub Total")
                        xTabla.SetData(xTabla.Rows.Count - 1, T_PRECIORESUMEN, FormatNumber(wSubTotal, 0,,, TriState.True))
                        xTabla.FondoCelda(xTabla.Rows.Count - 1, C_AMARILLO_CELDA)
                        xTabla.AddItem("")
                        tBarraProgreso.Value += 1
                        DoEvents()
                    Next
                    xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDADRESUMEN, "Total")
                    xTabla.SetData(xTabla.Rows.Count - 1, T_PRECIORESUMEN, FormatNumber(wTotal, 0,,, TriState.True))
                    xTabla.FondoCelda(xTabla.Rows.Count - 1, C_NARANJO)
                End If
            Else
                MsgError("No se encuentra registros para los filtros indicados")
            End If

        Else

            Dim wDC = New MarketONEDataContext(P_CONEXION)
            Dim wVistaReporte = wDC.T_ReporteVentas.Where(Function(x) x.Fecha >= dDesde.Value And x.Fecha <= dHasta.Value).ToList

            If xCliente.Text <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.Cliente = CInt(xCliente.Text)).ToList
            If xArticulo.Text <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.Articulo = xArticulo.ToDecimal).ToList
            If cFamilia.Text <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.Familia = CInt(cFamilia.SelectedValue.ToString)).ToList
            If cTipoDoc.Text <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.TipoDoc = cTipoDoc.SelectedValue.ToString).ToList
            If xNumero.Text.Trim <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.NumDoc = CInt(xNumero.Text.Trim)).ToList
            If xCaja.Text.Trim <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.Caja = CInt(xCaja.Text.Trim)).ToList
            If oSoloOT.Checked Then wVistaReporte = wVistaReporte.Where(Function(x) x.OT <> 0).ToList
            If xOT.Text.Trim <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.OT = CInt(xOT.Text.Trim)).ToList
            If xVendedor.Text.Trim <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.Usuario = xVendedor.Text.Trim).ToList
            If cLocal.Text <> "" Then wVistaReporte = wVistaReporte.Where(Function(x) x.Local = CInt(cLocal.SelectedValue.ToString)).ToList

            If wVistaReporte.Any Then
                If wButton.Text = "Imprimir" Then

                    Dim wListaVenta As New List(Of VentasGeneralReporte)
                    Dim wParametros = ParametroLocal()
                    Dim wRangoFecha = {New RangoFecha With {.FechaDesde = dDesde.Value, .FechaHasta = dHasta.Value}}.ToList
                    Dim wReporte As New ReporteVentas

                    tMensajeBarra.Text = "Generando Reporte..."
                    tBarraProgreso.Value = 0
                    tBarraProgreso.Maximum = wVistaReporte.Count
                    tBarraProgreso.Visible = True

                    For Each wV In wVistaReporte
                        wListaVenta.Add(New VentasGeneralReporte With {.Fecha = wV.Fecha,
                                                                  .OT = wV.OT,
                                                                  .Ticket = wV.Ticket,
                                                                  .DescTipoDoc = wV.DescTipoDoc,
                                                                  .NumDoc = wV.NumDoc,
                                                                  .NombreCliente = wV.Nombre,
                                                                  .Articulo = wV.Articulo.ToString,
                                                                  .Descripcio = wV.Descripcion,
                                                                  .DescFamilia = wV.DescFamilia,
                                                                  .PVenta = wV.PVenta,
                                                                  .POS = wV.Caja,
                                                                  .Usuario = wV.Usuario})
                        tBarraProgreso.Value += 1
                        DoEvents()
                    Next
                    wReporte.Database.Tables("MarketONE_VentasGeneralReporte").SetDataSource(wListaVenta)
                    wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wParametros)
                    wReporte.Database.Tables("MarketONE_RangoFecha").SetDataSource(wRangoFecha)
                    VisorReportes.MostrarReporte(wReporte)
                    VisorReportes.Show()
                    VisorReportes.BringToFront()
                Else
                    Titulos_General()
                    Dim wVentas = wVistaReporte.GroupBy(Function(x) x.Ticket).ToList
                    tBarraProgreso.Visible = True
                    tBarraProgreso.Value = 0
                    tBarraProgreso.Maximum = wVentas.Count
                    tMensajeBarra.Text = "Cargando Datos..."
                    For Each wV In wVentas
                        Dim wSubTotal As Double = 0
                        For Each wT In wV.OrderBy(Function(x) x.Ticket).ToList
                            xTabla.AddItem("")
                            xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, wT.Fecha.ToShortDateString)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_OT, wT.OT)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_TICKET, wT.Ticket)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_TIPODOC, wT.DescTipoDoc)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_NUMDOC, wT.NumDoc)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_NOMBRECLIENTE, wT.Nombre)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, wT.Articulo)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wT.Descripcion)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_POS, wT.Caja)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_USUARIO, wT.Usuario)
                            xTabla.SetData(xTabla.Rows.Count - 1, T_PRECIO, FormatNumber(wT.PVenta, 0,,, TriState.True))

                            wSubTotal += wT.PVenta
                        Next
                        xTabla.AddItem("")
                        xTabla.SetData(xTabla.Rows.Count - 1, T_USUARIO, "Sub Total")
                        xTabla.SetData(xTabla.Rows.Count - 1, T_PRECIO, FormatNumber(wSubTotal, 0,,, TriState.True))
                        xTabla.FondoCelda(xTabla.Rows.Count - 1, C_AMARILLO_CELDA)
                        xTabla.FuenteCelda(xTabla.Rows.Count - 1, T_PRECIO, C_AMARILLO_CELDA, Color.Black, True)
                        xTabla.AddItem("")
                        tBarraProgreso.Value += 1
                        DoEvents()
                    Next
                End If
            Else
                MsgError("No se encuentran registros para los filtros indicados")
            End If
        End If
        Call Auditoria(Me.Name, "Listado de Ventas", xCliente.Text, xArticulo.Text)
        tMensajeBarra.Text = "Listo"
        tBarraProgreso.Visible = False
        tBarraProgreso.Value = 0
        Cursor = Cursors.Default
        xTabla.Redraw = True
    End Sub

    Private Sub ConsultaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc")
        cFPagos.LoadItemsObj("FPagos", "FPago", "DescFPago")
        cFamilia.LoadItemsObj("Familias", "Familia", "DescFamilia")
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
    End Sub

    Private Sub xNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNumero.KeyPress
        ValidarDigitos(e)
        e.NextControl(xCaja)
    End Sub

    Private Sub xCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCaja.KeyPress
        ValidarDigitos(e)
        e.NextControl(xOT)
    End Sub

    Private Sub xOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xOT.KeyPress
        ValidarDigitos(e)
        e.NextControl(cFPagos)
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        ValidarDigitos(e)
        e.NextControl(xVendedor)
    End Sub

    Private Sub xCliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xCliente.Validating
        If xCliente.Text.Trim = "" Then Exit Sub
        Dim wDC = New MarketONEDataContext(P_CONEXION)

        Dim wCli = wDC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = CInt(xCliente.Text.Trim))
        If wCli IsNot Nothing Then
            xNombreCliente.Text = wCli.Nombre
        Else
            MsgError("Cliente no registrado")
            xCliente.Clear()
            xNombreCliente.Clear()
            xCliente.Focus()
        End If
    End Sub

    Private Sub xVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xVendedor.KeyPress
        e.NextControl(xArticulo)
    End Sub

    Private Sub xVendedor_Validating(sender As Object, e As CancelEventArgs) Handles xVendedor.Validating
        If xVendedor.Text.Trim = "" Then Exit Sub
        Dim wDC = New MarketONEDataContext(P_CONEXION)
        Dim wVen = wDC.T_Usuarios.FirstOrDefault(Function(x) x.Usuario = xVendedor.Text.Trim)
        If wVen IsNot Nothing Then
            xNombreVendedor.Text = wVen.NombreUsr
        Else
            MsgError("Vendedor no registrado")
            xVendedor.Clear()
            xNombreVendedor.Clear()
            xVendedor.Focus()
        End If

    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(cFamilia)
    End Sub

    Private Sub xArticulo_Validating(sender As Object, e As CancelEventArgs) Handles xArticulo.Validating
        If xArticulo.Text.Trim = "" Then Exit Sub
        Dim wDC = New MarketONEDataContext(P_CONEXION)
        Dim wArt = wDC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.ToDecimal)
        If wArt IsNot Nothing Then
            xDescripcion.Text = wArt.Descripcion
        Else
            MsgError("Artículo no registrado")
            xArticulo.Clear()
            xDescripcion.Clear()
            xArticulo.Focus()
        End If
    End Sub

    Private Sub bBuscarC_Click(sender As Object, e As EventArgs) Handles bBuscarC.Click
        Dim wQuery = "SELECT Cliente , Nombre as 'Nombre Cliente' From Clientes"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Nombre", Me, "Clientes", xCliente)
    End Sub

    Private Sub bBuscarV_Click(sender As Object, e As EventArgs) Handles bBuscarV.Click
        Dim wQuery = "SELECT Usuario , NombreUsr as 'Nombre Vendedor' From Usuarios"
        Buscador.Show()
        Buscador.Configurar(wQuery, "NombreUsr", Me, "Vendedores", xVendedor)
    End Sub

    Private Sub bBuscarA_Click(sender As Object, e As EventArgs) Handles bBuscarA.Click
        Dim wQuery = "SELECT Articulo , Descripcion From Articulos"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Descripcion", Me, "Artículos", xArticulo)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        Titulos_General()
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class