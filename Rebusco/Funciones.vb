Imports System
Imports LibMsg
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Reflection
Imports System.Globalization
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Xml.Serialization
Imports System.Text.RegularExpressions
Imports System.Collections.Specialized
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.Integration
Imports LiquidTechnologies.Runtime.Net20
Imports CrystalDecisions.CrystalReports.Engine

Public Class ProcesosNegocio
    Public Distribucion As Boolean
    Public ServicioTecnico As Boolean
    Public Remuneraciones As Boolean
    Public PuntoVenta As Boolean
    Public Optica As Boolean
    Public Restaurant As Boolean
    Public BodegaBasica As Boolean
    Public BodegaAvanzada As Boolean
    Public Ventas As Boolean
    Public Capturador As Boolean
End Class

Public Structure Clientes
    Public Shared Multibike As String = "M"
    Public Shared Wikets As String = "W"
    Public Shared Bikemonkey As String = "B"
End Structure

Public Structure EstadosOT

    Public Shared Asignada As String = "A"
    Public Shared Iniciada As String = "C"
    Public Shared Cerrada As String = "D"
    Public Shared EnProceso As String = "E"
    Public Shared Finalizada As String = "F"
    Public Shared Anulada As String = "N"
    Public Shared EsperaRepuestos As String = "P"
    Public Shared Realizada As String = "R"
    Public Shared EsperaServicio As String = "S"

End Structure


Public Structure TiposDoc
    Public Shared Movimiento As String = "MV"
End Structure


