Partial Public Class T_DocumentosD
    Implements ICloneable

    Private Function Clone() As Object Implements ICloneable.Clone
        Return Me.MemberwiseClone()
    End Function

    Public Function Clonar() As T_DocumentosD
        Return CType(Me.Clone(), T_DocumentosD)
    End Function
End Class
Partial Public Class T_DocumentosP
        Implements ICloneable

        Private Function Clone() As Object Implements ICloneable.Clone
            Return Me.MemberwiseClone()
        End Function

        Public Function Clonar() As T_DocumentosP
        Return CType(Me.Clone(), T_DocumentosP)
    End Function
    End Class
    Partial Public Class T_DocumentosG
        Implements ICloneable

        Private Function Clone() As Object Implements ICloneable.Clone
            Return Me.MemberwiseClone()
        End Function

        Public Function Clonar() As T_DocumentosG
        Return CType(Me.Clone(), T_DocumentosG)
    End Function


    End Class

