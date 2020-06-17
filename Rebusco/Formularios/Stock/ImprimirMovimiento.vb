Imports System.ComponentModel

Public Class ImprimirMovimiento
    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        xMovimiento.Clear()
        xMovimiento.Focus()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Cursor = Cursors.WaitCursor
        If xMovimiento.Text.Trim <> "" Then
            Dim wMovGs = SQL("Select MG.Movimiento,TM.DescTipo, MG.Fecha,L.Local,L.NombreLocal,B.Bodega,B.NombreBodega,UR.NombreUsr as UsrResponsable,UC.NombreUsr as UsrCreador,E.DescEstado," &
                  " TD.DescTipoDoc,MG.Numdoc,MG.ObsTra,A.Articulo,A.Descripcion,MD.Barra,MD.Cantidad,MD.Precio,A.SKU, MD.Costo" &
                  " FROM MovGen MG" &
                  " JOIN TipoMov TM ON MG.TipoMov = TM.TipoMov" &
                  " JOIN Locales L ON MG.Local = L.Local" &
                  " JOIN Bodegas B ON MG.Bodega = B.Bodega" &
                  " JOIN Usuarios UR ON MG.Responsable = UR.Usuario" &
                  " JOIN Usuarios UC ON MG.Usuario = UC.Usuario" &
                  " JOIN Estados E ON MG.Estado = E.Estado and E.Tipo = 'V'" &
                  " LEFT JOIN TipoDoc TD ON MG.TipoDoc = TD.TipoDoc" &
                  " JOIN MovDet MD ON MG.Movimiento = MD.Movimiento" &
                  " JOIN Articulos A ON MD.Articulo = A.Articulo WHERE MG.Movimiento = '" & xMovimiento.Text.Trim & "'")


            Dim wLista = New List(Of MovimientoReporte)
            For Each wMovG As DataRow In wMovGs.Rows
                wLista.Add(New MovimientoReporte With {.Movimiento = wMovG.GetInt("Movimiento"),
                                                  .TipoMov = wMovG.GetText("DescTipo"),
                                                  .Fecha = wMovG.GetDate("Fecha"),
                                                  .Local = wMovG.GetText("Local"),
                                                  .NombreLocal = wMovG.GetText("NombreLocal"),
                                                  .Bodega = wMovG.GetText("Bodega"),
                                                  .NombreBodega = wMovG.GetText("NombreBodega"),
                                                  .UsuarioC = wMovG.GetText("UsrResponsable"),
                                                  .UsuarioR = wMovG.GetText("UsrCreador"),
                                                  .Estado = wMovG.GetText("DescEstado"),
                                                  .TipoDoc = wMovG.GetText("DescTipoDoc"),
                                                  .NumDoc = wMovG.GetInt("NumDoc"),
                                                  .Observacion = wMovG.GetText("ObsTra"),
                                                  .Articulo = wMovG.GetText("Articulo"),
                                                  .SKU = wMovG.GetText("SKU"),
                                                  .Descripcion = wMovG.GetText("Descripcion"),
                                                  .Barra = wMovG.GetText("Barra"),
                                                  .Cantidad = wMovG.GetInt("Cantidad"),
                                                  .PVenta = wMovG.GetNum("Precio"),
                                                  .Costo = wMovG.GetNum("Costo")})
            Next

            If wLista.Count > 0 Then
                Dim wReporte As New ReporteMovimiento
                Dim wparamtros = ParametroReporte()
                wReporte.Database.Tables(0).SetDataSource(wLista)
                wReporte.Database.Tables(1).SetDataSource(wparamtros)
                VisorReportes.MostrarReporte(wReporte)
                VisorReportes.WinDeco1.TituloVentana = "Movimiento"
                VisorReportes.Show()
                VisorReportes.BringToFront()
                Auditoria(Me.Text, A_IMPRESO, xMovimiento.Text, "")
                Cursor = Cursors.Arrow
            Else
                Cursor = Cursors.Arrow
                MsgError("No se encuentran datos para la selección indicada")
            End If
        End If
    End Sub

    Private Sub ImprimirMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Auditoria(Me.Text, A_INGRESADO, "", "")
    End Sub

    Private Sub xMovimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMovimiento.KeyPress
        ValidarDigitos(e)
        e.NextControl(bImprimir)
    End Sub

    Private Sub xMovimiento_Validating(sender As Object, e As CancelEventArgs) Handles xMovimiento.Validating
        bImprimir.Focus()
    End Sub

End Class
