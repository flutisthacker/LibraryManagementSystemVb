Imports System.Data.SqlClient

Public Class purchase
    Dim con As New SqlConnection("Data Source=(LocalDB)\V11.0; Integrated Security= True; Database=bookdb")

  
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim selcmd As New SqlCommand("select Book_name,copy,isbn from book_details where isbn=@isbn ", con)
        Dim incmd As New SqlCommand("insert into customer values(@name , @paid, @book,@email,@copy) ", con)

        'selcmd.Parameters.AddWithValue("@isbn", tisbn.Text)
        'cmd.Parameters.AddWithValue("@password", txtpass.Text)
        '.Parameters.AddWithValue("@usertype", cbusertype.SelectedItem)
        ' 'cmd.Parameters.AddWithValue("@email", txtemail.Text)
        '' cmd.Parameters.AddWithValue("@phone", txtphn.Text)
        ' cmd.Parameters.AddWithValue("@gender", cbgender.SelectedItem)
        'Try
        'con.Open()
        '        selcmd.ExecuteNonQuery()
        '  Catch ex As Exception
        'con.Close()
        'MessageBox.Show("user saved")
        Inserteds()

    End Sub

    Sub Inserteds()
        Dim cmd As New SqlCommand("insert into Stock values(@bookname ,@isbn,@s_id,@qnty,@prices) ", con)
        cmd.Parameters.AddWithValue("@bookname", b_name.Text)
        cmd.Parameters.AddWithValue("@isbn", Int(isbn.Text))
        cmd.Parameters.AddWithValue("@s_id", Int(s_id.Text))
        cmd.Parameters.AddWithValue("@qnty", Int(qnty.Text))
        cmd.Parameters.AddWithValue("@prices", Int(prices.Text))
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("book saved")
        fieldclear()


    End Sub

    Sub fieldclear()
        b_name.Clear()
        isbn.Clear()
        s_id.Clear()
        qnty.Clear()
        prices.Clear()

    End Sub
End Class