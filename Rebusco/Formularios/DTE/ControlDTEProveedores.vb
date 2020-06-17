Imports C1.Win.C1FlexGrid
Imports DTEBoxCliente

Public Class ControlDTEProveedores
    Const T_OK = 0
    Const T_ESTADO = 1
    Const T_TIPODOC = 2
    Const T_DOC = 3
    Const T_NUM = 4
    Const T_FECHA = 5
    Const T_FECHASII = 6
    Const T_LOCAL = 7
    Const T_NOMBRELOCAL = 8
    Const T_CLIENTE = 9
    Const T_RUT = 10
    Const T_NOMBRE = 11
    Const T_FPAGO = 12
    Const T_MONTO = 13
    Const T_APROBADO = 14
    Const T_ANULADO = 15
    Const T_CESION = 16
    Const T_ELIMINADO = 17
    Const T_DISTRIBUIDO = 18
    Const T_RECIBIDO = 19
    Const T_SEGUIMIENTO = 20
    Const T_NOMBRECONTACTO = 21
    Const T_TELEFONOCONTACTO = 22
    Const T_CORREOCONTACTO = 23
    Const T_OBSERVACIONES = 24

    Dim wContacto As String
    Dim wCorreo As String
    Dim wTelefono As String
    Dim wObservaciones As String

    Dim cClave As String = ""

    Const StatusVacio = ""
    Const StatusAceptado = "Aceptado"
    Const StatusRechazado = "Rechazado"
    Const StatusAceptadoLey = "Aceptado Ley 19983"
    Const StatusError = "Error al consultar"

    Dim wEstadoGrilla As New ComboBox

    Private Sub ControlDTEProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        Titulos()

        wEstadoGrilla.Items.Add(StatusVacio)
        wEstadoGrilla.Items.Add(StatusAceptado)
        wEstadoGrilla.Items.Add(StatusAceptadoLey)
        wEstadoGrilla.Items.Add(StatusRechazado)

        cEstados.Items.Add(StatusVacio)
        cEstados.Items.Add(StatusAceptado)
        cEstados.Items.Add(StatusAceptadoLey)
        cEstados.Items.Add(StatusRechazado)

        dDesde.Value = IniFinFecha(1, Now.Date)
        dHasta.Value = Now.Date

        If cLocal.Items.Count = 2 Then
            cLocal.SelectedIndex = 1
        End If

        If UsuarioActual = "PED" Then
            bBuscarCli.Visible = True
        End If

        xRut.Text = Formatea_Rut(FE_Rut_Emisor, 1)
        xNombre.Text = FE_Razon_Social
    End Sub
    Private Sub ComboGrilla_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Dim wFiltro As String = ""
        Dim ListLocal = New List(Of ParametrosLocal)
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim tiposDoc = DC.T_TipoDoc.ToList()

        Dim PageSize As Integer = 300 'El tamaño máximo de página permitido es de 300 


        Dim ServicioDTE As DTEBoxCliente.Servicio
        ServicioDTE = New DTEBoxCliente.Servicio(DTE.FE_DTE, DTE.FE_Llave)

        Dim AmbienteDTE As DTEBoxCliente.Ambiente
        AmbienteDTE = CType(DTE.FE_Ambiente, DTEBoxCliente.Ambiente)

        If dDesde.Value > Date.Now Then
            dDesde.Value = Date.Now
        End If
        Dim FechaDesde As String = Format(dDesde.Value, "yyyy/MM/dd")
        Dim FechaHasta As String = Format(dHasta.Value, "yyyy/MM/dd")

        Cursor = Cursors.WaitCursor

        Dim DTE_GrupoRecibidos As DTEBoxCliente.GrupoBusqueda = DTEBoxCliente.GrupoBusqueda.Recibidos

        Dim DTE_Consulta As String
        DTE_Consulta = "(TipoDTE:33 or TipoDTE:34 or TipoDTE:39 or TipoDTE:52 or TipoDTE:56 or TipoDTE:61) "
        DTE_Consulta += " AND (FchEmis:[" & FechaDesde & " TO " & FechaHasta & "]) "
        DTE_Consulta += " AND (RUTRecep:" & DTE.FE_Rut_Emisor & ") "

        Dim ResultadoDTE As DTEBoxCliente.ResultadoDocumentos = ServicioDTE.BuscarDocumentos(AmbienteDTE, DTE_GrupoRecibidos, DTE_Consulta, 0, PageSize)
        If (ResultadoDTE.ResultadoServicio.Estado = 0) Then
            If (ResultadoDTE.TotalDocumentos > 0) Then
                Dim wLista As New List(Of ControlDTEProveedorReporte)
                Dim wCliente As Decimal = 0
                Dim wRut As String = ""
                Dim WNombreCliente As String = ""
                For Each wC In ResultadoDTE.ResumenDtes
                    Validacion.ValidateObj(wC)
                    Dim rutEmisor = FormatoRut(wC.RUTEmisor)
                    Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Rut = rutEmisor)

                    If wCli IsNot Nothing Then
                        wCliente = wCli.Cliente
                        WNombreCliente = wCli.Nombre
                        wRut = wCli.Rut
                    Else
                        WNombreCliente = wC.RznSoc
                        wRut = wC.RUTEmisor
                    End If

                    Dim CodSII = wC.TipoDTE.ToDecimal()

                    wLista.Add(New ControlDTEProveedorReporte With {.TipoDoc = If(tiposDoc.FirstOrDefault(Function(x) x.Cod_SII = CodSII)?.DescTipoDoc, ""),
                                                                    .TipoDTE = If(wC.TipoDTE Is DBNull.Value, "", wC.TipoDTE),
                                                                    .Folio = wC.Folio,
                                                                    .FchEmis = If(wC.FchEmis.ToString = "", "", Format(wC.FchEmis, "dd/mm/yyyy")),
                                                                    .FchRecepSII = "", ' If(wC.FchRecepSII.ToString = "", "", Format(wC.FchRecepSII, "dd/MM/yyyy")),
                                                                    .RUTEmisor = If(wC.RUTEmisor Is DBNull.Value, "", wC.RUTEmisor),
                                                                    .Cliente = wCliente.ToText(),
                                                                    .NombreCliente = If(WNombreCliente Is DBNull.Value, "", WNombreCliente),
                                                                    .Rut = If(wRut Is DBNull.Value, "", wRut),
                                                                    .MntTotal = If(wC.MntTotal Is DBNull.Value, "", wC.MntTotal),
                                                                    .Aprobado = If(wC.Aprobado Is DBNull.Value, "", wC.Aprobado),
                                                                    .Anulado = If(wC.Anulado Is DBNull.Value, "", wC.Anulado),
                                                                    .Cesion = If(wC.Cesion Is DBNull.Value, "", wC.Cesion),
                                                                    .Eliminado = If(wC.Eliminado Is DBNull.Value, "", wC.Eliminado),
                                                                    .Distribuido = If(wC.Distribuido Is DBNull.Value, "", wC.Distribuido),
                                                                    .Recibido = If(wC.Recibido Is DBNull.Value, "", wC.Recibido),
                                                                    .Seguimiento = If(wC.Seguimiento Is DBNull.Value, "", wC.Seguimiento)})
                Next

                Dim wListaParametros = ParametroLocal()
                Dim wReporte As New ReporteControlDTEProveedores
                wReporte.Database.Tables("MarketONE_ControlDTEProveedorReporte").SetDataSource(wLista)
                wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wListaParametros)

                VisorReportes.MostrarReporte(wReporte)
                VisorReportes.Show()
            Else
                MsgError("No se encuentra Documentos")
            End If
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bProcesar_Click(sender As Object, e As EventArgs) Handles bProcesar.Click
        Dim Hay As Boolean, qRespuesta As String

        Hay = False
        Cursor = Cursors.WaitCursor
        For i = 1 To xTabla.Rows.Count - 1
            Dim wModo As String = StatusAceptado
            Dim wRut As String = xTabla.GetData(i, T_RUT).ToString
            Dim wTipoDoc As String = xTabla.GetData(i, T_TIPODOC).ToString
            Dim wNumDoc As Double = Val(xTabla.GetData(i, T_NUM).ToString)
            Dim wContactoNombre As String = xTabla.GetData(i, T_NOMBRECONTACTO).ToString
            Dim wContactoTelefono As String = xTabla.GetData(i, T_TELEFONOCONTACTO).ToString
            Dim wContactoCorreo As String = xTabla.GetData(i, T_CORREOCONTACTO).ToString

            If CBool(xTabla.GetData(i, T_OK).ToString) Then
                If xTabla.GetData(i, T_ESTADO).ToString = StatusAceptado Then
                    Hay = True
                    qRespuesta = Status_Comercial(wModo, wRut, wTipoDoc, wNumDoc, wContactoNombre, wContactoTelefono, wContactoCorreo)
                    If qRespuesta <> "" Then
                        xTabla.SetData(i, T_OBSERVACIONES, qRespuesta)
                    End If
                End If
                If xTabla.GetData(i, T_ESTADO).ToString = StatusRechazado Then
                    Hay = True
                    qRespuesta = Status_Comercial(StatusRechazado, wRut, wTipoDoc, wNumDoc, wContactoNombre, wContactoTelefono, wContactoCorreo)
                    If qRespuesta <> "" Then
                        xTabla.SetData(i, T_OBSERVACIONES, qRespuesta)
                    End If
                End If
            End If
        Next i
        Cursor = Cursors.Arrow
        If Not Hay Then
            MsgError("No hay documentos marcados para enviar")
        Else
            Mensaje("Datos enviados a SII.")
            'Volver a Cargar los Datos
            Consultar_Datos()
        End If
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        Dim wLocal As Integer
        Dim wReceptor As String
        Dim PageSize As Integer = 300 'El tamaño máximo de página permitido es de 300 

        xCantDoc.Text = ""
        Titulos()

        Dim Bases = New RebuscoDataContext(P_CONEXION)

        bConsultar.Enabled = False
        wReceptor = DTE.FE_Rut_Emisor
        If Trim(cLocal.Text) <> "" Then
            Dim Loc = Bases.T_Locales.FirstOrDefault(Function(x) x.NombreLocal = Trim(cLocal.Text))
            wLocal = CInt(Loc.Local)
            wReceptor = Rut_DTE(Loc.RutLocal)
        End If

        Dim ServicioDTE As DTEBoxCliente.Servicio
        ServicioDTE = New DTEBoxCliente.Servicio(DTE.FE_DTE, DTE.FE_Llave)

        Dim AmbienteDTE As DTEBoxCliente.Ambiente
        AmbienteDTE = CType(DTE.FE_Ambiente, Ambiente)

        If dDesde.Value > Date.Now Then
            dHasta.Value = Date.Now
        End If

        Dim FechaDesde As String = FE_Fecha(dDesde.Value)
        Dim FechaHasta As String = FE_Fecha(dHasta.Value)

        Cursor = Cursors.WaitCursor

        Dim DTE_GrupoRecibidos As DTEBoxCliente.GrupoBusqueda = DTEBoxCliente.GrupoBusqueda.Recibidos
        Dim DTE_Consulta As String = "FchEmis:[" & FechaDesde & " TO " + FechaHasta & "] AND RUTRecep:" & DTE.FE_Rut_Emisor


        Dim ResultadoDTE As ResultadoDocumentos = ServicioDTE.BuscarDocumentos(AmbienteDTE, DTE_GrupoRecibidos, DTE_Consulta, 0, PageSize)
        If (ResultadoDTE.ResultadoServicio.Estado = 0) Then
            If (ResultadoDTE.TotalDocumentos > 0) Then

                xTabla.Visible = False

                Call Cargar_Datos(ResultadoDTE)

                If xTabla.Rows.Count > 1 Then
                    xTabla.Col = 1 : xTabla.Row = 1
                End If

                xCantDoc.Text = (xTabla.Rows.Count - 1).ToString
                Cursor = Cursors.Arrow
                xTabla.Visible = True

            Else
                Cursor = Cursors.Arrow
                MsgError("No se encontraron documentos.")
            End If
        Else
            ' Si la llamada no fue satisfactoria
            Cursor = Cursors.Arrow
            MsgError(ResultadoDTE.ResultadoServicio.Descripcion)
        End If


        bConsultar.Enabled = True
    End Sub

    Private Sub xTabla_DoubleClick(sender As Object, e As EventArgs) Handles xTabla.DoubleClick
        If xTabla.Rows.Count <= 1 Then Exit Sub

        If xTabla.Col = T_OK Then
            If CBool(xTabla.GetData(xTabla.Row, T_OK).ToString) Then
                xTabla.SetData(xTabla.Row, T_OK, UNCHECK)
            Else
                xTabla.SetData(xTabla.Row, T_OK, CHECK)
            End If
        End If
        If xTabla.Col = T_ESTADO Then
            xTabla.StartEditing(xTabla.Row, T_ESTADO)
        End If
        If xTabla.Col >= T_DOC And xTabla.Col <= T_MONTO Then
            Dim wTipoDoc As String = xTabla.GetData(xTabla.Row, T_TIPODOC).ToString
            Dim wNumDoc As Double = Val(xTabla.GetData(xTabla.Row, T_NUM).ToString)
            If Pregunta("Desea Ver/Imprimir Documentos del Proveedor" & vbCrLf & wTipoDoc & ": " & wNumDoc) Then
                Imprimir_Documento_Proveedor(xTabla.GetData(xTabla.Row, T_RUT).ToString, xTabla.GetData(xTabla.Row, T_TIPODOC).ToString, Val(xTabla.GetData(xTabla.Row, T_NUM).ToString))
            End If
        End If
    End Sub



    Private Sub xRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xRut.KeyPress
        If e.KeyChar = vbCr Then
            Encontrar_Cliente()
        End If
    End Sub

    Sub Encontrar_Cliente()
        Dim Swap = SQL("Select Cliente,Rut,Nombre,Clave from Clientes where Rut ='" + xRut.Text + "'").Top
        If Swap IsNot Nothing Then
            xNombre.Text = Swap.GetText("Nombre").Trim
            cClave = Swap.GetText("clave").Trim
        Else
            xNombre.Text = ""
            cClave = ""
        End If
    End Sub

