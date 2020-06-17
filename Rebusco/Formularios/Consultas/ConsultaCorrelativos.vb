Public Class ConsultaCorrelativos
    Const T_LOCAL = 0
    Const T_POS = 1
    Const T_TIPODOC = 2
    Const T_CORRELATIVO = 3
    Const T_INICIO = 4
    Const T_FINAL = 5
    Const T_FECHA = 6

    Private Sub ConsultaCorrelativos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        tMensajeBarra.Text = "Listo"
        tBarraProgreso.Visible = False
    End Sub

    Sub Titulos()
        xTabla.Cols.Count = 7
        xTabla.Rows.Count = 1

        xTabla.Cols(T_LOCAL).Width = 130
        xTabla.Cols(T_POS).Width = 40
        xTabla.Cols(T_TIPODOC).Width = 120
        xTabla.Cols(T_CORRELATIVO).Width = 90
        xTabla.Cols(T_INICIO).Width = 90
        xTabla.Cols(T_FINAL).Width = 90
        xTabla.Cols(T_FECHA).Width = 90

        xTabla.Cols(T_LOCAL).Caption = "Local"
        xTabla.Cols(T_POS).Caption = "Caja"
        xTabla.Cols(T_TIPODOC).Caption = "Tipo Documento"
        xTabla.Cols(T_CORRELATIVO).Caption = "Correlativo"
        xTabla.Cols(T_INICIO).Caption = "Inicio"
        xTabla.Cols(T_FINAL).Caption = "Final"
        xTabla.Cols(T_FECHA).Caption = "Fecha de Carga"

    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        Titulos()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wListaLocales = DC.T_Locales.ToList
        Dim wListaTipoDoc = DC.T_TipoDoc.ToList
        Dim wListaCorrelativo = DC.T_Correlativos.ToList

        If wListaCorrelativo.Any Then
            If cLocal.Text <> "" Then
                wListaCorrelativo = wListaCorrelativo.Where(Function(x) x.Local = CInt(cLocal.SelectedValue.ToString)).ToList
            End If
            If wListaCorrelativo.Any Then
                Titulos()
                tMensajeBarra.Text = "Cargando..."
                tBarraProgreso.Value = 0
                tBarraProgreso.Maximum = wListaCorrelativo.Count
                tBarraProgreso.Visible = True
                xTabla.Redraw = False

                For Each wC In wListaCorrelativo
                    xTabla.AddItem("")
                    xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, wListaLocales.FirstOrDefault(Function(x) x.Local = wC.Local).NombreLocal)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_POS, wC.POS)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_TIPODOC, wListaTipoDoc.FirstOrDefault(Function(x) x.TipoDoc = wC.TipoDoc).DescTipoDoc)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_CORRELATIVO, wC.Correlativo)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_INICIO, wC.Inicial)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FINAL, wC.Final)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, wC.FechaCAF)

                    xTabla.FuenteCelda(xTabla.Rows.Count - 1, T_INICIO, C_AMARILLO_CELDA, Color.Black, True)
                    xTabla.FuenteCelda(xTabla.Rows.Count - 1, T_FINAL, C_CELDA_SEL, Color.Black, True)

                    tBarraProgreso.Value += 1
                    DoEvents()
                Next

                xTabla.Redraw = True
                    tMensajeBarra.Text = "Listo"
                    tBarraProgreso.Visible = False
                End If
            End If

    End Sub
End Class