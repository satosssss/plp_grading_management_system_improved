Imports System.Drawing
Imports System.Windows.Forms

''' <summary>
''' Central design system for the whole app: one palette, one type scale, and
''' reusable style helpers. Every form should pull colors/fonts from here instead
''' of hardcoding them, so the look stays consistent everywhere.
''' </summary>
Public Module Theme

    ' ---------------------------------------------------------------------
    ' Palette — "refined school green"
    ' ---------------------------------------------------------------------
    Public ReadOnly Primary As Color = Color.FromArgb(20, 83, 45)        ' #14532D  headers, primary buttons
    Public ReadOnly PrimaryHover As Color = Color.FromArgb(22, 101, 52)  ' #166534  hover state
    Public ReadOnly PrimarySoft As Color = Color.FromArgb(226, 240, 230) ' light tint for subtle fills
    Public ReadOnly Accent As Color = Color.FromArgb(22, 163, 74)        ' #16A34A  active/links/success
    Public ReadOnly AccentSoft As Color = Color.FromArgb(220, 252, 231)  ' #DCFCE7  selection, badges
    Public ReadOnly Background As Color = Color.FromArgb(246, 248, 247)  ' #F6F8F7  app canvas
    Public ReadOnly Surface As Color = Color.White                       ' cards / panels
    Public ReadOnly SurfaceAlt As Color = Color.FromArgb(249, 250, 251)  ' #F9FAFB  zebra rows
    Public ReadOnly Border As Color = Color.FromArgb(229, 231, 235)      ' #E5E7EB  card borders
    Public ReadOnly TextPrimary As Color = Color.FromArgb(17, 24, 39)    ' #111827
    Public ReadOnly TextSecondary As Color = Color.FromArgb(107, 114, 128) ' #6B7280
    Public ReadOnly TextOnPrimary As Color = Color.White
    Public ReadOnly Danger As Color = Color.FromArgb(220, 38, 38)        ' #DC2626
    Public ReadOnly Warning As Color = Color.FromArgb(217, 119, 6)       ' #D97706
    Public ReadOnly Success As Color = Color.FromArgb(22, 163, 74)       ' #16A34A
    Public ReadOnly InputFill As Color = Color.White
    Public ReadOnly InputBorder As Color = Color.FromArgb(209, 213, 219) ' #D1D5DB
    Public ReadOnly GridHeaderFill As Color = Primary
    Public ReadOnly GridHeaderText As Color = TextOnPrimary
    Public ReadOnly GridLine As Color = Border

    ' ---------------------------------------------------------------------
    ' Type scale — Segoe UI only
    ' ---------------------------------------------------------------------
    Public ReadOnly FontPageTitle As Font = New Font("Segoe UI Semibold", 16.0F)
    Public ReadOnly FontSection As Font = New Font("Segoe UI Semibold", 12.0F)
    Public ReadOnly FontCardTitle As Font = New Font("Segoe UI Semibold", 11.0F)
    Public ReadOnly FontBody As Font = New Font("Segoe UI", 9.5F)
    Public ReadOnly FontBodyBold As Font = New Font("Segoe UI Semibold", 9.5F)
    Public ReadOnly FontInput As Font = New Font("Segoe UI", 10.0F)
    Public ReadOnly FontCaption As Font = New Font("Segoe UI", 8.5F)
    Public ReadOnly FontButton As Font = New Font("Segoe UI Semibold", 9.5F)
    Public ReadOnly FontGridHeader As Font = New Font("Segoe UI Semibold", 9.0F)
    Public ReadOnly FontGridCell As Font = New Font("Segoe UI", 9.0F)

    ''' <summary>Apply the standard canvas + font to a whole form.</summary>
    Public Sub StyleForm(f As Form)
        f.BackColor = Background
        f.ForeColor = TextPrimary
        f.Font = FontBody
    End Sub

    ''' <summary>Standard white card look for a rounded panel.</summary>
    Public Sub StyleCard(pnl As CustomPanel, Optional radius As Integer = 12)
        pnl.BackColor = Surface
        pnl.BorderColor = Border
        pnl.BorderThickness = 1
        pnl.CornerRadius = radius
    End Sub

    ''' <summary>Standard card look for the legacy RoundedPanel control.</summary>
    Public Sub StyleCard(pnl As RoundedPanel, Optional radius As Integer = 12)
        pnl.BackColor = Surface
        pnl.BorderColor = Border
        pnl.BorderThickness = 1
        pnl.CornerRadius = radius
    End Sub

    ''' <summary>Accent card: white with a soft green border (for stat tiles).</summary>
    Public Sub StyleAccentCard(pnl As CustomPanel, Optional radius As Integer = 12)
        pnl.BackColor = Surface
        pnl.BorderColor = PrimarySoft
        pnl.BorderThickness = 1
        pnl.CornerRadius = radius
    End Sub

    ''' <summary>Filled primary button (green, white text).</summary>
    Public Sub StylePrimaryButton(btn As CustomButton)
        btn.NormalColor = Primary
        btn.HoverColor = PrimaryHover
        btn.BorderColor = Primary
        btn.BorderSize = 0
        btn.CornerRadius = 8
        btn.ForeColor = TextOnPrimary
        btn.Font = FontButton
        btn.Cursor = Cursors.Hand
    End Sub

    ''' <summary>Secondary button: white with a green outline.</summary>
    Public Sub StyleSecondaryButton(btn As CustomButton)
        btn.NormalColor = Surface
        btn.HoverColor = AccentSoft
        btn.BorderColor = Primary
        btn.BorderSize = 1
        btn.CornerRadius = 8
        btn.ForeColor = Primary
        btn.Font = FontButton
        btn.Cursor = Cursors.Hand
    End Sub

    ''' <summary>Quiet/ghost button for low-emphasis actions.</summary>
    Public Sub StyleGhostButton(btn As CustomButton)
        btn.NormalColor = Background
        btn.HoverColor = PrimarySoft
        btn.BorderColor = Border
        btn.BorderSize = 1
        btn.CornerRadius = 8
        btn.ForeColor = TextSecondary
        btn.Font = FontButton
        btn.Cursor = Cursors.Hand
    End Sub

    ''' <summary>Flat nav/toolbar button (standard Button, no rounding).</summary>
    Public Sub StyleNavButton(btn As Button, active As Boolean)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = If(active, FontButton, FontBody)
        btn.ForeColor = If(active, TextOnPrimary, TextSecondary)
        btn.BackColor = If(active, Primary, Background)
    End Sub

    ''' <summary>Single consistent DataGridView theme used app-wide.</summary>
    Public Sub StyleGrid(dgv As DataGridView)
        With dgv
            .EnableHeadersVisualStyles = False
            .BackgroundColor = Surface
            .BorderStyle = BorderStyle.None
            .GridColor = GridLine
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersVisible = False

            .ColumnHeadersDefaultCellStyle.BackColor = GridHeaderFill
            .ColumnHeadersDefaultCellStyle.ForeColor = GridHeaderText
            .ColumnHeadersDefaultCellStyle.Font = FontGridHeader
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .ColumnHeadersHeight = 42
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            .DefaultCellStyle.BackColor = Surface
            .DefaultCellStyle.ForeColor = TextPrimary
            .DefaultCellStyle.Font = FontGridCell
            .DefaultCellStyle.Padding = New Padding(6, 0, 6, 0)
            .DefaultCellStyle.SelectionBackColor = AccentSoft
            .DefaultCellStyle.SelectionForeColor = TextPrimary

            .AlternatingRowsDefaultCellStyle.BackColor = SurfaceAlt
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = AccentSoft
            .AlternatingRowsDefaultCellStyle.SelectionForeColor = TextPrimary

            .RowTemplate.Height = 34
        End With
    End Sub

    ''' <summary>Clean text input.</summary>
    Public Sub StyleInput(tb As TextBoxBase)
        tb.Font = FontInput
        tb.ForeColor = TextPrimary
        tb.BackColor = InputFill
        tb.BorderStyle = BorderStyle.FixedSingle
    End Sub

    ''' <summary>Clean dropdown.</summary>
    Public Sub StyleCombo(cbo As ComboBox)
        cbo.Font = FontInput
        cbo.ForeColor = TextPrimary
        cbo.BackColor = InputFill
        cbo.FlatStyle = FlatStyle.Flat
    End Sub

    ''' <summary>Small role/status pill.</summary>
    Public Sub StylePill(lbl As Label, Optional bg As Color? = Nothing, Optional fg As Color? = Nothing)
        lbl.BackColor = If(bg.HasValue, bg.Value, AccentSoft)
        lbl.ForeColor = If(fg.HasValue, fg.Value, Primary)
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.Font = FontCaption
    End Sub

    ''' <summary>Dark green page header bar with white title text.</summary>
    Public Sub StyleHeaderBar(pnl As Panel, title As Label)
        pnl.BackColor = Primary
        If title IsNot Nothing Then
            title.ForeColor = TextOnPrimary
            title.Font = FontSection
        End If
    End Sub

End Module
