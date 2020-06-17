Imports C1.Win.C1FlexGrid

Public Class ControlDTEEmitidos
    Const T_OK = 0
    Const T_ESTADO = 1
    Const T_TIPODOC = 2
    Const T_DOC = 3
    Const T_NUM = 4
    Const T_FECHA = 5
    Const T_USUARIO = 6
    Const T_LOCAL = 7
    Const T_NOMBRELOCAL = 8
    Const T_CLIENTE = 9
    Const T_RUT = 10
    Const T_NOMBRE = 11
    Const T_FPAGO = 12
    Const T_MONTO = 13
    Const T_OBS = 14

    Const EI = "Emitido Incorrecto"
    Const ET = "Emitido con TED"
    Const AP = "Aprobado por SII"
    Const AR = "Aprobado con Reparos por SII"
    Const RE = "Rechazado por SII"
    Const RP = "Respuesta Pendiente"
    Const PT = "Pendiente de Timbraje"
    Const ST = "Documento sin Firma"

    Const NE = "No es Electrónico"
    Const ND = "No Definido"

    Dim wFila As Integer
    Dim wLocal As Integer

    Private Sub xTabla_MouseDown(sender As Object, e As MouseEventArgs) Handles xTabla.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim xTabla = DirectCast(sender, C1.Win.C1FlexGrid.C1FlexGrid)
            Dim wHit As C1.Win.C1FlexGrid.HitTestInfo = xTabla.HitTest(e.Location)
            xTabla.Row = wHit.Row
            xTabla.Col = wHit.Column
            mMenuTabla.Show(xTabla, wHit.Point)
        End If
    End Sub

    Private Sub ControlDTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal", "WHERE FElectronica = 1 Order by Local")
        If cLocal.Items.Count = 2 Then
            cLocal.SelectedIndex = 1
        End If

        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", "WHERE Cod_SII > 0 Order by DescTipoDoc")

        Titulos()

        cEstados.Items.Add("")
        cEstados.Items.Add(EI)
        cEstados.Items.Add(ET)
        cEstados.Items.Add(AP)
        cEstados.Items.Add(AR)
        cEstados.Items.Add(RE)
        cEstados.Items.Add(RP)
        cEstados.Items.Add(PT)

        oRapido.Checked = True

        xF1.Value = IniFinFecha(1, Now.Date)
        xF2.Value = IniFinFecha(2, Now.Date)
        Auditoria(Text, A_INGRESADO, "", "")
    End Sub

    Private Sub bDesmarcar_Click()
        For i = 1 To xTabla.Rows.Count - 1
            xTabla.SetData(i, T_OK, UNCHECK)
        Next i
    End Sub

    Private Sub bEnviarM_Click()
        Dim Hay As Boolean

        Hay = False
        Cursor = Cursors.WaitCursor
        For i = 1 To xTabla.Rows.Count - 1
            If xTabla.GetData(i, T_ESTADO).ToString = NE Then
                'El_Error ("No se puede enviar a DTE Documentos No electrónicos")
            Else
                If xTabla.GetData(i, T_ESTADO).ToString = AP Or xTabla.GetData(i, T_ESTADO).ToString = AR Then
                    'El_Error ("Documento Electrónico ya enviado a SII, no se puede volver a enviar")
                Else
                    If CBool(xTabla.GetData(i, T_OK)) = CHECK Then
                        Hay = True
                        Dim wTipoDoc = SQL("SELECT TipoDoc FROM TipoDoc WHERE DescTipoDoc = '" & xTabla.GetData(i, T_DOC).ToString).Top

                        If DTE.Emitir_DTE(Val(xTabla.GetData(i, T_LOCAL)), wTipoDoc.GetText("TipoDoc"), Val(xTabla.GetData(i, T_NUM).ToString)) Then
                            'Me.MousePointer = vbDefault
                            'El_Mensaje (Tabla.TextMatrix(Tabla.Row, T_DOC) + " " + Str(Tabla.TextMatrix(Tabla.Row, T_NUM)) + " Enviada Correctamente.")
                        Else
                            'Me.MousePointer = vbDefault
                            'El_Error ("Error al Enviar Documento Electrónico")
                        End If
                    End If
                End If
            End If
        Next i
        Cursor = Cursors.Arrow
        If Not Hay Then
            MsgError("No hay documentos marcados para enviar")
        Else
            Mensaje("Los Datos enviados a SII, demoran en algunos casos tener respuestas, " + vbCrLf + "deberá consultar los documentos en unos minutos mas para conocer su estado.")
            'Volver a Cargar los Datos
            Consultar_Datos()
        End If

    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        Titulos()
        cLocal.Text = ""
        cTipoDoc.Text = ""
        cEstados.Text = ""
        xCantDoc.Text = ""

        xF1.Value = IniFinFecha(1, Now.Date)
        xF2.Value = IniFinFecha(2, Now.Date)

        oRapido.Checked = True

        cLocal.Focus()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Sub Titulos()
        xTabla.Redraw = True

        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 15

        xTabla.SetData(0, T_OK, "Ok")
        xTabla.SetData(0, T_ESTADO, "Estado")
        xTabla.SetData(0, T_TIPODOC, "Tipo.Doc.")
        xTabla.SetData(0, T_DOC, "Documento")
        xTabla.SetData(0, T_NUM, "Número")
        xTabla.SetData(0, T_FECHA, "Fecha")
        xTabla.SetData(0, T_USUARIO, "Usuario")
        xTabla.SetData(0, T_LOCAL, "Local")
        xTabla.SetData(0, T_NOMBRELOCAL, "Local")
        xTabla.SetData(0, T_CLIENTE, "Cliente")
        xTabla.SetData(0, T_RUT, "Rut")
        xTabla.SetData(0, T_NOMBRE, "Nombre")
        xTabla.SetData(0, T_FPAGO, "F.Pago")
        xTabla.SetData(0, T_MONTO, "Monto")
        xTabla.SetData(0, T_OBS, "Observaciones")

        xTabla.Cols(T_OK).Width = 30
        xTabla.Cols(T_ESTADO).Width = 120
        xTabla.Cols(T_TIPODOC).Width = 0
        xTabla.Cols(T_DOC).Width = 115
        xTabla.Cols(T_NUM).Width = 65
        xTabla.Cols(T_FECHA).Width = 75
        xTabla.Cols(T_USUARIO).Width = 50
        xTabla.Cols(T_LOCAL).Width = 0
        xTabla.Cols(T_NOMBRELOCAL).Width = 80
        xTabla.Cols(T_CLIENTE).Width = 60
        xTabla.Cols(T_RUT).Width = 80
        xTabla.Cols(T_NOMBRE).Width = 280
        xTabla.Cols(T_FPAGO).Width = 80
        xTabla.Cols(T_MONTO).Width = 80
        xTabla.Cols(T_OBS).Width = 1000

        xTabla.Cols(T_OK).TextAlignFixed = TextAlignEnum.CenterCenter
        xTabla.Cols(T_FECHA).TextAlignFixed = TextAlignEnum.CenterCenter
        xTabla.Cols(T_MONTO).TextAlignFixed = TextAlignEnum.RightCenter
        xTabla.Cols(T_NUM).TextAlignFixed = TextAlignEnum.RightCenter
        xTabla.Cols(T_CLIENTE).TextAlignFixed = TextAlignEnum.RightCenter
        xTabla.Cols(T_USUARIO).TextAlignFixed = TextAlignEnum.CenterCenter
        xTabla.Cols(T_OBS).TextAlignFixed = TextAlignEnum.LeftCenter

        xTabla.Cols(T_OK).TextAlign = TextAlignEnum.CenterCenter
        xTabla.Cols(T_FECHA).TextAlign = TextAlignEnum.CenterCenter
        xTabla.Cols(T_NUM).TextAlign = TextAlignEnum.RightCenter
        xTabla.Cols(T_CLIENTE).TextAlign = TextAlignEnum.RightCenter
        xTabla.Cols(T_USUARIO).TextAlign = TextAlignEnum.CenterCenter
        xTabla.Cols(T_MONTO).TextAlign = TextAlignEnum.RightCenter
        xTabla.Cols(T_OBS).TextAlign = TextAlignEnum.LeftCenter

        xTabla.Cols(T_OK).DataType = GetType(Boolean)
        xTabla.Cols(T_MONTO).DataType = GetType(Double)
        xTabla.Cols(T_MONTO).Format = "N0"
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        xCantDoc.Text = ""
        Consultar_Datos()
        tProgresoBarra.Value = tProgresoBarra.Maximum
        xCantDoc.Text = (xTabla.Rows.Count - 1).ToString
    End Sub

    Sub Consultar_Datos()
        Dim DocDTE As String
        lStatus.Text = "Cargado Documentos..."
        wFila = 0
        wLocal = 999
        Titulos()

        If Trim(cLocal.Text) <> "" Then
            wLocal = CInt(cLocal.SelectedValue)
        End If

        Cursor = Cursors.WaitCursor
        xTabla.Visible = False

        DocDTE = cTipoDoc.SelectedValue.ToString

        If DocDTE = "FV" Or DocDTE = "0" Then
            Cargar_Datos("FV")
        End If
        If DocDTE = "NC" Or DocDTE = "0" Then
            Cargar_Datos("NC")
        End If
        If DocDTE = "ND" Or DocDTE = "0" Then
            Cargar_Datos("ND")
        End If
        If DocDTE = "GD" Or DocDTE = "0" Then
            Cargar_Datos("GD")
        End If
        If DocDTE = "BV" Or DocDTE = "0" Then
            Cargar_Datos("BV")
        End If
        If DocDTE = "FE" Or DocDTE = "0" Then
            Cargar_Datos("FE")
        End If
        If DocDTE = "FC" Or DocDTE = "0" Then
            Cargar_Datos("FC")
        End If

        If xTabla.Rows.Count > 1 Then
            xTabla.Col = 1 : xTabla.Row = 1
        End If

        lStatus.Text = "Listo  "
        Auditoria(Text, "Consultar", "", "")
        Cursor = Cursors.Arrow
        xTabla.Visible = True

    End Sub

    Sub Cargar_Datos(wTipo As String)
        Dim Filtro As String, wDocumento As String, wEstado As String, wLocal As Integer, wRut As String
        Dim Opcion_Crear As Boolean, wObs As String

        wLocal = 999
        If Trim(cLocal.Text) <> "" Then
            wLocal = CInt(cLocal.SelectedValue)
        End If

        If wLocal = 999 Then
            Filtro = "(1=1)"
        Else
            Filtro = "DG.Local = " & Val(wLocal)
        End If

        If wTipo <> "" Then
            Filtro = Filtro + " and DG.TipoDoc = '" + wTipo + "'"
        End If


        Dim wDocG = SQL("Select DG.Local,DG.TipoDoc,DG.Numero,DG.Fecha,DG.Usuario,DG.Cliente,Cl.Rut,Cl.Nombre,DG.FPago,DG.Total,DG.DTE, " &
                        " DG.Status_DTE,DG.TED,TD.DescTipoDoc FROM DocumentosG DG " &
                        " JOIN TipoDoc TD ON DG.TipoDoc = TD.TipoDoc" &
                        " JOIN Clientes Cl ON DG.Cliente = Cl.Cliente" &
                        " where " & Filtro & " And DG.Fecha >= '" & Format(xF1.Value, "dd/MM/yyyy 00:00:00") & "'" &
                        " And DG.Fecha <= '" & Format(xF2.Value, "dd/MM/yyyy 23:59:59") & "'  Order by DG.Numero,DG.Fecha")

        If wDocG.Rows.Count > 0 Then
            tProgresoBarra.Minimum = 0
            tProgresoBarra.Maximum = wDocG.Rows.Count
            tProgresoBarra.Value = 1
            tProgresoBarra.Visible = True
            For Each wD As DataRow In wDocG.Rows
                Application.DoEvents()
                wDocumento = wD.GetText("DescTipoDoc")

                xCantDoc.Text = (Val(xCantDoc.Text) + 1).ToString
                xTabla.AddItem("")
                xTabla.SetData(xTabla.Rows.Count - 1, T_OK, UNCHECK)

                If CBool(wD.GetText("DTE")) Then
                    If CInt(wD.GetText("Status_DTE")) = EstadosSII.No_Enviado Or IsDBNull(wD.GetText("Status_DTE")) Then
                        xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, EI)
                        xTabla.FuenteCelda(xTabla.Rows.Count - 1, Color.Magenta, Color.Black)
                        xTabla.FondoCelda(xTabla.Rows.Count - 1, Color.Magenta)
                    End If
                    If CInt(wD.GetText("Status_DTE")) = EstadosSII.Aprobado Then
                        xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, AP)
                        xTabla.FuenteCelda(xTabla.Rows.Count - 1, Color.LightGreen, Color.Black)
                        xTabla.FondoCelda(xTabla.Rows.Count - 1, Color.LightGreen)
                    End If
                    If CInt(wD.GetText("Status_DTE")) = EstadosSII.Rechazado Then
                        xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, RE)
                        xTabla.FuenteCelda(xTabla.Rows.Count - 1, Color.Red, Color.Yellow)
                        xTabla.FondoCelda(xTabla.Rows.Count - 1, Color.Red)
                    End If
                    If CInt(wD.GetText("Status_DTE")) = EstadosSII.Timbrado Then
                        xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, PT)
                        xTabla.FuenteCelda(xTabla.Rows.Count - 1, Color.Bisque, Color.Black)
                        xTabla.FondoCelda(xTabla.Rows.Count - 1, Color.Bisque)
                    End If

                    'Chequear si los documentos tienen TED (Archivo físico y/o registro en el documento)
                    If oCheckTED.Checked Then
                        If Leer_JPG(Ruta_Archivo_Fiscal(gJPG, wLocal, wD.GetText("TipoDoc"), wD.GetInt("Numero"), wD.GetInt("Cliente"))) Is Nothing Then
                            Opcion_Crear = True
                        Else
                            If Leer_TED(Ruta_Archivo_Fiscal(gXML, wLocal, wD.GetText("TipoDoc"), wD.GetInt("Numero"), wD.GetInt("Cliente"))) = "" Then
                                Opcion_Crear = True
                            End If
                        End If

                        Dim wPrimeraLinea = Primera_Linea(wLocal, wD.GetText("TipoDoc"), wD.GetInt("Numero"))

                        If oWS.Checked Then
                            'WEBSERVICE                   
                            'Dim WS = New MarketONEWS.Service
                            'Dim wDT = WS.EmitirTED("1", G_CLIENTEACTUAL, wLocal, wD.GetText("TipoDoc"), wD.GetInt("Numero"))

                            'If Val(wDT.Rows(0).Item(0)) = 1 Then '1 = Operación Exitosa
                            '    Dim wXML = wDT.Rows(0).Item(2)
                            '    'TED Generado correctamente.
                            '    Dim TEDGenerado = True
                            '    If Not DTE.Generar_TED(wLocal, wD.GetText("TipoDoc"), wD.GetInt("Numero"), wD.GetDate("Fecha"), wD.GetText("Rut"), wD.GetText("Nombre"), wD.GetInt("Total"), wPrimeraLinea).Estado Then
                            '        MsgError("Error al Grabar TED en disco")
                            '    End If
                            'Else
                            '    MsgError("Error Generando TED: " & wDT.Rows(0).Item(1).ToString) 'Item1 tiene el mensaje de error.                    
                            'End If
                            'If Opcion_Crear Then
                            '    'Crear Archivos a partir de los campos e las Tablas
                            '    If Not DTE.Generar_TED(wLocal, wD.GetText("TipoDoc"), wD.GetInt("Numero"), wD.GetDate("Fecha"), wD.GetText("Rut"), wD.GetText("Nombre"), wD.GetInt("Total"), wPrimeraLinea).Estado Then
                            '        'El_Error("No se pudo crear TED")
                            '    End If
                            'End If
                        Else
                            'TIMBRADOR
                            DTE.Generar_TED(wLocal, wD.GetText("TipoDoc"), wD.GetInt("Numero"), wD.GetDate("Fecha"), wD.GetText("Rut"), wD.GetText("Nombre"), wD.GetInt("Total"), wPrimeraLinea)
                        End If
                    End If

                    'Verificar el status en SII
                    If oSII.Checked Then
                        wEstado = ""
                        wObs = ""
                        If CInt(wD.GetText("Status_DTE")) = EstadosSII.Aprobado Or CInt(wD.GetText("Status_DTE")) = EstadosSII.Rechazado Then
                            wRut = DTE.FE_Rut_Emisor
                            Dim wLc = SQL("Select RutLocal from Locales where Local = " & Val(wD.GetText("Local"))).Top
                            If wLc IsNot Nothing Then
                                wRut = DTE.Rut_DTE(wLc.GetText("RutLocal"))
                            End If
                            Try
                                Dim wEstadoObs = DTE.Consultar_DTE(1, wTipo, Val(wD.GetText("Numero")))
                                wEstado = Mid(wEstadoObs.Item1.ToString, 1, 1)
                                wObs = wEstadoObs.Item2
                            Catch ex As Exception
                                wEstado = "7"
                            End Try

                            xTabla.SetData(xTabla.Rows.Count - 1, T_OBS, wObs)

                            If wEstado = "0" Then
                                xTabla.SetData(xTabla.Rows.Count - 1, T_OBS, DTE.Consultar_DTE(3, wTipo, Val(wD.GetText("Numero"))).Item2)
                                xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, AP)
                                xTabla.FuenteCelda(xTabla.Rows.Count - 1, Color.LightGreen, Color.Black)
                                xTabla.FondoCelda(xTabla.Rows.Count - 1, Color.LightGreen)
                            End If
                            If wEstado = "1" Then
                                xTabla.SetData(xTabla.Rows.Count - 1, T_OBS, DTE.Consultar_DTE(3, wTipo, Val(wD.GetText("Numero"))).Item2)
                                xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, RP)
                                xTabla.FuenteCelda(xTabla.Rows.Count - 1, Color.Orange, Color.Black)
                                xTabla.FondoCelda(xTabla.Rows.Count - 1, Color.Orange)
                            End If
                            If wEstado = "2" Then
                                xTabla.SetData(xTabla.Rows.Count - 1, T_OBS, DTE.Consultar_DTE(3, wTipo, Val(wD.GetText("Numero"))).Item2)
                                xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, AR)
                                xTabla.FuenteCelda(xTabla.Rows.Count - 1, Color.Orange, Color.Black)
                                xTabla.FondoCelda(xTabla.Rows.Count - 1, Color.Yellow)
                            End If

                            If wEstado = "6" Then
                                xTabla.SetData(xTabla.Rows.Count - 1, T_OBS, "Consulta Rápida")
                                xTabla.FuenteCelda(xTabla.Rows.Count - 1, Color.White, Color.Black)
                                xTabla.FondoCelda(xTabla.Rows.Count - 1, Color.White)
                            End If
                            If wEstado = "7" Then
                                xTabla.SetData(xTabla.Rows.Count - 1, T_OBS, "No se pudo Consultar DTE")
                                xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, RP)
                                xTabla.FondoCelda(xTabla.Rows.Count - 1, Color.Blue)
                            End If
                            If wEstado = "9" Then
                                xTabla.SetData(xTabla.Rows.Count - 1, T_OBS, DTE.Consultar_DTE(3, wTipo, Val(wD.GetText("Numero"))).Item2)
                                xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, RE)
                                xTabla.FuenteCelda(xTabla.Rows.Count - 1, Color.Red, Color.Yellow)
                            End If
                            If wEstado = "3" Or wEstado = "4" Or wEstado = "5" Or wEstado = "8" Then
                                xTabla.SetData(xTabla.Rows.Count - 1, T_OBS, DTE.Consultar_DTE(3, wTipo, Val(wD.GetText("Numero"))).Item2)
                                xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, ND)
                                xTabla.FuenteCelda(xTabla.Rows.Count - 1, Color.Magenta, Color.Black)
                            End If
                        End If
                    Else
                        xTabla.SetData(xTabla.Rows.Count - 1, T_OBS, "Consulta Rápida")
                    End If

                    'Código No Definido 
                    If CInt(wD.GetText("Status_DTE")) > EstadosSII.Rechazado Then
                        xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, ND)
                        xTabla.FuenteCelda(xTabla.Rows.Count - 1, Color.Magenta, Color.Black)
                    End If
                Else
                    xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, "No es Electrónico")
                    xTabla.FondoCelda(xTabla.Rows.Count - 1, Color.Silver)
                End If

                xTabla.SetData(xTabla.Rows.Count - 1, T_TIPODOC, DTE.Codigo_DTE_EMISION(wTipo))
                xTabla.SetData(xTabla.Rows.Count - 1, T_DOC, wDocumento)
                xTabla.SetData(xTabla.Rows.Count - 1, T_NUM, wD.GetText("Numero"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, FormatDateTime(wD.GetDate("Fecha"), DateFormat.ShortDate))
                xTabla.SetData(xTabla.Rows.Count - 1, T_USUARIO, wD.GetText("Usuario"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, wD.GetText("Local"))
                Dim wL = SQL("SELECT NombreLocal FROM Locales WHERE Local = " & wD.GetText("Local")).Top
                xTabla.SetData(xTabla.Rows.Count - 1, T_NOMBRELOCAL, wL.GetText("NombreLocal"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_CLIENTE, wD.GetText("Cliente"))
                Dim wCli = SQL("SELECT RUT,Nombre FROM Clientes WHERE Cliente = " & wD.GetText("Cliente")).Top
                xTabla.SetData(xTabla.Rows.Count - 1, T_NOMBRE, wCli.GetText("Nombre"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_RUT, wCli.GetText("Rut"))
                Dim wFP = SQL("SELECT DescFPago FROM FPagos WHERE FPago = '" & wD.GetText("FPago") & "'").Top
                xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGO, wFP.GetText("DescFPago"))
                xTabla.SetData(xTabla.Rows.Count - 1, T_MONTO, wD.GetText("Total"))
                If tProgresoBarra.Value < tProgresoBarra.Maximum Then
                    tProgresoBarra.Value += 1
                Else
                    tProgresoBarra.Value = tProgresoBarra.Maximum
                End If
                DoEvents()
            Next
        End If
        tProgresoBarra.Visible = False
    End Sub

    Private Sub xTabla_Click(sender As Object, e As EventArgs) Handles xTabla.Click
        If xTabla.Col = T_OK Then
            If CBool(xTabla.GetData(xTabla.Row, T_OK)) = CHECK Then
                xTabla.SetData(xTabla.Row, T_OK, UNCHECK)
            Else
                xTabla.SetData(xTabla.Row, T_OK, CHECK)
            End If
        End If
    End Sub
    Private Sub bEnviar_Click(sender As Object, e As EventArgs) Handles bEnviar.Click
        Dim wCliente As Double
        Dim wLocal As Integer
        Dim wTipoDoc As String
        Dim wNumDoc As Double
        Dim wFecha As Date
        Dim wRut As String
        Dim wNombre As String
        Dim wMonto As Double
        Dim wPrimeraLinea As String
        Dim wArticuloPrimeraLinea As String
        Dim Opcion_Crear As Boolean = False

        Dim Hay As Boolean
        Hay = False

        Cursor = Cursors.WaitCursor

        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wListaTipoDoc = DC.T_TipoDoc.ToList


        For i = 1 To xTabla.Rows.Count - 1
            wTipoDoc = wListaTipoDoc.FirstOrDefault(Function(x) x.Cod_SII = xTabla.GetData(i, T_TIPODOC).ToString.ToDecimal).TipoDoc
            wArticuloPrimeraLinea = DC.T_DocumentosD.FirstOrDefault(Function(x) x.Numero = CInt(xTabla.GetData(i, T_NUM).ToString)).Articulo.ToString
            wPrimeraLinea = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wArticuloPrimeraLinea.ToDecimal).Descripcion
            wCliente = Val(xTabla.GetData(i, T_CLIENTE).ToString)
            wLocal = CInt(xTabla.GetData(i, T_LOCAL).ToString)
            wNumDoc = Val(xTabla.GetData(i, T_NUM).ToString)
            wFecha = CDate(xTabla.GetData(i, T_FECHA).ToString)
            wRut = xTabla.GetData(i, T_RUT).ToString
            wNombre = xTabla.GetData(i, T_NOMBRE).ToString
            wMonto = Val(xTabla.GetData(i, T_MONTO).ToString)

            If CBool(xTabla.GetData(i, T_OK)) Then
                If oCheckTED.Checked Then
                    If DTE.Leer_JPG(DTE.Ruta_Archivo_Fiscal(gJPG, wLocal, wTipoDoc, wNumDoc, wCliente)) Is Nothing Then
                        Opcion_Crear = True
                    Else
                        If DTE.Leer_TED(DTE.Ruta_Archivo_Fiscal(gXML, Val(xTabla.GetData(i, T_LOCAL)), wTipoDoc, Val(xTabla.GetData(i, T_NUM).ToString), Val(xTabla.GetData(i, T_CLIENTE)))) = "" Then
                            Opcion_Crear = True
                        End If
                    End If

                    If oWS.Checked Then

                        ''WEBSERVICE                   
                        'Dim WS = New MarketONEWS.Service
                        'Dim wDT = WS.EmitirTED("1", G_CLIENTEACTUAL, wLocal, wTipoDoc, wNumDoc)
                        'If Val(wDT.Rows(0).Item(0)) = 1 Then '1 = Operación Exitosa
                        '    Dim wXML = wDT.Rows(0).Item(2)
                        '    'TED Generado correctamente.
                        '    Dim TEDGenerado = True
                        '    If Not DTE.Generar_TED(wLocal, wTipoDoc, wNumDoc, wFecha, wRut, wNombre, wMonto, wPrimeraLinea).Estado Then
                        '        MsgError("Error al Grabar TED en disco")
                        '    End If
                        'Else
                        '    MsgError("Error Generando TED: " & wDT.Rows(0).Item(1).ToString) 'Item1 tiene el mensaje de error.                    
                        'End If
                        'If Opcion_Crear Then
                        '    'Crear Archivos a partir de los campos e las Tablas
                        '    If Not DTE.Generar_TED(wLocal, wTipoDoc, wNumDoc, wFecha, wRut, wNombre, wMonto, wPrimeraLinea).Estado Then
                        '        'El_Error("No se pudo crear TED")
                        '    End If
                        'End If
                    Else
                        'TIMBRADOR
                        DTE.Generar_TED(wLocal, wTipoDoc, wNumDoc, wFecha, wRut, wNombre, wMonto, wPrimeraLinea)
                    End If
                End If

                If xTabla.GetData(i, T_ESTADO).ToString = NE Then
                    'El_Error ("No se puede enviar a DTE Documentos No electrónicos")
                Else
                    If xTabla.GetData(i, T_ESTADO).ToString = AP Or xTabla.GetData(i, T_ESTADO).ToString = AR Then
                        'El_Error ("Documento Electrónico ya enviado a SII, no se puede volver a enviar")
                    Else
                        Hay = True
                        If xTabla.GetData(i, T_ESTADO).ToString = ST Then
                            'No tiene TED, debe volver a crearse
                            ''Generar_TED(Val(xTabla.GetData(i, T_LOCAL)), BuscarCampo("TipoDoc", "TipoDoc", "DescTipoDoc", xTabla.GetData(i, T_DOC)), xTabla.GetData(i, T_NUM), xTabla.GetData(i, T_FECHA), Rut_DTE(xTabla.GetData(i, T_RUT)), Formatea_Texto(xTabla.GetData(i, T_NOMBRE)), xTabla.GetData(i, T_MONTO), xTabla.GetData(i, T_LINEA))
                            DTE.Generar_TED(wLocal, wTipoDoc, wNumDoc, wFecha, wRut, wNombre, wMonto, wPrimeraLinea)
                        Else
                            'Envio al DTE                        
                            If DTE.Generar_TED(wLocal, wTipoDoc, wNumDoc, wFecha, wRut, wNombre, wMonto, wPrimeraLinea).Estado Then
                                'Me.MousePointer = vbDefault
                                'El_Mensaje (Tabla.TextMatrix(Tabla.Row, T_DOC) + " " + Str(Tabla.TextMatrix(Tabla.Row, T_NUM)) + " Enviada Correctamente.")
                            Else
                                'Me.MousePointer = vbDefault
                                'El_Error ("Error al Enviar Documento Electrónico")
                            End If
                        End If
                    End If
                End If
            End If
        Next i
        Cursor = Cursors.Arrow
        If Not Hay Then
            MsgError("No hay documentos marcados para enviar")
        Else
            Mensaje("Los datos enviados a SII, demoran en algunos casos tener respuestas, " + vbCrLf + "deberá consultar los documentos en unos minutos mas para conocer su estado.")
            'Volver a Cargar los Datos
            Consultar_Datos()
        End If

        '    If CBool(xTabla.GetData(i, T_OK)) Then
        '        If oCrearTED.Checked Then
        '            If DTE.Leer_JPG(DTE.Ruta_Archivo_Fiscal(gJPG, wLocal, wTipoDoc, wNumDoc, wCliente)) Is Nothing Then
        '                Opcion_Crear = True
        '            Else
        '                If DTE.Leer_TED(DTE.Ruta_Archivo_Fiscal(gXML, Val(xTabla.GetData(i, T_LOCAL)), wTipoDoc, Val(xTabla.GetData(i, T_NUM).ToString), Val(xTabla.GetData(i, T_CLIENTE)))) = "" Then
        '                    Opcion_Crear = True
        '                End If
        '            End If

        '            If oWS.Checked Then
        '                'WEBSERVICE                   
        '                Dim WS = New MarketONEWS.Service
        '                Dim wDT = WS.EmitirTED("1", ClienteLocalActual, wLocal, wTipoDoc, wNumDoc)
        '                If Val(wDT.Rows(0).Item(0)) = 1 Then '1 = Operación Exitosa
        '                    Dim wXML = wDT.Rows(0).Item(2)
        '                    'TED Generado correctamente.
        '                    Dim TEDGenerado = True
        '                    If Not DTE.Generar_TED(wCliente, wLocal, wTipoDoc, wNumDoc, wFecha, wRut, wNombre, wMonto, wPrimeraLinea).Estado Then
        '                        MsgError("Error al Grabar TED en disco")
        '                    End If
        '                Else
        '                    MsgError("Error Generando TED: " & wDT.Rows(0).Item(1).ToString) 'Item1 tiene el mensaje de error.                    
        '                End If
        '                If Opcion_Crear Then
        '                    'Crear Archivos a partir de los campos e las Tablas
        '                    If Not DTE.Generar_TED(wCliente, wLocal, wTipoDoc, wNumDoc, wFecha, wRut, wNombre, wMonto, wPrimeraLinea).Estado Then
        '                        'El_Error("No se pudo crear TED")
        '                    End If
        '                End If
        '            Else
        '                'TIMBRADOR
        '                DTE.Generar_TED(wCliente, wLocal, wTipoDoc, wNumDoc, wFecha, wRut, wNombre, wMonto, wPrimeraLinea)
        '                'DTE.TED(Val(xTabla.GetData(i, T_LOCAL)), wDoc, xTabla.GetData(i, T_NUM))
        '            End If
        '        End If

        '        If xTabla.GetData(i, T_ESTADO).ToString = NE Then
        '            'El_Error ("No se puede enviar a DTE Documentos No electrónicos")
        '        Else
        '            If xTabla.GetData(i, T_ESTADO).ToString = AP Or xTabla.GetData(i, T_ESTADO).ToString = AR Then
        '                'El_Error ("Documento Electrónico ya enviado a SII, no se puede volver a enviar")
        '            Else
        '                Hay = True
        '                If xTabla.GetData(i, T_ESTADO).ToString = ST Then
        '                    'No tiene TED, debe volver a crearse
        '                    ''Generar_TED(Val(xTabla.GetData(i, T_LOCAL)), BuscarCampo("TipoDoc", "TipoDoc", "DescTipoDoc", xTabla.GetData(i, T_DOC)), xTabla.GetData(i, T_NUM), xTabla.GetData(i, T_FECHA), Rut_DTE(xTabla.GetData(i, T_RUT)), Formatea_Texto(xTabla.GetData(i, T_NOMBRE)), xTabla.GetData(i, T_MONTO), xTabla.GetData(i, T_LINEA))
        '                    DTE.Generar_TED(wCliente, wLocal, wTipoDoc, wNumDoc, wFecha, wRut, wNombre, wMonto, wPrimeraLinea)
        '                Else
        '                    'Envio al DTE                        
        '                    If DTE.Generar_TED(wCliente, wLocal, wTipoDoc, wNumDoc, wFecha, wRut, wNombre, wMonto, wPrimeraLinea).Estado Then
        '                        'Me.MousePointer = vbDefault
        '                        'El_Mensaje (Tabla.TextMatrix(Tabla.Row, T_DOC) + " " + Str(Tabla.TextMatrix(Tabla.Row, T_NUM)) + " Enviada Correctamente.")
        '                    Else
        '                        'Me.MousePointer = vbDefault
        '                        'El_Error ("Error al Enviar Documento Electrónico")
        '                    End If
        '                End If
        '            End If
        '        End If
        '    End If
        'Next i
        'Cursor = Cursors.Arrow
        'If Not Hay Then
        '    MsgError("No hay documentos marcados para enviar")
        'Else
        '    MsgBox("Los datos enviados a SII, demoran en algunos casos tener respuestas, " + vbCrLf + "deberá consultar los documentos en unos minutos mas para conocer su estado.")
        '    'Volver a Cargar los Datos
        '    Consultar_Datos()
        'End If

        'Dim wEncontrado As Boolean

        'wEncontrado = False
        'Cursor = Cursors.WaitCursor
        'For i = 1 To xTabla.Rows.Count - 1
        '    If CBool(xTabla.GetData(i, T_OK)) = CHECK Then
        '        If xTabla.GetData(i, T_ESTADO).ToString = NE Then
        '            MsgError("No se puede enviar a DTE Documentos No electrónicos")
        '        Else
        '            If xTabla.GetData(i, T_ESTADO).ToString = AP Or xTabla.GetData(i, T_ESTADO).ToString = AR Then
        '                MsgError("Documento Electrónico ya enviado a SII, no se puede volver a enviar")
        '            Else
        '                wEncontrado = True
        '                Dim wTipoDoc = SQL("SELECT * FROM TipoDoc WHERE DescTipoDoc = '" & xTabla.GetData(i, T_DOC).ToString.Trim).Top

        '                If DTE.Emitir_DTE(Val(xTabla.GetData(i, T_LOCAL)), wTipoDoc.GetText("TipoDoc"), Val(xTabla.GetData(i, T_NUM).ToString.Trim)) Then
        '                    Cursor = Cursors.Default
        '                    MsgBox(xTabla.GetData(xTabla.Row, T_DOC).ToString & " " & xTabla.GetData(xTabla.Row, T_NUM).ToString & " Enviada Correctamente.")
        '                Else
        '                    Cursor = Cursors.Default
        '                    MsgError("Error al Enviar Documento Electrónico")
        '                End If
        '            End If
        '        End If
        '    End If
        'Next i
        'Cursor = Cursors.Arrow
        'If Not wEncontrado Then
        '    MsgError("No hay documentos marcados para enviar")
        '    Auditoria(Text, "No hay documentos marcados para enviar", "", "")
        'Else
        '    MsgBox("Los Datos enviados a SII, demoran en algunos casos tener respuestas, " + vbCrLf + "deberá consultar los documentos en unos minutos mas para conocer su estado.")
        '    'Volver a Cargar los Datos
        '    Consultar_Datos()
        '    Auditoria(Text, "Documentos Enviados", "", "")
        'End If
    End Sub

    Private Sub mConsultar_Click(sender As Object, e As EventArgs) Handles mConsultar.Click
        If xTabla.Row = -1 Then Exit Sub
        ConsultarDTE.Show()
        Dim wLoc = SQL("SELECT * FROM Locales WHERE Local = " & xTabla.GetData(xTabla.Row, T_LOCAL).ToString).Top
        If wLoc IsNot Nothing Then
            ConsultarDTE.cLocal.Text = wLoc.GetText("NombreLocal")
        End If
        ConsultarDTE.cTipoDoc.Text = xTabla.GetData(xTabla.Row, T_DOC).ToString
        ConsultarDTE.xNumero.Text = xTabla.GetData(xTabla.Row, T_NUM).ToString
        ConsultarDTE.Consultar_Datos()
    End Sub

    Private Sub mImprimir_Click(sender As Object, e As EventArgs) Handles mImprimir.Click
        If xTabla.Row = -1 Then Exit Sub
        ImprimirDocumentos.Show()
        ImprimirDocumentos.cLocal.Text = Trim(xTabla.GetData(xTabla.Row, T_NOMBRELOCAL).ToString)
        ImprimirDocumentos.cTipoDoc.Text = Trim(xTabla.GetData(xTabla.Row, T_DOC).ToString)
        ImprimirDocumentos.xNumDoc.Text = xTabla.GetData(xTabla.Row, T_NUM).ToString
        ImprimirDocumentos.Imprimir_Datos()
    End Sub

    Private Sub oSII_Click(sender As Object, e As EventArgs) Handles oSII.Click
        oRapido.Checked = False
    End Sub

    Private Sub oRapido_Click(sender As Object, e As EventArgs) Handles oRapido.Click
        oSII.Checked = False
    End Sub
End Class