Imports System.IO
Imports System.Data.SqlClient

Public Class AddBook

    Dim con As New SqlConnection("Data Source=(LocalDB)\V11.0; Integrated Security= True; Database=bookdb")
   
    Private Sub AddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim qwe As String
        Dim d1 As DateTime = dtppdate.Value
        qwe = dtppdate.ToString()
        'MessageBox.Show(qwe)
        Dim cmd As New SqlCommand("insert into Book_details values(@bookname ,@author, @category, @publication, @pdate, @isbn,@status,@copy,@price) ", con)
        cmd.Parameters.AddWithValue("@bookname", tbname.Text)
        cmd.Parameters.AddWithValue("@author", tauthor.Text)
        cmd.Parameters.AddWithValue("@category", cbcat.SelectedItem)
        cmd.Parameters.AddWithValue("@publication", tpub.Text)
        cmd.Parameters.AddWithValue("@pdate", d1)
        cmd.Parameters.AddWithValue("@isbn", Int(tisbn.Text))
        cmd.Parameters.AddWithValue("@status", tstatus.Text)
        cmd.Parameters.AddWithValue("@copy", Int(tcbook.Text))
        cmd.Parameters.AddWithValue("@price", Int(tprice.Text))
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("book saved")
        fieldclear()

    End Sub

    Sub fieldclear()
        tbname.Clear()
        tauthor.Clear()
        cbcat.SelectedIndex = -1
        tisbn.Clear()
        tcbook.Clear()
        tstatus.Clear()
        tpub.Clear()
        tprice.Clear()

    End Sub

End Class