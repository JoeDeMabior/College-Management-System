Public Class Form1

    Private Sub cmdAdmin_Click(sender As Object, e As EventArgs) Handles cmdAdmin.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub cmdStudent_Click(sender As Object, e As EventArgs) Handles cmdStudent.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub cmdLecturer_Click(sender As Object, e As EventArgs) Handles cmdLecturer.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Dim peaceout As String
        peaceout = MsgBox("Exit the System?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "All System Out")
        If peaceout = vbYes Then
            Application.Exit()
        End If
    End Sub
End Class
