Imports BookManagementSystem.DataSet2TableAdapters

Public Class dbooklist
    Dim ad As New dbookTableAdapter
    Public dbfile As String

    Private Sub dbooklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = ad.GetData

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        dbfile = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        MainForm.fromdb = dbfile
        MainForm.open(dbfile)
        Me.Close()
    End Sub
   
End Class