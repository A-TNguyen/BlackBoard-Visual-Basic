﻿Public Class FormStudentManagement
    Private Sub Student_DataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Student_DataBindingNavigatorSaveItem.Click
        ' Save
        'Me.Validate()
        'Me.Student_DataBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.StudentDatabaseDataSet)

        ' TODO :)
        SaveButton.PerformClick()

    End Sub

    Private Sub FormStudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDatabaseDataSet.Student_Data' table. You can move, or remove it, as needed.
        Me.Student_DataTableAdapter.Fill(Me.StudentDatabaseDataSet.Student_Data)

    End Sub

    Private Sub Class3Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Enroll_CountTextBox_TextChanged(sender As Object, e As EventArgs) Handles Enroll_CountTextBox.TextChanged

    End Sub

    Private Sub StudentIDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StudentIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentIDTextBox.TextChanged

    End Sub

    Private Sub FirstNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged

    End Sub

    Private Sub Enroll_CountLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged

    End Sub

    Private Sub Class1Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Class1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Class1TextBox.TextChanged

    End Sub

    Private Sub Class2Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Class2TextBox_TextChanged(sender As Object, e As EventArgs) Handles Class2TextBox.TextChanged

    End Sub

    Private Sub LastNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Class3TextBox_TextChanged(sender As Object, e As EventArgs) Handles Class3TextBox.TextChanged

    End Sub

    Private Sub Class4Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Class4TextBox_TextChanged(sender As Object, e As EventArgs) Handles Class4TextBox.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        ' TODO :)
        AddNewButton.PerformClick()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        ' TODO :)
        DeleteButton.PerformClick()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        Admin_Student_Option.Show()
    End Sub

    Private Sub AddNewButton_Click(sender As Object, e As EventArgs) Handles AddNewButton.Click
        ' Add new
        ' MsgBox("You pressed Add Student Button")

        Try
            With AddNewButton
                If .Text = "Add New Student" Then
                    Student_DataBindingSource.AddNew()
                    .Text = "Cancel"
                Else
                    RefreshData()
                    .Text = "Add New Student"
                End If
            End With

            With FirstNameTextBox
                If (.CanSelect) Then
                    .Text = String.Empty
                    .Select()
                End If
            End With

        Catch ex As Exception
            MsgBox("An Error Occurred: " & ex.Message.ToString(),
                   MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Add new student failed.")
        End Try

    End Sub

    Private Sub RefreshData()

        Try
            Me.Student_DataBindingSource.Filter = Nothing
            Me.Student_DataTableAdapter.Fill(Me.StudentDatabaseDataSet.Student_Data)
        Catch ex As Exception
            MsgBox("Refresh Data Error!")
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ' Save | Update 
        ' MsgBox("You pressed Save Student Button")

        Try

            Dim result As DialogResult
            result = MessageBox.Show("Do you want to save the selected student?", "Save Data: ",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (result = DialogResult.Yes) Then
                Validate()
                Student_DataBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.StudentDatabaseDataSet)

                MessageBox.Show("The student has been successfully saved.",
                            "Save Data : ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                RefreshData()

            Else
                ' Exit Sub
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("Save | Update Failed: " & ex.Message.ToString(),
                            "Save Data : ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub



    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        ' Delete 
        ' MsgBox("You pressed Delete Student Button")
        Try

            If MessageBox.Show("Do you want to permenantly delete the selected student?",
                               "Delete Data: ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                Student_DataBindingSource.RemoveCurrent()

                Student_DataBindingSource.EndEdit()
                Student_DataTableAdapter.Update(StudentDatabaseDataSet.Student_Data)

                RefreshData()

                MessageBox.Show("The student has been deleted.",
                           "Delete Data : ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("Delete Data Failed: " & ex.Message.ToString(),
                           "Delete Data : ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteButton_Click_1(sender As Object, e As EventArgs) Handles DeleteButton.Click

    End Sub

    Private Sub Enroll_CountLabel_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
