Imports System.Linq

Public Class DocumentoReporte
    Public Property NombreFantasia As String
    Public Property NombreLocal As String
    Public Property NombreEncargado As String
    Public Property Giro As String
    Public Property Rut As String
    Public Property Direccion As String
    Public Property Ciudad As String
    Public Property Correo As String
    Public Property Telefono As String
    Public Property SSI As String
    Public Property NResolucion As Decimal
    Public Property AñoResolucion As Date
    Public Property LogoVocuher As Byte()

    Sub New()
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wLocal = DC.T_Locales.FirstOrDefault(Function(x) x.Local = G_LOCALACTUAL)
        If wLocal IsNot Nothing Then
            Dim wComuna = DC.T_Comunas.FirstOrDefault(Function(x) x.NombreComuna = wLocal.Comuna)
            NombreFantasia = wLocal.NombreLocal
            NombreLocal = wLocal.RazonLocal
            Giro = wLocal.GiroLocal
            NombreEncargado = ""
            Rut = wLocal.RutLocal
            Direccion = wLocal.DirLocal
            Ciudad = If(wComuna Is Nothing, "", wComuna.NombreComuna)
            Correo = wLocal.EMailLocal
            Telefono = wLocal.TelefonosLocal
            SSI = wLocal.SII
            NResolucion = wLocal.NResolucion
            AñoResolucion = wLocal.FResolucion
            LogoVocuher = wLocal.LogoVoucher
        End If
    End Sub
