Public Class welcome
    Private Declare Function record Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Dim sounderror As String = "C:\Users\Saman\Documents\Visual Studio 2013\Projects\BookManagementSystem\BookManagementSystem\My Project\welcome.mp3"

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\Users\Saman\Documents\Visual Studio 2013\Projects\BookManagementSystem\BookManagementSystem\My Project\welcome.mp3", AudioPlayMode.Background)
        'My.Computer.Audio.Play(BookManagementSystem.My.Resources.welcome.mp3, AudioPlayMode.Background)
        'Form1.loginpb.Image = bloodonation.My.Resources.Resources.icons8_User_32
        Label1.Visible = True
        Label1.Text = " |Oceans OF the Knowledge| "

    End Sub

    Private Sub welcome_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.Close()

    End Sub
End Class