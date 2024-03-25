<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_Profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Profile))
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.OrderBtn = New System.Windows.Forms.Button()
        Me.Specification = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UserInfoPanel1 = New System.Windows.Forms.Panel()
        Me.ContactNoTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LastNTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FirstNTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usernameTxt = New System.Windows.Forms.TextBox()
        Me.CartPanel = New System.Windows.Forms.Panel()
        Me.stockstatus = New System.Windows.Forms.Label()
        Me.confoLB = New System.Windows.Forms.Label()
        Me.Cart = New System.Windows.Forms.Label()
        Me.Price2LB = New System.Windows.Forms.Label()
        Me.TotalLB = New System.Windows.Forms.Label()
        Me.ViewMBtn = New System.Windows.Forms.Button()
        Me.trashimg = New System.Windows.Forms.PictureBox()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.CarName = New System.Windows.Forms.Label()
        Me.CarImage = New System.Windows.Forms.PictureBox()
        Me.UserInfoPanel2 = New System.Windows.Forms.Panel()
        Me.AddressTxt = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Sidebar = New System.Windows.Forms.Panel()
        Me.Profile = New System.Windows.Forms.Button()
        Me.Homebel = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Label()
        Me.Registerlink = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.FlowCart = New System.Windows.Forms.FlowLayoutPanel()
        Me.Remove_user_btn = New System.Windows.Forms.Button()
        Me.UserInfoPanel1.SuspendLayout()
        Me.CartPanel.SuspendLayout()
        CType(Me.trashimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserInfoPanel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPanel.SuspendLayout()
        Me.FlowCart.SuspendLayout()
        Me.SuspendLayout()
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.Red
        Me.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.ForeColor = System.Drawing.Color.White
        Me.Exit_btn.Location = New System.Drawing.Point(947, 12)
        Me.Exit_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(27, 26)
        Me.Exit_btn.TabIndex = 41
        Me.Exit_btn.Text = "X"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'OrderBtn
        '
        Me.OrderBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OrderBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.OrderBtn.ForeColor = System.Drawing.Color.White
        Me.OrderBtn.Location = New System.Drawing.Point(253, 133)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Size = New System.Drawing.Size(126, 36)
        Me.OrderBtn.TabIndex = 23
        Me.OrderBtn.Text = "Order Now"
        Me.OrderBtn.UseVisualStyleBackColor = False
        '
        'Specification
        '
        Me.Specification.AutoSize = True
        Me.Specification.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Specification.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specification.Location = New System.Drawing.Point(6, 1)
        Me.Specification.Name = "Specification"
        Me.Specification.Size = New System.Drawing.Size(181, 30)
        Me.Specification.TabIndex = 0
        Me.Specification.Text = "User Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Username"
        '
        'UserInfoPanel1
        '
        Me.UserInfoPanel1.BackColor = System.Drawing.Color.White
        Me.UserInfoPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserInfoPanel1.Controls.Add(Me.ContactNoTxt)
        Me.UserInfoPanel1.Controls.Add(Me.Label4)
        Me.UserInfoPanel1.Controls.Add(Me.EmailTxt)
        Me.UserInfoPanel1.Controls.Add(Me.Label3)
        Me.UserInfoPanel1.Controls.Add(Me.LastNTxt)
        Me.UserInfoPanel1.Controls.Add(Me.Label2)
        Me.UserInfoPanel1.Controls.Add(Me.FirstNTxt)
        Me.UserInfoPanel1.Controls.Add(Me.Label1)
        Me.UserInfoPanel1.Controls.Add(Me.usernameTxt)
        Me.UserInfoPanel1.Controls.Add(Me.Label6)
        Me.UserInfoPanel1.Controls.Add(Me.Specification)
        Me.UserInfoPanel1.Location = New System.Drawing.Point(208, 192)
        Me.UserInfoPanel1.Name = "UserInfoPanel1"
        Me.UserInfoPanel1.Size = New System.Drawing.Size(340, 367)
        Me.UserInfoPanel1.TabIndex = 45
        '
        'ContactNoTxt
        '
        Me.ContactNoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNoTxt.Location = New System.Drawing.Point(11, 323)
        Me.ContactNoTxt.Name = "ContactNoTxt"
        Me.ContactNoTxt.ReadOnly = True
        Me.ContactNoTxt.Size = New System.Drawing.Size(319, 24)
        Me.ContactNoTxt.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Contact No"
        '
        'EmailTxt
        '
        Me.EmailTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTxt.Location = New System.Drawing.Point(11, 257)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.ReadOnly = True
        Me.EmailTxt.Size = New System.Drawing.Size(319, 24)
        Me.EmailTxt.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Email"
        '
        'LastNTxt
        '
        Me.LastNTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNTxt.Location = New System.Drawing.Point(11, 199)
        Me.LastNTxt.Name = "LastNTxt"
        Me.LastNTxt.ReadOnly = True
        Me.LastNTxt.Size = New System.Drawing.Size(319, 24)
        Me.LastNTxt.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name"
        '
        'FirstNTxt
        '
        Me.FirstNTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNTxt.Location = New System.Drawing.Point(11, 136)
        Me.FirstNTxt.Name = "FirstNTxt"
        Me.FirstNTxt.ReadOnly = True
        Me.FirstNTxt.Size = New System.Drawing.Size(319, 24)
        Me.FirstNTxt.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name"
        '
        'usernameTxt
        '
        Me.usernameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTxt.Location = New System.Drawing.Point(11, 66)
        Me.usernameTxt.Name = "usernameTxt"
        Me.usernameTxt.ReadOnly = True
        Me.usernameTxt.Size = New System.Drawing.Size(319, 24)
        Me.usernameTxt.TabIndex = 3
        '
        'CartPanel
        '
        Me.CartPanel.BackColor = System.Drawing.Color.White
        Me.CartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CartPanel.Controls.Add(Me.stockstatus)
        Me.CartPanel.Controls.Add(Me.confoLB)
        Me.CartPanel.Controls.Add(Me.Cart)
        Me.CartPanel.Controls.Add(Me.Price2LB)
        Me.CartPanel.Controls.Add(Me.TotalLB)
        Me.CartPanel.Controls.Add(Me.ViewMBtn)
        Me.CartPanel.Controls.Add(Me.trashimg)
        Me.CartPanel.Controls.Add(Me.PriceLabel)
        Me.CartPanel.Controls.Add(Me.CarName)
        Me.CartPanel.Controls.Add(Me.CarImage)
        Me.CartPanel.Controls.Add(Me.OrderBtn)
        Me.CartPanel.Location = New System.Drawing.Point(3, 3)
        Me.CartPanel.Name = "CartPanel"
        Me.CartPanel.Size = New System.Drawing.Size(394, 181)
        Me.CartPanel.TabIndex = 46
        '
        'stockstatus
        '
        Me.stockstatus.AutoSize = True
        Me.stockstatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.stockstatus.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockstatus.ForeColor = System.Drawing.Color.Red
        Me.stockstatus.Location = New System.Drawing.Point(242, 132)
        Me.stockstatus.Name = "stockstatus"
        Me.stockstatus.Size = New System.Drawing.Size(137, 30)
        Me.stockstatus.TabIndex = 48
        Me.stockstatus.Text = "Out of Stock"
        '
        'confoLB
        '
        Me.confoLB.AutoSize = True
        Me.confoLB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.confoLB.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confoLB.Location = New System.Drawing.Point(60, 74)
        Me.confoLB.Name = "confoLB"
        Me.confoLB.Size = New System.Drawing.Size(272, 30)
        Me.confoLB.TabIndex = 31
        Me.confoLB.Text = "Waiting For Conformation"
        '
        'Cart
        '
        Me.Cart.AutoSize = True
        Me.Cart.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cart.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cart.Location = New System.Drawing.Point(22, 4)
        Me.Cart.Name = "Cart"
        Me.Cart.Size = New System.Drawing.Size(105, 30)
        Me.Cart.TabIndex = 0
        Me.Cart.Text = "Your Cart"
        '
        'Price2LB
        '
        Me.Price2LB.AutoSize = True
        Me.Price2LB.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price2LB.Location = New System.Drawing.Point(17, 140)
        Me.Price2LB.Name = "Price2LB"
        Me.Price2LB.Size = New System.Drawing.Size(101, 23)
        Me.Price2LB.TabIndex = 30
        Me.Price2LB.Text = "Rs. 725000"
        '
        'TotalLB
        '
        Me.TotalLB.AutoSize = True
        Me.TotalLB.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLB.Location = New System.Drawing.Point(12, 112)
        Me.TotalLB.Name = "TotalLB"
        Me.TotalLB.Size = New System.Drawing.Size(39, 18)
        Me.TotalLB.TabIndex = 29
        Me.TotalLB.Text = "Total"
        '
        'ViewMBtn
        '
        Me.ViewMBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ViewMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewMBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMBtn.Location = New System.Drawing.Point(301, 68)
        Me.ViewMBtn.Name = "ViewMBtn"
        Me.ViewMBtn.Size = New System.Drawing.Size(78, 23)
        Me.ViewMBtn.TabIndex = 28
        Me.ViewMBtn.Text = "View More"
        Me.ViewMBtn.UseVisualStyleBackColor = False
        '
        'trashimg
        '
        Me.trashimg.Image = Global.Car_Showroom.My.Resources.Resources.trash
        Me.trashimg.Location = New System.Drawing.Point(349, 18)
        Me.trashimg.Name = "trashimg"
        Me.trashimg.Size = New System.Drawing.Size(30, 27)
        Me.trashimg.TabIndex = 27
        Me.trashimg.TabStop = False
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(159, 66)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(70, 16)
        Me.PriceLabel.TabIndex = 26
        Me.PriceLabel.Text = "Rs. 725000"
        '
        'CarName
        '
        Me.CarName.AutoSize = True
        Me.CarName.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarName.Location = New System.Drawing.Point(159, 37)
        Me.CarName.Name = "CarName"
        Me.CarName.Size = New System.Drawing.Size(142, 18)
        Me.CarName.TabIndex = 25
        Me.CarName.Text = "Maruti Suzuki Swift "
        '
        'CarImage
        '
        Me.CarImage.Image = Global.Car_Showroom.My.Resources.Resources.BalenoC1
        Me.CarImage.Location = New System.Drawing.Point(15, 37)
        Me.CarImage.Name = "CarImage"
        Me.CarImage.Size = New System.Drawing.Size(138, 72)
        Me.CarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarImage.TabIndex = 24
        Me.CarImage.TabStop = False
        '
        'UserInfoPanel2
        '
        Me.UserInfoPanel2.BackColor = System.Drawing.Color.White
        Me.UserInfoPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserInfoPanel2.Controls.Add(Me.AddressTxt)
        Me.UserInfoPanel2.Controls.Add(Me.Label10)
        Me.UserInfoPanel2.Controls.Add(Me.Label11)
        Me.UserInfoPanel2.Location = New System.Drawing.Point(570, 193)
        Me.UserInfoPanel2.Name = "UserInfoPanel2"
        Me.UserInfoPanel2.Size = New System.Drawing.Size(398, 178)
        Me.UserInfoPanel2.TabIndex = 46
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(15, 68)
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.ReadOnly = True
        Me.AddressTxt.Size = New System.Drawing.Size(348, 90)
        Me.AddressTxt.TabIndex = 3
        Me.AddressTxt.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 30)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "User Information"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Car_Showroom.My.Resources.Resources.userImage
        Me.PictureBox3.Location = New System.Drawing.Point(208, 126)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 48
        Me.PictureBox3.TabStop = False
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Sidebar.BackgroundImage = CType(resources.GetObject("Sidebar.BackgroundImage"), System.Drawing.Image)
        Me.Sidebar.Controls.Add(Me.Profile)
        Me.Sidebar.Controls.Add(Me.Homebel)
        Me.Sidebar.Controls.Add(Me.Logout)
        Me.Sidebar.Controls.Add(Me.Registerlink)
        Me.Sidebar.Controls.Add(Me.PictureBox1)
        Me.Sidebar.Controls.Add(Me.PictureBox2)
        Me.Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(194, 571)
        Me.Sidebar.TabIndex = 40
        '
        'Profile
        '
        Me.Profile.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Profile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Profile.ForeColor = System.Drawing.Color.White
        Me.Profile.Location = New System.Drawing.Point(4, 508)
        Me.Profile.Name = "Profile"
        Me.Profile.Size = New System.Drawing.Size(188, 36)
        Me.Profile.TabIndex = 22
        Me.Profile.Text = "Guest"
        Me.Profile.UseVisualStyleBackColor = False
        '
        'Homebel
        '
        Me.Homebel.BackColor = System.Drawing.Color.Transparent
        Me.Homebel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Homebel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Homebel.ForeColor = System.Drawing.Color.White
        Me.Homebel.Location = New System.Drawing.Point(-2, 184)
        Me.Homebel.Name = "Homebel"
        Me.Homebel.Size = New System.Drawing.Size(194, 36)
        Me.Homebel.TabIndex = 16
        Me.Homebel.Text = "Home"
        Me.Homebel.UseVisualStyleBackColor = False
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.BackColor = System.Drawing.Color.Transparent
        Me.Logout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.ForeColor = System.Drawing.Color.Red
        Me.Logout.Location = New System.Drawing.Point(56, 467)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(68, 21)
        Me.Logout.TabIndex = 15
        Me.Logout.Text = "Log out"
        '
        'Registerlink
        '
        Me.Registerlink.AutoSize = True
        Me.Registerlink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Registerlink.Location = New System.Drawing.Point(31, 516)
        Me.Registerlink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Registerlink.Name = "Registerlink"
        Me.Registerlink.Size = New System.Drawing.Size(130, 13)
        Me.Registerlink.TabIndex = 7
        Me.Registerlink.TabStop = True
        Me.Registerlink.Text = "New User? Register Now!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 24)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 89)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(163, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackgroundImage = Global.Car_Showroom.My.Resources.Resources.header
        Me.HeaderPanel.Controls.Add(Me.Label94)
        Me.HeaderPanel.Location = New System.Drawing.Point(194, -1)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(798, 126)
        Me.HeaderPanel.TabIndex = 47
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.BackColor = System.Drawing.Color.Transparent
        Me.Label94.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.White
        Me.Label94.Location = New System.Drawing.Point(46, 37)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(211, 47)
        Me.Label94.TabIndex = 42
        Me.Label94.Text = "User Profile"
        '
        'FlowCart
        '
        Me.FlowCart.AutoScroll = True
        Me.FlowCart.Controls.Add(Me.CartPanel)
        Me.FlowCart.Location = New System.Drawing.Point(571, 378)
        Me.FlowCart.Name = "FlowCart"
        Me.FlowCart.Size = New System.Drawing.Size(421, 185)
        Me.FlowCart.TabIndex = 31
        '
        'Remove_user_btn
        '
        Me.Remove_user_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Remove_user_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remove_user_btn.ForeColor = System.Drawing.Color.White
        Me.Remove_user_btn.Location = New System.Drawing.Point(855, 142)
        Me.Remove_user_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Remove_user_btn.Name = "Remove_user_btn"
        Me.Remove_user_btn.Size = New System.Drawing.Size(99, 32)
        Me.Remove_user_btn.TabIndex = 49
        Me.Remove_user_btn.Text = "Remove"
        Me.Remove_user_btn.UseVisualStyleBackColor = False
        Me.Remove_user_btn.Visible = False
        '
        'User_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 568)
        Me.Controls.Add(Me.Remove_user_btn)
        Me.Controls.Add(Me.UserInfoPanel1)
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.UserInfoPanel2)
        Me.Controls.Add(Me.FlowCart)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User_Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.UserInfoPanel1.ResumeLayout(False)
        Me.UserInfoPanel1.PerformLayout()
        Me.CartPanel.ResumeLayout(False)
        Me.CartPanel.PerformLayout()
        CType(Me.trashimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserInfoPanel2.ResumeLayout(False)
        Me.UserInfoPanel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.FlowCart.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Exit_btn As Button
    Friend WithEvents Sidebar As Panel
    Friend WithEvents Profile As Button
    Friend WithEvents Homebel As Button
    Friend WithEvents Logout As Label
    Friend WithEvents Registerlink As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label94 As Label
    Friend WithEvents OrderBtn As Button
    Friend WithEvents Specification As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents UserInfoPanel1 As Panel
    Friend WithEvents CartPanel As Panel
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ContactNoTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LastNTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents usernameTxt As TextBox
    Friend WithEvents Cart As Label
    Friend WithEvents UserInfoPanel2 As Panel
    Friend WithEvents AddressTxt As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CarName As Label
    Friend WithEvents CarImage As PictureBox
    Friend WithEvents PriceLabel As Label
    Friend WithEvents trashimg As PictureBox
    Friend WithEvents Price2LB As Label
    Friend WithEvents TotalLB As Label
    Friend WithEvents ViewMBtn As Button
    Friend WithEvents FlowCart As FlowLayoutPanel
    Friend WithEvents confoLB As Label
    Friend WithEvents stockstatus As Label
    Friend WithEvents Remove_user_btn As Button
End Class
