Imports System.Collections.Specialized
Imports System.ComponentModel
Imports C1.Win.C1FlexGrid
Public Class ServicioTecnico
    Implements iFormulario
    Const T_ELIMINAR = 0

    Const T_SER_SERVICIO = 1
    Const T_SER_DESCRIPCION = 2
    Const T_SER_CANTIDAD = 3
    Const T_SER_ESTADO = 4
    Const T_SER_TECNICO = 5
    Const T_SER_FECHAENTREGA = 6
    Const T_SER_FECHASOLICITUD = 7
    Const T_SER_FECHA = 8

    Const T_ART_ARTICULO = 1
    Const T_ART_DESCRIPCION = 2
    Const T_ART_CANTIDAD = 3
    Const T_ART_ESTADO = 4
    Const T_ART_STOCK = 5
    Const T_ART_TECNICO = 6
    Const T_ART_FECHA = 7
    Const T_ART_FECHASOLICITUD = 8
    Const T_ART_FECHAENTREGA = 9

    Dim wValorAnterior As String
    Dim wStockTabla As Integer

    Private Sub ServicioTecnico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Titulos()
        cTecnicos.LoadItemsObj("Usuarios", "Usuario", "NombreUsr", " WHERE Acceso IN (3,4,5)")
        gServicios.Enabled = False
        Call Auditoria(Me.Name, A_INGRESADO, UsuarioActual, CStr(G_LOCALACTUAL))
    End Sub

    Private Sub bConfirmar_Click(sender As Object, e As EventArgs) Handles bConfirmar.Click
        If xOT.Text.Trim = "" Then
            MsgError("El campo OT no puede estar vacío")
            xOT.Focus()
            Exit Sub
        End If
        If xObsTecnico.Text.Trim = "" Then
            MsgError("El campo Observaciones del técnico no puede estar vacío")
            If Not xObsTecnico.Enabled Then Exit Sub
            tObservacion.SelectTab(ObsTec)
            xObsTecnico.Focus()
            Exit Sub
        End If

        If Not Pregunta("¿Confirma la Revisión de la OT " & Trim(xOT.Text) & "?") Then Exit Sub
        ConfirmarRevision()
    End Sub


    Sub ConfirmarRevision()
        Dim wMensaje As String
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim wOT = DC.T_OT.FirstOrDefault(Function(x) x.OT = Val(xOT.Text))
        If wOT IsNot Nothing Then

            If wOT.Estado = EstadosOT.Finalizada Then
                wOT.Estado = EstadosOT.Cerrada
                wMensaje = "OT modificada y cerrada correctamente"
                Auditoria(Me.Name, "Revisó OT", xOT.Text, CStr(G_LOCALACTUAL))
                Tracking.Ingresar(Tracking.Eventos.OTCerrada, DateTime.Now, wOT.Cliente, "OT", wOT.OT, wOT.Fecha, 0, "", wOT.Recepcion, Me.Text)
            Else
                wMensaje = "OT modificada correctamente"
                Auditoria(Me.Name, "Cerró OT", xOT.Text, CStr(G_LOCALACTUAL))
            End If

            wOT.TecnicoRevision = UsuarioActual
            wOT.FechaCierre = Now
            wOT.ObsTecnico = xObsTecnico.Text
            DC.SubmitChanges()
            Mensaje(wMensaje)
            InicioEstados()
            'LimpiarCampos(Me)
            xOT.Focus()
        End If
    End Sub
    Sub InicioEstados()

        bConfirmar.Visible = False


        If Trim(xOT.Text) <> "" Then
            Dim wOT = SQL("SELECT ESTADO FROM OT WHERE OT = '" & Trim(xOT.Text) & "'").Top
            If wOT IsNot Nothing Then

                Dim wEst = SQL("SELECT DescEstado,Estado FROM Estados " &
                  " WHERE Estado = '" & wOT.GetText("Estado") & "' and Tipo='O'").Top

                xEstado.Text = wEst.GetText("DescEstado").ToUpper

                'i= Ingresado
                'A= Asignado a técnico


                Select Case wOT.GetText("Estado")
                    Case "I", "A"
                        gServicios.Enabled = False
                        gArticulos.Enabled = False
                        bIniciar.Enabled = True
                        bGuardar.Enabled = False
                        xObsTecnico.Enabled = True
                        xObsCliente.Enabled = True
                        gTecnico.Enabled = True
                        bIniciar.Text = "Iniciar Servicio"
                        bIniciar.Visible = True

                    'D=Cerrada
                    'F=Finalizado
                    'N=Nula
                    Case "D", "F", "N"
                        gServicios.Enabled = False
                        gArticulos.Enabled = False
                        bIniciar.Enabled = False
                        bGuardar.Enabled = False
                        If wOT.GetText("Estado") <> "F" Then
                            xObsTecnico.Enabled = False
                            xObsCliente.Enabled = False
                        Else
                            xObsTecnico.Enabled = True
                            xObsCliente.Enabled = True
                        End If
                        gTecnico.Enabled = False
                        bIniciar.Text = "Finalizado"
                        bIniciar.Visible = False

                        If wOT.GetText("ESTADO") = "F" Then
                            bConfirmar.Visible = True
                        End If

                    'C=Iniciada
                    Case "C"
                        gServicios.Enabled = True
                        gArticulos.Enabled = True
                        xObsTecnico.Enabled = True
                        xObsCliente.Enabled = True
                        bIniciar.Enabled = True
                        bGuardar.Enabled = True
                        gTecnico.Enabled = False
                        bIniciar.Text = "Finalizar Servicio"
                        bIniciar.Visible = True

                End Select
            End If
        End If
    End Sub
    Private Sub bImprimirRevision_Click()
        'If Trim(xOT.Text) <> "" Then
        'If xTablaArticulos.Rows - 1 = 0 Then
        '    El_Error ("No hay artículos agregados para generar el informe")
        '    Exit Sub
        'End If
        '    If Pregunta("¿Desea imprimir la Revisión de la OT?") = True Then
        '        Cursor = Cursors.WaitCursor
        '        Salida.Reset
        '        Dim wFiltro As String
        '        wFiltro = "({OTDet.OT} = " & Val(xOT.Text) & ")"
        '        Salida.SelectionFormula = wFiltro
        '        Salida.ReportFileName = Ruta_Imprimir("RepuestosOT.RPT")
        '        Salida.Connect = ConectaReporte
        '        Salida.DiscardSavedData = True
        '        If oImprimir.Value Then
        '            Salida.Destination = crptToPrinter
        '        Else
        '            Salida.WindowState = crptMaximized
        '        End If
        '        '
        '        Salida.Action = 1
        '        Me.MousePointer = vbDefault
        '    End If
        'Else
        '    El_Error("Indique número de OT")
        '    xOT.SetFocus
        'End If
    End Sub
    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If xOT.Text <> "" Then
            Dim wOT = SQL("Select OT FROM OT WHERE OT = '" & xOT.Text & "'").Top
            If wOT IsNot Nothing Then
                ImprimirOT.xOT.Text = xOT.Text.Trim
                ImprimirOT.ShowDialog()
            Else
                MsgError("Número de OT no encontrada")
            End If
        End If
    End Sub

    Private Sub bIniciar_Click(sender As Object, e As EventArgs) Handles bIniciar.Click
        Dim wMensaje As String = ""

        If cTecnicos.Text = "" Then
            MsgError("Debe indicar técnico para realizar esta acción")
            cTecnicos.Focus()
            Exit Sub
        End If

        If Trim(xOT.Text) <> "" Then
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wOT = DC.T_OT.FirstOrDefault(Function(x) x.OT = xOT.Text.ToDecimal)
            If wOT IsNot Nothing Then
                If bIniciar.Text = "Iniciar Servicio" Then
                    If xTecnico.Text <> "" Then
                        wOT = DC.T_OT.FirstOrDefault(Function(x) x.OT = xOT.Text.ToDecimal)
                        wOT.Tecnico = xTecnico.Text
                        wOT.FechaAsignacion = Now
                        wOT.Estado = "C"
                        wOT.FechaInicio = Now
                        wMensaje = "Servicio iniciado correctamente"
                        DC.SubmitChanges()
                    Else
                        MsgError("Debe Asignar un Técnico a la OT")
                        xTecnico.Focus()
                        Exit Sub
                    End If
                ElseIf bIniciar.Text = "Finalizar Servicio" Then

                    If Not ModificarOT() Then
                        MsgError("No se ha podido guardar la OT")
                        Exit Sub
                    End If


                    If FinalizarOT() Then
                        wOT = DC.T_OT.FirstOrDefault(Function(x) x.OT = xOT.Text.ToDecimal)
                        wOT.FechaFinalizacion = Now
                        wOT.Estado = "F"
                        RebajarStock()
                        wMensaje = "Servicio finalizado correctamente"
                        DC.SubmitChanges()
                    Else
                        MsgError("No deben estar servicios o artículos en estado En Proceso, para finalizar la OT")
                        Exit Sub
                    End If
                End If

                InicioEstados()
                Mensaje(wMensaje)
            Else
                MsgError("OT no encontrada")
                xOT.Clear()
                xOT.Focus()
            End If
        Else
            MsgError("Indique OT")
            xOT.Focus()
        End If
    End Sub
    Sub RebajarStock()
        Dim wEstado, wArticulo As String
        For i = 1 To xTablaArticulos.Rows.Count - 1
            wEstado = xTablaArticulos.GetData(i, T_ART_ESTADO).ToString
            wArticulo = xTablaArticulos.GetData(i, T_ART_ARTICULO).ToString
            If wEstado = "Realizado" Then
                If Not SQLUpdate("UPDATE Stocks Set Stock=Stock-1 WHERE Articulo='" & wArticulo & "' and Local=" & G_LOCALACTUAL & "") Then
                    MsgError("El Stock al artículo " & wArticulo & " no pudo ser actualizado")
                End If
            End If
        Next
    End Sub
    Private Function FinalizarOT() As Boolean
        For i = 1 To xTabla.Rows.Count - 1
            Dim wArt = SQL("SELECT Estado FROM OTDET WHERE OT = '" & Trim(xOT.Text) & "'" &
                      " AND Articulo = '" & xTabla.GetData(i, T_SER_SERVICIO).ToString & "'").Top

            If wArt IsNot Nothing Then
                If wArt.GetText("Estado") <> "R" And wArt.GetText("Estado") <> "N" Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Sub cTecnicos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cTecnicos.SelectedIndexChanged
        If cTecnicos.Text <> "" Then
            xTecnico.Text = cTecnicos.SelectedValue.ToString
        End If
    End Sub

    Private Sub xOT_GotFocus(sender As Object, e As EventArgs) Handles xOT.GotFocus
        xOT.SelectionStart = 0
        xOT.SelectionLength = Len(xOT.Text)
    End Sub

    Private Sub xOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xOT.KeyPress
        ValidarDigitos(e)
        e.NextControl(bConsultarOT)
    End Sub

    Private Sub bConsultarOT_Click(sender As Object, e As EventArgs) Handles bConsultarOT.Click
        Consultar()
    End Sub

    Sub Consultar()

        Cursor = Cursors.WaitCursor

        If Trim(xOT.Text) <> "" Then
            Dim wOT = SQL("SELECT * FROM OT WHERE OT = '" & Trim(xOT.Text) & "'").Top
            If wOT IsNot Nothing Then
                xObsCliente.Text = wOT.GetText("ObsCliente")
                xObsTecnico.Text = wOT.GetText("ObsTecnico")
                xTecnico.Text = wOT.GetText("Tecnico")
                xTecnico_Validating(Nothing, Nothing)

                InicioEstados()
                CargarServicios()
                CargarArticulos()

            Else
                MsgError("OT no encontrada")
                LimpiarCampos(Me)
                xOT.Focus()
            End If
        Else
            bCancelar.Focus()
        End If

        Cursor = Cursors.Arrow
        If xServicio.Enabled Then
            xServicio.Focus()
        End If


    End Sub

    Private Sub bAgregarS_Click(sender As Object, e As EventArgs) Handles bAgregarS.Click
        If Trim(xServicio.Text) = "" Then
            MsgError("No hay un servicio cargado")
            xServicio.Focus()
            Exit Sub
        End If

        Dim wArt = SQL("Select * From Articulos WHERE Articulo = '" & Trim(xServicio.Text) & "' and TipoArticulo = 'S'").Top
        If wArt Is Nothing Then
            MsgError("El servicio ingresado no existe")
            Exit Sub
        End If

        Dim wRepetido As Boolean, wFila As Integer
        For i = 1 To xTabla.Rows.Count - 1
            If xTabla.GetData(i, T_SER_SERVICIO).ToString = xServicio.Text.Trim Then
                wRepetido = True
                wFila = i
            End If
        Next

        If Not wRepetido Then
            xTabla.AddItem("")
            xTabla.SetCellImage(xTabla.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
            wFila = xTabla.Rows.Count - 1
        End If

        xTabla.SetData(wFila, T_SER_SERVICIO, wArt.GetText("Articulo"))
        xTabla.SetData(wFila, T_SER_DESCRIPCION, wArt.GetText("Descripcion"))
        xTabla.SetData(wFila, T_SER_CANTIDAD, 1 + Val(If(Not wRepetido, 0, xTabla.GetData(wFila, T_SER_CANTIDAD))))
        xTabla.SetData(wFila, T_SER_ESTADO, "Realizado")
        xTabla.FondoCelda(wFila, C_REALIZADO)
        xTabla.Row = wFila
        xTabla.Col = 0

        xTabla.SetData(wFila, T_SER_FECHASOLICITUD, "01/01/2000")
        xTabla.SetData(wFila, T_SER_FECHAENTREGA, "01/01/3000")
        xServicio.Text = ""
        xServicio.Focus()
        xNombreServicio.Text = ""
    End Sub

    Private Sub bAgregarA_Click(sender As Object, e As EventArgs) Handles bAgregarA.Click
        If Trim(xArticulo.Text) = "" Then
            MsgError("El campo artículo no puede estar vacío")
        End If


        Dim wArt = SQL("Select * From Articulos WHERE Articulo = '" & Trim(xArticulo.Text) & "'").Top
        If wArt Is Nothing Then
            MsgError("El Artículo ingresado no existe")
            xArticulo.Focus()
            Exit Sub
        End If

        Dim wRepetido As Boolean, wFila As Integer
        For i = 1 To xTablaArticulos.Rows.Count - 1
            If xTablaArticulos.GetData(i, T_ART_ARTICULO).ToString = xArticulo.Text.Trim Then
                wRepetido = True
                wFila = i
            End If
        Next

        If Not wRepetido Then
            xTablaArticulos.AddItem("")
            xTablaArticulos.SetCellImage(xTablaArticulos.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
            wFila = xTablaArticulos.Rows.Count - 1
        End If

        xTablaArticulos.SetData(wFila, T_ART_ARTICULO, wArt.GetText("Articulo"))
        xTablaArticulos.SetData(wFila, T_ART_DESCRIPCION, wArt.GetText("Descripcion"))
        xTablaArticulos.SetData(wFila, T_ART_ESTADO, "Realizado")
        xTablaArticulos.SetData(wFila, T_ART_CANTIDAD, 1 + Val(If(Not wRepetido, 0, xTablaArticulos.GetData(wFila, T_ART_CANTIDAD))))

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wStock = DC.T_Stocks.FirstOrDefault(Function(x) x.Articulo = wArt.GetDecimal("Articulo") And x.Local = G_LOCALACTUAL And
                                                         x.Bodega = G_BODEGA)

        If wStock IsNot Nothing AndAlso wStock.Stock > 0 Then
            xTablaArticulos.FondoCelda(wFila, C_NARANJO)
            xTablaArticulos.SetData(wFila, T_ART_STOCK, "Disponible")
        Else
            xTablaArticulos.FondoCelda(wFila, C_AMARILLO)
            xTablaArticulos.SetData(wFila, T_ART_STOCK, "Sin Stock")
        End If

        xTablaArticulos.Row = wFila
        xTablaArticulos.Col = 0

        'Falta imagen a Celda
        xTablaArticulos.SetData(wFila, T_ART_FECHA, Now)
        xTablaArticulos.SetData(wFila, T_ART_FECHASOLICITUD, "01/01/2000")
        xTablaArticulos.SetData(wFila, T_ART_FECHAENTREGA, "01/01/3000")
        xArticulo.Text = ""
        xDescripcion.Text = ""
        xArticulo.Focus()
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If Trim(xOT.Text) = "" Then
            MsgError("Ingrese OT valida")
            Exit Sub
        End If

        If ModificarOT() Then
            Auditoria(Me.Name, "Modificó OT", xOT.Text, CStr(G_LOCALACTUAL))
            Mensaje("OT Actualizada Correctamente")
            'LimpiarCampos(Me)
            InicioEstados()
        End If
    End Sub
    Private Function ModificarOT() As Boolean

        Try
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wOT = DC.T_OT.FirstOrDefault(Function(x) x.OT = Val(xOT.Text))

            If wOT IsNot Nothing Then
                wOT.ObsTecnico = xObsTecnico.Text.Trim()
                wOT.ObsCliente = xObsCliente.Text.Trim()
                If wOT.Tecnico <> UsuarioActual And G_ACCESOUSUARIO = 3 Then
                    wOT.Tecnico = UsuarioActual
                End If
                Dim wOTDet = DC.T_OTDet.Where(Function(x) x.OT = Val(xOT.Text))
                If wOTDet.Any Then
                    DC.T_OTDet.DeleteAllOnSubmit(wOTDet)
                End If
                'Insert de Servicios
                If xTabla.Rows.Count - 1 > 0 Then

                    For Each wRow As Row In xTabla.Rows
                        If wRow.Index = 0 Then Continue For

                        Dim wPrecioVenta As Decimal = 0
                        Dim wArticulo = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wRow.Item(T_SER_SERVICIO).ToString.ToDecimal)
                        If wArticulo IsNot Nothing Then wPrecioVenta = wArticulo.PVenta
                        Dim wOTD = New T_OTDet With {
                            .OT = CInt(xOT.Text),
                            .Fecha = Now,
                            .Articulo = wRow.Item(T_SER_SERVICIO).ToString.ToDecimal,
                            .Cantidad = wRow.Item(T_SER_CANTIDAD).ToString.ToDecimal,
                            .Glosa = "",
                            .Estado = CChar(BuscarEstado(wRow.Item(T_SER_ESTADO).ToString, "S")),
                            .Tipo = CChar("S"),
                            .PVenta = wPrecioVenta,
                            .FechaEnt = New DateTime(2000, 1, 1),
                            .FechaSol = New DateTime(2000, 1, 1)
                        }

                        If wRow.Item(T_SER_TECNICO) Is Nothing Then
                            wOTD.Tecnico = Trim(xTecnico.Text)
                            wOTD.Fecha = Now
                        Else
                            wOTD.Tecnico = wRow.Item(T_SER_TECNICO).ToString
                            wOTD.Fecha = CDate(wRow.Item(T_SER_FECHA).ToString)
                        End If

                        If wRow.Item(T_SER_FECHASOLICITUD).ToString = "01/01/2000" Then
                            wOTD.FechaSol = Now
                        Else
                            wOTD.FechaSol = CDate(wRow.Item(T_SER_FECHASOLICITUD).ToString)
                        End If

                        If wRow.Item(T_SER_FECHAENTREGA).ToString = "01/01/3000" Then
                            If BuscarEstado(wRow.Item(T_SER_ESTADO).ToString, "S") = "R" Then
                                wOTD.FechaEnt = Now
                            End If
                        Else
                            wOTD.FechaEnt = CDate(wRow.Item(T_SER_FECHAENTREGA).ToString)
                        End If
                        DC.T_OTDet.InsertOnSubmit(wOTD)
                    Next
                End If
                DC.SubmitChanges()
                'Insert de Articulos
                For Each wRow As Row In xTablaArticulos.Rows
                    If wRow.Index = 0 Then Continue For
                    Dim wPrecioVenta As Decimal = 0
                    Dim wArticulo = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wRow.Item(T_ART_ARTICULO).ToString.ToDecimal)
                    If wArticulo IsNot Nothing Then wPrecioVenta = wArticulo.PVenta

                    Dim wOTD As New T_OTDet With {
                        .OT = CInt(xOT.Text),
                        .Fecha = Now,
                        .Articulo = wRow.Item(T_ART_ARTICULO).ToString.ToDecimal,
                        .Cantidad = CInt(wRow.Item(T_ART_CANTIDAD).ToString),
                        .Glosa = "",
                        .Estado = CChar("R"),
                        .Tipo = CChar("A"),
                        .PVenta = wPrecioVenta,
                        .FechaEnt = New DateTime(2000, 1, 1),
                        .FechaSol = New DateTime(2000, 1, 1)
                    }
                    If wRow.Item(T_ART_TECNICO) Is Nothing Then
                        wOTD.Tecnico = Trim(xTecnico.Text)
                        wOTD.Fecha = Now
                    Else
                        wOTD.Tecnico = wRow.Item(T_ART_TECNICO).ToString
                        wOTD.Fecha = CDate(wRow.Item(T_ART_FECHA))
                    End If

                    If wRow.Item(T_ART_FECHASOLICITUD).ToString = "01/01/2000" Then
                        wOTD.FechaSol = Now
                    Else
                        wOTD.FechaSol = CDate(wRow.Item(T_ART_FECHASOLICITUD))
                    End If

                    If wRow.Item(T_ART_FECHAENTREGA).ToString = "01/01/3000" Then
                        If BuscarEstado(wRow.Item(T_ART_ESTADO).ToString, "S") = "R" Then
                            wOTD.FechaEnt = Now
                        Else
                            wOTD.FechaEnt = CDate(wRow.Item(T_ART_FECHAENTREGA).ToString)
                        End If
                    Else
                        wOTD.FechaEnt = CDate(wRow.Item(T_ART_FECHAENTREGA).ToString)
                    End If
                    DC.T_OTDet.InsertOnSubmit(wOTD)
                Next
            End If
            DC.SubmitChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Sub Verificar()
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wOTDet = DC.T_OTDet.Where(Function(x) x.OT = Val(xOT.Text) And x.Tipo = CChar("S"))

        For Each wO In wOTDet
            For Each wRow As Row In xTabla.Rows
                If wRow.Index = 0 Then Continue For
                If wO.Articulo = wRow.Item(T_SER_SERVICIO).ToString.ToDecimal Then
                    DC.T_OTDet.DeleteOnSubmit(wO)
                    Exit For
                End If
            Next
        Next

        wOTDet = DC.T_OTDet.Where(Function(x) x.OT = Val(xOT.Text) And x.Tipo = CChar("A"))
        For Each wO In wOTDet
            For Each wRow As Row In xTablaArticulos.Rows
                If wRow.Index = 0 Then Continue For
                If wO.Articulo = wRow.Item(T_ART_ARTICULO).ToString.ToDecimal Then
                    DC.T_OTDet.DeleteOnSubmit(wO)
                    Exit For
                End If
            Next
        Next
        DC.SubmitChanges()
    End Sub

    Private Function BuscarEstado(ByVal wString As String, ByVal wTipo As String) As String
        If wString <> "" Then
            Dim wEst = SQL("SELECT Estado FROM Estados WHERE DescEstado = '" & wString & "' AND Tipo = '" & wTipo & "'").Top
            If wEst IsNot Nothing Then
                Return wEst.GetText("Estado")
            End If
        End If
        Return ""
    End Function

    Sub Titulos()
        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 9
        xTabla.Rows.Fixed = 1
        xTabla.Cols.Fixed = 0

        xTabla.Cols(T_ELIMINAR).Width = 50
        xTabla.Cols(T_SER_SERVICIO).Width = 86
        xTabla.Cols(T_SER_DESCRIPCION).Width = 523
        xTabla.Cols(T_SER_CANTIDAD).Width = 56
        xTabla.Cols(T_SER_ESTADO).Width = 74
        xTabla.Cols(T_SER_TECNICO).Width = 220
        xTabla.Cols(T_SER_FECHAENTREGA).Width = 0
        xTabla.Cols(T_SER_FECHASOLICITUD).Width = 0
        xTabla.Cols(T_SER_FECHA).Width = 0

        xTabla.Cols(T_ELIMINAR).Caption = "Eliminar"
        xTabla.Cols(T_SER_SERVICIO).Caption = "Servicio"
        xTabla.Cols(T_SER_DESCRIPCION).Caption = "Descripción"
        xTabla.Cols(T_SER_CANTIDAD).Caption = "Cantidad"
        xTabla.Cols(T_SER_ESTADO).Caption = "Estado"
        xTabla.Cols(T_SER_TECNICO).Caption = "Técnico"
        xTabla.Cols(T_SER_FECHAENTREGA).Caption = "FechaEnt"
        xTabla.Cols(T_SER_FECHASOLICITUD).Caption = "FechaSol"
        xTabla.Cols(T_SER_FECHA).Caption = "Fecha"

        xTabla.Cols(T_ELIMINAR).ImageAlign = ImageAlignEnum.CenterBottom
        xTabla.LoadItemsMaps(T_SER_TECNICO, "Usuarios", "Usuario", "NombreUsr", "Acceso = 3")

        xTablaArticulos.Clear()
        xTablaArticulos.Rows.Count = 1
        xTablaArticulos.Cols.Count = 10
        xTablaArticulos.Cols.Fixed = 0
        xTablaArticulos.Rows.Fixed = 1

        xTablaArticulos.Cols(T_ELIMINAR).Width = 50
        xTablaArticulos.Cols(T_ART_ARTICULO).Width = 86
        xTablaArticulos.Cols(T_ART_DESCRIPCION).Width = 515
        xTablaArticulos.Cols(T_ART_CANTIDAD).Width = 61
        xTablaArticulos.Cols(T_ART_ESTADO).Width = 0
        xTablaArticulos.Cols(T_ART_STOCK).Width = 77
        xTablaArticulos.Cols(T_ART_FECHA).Width = 0
        xTablaArticulos.Cols(T_ART_TECNICO).Width = 220
        xTablaArticulos.Cols(T_ART_FECHASOLICITUD).Width = 0
        xTablaArticulos.Cols(T_ART_FECHAENTREGA).Width = 0

        xTablaArticulos.Cols(T_ELIMINAR).Caption = "Eliminar"
        xTablaArticulos.Cols(T_ART_ARTICULO).Caption = "Artículo"
        xTablaArticulos.Cols(T_ART_DESCRIPCION).Caption = "Descripción"
        xTablaArticulos.Cols(T_ART_CANTIDAD).Caption = "Cantidad"
        xTablaArticulos.Cols(T_ART_ESTADO).Caption = "Estado"
        xTablaArticulos.Cols(T_ART_STOCK).Caption = "Stock"
        xTablaArticulos.Cols(T_ART_FECHA).Caption = "Fecha"
        xTablaArticulos.Cols(T_ART_TECNICO).Caption = "Técnico"
        xTablaArticulos.Cols(T_ART_FECHASOLICITUD).Caption = "FechaSol"
        xTablaArticulos.Cols(T_ART_FECHAENTREGA).Caption = "FechaEnt"

        xTablaArticulos.Cols(T_ELIMINAR).ImageAlign = ImageAlignEnum.CenterBottom
        xTablaArticulos.LoadItemsMaps(T_ART_TECNICO, "Usuarios", "Usuario", "NombreUsr", "Acceso = 3")
        xTablaArticulos.LoadItemsMaps(T_SER_TECNICO, "Usuarios", "Usuario", "NombreUsr", "Acceso = 3")

    End Sub
    Sub CargarServicios()

        Titulos()
        Dim wSers = SQL("SELECT RO.OT,RO.Articulo,A.Descripcion,RO.Estado,RO.Fecha,RO.Tecnico,RO.FechaSol,RO.FechaEnt,RO.Cantidad  FROM OTDet RO JOIN " &
               "Articulos A ON Ro.Articulo = A.Articulo WHERE OT = '" & Trim(xOT.Text) & "' AND A.TipoArticulo = 'S'")
        For Each wSer As DataRow In wSers.Rows
            xTabla.AddItem("")
            xTabla.SetCellImage(xTabla.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
            xTabla.SetData(xTabla.Rows.Count - 1, T_SER_SERVICIO, wSer.GetText("Articulo"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_SER_DESCRIPCION, wSer.GetText("Descripcion"))

            Dim wEst = SQL("Select DescEstado From Estados WHERE Estado = '" & wSer.GetText("Estado") & "' AND Tipo = 'S'").Top
            If wEst IsNot Nothing Then
                xTabla.SetData(xTabla.Rows.Count - 1, T_SER_ESTADO, wEst.GetText("DescEstado"))
            End If
            If wSer.GetText("Estado") = "E" Then
                xTabla.FondoCelda(xTabla.Rows.Count - 1, C_ENESPERA)
            ElseIf wSer.GetText("Estado") = "R" Then
                xTabla.FondoCelda(xTabla.Rows.Count - 1, C_REALIZADO)
            ElseIf wSer.GetText("Estado") = "N" Then
                xTabla.FondoCelda(xTabla.Rows.Count - 1, C_NOAPLICA)
            End If

            xTabla.SetData(xTabla.Rows.Count - 1, T_SER_CANTIDAD, wSer.GetText("Cantidad"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_SER_FECHA, wSer.GetText("Fecha"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_SER_TECNICO, wSer.GetText("Tecnico"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_SER_FECHASOLICITUD, wSer.GetText("FechaSol"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_SER_FECHAENTREGA, wSer.GetText("FechaEnt"))
        Next

        'Imagen a primera columna 
    End Sub
    Sub CargarArticulos()

        Dim wArts = SQL("SELECT RO.OT,RO.Articulo,A.Descripcion,RO.Estado,RO.Tecnico,RO.Fecha,RO.FechaSol,RO.FechaEnt,RO.Cantidad FROM OTDet RO JOIN " &
               "Articulos A ON Ro.Articulo = A.Articulo WHERE OT = '" & Trim(xOT.Text) & "' AND A.TipoArticulo = 'P'")

        For Each wArt As DataRow In wArts.Rows

            xTablaArticulos.AddItem("")
            xTablaArticulos.SetCellImage(xTablaArticulos.Rows.Count - 1, T_ELIMINAR, My.Resources.remove_table)
            xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_ART_ARTICULO, wArt.GetText("Articulo"))
            xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_ART_DESCRIPCION, wArt.GetText("Descripcion"))

            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wStock = DC.T_Stocks.FirstOrDefault(Function(x) x.Articulo = wArt.GetDecimal("Articulo") And x.Local = G_LOCALACTUAL And
                                                         x.Bodega = G_BODEGA)

            If wStock IsNot Nothing AndAlso wStock.Stock > 0 Then
                xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_ART_STOCK, "Disponible")
            Else
                xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_ART_STOCK, "Sin Stock")
            End If


            Dim wEst = SQL("Select DescEstado From Estados WHERE Estado =  '" & wArt.GetText("Estado") & "' AND Tipo  =  'S'").Top
            If wEst IsNot Nothing Then
                xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_ART_ESTADO, wEst.GetText("DescEstado"))
            End If

            If wArt.GetText("Estado") = "E" Then
                If wStock IsNot Nothing AndAlso wStock.Stock > 0 Then
                    xTablaArticulos.FondoCelda(xTablaArticulos.Rows.Count - 1, C_ENESPERA)
                Else
                    xTablaArticulos.FondoCelda(xTablaArticulos.Rows.Count - 1, C_ENESPERA_SINSTOCK)
                End If

            ElseIf wArt.GetText("Estado") = "R" Then
                xTablaArticulos.FondoCelda(xTablaArticulos.Rows.Count - 1, C_REALIZADO)
                'xTablaArticulos.FondoCelda(xTablaArticulos.Rows.Count - 1, C_REALIZADO_TXT)

            ElseIf wArt.GetText("Estado") = "N" Then
                xTablaArticulos.FondoCelda(xTablaArticulos.Rows.Count - 1, C_NOAPLICA)
                'xTablaArticulos.FondoCelda(xTablaArticulos.Rows.Count - 1, C_NOAPLICA_TXT)

            End If

            xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_ART_CANTIDAD, wArt.GetText("Cantidad"))
            xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_ART_FECHA, wArt.GetText("Fecha"))
            xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_ART_TECNICO, wArt.GetText("Tecnico"))
            xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_ART_FECHASOLICITUD, wArt.GetText("FechaSol"))
            xTablaArticulos.SetData(xTablaArticulos.Rows.Count - 1, T_ART_FECHAENTREGA, wArt.GetText("FechaEnt"))
        Next
        'Agregar Imagen a grilla
    End Sub

    Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs) Handles xTabla.DoubleClick
        If xTabla.Rows.Count = 1 Then Exit Sub

        If xTabla.Col = T_ELIMINAR Then
            xTabla.RemoveItem(xTabla.RowSel)
        End If

        If xTabla.Col = T_SER_ESTADO Then
            If Trim(xTabla.GetData(xTabla.RowSel, T_SER_ESTADO).ToString) = "En Espera" Then
                xTabla.SetData(xTabla.RowSel, T_SER_ESTADO, "Realizado")
                xTabla.FondoCelda(xTabla.Row, C_REALIZADO)
            ElseIf Trim(xTabla.GetData(xTabla.RowSel, T_SER_ESTADO).ToString) = "Realizado" Then
                xTabla.SetData(xTabla.RowSel, T_SER_ESTADO, "No Aplica")
                xTabla.FondoCelda(xTabla.Row, C_NARANJO)
            ElseIf Trim(xTabla.GetData(xTabla.RowSel, T_SER_ESTADO).ToString) = "No Aplica" Then
                xTabla.SetData(xTabla.RowSel, T_SER_ESTADO, "En Espera")
                xTabla.FondoCelda(xTabla.Row, C_ENESPERA)
            End If
        End If
        If xTabla.Col = T_SER_CANTIDAD Then
            wValorAnterior = xTabla.GetData(xTabla.RowSel, T_SER_CANTIDAD).ToString
            xTabla.StartEditing(xTabla.Row, T_SER_CANTIDAD)
        End If
    End Sub

    Private Sub xTablaArticulos_DoubleClick(sender As Object, e As EventArgs) Handles xTablaArticulos.DoubleClick
        If xTablaArticulos.Rows.Count - 1 = 0 Then Exit Sub
        Dim wArticulo As String

        If xTablaArticulos.Col = T_ELIMINAR Then
            xTablaArticulos.RemoveItem(xTablaArticulos.RowSel)
        End If


        If xTablaArticulos.Col = T_ART_ESTADO Then
            wArticulo = xTablaArticulos.GetData(xTablaArticulos.RowSel, T_ART_ARTICULO).ToString
            If xTablaArticulos.GetData(xTablaArticulos.Row, T_ART_ESTADO).ToString = "En Espera" Then

                If xTablaArticulos.GetData(xTablaArticulos.Row, T_ART_ESTADO).ToString = "Sin Stock" Then Exit Sub
                If Not CalcularStock(wArticulo) Then
                    If Not Pregunta("El artículo no tiene Stock. ¿Desea cambiar el estado?") Then Exit Sub
                End If
                xTablaArticulos.SetData(xTablaArticulos.Row, T_ART_ESTADO, "Realizado")
                xTablaArticulos.FondoCelda(xTablaArticulos.Row, C_VERDE_RESERVADO)
                xTablaArticulos.SetData(xTablaArticulos.Row, T_ART_STOCK, "Disponible")

            ElseIf xTablaArticulos.GetData(xTablaArticulos.Row, T_ART_ESTADO).ToString = "Realizado" Then

                xTablaArticulos.SetData(xTablaArticulos.Row, T_ART_ESTADO, "No Aplica")
                xTablaArticulos.FondoCelda(xTablaArticulos.Row, C_GRISOSCURO)

            ElseIf xTablaArticulos.GetData(xTablaArticulos.Row, T_ART_ESTADO).ToString = "No Aplica" Then

                xTablaArticulos.SetData(xTablaArticulos.Row, T_ART_ESTADO, "En Espera")
                xTablaArticulos.FondoCelda(xTablaArticulos.Row, C_AMARILLO_CELDA)
            End If

        ElseIf xTablaArticulos.Col = T_ART_STOCK Then


            If xTablaArticulos.GetData(xTablaArticulos.Row, T_ART_ESTADO).ToString = "En Espera" Then

                If xTablaArticulos.GetData(xTablaArticulos.Row, T_ART_STOCK).ToString = "Sin Stock" Then
                    xTablaArticulos.FondoCelda(xTablaArticulos.Row, C_REALIZADO)
                    xTablaArticulos.SetData(xTablaArticulos.Row, T_ART_STOCK, "Disponible")
                Else
                    xTablaArticulos.FondoCelda(xTablaArticulos.Row, C_VERDE_CLARO)
                    xTablaArticulos.SetData(xTablaArticulos.Row, T_ART_STOCK, "Sin Stock")
                End If
            End If

        End If

        If xTablaArticulos.ColSel = T_ART_CANTIDAD Then
            wValorAnterior = xTablaArticulos.GetData(xTablaArticulos.RowSel, T_ART_CANTIDAD).ToString
            xTablaArticulos.StartEditing(xTablaArticulos.Row, T_ART_CANTIDAD)
        End If
    End Sub

    Function CalcularStock(ByVal wArticulo As String) As Boolean
        Dim wStock As Double
        For Each wRow As Row In xTablaArticulos.Rows
            If wRow.Index = 0 Then Continue For
            If wArticulo = wRow.Item(T_ART_ARTICULO).ToString Then
                wStockTabla = wStockTabla + 1
            End If
        Next

        Dim wStocks = SQL("SELECT (Case  WHEN Stock<=0 THEN 0 ELSE Stock END) as Stock " &
                  " FROM Stocks WHERE Local=" & G_LOCALACTUAL & " AND Articulo='" & wArticulo & "'").Top
        If wStocks Is Nothing Then
            wStock = 0
        Else
            wStock = Val(wStocks.GetText("Stock"))
        End If
        wStock = wStock - wStockTabla
        If wStock <= 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub xTecnico_Validating(sender As Object, e As CancelEventArgs) Handles xTecnico.Validating
        If xTecnico.Text.Trim <> "" Then
            cTecnicos.SelectedValue = xTecnico.Text.Trim
            If cTecnicos.Text = "" Then
                MsgError("Técnico no encontrado")
                xTecnico.Clear()
                xTecnico.Focus()
            End If
        End If
    End Sub

    Private Sub xTabla_AfterEdit(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles xTabla.AfterEdit
        Dim wValor As String
        If xTabla.Col = T_SER_CANTIDAD Then
            wValor = xTabla.GetData(xTabla.Row, xTabla.Col).ToString
            If Not IsNumeric(wValor) Then
                xTabla.SetData(xTabla.Row, T_SER_CANTIDAD, wValorAnterior)
                MsgError("El valor ingresado debe ser númerico")
                Exit Sub
            End If
            If Val(wValor) <= 0 Then
                xTabla.SetData(xTabla.Row, T_SER_CANTIDAD, wValorAnterior)
                MsgError("El valor ingresado no puede ser igual o menor a 0")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub xTablaArticulos_AfterEdit(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles xTablaArticulos.AfterEdit
        If xTablaArticulos.Col <> T_ART_CANTIDAD Then Exit Sub

        Dim wValor As String
        wValor = xTablaArticulos.GetData(xTablaArticulos.Row, xTablaArticulos.Col).ToString
        If Not IsNumeric(wValor) Then
            xTablaArticulos.SetData(xTablaArticulos.Row, T_ART_CANTIDAD, wValorAnterior)
            MsgError("El valor ingresado debe ser númerico")
            Exit Sub
        End If
        If Val(wValor) <= 0 Then
            xTablaArticulos.SetData(xTablaArticulos.Row, T_ART_CANTIDAD, wValorAnterior)
            MsgError("El valor ingresado no puede ser igual o menor a 0")
            Exit Sub
        End If
    End Sub

    Private Sub xServicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xServicio.KeyPress
        e.NextControl(bAgregarS)
    End Sub

    Private Sub xServicio_Validating(sender As Object, e As CancelEventArgs) Handles xServicio.Validating
        If xServicio.ListaVisible Then
            If xServicio.ListaActiva Then
                Exit Sub
            Else
                xServicio.OcultarLista()
            End If
        End If

        If Trim(xServicio.Text) = "" Then
            xNombreServicio.Clear()
            Exit Sub
        End If
        If xServicio.DescEncontrada = "" Then
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wSer = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xServicio.Text.ToDecimal)
            If wSer IsNot Nothing Then
                xNombreServicio.Text = wSer.Descripcion
            End If
        Else
            xNombreServicio.Text = xServicio.DescEncontrada
        End If
    End Sub

    Private Sub xServicio_ItemSeleccionado(wDescripcion As String) Handles xServicio.ItemSeleccionado
        xNombreServicio.Text = wDescripcion
        bAgregarS.Focus()
    End Sub
    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(bAgregarA)
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
            xDescripcion.Clear()
            Exit Sub
        End If

        If xArticulo.DescEncontrada = "" Then
            Dim wIDArticulo = ObtenerArticulo(xArticulo.Text)
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wIDArticulo.ToDecimal())
            If wArt IsNot Nothing Then
                xArticulo.AutoCompletarActivo = False
                xArticulo.Text = wArt.Articulo.ToString()
                xDescripcion.Text = wArt.Descripcion
                xArticulo.AutoCompletarActivo = True
                Exit Sub
            End If

            'Dim wSer = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.ToDecimal)
            'If wSer IsNot Nothing Then
            '    xDescripcion.Text = wSer.Descripcion
            '    Exit Sub
            'End If
            Informacion("Artículo no encontrado")
            xDescripcion.Clear()
            xArticulo.Clear()
            xArticulo.Focus()
        Else
            xArticulo.AutoCompletarActivo = False
            'xArticulo.Text = xArticulo.IdEncontrado
            xDescripcion.Text = xArticulo.DescEncontrada
            xArticulo.AutoCompletarActivo = True
        End If
    End Sub
    Private Sub xArticulo_ItemSeleccionado(wDescripcion As String) Handles xArticulo.ItemSeleccionado
        xDescripcion.Text = wDescripcion
        bAgregarA.Focus()
    End Sub

    Private Sub bAgregarPlantilla_Click(sender As Object, e As EventArgs) Handles bAgregarPlantilla.Click
        If tObservacion.SelectedIndex = 0 Then
            xObsCliente.Text = xObsCliente.Text & If(xObsCliente.Text = "", "", vbCrLf) & cPlantilla.SelectedValue.ToString.Replace(";", vbCr)
        Else
            xObsTecnico.Text = xObsTecnico.Text & If(xObsTecnico.Text = "", "", vbCrLf) & cPlantilla.SelectedValue.ToString.Replace(";", vbCr)
        End If
    End Sub

    Private Sub xTabla_Click(sender As Object, e As EventArgs) Handles xTabla.Click
        If xTabla.Col = T_SER_TECNICO And xTabla.GetData(xTabla.Row, T_SER_ESTADO).ToString = "En Espera" Then
            xTabla.StartEditing(xTabla.Row, T_SER_TECNICO)
        End If
    End Sub

    Private Sub xTabla_SetupEditor(sender As Object, e As RowColEventArgs) Handles xTabla.SetupEditor
        'Dim cd As ComboBox = DirectCast(xTabla.Editor, ComboBox)
        'cd.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub xTablaArticulos_Click(sender As Object, e As EventArgs) Handles xTablaArticulos.Click
        If xTablaArticulos.Col = T_ART_TECNICO Then
            xTablaArticulos.StartEditing(xTablaArticulos.Row, T_ART_TECNICO)
        End If
    End Sub

    Private Sub xTablaArticulos_SetupEditor(sender As Object, e As RowColEventArgs) Handles xTablaArticulos.SetupEditor
        'Dim cd As ComboBox = DirectCast(xTablaArticulos.Editor, ComboBox)
        'cd.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        Titulos()
        gServicios.Enabled = False
        gArticulos.Enabled = False
        bIniciar.Enabled = True
        bGuardar.Enabled = False
        xObsTecnico.Enabled = False
        xObsCliente.Enabled = False
        gTecnico.Enabled = True
        tObservacion.SelectTab(ObsCli)
        bIniciar.Text = "Iniciar Servicio"
        bIniciar.Visible = True
    End Sub

    Private Sub bBuscarServicio_Click(sender As Object, e As EventArgs) Handles bBuscarServicio.Click
        Dim wBuscador = New BuscadorArticulo
        wBuscador.Configurar(Me, xServicio)
        wBuscador.ShowDialog()
    End Sub

    Private Sub bBuscarArticulo_Click(sender As Object, e As EventArgs) Handles bBuscarArticulo.Click
        Dim wBuscador = New BuscadorArticulo
        wBuscador.Configurar(Me, xArticulo)
        wBuscador.ShowDialog()
    End Sub
    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub
End Class