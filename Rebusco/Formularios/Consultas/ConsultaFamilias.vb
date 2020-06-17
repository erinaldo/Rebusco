Public Class ConsultaFamilias
    Const T_DESCRIPCION = 0

    Sub Titulos()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 1

        xTabla.Cols(T_DESCRIPCION).Width = 300
        xTabla.Cols(T_DESCRIPCION).Caption = "Descripción"
    End Sub

    Private Sub ConsultaFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tMensajeBarra.Text = "Listo"
        tBarraProgreso.Visible = False
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        Titulos()
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wListaFamiliaUsados = DC.T_Articulos.Select(Function(x) x.Familia).Distinct.ToList
        Dim wListaFamilias = DC.T_Familias.ToList

        If oSi.Checked Then
            wListaFamilias = wListaFamilias.Where(Function(x) wListaFamiliaUsados.Contains(x.Familia)).ToList
        End If
        If oNo.Checked Then
            wListaFamilias = wListaFamilias.Where(Function(x) Not wListaFamiliaUsados.Contains(x.Familia)).ToList
        End If

        If wListaFamilias.Any Then
            xTabla.Redraw = False
            tBarraProgreso.Visible = True
            tBarraProgreso.Maximum = wListaFamilias.Count
            tBarraProgreso.Value = 0
            tMensajeBarra.Text = "Cargando..."
            Titulos()

            For Each wF In wListaFamilias
                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wF.DescFamilia)
                tBarraProgreso.Value += 1
                DoEvents()
            Next

            xTabla.Redraw = True
            tBarraProgreso.Visible = False
            tMensajeBarra.Text = "Lista"

        Else
            MsgError("No se encuentra registros con los filtros indicados")
            bLimpiar_Click()
        End If
    End Sub

    Private Sub oSi_CheckedChanged(sender As Object, e As EventArgs) Handles oSi.CheckedChanged
        If oSi.Checked Then oNo.Checked = False
    End Sub

    Private Sub oNo_CheckedChanged(sender As Object, e As EventArgs) Handles oNo.CheckedChanged
        If oNo.Checked Then oSi.Checked = False
    End Sub
End Class