Imports System.ComponentModel

Public Class Abastecimiento
    Implements iFormulario
    Const T_ID As Integer = 0
    Const T_ARTICULO As Integer = 1
    Const T_DESCRIPCION As Integer = 2
    Const T_CANTIDAD As Integer = 3
    Dim wTotalLocal As Integer
    Dim wFila As Integer
    Private Sub bBuscarC_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bBuscarC.Click
        Dim wQuery As String
        wQuery = "SELECT Cliente as 'Cliente', Nombre as 'Nombre Cliente' From Clientes"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Nombre", Me, "Clientes", xCliente)
    End Sub
    Private Sub bBuscarA_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bBuscarA.Click
        Dim wQuery As String
        wQuery = "SELECT Articulo as 'Artículo', Descripcion as 'Descripción' From Articulos"
        Buscador.Show()
        Buscador.Configurar(wQuery, "Descripcion", Me, "Artículos", xArticulo)
    End Sub
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub xArticulo_Validating(sender As Object, e As CancelEventArgs) Handles xArticulo.Validating
        If xArticulo.ListaVisible Then
            If xArticulo.ListaActiva Then
                Exit Sub
            Else
                xArticulo.OcultarLista()
            End If
        End If

        If Trim(xArticulo.Text) = "" Then
            xNombreArticulo.Clear()
            Exit Sub
        End If

        If xArticulo.DescEncontrada = "" Then
            Dim wIDArticulo = ObtenerArticulo(xArticulo.Text)
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wIDArticulo.ToDecimal())
            If wArt IsNot Nothing Then
                xArticulo.AutoCompletarActivo = False
                xArticulo.Text = wArt.Articulo.ToString()
                xNombreArticulo.Text = wArt.Descripcion
                xArticulo.AutoCompletarActivo = True
                Exit Sub
            End If

            'Dim wSer = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.ToDecimal)
            'If wSer IsNot Nothing Then
            '    xDescripcion.Text = wSer.Descripcion
            '    Exit Sub
            'End If
            Informacion("Artículo no encontrado")
            xNombreArticulo.Clear()
            xArticulo.Clear()
            xArticulo.Focus()
        Else
            xArticulo.AutoCompletarActivo = False
            'xArticulo.Text = xArticulo.IdEncontrado
            xNombreArticulo.Text = xArticulo.DescEncontrada
            xArticulo.AutoCompletarActivo = True
        End If
    End Sub

    Private Sub bMostrar_Click(sender As Object, e As EventArgs) Handles bMostrar.Click
        Cursor = Cursors.WaitCursor
        xTabla.Redraw = False
        Dim wFiltro As String
        Dim wQuery As String = ""
        Dim wNombreLocal As String
        Dim wLocal, wTotalLocales As Integer

        If oFechaSol.Checked Then
            wFiltro = " od.FechaSol Between '" & cDesde.Value & "' AND '" & cHasta.Value & "'"
        Else
            wFiltro = " od.FechaEnt Between '" & cDesde.Value & "' AND '" & cHasta.Value & "'"
        End If

        If Val(xOT.Text) > 0 Then
            wFiltro = wFiltro & " AND od.OT=" & Val(xOT.Text)
        End If

        If Trim(xCliente.Text) <> "" And Trim(xNombreCliente.Text) <> "" Then
            wFiltro = wFiltro & " AND o.Cliente=" & Val(xCliente.Text)
        End If

        If Trim(xArticulo.Text) <> "" And Trim(xNombreArticulo.Text) <> "" Then
            wFiltro = wFiltro & " AND od.Articulo='" & Trim(xArticulo.Text) & "'"
        End If

        Dim wStk = SQL("SELECT (SELECT COUNT(Local) FROM Locales)as Total,Local,NombreLocal" &
                  " FROM Locales Order by Local")
        For Each wS As DataRow In wStk.Rows
            wLocal = CInt(wS.GetText("Local"))
            wTotalLocales = CInt(wS.GetText("Total"))
            wNombreLocal = wS.GetText("NombreLocal")
            wQuery = wQuery + ",Coalesce((SELECT SUM(Stock) FROM Stocks WHERE Articulo=od.Articulo And Local=" & wLocal & " Group By Local),0) as '" & wNombreLocal & "'"
        Next


        wStk = SQL("SELECT od.Articulo,a.Descripcion,COUNT(a.Articulo) as TotalSolicitado " & wQuery & "  " &
                    " FROM OTDet od INNER JOIN Articulos a on od.Articulo=a.Articulo and od.Tipo='A' and od.Estado='E' " &
                    " INNER JOIN OT o on o.OT=od.OT " &
                    " WHERE " & wFiltro & "" &
                    " GROUP By od.Articulo,a.Descripcion")
        Titulos()

        If wStk.Rows.Count = 0 Then
            MsgError("No hay datos para mostrar")
            Cursor = Cursors.Default
            Exit Sub
        End If
        tMensajeBarra.Text = "Cargardo Datos..."
        tBarraProgreso.Visible = True
        tBarraProgreso.Maximum = wStk.Rows.Count
        tBarraProgreso.Value = 0
        For Each wS As DataRow In wStk.Rows
            xTabla.AddItem("")
            xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, wS.GetText("Articulo"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wS.GetText("Descripcion"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDAD, wS.GetText("TotalSolicitado"))

            For i = 1 To wTotalLocales
                xTabla.SetData(xTabla.Rows.Count - 1, i + 3, Trim(wS.Item(i + 2).ToString))
            Next
            tBarraProgreso.Value += 1
            DoEvents()
        Next

        xTabla.AjustarColumnas()
        Cursor = Cursors.Default
        tBarraProgreso.Visible = False
        xTabla.Redraw = True
        tMensajeBarra.Text = "Listo"
        tCantidadR.Text = "Cantidad de Registros  " & xTabla.Rows.Count - 1
        Auditoria(Me.Name, "Consultó Abastecimiento", xOT.Text, CStr(G_LOCALACTUAL))
    End Sub
    Sub Titulos()
        Dim wLoc = SQL("SELECT (SELECT COUNT(Local) FROM Locales)as Total,Local,NombreLocal " &
                  " FROM Locales Order by Local")
        If wLoc.Rows.Count = 0 Then
            wTotalLocal = 0
        Else
            wTotalLocal = CInt(wLoc.Top.GetText("Total"))
        End If

        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 4 + wTotalLocal

        xTabla.Cols(T_ID).Caption = ""
        xTabla.Cols(T_ARTICULO).Caption = "Artículo"
        xTabla.Cols(T_DESCRIPCION).Caption = "Descripción"
        xTabla.Cols(T_CANTIDAD).Caption = "C.Solicitado"

        wFila = T_CANTIDAD
        For Each wL As DataRow In wLoc.Rows
            xTabla.Cols(wFila + 1).Caption = Trim(wL.GetText("NombreLocal"))
            xTabla.Cols(wFila + 1).Width = 100
            xTabla.Cols(wFila + 1).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
            wFila = wFila + 1
        Next

        xTabla.Cols(T_ID).Width = 0
        xTabla.Cols(T_ARTICULO).Width = 200
        xTabla.Cols(T_DESCRIPCION).Width = 100
        xTabla.Cols(T_CANTIDAD).Width = 100
        xTabla.AjustarColumnas
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click


        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wListaOT As New List(Of T_OTDet)

        If oFechaSol.Checked Then
            wListaOT = DC.T_OTDet.Where(Function(x) x.FechaSol >= cDesde.Value And x.FechaSol <= cHasta.Value).ToList
        Else
            wListaOT = DC.T_OTDet.Where(Function(x) x.FechaEnt >= cDesde.Value And x.FechaEnt <= cHasta.Value).ToList
        End If

        If wListaOT.Any Then
            'Dim wOTLocal = wListaOT.Select(Function(x))
        End If
        '    Dim wFila As Integer
        '    Me.MousePointer = vbHourglass
        '    LlenarAbastecimiento()
        '    Salida.Reset
        '    Salida.ReportFileName = Ruta_Imprimir("Abastecimiento.Rpt")

        'Set Stk = Sql("SELECT TOP 3 NombreLocal FROM Locales Order by Local")
        'wFila = 0
        '    Dim wNombreFiltro As String

        '    While Not Stk.EOF
        '        wNombreFiltro = "Local" & wFila + 1
        '        Salida.Formulas(wFila) = "" & wNombreFiltro & "='" & Trim(Stk.Fields("NombreLocal").Value) & "'"
        '        wFila = wFila + 1
        '        Stk.MoveNext
        'Wend

        'If oImprimir.Value Then
        '        Salida.Destination = crptToPrinter
        '    Else
        '        Salida.WindowState = crptMaximized
        '    End If

        '    Salida.Connect = ConectaReporte
        '    Salida.Action = 1
        '    Me.MousePointer = 0
        '    Call Auditoria(Me.Name, "Generó Reporte", xOT.Text, CDbl(LocalActual))
    End Sub


    Private Sub Abastecimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Titulos()
        cDesde.Value = IniFinFecha(1, Now)
        cHasta.Value = IniFinFecha(2, Now)

        If FE_BV Then
            oImprimir.Checked = False
        Else
            oImprimir.Checked = True
        End If

        Call Auditoria(Me.Name, "Ingresó al Módulo", UsuarioActual, CStr(G_LOCALACTUAL))
    End Sub

    Private Sub xCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles xCliente.KeyDown
        If e.KeyCode = Keys.F3 Then
            bBuscarC_Click()
        End If
    End Sub

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        ValidarDigitos(e)
        e.NextControl(xArticulo)
    End Sub

    Private Sub xCliente_Validating(sender As Object, e As CancelEventArgs) Handles xCliente.Validating
        If xCliente.Text <> "" Then
            Dim wCli = SQL("SELECT Nombre FROM Clientes WHERE Cliente=" & Val(xCliente.Text) & "").Top
            If wCli Is Nothing Then
                MsgError("El Cliente ingresado no existe")
                xCliente.Focus()
                Exit Sub
            End If
            xNombreCliente.Text = Trim(wCli.GetText("Nombre"))
        Else
            xNombreCliente.Clear()
        End If
        Application.DoEvents()
    End Sub

    Private Sub xArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles xArticulo.KeyDown
        If e.KeyCode = Keys.F3 Then
            bBuscarA_Click()
        End If
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(cDesde)
    End Sub


    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        Titulos()
        cDesde.Value = IniFinFecha(1, Now)
        cHasta.Value = IniFinFecha(2, Now)
    End Sub

End Class