Namespace ColorTables

    Public Class Vs2010DefaultTabControlColorTable
        Inherits Vs2010TabControlColorTable

        Public Overrides ReadOnly Property Background As System.Drawing.Color
            Get
                Return Color.FromArgb(10, 87, 139)
            End Get
        End Property

        Public Overrides ReadOnly Property Border As System.Drawing.Color
            Get
                Return Color.FromArgb(40, 127, 179)
            End Get
        End Property

        Public Overrides ReadOnly Property HoveringHeaderGradientBottom As System.Drawing.Color
            Get
                Return Color.FromArgb(100, 187, 219)
            End Get
        End Property

        Public Overrides ReadOnly Property HoveringHeaderGradientTop As System.Drawing.Color
            Get
                Return Color.FromArgb(100, 187, 219)
            End Get
        End Property

        Public Overrides ReadOnly Property SelectedHeaderGradientBottom As System.Drawing.Color
            Get
                Return Color.FromArgb(40, 127, 179)
            End Get
        End Property

        Public Overrides ReadOnly Property SelectedHeaderGradientMiddle As System.Drawing.Color
            Get
                Return Color.FromArgb(40, 127, 179)
            End Get
        End Property

        Public Overrides ReadOnly Property SelectedHeaderGradientTop As System.Drawing.Color
            Get
                Return Color.FromArgb(40, 127, 179)
            End Get
        End Property

        Public Overrides ReadOnly Property HoveringHeaderBorder As System.Drawing.Color
            Get
                Return Color.FromArgb(100, 187, 219)
            End Get
        End Property
    End Class

End Namespace