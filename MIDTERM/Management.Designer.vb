<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbsearch = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.dateshipped = New System.Windows.Forms.Label()
        Me.lbproductsupplier = New System.Windows.Forms.Label()
        Me.txtsupplier = New System.Windows.Forms.TextBox()
        Me.lbproductstock = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.lbproductmanufacturer = New System.Windows.Forms.Label()
        Me.txtpdtmanu = New System.Windows.Forms.TextBox()
        Me.lbproductdescription = New System.Windows.Forms.Label()
        Me.txtpdtdcpt = New System.Windows.Forms.TextBox()
        Me.lbproductquantity = New System.Windows.Forms.Label()
        Me.txtpdtqnty = New System.Windows.Forms.TextBox()
        Me.lbproductcategory = New System.Windows.Forms.Label()
        Me.txtpdtctgry = New System.Windows.Forms.TextBox()
        Me.lbproductbrand = New System.Windows.Forms.Label()
        Me.txtpdtbrnd = New System.Windows.Forms.TextBox()
        Me.lbproductname = New System.Windows.Forms.Label()
        Me.txtpdtnme = New System.Windows.Forms.TextBox()
        Me.lbproductid = New System.Windows.Forms.Label()
        Me.txtpdtid = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.Panel1.Size = New System.Drawing.Size(1334, 48)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MIDTERM.My.Resources.Resources.cross
        Me.PictureBox2.Location = New System.Drawing.Point(1136, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MIDTERM.My.Resources.Resources.minimize
        Me.PictureBox1.Location = New System.Drawing.Point(1107, 12)
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
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Controls.Add(Me.lbsearch)
        Me.Panel2.Controls.Add(Me.txtdate)
        Me.Panel2.Controls.Add(Me.txtsearch)
        Me.Panel2.Controls.Add(Me.btnsearch)
        Me.Panel2.Controls.Add(Me.btndelete)
        Me.Panel2.Controls.Add(Me.btnsave)
        Me.Panel2.Controls.Add(Me.btnupdate)
        Me.Panel2.Controls.Add(Me.dateshipped)
        Me.Panel2.Controls.Add(Me.lbproductsupplier)
        Me.Panel2.Controls.Add(Me.txtsupplier)
        Me.Panel2.Controls.Add(Me.lbproductstock)
        Me.Panel2.Controls.Add(Me.txtstock)
        Me.Panel2.Controls.Add(Me.lbproductmanufacturer)
        Me.Panel2.Controls.Add(Me.txtpdtmanu)
        Me.Panel2.Controls.Add(Me.lbproductdescription)
        Me.Panel2.Controls.Add(Me.txtpdtdcpt)
        Me.Panel2.Controls.Add(Me.lbproductquantity)
        Me.Panel2.Controls.Add(Me.txtpdtqnty)
        Me.Panel2.Controls.Add(Me.lbproductcategory)
        Me.Panel2.Controls.Add(Me.txtpdtctgry)
        Me.Panel2.Controls.Add(Me.lbproductbrand)
        Me.Panel2.Controls.Add(Me.txtpdtbrnd)
        Me.Panel2.Controls.Add(Me.lbproductname)
        Me.Panel2.Controls.Add(Me.txtpdtnme)
        Me.Panel2.Controls.Add(Me.lbproductid)
        Me.Panel2.Controls.Add(Me.txtpdtid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1334, 589)
        Me.Panel2.TabIndex = 2
        '
        'lbsearch
        '
        Me.lbsearch.AutoSize = True
        Me.lbsearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsearch.ForeColor = System.Drawing.Color.White
        Me.lbsearch.Location = New System.Drawing.Point(389, 31)
        Me.lbsearch.Name = "lbsearch"
        Me.lbsearch.Size = New System.Drawing.Size(128, 18)
        Me.lbsearch.TabIndex = 35
        Me.lbsearch.Text = "Search By Name:"
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Location = New System.Drawing.Point(183, 453)
        Me.txtdate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(192, 28)
        Me.txtdate.TabIndex = 34
        Me.txtdate.Text = "11/13/2021"
        Me.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(524, 24)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(294, 28)
        Me.txtsearch.TabIndex = 33
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Location = New System.Drawing.Point(850, 514)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(121, 48)
        Me.btnsearch.TabIndex = 32
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(689, 514)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(121, 48)
        Me.btndelete.TabIndex = 31
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(369, 514)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(121, 48)
        Me.btnsave.TabIndex = 29
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(529, 514)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(121, 48)
        Me.btnupdate.TabIndex = 28
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'dateshipped
        '
        Me.dateshipped.AutoSize = True
        Me.dateshipped.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateshipped.ForeColor = System.Drawing.Color.White
        Me.dateshipped.Location = New System.Drawing.Point(72, 463)
        Me.dateshipped.Name = "dateshipped"
        Me.dateshipped.Size = New System.Drawing.Size(104, 18)
        Me.dateshipped.TabIndex = 27
        Me.dateshipped.Text = "Date Shipped"
        '
        'lbproductsupplier
        '
        Me.lbproductsupplier.AutoSize = True
        Me.lbproductsupplier.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbproductsupplier.ForeColor = System.Drawing.Color.White
        Me.lbproductsupplier.Location = New System.Drawing.Point(108, 419)
        Me.lbproductsupplier.Name = "lbproductsupplier"
        Me.lbproductsupplier.Size = New System.Drawing.Size(68, 18)
        Me.lbproductsupplier.TabIndex = 25
        Me.lbproductsupplier.Text = "Supplier"
        '
        'txtsupplier
        '
        Me.txtsupplier.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupplier.Location = New System.Drawing.Point(183, 412)
        Me.txtsupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsupplier.Name = "txtsupplier"
        Me.txtsupplier.Size = New System.Drawing.Size(192, 28)
        Me.txtsupplier.TabIndex = 22
        Me.txtsupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbproductstock
        '
        Me.lbproductstock.AutoSize = True
        Me.lbproductstock.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbproductstock.ForeColor = System.Drawing.Color.White
        Me.lbproductstock.Location = New System.Drawing.Point(128, 378)
        Me.lbproductstock.Name = "lbproductstock"
        Me.lbproductstock.Size = New System.Drawing.Size(48, 18)
        Me.lbproductstock.TabIndex = 24
        Me.lbproductstock.Text = "Stock"
        '
        'txtstock
        '
        Me.txtstock.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.Location = New System.Drawing.Point(183, 371)
        Me.txtstock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(192, 28)
        Me.txtstock.TabIndex = 21
        Me.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbproductmanufacturer
        '
        Me.lbproductmanufacturer.AutoSize = True
        Me.lbproductmanufacturer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbproductmanufacturer.ForeColor = System.Drawing.Color.White
        Me.lbproductmanufacturer.Location = New System.Drawing.Point(13, 337)
        Me.lbproductmanufacturer.Name = "lbproductmanufacturer"
        Me.lbproductmanufacturer.Size = New System.Drawing.Size(163, 18)
        Me.lbproductmanufacturer.TabIndex = 23
        Me.lbproductmanufacturer.Text = "Product Manufacturer"
        '
        'txtpdtmanu
        '
        Me.txtpdtmanu.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtmanu.Location = New System.Drawing.Point(183, 330)
        Me.txtpdtmanu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtmanu.Name = "txtpdtmanu"
        Me.txtpdtmanu.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtmanu.TabIndex = 20
        Me.txtpdtmanu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbproductdescription
        '
        Me.lbproductdescription.AutoSize = True
        Me.lbproductdescription.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbproductdescription.ForeColor = System.Drawing.Color.White
        Me.lbproductdescription.Location = New System.Drawing.Point(26, 295)
        Me.lbproductdescription.Name = "lbproductdescription"
        Me.lbproductdescription.Size = New System.Drawing.Size(150, 18)
        Me.lbproductdescription.TabIndex = 19
        Me.lbproductdescription.Text = "Product Description"
        '
        'txtpdtdcpt
        '
        Me.txtpdtdcpt.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtdcpt.Location = New System.Drawing.Point(183, 288)
        Me.txtpdtdcpt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtdcpt.Name = "txtpdtdcpt"
        Me.txtpdtdcpt.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtdcpt.TabIndex = 16
        Me.txtpdtdcpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbproductquantity
        '
        Me.lbproductquantity.AutoSize = True
        Me.lbproductquantity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbproductquantity.ForeColor = System.Drawing.Color.White
        Me.lbproductquantity.Location = New System.Drawing.Point(49, 250)
        Me.lbproductquantity.Name = "lbproductquantity"
        Me.lbproductquantity.Size = New System.Drawing.Size(127, 18)
        Me.lbproductquantity.TabIndex = 18
        Me.lbproductquantity.Text = "Product Quantity"
        '
        'txtpdtqnty
        '
        Me.txtpdtqnty.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtqnty.Location = New System.Drawing.Point(183, 243)
        Me.txtpdtqnty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtqnty.Name = "txtpdtqnty"
        Me.txtpdtqnty.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtqnty.TabIndex = 15
        Me.txtpdtqnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbproductcategory
        '
        Me.lbproductcategory.AutoSize = True
        Me.lbproductcategory.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbproductcategory.ForeColor = System.Drawing.Color.White
        Me.lbproductcategory.Location = New System.Drawing.Point(44, 208)
        Me.lbproductcategory.Name = "lbproductcategory"
        Me.lbproductcategory.Size = New System.Drawing.Size(132, 18)
        Me.lbproductcategory.TabIndex = 17
        Me.lbproductcategory.Text = "Product Category"
        '
        'txtpdtctgry
        '
        Me.txtpdtctgry.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtctgry.Location = New System.Drawing.Point(183, 201)
        Me.txtpdtctgry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtctgry.Name = "txtpdtctgry"
        Me.txtpdtctgry.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtctgry.TabIndex = 14
        Me.txtpdtctgry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbproductbrand
        '
        Me.lbproductbrand.AutoSize = True
        Me.lbproductbrand.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbproductbrand.ForeColor = System.Drawing.Color.White
        Me.lbproductbrand.Location = New System.Drawing.Point(65, 165)
        Me.lbproductbrand.Name = "lbproductbrand"
        Me.lbproductbrand.Size = New System.Drawing.Size(111, 18)
        Me.lbproductbrand.TabIndex = 13
        Me.lbproductbrand.Text = "Product Brand"
        '
        'txtpdtbrnd
        '
        Me.txtpdtbrnd.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtbrnd.Location = New System.Drawing.Point(183, 158)
        Me.txtpdtbrnd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtbrnd.Name = "txtpdtbrnd"
        Me.txtpdtbrnd.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtbrnd.TabIndex = 10
        Me.txtpdtbrnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbproductname
        '
        Me.lbproductname.AutoSize = True
        Me.lbproductname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbproductname.ForeColor = System.Drawing.Color.White
        Me.lbproductname.Location = New System.Drawing.Point(68, 123)
        Me.lbproductname.Name = "lbproductname"
        Me.lbproductname.Size = New System.Drawing.Size(108, 18)
        Me.lbproductname.TabIndex = 12
        Me.lbproductname.Text = "Product Name"
        '
        'txtpdtnme
        '
        Me.txtpdtnme.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtnme.Location = New System.Drawing.Point(183, 113)
        Me.txtpdtnme.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtnme.Name = "txtpdtnme"
        Me.txtpdtnme.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtnme.TabIndex = 9
        Me.txtpdtnme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbproductid
        '
        Me.lbproductid.AutoSize = True
        Me.lbproductid.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbproductid.ForeColor = System.Drawing.Color.White
        Me.lbproductid.Location = New System.Drawing.Point(93, 75)
        Me.lbproductid.Name = "lbproductid"
        Me.lbproductid.Size = New System.Drawing.Size(83, 18)
        Me.lbproductid.TabIndex = 11
        Me.lbproductid.Text = "Product ID"
        '
        'txtpdtid
        '
        Me.txtpdtid.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdtid.Location = New System.Drawing.Point(183, 68)
        Me.txtpdtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdtid.Name = "txtpdtid"
        Me.txtpdtid.Size = New System.Drawing.Size(192, 28)
        Me.txtpdtid.TabIndex = 8
        Me.txtpdtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Interval = 80
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView1.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(386, 68)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(926, 413)
        Me.ListView1.TabIndex = 36
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ProductID"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ProductName"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ProductBrand"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ProductCategory"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 105
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ProductQuantity"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ProductDescription"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 118
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ProductManufacturer"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 129
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Stock"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Supplier"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "DateShipped"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 90
        '
        'Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1334, 637)
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
    Friend WithEvents dateshipped As Label
    Friend WithEvents lbproductsupplier As Label
    Friend WithEvents txtsupplier As TextBox
    Friend WithEvents lbproductstock As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents lbproductmanufacturer As Label
    Friend WithEvents txtpdtmanu As TextBox
    Friend WithEvents lbproductdescription As Label
    Friend WithEvents txtpdtdcpt As TextBox
    Friend WithEvents lbproductquantity As Label
    Friend WithEvents txtpdtqnty As TextBox
    Friend WithEvents lbproductcategory As Label
    Friend WithEvents txtpdtctgry As TextBox
    Friend WithEvents lbproductbrand As Label
    Friend WithEvents txtpdtbrnd As TextBox
    Friend WithEvents lbproductname As Label
    Friend WithEvents txtpdtnme As TextBox
    Friend WithEvents lbproductid As Label
    Friend WithEvents txtpdtid As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents txtdate As TextBox
    Friend WithEvents lbsearch As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
End Class
