
Imports DAUNTLESS_WOLVES_PROF.Models



Public Class frmlogin

    Private ReadOnly authService As New AuthService()

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1
        ' Mask password characters in TextBox1
        TextBox1.UseSystemPasswordChar = True

        ApplyLoginTheme()
        CenterCard()
    End Sub

    ' Keep the login card centered whenever the window is resized.
    Private Sub frmLogin_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterCard()
    End Sub

    Private Sub CenterCard()
        cardlogin.Left = (ClientSize.Width - cardlogin.Width) \ 2
        cardlogin.Top = ((ClientSize.Height - Panel1.Height - Panel2.Height - cardlogin.Height) \ 2) + Panel1.Height
        If cardlogin.Top < Panel1.Height + 12 Then cardlogin.Top = Panel1.Height + 12
    End Sub

    Private Sub ApplyLoginTheme()
        Theme.StyleForm(Me)

        ' Top / bottom brand bars
        Panel1.BackColor = Theme.Primary
        Panel2.BackColor = Theme.Primary
        Label1.ForeColor = Theme.TextOnPrimary
        Label1.Font = Theme.FontCardTitle

        ' Card
        Theme.StyleCard(cardlogin, 16)
        cardlogin.ClipCorners = True

        ' Field captions
        For Each lbl As Label In {Label2, Label3}
            lbl.ForeColor = Theme.TextSecondary
            lbl.Font = Theme.FontCaption
        Next

        ' Inputs: white rounded box containing a borderless textbox
        For Each box As CustomPanel In {CustomPanel1, boxPass}
            box.BackColor = Theme.InputFill
            box.BorderColor = Theme.InputBorder
            box.BorderThickness = 1
            box.CornerRadius = 10
        Next
        For Each tb As TextBox In {boxuser, TextBox1}
            tb.Font = Theme.FontInput
            tb.ForeColor = Theme.TextPrimary
            tb.BackColor = Theme.InputFill
        Next

        ' Role selector
        boxRole.BackColor = Theme.Surface
        boxRole.BorderColor = Theme.InputBorder
        boxRole.BorderThickness = 1
        boxRole.CornerRadius = 10
        For Each rb As RadioButton In {RadioButton1, RadioButton2}
            rb.Font = Theme.FontBody
            rb.ForeColor = Theme.TextPrimary
            rb.BackColor = Color.Transparent
        Next

        ' Primary action
        Theme.StylePrimaryButton(Button1)
        Button1.CornerRadius = 10
    End Sub

    ' LOG IN BUTTON CLICK (Button1)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = ValidationHelper.SanitizeInput(boxuser.Text)
        Dim password As String = TextBox1.Text

        If Not ValidationHelper.IsRequired(username) OrElse Not ValidationHelper.IsRequired(password) Then
            MessageBox.Show("Please enter both your Username/ID and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            boxuser.Focus()
            Return
        End If

        Try
            ' 2. Authenticate user against database via UserService
            Dim user As UserModel = authService.VerifyLogin(username, password, If(RadioButton1.Checked, "Student", "Teacher"))

            If user IsNot Nothing Then
                Dim role As String = user.Role.Trim().ToLower()
                Dim picked As String = If(RadioButton1.Checked, "student", "teacher")

                ' Admins have no radio button, so let them through with either selected
                If role <> "admin" AndAlso role <> picked Then
                    MessageBox.Show("This account is not a " & picked & " account. Please select the correct role.",
                                "Wrong role", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TextBox1.Clear()
                    Return
                End If

                ' 3. Save user state in AppSession
                AppSession.StartSession(user)

                ' 4. Route to designated form based on database user role
                Select Case user.Role.Trim().ToLower()
                    Case "admin"
                        Dim adminForm As New Admin()
                        adminForm.Show()
                        Me.Close()

                    Case "teacher", "professor", "prof"
                        Dim profForm As New frmprof()
                        profForm.Show()
                        Me.Close()

                    Case "student"
                        Dim studentForm As New frmstudent()
                        studentForm.Show()
                        Me.Close()

                    Case Else
                        MessageBox.Show("Unrecognized user role assigned.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        AppSession.ClearSession()
                End Select
            Else
                MessageBox.Show("Invalid Username/ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Clear()
                TextBox1.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show($"Database connection error: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class