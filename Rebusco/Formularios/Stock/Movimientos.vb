Imports System.ComponentModel
Imports MarketONE

Public Class Movimientos

    Implements iFormulario

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cMovimientos.LoadItemsObj("TipoMov", "TipoMov", "DescTipo", " Where Visible = 1 ORDER BY DescTipo")
        cBodegas.LoadItemsObj("Bodegas", "Bodega", "NombreBodega", " Where Local = " & G_LOCALACTUAL)
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", " ORDER BY DescTipoDoc")
        cResponsable.LoadItemsObj("Usuarios", "usuario", "NombreUsr", " ORDER BY NombreUsr")
        xMovimiento.Text = CStr(SiguienteCorrelativo("MovGen"))
        'Titulos()
        Auditoria(Me.Text, A_INGRESADO, "", "0")
        cBodegas.SelectedValue = G_BODEGA.ToString()

        sDetalleMov.DataSource = New List(Of DetalleMovimiento)

    End Sub

    Private Sub bBuscarA_Click(sender As Object, e As EventArgs)
        Dim wQuery As String
        wQuery = "SELECT Articulo as 'Artículo', Descripcion as 'Descripción' From Articulos"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Descripcion", Me, "Artículos", xArticulo)
    End Sub

    Private Sub xDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDocumento.KeyPress
        ValidarDigitos(e)
        e.NextControl(cTipoDoc)
    End Sub

    Private Sub cMovimientos_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim DC = New RebuscoDataContext(P_CONEXION)
        If Not cTipoDoc.SelectedValue.ToString = Nothing Then
            Dim wAjuste = DC.T_TipoMov.FirstOrDefault(Function(x) x.TipoMov = cTipoDoc.SelectedValue.ToString)
            If wAjuste IsNot Nothing Then
                cTipoDoc.Tag = wAjuste.Ajuste
                cBodegas.Focus()
            End If
        End If
    End Sub

    Private Sub cBodegas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBodegas.SelectedIndexChanged
        xArticulo.Focus()
    End Sub

    Private Sub cTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cTipoDoc.SelectedIndexChanged
        cResponsable.Focus()
    End Sub

    Private Sub cResponsable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cResponsable.SelectedIndexChanged
        xArticulo.Focus()
    End Sub

    Private Sub xArticulo_Validating(sender As Object, e As CancelEventArgs) Handles xArticulo.Validating
        If xArticulo.Text = "0" Then
            xDescripcion.Focus()
            Exit Sub
        End If

        If xArticulo.ListaVisible Then
            If xArticulo.ListaActiva Then
                Exit Sub
            Else
                xArticulo.OcultarLista()
            End If
        End If

        If Trim(xArticulo.Text) = "" Then
            xDescripcion.Text = ""
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

            MsgError("Artículo no encontrado", "Error en artículo")
            xDescripcion.Clear()
            xArticulo.Clear()
            xArticulo.Focus()
        Else
            xArticulo.AutoCompletarActivo = False
            xDescripcion.Text = xArticulo.DescEncontrada
            xArticulo.AutoCompletarActivo = True
        End If
    End Sub

    Private Sub xArticulo_ItemSeleccionado(wDescripcion As String) Handles xArticulo.ItemSeleccionado
        xDescripcion.Text = wDescripcion
        xCantidad.Focus()
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(xCantidad)
    End Sub

    Private Function ConsultarStock(wCodigo As String, Optional wCantidadTransito As Decimal = 0) As Boolean
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wStock = DC.T_Stocks.FirstOrDefault(Function(x) x.Articulo = wCodigo.ToDecimal And
                                                             x.Local = G_LOCALACTUAL And
                                                             x.Bodega = G_BODEGA)
        If wStock IsNot Nothing Then
            If wCantidadTransito <= wStock.Stock Then
                Return True
            End If
        End If

        Return False
    End Function


    Private Sub bAgregar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bAgregar.Click

        If xArticulo.Text.Trim = "" Then Return
        If xCantidad.Text = "" Then xCantidad.Text = "0"

        If xCantidad.Text.ToDecimal <= 0 Then
            MsgError("La cantidad debe ser mayor a 0", "Falta cantidad")
            xCantidad.Focus()
            Exit Sub
        End If

        Dim DC = New RebuscoDataContext(P_CONEXION)

        Dim Art = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.ToDecimal())

        ValidateObj(Art)

        If Art Is Nothing Then
            MsgError("Artículo no encontrado", "Artículo inexistente")
            xArticulo.Clear()
            xDescripcion.Clear()
            xArticulo.Focus()
            Exit Sub
        End If

        Dim DetMov = CType(sDetalleMov.DataSource, List(Of DetalleMovimiento))

        If P_STOCKOBLIGATORIO AndAlso cMovimientos.Tag IsNot Nothing AndAlso cMovimientos.Tag.ToString = ModoInventario.Disminuir Then
            If Not ConsultarStock(xArticulo.Text, DetMov.Where(Function(x) x.Articulo = xArticulo.Text.ToDecimal) _
                                                     .Sum(Function(x) x.Cantidad) + xCantidad.Text.ToDecimal) Then
                MsgError("No hay stock disponible", "Sin stock")
                Exit Sub
            End If
        End If


        Dim det = New DetalleMovimiento()
        det.Articulo = Art.Articulo
        det.SKU = Art.SKU
        det.Descripcion = Art.Descripcion
        det.Costo = 0 'Cargar anterior'
        det.Cantidad = xCantidad.Text.ToDecimal
        det.PrecioVenta = Art.PVenta
        det.Barra = ""
        det.Total = (Art.PVenta * det.Cantidad).ToDecimal(0)

        DetMov.Add(det)

        sDetalleMov.Load(DetMov)

        xArticulo.Clear()
        xDescripcion.Clear()
        xCantidad.Text = "0"
        xArticulo.Focus()

    End Sub

    Private Sub xCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCantidad.KeyPress
        If xCantidad.Text = "" Then Exit Sub
        ValidarDigitos(e)
        e.NextControl(bAgregar)
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

        Dim DetMov = CType(sDetalleMov.DataSource, List(Of DetalleMovimiento))

        If cMovimientos.Text.Trim = "" Then
            MsgError("Debe ingresar tipo de movimiento", "Falta tipo de movimiento")
            cMovimientos.Focus()
            Exit Sub
        End If
        If cBodegas.Text.Trim = "" Then
            MsgError("Debe ingresar Bodega", "Falta bodega")
            cBodegas.Focus()
            Exit Sub
        End If

        If Not DetMov.Any Then
            MsgError("Debe ingresar artículos al movimiento", "Faltan artículos")
            xArticulo.Focus()
            Exit Sub
        End If

        If cTipoDoc.Text = "" Then
            MsgError("Debe indicar tipo de documeto de referencia", "Falta documento")
            Exit Sub
        End If

        If cTipoDoc.Text <> "Sin Documento" Then
            If xDocumento.Text.Trim = "" Then
                MsgError("Debe indicar número de documento de referencia", "Falta documento")
                Exit Sub
            End If
        Else
            xDocumento.Text = "0"
        End If

        xMovimiento.Text = SiguienteCorrelativo("MovGen").ToString()

        Dim DC = New RebuscoDataContext(P_CONEXION)

        Dim Bodegas = DC.T_Bodegas.ToList()

        Dim TipoMov = DC.T_TipoMov.FirstOrDefault(Function(x) x.TipoMov = cMovimientos.SelectedValue.ToString)
        Dim wModoInventario = ""
        If TipoMov IsNot Nothing Then wModoInventario = TipoMov.Ajuste

        Dim wBod = SQL("Select Bodega from Bodegas where NombreBodega = '" & Trim(cBodegas.Text) & "' and Local = " & G_LOCALACTUAL).Top
        If wBod IsNot Nothing Then
            G_BODEGA = wBod.GetInt("Bodega")
        Else
            MsgError("Falta Bodega")
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        xMovimiento.Text = SiguienteCorrelativo("MovGen").ToString()
        Dim MovGen As New T_MovGen

        MovGen.Fecha = dFecha.Value
        MovGen.Hora = Format(dFecha.Value.Date.ToString, "hh:mm")
        MovGen.TipoMov = cMovimientos.SelectedValue.ToString
        MovGen.Local = Bodegas.FirstOrDefault(Function(x) x.Bodega = cBodegas.SelectedValue.ToString.ToDecimal()).Local
        MovGen.Bodega = cBodegas.SelectedValue.ToString.ToDecimal
        MovGen.Destino = 0
        MovGen.Usuario = UsuarioActual
        MovGen.Estado = "E"
        MovGen.TipoDoc = cTipoDoc.SelectedValue.ToString
        MovGen.NumDoc = xDocumento.Text.ToDecimal
        MovGen.ObsTra = xObservacion.Text.Trim
        MovGen.Total = DetMov.Sum(Function(x) x.Total)
        MovGen.Responsable = If(cResponsable.Text = "", UsuarioActual, cResponsable.SelectedValue.ToString)

        DC.T_MovGen.InsertOnSubmit(MovGen)
        DC.SubmitChanges()

        xMovimiento.Text = MovGen.Movimiento.ToText

        For Each det In DetMov
            Dim MovDet As New T_MovDet
            MovDet.Movimiento = MovGen.Movimiento
            MovDet.Fecha = Now
            MovDet.TipoMov = cMovimientos.SelectedValue.ToString
            MovDet.Articulo = det.Articulo
            MovDet.Barra = det.Barra
            MovDet.Cantidad = det.Cantidad
            MovDet.Precio = det.PrecioVenta
            MovDet.Costo = det.Costo

            Stocks(MovDet.Articulo, cBodegas.SelectedValue.ToString.ToDecimal,
                            MovGen.Local, det.Cantidad, wModoInventario)

            Dim eve = Tracking.Eventos.SinEvento
            Select Case wModoInventario
                Case ModoInventario.Incrementar
                    eve = Tracking.Eventos.StockIncrementado
                Case ModoInventario.Disminuir
                    eve = Tracking.Eventos.StockDisminuido
                Case ModoInventario.Igualar
                    eve = Tracking.Eventos.StockEstablecido
            End Select
            Tracking.Ingresar(eve, Now, 0, TiposDoc.Movimiento, MovGen.Movimiento, MovGen.Fecha, det.Articulo, det.Cantidad.ToDecimal(), MovGen.Bodega, MovGen.Local, "", Me.Text)

            DC.T_MovDet.InsertOnSubmit(MovDet)
        Next

        DC.SubmitChanges()
        Mensaje($"Movimiento N°{xMovimiento.Text} Registrado")

        Cursor = Cursors.Arrow

        If Pregunta("¿Desea imprimir movimiento?") Then
            ImprimirMovimiento(Val(xMovimiento.Text))
        End If

        Auditoria(Me.Text, A_GUARDADO, xDocumento.Text, cTipoDoc.Text)
        Limpiar()
        xMovimiento.Text = SiguienteCorrelativo("MovGen").ToString
        cMovimientos.Focus()


    End Sub


    Private Sub Limpiar(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        cMovimientos.Focus()
        xCantidad.Text = "0"
        xMovimiento.Text = SiguienteCorrelativo("MovGen").ToString
        sDetalleMov.DataSource = New List(Of DetalleMovimiento)

    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Sub ImprimirMovimiento(nMovimiento As Double)

        Dim wMovGs = SQL("Select MG.Movimiento,TM.DescTipo, MG.Fecha,L.Local,L.NombreLocal,B.Bodega,B.NombreBodega,UR.NombreUsr as UsrResponsable,UC.NombreUsr as UsrCreador,E.DescEstado," &
                     " TD.DescTipoDoc,MG.Numdoc,MG.ObsTra,A.Articulo,A.Descripcion,MD.Barra,MD.Cantidad,MD.Precio, MD.Costo, A.SKU" &
                     " FROM MovGen MG" &
                     " JOIN TipoMov TM ON MG.TipoMov = TM.TipoMov" &
                     " JOIN Locales L ON MG.Local = L.Local" &
                     " JOIN Bodegas B ON MG.Bodega = B.Bodega" &
                     " JOIN Usuarios UR ON MG.Responsable = UR.Usuario" &
                     " JOIN Usuarios UC ON MG.Usuario = UC.Usuario" &
                     " JOIN Estados E ON MG.Estado = E.Estado and E.Tipo = 'V'" &
                     " LEFT JOIN TipoDoc TD ON MG.TipoDoc = TD.TipoDoc" &
                     " JOIN MovDet MD ON MG.Movimiento = MD.Movimiento" &
                     " JOIN Articulos A ON MD.Articulo = A.Articulo WHERE MG.Movimiento = '" & nMovimiento.ToString & "'")

        Dim wReporte As New ReporteMovimiento
        Dim wLista = New List(Of MovimientoReporte)
        Dim ListParametros = New List(Of ParametrosReporte)

        Dim wParametros = ParametroReporte()

        For Each wMovG As DataRow In wMovGs.Rows
            Dim mov = New MovimientoReporte
            mov.Movimiento = wMovG.GetInt("Movimiento")
            mov.TipoMov = wMovG.GetText("DescTipo")
            mov.Fecha = wMovG.GetDate("Fecha")
            mov.Local = wMovG.GetText("Local")
            mov.NombreLocal = wMovG.GetText("NombreLocal")
            mov.Bodega = wMovG.GetText("Bodega")
            mov.NombreBodega = wMovG.GetText("NombreBodega")
            mov.UsuarioC = wMovG.GetText("UsrResponsable")
            mov.UsuarioR = wMovG.GetText("UsrCreador")
            mov.Estado = wMovG.GetText("DescEstado")
            mov.TipoDoc = wMovG.GetText("DescTipoDoc")
            mov.NumDoc = wMovG.GetInt("NumDoc")
            mov.Observacion = wMovG.GetText("ObsTra")
            mov.Articulo = wMovG.GetText("Articulo")
            mov.SKU = wMovG.GetText("SKU")
            mov.Descripcion = wMovG.GetText("Descripcion")
            mov.Barra = wMovG.GetText("Barra")
            mov.Cantidad = wMovG.GetInt("Cantidad")
            mov.PVenta = wMovG.GetInt("Precio")
            mov.Costo = wMovG.GetInt("Costo")
            wLista.Add(mov)
        Next

        If wLista.Count > 0 Then
            wReporte.Database.Tables(0).SetDataSource(wLista)
            wReporte.Database.Tables(1).SetDataSource(ListParametros)
            wReporte.PrintToPrinter(1, False, 0, 0)
        Else
            Mensaje("No se encuentran datos para la selección indicada")
            Close()
        End If
    End Sub

    Private Sub bCargarMovimiento_Click(sender As Object, e As EventArgs) Handles bCargarMovimiento.Click
        'Dim wQuery As String
        'wQuery = "SELECT Top 10 MG.Movimiento,Loc.Nombrelocal,tm.DescTipo,b.NombreBodega ,mg.Fecha" &
        '         " FROM MOVGEN MG, TipoMov as tm, Locales as loc, Bodegas as B"
        'Buscador.Show()
        'Buscador.Configurar(wQuery, "MG.Movimiento", Me, "Movimientos", xDocumento, " And MG.Cargado = 0 And tm.tipo = mg.TipoMov And loc.Local=mg.Local And b.Bodega = mg.bodega And mg.local = " & LocalActual)

        'If cTipoDoc.SelectedItem.ToString = "MV" And Val(xDocumento.Text) > 0 Then
        '    'Es Movimiento
        '    Dim wMov = SQL("SELECT Movimiento,Bodega FROM MovGen WHERE Movimiento = " & xDocumento.Text.Trim & " AND Cargado = 0").Top
        '    If wMov IsNot Nothing Then
        '        Cargar_Movimientos(wMov.GetNum("Movimiento"), BuscarCampo("Bodegas", "NombreBodega", "Bodega", wMov.GetText("Bodega")))
        '    Else
        '        MsgError("Movimiento no encontrado o ya fue cargado")
        '        xDocumento.Clear()
        '        xDocumento.Focus()
        '    End If
        'End If
    End Sub

    'Public Sub Cargar_Movimientos(ByVal wMovimiento As Double, ByVal wBodegaOrigen As String)
    '    LimpiarCampos(Me)
    '    Titulos()
    '    cTipoDoc.SelectedValue = "R"
    '    cMovimientos.SelectedValue = "R"
    '    xMovimiento.Text = SiguienteCorrelativo("MovGen").ToString

    '    Dim wArts = SQL("SELECT MD.Articulo,A.Descripcion,MD.Cantidad,MD.Precio FROM MovDet MD " &
    '              " JOIN Articulos A ON MD.Articulo = A.Articulo WHERE Movimiento = " & wMovimiento)

    '    If wArts.Rows.Count > 0 Then
    '        For Each wArt As DataRow In wArts.Rows
    '            xTablaOld.AddItem("")
    '            xTablaOld.SetCellImage(xTablaOld.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
    '            xTablaOld.SetData(xTablaOld.Rows.Count - 1, T_ARTICULO, wArt.GetText("Articulo"))
    '            xTablaOld.SetData(xTablaOld.Rows.Count - 1, T_DESCRIPCION, wArt.GetText("Descripcion"))
    '            xTablaOld.SetData(xTablaOld.Rows.Count - 1, T_BARRA, ObtenerArticulo(wArt.GetText("Articulo")))
    '            xTablaOld.SetData(xTablaOld.Rows.Count - 1, T_CANTIDAD, wArt.GetText("Cantidad"))
    '            xTablaOld.SetData(xTablaOld.Rows.Count - 1, T_PUNITARIO, wArt.GetText("Precio"))
    '            Calcula_Linea(xTablaOld.Rows.Count - 1)
    '        Next

    '    End If
    'End Sub
    'Sub Calcula_Linea(qFil As Integer)
    '    If qFil > 0 Then
    '        If Not IsNumeric((xTablaOld.GetData(qFil, T_CANTIDAD))) Or (xTablaOld.GetData(qFil, T_CANTIDAD).ToString) = "" Then
    '            MsgError("Valor no puede ser vacío o 0")
    '            xTablaOld.SetData(qFil, T_CANTIDAD, 1)
    '        End If
    '        If Trim(xTablaOld.GetData(qFil, T_PUNITARIO).ToString) = "" Then xTablaOld.SetData(qFil, T_PUNITARIO, 0)
    '        If Trim(xTablaOld.GetData(qFil, T_CANTIDAD).ToString) = "" Then xTablaOld.SetData(qFil, T_CANTIDAD, 0)
    '        xTablaOld.SetData(qFil, T_TOTAL, Format(Math.Round(CDbl(xTablaOld.GetData(qFil, T_PUNITARIO)) * Val(xTablaOld.GetData(qFil, T_CANTIDAD)), 1), "##,###"))
    '    End If
    'End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Dim wBuscador = New BuscadorArticulo
        wBuscador.Configurar(Me, xArticulo)
        wBuscador.ShowDialog()
    End Sub

    Private Sub xTabla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles xTabla.CellDoubleClick
        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = 0 Then
            xTabla.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Const T_COSTO = 3
    Const T_CANTIDAD = 5

    Private Sub xTabla_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles xTabla.CellValidating
        If xTabla.EditingControl Is Nothing Then Return
        Dim val = xTabla.EditingControl.Text.ToDecimal()
        If val < 0 Then
            xTabla.EditingControl.Text = "0"
            e.Cancel = True
        End If
    End Sub

    Private Sub xTabla_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles xTabla.CellEndEdit
        Dim art = CType(xTabla.CurrentRow.DataBoundItem, DetalleMovimiento)
        If e.ColumnIndex = T_CANTIDAD Then
            art.Total = art.Cantidad * art.PrecioVenta
        End If
    End Sub

    Private Sub xTabla_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles xTabla.EditingControlShowing
        If {T_CANTIDAD, T_COSTO}.Contains(xTabla.CurrentCell.ColumnIndex) Then
            RemoveHandler e.Control.KeyPress, AddressOf xEditor_KeyPress
            AddHandler e.Control.KeyPress, AddressOf xEditor_KeyPress
        End If
    End Sub

    Private Sub xEditor_KeyPress(sender As Object, e As KeyPressEventArgs)
        ValidarDigitos(e)
    End Sub

    Private Sub xCantidad_Enter(sender As Object, e As EventArgs) Handles xCantidad.Enter
        xCantidad.SelectAll()
    End Sub

    Private Sub sDetalleMov_ListChanged(sender As Object, e As ListChangedEventArgs) Handles sDetalleMov.ListChanged
        lTotal.Text = sDetalleMov.Count.ToString()
    End Sub

    Private Sub xMovimiento_TextChanged(sender As Object, e As EventArgs) Handles xMovimiento.TextChanged

    End Sub
End Class

Public Class DetalleMovimiento

    Public Sub New()
        Eliminar = My.Resources.delete
    End Sub

    Public Property Eliminar As Image
    Public Property Articulo As Decimal
    Public Property SKU As String
    Public Property Barra As String
    Public Property Descripcion As String
    Public Property Costo As Decimal
    Public Property Cantidad As Decimal
    Public Property PrecioVenta As Decimal
    Public Property Total As Decimal

End Class