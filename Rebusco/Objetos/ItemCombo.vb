Public Class ItemCombo

    Public Sub New()
        ID = ""
        Desc = ""
    End Sub

    Public Sub New(idItem As String, descItem As String)
        ID = idItem
        Desc = descItem
    End Sub

    Public Property ID As String
    Public Property Desc As String
End Class

