Imports System.Text.RegularExpressions
Public Class ConsumoFolios
    Private Sub ControlCOF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xRut.Text = Formatea_Rut(FE_Rut_Emisor, 1)
        xNombre.Text = FE_Razon_Social
    End Sub

    Private Sub BuscarCAF(wRut As String, wDocumento As String)
        Cursor = Cursors.WaitCursor
        DoEvents()

        Dim wCor = SQL("SELECT TOP 1 * FROM Correlativos WHERE Documento ='" & wDocumento & "'").Top
        If wCor IsNot Nothing Then
            If wDocumento = "BV" Then xFechaBV.Text = "" : xIniBV.Text = "" : xFinBV.Text = "" : xDisBV.Text = ""
            If wDocumento = "BE" Then xFechaBE.Text = "" : xIniBE.Text = "" : xFinBE.Text = "" : xDisBE.Text = ""
            If wDocumento = "FV" Then xFechaFV.Text = "" : xIniFV.Text = "" : xFinFV.Text = "" : xDisFV.Text = ""
            If wDocumento = "FE" Then xFechaFE.Text = "" : xIniFE.Text = "" : xFinFE.Text = "" : xDisFE.Text = ""
            If wDocumento = "GD" Then xFechaGD.Text = "" : xIniGD.Text = "" : xFinGD.Text = "" : xDisGD.Text = ""
            If wDocumento = "NC" Then xFechaNC.Text = "" : xIniNC.Text = "" : xFinNC.Text = "" : xDisNC.Text = ""
            If wDocumento = "ND" Then xFechaND.Text = "" : xIniND.Text = "" : xFinND.Text = "" : xDisND.Text = ""
            Exit Sub
        Else
            If wDocumento = "BV" Then
                xFechaBV.Text = wCor.GetDate("FechaCAF").ToString
                xIniBV.Text = wCor.GetNum("Inicial").ToString
                xFinBV.Text = wCor.GetNum("Final").ToString
                xDisBV.Text = ((wCor.GetNum("Final") - wCor.GetNum("Correlativo")) + 1).ToString
            End If
            If wDocumento = "BE" Then
                xFechaBE.Text = wCor.GetDate("FechaCAF").ToString
                xIniBE.Text = wCor.GetNum("Inicial").ToString
                xFinBE.Text = wCor.GetNum("Final").ToString
                xDisBE.Text = ((wCor.GetNum("Final") - wCor.GetNum("Correlativo")) + 1).ToString
            End If
        End If



    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub

    Private Sub bCOF_Click(sender As Object, e As EventArgs) Handles bCOF.Click
        'Control_COF()
    End Sub

    Private Sub ControlCOF_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Control_COF()
    End Sub

    Sub Buscar_Correlativos(wRut As String)
        BuscarCAF(wRut, "BV")
        BuscarCAF(wRut, "BE")
        BuscarCAF(wRut, "FV")
        BuscarCAF(wRut, "FE")
        BuscarCAF(wRut, "GD")
        BuscarCAF(wRut, "NC")
        BuscarCAF(wRut, "ND")
    End Sub
End Class