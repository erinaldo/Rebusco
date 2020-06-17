Public Class SearchForm
    Dim _Tabla As String
    Dim _IDBusqueda As String
    Dim _CampoBusqueda1 As String
    Dim _CampoBusqueda2 As String
    Dim _CamposAdicionales As String
    Dim _Filtros As String
    Public Property ValorCarga As String
    Sub New(ByVal wTitulo As String, ByVal wTabla As String, ByVal wIDBusqueda As String,
            ByVal wCampoBusqueda1 As String, ByVal wCampoBusqueda2 As String, ByVal wCamposAdicionales As String, wFiltros As String)
        InitializeComponent()
        WinDeco1.Titulo.Text = wTitulo
        _Tabla = wTabla
        _IDBusqueda = wIDBusqueda
        _CampoBusqueda1 = wCampoBusqueda1
        _CampoBusqueda2 = wCampoBusqueda2
        _CamposAdicionales = wCamposAdicionales
        _Filtros = wFiltros
    End Sub
#Region "MenuCopiar"
    Private Sub bCopiar_Click(sender As Object, e As EventArgs) Handles bCopiar.Click
        If bCopiar.Tag IsNot Nothing Then
            Clipboard.SetText(bCopiar.Tag.ToString)
            mMenuTabla.Hide()
        End If
    End Sub

    Private Sub xTabla_MouseDown(sender As Object, e As MouseEventArgs) Handles xTabla.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim xTabla = DirectCast(sender, C1.Win.C1FlexGrid.C1FlexGrid)
            MostrarMenuCopiar(xTabla, e.Location, mMenuTabla, bCopiar)
        End If
    End Sub
#End Region

    Private Sub xBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBuscar.KeyPress
        e.NextControl(bBuscar)
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click

        Dim wBuscar = SQL("SELECT " & _IDBusqueda & "," & _CampoBusqueda1 & If(_CampoBusqueda2 = "", "", " ," & _CampoBusqueda2) & " " & _CamposAdicionales & " FROM " & _Tabla & " WHERE " &
                          "(UPPER(" & _IDBusqueda & ") collate SQL_Latin1_General_Cp1251_CS_AS Like '%" & xBuscar.Text.Trim.ToUpper & "%' OR " &
                          "UPPER(" & _CampoBusqueda1 & ") collate SQL_Latin1_General_Cp1251_CS_AS LIKE '%" & xBuscar.Text.Trim.ToUpper & "%'  " &
                          If(_CampoBusqueda2 = "", ")", " OR UPPER(" & _CampoBusqueda2 & ") collate SQL_Latin1_General_Cp1251_CS_AS LIKE '%" & xBuscar.Text.Trim.ToUpper & "%') ") &
                           If(_Filtros = "", "", " AND " & _Filtros))

        If wBuscar.Rows.Count > 0 Then
            Cursor = Cursors.WaitCursor
            xTabla.Clear()
            xTabla.Rows.Count = 1
            xTabla.Cols.Count = wBuscar.Columns.Count
            xTabla.Redraw = False
            For Each wC As DataColumn In wBuscar.Columns
                xTabla.SetData(0, wC.Ordinal, wC.Caption)
                xTabla.Cols(wC.Ordinal).Width = 1
            Next

            For Each wR As DataRow In wBuscar.Rows
                DoEvents()
                xTabla.AddItem("")
                For Each wCol As C1.Win.C1FlexGrid.Column In xTabla.Cols
                    xTabla.SetData(xTabla.Rows.Count - 1, wCol.Index, wR.Item(wCol.Index).ToString)
                Next
                DoEvents()
            Next
            xTabla.Redraw = True
            Cursor = Cursors.Default
            xTabla.AjustarColumnas()
            xTabla.Focus()
        End If

    End Sub

    Private Sub Aceptar(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bAceptar.Click, xTabla.DoubleClick
        If xTabla.Rows.Count > 1 Then
            ValorCarga = xTabla.GetData(xTabla.Row, 0).ToString
            DialogResult = DialogResult.Yes
        End If
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub xTabla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTabla.KeyPress
        If e.KeyChar = vbCr Then
            Aceptar()
        End If
    End Sub
End Class