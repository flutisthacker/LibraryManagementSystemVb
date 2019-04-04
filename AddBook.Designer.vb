<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBook
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm
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
        Me.cbcat = New System.Windows.Forms.ComboBox()
        Me.tauthor = New System.Windows.Forms.TextBox()
        Me.tstatus = New System.Windows.Forms.TextBox()
        Me.tpub = New System.Windows.Forms.TextBox()
        Me.tisbn = New System.Windows.Forms.TextBox()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pdatelbl = New System.Windows.Forms.Label()
        Me.Catlbl = New System.Windows.Forms.Label()
        Me.Stalbl = New System.Windows.Forms.Label()
        Me.Publbl = New System.Windows.Forms.Label()
        Me.Autlbl = New System.Windows.Forms.Label()
        Me.ISlbl = New System.Windows.Forms.Label()
        Me.Booklbl = New System.Windows.Forms.Label()
        Me.dtppdate = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tcbook = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tprice = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbcat
        '
        Me.cbcat.FormattingEnabled = True
        Me.cbcat.Items.AddRange(New Object() {"Suspense ", "Crime ", "Detective", "Thriller", "Mystery", "Children", "Adventure", "Fiction", "Horror", "Quest", "Gothic", "Novel", "Epic", "Erotic_romance"})
        Me.cbcat.Location = New System.Drawing.Point(196, 125)
        Me.cbcat.Name = "cbcat"
        Me.cbcat.Size = New System.Drawing.Size(153, 21)
        Me.cbcat.TabIndex = 18
        '
        'tauthor
        '
        Me.tauthor.Location = New System.Drawing.Point(196, 87)
        Me.tauthor.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.tauthor.Name = "tauthor"
        Me.tauthor.Size = New System.Drawing.Size(153, 20)
        Me.tauthor.TabIndex = 12
        '
        'tstatus
        '
        Me.tstatus.Location = New System.Drawing.Point(196, 248)
        Me.tstatus.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.tstatus.Name = "tstatus"
        Me.tstatus.Size = New System.Drawing.Size(153, 20)
        Me.tstatus.TabIndex = 14
        '
        'tpub
        '
        Me.tpub.Location = New System.Drawing.Point(196, 166)
        Me.tpub.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.tpub.Name = "tpub"
        Me.tpub.Size = New System.Drawing.Size(153, 20)
        Me.tpub.TabIndex = 15
        '
        'tisbn
        '
        Me.tisbn.Location = New System.Drawing.Point(196, 277)
        Me.tisbn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.tisbn.Name = "tisbn"
        Me.tisbn.Size = New System.Drawing.Size(153, 20)
        Me.tisbn.TabIndex = 16
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(196, 54)
        Me.tbname.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(153, 20)
        Me.tbname.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 4
        '
        'Pdatelbl
        '
        Me.Pdatelbl.AutoSize = True
        Me.Pdatelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pdatelbl.ForeColor = System.Drawing.Color.White
        Me.Pdatelbl.Location = New System.Drawing.Point(18, 216)
        Me.Pdatelbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Pdatelbl.Name = "Pdatelbl"
        Me.Pdatelbl.Size = New System.Drawing.Size(93, 13)
        Me.Pdatelbl.TabIndex = 5
        Me.Pdatelbl.Text = "Published Date"
        '
        'Catlbl
        '
        Me.Catlbl.AutoSize = True
        Me.Catlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Catlbl.ForeColor = System.Drawing.Color.White
        Me.Catlbl.Location = New System.Drawing.Point(18, 135)
        Me.Catlbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Catlbl.Name = "Catlbl"
        Me.Catlbl.Size = New System.Drawing.Size(57, 13)
        Me.Catlbl.TabIndex = 6
        Me.Catlbl.Text = "Category"
        '
        'Stalbl
        '
        Me.Stalbl.AutoSize = True
        Me.Stalbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stalbl.ForeColor = System.Drawing.Color.White
        Me.Stalbl.Location = New System.Drawing.Point(18, 256)
        Me.Stalbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Stalbl.Name = "Stalbl"
        Me.Stalbl.Size = New System.Drawing.Size(43, 13)
        Me.Stalbl.TabIndex = 7
        Me.Stalbl.Text = "Status"
        '
        'Publbl
        '
        Me.Publbl.AutoSize = True
        Me.Publbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Publbl.ForeColor = System.Drawing.Color.White
        Me.Publbl.Location = New System.Drawing.Point(18, 173)
        Me.Publbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Publbl.Name = "Publbl"
        Me.Publbl.Size = New System.Drawing.Size(70, 13)
        Me.Publbl.TabIndex = 8
        Me.Publbl.Text = "Publication"
        '
        'Autlbl
        '
        Me.Autlbl.AutoSize = True
        Me.Autlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Autlbl.ForeColor = System.Drawing.Color.White
        Me.Autlbl.Location = New System.Drawing.Point(18, 95)
        Me.Autlbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Autlbl.Name = "Autlbl"
        Me.Autlbl.Size = New System.Drawing.Size(44, 13)
        Me.Autlbl.TabIndex = 9
        Me.Autlbl.Text = "Author"
        '
        'ISlbl
        '
        Me.ISlbl.AutoSize = True
        Me.ISlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISlbl.ForeColor = System.Drawing.Color.White
        Me.ISlbl.Location = New System.Drawing.Point(18, 283)
        Me.ISlbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ISlbl.Name = "ISlbl"
        Me.ISlbl.Size = New System.Drawing.Size(58, 13)
        Me.ISlbl.TabIndex = 10
        Me.ISlbl.Text = "ISBN no."
        '
        'Booklbl
        '
        Me.Booklbl.AutoSize = True
        Me.Booklbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Booklbl.ForeColor = System.Drawing.Color.White
        Me.Booklbl.Location = New System.Drawing.Point(18, 60)
        Me.Booklbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Booklbl.Name = "Booklbl"
        Me.Booklbl.Size = New System.Drawing.Size(72, 13)
        Me.Booklbl.TabIndex = 11
        Me.Booklbl.Text = "Book Name"
        '
        'dtppdate
        '
        Me.dtppdate.Location = New System.Drawing.Point(196, 209)
        Me.dtppdate.Name = "dtppdate"
        Me.dtppdate.Size = New System.Drawing.Size(153, 20)
        Me.dtppdate.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.BookManagementSystem.My.Resources.Resources.book
        Me.PictureBox1.Location = New System.Drawing.Point(223, 318)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 334)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Copy of books"
        '
        'tcbook
        '
        Me.tcbook.Location = New System.Drawing.Point(126, 331)
        Me.tcbook.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.tcbook.Name = "tcbook"
        Me.tcbook.Size = New System.Drawing.Size(61, 20)
        Me.tcbook.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(32, 362)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Price"
        '
        'tprice
        '
        Me.tprice.Location = New System.Drawing.Point(126, 359)
        Me.tprice.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.tprice.Name = "tprice"
        Me.tprice.Size = New System.Drawing.Size(61, 20)
        Me.tprice.TabIndex = 16
        '
        'AddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 391)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtppdate)
        Me.Controls.Add(Me.cbcat)
        Me.Controls.Add(Me.tauthor)
        Me.Controls.Add(Me.tstatus)
        Me.Controls.Add(Me.tpub)
        Me.Controls.Add(Me.tprice)
        Me.Controls.Add(Me.tcbook)
        Me.Controls.Add(Me.tisbn)
        Me.Controls.Add(Me.tbname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Pdatelbl)
        Me.Controls.Add(Me.Catlbl)
        Me.Controls.Add(Me.Stalbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Publbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Autlbl)
        Me.Controls.Add(Me.ISlbl)
        Me.Controls.Add(Me.Booklbl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddBook"
        Me.Padding = New System.Windows.Forms.Padding(23, 60, 23, 20)
        Me.Text = "AddBook"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbcat As System.Windows.Forms.ComboBox
    Friend WithEvents tauthor As System.Windows.Forms.TextBox
    Friend WithEvents tstatus As System.Windows.Forms.TextBox
    Friend WithEvents tpub As System.Windows.Forms.TextBox
    Friend WithEvents tisbn As System.Windows.Forms.TextBox
    Friend WithEvents tbname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Pdatelbl As System.Windows.Forms.Label
    Friend WithEvents Catlbl As System.Windows.Forms.Label
    Friend WithEvents Stalbl As System.Windows.Forms.Label
    Friend WithEvents Publbl As System.Windows.Forms.Label
    Friend WithEvents Autlbl As System.Windows.Forms.Label
    Friend WithEvents ISlbl As System.Windows.Forms.Label
    Friend WithEvents Booklbl As System.Windows.Forms.Label
    Friend WithEvents dtppdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tcbook As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tprice As System.Windows.Forms.TextBox
End Class
