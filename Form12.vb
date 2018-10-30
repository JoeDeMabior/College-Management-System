Imports ADODB
Imports System.String

Public Class Form12
    Public con As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim count As Integer = 0

        con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Joey\Documents\College.mdb; Persist Security Info = False")
        rs.Open("Select School from LecturersProfile where LecturerID = '" + Form7.txtUsername.Text + "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)

        lblSchool.Text = rs.Fields("School").Value

        If rs.Fields("School").Value = "Science, Engineering and Health" And Form11.lblProgram.Text = "Applied Computer Science" Then
            count += 1
            txtStudents.Text = count
        ElseIf rs.Fields("School").Value = "Science, Engineering and Health" And Form11.lblProgram.Text = "Electrical Engineering" Then
            count += 1
            txtStudents.Text = count
            txtStudents.Text = count
        ElseIf rs.Fields("School").Value = "Communication, Language and Performing Arts" And Form11.lblProgram.Text = "Communication" Then
            count += 1
            txtStudents.Text = count
        ElseIf rs.Fields("School").Value = "Arts and Humanities" And Form11.lblProgram.Text = "International Relations" Then
            count += 1
            txtStudents.Text = count
        ElseIf rs.Fields("School").Value = "Business and Economics" And Form11.lblProgram.Text = "Economics" Then
            count += 1
            txtStudents.Text = count
        End If
    End Sub

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        If txtStudents.Text = "" Then
            MsgBox("No Student(s) Registered.", MsgBoxStyle.Information)
        Else
            rs.Close()
            rs.Open("Select AdmNo, FirstName, LastName from StudentsProfile where Program = '" + Form11.lblProgram.Text + "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)

            txtAdmNo.Text = rs.Fields("AdmNo").Value
            txtName.Text = rs.Fields("LastName").Value + ", " + rs.Fields("FirstName").Value
        End If
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class