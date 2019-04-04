<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashscreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splashscreen))
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressLabel = New System.Windows.Forms.Label()
        Me.video = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.video, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.logo.ErrorImage = CType(resources.GetObject("logo.ErrorImage"), System.Drawing.Image)
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(0, 72)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(630, 403)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 18
        Me.logo.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(1, 472)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(630, 23)
        Me.ProgressBar1.TabIndex = 19
        '
        'ProgressTimer
        '
        Me.ProgressTimer.Enabled = True
        '
        'ProgressLabel
        '
        Me.ProgressLabel.AutoSize = True
        Me.ProgressLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProgressLabel.ForeColor = System.Drawing.Color.White
        Me.ProgressLabel.Location = New System.Drawing.Point(289, 478)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(39, 13)
        Me.ProgressLabel.TabIndex = 20
        Me.ProgressLabel.Text = "Label1"
        '
        'video
        '
        Me.video.Enabled = True
        Me.video.Location = New System.Drawing.Point(0, 63)
        Me.video.Name = "video"
        Me.video.OcxState = CType(resources.GetObject("video.OcxState"), System.Windows.Forms.AxHost.State)
        Me.video.Size = New System.Drawing.Size(630, 477)
        Me.video.TabIndex = 21
        Me.video.Visible = False
        '
        'splashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 498)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.video)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.ProgressLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "splashscreen"
        Me.Text = "Book Management System"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.video, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressTimer As System.Windows.Forms.Timer
    Friend WithEvents ProgressLabel As System.Windows.Forms.Label
    Friend WithEvents video As AxWMPLib.AxWindowsMediaPlayer
End Class
