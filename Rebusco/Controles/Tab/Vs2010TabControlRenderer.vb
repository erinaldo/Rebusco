Imports System.Drawing.Drawing2D

Namespace Renderers

    Public Class Vs2010TabControlRenderer

        Public Sub New()
            Me.New(New ColorTables.Vs2010DefaultTabControlColorTable())
        End Sub

        Public Sub New(ByVal colorTable As ColorTables.Vs2010TabControlColorTable)
            Me.ColorTable = colorTable
        End Sub

        Private _ColorTable As ColorTables.Vs2010TabControlColorTable
        Public Property ColorTable() As ColorTables.Vs2010TabControlColorTable
            Get
                If _ColorTable Is Nothing Then
                    _ColorTable = New ColorTables.Vs2010DefaultTabControlColorTable()
                End If
                Return _ColorTable
            End Get
            Set(ByVal value As ColorTables.Vs2010TabControlColorTable)
                _ColorTable = value
            End Set
        End Property

        Private Sub DrawSelectedTabHeader(ByVal g As Graphics, ByVal rect As RectangleF)
            Dim roundRadius As Single = 2.0F
            Using brush As New LinearGradientBrush(rect, _
                                                   Me.ColorTable.SelectedHeaderGradientTop, _
                                                   Me.ColorTable.SelectedHeaderGradientMiddle, _
                                                   LinearGradientMode.Vertical)
                Dim b = New ColorBlend(4)
                b.Colors = New Color() {Me.ColorTable.SelectedHeaderGradientTop, _
                                        Me.ColorTable.SelectedHeaderGradientMiddle, _
                                        Me.ColorTable.SelectedHeaderGradientBottom, _
                                        Me.ColorTable.SelectedHeaderGradientBottom}
                b.Positions = New Single() {0.0F, 0.5F, 0.5F, 1.0F}
                brush.InterpolationColors = b

                Using gp As New GraphicsPath()
                    gp.AddLine(rect.X + roundRadius, rect.Y, rect.Right - 2 * roundRadius, rect.Y)
                    gp.AddArc(rect.Right - 2 * roundRadius, rect.Y, 2 * roundRadius, 2 * roundRadius, 270, 90)
                    gp.AddLine(rect.Right, rect.Y + roundRadius, rect.Right, rect.Bottom)
                    gp.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom)
                    gp.AddLine(rect.X, rect.Bottom, rect.X, rect.Y)
                    gp.AddArc(rect.X, rect.Y, roundRadius * 2, roundRadius * 2, 180, 90)
                    gp.CloseFigure()

                    g.SmoothingMode = SmoothingMode.HighQuality
                    g.FillPath(brush, gp)
                    g.SmoothingMode = SmoothingMode.Default
                End Using
            End Using
        End Sub

        Private Sub DrawHoveringTabHeader(ByVal g As Graphics, ByVal rect As Rectangle)
            rect = New Rectangle(rect.X, rect.Y + 1, rect.Width - 2, rect.Height + 1)
            Dim innerRect As New Rectangle(rect.X + 1, rect.Y, rect.Width - 1, rect.Height - 3)

            Using b As New LinearGradientBrush(innerRect, _
                                               Me.ColorTable.HoveringHeaderGradientTop, _
                                               Me.ColorTable.HoveringHeaderGradientBottom, _
                                               LinearGradientMode.Vertical)
                g.FillRectangle(b, innerRect)
            End Using
            Using p As New Pen(Me.ColorTable.HoveringHeaderBorder)
                CommonDrawing.DrawRoundedRectangle(g, p, rect.X, rect.Y, rect.Width, rect.Height, 2)
            End Using
        End Sub

        Public Overridable Sub OnPaintTabHeader(ByVal e As PaintHeaderEventArgs)
            Dim textColor As Color

            If e.State = PaintHeaderEventArgs.TabHeaderState.Active Then
                Me.DrawSelectedTabHeader(e.Graphics, e.ClipRectangle)
                textColor = Color.White

            ElseIf e.State = PaintHeaderEventArgs.TabHeaderState.HotTracking Then
                Me.DrawHoveringTabHeader(e.Graphics, e.ClipRectangle)
                textColor = Color.White

            Else
                textColor = Color.White
            End If

            Dim format As New StringFormat
            format.Alignment = StringAlignment.Center
            format.LineAlignment = StringAlignment.Center
            e.Graphics.DrawString(e.TabPage.Text, e.TabPage.Font, New SolidBrush(textColor), e.ClipRectangle, format)
        End Sub

        Public Overridable Sub OnPaintTabHeadersBackground(ByVal e As PaintEventArgs)
            Using b As New SolidBrush(Me.ColorTable.Background)
                e.Graphics.FillRectangle(b, e.ClipRectangle)
            End Using
        End Sub

        Public Overridable Sub OnPaintBorders(ByVal e As PaintBordersEventArgs)
            Using b As New SolidBrush(Me.ColorTable.Border)
                e.Graphics.FillRectangle(b, e.ClipRectangle)
                'If e.Side = PaintBordersEventArgs.BorderSide.Top Then
                '    CommonDrawing.FillRoundedRectangle(e.Graphics, _
                '                                       b, _
                '                                       e.ClipRectangle.X, _
                '                                       e.ClipRectangle.Y, _
                '                                       e.ClipRectangle.Width, _
                '                                       e.ClipRectangle.Height + 3, _
                '                                       2)
                'Else
                '    CommonDrawing.FillRoundedRectangle(e.Graphics, _
                '                   b, _
                '                   e.ClipRectangle.X, _
                '                   e.ClipRectangle.Y - 2, _
                '                   e.ClipRectangle.Width, _
                '                   e.ClipRectangle.Height + 1, _
                '                   2)
                'End If
            End Using
        End Sub

        Public Class PaintHeaderEventArgs
            Inherits PaintEventArgs

            Public Enum TabHeaderState
                ''' <summary>
                ''' Represents a normal tab header.
                ''' </summary>
                Normal

                ''' <summary>
                ''' Represents the tab header the mouse is hovering over.
                ''' </summary>
                HotTracking

                ''' <summary>
                ''' Represents an active (selected) tab header.
                ''' </summary>
                ''' <remarks></remarks>
                Active

                ''' <summary>
                ''' Represents an inactive (selected but without focus) tab header.
                ''' </summary>
                ''' <remarks></remarks>
                Inactive
            End Enum

            Public Sub New(ByVal g As Graphics, ByVal clipRect As Rectangle, ByVal tabPage As TabPage, ByVal state As TabHeaderState)
                MyBase.New(g, clipRect)
                _TabPage = tabPage
                _State = state
            End Sub

            Private _State As TabHeaderState
            Public ReadOnly Property State() As TabHeaderState
                Get
                    Return _State
                End Get
            End Property

            Private _TabPage As TabPage
            Public ReadOnly Property TabPage() As TabPage
                Get
                    Return _TabPage
                End Get
            End Property

        End Class

        Public Class PaintBordersEventArgs
            Inherits PaintEventArgs

            Public Enum BorderSide
                Top
                Bottom
            End Enum

            Public Sub New(ByVal g As Graphics, ByVal clipRect As Rectangle, ByVal side As BorderSide)
                MyBase.New(g, clipRect)
                _Side = side
            End Sub

            Private _Side As BorderSide
            Public ReadOnly Property Side() As BorderSide
                Get
                    Return _Side
                End Get
            End Property

        End Class

    End Class

End Namespace