Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports C1.Win.C1FlexGrid

Public Class IngresoOT
    Implements iFormulario
    Dim wOT As Double
    Const T_ELIMINAR = 0
    Const T_ARTICULO_SERVICIO = 1
    Const T_DESCRIPCION_SERVICIO = 2
    Const T_CANTIDADSER = 3
    Const T_COSTO_SERVICIO = 4
    Const T_TOTAL_SERVICIO = 5

    Const T_ARTICULO = 1
    Const T_DESCRIPCION = 2
    Const T_CANTIDADART = 3
    Const T_STOCK = 4
    Const T_COSTO = 5
    Const T_TOTAL_ARTICULO = 6

    Dim NARANJO As Long
    Dim NARANJO_TXT As Long
    Dim BLANCO As Long
    Dim NEGRO As Long
    Dim wEstadoOT As String
    Dim G_CANTIDADANTERIOR As Decimal = 0

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub IngresoOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        TitulosServicio()
        TitulosArticulo()
        cPlantilla.LoadItemsObj("PlantillasObservaciones", "Contenido", "Descripcion")
        'xCliente.PreCargarDatos()
    End Sub

    Private Sub xOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xOT.KeyPress
        If e.KeyChar = vbCr Then
            If xCliente.Enabled Then
                xCliente.Focus()
            Else
                xEstado.Focus()
            End If
        End If
        ValidarDigitos(e)
    End Sub

    Public Sub xOT_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xOT.Validating
        If xOT.Text.Trim <> "" Then
            Dim wOT = SQL("SELECT * FROM OT WHERE OT=" & Val(xOT.Text) & "").Top
            If wOT Is Nothing Then
                LimpiarCampos(Me)
                bGuardar.Text = "Guardar"
            Else

                Dim wEst = SQL("SELECT DescEstado,Estado FROM Estados WHERE Estado = '" & wOT.GetText("Estado") & "' and Tipo='O'").Top
                Dim wDoc = SQL("SELECT DescTipoDoc FROM TipoDoc WHERE TipoDoc ='" & wOT.GetText("TipoDoc") & "'").Top
                Dim wTec = SQL("SELECT NombreUsr FROM Usuarios WHERE Usuario ='" & wOT.GetText("Tecnico") & "'").Top
                Dim wCli = SQL("SELECT Nombre FROM Clientes  WHERE Cliente ='" & wOT.GetText("Cliente") & "'").Top

                xCliente.AutoCompletarActivo = False
                xTecnico.AutoCompletarActivo = False
                xCliente.Text = Trim(wOT.GetText("Cliente"))
                xTecnico.Text = wOT.GetText("Tecnico")
                xCliente.AutoCompletarActivo = True
                xTecnico.AutoCompletarActivo = True

                dFecha.Value = CDate(wOT.GetText("Fecha"))
                xNombre.Text = Trim(wCli.GetText("Nombre"))

                If wEst IsNot Nothing Then
                    xEstado.Text = UCase(wEst.GetText("DescEstado"))
                    wEstadoOT = Trim(wEst.GetText("Estado"))
                End If

                dFechaEntrega.Value = CDate(wOT.GetText("FechaEntrega"))
                xObsCliente.Text = wOT.GetText("ObsCliente")
                xObsTecnico.Text = wOT.GetText("ObsTecnico")
                xTotalOT.Text = Val(wOT.GetText("TotalOT")).ToString

                xProductoR.Text = wOT.GetText("Recepcion")
                xCodigoR.Text = wOT.GetText("Codigo")

                If wTec IsNot Nothing Then
                    xNombreTecnico.Text = wTec.GetText("NombreUsr")
                End If

                If wEstadoOT = "D" Or wEstadoOT = "F" Then
                    DesactivarBotones(False)
                Else
                    DesactivarBotones(True)
                    xCliente.Focus()
                End If

                CargarServicios()
                CargarArticulos()
                TotalOT()
                bGuardar.Text = "Modificar"
            End If
        Else
            LimpiarCampos(Me)
        End If
    End Sub

    Private Sub xCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles xCliente.KeyDown
        If e.KeyCode = Keys.F3 Then
            bBuscarC.Buscar_Click()
        End If
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        e.NextControl(xTecnico)
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
        xEmail.Clear()

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
            xEmail.Text = Cli.Email
        Else
            xCliente.Clear()
            xNombre.Clear()
            xEmail.Clear()
        End If
        xCliente.AutoCompletarActivo = True

    End Sub

    Private Sub xCliente_ItemSeleccionado(wDescripcion As String) Handles xCliente.ItemSeleccionado
        xNombre.Text = wDescripcion
        xTecnico.Focus()
    End Sub

    Private Sub xTecnico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTecnico.KeyPress
        e.NextControl(xProductoR)
    End Sub

    Private Sub xTecnico_Validating(sender As Object, e As CancelEventArgs) Handles xTecnico.Validating
        If xTecnico.ListaVisible Then
            If xTecnico.ListaActiva Then
                Exit Sub
            Else
                xTecnico.OcultarLista()
            End If
        End If

        If Trim(xTecnico.Text) = "" Then
            xNombreTecnico.Clear()
            Exit Sub
        End If
        If xTecnico.DescEncontrada = "" Then
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wTec = DC.T_Usuarios.FirstOrDefault(Function(x) x.Usuario = xTecnico.Text.Trim)
            If wTec IsNot Nothing Then
                xNombreTecnico.Text = wTec.NombreUsr
            End If
        Else
            xNombreTecnico.Text = xTecnico.DescEncontrada
        End If
    End Sub

    Private Sub xTecnico_ItemSeleccionado(wDescripcion As String) Handles xTecnico.ItemSeleccionado
        xNombreTecnico.Text = wDescripcion
        xProductoR.Focus()
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Limpiar()
    End Sub

    Private Sub bCrear_Click(sender As Object, e As EventArgs) Handles bCrear.Click
        ManCliente.Configurar(Me, xCliente)
        ManCliente.ShowDialog()
    End Sub

    Private Sub xProductoR_KeyDown(sender As Object, e As KeyEventArgs) Handles xProductoR.KeyDown
        If e.KeyCode = Keys.F3 Then
            bConsultarP_Click()
        End If
    End Sub

    Private Sub xProductoR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xProductoR.KeyPress
        e.NextControl(xCodigoR)
    End Sub

    Private Sub xCodigoR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCodigoR.KeyPress
        e.NextControl(dFechaEntrega)
    End Sub

    Private Sub xCodigoR_KeyDown(sender As Object, e As KeyEventArgs) Handles xCodigoR.KeyDown
        If e.KeyCode = Keys.F3 Then
            bConsultarP_Click()
        End If
    End Sub

    Private Sub bConsultarP_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bConsultarP.Click
        If xCliente.Text.Trim <> "" Then
            Dim wCli = SQL("SELECT * FROM CLIENTES WHERE CLIENTE = '" & xCliente.Text.Trim & "'").Top
            If wCli IsNot Nothing Then
                ConsultarProductos.xCliente.Text = wCli.GetText("Cliente")
                ConsultarProductos.xNombre.Text = wCli.GetText("Nombre")
                ConsultarProductos.ShowDialog()
                ConsultarProductos.BringToFront()
            Else
                MsgError("Cliente no encontrado")
                xCliente.Clear()
                xNombre.Clear()
                xCliente.Focus()
            End If
        Else
            MsgError("Debe ingresar Cliente")
            xCliente.Focus()
        End If

    End Sub

    Sub Limpiar()
        LimpiarCampos(Me)
        DesactivarBotones(True)

        xOT.Text = CorrelativoOT.ToString

        dFecha.Value = Now
        dFechaEntrega.Value = Now
        Dim wEst = SQL("SELECT DescEstado,Estado FROM Estados WHERE ESTADO = 'I' AND TIPO = 'O'").Top
        If wEst IsNot Nothing Then
            xEstado.Text = UCase(wEst.GetText("DescEstado"))
            wEstadoOT = wEst.GetText("Estado")
        End If
        bGuardar.Text = "Guardar"
        TitulosArticulo()
        TitulosServicio()
    End Sub

    Private Sub xServicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xServicio.KeyPress
        e.NextControl(bAgregar)
    End Sub

    Private Sub xServicio_Validating(sender As Object, e As CancelEventArgs) Handles xServicio.Validating
        If xServicio.ListaVisible Then
            If xServicio.ListaActiva Then
                Exit Sub
            Else
                xServicio.OcultarLista()
            End If
        End If

        If Trim(xServicio.Text) = "" Then
            xNombreServicio.Clear()
            Exit Sub
        End If
        If xServicio.DescEncontrada = "" Then

            xServicio.Text = ObtenerArticulo(xServicio.Text)
            If xServicio.Text = "" Then
                MsgError("Artículo No Encontrado")
                xNombreServicio.Clear()
                xServicio.Clear()
                xServicio.Focus()
                Exit Sub
            End If

            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wSer = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xServicio.Text.ToDecimal)
            If wSer IsNot Nothing Then
                xNombreServicio.Text = wSer.Descripcion
            End If
        Else
            xNombreServicio.Text = xServicio.DescEncontrada
        End If
    End Sub

    Private Sub xServicio_ItemSeleccionado(wDescripcion As String) Handles xServicio.ItemSeleccionado
        xNombreServicio.Text = wDescripcion
        bAgregar.Focus()
    End Sub

    Private Sub bAgregar_Click(sender As Object, e As EventArgs) Handles bAgregar.Click
        Dim wRepetido As Boolean
        Dim wTotalServicio As Double
        Dim wFila As Integer
        If Trim(xServicio.Text) = "" Or Trim(xNombreServicio.Text) = "" Then
            MsgError("Debes ingresar un servicio")
            xServicio.Focus()
            Exit Sub
        End If

        Try
            Dim wSer = SQL("Select * From Articulos WHERE Articulo = '" & Trim(xServicio.Text) & "' AND TipoArticulo = 'S'").Top
            If wSer Is Nothing Then
                MsgError("Servicio no encontrado o el código ingresado no es de un servicio.")
                xServicio.Focus()
                Exit Sub
            End If


            For i = 1 To xTabla.Rows.Count - 1
                If xTabla.GetData(i, T_ARTICULO_SERVICIO).ToString = Trim(xServicio.Text) Then
                    wRepetido = True
                    wFila = i
                End If
            Next
            If Not wRepetido Then
                xTabla.AddItem("")
                xTabla.SetCellImage(xTabla.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
                wFila = xTabla.Rows.Count - 1
            End If

            xTabla.SetData(wFila, T_ARTICULO_SERVICIO, wSer.GetText("Articulo"))
            xTabla.SetData(wFila, T_DESCRIPCION_SERVICIO, wSer.GetText("Descripcion"))
            xTabla.SetData(wFila, T_CANTIDADSER, 1 + If(Not wRepetido, 0, xTabla.GetData(wFila, T_ARTICULO_SERVICIO).ToString.ToDecimal()))
            xTabla.SetData(wFila, T_COSTO_SERVICIO, wSer.GetDecimal("PVenta").ToText(NumericFormat.Money))
            wTotalServicio = xTabla.GetData(wFila, T_COSTO_SERVICIO).ToString.ToDecimal * xTabla.GetData(wFila, T_CANTIDADSER).ToString.ToDecimal
            xTabla.SetData(wFila, T_TOTAL_SERVICIO, wTotalServicio.ToText(NumericFormat.Money))
            xTabla.Row = xTabla.Rows.Count - 1
            xTabla.Col = 0

            xServicio.Clear()
            xNombreServicio.Clear()
            xServicio.Focus()
            TotalOT()
        Catch ex As Exception
            MsgError("Error al ingresar código de servicio")
            xServicio.Focus()
            Exit Sub
        End Try
    End Sub

    Private Sub bAgregarA_Click(sender As Object, e As EventArgs) Handles bAgregarA.Click
        Dim wStock As Integer
        Dim wStockTabla As Integer
        Dim wArticulos As String
        Dim wSubTotal As Double

        wStock = 0
        wStockTabla = 0

        If Trim(xArticulo.Text) = "" Then
            Informacion("Debe ingresar Artículo")
            xArticulo.Focus()
            Exit Sub
        End If

        Try

            Dim DC = New MarketONEDataContext(P_CONEXION)

            Dim idArt = xArticulo.Text.Trim().ToDecimal()
            Dim art = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = idArt And x.TipoArticulo = "P")
            If art Is Nothing Then
                MsgError("Artículo no encontrado o es de tipo Servicio", "Artículo incorrecto")
                Exit Sub
            End If

            If P_STOCKOBLIGATORIO Then
                Dim wExistencia = DC.T_Stocks.FirstOrDefault(Function(x) x.Local = G_LOCALACTUAL And x.Bodega = G_BODEGA And x.Articulo = xArticulo.Text.ToDecimal)
                If wExistencia Is Nothing OrElse wExistencia.Stock <= 0 Then
                    Informacion("El Artículo no tiene stock", "Sin stock")
                    xArticulo.Clear()
                    xDescripcion.Clear()
                    xArticulo.Focus()
                    Exit Sub
                End If
            End If


            Dim wRepetido As Boolean, wFila As Integer

            For i = 1 To xTablaArticulos.Rows.Count - 1
                If xTablaArticulos.GetData(i, T_ARTICULO).ToString = Trim(xArticulo.Text) Then
                    wRepetido = True
                    wFila = i
                End If
            Next

            If Not wRepetido Then
                xTablaArticulos.AddItem("")
                xTablaArticulos.SetCellImage(xTablaArticulos.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
                wFila = xTablaArticulos.Rows.Count - 1
            End If

            xTablaArticulos.SetData(wFila, T_ARTICULO, art.Articulo)
            xTablaArticulos.SetData(wFila, T_DESCRIPCION, art.Descripcion.Trim())
            xTablaArticulos.SetData(wFila, T_CANTIDADART, 1 + If(Not wRepetido, 0, xTablaArticulos.GetData(wFila, T_CANTIDADART).ToString.ToDecimal()))
            xTablaArticulos.SetData(wFila, T_COSTO, art.PVenta.ToText(NumericFormat.Money))
            wSubTotal = xTablaArticulos.GetData(wFila, T_COSTO).ToString.ToDecimal * xTablaArticulos.GetData(wFila, T_CANTIDADART).ToString.ToDecimal
            xTablaArticulos.SetData(wFila, T_TOTAL_ARTICULO, wSubTotal.ToText(NumericFormat.Money))

            For i = 1 To xTablaArticulos.Rows.Count - 1
                wArticulos = xTablaArticulos.GetData(i, T_ARTICULO).ToString
                If Trim(xArticulo.Text) = wArticulos Then
                    wStockTabla = wStockTabla + 1
                End If
            Next

            Dim wStk = SQL("SELECT (Case  WHEN Stock<=0 THEN 0 ELSE Stock END) as Stock " &
                      " FROM Stocks WHERE Local=" & G_LOCALACTUAL & " AND Articulo='" & Trim(xArticulo.Text) & "'").Top
            If wStk Is Nothing Then
                xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_STOCK, "Sin Stock")
                xTablaArticulos.FondoCelda(wFila, C_NARANJO)
                'xTablaArticulos.Cell(flexcpForeColor, wFila, T_ID, wFila, T_TOTAL_ARTICULO) = NARANJO_TXT
                wStock = 0
            Else
                wStock = CInt(wStk.GetText("Stock"))
            End If
            wStock = wStock - wStockTabla

            If wStock <= 0 Then
                xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_STOCK, "Sin Stock")
                xTablaArticulos.FondoCelda(wFila, C_NARANJO)
                'xTablaArticulos.Cell(flexcpForeColor, wFila, T_ID, wFila, T_TOTAL_ARTICULO) = NARANJO_TXT
            Else
                xTablaArticulos.SetData(wFila, T_STOCK, "Disponible")
            End If

            xTablaArticulos.Row = CInt(IIf(wRepetido, wFila, xTablaArticulos.Rows.Count - 1))

            xArticulo.Text = ""
            xDescripcion.Text = ""
            xArticulo.Focus()
            TotalOT()
        Catch ex As Exception
            MsgError("Artículo no encontrado o código pertenece a un servicio")
            Exit Sub
        End Try
    End Sub

    Private Sub bBuscarOT_Click(sender As Object, e As EventArgs) Handles bBuscarOT.Click
        ConsultaOT.Show()
        ConsultaOT.BringToFront()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If xOT.Text.Trim <> "" Then
            Dim wOT = SQL("SELECT * FROM OT WHERE OT = '" & xOT.Text.Trim & "'").Top
            If wOT IsNot Nothing Then
                ImprimirOT.xOT.Text = xOT.Text.Trim
                ImprimirOT.Show()
                ImprimirOT.BringToFront()
            Else
                MsgError("OT no encontrada")
            End If
        Else
            MsgError("Debe ingresar numero de OT")
            xOT.Focus()
        End If
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If xOT.Text.Trim = "" Then
            MsgError("Debe indicar un número de OT", "Falta OT")
            xOT.Focus()
            Exit Sub
        End If
        If dFecha.Value > Now Then
            MsgError("La fecha no puede ser superior al día actual", "Fecha incorrecta")
            dFecha.Focus()
            Exit Sub
        End If
        If xCliente.Text.Trim = "" Then
            MsgError("Debe indicar un cliente", "Falta cliente")
            xCliente.Focus()
            Exit Sub
        End If
        If xProductoR.Text.Trim = "" Then
            MsgError("Debe indicar un producto a recibir en Servicio Técnico", "Falta producto a recibir")
            xProductoR.Focus()
            Exit Sub
        End If
        If xTabla.Rows.Count - 1 = 0 Then
            MsgError("Debe ingresar al menos un servicio", "Faltan servicios")
            xServicio.Focus()
            Exit Sub
        End If

        If dFechaEntrega.Value.Date < dFecha.Value.Date Then
            MsgError("La fecha de entrega no puede ser menor a la fecha de creacion de la OT", "Fecha incorrecta")
            dFechaEntrega.Focus()
            Exit Sub
        End If

        If xEmail.Text.Trim <> "" Then
            Dim wPatron As New Regex("^[a-zA-Z0-9-]*(.[a-zA-Z0-9-]+)*(.[a-zA-Z0-9-]+)*(.[a-zA-Z0-9-]+)@[a-zA-Z0-9-]+(.[a-zA-Z0-9-]+)*(.[a-zA-Z]{2,4})$")
            If Not wPatron.IsMatch(xEmail.Text.Trim) Then
                MsgError("El correo no cumple con el formato correcto.")
                xEmail.Focus()
                Exit Sub
            End If
        End If


        'If Format(dFechaEntrega.Value, "dd/MM/yyyy") < Format(dFecha.Value, "dd/MM/yyy") Then
        '    MsgError("La fecha de entrega no puede ser menor a la fecha de creacion de la OT")
        '    Exit Sub
        'End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wOT As New T_OT
        Dim qOT = DC.T_OT.FirstOrDefault(Function(x) x.OT = xOT.Text.ToDecimal() And x.Local = CInt(G_LOCALACTUAL))

        If qOT IsNot Nothing Then
            wOT = qOT
        Else
            xOT.Text = CorrelativoOT().ToString
        End If

        TotalOT()

        wOT.OT = xOT.Text.ToDecimal
        wOT.Fecha = dFecha.Value
        wOT.Cliente = CInt(xCliente.Text)
        wOT.FechaEntrega = dFechaEntrega.Value
        wOT.ObsCliente = Trim(xObsCliente.Text)
        wOT.ObsTecnico = Trim(xObsTecnico.Text)
        wOT.TipoDoc = ""
        wOT.NumDoc = 0
        wOT.TotalOT = xTotalOT.Text.ToDecimal()
        wOT.Tecnico = Trim(xTecnico.Text)
        wOT.Usuario = UsuarioActual
        wOT.Local = G_LOCALACTUAL
        wOT.Recepcion = Trim(xProductoR.Text)
        wOT.Codigo = Trim(xCodigoR.Text)
        wOT.FechaPago = CDate("01/01/2000 00:00:00")
        wOT.FechaInicio = CDate("01/01/2000 00:00:00")
        wOT.FechaFinalizacion = CDate("01/01/2000 00:00:00")
        wOT.FechaCierre = CDate("01/01/2000 00:00:00")
        wOT.TecnicoRevision = ""

        If xTecnico.Text = "" Then
            wOT.Tecnico = ""
        Else
            wOT.Tecnico = xTecnico.Text
        End If


        If xTecnico.Text <> "" Then
            wOT.Tecnico = Trim(xTecnico.Text)
            wOT.FechaAsignacion = Now
            wOT.Estado = "A"
        Else
            wOT.Estado = "I"
            wOT.FechaAsignacion = New DateTime(3000, 1, 1)
        End If

        Dim NuevaOT = False

        If qOT Is Nothing Then
            NuevaOT = True
            DC.T_OT.InsertOnSubmit(wOT)
        End If

        DC.SubmitChanges()

        Dim wOTDet = DC.T_OTDet.Where(Function(x) x.OT = CInt(xOT.Text))
        If wOTDet.Any Then
            DC.T_OTDet.DeleteAllOnSubmit(wOTDet)
        End If

        For Each wRow As Row In xTabla.Rows
            If wRow.Index = 0 Then Continue For
            Dim wPrecioVenta As Decimal = 0
            Dim wArticulo = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wRow.Item(T_ARTICULO).ToString.ToDecimal)
            If wArticulo IsNot Nothing Then wPrecioVenta = wArticulo.PVenta
            Dim wOTD As New T_OTDet With {
                .OT = xOT.Text.ToDecimal,
                .Fecha = dFecha.Value,
                .Articulo = wRow.Item(T_ARTICULO_SERVICIO).ToString.ToDecimal,
                .Cantidad = wRow.Item(T_CANTIDADSER).ToString.ToDecimal,
                .Glosa = "",
                .FechaEnt = New DateTime(3000, 1, 1),
                .FechaSol = Now,
                .Estado = CChar("R"),
                .Tipo = CChar("S"),
                .Disponible = False,
                .Tecnico = "",
                .PVenta = wPrecioVenta
            }
            DC.T_OTDet.InsertOnSubmit(wOTD)
        Next

        For Each wRow As Row In xTablaArticulos.Rows
            If wRow.Index = 0 Then Continue For
            Dim wPrecioVenta As Decimal = 0
            Dim wArticulo = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wRow.Item(T_ARTICULO).ToString.ToDecimal)
            If wArticulo IsNot Nothing Then wPrecioVenta = wArticulo.PVenta
            Dim wOTD As New T_OTDet With {
                .OT = CInt(Trim(xOT.Text)),
                .Fecha = dFecha.Value,
                .Articulo = wRow.Item(T_ARTICULO).ToString.ToDecimal,
                .Cantidad = wRow.Item(T_CANTIDADART).ToString.ToDecimal,
                .Glosa = "",
                .FechaEnt = New DateTime(3000, 1, 1),
                .FechaSol = Now,
                .Estado = CChar("E"),
                .Tipo = CChar("A"),
                .Tecnico = "",
                .Disponible = If(wRow.Item(T_STOCK).ToString = "Disponible", True, False),
                .PVenta = wPrecioVenta
            }
            DC.T_OTDet.InsertOnSubmit(wOTD)
        Next

        Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = xCliente.Text.Trim.ToDecimal)
        If wCli IsNot Nothing Then
            wCli.Email = xEmail.Text
        End If

        DC.SubmitChanges()
        Mensaje("OT creada satisfactoriamente.", $"OT {xOT.Text} creada")

        If NuevaOT Then
            Tracking.Ingresar(Tracking.Eventos.OTIngresada, DateTime.Now, wOT.Cliente, "OT", wOT.OT, wOT.Fecha, 0, "", wOT.Recepcion, Me.Text)
        End If

        ImprimirOT.xOT.Text = xOT.Text.Trim
        ImprimirOT.ShowDialog()
        'ImprimirOT.BringToFront()

        Limpiar()
    End Sub


    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        Limpiar()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(bAgregarA)
    End Sub

    Sub TitulosServicio()
        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 6

        xTabla.Cols(T_ELIMINAR).Width = 51
        xTabla.Cols(T_ARTICULO_SERVICIO).Width = 130
        xTabla.Cols(T_DESCRIPCION_SERVICIO).Width = 611
        xTabla.Cols(T_COSTO_SERVICIO).Width = 90
        xTabla.Cols(T_CANTIDADSER).Width = 59
        xTabla.Cols(T_TOTAL_SERVICIO).Width = 90

        xTabla.Cols(T_ELIMINAR).Caption = "Eliminar"
        xTabla.Cols(T_ARTICULO_SERVICIO).Caption = "Servicio"
        xTabla.Cols(T_DESCRIPCION_SERVICIO).Caption = "Descripción"
        xTabla.Cols(T_COSTO_SERVICIO).Caption = "Costo"
        xTabla.Cols(T_CANTIDADSER).Caption = "Cantidad"
        xTabla.Cols(T_TOTAL_SERVICIO).Caption = "Total"

        xTabla.Cols(T_ARTICULO_SERVICIO).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
        xTabla.Cols(T_ELIMINAR).ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter
    End Sub
    Sub TitulosArticulo()
        xTablaArticulos.Clear()
        xTablaArticulos.Rows.Count = 1
        xTablaArticulos.Cols.Count = 7

        xTablaArticulos.Cols(T_ELIMINAR).Width = 51
        xTablaArticulos.Cols(T_ARTICULO).Width = 130
        xTablaArticulos.Cols(T_DESCRIPCION).Width = 506
        xTablaArticulos.Cols(T_COSTO).Width = 90
        xTablaArticulos.Cols(T_STOCK).Width = 0

        xTablaArticulos.Cols(T_ELIMINAR).Caption = "Eliminar"
        xTablaArticulos.Cols(T_ARTICULO).Caption = "Artículo"
        xTablaArticulos.Cols(T_DESCRIPCION).Caption = "Descripción"
        xTablaArticulos.Cols(T_STOCK).Caption = "Stock"
        xTablaArticulos.Cols(T_CANTIDADART).Caption = "Cantidad"
        xTablaArticulos.Cols(T_COSTO).Caption = "Costo"
        xTablaArticulos.Cols(T_TOTAL_ARTICULO).Caption = "Sub-Total"

        xTablaArticulos.Cols(T_ELIMINAR).ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter
        xTablaArticulos.Cols(T_ARTICULO_SERVICIO).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
    End Sub
    Sub TotalOT()
        Dim TotalOT As Decimal
        xTotalOT.Text = "0"

        For Each wRow As Row In xTabla.Rows
            If wRow.Index = 0 Then Continue For
            TotalOT += wRow.Item(T_TOTAL_SERVICIO).ToString.ToDecimal
        Next

        xTotalOT.Text = Math.Round(TotalOT, 0).ToString

        For Each wRow As Row In xTablaArticulos.Rows
            If wRow.Index = 0 Then Continue For
            TotalOT += wRow.Item(T_TOTAL_ARTICULO).ToString.ToDecimal
        Next

        xTotalOT.Text = Math.Round(TotalOT, 0).ToText(NumericFormat.Money)
    End Sub

    Private Sub xNombre_TextChanged(sender As Object, e As EventArgs) Handles xNombre.TextChanged
        If xNombre.Text <> "" Then
            bConsultarP.Visible = True
        Else
            bConsultarP.Visible = False
        End If
        xTecnico.Focus()
    End Sub


    Private Sub xObsCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xObsCliente.KeyPress
        e.NextControl(xObsTecnico)
    End Sub

    Sub CargarServicios()
        Dim wFilas = 1
        Dim wSubTotal As Double
        TitulosServicio()
        Dim wSer = SQL("Select RO.OT, RO.Articulo, A.Descripcion, RO.Cantidad, A.PVenta FROM OTDet RO JOIN " &
               "Articulos A ON Ro.Articulo = A.Articulo WHERE OT = '" & xOT.Text.Trim & "' AND A.TipoArticulo = 'S'")

        If wSer.Rows.Count > 0 Then
            For Each wS As DataRow In wSer.Rows
                xTabla.AddItem("")
                xTabla.SetCellImage(xTabla.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
                xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO_SERVICIO, wS.GetText("Articulo"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION_SERVICIO, wS.GetText("Descripcion"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDADSER, wS.GetDecimal("Cantidad").ToText(NumericFormat.Money))
                xTabla.SetData(xTabla.Rows.Count - 1, T_COSTO_SERVICIO, wS.GetText("PVenta"))
                wSubTotal = wS.GetDecimal("Cantidad") * wS.GetDecimal("PVenta")
                xTabla.SetData(xTabla.Rows.Count - 1, T_TOTAL_SERVICIO, wSubTotal.ToText(NumericFormat.Money))
            Next
        End If
    End Sub

    Sub CargarArticulos()
        Dim wDisponible As Boolean
        Dim wSubTotal As Double

        TitulosArticulo()
        Dim wArt = SQL("SELECT RO.OT,RO.Articulo,A.Descripcion,A.PVenta,Ro.Disponible,RO.Cantidad FROM OTDet RO JOIN " &
               "Articulos A ON Ro.Articulo = A.Articulo WHERE OT = '" & Trim(xOT.Text) & "' AND A.TipoArticulo = 'P'")

        If wArt.Rows.Count > 0 Then
            TitulosArticulo()
            For Each wA As DataRow In wArt.Rows
                xTablaArticulos.AddItem("")
                xTablaArticulos.SetCellImage(xTablaArticulos.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
                xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_ARTICULO, wA.GetText("Articulo"))
                xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_DESCRIPCION, wA.GetText("Descripcion"))
                xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_CANTIDADART, wA.GetText("Cantidad"))
                xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_COSTO, wA.GetDecimal("PVenta").ToText(NumericFormat.Money))
                xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_STOCK, If(CBool(wA.GetText("Disponible")), "Disponible", "Sin Stock"))
                wSubTotal = wA.GetNum("Cantidad") * wA.GetNum("PVenta")
                xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_TOTAL_ARTICULO, wSubTotal.ToText(NumericFormat.Money))

                wDisponible = If(CBool(wA.GetText("Disponible")), True, False)
                If Not wDisponible Then
                    'xTablaArticulos.Cell(flexcpBackColor, xTablaArticulos.Rows - 1, T_ID, xTablaArticulos.Rows - 1, T_COSTO) = NARANJO
                    'xTablaArticulos.Cell(flexcpForeColor, xTablaArticulos.Rows - 1, T_ID, xTablaArticulos.Rows - 1, T_COSTO) = NARANJO_TXT
                End If
            Next
        End If
    End Sub

    Sub DesactivarBotones(ByRef wActivado As Boolean)
        gServicio.Enabled = wActivado
        xObsCliente.Enabled = wActivado
        xObsTecnico.Enabled = wActivado
        bGuardar.Enabled = wActivado
        xCliente.Enabled = wActivado
        xProductoR.Enabled = wActivado
        xCodigoR.Enabled = wActivado
        xTecnico.Enabled = wActivado
        dFecha.Enabled = wActivado
        dFechaEntrega.Enabled = wActivado
        xTabla.Enabled = wActivado
        xNombre.Enabled = wActivado
        bBuscarC.Enabled = wActivado
        bCrear.Enabled = wActivado
    End Sub

    Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs) Handles xTabla.DoubleClick
        If xTabla.Rows.Count - 1 > 0 Then
            If xTabla.Col = T_ELIMINAR Then
                xTabla.RemoveItem(xTabla.Row)
            End If
            If xTabla.Col = T_CANTIDADSER Then
                xTabla.StartEditing(xTabla.Row, T_CANTIDADSER)
            End If
        End If
        TotalOT()
    End Sub

    Private Sub xTablaArticulos_DoubleClick(sender As Object, e As EventArgs) Handles xTablaArticulos.DoubleClick

        If xTablaArticulos.Rows.Count - 1 = 0 Then Exit Sub

        If xTablaArticulos.Rows.Count - 1 > 0 And xTablaArticulos.Col = 0 Then
            xTablaArticulos.RemoveItem(xTablaArticulos.Row)
        End If

        'If xTablaArticulos.Col = T_STOCK Then
        '    If xTablaArticulos.GetData(xTablaArticulos.Row, T_STOCK).ToString = "Disponible" Then
        '        xTablaArticulos.SetData(xTablaArticulos.Row, T_STOCK, "Sin Stock")
        '        xTablaArticulos.FondoCelda(xTablaArticulos.Row, C_NARANJO)
        '    Else
        '        xTablaArticulos.SetData(xTablaArticulos.Row, T_STOCK, "Disponible")
        '        xTablaArticulos.FondoCelda(xTablaArticulos.Row, C_BLANCO)
        '    End If
        'End If

        If xTablaArticulos.Col = T_CANTIDADART Then
            G_CANTIDADANTERIOR = xTablaArticulos.GetData(xTablaArticulos.Row, T_CANTIDADART).ToString.ToDecimal
            xTablaArticulos.StartEditing(xTablaArticulos.Row, T_CANTIDADART)
        End If

        TotalOT()
    End Sub

    Private Sub xTotalOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTotalOT.KeyPress
        e.NextControl(xTecnico)
    End Sub

    Private Sub IngresoOT_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If xCliente.Enabled = True Then xCliente.Focus()
        Auditoria(Me.Name, "Ingresó al Módulo", UsuarioActual, CStr(G_LOCALACTUAL))
    End Sub

    Private Sub dFechaEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dFechaEntrega.KeyPress
        e.NextControl(xServicio)
    End Sub

    Private Sub xTabla_AfterEdit(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles xTabla.AfterEdit
        If xTabla.Rows.Count > 1 Then
            Dim wCantidad As Decimal = xTabla.GetData(xTabla.Row, T_CANTIDADSER).ToString.ToDecimal()
            Dim wCosto As Decimal = xTabla.GetData(xTabla.Row, T_COSTO_SERVICIO).ToString.ToDecimal()
            xTabla.SetData(xTabla.Row, T_TOTAL_SERVICIO, (wCantidad * wCosto).ToText(NumericFormat.Money))
            xTabla.FinishEditing(True)
            TotalOT()
        End If
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
                Exit Sub
            End If

            'Dim wSer = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.ToDecimal)
            'If wSer IsNot Nothing Then
            '    xDescripcion.Text = wSer.Descripcion
            '    Exit Sub
            'End If
            Informacion("Artículo no encontrado")
            xDescripcion.Clear()
            xArticulo.Clear()
            xArticulo.Focus()
        Else
            xArticulo.AutoCompletarActivo = False
            'xArticulo.Text = xArticulo.IdEncontrado
            xDescripcion.Text = xArticulo.DescEncontrada
            xArticulo.AutoCompletarActivo = True
        End If
    End Sub
    Private Sub xArticulo_ItemSeleccionado(wDescripcion As String) Handles xArticulo.ItemSeleccionado
        xDescripcion.Text = wDescripcion
        bAgregarA.Focus()
    End Sub

    Private Sub bAgregarPlantilla_Click(sender As Object, e As EventArgs) Handles bAgregarPlantilla.Click
        If tObservacion.SelectedIndex = 0 Then
            xObsCliente.Text = xObsCliente.Text & If(xObsCliente.Text = "", "", vbCrLf) & cPlantilla.SelectedValue.ToString.Replace(";", vbCr)
        Else
            xObsTecnico.Text = xObsTecnico.Text & If(xObsTecnico.Text = "", "", vbCrLf) & cPlantilla.SelectedValue.ToString.Replace(";", vbCr)
        End If
    End Sub


    Private Sub xTablaArticulos_ValidateEdit(sender As Object, e As ValidateEditEventArgs) Handles xTablaArticulos.ValidateEdit
        If xTablaArticulos.Rows.Count > 1 Then
            Dim wCantidad = xTablaArticulos.Editor.Text.ToDecimal
            Dim wArticulo = xTablaArticulos.GetData(xTablaArticulos.Row, T_ARTICULO).ToString.ToDecimal
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wStock = DC.T_Stocks.FirstOrDefault(Function(x) x.Local = G_LOCALACTUAL And x.Articulo = wArticulo)

            If P_STOCKOBLIGATORIO Then
                If wStock Is Nothing OrElse wStock.Stock <= wCantidad Then
                    Informacion("La cantidad ingresada supera la cantidad disponible en Stock")
                    xTablaArticulos.SetData(xTablaArticulos.Row, T_CANTIDADART, G_CANTIDADANTERIOR)
                    Exit Sub
                End If
            End If
            Dim wCosto As Decimal = xTablaArticulos.GetData(xTablaArticulos.Row, T_COSTO).ToString.ToDecimal
            xTablaArticulos.SetData(xTablaArticulos.Row, T_TOTAL_ARTICULO, wCantidad * wCosto)
            ' xTablaArticulos.FinishEditing(True)
            TotalOT()

        End If
    End Sub

    Private Sub bBuscarServicio_Click(sender As Object, e As EventArgs) Handles bBuscarServicio.Click
        Dim wBuscador = New BuscadorArticulo
        wBuscador.Configurar(Me, xServicio)
        wBuscador.ShowDialog()
    End Sub

    Private Sub bBuscarArticulo_Click(sender As Object, e As EventArgs) Handles bBuscarArticulo.Click
        Dim wBuscador = New BuscadorArticulo
        wBuscador.Configurar(Me, xArticulo)
        xArticulo.AutoCompletarActivo = False
        wBuscador.ShowDialog()
        xArticulo.AutoCompletarActivo = True
    End Sub

    Function CorrelativoOT() As Double
        Dim wOT = SQL("SELECT TOP 1 OT FROM OT ORDER BY OT DESC").Top
        If wOT Is Nothing Then
            CorrelativoOT = 1
        Else
            CorrelativoOT = Val(wOT.GetText("OT")) + 1
        End If
    End Function


End Class