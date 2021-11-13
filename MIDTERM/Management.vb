Public Class Management
    Private Sub Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                With ListView1.Items.Add(objdr("Product ID"))
                    .subitems.add(objdr("Product Name"))
                    .subitems.add(objdr("Product Brand"))
                    .subitems.add(objdr("Product Category"))
                    .subitems.add(objdr("Product Quantity"))
                    .subitems.add(objdr("Product Description"))
                    .subitems.add(objdr("Product Manufacturer"))
                    .subitems.add(objdr("Stock"))
                    .subitems.add(objdr("Supplier"))
                    .subitems.add(objdr("Date Shipped"))
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
        strsql = "INSERT tbl_pcperipherals set Product Name=@field2, Product Brand=@field3, Product Category=@field4, Product Quantity=@field5, Product Description=@field6, Product Manufacturer=@field7, 
        Stock=@field8,Supplier=@field9, Date Shipped=@field10,"
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
            .Parameters.AddWithValue("@field10", txtdtship.Text)
        End With
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        MsgBox("Recrod Update")
        Me.fillsview()
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        strsql = "UPDATE tbl_pcperipherals set Product Name=@field2, Product Brand=@field3, Product Category=@field4, Product Quantity=@field5, Product Description=@field6, Product Manufacturer=@field7, 
        Stock=@field8,Supplier=@field9, Date Shipped=@field10,"
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
            .Parameters.AddWithValue("@field10", txtdtship.Text)
        End With
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        MsgBox("Recrod Update")
        Me.fillsview()
    End Sub


    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

    End Sub
End Class