<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.signgb = New System.Windows.Forms.GroupBox()
        Me.lerror = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbgender = New System.Windows.Forms.ComboBox()
        Me.txtphn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.Label()
        Me.sign = New System.Windows.Forms.Button()
        Me.cbusertype = New System.Windows.Forms.ComboBox()
        Me.txtcfm = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.signgb.SuspendLayout()
        Me.SuspendLayout()
        '
        'signgb
        '
        Me.signgb.BackColor = System.Drawing.Color.Black
        Me.signgb.Controls.Add(Me.lerror)
        Me.signgb.Controls.Add(Me.Label6)
        Me.signgb.Controls.Add(Me.cbgender)
        Me.signgb.Controls.Add(Me.txtphn)
        Me.signgb.Controls.Add(Me.Label5)
        Me.signgb.Controls.Add(Me.txtemail)
        Me.signgb.Controls.Add(Me.Email)
        Me.signgb.Controls.Add(Me.sign)
        Me.signgb.Controls.Add(Me.cbusertype)
        Me.signgb.Controls.Add(Me.txtcfm)
        Me.signgb.Controls.Add(Me.txtpass)
        Me.signgb.Controls.Add(Me.txtname)
        Me.signgb.Controls.Add(Me.Label8)
        Me.signgb.Controls.Add(Me.Label11)
        Me.signgb.Controls.Add(Me.Label9)
        Me.signgb.Controls.Add(Me.Label10)
        Me.signgb.Location = New System.Drawing.Point(13, 63)
        Me.signgb.Name = "signgb"
        Me.signgb.Size = New System.Drawing.Size(260, 370)
        Me.signgb.TabIndex = 36
        Me.signgb.TabStop = False
        '
        'lerror
        '
        Me.lerror.AutoSize = True
        Me.lerror.ForeColor = System.Drawing.Color.Red
        Me.lerror.Location = New System.Drawing.Point(140, 96)
        Me.lerror.Name = "lerror"
        Me.lerror.Size = New System.Drawing.Size(82, 13)
        Me.lerror.TabIndex = 50
        Me.lerror.Text = "Does not match"
        Me.lerror.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(25, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Gender"
        '
        'cbgender
        '
        Me.cbgender.FormattingEnabled = True
        Me.cbgender.Items.AddRange(New Object() {"Male ", "Female", "Others"})
        Me.cbgender.Location = New System.Drawing.Point(122, 262)
        Me.cbgender.Name = "cbgender"
        Me.cbgender.Size = New System.Drawing.Size(100, 21)
        Me.cbgender.TabIndex = 48
        '
        'txtphn
        '
        Me.txtphn.Location = New System.Drawing.Point(122, 229)
        Me.txtphn.Name = "txtphn"
        Me.txtphn.Size = New System.Drawing.Size(100, 20)
        Me.txtphn.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Phone"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(122, 194)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 45
        Me.txtemail.Text = "@gmail.com"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.ForeColor = System.Drawing.Color.White
        Me.Email.Location = New System.Drawing.Point(25, 194)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(32, 13)
        Me.Email.TabIndex = 44
        Me.Email.Text = "Email"
        '
        'sign
        '
        Me.sign.Location = New System.Drawing.Point(122, 300)
        Me.sign.Name = "sign"
        Me.sign.Size = New System.Drawing.Size(75, 23)
        Me.sign.TabIndex = 28
        Me.sign.Text = "Signup"
        Me.sign.UseVisualStyleBackColor = True
        '
        'cbusertype
        '
        Me.cbusertype.FormattingEnabled = True
        Me.cbusertype.Items.AddRange(New Object() {"Admin", "Developers", "Users"})
        Me.cbusertype.Location = New System.Drawing.Point(122, 150)
        Me.cbusertype.Name = "cbusertype"
        Me.cbusertype.Size = New System.Drawing.Size(100, 21)
        Me.cbusertype.TabIndex = 27
        '
        'txtcfm
        '
        Me.txtcfm.Location = New System.Drawing.Point(122, 112)
        Me.txtcfm.Name = "txtcfm"
        Me.txtcfm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcfm.Size = New System.Drawing.Size(100, 20)
        Me.txtcfm.TabIndex = 25
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(122, 73)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(100, 20)
        Me.txtpass.TabIndex = 26
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(122, 27)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(25, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "User Tpye"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(25, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Confirm "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(25, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(25, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Name"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 468)
        Me.Controls.Add(Me.signgb)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.signgb.ResumeLayout(False)
        Me.signgb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents signgb As System.Windows.Forms.GroupBox
    Friend WithEvents sign As System.Windows.Forms.Button
    Friend WithEvents cbusertype As System.Windows.Forms.ComboBox
    Friend WithEvents txtcfm As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbgender As System.Windows.Forms.ComboBox
    Friend WithEvents txtphn As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Email As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lerror As System.Windows.Forms.Label
End Class
