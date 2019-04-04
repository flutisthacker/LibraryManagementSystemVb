
Imports System.IO
Imports System.Data.SqlClient
Imports BookManagementSystem.DataSet1TableAdapters

Public Class issue
    Dim ad As New Book_detailsTableAdapter()
    Dim datee As DateTime
    Dim con As New SqlConnection("Data Source=(LocalDB)\V11.0; Integrated Security= True; Database=bookdb")

    Sub loadgrid()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\V11.0; Integrated Security= True; Database=bookdb")
            Dim cmd As New SqlCommand("select * from book_details ", con)
            Dim da As New SqlDataAdapter(cmd)  'mediator cmd-da-dt
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            'DataGridView1.DataSource = ad.GetData()
            'Book_detailsTableAdapter()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadgrid()

        '  
    End Sub

    Sub fieldclear()
        tbname.Clear()
        tath.Clear()
        Tpub.Clear()
        tisbn.Clear()
        tcopy.Clear()
        tprice.Clear()
        tstatus.Clear()

        cbcat.SelectedItem = -1

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Edit
        datee = dtpd.Value

        Dim cmd As New SqlCommand("update Book_details set Book_name=@bookname,author=@author,category=@category,publication=@pub,published_date=@pdate,isbn=@isbn,status=@status,copy=@copy,price=@price where id=@id", con)
        cmd.Parameters.AddWithValue("@bookname", tbname.Text)
        cmd.Parameters.AddWithValue("@author", tath.Text)
        cmd.Parameters.AddWithValue("@category", cbcat.SelectedItem)
        cmd.Parameters.AddWithValue("@pub", Tpub.Text)
        cmd.Parameters.AddWithValue("@pdate", datee)
        cmd.Parameters.AddWithValue("@isbn", Int(tisbn.Text))
        cmd.Parameters.AddWithValue("@status", tstatus.Text)
        cmd.Parameters.AddWithValue("@copy", Int(tcopy.Text))
        cmd.Parameters.AddWithValue("@price", Int(tprice.Text))
        cmd.Parameters.AddWithValue("@id", DataGridView1.CurrentCell.Value)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("book saved")
        fieldclear()
        loadgrid()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        tbname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        tath.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        cbcat.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        Tpub.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        ' datee.Value = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        tisbn.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        tstatus.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        tcopy.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        tprice.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim cmd As New SqlCommand("delete from Book_details where id=@id", con)
        cmd.Parameters.AddWithValue("@id", DataGridView1.CurrentCell.Value)
        con.Open()

        cmd.ExecuteNonQuery()
        '  Catch ex As Exception
        con.Close()
        MessageBox.Show("user deleted")
        loadgrid()

    End Sub
End Class
