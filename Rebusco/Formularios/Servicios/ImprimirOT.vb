Public Class ImprimirOT

    Private Sub bImprimirOT_Click(sender As Object, e As EventArgs) Handles bImprimirOT.Click
        Cursor = Cursors.WaitCursor
        Imprimir_OT(xOT.Text.Trim.ToDouble, oAutomatico.Checked)
        Cursor = Cursors.Default
    End Sub

    Private Sub bImprimirRevision_Click(sender As Object, e As EventArgs) Handles bImprimirRevision.Click
        Dim wReporte As New ReporteRevisionOTMecanico
        Dim Lista = New List(Of RevisionOTMecanicoListado)

        Dim wRevs = SQL("SELECT O.OT,O.Tecnico, OD.Articulo,A.Descripcion,OD.Cantidad,A.PVenta" &
                 " FROM OT O" &
                 " JOIN Clientes C ON O.Cliente = C.Cliente" &
                 " JOIN OTDet OD ON O.OT = OD.OT" &
                 " JOIN Articulos A ON OD.Articulo = A.Articulo and A.TipoArticulo = 'S'" &
                 " WHERE O.OT = '" & xOT.Text.Trim & "'")




        For Each wRev As DataRow In wRevs.Rows
            Lista.Add(New RevisionOTMecanicoListado With {.NumeroOT = CInt(wRev.GetText("OT")),
                                                    .tecnico = wRev.GetText("Tecnico"),
                                                    .Articulo = wRev.GetText("Articulo"),
                                                    .Descripcion = wRev.GetText("Descripcion"),
                                                    .Cantidad = CInt(wRev.GetText("Cantidad"))})
        Next

        If Lista.Count > 0 Then
            Dim wListaParametros = ParametroLocal()
            wReporte.Database.Tables("MarketONE_RevisionOTMecanicoListado").SetDataSource(Lista)
            wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wListaParametros)

            If oAutomatico.Checked Then
                wReporte.PrintToPrinter(1, False, 0, 0)
            Else
                VisorReportes.MostrarReporte(wReporte)
                VisorReportes.Show()
                VisorReportes.BringToFront()
            End If
        Else
            MsgError("No se encuentran datos para la selección indicada")
        End If

    End Sub

    Private Sub bImprimirRepuestos_Click(sender As Object, e As EventArgs) Handles bImprimirRepuestos.Click
        Dim wReporte As New ReporteRepuestosPendietes
        Dim wListaRepuestos = New List(Of RepuestosPendientesListado)

        Dim wOTs = SQL("SELECT O.OT,OD.FechaSol, OD.Articulo,A.Descripcion,OD.Cantidad,A.PVenta" &
                 " FROM OT O" &
                 " JOIN Clientes C ON O.Cliente = C.Cliente" &
                 " JOIN OTDet OD ON O.OT = OD.OT" &
                 " JOIN Articulos A ON OD.Articulo = A.Articulo and A.TipoArticulo = 'P'" &
                 " WHERE O.OT = '" & xOT.Text.Trim & "' AND OD.Estado = 'E'")





        For Each wOT As DataRow In wOTs.Rows
            wListaRepuestos.Add(New RepuestosPendientesListado With {.NumeroOT = CInt(wOT.GetText("OT")),
                                                              .Fecha = CDate(wOT.GetText("FechaSol")),
                                                              .Articulo = wOT.GetText("Articulo"),
                                                              .Descripcion = wOT.GetText("Descripcion"),
                                                              .Cantidad = CInt(wOT.GetText("Cantidad"))})
        Next

        If wListaRepuestos.Count > 0 Then
            Dim wListaParametros = ParametroLocal()
            wReporte.Database.Tables("MarketONE_RepuestosPendientesListado").SetDataSource(wListaRepuestos)
            wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wListaParametros)

            If oAutomatico.Checked Then
                wReporte.PrintToPrinter(1, False, 0, 0)
            Else
                VisorReportes.MostrarReporte(wReporte)
                VisorReportes.Show()
                VisorReportes.BringToFront()
            End If
        Else
            MsgError("No se encuentran datos para la selección indicada")
        End If
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub ImprimirOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FE_BV Then
            oAutomatico.Checked = False
        Else
            oAutomatico.Checked = True
        End If
    End Sub
End Class