End Class
Public Class ReporteEncabezadoDocumento
    Public Property NumDoc As Decimal
    Public Property TipoDoc As String
    Public Property FechaEmisión As Date
    Public Property FPago As String
    Public Property NombreCliente As String
    Public Property Rut As String
    Public Property Giro As String
    Public Property Direccion As String
    Public Property Ciudad As String
    Public Property Comuna As String
    Public Property Correo As String
    Public Property Telefono As String
    Public Property Vendedor As String
    Public Property Timbre As Byte()
    Public Property Efectivo As Boolean
    Public Property Descuento As Decimal
    Public Property Total As Decimal

    Public Property Caja As Decimal
    Public Property POS As Decimal
    Public Property Local As Decimal
    Public Property TipoCopia As String


    Sub New(wNumDoc As Decimal, wTipoDoc As DocumentoPago)
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Caja = G_POS
        POS = G_POS
        Local = G_LOCALACTUAL

        Dim wClientes = DC.T_Clientes.ToList()
        Dim wComunas = DC.T_Comunas.ToList()
        Dim wUsuarios = DC.T_Usuarios.ToList()

        Select Case wTipoDoc
            Case DocumentoPago.Boleta
                Dim wEncabezadoBoleta = DC.T_DocumentosG.FirstOrDefault(Function(x) x.Numero = wNumDoc And x.TipoDoc = "BV")
                Efectivo = DC.T_DocumentosP.Any(Function(x) x.TipoDoc = "BO" And x.Numero = wNumDoc And x.FPago = "E")
                If wEncabezadoBoleta IsNot Nothing Then
                    NumDoc = wEncabezadoBoleta.Numero
                    TipoDoc = "BOLETA ELECTRONICA"
                    FechaEmisión = Now
                    FPago = "EFECTIVO"

                    Dim wCliente = wClientes.FirstOrDefault(Function(x) x.Cliente = wEncabezadoBoleta.Cliente)

                    If wCliente Is Nothing Then
                        MsgError("Error al obtener cliente: " & wEncabezadoBoleta.Cliente)
                        Throw New System.Exception("No se pudo crear el encabezado")
                    End If

                    Dim wComuna = wComunas.FirstOrDefault(Function(x) x.Codigo = wCliente.Comuna)

                    If wComuna Is Nothing Then
                        MsgError("Error al obtener ciudad: " & wCliente.Ciudad)
                        Throw New System.Exception("No se pudo crear el encabezado")
                    End If

                    NombreCliente = wCliente.Nombre
                    Rut = wEncabezadoBoleta.Rut
                    Giro = wCliente.Giro
                    Direccion = wCliente.Direccion
                    Dim wCiudadCliente = wCliente.Ciudad
                    Ciudad = wComuna.NombreComuna
                    Correo = wCliente.Email
                    Telefono = wCliente.Telefonos

                    Dim wVendedor = wUsuarios.FirstOrDefault(Function(x) x.Usuario = wEncabezadoBoleta.Vendedor)

                    If wVendedor Is Nothing Then
                        MsgError("Error al obtener tarjeta: " & wEncabezadoBoleta.Usuario)
                        Throw New System.Exception("No se pudo crear el encabezado")
                    End If

                    Vendedor = wVendedor.NombreUsr
                    Timbre = wEncabezadoBoleta.Firma
                    Descuento = Convert.ToDecimal(wEncabezadoBoleta.Descuento)
                    Total = Convert.ToDecimal(wEncabezadoBoleta.Total)
                    TipoCopia = "COPIA CLIENTE"

                    Select Case wEncabezadoBoleta.FPago
                        Case "E"
                            FPago = "EFECTIVO"
                        Case "V"
                            FPago = "VARIAS FORMAS"
                        Case "O"
                            FPago = "OTRA FORMA"
                    End Select

                End If
            Case DocumentoPago.Factura
                Dim wEncabezadoFactura = DC.T_DocumentosG.FirstOrDefault(Function(x) x.Numero = wNumDoc And x.TipoDoc = "FV")
                Efectivo = DC.T_DocumentosP.Any(Function(x) x.TipoDoc = "FV" And x.Numero = wNumDoc And x.FPago = "E")
                If wEncabezadoFactura IsNot Nothing Then
                    NumDoc = wEncabezadoFactura.Numero
                    TipoDoc = "FACTURA ELECTRONICA"
                    FechaEmisión = Now

                    Select Case wEncabezadoFactura.FPago.Trim
                        Case "E"
                            FPago = "EFECTIVO"
                        Case "V"
                            FPago = "VARIAS FORMAS"
                        Case "O"
                            FPago = "OTRA FORMA"
                    End Select

                    'FPago = wEncabezadoFactura.FPago

                    Dim wCliente = wClientes.FirstOrDefault(Function(x) x.Cliente = wEncabezadoFactura.Cliente)

                    If wCliente Is Nothing Then
                        MsgError("Error al obtener cliente: " & wEncabezadoFactura.Cliente)
                        Throw New System.Exception("No se pudo crear el encabezado")
                    End If

                    Dim wComuna = wComunas.FirstOrDefault(Function(x) x.Codigo = wCliente.Comuna)

                    If wComuna Is Nothing Then
                        MsgError("Error al obtener ciudad: " & wCliente.Ciudad)
                        Throw New System.Exception("No se pudo crear el encabezado")
                    End If

                    NombreCliente = wCliente.Nombre
                    Rut = wEncabezadoFactura.Rut
                    Giro = wCliente.Giro
                    Direccion = wCliente.Direccion
                    Dim wCiudadCliente = wCliente.Ciudad
                    Ciudad = wComuna.NombreComuna
                    Correo = wCliente.Email
                    Telefono = wCliente.Telefonos

                    Dim wTarjeta = wUsuarios.FirstOrDefault(Function(x) x.Usuario = wEncabezadoFactura.Usuario)

                    If wTarjeta Is Nothing Then
                        MsgError("Error al obtener tarjeta: " & wEncabezadoFactura.Usuario)
                        Throw New System.Exception("No se pudo crear el encabezado")
                    End If

                    Vendedor = wTarjeta.NombreUsr
                    Timbre = wEncabezadoFactura.Firma
                    Descuento = Convert.ToDecimal(wEncabezadoFactura.Descuento)
                    Total = wEncabezadoFactura.Numero
                End If
        End Select
    End Sub
End Class
Public Class ReporteDetalleDocumento
    Public Property Boleta As Decimal
    Public Property Articulo As String
    Public Property Cantidad As Decimal
    Public Property PrecioUnidad As Decimal
    Public Property Impuesto As Decimal
    Public Property Total As Decimal
End Class
