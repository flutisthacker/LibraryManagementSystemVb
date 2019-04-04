Imports System.Data.SqlClient

Public Class Bookdetail

    Private Sub Bookdetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\V11.0; Integrated Security= True; Database=bookdb")
            Dim cmd As New SqlCommand("select * from Book_details ", con)
            Dim da As New SqlDataAdapter(cmd)  'mediator cmd-da-dt
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try

    End Sub
End Class