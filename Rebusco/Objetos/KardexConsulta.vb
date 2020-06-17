Imports System.ComponentModel

Public Class KardexConsulta
    <DisplayName("Fecha/Hora")>
    Public Property FechaHora As DateTime
    <DisplayName("Local")>
    Public Property Local As String
    <DisplayName("Bodega")>
    Public Property Bodega As String
    <Browsable(False)>
    <DisplayName("Artículo")>
    Public Property Articulo As Decimal
    <Browsable(False)>
    <DisplayName("SKU")>
    Public Property SKU As String
    <Browsable(False)>
    <DisplayName("Descripción")>
    Public Property Descripcion As String
    <Browsable(False)>
    <DisplayName("TipoMov")>
    Public Property TipoMov As String
    <DisplayName("Tipo de Mov.")>
    Public Property DescripcionMovimiento As String
    <DisplayName("TipoDoc")>
    <Browsable(False)>
    Public Property TipoDoc As String
    <DisplayName("Tipo de Doc.")>
    Public Property DescripcionTipoDoc As String
    <DisplayName("Modo")>
    <Browsable(False)>
    Public Property Modo As String
    <Browsable(False)>
    <DisplayName("Usuario")>
    Public Property Usuario As String
    <DisplayName("Número Documento")>
    Public Property NumDoc As Decimal
    <DisplayName("Entrada")>
    Public Property Entrada As Decimal
    <DisplayName("Salida")>
    Public Property Salida As Decimal
    <DisplayName("Saldo")>
    Public Property Saldo As Decimal
    <DisplayName("Usuario")>
    Public Property NombreUsuario As String
End Class

Public Class EncabezadoKardezReporte
    Public Property Articulo As String
    Public Property DescripcionArticulo As String
    Public Property SKU As String
    Public Property Desde As DateTime
    Public Property Hasta As DateTime
    Public Property Local As String
    Public Property Bodega As String
End Class
