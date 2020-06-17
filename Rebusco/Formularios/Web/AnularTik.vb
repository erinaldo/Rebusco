Imports System.ComponentModel

Public Class AnularTik
    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        LimpiarCampos(Me)
        xTicket.Focus()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub
    Private Sub xTicket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTicket.KeyPress
        ValidarDigitos(e)
        e.NextControl(xObs)
    End Sub

    Private Sub bAnular_Click(sender As Object, e As EventArgs) Handles bAnular.Click
        If Val(xTicket.Text) <= 0 Then
            MsgError("Debe ingresar un N° de Ticket")
            xTicket.Focus()
            Exit Sub
        End If
        If xObs.Text.Trim = "" Then
            MsgError("Debe ingresar una Observación")
            xObs.Focus()
            Exit Sub
        End If

        If Not Pregunta("Desea Anular Ticket: " & Val(xTicket.Text)) Then
            Exit Sub
        End If

        Dim DC = New RebuscoDataContext(P_CONEXION)
        Dim wTik = DC.T_TikGen.FirstOrDefault(Function(x) x.Ticket = Val(xTicket.Text))
        If wTik Is Nothing Then
            MsgError("Ticket no encontrado")
            Exit Sub
        Else
            If wTik.Estado = "" Then
                MsgError("EL Ticket ya se encuentra Anulado")
                Exit Sub
            Else
                wTik.Estado = "N"
                wTik.Observacion = xObs.Text.Trim
                DC.SubmitChanges()
                Informacion("Ticket Anulado")
                Auditoria(Me.Name, "Anuló Ticket", xTicket.Text.Trim, CStr(G_LOCALACTUAL))
                LimpiarCampos(Me)
                xTicket.Focus()
            End If
        End If
    End Sub

    Private Sub AnularTik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Auditoria(Me.Name, "Ingresó al Módulo", UsuarioActual, CStr(G_LOCALACTUAL))
    End Sub

    Private Sub xTicket_Validating(sender As Object, e As CancelEventArgs) Handles xTicket.Validating
        Ver_Ticket()
    End Sub

    Sub Ver_Ticket()
        If Val(xTicket.Text) <= 0 Then
            Exit Sub
        End If

        Dim wTik = SQL("Select * from TikGen where Ticket = " & Val(xTicket.Text)).Top
        If wTik IsNot Nothing Then
            If wTik.GetText("Estado") = "A" Then
                MsgError("Ticket ya se encuentra Anulado")
                Exit Sub
            End If

            Dim DC = New RebuscoDataContext(P_CONEXION)
            Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = Val(wTik.GetText("Cliente")))
            xCliente.Text = wTik.GetText("Cliente")
            If wCli IsNot Nothing Then xNombre.Text = wCli.Nombre

            xFecha.Text = wTik.GetText("Fecha")

            Dim wEst = DC.T_Estados.FirstOrDefault(Function(x) x.Estado = wTik.GetText("Estado") And x.Tipo = "W")
            If wEst IsNot Nothing Then xEstado.Text = wEst.DescEstado

            xObs.Text = wTik.GetText("Observacion")
            xObs.Focus()
        Else
            MsgError("Ticket No Encontrado")
            LimpiarCampos(Me)
        End If
    End Sub
End Class