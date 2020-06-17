Imports System.ComponentModel

Public Class AnularOT
    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        xOT.Focus()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub
    Private Sub xOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xOT.KeyPress
        ValidarDigitos(e)
        e.NextControl(xObsTecnico)
    End Sub

    Private Sub bAnular_Click(sender As Object, e As EventArgs) Handles bAnular.Click
        If Val(xOT.Text) <= 0 Then
            MsgError("Debe ingresar una OT")
            xOT.Focus()
            Exit Sub
        End If
        If xObsTecnico.Text.Trim = "" Then
            MsgError("Debe ingresar una Observación")
            xObsTecnico.Focus()
            Exit Sub
        End If

        If Not Pregunta("Desea Anular la OT: " & Val(xOT.Text)) Then
            Exit Sub
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wOT = DC.T_OT.FirstOrDefault(Function(x) x.OT = Val(xOT.Text))
        If wOT Is Nothing Then
            MsgError("OT no encontrada")
            Exit Sub
        Else
            If wOT.Estado = "" Then
                MsgError("La OT ya se encuentra Anulada")
                Exit Sub
            Else
                wOT.Estado = "N"
                wOT.ObsTecnico = xObsTecnico.Text.Trim
                DC.SubmitChanges()
                Informacion("OT Anulada")
                Auditoria(Me.Name, "Anuló OT", xOT.Text.Trim, CStr(G_LOCALACTUAL))
                LimpiarCampos(Me)
                xOT.Focus()
            End If
        End If
    End Sub

    Private Sub AnularOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Auditoria(Me.Name, "Ingresó al Módulo", UsuarioActual, CStr(G_LOCALACTUAL))
    End Sub

    Private Sub xOT_Validating(sender As Object, e As CancelEventArgs) Handles xOT.Validating
        If Val(xOT.Text) <= 0 Then
            Exit Sub
        End If

        Dim wOT = SQL("Select * from OT where OT = " & Val(xOT.Text)).Top
        If wOT IsNot Nothing Then

            If wOT.GetText("Estado") = "N" Then
                MsgError("OT ya se encuentra Anulada")
                Exit Sub
            End If

            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = Val(wOT.GetText("Cliente")))
            xCliente.Text = wOT.GetText("Cliente")
            If wCli IsNot Nothing Then xNombre.Text = wCli.Nombre

            xProductoR.Text = wOT.GetText("Recepcion")
            xFechaOT.Text = wOT.GetText("Fecha")

            Dim wEst = DC.T_Estados.FirstOrDefault(Function(x) x.Estado = wOT.GetText("Estado"))
            If wEst IsNot Nothing Then xEstado.Text = wEst.DescEstado

            xObsTecnico.Text = wOT.GetText("ObsTecnico")
            xObsTecnico.Focus()
        Else
            MsgError("OT No Encontrada")
            LimpiarCampos(Me)
        End If
    End Sub
End Class