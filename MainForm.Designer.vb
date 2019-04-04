<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    ' Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NoteItToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecretToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.FROMDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AddUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Userwho = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbook = New System.Windows.Forms.ToolStripDropDownButton()
        Me.IssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AboutProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequirementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevelopersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuturePlanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripButton()
        Me.FontDropDownList1 = New ActiproSoftware.SyntaxEditor.FontDropDownList()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(20, 730)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "hello"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(65, 17)
        Me.ToolStripStatusLabel1.Text = "User Name"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton1, Me.ToolStripButton5, Me.tsbook, Me.ToolStripButton8, Me.ToolStripButton7, Me.tsbexit, Me.ToolStripLabel1, Me.ToolStripComboBox1})
        Me.ToolStrip1.Location = New System.Drawing.Point(20, 60)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 57)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.White
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoteItToolStripMenuItem, Me.ColorToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton2.Image = Global.BookManagementSystem.My.Resources.Resources.File_png_32
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(68, 54)
        Me.ToolStripButton2.Text = "file"
        '
        'NoteItToolStripMenuItem
        '
        Me.NoteItToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SecretToolStripMenuItem})
        Me.NoteItToolStripMenuItem.Name = "NoteItToolStripMenuItem"
        Me.NoteItToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.NoteItToolStripMenuItem.Text = "Note it"
        '
        'SecretToolStripMenuItem
        '
        Me.SecretToolStripMenuItem.Name = "SecretToolStripMenuItem"
        Me.SecretToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.SecretToolStripMenuItem.Text = "secret"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FROMDBToolStripMenuItem, Me.CloseBookToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_open_filled_50
        Me.ToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(99, 54)
        Me.ToolStripButton1.Text = "OPen"
        '
        'FROMDBToolStripMenuItem
        '
        Me.FROMDBToolStripMenuItem.Name = "FROMDBToolStripMenuItem"
        Me.FROMDBToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.FROMDBToolStripMenuItem.Text = "FROM DB"
        '
        'CloseBookToolStripMenuItem
        '
        Me.CloseBookToolStripMenuItem.Name = "CloseBookToolStripMenuItem"
        Me.CloseBookToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.CloseBookToolStripMenuItem.Text = "close book"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItem1.Text = "open"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.BackColor = System.Drawing.Color.White
        Me.ToolStripButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUsersToolStripMenuItem, Me.EditUsersToolStripMenuItem, Me.UserGridToolStripMenuItem, Me.Userwho})
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton5.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_User_32
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(80, 54)
        Me.ToolStripButton5.Text = "Users"
        '
        'AddUsersToolStripMenuItem
        '
        Me.AddUsersToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_add_user_male_50
        Me.AddUsersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddUsersToolStripMenuItem.Name = "AddUsersToolStripMenuItem"
        Me.AddUsersToolStripMenuItem.Size = New System.Drawing.Size(180, 56)
        Me.AddUsersToolStripMenuItem.Text = "Add Users"
        '
        'EditUsersToolStripMenuItem
        '
        Me.EditUsersToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_User_32
        Me.EditUsersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditUsersToolStripMenuItem.Name = "EditUsersToolStripMenuItem"
        Me.EditUsersToolStripMenuItem.Size = New System.Drawing.Size(180, 56)
        Me.EditUsersToolStripMenuItem.Text = "Edit Users"
        '
        'UserGridToolStripMenuItem
        '
        Me.UserGridToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_grid_50
        Me.UserGridToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UserGridToolStripMenuItem.Name = "UserGridToolStripMenuItem"
        Me.UserGridToolStripMenuItem.Size = New System.Drawing.Size(180, 56)
        Me.UserGridToolStripMenuItem.Text = "UserGrid"
        '
        'Userwho
        '
        Me.Userwho.Name = "Userwho"
        Me.Userwho.Size = New System.Drawing.Size(180, 56)
        Me.Userwho.Text = "Authorization"
        '
        'tsbook
        '
        Me.tsbook.BackColor = System.Drawing.Color.White
        Me.tsbook.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IssueToolStripMenuItem, Me.PurchaseToolStripMenuItem, Me.StockToolStripMenuItem, Me.BorrowToolStripMenuItem, Me.BookDetailsToolStripMenuItem, Me.AddBookToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.tsbook.ForeColor = System.Drawing.Color.Black
        Me.tsbook.Image = Global.BookManagementSystem.My.Resources.Resources.book
        Me.tsbook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbook.Name = "tsbook"
        Me.tsbook.Size = New System.Drawing.Size(84, 54)
        Me.tsbook.Text = "Books"
        '
        'IssueToolStripMenuItem
        '
        Me.IssueToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_reading_filled_50
        Me.IssueToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IssueToolStripMenuItem.Name = "IssueToolStripMenuItem"
        Me.IssueToolStripMenuItem.Size = New System.Drawing.Size(173, 56)
        Me.IssueToolStripMenuItem.Text = "Edit"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_purchase_order_32
        Me.PurchaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(173, 56)
        Me.PurchaseToolStripMenuItem.Text = "Purchase"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_business_32
        Me.StockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(173, 56)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'BorrowToolStripMenuItem
        '
        Me.BorrowToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.Borrow_Book_32
        Me.BorrowToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem"
        Me.BorrowToolStripMenuItem.Size = New System.Drawing.Size(173, 56)
        Me.BorrowToolStripMenuItem.Text = "Borrow"
        '
        'BookDetailsToolStripMenuItem
        '
        Me.BookDetailsToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.More_Details_32
        Me.BookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BookDetailsToolStripMenuItem.Name = "BookDetailsToolStripMenuItem"
        Me.BookDetailsToolStripMenuItem.Size = New System.Drawing.Size(173, 56)
        Me.BookDetailsToolStripMenuItem.Text = "Book Details"
        '
        'AddBookToolStripMenuItem
        '
        Me.AddBookToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.book
        Me.AddBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem"
        Me.AddBookToolStripMenuItem.Size = New System.Drawing.Size(173, 56)
        Me.AddBookToolStripMenuItem.Text = "Add book"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_search_24
        Me.SearchToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(173, 56)
        Me.SearchToolStripMenuItem.Text = "search"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.BackColor = System.Drawing.Color.White
        Me.ToolStripButton8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.HorizontalToolStripMenuItem, Me.VerticalToolStripMenuItem})
        Me.ToolStripButton8.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton8.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_align_bottom_50
        Me.ToolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(114, 54)
        Me.ToolStripButton8.Text = "Cascade"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_align_bottom_50
        Me.CascadeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(161, 56)
        Me.CascadeToolStripMenuItem.Text = "Cascade"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_resize_horizontal_filled_50
        Me.HorizontalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(161, 56)
        Me.HorizontalToolStripMenuItem.Text = "horizontal"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.Vertical_32
        Me.VerticalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(161, 56)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.BackColor = System.Drawing.Color.White
        Me.ToolStripButton7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutProjectToolStripMenuItem, Me.RequirementsToolStripMenuItem, Me.DevelopersToolStripMenuItem, Me.TimeToolStripMenuItem, Me.FuturePlanToolStripMenuItem})
        Me.ToolStripButton7.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton7.Image = Global.BookManagementSystem.My.Resources.Resources.About_32
        Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(83, 54)
        Me.ToolStripButton7.Text = "about"
        '
        'AboutProjectToolStripMenuItem
        '
        Me.AboutProjectToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.About_32
        Me.AboutProjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutProjectToolStripMenuItem.Name = "AboutProjectToolStripMenuItem"
        Me.AboutProjectToolStripMenuItem.Size = New System.Drawing.Size(186, 56)
        Me.AboutProjectToolStripMenuItem.Text = "About project"
        '
        'RequirementsToolStripMenuItem
        '
        Me.RequirementsToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_view_details_50
        Me.RequirementsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RequirementsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RequirementsToolStripMenuItem.Name = "RequirementsToolStripMenuItem"
        Me.RequirementsToolStripMenuItem.Size = New System.Drawing.Size(186, 56)
        Me.RequirementsToolStripMenuItem.Text = "Requirements"
        '
        'DevelopersToolStripMenuItem
        '
        Me.DevelopersToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.More_Details_32
        Me.DevelopersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DevelopersToolStripMenuItem.Name = "DevelopersToolStripMenuItem"
        Me.DevelopersToolStripMenuItem.Size = New System.Drawing.Size(186, 56)
        Me.DevelopersToolStripMenuItem.Text = "Developers"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.Image = Global.BookManagementSystem.My.Resources.Resources.icons8_time_32
        Me.TimeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(186, 56)
        Me.TimeToolStripMenuItem.Text = "Time"
        '
        'FuturePlanToolStripMenuItem
        '
        Me.FuturePlanToolStripMenuItem.Name = "FuturePlanToolStripMenuItem"
        Me.FuturePlanToolStripMenuItem.Size = New System.Drawing.Size(186, 56)
        Me.FuturePlanToolStripMenuItem.Text = "Background"
        Me.FuturePlanToolStripMenuItem.ToolTipText = "Still Under deveop"
        '
        'tsbexit
        '
        Me.tsbexit.BackColor = System.Drawing.Color.White
        Me.tsbexit.ForeColor = System.Drawing.Color.Black
        Me.tsbexit.Image = Global.BookManagementSystem.My.Resources.Resources.Exit_32
        Me.tsbexit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbexit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbexit.Name = "tsbexit"
        Me.tsbexit.Size = New System.Drawing.Size(61, 54)
        Me.tsbexit.Text = "Exit"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(43, 54)
        Me.ToolStripLabel1.Text = "Closed"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripComboBox1.Image = CType(resources.GetObject("ToolStripComboBox1.Image"), System.Drawing.Image)
        Me.ToolStripComboBox1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(23, 54)
        '
        'FontDropDownList1
        '
        Me.FontDropDownList1.ForeColor = System.Drawing.Color.Yellow
        Me.FontDropDownList1.FormattingEnabled = True
        Me.FontDropDownList1.Location = New System.Drawing.Point(818, 63)
        Me.FontDropDownList1.Name = "FontDropDownList1"
        Me.FontDropDownList1.Size = New System.Drawing.Size(121, 21)
        Me.FontDropDownList1.TabIndex = 5
        Me.FontDropDownList1.Visible = False
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.Color.White
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Coral
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.BookManagementSystem.My.Resources.Resources.loggo_ico
        Me.PictureBox1.Location = New System.Drawing.Point(945, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.BookManagementSystem.My.Resources.Resources.logo_2
        Me.PictureBox3.Location = New System.Drawing.Point(20, 76)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1008, 641)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(20, 117)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(984, 613)
        Me.AxAcroPDF1.TabIndex = 15
        Me.AxAcroPDF1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'photo
        '
        Me.photo.Location = New System.Drawing.Point(845, 60)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(100, 57)
        Me.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.photo.TabIndex = 17
        Me.photo.TabStop = False
        Me.photo.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImage = CType(resources.GetObject("$this.BackImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 772)
        Me.ControlBox = False
        Me.Controls.Add(Me.photo)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FontDropDownList1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox3)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Text = "Book Management System"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents FontDropDownList1 As ActiproSoftware.SyntaxEditor.FontDropDownList
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents tsbexit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbook As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents IssueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents NoteItToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents AddUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Userwho As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents AboutProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequirementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuturePlanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevelopersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecretToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents FROMDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CloseBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents photo As System.Windows.Forms.PictureBox
End Class
