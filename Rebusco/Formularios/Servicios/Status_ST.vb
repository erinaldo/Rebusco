Public Class Status_ST
    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bActualizar_Click(sender As Object, e As EventArgs) Handles bActualizar.Click
        Consultar_Datos
    End Sub

    Sub Consultar_Datos()
        If cLocal.SelectedValue Is Nothing Then Exit Sub
        If cLocal.SelectedValue.ToString.Trim = "" Or cLocal.SelectedValue.ToString.Trim = "0" Then Exit Sub

        Dim wLocal As String = cLocal.SelectedValue.ToString

        Me.Cursor = Cursors.WaitCursor

        Dim DC = New MarketONEDataContext(P_CONEXION)

        'Ingresadas no Asignadas a Técnico
        Dim wOTIngresadas = DC.T_OT.Where(Function(x) x.Estado = "I")
        xOTIngresadas.Text = If(wOTIngresadas.Any(), wOTIngresadas.Count.ToString, "0")

        'Asignadas a técnico
        Dim wOTAsignadaTecnico = DC.T_OT.Where(Function(x) x.Estado = "A")
        xOTTecnicoAsignado.Text = If(wOTAsignadaTecnico.Any(), wOTAsignadaTecnico.Count.ToString(), "0")

        'Servicio Iniciado por técnico
        Dim wOTServicioIniciado = DC.T_OT.Where(Function(x) x.Estado = "C")
        xOTProceso.Text = If(wOTServicioIniciado.Any(), wOTServicioIniciado.Count.ToString(), "0")

        'Pendiente de Cobrar
        Dim wOTPendienteCobro = DC.T_OT.Where(Function(x) x.Estado = "D" And x.NumDoc = 0)
        xOTCerrada.Text = If(wOTPendienteCobro.Any(), wOTPendienteCobro.Count.ToString(), "0")



        ''Ingresadas no Asignadas a Técnico
        'Dim sOTi = SQL("Select Count(OT) AS Ingresadas from OT where (Estado = 'I') and Local = " + wLocal).Top
        'If sOTi IsNot Nothing Then
        '    xOTIngresadas.Text = sOTi.GetNum("Ingresadas").ToString
        'Else
        '    xOTIngresadas.Text = "0"
        'End If


        ''Cerradas en Proceso o Pendientes
        'Dim sOTp = SQL("Select Count(OT) AS Proceso from OT where Local=" + wLocal + " and (Estado not in ('I','D','N'))").Top
        'If sOTp IsNot Nothing Then
        '    xOTProceso.Text = sOTp.GetNum("Proceso").ToString
        'Else
        '    xOTProceso.Text = "0"
        'End If

        ''Cerradas no Cobradas
        'Dim sOTc = SQL("Select Count(OT) AS Cerradas from OT where  (Estado = 'D') and NumDoc=0 and Local=" + wLocal).Top
        'If sOTc IsNot Nothing Then
        '    xOTCerrada.Text = sOTc.GetNum("Cerradas").ToString
        'Else
        '    xOTCerrada.Text = "0"
        'End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Status_ST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        cLocal.SelectedValue = G_LOCALACTUAL
        cLocal.Text = NombreLocalActual
        cLocal.Enabled = True

        Consultar_Datos()
    End Sub

    Private Sub Status_ST_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Consultar_Datos()
    End Sub

    Private Sub cLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cLocal.SelectedIndexChanged
        Consultar_Datos()
    End Sub
End Class