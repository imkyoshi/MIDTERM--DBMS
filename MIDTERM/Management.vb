Public Class Management
    Private Sub Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.fillsview()
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
    Sub fillsview()
        Try
            ListView1.Items.Clear()
            strsql = "SELECT * FROM tbl_pcperipherals"
            objcmd = New MySql.Data.MySqlClient.MySqlCommand(strsql, objconn)
            objdr = objcmd.ExecuteReader
            While (objdr.Read)
                With ListView1.Items.Add(objdr("ProductID"))
                    .SubItems.add(objdr("ProductName"))
                    .subitems.add(objdr("ProductBrand"))
                    .subitems.add(objdr("ProductCategory"))
                    .subitems.add(objdr("ProductQuantity"))
                    .subitems.add(objdr("ProductDescription"))
                    .subitems.add(objdr("ProductManufacturer"))
                    .subitems.add(objdr("Stock"))
                    .subitems.add(objdr("Supplier"))
                    .subitems.add(objdr("DateShipped"))
                End With
            End While
            objcmd.Dispose()
            objdr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.fillsview()
        End Try
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        strsql = "INSERT tbl_pcperipherals set ProductName=@field2, ProductBrand=@field3, ProductCategory=@field4, ProductQuantity=@field5, ProductDescription=@field6, ProductManufacturer=@field7, 
        Stock=@field8,Supplier=@field9, DateShipped=@field10"
        objcmd = New MySql.Data.MySqlClient.MySqlCommand(strsql, objconn)
        With objcmd
            .Parameters.AddWithValue("@field1", txtpdtid.Text)
            .Parameters.AddWithValue("@field2", txtpdtnme.Text)
            .Parameters.AddWithValue("@field3", txtpdtbrnd.Text)
            .Parameters.AddWithValue("@field4", txtpdtctgry.Text)
            .Parameters.AddWithValue("@field5", txtpdtqnty.Text)
            .Parameters.AddWithValue("@field6", txtpdtdcpt.Text)
            .Parameters.AddWithValue("@field7", txtpdtmanu.Text)
            .Parameters.AddWithValue("@field8", txtstock.Text)
            .Parameters.AddWithValue("@field9", txtsupplier.Text)
            .Parameters.AddWithValue("@field10", txtdate.Text)
        End With
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        MsgBox("Recrod Saved")
        Me.fillsview()
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        strsql = "UPDATE tbl_pcperipherals set ProductName=@field2, ProductBrand=@field3, ProductCategory=@field4, ProductQuantity=@field5, ProductDescription=@field6, ProductManufacturer=@field7, 
        Stock=@field8,Supplier=@field9, DateShipped=@field10"
        objcmd = New MySql.Data.MySqlClient.MySqlCommand(strsql, objconn)
        With objcmd
            .Parameters.AddWithValue("@field1", txtpdtid.Text)
            .Parameters.AddWithValue("@field2", txtpdtnme.Text)
            .Parameters.AddWithValue("@field3", txtpdtbrnd.Text)
            .Parameters.AddWithValue("@field4", txtpdtctgry.Text)
            .Parameters.AddWithValue("@field5", txtpdtqnty.Text)
            .Parameters.AddWithValue("@field6", txtpdtdcpt.Text)
            .Parameters.AddWithValue("@field7", txtpdtmanu.Text)
            .Parameters.AddWithValue("@field8", txtstock.Text)
            .Parameters.AddWithValue("@field9", txtsupplier.Text)
            .Parameters.AddWithValue("@field10", txtdate.Text)
        End With
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        MsgBox("Recrod Update")
        Me.fillsview()
    End Sub


    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

    End Sub

    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        With ListView1.SelectedItems(0)
            txtpdtid.Text = .SubItems(0).Text
            txtpdtnme.Text = .SubItems(1).Text
            txtpdtbrnd.Text = .SubItems(2).Text
            txtpdtctgry.Text = .SubItems(3).Text
            txtpdtqnty.Text = .SubItems(4).Text
            txtpdtdcpt.Text = .SubItems(5).Text
            txtpdtmanu.Text = .SubItems(6).Text
            txtstock.Text = .SubItems(7).Text
            txtsupplier.Text = .SubItems(8).Text
            dtpdtship.Text = .SubItems(9).Text
        End With
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class