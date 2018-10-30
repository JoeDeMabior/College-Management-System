Imports ADODB
Imports System.String

Public Class Form5
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim str As String

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Joey\Documents\College.mdb; Persist Security Info = False")
        rs.Open("Select * from LecturersProfile where LecturerID = '" + Form7.txtUsername.Text + "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)

        Dim name As String
        name = rs.Fields("FirstName").Value
        lblWelcome.Text = name + "'s " + lblWelcome.Text

        display()
    End Sub

    Sub display()
        txtID.Text = rs.Fields("LecturerID").Value
        cboTitle.Text = rs.Fields("Title").Value
        txtFirstName.Text = rs.Fields("FirstName").Value
        txtLastName.Text = rs.Fields("LastName").Value
        DateTimePicker1.Value = rs.Fields("DOB").Value
        If rs.Fields("Gender").Value = rbMale.Text Then
            rbMale.Checked = True
        ElseIf rs.Fields("Gender").Value = rbFemale.Text Then
            rbFemale.Checked = True
        End If
        cboSchool.Text = rs.Fields("School").Value
        txtPhone.Text = rs.Fields("PhoneNo").Value
        txtEmail.Text = rs.Fields("Email").Value
        PictureBox1.Image = Image.FromFile(rs.Fields("Photo").Value)
        txtPassword.Text = rs.Fields("Password").Value
        lblPassword.Visible = False
        txtPassword.Visible = False
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        rs.Fields("LecturerID").Value = txtID.Text
        rs.Fields("Title").Value = cboTitle.Text
        rs.Fields("FirstName").Value = txtFirstName.Text
        rs.Fields("LastName").Value = txtLastName.Text
        rs.Fields("DOB").Value = DateTimePicker1.Value
        If rbMale.Checked = True Then
            rs.Fields("Gender").Value = rbMale.Text
        ElseIf rbFemale.Checked = True Then
            rs.Fields("Gender").Value = rbFemale.Text
        End If
        rs.Fields("School").Value = cboSchool.Text
        rs.Fields("PhoneNo").Value = txtPhone.Text
        rs.Fields("Email").Value = txtEmail.Text
        rs.Fields("Photo").Value = str
        rs.Fields("Passowrd").Value = txtPassword.Text

        MsgBox("Record Updated Successfully.", MsgBoxStyle.Information)
        rs.Update()
    End Sub

    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click
        Form7.txtUsername.Text = ""
        Form7.txtPassword.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub cmdSchedule_Click(sender As Object, e As EventArgs) Handles cmdSchedule.Click
        Me.Hide()
        Form12.Show()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        lblPassword.Visible = True
        txtPassword.Visible = True
    End Sub
End Class