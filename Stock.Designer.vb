﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Price
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prices = New System.Windows.Forms.TextBox()
        Me.copieslbl = New System.Windows.Forms.Label()
        Me.qnty = New System.Windows.Forms.TextBox()
        Me.stdlbl = New System.Windows.Forms.Label()
        Me.booknamelbl = New System.Windows.Forms.Label()
        Me.Booknolbl = New System.Windows.Forms.Label()
        Me.s_id = New System.Windows.Forms.TextBox()
        Me.b_name = New System.Windows.Forms.TextBox()
        Me.isbn = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 217)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Price"
        '
        'prices
        '
        Me.prices.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.prices.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prices.Location = New System.Drawing.Point(128, 210)
        Me.prices.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.prices.Name = "prices"
        Me.prices.Size = New System.Drawing.Size(182, 21)
        Me.prices.TabIndex = 36
        '
        'copieslbl
        '
        Me.copieslbl.AutoSize = True
        Me.copieslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copieslbl.ForeColor = System.Drawing.Color.White
        Me.copieslbl.Location = New System.Drawing.Point(3, 183)
        Me.copieslbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.copieslbl.Name = "copieslbl"
        Me.copieslbl.Size = New System.Drawing.Size(59, 15)
        Me.copieslbl.TabIndex = 35
        Me.copieslbl.Text = "Quantity"
        '
        'qnty
        '
        Me.qnty.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.qnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qnty.Location = New System.Drawing.Point(126, 176)
        Me.qnty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.qnty.Name = "qnty"
        Me.qnty.Size = New System.Drawing.Size(182, 21)
        Me.qnty.TabIndex = 34
        '
        'stdlbl
        '
        Me.stdlbl.AutoSize = True
        Me.stdlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdlbl.ForeColor = System.Drawing.Color.White
        Me.stdlbl.Location = New System.Drawing.Point(5, 153)
        Me.stdlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.stdlbl.Name = "stdlbl"
        Me.stdlbl.Size = New System.Drawing.Size(78, 15)
        Me.stdlbl.TabIndex = 31
        Me.stdlbl.Text = "Student ID."
        '
        'booknamelbl
        '
        Me.booknamelbl.AutoSize = True
        Me.booknamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booknamelbl.ForeColor = System.Drawing.Color.White
        Me.booknamelbl.Location = New System.Drawing.Point(5, 89)
        Me.booknamelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.booknamelbl.Name = "booknamelbl"
        Me.booknamelbl.Size = New System.Drawing.Size(85, 15)
        Me.booknamelbl.TabIndex = 32
        Me.booknamelbl.Text = "Book Name."
        '
        'Booknolbl
        '
        Me.Booknolbl.AutoSize = True
        Me.Booknolbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Booknolbl.ForeColor = System.Drawing.Color.White
        Me.Booknolbl.Location = New System.Drawing.Point(5, 119)
        Me.Booknolbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Booknolbl.Name = "Booknolbl"
        Me.Booknolbl.Size = New System.Drawing.Size(63, 15)
        Me.Booknolbl.TabIndex = 33
        Me.Booknolbl.Text = "ISBN no."
        '
        's_id
        '
        Me.s_id.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.s_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_id.Location = New System.Drawing.Point(128, 150)
        Me.s_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.s_id.Multiline = True
        Me.s_id.Name = "s_id"
        Me.s_id.Size = New System.Drawing.Size(182, 20)
        Me.s_id.TabIndex = 28
        '
        'b_name
        '
        Me.b_name.AcceptsReturn = True
        Me.b_name.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.b_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_name.Location = New System.Drawing.Point(126, 86)
        Me.b_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.b_name.Multiline = True
        Me.b_name.Name = "b_name"
        Me.b_name.Size = New System.Drawing.Size(184, 20)
        Me.b_name.TabIndex = 29
        '
        'isbn
        '
        Me.isbn.AcceptsReturn = True
        Me.isbn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.isbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbn.Location = New System.Drawing.Point(126, 116)
        Me.isbn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.isbn.Multiline = True
        Me.isbn.Name = "isbn"
        Me.isbn.Size = New System.Drawing.Size(184, 20)
        Me.isbn.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_business_32
        Me.PictureBox1.Location = New System.Drawing.Point(209, 240)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Price
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 315)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prices)
        Me.Controls.Add(Me.copieslbl)
        Me.Controls.Add(Me.qnty)
        Me.Controls.Add(Me.stdlbl)
        Me.Controls.Add(Me.booknamelbl)
        Me.Controls.Add(Me.Booknolbl)
        Me.Controls.Add(Me.s_id)
        Me.Controls.Add(Me.b_name)
        Me.Controls.Add(Me.isbn)
        Me.Name = "Price"
        Me.Text = "Stock"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prices As System.Windows.Forms.TextBox
    Friend WithEvents copieslbl As System.Windows.Forms.Label
    Friend WithEvents qnty As System.Windows.Forms.TextBox
    Friend WithEvents stdlbl As System.Windows.Forms.Label
    Friend WithEvents booknamelbl As System.Windows.Forms.Label
    Friend WithEvents Booknolbl As System.Windows.Forms.Label
    Friend WithEvents s_id As System.Windows.Forms.TextBox
    Friend WithEvents b_name As System.Windows.Forms.TextBox
    Friend WithEvents isbn As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
