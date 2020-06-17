Imports System.ComponentModel
Imports System.Data.Linq
Imports C1.Win.C1FlexGrid

Public Class EmisionDocumentos
    Implements iFormulario


    Const T_ELIMINAR = 0
    Const T_ID = 1
    Const T_ARTICULO = 2
    Const T_DESCRIPCION = 3
    Const T_UNIDAD = 4
    Const T_BARRA = 5
    Const T_CANTIDAD = 6
    Const T_NETO = 7
    Const T_PVENTA = 8
    Const T_SUBTOTAL = 9
    Const T_IVA = 10
    Const T_EXE = 11
    Const T_MIN = 12
    Const T_BEB = 13
    Const T_VIN = 14
    Const T_CER = 15
    Const T_LIC = 16
    Const T_CAR = 17
    Const T_HAR = 18
    Const T_TAB = 19
    Const T_FEP = 20
    Const T_LOG = 21
    Const T_OTRO = 22

    Dim xGlosa As String = ""

    Dim BodegaParcial As Integer
    Dim ConPagos As Boolean = False
    Dim MODO_BODEGA As String = "0"

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Dim xFPago As String, TipoDoc As String, xMotivo As String, Electronico As Boolean
        Dim wTipoDocR As String, Fecha_Doc As DateTime

        TipoDoc = ""

        If cTipoDoc.SelectedIndex <= 0 Then
            MsgError("Debe selccionar un tipo de documento", "Falta tipo de documento")
            Exit Sub
        End If

        Dim wTipoDoc = SQL("SELECT * FROM TipoDoc WHERE TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "'").Top
        If wTipoDoc IsNot Nothing Then
            TipoDoc = wTipoDoc.GetText("TipoDoc")
            MODO_BODEGA = wTipoDoc.GetText("Modo")
            Electronico = wTipoDoc.GetBool("Electronica")

            ConPagos = CBool(wTipoDoc.GetText("Pagos"))
        Else
            MsgError("Error en Tipo de Documento")
            cTipoDoc.Focus()
            Exit Sub
        End If

        If cTipoDocRef.Text.ToString.Trim <> "" Then
            Dim wTipoDR = SQL("SELECT * FROM TipoDoc WHERE DescTipoDoc = '" & cTipoDocRef.Text & "'").Top
            If wTipoDR IsNot Nothing Then
                wTipoDocR = wTipoDR.GetText("TipoDoc")
            Else
                MsgError("Error en Tipo de Documento Referencia")
                Exit Sub
            End If
        Else
            wTipoDocR = ""
        End If
        If Val(xNumDoc.Text) = 0 Then
            MsgError("Falta Número del Documento")
            Exit Sub
        End If
        If xRut.Text = "__.___.___-_" Or Trim(xNombre.Text) = "" Then
            MsgError("Falta Cliente")
            Exit Sub
        End If

        Dim wFPagos = SQL("SELECT * FROM FPagos WHERE FPago = '" & cFPago.SelectedValue.ToString & "'").Top
        If wFPagos IsNot Nothing Then
            xFPago = wFPagos.GetText("FPago")
        Else
            MsgError("Error en Forma de Pago")
            Exit Sub
        End If

        If xNombre.Text = "" Then
            MsgError("Error en Rut/Cliente")
            Exit Sub
        End If

        If xTabla.Rows.Count - 1 = 0 Then
            MsgError("Falta Detalle")
            Exit Sub
        End If
        If Val(xTotal.Text) = 0 Then
            MsgError("Documento no puede tener valor 0")
            Exit Sub
        End If

        If ValidarDeuda() Then
            Exit Sub
        End If

        If xVendedor.Text = "" Then xVendedor.Text = UsuarioActual

        xMotivo = "X"
        If TipoDoc = "GD" Or TipoDoc = "NC" Or TipoDoc = "ND" Then
            If cMotivo.Text.Trim = "" Then
                MsgError(cTipoDoc.Text.Trim + " debe especificar un motivo")
                cMotivo.Focus()
                Exit Sub
            End If

            Dim wMot = SQL("Select * from  Motivos where DescMotivo = '" & cMotivo.Text & "' and TipoDoc = '" & TipoDoc & "'").Top
            If wMot IsNot Nothing Then
                xMotivo = wMot.GetText("Motivo")
            Else
                MsgError("Motivo de " + cTipoDoc.Text.Trim + " incorrecto.")
                cMotivo.Focus()
                Exit Sub
            End If
        End If

        'Correlativo
        xNumDoc.Text = BuscarCorrelativo(ModoCorrelativo.Actualizar, If(cTipoDoc.SelectedValue?.ToString, ""), xFecha.Value, CInt(G_POS.ToText)).ToString()
        If Val(xNumDoc.Text) = 0 Then
            MsgError("Error no hay correlativos disponibles, imposible emitir documento")
            Exit Sub
        End If

        'Verificar Documento Repetido
        Dim Existente = SQL("Select * from DocumentosG where Local=" & Val(G_LOCALACTUAL) & "" &
                        " AND TipoDoc = '" & TipoDoc & "' and Numero =" & Val(xNumDoc.Text)).Top
        If Existente IsNot Nothing Then
            MsgError("El Documento ya fue Ingresado en el Sistema" + vbCrLf + "intente nuevamente.")
            Exit Sub
        End If



        Fecha_Doc = CDate(Format(xFecha.Value, "dd/MM/yyyy") & " " & Mid(Now.ToString, 11, 20))
        xFecha.Value = Fecha_Doc

        Aceptar.Enabled = False
        Cursor = Cursors.WaitCursor
        Dim DC = New RebuscoDataContext(P_CONEXION)
        '--------------------------------------
        'Si el Documento requiere pagos...
        If xFPago <> "V" Then
            'Se crea un registro con un pago pendiente
            'Si se declara varias formas de pago ira al modulo de pago y no este


            Dim wDocP As New T_DocumentosP

            wDocP.Local = G_LOCALACTUAL
            wDocP.TipoDoc = cTipoDoc.SelectedValue.ToString
            wDocP.Numero = CInt(xNumDoc.Text)
            wDocP.Fecha = xFecha.Value
            wDocP.Cliente = CInt(xCliente.Text)
            wDocP.Vendedor = xVendedor.Text.Trim
            wDocP.FPago = CChar(cFPago.SelectedValue.ToString)
            If cFPago.SelectedValue.ToString = "E" Then
                wDocP.Estado = CChar("C")
                wDocP.FechaPago = Now.Date
                wDocP.FechaCanc = Now.Date
                wDocP.Obs = "PAGO EFECTIVO"
            Else
                wDocP.Estado = CChar("P")
                wDocP.FechaPago = DateAdd("m", 1, CDate(xFecha.Value))
                wDocP.FechaCanc = CDate("01/01/2000")
                wDocP.Obs = ""
            End If

            wDocP.NumeroPago = "0"
            wDocP.Cuenta = ""
            wDocP.Banco = "000"
            wDocP.Titular = ""
            wDocP.Monto = CInt(xTotal.Text)
            wDocP.Usuario = UsuarioActual
            DC.T_DocumentosP.InsertOnSubmit(wDocP)
            DC.SubmitChanges()
        Else
            'NO DESARROLLADO AUN EL MODULO DE PAGOS 
            'Se va al modulo de ingreso de pagos
            'If ConPagos Then
            'With ModuloFPagos
            '    .Show
            '    .xNumero = xNumero
            '    .xTipoDoc = cTipoDoc.Text
            '    .xFPago = cFPago.Text
            '    .xCliente = xCliente.Text
            '    .xFecha = xFecha.Value
            '    .xNombre = xNombre
            '    .xVendedor = xVendedor
            '    .xMonto = xTotal
            'End With

            'Me.Enabled = False
            '    While Me.Enabled = False
            '        DoEvents()
            '    End While

            '    'Verificar que se le hayan hecho los pagos
            '    DocP = SQL("Select * from DocumentosP where Local=" + Num(LocalActual) + " and TipoDoc = '" + xTipoDoc + "' and Numero =" + Num(xNumero.Text))
            '    If DocP.RecordCount = 0 Then
            '        MsgError("No se registraron pagos, documento no registrado.")
            '        Exit Sub
            '    End If
            'End If
        End If
        '--------------------------------------
        Dim wDocG As New T_DocumentosG

        If DTE.FE_EsElectronica Then
            If DTE.Es_Electronico(TipoDoc) Then
                wDocG.DTE = True
            Else
                wDocG.DTE = False
            End If
        End If

        wDocG.Local = G_LOCALACTUAL
        wDocG.TipoDoc = TipoDoc
        wDocG.Numero = CInt(xNumDoc.Text)
        wDocG.Ticket = 0
        wDocG.Electronica = Electronico
        wDocG.Fecha = xFecha.Value
        wDocG.Estado = CChar("A")
        wDocG.Bodega = BodegaParcial
        wDocG.Cliente = CInt(xCliente.Text)
        wDocG.Rut = xRut.Text
        wDocG.Aprobado = True
        wDocG.FPago = xFPago
        wDocG.Observaciones = Trim(xObs.Text)
        wDocG.Usuario = UsuarioActual
        wDocG.Vendedor = xVendedor.Text
        wDocG.SubTotal = CDbl(xSubTotal.Text)
        wDocG.Descuento = CDbl(xDescuento.Text)
        wDocG.Firma = New Byte() {}
        wDocG.TED = ""

        If cTipoDocRef.Text.ToString.Trim = "Orden de Compra" Then
            wDocG.OC = Trim(xNumDocRef.Text)
        Else
            wDocG.OC = ""
        End If
        wDocG.Motivo = CChar(xMotivo)
        wDocG.Neto = CInt(Val(xNeto.Text))
        wDocG.IVA = CInt(Val(xIVA.Text))
        wDocG.EXE = 0
        wDocG.MIN = CInt(Val(xMIN.Text))
        wDocG.BEB = CInt(Val(xBEB.Text))
        wDocG.VIN = CInt(Val(xVIN.Text))
        wDocG.CER = CInt(Val(xCER.Text))
        wDocG.LIC = CInt(Val(xLIC.Text))
        wDocG.CAR = CInt(Val(xCAR.Text))
        wDocG.HAR = CInt(Val(xHAR.Text))
        wDocG.TAB = CInt(Val(xTAB.Text))
        wDocG.FEP = CInt(Val(xFEP.Text))
        wDocG.LGT = 0
        wDocG.OTRO = 0
        wDocG.Total = CDbl(Val(xTotal.Text))

        'Agregar Referencias
        If Trim(wTipoDocR) <> "" Then
            Dim wTipoDocRef = DC.T_TipoDoc.FirstOrDefault(Function(x) x.TipoDoc = wTipoDocR)
            Dim wTributario As Boolean = False

            If wTipoDocRef IsNot Nothing Then
                wTributario = wTipoDocRef.Contable
            End If

            Dim wDocR As New T_DocumentosR With {
                .Local = G_LOCALACTUAL,
                .TipoDoc = TipoDoc,
                .Numero = CInt(xNumDoc.Text),
                .TipoDocRef = wTipoDocRef.TipoDoc,
                .NumDocRef = xNumDocRef.Text.ToString,
                .FechaRef = xFechaDocRef.Value,
                .Tributario = wTributario
            }
            DC.T_DocumentosR.InsertOnSubmit(wDocR)
            DC.SubmitChanges()
        End If

        wDocG.RutTransporte = "00.000.000-0"
        wDocG.NombreTransporte = ""
        wDocG.RutChofer = "00.000.000-0"
        wDocG.NombreChofer = ""
        wDocG.PatenteMovil = ""
        wDocG.DTE = DTE.FE_EsElectronica
        wDocG.STATUS_DTE = EstadosSII.No_Enviado
        wDocG.StockTraspasado = False
        DC.T_DocumentosG.InsertOnSubmit(wDocG)
        DC.SubmitChanges()

        For i = 1 To xTabla.Rows.Count - 1
            Dim wDocD As New T_DocumentosD
            wDocD.Local = G_LOCALACTUAL
            wDocD.TipoDoc = TipoDoc
            wDocD.Numero = CInt(xNumDoc.Text)
            wDocD.Articulo = Convert.ToDecimal(xTabla.GetData(i, T_ARTICULO).ToString)
            wDocD.Cantidad = Val(xTabla.GetData(i, T_CANTIDAD))
            wDocD.Neto = Val(xTabla.GetData(i, T_NETO))
            wDocD.IVA = CInt(xTabla.GetData(i, T_IVA))
            wDocD.PVenta = CInt(xTabla.GetData(i, T_PVENTA))
            If Trim(xTabla.GetData(i, T_ARTICULO).ToString) = "0" Then
                wDocD.Glosa = xTabla.GetData(i, T_DESCRIPCION).ToString
            Else
                wDocD.Glosa = ""
            End If
            DC.T_DocumentosD.InsertOnSubmit(wDocD)
            DC.SubmitChanges()

            'Actualizar Stocks
            If xTabla.GetData(i, T_ARTICULO).ToString.Trim <> "0" Then
                Stocks(Trim(xTabla.GetData(i, T_ARTICULO).ToString).ToDecimal, G_BODEGA, G_LOCALACTUAL, xTabla.GetData(i, T_CANTIDAD).ToString.ToDecimal, MODO_BODEGA)
                Tracking.Ingresar(Tracking.Eventos.StockDisminuido, Now, wDocG.Cliente, wDocG.TipoDoc, wDocG.Numero, Now, wDocD.Articulo, wDocD.Cantidad.ToDecimal(), G_BODEGA, G_LOCALACTUAL, "", Me.Text)
            End If
        Next i

        'Facturación Electrónica
        Try
            'Parametrizar con datos del Local
            If Not DTE.Parametros_DTE(G_LOCALACTUAL) Then
                Aceptar.Enabled = True
                Cursor = Cursors.Arrow
                MsgError("Error al sacar parámetros del Local.")
            Else
                If DTE.FE_EsElectronica Then
                    If DTE.Es_Electronico(TipoDoc) Then
                        'Generar TED
                        Dim wCli = SQL("SELECT * FROM Clientes WHERE Cliente = " & Val(xCliente.Text)).Top
                        If Not DTE.Generar_TED(G_LOCALACTUAL, cTipoDoc.SelectedValue.ToString, Val(xNumDoc.Text), xFecha.Value, xRut.Text, xNombre.Text.Trim, Val(xTotal.Text), "").Estado Then
                            Aceptar.Enabled = True
                            Cursor = Cursors.Arrow
                            MsgError("Error al Generar TED.")
                        Else
                            'Envio al DTE                        
                            If DTE.Emitir_DTE(G_LOCALACTUAL, TipoDoc, Val(xNumDoc.Text)) Then
                                Aceptar.Enabled = True
                                Cursor = Cursors.Arrow
                            Else
                                Aceptar.Enabled = True
                                Cursor = Cursors.Arrow
                                MsgError("Error al enviar documento.")
                            End If
                        End If
                    Else
                        'El documento no es eelectronico, por lo tanto no hay timbre ni envio a SII
                    End If
                End If
            End If
        Catch ex As Exception
            Aceptar.Enabled = True
            Cursor = Cursors.Arrow
            MsgError("Error al generar DTE, revise el documento en portal DTE.")
        End Try

        Aceptar.Enabled = True
        Cursor = Cursors.Arrow
        Mensaje(cTipoDoc.Text + " N°" & Val(xNumDoc.Text) & " Ingresada.")
        G_TIPOCOPIA = {1, 2, 3}.ToList

        Auditoria(Me.Text, A_GUARDADO, "", "0")

        If P_IMPRIMIRDOCUMENTO Then
            Imprimir_Documento(Val(G_LOCALACTUAL), TipoDoc, Val(xNumDoc.Text), cTipoDoc.Text, G_TIPOCOPIA)
        End If

        LimpiarCampos(True)
        xNumDoc.Text = BuscarCorrelativo(ModoCorrelativo.Consultar, If(cTipoDoc.SelectedValue?.ToString, ""), xFecha.Value, CInt(G_POS.ToText)).ToString()

    End Sub

    Private Sub Agregar(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bAgregar.Click
        AgregarArticulo(1)
    End Sub

    Private Sub AgregarArticulo(Cantidad As Decimal, Optional EditarCantidad As Boolean = True)
        Dim DC = New RebuscoDataContext(P_CONEXION)

        If G_IDCLIENTE = Clientes.Wikets Then
            If xArticulo.Text.Trim = "" And xCliente.Text.Trim <> "" Then
                Dim wGlosa = DC.T_Clientes.FirstOrDefault(Function(X) X.Cliente = xCliente.Text.ToDecimal)
                If wGlosa IsNot Nothing Then
                    If wGlosa.Glosa.Trim <> "" Then
                        xArticulo.Text = "0"
                        xDescripcion.Text = wGlosa.Glosa
                    Else
                        xArticulo.Text = "0"
                        xDescripcion.Text = "."
                    End If
                Else
                    xArticulo.Text = "0"
                    xDescripcion.Text = "."
                End If
            End If
        End If

        Dim xBarra As String

        xArticulo.Focus()
        xArticulo_Cargar()

        If Trim(xDescripcion.Text) <> "" Then
            Dim wArt = SQL("Select * from Articulos where Articulo = '" & xArticulo.Text.Trim & "'").Top
            If Esta_en_Tabla(xArticulo.Text) = 0 Then
                xTabla.AddItem("")
                xTabla.SetCellImage(xTabla.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
                xTabla.SetData(xTabla.Rows.Count - 1, T_ID, "")
                xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, wArt.GetText("Articulo"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, xDescripcion.Text.Trim)

                If G_IDCLIENTE = Clientes.Wikets Then
                    'Automatización de Glosa
                    If Trim(wArt.GetText("Articulo")) = "0" And xTabla.Rows.Count - 1 = 1 Then
                        xDescripcion.Text = xGlosa
                        xDescripcion.Text = Replace(xDescripcion.Text, "%", UCase(ObtenerMes(Now.Month.ToString)) & " " & Now.Year)  'Mes de la Factura
                        xDescripcion.Text = Replace(xDescripcion.Text, "#", CType(IIf(Now.Month = 1, UCase(ObtenerMes("12")), UCase(ObtenerMes((Now.Month - 1).ToString))), String) & " " & CType(IIf(Now.Month = 1, Now.Year - 1, Now.Year), String))
                        xDescripcion.Text = Replace(xDescripcion.Text, "&", Format(Now.Date, "dd/MM/yyyy"))
                        xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, Trim(xDescripcion.Text))
                    End If
                End If

                xTabla.SetData(xTabla.Rows.Count - 1, T_UNIDAD, wArt.GetText("Unidad"))
                xBarra = ""
                Dim wBar = SQL("Select Top 1 Barra from Barras where Articulo = '" & xArticulo.Text & "'").Top
                If wBar IsNot Nothing Then
                    xBarra = wBar.GetText("Barra")
                End If
                xTabla.SetData(xTabla.Rows.Count - 1, T_BARRA, xBarra)
                xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDAD, Cantidad)
                If xArticulo.Text = "0" Then
                    xTabla.SetData(xTabla.Rows.Count - 1, T_NETO, 0)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_PVENTA, 0)
                Else
                    xTabla.SetData(xTabla.Rows.Count - 1, T_PVENTA, wArt.GetText("PVenta"))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_NETO, CalcularNETO(wArt.GetDecimal("PVenta")))
                End If
                xTabla.SetData(xTabla.Rows.Count - 1, T_SUBTOTAL, 0)
                CalcularTotal()
                Limpiar_Articulo()
                xTabla.Focus()

                If G_IDCLIENTE = Clientes.Wikets Then
                    xTabla.Col = T_DESCRIPCION
                    If xTabla.GetData(xTabla.Rows.Count - 1, T_DESCRIPCION).ToString = "." Then
                        xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, "SERVICIOS INFORMATICOS")
                    End If
                    xTabla.Row = xTabla.Rows.Count - 1
                Else
                    xTabla.Col = T_CANTIDAD
                End If
                If EditarCantidad Then
                    xTabla.Focus()
                    xTabla_Click()
                End If
            Else
                MsgError("Articulo ya Ingresado")
            End If
        End If

    End Sub

    Private Sub bBuscarCli_Click(sender As Object, e As EventArgs) Handles bBuscarCli.Click
        Dim wQuery As String
        wQuery = "SELECT Cliente,Rut,Nombre From Clientes"
        Buscador.Show()
        Buscador.BringToFront()
        Buscador.Configurar(wQuery, "Nombre", Me, "Clientes", xCliente)
    End Sub

    Private Sub bProcesarDoc_Click(sender As Object, e As EventArgs) Handles bProcesarDoc.Click
        'Evaluar Documento de referecia no pertenezca a otro documento no Nulo (falta)
        'TICKET

        If If(cTipoDocRef.SelectedValue?.ToString, "") = "" Then
            MsgError("Debe seleccionar un tipo de documento")
            Exit Sub
        End If

        If cTipoDocRef.SelectedValue.ToString = "OT" Then
            CargarOT()
            Exit Sub
        End If

        If cTipoDocRef.Text = "Ticket" Then
            If Val(xNumDocRef.Text) > 0 Then
                Dim wTikG = SQL("Select * from TikGen where Ticket = " & Val(xNumDocRef.Text)).Top
                If wTikG IsNot Nothing Then
                    If wTikG.GetText("Estado") = "E" Or wTikG.GetText("Estado") = "V" Then
                        If CDate(Format(wTikG("Fecha"), "dd/mm/yyyy")) = xFecha.Value Then
                            Cargar_Ticket()
                        Else
                            MsgError("Ticket fuera de fecha")
                            Exit Sub
                        End If
                    Else
                        MsgError("Ticket No se puede usar")
                        Exit Sub
                    End If
                Else
                    MsgError("Ticket No Encontrado")
                    Exit Sub
                End If
            End If
            Exit Sub
        End If

        'OTROS DOCUMENTOS
        Titulos()

        If xNumDocRef.Text = "" Then
            MsgError("Falta Número de Documento")
            Exit Sub
        End If

        Dim DocRef = SQL("Select Numero, Fecha, Cliente from DocumentosG where Numero=" & Val(xNumDocRef.Text) & " and Local = " & Val(G_LOCALACTUAL) &
                   " and TipoDoc = '" & cTipoDocRef.SelectedValue.ToString() & "' and Estado = 'A'").Top

        If DocRef IsNot Nothing Then
            xCliente.Text = DocRef.GetText("Cliente")
            xCliente_Validating(Nothing, Nothing)
            If xNombre.Text.Trim = "" Then
                Exit Sub
            End If
            Dim wDocD = SQL("Select * from DocumentosD where Numero=" & Val(xNumDocRef.Text) & " and Local = " & Val(G_LOCALACTUAL) &
                   " and TipoDoc = '" & cTipoDocRef.SelectedValue.ToString() & "'")
            If wDocD.Rows.Count = 0 Then
                MsgError("Error en detalle de documento referencia")
                Exit Sub
            End If
            xFechaDocRef.Value = CDate(DocRef.GetText("Fecha"))
            For Each wD As DataRow In wDocD.Rows
                xArticulo.Text = wD.GetText("Articulo")
                AgregarArticulo(1, False)
                'xTabla.AddItem("")
                xTabla.SetCellImage(xTabla.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
                If wD.GetText("Glosa") <> "" Then
                    xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wD.GetText("Glosa"))
                End If
                xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDAD, Trim(wD.GetText("Cantidad")))
                xTabla.SetData(xTabla.Rows.Count - 1, T_NETO, Trim(wD.GetText("Neto")))
                CalcularTotal()
            Next


            If cTipoDocRef.Text = "Cotización" Then
                bAgregar.Enabled = False
                BuscarArt.Enabled = False
                bLimpiarArt.Enabled = False
                xArticulo.Enabled = False
                xDescripcion.Enabled = False
                xCliente.Enabled = False
                bBuscarCli.Enabled = False
                bCrearCli.Enabled = False
            Else
                bAgregar.Enabled = True
                xCliente.Enabled = True
                BuscarArt.Enabled = True
                bLimpiarArt.Enabled = True
                xArticulo.Enabled = True
                xDescripcion.Enabled = True
                bBuscarCli.Enabled = True
                bCrearCli.Enabled = True
            End If
        Else
            MsgError("No se Encontró Documento Referencia")
        End If
        xArticulo.Focus()
    End Sub

    Dim ListaOT As New List(Of Decimal)
    Private Sub CargarOT()

        If Trim(xNumDocRef.Text) = "" Or Val(xNumDocRef.Text) <= 0 Then
            MsgError("El Campo OT no puede estar vacío")
            Exit Sub
        End If

        Dim Ven = SQL("SELECT e.DescEstado,o.Estado,c.Cliente " &
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

        xCliente.Text = Ven.GetText("Cliente")
        xCliente_Validating()

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
            xArticulo.AutoCompletarActivo = True
            AgregarArticulo(wArtD.GetText("Cantidad").ToDecimal, False)
        Next

        ListaOT.Add(xNumDocRef.ToDecimal)

        Mensaje($"OT {xNumDocRef.ToDecimal} carga exitosamente.", "OT cargada")

    End Sub

    Private Sub bCrearCli_Click(sender As Object, e As EventArgs) Handles bCrearCli.Click
        ManCliente.Show()
        ManCliente.xCliente.Text = xCliente.Text
        ManCliente.Focus()
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bLimpiarArt_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiarArt.Click
        Limpiar_Articulo()
    End Sub

    Private Sub Limpiar_Articulo()
        xArticulo.Text = ""
        xDescripcion.Text = ""
        xArticulo.Focus()
    End Sub


    Private Sub BuscarArt_Click(sender As Object, e As EventArgs) Handles BuscarArt.Click
        Dim wBuscador = New BuscadorArticulo
        wBuscador.Configurar(Me, xArticulo)
        wBuscador.ShowDialog()
        xArticulo.Focus()
    End Sub

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub cTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cTipoDoc.SelectedIndexChanged


        Dim DocSeleccionado = If(cTipoDoc.SelectedValue?.ToString, "")
        If DocSeleccionado = "" Then Exit Sub

        Dim wTipoDoc = SQL("Select * from TipoDoc where DescTipoDoc = '" & cTipoDoc.Text & "'").Top

        If wTipoDoc IsNot Nothing Then
            oElectronico.Checked = wTipoDoc.GetBool("Electronica")
        Else
            cTipoDoc.Text = ""
            oElectronico.Checked = False
        End If

        If DocSeleccionado = "GD" Or DocSeleccionado = "NC" Or DocSeleccionado = "ND" Then
            cMotivo.LoadItemsObj("Motivos", "Motivo", "DescMotivo", "WHERE TipoDoc = '" & DocSeleccionado & "' and DescMotivo <> '' Order By DescMotivo")
            cMotivo.SelectedIndex = -1
        Else
            cMotivo.LoadItemsObj("Motivos", "Motivo", "DescMotivo", "WHERE TipoDoc = '" & DocSeleccionado & "' and Motivo = 'X' Order By DescMotivo")
            cMotivo.SelectedIndex = -1
        End If

        cMotivo.Text = ""

        'Ver Documentos Referencia
        'cTipoDocRef.Items.Clear()
        'cTipoDocRef.Items.Add("")
        'If cTipoDoc.Text <> "" Then
        '    Dim wDocRef = SQL("Select TipoDocRef from DocumentosRef where TipoDoc = '" & DocSeleccionado & "'")
        '    For Each wDocR As DataRow In wDocRef.Rows
        '        Dim wTipoD = SQL("Select TipoDoc, DescTipoDoc from TipoDoc where TipoDoc = '" & wDocR.GetText("TipoDocRef") & "'").Top
        '        If wTipoD IsNot Nothing Then
        '            cTipoDocRef.DisplayMember = "Desc"
        '            cTipoDocRef.ValueMember = "ID"
        '            Dim item = New ItemCombo(wTipoD.GetText("TipoDoc"), wTipoD.GetText("DescTipoDoc"))
        '            cTipoDocRef.Items.Add(item)
        '        End If
        '    Next
        'End If

        cTipoDocRef.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", $" WHERE TipoDoc IN (SELECT TipoDocRef FROM DocumentosRef WHERE TipoDoc = '{DocSeleccionado}')", True, "", "")
        xNumDoc.Text = BuscarCorrelativo(ModoCorrelativo.Consultar, If(cTipoDoc.SelectedValue?.ToString, ""), xFecha.Value, CInt(G_POS.ToText)).ToString()

        'Factura Exenta
        If DocSeleccionado = "FE" Then
            xIVA.BackColor = Color.Red
        Else
            xIVA.BackColor = xNeto.BackColor
        End If
    End Sub

    Private Sub Documentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Titulos()
        cTipoDoc.Items.Clear()
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", "ORDER BY DescTipoDoc", True, "", "")
        cFPago.LoadItemsObj("FPagos", "Fpago", "DescFPago", "ORDER BY Orden")
        cMotivo.LoadItemsObj("Motivos", "Motivo", "DescMotivo")
        xVendedor.Text = UsuarioActual
        xFecha.Value = Now.Date

        Dim wLoc = SQL("Select NombreLocal from Locales where Local = " & G_LOCALACTUAL.ToString).Top
        If wLoc IsNot Nothing Then
            WinDeco1.Titulo.Text = "Emitir Documentos - " & wLoc.GetText("NombreLocal").ToUpper
            xLocal.Text = wLoc.GetText("NombreLocal")
        Else
            xLocal.Text = ""
        End If

        If Not G_SUPERVISOR Then
            xVendedor.Text = ""
            xVendedor.Enabled = True
            xVendedor.ReadOnly = False
        Else
            xVendedor.Text = UsuarioActual
        End If
        Auditoria(Me.Text, A_INGRESADO, "", "0")

        If G_IDCLIENTE = Clientes.Wikets Then
            Dim wTD = SQL("Select DescTipoDoc from TipoDoc where TipoDoc = 'FV'").Top
            If wTD IsNot Nothing Then
                cTipoDoc.Text = wTD.GetText("DescTipoDoc")
            End If
            Dim wFP = SQL("Select DescFPago from FPagos where FPago = 'T'").Top
            If wFP IsNot Nothing Then
                cFPago.Text = wFP.GetText("DescFPago")
            End If
            xCliente.Focus()
        End If

    End Sub

    Private Sub Limpiar(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos(Optional wForzar As Boolean = False)
        If Not wForzar Then
            If xTabla.Rows.Count > 1 Then
                If Not Pregunta("¿Desea Limpiar Datos?") Then
                    Exit Sub
                End If
            End If
        End If

        xFecha.Value = Now.Date
        xNumDoc.Text = ""
        'cTipoDoc.SelectedIndex = 0     'Mantener el último tipo de documento emitido
        cFPago.Text = "Efectivo"
        xRut.Text = "__.___.___-_"
        xNombre.Text = ""
        xCiudad.Text = ""
        xComuna.Text = ""
        xFantasia.Text = ""
        xArticulo.Text = ""
        xDescripcion.Text = ""
        xObs.Text = ""
        xGlosa = ""
        Titulos()
        xSubTotal.Text = "0"
        xDescuento.Text = "0"
        xNeto.Text = "0"
        xIVA.Text = "0"
        xTotal.Text = "0"
        xNumDocRef.Text = ""
        oElectronico.Checked = True

        xFEP.Text = "0"
        xHAR.Text = "0"
        xCAR.Text = "0"
        xTAB.Text = "0"
        xMIN.Text = "0"
        xBEB.Text = "0"
        xCER.Text = "0"
        xVIN.Text = "0"
        xLIC.Text = "0"

        If Not G_SUPERVISOR Then
            xVendedor.Text = ""
            xVendedor.Enabled = True
            xVendedor.ReadOnly = False
        Else
            xVendedor.Text = UsuarioActual
        End If

        xNumDocRef.Text = ""
        cTipoDocRef.SelectedIndex = -1
        xFechaDocRef.Value = CDate("01/01/2000")
        xCliente.Text = ""
        xDireccion.Text = ""
        nLineas.Text = "0"
        cTipoDocRef.Text = ""
        CalcularTotal()
        bAgregar.Enabled = True
        BuscarArt.Enabled = True
        bLimpiarArt.Enabled = True
        xArticulo.Enabled = True
        xDescripcion.Enabled = True
        xCliente.Enabled = True
        bBuscarCli.Enabled = True
        bCrearCli.Enabled = True
        xFechaDocRef.Enabled = False

        If cTipoDoc.SelectedValue Is Nothing Then
            xNumDoc.Text = BuscarCorrelativo(ModoCorrelativo.Consultar, If(cTipoDoc.SelectedValue?.ToString, ""), xFecha.Value, CInt(G_POS.ToText)).ToString()
        End If

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub Documentos_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If xTabla.Rows.Count - 1 > 0 Then
            If Not Pregunta("¿Desea Salir?") Then
                e.Cancel = True
            End If
        End If
    End Sub
    Sub Titulos()
        xTabla.Redraw = True

        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 23

        xTabla.SetData(0, T_ELIMINAR, "")
        xTabla.SetData(0, T_ID, "Id")
        xTabla.SetData(0, T_ARTICULO, "Artículo")
        xTabla.SetData(0, T_DESCRIPCION, "Descripción")
        xTabla.SetData(0, T_UNIDAD, "Unidad")
        xTabla.SetData(0, T_BARRA, "Barra")
        xTabla.SetData(0, T_CANTIDAD, "Cantidad")
        xTabla.SetData(0, T_NETO, "Precio Neto")
        xTabla.SetData(0, T_PVENTA, "Precio Venta")
        xTabla.SetData(0, T_SUBTOTAL, "SubTotal")

        xTabla.SetData(0, T_IVA, "IVA")
        xTabla.SetData(0, T_EXE, "EXE")
        xTabla.SetData(0, T_MIN, "MIN")
        xTabla.SetData(0, T_BEB, "BEB")
        xTabla.SetData(0, T_VIN, "VIN")
        xTabla.SetData(0, T_CER, "CER")
        xTabla.SetData(0, T_LIC, "LIC")
        xTabla.SetData(0, T_CAR, "CAR")
        xTabla.SetData(0, T_HAR, "HAR")
        xTabla.SetData(0, T_TAB, "TAB")
        xTabla.SetData(0, T_FEP, "FEP")
        xTabla.SetData(0, T_LOG, "LOG")
        xTabla.SetData(0, T_OTRO, "OTRO")

        xTabla.Cols(T_ELIMINAR).Width = 30
        xTabla.Cols(T_ID).Width = 0
        xTabla.Cols(T_ARTICULO).Width = 100
        xTabla.Cols(T_DESCRIPCION).Width = 360
        xTabla.Cols(T_UNIDAD).Width = 80
        xTabla.Cols(T_BARRA).Width = 0
        xTabla.Cols(T_CANTIDAD).Width = 100
        xTabla.Cols(T_NETO).Width = 100
        xTabla.Cols(T_SUBTOTAL).Width = 100

        xTabla.Cols(T_IVA).Width = 0
        xTabla.Cols(T_EXE).Width = 0
        xTabla.Cols(T_MIN).Width = 0
        xTabla.Cols(T_BEB).Width = 0
        xTabla.Cols(T_VIN).Width = 0
        xTabla.Cols(T_CER).Width = 0
        xTabla.Cols(T_LIC).Width = 0
        xTabla.Cols(T_CAR).Width = 0
        xTabla.Cols(T_HAR).Width = 0
        xTabla.Cols(T_TAB).Width = 0
        xTabla.Cols(T_FEP).Width = 0
        xTabla.Cols(T_LOG).Width = 0
        xTabla.Cols(T_OTRO).Width = 0

        xTabla.Cols(T_ID).TextAlign = TextAlignEnum.LeftCenter
        xTabla.Cols(T_ARTICULO).TextAlign = TextAlignEnum.LeftCenter
        xTabla.Cols(T_DESCRIPCION).TextAlign = TextAlignEnum.LeftCenter
        xTabla.Cols(T_UNIDAD).TextAlign = TextAlignEnum.LeftCenter
        xTabla.Cols(T_BARRA).TextAlign = TextAlignEnum.LeftCenter
        xTabla.Cols(T_CANTIDAD).TextAlign = TextAlignEnum.RightCenter
        xTabla.Cols(T_NETO).TextAlign = TextAlignEnum.RightCenter
        xTabla.Cols(T_PVENTA).TextAlign = TextAlignEnum.RightCenter
        xTabla.Cols(T_SUBTOTAL).TextAlign = TextAlignEnum.RightCenter

        xTabla.Cols(T_CANTIDAD).TextAlignFixed = TextAlignEnum.RightCenter
        xTabla.Cols(T_NETO).TextAlignFixed = TextAlignEnum.RightCenter
        xTabla.Cols(T_PVENTA).TextAlignFixed = TextAlignEnum.RightCenter
        xTabla.Cols(T_SUBTOTAL).TextAlignFixed = TextAlignEnum.RightCenter
        xTabla.Cols(T_ELIMINAR).ImageAlign = ImageAlignEnum.CenterCenter
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(bAgregar)
    End Sub

    Sub xArticulo_Cargar()
        If Trim(xArticulo.Text) <> "" Then
            xArticulo.Text = ObtenerArticulo(xArticulo.Text)
            If Trim(xArticulo.Text) = "" Then
                MsgError("Artículo No Existe")
                bLimpiarArt_Click()
            Else
                Dim wArt = SQL("Select * from Articulos where Articulo = '" & Trim(xArticulo.Text) & "'").Top
                If wArt IsNot Nothing Then
                    xDescripcion.Text = wArt.GetText("Descripcion")
                    bAgregar.Focus()
                Else
                    MsgError("Artículo No Encontrado")
                    Call bLimpiarArt_Click()
                End If
            End If
        End If
    End Sub

    Private Sub xFEPP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xFEP.KeyPress
        If e.KeyChar = vbCr Then
            CalcularTotal()
        End If
    End Sub

    Private Sub xMIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMIN.KeyPress
        If e.KeyChar = vbCr Then
            CalcularTotal()
        End If
    End Sub

    Private Sub xCER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMIN.KeyPress
        If e.KeyChar = vbCr Then
            CalcularTotal()
        End If
    End Sub

    Private Sub xVIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMIN.KeyPress
        If e.KeyChar = vbCr Then
            CalcularTotal()
        End If
    End Sub

    Private Sub xLIC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMIN.KeyPress
        If e.KeyChar = vbCr Then
            CalcularTotal()
        End If
    End Sub

    Private Sub xCAR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMIN.KeyPress
        If e.KeyChar = vbCr Then
            CalcularTotal()
        End If
    End Sub

    Private Sub xIHA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMIN.KeyPress
        If e.KeyChar = vbCr Then
            CalcularTotal()
        End If
    End Sub

    Private Sub xTAB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMIN.KeyPress
        If e.KeyChar = vbCr Then
            CalcularTotal()
        End If
    End Sub

    Private Sub xBEB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMIN.KeyPress
        If e.KeyChar = vbCr Then
            CalcularTotal()
        End If
    End Sub

    Private Sub xCliente_GotFocus(sender As Object, e As EventArgs) Handles xCliente.GotFocus
        xCliente.SelectAll()
    End Sub

    Private Sub xDescuento_TextChanged(sender As Object, e As EventArgs) Handles xDescuento.TextChanged
        Call CalcularTotal()
    End Sub
    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        e.NextControl(xArticulo)
    End Sub

    Private Sub xNumDocRef_GotFocus(sender As Object, e As EventArgs) Handles xNumDocRef.GotFocus
        xNumDocRef.SelectAll()
    End Sub

    Private Sub xTabla_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles xTabla.Click
        Try
            If xTabla.GetData(xTabla.Row, T_ARTICULO).ToString = "0" Then
                If xTabla.Col = T_CANTIDAD Or xTabla.Col = T_NETO Or xTabla.Col = T_DESCRIPCION Then
                    xTabla.StartEditing()
                End If
            Else
                If xTabla.Col = T_CANTIDAD Then
                    xTabla.StartEditing()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub xRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xRut.KeyPress
        e.NextControl(xArticulo)
    End Sub

    Private Sub xTabla_AfterEdit(sender As Object, e As RowColEventArgs) Handles xTabla.AfterEdit
        If xTabla.Col <> T_DESCRIPCION Then
            If Not IsNumeric(xTabla.GetData(xTabla.Row, xTabla.Col)) Then
                MsgError("Cantidad Incorrecta")
                xTabla.SetData(xTabla.Row, xTabla.Col, 0)
                Exit Sub
            End If

            If xTabla.Col = T_NETO And xTabla.GetData(xTabla.Row, T_ARTICULO).ToString = "0" Then
                xTabla.SetData(xTabla.Row, T_NETO, CDbl(xTabla.GetData(xTabla.Row, T_NETO)))
                xTabla.SetData(xTabla.Row, T_PVENTA, Math.Round(CDbl(xTabla.GetData(xTabla.Row, T_NETO)) * (1 + (G_IVA / 100)), 0))
            End If
            Call CalcularTotal()
        Else
            xTabla.Col = T_NETO
        End If
        nLineas.Text = (xTabla.Rows.Count - 1).ToString
    End Sub

    Sub CalcularTotal()
        Dim Total As Double, iLineas As Integer
        Dim wSubTotal As Double

        If xIVA.Text = "" Then xIVA.Text = "0"

        xImpuestos.Text = (Val(xFEP.Text) + Val(xTAB.Text) + Val(xMIN.Text) + Val(xBEB.Text) + Val(xVIN.Text) + Val(xCER.Text) + Val(xLIC.Text) + Val(xCAR.Text) + Val(xHAR.Text)).ToString

        Dim DocSeleccionado = If(cTipoDoc.SelectedValue?.ToString, "")

        Total = 0 : iLineas = 0
        For i = 1 To xTabla.Rows.Count - 1
            If Not IsNumeric(xTabla.GetData(i, T_CANTIDAD)) Then
                MsgError("Cantidad Incorrecta")
                xTabla.SetData(i, T_CANTIDAD, 0)
            End If
            Try
                If xTabla.GetData(i, T_CANTIDAD).ToString = "" Then xTabla.SetData(i, T_CANTIDAD, 0)
                If xTabla.GetData(i, T_NETO).ToString = "" Then xTabla.SetData(i, T_NETO, 0)
                If (If(xTabla.GetData(i, T_SUBTOTAL)?.ToString(), "")) = "" Then xTabla.SetData(i, T_SUBTOTAL, 0)
            Catch ex As Exception
            End Try

            wSubTotal = Math.Round(Val(xTabla.GetData(i, T_CANTIDAD)) * Val(xTabla.GetData(i, T_NETO)), 0, MidpointRounding.AwayFromZero)

            If wSubTotal > MaxDouble Then
                MsgError("El SubTotal es demasiado alto, se debe ajustar el Precio o la Cantidad del Artículo:   " & xTabla.GetData(i, T_DESCRIPCION).ToString)
                xTabla.SetData(i, T_NETO, 1)
                i -= 1
                Continue For
            End If



            xTabla.SetData(i, T_SUBTOTAL, Math.Round(Val(xTabla.GetData(i, T_CANTIDAD)) * Val(xTabla.GetData(i, T_NETO)), 3))
            If DocSeleccionado = "FE" Or (xTipoDocRef.Text = "FE" And (DocSeleccionado = "NC" Or DocSeleccionado = "ND")) Then  'Factura Exenta
                xTabla.SetData(i, T_IVA, 0)
            Else
                xTabla.SetData(i, T_IVA, Math.Round((G_IVA / 100) * wSubTotal, 0, MidpointRounding.AwayFromZero))
            End If
            Total = Total + CDbl(xTabla.GetData(i, T_SUBTOTAL))
            iLineas = iLineas + 1
        Next i

        xSubTotal.Text = Math.Round(Total, 0).ToString
        If xDescuento.Text = "" Then xDescuento.Text = "0"
        If xImpuestos.Text = "" Then xImpuestos.Text = "0"
        xNeto.Text = Math.Round(Total - CDbl(xDescuento.Text), 0).ToString

        'Faturas Exentas o Anulacion de ellas por NC o ND no llevan IVA
        If DocSeleccionado = "FE" Or (xTipoDocRef.Text = "FE" And (DocSeleccionado = "NC" Or DocSeleccionado = "ND")) Then  'Factura Exenta
            xIVA.Text = "0"
        Else
            xIVA.Text = (Math.Round(Val(xNeto.Text) * (G_IVA / 100))).ToString
        End If
        xTotal.Text = CStr(CDbl(xNeto.Text) + CDbl(xIVA.Text) + CDbl(xImpuestos.Text))

        'Formatear Texto
        'xSubTotal.Text = Format(xSubTotal.Text, "###,###,###")
        'xDescuento.Text = Format(xDescuento.Text, "###,###,###")
        'xNeto.Text = Format(xNeto.Text, "###,###,###")
        'xIVA.Text = Format(xIVA.Text, "###,###,###")
        'xImpuestos.Text = Format(xImpuestos.Text, "###,###,###")
        'xTotal.Text = Format(xTotal.Text, "###,###,###")

        nLineas.Text = iLineas.ToString
    End Sub

    Private Sub xTabla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTabla.KeyPress
        If e.KeyChar = vbCr Then
            If xTabla.Col = T_CANTIDAD Or xTabla.Col = T_NETO Then
                xTabla.StartEditing()
            End If
        End If
        If e.KeyChar = "*" Then
            xArticulo.Focus()
        End If
    End Sub

    Private Sub xTabla_KeyPressEdit(sender As Object, e As KeyPressEditEventArgs) Handles xTabla.KeyPressEdit
        If e.KeyChar = vbCr Then
            If xTabla.Col = T_CANTIDAD Then
                If Val(xTabla.GetData(xTabla.Row, T_NETO)) > 0 Then
                    'xArticulo.focus
                Else
                    xTabla.Col = T_NETO
                    'SendKeys("{ENTER}")
                End If
            End If
        End If
        If xTabla.Col = T_NETO Then
            If e.KeyChar = Chr(32) Or e.KeyChar = vbLf Then
                e.Handled = True
            End If
        End If
    End Sub

    Function Esta_en_Tabla(tArticulo As Object) As Integer
        Esta_en_Tabla = 0
        For i = 1 To xTabla.Rows.Count - 1
            If xTabla.GetData(i, T_ARTICULO).ToString.Trim = tArticulo.ToString And Val(tArticulo) <> 0 Then
                Esta_en_Tabla = i
            End If
        Next i
    End Function

    Private Sub xVendedor_TextChanged(sender As Object, e As EventArgs) Handles xVendedor.TextChanged
        If Trim(xVendedor.Text) = "" Then
            xNomVen.Text = ""
            BodegaParcial = CInt(G_BODEGA)
            Exit Sub
        End If
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wUsr = DC.T_Usuarios.FirstOrDefault(Function(x) x.Usuario = xVendedor.Text.Trim)
        If wUsr IsNot Nothing Then
            xNomVen.Text = wUsr.NombreUsr
            BodegaParcial = CInt(wUsr.Bodega)
        Else
            xNomVen.Clear()
            BodegaParcial = CInt(G_BODEGA)
        End If
    End Sub

    Sub Cargar_Ticket()
        Dim Suma_Abonos As Double

        Titulos()

        Suma_Abonos = 0
        xTotal.Text = "0"
        xSubTotal.Text = "0"
        xDescuento.Text = "0"

        If Val(xNumDocRef.Text) = 0 Then
            Exit Sub
        End If

        Dim TikD = SQL("SELECT * FROM TikDet WHERE Ticket = " & Val(xNumDocRef.Text))
        If TikD.Rows.Count > 0 Then
            For Each wTikD As DataRow In TikD.Rows


                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_ID, "")
                xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, Trim(wTikD.GetText("Articulo")))
                Dim wArt = SQL("Select * from Articulos where Articulo = '" & Trim(wTikD.GetText("Articulo")) & "'").Top
                If wArt IsNot Nothing Then
                    xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wArt.GetText("Descripcion"))
                End If
                xTabla.SetData(xTabla.Rows.Count - 1, T_UNIDAD, Trim(wArt.GetText("Unidad")))
                xTabla.SetData(xTabla.Rows.Count - 1, T_BARRA, Trim(wTikD.GetText("Barra")))
                xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDAD, CDbl(wTikD("Cantidad")))
                xTabla.SetData(xTabla.Rows.Count - 1, T_NETO, CalcularNETO(wTikD.GetDecimal("PVenta")))
                xTabla.SetData(xTabla.Rows.Count - 1, T_SUBTOTAL, CDbl(xTabla.GetData(xTabla.Rows.Count - 1, T_CANTIDAD)) * CDbl(xTabla.GetData(xTabla.Rows.Count - 1, T_NETO)))
                bLimpiarArt_Click()
                xTabla.Focus()
                xTabla.Row = xTabla.Rows.Count - 1
                xTabla.Col = T_CANTIDAD
                xTabla_Click()

            Next
        End If

        Suma_Abonos = 0
        Dim wAbo = SQL("Select Sum(Total) as Abonado, sum(Descuento) as Descuentos from Ventas where Ticket = " & Val(xNumDocRef.Text)).Top
        If wAbo IsNot Nothing Then
            If Not IsDBNull(wAbo.GetText("Abonado")) Then
                Suma_Abonos = Val(wAbo.GetText("Abonado"))
                xDescuento.Text = Format(Suma_Abonos, "###,###,###")
            End If
            If Not IsDBNull(wAbo("Descuentos")) Then
                xDescuento.Text = wAbo.GetText("Descuentos")
            End If
        End If
        xTabla.Focus()
        CalcularTotal()

    End Sub

    Private Sub xVendedor_GotFocus(sender As Object, e As EventArgs) Handles xVendedor.GotFocus
        xVendedor.SelectAll()
    End Sub

    Public Function ValidarDeuda() As Boolean
        If xCliente.Text <> "" Then
            If cFPago.Text = "Crédito" Then
                If cTipoDoc.Text = "Factura de Venta" Then
                    Dim wDeuda, wPagado, wCredito, wSaldo, wTotalDeuda, wCupo As Double
                    Dim wCupos As String
                    Dim DC = New RebuscoDataContext(P_CONEXION)
                    Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = Val(xCliente.Text))
                    If wCli IsNot Nothing Then
                        'Sacar Total de Deuda
                        Dim wMov = SQL("SELECT Coalesce(SUM(Total),0) as Deuda FROM Documentosg " &
                                  " WHERE Cliente=" & Val(xCliente.Text) & " AND FPago='Cr' and TipoDoc='F'").Top

                        wDeuda = Val(wMov.GetText("Deuda"))

                        'Sacar Total Pagado
                        Dim wDoc = SQL("SELECT Coalesce(SUM(Monto),0) as Pagado FROM DocumentosP " &
                                       " WHERE Cliente=" & Val(xCliente.Text) & " AND TipoDoc='F' AND FPago='Cr'").Top

                        wPagado = Val(wDoc.GetText("Pagado"))
                        wSaldo = wDeuda - wPagado
                        wTotalDeuda = wSaldo + Val(xTotal.Text)
                        wCupo = wCredito - wSaldo

                        If wCupo < 0 Then
                            wCupos = "0"
                        Else
                            wCupos = Format(wCupo, "###,###,###")
                        End If

                        If wTotalDeuda > wCredito Then
                            MsgError("No se generará Factura de Venta al Cliente actual." & vbCrLf &
                                  "El Cliente cuenta con una deuda de $" & Format(wSaldo, "###,###,###") & vbCrLf &
                                  "Saldo Disponible a Favor de $" & wCupos)
                            ValidarDeuda = True
                            Exit Function
                        End If
                    End If
                End If
            End If
        End If
        ValidarDeuda = False
    End Function

    Private Sub cTipoDocRef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cTipoDocRef.SelectedIndexChanged
        xFechaDocRef.Enabled = False
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wTipoDoc = DC.T_TipoDoc.FirstOrDefault(Function(x) x.DescTipoDoc = cTipoDocRef.Text)
        If wTipoDoc IsNot Nothing Then
            xTipoDocRef.Text = wTipoDoc.TipoDoc
            If wTipoDoc.TipoDoc = "OC" Then
                xFechaDocRef.Enabled = True
                xFechaDocRef.Value = xFecha.Value
            End If
        Else
            cTipoDocRef.SelectedIndex = -1
            xTipoDocRef.Clear()
        End If
    End Sub


    Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs) Handles xTabla.DoubleClick
        Try
            If xTabla.Rows.Count > 1 Then
                If xTabla.Col = T_ELIMINAR Then
                    xTabla.RemoveItem(xTabla.Row)
                    CalcularTotal()
                End If
            End If
        Catch ex As Exception
            MsgError("No se pudo eliminar linea")
        End Try
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
            Dim DC = New RebuscoDataContext(P_CONEXION)
            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wIDArticulo.ToDecimal())
            If wArt IsNot Nothing Then
                xArticulo.AutoCompletarActivo = False
                xArticulo.Text = wArt.Articulo.ToString()
                xDescripcion.Text = wArt.Descripcion
                xArticulo.AutoCompletarActivo = True

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

        End If
    End Sub

    Private Sub xCliente_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xCliente.Validating
        Ver_Cliente
    End Sub

    Sub Ver_Cliente()
        If Not IsNumeric(xCliente.Text) Then
            Dim wCl = SQL("SELECT Cliente FROM Clientes WHERE Fantasia = '" & xCliente.Text.Trim & "'").Top
            If wCl IsNot Nothing Then
                xCliente.Text = wCl.GetText("Cliente")
            Else
                xCliente.Text = ""
                xNombre.Text = ""
                xRut.Text = "__.___.___-_"
                xDireccion.Text = ""
                xCiudad.Text = ""
                xComuna.Text = ""
                xFantasia.Text = ""
                xGlosa = ""
                xCliente.Focus()
            End If
        End If

        If Val(xCliente.Text) > 0 Then
            Dim wCli = SQL("SELECT * FROM Clientes WHERE Cliente = '" & xCliente.Text.Trim & "'").Top

            If wCli IsNot Nothing Then
                xRut.Text = wCli.GetText("Rut")
                xNombre.Text = wCli.GetText("Nombre")
                xDireccion.Text = wCli.GetText("Direccion")
                xCiudad.Text = BuscarCiudad(wCli.GetText("Ciudad"))
                xComuna.Text = BuscarComuna(wCli.GetText("Comuna"))
                xFantasia.Text = wCli.GetText("Fantasia")
                cFPago.SelectedValue = wCli.GetText("FPago").Trim
                xGlosa = wCli.GetText("Glosa").Trim
            Else
                MsgError("Cliente no Existe")
                xNombre.Text = ""
                xRut.Text = "__.___.___-_"
                xDireccion.Text = ""
                xCiudad.Text = ""
                xComuna.Text = ""
                xFantasia.Text = ""
                xGlosa = ""
                Exit Sub
            End If
        End If
    End Sub

    Private Sub xNumDoc_Validating(sender As Object, e As CancelEventArgs) Handles xNumDoc.Validating
        If Val(xNumDoc.Text) > 0 Then

            Dim DocSeleccionado = If(cTipoDoc.SelectedValue?.ToString, "")

            Dim wTipoDoc = SQL("SELECT * FROM TipoDoc WHERE TipoDoc = '" & DocSeleccionado & "'").Top
            If wTipoDoc IsNot Nothing Then
                MODO_BODEGA = wTipoDoc.GetText("Modo")
                ConPagos = CBool(wTipoDoc.GetText("Pagos"))
            Else
                MsgError("Error en Tipo de Documento")
                Exit Sub
            End If
            Dim wDocG = SQL("Select * from DocumentosG" &
                            " WHERE Local=" & Val(G_LOCALACTUAL) & "" &
                            " AND TipoDoc = '" & DocSeleccionado & "' AND Numero =" & Val(xNumDoc.Text)).Top
            If wDocG IsNot Nothing Then
                MsgError("El Documento ya fue Ingresado en el Sistema")
                Exit Sub
            End If
        End If

    End Sub

    Private Sub xRut_Validating(sender As Object, e As CancelEventArgs) Handles xRut.Validating
        If xRut.Text <> "__.___.___-_" Then
            Dim wCli = SQL("SELECT * FROM CLientes WHERE Rut = '" & xRut.Text & "'").Top
            If wCli IsNot Nothing Then
                xNombre.Text = wCli.GetText("Nombre")
            Else
                MsgError("Cliente no Existe")
                xNombre.Text = ""
                xRut.Text = "__.___.___-_"
                Exit Sub
            End If
        End If
    End Sub


    Private Sub bQuitar_Click(sender As Object, e As EventArgs) Handles bQuitar.Click
        If xTabla.Row > 0 Then
            If Pregunta("¿Desea Eliminar Artículo:" & vbCrLf & (xTabla.GetData(xTabla.Row, T_DESCRIPCION)).ToString & "?") Then
                xTabla.RemoveItem(xTabla.Row)
                CalcularTotal()
                xArticulo.Focus()
            End If
        End If
    End Sub

    Private Sub EmisionDocumentos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CambiarPOS()
    End Sub

    Private Sub CambiarPOS()
        Dim DC = New RebuscoDataContext(P_CONEXION)

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
                    If wPos.Correlativo = 0 Then
                        PreguntaAdvertencia("El POS indicado no tiene correlativos asignados")
                    End If
                Else
                    PreguntaAdvertencia("El POS indicado no tiene correlativos asignados")
                End If

                G_POS = NumPOS.ID_POS
            Else
                If xPOS.ToDecimal > 0 Then Exit Sub
                NumPOS.Close()
                Close()
                Exit Sub
            End If
        End While

        If xPOS.ToDecimal > 0 Then
            If Not Pregunta("Al cambiar el número de POS se limpiarán los datos cargados. ¿Desea continuar?") Then
                Exit Sub
            End If
            Limpiar(True)
        End If

        xPOS.Text = G_POS.ToString()

    End Sub

    Private Sub xCambiarPOS_Click(sender As Object, e As EventArgs) Handles xCambiarPOS.Click
        CambiarPOS()
    End Sub

    Private Sub xArticulo_ItemSeleccionado(wDescripcion As String) Handles xArticulo.ItemSeleccionado
        xDescripcion.Text = wDescripcion
    End Sub

    Private Sub xNumDocRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNumDocRef.KeyPress
        e.NextControl(bProcesarDoc)
    End Sub

    Private Sub bDirectorio_Click(sender As Object, e As EventArgs) Handles bDirectorio.Click
        Abrir_Documento(Directorio_PDF)
    End Sub

    Private Sub xCliente_TextChanged(sender As Object, e As EventArgs) Handles xCliente.TextChanged

    End Sub
End Class