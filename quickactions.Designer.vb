<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quickactions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel2 = New Panel()
        lblHeader = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        btnPrimary = New CustomButton()
        pnlGrades = New Panel()
        cboSubject = New ComboBox()
        cboStudent = New ComboBox()
        lblSubject = New Label()
        lblGrade = New Label()
        lblStudent = New Label()
        txtGrade = New TextBox()
        pnlLogs = New Panel()
        dgvLogs = New DataGridView()
        pnlRequests = New Panel()
        dgvrequests = New DataGridView()
        cboAssessment = New ComboBox()
        lblAssessment = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        pnlGrades.SuspendLayout()
        pnlLogs.SuspendLayout()
        CType(dgvLogs, ComponentModel.ISupportInitialize).BeginInit()
        pnlRequests.SuspendLayout()
        CType(dgvrequests, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Honeydew
        Panel2.Controls.Add(lblHeader)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 32)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(444, 40)
        Panel2.TabIndex = 5
        ' 
        ' lblHeader
        ' 
        lblHeader.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.ForeColor = Color.DarkGreen
        lblHeader.Location = New Point(16, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(300, 40)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Quick Actions"
        lblHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGreen
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(444, 32)
        Panel1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(11, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 17)
        Label1.TabIndex = 0
        Label1.Text = "Dauntless Wolves' Grading System"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkGreen
        Panel3.Controls.Add(btnPrimary)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 390)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(444, 41)
        Panel3.TabIndex = 6
        ' 
        ' btnPrimary
        ' 
        btnPrimary.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnPrimary.Location = New Point(336, 6)
        btnPrimary.Name = "btnPrimary"
        btnPrimary.Size = New Size(96, 30)
        btnPrimary.TabIndex = 24
        btnPrimary.Text = "Save"
        ' 
        ' pnlGrades
        ' 
        pnlGrades.Controls.Add(lblAssessment)
        pnlGrades.Controls.Add(cboAssessment)
        pnlGrades.Controls.Add(cboSubject)
        pnlGrades.Controls.Add(cboStudent)
        pnlGrades.Controls.Add(lblSubject)
        pnlGrades.Controls.Add(lblGrade)
        pnlGrades.Controls.Add(lblStudent)
        pnlGrades.Controls.Add(txtGrade)
        pnlGrades.Dock = DockStyle.Fill
        pnlGrades.Location = New Point(0, 66)
        pnlGrades.Name = "pnlGrades"
        pnlGrades.Size = New Size(444, 324)
        pnlGrades.TabIndex = 7
        ' 
        ' cboSubject
        ' 
        cboSubject.FormattingEnabled = True
        cboSubject.Location = New Point(87, 117)
        cboSubject.Name = "cboSubject"
        cboSubject.Size = New Size(275, 23)
        cboSubject.TabIndex = 23
        ' 
        ' cboStudent
        ' 
        cboStudent.FormattingEnabled = True
        cboStudent.Location = New Point(87, 58)
        cboStudent.Name = "cboStudent"
        cboStudent.Size = New Size(275, 23)
        cboStudent.TabIndex = 22
        ' 
        ' lblSubject
        ' 
        lblSubject.AutoSize = True
        lblSubject.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubject.ForeColor = Color.DarkGreen
        lblSubject.Location = New Point(85, 100)
        lblSubject.Name = "lblSubject"
        lblSubject.Size = New Size(47, 15)
        lblSubject.TabIndex = 21
        lblSubject.Text = "Subject"
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGrade.ForeColor = Color.DarkGreen
        lblGrade.Location = New Point(86, 211)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(38, 15)
        lblGrade.TabIndex = 19
        lblGrade.Text = "Grade"
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudent.ForeColor = Color.DarkGreen
        lblStudent.Location = New Point(86, 39)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(49, 15)
        lblStudent.TabIndex = 18
        lblStudent.Text = "Student"
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(85, 227)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(277, 23)
        txtGrade.TabIndex = 16
        ' 
        ' pnlLogs
        ' 
        pnlLogs.Controls.Add(dgvLogs)
        pnlLogs.Dock = DockStyle.Fill
        pnlLogs.Location = New Point(0, 66)
        pnlLogs.Name = "pnlLogs"
        pnlLogs.Size = New Size(444, 324)
        pnlLogs.TabIndex = 8
        ' 
        ' dgvLogs
        ' 
        dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLogs.Dock = DockStyle.Fill
        dgvLogs.Location = New Point(0, 0)
        dgvLogs.Name = "dgvLogs"
        dgvLogs.Size = New Size(444, 324)
        dgvLogs.TabIndex = 0
        ' 
        ' pnlRequests
        ' 
        pnlRequests.Controls.Add(dgvrequests)
        pnlRequests.Dock = DockStyle.Fill
        pnlRequests.Location = New Point(0, 66)
        pnlRequests.Name = "pnlRequests"
        pnlRequests.Size = New Size(444, 324)
        pnlRequests.TabIndex = 9
        ' 
        ' dgvrequests
        ' 
        dgvrequests.AllowUserToAddRows = False
        dgvrequests.AllowUserToDeleteRows = False
        dgvrequests.AllowUserToOrderColumns = True
        dgvrequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvrequests.BackgroundColor = Color.WhiteSmoke
        dgvrequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvrequests.Dock = DockStyle.Fill
        dgvrequests.Location = New Point(0, 0)
        dgvrequests.Name = "dgvrequests"
        dgvrequests.ReadOnly = True
        dgvrequests.RowHeadersVisible = False
        dgvrequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvrequests.Size = New Size(444, 324)
        dgvrequests.TabIndex = 0
        ' 
        ' cboAssessment
        ' 
        cboAssessment.DropDownStyle = ComboBoxStyle.DropDownList
        cboAssessment.FormattingEnabled = True
        cboAssessment.Location = New Point(87, 176)
        cboAssessment.Name = "cboAssessment"
        cboAssessment.Size = New Size(275, 23)
        cboAssessment.TabIndex = 24
        ' 
        ' lblAssessment
        ' 
        lblAssessment.AutoSize = True
        lblAssessment.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAssessment.ForeColor = Color.DarkGreen
        lblAssessment.Location = New Point(88, 158)
        lblAssessment.Name = "lblAssessment"
        lblAssessment.Size = New Size(69, 15)
        lblAssessment.TabIndex = 25
        lblAssessment.Text = "Assessment"
        ' 
        ' quickactions
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(444, 431)
        Controls.Add(pnlGrades)
        Controls.Add(pnlRequests)
        Controls.Add(pnlLogs)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "quickactions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "The Dauntless Grading System — Quick Actions"
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        pnlGrades.ResumeLayout(False)
        pnlGrades.PerformLayout()
        pnlLogs.ResumeLayout(False)
        CType(dgvLogs, ComponentModel.ISupportInitialize).EndInit()
        pnlRequests.ResumeLayout(False)
        CType(dgvrequests, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlGrades As Panel
    Friend WithEvents pnlLogs As Panel
    Friend WithEvents pnlRequests As Panel
    Friend WithEvents cboSubject As ComboBox
    Friend WithEvents cboStudent As ComboBox
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblStudent As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnPrimary As CustomButton
    Friend WithEvents dgvrequests As DataGridView
    Friend WithEvents dgvLogs As DataGridView
    Friend WithEvents cboAssessment As ComboBox
    Friend WithEvents lblAssessment As Label
End Class
