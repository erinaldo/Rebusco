Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class Test
    Declare Function SetDefaultPrinter Lib "winspool.drv" Alias "SetDefaultPrinterA" (ByVal pszPrinter As String) As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wImagen = ImageToBase64(PictureBox1.Image, PictureBox1.Image.RawFormat)
        Dim ImagenW = Base64ToImage(wImagen)
        PictureBox2.Image = ImagenW
    End Sub
    Public Function ImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Using ms As MemoryStream = New MemoryStream()
            image.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function
    Public Function Base64ToImage(ByVal base64String As String) As Image
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As MemoryStream = New MemoryStream(imageBytes, 0, imageBytes.Length)
        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim image As Image = Image.FromStream(ms, True)
        Return image
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For Each wMenu In Principal.Barra.Items.OfType(Of ToolStripMenuItem)
            SQL("INSERT INTO Modulos (Menu, Texto) Values ('" & wMenu.Name & "','" & wMenu.Text.Replace("&", "") & "')")
            BuscarItem(wMenu)
        Next

    End Sub

    Public Function BuscarItem(ByVal Parent As MenuStrip) As ToolStripMenuItem
        Dim wItem As ToolStripMenuItem
        Dim wSubItem As ToolStripMenuItem
        For Each wItem In Parent.Items.OfType(Of ToolStripMenuItem)

            If TypeOf wItem IsNot ToolStripMenuItem Then Continue For

            If wItem.HasDropDownItems Then
                wSubItem = BuscarItem(wItem)
                If wSubItem IsNot Nothing Then Return wSubItem
            End If
        Next
        Return Nothing
    End Function

    Public Function BuscarItem(ByVal Parent As ToolStripMenuItem) As ToolStripMenuItem
        Dim wItem As ToolStripMenuItem
        Dim wSubItem As ToolStripMenuItem
        For Each wItem In Parent.DropDownItems.OfType(Of ToolStripMenuItem)

            If TypeOf wItem IsNot ToolStripMenuItem Then Continue For
            SQL("INSERT INTO Modulos (Menu, Texto) Values ('" & wItem.Name & "','" & wItem.Text.Replace("&", "") & "')")

            If wItem.HasDropDownItems Then
                wSubItem = BuscarItem(wItem)
                If wSubItem IsNot Nothing Then Return wSubItem
            End If
        Next
        Return Nothing
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim wFila = 1

        Dim wListaArray As String() = Clipboard.GetText().Split(CType(vbCrLf, Char()))
        Dim wListaCompos As New List(Of Campos)
        wFila = 1

        For Each wFilaPedido As String In wListaArray
            Dim wPartes As String() = wFilaPedido.Split(CType(vbTab, Char()))
            If wPartes.Count <> 3 Then Continue For
            wListaCompos.Add(New Campos With {.ID = wPartes(0).Trim,
                                            .Desc = wPartes(1).Trim,
                                            .Opt1 = wPartes(2).Trim})




            'Dim DC = New MarketONEDataContext(P_CONEXION)
            'Dim wComunaPASO As New ComunaPASO()
            'wComunaPASO.Codigo = wPartes(0).Trim
            'wComunaPASO.NombreComuna = FormatoTexto(wPartes(1).Trim)
            'wComunaPASO.Region = wPartes(2).Trim
            'wComunaPASO.CodigoArea = 0
            'wComunaPASO.Alias = wPartes(3).Trim
            'DC.ComunaPASO.InsertOnSubmit(wComunaPASO)
            'DC.SubmitChanges()
        Next
        Dim DC = New MarketONEDataContext(P_CONEXION)
        For Each wItem In wListaCompos

            Dim wSubFamilia = New T_SubFamilias With {
                .SubFamilia = wItem.ID.ToDecimal(),
                .DescSubFamilia = wItem.Desc.Trim(),
                .Familia = wItem.Opt1.ToDecimal()}
            DC.T_SubFamilias.InsertOnSubmit(wSubFamilia)
            DC.SubmitChanges()
        Next

        'Dim DC = New MarketONEDataContext(P_CONEXION)
        'For Each wLC In wListaCompos
        '    Dim wComunaExistente = DC.ComunaPASO.FirstOrDefault(Function(x) x.Codigo = wLC.ID)
        '    If wComunaExistente Is Nothing Then
        '        Dim wComunaPASO As New ComunaPASO()
        '        wComunaPASO.Codigo = wLC.ID
        '        wComunaPASO.NombreComuna = FormatoTexto(wLC.Desc)
        '        wComunaPASO.Region = wLC.Opt1
        '        wComunaPASO.CodigoArea = 0
        '        wComunaPASO.Alias = ""
        '        DC.ComunaPASO.InsertOnSubmit(wComunaPASO)
        '        DC.SubmitChanges()
        '    End If
        'Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wClientes = DC.T_Clientes.Where(Function(x) x.Comuna <> "00000")
        For Each wC In wClientes
            SQL("Update Clientes SET Comuna = '" & wC.Comuna.ToString.PadLeft(5, CChar("0")) & "' WHERE Cliente = " & wC.Cliente)
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wCli = DC.T_Clientes()
        Dim wCom = DC.T_Comunas().ToList()

        For Each wC In wCli
            Dim wBuscarAliasComuna = wCom.Any(Function(x) x.Alias = wC.Comuna)
            If wBuscarAliasComuna Then
                wC.Comuna = wCom.FirstOrDefault(Function(x) x.Alias = wC.Comuna).Codigo
            Else
                wC.Comuna = wC.Comuna
            End If
            Dim wBuscarAliasCiudad = wCom.Any(Function(x) x.Alias = wC.Ciudad)
            If wBuscarAliasCiudad Then
                wC.Ciudad = wCom.FirstOrDefault(Function(x) x.Alias = wC.Ciudad).Codigo
            Else
                wC.Ciudad = wC.Ciudad
            End If
            DC.SubmitChanges()
        Next
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wArt = DC.T_Articulos()
        Dim wCont = 1
        For Each wA In wArt
            wA.SKU = wA.Articulo.ToString
            wA.Articulo = wCont
            wCont += 1
        Next
        DC.SubmitChanges()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wModulos = DC.T_Modulos.ToList()

        For Each wModulo In wModulos
            Dim wAcceso As New T_PermisosAcceso With {
                .Acceso = 9,
                .Modulo = wModulo.Modulo
            }
            DC.T_PermisosAcceso.InsertOnSubmit(wAcceso)
        Next
        DC.SubmitChanges()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wModulos = DC.T_Modulos.ToList()

        For Each wModulo In wModulos
            Dim wAcceso As New T_PermisosUsuario With {
                .Usuario = "PED",
                .Modulo = wModulo.Modulo
            }
            DC.T_PermisosUsuario.InsertOnSubmit(wAcceso)
        Next

        DC.SubmitChanges()
    End Sub



    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Impresoras As String
        For Each Impresoras In PrinterSettings.InstalledPrinters
            ComboBox1.Items.Add(Impresoras.ToString)
        Next
        oStockObligatorio.Checked = P_STOCKOBLIGATORIO
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SetDefaultPrinter(ComboBox1.Text)
    End Sub


    Private Sub Button22_Click(sender As Object, e As EventArgs)
        Dim DC = New MarketONEDataContext("Data Source=190.13.151.66;Initial Catalog=MarketONE;User ID=wikets;Password=software")
        Dim wOTDet = DC.T_OTDet
        For Each wOT In wOTDet
            Dim wArticulo = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wOT.Articulo)
            If wArticulo IsNot Nothing Then
                wOT.PVenta = wArticulo.PVenta
            End If
        Next
        DC.SubmitChanges()
    End Sub



    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        BuscadorArticulo.Show()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wUsuarios = DC.T_Usuarios
        For Each wUsuario In wUsuarios
            Dim wClaveAntigua = Descripta(wUsuario.Clave)
            Dim wClaveNueva = Encriptar(wClaveAntigua)
            wUsuario.Clave = wClaveNueva
        Next
        DC.SubmitChanges()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click

        Dim wImagen = oDirectorio.ShowDialog()

        If wImagen = Windows.Forms.DialogResult.OK Then
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wLocales = DC.T_Locales
            Dim imgStream As MemoryStream = New MemoryStream()
            Image.FromFile(oDirectorio.FileName).Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
            imgStream.Close()
            Dim byteArray As Byte() = imgStream.ToArray()
            imgStream.Dispose()

            For Each local In wLocales
                local.LogoVoucher = byteArray
            Next
            DC.SubmitChanges()
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click

        Dim wConsultaTablas = SQL("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE COLUMN_NAME = 'Rut' order by DATA_TYPE")

        For Each wtabla As DataRow In wConsultaTablas.Rows
            Dim wModificarRut = SQL("SELECT RUT FROM " & wtabla.GetText("TABLE_NAME"))
            For Each wRut As DataRow In wModificarRut.Rows
                SQL("UPDATE " & wtabla.GetText("TABLE_NAME") & " SET RUT = '" & FormatoRut(wRut.GetText("Rut")) & "' WHERE RUT = '" & wRut.GetText("RUT") & "'")
            Next
        Next

        'Dim DC = New MarketONEDataContext(P_CONEXION)


        'Dim wClientes = DC.T_Clientes

        'For Each wCliente In wClientes
        '    wCliente.Rut = FormatoRut(wCliente.Rut)
        'Next

        'Dim DC
        'DC.SubmitChanges()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        ConsultarDatoBicicleta.Show()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim wDC = New MarketONEDataContext(P_CONEXION)
        'Dim wMovimientos = wDC.T_MovGen.Where(Function(x) x.Fecha < New DateTime(2020, 2, 2, 15, 45, 29))
        'For Each wMov In wMovimientos
        '    Dim wDetallesMov = wDC.T_MovDet.Where(Function(x) x.Movimiento = wMov.Movimiento)
        '    Dim wMovGenExiste = wDC.T_Tracking.FirstOrDefault(Function(x) x.NumDoc = wMov.Movimiento And x.TipoDoc = "MV")
        '    If wMovGenExiste IsNot Nothing Then Continue For

        '    For Each wDetalle In wDetallesMov
        '        Dim wTipoEvento As Tracking.Eventos
        '        If {"E", "P", "R"}.Contains(wMov.TipoMov) Then
        '            wTipoEvento = Tracking.Eventos.StockIncrementado
        '        ElseIf {"C", "D", "M", "N", "S", "V"}.Contains(wMov.TipoMov) Then
        '            wTipoEvento = Tracking.Eventos.StockDisminuido
        '        End If

        '        'Tracking.Ingresar(wTipoEvento, wMov.Fecha, 0, wMov.TipoDoc, wMov.NumDoc, wMov.Fecha, wDetalle.Articulo, wDetalle.Cantidad, wMov.Bodega, wMov.Local, "", "GENERAR MOVIMIENTOS")
        '        Tracking.Ingresar(wTipoEvento, wMov.Fecha, 0, TiposDoc.Movimiento, wMov.Movimiento, wMov.Fecha, wDetalle.Articulo, wDetalle.Cantidad.ToDecimal(), wMov.Bodega, wMov.Local, "", "GENERAR MOVIMIENTOS")
        '    Next
        'Next

        Dim wDocumentosG = wDC.T_DocumentosG.Where(Function(x) x.Fecha < New DateTime(2020, 2, 2, 15, 45, 29) And x.TipoDoc = "B")
        For Each wDoc In wDocumentosG
            Dim wDetalleDoc = wDC.T_DocumentosD.Where(Function(x) x.Numero = wDoc.Numero)
            For Each wDetalle In wDetalleDoc
                Dim wTipoEvento As Tracking.Eventos = Nothing

                If {"BV", "FE", "FV", "GD", "GI", "ND", "NV", "BM", "B"}.Contains(wDoc.TipoDoc) Then
                    wTipoEvento = Tracking.Eventos.StockDisminuido
                End If

                If wTipoEvento <> Nothing Then
                    Tracking.Ingresar(Tracking.Eventos.StockDisminuido, wDoc.Fecha, wDoc.Cliente, wDoc.TipoDoc, wDoc.Numero, wDoc.Fecha,
                    wDetalle.Articulo, wDetalle.Cantidad.ToDecimal(), wDoc.Bodega, wDoc.Local, wDoc.Observaciones, "VENTA LOCAL")
                End If
            Next
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim wDC = New MarketONEDataContext(P_CONEXION)
        Dim wListaArray As String() = Clipboard.GetText().Split(CType(vbCrLf, Char()))
        Dim wListaCompos As New List(Of Campos)
        Dim wFila = 1

        For Each wFilaPedido As String In wListaArray
            Dim wPartes As String() = wFilaPedido.Split(CType(vbTab, Char()))
            If wPartes.Count <> 16 Then Continue For

            Dim wMovGenConsulta = wDC.T_MovGen.FirstOrDefault(Function(x) x.Movimiento = wPartes(0).ToDecimal())
            If wMovGenConsulta IsNot Nothing Then Continue For

            Dim wMovGen = New T_MovGen With
                {
                    .Movimiento = wPartes(0).ToDecimal(),
                    .Fecha = wPartes(1).ToDateTime(),
                    .Hora = wPartes(2).ToString(),
                    .TipoMov = wPartes(3).Trim,
                    .Local = wPartes(4).ToDecimal(),
                    .Bodega = wPartes(5).ToDecimal(),
                    .Destino = wPartes(6).ToDecimal(),
                    .Usuario = wPartes(7).Trim,
                    .Responsable = wPartes(8),
                    .Estado = wPartes(9).Trim,
                    .TipoDoc = wPartes(10).Trim,
                    .NumDoc = wPartes(11).ToDecimal(),
                    .ObsTra = wPartes(13).Trim,
                    .Total = wPartes(14).ToDecimal(),
                    .Cargado = True
                }
            wDC.T_MovGen.InsertOnSubmit(wMovGen)
            wDC.SubmitChanges()
        Next
        'wDC.SubmitChanges()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = Encriptar(TextBox1.Text)
    End Sub
End Class
Public Class Campos

    Property ID As String
    Property Desc As String
    Property Opt1 As String
    Property Opt2 As String
    Property Opt3 As String

End Class
Public Class TestReport
    Property Sat As Double
    Property OT As Double
    Property Cliente As Double
    Property nombreCLiente As String
    Property Remitente As Double
    Property NombreRemitente As String
    Property Destino As Double
    Property NombreDestino As String
    Property NumDoc As Double
End Class