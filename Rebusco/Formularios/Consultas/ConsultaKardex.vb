Imports System.ComponentModel

Public Class ConsultaKardex

    Private Sub xArticulo_Validating(sender As Object, e As CancelEventArgs) Handles xArticulo.Validating
        Dim DC = New MarketONEDataContext(P_CONEXION)

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
            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wIDArticulo.ToDecimal())
            If wArt IsNot Nothing Then
                xArticulo.AutoCompletarActivo = False
                xArticulo.Text = wArt.Articulo.ToString()
                xDescripcion.Text = wArt.Descripcion
                xSKU.Text = wArt.SKU
                xArticulo.AutoCompletarActivo = True
                Exit Sub
            End If

            Informacion("Artículo no encontrado")
            xDescripcion.Clear()
            xArticulo.Clear()
            xArticulo.Focus()
        Else
            xArticulo.AutoCompletarActivo = False
            Dim wIDArticulo = ObtenerArticulo(xArticulo.Text)
            xDescripcion.Text = xArticulo.DescEncontrada
            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wIDArticulo.ToDecimal())
            If wArt IsNot Nothing Then
                xArticulo.AutoCompletarActivo = False
                xArticulo.Text = wArt.Articulo.ToString()
                xSKU.Text = wArt.SKU
                xArticulo.AutoCompletarActivo = True
                Exit Sub
            End If
            xArticulo.AutoCompletarActivo = True
        End If
    End Sub

    Private Sub xArticulo_ItemSeleccionado(wDescripcion As String) Handles xArticulo.ItemSeleccionado
        xDescripcion.Text = wDescripcion
        bConsultar.Focus()
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(bConsultar)
    End Sub

    Public Function GenerarKardex(warticulo As Decimal, wDesde As DateTime, wHasta As DateTime, Optional wLocal As Decimal = 0, Optional wBodega As Decimal = 0) As List(Of KardexConsulta)


        Dim wListaKardex = New List(Of KardexConsulta)
        Dim wDC = New MarketONEDataContext(P_CONEXION)
        Dim wTipoDocs = wDC.T_TipoDoc.ToList()
        Dim wTipoMovs = wDC.T_TipoMov.ToList()

        Dim wMovEntrada = wTipoMovs.Where(Function(x) x.Ajuste = "+").Select(Function(x) x.TipoMov)
        Dim wMovSalida = wTipoMovs.Where(Function(x) x.Ajuste = "-").Select(Function(x) x.TipoMov)
        Dim wMovIgualdad = wTipoMovs.Where(Function(x) x.Ajuste = "=").Select(Function(x) x.TipoMov)

        Dim wDocEntrada = wTipoDocs.Where(Function(x) x.Modo = "+").Select(Function(x) x.TipoDoc)
        Dim wDocSalida = wTipoDocs.Where(Function(x) x.Modo = "-").Select(Function(x) x.TipoDoc)

        Dim wMovimientosDet = wDC.T_KardexMovimientos.Where(Function(x) x.Articulo = xArticulo.Text.ToDecimal() And x.Fecha >= wDesde And x.Fecha <= wHasta).ToList()

        If wLocal > 0 Then
            wMovimientosDet = wMovimientosDet.Where(Function(x) x.Local = wLocal).ToList()
        End If

        If wBodega > 0 Then
            wMovimientosDet = wMovimientosDet.Where(Function(x) x.Bodega = wBodega).ToList()
        End If

        For Each wMovDet In wMovimientosDet
            Dim wMovimiento = wDC.T_MovGen.FirstOrDefault(Function(x) x.Movimiento = wMovDet.Movimiento)

            If wMovimiento IsNot Nothing Then
                Dim wKardex = New KardexConsulta With
                    {
                        .Articulo = wMovDet.Articulo,
                        .Descripcion = wMovDet.Descripcion.Trim(),
                        .DescripcionMovimiento = wMovDet.DescTipo.Trim(),
                        .DescripcionTipoDoc = wMovDet.DescTipoDoc.Trim(),
                        .Entrada = 0,
                        .FechaHora = wMovDet.Fecha,
                        .Usuario = wMovimiento.Usuario.Trim(),
                        .Modo = "",
                        .TipoMov = wMovimiento.TipoMov,
                        .TipoDoc = wMovimiento.TipoDoc,
                        .NumDoc = wMovimiento.Movimiento,
                        .Salida = 0,
                        .NombreUsuario = wMovDet.NombreUsr.Trim(),
                        .Saldo = 0,
                        .SKU = wMovDet.SKU,
                        .Local = wMovDet.NombreLocal.Trim(),
                        .Bodega = wMovDet.NombreBodega.Trim()
                    }

                If wMovEntrada.Contains(wMovimiento.TipoMov) Then
                    wKardex.Entrada = wMovDet.Cantidad.ToDecimal()
                End If

                If wMovSalida.Contains(wMovimiento.TipoMov) Then
                    wKardex.Salida = wMovDet.Cantidad.ToDecimal()
                End If

                If wMovIgualdad.Contains(wMovimiento.TipoMov) Then
                    wKardex.Entrada = wMovDet.Cantidad.ToDecimal()
                    wKardex.Salida = wMovDet.Cantidad.ToDecimal()
                    wKardex.Saldo = wMovDet.Cantidad.ToDecimal()
                End If

                wListaKardex.Add(wKardex)
            End If
        Next

        Dim wDocumentosDet = wDC.T_KardexDocumentos.Where(Function(x) x.Articulo = warticulo And x.Fecha >= wDesde And x.Fecha <= wHasta)

        If wLocal > 0 Then
            wDocumentosDet = wDocumentosDet.Where(Function(x) x.Local = wLocal)
        End If

        If wBodega > 0 Then
            wDocumentosDet = wDocumentosDet.Where(Function(x) x.Bodega = wBodega)
        End If

        For Each wDocumento In wDocumentosDet
            Dim wKardex = New KardexConsulta With
                    {
                        .Articulo = wDocumento.Articulo,
                        .Descripcion = wDocumento.Descripcion.Trim(),
                        .DescripcionMovimiento = If(wDocSalida.Contains(wDocumento.TipoDoc), "VENTA", ""),
                        .DescripcionTipoDoc = wDocumento.DescTipoDoc.Trim(),
                        .Entrada = If(wDocEntrada.Contains(wDocumento.TipoDoc), wDocumento.Cantidad.ToDecimal(), 0),
                        .FechaHora = wDocumento.Fecha,
                        .Usuario = wDocumento.Usuario.Trim(),
                        .Modo = "",
                        .TipoMov = "",
                        .TipoDoc = wDocumento.TipoDoc.Trim(),
                        .NumDoc = wDocumento.Numero,
                        .Salida = If(wDocSalida.Contains(wDocumento.TipoDoc), wDocumento.Cantidad.ToDecimal(), 0),
                        .NombreUsuario = wDocumento.NombreUsr.Trim(),
                        .Saldo = 0,
                        .SKU = wDocumento.SKU,
                        .Local = wDocumento.NombreLocal.Trim(),
                        .Bodega = wDocumento.NombreBodega.Trim()
                    }
            wListaKardex.Add(wKardex)
        Next

        wListaKardex = wListaKardex.OrderBy(Function(x) x.FechaHora).ToList()
        Dim wSaldo As Decimal = 0
        For Each wItems In wListaKardex
            If wItems.Entrada = wItems.Salida Then
                wItems.Saldo = wItems.Entrada
                wSaldo = wItems.Saldo
                Continue For
            End If

            If wItems.Entrada > 0 Then wSaldo += wItems.Entrada
            If wItems.Salida > 0 Then wSaldo -= wItems.Salida
            wItems.Saldo = wSaldo
        Next

        Return wListaKardex
    End Function


    Private Sub dDesde_ValueChanged(sender As Object, e As EventArgs) Handles dDesde.ValueChanged
        If dDesde.Value > dHasta.Value Then
            dDesde.Value = dHasta.Value.AddDays(-1)
        End If
    End Sub

    Private Sub dHasta_ValueChanged(sender As Object, e As EventArgs) Handles dHasta.ValueChanged
        If dHasta.Value < dDesde.Value Then
            dHasta.Value = dDesde.Value.AddDays(1)
        End If
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        If xArticulo.Text.Trim = "" Then
            MsgError("Debe indicar artículo")
            xArticulo.Focus()
            Exit Sub
        End If

        Dim wLocal As Decimal = 0
        Dim wBodega As Decimal = 0

        If cLocal.Text <> "" Then
            wLocal = cLocal.SelectedValue.ToString().ToDecimal()
        End If

        If cBodega.Text <> "" Then
            wBodega = cBodega.SelectedValue.ToString().ToDecimal()
        End If

        Dim wKardex = GenerarKardex(xArticulo.Text.ToDecimal(), dDesde.Value, dHasta.Value, wLocal, wBodega)

        If Not wKardex.Any Then
            MsgError("No se encuentra registro para los filtros indicados")
            KardexConsultaBindingSource.DataSource = Nothing
            Exit Sub
        End If

        KardexConsultaBindingSource.Load(wKardex)
    End Sub

    Private Sub ConsultaKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Visible = True
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        dDesde.Value = IniFinFecha(1, Now)
        dHasta.Value = IniFinFecha(2, Now)
        xArticulo.Clear()
        xArticulo.Focus()
    End Sub

    Private Sub ConsultaKardex_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bLimpiar_Click()
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
    End Sub

    Private Sub cLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cLocal.SelectedIndexChanged
        If cLocal.Text = "" Then Exit Sub
        cBodega.LoadItemsObj("Bodegas", "Bodega", "NombreBodega", " WHERE Local = " & cLocal.SelectedValue.ToString())
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If xArticulo.Text.Trim = "" Then
            MsgError("Debe indicar artículo")
            xArticulo.Focus()
            Exit Sub
        End If

        If xTabla.Rows.Count = 0 Then
            MsgError("No se encuentra información cargada para generar el reporte.")
            Exit Sub
        End If

        Dim wEncabezado = New EncabezadoKardezReporte With
            {
                .Articulo = xArticulo.Text,
                .SKU = xSKU.Text,
                .DescripcionArticulo = xDescripcion.Text,
                .Local = cLocal.Text,
                .Bodega = cBodega.Text,
                .Desde = dDesde.Value,
                .Hasta = dHasta.Value
            }

        Dim wListadoKardexDetalle = New List(Of KardexConsulta)
        wListadoKardexDetalle = DirectCast(KardexConsultaBindingSource.DataSource, List(Of KardexConsulta))
        Dim wListaParametros = ParametroReporte()
        Dim wReporte = New ReporteConsultaKardex

        wReporte.Database.Tables("MarKetONE_KardexConsulta").SetDataSource(wListadoKardexDetalle)
        wReporte.Database.Tables("MarketONE_EncabezadoKardezReporte").SetDataSource({wEncabezado}.ToList())
        wReporte.Database.Tables("MarKetONE_ParametrosReporte").SetDataSource(wListaParametros)

        VisorReportes.MostrarReporte(wReporte)
        VisorReportes.Show()
        VisorReportes.BringToFront()
    End Sub
