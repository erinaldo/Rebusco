Imports System.ComponentModel

Public Class ManCiudades
    'Implements iFormulario
    'Private Sub ManBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Limpiar()
    '    bGuardar.Text = "Guardar"
    '    xCiudad.Focus()
    '    Auditoria(Me.Text, A_INGRESO, "", "")
    'End Sub
    'Private Sub xCiudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCiudad.KeyPress
    '    e.NextControl(xDescripcion)
    'End Sub

    'Private Sub xCiudad_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xCiudad.Validating
    '    Try
    '        If xCiudad.Text.Trim <> "" Then
    '            Dim wCiu = SQL("SELECT * FROM Ciudades WHERE Ciudad = '" & xCiudad.Text.Trim & "'").Top
    '            If wCiu IsNot Nothing Then
    '                xDescripcion.Text = wCiu.GetText("NombreCiudad")
    '                xRegion.Text = wCiu.GetText("Region")
    '                xArea.Text = wCiu.GetText("CodigoArea")
    '                bGuardar.Text = "Modificar"
    '            Else
    '                xDescripcion.Focus()
    '                bGuardar.Text = "Guardar"
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
    '    Dim wMensaje As String() = {MSGM, A_MODIFICO}
    '    Cursor = Cursors.WaitCursor
    '    If xCiudad.Text = "" Then
    '        MsgError("Ingrese Ciudad")
    '        xCiudad.Focus()
    '        Exit Sub
    '    End If
    '    If xDescripcion.Text = "" Then
    '        MsgError("Ingrese Nombre Ciudad")
    '        xDescripcion.Focus()
    '        Exit Sub
    '    End If
    '    If xRegion.Text = "" Then
    '        MsgError("Ingrese Región")
    '        xRegion.Focus()
    '        Exit Sub
    '    End If
    '    If xArea.Text = "" Then
    '        MsgError("Ingrese Área")
    '        xRegion.Focus()
    '        Exit Sub
    '    End If

    '    Dim DC = New MarketONEDataContext(P_CONEXION)
    '    Dim wCiu As New T_Ciudades
    '    Dim qCiu = DC.T_Ciudades.FirstOrDefault(Function(x) x.Ciudad = xCiudad.Text.Trim)

    '    If qCiu IsNot Nothing Then wCiu = qCiu
    '    wCiu.Ciudad = xCiudad.Text.Trim
    '    wCiu.NombreCiudad = xDescripcion.Text.Trim
    '    wCiu.Region = CShort(xRegion.Text.Trim)
    '    wCiu.CodigoArea = CShort(xArea.Text.Trim)

    '    If qCiu Is Nothing Then
    '        DC.T_Ciudades.InsertOnSubmit(wCiu)
    '        wMensaje = {MSGG, A_GUARDO}
    '    End If
    '    Auditoria(Me.Text, wMensaje(1), xCiudad.Text.Trim, xDescripcion.Text.Trim)
    '    MsgBox(wMensaje(0))
    '    Limpiar()
    '    Cursor = Cursors.Arrow
    'End Sub

    'Private Sub Limpiar()
    '    xCiudad.Clear()
    '    xDescripcion.Clear()
    '    xRegion.Clear()
    '    xArea.Clear()
    '    bGuardar.Text = "Guardar"
    '    xCiudad.Focus()

    'End Sub

    'Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
    '    Limpiar()
    'End Sub

    'Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
    '    Close()
    'End Sub
    'Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
    '    Try
    '        If xCiudad.Text.Trim <> "" Then
    '            If ValidarEliminar("Cliente", xCiudad.Text.Trim, "Ciudades") Then
    '                MsgError("No se puede eliminar la Ciudad")
    '            Else
    '                SQL("DELETE FROM Ciudades WHERE Ciudad = '" & xCiudad.Text.Trim & "'")
    '                MsgBox("Ciudad eliminada correctamente")
    '                Limpiar()
    '                Auditoria(Me.Text, A_ELIMINO, xCiudad.Text.Trim, xDescripcion.Text.Trim)
    '                xCiudad.Focus()
    '            End If
    '            End If
    '    Catch ex As Exception
    '        MsgError(ex.Message)
    '    End Try
    'End Sub

    'Private Sub xDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xDescripcion.KeyPress
    '    e.NextControl(xRegion)
    'End Sub

    'Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
    '    Dim wQuery = "SELECT Ciudad, NombreCiudad as 'Nombre Ciudad' FROM Ciudades"
    '    Buscador.Show()
    '    Buscador.Configurar(wQuery, "NombreCiudad", Me, "Ciudades", xCiudad)
    'End Sub
    'Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
    '    wControl.Text = wValor
    '    wControl.Validate
    'End Sub
    'Private Sub ManCiudades_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
    '    xCiudad.Focus()
    'End Sub
    'Private Sub xRegion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xRegion.KeyPress
    '    e.NextControl(xArea)
    'End Sub
End Class