Public Module Funciones

    Public G_DEMO As Boolean = False

    Public Const P_EMPRESA As String = "Wikets Software"
    Public Const P_SISTEMA As String = "MarketONE"
    Public Const VERSION As String = "1.50x "
    Public Const FechaDespliegue As String = "10/06/2020"

    Public P_PROCESOSNEGOCIO As ProcesosNegocio

    Public Directorio_CAF As String
    Public Directorio_TED As String
    Public Directorio_PDF As String
    Public Directorio_TXT As String

    Public G_TIPOCOPIA As List(Of Integer)

    Public G_BODEGA As Decimal
    Public IvaGlobal As Double

    Public A_INGRESADO As String = "Ingresado"
    Public A_GUARDADO As String = "Guardado"
    Public A_IMPRESO As String = "Impreso"
    Public A_MODIFICADO As String = "Modificado"
    Public A_ELIMINADO As String = "Eliminado"
    Public A_ANULADO As String = "Anulado"
    Public MSG_GUARDADO As String = "Registro Guardado Correctamente"
    Public MSG_MODIFICADO As String = "Registro Modificado Correctamente"

    Public Const CHECK As Boolean = True
    Public Const UNCHECK As Boolean = False
    Public Const W_SELECCIONAR As String = "Seleccionar"
    Public MaxDouble As Double = 999999999999999 '15 dígitos / Máximo para evitar notación científica en conversión

    'Colores
    Public C_ROJO_CRITICO As Color = Color.FromArgb(234, 118, 119)
    Public C_AMARILLO_URGENTE As Color = Color.FromArgb(245, 185, 95)
    Public C_GRIS_INASISTIDA As Color = Color.FromArgb(161, 161, 161)
    Public C_AZUL_ASISTIDA As Color = Color.FromArgb(118, 163, 204)
    Public C_VERDE_RESERVADO As Color = Color.FromArgb(82, 255, 181)
    Public C_VERDE_INICIADO As Color = Color.FromArgb(105, 245, 133)
    Public C_AZUL_CELESTE As Color = Color.FromArgb(150, 237, 255)

    Public C_ROJO As Color = Color.FromArgb(255, 99, 115)
    Public C_AMARILLO As Color = Color.FromArgb(255, 220, 69)
    Public C_AMARILLO_CELDA As Color = Color.FromArgb(255, 222, 144)
    Public C_SOLOLECTURA As Color = Color.FromArgb(220, 230, 235)
    Public C_VERDE As Color = Color.FromArgb(135, 255, 115)
    Public C_TITULO As Color = Color.FromArgb(29, 73, 140)
    Public C_CELESTE As Color = Color.FromArgb(115, 214, 255)
    Public C_VERDE_CLARO As Color = Color.FromArgb(210, 255, 132)
    Public C_BLANCO As Color = Color.White
    Public C_VIOLETA As Color = Color.FromArgb(155, 162, 255)
    Public C_GRISAZUL As Color = Color.FromArgb(212, 232, 248)
    Public C_GRIS As Color = Color.FromArgb(222, 232, 232)
    Public C_GRISOSCURO As Color = Color.FromArgb(202, 212, 222)
    Public C_NARANJO As Color = Color.FromArgb(255, 179, 149)
    Public C_NARANJO_TXT As Color = Color.FromArgb(83, 0, 2)
    Public C_FUENTE_AZUL As Color = Color.FromArgb(29, 73, 140)
    Public C_FUENTE_AZUL_2 As Color = Color.FromArgb(15, 41, 100)
    Public C_FUENTE_VERDE As Color = Color.FromArgb(0, 64, 0)
    Public C_FUENTE_AMARILLO As Color = Color.FromArgb(64, 51, 0)
    Public C_FUENTE_ROJO As Color = Color.FromArgb(64, 0, 0)
    Public C_CELDA_SEL As Color = Color.FromArgb(108, 201, 255)
    Public C_TITULODIAACTUAL As Color = Color.FromArgb(42, 67, 106)
    Public C_CELDADIAACTUAL As Color = Color.FromArgb(226, 234, 245)

    Public C_NOAPLICA As Color = Color.FromArgb(199, 187, 180) 'cafe claro
    Public C_REALIZADO As Color = Color.FromArgb(180, 255, 82) 'Verde
    Public C_ENESPERA As Color = Color.FromArgb(252, 255, 255) 'Blanco
    Public C_ENESPERA_SINSTOCK As Color = Color.FromArgb(255, 179, 149) 'Naranjo
    Public C_NOAPLICA_TXT As Color = Color.FromArgb(55, 52, 50) 'Negro
    Public C_REALIZADO_TXT As Color = Color.FromArgb(3, 62, 21) 'Verde Oscuro
    Public C_ENESPERA_TXT As Color = Color.FromArgb(47, 34, 23) 'Cafe Oscuro
    Public C_ENESPERA_STINSTOCK_TXT As Color = Color.FromArgb(83, 0, 2) 'Rojo

    Public G_SUPERVISOR As Boolean
    Public G_PROGRAMADOR As Boolean

    Public G_LOCALACTUAL As Decimal
    Public UsuarioActual As String
    Public NombreLocalActual As String
    Public NombreBodegaActual As String
    Public LocalUsuario As Decimal
    Public Ubicacion As Double
    Public NombreUsuarioActual As String
    Public G_ACCESOUSUARIO As Decimal
    Public ClienteUsuarioActual As Double
    Public G_CLIENTEACTUAL As Double
    Public G_FANTASIACLIENTE As String
    Public gPDF As String = "pdf"
    Public gXML As String = "xml"
    Public gJPG As String = "jpg"
    Public gTXT As String = "txt"

    Public F_VERVALORIZACION As Boolean
    Public F_VERCOSTO As Boolean

    Public Property P_FPAGO As String = "E"

    Public CONFIGURACION As Settings

    Public Const PATRONCONEXION As String = "Data Source={0};Initial Catalog={1};User ID=wikets;Password=software"
    Public ReadOnly Property P_CONEXION As String
        Get
            Return String.Format(PATRONCONEXION, CONFIGURACION.IPServidor, CONFIGURACION.Base)
        End Get
    End Property


    Public ReadOnly Property P_CANTIDADCOPIA As Decimal
        Get
            Return CONFIGURACION.CantidadCopias
        End Get
    End Property

    Public ReadOnly Property P_IMPRESORAVOUCHER As String
        Get
            Return CONFIGURACION.ImpresoraVoucher
        End Get
    End Property

    Public ReadOnly Property P_STOCKOBLIGATORIO As Boolean
        Get
            Return CONFIGURACION.StockObligatorio
        End Get
    End Property

    Public ReadOnly Property P_IMPRIMIRDOCUMENTO As Boolean
        Get
            Return CONFIGURACION.ImprimirDocumento
        End Get
    End Property

    Public ReadOnly Property P_DIRECTORIO As String
        Get
            Return My.Application.Info.DirectoryPath
        End Get
    End Property

    Public Property G_IVA As Decimal
    Public Property G_IDCLIENTE As String
    Private _POS As Decimal = 0
    Public Property G_POS As Decimal
        Get
            If G_IDCLIENTE = Clientes.Wikets Then
                Return 1
            Else
                Return _POS
            End If
        End Get
        Set(value As Decimal)
            If Not G_IDCLIENTE = Clientes.Wikets Then
                _POS = value
            End If
        End Set
    End Property

    Public P_MAXIMODESCUENTO As Decimal

    Public G_LOGO As Image



    Public Function ObtenerParametros() As Boolean

        Try

            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim PAR = DC.T_Parametros.FirstOrDefault()

            If PAR Is Nothing Then Return False

            P_MAXIMODESCUENTO = PAR.MaximoDescuento
            G_IVA = PAR.Iva.ToString.ToDecimal
            If PAR.Clave.Trim = "" Then
                MsgError("No se ha establecido un ID de Cliente. Comuníquese con Soporte", "Error de parámetro")
                End
            End If
            G_IDCLIENTE = PAR.Clave

            Dim MatrizImagen() As Byte = CType(PAR.Logo1, Byte())
            Dim ImagenMemoria As New IO.MemoryStream(MatrizImagen)
            If MatrizImagen.Length > 0 Then
                G_LOGO = Image.FromStream(ImagenMemoria)
            End If

            Return True
        Catch ex As Exception
            MsgError($"{P_CONEXION} {ex.Message}")
            Return False
        End Try
    End Function

    Public Sub SaveJson(json As String, archivo As String)

        Dim wPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Directory.CreateDirectory(wPath)
        wPath &= "/Log_" + archivo + ".json"
        Try
            File.WriteAllText(wPath, json)
        Catch ex As Exception
        End Try

    End Sub

    Public Function SerializarXML(Of T)(wObjeto As T) As Byte()

        Dim xmlString As String = Nothing
        Dim memoryStream As New MemoryStream()
        Dim xs As New XmlSerializer(GetType(T))
        Dim xmlTextWriter As New Xml.XmlTextWriter(memoryStream, Encoding.UTF8)
        xs.Serialize(xmlTextWriter, wObjeto)
        memoryStream = DirectCast(xmlTextWriter.BaseStream, MemoryStream)
        Return memoryStream.ToArray()

    End Function

    Public Function ByteArrayToUTF8String(characters As Byte()) As String
        Dim encoding As New UTF8Encoding()
        Dim constructedString As String = encoding.GetString(characters)
        Return (constructedString)
    End Function

    Public Enum EstadosSII
        No_Enviado = 0
        Aprobado = 1
        Rechazado = 2
        Timbrado = 3
        Indefinido = 9
    End Enum

    Public Const MAX_LINEAS = 30


    <Extension()>
    Public Sub NextControl(ByVal wOrigen As KeyPressEventArgs, wDestino As Control)
        If wOrigen.KeyChar = vbCr Then
            wDestino.Focus()
        End If
    End Sub
    <Extension>
    Public Sub NextControl(ByRef WOrigen As KeyEventArgs, ByRef WDestino As Control)
        If WOrigen.KeyCode = Keys.Enter Then
            WDestino.Focus()
        End If
    End Sub
    <Extension>
    Public Function ToDouble(ByRef Texto As TextBox) As Double
        Dim wTexto = Texto.Text
        Return If(IsNumeric(wTexto), wTexto.ToDecimal, 0)
    End Function

    <Extension>
    Public Sub TrimText(ByRef Texto As TextBox)
        Texto.Text = Texto.Text.Trim()
    End Sub

    <Extension>
    Public Function ToDouble(ByRef Texto As String) As Double
        Return If(IsNumeric(Texto), Convert.ToDouble(Texto.ToDecimal), 0)
    End Function
    <Extension>
    Public Function ToDecimal(ByRef Texto As TextBox) As Decimal
        Return Texto.Text.ToDecimal
    End Function

    <Extension()>
    Public Function ToDecimal(ByVal texto As String, ByVal Optional precision As Integer = 0, ByVal Optional truncar As Boolean = False) As Decimal
        Dim result = ""

        result = New String(texto.Where(Function(x) Char.IsDigit(x) OrElse New Char() {","c, "."c}.Contains(x)).ToArray())

        result = $"{If(texto.Length > 0, (If(texto(0) = "-", "-", "")), "")}{result}"

        If result.Contains(",") AndAlso result.Contains(".") Then
            result = result.Replace(".", "").Replace(",", ".")
        ElseIf result.Contains(",") Then
            result = result.Replace(",", ".")
        ElseIf result.Contains(".") Then
            result = result.Replace(".", "")
        End If

        If result.Where(Function(x) x = ","c).Count > 1 Then
            Return 0D
        End If
        If result.Where(Function(x) x = "."c).Count > 1 Then
            Return 0D
        End If

        If truncar Then
            Return If(result = "", 0D, Truncate(Convert.ToDecimal(result, New CultureInfo("en-us")), precision))
        Else
            Return If(result = "", 0D, Math.Round(Convert.ToDecimal(result, New CultureInfo("en-us")), precision, MidpointRounding.AwayFromZero))
        End If
    End Function


    <Extension()>
    Public Function ToDecimal(ByVal num As Decimal, ByVal Optional precision As Integer = 0, ByVal Optional truncate As Boolean = False) As Decimal
        Return num.ToString("G29").ToDecimal(precision, truncate)
    End Function

    <Extension()>
    Public Function ToDecimal(ByVal num As Double, ByVal Optional precision As Integer = 0, ByVal Optional truncate As Boolean = False) As Decimal
        Return num.ToString("G29").ToDecimal(precision, truncate)
    End Function

    Public Function Truncate(ByVal valor As Decimal, ByVal precision As Integer) As Decimal
        Dim multiplo As Decimal = Convert.ToDecimal(Math.Pow(10, precision))
        Dim resultado As Decimal = Math.Truncate(multiplo * valor)
        Return (resultado / multiplo)
    End Function
    <Extension>
    Public Function ToInteger(ByRef Texto As TextBox) As Integer
        Return If(IsNumeric(Texto), Convert.ToInt32(Texto.Text), 0)
    End Function
    <Extension>
    Public Function ToInteger(ByRef Texto As String) As Integer
        Return If(IsNumeric(Texto), Convert.ToInt32(Texto), 0)
    End Function

    Public Enum NumericFormat
        Normal
        Money
    End Enum

    <Extension>
    Public Function ToText(ByRef Numero As TextBox, Formato As NumericFormat, Optional Precision As Integer = 0) As String
        Dim Dec = If(IsNumeric(Numero.Text), Convert.ToDecimal(Numero.Text), 0)
        Return Dec.ToText(Formato, Precision)
    End Function

    <Extension>
    Public Function ToText(ByRef Numero As Double, Formato As NumericFormat, Optional Precision As Integer = 0) As String
        Dim Dec = Convert.ToDecimal(Numero)
        Return Dec.ToText(Formato, Precision)
    End Function

    <Extension>
    Public Function ToText(ByRef Numero As Decimal, Formato As NumericFormat, Optional Precision As Integer = 0) As String
        Dim wPartes() As String
        Dim wDecimal As String = ""
        Dim wEntero As String = ""
        Dim wFormato As String = ""
        Dim wCondicion As String = ""
        Numero = Math.Round(Numero, Precision, MidpointRounding.AwayFromZero)

        If InStr(Numero.ToString, ".") > 0 Then
            wPartes = Numero.ToString.Split(CType(".", Char()))
            wDecimal = wPartes(1).ToString
            wEntero = wPartes(0).ToString
        Else
            wEntero = Numero.ToString
        End If

        wFormato = FormatNumber(wEntero, 0,,, TriState.True).Replace(",", ".").ToString

        Return If(wDecimal = "", wFormato, wFormato & "," & wDecimal)
    End Function


    Public Sub ValidarDigitos(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub ValidarDigitosDecimal(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = CChar(",") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    <Extension()>
    Public Function Validar(ByRef wValor As Double, Optional ByVal wPosicionesDecimales As Integer = 3) As Double
        Try
            wValor = Decimal.Round(CInt(wValor), wPosicionesDecimales, MidpointRounding.AwayFromZero)
            If wValor > MaxDouble Then wValor = MaxDouble
        Catch ex As OverflowException
            wValor = MaxDouble
        End Try
        Return wValor
    End Function
    Public Sub ValidarDigitos(ByRef sender As Object, Optional ByVal wPosicionesDecimales As Integer = 3)
        If sender Is Nothing Then Exit Sub
        Dim wTextBox As TextBox = DirectCast(sender, TextBox)
        Trim(wTextBox.Text)
        If wTextBox.Text <> "" AndAlso Not wTextBox.Text = "0" Then
            Dim wValor As Double = Val(wTextBox.Text.Replace(",", "."))
            wValor.Validar(wPosicionesDecimales)
            wTextBox.Text = IIf(wValor = 0, "", wValor).ToString
        End If
    End Sub


#Region "ADO.Net"

    Public SQL_QUERY As String
    Function SQL(ByRef wQuery As String) As DataTable

        SQL_QUERY = wQuery
        Dim wDt As New DataTable
        Try
            Using wCon As New SqlConnection(P_CONEXION)
                wCon.Open()
                Using wCmd As New SqlCommand(wQuery, wCon)
                    Using wDa As New SqlDataAdapter(wCmd)
                        wDa.Fill(wDt)
                    End Using
                End Using
                SqlConnection.ClearPool(wCon)
            End Using
            Return wDt
        Catch ex As Exception
            MsgError("Error en Consulta SQL:" & vbCrLf & vbCrLf & wQuery & vbCrLf & " Tipo Error:" + ex.Message.ToString)
            Return Nothing
        End Try
    End Function


    Function SQLScalar(ByVal wQuery As String) As Object
        Try
            Using wCon As New SqlConnection(P_CONEXION)
                wCon.Open()
                Using wCmd As New SqlCommand(wQuery, wCon)
                    Dim wValor = wCmd.ExecuteScalar
                    If wValor Is Nothing Then
                        Return ""
                    Else
                        Return wValor
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgError("Error en Consulta SQL:" & vbCrLf & vbCrLf & wQuery & vbCrLf & " Tipo Error:" + ex.Message.ToString)
            Return Nothing
        End Try
    End Function


    Function SQLUpdate(ByVal wQuery As String) As Boolean
        Try
            Using wCon As New SqlConnection(P_CONEXION)
                wCon.Open()
                Using wCmd As New SqlCommand(wQuery, wCon)
                    Dim wValor = wCmd.ExecuteNonQuery
                    Return wValor > 0
                End Using
            End Using
        Catch ex As Exception
            MsgError("Error en Consulta SQL:" & vbCrLf & vbCrLf & wQuery & vbCrLf & " Tipo Error:" + ex.Message.ToString)
            Return False
        End Try
    End Function


    <Extension()>
    Function GetText(ByRef wFila As DataRow, wCampo As String) As String
        Return wFila.Item(wCampo).ToString.Trim
    End Function

    <Extension()>
    Function GetValue(ByRef wFila As DataRow, wCampo As String) As Object
        Return wFila.Item(wCampo)
    End Function

    <Extension()>
    Function GetNum(ByRef wFila As DataRow, wCampo As String) As Double
        Return Val(wFila.Item(wCampo))
    End Function
    <Extension()>
    Function GetDate(ByRef wFila As DataRow, wCampo As String) As Date
        Return CDate(wFila.Item(wCampo))
    End Function
    <Extension()>
    Function GetInt(ByRef wFila As DataRow, wCampo As String) As Integer
        Return CInt(wFila.Item(wCampo))
    End Function
    <Extension()>
    Function GetBool(ByRef wFila As DataRow, wCampo As String) As Boolean
        Return CBool(wFila.Item(wCampo))
    End Function
    <Extension()>
    Function Top(ByRef wTabla As DataTable) As DataRow
        If wTabla IsNot Nothing Then
            If wTabla.Rows.Count = 0 Then Return Nothing
            Return wTabla.Rows(0)
        Else
            Return Nothing
        End If
    End Function
    <Extension>
    Function GetDecimal(ByRef wFila As DataRow, wCampo As String) As Decimal
        Return wFila.Item(wCampo).ToString.ToDecimal
    End Function
#End Region

#Region "MENSAJES"

    Public Sub MsgError(ByVal wError As String, Optional wTitulo As String = "Error")
        Dim _mensaje = New Msg()
        _mensaje.Mostrar(wTitulo, wError, TipoMensaje.Error, LibMsg.Ubicacion.Centrado)
        ElementHost.EnableModelessKeyboardInterop(_mensaje)
        _mensaje.ShowDialog()
    End Sub

    Public Sub Mensaje(ByVal wMensaje As String, Optional wTitulo As String = "Mensaje")
        Dim wMsg = New Msg
        wMsg.Mostrar(wTitulo, wMensaje, TipoMensaje.Ok, LibMsg.Ubicacion.Centrado)
        wMsg.ShowDialog()
    End Sub

    Public Function Pregunta(ByVal wMensaje As String, Optional wTitulo As String = "Pregunta") As Boolean
        Dim wMsg = New Msg
        wMsg.Mostrar(wTitulo, wMensaje, TipoMensaje.Confirmacion, LibMsg.Ubicacion.Centrado)
        wMsg.ShowDialog()
        Return wMsg.DialogResult.Value
    End Function
    Public Function PreguntaAdvertencia(ByVal wMensaje As String, Optional wTitulo As String = "Advertencia") As Boolean
        Dim wMsg = New Msg
        wMsg.Mostrar(wTitulo, wMensaje, TipoMensaje.Advertencia, LibMsg.Ubicacion.Centrado)
        wMsg.ShowDialog()
        Return wMsg.DialogResult.Value
    End Function
    Public Sub Informacion(ByVal wMensaje As String, Optional Titulo As String = "Información")
        Dim wMsg = New Msg
        wMsg.Mostrar(Titulo, wMensaje, TipoMensaje.Info, LibMsg.Ubicacion.Centrado)
        wMsg.ShowDialog()
    End Sub

#End Region

    Public Sub DrawRoundedRectangle(graphics As Graphics, rectangle As Rectangle, pen As Pen, radius As Integer)
        If graphics Is Nothing Then
            Throw New ArgumentNullException("graphics")
        End If

        Dim mode As Drawing2D.SmoothingMode = graphics.SmoothingMode
        graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Using path As Drawing2D.GraphicsPath = RoundedRectangle(rectangle, radius)
            graphics.DrawPath(pen, path)
        End Using
        graphics.SmoothingMode = mode
    End Sub
    Public Function RoundedRectangle(r As Rectangle, radius As Integer) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath()
        Dim d As Integer = radius * 2

        path.AddLine(r.Left + d, r.Top, r.Right - d, r.Top)
        path.AddArc(Rectangle.FromLTRB(r.Right - d, r.Top, r.Right, r.Top + d), -90, 90)
        path.AddLine(r.Right, r.Top + d, r.Right, r.Bottom - d)
        path.AddArc(Rectangle.FromLTRB(r.Right - d, r.Bottom - d, r.Right, r.Bottom), 0, 90)
        path.AddLine(r.Right - d, r.Bottom, r.Left + d, r.Bottom)
        path.AddArc(Rectangle.FromLTRB(r.Left, r.Bottom - d, r.Left + d, r.Bottom), 90, 90)
        path.AddLine(r.Left, r.Bottom - d, r.Left, r.Top + d)
        path.AddArc(Rectangle.FromLTRB(r.Left, r.Top, r.Left + d, r.Top + d), 180, 90)
        path.CloseFigure()

        Return path

    End Function

    Public Sub Auditoria(Optional wProceso As String = "", Optional wEvento As String = "", Optional wDato As String = "", Optional wValor As String = "0", Optional wCantidad As Decimal = 0D)
        Dim wUsuario As String = ""
        If UsuarioActual <> "" Then
            wUsuario = UsuarioActual
        End If

        Try
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wAud = New T_Auditoria With {
                .Lugar = "PC",
                .Fecha = Now,
                .Hora = Format(Now, "hh:mm:ss"),
                .Local = G_LOCALACTUAL,
                .Usuario = wUsuario,
                .Proceso = wProceso,
                .Evento = wEvento,
                .Dato = wDato,
                .Valor = wValor,
                .Cantidad = wCantidad
            }
            DC.T_Auditoria.InsertOnSubmit(wAud)
            DC.SubmitChanges()
        Catch ex As Exception

        End Try

    End Sub
    Public Function Descripta(ByRef wCadena As String) As String
        Dim Descriptado As String
        Dim X As Integer
        Dim AUX As String

        wCadena = Trim(wCadena)
        Descriptado = ""
        AUX = " "
        For X = 1 To Len(wCadena)
            AUX = Mid(wCadena, X, 1)
            Descriptado = Descriptado & Chr(CInt((Asc(AUX) / 2) - 2))
        Next X
        Return Descriptado
    End Function

    Public Function ObtenerTipoBodega(wLocal As Decimal, wTipo As String) As KeyValuePair(Of Decimal, String)
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim Bod = DC.T_Bodegas.Where(Function(x) x.Local = wLocal)

        If Bod.Any Then
            Select Case wTipo.Trim
                Case "P"
                    Bod = Bod.Where(Function(x) x.Principal = True)
                Case "D"
                    Bod = Bod.Where(Function(x) x.Despacho = True)
                Case "R"
                    Bod = Bod.Where(Function(x) x.Despacho = True)
                Case Else
                    Bod = Bod.Where(Function(x) x.Principal = True)
            End Select
            Return New KeyValuePair(Of Decimal, String)(Bod.First().Bodega, Bod.First().NombreBodega.Trim())
        End If
        Return New KeyValuePair(Of Decimal, String)(0, "")
    End Function

    <Extension>
    Public Sub LoadItemsMaps(ByVal xTabla As C1.Win.C1FlexGrid.C1FlexGrid, wCol As Integer, wTabla As String, wID As String, wDesc As String, Optional wFiltro As String = "")
        Dim dtMap As New ListDictionary()
        Dim wQuery = "SELECT * FROM " & wTabla
        If wFiltro <> "" Then
            wQuery = wQuery & " WHERE " & wFiltro
        End If

        dtMap.Add(0, "")
        Dim wItemsCombo = SQL(wQuery)
        For Each wItem As DataRow In wItemsCombo.Rows
            dtMap.Add(wItem.GetText(wID), wItem.GetText(wDesc))
        Next
        xTabla.Cols(wCol).DataMap = dtMap
    End Sub
    <Extension()>
    Public Sub LoadItemsObj(ByRef wCombobox As ComboBox, wTabla As String, wID As String, wDescripcion As String,
                            Optional wFiltro As String = "", Optional wVacio As Boolean = True, Optional wSinID As String = "0",
                            Optional wSinDesc As String = "")

        Dim wQuery = "SELECT * FROM " & wTabla & ""
        If wFiltro <> "" Then
            wQuery = wQuery & " " & wFiltro
        End If

        Dim wSwap = SQL(wQuery)
        Dim wListaCombo As New List(Of ItemCombo)
        If wSwap.Rows.Count > 0 Then

            If wVacio Then
                wListaCombo.Add(New ItemCombo With {.ID = wSinID, .Desc = wSinDesc})
            Else
                If wSinDesc <> "" Then
                    wListaCombo.Add(New ItemCombo With {.ID = wSinID, .Desc = wSinDesc})
                End If
            End If

            For Each wS As DataRow In wSwap.Rows
                wListaCombo.Add(New ItemCombo With {.ID = wS.GetText(wID).Trim, .Desc = wS.GetText(wDescripcion).Trim})
            Next

            wCombobox.DisplayMember = "Desc"
            wCombobox.ValueMember = "ID"
            wCombobox.DataSource = wListaCombo
        Else
            If wSinDesc <> "" Then
                wListaCombo.Add(New ItemCombo With {.ID = wSinID, .Desc = wSinDesc})
                wCombobox.DisplayMember = "Desc"
                wCombobox.ValueMember = "ID"
                wCombobox.DataSource = wListaCombo
            End If
        End If
    End Sub
    <Extension>
    Public Sub LoadComboGrilla(ByRef wCombobox As ComboBox, wtabla As String, wDisplayMenber As String, wValueMenber As String, Optional wFiltro As String = Nothing)
        Dim Lista As New Dictionary(Of String, String)
        Dim VAL = SQL("SELECT " & wDisplayMenber & "," & wValueMenber & " FROM " & wtabla & " " & wFiltro & "")

        Try
            For Each wV As DataRow In VAL.Rows
                Lista.Add(wV.GetText(wValueMenber), wV.GetText(wDisplayMenber))
            Next
        Catch ex As Exception
        End Try

        wCombobox.ValueMember = "Value"
        wCombobox.DisplayMember = "Key"
        wCombobox.DataSource = Lista.ToArray
    End Sub
    Public Function IniFinFecha(ByVal wModo As Integer, ByVal wFecha As DateTime, Optional ByVal wMesesAdicionales As Integer = 0) As DateTime
        'Fecha con el primer o último día del mes incluido en la fecha ingresada (igual que IniFecha pero devuelve DateTime)
        IniFinFecha = CDate("01/01/3000")
        Select Case wModo
            Case 1 'Inicial
                Return FechaDesde(New DateTime(wFecha.Year, wFecha.Month + wMesesAdicionales, 1))
            Case 2 'Final
                Return FechaHasta(New DateTime(wFecha.Year, wFecha.Month + wMesesAdicionales, 1).AddMonths(1).AddDays(-1))
        End Select
    End Function
    Function FechaHasta(ByVal wFecha As DateTime) As Date
        Return New DateTime(wFecha.Year, wFecha.Month, wFecha.Day, 23, 59, 59)
    End Function

    Function FechaDesde(ByVal wFecha As DateTime) As Date
        Return New DateTime(wFecha.Year, wFecha.Month, wFecha.Day, 0, 0, 0)
    End Function
    <Extension()>
    Public Sub FuenteCelda(ByVal xTabla As C1.Win.C1FlexGrid.C1FlexGrid, ByVal wFila As Integer, ByVal wFondo As Color, ByVal wColor As Color)
        Dim fuente As C1.Win.C1FlexGrid.CellStyle
        fuente = xTabla.Styles.Add("CellFont_" & wColor.ToString)
        fuente.Font = New Font(fuente.Font.FontFamily, fuente.Font.Size, If(fuente.Font.Bold, FontStyle.Bold, FontStyle.Regular))
        fuente.ForeColor = wColor
        fuente.BackColor = wFondo

        For wCol As Integer = 0 To xTabla.Cols.Count - 1
            xTabla.SetCellStyle(wFila, wCol, fuente)
        Next

    End Sub
    <Extension()>
    Public Sub FondoCelda(ByVal xTabla As C1.Win.C1FlexGrid.C1FlexGrid, ByVal wFila As Integer, ByVal wFondo As Color)
        Dim fondo As C1.Win.C1FlexGrid.CellStyle
        fondo = xTabla.Styles.Add("CellBackColor_" & wFondo.ToString)
        fondo.BackColor = wFondo
        For col As Integer = 0 To xTabla.Cols.Count - 1
            xTabla.SetCellStyle(wFila, col, fondo)
        Next col
    End Sub
    <Extension()>
    Public Sub FuenteCelda(ByVal xTabla As C1.Win.C1FlexGrid.C1FlexGrid, ByVal wFila As Integer, ByVal wCol As Integer, ByVal wFondo As Color, ByVal wColor As Color, ByVal wBold As Boolean)
        Dim fuente As C1.Win.C1FlexGrid.CellStyle
        fuente = xTabla.Styles.Add("CellFont_" & wColor.ToString)
        fuente.Font = New Font(fuente.Font.FontFamily, fuente.Font.Size, If(wBold, FontStyle.Bold, FontStyle.Regular))
        fuente.ForeColor = wColor
        fuente.BackColor = wFondo
        xTabla.SetCellStyle(wFila, wCol, fuente)
    End Sub
    Public Function Stocks(wArticulo As Decimal, wBodega As Decimal, wLocal As Decimal, wCantidad As Decimal, wModo As String) As Double
        Try
            Dim DC = New MarketONEDataContext(P_CONEXION)
            'MODIFICACION STOCK
            Dim wStock = DC.T_Stocks.FirstOrDefault(Function(x) x.Articulo = wArticulo.ToDecimal And x.Bodega = wBodega And x.Local = wLocal)
            Dim qStock = New T_Stocks
            If wStock Is Nothing AndAlso wModo = ModoInventario.Crear Then
                Dim wLocales = DC.T_Locales.ToList()
                For Each wLo In wLocales
                    Dim wBods = DC.T_Bodegas.Where(Function(x) x.Local = wLo.Local).ToList()
                    For Each wBod In wBods
                        Dim wCrearStock = DC.T_Stocks.FirstOrDefault(Function(x) x.Articulo = wArticulo And
                                                                              x.Bodega = wBod.Bodega And
                                                                              x.Local = wLo.Local)
                        If wCrearStock Is Nothing Then
                            Dim wS As New T_Stocks With
                        {
                            .Articulo = wArticulo,
                            .Bodega = wBodega,
                            .Local = wLocal,
                            .Stock = 0,
                            .StockMin = 0,
                            .StockMax = 10000
                        }
                            DC.T_Stocks.InsertOnSubmit(wS)
                        End If
                    Next
                Next
                DC.SubmitChanges()
            Else
                If wStock Is Nothing Then
                    Dim wS As New T_Stocks With
                       {
                           .Articulo = wArticulo.ToDecimal,
                           .Bodega = wBodega,
                           .Local = wLocal,
                           .Stock = 0,
                           .StockMin = 0,
                           .StockMax = 10000
                       }
                    DC.T_Stocks.InsertOnSubmit(wS)
                    DC.SubmitChanges()
                    qStock = DC.T_Stocks.FirstOrDefault(Function(x) x.Articulo = wArticulo.ToDecimal And x.Bodega = wBodega And x.Local = wLocal)
                    If qStock IsNot Nothing Then wStock = qStock
                End If

                Select Case wModo
                    Case ModoInventario.Incrementar
                        wStock.Stock += wCantidad
                    Case ModoInventario.Disminuir
                        wStock.Stock -= wCantidad
                    Case ModoInventario.Igualar
                        wStock.Stock = wCantidad
                    Case ModoInventario.Consultar
                        Return wStock.Stock
                End Select
            End If

            DC.SubmitChanges()
        Catch ex As Exception
            MsgError("Error al actualizar inventario" & vbCrLf & "Local: " & wLocal.ToString & vbCrLf & "Bodega: " & wBodega.ToString & vbCrLf & "Articulo: " & wArticulo.ToString & vbCrLf & "Cantidad: " & wCantidad.ToString)
        End Try

        Return 0
    End Function

    Public Function SiguienteCorrelativo(wLocal As Decimal, wTipoDoc As String, wPOS As Decimal) As String
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wCorrelativo = DC.T_Correlativos.FirstOrDefault(Function(x) x.Local = wLocal And x.TipoDoc = wTipoDoc And x.POS = wPOS)
        If wCorrelativo IsNot Nothing Then
            Return (Convert.ToDouble(wCorrelativo.Correlativo) + 1).ToString
        End If
        Return ""
    End Function

    Public Function ActualizarCorrelativo(wLocal As Decimal, wTipoDoc As String, wPOS As Decimal) As Boolean
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wNuevoCorrelativo = DC.T_Correlativos.FirstOrDefault(Function(x) x.Local = wLocal And x.TipoDoc = wTipoDoc And x.POS = wPOS)
        If wNuevoCorrelativo IsNot Nothing Then
            wNuevoCorrelativo.Correlativo = wNuevoCorrelativo.Correlativo + 1
            DC.SubmitChanges()
        End If
        Return False
    End Function

    Public Enum ModoCorrelativo
        Consultar = 0
        Actualizar = 1
    End Enum

    Public Function BuscarCorrelativo(Modo As ModoCorrelativo, TipoDoc As String, Fecha As DateTime, Optional POS As Decimal = 0) As Double
        Dim Correlativo As Double = 0
        Dim DC = New MarketONEDataContext(P_CONEXION)

        If POS = 0 Then
            POS = G_LOCALACTUAL
        End If

        Dim Cor = DC.T_Correlativos.FirstOrDefault(Function(x) x.Local = G_LOCALACTUAL And x.TipoDoc = TipoDoc And x.POS = POS)

        If TipoDoc = "" Then
            MsgError("No se ha especificado un tipo de documento", "Error al obtener correlativo")
        End If

        If Cor Is Nothing Then
            MsgError("No existe correlativo para" & vbCrLf & "Local: " & G_LOCALACTUAL & vbCrLf & "Documento: " & TipoDoc, "Error al obtener correlativo")
            Return 0
        Else
            If Fecha.Date < Cor.FechaCAF.Date Then
                MsgError("Fecha del documento fuera del rango permitido en CAF", "Error al obtener correlativo")
                Return 0
            End If
            If Fecha.Date > Cor.FechaCAF.AddMonths(6).Date Then
                MsgError("Fecha de CAF vencido", "Error al obtener correlativo")
                Return 0
            End If
            If Cor.Correlativo < Cor.Inicial Or Cor.Correlativo > Cor.Final Then
                MsgError("Correlativo Fuera de Rango" & vbCrLf & "Local: " & G_LOCALACTUAL & vbCrLf & "Documento: " & TipoDoc, "Error al obtener correlativo")
                Return 0
            End If

            Correlativo = Cor.Correlativo
            If Modo = ModoCorrelativo.Actualizar Then
                Cor.Correlativo = Cor.Correlativo + 1
                DC.SubmitChanges()
            End If

            Return Val(Correlativo)
        End If
    End Function

    Public Sub LimpiarCampos(ByVal wForm As Control, Optional wDescartar As String = "")
        Dim wControl As Control
        For Each wControl In wForm.Controls
            If (wControl.HasChildren) And Not (TypeOf wControl Is NumericUpDown) Then
                LimpiarCampos(wControl, wDescartar)
            Else

                If (TypeOf wControl Is TextBox) And wDescartar <> wControl.Name Then
                    wControl.Text = ""
                End If
                If (TypeOf wControl Is TextBoxAutoComple) And wDescartar <> wControl.Name Then
                    wControl.Text = ""
                End If
                If (TypeOf wControl Is ComboBox) And wDescartar <> wControl.Name Then
                    Dim wCombo As ComboBox = CType(wControl, ComboBox)
                    If wCombo.Items.Count > 0 Then
                        wCombo.SelectedIndex = -1
                    End If
                End If
                If (TypeOf wControl Is CheckBox) And wDescartar <> wControl.Name Then
                    Dim wCheck As CheckBox = CType(wControl, CheckBox)
                    wCheck.Checked = False
                End If
                If (TypeOf wControl Is MaskedTextBox) And wDescartar <> wControl.Name Then
                    Dim wMaskText As MaskedTextBox = CType(wControl, MaskedTextBox)
                    wMaskText.Clear()
                End If

                If (TypeOf wControl Is NumericUpDown) And wDescartar <> wControl.Name Then
                    Dim wNumUpDo As NumericUpDown = CType(wControl, NumericUpDown)
                    wNumUpDo.Value = wNumUpDo.Minimum
                End If

                'If (TypeOf wControl Is PictureBox) And wDescartar <> wControl.Name Then
                '    Dim wPictureBox As PictureBox = CType(wControl, PictureBox)
                '    wPictureBox.Image = Nothing
                'End If
            End If
        Next
    End Sub
    Public Function CalcularNETO(wPrecio As Decimal) As Decimal
        'Esta Funcion no calcula los impuestos por ahora
        'Return wPrecio / (1 + (gIVA / 100))
        Return Math.Round(wPrecio / (1 + (G_IVA / 100)), 0, MidpointRounding.AwayFromZero)
    End Function
    Public Function BuscarCiudad(wCiudad As String) As String
        If wCiudad = "" Then
            Return ""
        End If
        Dim wCiu = SQL("Select NombreComuna from Comunas where Codigo = '" & wCiudad & "'").Top
        If wCiu IsNot Nothing Then
            Return wCiu.GetText("NombreComuna")
        Else
            Return wCiudad
        End If
    End Function
    Public Function BuscarComuna(wComuna As String) As String
        If wComuna = "" Then
            Return ""
        End If
        Dim wCom = SQL("Select NombreComuna from Comunas where Codigo = '" & wComuna & "'").Top
        If wCom IsNot Nothing Then
            Return wCom.GetText("NombreComuna")
        Else
            Return wComuna
        End If
    End Function


    Public Function ObtenerArticulo(wDato As String) As String
        If wDato.Trim = "" Then Return ""

        'Buscar su es articulo Pesable
        If (Mid(wDato, 1, 2) = "24" Or Mid(wDato, 1, 2) = "25") And Len(wDato) = 13 Then
            If Val(Mid(wDato, 3, 5)) > 0 Then
                wDato = Mid(wDato, 3, 5)
            End If
        End If

        'Buscar por Artículo
        Dim DC = New MarketONEDataContext(P_CONEXION)
        If IsNumeric(wDato) Then
            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = Val(wDato))
            If wArt IsNot Nothing Then
                Return wArt.Articulo.ToString
            End If
        End If

        'Buscar por Barra
        Dim wBarr = DC.T_Barras.FirstOrDefault(Function(x) x.Barra = wDato.Trim)
        If wBarr IsNot Nothing Then
            Return wBarr.Articulo.ToString
        End If

        'Buscar  por SKU
        Dim wSKU = DC.T_Articulos.FirstOrDefault(Function(x) x.SKU = wDato.ToString)
        If wSKU IsNot Nothing Then
            Return wSKU.Articulo.ToString
        End If

        Return ""
    End Function

    Public Function ParametroReporte() As List(Of ParametrosReporte)
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim wPar = DC.T_Parametros.FirstOrDefault()

        If wPar IsNot Nothing Then
            Dim wLista = New List(Of ParametrosReporte)
            wLista.Add(New ParametrosReporte With {.Logo = wPar.Logo1})
            Return wLista
        End If
        Return Nothing
    End Function
    Public Function ParametroLocal() As List(Of ParametrosLocal)
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wComunas = DC.T_Comunas.ToList()
        Dim wParLocal = DC.T_Locales.Where(Function(x) x.Local = G_LOCALACTUAL) _
                                     .Select(Function(x) New ParametrosLocal With {.Local = x.Local,
                                                           .NombreLocal = x.NombreLocal,
                                                           .RazonLocal = x.RazonLocal,
                                                           .GiroLocal = x.GiroLocal,
                                                           .DirLocal = x.DirLocal,
                                                           .Comuna = x.Comuna,
                                                           .RutLocal = x.RutLocal,
                                                           .Logo = x.Logo,
                                                           .HorarioLocal = x.HorarioLocal,
                                                           .TelefonosLocal = x.TelefonosLocal,
                                                           .EMailLocal = x.EMailLocal,
                                                           .RedSocial1 = x.RedSocial1,
                                                           .RedSocial2 = x.RedSocial2}).ToList

        If wComunas.Any Then
            wParLocal.First().NombreComuna = wComunas.FirstOrDefault(Function(x) x.Codigo = wParLocal.First().Comuna).NombreComuna
        Else
            wParLocal.First().NombreComuna = "SIN COMUNA"
        End If
        If wParLocal.Any Then
            Return wParLocal
        End If
        Return Nothing
    End Function

    Public Sub Imprimir_Documento(wLocal As Double, wTipoDoc As String, wNumDoc As Double, wDescTipoDoc As String, wCopias As List(Of Integer))
        Dim Lista = New List(Of DTE_Documentos)
        G_TIPOCOPIA = New List(Of Integer)
        Try
            Dim wDTE_DOCUMENTO = SQL("SELECT g.Local, g.TipoDoc, g.Numero, g.Fecha, g.OC, g.Cliente,isnull(DR.TipoDocRef,'') as TipoDocRef," &
                " isnull(DR.NumDocRef,0) as NumDocRef,isnull(DR.FechaRef,'') as FechaRef,isnull(r.DescTipoDoc,'') as DescTipoDocRef, " &
                " g.Observaciones, g.Descuento,g.Abonado, g.Neto, g.IVA, g.Total, d.Articulo, m.DescMotivo,  d.Cantidad,  " &
                " d.Neto As Precio, Coalesce(d.Neto,0) as PVenta, d.Glosa, l.NombreLocal, l.RazonLocal, l.RutLocal, l.GiroLocal, l.DirLocal, l.EMailLocal, " &
                " l.TelefonosLocal, l.HorarioLocal, l.SII, l.NResolucion, l.BancoDeposito, l.CuentaDeposito, l.RutDeposito, l.TitularDeposito, l.CorreoDeposito, " &
                " l.FResolucion, col.NombreComuna as NombreComuna, a.Descripcion, u.DescUnidad, t.DescTipoDoc , c.Nombre, c.Fantasia, " &
                " c.Rut, c.Direccion, c.Giro, c.Telefonos, c.Contacto, c.Email, f.FPago, f.DescFPago, " &
                " co.NombreComuna AS ComunaCli, isNull(r.DescTipoDoc,'') as DescTipoDocRef  " &
                " FROM DocumentosG AS g" &
                " INNER JOIN DocumentosD AS d ON g.Local = d.Local And g.TipoDoc = d.TipoDoc And g.Numero = d.Numero " &
                " INNER JOIN Locales As l On g.Local = l.Local " &
                " INNER JOIN Articulos AS a ON d.Articulo = a.Articulo " &
                " INNER JOIN Unidades AS u ON a.Unidad = u.Unidad " &
                " INNER JOIN TipoDoc AS t ON g.TipoDoc = t.TipoDoc" &
                " INNER JOIN Clientes AS c ON g.Cliente = c.Cliente " &
                " INNER JOIN FPagos AS f ON g.FPago = f.FPago " &
                " LEFT JOIN Comunas AS co ON c.Comuna = co.Codigo " &
                " LEFT JOIN Comunas AS col ON l.Comuna = col.Codigo " &
                " LEFT JOIN Motivos AS M ON g.Motivo = M.Motivo And M.TipoDoc = G.TipoDoc" &
                " LEFT JOIN DocumentosR AS DR ON g.Numero = DR.Numero" &
                " LEFT JOIN TipoDoc AS r on r.TipoDoc = DR.TipoDocRef  " &
                " WHERE g.Local=" & Val(wLocal) & " And g.TipoDoc='" & wTipoDoc & "' And g.Numero=" & Val(wNumDoc))


            For i = 1 To wCopias.Count
                For Each wD As DataRow In wDTE_DOCUMENTO.Rows
                    Lista.Add(New DTE_Documentos With {
                            .Local = wD.GetText("Local"),
                            .RutLocal = wD.GetText("RutLocal"),
                            .NombreLocal = wD.GetText("NombreLocal"),
                            .RazonLocal = wD.GetText("RazonLocal"),
                            .GiroLocal = wD.GetText("GiroLocal"),
                            .DireccionLocal = wD.GetText("DirLocal"),
                            .CiudadLocal = wD.GetText("NombreComuna"),
                            .ComunaLocal = wD.GetText("NombreComuna"),
                            .EmailLocal = wD.GetText("EMailLocal"),
                            .FonoLocal = wD.GetText("TelefonosLocal"),
                            .Horarios = wD.GetText("HorarioLocal"),
                            .SII = wD.GetText("SII"),
                            .BancoDeposito = wD.GetText("BancoDeposito"),
                            .CuentaDeposito = wD.GetText("CuentaDeposito"),
                            .RutDeposito = wD.GetText("RutDeposito"),
                            .TitularDeposito = wD.GetText("TitularDeposito"),
                            .CorreoDeposito = wD.GetText("CorreoDeposito"),
                            .TipoDoc = wD.GetText("TipoDoc"),
                            .DescTipoDoc = wDescTipoDoc,
                            .Numero = Val(wD.GetText("Numero")),
                            .Fecha = CDate(wD.GetText("Fecha")),
                            .Cliente = Val(wD.GetText("Cliente")),
                            .Rut = wD.GetText("Rut"),
                            .Nombre = wD.GetText("Nombre"),
                            .Direccion = wD.GetText("Direccion"),
                            .Giro = wD.GetText("Giro"),
                            .Ciudad = wD.GetText("ComunaCli"),
                            .Comuna = wD.GetText("ComunaCli"),
                            .Telefono = wD.GetText("Telefonos"),
                            .Contacto = wD.GetText("Contacto"),
                            .Correo = wD.GetText("EMail"),
                            .FPago = wD.GetText("DescFPago"),
                            .OC = wD.GetText("OC"),
                            .Motivo = wD.GetText("DescMotivo"),
                            .TipoDocRef = wD.GetText("TipoDocRef"),
                            .DescTipoDocRef = wD.GetText("DescTipoDocRef"),
                            .NumTipoDocRef = wD.GetText("NumDocRef"),
                            .FechaTipoDocRef = Mid(wD.GetText("FechaRef"), 1, 10),
                            .Observaciones = wD.GetText("Observaciones"),
                            .Articulo = wD.GetText("Articulo"),
                            .Descripcion = wD.GetText("Descripcion"),
                            .Glosa = wD.GetText("Glosa"),
                            .Barra = "",
                            .Unidad = wD.GetText("DescUnidad"),
                            .Cantidad = Val(wD.GetText("Cantidad")),
                            .Precio = Val(wD.GetText("Precio")),
                            .PVenta = Val(wD.GetText("PVenta")),
                            .Neto = Val(wD.GetText("Neto")),
                            .Descuento = Val(wD.GetText("Descuento")),
                            .IVA = Val(wD.GetText("IVA")),
                            .Total = wD.GetDecimal("Total") + wD.GetDecimal("Descuento") + wD.GetDecimal("Abonado"),
                            .NResolucion = Val(wD.GetText("NResolucion")),
                            .FResolucion = CDate(wD.GetText("FResolucion")),
                            .Grupo = wCopias(i - 1)})
                Next
            Next
            Dim wFir As New List(Of FirmaDocumento)
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wFirma = DC.T_DocumentosG.FirstOrDefault(Function(x) x.Numero = Val(wNumDoc) And
                                                                      x.TipoDoc = wTipoDoc)
            If wFirma IsNot Nothing Then wFir.Add(New FirmaDocumento With {.Firma = wFirma.Firma})
            Dim ListLocal = ParametroLocal()

            If Lista.Count > 0 Then
                Dim wReporte = New Documentos_DTE
                wReporte.Database.Tables("SisVen_DTE_Documentos").SetDataSource(Lista)
                wReporte.Database.Tables("SisVen_LocalesReporte").SetDataSource(ListLocal)
                wReporte.Database.Tables("SisVen_DocumentosG").SetDataSource(wFir)
                wReporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, DTE.Ruta_Archivo_Fiscal(gPDF, G_LOCALACTUAL, wTipoDoc, Val(wNumDoc), 0))
                VisorReportes.MostrarReporte(wReporte)
                VisorReportes.WinDeco1.TituloVentana = wDescTipoDoc & " " & wNumDoc
                VisorReportes.Show()
                VisorReportes.BringToFront()
            Else
                MsgError("Error al Generar el Documento")
            End If
        Catch ex As Exception
            If G_ACCESOUSUARIO = 9 Then
                MsgError(ex.Message)
            End If
        End Try
    End Sub

    Public Enum DocumentoPago
        Boleta
        Factura
    End Enum

    Public Sub ImprimirDocumento(wNumdoc As Decimal, wTipoDoc As DocumentoPago, Optional wCantidadCopia As Decimal = 1)

        Try

            Dim Efectivo = False
            Dim wPageMargins = New CrystalDecisions.Shared.PageMargins With {
                            .bottomMargin = 2, '2
                            .leftMargin = 0,
                            .rightMargin = 0,
                            .topMargin = -0
                        }

            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wArticulos = DC.T_Articulos.ToList()

            Select Case wTipoDoc
                Case DocumentoPago.Boleta
                    Try
                        Dim wEncabezado = New ReporteEncabezadoDocumento(wNumdoc, wTipoDoc)
                        Efectivo = wEncabezado.Efectivo

                        Dim wParametros = New DocumentoReporte()
                        Dim wDetalleDocumento = DC.T_DocumentosD.Where(Function(x) x.Numero = wNumdoc And x.TipoDoc = "BV")
                        Dim wDetalle = New List(Of ReporteDetalleDocumento)

                        For Each wD In wDetalleDocumento
                            Dim wDescripcion = wArticulos.FirstOrDefault(Function(x) x.Articulo = wD.Articulo)
                            wDetalle.Add(New ReporteDetalleDocumento With {
                            .Articulo = If(wDescripcion IsNot Nothing, wDescripcion.Descripcion, ""),
                            .Boleta = wD.Numero,
                            .Cantidad = Convert.ToDecimal(wD.Cantidad),
                            .PrecioUnidad = Convert.ToDecimal(wD.PVenta),
                            .Total = Convert.ToDecimal(wD.Cantidad * wD.PVenta)})
                        Next


                        Dim wDetallePago = New List(Of DetallePagosDoc)
                        Dim wFPagos = DC.T_DocumentosP.Where(Function(x) x.Numero = wNumdoc And x.TipoDoc = "BV").ToList
                        Dim wFormaPago = DC.T_FPagos.ToList()

                        For Each wFPago In wFPagos.GroupBy(Function(x) x.FPago)
                            Dim wDescripcion = wFormaPago.FirstOrDefault(Function(x) x.FPago = wFPago.First().FPago)
                            wDetallePago.Add(New DetallePagosDoc With
                                         {.DescripcionPago = If(wDescripcion IsNot Nothing, wDescripcion.DescFPago, ""),
                                         .MontoPago = wFPago.Sum(Function(x) Math.Abs(x.Monto))})
                        Next


                        Dim wReporte = New ReporteBoleta

                        'Dim wReporte = New ReportClass
                        'If wEncabezado.Rut = "66.666.666-6" Then
                        '    wReporte = New ReporteBoletaSinCliente
                        'Else

                        'End If

                        wReporte.PrintOptions.PrinterName = P_IMPRESORAVOUCHER
                        wReporte.Subreports(0).SetDataSource(wDetallePago)
                        wReporte.Database.Tables("ReporteDetalleDocumento").SetDataSource(wDetalle)
                        wReporte.Database.Tables("ReporteImprimirDocumento").SetDataSource({wParametros}.ToList)
                        wReporte.Database.Tables("ReporteEncabezadoDocumento").SetDataSource({wEncabezado}.ToList)
                        wReporte.PrintOptions.ApplyPageMargins(wPageMargins)
                        'VisorReportes.Visor.ReportSource = wReporte
                        'VisorReportes.Show()

                        If wCantidadCopia > 1 Then
                            For i = 1 To wCantidadCopia
                                wReporte.PrintToPrinter(1, False, 0, 0)
                            Next
                        Else
                            wReporte.PrintToPrinter(1, False, 0, 0)
                        End If


                        wReporte.Close()
                        wReporte.Dispose()
                    Catch ex As Exception
                        Mensaje("Error al Re-Imprimir Boleta")
                    End Try

                Case DocumentoPago.Factura

                    'Dim wEncabezado = New ReporteEncabezadoDocumento(wNumdoc, wTipoDoc)
                    'Efectivo = wEncabezado.Efectivo

                    'If Efectivo AndAlso P_GAVETA_AUTOMATICA AndAlso AbrirGaveta Then
                    '    Principal.AbrirGaveta()
                    'End If

                    'Dim wParametrosDocumento = New DocumentoReporte()
                    'Dim wDetalleDocumento = DC.T_FvDet.Where(Function(x) x.Factura = wNumdoc)
                    'Dim wDetalleBoleta = New List(Of ReporteDetalleDocumento)
                    'For Each wDetalle In wDetalleDocumento
                    '    wDetalleBoleta.Add(New ReporteDetalleDocumento With {
                    '        .Articulo = wDetalle.Descripcion,
                    '        .Boleta = wDetalle.Factura,
                    '        .Cantidad = wDetalle.CantiFac,
                    '        .PrecioUnidad = wDetalle.PrecioFac,
                    '        .Total = wDetalle.CantiFac * wDetalle.PrecioFac,
                    '        .Impuesto = 19})
                    'Next

                    'Dim wReporte = New ReporteBoleta

                    'Dim wDetallePago = New List(Of DetallePagosDoc)
                    'Dim wFPagos = DC.T_Caja.Where(Function(x) x.NumDoc = wNumdoc).ToList()

                    'wFPagos.ForEach(Sub(x)
                    '                    If x.Serie = "VUELTO" Then x.Tipo = "VUELTO"
                    '                End Sub)

                    'For Each wFPago In wFPagos.GroupBy(Function(x) x.Tipo)
                    '    wDetallePago.Add(New DetallePagosDoc With
                    '                     {.DescripcionPago = wFPago.First().Tipo,
                    '                     .MontoPago = wFPago.Sum(Function(x) Math.Abs(x.Monto))})
                    'Next

                    'If P_COPIACLIENTE Then
                    '    wReporte = New ReporteBoleta
                    '    wEncabezado.TipoCopia = "COPIA CLIENTE"
                    '    wReporte.Subreports(0).SetDataSource(wDetallePago)
                    '    wReporte.Database.Tables("ReporteDetalleDocumento").SetDataSource(wDetalleBoleta)
                    '    wReporte.Database.Tables("ReporteImprimirDocumento").SetDataSource({wParametrosDocumento}.ToList)
                    '    wReporte.Database.Tables("ReporteEncabezadoDocumento").SetDataSource({wEncabezado}.ToList)
                    '    wReporte.PrintOptions.ApplyPageMargins(wPageMargins)
                    '    'wReporte.PrintOptions.NoPrinter = False
                    '    'wReporte.PrintOptions.DissociatePageSizeAndPrinterPaperSize = True
                    '    'wReporte.PrintOptions.PrinterName = "EPSON TM-T20II Receipt"
                    '    wReporte.PrintToPrinter(1, False, 0, 0)

                    '    wReporte.Close()
                    '    wReporte.Dispose()
                    'End If
                    'If P_COPIATRIBUTARIO Then
                    '    wReporte = New ReporteBoleta
                    '    wEncabezado.TipoCopia = "CONTROL TRIBUTARIO"
                    '    wReporte.Subreports(0).SetDataSource(wDetallePago)
                    '    wReporte.Database.Tables("ReporteDetalleDocumento").SetDataSource(wDetalleBoleta)
                    '    wReporte.Database.Tables("ReporteImprimirDocumento").SetDataSource({wParametrosDocumento}.ToList)
                    '    wReporte.Database.Tables("ReporteEncabezadoDocumento").SetDataSource({wEncabezado}.ToList)
                    '    wReporte.PrintOptions.ApplyPageMargins(wPageMargins)
                    '    'wReporte.PrintOptions.NoPrinter = False
                    '    'wReporte.PrintOptions.DissociatePageSizeAndPrinterPaperSize = True
                    '    'wReporte.PrintOptions.PrinterName = "EPSON TM-T20II Receipt"

                    '    wReporte.PrintToPrinter(1, False, 0, 0)

                    '    wReporte.Close()
                    '    wReporte.Dispose()
                    'End If
                    'If P_COPIACEDIBLE Then
                    '    Dim wReporteCedible = New ReporteFVCedible
                    '    wEncabezado.TipoCopia = "CEDIBLE"
                    '    wReporteCedible.Subreports(0).SetDataSource(wDetallePago)
                    '    wReporteCedible.Database.Tables("ReporteDetalleDocumento").SetDataSource(wDetalleBoleta)
                    '    wReporteCedible.Database.Tables("ReporteImprimirDocumento").SetDataSource({wParametrosDocumento}.ToList)
                    '    wReporteCedible.Database.Tables("ReporteEncabezadoDocumento").SetDataSource({wEncabezado}.ToList)
                    '    wReporteCedible.PrintOptions.ApplyPageMargins(wPageMargins)
                    '    'wReporteCedible.PrintOptions.ApplyPageMargins(wPageMargins)
                    '    'wReporte.PrintOptions.PaperSize =
                    '    'wReporteCedible.PrintOptions.NoPrinter = False
                    '    'wReporteCedible.PrintOptions.DissociatePageSizeAndPrinterPaperSize = True
                    '    'wReporteCedible.PrintOptions.PrinterName = "EPSON TM-T20II Receipt"
                    '    wReporteCedible.PrintToPrinter(1, False, 0, 0)

                    '    wReporteCedible.Close()
                    '    wReporteCedible.Dispose()
                    'End If
            End Select



        Catch ex As Exception
            MsgError("Ha ocurrido una excepción al intentar imprimir." & vbCrLf & ex.ToString() & "Error de impresión")
        End Try

    End Sub

    Function Estatus_Impresora(wImpresora As String) As Boolean
        Dim iDoc As New PrintDocument
        Dim Impresoras As String

        ' recorre las impresoras instaladas  
        For Each Impresoras In PrinterSettings.InstalledPrinters
            If wImpresora = Mid(Impresoras.ToString, 1, Len(wImpresora)) Then
                Return True
            End If
        Next

        Return False
    End Function


    Public Sub MostrarMenuCopiar(ByRef xTabla As C1.Win.C1FlexGrid.C1FlexGrid, ByRef wUbicacion As Point, ByRef mMenu As ContextMenuStrip, ByRef bCopiar As ToolStripMenuItem)
        Dim wData As String
        Dim wHit As C1.Win.C1FlexGrid.HitTestInfo = xTabla.HitTest(wUbicacion)
        xTabla.Row = wHit.Row
        xTabla.Col = wHit.Column

        If xTabla.Row < 1 Then Exit Sub
        If xTabla.GetData(xTabla.Row, xTabla.Col) Is Nothing Then
            wData = ""
        Else
            wData = xTabla.GetData(xTabla.Row, xTabla.Col).ToString.Trim
            If wData = "True" Or wData = "False" Then
                wData = ""
            End If
        End If
        If wData <> "" Then
            bCopiar.Text = "Copiar " & wData.Trim.Substring(0, If(wData.Length > 22, 22, wData.Length))
            bCopiar.Tag = wData.Trim
            mMenu.Show(xTabla, wHit.Point)
        End If
    End Sub
    <Extension()>
    Public Sub AjustarColumnas(ByVal xTabla As C1.Win.C1FlexGrid.C1FlexGrid)
        For col As Integer = 0 To xTabla.Cols.Count - 1

            If xTabla.Cols(col).Width > 0 Then
                xTabla.AutoSizeCol(col)
            Else
                xTabla.Cols(col).Width = 0
            End If
        Next col
    End Sub
    Private ReadOnly onValidating As MethodInfo = GetType(Control).GetMethod("OnValidating", BindingFlags.Instance Or BindingFlags.NonPublic)
    Private ReadOnly onValidated As MethodInfo = GetType(Control).GetMethod("OnValidated", BindingFlags.Instance Or BindingFlags.NonPublic)

    <System.Runtime.CompilerServices.Extension>
    Public Function Validate(control As Control) As Boolean
        Dim e As New CancelEventArgs()
        onValidating.Invoke(control, New Object() {e})
        If e.Cancel Then
            Return False
        End If
        onValidated.Invoke(control, New Object() {EventArgs.Empty})
        Return True
    End Function

    'Private ReadOnly onClick As MethodInfo = GetType(Control).GetMethod("OnClick", BindingFlags.Instance Or BindingFlags.NonPublic)
    '<Extension>
    'Public Function Click(control As Control) As Boolean
    '    Dim e As New CancelEventArgs()
    '    onClick.Invoke(control, New Object() {e})
    '    If e.Cancel Then
    '        Return False
    '    End If
    '    onClick.Invoke(control, New Object() {EventArgs.Empty})
    'End Function
    Public Function ObtenerListado(wTabla As String, wCampo1 As String, wCampo2 As String, wCaracter As String, Optional wFiltro As String = " 1=1 ") As String()
        Dim wCampo = wCampo1 & " + ' " & wCaracter & " ' + " & wCampo2

        Dim wPaso = SQL("SET NOCOUNT ON DECLARE @Valor VarChar(MAX) = ''     " &
                "SELECT @Valor =  " &
                "CASE WHEN @Valor = '' " &
                "THEN COALESCE(rtrim(" & wCampo1 & "), '') " &
                "ELSE @Valor + COALESCE(',' + rtrim(" & wCampo1 & "), '') " &
                "END " &
                "FROM (SELECT Distinct CAST(" & wCampo1 & " AS VARCHAR) " & " + ' " & wCaracter & " ' + CAST(" & wCampo2 & " AS VARCHAR) AS " & wCampo1 &
                " FROM " & wTabla & " WHERE " & wFiltro & " ) Tab " &
                "SELECT @Valor as Valor")

        Dim wResultado As String = wPaso.Top(0).ToString()
        Dim wArray = wResultado.Split(CChar("~")).ToList()
        Return wResultado.Split(CChar("~")).Select(Function(x) x.Trim).OrderBy(Function(x) x).ToArray

    End Function
    Public Sub DoEvents()
        Application.DoEvents()
    End Sub
    Public Function Abrir_Documento(wArchivo As String) As Boolean
        Dim exeArchivo As New ProcessStartInfo
        Dim Proceso As New Process
        exeArchivo.FileName = wArchivo
        Try
            Proceso = Process.Start(exeArchivo)
            Abrir_Documento = True
        Catch Ex As Exception
            Abrir_Documento = False
            MsgError("Error al abrir archivo:" + vbCrLf + wArchivo + vbCrLf + Ex.Message)
        End Try
    End Function

    Public Function SiguienteCorrelativo(ByVal wTabla As String) As Double
        Dim wCor = SQL("SELECT (IDENT_CURRENT('" & wTabla & "') + IDENT_INCR('" & wTabla & "')) AS Correlativo").Top
        If wCor IsNot Nothing Then
            Return wCor.GetInt("CORRELATIVO")
        Else
            Return 0
        End If
    End Function
    Public Function SiguienteCorrelativo(ByVal wTabla As String, ByVal wClave As String) As Double
        Dim wCorr = SQL("SELECT TOP 1(" & wClave & " + 1) AS ID FROM " & wTabla & " T1 " &
           "WHERE NOT EXISTS (SELECT * FROM " & wTabla & " T2  " &
           "WHERE T1." & wClave & " + 1 = T2." & wClave & ") " &
           "ORDER BY ID ASC").Top
        If wCorr Is Nothing Then
            Return 0
        Else
            Return wCorr.GetNum("ID")
        End If
    End Function

    Public Function VerificarRut(ByVal Rut As String) As Boolean

        Rut = FormatoRut(Rut)
        Rut = Rut.Replace(",", "").Replace(".", "").Replace(" ", "").Trim()

        If Rut = "" OrElse Not Rut.Contains("-") OrElse Rut.Length < 9 OrElse Rut.Length > 10 Then
            Return False
        End If

        Dim arr As Char() = Rut.Substring(0, Rut.IndexOf("-"c)).ToCharArray()
        Array.Reverse(arr)
        Dim val = New String(arr)
        Dim dig = Rut.Substring(Rut.IndexOf("-"c) + 1, 1).ToUpper()
        Dim mul = 2
        Dim total = 0D

        For i = 0 To val.Length - 1
            total += Convert.ToInt32(val.Substring(i, 1)) * mul
            mul += 1

            If mul = 8 Then
                mul = 2
            End If
        Next

        Dim result = (11 - (total Mod 11)).ToString()

        If result = "10" Then
            result = "K"
        End If

        If result = "11" Then
            result = "0"
        End If

        Return (dig = result)
    End Function

    Public Function FormatoRut(ByVal Rut As String) As String
        Rut = Rut.Replace(" ", "").Replace("-", "").Replace(".", "")

        If Rut = "" OrElse Rut.Length < 8 Then
            Return ""
        End If

        If Rut.Length > 9 Then
            Return ""
        End If

        Dim n As Decimal = Nothing

        If Not Decimal.TryParse(Rut.Substring(0, Rut.Length - 1), n) Then
            Return ""
        End If

        Rut = Convert.ToDecimal(Rut.Substring(0, Rut.Length - 1)).ToString("#,##0").Replace(",", ".") & "-" & Rut.Substring(Rut.Length - 1)

        If Rut.Length < 12 Then
            Rut = Rut.PadLeft(12, "0"c)
        End If

        Return Rut
    End Function

    Public Function Formatea_Rut(ByVal wRut As String, Optional wModo As Integer = 0) As String
        'Formato Modo=0  12345678-9         Modo=1  12.345.678-9
        Dim wFormato As String
        wFormato = Trim(wRut)
        wFormato = Replace(wFormato, ".", "")
        wFormato = Replace(wFormato, " ", "")
        wFormato = "000000000000" + wFormato
        wFormato = Right(wFormato, 10)
        If wModo <> 0 Then
            Return Mid(wFormato, 1, 2) + "." + Mid(wFormato, 3, 3) + "." + Mid(wFormato, 6, 3) + "-" + Mid(wFormato, 10, 1)
        End If
        Return (wFormato)
    End Function

    Public Function ValidarEliminar(ByVal wCampo As String, ByVal wClave As String, ByVal wTabla As String) As Boolean

        Dim wTabs = SQL("SELECT  sysobjects.name AS table_name FROM sysobjects INNER JOIN syscolumns ON sysobjects.id = syscolumns.id " &
                         "INNER JOIN systypes ON syscolumns.xtype = systypes.xtype WHERE (sysobjects.xtype = 'U')  and " &
                         "(UPPER(syscolumns.name) = upper('" & wCampo & "'))")

        For Each wT As DataRow In wTabs.Rows
            If wT.GetText("table_name") <> wTabla Then
                Dim val = SQL("SELECT " & wCampo & " FROM " & wT.GetText("table_name") & " WHERE " & wCampo & " = '" & wClave & "'").Top
                If val IsNot Nothing Then
                    Return True
                    Exit Function
                End If
            End If
        Next

        Return False
    End Function
    <Extension>
    Public Sub AñosMes(ByVal wCombobox As ComboBox, ByVal wTipo As String)
        Dim wFila = 1
        Dim wLista As New Dictionary(Of String, String)
        wLista.Add("", "0")

        If wTipo = "A" Then
            wLista.Add(Year(Now()).ToString, Now.Year.ToString)
            wLista.Add((Year(Now()) - 1).ToString, Now.AddYears(-1).ToString)
        ElseIf wTipo = "M" Then
            Dim datetimeFormat = Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat
            For Each wMes In datetimeFormat.MonthNames()
                If wFila = 13 Then Exit For
                wLista.Add(wMes.ToUpper, wFila.ToString)
                wFila += 1
            Next
        End If

        wCombobox.ValueMember = "Value"
        wCombobox.DisplayMember = "Key"
        wCombobox.DataSource = wLista.ToArray
    End Sub
    Public Function Crypt(ByRef pCadena As String) As String
        Dim Descriptado As String, AUX As String
        Dim X As Integer

        pCadena = Trim(pCadena)
        Descriptado = ""
        AUX = " "
        For X = 1 To Len(pCadena)
            AUX = Mid(pCadena, X, 1)
            Descriptado = Descriptado + Chr((Asc(AUX) + 2) * 2)
        Next X
        Return Descriptado
    End Function

    Public Function ImagenArray(ByVal wImagen As Image) As Array
        Dim msQr As New MemoryStream
        Dim arrQr() As Byte
        wImagen.Save(msQr, wImagen.RawFormat)
        arrQr = msQr.GetBuffer
        Return arrQr
    End Function

    Public Function ArrayImagen(ByVal wArray() As Byte) As Image
        Try
            Dim MatrizImagen() As Byte = CType(wArray, Byte())
            Dim ImagenMemoria As New IO.MemoryStream(MatrizImagen)
            Return Image.FromStream(ImagenMemoria)
        Catch ex As Exception
            'No se pudo cargar la imagen
        End Try
    End Function

    <Extension()>
    Public Function BuscarFila(ByVal xTabla As C1.Win.C1FlexGrid.C1FlexGrid, wTexto As String, wColumna As Integer, Optional wInicio As Integer = 0) As Integer
        For wFila As Integer = wInicio To xTabla.Rows.Count - 1
            If xTabla.GetData(wFila, wColumna).ToString.ToLower.QuitarTildes.Contains(wTexto.ToLower.QuitarTildes) Then
                Return wFila
                Exit Function
            End If
        Next
        Return -1
    End Function

    <Extension()>
    Public Function SumarFilas(ByVal xTabla As C1.Win.C1FlexGrid.C1FlexGrid, wTexto As String, wColumnaComprar As Integer, wColumnaSumar As Integer, Optional wInicio As Integer = 0) As Decimal
        Dim wCantidad As Decimal = 0
        For wFila As Integer = wInicio To xTabla.Rows.Count - 1
            If xTabla.GetData(wFila, wColumnaComprar).ToString = wTexto Then
                wCantidad = xTabla.GetData(wFila, wColumnaSumar).ToString.ToDecimal
            End If
        Next
        Return wCantidad
    End Function
    <Extension()>
    Function QuitarTildes(ByVal wTexto As String) As String

        wTexto = Replace(wTexto, "Á", "A")
        wTexto = Replace(wTexto, "É", "E")
        wTexto = Replace(wTexto, "Í", "I")
        wTexto = Replace(wTexto, "Ó", "O")
        wTexto = Replace(wTexto, "Ú", "U")

        wTexto = Replace(wTexto, "á", "a")
        wTexto = Replace(wTexto, "é", "e")
        wTexto = Replace(wTexto, "í", "i")
        wTexto = Replace(wTexto, "ó", "o")
        wTexto = Replace(wTexto, "ú", "u")

        If wTexto Is Nothing Then wTexto = ""
        Return wTexto
    End Function
    Public Function CambiarCorrelativo(wLocal As Decimal, wPOS As Integer, wTipoDoc As String) As Double
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim wCor = DC.T_Correlativos.FirstOrDefault(Function(x) x.Local = wLocal And x.POS = wPOS And x.TipoDoc = wTipoDoc)
        If wCor IsNot Nothing Then
            Dim wNuevoCorrelativo = InputBox("Cambio de Correlativo - Caja: " & wPOS, "Correlativo:", wCor.Correlativo.ToString)
            If Val(wNuevoCorrelativo) <> 0 Then
                If SQLUpdate("Update Correlativos Set Correlativo = " & wNuevoCorrelativo & " Where Local = " & wLocal &
                    " and POS = " & wPOS & " and TipoDoc = '" & wTipoDoc & "'") Then
                    Mensaje("Correlativo Actualizado, nuevo correlativo (" & wNuevoCorrelativo & ")")
                    Return Val(wNuevoCorrelativo)
                Else
                    MsgError("Error al actualizar el correlativo")
                End If

            Else

            End If
        End If
        Return 0
    End Function
    Function ImagenBool(ByRef wEstado As Boolean) As Image
        Return CType(IIf(wEstado, My.Resources.check16true_Grilla, My.Resources.check16tfalse_Grilla), Image)
    End Function
    Public Function Letras(ByVal numero As String) As String
        '********Declara variables de tipo cadena************
        Dim palabras As String = ""
        Dim entero As String = ""
        Dim dec As String = ""
        Dim flag As String = ""

        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer

        flag = "N"

        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If

        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If CInt(Trim(CType(numero.ToString.Length, String))) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next

        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "." Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y

        If Len(dec) = 1 Then dec = dec & "0"

        '**********proceso de conversión***********
        flag = "N"

        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "cien "
                                Else
                                    palabras = palabras & "ciento "
                                End If
                            Case "2"
                                palabras = palabras & "doscientos "
                            Case "3"
                                palabras = palabras & "trescientos "
                            Case "4"
                                palabras = palabras & "cuatrocientos "
                            Case "5"
                                palabras = palabras & "quinientos "
                            Case "6"
                                palabras = palabras & "seiscientos "
                            Case "7"
                                palabras = palabras & "setecientos "
                            Case "8"
                                palabras = palabras & "ochocientos "
                            Case "9"
                                palabras = palabras & "novecientos "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "uno "
                                    Else
                                        palabras = palabras & "un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "nueve "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or
                      (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And
                       Len(entero) <= 6) Then palabras = palabras & "mil "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "millón "
                    Else
                        palabras = palabras & "millones "
                    End If
                End If
            Next y

            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                Letras = palabras & "con " & dec
            Else
                Letras = palabras
            End If
        Else
            Letras = ""
        End If
    End Function
    Public Function DeserializarXML(Of t)(xml As String) As t
        Try
            If xml = "" Then Return Nothing
            Dim xs As New XmlSerializer(GetType(t))
            Dim memoryStream As New MemoryStream(StringToUTF8ByteArray(xml))
            Dim xmlTextWriter As New Xml.XmlTextWriter(memoryStream, Encoding.UTF8)
            Return DirectCast(xs.Deserialize(memoryStream), t)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function StringToUTF8ByteArray(stringVal As String) As [Byte]()
        Dim encoding As New UTF8Encoding()
        Dim byteArray As Byte() = encoding.GetBytes(stringVal)
        Return byteArray
    End Function

    Public Function ObtenerMes(wMes As String) As String
        Dim datetimeFormat = Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat
        If wMes = "13" Then wMes = "1"
        If wMes = "0" Then wMes = "12"

        If Val(wMes) > 0 Then
            Return datetimeFormat.MonthNames(CInt(Val(wMes) - 1)).ToUpper
        Else
            For Each wM In datetimeFormat.MonthGenitiveNames
                If wM.ToUpper = wMes.ToUpper Then
                    Dim Fecha = CDate("01/" & wM & "/" & Now.Year)
                    Return DateTime.ParseExact(CDate("01/" & wM & "/" & Now.Year).ToString("MM/dd/yyyy"), "MM/dd/yyyy", CultureInfo.InvariantCulture).Month.ToString
                End If
            Next
        End If
        Return ""
    End Function

    Function Nombre_Mes(ByRef nMes As Integer) As String
        Nombre_Mes = ""

        Select Case nMes
            Case = 1
                Nombre_Mes = "Enero"
            Case = 2
                Nombre_Mes = "Febrero"
            Case = 3
                Nombre_Mes = "Marzo"
            Case = 4
                Nombre_Mes = "Abril"
            Case = 5
                Nombre_Mes = "Mayo"
            Case = 6
                Nombre_Mes = "Junio"
            Case = 7
                Nombre_Mes = "Julio"
            Case = 8
                Nombre_Mes = "Agosto"
            Case = 9
                Nombre_Mes = "Septiembre"
            Case = 10
                Nombre_Mes = "Octubre"
            Case = 11
                Nombre_Mes = "Noviembre"
            Case = 12
                Nombre_Mes = "Diciembre"
            Case = 0
                Nombre_Mes = "Diciembre"
            Case = 13
                Nombre_Mes = "Enero"
            Case Else
                Nombre_Mes = ""
        End Select
    End Function

    Public Function Cambia_Car(wCar As String, wAsc As Integer) As String
        Cambia_Car = wCar
        If Trim(wCar) <> "" Then
            If Asc(wCar) = wAsc Then
                Cambia_Car = ""
            End If
        End If
    End Function

    Public Function Primera_Linea(wLocal As Double, wTipoDoc As String, wNumero As Double) As String
        Dim xBases As New MarketONEDataContext(P_CONEXION)
        Dim wPrimeraLinea As String = "ARTICULO"
        xBases.Log = System.Console.Out
        Dim wPaso = xBases.T_DocumentosD.FirstOrDefault(Function(x) x.Local = wLocal And x.TipoDoc = wTipoDoc And x.Numero = wNumero)

        If wPaso Is Nothing Then
            Return ""
        Else
            If Trim(wPaso.Glosa) <> "" Then
                wPrimeraLinea = Texto_DTE(wPaso.Glosa)
            Else
                Dim wArt = xBases.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wPaso.Articulo)
                If wArt Is Nothing Then
                    'Articulo no encontrado
                Else
                    wPrimeraLinea = Texto_DTE(wArt.Descripcion).Trim
                End If
            End If
        End If

        Return wPrimeraLinea
    End Function

    Public Enum TipoCodigo
        NoEncontrado = 0
        Barra = 1
        Articulo = 2
        SKU = 3
        Pesable = 4
        ProduccionPropia = 5
    End Enum

    Public Class DatosArticulos
        Public Articulo As T_Articulos
        Public Property Tipo As TipoCodigo
        Public Property Cantidad As Decimal
        Public Property Precio As Decimal
    End Class

    Public Function BuscarArticulo(wCodigo As String) As DatosArticulos

        If wCodigo = "" Then Return Nothing

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wBusquedaBarra As T_Barras = Nothing
        Dim wBusquedaArt As T_Articulos = Nothing
        Dim wTipo As TipoCodigo = TipoCodigo.NoEncontrado
        Dim wCantidad As Decimal = 0

        If IsNumeric(wCodigo) Then
            wBusquedaArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wCodigo.ToDecimal)
            If wBusquedaArt IsNot Nothing Then wTipo = TipoCodigo.Articulo
        Else
            wBusquedaArt = DC.T_Articulos.FirstOrDefault(Function(x) x.SKU = wCodigo)
            wTipo = If(wBusquedaArt IsNot Nothing, TipoCodigo.SKU, TipoCodigo.NoEncontrado)
        End If
        If wBusquedaArt Is Nothing Then
            If Not {"24", "25", "28"}.Contains(wCodigo.Substring(0, 2)) And wCodigo.Length = 13 Then
                wBusquedaBarra = DC.T_Barras.FirstOrDefault(Function(x) x.Barra = wCodigo)
                If wBusquedaBarra IsNot Nothing Then
                    wTipo = TipoCodigo.Barra
                    wCantidad = wBusquedaBarra.Unidades
                End If
            ElseIf {"24", "25", "28"}.Contains(wCodigo.Substring(0, 2)) And wCodigo.Length = 13 Then
                wBusquedaArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wCodigo.Substring(2, 5).ToDouble)
                If wBusquedaArt IsNot Nothing Then
                    wTipo = TipoCodigo.Pesable
                    wCantidad = wCodigo.Substring(7, 4).ToDecimal
                End If
            ElseIf wCodigo.Substring(0, 2) = "50" Then
                If Val(wCodigo.Substring(2, 7)) = 0 Then
                    wBusquedaArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wCodigo.Substring(8, 5).ToDecimal)
                    If wBusquedaArt IsNot Nothing Then wTipo = TipoCodigo.ProduccionPropia
                    wCantidad = wCodigo.Substring(7, 4).ToDecimal
                Else
                    wBusquedaArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wCodigo.Substring(2, 7).ToDecimal)
                    If wBusquedaArt IsNot Nothing Then wTipo = TipoCodigo.ProduccionPropia
                    wCantidad = wCodigo.Substring(7, 4).ToDecimal
                End If
            End If
        End If

        If wBusquedaArt Is Nothing And wBusquedaBarra Is Nothing Then
            Return Nothing
        Else
            If wBusquedaArt Is Nothing Then
                wBusquedaArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wBusquedaBarra.Articulo)
            End If
            If wBusquedaArt Is Nothing Then
                Return Nothing
            End If
        End If

        Return New DatosArticulos With
        {
            .Articulo = wBusquedaArt,
            .Cantidad = If(wCantidad = 0, 1, wCantidad),
            .Precio = 0,
            .Tipo = wTipo
        }
    End Function
    <Extension()>
    Public Sub Load(Source As BindingSource, Lista As Object)
        Source.DataSource = Nothing
        Source.DataSource = Lista
    End Sub

    Public Function Encriptar(ByVal _cadenaAencriptar As String) As String
        Dim result As String = String.Empty
        Dim encryted As Byte() = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar)
        result = Convert.ToBase64String(encryted)
        Return result
    End Function
    Public Function DesEncriptar(ByVal _cadenaAdesencriptar As String) As String
        Dim result As String = String.Empty
        Dim decryted As Byte() = Convert.FromBase64String(_cadenaAdesencriptar)
        result = System.Text.Encoding.Unicode.GetString(decryted)
        Return result
    End Function

    Public Enum TipoVenta
        DelGiro = 1
        ActivoFijo = 2
        BienRaiz = 3
    End Enum

    Public Structure ModoInventario
        Public Const Incrementar = "+"
        Public Const Disminuir = "-"
        Public Const Crear = "*"
        Public Const Igualar = "="
        Public Const Consultar = "C"
    End Structure

    Public Function RedondeoPeso(wValor As Decimal) As Decimal
        Return Convert.ToDecimal(RedondeoPeso(Convert.ToDouble(wValor)))
    End Function

    Public Function RedondeoPeso(valor As Double) As Double

        Dim num As String = valor.ToDecimal(0).ToText
        If {"1", "2", "3", "4", "5"}.Contains(num.Substring(num.Length - 1)) Then
            num = num.Substring(0, num.Length - 1) & "0"
        End If
        If {"6", "7", "8", "9"}.Contains(num.Substring(num.Length - 1)) Then
            num = num.Substring(0, num.Length - 1) & "0"
            num = (num.ToDecimal + 10).ToText
        End If
        Return CDbl(num)
    End Function

    Public Function ThumbnailSquare(wImage As Image, wMax As Integer) As Bitmap
        Dim Orientation As Orientation
        Dim H As Integer = 0
        Dim W As Integer = 0
        H = wImage.Height
        W = wImage.Width
        Dim image As Bitmap = Nothing

        If H > W Then
            Orientation = Orientation.Vertical
        Else
            Orientation = Orientation.Horizontal
        End If

        Select Case Orientation
            Case Orientation.Vertical
                W = Convert.ToInt32(wMax / (H / W))
                H = wMax
            Case Orientation.Horizontal
                H = Convert.ToInt32((H / W) * wMax)
                W = wMax
        End Select

        image = New Bitmap(wImage, New Size(W, H))

        Dim canvas As Bitmap

        canvas = New Bitmap(wMax, wMax)

        Dim g = Graphics.FromImage(canvas)

        Select Case Orientation
            Case Orientation.Vertical
                g.DrawImage(image, New Point(CInt((wMax - W) / 2), 0))
            Case Orientation.Horizontal
                g.DrawImage(image, New Point(0, CInt((wMax - H) / 2)))
        End Select

        Return canvas
    End Function

    Public Function FechaArchivo() As String
        Dim wFecha = DateTime.Now
        Return wFecha.Year.ToString.Substring(2, 2) & wFecha.Month.ToString().PadLeft(2, "0"c) & wFecha.Day.ToString().PadLeft(2, "0"c)
    End Function

    Public Function HoraArchivo() As String
        Dim wFecha = DateTime.Now
        Return wFecha.Hour.ToString().PadLeft(2, "0"c) & wFecha.Minute.ToString().PadLeft(2, "0"c) & wFecha.Second.ToString().PadLeft(2, "0"c)
    End Function

    Private Function Ping(ip As String) As Boolean
        Try
            Dim pg = New Net.NetworkInformation.Ping()
            Dim resultado = pg.Send(ip, CInt(CONFIGURACION.TiempoConexion / 2) * 1000)
            Return resultado.Status = Net.NetworkInformation.IPStatus.Success
        Catch ex As Net.Sockets.SocketException
            Return False
        End Try
    End Function

    Private Function ProbarConexion(ip As String, base As String) As Boolean
        Dim resultado = IgnoreErrors(Function() ProbarConexionEx(ip, base), False)
        Return resultado
    End Function

    Private Function ProbarConexionEx(ip As String, base As String) As Boolean
        Dim conexion As String = String.Format(PATRONCONEXION, ip, base)
        Dim DC As New MarketONEDataContext(conexion)
        Try
            DC.ExecuteCommand("SELECT 1")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Enum ResultadoConexion
        Correcto = 0
        ErrorConexion = 1
        TiempoAgotado = 2
    End Enum
    Public Class RespuestaServidor
        Public Resultado As ResultadoConexion
        Public ReadOnly Property IsCompleted As Boolean
            Get
                Return Resultado = ResultadoConexion.Correcto Or
                        Resultado = ResultadoConexion.ErrorConexion
            End Get
        End Property

        Public ReadOnly Property Result As Boolean
            Get
                Return Resultado = ResultadoConexion.Correcto
            End Get
        End Property
    End Class
    <System.Diagnostics.DebuggerNonUserCode()>
    Public Function ProbarConexionServidor(Servidor As String, base As String) As RespuestaServidor
        Dim timeout = TimeSpan.FromSeconds(CONFIGURACION.TiempoConexion)

        'Dim task = Threading.Tasks.Task.Factory.StartNew(Function() ProbarConexion(Servidor, base))
        'task.Wait(timeout)

        'If task.Result Then
        '    Return New RespuestaServidor() With {.Resultado = ResultadoConexion.Correcto}
        'Else
        '    If task.IsCompleted Then
        '        Return New RespuestaServidor() With {.Resultado = ResultadoConexion.ErrorConexion}
        '    Else
        '        Return New RespuestaServidor() With {.Resultado = ResultadoConexion.TiempoAgotado}
        '    End If
        'End If

        'TEST

        Dim pruebaConexion = New Task(Of RespuestaServidor) _
            (Function()
                 Dim intentoConexion = New Task(Of Boolean) _
                    (Function()
                         Try
                             If Not Ping(Servidor) Then Return False
                             ProbarConexion(Servidor, base)
                             Return True
                         Catch e As Exception
                             Return False
                         End Try
                     End Function, TaskCreationOptions.LongRunning)


                 'Dim source = New Threading.CancellationTokenSource()
                 'source.CancelAfter(timeout)
                 'Try
                 '    intentoConexion.Wait(source.Token)
                 '    If intentoConexion.Result Then
                 '        Return New RespuestaServidor() With {.Resultado = ResultadoConexion.Correcto}
                 '    Else
                 '        Return New RespuestaServidor() With {.Resultado = ResultadoConexion.ErrorConexion}
                 '    End If
                 'Catch ex As OperationCanceledException
                 '    Return New RespuestaServidor() With {.Resultado = ResultadoConexion.TiempoAgotado}
                 'End Try

                 intentoConexion.Start()

                 If intentoConexion.Wait(timeout) Then
                     If intentoConexion.Result Then
                         Return New RespuestaServidor() With {.Resultado = ResultadoConexion.Correcto}
                     Else
                         Return New RespuestaServidor() With {.Resultado = ResultadoConexion.ErrorConexion}
                     End If
                 End If
                 Return New RespuestaServidor() With {.Resultado = ResultadoConexion.TiempoAgotado}

             End Function)

        pruebaConexion.Start()
        pruebaConexion.Wait()

        Return pruebaConexion.Result
    End Function

    Public Function IgnoreErrors(Of T)(ByVal operation As Func(Of T), ByVal Optional defaultValue As T = Nothing) As T
        If operation Is Nothing Then Return defaultValue
        Dim result As T
        Try
            result = operation.Invoke()
        Catch
            result = defaultValue
        End Try
        Return result
    End Function

    Public Function Imprimir_OT(Numero_OT As Double, wAutomatico As Boolean) As Boolean
        Dim wReporte As New OrdenTrabajo
        Dim Lista = New List(Of OTReporte)

        Dim wOTs = SQL("SELECT O.OT, C.Rut,C.Nombre,C.Comuna,C.Direccion,C.Telefonos,O.Fecha,O.FechaEntrega,IsNull(U.NombreUsr, '') AS NombreUsr,O.Codigo," &
                 " O.Recepcion,O.ObsCliente,O.ObsTecnico," &
                 " OD.Articulo,A.Descripcion,OD.Cantidad,OD.PVenta" &
                 " FROM OT O" &
                 " JOIN Clientes C ON O.Cliente = C.Cliente" &
                 " LEFT JOIN Usuarios U ON O.Tecnico = U.Usuario " &
                 " JOIN OTDet OD ON O.OT = OD.OT" &
                 " JOIN Articulos A ON OD.Articulo = A.Articulo" &
                 " WHERE O.OT = '" & Numero_OT.ToString & "'")


        For Each wOT As DataRow In wOTs.Rows
            Lista.Add(New OTReporte With {.NumeroOT = wOT.GetText("OT"),
                                              .RUT = wOT.GetText("Rut"),
                                              .NombreCliente = wOT.GetText("Nombre"),
                                              .Direccion = wOT.GetText("Direccion"),
                                              .Ciudad = wOT.GetText("Comuna"),
                                              .Telefono = wOT.GetText("Telefonos"),
                                              .FechaOT = wOT.GetDate("Fecha"),
                                              .FechaEntrega = wOT.GetDate("FechaEntrega"),
                                              .TecnicoR = wOT.GetText("NombreUsr"),
                                              .CodigoR = wOT.GetText("Codigo"),
                                              .ProductoR = wOT.GetText("Recepcion"),
                                              .ObsCliente = wOT.GetText("ObsCliente"),
                                              .ObsTecnico = wOT.GetText("obsTecnico"),
                                              .Articulo = wOT.GetText("Articulo"),
                                              .Descripcion = wOT.GetText("Descripcion"),
                                              .Cantidad = wOT.GetNum("Cantidad"),
                                              .pVenta = wOT.GetNum("PVenta")})
        Next


        If Lista.Count > 0 Then
            Dim wListaParametros = ParametroLocal()
            wReporte.Database.Tables("MarketONE_OTReporte").SetDataSource(Lista)
            wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wListaParametros)

            If wAutomatico Then
                wReporte.PrintToPrinter(1, False, 0, 0)
            Else
                VisorReportes.MostrarReporte(wReporte)
                VisorReportes.Show()
                VisorReportes.BringToFront()
            End If
        Else
            MsgError("OT No Encontrada.")
            Return False
        End If

        Return True
    End Function

    Public Function BuscarCampo(ByVal wTabla As String, wCampoRetorno As String, wCampoBusqueda As String, wDatoaBuscar As String, Optional wFiltro As String = "") As String
        Dim wBuscar = SQL("SELECT " & wCampoRetorno & " FROM " & wTabla & " WHERE " & wCampoBusqueda & " = '" & wDatoaBuscar & "'" + If(wFiltro.Trim = "", "", " and " + wFiltro)).Top
        If wBuscar IsNot Nothing Then
            Return wBuscar.GetText(wCampoRetorno)
        End If
        Return Nothing
    End Function

End Module
