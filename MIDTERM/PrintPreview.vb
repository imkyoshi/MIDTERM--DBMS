Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class PrintPreview
    Dim con As New MySqlConnection("server=localhost;username=root;password=Otosorb110;database=db_vbmysql")
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub PrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PRINTLOAD()
        Timer1.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity += 0.1
        If Me.Opacity = 100 Then
            Timer1.Stop()
        End If
    End Sub
    Sub PRINTLOAD()
        Dim dbsr As ReportDataSource
        Me.ReportViewer1.RefreshReport()
        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Report\Print.rdlc"
            End With

            Dim da As New MySqlDataAdapter
            Dim dt As New DataSet1

            con.Open()
            da.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM tbl_pcperipherals", con)
            da.Fill(dt.Tables("tbl_pcperipherals"))
            con.Close()

            dbsr = New ReportDataSource("DataSet1", dt.Tables("tbl_pcperipherals"))
            ReportViewer1.LocalReport.DataSources.Add(dbsr)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 75

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
End Class