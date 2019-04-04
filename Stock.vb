Imports System.Data.SqlClient

Public Class Price

    Dim con As New SqlConnection("Data Source=(LocalDB)\V11.0; Integrated Security= True; Database= bookdb")
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

   

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        '        Dim cmd As New SqlCommand("update Book_details set Book_name=@a,isbn=@b,published_date=@d,status=@e Where isbn=@b", con)
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