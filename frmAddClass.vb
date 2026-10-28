

Public Class frmAddClass

    Private ReadOnly _classService As New ClassService()
    Private ReadOnly semesterPicker As New ComboBox With {.Name = "cboOfferingSemester", .DropDownStyle = ComboBoxStyle.DropDownList}
    Private ReadOnly academicYearInput As New TextBox With {.Name = "txtOfferingYear", .MaxLength = 9}

    ' Values the dashboard reads after the dialog returns OK
    Public Property SubjectCode As String
    Public Property SubjectName As String
    Public Property SectionName As String
    Public Property ProfessorName As String

    Private Sub frmAddClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not AppSession.IsAdmin Then
            MessageBox.Show(Me, "Please sign in as an administrator.")
            Close()
            Return
        End If
        ApplyAddClassTheme()
        ConfigureOfferingFields()
        LoadProfessorsFromDb()
    End Sub

    Private Sub ApplyAddClassTheme()
        Theme.StyleForm(Me)
        Panel1.BackColor = Theme.Primary
        Panel2.BackColor = Theme.PrimarySoft
        Panel3.BackColor = Theme.Primary
        Label1.ForeColor = Theme.TextOnPrimary
        Label2.ForeColor = Theme.Primary
        For Each lbl As Label In {lblCode, lblName, lblSection, lblrpof}
            lbl.ForeColor = Theme.TextSecondary
            lbl.Font = Theme.FontCaption
        Next
        For Each tb As TextBox In {txtCode, txtName, txtSection}
            Theme.StyleInput(tb)
        Next
        Theme.StyleCombo(cboProfessor)
        Theme.StylePrimaryButton(btnsave)
        Theme.StyleSecondaryButton(btncancel)
        lblerror.ForeColor = Theme.Danger
    End Sub

    ' Adds the semester / academic-year fields below the professor picker and
    ' repositions the footer buttons to sit under them.
    Private Sub ConfigureOfferingFields()
        Dim defaults = ClassService.GetDefaultTerm()
        semesterPicker.Items.AddRange({"1st Semester", "2nd Semester"})
        semesterPicker.SelectedItem = defaults.Semester
        academicYearInput.Text = defaults.AcademicYear

        Dim top As Integer = cboProfessor.Bottom + 24
        Dim lblSem As New Label With {.Text = "Semester", .ForeColor = Theme.TextSecondary,
            .Font = Theme.FontCaption, .AutoSize = True, .Location = New Point(32, top)}
        Dim lblYear As New Label With {.Text = "Academic year", .ForeColor = Theme.TextSecondary,
            .Font = Theme.FontCaption, .AutoSize = True, .Location = New Point(224, top)}
        Theme.StyleCombo(semesterPicker)
        Theme.StyleInput(academicYearInput)
        semesterPicker.SetBounds(32, top + 19, 180, 23)
        academicYearInput.SetBounds(224, top + 19, 164, 23)

        btnsave.Top = academicYearInput.Bottom + 24
        btncancel.Top = btnsave.Top
        lblerror.Top = btnsave.Bottom + 8
        ClientSize = New Size(ClientSize.Width, lblerror.Bottom + 20)
        Text = "The Dauntless Grading System — Add Class"

        Controls.AddRange(New Control() {lblSem, lblYear, semesterPicker, academicYearInput})
    End Sub

    ''' <summary>
    ''' Loads active professors directly from MySQL into cboProfessor
    ''' </summary>
    Public Sub LoadProfessorsFromDb()
        btnsave.Enabled = False
        UiKit.TryLoadData(Me, "professor choices", Sub()
            Dim dtTeachers As DataTable = _classService.GetActiveTeachers()
            cboProfessor.DataSource = dtTeachers
            cboProfessor.DisplayMember = "display_name"
            cboProfessor.ValueMember = "teacher_id"
            cboProfessor.SelectedIndex = -1
            btnsave.Enabled = dtTeachers.Rows.Count > 0
            lblrpof.Text = If(dtTeachers.Rows.Count = 0, "No active professors", "Professor")
        End Sub)
    End Sub

    ' Kept for compatibility if called manually from Admin dashboard
    Public Sub LoadProfessors(names As IEnumerable(Of String))
        cboProfessor.DataSource = Nothing
        cboProfessor.Items.Clear()
        For Each n In names
            cboProfessor.Items.Add(n)
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lblerror.Visible = False
        If Not AppSession.IsAdmin Then
            ShowError("Administrator access is required.")
            Return
        End If
        If Not ValidationHelper.IsValidAcademicYear(academicYearInput.Text.Trim()) Then
            ShowError("Enter consecutive academic years, such as 2026-2027.")
            academicYearInput.Focus()
            Return
        End If

        ' Validation check
        If String.IsNullOrWhiteSpace(txtCode.Text) OrElse
           String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtSection.Text) Then
            ShowError("Please fill in the subject code, name and section.")
            Return
        End If

        If cboProfessor.SelectedIndex = -1 OrElse cboProfessor.SelectedValue Is Nothing Then
            ShowError("Please choose a professor.")
            Return
        End If

        Try
            ' Extract user inputs
            SubjectCode = txtCode.Text.Trim().ToUpper()
            SubjectName = txtName.Text.Trim()
            SectionName = txtSection.Text.Trim().ToUpper()

            Dim teacherId As String = cboProfessor.SelectedValue.ToString()
            ProfessorName = cboProfessor.Text

            ' Use the authenticated administrator for the audit trail.
            Dim currentAdminId As String = AppSession.CurrentUser.UserId

            ' Save offering to MySQL via ClassService & log audit event
            Dim result As OperationResult = _classService.CreateClass(
    courseCode:=SubjectCode,
    courseName:=SubjectName,
    section:=SectionName,
    semester:=semesterPicker.Text,
    academicYear:=academicYearInput.Text.Trim(),
    teacherId:=teacherId,
    adminUserId:=currentAdminId
)

            If result.Success Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                ShowError(result.Message)
            End If

        Catch ex As Exception
            ' Displays MySQL duplicates or connection errors directly on form
            ShowError(ex.Message)
        End Try
    End Sub


    Private Sub ShowError(msg As String)

        ' Hide the small error label
        lblerror.Visible = False

        ' Display the full error message
        MessageBox.Show(
        msg,
        "Add Class/Subject",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning
    )

    End Sub


    ' Designer Event Handlers
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtSection.TextChanged
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblrpof.Click
    End Sub

    Private Sub lblerror_Click(sender As Object, e As EventArgs) Handles lblerror.Click
    End Sub

End Class