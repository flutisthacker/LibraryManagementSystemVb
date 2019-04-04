
Imports System.IO
Imports System.Data.SqlClient


Public Class firstLook
    Private Declare Function record Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Dim sounderror As String = "C:\Users\Saman\Documents\Visual Studio 2013\Projects\BookManagementSystem\BookManagementSystem\My Project\error.mp3"
    Dim sounderrora As String = "C:\Users\Saman\Documents\Visual Studio 2013\Projects\BookManagementSystem\BookManagementSystem\My Project\errora.mp3"
    Dim con As New SqlConnection("Data Source=(LocalDB)\V11.0; Integrated Security= True; Database= bookdb")
    Dim signb As Boolean = False
    Dim logb As Boolean = False
    Dim recb As Boolean = False

    Dim mf As New MainForm
    Private Sub firstLook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mf.Show()
        mf.Enabled = False
        mf.Opacity = 50%

        con.Open()
    End Sub



    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        con.Close()
        End

        'Application.Exit()


    End Sub

    Private Sub logo_Click(sender As Object, e As EventArgs)
        Dim rnd As New Random
        ' onandoff.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'login
        If logb = False Then
            loggb.Visible = True
            logb = True
        Else
            loggb.Visible = False
            logb = False
        End If


        ' Panel3.Visible = False
        'Panel4.Visible = False
        '   logingb.Visible = True
        '  signgb.Visible = False
        ' Recovergb.Visible = False


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        '   Hidelogo(150, 150)
        MessageBox.Show("We are deveploping the feature")
        If recb = False Then
            reccb.Visible = True
            recb = True
        Else
            reccb.Visible = False
            recb = False
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        If Reggb.Visible = False Then
            'logb
            Reggb.Visible = True
            signb = True
        Else
            Reggb.Visible = False
            signb = False
        End If

        'Hidelogo(150, 150
        'Panel3.Visible = False
        'Panel2.Visible = False

        '  signgb.Visible = True
        ' logingb.Visible = False
        'Recovergb.Visible = False

    End Sub

    Private Sub GroupBox1_Click(sender As Object, e As EventArgs)
        '   GroupBox1.Size = New System.Drawing.Size(760, 308)
        '     BackColor = Color.FromArgb(128, 0, 0, 0)

    End Sub


    Private Sub showColorValueLabels()
        '    Label1.Text = "Red value is : " & TrackBar1.Value.ToString()
        '   Label2.Text = "green value is : " & TrackBar2.Value.ToString()
        '   Label3.Text = "blue value is : " & TrackBar3.Value.ToString()
    End Sub



    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Dim rnd As New Random
        BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))

    End Sub
    Sub fieldclear()
        txtname.Clear()
        txtcfm.Clear()
        txtemail.Clear()
        txtpass.Clear()
        txtphn.Clear()
        cbgender.SelectedItem = -1
        cbusertype.SelectedItem = -1

    End Sub
    Private Sub sign_Click(sender As Object, e As EventArgs) Handles sign.Click
        Dim cmd As New SqlCommand("insert into users values(@username , @password, @usertype,@email,@phone,@gender) ", con)
        If (txtpass.Text = txtcfm.Text) Then
            lerror.Visible = False
        Else
            lerror.Visible = True
        End If
        cmd.Parameters.AddWithValue("@username", txtname.Text)
        cmd.Parameters.AddWithValue("@password", txtpass.Text)
        cmd.Parameters.AddWithValue("@usertype", cbusertype.SelectedItem)
        cmd.Parameters.AddWithValue("@email", txtemail.Text)
        cmd.Parameters.AddWithValue("@phone", txtphn.Text)
        cmd.Parameters.AddWithValue("@gender", cbgender.SelectedItem)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("user saved")
            fieldclear()

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles logdbb.Click
        'login
        ' Dim SelectQ As String = "select username,password,usertype from users where username=" + txtname.Text + " And userpass=" + txtpass.Text + "  "
        Dim SelectQ As String = "select username,password,usertype from users where username=@username And password=@password  AND usertype=@usertype"
        Dim cmd As New SqlCommand(SelectQ, con)
       
        If logdbn.Text = "" Then
            logdbn.Select()
            MessageBox.Show("UserName empty")
            My.Computer.Audio.Play("C:\Users\Saman\Documents\Visual Studio 2013\Projects\BookManagementSystem\BookManagementSystem\My Project\errora.mp3", AudioPlayMode.Background)

        ElseIf logdbp.Text = "" Then
            logdbp.Select()
            MessageBox.Show("Password empty")
            My.Computer.Audio.Play("C:\Users\Saman\Documents\Visual Studio 2013\Projects\BookManagementSystem\BookManagementSystem\My Project\error.mp3", AudioPlayMode.Background)

        Else
            Try
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = logdbn.Text
                cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = logdbp.Text
                cmd.Parameters.AddWithValue("@usertype", SqlDbType.VarChar).Value = logdbut.SelectedItem
                Dim ad As New SqlDataAdapter(cmd)
                Dim tb As New DataTable
                ad.Fill(tb)
                If tb.Rows.Count <= 0 Then
                    MessageBox.Show("invalid UserName /Password")

                Else
                    My.Computer.Audio.Play("C:\Users\Saman\Documents\Visual Studio 2013\Projects\BookManagementSystem\BookManagementSystem\My Project\loggedin.mp3", AudioPlayMode.Background)
                    Me.Hide()
                    mf.BringToFront()
                    mf.Enabled = True
                    mf.Opacity = 100%
                    mf.ToolStripStatusLabel1.Text = logdbn.Text
                    mf.Userwho.Text = logdbn.Text
                    photovisible(logdbn.Text)

                End If
                cmd.ExecuteNonQuery()
                con.Close()
               
                
            Catch ex As Exception
                'MessageBox.Show("user saved " & cmd.CommandText)
                ' If (txtname.ToString = "admin") Then 'And txtpass.ToString = "admin"
                'MessageBox.Show("You are logged in")
                'onandoff.Hide()


            End Try

        End If
    End Sub
    Sub photovisible(ByVal sad)
        mf.photo.Visible = True
        Dim fp As String = "C:\Users\Saman\Documents\Visual Studio 2013\Projects\BookManagementSystem\BookManagementSystem\Resources\"
Select sad
            Case "saman"
                mf.photo.ImageLocation = fp + "saman.jpg"
            Case "sanjiv"
                mf.photo.ImageLocation = fp + "sanjiv.jpg"
            Case "sohel"
                mf.photo.ImageLocation = fp + "sohel.jpg"
            Case "ragim"
                mf.photo.ImageLocation = fp + "ragim.jpg"

        End Select
    End Sub


    'Else
    'My.Computer.Audio.Play("C:\Users\Saman\Documents\Visual Studio 2013\Projects\BookManagementSystem\BookManagementSystem\My Project\error.mp3", AudioPlayMode.Background)

    'MessageBox.Show("what the hell")
    '    End If


    

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            told.PasswordChar = ""
            tnew.PasswordChar = ""
            Tcfn.PasswordChar = ""
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
