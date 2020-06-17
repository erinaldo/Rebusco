Imports System.IO

Public Class CargarImagenes
    Implements CargaImagenes

    Const T_ELIMINAR = 0
    Const T_COPIAR = 1
    Const T_DIRECTORIOIMAGEN = 2
    Const T_COPIADO = 3
    Const T_NOMBREJPG = 4

    Dim Directorio As String

    Sub CargarDirectorio(ByVal wTitulo As String, ByVal wDirectorio As String) Implements CargaImagenes.CargarDirectorio
        Directorio = wDirectorio
        WinDeco1.Titulo.Text = wTitulo
    End Sub
    Private Sub CargarImagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = True
        DoEvents()
        lRuta.Text &= CONFIGURACION.RutaArchivos
    End Sub

    Private Sub CargarImagenes_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CargarAdjuntos()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        Close()
    End Sub

    Private Sub bCargarImagen_Click(sender As Object, e As EventArgs) Handles bCargarImagen.Click


        'Regularizar Nombres de archivos?

        If Directorio = "" Then Exit Sub
        Dim Ruta = $"{CONFIGURACION.RutaArchivos}/Articulos/{Directorio}/"
        Directory.CreateDirectory(Ruta)
        Dim Ubicacion = New DirectoryInfo(Ruta)
        Dim Archivos = Ubicacion.GetFiles("*.*")

        Dim extensiones = {"png", "jpg"}
        Dim filtro = extensiones.Aggregate(Function(x, y) $"Imágenes {x}|*.{x}" & "|" & $"Imágenes {y}|*.{y}").ToLower()

        oCargarImagen.Filter = filtro

        If oCargarImagen.ShowDialog = DialogResult.OK Then
            Dim wNombreArchivo = oCargarImagen.FileName
            'Dim wDestino = Path.Combine(Ruta, Path.GetFileName(wNombreArchivo))
            Dim wDestino = Path.Combine(Ruta, $"{Directorio}_{FechaArchivo()}{HoraArchivo()}{Path.GetExtension(wNombreArchivo)}")

            If File.Exists(Ruta & "\" & oCargarImagen.SafeFileName) Then
                If Pregunta("Ya existe una imagen con esta identificación, ¿Desea reemplazar?", "Imagen existente") Then
                    File.Copy(oCargarImagen.FileName, wDestino, True)
                End If
            Else
                File.Copy(oCargarImagen.FileName, wDestino)
            End If
            CargarAdjuntos()

        End If
    End Sub


    Private Sub VistaImagenes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VistaImagenes.SelectedIndexChanged

        Try
            Dim DC = New RebuscoDataContext(P_CONEXION)

            If VistaImagenes.SelectedIndices.Count = 0 Then Exit Sub
            Dim wItem = VistaImagenes.SelectedItems(0)
            Dim wDatosItem As DatosImagen = CType(wItem.Tag, DatosImagen)

            VistaPrevia.Tag = wDatosItem.Ruta
            Dim sz = wDatosItem.Imagen.Size

            Select Case wDatosItem.Extension
                Case "JPG"
                Case "PNG"
                    VistaPrevia.Image = wDatosItem.Imagen
                    VistaPrevia.SizeMode = PictureBoxSizeMode.Zoom
            End Select


        Catch ex As Exception
        End Try


    End Sub

    Public Sub CargarAdjuntos()

        If Directorio = "" Then Exit Sub
        Dim Ruta = $"{CONFIGURACION.RutaArchivos}/Articulos/{Directorio}/"
        Directory.CreateDirectory(Ruta)
        Dim Ubicacion = New DirectoryInfo(Ruta)

        lAdjuntos.Text = "0"

        ListaImagenes.Images.Clear()

        If ListaImagenes.Images.Count = 0 Then
            ListaImagenes.Images.Clear()
            VistaImagenes.Items.Clear()
            VistaImagenes.View = View.LargeIcon
            VistaImagenes.LargeImageList = ListaImagenes
            ListaImagenes.ImageSize = New Size(160, 160)
        End If

        For Each fileinfo As FileInfo In Ubicacion.GetFiles("*.*")
            Dim img = Path.GetFileNameWithoutExtension(fileinfo.FullName)
            Dim ext = Path.GetExtension(fileinfo.FullName).Replace(".", "").ToUpper

            Select Case ext

                Case "JPG", "BMP", "PNG", "JPEG"
                    Dim wImagen = File.ReadAllBytes(fileinfo.FullName)
                    If wImagen.Length = 0 Then
                        Dim bmp = My.Resources.ERROR160
                        ListaImagenes.Images.Add(bmp)
                        Dim wItem = New ListViewItem()
                        wItem.ImageIndex = ListaImagenes.Images.Count - 1
                        wItem.Text = img
                        wItem.Tag = New DatosImagen(ext, New Bitmap(bmp), fileinfo.FullName)
                        VistaImagenes.Items.Add(wItem)
                    Else
                        Using ms = New MemoryStream(wImagen)
                            Using bmp = New Bitmap(ms)
                                ListaImagenes.Images.Add(ThumbnailSquare(bmp, 160))
                                Dim wItem = New ListViewItem()
                                wItem.ImageIndex = ListaImagenes.Images.Count - 1
                                wItem.Text = img
                                wItem.Tag = New DatosImagen(ext, New Bitmap(bmp), fileinfo.FullName)
                                VistaImagenes.Items.Add(wItem)
                            End Using
                        End Using
                    End If

            End Select
        Next

        If VistaImagenes.Items.Count > 0 Then
            VistaImagenes.Items(0).Selected = True
            VistaImagenes.Select()
        End If

        lAdjuntos.Text = VistaImagenes.Items.Count.ToString()

    End Sub

    Private Sub bVerImagen_Click(sender As Object, e As EventArgs) Handles bVerImagen.Click
        If VistaImagenes.SelectedIndices.Count = 0 Then Exit Sub
        Dim wItem = VistaImagenes.SelectedItems(0)
        Dim img As DatosImagen = CType(wItem.Tag, DatosImagen)
        Process.Start(img.Ruta)
    End Sub

    Private Sub VistaPrevia_MouseDown(sender As Object, e As MouseEventArgs) Handles VistaPrevia.MouseDown
        If e.Button = MouseButtons.Left Then
            If VistaPrevia.Tag Is Nothing Then Exit Sub
            Process.Start(VistaPrevia.Tag.ToString())
        End If
    End Sub

    Private Sub VistaImagenes_MouseClick(sender As Object, e As MouseEventArgs) Handles VistaImagenes.MouseClick
        If Not e.Button = MouseButtons.Right Then Exit Sub
        If VistaImagenes.FocusedItem.Bounds.Contains(e.Location) Then
            mMenuTabla.Show(Cursor.Position)
        End If
    End Sub

    Private Sub bEliminarImagen_Click(sender As Object, e As EventArgs) Handles bEliminarImagen.Click
        If VistaImagenes.SelectedIndices.Count = 0 Then Exit Sub
        Dim wItem = VistaImagenes.SelectedItems(0)
        Dim img As DatosImagen = CType(wItem.Tag, DatosImagen)
        If Not Pregunta("¿Desea eliminar la imagen seleccionada?", "Confirmar eliminación") Then Exit Sub
        File.Delete(img.Ruta)
        CargarAdjuntos()
    End Sub

    Private Sub VistaImagenes_KeyDown(sender As Object, e As KeyEventArgs) Handles VistaImagenes.KeyDown
        If Not e.KeyCode = Keys.Delete Then Exit Sub
        If VistaImagenes.SelectedIndices.Count = 0 Then Exit Sub
        Dim wItem = VistaImagenes.SelectedItems(0)
        Dim img As DatosImagen = CType(wItem.Tag, DatosImagen)
        If Not Pregunta("¿Desea eliminar la imagen seleccionada?", "Confirmar eliminación") Then Exit Sub
        File.Delete(img.Ruta)
        CargarAdjuntos()
    End Sub

    Private Sub bEliminarSel_Click(sender As Object, e As EventArgs) Handles bEliminarSel.Click
        If VistaImagenes.SelectedIndices.Count = 0 Then Exit Sub
        Dim wItem = VistaImagenes.SelectedItems(0)
        Dim img As DatosImagen = CType(wItem.Tag, DatosImagen)
        If Not Pregunta("¿Desea eliminar la imagen seleccionada?", "Confirmar eliminación") Then Exit Sub
        File.Delete(img.Ruta)
        CargarAdjuntos()
    End Sub
End Class

Public Class DatosImagen
    Public Property Extension As String
    Public Property Imagen As Image
    Public Property Ruta As String
    Public Sub New(ext As String, img As Image, rt As String)
        Extension = ext
        Imagen = img
        Ruta = rt
    End Sub
End Class