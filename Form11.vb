Imports ADODB
Imports System.String

Public Class Form11
    Public con As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Dim counter As Integer

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Joey\Documents\College.mdb; Persist Security Info = False")
        rs.Open("Select Program from StudentsProfile where AdmNo = '" + Form6.txtUsername.Text + "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)

        lblProgram.Text = rs.Fields("Program").Value

        If rs.Fields("Program").Value = "Applied Computer Science" Then
            cboCourse.Items.Add("C")
            cboCourse.Items.Add("C++")
            cboCourse.Items.Add("Java")
            cboCourse.Items.Add("Visual Basic")
        ElseIf rs.Fields("Program").Value = "Electrical Engineering" Then
            cboCourse.Items.Add("Digital Electronics")
            cboCourse.Items.Add("Python Programming Language")
            cboCourse.Items.Add("Physics")
        ElseIf rs.Fields("Program").Value = "Communication" Then
            cboCourse.Items.Add("Public Relations")
            cboCourse.Items.Add("Cultural Studies")
            cboCourse.Items.Add("Electronic Media")
        ElseIf rs.Fields("Program").Value = "International Relations" Then
            cboCourse.Items.Add("Governmental Studies")
            cboCourse.Items.Add("Conflicts and Resolution")
            cboCourse.Items.Add("Treaties")
        ElseIf rs.Fields("Program").Value = "Economics" Then
            cboCourse.Items.Add("Introduction to Economics")
            cboCourse.Items.Add("Trade")
            cboCourse.Items.Add("Banking Services")
        End If

        cboSemester.Items.Add("January 2017")
        cboSemester.Items.Add("June 2017")
        cboSemester.Items.Add("August 2017")

        counter = 0
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If cboCourse.Text = "" Then
            MsgBox("Please Select a Course to Register.", MsgBoxStyle.Critical)
        Else
            lstCourses.Items.Add(cboCourse.Text)
            counter = counter + 1
            txtCounter.Text = counter
        End If
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        lstCourses.Items.Remove(lstCourses.SelectedItem)
        counter = counter - 1
        txtCounter.Text = counter
    End Sub

    Private Sub cmdRegister_Click(sender As Object, e As EventArgs) Handles cmdRegister.Click
        If counter > 2 Then
            MsgBox("Registration Not Allowed For More Than TWO Courses.", MsgBoxStyle.Critical)
        Else
            If cboSemester.Text = "" Then
                MsgBox("Please Select a Semester.", MsgBoxStyle.Critical)
            Else
                MsgBox("Registration Successful.", MsgBoxStyle.Information)
                Me.Hide()
                Form4.Show()
                If rs.Fields("Program").Value = "Applied Computer Science" And Form12.lblSchool.Text = "Science, Engineering and Health" Then
                    Form12.txtStudents.Text = Val(Form12.txtStudents.Text) + 1
                ElseIf rs.Fields("Program").Value = "Electrical Engineering" And Form12.lblSchool.Text = "Science, Engineering and Health" Then
                    Form12.txtStudents.Text = Val(Form12.txtStudents.Text) + 1
                ElseIf rs.Fields("Program").Value = "Communication" And Form12.lblSchool.Text = "Communication, Language and Performing Arts" Then
                    Form12.txtStudents.Text = Val(Form12.txtStudents.Text) + 1
                ElseIf rs.Fields("Program").Value = "International Relations" And Form12.lblSchool.Text = "Arts and Humanities" Then
                    Form12.txtStudents.Text = Val(Form12.txtStudents.Text) + 1
                ElseIf rs.Fields("Program").Value = "Economics" And Form12.lblSchool.Text = "Business and Economics" Then
                    Form12.txtStudents.Text = Val(Form12.txtStudents.Text) + 1
                End If
            End If
        End If
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class