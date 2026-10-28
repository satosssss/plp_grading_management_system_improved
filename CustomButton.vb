Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D

''' <summary>
''' Owner-drawn rounded button. Colors come from Theme by default; call
''' Theme.StylePrimaryButton / StyleSecondaryButton / StyleGhostButton to
''' pick a variant. Paints its own fill + border + centered text and tracks
''' hover state internally (no flicker from mutating BackColor).
''' </summary>
Public Class CustomButton
    Inherits Button

    Private _borderColor As Color = Theme.Primary
    Private _borderSize As Integer = 0
    Private _cornerRadius As Integer = 8
    Private _hoverColor As Color = Theme.PrimaryHover
    Private _normalColor As Color = Theme.Primary
    Private _isHovered As Boolean = False

    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.ResizeRedraw Or
                 ControlStyles.UserPaint Or
                 ControlStyles.SupportsTransparentBackColor, True)
        BackColor = _normalColor
        ForeColor = Theme.TextOnPrimary
        Font = Theme.FontButton
        Cursor = Cursors.Hand
        Size = New Size(110, 34)
    End Sub

    <Category("Appearance"), Description("Border color of the button.")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Invalidate()
        End Set
    End Property

    <Category("Appearance"), Description("Border thickness of the button.")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = Math.Max(0, value)
            Invalidate()
        End Set
    End Property

    <Category("Appearance"), Description("Corner radius for rounded edges.")>
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = Math.Max(0, value)
            Invalidate()
        End Set
    End Property

    <Category("Appearance"), Description("Background color when hovered.")>
    Public Property HoverColor As Color
        Get
            Return _hoverColor
        End Get
        Set(value As Color)
            _hoverColor = value
        End Set
    End Property

    <Category("Appearance"), Description("Normal background color.")>
    Public Property NormalColor As Color
        Get
            Return _normalColor
        End Get
        Set(value As Color)
            _normalColor = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        Dim g As Graphics = pevent.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        Dim rect As Rectangle = Me.ClientRectangle
        Dim fill As Color = If(_isHovered AndAlso Enabled, _hoverColor, _normalColor)

        Using path As GraphicsPath = GetRoundedRectPath(rect, _cornerRadius)
            Region = New Region(path)
            Using brush As New SolidBrush(fill)
                g.FillPath(brush, path)
            End Using
            If _borderSize > 0 Then
                Using pen As New Pen(_borderColor, _borderSize)
                    g.DrawPath(pen, path)
                End Using
            End If
        End Using

        Dim sf As New StringFormat() With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center,
            .Trimming = StringTrimming.EllipsisCharacter,
            .FormatFlags = StringFormatFlags.NoWrap
        }
        Dim textColor As Color = If(Enabled, ForeColor, Theme.TextSecondary)
        Using textBrush As New SolidBrush(textColor)
            g.DrawString(Text, Font, textBrush, rect, sf)
        End Using
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _isHovered = True
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _isHovered = False
        Invalidate()
    End Sub

    Protected Overrides Sub OnEnabledChanged(e As EventArgs)
        MyBase.OnEnabledChanged(e)
        Invalidate()
    End Sub

    Private Function GetRoundedRectPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        If radius <= 0 Then
            path.AddRectangle(rect)
            Return path
        End If
        Dim d As Integer = radius * 2
        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function
End Class
