Imports System.ComponentModel
Public Class DocumentoListado
    Implements ICloneable

    Public Function Clone() As Object Implements ICloneable.Clone
        Return Me.MemberwiseClone()
    End Function

    Public Function Clonar() As DocumentoListado
        Return CType(Clone(), DocumentoListado)
    End Function

    <DisplayName("Local")>
    Public Property Local As Double
    Public Property TipoDoc As String
    <DisplayName("Tipo doc.")>
    Public Property DescTipoDoc As String
    <DisplayName("Número")>
    Public Property Documento As Decimal
    <DisplayName("Ticket")>
    Public Property Ticket As Double
    <DisplayName("Fecha")>
    Public Property Fecha As Date
    <DisplayName("Rut")>
    Public Property Rut As String
    <DisplayName("Cliente")>
    Public Property Cliente As Decimal
    <DisplayName("Nombre")>
    Public Property NombreCliente As String
    <DisplayName("Estado")>
    Public Property Estado As String
    Public Property FPago As String
    <DisplayName("Forma Pago")>
    Public Property DescFPago As String
    <DisplayName("Vendedor")>
    Public Property Vendedor As String
    <DisplayName("Sub-Total")>
    Public Property SubTotal As Double
    <DisplayName("Descuento")>
    Public Property Descuento As Double
    <DisplayName("Neto")>
    Public Property Neto As Double
    <DisplayName("IVA")>
    Public Property Iva As Double
    <DisplayName("Total")>
    Public Property Total As Double
    Public Property Articulo As String
    Public Property Descripcion As String
    Public Property Cantidad As Double
    Public Property Precio As Double
End Class
