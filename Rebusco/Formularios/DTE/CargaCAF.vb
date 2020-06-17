Imports System
Imports System.IO
Imports System.Collections

Public Class CargaCAF
    Dim wRut As String
    Dim wTipoDoc As Integer
    Dim wInicial As Long
    Dim wFinal As Long
    Dim wFecha As String


    Private Sub CargaCAF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Auditoria(Text, A_INGRESADO, "", "")
        xArchivo.Focus()

        xDestino.Text = "Directorio Destino: " + (Application.StartupPath & "\CAF\")
    End Sub

    Public Function LeeXML() As String
        Dim wArchivo As New StreamReader(xArchivo.Text)

        LeeXML = ""
        Try
            LeeXML = wArchivo.ReadToEnd
            wArchivo.Close()
        Catch ex As Exception
            MsgError("Error al leer archivo")
        End Try
    End Function

    Private Function ObtieneDatos_CAF(ByVal wXML As String) As Boolean
        Dim wDato As String

        wDato = "" : wRut = "" : wTipoDoc = 0 : wInicial = 0 : wFinal = 0
        Try
            wDato = Mid(wXML, CInt(InStr(wXML, "<RE>") + 4), CInt(InStr(wXML, "</RE>") - CInt(InStr(wXML, "<RE>") + 4)))
            wRut = Mid(wDato, 1, (Len(wDato) - 8)) & "." & Mid(wDato, (Len(wDato) - 7), 3) & "." & Mid(wDato, (Len(wDato) - 4), 5)
            wDato = Mid(wXML, CInt(InStr(wXML, "<TD>") + 4), CInt(InStr(wXML, "</TD>") - CInt(InStr(wXML, "<TD>") + 4)))
            wTipoDoc = CInt(wDato)
            wDato = Mid(wXML, CInt(InStr(wXML, "<D>") + 3), CInt(InStr(wXML, "</D>") - CInt(InStr(wXML, "<D>") + 3)))
            wInicial = CInt(wDato)
            wDato = Mid(wXML, CInt(InStr(wXML, "<H>") + 3), CInt(InStr(wXML, "</H>") - CInt(InStr(wXML, "<H>") + 3)))
            wFinal = CInt(wDato)
            wDato = Mid(wXML, CInt((InStr(wXML, "<FA>") + 4)), CInt(InStr(wXML, "</FA>") - CInt(InStr(wXML, "<FA>") + 4)))
            wFecha = Trim(wDato)
            ObtieneDatos_CAF = True
        Catch ex As Exception
            ObtieneDatos_CAF = False
        End Try
    End Function

    Private Function guardaXML(ByVal wXML As String, ByVal wLocal As Integer) As Boolean
        Dim wTipoDoc As String

        guardaXML = True

        Dim wDoc = SQL("Select * from TipoDoc WHERE Cod_SII = " & Val(Me.wTipoDoc)).Top
        If wDoc Is Nothing Then
            MsgError("Código Documento Fiscal No Encontrado")
            guardaXML = False
            Exit Function
        End If

        wTipoDoc = Trim(wDoc.GetText("TipoDoc"))

        Try
            FileCopy(xArchivo.Text, (Application.StartupPath & "\CAF\" & wTipoDoc & wLocal.ToString.PadLeft(2, CChar("0")) & ".xml"))
        Catch ex As Exception
            MsgError("Error al copiar archivo a carpeta CAF")
            guardaXML = False
            Exit Function
        End Try

        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wCor = DC.T_Correlativos.Where(Function(x) x.Local = wLocal And x.TipoDoc = wTipoDoc)
        Dim locales = DC.T_Locales.ToList()
        Dim tiposDoc = DC.T_TipoDoc.ToList()

        Try
            If wCor.Any Then
                For Each wC In wCor
                    Application.DoEvents()
                    If wC.POS = 0 Then
                        If wC.Correlativo < wInicial Then
                            wC.Correlativo = wInicial
                        End If
                    End If
                    wC.Inicial = wInicial
                    wC.Final = wFinal
                    wC.FechaCAF = CDate(wFecha)
                    wC.CAF = wXML
                    DC.SubmitChanges()
                Next
            Else
                Dim wCorrelativo As New T_Correlativos
                wCorrelativo.Local = wLocal
                wCorrelativo.POS = 0
                wCorrelativo.TipoDoc = wTipoDoc
                wCorrelativo.Correlativo = wInicial
                wCorrelativo.Inicial = wInicial
                wCorrelativo.Final = wFinal
                wCorrelativo.FechaCAF = CDate(wFecha)
                wCorrelativo.CAF = wXML
                DC.T_Correlativos.InsertOnSubmit(wCorrelativo)
                DC.SubmitChanges()
            End If

            xStatus.Text &= $"Local: ({wLocal}) {wRut} {If(locales.FirstOrDefault(Function(x) x.Local = wLocal)?.NombreLocal, "")}" & vbCrLf
            xStatus.Text &= $"Documento: ({wTipoDoc}) {If(tiposDoc.FirstOrDefault(Function(x) x.TipoDoc = wTipoDoc)?.DescTipoDoc, "")}" & vbCrLf
            xStatus.Text &= $"Correlativos: {wInicial} al " & wFinal & "  Fecha: " & wFecha & vbCrLf
            xStatus.Text &= $"Destino: {Directorio_CAF}\{wTipoDoc}{wLocal.ToString.PadLeft(2, CChar("0"))}.xml" & vbCrLf
            xStatus.Text &= $"CAF CARGADO CORRECTAMENTE." & vbCrLf
            xStatus.Text &= $"------------------------------------------------------------------------------" & vbCrLf
        Catch ex As Exception
            guardaXML = False
        End Try

    End Function

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim wXML As String, qLocal As Integer, qError As Boolean

        If Not System.IO.File.Exists(xArchivo.Text) Then
            MsgError("No se pudo abrir archivo:" & vbCrLf & xArchivo.Text)
            Exit Sub
        End If

        wXML = LeeXML()
        If wXML.Trim = "" Then
            MsgError("Archivo sin datos, no se puede procesar")
            Exit Sub
        End If

        bGuardar.Enabled = False
        Cursor = Cursors.WaitCursor
        qLocal = 9999
        qError = False
        If ObtieneDatos_CAF(wXML) Then
            Dim wLoc = SQL("SELECT Local, RutLocal FROM Locales Order by RutLocal")
            For Each wL As DataRow In wLoc.Rows
                Application.DoEvents()
                If wL.GetText("RutLocal") = wRut Then
                    qError = Not guardaXML(wXML, CInt(wL.GetText("Local")))
                    If qLocal = 9999 Then qLocal = CInt(wL.GetText("Local"))
                End If
            Next
            If qLocal <> 9999 Then
                qError = Not Enviar_CAF_DTE(qLocal, xArchivo.Text)
            End If
            If qError Then
                Mensaje("Folios CAF No se cargaron correctamente.  Revise la información en la ventana de eventos.")
            Else
                Mensaje("Folios CAF Cargados.")
            End If
            Auditoria(Text, "Carga de CAF", "", "")
        End If
        xArchivo.Text = ""
        Cursor = Cursors.Arrow
        bGuardar.Enabled = True
    End Sub

    Private Sub bCargar_Click(sender As Object, e As EventArgs) Handles bCargar.Click
        xStatus.Text = ""

        cdCAF.Filter = "CAF (*.xml)|*.xml"
        cdCAF.DefaultExt = "xml"
        cdCAF.FileName = ""
        cdCAF.Title = "Seleccione el archivo CAF"
        cdCAF.ShowDialog()
        xArchivo.Text = cdCAF.FileName

    End Sub

    Function Enviar_CAF_DTE(wLocal As Integer, wArchivo As String) As Boolean
        'Parametrizar FE con datos del Local

        Enviar_CAF_DTE = True

        If Not Parametros_DTE(wLocal) Then
            xStatus.Text = xStatus.Text + "No pudo parametrizarse el DTE.  Favor cargar CAF manualmente desde el DTE." + vbCrLf
            Enviar_CAF_DTE = False
            Exit Function
        End If

        'Llamando al servicio del BOX
        Dim servicio As DTEBoxCliente.Servicio
        servicio = New DTEBoxCliente.Servicio(FE_DTE, FE_Llave)

        Dim resultado As DTEBoxCliente.ResultadoServicio
        Dim AmbienteDTE As DTEBoxCliente.Ambiente
        AmbienteDTE = CType(FE_Ambiente, DTEBoxCliente.Ambiente)

        'resultado = servicio.EnviarCAF(FE_Ambiente, wArchivo)
        resultado = servicio.EnviarCAF(AmbienteDTE, wArchivo)

        If (resultado.Estado = 0) Then
            xStatus.Text = xStatus.Text + "El CAF se envió satisfactoriamente al DTE." + vbCrLf
        Else
            xStatus.Text = xStatus.Text + "No pudo enviarse el CAF al DTE o CAF ya cargado anteriormente.  Favor cargarlo manualmente desde el DTE." + vbCrLf
            Enviar_CAF_DTE = False
        End If
    End Function
End Class