#Region "Funciones Locales"

    Sub Titulos()
        xTabla.Redraw = True

        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 25

        xTabla.SetData(0, T_OK, "Ok")
        xTabla.SetData(0, T_ESTADO, "Estado")
        xTabla.SetData(0, T_TIPODOC, "Tipo.Doc.")
        xTabla.SetData(0, T_DOC, "Documento")
        xTabla.SetData(0, T_NUM, "Número")
        xTabla.SetData(0, T_FECHA, "Fecha")
        xTabla.SetData(0, T_FECHASII, "Recepción SII")
        xTabla.SetData(0, T_LOCAL, "Local")
        xTabla.SetData(0, T_NOMBRELOCAL, "Local")
        xTabla.SetData(0, T_CLIENTE, "Cliente")
        xTabla.SetData(0, T_RUT, "Rut")
        xTabla.SetData(0, T_NOMBRE, "Nombre")
        xTabla.SetData(0, T_FPAGO, "F.Pago")
        xTabla.SetData(0, T_MONTO, "Monto")
        xTabla.SetData(0, T_APROBADO, "Autorizado")
        xTabla.SetData(0, T_ANULADO, "Anulado")
        xTabla.SetData(0, T_CESION, "Cesión")
        xTabla.SetData(0, T_ELIMINADO, "Eliminado")
        xTabla.SetData(0, T_DISTRIBUIDO, "Distribuido")
        xTabla.SetData(0, T_RECIBIDO, "Recibido")
        xTabla.SetData(0, T_SEGUIMIENTO, "Autorizado")
        xTabla.SetData(0, T_NOMBRECONTACTO, "Nombre Contacto")
        xTabla.SetData(0, T_TELEFONOCONTACTO, "Telefono Contacto")
        xTabla.SetData(0, T_CORREOCONTACTO, "Correo Contacto")
        xTabla.SetData(0, T_OBSERVACIONES, "Observaciones")

        xTabla.Cols(T_OK).Width = 30
        xTabla.Cols(T_ESTADO).Width = 110
        xTabla.Cols(T_TIPODOC).Width = 0
        xTabla.Cols(T_DOC).Width = 105
        xTabla.Cols(T_NUM).Width = 70
        xTabla.Cols(T_FECHA).Width = 75
        xTabla.Cols(T_FECHASII).Width = 0
        xTabla.Cols(T_LOCAL).Width = 0
        xTabla.Cols(T_NOMBRELOCAL).Width = 0
        xTabla.Cols(T_CLIENTE).Width = 60
        xTabla.Cols(T_RUT).Width = 80
        xTabla.Cols(T_NOMBRE).Width = 200
        xTabla.Cols(T_FPAGO).Width = 0
        xTabla.Cols(T_MONTO).Width = 80
        xTabla.Cols(T_APROBADO).Width = 60
        xTabla.Cols(T_ANULADO).Width = 60
        xTabla.Cols(T_CESION).Width = 0
        xTabla.Cols(T_ELIMINADO).Width = 60
        xTabla.Cols(T_DISTRIBUIDO).Width = 60
        xTabla.Cols(T_RECIBIDO).Width = 60
        xTabla.Cols(T_SEGUIMIENTO).Width = 0
        xTabla.Cols(T_NOMBRECONTACTO).Width = 50
        xTabla.Cols(T_TELEFONOCONTACTO).Width = 50
        xTabla.Cols(T_CORREOCONTACTO).Width = 50
        xTabla.Cols(T_OBSERVACIONES).Width = 200

        xTabla.Cols(T_OK).TextAlignFixed = TextAlignEnum.CenterCenter
        xTabla.Cols(T_FECHA).TextAlignFixed = TextAlignEnum.CenterCenter
        xTabla.Cols(T_FECHASII).TextAlignFixed = TextAlignEnum.CenterCenter
        xTabla.Cols(T_MONTO).TextAlignFixed = TextAlignEnum.RightCenter
        xTabla.Cols(T_NUM).TextAlignFixed = TextAlignEnum.RightCenter
        xTabla.Cols(T_CLIENTE).TextAlignFixed = TextAlignEnum.RightCenter

        xTabla.Cols(T_OK).TextAlign = TextAlignEnum.CenterCenter
        xTabla.Cols(T_FECHA).TextAlign = TextAlignEnum.CenterCenter
        xTabla.Cols(T_FECHASII).TextAlign = TextAlignEnum.CenterCenter
        xTabla.Cols(T_NUM).TextAlign = TextAlignEnum.RightCenter
        xTabla.Cols(T_CLIENTE).TextAlign = TextAlignEnum.RightCenter
        xTabla.Cols(T_MONTO).TextAlign = TextAlignEnum.RightCenter

        xTabla.Cols(T_OK).DataType = GetType(Boolean)
        xTabla.Cols(T_MONTO).DataType = GetType(Double)
        xTabla.Cols(T_MONTO).Format = "N0"

        wEstadoGrilla.DropDownStyle = ComboBoxStyle.DropDownList
        xTabla.Cols(T_ESTADO).Editor = wEstadoGrilla
        AddHandler wEstadoGrilla.SelectedIndexChanged, AddressOf ComboGrilla_SelectedIndexChanged

    End Sub

    Sub Cargar_Datos(ResultadoDTE As ResultadoDocumentos)

        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim tiposDoc = DC.T_TipoDoc.ToList()

        Dim wRut As String
        Dim wTipoDoc As String

        For Each doc As ResumenDTE In ResultadoDTE.ResumenDtes
            DoEvents()
            If Not oTodos.Checked And (doc.TipoDTE = "39" Or doc.TipoDTE = "52" Or doc.TipoDTE = "46" Or doc.TipoDTE = "801") Then
                'No considerar estos documentos
            Else
                Dim CodSII = doc.TipoDTE.ToDecimal()
                wTipoDoc = If(tiposDoc.FirstOrDefault(Function(x) x.Cod_SII = CodSII)?.DescTipoDoc, "")
                If Trim(cTipoDoc.Text) = wTipoDoc Or wTipoDoc = "" Or Trim(cTipoDoc.Text) = "" Then
                    xTabla.AddItem("")
                    xTabla.SetData(xTabla.Rows.Count - 1, T_OK, UNCHECK)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_TIPODOC, If(tiposDoc.FirstOrDefault(Function(x) x.Cod_SII = CodSII)?.TipoDoc, ""))
                    xTabla.SetData(xTabla.Rows.Count - 1, T_DOC, wTipoDoc)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_NUM, doc.Folio)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, Format(doc.FchEmis, "dd/MM/yyyy"))
                    'xTabla.SetData(xTabla.Rows.Count - 1, T_FECHASII, Format(doc.FchRecepSII, "dd/MM/yyyy"))
                    wRut = Formatea_Rut(doc.RUTEmisor, 1)
                    Dim wCli = SQL("Select * from Clientes where Rut = '" & wRut & "'").Top
                    If wCli IsNot Nothing Then
                        xTabla.SetData(xTabla.Rows.Count - 1, T_CLIENTE, wCli.GetText("Cliente"))
                        xTabla.SetData(xTabla.Rows.Count - 1, T_NOMBRE, wCli.GetText("Nombre"))
                        xTabla.SetData(xTabla.Rows.Count - 1, T_RUT, wCli.GetText("Rut"))
                    Else
                        xTabla.SetData(xTabla.Rows.Count - 1, T_NOMBRE, doc.RznSoc)
                        xTabla.SetData(xTabla.Rows.Count - 1, T_RUT, FormatoRut(doc.RUTEmisor))
                    End If
                    xTabla.SetData(xTabla.Rows.Count - 1, T_MONTO, doc.MntTotal)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGO, doc.Estructura)

                    'xTabla.SetData(wFila, T_APROBADO, doc.Aprobado)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_APROBADO, doc.AutorizadoSII)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_ANULADO, doc.Anulado)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_CESION, doc.Cesion)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_ELIMINADO, doc.Eliminado)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_DISTRIBUIDO, doc.Distribuido)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_RECIBIDO, doc.Recibido)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_SEGUIMIENTO, doc.Seguimiento)

                    Dim statusCom = Status_Comercial("", xTabla.GetData(xTabla.Rows.Count - 1, T_RUT).ToString,
                                                     xTabla.GetData(xTabla.Rows.Count - 1, T_TIPODOC).ToString,
                                                     Val(xTabla.GetData(xTabla.Rows.Count - 1, T_NUM).ToString))
                    Select Case (statusCom)
                        Case "0"
                            xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, StatusVacio)
                        Case "1"
                            xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, StatusAceptadoLey)
                        Case "2"
                            xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, StatusAceptado)
                        Case "3"
                            xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, StatusRechazado)
                        Case Else
                            xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, StatusError)
                    End Select

                    xTabla.SetData(xTabla.Rows.Count - 1, T_NOMBRECONTACTO, wContacto)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_TELEFONOCONTACTO, wTelefono)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_CORREOCONTACTO, wCorreo)
                    xTabla.SetData(xTabla.Rows.Count - 1, T_OBSERVACIONES, wObservaciones)
                End If
            End If
        Next
    End Sub

    Function Status_Comercial(wModo As String, wRut As String, wTipoDoc As String, wNumDoc As Double, Optional wContactoNombre As String = "", Optional wContactoTelefono As String = "", Optional wContactoCorreo As String = "") As String
        Dim wXML As String

        Dim ServicioDTE As Servicio
        ServicioDTE = New Servicio(DTE.FE_DTE, DTE.FE_Llave)
        If wModo = "" Then
            'Consulta de Estado             
            Dim Grupo As GrupoBusqueda = GrupoBusqueda.Recibidos
            Dim RetornarXML As Boolean = True

            'Se efectúa la llamada al servicio, el último parámetro es un boolean que indica si se desea que el servicio devuelva el xml de la respuesta comercial o no.
            Dim ResultadoEST As ResultadoConsultarEstadoComercial
            ResultadoEST = ServicioDTE.EstadoComercialDocumento(CType(DTE.FE_Ambiente, Ambiente), Grupo, Formatea_Rut(wRut, 0), CType(DTE.Codigo_DTE_EMISION(wTipoDoc), TipoDocumento), CLng(wNumDoc), RetornarXML)
            If (ResultadoEST.ResultadoServicio.Estado = CType("0", EstadoResultado)) Then
                'El código de estado comercial puede tomar los siguientes valores: 0-Sin aceptaci�n o rechazo comercial, 1-Aceptado Ley 19983, 2-Aceptado, 3-Rechazado
                Status_Comercial = ResultadoEST.CodigoEstadoComercial
                If Status_Comercial = Nothing Then Status_Comercial = StatusVacio
                wObservaciones = ResultadoEST.DescripcionEstadoComercial.ToString.Trim
                wContacto = ResultadoEST.NombreContacto
                wCorreo = ResultadoEST.CorreoContacto
                wTelefono = ResultadoEST.TelefonoContacto
                If ResultadoEST.Observaciones.ToString.Trim <> "" Then
                    wObservaciones = ResultadoEST.Observaciones.ToString.Trim
                End If
                wXML = ResultadoEST.ACKXml
            Else
                Status_Comercial = Trim(ResultadoEST.ResultadoServicio.Descripcion)
            End If
        Else
            If wModo = StatusAceptado Then
                wObservaciones = "Documento Aprobado"
            End If
            If wModo = StatusRechazado Then
                wObservaciones = "Documento Rechazado"
            End If

            Dim ResultadoDOC As ResultadoServicio
            ResultadoDOC = ServicioDTE.EnviarRespuestaComercial(CType(DTE.FE_Ambiente, Ambiente), Formatea_Rut(wRut, 0), DTE.Codigo_DTE_EMISION(wTipoDoc), CLng((wNumDoc)), wContactoNombre, wContactoTelefono, wContactoCorreo, wObservaciones, If(wModo = "AP", TipoRespuestaComercial.Aceptacion, TipoRespuestaComercial.Rechazo))
            If (ResultadoDOC.Estado = CType("0", EstadoResultado)) Then
                Status_Comercial = ""
            Else
                Status_Comercial = Trim(ResultadoDOC.Descripcion)
            End If
        End If
    End Function

    Sub Imprimir_Documento_Proveedor(wRut As String, wTipoDoc As String, wNumDoc As Double)
        Dim wNombreArchivo As String
        Dim Grupo As GrupoBusqueda = GrupoBusqueda.Recibidos

        Dim ServicioDTE As DTEBoxCliente.Servicio
        ServicioDTE = New DTEBoxCliente.Servicio(DTE.FE_DTE, DTE.FE_Llave)

        Dim ResultadoDOC As DTEBoxCliente.ResultadoRecuperarPdf
        ResultadoDOC = ServicioDTE.RecuperarPdf(CType(DTE.FE_Ambiente, Ambiente), Grupo, Formatea_Rut(wRut, 0), Codigo_DTE_Consulta(wTipoDoc), CLng(wNumDoc))

        If (ResultadoDOC.ResultadoServicio.Estado = DTEBoxCliente.EstadoResultado.Ok) Then
            Dim Documento_PDF As Byte()
            Documento_PDF = ResultadoDOC.Datos
            wNombreArchivo = Directorio_PDF + "Proveedor " & wRut & " " & wTipoDoc & " " & wNumDoc & ".PDF"
            System.IO.File.WriteAllBytes(wNombreArchivo, Documento_PDF)
            Abrir_Documento(wNombreArchivo)
        Else
            MsgError(ResultadoDOC.ResultadoServicio.Descripcion)
        End If

    End Sub

    Sub Estado_Documento_Proveedor(wRut As String, wTipoDoc As String, wNumDoc As Double)
        Dim wNombreArchivo As String
        Dim Grupo As GrupoBusqueda = GrupoBusqueda.Recibidos

        Dim ServicioDTE As Servicio
        ServicioDTE = New Servicio(DTE.FE_DTE, DTE.FE_Llave)

        Dim ResultadoDOC As DTEBoxCliente.ResultadoRecuperarPdf
        ResultadoDOC = ServicioDTE.RecuperarPdf(CType(DTE.FE_Ambiente, Ambiente), Grupo, Formatea_Rut(wRut, 0), DTE.Codigo_DTE_EMISION(wTipoDoc), CLng(wNumDoc))

        If (ResultadoDOC.ResultadoServicio.Estado = DTEBoxCliente.EstadoResultado.Ok) Then
            Dim Documento_PDF As Byte()
            Documento_PDF = ResultadoDOC.Datos
            wNombreArchivo = Directorio_PDF + "Proveedor " & wRut & " " & wTipoDoc & " " & wNumDoc & ".PDF"
            System.IO.File.WriteAllBytes(wNombreArchivo, Documento_PDF)
        Else
            MsgError(ResultadoDOC.ResultadoServicio.Descripcion)
        End If

    End Sub

    Sub Consultar_Datos()
        Dim PageSize As Integer = 300 'El tamaño máximo de página permitido es de 300 

        xCantDoc.Text = ""
        Titulos()

        Dim ServicioDTE As DTEBoxCliente.Servicio
        ServicioDTE = New DTEBoxCliente.Servicio(DTE.FE_DTE, DTE.FE_Llave)

        Dim AmbienteDTE As DTEBoxCliente.Ambiente
        AmbienteDTE = CType(DTE.FE_Ambiente, Ambiente)

        If dHasta.Value > Date.Now Then
            dHasta.Value = Date.Now
        End If
        Dim FechaDesde As String = Format(dDesde.Value, "YYYY/MM/DD")
        Dim FechaHasta As String = Format(dHasta.Value, "YYYY/MM/DD")

        Cursor = Cursors.WaitCursor

        Dim DTE_GrupoRecibidos As DTEBoxCliente.GrupoBusqueda = DTEBoxCliente.GrupoBusqueda.Recibidos

        Dim DTE_Consulta As String = "(FchEmis:[" + FechaDesde + " TO " + FechaHasta + "] AND RUTRecep:" + DTE.FE_Rut_Emisor + ")"

        Dim ResultadoDTE As ResultadoDocumentos = ServicioDTE.BuscarDocumentos(AmbienteDTE, DTE_GrupoRecibidos, DTE_Consulta, 0, PageSize)
        If (ResultadoDTE.ResultadoServicio.Estado = 0) Then
            If (ResultadoDTE.TotalDocumentos > 0) Then

                xTabla.Visible = False

                Call Cargar_Datos(ResultadoDTE)

                If xTabla.Rows.Count > 1 Then
                    xTabla.Col = 1 : xTabla.Row = 1
                End If

                xCantDoc.Text = (xTabla.Rows.Count - 1).ToString
                Cursor = Cursors.Arrow
                xTabla.Visible = True

            Else
                Cursor = Cursors.Arrow
                MsgError("No se encontraron documentos.")
            End If
        Else
            ' Si la llamada no fue satisfactoria
            Cursor = Cursors.Arrow
            MsgError(ResultadoDTE.ResultadoServicio.Descripcion)
        End If

    End Sub


#End Region
End Class