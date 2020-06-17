Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports C1.Win.C1FlexGrid

Public Class VentaLocal
    Implements iFormulario

    Const T_ELIMINAR = 0
    Const T_PAGADO = 1
    Const T_ARTICULO = 2
    Const T_DESCRIPCION = 3
    Const T_BARRA = 4
    Const T_CANTIDAD = 5
    Const T_NETO = 6
    Const T_PRECIO = 7
    Const T_TOTAL = 8
    Const T_BLOQUEADA = 9
    Const T_DATOS_BICICLETA = 10
    Const T_REGISTRADO = 11
    Const T_MARCA = 12
    Const T_SERIE = 13
    Const T_TALLA = 14
    Const T_SKU = 15

    Const Tiempo_Reloj = 5  '5 minutos para el cambio de fecha/hora

    'Dim xTipoDoc As String   'Tipo de Documento
    Dim Ultimo_Art As String
    Dim Suma_Abonos As Double
    Dim xTicket As Double
    Dim wVendedor As String
    Dim wCliente As String
    Dim wTotalPagar As Decimal
    Dim wAcumulado As Double

    Dim Temporizador As Long
    Dim PagosVarios As Boolean
    Dim UsarAbonos As Boolean

    Public gSerie As String
    Public gGuardarDatos As Boolean



    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.F1 Then cFormaPago.Focus()
        If keyData = Keys.F2 Then xArticulo.Focus()
        If keyData = Keys.F3 Then cTipoDoc.Focus()
        If keyData = Keys.F4 Then Limpiar()
        If keyData = Keys.F5 Then cFormaPago.Focus()  'Repetir ultimo Articulo, Evaluar
        If keyData = Keys.F6 Then
            xTabla.RemoveItem(xTabla.Rows.Count - 1)
            xAbonado.Text = "0"
            xDescripcion.Text = "0"
            CalculaTotales()
        End If

        If keyData = Keys.F7 Then
            xPagoCliente.Text = xTotal.Text
            xAbono_Validating()
        End If

        If keyData = Keys.F8 Then bBuscarOT.PerformClick()
        If keyData = Keys.F9 Then xPagoCliente.Focus()
        If keyData = Keys.F10 Then bEmitir_Click()

        Return False
    End Function
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub VentaLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = True
        lLocal.Text = $"Local: {NombreLocalActual}"
        lBodega.Text = $"Bodega: {NombreBodegaActual}"
        cFormaPago.SelectedValue = P_FPAGO
        DoEvents()

        If G_IDCLIENTE = Clientes.Multibike Then
            cFormaPago.SelectedValue = "R"
        Else
            cFormaPago.SelectedValue = "E"
        End If

        Select Case G_IDCLIENTE
            Case "M"
                oAuto.Checked = False
            Case "B"
                oAuto.Checked = True
        End Select

    End Sub
    Private Sub VentaLocal_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim TipoDoc = ""
        If FE_BV Then
            TipoDoc = "BV"
        Else
            TipoDoc = "BM"
        End If

        CambiarPOS()
        Titulos()
        xFecha.Value = Now

        'Determinar si por parámetros de facturación electrónica se opera con boleta manual o electrónica

        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", " WHERE TipoDoc = '" + TipoDoc + "'")
        cTipoDoc.SelectedValue = TipoDoc

        xBoleta.Text = SiguienteCorrelativo(G_LOCALACTUAL, TipoDoc, G_POS)

        'cDocumentoCargar.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc")
        cDocumentoCargar.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", " WHERE Emision = 1 or TipoDoc = 'OT'")
        If G_IDCLIENTE = Clientes.Wikets Then
            cFormaPago.LoadItemsObj("FPagos", "Fpago", "DescFPago", "Where FPago IN ('C','D','E','T') Order by Orden")
        ElseIf G_IDCLIENTE = Clientes.Multibike Then
            cFormaPago.LoadItemsObj("FPagos", "Fpago", "DescFPago", "Where FPago IN ('E','C','D','R','V','T') Order by Orden")
        Else
            cFormaPago.LoadItemsObj("FPagos", "Fpago", "DescFPago", "Order by Orden")
        End If

        If G_IDCLIENTE <> Clientes.Multibike Then
            cFormaPago.SelectedValue = P_FPAGO
        End If
        cDocumentoCargar.SelectedValue = "OT"

        DoEvents()
        xUsuario.AutoCompletarActivo = False
        cVendedor.LoadItemsObj("Usuarios", "Usuario", "NombreUsr", " WHERE Acceso > 0")
        xArticulo.PreCargarDatos()

        If Trim(wVendedor) = "" Then
            wVendedor = UsuarioActual
            xUsuario.Text = wVendedor
            cVendedor.SelectedValue = UsuarioActual
        End If
        xUsuario.AutoCompletarActivo = True
        Tiempo.Interval = 1000 '1 segundo
        Temporizador = 0

        xRut.Focus()
        Auditoria(Me.Name, "Ingresó al Módulo", UsuarioActual, CStr(G_LOCALACTUAL))
    End Sub

    Private Sub CambiarPOS()
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim NumPOS As New NumeroPOS

        G_POS = 0
        NumPOS.ID_POS = G_POS

        While NumPOS.ID_POS = 0

            NumPOS.xPOS.Text = "0"
            NumPOS.xPOS.SelectAll()

            If NumPOS.ShowDialog() = DialogResult.OK Then

                If NumPOS.ID_POS = 0 Then Continue While

                Dim wPos = DC.T_Correlativos.FirstOrDefault(Function(x) x.POS = NumPOS.ID_POS And
                                                                         x.Local = G_LOCALACTUAL)
                If wPos IsNot Nothing Then
                    If wPos.Correlativo > 0 Then
                        G_POS = wPos.POS
                    Else
                        MsgError("El POS indicado no tiene correlativos asignados")
                        NumPOS.ID_POS = 0
                    End If
                Else
                    MsgError("El POS indicado no tiene correlativos asignados")
                    NumPOS.ID_POS = 0
                End If
            Else
                NumPOS.Close()
                Close()
                Exit Sub
            End If
        End While

        xPOS.Text = G_POS.ToString()

    End Sub

    Private Sub xUsuario_ItemSeleccionado(wDescripcion As String) Handles xUsuario.ItemSeleccionado
        cVendedor.SelectedValue = xUsuario.Text
    End Sub
    Private Sub xUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xUsuario.Validating
        If xUsuario.ListaVisible Then
            If xUsuario.ListaActiva Then
                Exit Sub
            Else
                xUsuario.OcultarLista()
            End If
        End If

        If Trim(xUsuario.Text) = "" Then
            cVendedor.SelectedIndex = -1
            Exit Sub
        End If

        Dim wIndice = cVendedor.FindStringExact(xUsuario.DescEncontrada)
        If wIndice = -1 Then
            MsgError("La Vendedor no encontrado")
            xUsuario.Clear()
            cVendedor.SelectedIndex = -1
            Exit Sub
        End If

        cVendedor.SelectedValue = xUsuario.Text.Trim()
        If cVendedor.Text = "" Then
            cVendedor.SelectedIndex = -1
            xUsuario.Clear()
            MsgError("Vendedo no encontrado")
            Exit Sub
        End If

        'cVendedor.SelectedIndex = wIndice
        'cVendedor.Refresh()
    End Sub

    Private Sub cVendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cVendedor.SelectedIndexChanged
        If Trim(cVendedor.Text) = "" Then
            xUsuario.Clear()
            Exit Sub
        End If

        Dim wID = xUsuario.EncontrarID(cVendedor.Text)
        If wID = "" Then
            cVendedor.SelectedIndex = 0
            Exit Sub
        End If

        xUsuario.AutoCompletarActivo = False
        xUsuario.Text = wID
        xUsuario.AutoCompletarActivo = True
    End Sub

    Private Sub bBonos_Click(sender As Object, e As EventArgs) Handles bBonos.Click
        If xNombre.Text.Trim <> "" Then
            Abonos.xCliente.Text = xCliente.Text
            Abonos.xCliente_Validating()
            Abonos.ShowDialog()
            Buscar_Abonos()
        End If
        Buscar_Abonos()
    End Sub

    Private Sub Agregar(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bAgregar.Click
        If Trim(xArticulo.Text) = "" Then
            MsgError("Debe ingresar un artículo")
            xArticulo.Focus()
            Exit Sub
        End If
        If Val(xCantidad.Text) <= 0 Then
            MsgError("Falta Cantidad")
            xCantidad.Text = "1"
            xCantidad.SelectAll()
            xCantidad.Focus()
            Exit Sub
        End If

        If Val(xDescuento.Text) > 0 Then xDescuento.Text = "0"
        If Val(xAbonado.Text) > 0 Then
            xPagoCliente.Text = "0"
            xAbonado.Text = ""
        End If

        Agregar_Articulo()
    End Sub

    Private Sub bBuscarOT_Click(sender As Object, e As EventArgs) Handles bBuscarOT.Click
        If cDocumentoCargar.Text = "" Then
            MsgError("Debe seleccinar un tipo de documento a cargar")
            Exit Sub
        End If
        If cDocumentoCargar.SelectedValue.ToString = "OT" Then
            Dim wForm As New ConsultaOT("EmisionDocumento")
            wForm.Consultar()
            wForm.ShowDialog()
        Else
            Dim conDoc = New ConsultaDocumento()
            conDoc.Configurar(Me, xNumDocRef, cDocumentoCargar.SelectedValue.ToString())
            conDoc.ShowDialog()
        End If

    End Sub

    Private Sub bCargar_Click(sender As Object, e As EventArgs) Handles bCargar.Click
        CargarDocumento()
    End Sub

    Public Sub CargarDocumento()
        If cDocumentoCargar.SelectedValue.ToString = "OT" Then
            CargarOT()
        Else
            DocumentoG()
        End If
        gCargarDocumento.Visible = False
    End Sub

    Public Sub DocumentoG()
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wDocumentoD = DC.T_DocumentosD.Where(Function(x) x.Numero = xNumDocRef.Text.ToDecimal)

        For Each wArticulo In wDocumentoD
            xArticulo.AutoCompletarActivo = False
            xArticulo.Text = wArticulo.Articulo.ToString
            xCantidad.Text = wArticulo.Cantidad.ToString
            xArticulo.AutoCompletarActivo = True
            Agregar()
        Next
    End Sub

    Private Sub bCrearCliente_Click(sender As Object, e As EventArgs) Handles bCrearCliente.Click
        ManCliente.Configurar(Me, xCliente)
        ManCliente.ShowDialog()
    End Sub

    Private Sub bUsarABonos_Click(sender As Object, e As EventArgs) Handles bUsarABonos.Click
        If xAbonosCli.ToDecimal > 0 Then
            If Pregunta("Desea utilizar TODO el monto abonado del cliente como pago para este Documento") Then
                xAbonado.Text = xAbonosCli.Text
                UsarAbonos = True
            End If
            CalculaTotales()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        Temporizador = Temporizador + 1
        If Temporizador >= (Tiempo_Reloj * 60) Then
            Temporizador = 0
            xFecha.Value = Now
        End If
    End Sub

    Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
        e.NextControl(xCantidad)
    End Sub

    Dim ListaOT As New List(Of Decimal)
    Private Sub CargarOT()

        If Trim(xNumDocRef.Text) = "" Or Val(xNumDocRef.Text) <= 0 Then
            MsgError("El Campo OT no puede estar vacío")
            Exit Sub
        End If

        Dim Ven = SQL("SELECT e.DescEstado,o.Estado,c.Rut " &
                  " FROM OT o INNER JOIN Estados e on o.Estado=e.Estado  AND e.Tipo='O' " &
                  " LEFT JOIN Clientes c on o.Cliente=c.Cliente" &
                  " WHERE OT=" & Val(xNumDocRef.Text)).Top

        If Ven Is Nothing Then
            MsgError("La OT ingresada no existe")
            xNumDocRef.Text = ""
            Exit Sub
        End If

        If Ven.GetText("Estado") <> "D" Then
            MsgError("La OT ingresada no se encuentra Cerrada")
            xNumDocRef.Text = ""
            Exit Sub
        End If

        If ListaOT.Contains(xNumDocRef.ToDecimal) Then
            MsgError("OT ya se encuentra cargada")
            Exit Sub
        End If

        xRut.Text = Ven.GetText("Rut")
        xRut_Validating()

        Ven = SQL("SELECT FechaPago,o.TipoDoc,NumDoc,d.Estado " &
                   " FROM OT o LEFT JOIN  DocumentosG d on o.NumDoc=d.Numero and o.TipoDoc=d.TipoDoc " &
                   " WHERE OT=" & Val(xNumDocRef.Text)).Top

        If Ven Is Nothing Then
            MsgError("OT ingresada no existe")
            xNumDocRef.Focus()
            Exit Sub
        End If

        If Ven.GetText("FechaPago") = "" Then
            Dim wEstado As String
            wEstado = If(Ven.GetText("Estado") = "", "A", Ven.GetText("Estado")).ToString

            If wEstado <> "N" Then
                MsgError("La OT ingresada no puede ser cargada debido a que ya se encuentra un Documento de pago emitido para ella." & vbCrLf & "Boleta emitida:  " & Ven.GetText("NumDoc"))
                Limpiar()
                Exit Sub
            End If
        End If


        Dim wVenDet = SQL("SELECT o.Articulo,a.Descripcion,Coalesce(b.Barra,'') as Barra,o.Cantidad, " &
                " a.PVenta,(o.Cantidad*a.PVenta) as Total " &
                " FROM OTDet o INNER JOIN Estados e on o.Estado=e.Estado And e.Tipo='S' " &
                " INNER JOIN Articulos a on o.Articulo=a.Articulo " &
                " LEFT JOIN Barras b on a.Articulo=b.Articulo " &
                " WHERE o.Estado='R' And o.OT=" & Val(xNumDocRef.Text))
        'Titulos
        'X = Ven.RecordCount
        For Each wArtD As DataRow In wVenDet.Rows
            xArticulo.AutoCompletarActivo = False
            xArticulo.Text = wArtD.GetText("Articulo")
            xCantidad.Text = wArtD.GetText("Cantidad")
            xArticulo.AutoCompletarActivo = True
            Agregar()

        Next
        ListaOT.Add(xNumDocRef.ToDecimal)
    End Sub

    Private Sub bConsultarBoleta_Click(sender As Object, e As EventArgs) Handles bConsultarBoleta.Click
        'ConsBoleta.Show
    End Sub

    Private Sub bEmitir_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bEmitir.Click

        If xPagoCliente.Text = "0" Then
            xPagoCliente.Text = xTotal.Text
        End If

        If xDescuento.Text = "" Then
            xDescuento.Text = "0"
        End If
        If xAbonado.Text = "" Then
            xAbonado.Text = "0"
        End If
        If xSubTotal.Text.ToDecimal = 0 Then
            MsgError("Vale de Venta Incompleto")
            Exit Sub
        End If

        If Trim(cTipoDoc.Text) = "" Then
            MsgError("Falta Documento")
            cTipoDoc.Focus()
            Exit Sub
        End If

        If xDescuento.Text.ToDecimal < 0 Then
            MsgError("Error en Descuento")
            Exit Sub
        End If

        If xNeto.Text.ToDecimal < 0 Then
            MsgError("Error en SubTotal")
            Exit Sub
        End If

        If cFormaPago.SelectedValue Is Nothing Then
            MsgError("Error Falta Forma de Pago")
            cFormaPago.Focus()
            Exit Sub
        End If


        DoEvents()

        If xTabla.Rows.Count - 1 <= 0 Then
            MsgError("Faltan Items")
            Exit Sub
        End If

        If Not VerificarRut(xRut.Text) Then
            If Pregunta("¿Venta sin Cliente?") Then
                xRut.Text = "66.666.666-6"
                xRut_Validating()
            Else
                xRut.Focus()
                Exit Sub
            End If
        End If

        If Not Pregunta("¿Desea emitir " & cTipoDoc.Text & "?") Then
            Exit Sub
        End If

        bEmitir.Enabled = False
        Cursor = Cursors.WaitCursor

        For i As Integer = 1 To xTabla.Rows.Count - 1
            If xTabla.GetData(i, T_REGISTRADO).ToString = "No" Then
                Dim DatosBic = New DatosBicicleta
                DatosBic.lDescripcion.Text = xTabla.GetData(i, T_DESCRIPCION).ToString
                DatosBic.xMarca.Text = If(Trim(xTabla.GetData(i, T_MARCA).ToString).ToString = "", "SPECIALIZED", xTabla.GetData(i, T_MARCA).ToString)
                DatosBic.xModelo.Text = Trim(xTabla.GetData(i, T_DESCRIPCION).ToString)
                DatosBic.xSerie.Text = xTabla.GetData(i, T_SERIE).ToString
                DatosBic.xSKU.Text = xTabla.GetData(i, T_SKU).ToString
                DatosBic.xDocumento.Text = xBoleta.Text
                DatosBic.xRut.Text = xRut.Text.Replace(",", ".")
                DatosBic.lCodigo.Text = xTabla.GetData(i, T_ARTICULO).ToString
                DatosBic.xTalla.Text = xTabla.GetData(i, T_TALLA).ToString
                DatosBic.xRut_Validating()
                DatosBic.CargarDatos()
                DatosBic.cFPago.SelectedValue = cFormaPago.SelectedValue.ToString()
                DatosBic.cLocal.SelectedValue = G_LOCALACTUAL.ToString()
                DatosBic.ShowDialog()
                xTabla.SetData(i, T_SERIE, gSerie)
                xTabla.SetData(i, T_REGISTRADO, "Si")
            End If
        Next

        PagosVarios = False

        Dim wCorrelativo = SiguienteCorrelativo(G_LOCALACTUAL, cTipoDoc.SelectedValue.ToString, G_POS).ToString

        Dim DC = New MarketONEDataContext(P_CONEXION)
        If cFormaPago.SelectedValue.ToString = "V" Then
            Dim wModuloPagos = New ModuloFPagos
            PagosVarios = True
            wModuloPagos.xNumero.Text = wCorrelativo
            wModuloPagos.xTipoDoc.Text = cTipoDoc.Text.Trim
            wModuloPagos.xIDTipoDoc.Text = cTipoDoc.SelectedValue.ToString
            wModuloPagos.xCliente.Text = wCliente
            wModuloPagos.xCliente_Validating()
            wModuloPagos.xVendedor.Text = xUsuario.Text
            wModuloPagos.xVendedor_Validating()
            wModuloPagos.xTotal.Text = xTotal.Text

            If wModuloPagos.ShowDialog = DialogResult.Cancel Then
                MsgError("No se completó el pago")
                PagosVarios = False
                bEmitir.Enabled = True
                Cursor = Cursors.Default
                Exit Sub
            End If
        Else
            Dim wDocP As New T_DocumentosP With {
                .Local = G_LOCALACTUAL,
                .TipoDoc = cTipoDoc.SelectedValue.ToString,
                .Numero = wCorrelativo.ToDecimal,
                .Fecha = xFecha.Value,
                .Cliente = xCliente.Text.ToDecimal,
                .Vendedor = xUsuario.Text,
                .Estado = "C",
                .FechaCanc = Now,
                .FPago = cFormaPago.SelectedValue.ToString,
                .FechaPago = DateAdd("m", 1, CDate(xFecha.Value)),
                .NumeroPago = "0",
                .Cuenta = "",
                .Banco = "000",
                .Titular = "",
                .Monto = xTotal.Text.ToDecimal,
                .Obs = "",
                .Usuario = UsuarioActual
            }
            DC.T_DocumentosP.InsertOnSubmit(wDocP)
        End If

        'Determinar si el documento a emitir es electrónico o no para enviar a SII
        Dim Doc_Electronico As Boolean = DTE.Es_Electronico(cTipoDoc.SelectedValue.ToString)


        Dim wDocG As New T_DocumentosG()

        wDocG.Local = G_LOCALACTUAL
        wDocG.TipoDoc = cTipoDoc.SelectedValue.ToString
        wDocG.Numero = wCorrelativo.ToDecimal()
        wDocG.Fecha = xFecha.Value
        wDocG.Estado = "A"
        wDocG.Cliente = Convert.ToDecimal(xCliente.Text)
        wDocG.Rut = xRut.Text
        wDocG.Aprobado = True
        wDocG.FPago = cFormaPago.SelectedValue.ToString
        wDocG.Bodega = G_BODEGA
        wDocG.OC = ""
        wDocG.Motivo = "0"
        wDocG.Observaciones = ""
        wDocG.Usuario = UsuarioActual
        wDocG.Vendedor = xUsuario.Text.Trim
        wDocG.Electronica = False
        wDocG.POS = G_POS
        wDocG.Abonado = xAbonado.ToDecimal
        wDocG.Descuento = xDescuento.ToDecimal
        wDocG.Neto = xNeto.ToDecimal
        wDocG.IVA = xIVA.ToDecimal
        wDocG.EXE = 0
        wDocG.MIN = 0
        wDocG.BEB = 0
        wDocG.VIN = 0
        wDocG.CER = 0
        wDocG.LIC = 0
        wDocG.HAR = 0
        wDocG.CAR = 0
        wDocG.FEP = 0
        wDocG.TAB = 0
        wDocG.LGT = 0
        wDocG.OTRO = 0
        wDocG.Total = xTotal.ToDecimal
        wDocG.RutTransporte = ""
        wDocG.NombreTransporte = ""
        wDocG.RutChofer = ""
        wDocG.NombreChofer = ""
        wDocG.PatenteMovil = ""
        wDocG.DTE = Doc_Electronico
        wDocG.Firma = New Byte() {}
        wDocG.TED = ""
        wDocG.STATUS_DTE = 0
        wDocG.StockTraspasado = False
        wDocG.SubTotal = xSubTotal.Text.ToDecimal
        wDocG.Ticket = 0


        DC.T_DocumentosG.InsertOnSubmit(wDocG)
        ActualizarCorrelativo(G_LOCALACTUAL, cTipoDoc.SelectedValue.ToString, G_POS)

        For Each wRow As C1.Win.C1FlexGrid.Row In xTabla.Rows
            If wRow.Index = 0 Then Continue For
            Dim wDocD As New T_DocumentosD
            wDocD.Local = G_LOCALACTUAL
            wDocD.TipoDoc = cTipoDoc.SelectedValue.ToString
            wDocD.Numero = Convert.ToDecimal(wCorrelativo)
            wDocD.Articulo = wRow.Item(T_ARTICULO).ToString.ToDecimal
            wDocD.Cantidad = wRow.Item(T_CANTIDAD).ToString.ToDecimal
            wDocD.Neto = Math.Round(wRow.Item(T_NETO).ToString.ToDecimal, 0, MidpointRounding.AwayFromZero)
            wDocD.IVA = Convert.ToDecimal(Math.Round((G_IVA / 100) * wRow.Item(T_NETO).ToString.ToDecimal, 0, MidpointRounding.AwayFromZero))
            wDocD.EXE = 0
            wDocD.MIN = 0
            wDocD.BEB = 0
            wDocD.VIN = 0
            wDocD.CER = 0
            wDocD.LIC = 0
            wDocD.CAR = 0
            wDocD.LGT = 0
            wDocD.FEP = 0
            wDocD.TAB = 0
            wDocD.HAR = 0
            wDocD.OTRO = 0
            wDocD.PVenta = wRow.Item(T_PRECIO).ToString.ToDecimal
            wDocD.Glosa = ""

            DC.T_DocumentosD.InsertOnSubmit(wDocD)
        Next

        If cDocumentoCargar.SelectedValue.ToString() = "OT" And xNumDocRef.Text <> "" Then
            Dim wOT = DC.T_OT.FirstOrDefault(Function(x) x.OT = xNumDocRef.Text.ToDecimal())
            If wOT IsNot Nothing Then
                wOT.TipoDoc = cFormaPago.SelectedValue.ToString
                wOT.NumDoc = wCorrelativo.ToDecimal
                wOT.FechaPago = Now
            End If
        End If

        If xAbonado.ToDecimal > 0 Then
            Dim wAbo = DC.T_Abonos.Where(Function(x) x.Cliente = wCliente.ToDecimal And x.Estado = "P")
            If wAbo.Any Then
                For Each wA In wAbo
                    wA.Estado = "C"
                    wA.FechaPago = Now
                    wA.TipoDoc = wDocG.TipoDoc
                    wA.NumDoc = wDocG.Numero
                Next
                DC.SubmitChanges()
            End If
        End If

        For Each wRow As Row In xTabla.Rows
            If wRow.Index = 0 Then Continue For
            Dim articulo = wRow.Item(T_ARTICULO).ToString.ToDecimal()
            Dim cantidad = wRow.Item(T_CANTIDAD).ToString.ToDecimal()
            Stocks(articulo, G_BODEGA, G_LOCALACTUAL, cantidad, ModoInventario.Disminuir)
            Tracking.Ingresar(Tracking.Eventos.StockDisminuido, Now, wDocG.Cliente, wDocG.TipoDoc, wDocG.Numero, Now, articulo, cantidad, G_BODEGA, G_LOCALACTUAL, "", Me.Text)
        Next

        DC.SubmitChanges()

        'Facturación Electrónica
        'En este caso son solo boletas, por lo que se dejan las variables fijas

        Dim TipoDoc = ""
        If FE_BV Then
            TipoDoc = "BV"
        Else
            TipoDoc = "BM"
        End If

        Dim wResultadoDTE As String = ""
        If FE_BV Then
            Try
                'Parametrizar con datos del Local
                If Not DTE.Parametros_DTE(G_LOCALACTUAL) Then
                    bEmitir.Enabled = True
                    Cursor = Cursors.Default
                    wResultadoDTE = "Error al sacar parámetros del Local."
                Else
                    If DTE.FE_EsElectronica Then
                        If DTE.Es_Electronico(TipoDoc) Then
                            'Generar TED
                            Dim wCli = SQL("SELECT * FROM Clientes WHERE Cliente = " & Val(xCliente.Text)).Top
                            If Not DTE.Generar_TED(G_LOCALACTUAL, TipoDoc, wCorrelativo.ToDouble, xFecha.Value, xRut.Text, xNombre.Text.Trim, Val(xTotal.Text), "").Estado Then
                                bEmitir.Enabled = True
                                Cursor = Cursors.Default
                                wResultadoDTE = "Error al Generar TED."
                            Else
                                'Envio al DTE                        
                                If DTE.Emitir_DTE(G_LOCALACTUAL, TipoDoc, wCorrelativo.ToDouble) Then
                                    bEmitir.Enabled = True
                                    Cursor = Cursors.Default
                                Else
                                    bEmitir.Enabled = True
                                    Cursor = Cursors.Default
                                    wResultadoDTE = "Error al enviar documento."
                                End If
                            End If
                        Else
                            'El documento no es eelectronico, por lo tanto no hay timbre ni envio a SII
                        End If
                    End If
                End If
            Catch ex As Exception
                bEmitir.Enabled = True
                Cursor = Cursors.Default
                wResultadoDTE = "Error al generar DTE, revise el documento en portal DTE."
            End Try
        End If

        bEmitir.Enabled = True
        Cursor = Cursors.Default

        If wResultadoDTE = "" Then wResultadoDTE = "Emitido Correctamente"
        Mensaje("Documento Emitido: " & vbCrLf &
               "Tipo de documento : " & cTipoDoc.Text & vbCrLf &
               "Número de Documento : " & wCorrelativo & vbCrLf &
               "STATUS: " & wResultadoDTE)

        If FE_BV And cTipoDoc.SelectedValue.ToString = "BV" Then
            ImprimirDocumento(Convert.ToInt32(wCorrelativo), DocumentoPago.Boleta, P_CANTIDADCOPIA)
        End If

        Limpiar()
        Auditoria(Me.Name, "Realizó Venta", wCorrelativo, G_LOCALACTUAL.ToString)
    End Sub

    Private Sub bImprimirOT_Click(sender As Object, e As EventArgs) Handles bImprimirOT.Click
        If xNumDocRef.Text <> "" Then
            Cursor = Cursors.WaitCursor
            Imprimir_OT(xNumDocRef.Text.Trim.ToDouble, True)
            Cursor = Cursors.Default
        End If
    End Sub

    Sub Emitir_Vale(xTicket As Double)
        'Salida.Reset
        'Salida.DiscardSavedData = True
        'Salida.ReportFileName = Directorio + "\Reportes\Vale.rpt"
        'Salida.SelectionFormula = "{TikGen.Ticket}=" + NUM(xTicket)
        'Salida.Connect = ConectaReporte
        'Salida.Destination = crptToPrinter
        'Salida.Action = 1
    End Sub

    Private Sub Limpiar(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        Titulos()

        xArticulo.Clear()
        xDescripcion.Clear()
        xCantidad.Clear()
        xSubTotal.Text = "0"
        ListaOT = New List(Of Decimal)
        xLineas.Text = "0"
        Ultimo_Art = "0"
        UsarAbonos = False
        xFecha.Value = Now

        Dim TipoDoc = ""
        If FE_BV Then
            TipoDoc = "BV"
        Else
            TipoDoc = "BM"
        End If

        xBoleta.Text = SiguienteCorrelativo(G_LOCALACTUAL, TipoDoc, G_POS)
        xIVA.Text = "0"
        xTotal.Text = "0"
        xAbonado.Text = "0"
        xPagoCliente.Text = "0"
        xDescuento.Text = "0"
        xSubTotal.Text = "0"
        xNeto.Text = "0"
        xRut.Text = "__.___.___-_"
        xNombre.Text = ""
        xCliente.Text = ""
        xSaldo.Text = "0"
        xNumDocRef.Text = ""
        Suma_Abonos = 0
        cTipoDoc.SelectedValue = TipoDoc
        If G_IDCLIENTE = Clientes.Multibike Then
            cFormaPago.SelectedValue = " "
        Else
            cFormaPago.SelectedValue = "E"
        End If
        wTotalPagar = 0
        wAcumulado = 0
        xAbonosCli.Text = "0"
        xArticulo.Focus()

    End Sub

    Private Sub bCuadraturaCaja_Click(sender As Object, e As EventArgs) Handles bCuadraturaCaja.Click
        VentasCaja.Show()
        VentasCaja.BringToFront()
        VentasCaja.bImprimir.Enabled = True
        VentasCaja.bConsultar.Enabled = True
        If G_ACCESOUSUARIO >= 5 Then
            VentasCaja.cLocal.Enabled = True
        Else
            VentasCaja.cLocal.Enabled = False
        End If
    End Sub


    Sub SeleccionarCaja()

        Dim nCaja As String

        nCaja = "0"
        While Val(nCaja) = 0
            nCaja = InputBox("N° de Caja", "Ingreso de Caja")
            If nCaja = "" Then
                If Pregunta("No hay una Caja seleccionada," & vbCrLf & " ¿Desea cerrar este módulo?") Then
                    Close()
                    Exit Sub
                    DoEvents()
                End If
            End If
        End While
        nCaja = Mid(nCaja, 1, 2)
        G_POS = Convert.ToDecimal(nCaja)

    End Sub

    Private Sub VentaLocal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            If cFormaPago.Enabled Then
                cFormaPago.Focus()
            End If
        End If

        If e.KeyCode = Keys.F2 Then
            Limpiar_Articulo()
        End If

        If e.KeyCode = Keys.F3 Then
            If cTipoDoc.Enabled Then
                cTipoDoc.Focus()
            End If
        End If

        If e.KeyCode = Keys.F4 Then
            Limpiar()
        End If

        If e.KeyCode = Keys.F5 Then
            Repite_Ultimo()
        End If

        If e.KeyCode = Keys.F6 Then
            Elimina_Ultimo()
        End If

        If e.KeyCode = Keys.F7 Then
            xDescuento.Text = "0"
            xPagoCliente.Text = xSubTotal.Text
        End If

        If e.KeyCode = Keys.F8 Then
            'bBuscar_Click(Nothing, Nothing)
        End If

        If e.KeyCode = Keys.F9 Then
            xPagoCliente.Focus()
        End If

        If e.KeyCode = Keys.F10 Then
            bEmitir_Click(Nothing, Nothing)
        End If
    End Sub

    Sub Titulos()


        Try



            xTabla.Clear()
            xTabla.Rows.Count = 1
            xTabla.Cols.Count = 16

            xTabla.Cols(T_ELIMINAR).Caption = "Eliminar"
            xTabla.Cols(T_PAGADO).Caption = ""
            xTabla.Cols(T_ARTICULO).Caption = "Artículo"
            xTabla.Cols(T_DESCRIPCION).Caption = "Descripción"
            xTabla.Cols(T_BARRA).Caption = "Barra"
            xTabla.Cols(T_CANTIDAD).Caption = "Cant."
            xTabla.Cols(T_NETO).Caption = "Neto"
            xTabla.Cols(T_PRECIO).Caption = "Precio"
            xTabla.Cols(T_TOTAL).Caption = "Total"
            xTabla.Cols(T_BLOQUEADA).Caption = "Bloqueado"
            xTabla.Cols(T_DATOS_BICICLETA).Caption = "Datos"
            xTabla.Cols(T_REGISTRADO).Caption = "Registrado"
            xTabla.Cols(T_MARCA).Caption = "Marca"
            xTabla.Cols(T_SERIE).Caption = "Serie"
            xTabla.Cols(T_TALLA).Caption = "Talla"
            xTabla.Cols(T_SKU).Caption = "SKU"

            xTabla.Cols(T_ELIMINAR).Width = 48
            xTabla.Cols(T_ARTICULO).Width = 104
            xTabla.Cols(T_DESCRIPCION).Width = 381
            xTabla.Cols(T_BARRA).Width = 0
            xTabla.Cols(T_CANTIDAD).Width = 44
            xTabla.Cols(T_NETO).Width = 75
            xTabla.Cols(T_PRECIO).Width = 75
            xTabla.Cols(T_TOTAL).Width = 75
            xTabla.Cols(T_BLOQUEADA).Width = 0
            xTabla.Cols(T_PAGADO).Width = 0
            xTabla.Cols(T_TALLA).Width = 0
            xTabla.Cols(T_SERIE).Width = 0
            xTabla.Cols(T_MARCA).Width = 0
            xTabla.Cols(T_REGISTRADO).Width = 0
            xTabla.Cols(T_DATOS_BICICLETA).Width = 0
            xTabla.Cols(T_SKU).Width = 0

            xTabla.Cols(T_ELIMINAR).ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter
            xTabla.Cols(T_DATOS_BICICLETA).ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter

            xTabla.Cols(T_ARTICULO).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
            xTabla.Cols(T_DESCRIPCION).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
            xTabla.Cols(T_BARRA).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
            xTabla.Cols(T_CANTIDAD).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            xTabla.Cols(T_PRECIO).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            xTabla.Cols(T_TOTAL).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter

            xSubTotal.Text = "0"

        Catch ex As Exception

        End Try

    End Sub

    Private Sub xTabla_AfterEdit(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles xTabla.AfterEdit
        If e.Col = T_CANTIDAD Then
            If Not IsNumeric(xTabla.GetData(xTabla.Row, T_CANTIDAD).ToString) Then
                MsgError("Cantidad Incorrecta")
                xTabla.SetData(xTabla.Row, T_CANTIDAD, 1)
            Else
                Dim DC = New MarketONEDataContext(P_CONEXION)
                Dim wArticulo = xTabla.GetData(xTabla.Row, T_CANTIDAD).ToString.ToDecimal
                Dim wTipoArticulo = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wArticulo)
                If wTipoArticulo IsNot Nothing Then
                    If wTipoArticulo.TipoArticulo = "P" Then
                        If Not CalcularExistencia(xTabla.GetData(xTabla.Row, T_CANTIDAD).ToString.ToDecimal) Then
                            MsgError("La cantidad ingresada supera el stock del artículo")
                            xTabla.SetData(xTabla.Row, T_CANTIDAD, 1)
                            Exit Sub
                        End If
                    End If
                End If
                xTabla.SetData(xTabla.Row, T_TOTAL, CDbl(xTabla.GetData(xTabla.Row, T_CANTIDAD).ToString) * CDbl(xTabla.GetData(xTabla.Row, T_PRECIO).ToString))
            End If
            xDescuento.Text = "0"
            CalculaTotales()
        End If
    End Sub

    Private Sub xTabla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTabla.KeyPress
        If e.KeyChar = vbCr Then
            If xTabla.Col = T_CANTIDAD Then
                xTabla.StartEditing(xTabla.Row, T_CANTIDAD)
            End If
        End If
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(xCantidad)
    End Sub

    Private Sub xCantidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xCantidad.Validating
        If xCantidad.Text = "" Then Exit Sub
        bAgregar.Focus()
    End Sub

    Private Sub xCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCantidad.KeyPress
        If xCantidad.Text = "" Then Exit Sub
        e.NextControl(bAgregar)
        ValidarDigitos(e)
    End Sub

    Sub Agregar_Articulo()
        Dim wArticuloEncontrado As Integer
        Dim wCantidad As Decimal
        Dim xBarra As String = ""
        Dim wMarca As String
        Dim wTalla As String

        For Each wRow As Row In xTabla.Rows
            If wRow.Index = 0 Then Continue For
            If wRow.Item(T_ARTICULO).ToString.Trim = xArticulo.Text.Trim Then
                wArticuloEncontrado = wRow.Index
                Exit For
            End If
        Next

        Dim wArt = SQL("Select * from Articulos where Articulo = '" & xArticulo.Text.Trim & "'").Top
        If wArt Is Nothing Then
            Exit Sub
        End If

        If wArt.GetBool("ActivoFijo") Then
            MsgError("Artículo ingresado está como Activo Fijo")
            xArticulo.Focus()
            Exit Sub
        End If

        If wArt.GetText("Estado") = "X" Then
            MsgError("Articulo Bloqueado.")
            Exit Sub
        End If

        If Val(xLineas.Text) >= MAX_LINEAS Then
            MsgError("Máximo de Lineas, No se pueden ingresar mas artículos.")
            Limpiar_Articulo()
            Exit Sub
        End If

        If wArt.GetText("TipoArticulo") = "P" And P_STOCKOBLIGATORIO Then
            If Not CalcularExistencia(xCantidad.Text.ToDecimal) Then
                MsgError("Artículo sin existencia suficiente para venta")
                Exit Sub
            End If
        End If

        Dim wBar = SQL("Select Top 1 Barra from Barras where Articulo = '" & xArticulo.Text.Trim & "'").Top

        If wBar IsNot Nothing Then
            xBarra = wBar.GetText("Barra")
        End If

        If xTabla.Rows.Count = 1 Then Titulos()

        If wArticuloEncontrado = 0 Then
            xTabla.AddItem("")
            wArticuloEncontrado = xTabla.Rows.Count - 1
            wCantidad = xCantidad.Text.ToDecimal
        Else
            wCantidad = xCantidad.Text.ToDecimal + xTabla.GetData(wArticuloEncontrado, T_CANTIDAD).ToString.ToDecimal
        End If


        wTalla = If(wArt.GetText("DetalleProducto") Is Nothing, "", Trim(wArt.GetText("DetalleProducto")))
        wMarca = wArt.GetText("Marca")

        xTabla.SetCellImage(wArticuloEncontrado, T_ELIMINAR, My.Resources.remove_table)
        xTabla.SetData(wArticuloEncontrado, T_ARTICULO, wArt.GetText("Articulo"))
        xTabla.SetData(wArticuloEncontrado, T_DESCRIPCION, wArt.GetText("Descripcion"))
        xTabla.SetData(wArticuloEncontrado, T_BARRA, xBarra)
        xTabla.SetData(wArticuloEncontrado, T_CANTIDAD, wCantidad)
        xTabla.SetData(wArticuloEncontrado, T_NETO, CalcularNETO(wArt.GetDecimal("PVenta")).ToText(NumericFormat.Money))
        xTabla.SetData(wArticuloEncontrado, T_PRECIO, wArt.GetDecimal("PVenta").ToText(NumericFormat.Money))
        Dim wTotal = xTabla.GetData(wArticuloEncontrado, T_CANTIDAD).ToString.ToDecimal * xTabla.GetData(wArticuloEncontrado, T_PRECIO).ToString.ToDecimal
        xTabla.SetData(wArticuloEncontrado, T_TOTAL, wTotal.ToText(NumericFormat.Money))
        xTabla.SetData(wArticuloEncontrado, T_SERIE, "")
        xTabla.SetCellImage(wArticuloEncontrado, T_DATOS_BICICLETA, My.Resources.preview16)
        xTabla.SetData(wArticuloEncontrado, T_SKU, wArt.GetText("SKU"))
        If wArt.GetText("Familia") = "1" And wArt.GetText("SubFamilia") <> "0" Then
            xTabla.Row = wArticuloEncontrado
            xTabla.Col = T_DATOS_BICICLETA
            xTabla.Cols(T_DATOS_BICICLETA).ImageAlign = ImageAlignEnum.CenterCenter
            xTabla.FondoCelda(wArticuloEncontrado, C_ENESPERA)
            xTabla.FondoCelda(wArticuloEncontrado, C_ENESPERA)
            xTabla.SetData(wArticuloEncontrado, T_REGISTRADO, "No")
            xTabla.SetData(wArticuloEncontrado, T_MARCA, wMarca)
            xTabla.SetData(wArticuloEncontrado, T_TALLA, wTalla)
        Else
            xTabla.FondoCelda(wArticuloEncontrado, C_NOAPLICA)
            xTabla.SetData(wArticuloEncontrado, T_REGISTRADO, "No Aplica")
        End If

        Ultimo_Art = wArt.GetText("Articulo")

        'If xArticulo.Text = "0" Then

        'End If

        'If xCantidad.Text = "" Then xCantidad.Text = "0"

        'wFamilia = wArt.GetText("Familia")
        'wSubFamilia = wArt.GetText("SubFamilia")

        'wTalla = If(wArt.GetText("DetalleProducto") Is Nothing, "", Trim(wArt.GetText("DetalleProducto")))

        'Dim wCantidad As Integer = 1

        'For i As Integer = wCantidad To CInt(xCantidad.Text)

        '    If wFamilia = "1" And wSubFamilia <> "1" Then
        '        wArticuloEncontrado = 0
        '    End If

        '    If wArticuloEncontrado = 0 Then
        '        If Val(xLineas.Text) >= MAX_LINEAS Then
        '            MsgError("Máximo de Lineas, No se pueden ingresar mas artículos.")
        '            Call Limpiar_Articulo()
        '            Exit Sub
        '        Else

        '            xTabla.AddItem("")
        '            xTabla.SetCellImage(xTabla.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
        '            xTabla.SetCellImage(xTabla.Rows.Count - 1, T_DATOS_BICICLETA, My.Resources.preview16)
        '            wArticuloEncontrado = xTabla.Rows.Count - 1
        '            xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDAD, 0)
        '        End If
        '    End If

        '    xTabla.SetData(wArticuloEncontrado, T_ARTICULO, wArt.GetText("Articulo"))

        '    If wArt.GetText("Articulo") = "0" Then
        '        xTabla.SetData(wArticuloEncontrado, T_DESCRIPCION, xDescripcion.Text.Trim)
        '    Else
        '        xTabla.SetData(wArticuloEncontrado, T_DESCRIPCION, wArt.GetText("Descripcion"))
        '    End If


        '    wMarca = wArt.GetText("Marca")
        '    xTabla.SetData(wArticuloEncontrado, T_BARRA, xBarra)
        '    xTabla.SetData(wArticuloEncontrado, T_CANTIDAD, CDbl(xTabla.GetData(xTabla.Rows.Count - 1, T_CANTIDAD).ToString) + If(wFamilia = "1" And wSubFamilia <> "0", 1, i))
        '    xTabla.SetData(wArticuloEncontrado, T_PRECIO, wArt.GetDecimal("PVenta"))
        '    xTabla.SetData(wArticuloEncontrado, T_NETO, CalcularNETO(wArt.GetDecimal("PVenta")))
        '    Dim wTotal = xTabla.GetData(xTabla.Rows.Count - 1, T_CANTIDAD).ToString.ToDecimal * xTabla.GetData(xTabla.Rows.Count - 1, T_PRECIO).ToString.ToDecimal
        '    xTabla.SetData(wArticuloEncontrado, T_TOTAL, wTotal)
        '    xTabla.SetData(wArticuloEncontrado, T_SERIE, "")

        '    If wFamilia = "1" And wSubFamilia <> "0" Then
        '        xTabla.Row = xTabla.Rows.Count - 1
        '        xTabla.Col = T_DATOS_BICICLETA
        '        xTabla.Cols(T_DATOS_BICICLETA).ImageAlign = ImageAlignEnum.CenterCenter
        '        xTabla.FondoCelda(wArticuloEncontrado, C_ENESPERA)
        '        xTabla.FondoCelda(wArticuloEncontrado, C_ENESPERA)
        '        xTabla.SetData(wArticuloEncontrado, T_REGISTRADO, "No")
        '        xTabla.SetData(wArticuloEncontrado, T_MARCA, wMarca)
        '        xTabla.SetData(wArticuloEncontrado, T_TALLA, wTalla)
        '    Else
        '        xTabla.FondoCelda(wArticuloEncontrado, C_NOAPLICA)
        '        xTabla.SetData(wArticuloEncontrado, T_REGISTRADO, "No Aplica")
        '    End If

        'Next i
        'Ultimo_Art = wArt.GetText("Articulo")

        Limpiar_Articulo()
        CalculaTotales()

        xTabla.Focus()
        xTabla.Row = xTabla.Rows.Count - 1
        xTabla.Col = T_ARTICULO
        DoEvents()
        Limpiar_Articulo()
    End Sub
    Sub Limpiar_Articulo()
        xArticulo.Clear()
        xDescripcion.Clear()
        xCantidad.Clear()
        xArticulo.Focus()
    End Sub
    Sub Repite_Ultimo()
        Dim Esta_Art As Boolean

        If CInt(Ultimo_Art) > 0 Then
            Esta_Art = False
            For i As Integer = 1 To xTabla.Rows.Count - 1
                If Trim(xTabla.GetData(i, T_ARTICULO).ToString) = Trim(Ultimo_Art) Then
                    xTabla.SetData(i, T_CANTIDAD, CDbl(xTabla.GetData(i, T_CANTIDAD).ToString) + 1)
                    xTabla.SetData(i, T_TOTAL, CDbl(xTabla.GetData(i, T_CANTIDAD).ToString) * CDbl(xTabla.GetData(i, T_PRECIO).ToString))
                    Esta_Art = True
                    i = 10000
                End If
            Next i

            If Not Esta_Art Then
                Ultimo_Art = "0"
            End If

            Call Limpiar_Articulo()
            Call CalculaTotales()
        End If
    End Sub
    Sub Elimina_Ultimo()
        Dim Esta_Art As Boolean

        If CInt(Ultimo_Art) > 0 Then
            Esta_Art = False
            For i As Integer = 1 To xTabla.Rows.Count - 1
                If xTabla.GetData(i, T_ARTICULO).ToString.Trim = Trim(Ultimo_Art) Then
                    xTabla.SetData(i, T_CANTIDAD, CDbl(xTabla.GetData(i, T_CANTIDAD).ToString) - 1)
                    xTabla.SetData(i, T_TOTAL, CDbl(xTabla.GetData(i, T_CANTIDAD).ToString) * CDbl(xTabla.GetData(i, T_PRECIO).ToString))
                    Esta_Art = True
                    If CDbl(xTabla.GetData(i, T_CANTIDAD).ToString) <= 0 Then
                        xTabla.RemoveItem(i)
                        Esta_Art = False
                        i = 10000
                    End If
                End If
            Next i

            If Not Esta_Art Then
                Ultimo_Art = "0"
            End If

            Call Limpiar_Articulo()
            Call CalculaTotales()
        End If
    End Sub
    Private Sub bVentaEspecial_Click(sender As Object, e As EventArgs)
        'If Solicita(Me) Then
        '    Call Realizar_Venta(0, Val(xTicket))
        'Else
        MsgError("No Autorizado")
        'End If
        'Me.Show
    End Sub

    Private Sub cDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cTipoDoc.KeyPress
        e.NextControl(xArticulo)
    End Sub

    Private Sub cFPagos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cFormaPago.KeyPress
        e.NextControl(cTipoDoc)
    End Sub

    Private Sub bCambiarCorrelativo_Click(sender As Object, e As EventArgs) Handles bCambiarCorrelativo.Click

        Dim TipoDoc = ""
        If FE_BV Then
            TipoDoc = "BV"
        Else
            TipoDoc = "BM"
        End If

        xBoleta.Text = CambiarCorrelativo(G_LOCALACTUAL, CInt(G_POS), TipoDoc).ToString
        xArticulo.Focus()
    End Sub

    Private Sub xRut_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xRut.Validating
        xAbonosCli.Text = "0"
        UsarAbonos = False
        xRut.Text = FormatoRut(xRut.Text)
        If xRut.Text.Replace(",", "").Replace(".", "").Replace("-", "").Trim <> "" Then
            If Not VerificarRut(xRut.Text) Then
                MsgError("Rut Incorrecto.")
                xRut.Clear()
                xNombre.Clear()
                xCliente.Clear()
                wCliente = ""
                xRut.Focus()
                Exit Sub
            Else
                Dim wCli = SQL("SELECT Nombre,Cliente " &
                          " FROM Clientes WHERE Rut='" & xRut.Text.Replace(",", ".").Trim() & "'").Top
                If wCli Is Nothing Then
                    wCliente = ""
                    MsgError("El Cliente ingresado no existe")
                    If Not Pregunta("¿Desea agregar un nuevo Cliente?") Then
                        xRut.Clear()
                        xCliente.Clear()
                        xNombre.Clear()
                        Exit Sub
                    Else
                        ManCliente.Configurar(Me, xCliente)
                        ManCliente.ShowDialog()
                        Exit Sub
                    End If
                End If
                wCliente = wCli.GetText("Cliente")

                xCliente.AutoCompletarActivo = False
                xCliente.Text = wCli.GetText("Cliente")
                xCliente.AutoCompletarActivo = True

                xNombre.Text = wCli.GetText("Nombre")

                Buscar_Abonos()
            End If
        Else
            xNombre.Text = ""
            wCliente = ""
            UsarAbonos = False
            xArticulo.Focus()
        End If
    End Sub
    Sub CalculaTotales()
        Dim wTotalNeto As Double = 0
        Dim wTotalPrecio As Decimal = 0

        If xTabla.Rows.Count = 1 Then
            xSubTotal.Text = "0"
            xPagoCliente.Text = "0"
            xDescuento.Text = "0"
            xNeto.Text = "0"
            xAbonado.Text = "0"
            xSaldo.Text = "0"
        End If

        For Each wRow As Row In xTabla.Rows
            If wRow.Index = 0 Then Continue For
            If wRow.Item(T_NETO).ToString = "" Then
                wRow.Item(T_NETO) = "0"
            End If
            wTotalNeto += wRow.Item(T_NETO).ToString.ToDecimal * wRow.Item(T_CANTIDAD).ToString.ToDecimal
            wTotalPrecio += wRow.Item(T_PRECIO).ToString.ToDecimal * wRow.Item(T_CANTIDAD).ToString.ToDecimal
        Next

        xNeto.Text = Math.Round(wTotalNeto, 0, MidpointRounding.AwayFromZero).ToText(NumericFormat.Money)
        xIVA.Text = (Math.Round((G_IVA / 100) * wTotalNeto, 0, MidpointRounding.AwayFromZero)).ToText(NumericFormat.Money)
        xSubTotal.Text = (wTotalPrecio).ToText(NumericFormat.Money)
        Dim Total = (xSubTotal.ToDecimal - xDescuento.ToDecimal - xAbonado.ToDecimal)
        If If(cFormaPago.SelectedValue?.ToString, "") = "E" Then
            Total = RedondeoPeso(Total)
        End If
        xTotal.Text = Total.ToText(NumericFormat.Money)
        xSaldo.Text = (xTotal.ToDecimal - xPagoCliente.ToDecimal).ToText(NumericFormat.Money)

        If xSaldo.ToDecimal < 0 Then xSaldo.Text = (xSaldo.ToDecimal * -1).ToText(NumericFormat.Money)

        'xAbonado.Text = xAbonado.ToText(NumericFormat.Money)
        xPagoCliente.Text = xPagoCliente.ToDecimal.ToText(NumericFormat.Money)
        xDescuento.Text = xDescuento.ToDecimal.ToText(NumericFormat.Money)
        xLineas.Text = (xTabla.Rows.Count - 1).ToString

    End Sub

    Private Sub xUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xUsuario.KeyPress
        e.NextControl(xRut)
    End Sub

    Sub Buscar_Abonos()
        Dim SumaAbo As Double

        xAbonosCli.Text = "0"
        If Trim(xNombre.Text) = "" Then Exit Sub

        Dim wAbos = SQL("Select * from Abonos where Cliente = " & Val(wCliente) & " and Estado = 'P' order by FechaAbono")
        If wAbos.Rows.Count = 0 Then
            Exit Sub
        End If

        For Each wAbo As DataRow In wAbos.Rows
            DoEvents()
            If wAbo.GetText("Estado") = "P" Then
                SumaAbo = SumaAbo + wAbo.GetInt("Monto")
            End If
        Next
        xAbonosCli.Text = SumaAbo.ToText(NumericFormat.Money)
    End Sub

    Private Sub cVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cVendedor.KeyPress
        e.NextControl(xNumDocRef)
    End Sub

    Private Sub xOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNumDocRef.KeyPress
        If xNumDocRef.Text = "" Then
            e.NextControl(cFormaPago)
        Else
            e.NextControl(bCargar)
        End If

    End Sub

    Sub SeleccionaCaja()
        Dim nCaja As String
        nCaja = "0"
        While Val(nCaja) = 0
            nCaja = InputBox("N° de Caja", "Ingreso de Caja")
        End While
        nCaja = Mid(nCaja, 1, 2)
        G_POS = Convert.ToDecimal(nCaja)
    End Sub

    Private Sub xArticulo_Validating(sender As Object, e As CancelEventArgs) Handles xArticulo.Validating
        If xArticulo.ListaVisible Then
            If xArticulo.ListaActiva Then
                Exit Sub
            Else
                xArticulo.OcultarLista()
            End If
        End If

        If Trim(xArticulo.Text) = "" Then
            xDescripcion.Clear()
            Exit Sub
        End If

        If xArticulo.DescEncontrada = "" Then
            Dim wIDArticulo = ObtenerArticulo(xArticulo.Text)
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wIDArticulo.ToDecimal())
            If wArt IsNot Nothing Then
                xArticulo.AutoCompletarActivo = False
                xArticulo.Text = wArt.Articulo.ToString()
                xDescripcion.Text = wArt.Descripcion
                xArticulo.AutoCompletarActivo = True


                If oAuto.Checked And xDescripcion.Text.Trim <> "" Then
                    xCantidad.Text = "1"
                    Agregar()
                Else
                    xCantidad.Text = "1"
                    xCantidad.SelectAll()
                    xCantidad.Focus()
                End If

                Exit Sub
            End If

            Informacion("Artículo no encontrado")
            xDescripcion.Clear()
            xArticulo.Clear()
            xArticulo.Focus()
        Else
            xArticulo.AutoCompletarActivo = False
            ''xArticulo.Text = xArticulo.IdEncontrado
            xDescripcion.Text = xArticulo.DescEncontrada
            xArticulo.AutoCompletarActivo = True

            If oAuto.Checked And xDescripcion.Text.Trim <> "" Then
                xCantidad.Text = "1"
                Agregar()
            Else
                xCantidad.Text = "1"
                xCantidad.SelectAll()
                xCantidad.Focus()
            End If


        End If
    End Sub

    Private Sub xArticulo_ItemSeleccionado(wDescripcion As String) Handles xArticulo.ItemSeleccionado
        xDescripcion.Text = wDescripcion
        xCantidad.Focus()
    End Sub

    Private Sub bGenerarDescuento_Click(sender As Object, e As EventArgs) Handles bGenerarDescuento.Click

        If Val(xAbonado.Text) > 0 Then
            If Not Pregunta("Al ingresar un descuento los abonos seran eliminados" & vbLf & "¿Desea continuar agregando descuento?") Then
                Exit Sub
            End If
        End If

        xAbonado.Text = "0"

        If xUsuario.Text = "" Then
            MsgError("Debe seleccionar un vendedor", "Falta vendedor")
            Exit Sub
        End If

        'If xRut.Text.Replace(".", "").Replace("-", "").Trim = "" Then
        '    MsgError("Debe ingresar un cliente", "Falta cliente")
        '    Exit Sub
        'End If

        If xCliente.Text.Trim = "" Then
            MsgError("Debe ingresar un cliente", "Falta cliente")
            xRut.Focus()
            Exit Sub
        End If

        If xTabla.Rows.Count = 1 Then
            MsgError("Debe ingresar artículos para realizar descuento", "Faltan artículos")
            Exit Sub
        End If



        Dim DctoAcmulado As Double

        For Each fila As C1.Win.C1FlexGrid.Row In xTabla.Rows
            If fila.Index = 0 Then Continue For
            Dim DctoAplicar = CalculoDescuento(xUsuario.Text, CInt(xCliente.Text), fila.Item(T_ARTICULO).ToString)
            Dim MontoDcto = fila.Item(T_TOTAL).ToString.ToDecimal * (DctoAplicar / 100)
            DctoAcmulado += MontoDcto
        Next

        DctoAcmulado = RedondeoPeso(DctoAcmulado)


        If DctoAcmulado > 0 Then
            Mensaje("Se calcularon los descuentos correspondientes", "Descuentos aplicados")
        Else
            Informacion("No hay descuentos para aplicar", "Sin descuentos")
        End If

        xDescuento.Text = DctoAcmulado.ToText(NumericFormat.Money)
        CalculaTotales()

    End Sub
    Private Function CalculoDescuento(wUsuario As String, wCliente As Decimal, wArticulo As String) As Double
        Dim ListaDescuentos = New List(Of Decimal)
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim Art = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wArticulo.ToDecimal)
        Dim DescMaxArticulo = Art.MaxDescuento
        Dim TipoArt = Art.TipoArticulo
        Dim DescMaxCliente = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = wCliente).MaxDescuento
        Dim DescMaxClienteServicios = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = wCliente).MaxDescuentoServicios
        Dim DescMaxUsuario = DC.T_Usuarios.FirstOrDefault(Function(x) x.Usuario = wUsuario).MaxDescuento
        Dim DescuentoMenor As Double

        If TipoArt = "S" Then
            ListaDescuentos = {DescMaxArticulo, DescMaxClienteServicios, DescMaxUsuario}.ToList
        Else
            ListaDescuentos = {DescMaxArticulo, DescMaxCliente, DescMaxUsuario}.ToList
        End If

        DescuentoMenor = ListaDescuentos.OrderBy(Function(x) x).FirstOrDefault()

        Return If(DescuentoMenor > 0, DescuentoMenor, 0)

    End Function

    Private Sub xAbono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xPagoCliente.KeyPress
        e.NextControl(bEmitir)
    End Sub

    Private Sub xAbono_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xPagoCliente.Validating
        If Val(xPagoCliente.Text) <= Val(Replace(xNeto.Text, ".", "")) Then
            lSaldo.Text = "Falta"
            xSaldo.BackColor = C_ROJO
            xSaldo.ForeColor = C_FUENTE_ROJO
        ElseIf Val(xPagoCliente.Text) >= Val(Replace(xNeto.Text, ".", "")) Then
            lSaldo.Text = "Vuelto"
            xSaldo.BackColor = C_AZUL_CELESTE
            xSaldo.ForeColor = C_FUENTE_AZUL
        End If

        If xSaldo.Text = "0" Then
            xSaldo.BackColor = C_AZUL_CELESTE
            xSaldo.ForeColor = C_FUENTE_AZUL
        End If

        CalculaTotales()
    End Sub

    Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs) Handles xTabla.DoubleClick

        Try
            If xTabla.Col = T_ELIMINAR Then
                xTabla.RemoveItem(xTabla.Row)
                xPagoCliente.Text = "0"
                xDescripcion.Text = "0"
                xDescuento.Text = "0"
                CalculaTotales()
            End If
        Catch ex As Exception
            'Se intentó eliminar una fila mas de las que habian 
        End Try


        If xTabla.Rows.Count = 1 Then Exit Sub

        If xTabla.Col = T_CANTIDAD Then
            xTabla.StartEditing(xTabla.Row, T_CANTIDAD)
        End If



    End Sub

    Private Sub xRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xRut.KeyPress
        e.NextControl(cFormaPago)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Titulos()
    End Sub

    Private Sub bCargarDocumento_Click(sender As Object, e As EventArgs) Handles bCargarDocumento.Click
        xNumDocRef.Clear()
        gCargarDocumento.Top = (gCargarDocumento.Parent.ClientSize.Height - gCargarDocumento.Height) \ 2
        gCargarDocumento.Left = (gCargarDocumento.Parent.ClientSize.Width - gCargarDocumento.Width) \ 2
        gCargarDocumento.Visible = True
        xNumDocRef.Focus()
    End Sub

    Private Sub bCancelarCarga_Click(sender As Object, e As EventArgs) Handles bCancelarCarga.Click
        gCargarDocumento.Visible = False
    End Sub
    Public Function CalcularExistencia(wCantidad As Decimal) As Boolean
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wStock = DC.T_Stocks.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.ToDecimal And
                                                                         x.Local = G_LOCALACTUAL And
                                                                         x.Bodega = G_BODEGA)
        If wStock Is Nothing Then Return False
        If wStock.Stock < wCantidad Then
            Return False
        End If
        Return True
    End Function

    Private Sub bBuscarArticulo_Click(sender As Object, e As EventArgs) Handles bBuscarArticulo.Click
        Dim wBuscador = New BuscadorArticulo
        wBuscador.Configurar(Me, xArticulo)
        wBuscador.ShowDialog()
    End Sub

    Private Sub xRut_GotFocus(sender As Object, e As EventArgs) Handles xRut.GotFocus
        xRut.SelectAll()
    End Sub

    Private Sub VentaLocal_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        xArticulo.Focus()
    End Sub

    Private Sub xRut_Enter(sender As Object, e As EventArgs) Handles xRut.Enter
        Dim objDelegate As MaskedTextBoxSelectAll_Delegate
        objDelegate = AddressOf MaskedTextBoxSelectAll
        BeginInvoke(objDelegate, Me.ActiveControl)
    End Sub

    Public Delegate Sub MaskedTextBoxSelectAll_Delegate(ByVal ctl As MaskedTextBox)
    Private Sub MaskedTextBoxSelectAll(ByVal ctl As MaskedTextBox)
        ctl.SelectAll()
    End Sub

    Private Sub xCliente_ItemSeleccionado(wDescripcion As String) Handles xCliente.ItemSeleccionado
        xNombre.Text = wDescripcion
        cFormaPago.Focus()
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        e.NextControl(cFormaPago)
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

        Dim DC = New MarketONEDataContext(P_CONEXION)


        Dim Cli As T_Clientes = Nothing

        xNombre.Clear()

        If xCliente.DescEncontrada = "" Then

            Dim rut = FormatoRut(xCliente.Text.Replace(",", "."))
            If wPatronRut.IsMatch(rut) Then
                Cli = DC.T_Clientes.FirstOrDefault(Function(x) x.Rut = rut)
            End If

            If Cli Is Nothing Then
                If IsNumeric(xCliente.Text) Then
                    Cli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = xCliente.Text.Trim.ToDecimal)
                End If
            End If

            If Cli Is Nothing Then
                Cli = DC.T_Clientes.FirstOrDefault(Function(x) x.Fantasia = xCliente.Text.Trim)
            End If
        Else
            Cli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = xCliente.Text.ToDecimal)
        End If

        xCliente.AutoCompletarActivo = False
        If Cli IsNot Nothing Then
            xCliente.Text = Cli.Cliente.ToString
            xNombre.Text = Cli.Nombre
            xRut.Text = Cli.Rut
        Else
            xCliente.Clear()
            xNombre.Clear()
            xRut.Clear()
        End If
        xCliente.AutoCompletarActivo = True

    End Sub

    Private Sub cFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cFormaPago.SelectedIndexChanged
        CalculaTotales()
    End Sub

    Private Sub xDescuento_TextChanged(sender As Object, e As EventArgs) Handles xDescuento.TextChanged
        If xDescuento.ToDecimal = 0 Then
            xDescuento.BackColor = Color.White
        Else
            xDescuento.BackColor = Color.FromArgb(255, 240, 99)
        End If
    End Sub

    Private Sub bEditarCliente_Click(sender As Object, e As EventArgs) Handles bEditarCliente.Click
        ManCliente.ConfigurarExistente(Me, xCliente, xCliente.Text.ToDecimal())
        ManCliente.ShowDialog()
    End Sub

    Private Sub xNombre_TextChanged(sender As Object, e As EventArgs) Handles xNombre.TextChanged
        bEditarCliente.Enabled = xNombre.Text <> ""
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class