End Class

'Public Function GenerarKardex(warticulo As Decimal, wDesde As DateTime, wHasta As DateTime) As List(Of KardexConsulta)
'    Dim wDC = New MarketONEDataContext(P_CONEXION)
'    Dim wListado = New List(Of KardexConsulta)
'    Dim wArticulos = wDC.T_Articulos.ToList()
'    Dim wTipoMovs = wDC.T_TipoMov.ToList()
'    Dim wTipoDocs = wDC.T_TipoDoc.ToList()
'    Dim wUsuarios = wDC.T_Usuarios.ToList()

'    Dim wTracking = wDC.T_Tracking.Where(Function(x) x.Articulo = xArticulo.Text.ToDecimal() And
'                                                                  x.FechaEvento >= wDesde And
'                                                                  x.FechaEvento <= wHasta And
'                                                                  {201D, 202D, 203D, 204D}.Contains(x.Evento))
'    For Each wTra In wTracking
'        Dim wUsuario = wUsuarios.FirstOrDefault(Function(x) x.Usuario = wTra.Usuario)
'        Dim wDescripcionMovimiento = ""
'        Dim wDescripcionTipoDoc = ""
'        Dim wTipoMov = ""

'        If wTra.TipoDoc = "MV" Then
'            Dim wMovimiento = wDC.T_MovGen.FirstOrDefault(Function(x) x.Movimiento = wTra.NumDoc)
'            If wMovimiento IsNot Nothing Then
'                Dim wConsultaTipoMov = wTipoMovs.FirstOrDefault(Function(x) x.TipoMov = wMovimiento.TipoMov)
'                wDescripcionMovimiento = wConsultaTipoMov.DescTipo.Trim()
'                wTipoMov = wConsultaTipoMov.TipoMov.Trim()
'            End If
'        End If

'        Dim wConsultaTipoDoc = wTipoDocs.FirstOrDefault(Function(x) x.TipoDoc = wTra.TipoDoc)
'        If wConsultaTipoDoc IsNot Nothing Then
'            wDescripcionTipoDoc = wConsultaTipoDoc.DescTipoDoc.Trim()
'        End If

'        Dim wKardex = New KardexConsulta With
'        {
'            .Articulo = wTra.Articulo,
'            .Cantidad = wTra.Cantidad,
'            .Descripcion = wTra.Descripcion,
'            .DescripcionMovimiento = wDescripcionMovimiento,
'            .DescripcionTipoDoc = If(wTipoMov = "MV", "", wDescripcionTipoDoc),
'            .Modo = "",
'            .NumDoc = wTra.NumDoc,
'            .SKU = wTra.SKU,
'            .TipoDoc = wTra.TipoDoc,
'            .TipoMov = wTipoMov,
'            .Usuario = wTra.Usuario,
'            .NombreUsuario = If(wUsuario Is Nothing, "", wUsuario.NombreUsr)
'        }
'        wListado.Add(wKardex)
'    Next
'    Return wListado
'End Function