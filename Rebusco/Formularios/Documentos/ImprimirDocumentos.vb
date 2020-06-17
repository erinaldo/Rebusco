Imports System.ComponentModel

Public Class ImprimirDocumentos
    Private Sub ImprimirDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", " ORDER BY DescTipoDoc")
        If cLocal.Items.Count = 2 Then
            cLocal.SelectedIndex = 1
        End If
    End Sub

    Private Sub xLocal_KeyPress(sender As Object, e As KeyPressEventArgs)
        ValidarDigitos(e)
        e.NextControl(cTipoDoc)
    End Sub

    Private Sub xNumDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xNumDoc.KeyPress
        ValidarDigitos(e)
        e.NextControl(bImprimir)
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        xNumDoc.Clear()
        cTipoDoc.SelectedIndex = 0
        cLocal.SelectedIndex = 0
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Imprimir_Datos
    End Sub

    Sub Imprimir_Datos()
        Dim wFiltros = "", wQuery = "", wTipoDoc As String = ""

        If cLocal.Text.Trim = "" Then
            MsgError("Ingrese Local")
            cLocal.Focus()
            Exit Sub
        End If

        If cTipoDoc.Text = "" Then
            MsgError("Ingrese Tipo de Documento")
            cTipoDoc.Focus()
            Exit Sub
        End If

        If xNumDoc.Text.Trim = "" Then
            MsgError("Ingrese Número de Documento")
            xNumDoc.Focus()
            Exit Sub
        End If

        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wDoc = DC.T_DocumentosG.FirstOrDefault(Function(x) x.TipoDoc = cTipoDoc.SelectedValue.ToString And
                                                                x.Local = Val(cLocal.SelectedValue.ToString) And
                                                                x.Numero = Val(xNumDoc.Text))
        If wDoc Is Nothing Then
            MsgError("Documento no encontrado")
            Exit Sub
        End If

        wQuery = "Select Numero from DocumentosG where Local = " & Val(cLocal.SelectedValue) & "" &
                 " And TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & Val(xNumDoc.Text)
        Dim wDocG = SQL(wQuery)
        If wDocG.Rows.Count = 0 Then
            MsgError("Documento No Encontrado")
            Exit Sub
        End If


        G_TIPOCOPIA = New List(Of Integer)
        If gCopias.Enabled = False Then
            G_TIPOCOPIA.Add(0)
        Else
            If oCliente.Checked Then G_TIPOCOPIA.Add(1)
            If oControlTributario.Checked Then G_TIPOCOPIA.Add(2)
            If oCedible.Checked Then G_TIPOCOPIA.Add(3)
        End If

        bImprimir.Enabled = False

        If FE_BV And cTipoDoc.SelectedValue.ToString = "BV" Then
            ImprimirDocumento(Convert.ToInt32(xNumDoc.Text), DocumentoPago.Boleta)
        Else
            Imprimir_Documento(Val(cLocal.SelectedValue.ToString), cTipoDoc.SelectedValue.ToString, Val(xNumDoc.Text), cTipoDoc.Text, G_TIPOCOPIA)
        End If

        bImprimir.Enabled = True
        Auditoria(cTipoDoc.Text, A_IMPRESO, CStr(xNumDoc.Text))
    End Sub

    Private Sub cTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cTipoDoc.SelectedIndexChanged
        If cTipoDoc.Text <> "" Then
            Dim wListTipoDoc = {"FV", "NC", "ND", "FE"}
            If wListTipoDoc.Contains(cTipoDoc.SelectedValue.ToString) Then
                gCopias.Enabled = True
            Else
                gCopias.Enabled = False
            End If
            xNumDoc.Focus()
        End If
    End Sub

    Private Sub oCliente_CheckedChanged(sender As Object, e As EventArgs) Handles oCliente.CheckedChanged, oCedible.CheckedChanged, oControlTributario.CheckedChanged
        Dim wCheckBox As CheckBox = DirectCast(sender, CheckBox)
        wCheckBox.ForeColor = If(wCheckBox.Checked, Color.White, Color.FromArgb(29, 73, 140))

        wCheckBox.Image = If(wCheckBox.Checked, My.Resources.Resources.check16true_b,
                                                    My.Resources.Resources.check16false_b)
    End Sub
End Class