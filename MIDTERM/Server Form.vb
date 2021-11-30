Public Class ServerForm
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub ServerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity += 0.1
        If Me.Opacity = 100 Then
            Timer1.Stop()
        End If
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Btnconnect_Click(sender As Object, e As EventArgs) Handles btnconnect.Click
        objconn.ConnectionString = "server=" & txtserver.Text & ";" _
& "user id=" & txtusername.Text & ";" _
& "password=" & txtpassword.Text & ";" _
& "database=db_vbmysql"

        Try
            objconn.Open()
            MsgBox("You are connected!")
            objconn.Close()
            Me.Hide()
            LoginForm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        txtpassword.PasswordChar = "•"
    End Sub
End Class
