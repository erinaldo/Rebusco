Public Class Tracking

    Public Enum Eventos
        SinEvento = 0
        OTIngresada = 300
        OTCerrada = 301
        StockCreado = 200
        StockEstablecido = 201
        StockIncrementado = 202
        StockDisminuido = 203
        StockRestablecido = 204
        ArticuloCreado = 250
        ArticuloModificado = 251
        ArticuloEliminado = 252
    End Enum

    Public Shared Function ExisteTrackingUsuario(Evento As Decimal, FechaRegistroReferencia As DateTime, AlertaSecuencial As Decimal, Usuario As String) As Boolean
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Return DC.T_Tracking.Any(Function(x) x.Evento = Evento AndAlso x.AlertaSecuencial = AlertaSecuencial AndAlso x.FechaRegistroReferencia.Date = FechaRegistroReferencia.Date AndAlso x.Usuario = Usuario)
    End Function

    Public Shared Function ExisteTrackingCliente(Evento As Decimal, FechaRegistroReferencia As DateTime, AlertaSecuencial As Decimal, Cliente As Decimal) As Boolean
        Dim DC = New RebuscoDataContext(P_CONEXION)
        Return DC.T_Tracking.Any(Function(x) x.Evento = Evento AndAlso x.AlertaSecuencial = AlertaSecuencial AndAlso x.FechaRegistroReferencia.Date = FechaRegistroReferencia.Date AndAlso x.Cliente = Cliente)
    End Function

    Public Shared Sub Ingresar(Evento As Decimal, FechaEvento As DateTime, Cliente As Decimal,
                                TipoDoc As String, NumDoc As Decimal,
                                FechaRegRef As DateTime, Secuencial As Decimal, Observacion As String,
                                Especificacion As String, Modulo As String)

        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim Eve = DC.T_Eventos.FirstOrDefault(Function(x) x.Evento = CDec(Evento))
        Dim Trk = New T_Tracking()

        Validacion.ValidateObj(Trk)

        Trk.FechaSys = DateTime.Now
        Trk.FechaEvento = FechaEvento
        Trk.Evento = Eve.Evento
        Trk.DescripcionEvento = Eve.Descripcion
        Trk.Local = G_LOCALACTUAL
        Trk.TipoDoc = TipoDoc
        Trk.NumDoc = NumDoc
        Trk.Cliente = Cliente
        Trk.Usuario = UsuarioActual
        Trk.Origen = "MKT"
        Trk.Observacion = Observacion
        Trk.AlertaGenerada = False
        Trk.FechaRegistroReferencia = FechaRegRef
        Trk.AlertaSecuencial = Secuencial
        Trk.Especificacion = Especificacion
        Trk.Modulo = Modulo.Trim.ToUpper()
        DC.T_Tracking.InsertOnSubmit(Trk)

        DC.SubmitChanges()

    End Sub

    Public Shared Sub Ingresar(Evento As Decimal, FechaEvento As DateTime, Cliente As Decimal,
                                TipoDoc As String, NumDoc As Decimal,
                                FechaRegRef As DateTime, Articulo As Decimal, Cantidad As Decimal,
                                Bodega As Decimal, Local As Decimal, Observacion As String, Modulo As String)

        If (Evento = Eventos.SinEvento) Then Exit Sub

        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim Eve = DC.T_Eventos.FirstOrDefault(Function(x) x.Evento = Evento)

        Dim Art = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = Articulo)
        Dim Trk = New T_Tracking()

        Validacion.ValidateObj(Trk)

        Trk.FechaSys = DateTime.Now
        Trk.FechaEvento = FechaEvento
        Trk.Evento = Evento
        Trk.DescripcionEvento = If(Eve?.Descripcion, "")
        Trk.Local = Local
        Trk.TipoDoc = TipoDoc
        Trk.NumDoc = NumDoc
        Trk.Cliente = Cliente
        Trk.Usuario = UsuarioActual
        Trk.Origen = "MKT"
        Trk.FechaRegistroReferencia = FechaRegRef
        Trk.Articulo = Articulo
        Trk.SKU = If(Art?.SKU, "")
        Trk.Descripcion = If(Art?.Descripcion, "")
        Trk.Cantidad = Cantidad
        Trk.Bodega = Bodega
        Trk.Observacion = Observacion
        Trk.AlertaGenerada = False
        Trk.Modulo = Modulo.Trim.ToUpper()
        DC.T_Tracking.InsertOnSubmit(Trk)

        DC.SubmitChanges()

    End Sub



End Class
