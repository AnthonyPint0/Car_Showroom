<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Mainform
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Mainform))
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.Sidebar = New System.Windows.Forms.Panel()
        Me.Profile = New System.Windows.Forms.Button()
        Me.Add_carBtn = New System.Windows.Forms.Button()
        Me.Sales_Reports = New System.Windows.Forms.Button()
        Me.Customer_Management = New System.Windows.Forms.Button()
        Me.Car_Inventory = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Label()
        Me.Registerlink = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CarIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailableCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxCapacityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Car_ShowroomADataSet = New Car_Showroom.Car_ShowroomADataSet()
        Me.InventoryStatusTableAdapter = New Car_Showroom.Car_ShowroomADataSetTableAdapters.InventoryStatusTableAdapter()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Car_InventoryGB = New System.Windows.Forms.GroupBox()
        Me.AddCarBtn = New System.Windows.Forms.Button()
        Me.noofcars = New System.Windows.Forms.TextBox()
        Me.CarIDCB = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Add_carGB = New System.Windows.Forms.GroupBox()
        Me.BodyTypeCB = New System.Windows.Forms.ComboBox()
        Me.CarPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.UploadImageButton = New System.Windows.Forms.Button()
        Me.DescriptionTB = New System.Windows.Forms.RichTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CustReviewlinkTB = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PriceTB = New System.Windows.Forms.TextBox()
        Me.CustReviewTB = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DriverTypeTB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MaxPowerTB = New System.Windows.Forms.TextBox()
        Me.SeatingCapacityTB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TransmissionTB = New System.Windows.Forms.TextBox()
        Me.FuelTypeTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.EngineTB = New System.Windows.Forms.TextBox()
        Me.MileageTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CarIdTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CarNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car_ShowroomADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Car_InventoryGB.SuspendLayout()
        Me.Add_carGB.SuspendLayout()
        CType(Me.CarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.Red
        Me.Exit_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.ForeColor = System.Drawing.Color.White
        Me.Exit_btn.Location = New System.Drawing.Point(942, 12)
        Me.Exit_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(28, 26)
        Me.Exit_btn.TabIndex = 42
        Me.Exit_btn.Text = "X"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Sidebar.BackgroundImage = CType(resources.GetObject("Sidebar.BackgroundImage"), System.Drawing.Image)
        Me.Sidebar.Controls.Add(Me.Profile)
        Me.Sidebar.Controls.Add(Me.Add_carBtn)
        Me.Sidebar.Controls.Add(Me.Sales_Reports)
        Me.Sidebar.Controls.Add(Me.Customer_Management)
        Me.Sidebar.Controls.Add(Me.Car_Inventory)
        Me.Sidebar.Controls.Add(Me.Logout)
        Me.Sidebar.Controls.Add(Me.Registerlink)
        Me.Sidebar.Controls.Add(Me.PictureBox1)
        Me.Sidebar.Controls.Add(Me.PictureBox2)
        Me.Sidebar.Location = New System.Drawing.Point(-2, 0)
        Me.Sidebar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(194, 571)
        Me.Sidebar.TabIndex = 41
        '
        'Profile
        '
        Me.Profile.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
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
        'Add_carBtn
        '
        Me.Add_carBtn.BackColor = System.Drawing.Color.Transparent
        Me.Add_carBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Add_carBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Add_carBtn.ForeColor = System.Drawing.Color.White
        Me.Add_carBtn.Location = New System.Drawing.Point(1, 209)
        Me.Add_carBtn.Name = "Add_carBtn"
        Me.Add_carBtn.Size = New System.Drawing.Size(194, 36)
        Me.Add_carBtn.TabIndex = 20
        Me.Add_carBtn.Text = "Add New Car"
        Me.Add_carBtn.UseVisualStyleBackColor = False
        '
        'Sales_Reports
        '
        Me.Sales_Reports.BackColor = System.Drawing.Color.Transparent
        Me.Sales_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Sales_Reports.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Sales_Reports.ForeColor = System.Drawing.Color.White
        Me.Sales_Reports.Location = New System.Drawing.Point(0, 262)
        Me.Sales_Reports.Name = "Sales_Reports"
        Me.Sales_Reports.Size = New System.Drawing.Size(194, 36)
        Me.Sales_Reports.TabIndex = 18
        Me.Sales_Reports.Text = "Sales Reports"
        Me.Sales_Reports.UseVisualStyleBackColor = False
        '
        'Customer_Management
        '
        Me.Customer_Management.BackColor = System.Drawing.Color.Transparent
        Me.Customer_Management.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Customer_Management.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Customer_Management.ForeColor = System.Drawing.Color.White
        Me.Customer_Management.Location = New System.Drawing.Point(1, 322)
        Me.Customer_Management.Name = "Customer_Management"
        Me.Customer_Management.Size = New System.Drawing.Size(194, 55)
        Me.Customer_Management.TabIndex = 17
        Me.Customer_Management.Text = "Customer Management"
        Me.Customer_Management.UseVisualStyleBackColor = False
        '
        'Car_Inventory
        '
        Me.Car_Inventory.BackColor = System.Drawing.Color.Transparent
        Me.Car_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Car_Inventory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Car_Inventory.ForeColor = System.Drawing.Color.White
        Me.Car_Inventory.Location = New System.Drawing.Point(0, 153)
        Me.Car_Inventory.Name = "Car_Inventory"
        Me.Car_Inventory.Size = New System.Drawing.Size(194, 36)
        Me.Car_Inventory.TabIndex = 16
        Me.Car_Inventory.Text = "Car Inventory"
        Me.Car_Inventory.UseVisualStyleBackColor = False
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.BackColor = System.Drawing.Color.Transparent
        Me.Logout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.ForeColor = System.Drawing.Color.Red
        Me.Logout.Location = New System.Drawing.Point(73, 464)
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CarIDDataGridViewTextBoxColumn, Me.AvailableCountDataGridViewTextBoxColumn, Me.MaxCapacityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InventoryStatusBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(667, 360)
        Me.DataGridView1.TabIndex = 1
        '
        'CarIDDataGridViewTextBoxColumn
        '
        Me.CarIDDataGridViewTextBoxColumn.DataPropertyName = "CarID"
        Me.CarIDDataGridViewTextBoxColumn.HeaderText = "CarID"
        Me.CarIDDataGridViewTextBoxColumn.MinimumWidth = 20
        Me.CarIDDataGridViewTextBoxColumn.Name = "CarIDDataGridViewTextBoxColumn"
        Me.CarIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CarIDDataGridViewTextBoxColumn.Width = 200
        '
        'AvailableCountDataGridViewTextBoxColumn
        '
        Me.AvailableCountDataGridViewTextBoxColumn.DataPropertyName = "AvailableCount"
        Me.AvailableCountDataGridViewTextBoxColumn.HeaderText = "AvailableCount"
        Me.AvailableCountDataGridViewTextBoxColumn.MinimumWidth = 40
        Me.AvailableCountDataGridViewTextBoxColumn.Name = "AvailableCountDataGridViewTextBoxColumn"
        Me.AvailableCountDataGridViewTextBoxColumn.ReadOnly = True
        Me.AvailableCountDataGridViewTextBoxColumn.Width = 200
        '
        'MaxCapacityDataGridViewTextBoxColumn
        '
        Me.MaxCapacityDataGridViewTextBoxColumn.DataPropertyName = "MaxCapacity"
        Me.MaxCapacityDataGridViewTextBoxColumn.HeaderText = "MaxCapacity"
        Me.MaxCapacityDataGridViewTextBoxColumn.MinimumWidth = 40
        Me.MaxCapacityDataGridViewTextBoxColumn.Name = "MaxCapacityDataGridViewTextBoxColumn"
        Me.MaxCapacityDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaxCapacityDataGridViewTextBoxColumn.Width = 200
        '
        'InventoryStatusBindingSource
        '
        Me.InventoryStatusBindingSource.DataMember = "InventoryStatus"
        Me.InventoryStatusBindingSource.DataSource = Me.Car_ShowroomADataSet
        '
        'Car_ShowroomADataSet
        '
        Me.Car_ShowroomADataSet.DataSetName = "Car_ShowroomADataSet"
        Me.Car_ShowroomADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryStatusTableAdapter
        '
        Me.InventoryStatusTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Car_InventoryGB)
        Me.FlowLayoutPanel1.Controls.Add(Me.Add_carGB)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(199, 31)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(746, 507)
        Me.FlowLayoutPanel1.TabIndex = 44
        '
        'Car_InventoryGB
        '
        Me.Car_InventoryGB.BackColor = System.Drawing.Color.White
        Me.Car_InventoryGB.Controls.Add(Me.AddCarBtn)
        Me.Car_InventoryGB.Controls.Add(Me.noofcars)
        Me.Car_InventoryGB.Controls.Add(Me.CarIDCB)
        Me.Car_InventoryGB.Controls.Add(Me.Label3)
        Me.Car_InventoryGB.Controls.Add(Me.Label2)
        Me.Car_InventoryGB.Controls.Add(Me.Label1)
        Me.Car_InventoryGB.Controls.Add(Me.DataGridView1)
        Me.Car_InventoryGB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_InventoryGB.Location = New System.Drawing.Point(3, 3)
        Me.Car_InventoryGB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 25)
        Me.Car_InventoryGB.Name = "Car_InventoryGB"
        Me.Car_InventoryGB.Size = New System.Drawing.Size(722, 469)
        Me.Car_InventoryGB.TabIndex = 4
        Me.Car_InventoryGB.TabStop = False
        Me.Car_InventoryGB.Text = "Car Inventory"
        '
        'AddCarBtn
        '
        Me.AddCarBtn.BackColor = System.Drawing.Color.Green
        Me.AddCarBtn.ForeColor = System.Drawing.Color.White
        Me.AddCarBtn.Location = New System.Drawing.Point(557, 417)
        Me.AddCarBtn.Name = "AddCarBtn"
        Me.AddCarBtn.Size = New System.Drawing.Size(90, 43)
        Me.AddCarBtn.TabIndex = 26
        Me.AddCarBtn.Text = "Add Car"
        Me.AddCarBtn.UseVisualStyleBackColor = False
        '
        'noofcars
        '
        Me.noofcars.Location = New System.Drawing.Point(278, 438)
        Me.noofcars.Name = "noofcars"
        Me.noofcars.Size = New System.Drawing.Size(58, 25)
        Me.noofcars.TabIndex = 25
        '
        'CarIDCB
        '
        Me.CarIDCB.FormattingEnabled = True
        Me.CarIDCB.Location = New System.Drawing.Point(12, 435)
        Me.CarIDCB.Name = "CarIDCB"
        Me.CarIDCB.Size = New System.Drawing.Size(121, 26)
        Me.CarIDCB.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(275, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. of Cars"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CarID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add Car:"
        '
        'Add_carGB
        '
        Me.Add_carGB.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Add_carGB.Controls.Add(Me.BodyTypeCB)
        Me.Add_carGB.Controls.Add(Me.CarPictureBox)
        Me.Add_carGB.Controls.Add(Me.Label18)
        Me.Add_carGB.Controls.Add(Me.UploadImageButton)
        Me.Add_carGB.Controls.Add(Me.DescriptionTB)
        Me.Add_carGB.Controls.Add(Me.Label17)
        Me.Add_carGB.Controls.Add(Me.CustReviewlinkTB)
        Me.Add_carGB.Controls.Add(Me.Label14)
        Me.Add_carGB.Controls.Add(Me.PriceTB)
        Me.Add_carGB.Controls.Add(Me.CustReviewTB)
        Me.Add_carGB.Controls.Add(Me.Label15)
        Me.Add_carGB.Controls.Add(Me.Label16)
        Me.Add_carGB.Controls.Add(Me.DriverTypeTB)
        Me.Add_carGB.Controls.Add(Me.Label10)
        Me.Add_carGB.Controls.Add(Me.Label11)
        Me.Add_carGB.Controls.Add(Me.MaxPowerTB)
        Me.Add_carGB.Controls.Add(Me.SeatingCapacityTB)
        Me.Add_carGB.Controls.Add(Me.Label12)
        Me.Add_carGB.Controls.Add(Me.Label13)
        Me.Add_carGB.Controls.Add(Me.TransmissionTB)
        Me.Add_carGB.Controls.Add(Me.FuelTypeTB)
        Me.Add_carGB.Controls.Add(Me.Label8)
        Me.Add_carGB.Controls.Add(Me.Label9)
        Me.Add_carGB.Controls.Add(Me.EngineTB)
        Me.Add_carGB.Controls.Add(Me.MileageTB)
        Me.Add_carGB.Controls.Add(Me.Label6)
        Me.Add_carGB.Controls.Add(Me.Label7)
        Me.Add_carGB.Controls.Add(Me.CarIdTextBox)
        Me.Add_carGB.Controls.Add(Me.SaveButton)
        Me.Add_carGB.Controls.Add(Me.CarNameTextBox)
        Me.Add_carGB.Controls.Add(Me.Label4)
        Me.Add_carGB.Controls.Add(Me.Label5)
        Me.Add_carGB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_carGB.Location = New System.Drawing.Point(3, 500)
        Me.Add_carGB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 25)
        Me.Add_carGB.Name = "Add_carGB"
        Me.Add_carGB.Size = New System.Drawing.Size(706, 469)
        Me.Add_carGB.TabIndex = 5
        Me.Add_carGB.TabStop = False
        Me.Add_carGB.Text = "Add New Car"
        '
        'BodyTypeCB
        '
        Me.BodyTypeCB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.BodyTypeCB.FormattingEnabled = True
        Me.BodyTypeCB.Location = New System.Drawing.Point(522, 369)
        Me.BodyTypeCB.Name = "BodyTypeCB"
        Me.BodyTypeCB.Size = New System.Drawing.Size(151, 23)
        Me.BodyTypeCB.TabIndex = 55
        '
        'CarPictureBox
        '
        Me.CarPictureBox.Location = New System.Drawing.Point(137, 377)
        Me.CarPictureBox.Name = "CarPictureBox"
        Me.CarPictureBox.Size = New System.Drawing.Size(145, 83)
        Me.CarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarPictureBox.TabIndex = 54
        Me.CarPictureBox.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(9, 374)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(122, 32)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "*Image Name must " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "be Same as CarID"
        '
        'UploadImageButton
        '
        Me.UploadImageButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UploadImageButton.ForeColor = System.Drawing.Color.Black
        Me.UploadImageButton.Location = New System.Drawing.Point(6, 415)
        Me.UploadImageButton.Name = "UploadImageButton"
        Me.UploadImageButton.Size = New System.Drawing.Size(116, 34)
        Me.UploadImageButton.TabIndex = 52
        Me.UploadImageButton.Text = "Upload Image"
        Me.UploadImageButton.UseVisualStyleBackColor = False
        '
        'DescriptionTB
        '
        Me.DescriptionTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DescriptionTB.Location = New System.Drawing.Point(110, 275)
        Me.DescriptionTB.Name = "DescriptionTB"
        Me.DescriptionTB.Size = New System.Drawing.Size(237, 96)
        Me.DescriptionTB.TabIndex = 51
        Me.DescriptionTB.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 276)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 16)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Description"
        '
        'CustReviewlinkTB
        '
        Me.CustReviewlinkTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CustReviewlinkTB.Location = New System.Drawing.Point(110, 226)
        Me.CustReviewlinkTB.Name = "CustReviewlinkTB"
        Me.CustReviewlinkTB.Size = New System.Drawing.Size(151, 21)
        Me.CustReviewlinkTB.TabIndex = 49
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 231)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 16)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "CustReviewLink"
        '
        'PriceTB
        '
        Me.PriceTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.PriceTB.Location = New System.Drawing.Point(110, 126)
        Me.PriceTB.Name = "PriceTB"
        Me.PriceTB.Size = New System.Drawing.Size(151, 21)
        Me.PriceTB.TabIndex = 47
        '
        'CustReviewTB
        '
        Me.CustReviewTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CustReviewTB.Location = New System.Drawing.Point(110, 175)
        Me.CustReviewTB.Name = "CustReviewTB"
        Me.CustReviewTB.Size = New System.Drawing.Size(151, 21)
        Me.CustReviewTB.TabIndex = 46
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 180)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 16)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "CustReview"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(41, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 16)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Price"
        '
        'DriverTypeTB
        '
        Me.DriverTypeTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DriverTypeTB.Location = New System.Drawing.Point(522, 322)
        Me.DriverTypeTB.Name = "DriverTypeTB"
        Me.DriverTypeTB.Size = New System.Drawing.Size(151, 21)
        Me.DriverTypeTB.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(436, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Body Type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(434, 326)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 16)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Driver Type"
        '
        'MaxPowerTB
        '
        Me.MaxPowerTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.MaxPowerTB.Location = New System.Drawing.Point(522, 222)
        Me.MaxPowerTB.Name = "MaxPowerTB"
        Me.MaxPowerTB.Size = New System.Drawing.Size(151, 21)
        Me.MaxPowerTB.TabIndex = 39
        '
        'SeatingCapacityTB
        '
        Me.SeatingCapacityTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.SeatingCapacityTB.Location = New System.Drawing.Point(522, 271)
        Me.SeatingCapacityTB.Name = "SeatingCapacityTB"
        Me.SeatingCapacityTB.Size = New System.Drawing.Size(151, 21)
        Me.SeatingCapacityTB.TabIndex = 38
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(398, 273)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 16)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Seating Capacity"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(432, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Max Power"
        '
        'TransmissionTB
        '
        Me.TransmissionTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TransmissionTB.Location = New System.Drawing.Point(522, 129)
        Me.TransmissionTB.Name = "TransmissionTB"
        Me.TransmissionTB.Size = New System.Drawing.Size(151, 21)
        Me.TransmissionTB.TabIndex = 35
        '
        'FuelTypeTB
        '
        Me.FuelTypeTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.FuelTypeTB.Location = New System.Drawing.Point(522, 178)
        Me.FuelTypeTB.Name = "FuelTypeTB"
        Me.FuelTypeTB.Size = New System.Drawing.Size(151, 21)
        Me.FuelTypeTB.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(441, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Fuel Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(420, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Transmission"
        '
        'EngineTB
        '
        Me.EngineTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.EngineTB.Location = New System.Drawing.Point(522, 29)
        Me.EngineTB.Name = "EngineTB"
        Me.EngineTB.Size = New System.Drawing.Size(151, 21)
        Me.EngineTB.TabIndex = 31
        '
        'MileageTB
        '
        Me.MileageTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.MileageTB.Location = New System.Drawing.Point(522, 78)
        Me.MileageTB.Name = "MileageTB"
        Me.MileageTB.Size = New System.Drawing.Size(151, 21)
        Me.MileageTB.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(452, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Mileage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(457, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Engine"
        '
        'CarIdTextBox
        '
        Me.CarIdTextBox.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CarIdTextBox.Location = New System.Drawing.Point(110, 34)
        Me.CarIdTextBox.Name = "CarIdTextBox"
        Me.CarIdTextBox.Size = New System.Drawing.Size(151, 21)
        Me.CarIdTextBox.TabIndex = 27
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.Green
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Location = New System.Drawing.Point(557, 417)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(90, 43)
        Me.SaveButton.TabIndex = 26
        Me.SaveButton.Text = "Add Car"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'CarNameTextBox
        '
        Me.CarNameTextBox.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarNameTextBox.Location = New System.Drawing.Point(110, 83)
        Me.CarNameTextBox.Name = "CarNameTextBox"
        Me.CarNameTextBox.Size = New System.Drawing.Size(151, 21)
        Me.CarNameTextBox.TabIndex = 25
        Me.CarNameTextBox.Text = "Hyundai Grand i10 Nios"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Car Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "CarID"
        '
        'Admin_Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(983, 571)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Mainform"
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car_ShowroomADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Car_InventoryGB.ResumeLayout(False)
        Me.Car_InventoryGB.PerformLayout()
        Me.Add_carGB.ResumeLayout(False)
        Me.Add_carGB.PerformLayout()
        CType(Me.CarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Exit_btn As Button
    Friend WithEvents Sidebar As Panel
    Friend WithEvents Profile As Button
    Friend WithEvents Sales_Reports As Button
    Friend WithEvents Car_Inventory As Button
    Friend WithEvents Logout As Label
    Friend WithEvents Registerlink As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Car_ShowroomADataSet As Car_ShowroomADataSet
    Friend WithEvents InventoryStatusBindingSource As BindingSource
    Friend WithEvents InventoryStatusTableAdapter As Car_ShowroomADataSetTableAdapters.InventoryStatusTableAdapter
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Car_InventoryGB As GroupBox
    Friend WithEvents CarIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AvailableCountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaxCapacityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Add_carBtn As Button
    Friend WithEvents Customer_Management As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents noofcars As TextBox
    Friend WithEvents CarIDCB As ComboBox
    Friend WithEvents AddCarBtn As Button
    Friend WithEvents Add_carGB As GroupBox
    Friend WithEvents CarIdTextBox As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents CarNameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents EngineTB As TextBox
    Friend WithEvents MileageTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DriverTypeTB As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents MaxPowerTB As TextBox
    Friend WithEvents SeatingCapacityTB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TransmissionTB As TextBox
    Friend WithEvents FuelTypeTB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DescriptionTB As RichTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents CustReviewlinkTB As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PriceTB As TextBox
    Friend WithEvents CustReviewTB As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents UploadImageButton As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents CarPictureBox As PictureBox
    Friend WithEvents BodyTypeCB As ComboBox
End Class
