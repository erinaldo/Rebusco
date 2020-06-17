Public Class ConsultaBodegas
    Const T_LOCAL = 0
    Const T_BODEGA = 1
    Const T_PRINCIPAL = 2
    Const T_DESPACHO = 3
    Const T_MOVIL = 4

    Sub Titulos()

        xTabla.Cols.Count = 5
        xTabla.Rows.Count = 1

        xTabla.Cols(T_LOCAL).Width = 195
        xTabla.Cols(T_BODEGA).Width = 195
        xTabla.Cols(T_PRINCIPAL).Width = 60
        xTabla.Cols(T_DESPACHO).Width = 60
        xTabla.Cols(T_MOVIL).Width = 60

        xTabla.Cols(T_LOCAL).Caption = "Local"
        xTabla.Cols(T_BODEGA).Caption = "Bodega"
        xTabla.Cols(T_PRINCIPAL).Caption = "Principal"
        xTabla.Cols(T_DESPACHO).Caption = "Despacho"
        xTabla.Cols(T_MOVIL).Caption = "Movil"

        xTabla.Cols(T_PRINCIPAL).ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter
        xTabla.Cols(T_DESPACHO).ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter
        xTabla.Cols(T_MOVIL).ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter

    End Sub

    Private Sub ConsultaBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        tBarraProgreso.Visible = False
        Titulos()
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click

        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim wListaLocales = DC.T_Locales.ToList
        Dim wListaBodegas = DC.T_Bodegas.ToList
        If cLocal.Text.Trim <> "" Then
            wListaBodegas = wListaBodegas.Where(Function(x) x.Local = CInt(cLocal.SelectedValue.ToString)).ToList
        End If

        If oPrincipal.Checked Then wListaBodegas = wListaBodegas.Where(Function(x) x.Principal = True).ToList
        If oDespacho.Checked Then wListaBodegas = wListaBodegas.Where(Function(x) x.Despacho = True).ToList
        If oMovil.Checked Then wListaBodegas = wListaBodegas.Where(Function(x) x.Movil = True).ToList

        If wListaBodegas.Any Then
            tMensajeBarra.Text = "Cargado Registros"
            tBarraProgreso.Maximum = wListaBodegas.Count
            tBarraProgreso.Value = 0
            xTabla.Redraw = False
            tBarraProgreso.Visible = True
            Titulos()

            For Each wB In wListaBodegas
                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, wListaLocales.FirstOrDefault(Function(x) x.Local = wB.Local).NombreLocal)
                xTabla.SetData(xTabla.Rows.Count - 1, T_BODEGA, wB.NombreBodega)
                xTabla.SetCellImage(xTabla.Rows.Count - 1, T_PRINCIPAL, ImagenBool(If(IsNothing(wB.Principal), False, wB.Principal)))
                xTabla.SetCellImage(xTabla.Rows.Count - 1, T_DESPACHO, ImagenBool(If(IsNothing(wB.Despacho), False, wB.Despacho)))
                xTabla.SetCellImage(xTabla.Rows.Count - 1, T_MOVIL, ImagenBool(If(IsNothing(wB.Movil), False, wB.Movil)))
                DoEvents()
                tBarraProgreso.Value += 1
            Next
            tMensajeBarra.Text = "Listo"
            xTabla.Redraw = True
            tBarraProgreso.Visible = False
        Else
            MsgError("No se encuentra bodegas con los parametros indicados.")
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        Titulos()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
End Class