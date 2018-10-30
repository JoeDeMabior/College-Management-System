Imports ADODB
Imports System.String

Public Class Form4
    Public con As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public str As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Joey\Documents\College.mdb; Persist Security Info = False")
        rs.Open("Select * from StudentsProfile where AdmNo = '" + Form6.txtUsername.Text + "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)

        Dim name As String
        name = rs.Fields("FirstName").Value
        lblWelcome.Text = name + "'s " + lblWelcome.Text

        display()
    End Sub

    Sub display()
        txtAdmNo.Text = rs.Fields("AdmNo").Value
        txtFirstName.Text = rs.Fields("FirstName").Value
        txtLastName.Text = rs.Fields("LastName").Value
        DateTimePicker1.Value = rs.Fields("DOB").Value
        If rs.Fields("Gender").Value = rbMale.Text Then
            rbMale.Checked = True
        ElseIf rs.Fields("Gender").Value = rbFemale.Text Then
            rbFemale.Checked = True
        End If
        cboProgram.Text = rs.Fields("Program").Value
        txtPhone.Text = rs.Fields("PhoneNo").Value
        txtEmail.Text = rs.Fields("Email").Value
        PictureBox1.Image = Image.FromFile(rs.Fields("Photo").Value)
        txtPassword.Text = rs("Password").Value
        lblPassword.Visible = False
        txtPassword.Visible = False
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        rs.Fields("AdmNo").Value = txtAdmNo.Text
        rs.Fields("FirstName").Value = txtFirstName.Text
        rs.Fields("LastName").Value = txtLastName.Text
        rs.Fields("DOB").Value = DateTimePicker1.Value
        If rbMale.Checked = True Then
            rs.Fields("Gender").Value = rbMale.Text
        ElseIf rbFemale.Checked = True Then
            rs.Fields("Gender").Value = rbFemale.Text
        End If
        rs.Fields("Program").Value = cboProgram.Text
        rs.Fields("PhoneNo").Value = txtPhone.Text
        rs.Fields("Email").Value = txtEmail.Text
        rs.Fields("Password").Value = txtPassword.Text

        MsgBox("Record Updated Successfully.", MsgBoxStyle.Information)
        rs.Update()
    End Sub

    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click
        Form6.txtUsername.Text = ""
        Form6.txtPassword.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub cmdRegister_Click(sender As Object, e As EventArgs) Handles cmdRegister.Click
        Me.Hide()
        Form11.Show()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        lblPassword.Visible = True
        txtPassword.Visible = True
    End Sub
End Class