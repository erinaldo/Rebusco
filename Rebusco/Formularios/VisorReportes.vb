Imports CrystalDecisions.CrystalReports.Engine

Public Class VisorReportes
    Private Sub VisorReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub MostrarReporte(ByVal wReporte As ReportClass)
        Visor.ReportSource = wReporte
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub
End Class