
Imports System.IO
Imports System.Data.SqlClient


Public Class borrow


    Dim con As New SqlConnection("Data Source=(LocalDB)\V11.0; Integrated Security= True; Database= bookdb")
    Private Sub borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Notice.Text = "Your Due Date Is One Week!!!"

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim d1 As DateTime = datepicker.Value
        Dim cmd As New SqlCommand("update Book_details set Book_name=@a,isbn=@b,published_date=@d,status=@e Where isbn=@b", con)
        cmd.Parameters.AddWithValue("@a", booknametxt.Text)
        cmd.Parameters.AddWithValue("@b", booknotxt.Text)
        cmd.Parameters.AddWithValue("@d", d1)
        cmd.Parameters.AddWithValue("@e", Tstatus.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
End Class