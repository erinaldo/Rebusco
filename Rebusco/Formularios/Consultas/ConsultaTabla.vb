Public Class ConsultaTabla
    Dim gConsulta As String


    Private Sub Listados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Auditoria(WinDeco1.Titulo.Text, A_INGRESADO, "", "")
        tMensajeBarra.Text = "Listo"
        tBarraProgreso.Visible = False
    End Sub
    Public Sub ConsultaTabla(wTitulo As String, wTabla As String)
        gConsulta = wTabla
        WinDeco1.Titulo.Text = wTitulo
    End Sub
    Private Sub bMostrar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        Select Case gConsulta
            Case "Articulos"
                Listado_Articulos()
            Case "Ciudades"
                Listado_Ciudades()
            Case "TipoDocumento"
                Listado_TipoDocumentos()
            Case "Familias"
                Listado_Familias()
            Case "Eventos"
                Listado_Eventos()
            Case "Unidades"
                Listado_UnidadMedida()
            Case "Bodegas"
                Listado_Bodegas()
            Case "Correlativos"
                Listado_Correlativo()
            Case "TipoMovimiento"
                Listado_TipoMovimientos()
            Case "FormaPagos"
                Listado_FormaPagos()
            Case "Estados"
                Listado_Estados()
            Case "Usuarios"
                listado_Usuarios()
            Case "Accesos"
                Listado_Accesos()


        End Select
    End Sub
    Sub Listado_TipoDocumentos()
        Dim wQuery = "SELECT TipoDoc as 'Tipo Documento', DescTipoDoc as 'Descripción', Electronica as 'Electrónica', Cod_SII as 'Código en SII' FROM TipoDoc order by TipoDoc"
        LLenarGrilla(wQuery)
    End Sub

    Sub Listado_Familias()
        Dim wQuery = "SELECT Familia, DescFamilia as 'Nombre Familia' FROM Familias ORDER BY DescFamilia"
        LLenarGrilla(wQuery)
    End Sub
    Sub Listado_Eventos()
        Dim wQuery = "SELECT EventoRem as Evento, DescEventoRem as 'Descripción', CalculoRem as Cálculo FROM EventosRem"
        LLenarGrilla(wQuery)
    End Sub
    Sub Listado_UnidadMedida()
        Dim wQuery = "SELECT Unidad,DescUnidad as Descripción FROM Unidades ORDER BY DescUnidad"
        LLenarGrilla(wQuery)
    End Sub
    Sub Listado_Bodegas()
        Dim wQuery = "SELECT Bodega, NombreBodega as 'Nombre Bodega' FROM Bodegas ORDER BY Bodega"
        LLenarGrilla(wQuery)
    End Sub
    Sub Listado_Correlativo()
        Dim wQuery = "SELECT L.NombreLocal as Local,C.Caja,T.DescTipoDoc as 'Tipo Documento' ,C.Correlativo as 'Correlativo Actual',Inicial as 'Folio Inicial',Final as 'Folio Final',FechaCAF as 'Fecha CAF' FROM Correlativos C Join Locales L ON C.Local = L.Local" &
                     " Join TipoDoc T ON C.TipoDoc = T.TipoDoc ORDER BY T.DescTipoDoc"
        LLenarGrilla(wQuery)
    End Sub
    Sub Listado_TipoMovimientos()
        Dim wQuery = "SELECT TipoMov as Tipo,DescTipo as Descripción, Ajuste FROM TipoMov ORDER BY DescTipo"
        LLenarGrilla(wQuery)
    End Sub
    Sub Listado_FormaPagos()
        Dim wQuery = "SELECT FPago as Pago, DescFPago as Descripción FROM Fpagos ORDER BY DescFPago"
        LLenarGrilla(wQuery)
    End Sub
    Sub Listado_Estados()
        Dim wQuery = "SELECT Estado, DescEstado as Descripción, Tipo FROM Estados ORDER BY DescEstado"
        LLenarGrilla(wQuery)
    End Sub
    Sub listado_Usuarios()
        Dim wQuery = "Select u.Usuario, u.NombreUsr as Nombre,u.Rut,a.NombreAcceso as 'Tipo de Acceso' FROM Usuarios as U,Accesos as a where u.Acceso=a.Acceso ORDER BY Usuario"
        LLenarGrilla(wQuery)
    End Sub
    Sub Listado_Accesos()
        Dim wQuery = "SELECT Acceso,NombreAcceso as 'Tipo de Acceso' FROM Accesos ORDER BY Acceso"
        LLenarGrilla(wQuery)
    End Sub
    Sub Listado_Ciudades()
        Dim wQuery = "SELECT Ciudad, NombreCiudad as Nombre,CodigoArea as 'Código de Área', Region as 'Región' FROM Ciudades ORDER BY Ciudad"
        LLenarGrilla(wQuery)
    End Sub
    Sub Listado_Articulos()
        Dim wQuery = "SELECT A.Articulo, A.Descripcion, U.DescUnidad, F.Descfamilia FROM Articulos A JOIN Unidades U ON A.Unidad = U.Unidad" &
                     " JOIN Familias F ON A.Familia = F.Familia ORDER BY A.Descripcion"
        LLenarGrilla(wQuery)
    End Sub
    Sub Listado_EstadoClientes()
        Dim wQuery = "SELECT C.Cliente, C.Nombre, E.DescEstado as Estado FROM Clientes C JOIN Estados E ON C.Estado = E.Estado and E.Tipo = 'C' ORDER BY C.Nombre"
        LLenarGrilla(wQuery)
    End Sub
    Private Sub LLenarGrilla(wQuery As String)
        Dim wFila As Integer

        Me.Cursor = Cursors.WaitCursor

        Dim Swap = SQL(wQuery)
        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = Swap.Columns.Count
        'Se obtiene el Nombre de las Columnas desde la consulta SQL
        For i = 0 To Swap.Columns.Count - 1
            xTabla.SetData(0, i, Swap.Columns(i).ColumnName)
            xTabla.Cols(i).Width = 1
        Next
        wFila = 1
        xTabla.Redraw = False
        tBarraProgreso.Visible = True
        tBarraProgreso.Maximum = Swap.Rows.Count
        tBarraProgreso.Value = 0
        tMensajeBarra.Text = "Cargando..."

        'Se llenan las Columnas con los Datos de la Consulta
        For Each wT As DataRow In Swap.Rows
            DoEvents()
            xTabla.AddItem("")
            tBarraProgreso.Visible = True
            For Col = 0 To xTabla.Cols.Count - 1
                xTabla.SetData(xTabla.Rows.Count - 1, Col, wT(Col).ToString.Trim)
            Next Col
            tBarraProgreso.Value += 1
        Next

        tMensajeBarra.Text = "Listo"
        tBarraProgreso.Visible = False
        xTabla.AjustarColumnas
        xTabla.Redraw = True
        xTabla.Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub
End Class