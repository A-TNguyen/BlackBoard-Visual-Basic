Public Class Login
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextField.TextChanged

    End Sub

    Dim a As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UsernameTextField.Text = My.Settings.Username Then
            a += 1
        End If
        If PasswordTextField.Text = My.Settings.Password Then
            a += 1
        End If
        If a = 2 Then
            MsgBox("Login Successful", MsgBoxStyle.Information)
            Me.Hide()
            FormStudentManagement.Show()

        Else
            MsgBox("Login Failed: Invalid username or password", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class