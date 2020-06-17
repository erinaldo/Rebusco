Imports System.IO
Imports System.Text
Imports DTEBoxCliente

Module DTE
    'Facturación Electrónica
    Public FE_IP As String
    Public FE_EsElectronica As Boolean
    Public FE_Ambiente As Double
    Public FE_Rut_Emisor As String
    Public FE_Razon_Social As String
    Public FE_Giro As String
    Public FE_Direccion As String
    Public FE_Comuna As String
    Public FE_Ciudad As String
    Public FE_Email As String
    Public FE_Ateco As Double
    Public FE_Llave As String
    Public FE_NResolucion As Double
    Public FE_FResolucion As Date
    Public FE_DTE As String
    Public FE_PDFColumnas As Integer
    Public FE_PDFNivel As Integer
    Public FE_PDFTruncado As Boolean
    Public FE_TipoDTE As Double
    Public FE_CodigoDTE As Double
    Public FE_FV As Boolean
    Public FE_GD As Boolean
    Public FE_NC As Boolean
    Public FE_FE As Boolean
    Public FE_ND As Boolean
    Public FE_BV As Boolean
    Public FE_BE As Boolean
    Public FE_FC As Boolean

    Public Structure TipoArchivo
        Shared PDF As String = "pdf"
        Shared XML As String = "xml"
        Shared JPG As String = "jpg"
        Shared TXT As String = "txt"
    End Structure

    Public MensajeDTE As String

    Public Class RespuestaTED
        Public Property Estado As Boolean
        Public Property Mensaje As String
        Public Property Imagen As Byte()
        Public Property XML As String

        Public Sub New(wEstado As Boolean, wMensaje As String)
            Estado = wEstado
            Mensaje = wMensaje
            Imagen = Nothing
            XML = ""
        End Sub

        Public Sub New(wEstado As Boolean, wMensaje As String, wImagen As Byte(), wXML As String)
            Estado = wEstado
            Mensaje = wMensaje
            Imagen = wImagen
            XML = wXML
        End Sub
    End Class

    Public Function Generar_TED(wLocal As Decimal, wTipoDoc As String, wNumDoc As Double, wFecha As Date, wRut As String, wNombre As String, wMonto As Double, wPrimeraLinea As String) As RespuestaTED
        Dim DC As New RebuscoDataContext(P_CONEXION)
        Dim Imagen As Byte() = Nothing
        Dim XML As String
        Dim wStep = 0

        Try
            wStep = 1
            'Datos del TED
            Dim tipoDocumento As GDEGateway.Timbre.TipoDocumento
            tipoDocumento = Nothing
            If wTipoDoc = "FV" Then
                tipoDocumento = GDEGateway.Timbre.TipoDocumento.FacturaElectronica
            End If
            If wTipoDoc = "GD" Then
                tipoDocumento = GDEGateway.Timbre.TipoDocumento.GuiaDespachoElectronica
            End If
            If wTipoDoc = "NC" Then
                tipoDocumento = GDEGateway.Timbre.TipoDocumento.NotaCreditoElectronica
            End If
            If wTipoDoc = "ND" Then
                tipoDocumento = GDEGateway.Timbre.TipoDocumento.NotaDebitoElectronica
            End If
            If wTipoDoc = "BV" Then
                tipoDocumento = GDEGateway.Timbre.TipoDocumento.BoletaElectronica
            End If
            If wTipoDoc = "FC" Then
                tipoDocumento = GDEGateway.Timbre.TipoDocumento.FacturaCompraElectronica
            End If
            If wTipoDoc = "FE" Then
                tipoDocumento = GDEGateway.Timbre.TipoDocumento.FacturaElectronicaNoAfectaOExenta
            End If

            Dim CAF() As Byte = Nothing
            wStep = 2

            'Leer CAF del Local
            Try
                wStep = 4
                Dim wCorr = DC.T_Correlativos.FirstOrDefault(Function(x) x.Local = Val(wLocal) And x.TipoDoc = wTipoDoc)
                Dim wTextoXML = wCorr.CAF
                If wCorr IsNot Nothing Then
                    CAF = Encoding.UTF8.GetBytes(wTextoXML)
                End If
            Catch ex As Exception
                Return New RespuestaTED(False, "Error al recuperar CAF")
            End Try

            wStep = 5
            'Datos del PDF417
            Dim pdfTipo As GDEGateway.Timbre.TipoPdf417
            pdfTipo = GDEGateway.Timbre.TipoPdf417.Grafico
            Dim pdfColumnas As Integer
            pdfColumnas = 13
            Dim pdfNivelCorreccion As Integer
            pdfNivelCorreccion = 5
            Dim pdfTruncado As Boolean
            pdfTruncado = False
            Dim pdfFormato As GDEGateway.Timbre.FormatoPdf417
            pdfFormato = GDEGateway.Timbre.FormatoPdf417.Jpeg
            Dim directorioTemporal As String
            directorioTemporal = Directorio_TED

            Dim tedGenerado As GDEGateway.Timbre.TED
            wStep = 6

            'Dim wNumero As Decimal
            'wNumero = Convert.ToDecimal(wNumDoc)
            wPrimeraLinea = Primera_Linea(wLocal, wTipoDoc, wNumDoc)

            tedGenerado = GDEGateway.Timbre.Generador.GenerarTimbre(
                FE_Rut_Emisor,
                tipoDocumento,
                wFecha,
                CInt(wNumDoc),
                Rut_DTE(wRut),
                Texto_DTE(wNombre),
                CInt(wMonto),
                wPrimeraLinea,
                CAF,
                pdfTipo,
                pdfColumnas,
                pdfNivelCorreccion,
                pdfTruncado,
                pdfFormato,
                directorioTemporal)

            Dim tedValor As String

            wStep = 7
            tedValor = tedGenerado.Valor

            Dim DocG = DC.T_DocumentosG.FirstOrDefault(Function(x) x.Local = wLocal And x.TipoDoc = wTipoDoc And x.Numero = wNumDoc)
            If DocG Is Nothing Then
                Return New RespuestaTED(False, "Error al recuperar CAF. Documento no existe")
            End If

            wStep = 8
            'Guardar el pdf417 en disco como imagen
            Dim pdf417FilePath As String
            pdf417FilePath = Ruta_Archivo_Fiscal(TipoArchivo.JPG, wLocal, wTipoDoc, wNumDoc, DocG.Cliente)
            Imagen = tedGenerado.CodigoComoBytes()
            System.IO.File.WriteAllBytes(pdf417FilePath, Imagen)

            wStep = 9
            Dim ArchivoXML As String
            ArchivoXML = Ruta_Archivo_Fiscal(TipoArchivo.XML, wLocal, wTipoDoc, wNumDoc, DocG.Cliente)
            System.IO.File.WriteAllText(ArchivoXML, tedValor)

            XML = tedValor

            If DocG IsNot Nothing Then
                If DocG.STATUS_DTE = EstadosSII.No_Enviado Or DocG.STATUS_DTE = EstadosSII.Timbrado Or DocG.STATUS_DTE = EstadosSII.Indefinido Then
                    'Cambiar el estado de un documento si este solo se ha timbrado
                    wStep = 10
                    DocG.TED = XML
                    DocG.Firma = Imagen
                    DocG.STATUS_DTE = EstadosSII.Timbrado
                    DC.Log = System.Console.Out
                    DC.SubmitChanges()
                    DC.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)
                End If
            End If

        Catch ex As Exception
            Return New RespuestaTED(False, "(" & wStep & ")" & " " & ex.ToString)
        End Try

        Return New RespuestaTED(True, "", Imagen, XML)
    End Function

    Public Function Leer_TED(pArchivo As String) As String
        Try
            Dim wArchivo As New StreamReader(Trim(pArchivo))
            Return wArchivo.ReadToEnd()
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function Ruta_Archivo_Fiscal(wExtension As String, wLocal As Double, wTipoDoc As String, wNumero As Double, wCliente As Double) As String
        Dim DC As New RebuscoDataContext(P_CONEXION)
        Dim wFantasia As String = ""

        If wCliente = 0 Then
            Dim DocG = DC.T_DocumentosG.FirstOrDefault(Function(x) x.Local = wLocal And x.TipoDoc = wTipoDoc And x.Numero = wNumero)
            If DocG IsNot Nothing Then
                wCliente = DocG.Cliente
            End If
        End If

        If wCliente > 0 Then
            Dim Cliente = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = wCliente)
            If Cliente IsNot Nothing Then
                wFantasia = Cliente.Fantasia.Trim
            End If
        End If

        Dim wRuta = Trim(wTipoDoc) & " (" & wLocal.ToString.PadLeft(2, CChar("0")) & ") " & wNumero.ToString.PadLeft(8, CChar("0")) & (" " & wFantasia) & "." + LCase(wExtension)

        Select Case wExtension
            Case TipoArchivo.PDF
                Return Directorio_PDF & wRuta
            Case TipoArchivo.XML
                Return Directorio_TED & wRuta
            Case TipoArchivo.JPG
                Return Directorio_TED & wRuta
            Case TipoArchivo.TXT
                Return Directorio_TXT & wRuta
            Case Else
                Return P_DIRECTORIO & wRuta
        End Select

    End Function

    Public Function Emitir_DTE(wLocal As Double, wTipoDoc As String, wNumDoc As Double) As Boolean
        Dim wPrimeraLinea As String, wUnidad As String, wArticulo As String, Referencias As Double
        Dim wFechaRef As Date, wTipoDocRef As String, wNumDocRef As String
        Dim DC As New RebuscoDataContext(P_CONEXION)


        'Las Boletas de Venta tienen tratamiento especial
        If wTipoDoc = "BV" Then
            Dim Respuesta = Emitir_Boleta(wLocal, wTipoDoc, wNumDoc)
            Return Respuesta
        End If

        Dim dte As DocumentoDTE.SiiDte.DTEDefType
        dte = New DocumentoDTE.SiiDte.DTEDefType()
        dte.DTE_Choice = New DocumentoDTE.SiiDte.DTE_Choice()

        'Documento
        dte.DTE_Choice.Documento = New DocumentoDTE.SiiDte.Documento()
        Dim doc As DocumentoDTE.SiiDte.Documento
        doc = dte.DTE_Choice.Documento

        'Documento/Encabezado
        doc.Encabezado = New DocumentoDTE.SiiDte.Encabezado()
        doc.Encabezado.IdDoc = New DocumentoDTE.SiiDte.IdDoc()

        'Recuperar Documento       
        Dim DocG = DC.T_DocumentosG.FirstOrDefault(Function(x) x.Local = wLocal And x.TipoDoc = wTipoDoc And x.Numero = wNumDoc)
        If DocG Is Nothing Then
            Return False
        End If

        Dim ListaDocD = DC.T_DocumentosD.Where(Function(x) x.Local = wLocal And x.TipoDoc = wTipoDoc And x.Numero = wNumDoc).ToList
        If Not ListaDocD.Any Then
            Return False
        End If

        Dim Cli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = DocG.Cliente)
        If Cli Is Nothing Then
            Return False
        End If

        'Documento/Referencia
        Dim wDocR = DC.T_DocumentosR.FirstOrDefault(Function(x) x.Local = wLocal And x.Numero = wNumDoc And x.TipoDoc = wTipoDoc)
        If wDocR IsNot Nothing Then
            wFechaRef = wDocR.FechaRef
            wTipoDocRef = wDocR.TipoDocRef
            wNumDocRef = wDocR.NumDocRef
        Else
            wFechaRef = New Date(2000, 1, 1)
            wTipoDocRef = ""
            wNumDocRef = ""
        End If

        'Documento/Encabezado/IdDoc
        doc.Encabezado.IdDoc.TipoDTE = CType(Codigo_DTE_EMISION(wTipoDoc), DocumentoDTE.SiiDte.Enumerations.DTEType)     'Codigo del tipo .n99
        doc.Encabezado.IdDoc.Folio = CInt(wNumDoc)
        doc.Encabezado.IdDoc.FchEmis = New LiquidTechnologies.Runtime.Net20.XmlDateTime(DocG.Fecha.Date)
        doc.Encabezado.IdDoc.FmaPago = CType(IIf(DocG.FPago.Trim.ToUpper = "E", DocumentoDTE.SiiDte.Enumerations.IdDoc_FmaPago.n1, DocumentoDTE.SiiDte.Enumerations.IdDoc_FmaPago.n2), DocumentoDTE.SiiDte.Enumerations.IdDoc_FmaPago)

        If wTipoDoc = "GD" Then
            doc.Encabezado.IdDoc.TipoDespacho = DocumentoDTE.SiiDte.Enumerations.IdDoc_TipoDespacho.n1
            doc.Encabezado.IdDoc.IndTraslado = Codigo_Referencia_GD(wTipoDoc, DocG.Motivo.ToString.Trim)
            doc.Encabezado.IdDoc.IndServicio = DocumentoDTE.SiiDte.Enumerations.IdDoc_IndServicio.n1
            doc.Encabezado.IdDoc.FchVenc = New LiquidTechnologies.Runtime.Net20.XmlDateTime(DocG.Fecha.Date)
        End If

        If wTipoDoc = "NC" Or wTipoDoc = "ND" Then
            doc.Encabezado.IdDoc.FmaPago = DocumentoDTE.SiiDte.Enumerations.IdDoc_FmaPago.n1
            doc.Encabezado.IdDoc.FchVenc = New LiquidTechnologies.Runtime.Net20.XmlDateTime(wFechaRef)
        End If


        'Documento/Encabezado/Emisor
        doc.Encabezado.Emisor = New DocumentoDTE.SiiDte.Emisor()
        doc.Encabezado.Emisor.RUTEmisor = FE_Rut_Emisor
        doc.Encabezado.Emisor.RznSoc = FE_Razon_Social
        doc.Encabezado.Emisor.GiroEmis = FE_Giro
        doc.Encabezado.Emisor.Acteco.Add(CInt(FE_Ateco))
        doc.Encabezado.Emisor.DirOrigen = FE_Direccion
        doc.Encabezado.Emisor.CmnaOrigen = FE_Comuna
        doc.Encabezado.Emisor.CiudadOrigen = FE_Ciudad
        doc.Encabezado.Emisor.CorreoEmisor = FE_Email

        'Documento/Encabezado/Receptor
        doc.Encabezado.Receptor = New DocumentoDTE.SiiDte.Receptor()
        doc.Encabezado.Receptor.RUTRecep = UCase(DocG.Rut).Replace("_", "").Replace(".", "")
        doc.Encabezado.Receptor.RznSocRecep = Texto_DTE(Mid(Cli.Nombre, 1, 100))
        doc.Encabezado.Receptor.CdgIntRecep = CStr(Cli.Cliente)
        doc.Encabezado.Receptor.GiroRecep = Texto_DTE(Mid(Cli.Giro, 1, 40))
        If Cli.Contacto.Trim <> "" Then
            doc.Encabezado.Receptor.Contacto = Texto_DTE(Mid(Cli.Contacto, 1, 80))
        Else
            doc.Encabezado.Receptor.Contacto = Texto_DTE(Mid(Cli.Nombre, 1, 80))
        End If
        If Cli.Email.Trim <> "" Then
            doc.Encabezado.Receptor.CorreoRecep = Texto_DTE(Mid(Cli.Email, 1, 80)).ToString.Trim
        End If
        doc.Encabezado.Receptor.DirRecep = Texto_DTE(Mid(Cli.Direccion, 1, 70))
        doc.Encabezado.Receptor.CmnaRecep = Texto_DTE(Mid(Saca_Comuna(Cli.Comuna), 1, 20))
        doc.Encabezado.Receptor.CiudadRecep = Texto_DTE(Mid(Saca_Comuna(Cli.Comuna), 1, 20))
        doc.Encabezado.Receptor.CorreoRecep = Cli.Email.ToString.Trim


        'Documento/Descuentos Generales
        If DocG.Descuento > 0 Then
            Dim dscRcgGlobal As DocumentoDTE.SiiDte.DscRcgGlobal
            dscRcgGlobal = New DocumentoDTE.SiiDte.DscRcgGlobal()
            dscRcgGlobal.NroLinDR = 1
            dscRcgGlobal.TpoMov = DocumentoDTE.SiiDte.Enumerations.DscRcgGlobal_TpoMov.D
            dscRcgGlobal.TpoValor = DocumentoDTE.SiiDte.Enumerations.DineroPorcentajeType.Dollar  'Dollar = Descuento en Pesos,  Percent=Descuento por porcentaje
            dscRcgGlobal.ValorDR = CInt(DocG.Descuento)
            doc.DscRcgGlobal.Add(dscRcgGlobal)
        End If

        'Documento/Encabezado/Totales
        doc.Encabezado.Totales = New DocumentoDTE.SiiDte.Totales()
        doc.Encabezado.Totales.MntTotal = CInt(DocG.Total)

        If wTipoDoc = "FE" Or wTipoDocRef = "FE" Then
            doc.Encabezado.Totales.MntExe = CInt(DocG.Neto)
        Else
            doc.Encabezado.Totales.MntNeto = CInt(DocG.Neto)
            doc.Encabezado.Totales.TasaIVA = G_IVA.ToString.ToDecimal
            doc.Encabezado.Totales.IVA = CInt(DocG.IVA)
        End If


        'Documento/Detalle
        Dim det As DocumentoDTE.SiiDte.Detalle
        Dim Lineas = 1

        wPrimeraLinea = "ARTICULO"
        For Each DocD In ListaDocD
            det = New DocumentoDTE.SiiDte.Detalle()

            wUnidad = "UN"

            Dim Art = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = DocD.Articulo)

            If Art IsNot Nothing Then
                wUnidad = Art.Unidad.Trim
            End If

            wArticulo = Trim(Mid(DocD.Glosa, 1, 80))
            If wArticulo = "" Then wArticulo = Art.Descripcion
            If wPrimeraLinea = "ARTICULO" Then
                wPrimeraLinea = Trim(Mid(Texto_DTE(wArticulo), 1, 80))
                wArticulo = wPrimeraLinea
            End If

            det.NroLinDet = Lineas
            If Lineas = 1 Then
                det.NmbItem = wPrimeraLinea
            Else
                det.NmbItem = wArticulo
            End If
            det.MontoItem = CInt(Math.Round(DocD.Cantidad * DocD.Neto, 0))
            det.DscItem = wArticulo
            det.QtyItem = CInt(DocD.Cantidad)
            det.UnmdItem = wUnidad
            If DocD.Neto > 0 Then
                det.PrcItem = CInt(DocD.Neto)
            End If

            'Si es NC o ND y el Documento afecto es FE, debe tener este item especial de exento
            If wTipoDocRef = "FE" Then
                det.IndExe = 0   'En el DTE les llega como un 1
            End If

            doc.Detalle.Add(det)
            Lineas += 1
        Next


        'Referencias
        If wTipoDocRef <> "" Then
            Dim reference As DocumentoDTE.SiiDte.Referencia
            reference = New DocumentoDTE.SiiDte.Referencia()

            Referencias = 1

            reference.NroLinRef = CInt(Referencias)
            reference.TpoDocRef = CStr(Codigo_SII(wTipoDocRef.Trim))
            reference.FolioRef = CStr(wNumDocRef)
            reference.FchRef = New LiquidTechnologies.Runtime.Net20.XmlDateTime(wFechaRef.Date)
            If wTipoDoc = "NC" Or wTipoDoc = "ND" Then
                reference.CodRef = Codigo_Referencia_NC(wTipoDoc, DocG.Motivo.ToString.Trim)
                reference.RazonRef = Texto_DTE(Descripcion_Motivo(wTipoDoc, DocG.Motivo.ToString.Trim))
            End If
            If wTipoDocRef = "OC" Then
                reference.RazonRef = Texto_DTE("ORDEN DE COMPRA")
            End If
            If wTipoDocRef = "GD" Then
                reference.RazonRef = Texto_DTE("GUIA DE DESPACHO")
            End If
            If wTipoDocRef = "CO" Then
                reference.RazonRef = Texto_DTE("COTIZACION")
            End If
            doc.Referencia.Add(reference)
            Referencias = Referencias + 1
        End If

        'Llamada al Servicio
        MensajeDTE = ""
        Dim AmbienteDTE As DTEBoxCliente.Ambiente
        AmbienteDTE = CType(FE_Ambiente, Ambiente)
        Dim FechaResolucion As Date
        FechaResolucion = New DateTime(FE_FResolucion.Year, FE_FResolucion.Month, FE_FResolucion.Day)
        Dim NumeroResolucion As Integer
        NumeroResolucion = CInt(FE_NResolucion)
        Dim TipoPDF417 As DTEBoxCliente.TipoPdf417
        TipoPDF417 = DTEBoxCliente.TipoPdf417.Fuente

        Dim GenerarFolio As Boolean
        GenerarFolio = False   'Es para que el DTE genere correlativo automatico o no

        Dim apiURL As String
        Dim apiAuth As String
        apiURL = FE_DTE
        apiAuth = FE_Llave

        Dim ServicioDTE As DTEBoxCliente.Servicio
        ServicioDTE = New DTEBoxCliente.Servicio(apiURL, apiAuth)

        Dim ResultadoDTE As DTEBoxCliente.ResultadoEnvioDte
        ResultadoDTE = ServicioDTE.EnviarDocumento(dte, AmbienteDTE, FechaResolucion.Date, NumeroResolucion, TipoPDF417, GenerarFolio)

        'Procesar Resultado del Servicio
        If (ResultadoDTE.ResultadoServicio.Estado = DTEBoxCliente.EstadoResultado.Ok) Then
            'Usar el data que viene en el resultado de la llamada
            Dim TED As String
            TED = ResultadoDTE.TED
            'Xml que representa el elemento TED generado
            'Si tipoPdf417 = DTEBoxCliente.TipoPdf417.Fuente viene el código,
            ' si es DTEBoxCliente.TipoPdf417.Grafico , Entonces arreglo de bytes codigificado en base64,
            ' usar método result.Pdf417ComoArregloBytes()
            Dim PDF417 As String
            PDF417 = ResultadoDTE.Pdf417

            If DocG.STATUS_DTE <> EstadosSII.Aprobado Then
                'Grabar Cambio de Estado
                DocG.DTE = True
                DocG.STATUS_DTE = EstadosSII.Aprobado
                Try
                    'DocG.Fields("Firma").Value = Leer_JPG(Directorio_TED + wTipoDoc + "(" + Llena0(wLocal, 2) + ")" + Llena0(wNumDoc, 8) + ".jpg")
                    DocG.Firma = Leer_JPG(Ruta_Archivo_Fiscal(TipoArchivo.JPG, wLocal, wTipoDoc, wNumDoc, DocG.Cliente))
                Catch ex As Exception
                    'MsgError("Error al Leer Firma:" + vbCrLf + Archivo_Fiscal(gJPG, wLocal, wTipoDoc, wNumDoc, DocG("Cliente").Value))
                End Try
                DocG.TED = ResultadoDTE.TED
            End If
            DC.SubmitChanges()
        Else
            MensajeDTE = ResultadoDTE.ResultadoServicio.Descripcion

            'Grabar Cambio de Status
            If DocG.STATUS_DTE = EstadosSII.No_Enviado Then
                'Grabar Cambio de Estado
                DocG.STATUS_DTE = EstadosSII.Rechazado
            End If
            DC.SubmitChanges()
            Return False
        End If
        Return True
    End Function


    Public Function Emitir_Boleta(wLocal As Double, wTipoDoc As String, wNumDoc As Double) As Boolean
        Dim wPrimeraLinea As String, wUnidad As String, wArticulo As String

        Dim DC As New RebuscoDataContext(P_CONEXION)

        'MODULO SIMILAR A LA EMISION DE FACTURAS PERO ES ESPECIFICO PARA BOLETAS YA QUE TIENN TRATAMIENTO DISTINTO

        If wTipoDoc <> "BV" Then
            'No correspode módulo
            Return False
        End If

        Dim Boleta As DocumentoBoleta.SiiDte.BOLETADefType
        Boleta = New DocumentoBoleta.SiiDte.BOLETADefType()

        'Boleta/Documento
        Boleta.Documento = New DocumentoBoleta.SiiDte.Documento()
        Dim doc As DocumentoBoleta.SiiDte.Documento
        doc = Boleta.Documento

        'Boleta/Documento/Encabezado
        doc.Encabezado = New DocumentoBoleta.SiiDte.Encabezado()
        doc.Encabezado.IdDoc = New DocumentoBoleta.SiiDte.IdDoc()

        'Boleta/Recuperar Documento
        Dim DocG = DC.T_DocumentosG.FirstOrDefault(Function(x) x.Local = wLocal And x.TipoDoc = wTipoDoc And x.Numero = wNumDoc)
        If DocG Is Nothing Then
            Return False
        End If

        Dim ListaDocD = DC.T_DocumentosD.Where(Function(x) x.Local = wLocal And x.TipoDoc = wTipoDoc And x.Numero = wNumDoc).ToList
        If Not ListaDocD.Any Then
            Return False
        End If

        Dim Cli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = DocG.Cliente)
        If Cli Is Nothing Then
            Return False
        End If

        'Documento/Encabezado/IdDoc
        doc.Encabezado.IdDoc.TipoDTE = DocumentoBoleta.SiiDte.Enumerations.DTEType.n39
        doc.Encabezado.IdDoc.Folio = CInt(wNumDoc)
        doc.Encabezado.IdDoc.FchEmis = New LiquidTechnologies.Runtime.Net20.XmlDateTime(DocG.Fecha.Date)
        doc.Encabezado.IdDoc.IndServicio = DocumentoBoleta.SiiDte.Enumerations.IdDoc_IndServicio.n1

        'Boleta/Documento/Encabezado/Emisor
        doc.Encabezado.Emisor = New DocumentoBoleta.SiiDte.Emisor()
        doc.Encabezado.Emisor.RUTEmisor = FE_Rut_Emisor

        doc.Encabezado.Emisor.RznSocEmisor = FE_Razon_Social
        doc.Encabezado.Emisor.GiroEmisor = FE_Giro
        doc.Encabezado.Emisor.DirOrigen = FE_Direccion
        doc.Encabezado.Emisor.CmnaOrigen = FE_Comuna
        doc.Encabezado.Emisor.CiudadOrigen = FE_Ciudad

        'Boleta/Documento/Encabezado/Receptor
        doc.Encabezado.Receptor = New DocumentoBoleta.SiiDte.Receptor()
        doc.Encabezado.Receptor.RUTRecep = Rut_DTE(Cli.Rut)
        doc.Encabezado.Receptor.RznSocRecep = Texto_DTE(Mid(Cli.Nombre, 1, 100))
        doc.Encabezado.Receptor.CdgIntRecep = CStr(Cli.Cliente)
        doc.Encabezado.Receptor.Contacto = Texto_DTE(Mid(Cli.Contacto, 1, 80))
        doc.Encabezado.Receptor.DirRecep = Texto_DTE(Mid(Cli.Direccion, 1, 70))
        doc.Encabezado.Receptor.CmnaRecep = Texto_DTE(Mid(Saca_Comuna(Cli.Comuna), 1, 20))
        doc.Encabezado.Receptor.CiudadRecep = Texto_DTE(Mid(Saca_Comuna(Cli.Ciudad), 1, 20))

        'Boleta/Documento/Encabezado/Totales
        doc.Encabezado.Totales = New DocumentoBoleta.SiiDte.Totales()
        doc.Encabezado.Totales.MntTotal = CInt(DocG.Total)


        'Documento/Detalle
        Dim det As DocumentoBoleta.SiiDte.Detalle

        Dim Lineas = 1
        wPrimeraLinea = "ARTICULO"
        For Each DocD In ListaDocD

            det = New DocumentoBoleta.SiiDte.Detalle()

            wUnidad = "UN"

            Dim Art = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = DocD.Articulo)

            If Art IsNot Nothing Then
                wUnidad = Art.Unidad.Trim
            End If

            If Trim(Mid(DocD.Glosa, 1, 80)) = "" Then
                wArticulo = If(Art IsNot Nothing, Trim(Art.Descripcion), "")
            Else
                wArticulo = Trim(Mid(DocD.Glosa, 1, 80))
            End If
            If wPrimeraLinea = "ARTICULO" Then
                wPrimeraLinea = Trim(Mid(Texto_DTE(wArticulo), 1, 80))
                wArticulo = wPrimeraLinea
            End If

            det.NroLinDet = Lineas

            If Lineas = 1 Then
                det.NmbItem = wPrimeraLinea
            Else
                det.NmbItem = wArticulo
            End If

            det.MontoItem = CInt(Math.Round(DocD.Cantidad * DocD.Neto * (1 + (G_IVA / 100)), 0))
            det.DscItem = wArticulo
            det.QtyItem = CInt(DocD.Cantidad)
            det.UnmdItem = wUnidad
            If DocD.Neto > 0 Then
                det.PrcItem = CInt(Math.Round(DocD.Neto * (1 + (G_IVA / 100)), 0))
            End If

            'Para agregar codigo de producto
            ''Documento/Detalle/CdgItem
            'Dim cdgItem As DocumentoDTE.SiiDte.CdgItem
            'cdgItem = New DocumentoDTE.SiiDte.CdgItem()
            'cdgItem.TpoCodigo = "INT"  'Intenro
            'cdgItem.VlrCodigo = "BUR-BURSTA"
            'det.CdgItem.Add(cdgItem)

            doc.Detalle.Add(det)
            Lineas += 1

        Next


        'Llamada al Servicio
        MensajeDTE = ""
        Dim AmbienteDTE As DTEBoxCliente.Ambiente
        AmbienteDTE = CType(FE_Ambiente, Ambiente)
        Dim FechaResolucion As Date
        FechaResolucion = New DateTime(FE_FResolucion.Year, FE_FResolucion.Month, FE_FResolucion.Day)
        Dim NumeroResolucion As Integer
        NumeroResolucion = CInt(FE_NResolucion)
        Dim TipoPDF417 As DTEBoxCliente.TipoPdf417
        TipoPDF417 = DTEBoxCliente.TipoPdf417.Fuente

        Dim GenerarFolio As Boolean
        GenerarFolio = False    'Es para que el DTE genere correlativo automatico o no

        Dim apiURL As String
        Dim apiAuth As String
        apiURL = FE_DTE
        apiAuth = FE_Llave

        Dim ServicioDTE As DTEBoxCliente.Servicio
        ServicioDTE = New DTEBoxCliente.Servicio(apiURL, apiAuth)

        Dim ResultadoDTE As DTEBoxCliente.ResultadoEnvioBoleta
        ResultadoDTE = ServicioDTE.EnviarDocumento(Boleta, AmbienteDTE, FechaResolucion, NumeroResolucion, TipoPDF417, GenerarFolio)

        'Procesar Resultado del Servicio
        If (ResultadoDTE.ResultadoServicio.Estado = DTEBoxCliente.EstadoResultado.Ok) Then
            'Usar el data que viene en el resultado de la llamada
            Dim TED As String
            TED = ResultadoDTE.TED 'Xml que representa el elemento TED generado
            'Si tipoPdf417 = DTEBoxCliente.TipoPdf417.Fuente viene el código,
            ' si es DTEBoxCliente.TipoPdf417.Grafico , Entonces arreglo de bytes codigificado en base64,
            ' usar método result.Pdf417ComoArregloBytes()
            Dim PDF417 As String
            PDF417 = ResultadoDTE.Pdf417

            If DocG.STATUS_DTE <> EstadosSII.Aprobado Then
                'Grabar Cambio de Estado
                DocG.STATUS_DTE = EstadosSII.Aprobado
                'DocG.Firma = Leer_JPG(Directorio_TED + wTipoDoc + "(" + Llena0(wLocal, 2) + ")" + Llena0(wNumDoc, 8) + ".jpg")
                DocG.Firma = Leer_JPG(Ruta_Archivo_Fiscal(TipoArchivo.JPG, wLocal, wTipoDoc, wNumDoc, DocG.Cliente))
                DocG.TED = ResultadoDTE.TED 'XElement.Parse(ResultadoDTE.TED)
            End If

            DC.SubmitChanges()

        Else
            MensajeDTE = ResultadoDTE.ResultadoServicio.Descripcion
            'Grabar Cambio de Status
            If DocG.STATUS_DTE = EstadosSII.No_Enviado Then
                'Grabar Cambio de Estado
                DocG.STATUS_DTE = EstadosSII.Rechazado
                DC.SubmitChanges()
            End If
            Return False
        End If

        Return True

    End Function

    Public Function Consultar_DTE(pConsulta As Double, pTipoDoc As String, pNumero As Double) As Tuple(Of Integer, String)
        Dim RutDF As String, Intentos As Integer
        'Consultar el Estado de un Documento electrónico
        'pConsulta = 1  -- Consultar Estado
        'pConsulta = 2  -- Consultar ID Seguimiento SII
        'pConsulta = 3  -- Consultar Comentario

        FE_TipoDTE = Codigo_DTE_Consulta(pTipoDoc)

        On Error GoTo ReIntentos
        Intentos = 0
