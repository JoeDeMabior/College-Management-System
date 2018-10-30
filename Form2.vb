Public Class Form2
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim name As String = ""

        con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Joey\Documents\College.mdb; Persist Security Info = False")
        rs.Open("Select * from AdminsProfile where AdminID = '" + txtUsername.Text + "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)

        Try
            name = rs.Fields("LastName").Value
        Catch ex As Exception

        End Try

        If rs.EOF Then
            con.Close()
            MsgBox("Username Not Found. Please Try Again.", MsgBoxStyle.Exclamation, "Login Error")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Focus()
        ElseIf txtPassword.Text = rs.Fields("Password").Value Then
            con.Close()
            MsgBox("Welcome, Admin " + name + "!", MsgBoxStyle.Information, "Access Granted")
            Me.Hide()
            Form3.Show()
        ElseIf txtPassword.Text <> rs.Fields("Password").Value Then
            con.Close()
            MsgBox("Incorrect Password. Please Try Again.", MsgBoxStyle.Exclamation, "Login Error")
            txtPassword.Text = ""
            txtPassword.Focus()
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub
End Class