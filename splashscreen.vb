Public Class splashscreen
    Dim frm As New firstLook
    Private Declare Function record Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Dim intro As String = "C:\Users\Saman\Documents\Visual Studio 2013\Projects\BookManagementSystem\BookManagementSystem\bin\Debug\booksplash.mp3"

    Private Sub ProgressTimer_Tick(sender As Object, e As EventArgs) Handles ProgressTimer.Tick
        ProgressBar1.Enabled = True
        ProgressBar1.Increment(1)
        If (ProgressBar1.Value = 10) Then
            My.Computer.Audio.Play(intro, AudioPlayMode.Background)
            ProgressLabel.Enabled = True
            Me.Opacity = 95
            ProgressLabel.Text = "Initializing Project"
        ElseIf (ProgressBar1.Value = 20) Then
            Me.Opacity = 90
            video.Show()
            video.URL = "C:\Users\Saman\Documents\Visual Studio 2013\Projects\BookManagementSystem\BookManagementSystem\My Project\neo_1.avi"
            ProgressLabel.Text = "Loading the Database 20"
        ElseIf (ProgressBar1.Value = 30) Then
            Me.Opacity = 85
            ProgressLabel.Text = "Loading the Database 40"

        ElseIf (ProgressBar1.Value = 40) Then
            Me.Opacity = 80
            ProgressLabel.Text = "Loading the Database 60"
        ElseIf (ProgressBar1.Value = 50) Then
            Me.Opacity = 75

            ProgressLabel.Text = "Loading the Database 80"
        ElseIf (ProgressBar1.Value = 60) Then
            Me.Opacity = 70
            ProgressLabel.Text = "Database Loaded"

        ElseIf (ProgressBar1.Value = 70) Then
            Me.Opacity = 65
            ProgressLabel.Text = "Loading the images"
        ElseIf (ProgressBar1.Value = 80) Then
            Me.Opacity = 60
            ProgressLabel.Text = "Loading the audio"
        ElseIf (ProgressBar1.Value = 90) Then
            Me.Opacity = 55
            ProgressLabel.Text = "Loading the Data"
        ElseIf (ProgressBar1.Value = 100) Then
            ProgressLabel.Text = "Project Initialization 100%"
            Me.Opacity = 50
            video.Hide()
            ProgressBar1.Enabled = False
            ProgressBar1.Visible = False
            ProgressTimer.Dispose()
            frm.Show()
            Me.Hide()

        End If


    End Sub
    Private Sub splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class