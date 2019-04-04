<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrow
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
        Me.Notice = New System.Windows.Forms.Label()
        Me.issuelbl = New System.Windows.Forms.Label()
        Me.Booknolbl = New System.Windows.Forms.Label()
        Me.booknotxt = New System.Windows.Forms.TextBox()
        Me.booknametxt = New System.Windows.Forms.TextBox()
        Me.booknamelbl = New System.Windows.Forms.Label()
        Me.datepicker = New System.Windows.Forms.DateTimePicker()
        Me.Tstatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Notice
        '
        Me.Notice.AutoSize = True
        Me.Notice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notice.ForeColor = System.Drawing.Color.White
        Me.Notice.Location = New System.Drawing.Point(171, 224)
        Me.Notice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Notice.Name = "Notice"
        Me.Notice.Size = New System.Drawing.Size(67, 15)
        Me.Notice.TabIndex = 12
        Me.Notice.Text = "Due Date"
        '
        'issuelbl
        '
        Me.issuelbl.AutoSize = True
        Me.issuelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issuelbl.ForeColor = System.Drawing.Color.White
        Me.issuelbl.Location = New System.Drawing.Point(16, 140)
        Me.issuelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.issuelbl.Name = "issuelbl"
        Me.issuelbl.Size = New System.Drawing.Size(75, 15)
        Me.issuelbl.TabIndex = 13
        Me.issuelbl.Text = "Issue Date"
        '
        'Booknolbl
        '
        Me.Booknolbl.AutoSize = True
        Me.Booknolbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Booknolbl.ForeColor = System.Drawing.Color.White
        Me.Booknolbl.Location = New System.Drawing.Point(20, 100)
        Me.Booknolbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Booknolbl.Name = "Booknolbl"
        Me.Booknolbl.Size = New System.Drawing.Size(65, 15)
        Me.Booknolbl.TabIndex = 16
        Me.Booknolbl.Text = "ISBN No."
        '
        'booknotxt
        '
        Me.booknotxt.AcceptsReturn = True
        Me.booknotxt.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.booknotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booknotxt.Location = New System.Drawing.Point(222, 95)
        Me.booknotxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.booknotxt.Multiline = True
        Me.booknotxt.Name = "booknotxt"
        Me.booknotxt.Size = New System.Drawing.Size(184, 20)
        Me.booknotxt.TabIndex = 10
        '
        'booknametxt
        '
        Me.booknametxt.AcceptsReturn = True
        Me.booknametxt.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.booknametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booknametxt.Location = New System.Drawing.Point(222, 65)
        Me.booknametxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.booknametxt.Multiline = True
        Me.booknametxt.Name = "booknametxt"
        Me.booknametxt.Size = New System.Drawing.Size(184, 20)
        Me.booknametxt.TabIndex = 10
        '
        'booknamelbl
        '
        Me.booknamelbl.AutoSize = True
        Me.booknamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booknamelbl.ForeColor = System.Drawing.Color.White
        Me.booknamelbl.Location = New System.Drawing.Point(20, 70)
        Me.booknamelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.booknamelbl.Name = "booknamelbl"
        Me.booknamelbl.Size = New System.Drawing.Size(85, 15)
        Me.booknamelbl.TabIndex = 16
        Me.booknamelbl.Text = "Book Name."
        '
        'datepicker
        '
        Me.datepicker.Location = New System.Drawing.Point(213, 136)
        Me.datepicker.Name = "datepicker"
        Me.datepicker.Size = New System.Drawing.Size(200, 20)
        Me.datepicker.TabIndex = 24
        '
        'Tstatus
        '
        Me.Tstatus.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Tstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tstatus.Location = New System.Drawing.Point(211, 178)
        Me.Tstatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tstatus.Multiline = True
        Me.Tstatus.Name = "Tstatus"
        Me.Tstatus.Size = New System.Drawing.Size(182, 20)
        Me.Tstatus.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 183)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Status"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BookManagementSystem.My.Resources.Resources.Borrow_Book_32
        Me.PictureBox1.Location = New System.Drawing.Point(174, 242)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 301)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.datepicker)
        Me.Controls.Add(Me.Notice)
        Me.Controls.Add(Me.issuelbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.booknamelbl)
        Me.Controls.Add(Me.Booknolbl)
        Me.Controls.Add(Me.Tstatus)
        Me.Controls.Add(Me.booknametxt)
        Me.Controls.Add(Me.booknotxt)
        Me.Name = "borrow"
        Me.Text = "Borrow"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Notice As System.Windows.Forms.Label
    Friend WithEvents issuelbl As System.Windows.Forms.Label
    Friend WithEvents Booknolbl As System.Windows.Forms.Label
    Friend WithEvents booknotxt As System.Windows.Forms.TextBox
    Friend WithEvents booknametxt As System.Windows.Forms.TextBox
    Friend WithEvents booknamelbl As System.Windows.Forms.Label
    Friend WithEvents datepicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
