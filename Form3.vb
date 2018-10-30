Imports ADODB
Imports System.String

Public Class Form3
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Joey\Documents\College.mdb; Persist Security Info = False")
        rs.Open("Select * from AdminsProfile", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)

        Dim name As String
        name = rs.Fields("FirstName").Value

        lblHello.Text = lblHello.Text + ", " + name + "!"
    End Sub

    Private Sub cmdProfile_Click(sender As Object, e As EventArgs) Handles cmdProfile.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub cmdStudent_Click(sender As Object, e As EventArgs) Handles cmdStudent.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub cmdLecturer_Click(sender As Object, e As EventArgs) Handles cmdLecturer.Click
        Me.Hide()
        Form10.Show()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class