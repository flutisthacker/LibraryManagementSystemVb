<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class issue
    ' Inherits System.Windows.Forms.Form
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
        Me.Booklbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ISlbl = New System.Windows.Forms.Label()
        Me.Autlbl = New System.Windows.Forms.Label()
        Me.Publbl = New System.Windows.Forms.Label()
        Me.Stalbl = New System.Windows.Forms.Label()
        Me.Catlbl = New System.Windows.Forms.Label()
        Me.Pdatelbl = New System.Windows.Forms.Label()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.tisbn = New System.Windows.Forms.TextBox()
        Me.Tpub = New System.Windows.Forms.TextBox()
        Me.tstatus = New System.Windows.Forms.TextBox()
        Me.tath = New System.Windows.Forms.TextBox()
        Me.cbcat = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtpd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tcopy = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tprice = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Booklbl
        '
        Me.Booklbl.AutoSize = True
        Me.Booklbl.ForeColor = System.Drawing.Color.Transparent
        Me.Booklbl.Location = New System.Drawing.Point(24, 73)
        Me.Booklbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Booklbl.Name = "Booklbl"
        Me.Booklbl.Size = New System.Drawing.Size(81, 15)
        Me.Booklbl.TabIndex = 0
        Me.Booklbl.Text = "Book Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(36, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 0
        '
        'ISlbl
        '
        Me.ISlbl.AutoSize = True
        Me.ISlbl.ForeColor = System.Drawing.Color.Transparent
        Me.ISlbl.Location = New System.Drawing.Point(24, 307)
        Me.ISlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ISlbl.Name = "ISlbl"
        Me.ISlbl.Size = New System.Drawing.Size(63, 15)
        Me.ISlbl.TabIndex = 0
        Me.ISlbl.Text = "ISBN no."
        '
        'Autlbl
        '
        Me.Autlbl.AutoSize = True
        Me.Autlbl.ForeColor = System.Drawing.Color.Transparent
        Me.Autlbl.Location = New System.Drawing.Point(24, 108)
        Me.Autlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Autlbl.Name = "Autlbl"
        Me.Autlbl.Size = New System.Drawing.Size(48, 15)
        Me.Autlbl.TabIndex = 0
        Me.Autlbl.Text = "Author"
        '
        'Publbl
        '
        Me.Publbl.AutoSize = True
        Me.Publbl.ForeColor = System.Drawing.Color.Transparent
        Me.Publbl.Location = New System.Drawing.Point(24, 186)
        Me.Publbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Publbl.Name = "Publbl"
        Me.Publbl.Size = New System.Drawing.Size(79, 15)
        Me.Publbl.TabIndex = 0
        Me.Publbl.Text = "Publication"
        '
        'Stalbl
        '
        Me.Stalbl.AutoSize = True
        Me.Stalbl.ForeColor = System.Drawing.Color.Transparent
        Me.Stalbl.Location = New System.Drawing.Point(24, 269)
        Me.Stalbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Stalbl.Name = "Stalbl"
        Me.Stalbl.Size = New System.Drawing.Size(47, 15)
        Me.Stalbl.TabIndex = 0
        Me.Stalbl.Text = "Status"
        '
        'Catlbl
        '
        Me.Catlbl.AutoSize = True
        Me.Catlbl.ForeColor = System.Drawing.Color.Transparent
        Me.Catlbl.Location = New System.Drawing.Point(24, 148)
        Me.Catlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Catlbl.Name = "Catlbl"
        Me.Catlbl.Size = New System.Drawing.Size(63, 15)
        Me.Catlbl.TabIndex = 0
        Me.Catlbl.Text = "Category"
        '
        'Pdatelbl
        '
        Me.Pdatelbl.AutoSize = True
        Me.Pdatelbl.ForeColor = System.Drawing.Color.Transparent
        Me.Pdatelbl.Location = New System.Drawing.Point(24, 229)
        Me.Pdatelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Pdatelbl.Name = "Pdatelbl"
        Me.Pdatelbl.Size = New System.Drawing.Size(105, 15)
        Me.Pdatelbl.TabIndex = 0
        Me.Pdatelbl.Text = "Published Date"
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(176, 67)
        Me.tbname.Margin = New System.Windows.Forms.Padding(4)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(132, 21)
        Me.tbname.TabIndex = 1
        '
        'tisbn
        '
        Me.tisbn.Location = New System.Drawing.Point(176, 301)
        Me.tisbn.Margin = New System.Windows.Forms.Padding(4)
        Me.tisbn.Name = "tisbn"
        Me.tisbn.Size = New System.Drawing.Size(132, 21)
        Me.tisbn.TabIndex = 1
        '
        'Tpub
        '
        Me.Tpub.Location = New System.Drawing.Point(176, 179)
        Me.Tpub.Margin = New System.Windows.Forms.Padding(4)
        Me.Tpub.Name = "Tpub"
        Me.Tpub.Size = New System.Drawing.Size(132, 21)
        Me.Tpub.TabIndex = 1
        '
        'tstatus
        '
        Me.tstatus.Location = New System.Drawing.Point(176, 261)
        Me.tstatus.Margin = New System.Windows.Forms.Padding(4)
        Me.tstatus.Name = "tstatus"
        Me.tstatus.Size = New System.Drawing.Size(132, 21)
        Me.tstatus.TabIndex = 1
        '
        'tath
        '
        Me.tath.Location = New System.Drawing.Point(176, 100)
        Me.tath.Margin = New System.Windows.Forms.Padding(4)
        Me.tath.Name = "tath"
        Me.tath.Size = New System.Drawing.Size(132, 21)
        Me.tath.TabIndex = 1
        '
        'cbcat
        '
        Me.cbcat.FormattingEnabled = True
        Me.cbcat.Items.AddRange(New Object() {"Suspense ", "Crime ", "Detective", "Thriller", "Mystery"})
        Me.cbcat.Location = New System.Drawing.Point(176, 138)
        Me.cbcat.Name = "cbcat"
        Me.cbcat.Size = New System.Drawing.Size(132, 23)
        Me.cbcat.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(325, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(711, 378)
        Me.DataGridView1.TabIndex = 4
        '
        'dtpd
        '
        Me.dtpd.Location = New System.Drawing.Point(176, 223)
        Me.dtpd.Name = "dtpd"
        Me.dtpd.Size = New System.Drawing.Size(143, 21)
        Me.dtpd.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 344)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "copy"
        '
        'tcopy
        '
        Me.tcopy.Location = New System.Drawing.Point(106, 344)
        Me.tcopy.Margin = New System.Windows.Forms.Padding(4)
        Me.tcopy.Name = "tcopy"
        Me.tcopy.Size = New System.Drawing.Size(73, 21)
        Me.tcopy.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(24, 376)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "price"
        '
        'tprice
        '
        Me.tprice.Location = New System.Drawing.Point(106, 370)
        Me.tprice.Margin = New System.Windows.Forms.Padding(4)
        Me.tprice.Name = "tprice"
        Me.tprice.Size = New System.Drawing.Size(73, 21)
        Me.tprice.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_trash_26
        Me.PictureBox2.Location = New System.Drawing.Point(253, 344)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_edit_property_50
        Me.PictureBox1.Location = New System.Drawing.Point(186, 344)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'issue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 414)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtpd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbcat)
        Me.Controls.Add(Me.tath)
        Me.Controls.Add(Me.tstatus)
        Me.Controls.Add(Me.Tpub)
        Me.Controls.Add(Me.tprice)
        Me.Controls.Add(Me.tcopy)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "issue"
        Me.Text = "Edit Book"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Booklbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ISlbl As System.Windows.Forms.Label
    Friend WithEvents Autlbl As System.Windows.Forms.Label
    Friend WithEvents Publbl As System.Windows.Forms.Label
    Friend WithEvents Stalbl As System.Windows.Forms.Label
    Friend WithEvents Catlbl As System.Windows.Forms.Label
    Friend WithEvents Pdatelbl As System.Windows.Forms.Label
    Friend WithEvents tbname As System.Windows.Forms.TextBox
    Friend WithEvents tisbn As System.Windows.Forms.TextBox
    Friend WithEvents Tpub As System.Windows.Forms.TextBox
    Friend WithEvents tstatus As System.Windows.Forms.TextBox
    Friend WithEvents tath As System.Windows.Forms.TextBox
    Friend WithEvents cbcat As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dtpd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tcopy As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tprice As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
