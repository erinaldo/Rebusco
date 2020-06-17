Imports System.IO
Imports Newtonsoft.Json

Public Class Servidor
    Public Property IP As String
    Public Property Empresa As String
End Class

Public Class Settings
    Public Property Empresa As String
    Public Property ImprimirDocumento As Boolean
    Public Property TiempoConexion As Integer
    Public Property CantidadCopias As Integer
    Public Property StockObligatorio As Boolean
    Public Property ImpresoraVoucher As String
    Public Property RutaArchivos As String
    Public Property ServidoresEmpresas As List(Of Servidor)

    Public Property Base As String
    Public Property IPServidor As String

    Private Const NombreArchivo As String = "Rebusco_Settings"

    Public Sub New()
        Empresa = ""
        ImprimirDocumento = True
        TiempoConexion = 5
        CantidadCopias = 2
        StockObligatorio = False
        ImpresoraVoucher = ""
        ImprimirDocumento = True
        RutaArchivos = ""
        ServidoresEmpresas = New List(Of Servidor)
    End Sub



    Public Sub Open()
        Dim ruta = $"{Path.GetDirectoryName(Reflection.Assembly.GetEntryAssembly().Location)}/{NombreArchivo}.json"
        Process.Start("notepad.exe", ruta)
    End Sub

    Public Function Check() As Boolean
        If Empresa = "" Then Return False
        If TiempoConexion = 0 Then Return False
        If RutaArchivos = "" Then Return False
        Return True
    End Function

    Public Shared Function GetSettings() As String
        Try
            CONFIGURACION = LoadConfig(Of Settings)()

            If CONFIGURACION Is Nothing Then
                CONFIGURACION = New Settings()
                SaveConfig(CONFIGURACION)
                Throw New Exception("No se ha configurado Rebusco")
            Else

                If Not CONFIGURACION.Check() Then
                    Throw New Exception("Los valores de configuración no son válidos.")
                End If

                CONFIGURACION.IPServidor = If(CONFIGURACION.ServidoresEmpresas.FirstOrDefault _
                                                (Function(x) x.Empresa = CONFIGURACION.Empresa)?.IP, "")
                If CONFIGURACION.IPServidor = "" Then
                    Throw New Exception("No se ha seleccionado una empresa del listado de Servidores")
                End If

                CONFIGURACION.Base = $"{CONFIGURACION.Empresa}"

            End If

        Catch ex As Exception
            Return ex.Message
        End Try

        Return ""
    End Function

    Public Shared Function LoadConfig(Of T)() As T
        Dim ruta = $"{Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)}/"
        Dim d As DirectoryInfo = New DirectoryInfo(Path.GetDirectoryName(ruta))
        Dim Files As FileInfo() = d.GetFiles(Path.GetFileName($"{NombreArchivo}.json"))
        If Files.Length = 0 Then Return Nothing
        Dim archivo = Files.First()
        Dim obj = JsonConvert.DeserializeObject(Of T)(File.ReadAllText(archivo.FullName))
        Return obj
    End Function

    Public Shared Function SaveConfig(Of T)(ByVal obj As T) As String
        Dim json = JsonConvert.SerializeObject(obj, Formatting.Indented)
        Dim nombre = $"{NombreArchivo}.json"
        Dim ruta = $"{Path.GetDirectoryName(Reflection.Assembly.GetEntryAssembly().Location)}/"
        Directory.CreateDirectory(ruta)
        Dim RutaArchivo = $"{ruta}{nombre}"

        Try
            Directory.CreateDirectory(Path.GetDirectoryName(RutaArchivo))
            Try
                File.Delete(RutaArchivo)
            Catch ex As Exception
            End Try

            File.WriteAllText(RutaArchivo, json)
        Catch ex As Exception
            Return ""
        End Try

        Return RutaArchivo
    End Function
End Class