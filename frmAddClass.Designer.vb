<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddClass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    'NOTE: The following procedure is required by the Windows Form Designer.
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Panel3 = New Panel()
        txtCode = New TextBox()
        txtName = New TextBox()
        txtSection = New TextBox()
        cboProfessor = New ComboBox()
        lblCode = New Label()
        lblSection = New Label()
        lblrpof = New Label()
        lblName = New Label()
        btnsave = New CustomButton()
        btncancel = New CustomButton()
        lblerror = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGreen
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(420, 44)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(16, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 19)
        Label1.TabIndex = 0
        Label1.Text = "Dauntless Wolves' Grading System"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Honeydew
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 44)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(420, 40)
        Panel2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(16, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(200, 40)
        Label2.TabIndex = 0
        Label2.Text = "Add Class / Subject"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkGreen
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 540)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(420, 12)
        Panel3.TabIndex = 5
        ' 
        ' Field labels (consistent left margin + rhythm)
        ' 
        lblCode.AutoSize = True
        lblCode.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCode.ForeColor = Color.DarkGreen
        lblCode.Location = New Point(32, 104)
        lblCode.Name = "lblCode"
        lblCode.Size = New Size(77, 15)
        lblCode.TabIndex = 10
        lblCode.Text = "Subject Code"
        ' 
        ' txtCode
        ' 
        txtCode.Location = New Point(32, 123)
        txtCode.Name = "txtCode"
        txtCode.Size = New Size(356, 23)
        txtCode.TabIndex = 6
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.DarkGreen
        lblName.Location = New Point(32, 156)
        lblName.Name = "lblName"
        lblName.Size = New Size(82, 15)
        lblName.TabIndex = 13
        lblName.Text = "Subject Name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(32, 175)
        txtName.Name = "txtName"
        txtName.Size = New Size(356, 23)
        txtName.TabIndex = 7
        ' 
        ' lblSection
        ' 
        lblSection.AutoSize = True
        lblSection.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSection.ForeColor = Color.DarkGreen
        lblSection.Location = New Point(32, 208)
        lblSection.Name = "lblSection"
        lblSection.Size = New Size(47, 15)
        lblSection.TabIndex = 11
        lblSection.Text = "Section"
        ' 
        ' txtSection
        ' 
        txtSection.Location = New Point(32, 227)
        txtSection.Name = "txtSection"
        txtSection.Size = New Size(356, 23)
        txtSection.TabIndex = 8
        ' 
        ' lblrpof
        ' 
        lblrpof.AutoSize = True
        lblrpof.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblrpof.ForeColor = Color.DarkGreen
        lblrpof.Location = New Point(32, 260)
        lblrpof.Name = "lblrpof"
        lblrpof.Size = New Size(64, 15)
        lblrpof.TabIndex = 12
        lblrpof.Text = "Professor"
        ' 
        ' cboProfessor
        ' 
        cboProfessor.DropDownStyle = ComboBoxStyle.DropDownList
        cboProfessor.FormattingEnabled = True
        cboProfessor.Location = New Point(32, 279)
        cboProfessor.Name = "cboProfessor"
        cboProfessor.Size = New Size(356, 23)
        cboProfessor.TabIndex = 9
        ' 
        ' lblerror
        ' 
        lblerror.AutoSize = True
        lblerror.ForeColor = Color.Firebrick
        lblerror.Location = New Point(32, 504)
        lblerror.Name = "lblerror"
        lblerror.Size = New Size(34, 15)
        lblerror.TabIndex = 16
        lblerror.Text = "Error"
        lblerror.Visible = False
        ' 
        ' btnsave
        ' 
        btnsave.DialogResult = DialogResult.None
        btnsave.Location = New Point(193, 470)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(96, 34)
        btnsave.TabIndex = 14
        btnsave.Text = "Save"
        ' 
        ' btncancel
        ' 
        btncancel.DialogResult = DialogResult.Cancel
        btncancel.Location = New Point(297, 470)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(96, 34)
        btncancel.TabIndex = 15
        btncancel.Text = "Cancel"
        ' 
        ' frmAddClass
        ' 
        AcceptButton = btnsave
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        CancelButton = btncancel
        ClientSize = New Size(420, 552)
        Controls.Add(lblerror)
        Controls.Add(btncancel)
        Controls.Add(btnsave)
        Controls.Add(lblName)
        Controls.Add(lblrpof)
        Controls.Add(lblSection)
        Controls.Add(lblCode)
        Controls.Add(cboProfessor)
        Controls.Add(txtSection)
        Controls.Add(txtName)
        Controls.Add(txtCode)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAddClass"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Class/ Subject"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSection As TextBox
    Friend WithEvents cboProfessor As ComboBox
    Friend WithEvents lblCode As Label
    Friend WithEvents lblSection As Label
    Friend WithEvents lblrpof As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnsave As CustomButton
    Friend WithEvents btncancel As CustomButton
    Friend WithEvents lblerror As Label
End Class