ReIntentos:
        Intentos = Intentos + 1
        If Intentos > 3 Then
            On Error GoTo 0
            Return New Tuple(Of Integer, String)(7, "3 Reintentos fallidos. Intente nuevamente.")
            Exit Function
        End If

        Dim apiURL As String
        Dim apiAuth As String
        apiURL = FE_DTE
        apiAuth = FE_Llave

        Dim ServicioDTE As DTEBoxCliente.Servicio
        ServicioDTE = New DTEBoxCliente.Servicio(apiURL, apiAuth)

        Dim FE_Grupo As DTEBoxCliente.GrupoBusqueda
        FE_Grupo = DTEBoxCliente.GrupoBusqueda.Emitidos

        Dim FE_Resultado As DTEBoxCliente.ResultadoEstadoFiscal
        FE_Resultado = ServicioDTE.EstadoFiscal(CType(FE_Ambiente, Ambiente), FE_Grupo, FE_Rut_Emisor, CType(FE_TipoDTE, TipoDocumento), CInt(pNumero))

        On Error GoTo 0

        'Resultado de la operación, 0 exitosa, diferente de cero es error al cunsultar DTE (no es error del documento)
        If (FE_Resultado.ResultadoServicio.Estado = 0) Then
            If pConsulta = 1 Then
                Select Case CInt(FE_Resultado.Estado)
                    Case 0
                        Return New Tuple(Of Integer, String)(0, "El documento fue autorizado")
                    Case 1
                        Return New Tuple(Of Integer, String)(1, "La resolución del SII está pendiente")
                    Case 2
                        Return New Tuple(Of Integer, String)(2, "El documento fue autorizado, pero con observaciones o reparos")
                    Case 9
                        Return New Tuple(Of Integer, String)(9, "El documento fue rechazado")
                    Case Else
                        Return New Tuple(Of Integer, String)(CInt(FE_Resultado.Estado), "")
                End Select
            End If

            If pConsulta = 2 Then
                'TrackId que entregó el SII con la autorización del documento.
                Return New Tuple(Of Integer, String)(22, Trim(FE_Resultado.IdSeguimiento))
            End If

            If pConsulta = 3 Then
                'Comentarios asociados al estado de autorización
                Return New Tuple(Of Integer, String)(33, Trim(FE_Resultado.Comentarios))
            End If
        Else
            Return New Tuple(Of Integer, String)(99, Trim(FE_Resultado.ResultadoServicio.Descripcion))
        End If

    End Function


    Public Function Parametros_DTE(wLocal As Double) As Boolean
        Dim DC As New RebuscoDataContext(P_CONEXION)

        Parametros_DTE = False
        Try
            Dim Loc = DC.T_Locales.FirstOrDefault(Function(x) x.Local = wLocal)

            If Loc IsNot Nothing Then
                FE_IP = Loc.IP_DTE.ToString.Trim
                FE_EsElectronica = Loc.FElectronica
                FE_Rut_Emisor = UCase(Loc.RutLocal).Replace("_", "").Replace(".", "")
                FE_Ambiente = Val(IIf(Loc.Produccion, DTEBoxCliente.Ambiente.Produccion, DTEBoxCliente.Ambiente.Homologacion))
                FE_Razon_Social = Texto_DTE(Mid(Loc.RazonLocal, 1, 100))
                FE_Giro = Texto_DTE(Mid(Loc.GiroLocal, 1, 80))
                FE_Direccion = Texto_DTE(Mid(Loc.DirLocal, 1, 60))
                FE_Comuna = Texto_DTE(Saca_Comuna(Loc.Comuna))
                FE_Ciudad = Texto_DTE(Saca_Comuna(Loc.Comuna))
                FE_Email = Loc.EMailLocal.ToString.Trim
                FE_Ateco = Val(Loc.ATECO)
                FE_Llave = Loc.Llave.ToString.Trim
                FE_NResolucion = Loc.NResolucion
                FE_FResolucion = Loc.FResolucion
                FE_DTE = "http://" + FE_IP + "/api/Core.svc/Core"
                FE_FV = Loc.FV_Elect
                FE_GD = Loc.GD_Elect
                FE_NC = Loc.NC_Elect
                FE_FE = Loc.FE_Elect
                FE_ND = Loc.ND_Elect
                FE_BV = Loc.BV_Elect
                FE_BE = Loc.BE_Elect
                FE_FC = Loc.FC_Elect

                Parametros_DTE = True
            Else
                FE_IP = "127.0.0.1"
                FE_EsElectronica = False
                FE_Ambiente = DTEBoxCliente.Ambiente.Homologacion
                FE_Rut_Emisor = "00.000.000.0"
                FE_Razon_Social = ""
                FE_Giro = ""
                FE_Direccion = ""
                FE_Comuna = ""
                FE_Ciudad = ""
                FE_Email = ""
                FE_Ateco = 0
                FE_Llave = ""
                FE_NResolucion = 0
                FE_FResolucion = CDate("2000-01-01")
                FE_DTE = "http://" + FE_IP + "/api/Core.svc/Core"
                FE_FV = False
                FE_GD = False
                FE_NC = False
                FE_FE = False
                FE_ND = False
                FE_BV = False
                FE_BE = False
                FE_FC = False
            End If

            Directorio_CAF = P_DIRECTORIO & "\CAF\"
            If Not System.IO.Directory.Exists(Directorio_CAF) Then
                System.IO.Directory.CreateDirectory(Directorio_CAF)
            End If
            Directorio_TED = P_DIRECTORIO & "\TED\"
            If Not System.IO.Directory.Exists(Directorio_TED) Then
                System.IO.Directory.CreateDirectory(Directorio_TED)
            End If
            Directorio_PDF = P_DIRECTORIO & "\PDF\"
            If Not System.IO.Directory.Exists(Directorio_PDF) Then
                System.IO.Directory.CreateDirectory(Directorio_PDF)
            End If
            Directorio_TXT = P_DIRECTORIO & "\TXT\"
            If Not System.IO.Directory.Exists(Directorio_TXT) Then
                System.IO.Directory.CreateDirectory(Directorio_TXT)
            End If
            'P_DIRECTORIO = Environment.CurrentDirectory

        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    Public Function Es_Electronico(wTipoDoc As String) As Boolean
        Es_Electronico = False
        If FE_EsElectronica Then
            If FE_FV And wTipoDoc = "FV" Then Es_Electronico = True
            If FE_GD And wTipoDoc = "GD" Then Es_Electronico = True
            If FE_NC And wTipoDoc = "NC" Then Es_Electronico = True
            If FE_FE And wTipoDoc = "FE" Then Es_Electronico = True
            If FE_ND And wTipoDoc = "ND" Then Es_Electronico = True
            If FE_BV And wTipoDoc = "BV" Then Es_Electronico = True
            If FE_BE And wTipoDoc = "BE" Then Es_Electronico = True
            If FE_FC And wTipoDoc = "FV" Then Es_Electronico = True
        End If
    End Function

    Public Function Codigo_DTE_Consulta(wTipoDoc As String) As Integer
        If wTipoDoc = "BV" Then
            Return TipoDocumento.TIPO_39
        End If
        If wTipoDoc = "BE" Then
            Return TipoDocumento.TIPO_41
        End If
        If wTipoDoc = "FV" Then
            Return TipoDocumento.TIPO_33
        End If
        If wTipoDoc = "FE" Then
            Return TipoDocumento.TIPO_34
        End If
        If wTipoDoc = "FC" Then
            Return TipoDocumento.TIPO_46
        End If
        If wTipoDoc = "GD" Then
            Return TipoDocumento.TIPO_52
        End If
        If wTipoDoc = "NC" Then
            Return TipoDocumento.TIPO_61
        End If
        If wTipoDoc = "ND" Then
            Return TipoDocumento.TIPO_56
        End If
        If wTipoDoc = "OC" Then
            'No es electrónica, no existe para consulta al DTE
            Return 0
        End If

        Return 0
    End Function

    Public Function Codigo_DTE_EMISION(wTipoDoc As String) As Integer
        If wTipoDoc = "FV" Then
            Return DocumentoDTE.SiiDte.Enumerations.DTEType.n33
        End If
        If wTipoDoc = "GD" Then
            Return DocumentoDTE.SiiDte.Enumerations.DTEType.n52
        End If
        If wTipoDoc = "NC" Then
            Return DocumentoDTE.SiiDte.Enumerations.DTEType.n61
        End If
        If wTipoDoc = "ND" Then
            Return DocumentoDTE.SiiDte.Enumerations.DTEType.n56
        End If
        If wTipoDoc = "FE" Then
            Return DocumentoDTE.SiiDte.Enumerations.DTEType.n34
        End If
        If wTipoDoc = "BV" Then
            Return 39
        End If
        If wTipoDoc = "FC" Then
            Return DocumentoDTE.SiiDte.Enumerations.DTEType.n46
        End If
        Return 0
    End Function

    Public Function Codigo_Referencia_NC(wTipoDoc As String, wMotivo As String) As DocumentoDTE.SiiDte.Enumerations.Referencia_CodRef
        wMotivo = UCase(Trim(wMotivo))

        If wTipoDoc = "NC" Or wTipoDoc = "ND" Then
            If wMotivo = "A" Then
                Return DocumentoDTE.SiiDte.Enumerations.Referencia_CodRef.n1
            End If
            If wMotivo = "D" Then
                Return DocumentoDTE.SiiDte.Enumerations.Referencia_CodRef.n2
            End If
            If wMotivo = "O" Or wMotivo = "P" Then
                Return DocumentoDTE.SiiDte.Enumerations.Referencia_CodRef.n3
            End If
        End If
        Return DocumentoDTE.SiiDte.Enumerations.Referencia_CodRef.n1


    End Function

    Public Function Codigo_Referencia_GD(wTipoDoc As String, wMotivo As String) As DocumentoDTE.SiiDte.Enumerations.IdDoc_IndTraslado
        wMotivo = UCase(Trim(wMotivo))

        If wTipoDoc = "GD" Then
            If Trim(UCase(wMotivo)) = "O" Then  'DEVOLUCION
                Return DocumentoDTE.SiiDte.Enumerations.IdDoc_IndTraslado.n6
            End If
            If Trim(UCase(wMotivo)) = "S" Then  'TRANSITO
                Return DocumentoDTE.SiiDte.Enumerations.IdDoc_IndTraslado.n5
            End If
            If Trim(UCase(wMotivo)) = "M" Then  'MERMA
                Return DocumentoDTE.SiiDte.Enumerations.IdDoc_IndTraslado.n6
            End If
            If Trim(UCase(wMotivo)) = "V" Then  'VENTA
                Return DocumentoDTE.SiiDte.Enumerations.IdDoc_IndTraslado.n2
            End If
            If Trim(UCase(wMotivo)) = "T" Then 'TRASPASO
                Return DocumentoDTE.SiiDte.Enumerations.IdDoc_IndTraslado.n5
            End If
        End If
        Return DocumentoDTE.SiiDte.Enumerations.IdDoc_IndTraslado.n1
    End Function

    Public Function Codigo_SII(wTipoDoc As String) As Decimal
        If wTipoDoc = "" Then Return 0
        Dim DC As New RebuscoDataContext(P_CONEXION)
        Dim TipoDoc = DC.T_TipoDoc.FirstOrDefault(Function(x) x.TipoDoc = wTipoDoc)
        If TipoDoc Is Nothing Then Return 0
        Return TipoDoc.Cod_SII
    End Function

    Public Function Cambia_Car(wCar As String, wAsc As Integer) As String
        Cambia_Car = wCar
        If Trim(wCar) <> "" Then
            If Asc(wCar) = wAsc Then
                Cambia_Car = ""
            End If
        End If
    End Function

    'Public  Function Saca_Ciudad(wCiudad As String) As String
    '    If wCiudad = "" Then Return ""
    '    Dim DC As New MarketONEDataContext(P_CONEXION)
    '    Dim Ciudad = DC.T_Ciudades.FirstOrDefault(Function(x) x.Ciudad = wCiudad)
    '    If Ciudad Is Nothing Then Return wCiudad
    '    Return Ciudad.NombreCiudad
    'End Function

    Public Function Saca_Comuna(wComuna As String) As String
        If wComuna = "" Then Return ""
        Dim DC As New RebuscoDataContext(P_CONEXION)
        Dim Comuna = DC.T_Comunas.FirstOrDefault(Function(x) x.Codigo = wComuna)
        If Comuna Is Nothing Then Return wComuna
        Return Comuna.NombreComuna
    End Function

    Public Function Descripcion_Motivo(wTipoDoc As String, wMotivo As String) As String
        Dim DC As New RebuscoDataContext(P_CONEXION)
        Dim Motivo = DC.T_Motivos.FirstOrDefault(Function(x) x.Motivo = wMotivo And x.TipoDoc = wTipoDoc)
        If Motivo Is Nothing Then Return ""
        Return Mid(Motivo.DescMotivo, 1, 50)
    End Function

    Public Function Leer_JPG(pArchivo As String) As Byte()
        Try
            Dim wArchivo As New FileStream(pArchivo, FileMode.Open, FileAccess.Read)
            Dim Lectura As New BinaryReader(wArchivo)
            Dim Imagen(CInt(wArchivo.Length)) As Byte
            Lectura.Read(Imagen, 0, CInt(wArchivo.Length))
            wArchivo.Close()
            Return Imagen
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Rut_DTE(wRut As String) As String
        Dim wRutDTE = UCase(wRut).Replace("_", "").Replace(".", "")
        If wRutDTE(0) = "0" Then
            wRutDTE = wRutDTE.Substring(1)
        End If
        Return wRutDTE
    End Function

    Public Function FE_Fecha(wFecha As Date) As String
        'El formato que reconoce el DTE es YYYY-MM-DD
        Dim wFecha_DTE As String = wFecha.ToString
        wFecha_DTE = Mid(wFecha_DTE, 1, 10)
        wFecha_DTE = Replace(wFecha_DTE, "/", "")
        wFecha_DTE = Replace(wFecha_DTE, "-", "")
        wFecha_DTE = Mid(wFecha_DTE, 5, 5) + "-" + Mid(wFecha_DTE, 3, 2) + "-" + Mid(wFecha_DTE, 1, 2)
        Return (wFecha_DTE)
    End Function

    Public Function Texto_DTE(wTexto As String, Optional wLargo As Integer = 0) As String
        Dim Car As String, i As Integer, Texto_Resultado As String

        Texto_DTE = UCase(Trim(wTexto))
        Texto_DTE = Replace(Texto_DTE, "Á", "A")
        Texto_DTE = Replace(Texto_DTE, "Ä", "A")
        Texto_DTE = Replace(Texto_DTE, "É", "E")
        Texto_DTE = Replace(Texto_DTE, "Í", "I")
        Texto_DTE = Replace(Texto_DTE, "Ó", "O")
        Texto_DTE = Replace(Texto_DTE, "Ö", "O")
        Texto_DTE = Replace(Texto_DTE, "Ú", "U")
        Texto_DTE = Replace(Texto_DTE, "Ü", "U")
        Texto_DTE = Replace(Texto_DTE, "Ñ", "N")
        Texto_DTE = Replace(Texto_DTE, "²", "2")
        Texto_DTE = Replace(Texto_DTE, "º", "")
        Texto_DTE = Replace(Texto_DTE, "°", "")
        Texto_DTE = Replace(Texto_DTE, "°", "")
        Texto_DTE = Replace(Texto_DTE, "°", "")
        Texto_DTE = Replace(Texto_DTE, "º", "")
        Texto_DTE = Replace(Texto_DTE, "ª", "")
        Texto_DTE = Replace(Texto_DTE, "ª", "")
        Texto_DTE = Replace(Texto_DTE, "%", "")
        Texto_DTE = Replace(Texto_DTE, "$", "")
        Texto_DTE = Replace(Texto_DTE, "&", "")
        Texto_DTE = Replace(Texto_DTE, "*", "")
        Texto_DTE = Replace(Texto_DTE, "^", "")
        Texto_DTE = Replace(Texto_DTE, "~", "")
        Texto_DTE = Replace(Texto_DTE, "#", "")
        Texto_DTE = Replace(Texto_DTE, Chr(34), "")
        Texto_DTE = Replace(Texto_DTE, Chr(39), "")
        Texto_DTE = Replace(Texto_DTE, Chr(96), "")
        Texto_DTE = Replace(Texto_DTE, Chr(176), "")
        Texto_DTE = Replace(Texto_DTE, Chr(186), "")

        Texto_Resultado = ""
        'Sacar los caracteres no imprimibles despues de la limpieza de letras
        For i = 1 To Len(Texto_DTE)
            Car = Mid(Texto_DTE, i, 1)
            If Asc(Car) < 32 Or Asc(Car) > 122 Then
                'Eliminar si no es Imprimible
                Car = ""
            End If

            Car = Cambia_Car(Car, 34)   '"
            Car = Cambia_Car(Car, 35)   '#
            Car = Cambia_Car(Car, 39)   ''
            Car = Cambia_Car(Car, 58)   ':
            Car = Cambia_Car(Car, 59)   ';
            Car = Cambia_Car(Car, 64)   '@
            Car = Cambia_Car(Car, 94)   '^
            Car = Cambia_Car(Car, 96)   '´
            Car = Cambia_Car(Car, 60)   '<
            Car = Cambia_Car(Car, 61)   '=
            Car = Cambia_Car(Car, 62)   '>

            Texto_Resultado = Texto_Resultado + Car
        Next i

        Texto_DTE = Texto_Resultado

        If Trim(Texto_DTE) = "" Then
            Texto_DTE = ""
        End If

        If wLargo > 0 Then
            Texto_DTE = Mid(Texto_DTE + Space(wLargo), 1, wLargo)
        End If

    End Function
End Module
