Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity += 0.1
        If Me.Opacity = 100 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim usr, pass As String
        strsql = "SELECT Username, Password FROM tbl_login WHERE Username = @field1 AND Password = @field2"
        objcmd = New MySql.Data.MySqlClient.MySqlCommand(strsql, objconn)
        With objcmd
            .Parameters.AddWithValue("@field1", txtusername1.Text)
            .Parameters.AddWithValue("@field2", txtpassword1.Text)
        End With
        objconn.Open()
        objcmd.ExecuteNonQuery()
        objdr = objcmd.ExecuteReader
        If (objdr.Read()) Then
            usr = objdr("Username")
            pass = objdr("Password") 'Validating Username and password in database'
            MsgBox("You have successfully Login!")
            objcmd.Dispose()
            objdr.Close()
            Me.Hide()
            Management.ShowDialog()
        Else
            MsgBox("Invalid Username or Password!")
        End If
        objconn.Close() 'FIX for Your Connection is already open'
        objcmd.Dispose()
        objdr.Close()
    End Sub

    Private Sub Txtpassword1_TextChanged(sender As Object, e As EventArgs) Handles txtpassword1.TextChanged
        txtpassword1.PasswordChar = "•"
    End Sub
End Class