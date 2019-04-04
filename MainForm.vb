
Imports System.IO
Imports System.Data.SqlClient
Imports BookManagementSystem.DataSet2TableAdapters
Imports System.Threading

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ToolStripButton10.ComboBox.
        Me.ForeColor = Color.Black
        welcome.MdiParent = Me
        PictureBox3.Visible = False
        welcome.Show()

    End Sub


    Private Sub tsbexit_Click(sender As Object, e As EventArgs) Handles tsbexit.Click
        Application.Exit()
        '  Con.close()
    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs)

    End Sub



    Private Sub FontDropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FontDropDownList1.SelectedIndexChanged
        'Dim sd As String
        'sd = (FontDropDownList1.SelectedItem)

    End Sub


    Private Sub IssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueToolStripMenuItem.Click
        issue.MdiParent = Me
        issue.Show()

    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        Price.MdiParent = Me
        Price.Show()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click
        purchase.MdiParent = Me
        purchase.Show()
    End Sub

    Private Sub BorrowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowToolStripMenuItem.Click
        borrow.MdiParent = Me
        borrow.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click

    End Sub

    Private Sub NoteItToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoteItToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe")
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
        future.MdiParent = Me
        future.Show()
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
        future.MdiParent = Me
        future.Show()
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
        future.MdiParent = Me
        future.Show()
    End Sub
    Dim Astatus As Boolean = False



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick, ToolStripStatusLabel4.Click
        ToolStripStatusLabel4.Text = " Time= " & Date.Now.ToLongTimeString
        TimeToolStripMenuItem.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        firstLook.Show()
        photo.Visible = False

    End Sub



    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        'username
        UserDatagrid.MdiParent = Me
        UserDatagrid.Show()
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Dim fnt As New ColorDialog
        fnt.ShowDialog()
        Me.BackColor = fnt.Color
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim fnt As New FontDialog
        fnt.ShowDialog()
        Me.Font = fnt.Font


    End Sub


    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub UserGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserGridToolStripMenuItem.Click
        UserDatagrid.MdiParent = Me
        UserDatagrid.Show()
    End Sub

    Private Sub EditUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUsersToolStripMenuItem.Click
        Edituser.MdiParent = Me
        Edituser.Show()
    End Sub

    Private Sub AboutProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutProjectToolStripMenuItem.Click
        'about
        AboutBox1.MdiParent = Me
        AboutBox1.Show()


    End Sub


    Private Sub RequirementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequirementsToolStripMenuItem.Click
        Requirements.MdiParent = Me
        Requirements.Show()

    End Sub

    Private Sub AddBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBookToolStripMenuItem.Click
        AddBook.MdiParent = Me
        AddBook.Show()
    End Sub

    Private Sub BookDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookDetailsToolStripMenuItem.Click
        Bookdetail.MdiParent = Me
        Bookdetail.Show()

        ' My.Forms.Bookdetail.Show() we can also do this

    End Sub

    Private Sub AddUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUsersToolStripMenuItem.Click
        Register.MdiParent = Me
        Register.Show()

    End Sub

    Private Sub DevelopersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevelopersToolStripMenuItem.Click

        'Dim childAbout As New About
        'childAbout.MdiParent = Me
        'childAbout.Show()
        '       About.MdiParent = Me
        About.Show()
    End Sub

    Private Sub SecretToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecretToolStripMenuItem.Click
        'Dim video As New
    End Sub




    Private Sub StatusStrip1_MouseHover(sender As Object, e As EventArgs) Handles StatusStrip1.MouseHover, StatusStrip1.MouseEnter
        StatusStrip1.Visible = True
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        future.MdiParent = Me
        future.Show()
    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub

    Private Sub FROMDBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FROMDBToolStripMenuItem.Click

        fromdb = Nothing
        dbooklist.MdiParent = Me
        dbooklist.Show()

    End Sub
    Dim con As New SqlConnection("Data Source=(LocalDB)\V11.0; Integrated Security= True; Database= bookdb")

    Private Sub CloseBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseBookToolStripMenuItem.Click
        '        AxAcroPDF1.Visible = False
        closebook()

    End Sub


    Dim ad As New dbookTableAdapter
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'OpenFileDialog1.Filter = "All text Files (*.pdf)| *.pdf)"
        'If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK() Then
        OpenFileDialog1.ShowDialog()
        'If(OpenFileDialog1.)
        open(OpenFileDialog1.FileName)
       
        'tobookdb()

        'take it to db 
        'End If
    End Sub
    Public fromdb As String = Nothing
    Public bookstate As Boolean = False


    Sub tobookdb()
        Dim SelectQ As String = "select name from dbook where name=@aname "
        Dim cmd As New SqlCommand(SelectQ, con)

        Try
            cmd.Parameters.Add("@aname", SqlDbType.VarChar).Value = OpenFileDialog1.FileName
            Dim ad As New SqlDataAdapter(cmd)
            Dim add As New dbookTableAdapter

            Dim tb As New DataTable
            ad.Fill(tb)
            If tb.Rows.Count <= 0 Then
                MessageBox.Show("invalid UserName /Password")
                Dim i As Integer = add.InsertQuery(OpenFileDialog1.FileName)
                If i > 0 Then
                    MessageBox.Show("done")
                End If

            Else
                MessageBox.Show("its on you db")


            End If
            cmd.ExecuteNonQuery()
            con.Close()
        Catch theexception As Exception
        End Try

    End Sub


    Sub closebook()
        If bookstate = True Then
            'AxAcroPDF1.Dispose()
            AxAcroPDF1.LoadFile(Nothing)
            AxAcroPDF1.Visible = False
            bookstate = False
            ToolStripLabel1.Text = ""

        End If
    End Sub

    Public Sub open(ByVal name As String)
        If bookstate = False Then

            AxAcroPDF1.Visible = True
            AxAcroPDF1.LoadFile(name)
            ToolStripLabel1.Text = "OPENED"
            bookstate = True
        End If

    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs) Handles ToolStripComboBox1.Click
        'dock
        If ToolStrip1.Dock = DockStyle.Top Then
            ToolStrip1.Dock = DockStyle.Bottom
        Else
            ToolStrip1.Dock = DockStyle.Top
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles photo.Click
        'beside logo
        background.MdiParent = Me
        background.Show()
        background.PictureBox1.ImageLocation = photo.ImageLocation()

    End Sub

    Private Sub AxAcroPDF1_Enter(sender As Object, e As EventArgs) Handles AxAcroPDF1.Enter

    End Sub

    Private Sub Userwho_Click(sender As Object, e As EventArgs) Handles Userwho.Click
        'authorization
        background.MdiParent = Me
        background.Show()
        background.PictureBox1.ImageLocation = photo.ImageLocation()

    End Sub

    Private Sub FuturePlanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuturePlanToolStripMenuItem.Click
        background.MdiParent = Me
        background.Show()
        background.PictureBox1.ImageLocation = photo.ImageLocation()
        background.Size.Height.Equals(984)
        background.Size.Width.Equals(613)

    End Sub
End Class