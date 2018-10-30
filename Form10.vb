Imports ADODB
Imports System.String

Public Class Form10
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim str As String

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTitle.Items.Add("Prof.")
        cboTitle.Items.Add("Dr.")
        cboTitle.Items.Add("Mr.")
        cboTitle.Items.Add("Mrs.")
        cboTitle.Items.Add("Miss")
        cboTitle.Items.Add("Ms")

        cboSchool.Items.Add("Science, Engineering and Health")
        cboSchool.Items.Add("Business and Economics")
        cboSchool.Items.Add("Communication, Language and Performing Arts")
        cboSchool.Items.Add("Human and Social Sciences")
        cboSchool.Items.Add("Arts and Humanities")

        con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Joey\Documents\College.mdb; Persist Security Info = False")
        rs.Open("Select * from LecturersProfile", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)

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
        txtID.Text = ""
        cboTitle.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        DateTimePicker1.Value = Date.Today
        rbMale.Checked = False
        rbFemale.Checked = False
        cboSchool.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        PictureBox1.Image = Nothing
        txtPassword.Text = ""
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

    Sub refreshData()
        rs.Close()
        rs.Open("Select * from LecturersProfile", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
        If Not rs.EOF Then
            rs.MoveNext()
            display()
        Else
            MsgBox("Record Not Found.", MsgBoxStyle.Information)
        End If
    End Sub

    Sub reload()
        rs.Close()
        rs.Open("Select * from LecturersProfile", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
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
        rs.Fields("Password").Value = txtPassword.Text

        If str = "" Then
            MsgBox("Please Upload a Photo for the Lecturer.", MsgBoxStyle.Critical)
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
        confirm = MsgBox("Do You Really Want to Delete This Lecturer Profile?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Deletion Confirmation")
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
        rs.Fields("Password").Value = txtPassword.Text

        MsgBox("Record Updated Successfully.", MsgBoxStyle.Information)
        rs.Update()
    End Sub

    Private Sub cmdDisplay_Click(sender As Object, e As EventArgs) Handles cmdDisplay.Click
        display()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        rs.Close()
        rs.Open("Select * from LecturersProfile where LecturerID = '" + txtID.Text + "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)
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