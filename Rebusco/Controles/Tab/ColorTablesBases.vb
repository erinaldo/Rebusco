Namespace ColorTables

    ''' <summary>
    ''' Holds the colors for elements common to all strips, such as selection colors.
    ''' </summary>
    ''' <remarks>Inherit this class, override all properties and return your desired colors.</remarks>
    Public MustInherit Class Vs2010CommonColorTable

        ''' <summary>
        ''' Gets the color of the text on all items.
        ''' </summary>
        ''' <returns>The color of the text on all items.</returns>
        Public MustOverride ReadOnly Property TextColor As Color

        ''' <summary>
        ''' Gets the color of the border of a selected item.
        ''' </summary>
        ''' <returns>The color of the border of a selected item.</returns>
        Public MustOverride ReadOnly Property SelectedBorder As Color

        ''' <summary>
        ''' Gets the top color of the gradient making up a selection rectangle.
        ''' </summary>
        ''' <returns>The top color of the gradient making up a selection rectangle.</returns>
        Public MustOverride ReadOnly Property SelectedGradientTop As Color

        ''' <summary>
        ''' Gets the bottom color of the gradient making up a selection rectangle.
        ''' </summary>
        ''' <returns>The bottom color of the gradient making up a selection rectangle.</returns>
        Public MustOverride ReadOnly Property SelectedGradientMiddle As Color

        ''' <summary>
        ''' Gets the color of the solid bottom making up a selection rectangle.
        ''' </summary>
        ''' <returns>The color of the solid bottom making up a selection rectangle.</returns>
        Public MustOverride ReadOnly Property SelectedGradientBottom As Color

        ''' <summary>
        ''' Gets the background color of a pressed item.
        ''' </summary>
        ''' <returns>The background color of a pressed item.</returns>
        Public MustOverride ReadOnly Property PressedBackground As Color

        ''' <summary>
        ''' Gets the background color of a checked item.
        ''' </summary>
        ''' <returns>The background color of a checked item.</returns>
        Public MustOverride ReadOnly Property CheckedBackground As Color

        ''' <summary>
        ''' Gets the background color of a checked and selected item.
        ''' </summary>
        ''' <returns>The background color of a checked and selected item.</returns>
        Public MustOverride ReadOnly Property CheckedSelectedBackground As Color

        ''' <summary>
        ''' Gets the border color of a dropdown menu.
        ''' </summary>
        ''' <returns>The border color of a dropdown menu.</returns>
        Public MustOverride ReadOnly Property DropdownBorder As Color

        ''' <summary>
        ''' Gets the color of the arrow for both menus and dropdown buttons.
        ''' </summary>
        ''' <returns>The color of the arrow for both menus and dropdown buttons.</returns>
        Public MustOverride ReadOnly Property Arrow As Color

    End Class

    Public MustInherit Class Vs2010TabControlColorTable
        Public MustOverride ReadOnly Property Background As Color
        Public MustOverride ReadOnly Property SelectedHeaderGradientTop As Color
        Public MustOverride ReadOnly Property SelectedHeaderGradientBottom As Color
        Public MustOverride ReadOnly Property SelectedHeaderGradientMiddle As Color
        Public MustOverride ReadOnly Property HoveringHeaderGradientTop As Color
        Public MustOverride ReadOnly Property HoveringHeaderGradientBottom As Color
        Public MustOverride ReadOnly Property HoveringHeaderBorder As Color
        Public MustOverride ReadOnly Property Border As Color
    End Class

End Namespace
