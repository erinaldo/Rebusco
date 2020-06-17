Imports Rebusco.Renderers

Namespace Controls

    Public Class Vs2010TabControl
        Inherits TabControl

        Private Const TAB_HEIGHT As Integer = 26

        Private _HotTrackIndex As Integer = -1

        Public Sub New()
            Me.DrawMode = TabDrawMode.OwnerDrawFixed

            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            Me.SetStyle(ControlStyles.DoubleBuffer, True)
            Me.SetStyle(ControlStyles.ResizeRedraw, True)
            Me.SetStyle(ControlStyles.UserPaint, True)

            Me.ItemSize = New Size(Me.ItemSize.Width, TAB_HEIGHT)
            Me.HotTrack = True
        End Sub

        Private _Renderer As Vs2010TabControlRenderer
        Public Property Renderer() As Vs2010TabControlRenderer
            Get
                If _Renderer Is Nothing Then
                    _Renderer = New Vs2010TabControlRenderer()
                End If
                Return _Renderer
            End Get
            Set(ByVal value As Vs2010TabControlRenderer)
                _Renderer = value
            End Set
        End Property

        Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseMove(e)

            If Me.HotTrack Then
                For i As Integer = 0 To Me.TabCount - 1
                    Dim rect = Me.GetTabRect(i)
                    If i <> _HotTrackIndex Then
                        If rect.Contains(e.Location) Then
                            If _HotTrackIndex <> -1 Then Me.Invalidate(Me.GetTabRect(_HotTrackIndex))
                            _HotTrackIndex = i
                            Me.Invalidate(rect)
                            Exit For
                        End If
                    End If
                Next i
            End If
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
            MyBase.OnMouseLeave(e)
            If Me.HotTrack AndAlso _HotTrackIndex <> -1 Then
                Me.Invalidate(Me.GetTabRect(_HotTrackIndex))
                _HotTrackIndex = -1
            End If
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)

            ' Tab headers
            For i As Integer = 0 To Me.TabPages.Count - 1

                Dim tabRect As Rectangle = Me.GetTabRect(i)
                tabRect = New Rectangle(tabRect.X + 1, tabRect.Y + 3, tabRect.Width, tabRect.Height - 5)

                Dim state As Vs2010TabControlRenderer.PaintHeaderEventArgs.TabHeaderState

                If Me.SelectedTab Is Me.TabPages(i) Then
                    state = Vs2010TabControlRenderer.PaintHeaderEventArgs.TabHeaderState.Active
                ElseIf i = _HotTrackIndex Then
                    state = Vs2010TabControlRenderer.PaintHeaderEventArgs.TabHeaderState.HotTracking
                Else
                    state = Vs2010TabControlRenderer.PaintHeaderEventArgs.TabHeaderState.Normal
                End If

                Dim headerEventArgs As New Vs2010TabControlRenderer.PaintHeaderEventArgs(e.Graphics, _
                                                                                         tabRect, _
                                                                                         Me.TabPages(i), _
                                                                                         state)
                Me.Renderer.OnPaintTabHeader(headerEventArgs)
            Next

            ' Borders
            Dim topBorderRect As New Rectangle(4, Me.ItemSize.Height, Me.Width - 8, 4)
            Dim bottomBorderRect As New Rectangle(4, Me.Height - 4, Me.Width - 8, 4)
            Dim borderEventArgs As New Vs2010TabControlRenderer.PaintBordersEventArgs(e.Graphics, _
                                                                                      topBorderRect, _
                                                                                      Renderers.Vs2010TabControlRenderer.PaintBordersEventArgs.BorderSide.Top)
            Me.Renderer.OnPaintBorders(borderEventArgs)
            borderEventArgs = New Vs2010TabControlRenderer.PaintBordersEventArgs(e.Graphics, _
                                                                                bottomBorderRect, _
                                                                                Vs2010TabControlRenderer.PaintBordersEventArgs.BorderSide.Bottom)
            Me.Renderer.OnPaintBorders(borderEventArgs)



        End Sub

        Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaintBackground(pevent)

            ' Background
            Dim bgRect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
            Dim bgEventArgs As New PaintEventArgs(pevent.Graphics, bgRect)
            Me.Renderer.OnPaintTabHeadersBackground(bgEventArgs)



        End Sub

    End Class

End Namespace