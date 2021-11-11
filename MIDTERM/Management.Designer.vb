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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnconnect = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lbpassword = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.lbusername = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.lbserver = New System.Windows.Forms.Label()
        Me.txtserver = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Size = New System.Drawing.Size(1025, 48)
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
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnconnect)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TextBox7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.lbpassword)
        Me.Panel2.Controls.Add(Me.txtpassword)
        Me.Panel2.Controls.Add(Me.lbusername)
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Controls.Add(Me.lbserver)
        Me.Panel2.Controls.Add(Me.txtserver)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1025, 623)
        Me.Panel2.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(314, 93)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(679, 416)
        Me.ListView1.TabIndex = 30
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(328, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 48)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnconnect
        '
        Me.btnconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconnect.ForeColor = System.Drawing.Color.White
        Me.btnconnect.Location = New System.Drawing.Point(160, 536)
        Me.btnconnect.Name = "btnconnect"
        Me.btnconnect.Size = New System.Drawing.Size(121, 48)
        Me.btnconnect.TabIndex = 28
        Me.btnconnect.Text = "Update"
        Me.btnconnect.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(19, 487)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Password"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(103, 481)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(192, 28)
        Me.TextBox7.TabIndex = 26
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox7.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(19, 443)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Password"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(103, 437)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(192, 28)
        Me.TextBox4.TabIndex = 22
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox4.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Username"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(103, 396)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(192, 28)
        Me.TextBox5.TabIndex = 21
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(39, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Server"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(103, 355)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(192, 28)
        Me.TextBox6.TabIndex = 20
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(103, 313)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 28)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Username"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(103, 268)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 28)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Server"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(103, 226)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 28)
        Me.TextBox3.TabIndex = 14
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbpassword
        '
        Me.lbpassword.AutoSize = True
        Me.lbpassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpassword.ForeColor = System.Drawing.Color.White
        Me.lbpassword.Location = New System.Drawing.Point(19, 192)
        Me.lbpassword.Name = "lbpassword"
        Me.lbpassword.Size = New System.Drawing.Size(77, 18)
        Me.lbpassword.TabIndex = 13
        Me.lbpassword.Text = "Password"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(103, 183)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(192, 28)
        Me.txtpassword.TabIndex = 10
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusername.ForeColor = System.Drawing.Color.White
        Me.lbusername.Location = New System.Drawing.Point(16, 148)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(80, 18)
        Me.lbusername.TabIndex = 12
        Me.lbusername.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(103, 138)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(192, 28)
        Me.txtusername.TabIndex = 9
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbserver
        '
        Me.lbserver.AutoSize = True
        Me.lbserver.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbserver.ForeColor = System.Drawing.Color.White
        Me.lbserver.Location = New System.Drawing.Point(39, 100)
        Me.lbserver.Name = "lbserver"
        Me.lbserver.Size = New System.Drawing.Size(57, 18)
        Me.lbserver.TabIndex = 11
        Me.lbserver.Text = "Server"
        '
        'txtserver
        '
        Me.txtserver.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserver.Location = New System.Drawing.Point(103, 93)
        Me.txtserver.Margin = New System.Windows.Forms.Padding(4)
        Me.txtserver.Name = "txtserver"
        Me.txtserver.Size = New System.Drawing.Size(192, 28)
        Me.txtserver.TabIndex = 8
        Me.txtserver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Interval = 80
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(487, 536)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 48)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(642, 536)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 48)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(314, 42)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(294, 28)
        Me.TextBox8.TabIndex = 33
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 671)
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
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lbpassword As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents lbusername As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents lbserver As Label
    Friend WithEvents txtserver As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents btnconnect As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
