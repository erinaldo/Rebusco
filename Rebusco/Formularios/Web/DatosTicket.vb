Public Class DatosTicket
    Const T_ID = 0
    Const T_TICKET = 1
    Const T_ARTICULO = 2
    Const T_DESCRIPCION = 3
    Const T_SKU = 4
    Const T_BARRA = 5
    Const T_CANTIDAD = 6
    Const T_PVENTA = 7
    Const T_TOTAL = 8
    Const T_PAGADO = 9
    Const T_ENTREGADO = 10

    Private Sub bCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub bAnulacionTik_Click(sender As Object, e As EventArgs) Handles bAnulacionTik.Click
        AnularTik.xTicket.Text = xTicket.Text
        AnularTik.Show()
        AnularTik.BringToFront()
        AnularTik.Ver_Ticket()
    End Sub

    Sub Mostrar_Datos()
        If Val(xTicket.Text) = 0 Then
            Exit Sub
        End If

        Dim wTik = SQL("SELECT * FROM TikGen WHERE Ticket = '" & xTicket.Text.Trim & "'").Top
        If wTik Is Nothing Then
            Exit Sub
        End If

        xCliente.Text = wTik.GetText("Cliente")
        Dim wCli = SQL("SELECT * FROM Clientes WHERE Cliente = " & xCliente.Text).Top
        If wCli IsNot Nothing Then
            xRut.Text = wCli.GetText("Rut")
            xNombre.Text = wCli.GetText("Nombre")
            xTelefono.Text = wCli.GetText("Telefonos")
            xCorreo.Text = wCli.GetText("EMail")
        End If

        xEstado.Text = BuscarCampo("Estados", "DescEstado", "Estado", wTik.GetText("Estado"), "Tipo='W'")
        xLocal.Text = BuscarCampo("Locales", "NombreLocal", "Local", wTik.GetText("Local"))
        xDoR.Text = IIf(wTik.GetText("DespachoRetiro").ToString = "D", "Despacho", "Retira").ToString
        If wTik.GetText("DespachoRetiro").ToString = "R" Then
            bDespachar.Enabled = False
        End If
        xTotal.Text = CDbl(wTik.GetText("Total")).ToString("#,##0")
        xFecha.Value = wTik.GetDate("Fecha")
        xIDTransaccion.Text = wTik.GetText("IdTransaccion")

        oPagado.Checked = wTik.GetBool("Pagado")
        oFacturar.Checked = wTik.GetBool("Facturar")
        xFechaPago.Value = wTik.GetDate("FechaPago")
        xFPago.Text = BuscarCampo("FPagos", "DescFPago", "FPago", wTik.GetText("FPago"))

        If wTik.GetBool("Pagado") Then
            bConfirmar.Enabled = False
        End If

        xFechaDoc.Value = CDate("01/01/2000")
        xTipoDoc.Text = wTik.GetText("TipoDoc")
        xNumDoc.Text = wTik.GetText("NumDoc")
        Dim wDoc = SQL("SELECT * FROM DocumentosG WHERE TipoDoc = '" & wTik.GetText("TipoDoc") & "' and Numero = " & wTik.GetText("NumDoc")).Top
        If wDoc IsNot Nothing Then
            xFechaDoc.Value = wDoc.GetDate("Fecha")
            bPago.Enabled = False
        End If

        xFechaListo.Value = wTik.GetDate("FechaListo")
        xFechaDespacho.Value = wTik.GetDate("FechaDespacho")
        xFechaEntrega.Value = wTik.GetDate("FechaEntrega")

        xOT.Text = wTik.GetText("OT")
        If Val(wTik.GetText("OT")) > 0 Then
            bOT.Enabled = False
        End If

        xNombreDespacho.Text = wTik.GetText("NombreDespacho")
        xDireccionDespacho.Text = wTik.GetText("DireccionDespacho")
        xTelefonosDespacho.Text = wTik.GetText("TelefonoDespacho")
        xCorreoDespacho.Text = wTik.GetText("EmailDespacho")
        xCiudadDespacho.Text = BuscarCampo("Comunas", "NombreComuna", "Codigo", wTik.GetText("CiudadDespacho"))
        xComunaDespacho.Text = BuscarCampo("Comunas", "NombreComuna", "Codigo", wTik.GetText("ComunaDespacho"))
        xObservaciones.Text = wTik.GetText("Observacion")

        Mostrar_Detalles()
    End Sub

    Sub Mostrar_Detalles()
        Titulos()

        Dim wDet = SQL("SELECT D.Id, D.Ticket, D.Articulo, A.Descripcion, A.SKU, D.Barra, D.Cantidad, D.PVenta, (D.Cantidad * D.PVenta) as Total, D.PagoRealizado, D.Entregado" &
                 " FROM TikDet as D " &
                 " LEFT Join Articulos as A on D.Articulo = A.Articulo " &
                 " WHERE Ticket = " & xTicket.Text &
                 " ORDER BY Id")

        If wDet.Rows.Count = 0 Then
            Exit Sub
        End If

        For Each wD As DataRow In wDet.Rows
            xTabla.AddItem("")
            xTabla.SetData(xTabla.Rows.Count - 1, T_ID, Trim(wD.GetText("ID")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_TICKET, Trim(wD.GetText("Ticket")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, Trim(wD.GetText("Articulo")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, Trim(wD.GetText("Descripcion")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_SKU, Trim(wD.GetText("SKU")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_BARRA, Trim(wD.GetText("Barra")))
            xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDAD, CDbl(wD.GetText("Cantidad")).ToString("#,##0"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_PVENTA, CDbl(wD.GetText("PVenta")).ToString("#,##0"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL, CDbl(wD.GetText("Total")).ToString("#,##0"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_PAGADO, wD.GetBool("PagoRealizado"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_ENTREGADO, wD.GetBool("Entregado"))
        Next
    End Sub

    Private Sub DatosTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub Titulos()
        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 11

        xTabla.Cols(T_ID).Width = 0
        xTabla.Cols(T_TICKET).Width = 0
        xTabla.Cols(T_ARTICULO).Width = 70
        xTabla.Cols(T_DESCRIPCION).Width = 250
        xTabla.Cols(T_SKU).Width = 100
        xTabla.Cols(T_BARRA).Width = 100
        xTabla.Cols(T_CANTIDAD).Width = 80
        xTabla.Cols(T_PVENTA).Width = 100
        xTabla.Cols(T_TOTAL).Width = 100
        xTabla.Cols(T_PAGADO).Width = 80
        xTabla.Cols(T_ENTREGADO).Width = 80

        xTabla.Cols(T_ID).Caption = "Id"
        xTabla.Cols(T_TICKET).Caption = "Ticket"
        xTabla.Cols(T_ARTICULO).Caption = "Artículo"
        xTabla.Cols(T_DESCRIPCION).Caption = "Descripción"
        xTabla.Cols(T_SKU).Caption = "SKU"
        xTabla.Cols(T_BARRA).Caption = "Barra"
        xTabla.Cols(T_CANTIDAD).Caption = "Cantidad"
        xTabla.Cols(T_PVENTA).Caption = "P.Venta"
        xTabla.Cols(T_TOTAL).Caption = "Total"
        xTabla.Cols(T_PAGADO).Caption = "Pagado"
        xTabla.Cols(T_ENTREGADO).Caption = "Entregado"

        xTabla.Cols(T_CANTIDAD).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        xTabla.Cols(T_PVENTA).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        xTabla.Cols(T_TOTAL).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter

        xTabla.Cols(T_CANTIDAD).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        xTabla.Cols(T_PVENTA).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        xTabla.Cols(T_TOTAL).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter

        xTabla.Cols(T_PAGADO).DataType = GetType(Boolean)
        xTabla.Cols(T_ENTREGADO).DataType = GetType(Boolean)
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click

    End Sub

    Private Sub bCancelar_Click_1(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub

    Private Sub bPago_Click(sender As Object, e As EventArgs) Handles bPago.Click
        If oFacturar.Checked Then
            EmisionDocumentos.Show()
            EmisionDocumentos.BringToFront()
            EmisionDocumentos.cTipoDoc.Text = "Factura Electrónica"
            EmisionDocumentos.xCliente.Text = xCliente.Text
            EmisionDocumentos.Ver_Cliente()
        End If
    End Sub

    Private Sub bOT_Click(sender As Object, e As EventArgs) Handles bOT.Click

    End Sub
End Class