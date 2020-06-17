Imports C1.Win.C1FlexGrid

Public Class Buscador
    Dim gFormulario As iFormulario
    Dim gCampos As String
    Dim gTablas As String
    Dim gIndice As String
    Dim gControl As Control
    Dim gQuery As String
    Dim gFiltro As String
    Dim wFila As Integer

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

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Buscar_Datos()
    End Sub
    Sub Buscar_Datos()
        Try
            xTabla.Redraw = False
            Cursor = Cursors.WaitCursor
            bBuscar.Enabled = False
            xTabla.Rows.Count = 1
            xTabla.Cols.Count = 1

            Dim REG = SQL(gQuery & " WHERE " & gIndice & " Like '%" & xBuscar.Text & "%' " & gFiltro)
            If REG.Rows.Count > 0 Then
                xProgreso.Visible = True
                bBuscar.Enabled = False
                bCancelar.Enabled = False
                xProgreso.Value = 1
                xProgreso.Minimum = 1
                xProgreso.Maximum = REG.Rows.Count
                xTabla.Clear()
                xTabla.Rows.Count = 1
                xTabla.Cols.Count = REG.Columns.Count

                For i = 0 To REG.Columns.Count - 1
                    xTabla.SetData(0, i, REG.Columns.Item(i).Caption)
                    xTabla.Cols(i).Width = 1
                Next

                wFila = 1
                xTabla.Redraw = False

                For Each wB As DataRow In REG.Rows
                    Application.DoEvents()
                    xTabla.AddItem("")
                    For Col = 0 To xTabla.Cols.Count - 1
                        xTabla.SetData(wFila, Col, wB.Item(Col))
                    Next Col
                    xProgreso.Value = wFila
                    wFila += 1
                Next
                xTabla.AjustarColumnas
                lCantidadArticulos.Text = CStr(wFila - 1)
                xTabla.Redraw = True
                xProgreso.Value = 1
                xProgreso.Visible = False
                bBuscar.Enabled = True
                bCancelar.Enabled = True
                Auditoria(Text, WinDeco1.Titulo.Text, "", "0")
                xTabla.AjustarColumnas
                xTabla.Focus()
            Else
                MsgError("No hay datos para Mostrar")
                xTabla.Clear()
                xTabla.Rows.Count = 1
                lCantidadArticulos.Text = "0"
                xBuscar.SelectAll()
                xBuscar.Focus()
            End If
        Catch ex As Exception
        Finally
            xTabla.Redraw = True
            Cursor = Cursors.Arrow
            bBuscar.Enabled = True
        End Try

    End Sub

    Public Sub Configurar(ByVal wQuery As String, ByVal wClave As String, wFormulario As iFormulario, ByVal wTitulo As String, wControl As Control, Optional wFiltro As String = "")
        gFormulario = wFormulario
        gQuery = wQuery
        gIndice = wClave
        gControl = wControl
        WinDeco1.Titulo.Text = "Buscar " & wTitulo
    End Sub

    Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs) Handles xTabla.DoubleClick
        Dim wRegistro As String = xTabla.GetData(xTabla.Row, 0).ToString
        gFormulario.CargarRegistro(gControl, wRegistro)
        Close()
    End Sub

    Private Sub xTabla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTabla.KeyPress
        If e.KeyChar = vbCr AndAlso xTabla.Rows.Count > 1 Then
            Dim wRegistro As String = xTabla.GetData(xTabla.Row, 0).ToString
            gFormulario.CargarRegistro(gControl, wRegistro)
            Close()
            'Dim wRegistro As String = xTabla.GetData(xTabla.Row, xTabla.indiceNombreColumna(gIndice))
            'gFormulario.CargarRegistro(gControl, wRegistro)
            'Close()
        End If
    End Sub

    Private Sub xBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBuscar.KeyPress
        If e.KeyChar = vbCr Then
            Buscar_Datos()
        End If
    End Sub
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub


End Class

