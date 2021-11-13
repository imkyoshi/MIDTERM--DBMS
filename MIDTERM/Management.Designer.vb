<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Product ID"}, -1, System.Drawing.Color.White, System.Drawing.Color.Empty, New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Product Name"}, -1, System.Drawing.Color.White, System.Drawing.Color.Empty, New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Product Brand"}, -1, System.Drawing.Color.White, System.Drawing.Color.Empty, New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Product Category"}, -1, System.Drawing.Color.White, System.Drawing.Color.Empty, New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Product Quanity"}, -1, System.Drawing.Color.White, System.Drawing.Color.Empty, New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Product Description"}, -1, System.Drawing.Color.White, System.Drawing.Color.Empty, New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Product Manufacturer"}, -1, System.Drawing.Color.White, System.Drawing.Color.Empty, New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Stock"}, -1, System.Drawing.Color.White, System.Drawing.Color.Empty, New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Supplier"}, -1, System.Drawing.Color.White, System.Drawing.Color.Empty, New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Date Shipped"}, -1, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(130, Byte), Integer)), New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.chpdtid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chpdtnme = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chpdtbrnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chpdtctgry = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chpdtqty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chpdtdcrpt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chpdmnuft = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chstck = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chspp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdtshp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdtship = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsupplier = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpdtmanu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpdtdcpt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpdtqnty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpdtctgry = New System.Windows.Forms.TextBox()
        Me.lbpassword = New System.Windows.Forms.Label()
        Me.txtpdtbrnd = New System.Windows.Forms.TextBox()
        Me.lbusername = New System.Windows.Forms.Label()
        Me.txtpdtnme = New System.Windows.Forms.TextBox()
        Me.lbserver = New System.Windows.Forms.Label()
        Me.txtpdtid = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1195, 48)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MIDTERM.My.Resources.Resources.cross
        Me.PictureBox2.Location = New System.Drawing.Point(990, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MIDTERM.My.Resources.Resources.minimize
        Me.PictureBox1.Location = New System.Drawing.Point(961, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Server Form"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TextBox8)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Controls.Add(Me.btndelete)
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Controls.Add(Me.btnsave)
        Me.Panel2.Controls.Add(Me.btnupdate)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtdtship)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtsupplier)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtstock)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtpdtmanu)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtpdtdcpt)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtpdtqnty)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtpdtctgry)
        Me.Panel2.Controls.Add(Me.lbpassword)
        Me.Panel2.Controls.Add(Me.txtpdtbrnd)
        Me.Panel2.Controls.Add(Me.lbusername)
        Me.Panel2.Controls.Add(Me.txtpdtnme)
        Me.Panel2.Controls.Add(Me.lbserver)
        Me.Panel2.Controls.Add(Me.txtpdtid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1195, 623)
        Me.Panel2.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 80
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(412, 43)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(294, 28)
        Me.TextBox8.TabIndex = 59
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(794, 532)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(121, 48)
        Me.btnadd.TabIndex = 58
        Me.btnadd.Text = "Search"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(633, 532)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(121, 48)
        Me.btndelete.TabIndex = 57
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chpdtid, Me.chpdtnme, Me.chpdtbrnd, Me.chpdtctgry, Me.chpdtqty, Me.chpdtdcrpt, Me.chpdmnuft, Me.chstck, Me.chspp, Me.chdtshp})
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10})
        Me.ListView1.Location = New System.Drawing.Point(412, 88)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(749, 416)
        Me.ListView1.TabIndex = 56
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'chpdtid
        '
        Me.chpdtid.Text = "Product ID"
        Me.chpdtid.Width = 900
        '
        'chpdtnme
        '
        Me.chpdtnme.Text = "Product Name"
        Me.chpdtnme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chpdtnme.Width = 500
        '
        'chpdtbrnd
        '
        Me.chpdtbrnd.Text = "Product Brand"
        Me.chpdtbrnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chpdtbrnd.Width = 500
        '
        'chpdtctgry
        '
        Me.chpdtctgry.Text = "Product Category"
        Me.chpdtctgry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chpdtctgry.Width = 500
        '
        'chpdtqty
        '
        Me.chpdtqty.Text = "Product Quantity"
        Me.chpdtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chpdtqty.Width = 500
        '
        'chpdtdcrpt
        '
        Me.chpdtdcrpt.Text = "Product Description"
        Me.chpdtdcrpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chpdtdcrpt.Width = 500
        '
        'chpdmnuft
        '
        Me.chpdmnuft.Text = "Product Manufacturer"
        Me.chpdmnuft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chpdmnuft.Width = 500
        '
        'chstck
        '
        Me.chstck.Text = "Stock"
        Me.chstck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chstck.Width = 500
        '
        'chspp
        '
        Me.chspp.Text = "Supplier"
        Me.chspp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chspp.Width = 500
        '
        'chdtshp
        '
        Me.chdtshp.Text = "Date Shipped"
        Me.chdtshp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chdtshp.Width = 500
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(313, 532)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(121, 48)
        Me.btnsave.TabIndex = 55
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(473, 532)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(121, 48)
        Me.btnupdate.TabIndex = 54
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(92, 483)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 18)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Date Shipped"
        '
        'txtdtship
        '
        Me.txtdtship.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdtship.Location = New System.Drawing.Point(203, 476)
        Me.txtdtship.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdtship.Name = "txtdtship"
        Me.txtdtship.Size = New System.Drawing.Size(192, 28)
        Me.txtdtship.TabIndex = 52
        Me.txtdtship.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtdtship.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(128, 439)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Supplier"
        '
        'txtsupplier
        '
        Me.txtsupplier.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupplier.Location = New System.Drawing.Point(203, 432)
        Me.txtsupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsupplier.Name = "txtsupplier"
        Me.txtsupplier.Size = New System.Drawing.Size(192, 28)
        Me.txtsupplier.TabIndex = 48
        Me.txtsupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtsupplier.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(148, 398)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 18)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Stock"
        '
        'txtstock
        '
        Me.txtstock.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.Location = New System.Drawing.Point(203, 391)
        Me.txtstock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(192, 28)
        Me.txtstock.TabIndex = 47
        Me.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(33, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 18)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Product Manufacturer"
        '
        'txtpdtmanu
        '
        Me.txtpdtmanu.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtmanu.Location = New System.Drawing.Point(203, 350)
        Me.txtpdtmanu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtmanu.Name = "txtpdtmanu"
        Me.txtpdtmanu.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtmanu.TabIndex = 46
        Me.txtpdtmanu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 18)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Product Description"
        '
        'txtpdtdcpt
        '
        Me.txtpdtdcpt.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtdcpt.Location = New System.Drawing.Point(203, 308)
        Me.txtpdtdcpt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtdcpt.Name = "txtpdtdcpt"
        Me.txtpdtdcpt.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtdcpt.TabIndex = 42
        Me.txtpdtdcpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpdtdcpt.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(69, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 18)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Product Quantity"
        '
        'txtpdtqnty
        '
        Me.txtpdtqnty.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtqnty.Location = New System.Drawing.Point(203, 263)
        Me.txtpdtqnty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtqnty.Name = "txtpdtqnty"
        Me.txtpdtqnty.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtqnty.TabIndex = 41
        Me.txtpdtqnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(64, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 18)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Product Category"
        '
        'txtpdtctgry
        '
        Me.txtpdtctgry.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtctgry.Location = New System.Drawing.Point(203, 221)
        Me.txtpdtctgry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtctgry.Name = "txtpdtctgry"
        Me.txtpdtctgry.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtctgry.TabIndex = 40
        Me.txtpdtctgry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbpassword
        '
        Me.lbpassword.AutoSize = True
        Me.lbpassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpassword.ForeColor = System.Drawing.Color.White
        Me.lbpassword.Location = New System.Drawing.Point(85, 185)
        Me.lbpassword.Name = "lbpassword"
        Me.lbpassword.Size = New System.Drawing.Size(111, 18)
        Me.lbpassword.TabIndex = 39
        Me.lbpassword.Text = "Product Brand"
        '
        'txtpdtbrnd
        '
        Me.txtpdtbrnd.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtbrnd.Location = New System.Drawing.Point(203, 178)
        Me.txtpdtbrnd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtbrnd.Name = "txtpdtbrnd"
        Me.txtpdtbrnd.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtbrnd.TabIndex = 36
        Me.txtpdtbrnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpdtbrnd.UseSystemPasswordChar = True
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusername.ForeColor = System.Drawing.Color.White
        Me.lbusername.Location = New System.Drawing.Point(88, 140)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(108, 18)
        Me.lbusername.TabIndex = 38
        Me.lbusername.Text = "Product Name"
        '
        'txtpdtnme
        '
        Me.txtpdtnme.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtnme.Location = New System.Drawing.Point(203, 133)
        Me.txtpdtnme.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtnme.Name = "txtpdtnme"
        Me.txtpdtnme.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtnme.TabIndex = 35
        Me.txtpdtnme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbserver
        '
        Me.lbserver.AutoSize = True
        Me.lbserver.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbserver.ForeColor = System.Drawing.Color.White
        Me.lbserver.Location = New System.Drawing.Point(113, 95)
        Me.lbserver.Name = "lbserver"
        Me.lbserver.Size = New System.Drawing.Size(83, 18)
        Me.lbserver.TabIndex = 37
        Me.lbserver.Text = "Product ID"
        '
        'txtpdtid
        '
        Me.txtpdtid.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtid.Location = New System.Drawing.Point(203, 88)
        Me.txtpdtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtid.Name = "txtpdtid"
        Me.txtpdtid.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtid.TabIndex = 34
        Me.txtpdtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 671)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Management"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents chpdtid As ColumnHeader
    Friend WithEvents chpdtnme As ColumnHeader
    Friend WithEvents chpdtbrnd As ColumnHeader
    Friend WithEvents chpdtctgry As ColumnHeader
    Friend WithEvents chpdtqty As ColumnHeader
    Friend WithEvents chpdtdcrpt As ColumnHeader
    Friend WithEvents chpdmnuft As ColumnHeader
    Friend WithEvents chstck As ColumnHeader
    Friend WithEvents chspp As ColumnHeader
    Friend WithEvents chdtshp As ColumnHeader
    Friend WithEvents btnsave As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdtship As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsupplier As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtpdtmanu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpdtdcpt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpdtqnty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpdtctgry As TextBox
    Friend WithEvents lbpassword As Label
    Friend WithEvents txtpdtbrnd As TextBox
    Friend WithEvents lbusername As Label
    Friend WithEvents txtpdtnme As TextBox
    Friend WithEvents lbserver As Label
    Friend WithEvents txtpdtid As TextBox
End Class
