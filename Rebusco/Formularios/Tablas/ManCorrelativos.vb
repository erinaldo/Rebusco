Imports System.ComponentModel

Public Class ManCorrelativos
    Implements iFormulario
    Private Sub ManCorrelativos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos(Me)
        bGuardar.Text = "Guardar"
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal", "Order By Local")
        'cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", "WHERE Cod_SII > 0")
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", "")
        xLocal.Focus()
        Auditoria(Me.Text, A_INGRESADO, "", "")
        If cLocal.Items.Count = 2 Then
            cLocal.SelectedIndex = 1
        End If
    End Sub
    Private Sub xLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xLocal.KeyPress, TextBox1.KeyPress
        ValidarDigitos(e)
        e.NextControl(xCaja)
    End Sub

    Private Sub xLocal_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xLocal.Validating, TextBox1.Validating
        Try
            If xLocal.Text.Trim <> "" Then
                cLocal.SelectedValue = xLocal.Text.Trim
                If cLocal.Text = "" Then
                    MsgError("Local no encontrado")
                    xLocal.Clear()
                    xLocal.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim wMensaje As String() = {MSG_MODIFICADO, A_MODIFICADO}

        If xLocal.Text = "" Then
            MsgError("Ingrese Numero de Local")
            xLocal.Focus()
            Exit Sub
        End If
        If cTipoDoc.Text = "" Then
            MsgError("Ingrese Tipo de Documento")
            cTipoDoc.Focus()
            Exit Sub
        End If
        If xCorrelativo.Text = "" Then
            MsgError("Ingrese Correlativo")
            xCorrelativo.Focus()
            Exit Sub
        End If

        If Val(xInicial.Text) > Val(xFinal.Text) Then
            MsgError("Rango de Correlativos Incorrecto")
            xInicial.Focus()
            Exit Sub
        End If
        If Val(xCorrelativo.Text) < Val(xInicial.Text) Or Val(xCorrelativo.Text) > Val(xFinal.Text) Then
            MsgError("Correlativo fuera del rango permitido")
            xCorrelativo.Focus()
            Exit Sub
        End If
        If CDate(dFechaCAF.Value) > Now.Date Then
            MsgError("Fecha CAF no puede superior a la actual")
            dFechaCAF.Focus()
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Dim DC = New RebuscoDataContext(P_CONEXION) With {
            .Log = System.Console.Out
        }
        Dim wCorr As New T_Correlativos
        Dim qCorr = DC.T_Correlativos.FirstOrDefault(Function(x) x.Local = CInt(xLocal.Text) And
                                                                 x.POS = CInt(xCaja.Text) And
                                                                 x.TipoDoc = cTipoDoc.SelectedValue.ToString)

        If qCorr IsNot Nothing Then wCorr = qCorr

        wCorr.Local = CInt(xLocal.Text)
        wCorr.TipoDoc = cTipoDoc.SelectedValue.ToString
        wCorr.POS = CInt(xCaja.Text)
        wCorr.Inicial = CInt(xInicial.Text)
        wCorr.Final = CInt(xFinal.Text)
        wCorr.FechaCAF = dFechaCAF.Value
        wCorr.Correlativo = CInt(xCorrelativo.Text)

        If qCorr Is Nothing Then
            DC.T_Correlativos.InsertOnSubmit(wCorr)
            wMensaje = {MSG_GUARDADO, A_GUARDADO}
        End If
        DC.SubmitChanges()
        Mensaje(wMensaje(0))
        Auditoria(Me.Text, wMensaje(1), xCorrelativo.Text, cTipoDoc.SelectedValue.ToString)
        LimpiarCampos(Me)
        If cLocal.Items.Count = 2 Then
            cLocal.SelectedIndex = 1
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
        If cLocal.Items.Count = 2 Then
            cLocal.SelectedIndex = 1
        End If
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
    Private Sub xCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCaja.KeyPress, TextBox2.KeyPress
        ValidarDigitos(e)
        e.NextControl(xCorrelativo)
    End Sub

    Private Sub ManTipoMov_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        xLocal.Focus()
    End Sub
    Private Sub cLocal_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.NextControl(bGuardar)
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        ValidarDigitos(e)
        e.NextControl(bGuardar)
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs)
        xLocal.Focus()
        bGuardar.Text = "Guardar"
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs)
        'Auditoria(Me.Text, A_ELIMINO, "", "")
    End Sub

    Sub CargarCorrelativo()
        If Val(xLocal.Text) = 0 Then Exit Sub
        If cTipoDoc.Text = "" Then Exit Sub

        lFolios.Visible = False
        fFolios.Visible = False

        If xCaja.Text = "" Then xCaja.Text = "0"

        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wCorr = DC.T_Correlativos.FirstOrDefault(Function(x) x.POS = CInt(xCaja.Text) And
                                                                  x.Local = CInt(xLocal.Text) And
                                                                  x.TipoDoc = cTipoDoc.SelectedValue.ToString)

        If wCorr IsNot Nothing Then
            xLocal.Text = wCorr.Local.ToString
            xLocal_Validating()
            xCaja.Text = wCorr.POS.ToString
            cTipoDoc.SelectedValue = wCorr.TipoDoc
            xCorrelativo.Text = wCorr.Correlativo.ToString
            xInicial.Text = wCorr.Inicial.ToString
            xFinal.Text = wCorr.Final.ToString
            dFechaCAF.Value = wCorr.FechaCAF
            bGuardar.Text = "Modificar"

            Dim TDo = DC.T_TipoDoc.FirstOrDefault(Function(x) x.TipoDoc = wCorr.TipoDoc.ToString)
            If TDo IsNot Nothing Then
                If TDo.Electronica Then
                    lFolios.Visible = True
                    fFolios.Visible = True
                End If
            End If
        Else
            xLocal_Validating()
            xCaja.Clear()
            xCorrelativo.Clear()
            xInicial.Clear()
            xFinal.Clear()
            dFechaCAF.Value = CDate("01/01/2000")
            bGuardar.Text = "Ingresar"
        End If

    End Sub


    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub cLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cLocal.SelectedIndexChanged
        If cLocal.Text <> "" Then
            xLocal.Text = cLocal.SelectedValue.ToString
            CargarCorrelativo()
        Else
            xLocal.Clear()
        End If
    End Sub

    Private Sub cTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cTipoDoc.SelectedIndexChanged
        CargarCorrelativo()
    End Sub

    Private Sub xCaja_Validating(sender As Object, e As CancelEventArgs) Handles xCaja.Validating
        CargarCorrelativo()
    End Sub

    Private Sub oCompartir_Load(sender As Object, e As EventArgs)
        If oCompartir.Checked Then
            xCaja.Enabled = False
            xCaja.Text = "0"
        Else
            xCaja.Enabled = True
            xCaja.Clear()
            xCaja.Focus()
        End If
    End Sub
End Class