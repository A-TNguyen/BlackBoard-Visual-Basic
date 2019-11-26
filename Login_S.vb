Public Class Login_S
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Login Successful", MsgBoxStyle.Information)
        Me.Hide()
        Student_View.Show()
    End Sub
End Class