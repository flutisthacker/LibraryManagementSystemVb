Imports System.Net.Mime.MediaTypeNames

Public Class Form1
    Dim path As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'http://go.microsoft.com/fwlink/?LinkId=95772
        'Process.Start()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim Filed As New OpenFileDialog
        Filed.ShowDialog()
        path = Filed.FileName
        AxWindowsMediaPlayer1.URL = path
        MessageBox.Show(path)

    End Sub
End Class
