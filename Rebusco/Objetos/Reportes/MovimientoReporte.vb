Public Class MovimientoReporte
    Public Property Movimiento As Integer
    Public Property Fecha As Date
    Public Property Bodega As String
    Public Property TipoMov As String
    Public Property NombreBodega As String
    Public Property Local As String
    Public Property NombreLocal As String
    Public Property UsuarioC As String
    Public Property UsuarioR As String
    Public Property Estado As String
    Public Property TipoDoc As String
    Public Property NumDoc As Integer
    Public Property Observacion As String
    Public Property Total As Double

    Public Property Articulo As String
    Public Property Descripcion As String
    Public Property Barra As String
    Public Property SKU As String
    Public Property Cantidad As Integer
    Public Property PVenta As Double
    Public Property Costo As Double
End Class
Public Class MovimientosReporte
    Public Property Movimiento As Integer
    Public Property Fecha As Date
    Public Property DescTipoDoc As String
    Public Property DescTipoMov As String
    Public Property NombreLocal As String
    Public Property NombreBodega As String
    Public Property NombreUsuario As String
    Public Property nombreResponsable As String
    Public Property DescEstado As String
    Public Property NumDoc As Double
    Public Property ObsTra As String
    Public Property Total As Double
End Class