Public Class ConsultaEventosRem
    Const T_EVENTOREM = 0
    Const T_DESCRIPCION = 1
    Const T_CALCULOREM = 2

    Sub Titulos()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 3

        xTabla.Cols(T_EVENTOREM).Width = 60
        xTabla.Cols(T_DESCRIPCION).Width = 280
        xTabla.Cols(T_CALCULOREM).Width = 60

        xTabla.Cols(T_EVENTOREM).Caption = "Evento"
        xTabla.Cols(T_DESCRIPCION).Caption = "Descripción"
        xTabla.Cols(T_CALCULOREM).Caption = "Calculo"

        xTabla.Cols(T_EVENTOREM).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
    End Sub

    Private Sub ConsultaEventosRem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wLista = New List(Of ItemCombo)

        wLista.Add(New ItemCombo With {.ID = "+", .Desc = "SUMAR"})
        wLista.Add(New ItemCombo With {.ID = "-", .Desc = "RESTAR"})
        wLista.Add(New ItemCombo With {.ID = "=", .Desc = "IGUAL"})

        cCalculoRem.ValueMember = "ID"
        cCalculoRem.DisplayMember = "Desc"
        cCalculoRem.DataSource = wLista
        tMensajeBarra.Text = "Listo"
        tBarraProgreso.Visible = False
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        Titulos()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wListaEventos = DC.T_EventosRem.ToList

        If cCalculoRem.Text <> "" Then
            wListaEventos = wListaEventos.Where(Function(x) x.CalculoRem = cCalculoRem.SelectedValue.ToString).ToList
        End If

        If wListaEventos.Any Then
            xTabla.Redraw = False
            tMensajeBarra.Text = "Cargando..."
            tBarraProgreso.Visible = True
            tBarraProgreso.Maximum = wListaEventos.Count
            tBarraProgreso.Value = 0
            Titulos()

            For Each wE In wListaEventos
                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_EVENTOREM, wE.EventoRem)
                xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wE.DescEventoRem)
                xTabla.SetData(xTabla.Rows.Count - 1, T_CALCULOREM, wE.CalculoRem)
                tBarraProgreso.Value += 1
                DoEvents()
            Next

            xTabla.Redraw = True
            tMensajeBarra.Text = "Listo"
            tBarraProgreso.Visible = False
        Else
            MsgError("No se encuentran datos para los filtros indicados")
            bLimpiar_Click()
        End If
    End Sub
End Class