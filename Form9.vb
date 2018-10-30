Imports ADODB
Imports System.String

Public Class Form9
    Public con As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public str As String

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboProgram.Items.Add("Applied Computer Science")
        cboProgram.Items.Add("Electrical Engineering")
        cboProgram.Items.Add("Communication")
        cboProgram.Items.Add("International Relations")
        cboProgram.Items.Add("Economics")

        con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Joey\Documents\College.mdb; Persist Security Info = False")
        rs.Open("Select * from StudentsProfile", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)

        display()
    End Sub

    Private Sub cmdPhoto_Click(sender As Object, e As EventArgs) Handles cmdPhoto.Click
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "Jpeg | *.jpg"
        str = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(str)
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        rs.AddNew()
        clear()
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        lblPassword.Visible = True
        txtPassword.Visible = True
    End Sub

    Sub clear()
        txtAdmNo.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        DateTimePicker1.Value = Date.Today
        rbMale.Checked = False
        rbFemale.Checked = False
        cboProgram.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        PictureBox1.Image = Nothing
        txtPassword.Text = ""
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
        txtPassword.Text = rs.Fields("Password").Value
        lblPassword.Visible = False
        txtPassword.Visible = False
    End Sub

    Sub refreshData()
        rs.Close()
        rs.Open("Select * from StudentsProfile", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
        If Not rs.EOF Then
            rs.MoveNext()
            display()
        Else
            MsgBox("Record Not Found.", MsgBoxStyle.Information)
        End If
    End Sub

    Sub reload()
        rs.Close()
        rs.Open("Select * from StudentsProfile", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
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
        rs.Fields("Photo").Value = str
        rs.Fields("Password").Value = txtPassword.Text

        If str = "" Then
            MsgBox("Please Upload a Photo for the Student.", MsgBoxStyle.Critical)
        Else
            MsgBox("Record Saved Successfully.", MsgBoxStyle.Information)
            rs.Update()
        End If
    End Sub

    Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
        rs.MoveFirst()
        display()
    End Sub

    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        rs.MoveLast()
        display()
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        rs.MoveNext()
        If Not rs.EOF Then
            display()
        Else
            rs.MoveFirst()
            display()
        End If
    End Sub

    Private Sub cmdPrevious_Click(sender As Object, e As EventArgs) Handles cmdPrevious.Click
        rs.MovePrevious()
        If rs.BOF Then
            rs.MoveLast()
            display()
        Else
            display()
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim confirm As String
        confirm = MsgBox("Do You Really Want to Delete This Student Profile?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Deletion Confirmation")
        If confirm = vbYes Then
            rs.Delete(AffectEnum.adAffectCurrent)
            MsgBox("Record Deleted Successfully.", MsgBoxStyle.Information, "Message")
            rs.Update()
            refreshData()
        Else
            MsgBox("Record Not Deleted.", MsgBoxStyle.Information, "Message")
        End If
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
        rs.Fields("Photo").Value = str
        rs.Fields("Password").Value = txtPassword.Text

        MsgBox("Record Updated Successfully.", MsgBoxStyle.Information)
        rs.Update()
    End Sub

    Private Sub cmdDisplay_Click(sender As Object, e As EventArgs) Handles cmdDisplay.Click
        display()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        rs.Close()
        rs.Open("Select * from StudentsProfile where AdmNo = '" + txtAdmNo.Text + "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)
        If Not rs.EOF Then
            display()
            reload()
        Else
            MsgBox("Record Not Found.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        lblPassword.Visible = True
        txtPassword.Visible = True
    End Sub
End Class