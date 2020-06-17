Public Class ConsultaEstados
    Const T_ESTADO = 0
    Const T_DESCRIPCICON = 1

    Private Sub ConsultaEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cTipoEstado.LoadItemsObj("TipoEstados", "Tipo", "DescTipo")
        tMensajeBarra.Text = "Lista"
        tBarraProgreso.Visible = False
    End Sub

    Sub Titulos()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 2

        xTabla.Cols(T_ESTADO).Width = 60
        xTabla.Cols(T_DESCRIPCICON).Width = 340

        xTabla.Cols(T_ESTADO).Caption = "Estado"
        xTabla.Cols(T_DESCRIPCICON).Caption = "Descripción"

        xTabla.Cols(T_ESTADO).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        Titulos()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        Dim DC = New RebuscoDataContext(P_CONEXION)

        Dim wListaEstados = DC.T_Estados.ToList

        If cTipoEstado.Text <> "" Then
            wListaEstados = wListaEstados.Where(Function(x) x.Tipo = cTipoEstado.SelectedValue.ToString).ToList
        End If

        If wListaEstados.Any Then
            xTabla.Redraw = False
            tMensajeBarra.Text = "Cargando..."
            tBarraProgreso.Maximum = wListaEstados.Count
            tBarraProgreso.Value = 0
            Titulos()
            For Each wE In wListaEstados
                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, wE.Estado)
                xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCICON, wE.DescEstado)
                tBarraProgreso.Value += 1
                DoEvents()
            Next

            xTabla.Redraw = True
            tMensajeBarra.Text = "Listo"
            tBarraProgreso.Visible = False
        Else
            MsgError("No se encuentra datos para los filtros indicados")
            bLimpiar_Click()
        End If
    End Sub
End Class