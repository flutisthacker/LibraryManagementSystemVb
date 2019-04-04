Imports System.IO
Imports System.Data.SqlClient
Public Class Edituser
    Dim con As New SqlConnection("Data Source=(LocalDB)\V11.0; Integrated Security= True; Database=bookdb")
    Sub loadgrid()
        Dim dt As New DataTable()

        Dim cmda As New SqlCommand("select * from users ", con)
        Dim sda As New SqlDataAdapter(cmda)  'mediator cmd-da-dt

        Try

            sda.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Edituser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadgrid()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtpass.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        cbusertype.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtemail.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtphn.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        cbgender.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim cmd As New SqlCommand("update users set username=@username,password=@password, usertype=@usertype,Email=@email,Phone=@phone,Gender=@gender where userid=@userid ", con)
        cmd.Parameters.AddWithValue("@username", txtname.Text)
        cmd.Parameters.AddWithValue("@password", txtpass.Text)
        cmd.Parameters.AddWithValue("@usertype", cbusertype.SelectedItem)
        cmd.Parameters.AddWithValue("@email", txtemail.Text)
        cmd.Parameters.AddWithValue("@phone", txtphn.Text)
        cmd.Parameters.AddWithValue("@gender", cbgender.SelectedItem)
        cmd.Parameters.AddWithValue("@userid", DataGridView1.CurrentCell.Value)

        'Try
        con.Open()

        cmd.ExecuteNonQuery()
        '  Catch ex As Exception
        con.Close()
        MessageBox.Show("user saved")

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        loadgrid()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim cmd As New SqlCommand("delete from users where userid=@userid", con)
        cmd.Parameters.AddWithValue("@userid", DataGridView1.CurrentCell.Value)
        con.Open()

        cmd.ExecuteNonQuery()
        '  Catch ex As Exception
        con.Close()
        MessageBox.Show("user deleted")

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        OpenFileDialog1.ShowDialog()
        PictureBox4.ImageLocation = OpenFileDialog1.FileName
        'PictureBox4.SizeMode(AutoSize)

    End Sub
End Class