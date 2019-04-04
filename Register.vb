Imports System.Data.SqlClient
Public Class Register


    Dim con As New SqlConnection("Data Source=(LocalDB)\V11.0; Integrated Security= True; Database= bookdb")

 
    Sub fieldclear()
        txtname.Clear()
        txtcfm.Clear()
        txtemail.Clear()
        txtpass.Clear()
        txtphn.Clear()
        cbgender.SelectedIndex = -1
        cbusertype.SelectedIndex = -1

    End Sub

    Private Sub sign_Click(sender As Object, e As EventArgs) Handles sign.Click
        con.Open()
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
        'Try
        cmd.ExecuteNonQuery()
        '  Catch ex As Exception
        con.Close()
        MessageBox.Show("user saved")
        fieldclear()



    End Sub
End Class