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
        Me.InventoryStatusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShowroonDataSet = New Car_Showroom.ShowroonDataSet()
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
        Me.CustomerGB = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Remove_user_btn = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesRepertGB = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cart = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Ordered = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Delivered = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovedOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderHistoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Car_Showroom.Car_ShowroomADataSetTableAdapters.CustomerTableAdapter()
        Me.OrderHistoryTableAdapter = New Car_Showroom.Car_ShowroomADataSetTableAdapters.OrderHistoryTableAdapter()
        Me.InventoryStatusTableAdapter1 = New Car_Showroom.ShowroonDataSetTableAdapters.InventoryStatusTableAdapter()
        Me.CustomerTableAdapter1 = New Car_Showroom.ShowroonDataSetTableAdapters.CustomerTableAdapter()
        Me.OrderHistoryTableAdapter1 = New Car_Showroom.ShowroonDataSetTableAdapters.OrderHistoryTableAdapter()
        Me.Car_WashDataSet = New Car_Showroom.Car_WashDataSet()
        Me.InventoryStatusBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryStatusTableAdapter2 = New Car_Showroom.Car_WashDataSetTableAdapters.InventoryStatusTableAdapter()
        Me.CustomerBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter2 = New Car_Showroom.Car_WashDataSetTableAdapters.CustomerTableAdapter()
        Me.OrderHistoryBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderHistoryTableAdapter2 = New Car_Showroom.Car_WashDataSetTableAdapters.OrderHistoryTableAdapter()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryStatusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowroonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car_ShowroomADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Car_InventoryGB.SuspendLayout()
        Me.Add_carGB.SuspendLayout()
        CType(Me.CarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerGB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesRepertGB.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderHistoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car_WashDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryStatusBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderHistoryBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.Red
        Me.Exit_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.ForeColor = System.Drawing.Color.White
        Me.Exit_btn.Location = New System.Drawing.Point(1256, 15)
        Me.Exit_btn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(37, 32)
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
        Me.Sidebar.Location = New System.Drawing.Point(-3, 0)
        Me.Sidebar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(259, 703)
        Me.Sidebar.TabIndex = 41
        '
        'Profile
        '
        Me.Profile.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Profile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Profile.ForeColor = System.Drawing.Color.White
        Me.Profile.Location = New System.Drawing.Point(5, 625)
        Me.Profile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Profile.Name = "Profile"
        Me.Profile.Size = New System.Drawing.Size(251, 44)
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
        Me.Add_carBtn.Location = New System.Drawing.Point(1, 257)
        Me.Add_carBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Add_carBtn.Name = "Add_carBtn"
        Me.Add_carBtn.Size = New System.Drawing.Size(259, 44)
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
        Me.Sales_Reports.Location = New System.Drawing.Point(0, 322)
        Me.Sales_Reports.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sales_Reports.Name = "Sales_Reports"
        Me.Sales_Reports.Size = New System.Drawing.Size(259, 44)
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
        Me.Customer_Management.Location = New System.Drawing.Point(1, 396)
        Me.Customer_Management.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Customer_Management.Name = "Customer_Management"
        Me.Customer_Management.Size = New System.Drawing.Size(259, 68)
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
        Me.Car_Inventory.Location = New System.Drawing.Point(0, 188)
        Me.Car_Inventory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Car_Inventory.Name = "Car_Inventory"
        Me.Car_Inventory.Size = New System.Drawing.Size(259, 44)
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
        Me.Logout.Location = New System.Drawing.Point(97, 571)
        Me.Logout.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(84, 28)
        Me.Logout.TabIndex = 15
        Me.Logout.Text = "Log out"
        '
        'Registerlink
        '
        Me.Registerlink.AutoSize = True
        Me.Registerlink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Registerlink.Location = New System.Drawing.Point(41, 635)
        Me.Registerlink.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Registerlink.Name = "Registerlink"
        Me.Registerlink.Size = New System.Drawing.Size(160, 16)
        Me.Registerlink.TabIndex = 7
        Me.Registerlink.TabStop = True
        Me.Registerlink.Text = "New User? Register Now!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(19, 110)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(217, 63)
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
        Me.DataGridView1.DataSource = Me.InventoryStatusBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(8, 30)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(889, 443)
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
        'InventoryStatusBindingSource1
        '
        Me.InventoryStatusBindingSource1.DataMember = "InventoryStatus"
        Me.InventoryStatusBindingSource1.DataSource = Me.ShowroonDataSet
        '
        'ShowroonDataSet
        '
        Me.ShowroonDataSet.DataSetName = "ShowroonDataSet"
        Me.ShowroonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.FlowLayoutPanel1.Controls.Add(Me.CustomerGB)
        Me.FlowLayoutPanel1.Controls.Add(Me.SalesRepertGB)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(265, 38)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(995, 624)
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
        Me.Car_InventoryGB.Location = New System.Drawing.Point(4, 4)
        Me.Car_InventoryGB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 31)
        Me.Car_InventoryGB.Name = "Car_InventoryGB"
        Me.Car_InventoryGB.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Car_InventoryGB.Size = New System.Drawing.Size(963, 577)
        Me.Car_InventoryGB.TabIndex = 4
        Me.Car_InventoryGB.TabStop = False
        Me.Car_InventoryGB.Text = "Car Inventory"
        '
        'AddCarBtn
        '
        Me.AddCarBtn.BackColor = System.Drawing.Color.Green
        Me.AddCarBtn.ForeColor = System.Drawing.Color.White
        Me.AddCarBtn.Location = New System.Drawing.Point(743, 513)
        Me.AddCarBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddCarBtn.Name = "AddCarBtn"
        Me.AddCarBtn.Size = New System.Drawing.Size(120, 53)
        Me.AddCarBtn.TabIndex = 26
        Me.AddCarBtn.Text = "Add Car"
        Me.AddCarBtn.UseVisualStyleBackColor = False
        '
        'noofcars
        '
        Me.noofcars.Location = New System.Drawing.Point(371, 539)
        Me.noofcars.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.noofcars.Name = "noofcars"
        Me.noofcars.Size = New System.Drawing.Size(76, 29)
        Me.noofcars.TabIndex = 25
        '
        'CarIDCB
        '
        Me.CarIDCB.FormattingEnabled = True
        Me.CarIDCB.Location = New System.Drawing.Point(16, 535)
        Me.CarIDCB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CarIDCB.Name = "CarIDCB"
        Me.CarIDCB.Size = New System.Drawing.Size(160, 30)
        Me.CarIDCB.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(367, 512)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. of Cars"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 512)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CarID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 480)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 22)
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
        Me.Add_carGB.Location = New System.Drawing.Point(4, 616)
        Me.Add_carGB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 31)
        Me.Add_carGB.Name = "Add_carGB"
        Me.Add_carGB.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Add_carGB.Size = New System.Drawing.Size(941, 577)
        Me.Add_carGB.TabIndex = 5
        Me.Add_carGB.TabStop = False
        Me.Add_carGB.Text = "Add New Car"
        '
        'BodyTypeCB
        '
        Me.BodyTypeCB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.BodyTypeCB.FormattingEnabled = True
        Me.BodyTypeCB.Location = New System.Drawing.Point(696, 454)
        Me.BodyTypeCB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BodyTypeCB.Name = "BodyTypeCB"
        Me.BodyTypeCB.Size = New System.Drawing.Size(200, 25)
        Me.BodyTypeCB.TabIndex = 55
        '
        'CarPictureBox
        '
        Me.CarPictureBox.Location = New System.Drawing.Point(183, 464)
        Me.CarPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CarPictureBox.Name = "CarPictureBox"
        Me.CarPictureBox.Size = New System.Drawing.Size(193, 102)
        Me.CarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarPictureBox.TabIndex = 54
        Me.CarPictureBox.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(12, 460)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(152, 38)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "*Image Name must " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "be Same as CarID"
        '
        'UploadImageButton
        '
        Me.UploadImageButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UploadImageButton.ForeColor = System.Drawing.Color.Black
        Me.UploadImageButton.Location = New System.Drawing.Point(8, 511)
        Me.UploadImageButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UploadImageButton.Name = "UploadImageButton"
        Me.UploadImageButton.Size = New System.Drawing.Size(155, 42)
        Me.UploadImageButton.TabIndex = 52
        Me.UploadImageButton.Text = "Upload Image"
        Me.UploadImageButton.UseVisualStyleBackColor = False
        '
        'DescriptionTB
        '
        Me.DescriptionTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DescriptionTB.Location = New System.Drawing.Point(147, 338)
        Me.DescriptionTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DescriptionTB.Name = "DescriptionTB"
        Me.DescriptionTB.Size = New System.Drawing.Size(315, 117)
        Me.DescriptionTB.TabIndex = 51
        Me.DescriptionTB.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 340)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 19)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Description"
        '
        'CustReviewlinkTB
        '
        Me.CustReviewlinkTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CustReviewlinkTB.Location = New System.Drawing.Point(147, 278)
        Me.CustReviewlinkTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CustReviewlinkTB.Name = "CustReviewlinkTB"
        Me.CustReviewlinkTB.Size = New System.Drawing.Size(200, 25)
        Me.CustReviewlinkTB.TabIndex = 49
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 284)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 19)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "CustReviewLink"
        '
        'PriceTB
        '
        Me.PriceTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.PriceTB.Location = New System.Drawing.Point(147, 155)
        Me.PriceTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PriceTB.Name = "PriceTB"
        Me.PriceTB.Size = New System.Drawing.Size(200, 25)
        Me.PriceTB.TabIndex = 47
        '
        'CustReviewTB
        '
        Me.CustReviewTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CustReviewTB.Location = New System.Drawing.Point(147, 215)
        Me.CustReviewTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CustReviewTB.Name = "CustReviewTB"
        Me.CustReviewTB.Size = New System.Drawing.Size(200, 25)
        Me.CustReviewTB.TabIndex = 46
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 222)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 19)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "CustReview"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(55, 164)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 19)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Price"
        '
        'DriverTypeTB
        '
        Me.DriverTypeTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DriverTypeTB.Location = New System.Drawing.Point(696, 396)
        Me.DriverTypeTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DriverTypeTB.Name = "DriverTypeTB"
        Me.DriverTypeTB.Size = New System.Drawing.Size(200, 25)
        Me.DriverTypeTB.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(581, 459)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 19)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Body Type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(579, 401)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 19)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Driver Type"
        '
        'MaxPowerTB
        '
        Me.MaxPowerTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.MaxPowerTB.Location = New System.Drawing.Point(696, 273)
        Me.MaxPowerTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaxPowerTB.Name = "MaxPowerTB"
        Me.MaxPowerTB.Size = New System.Drawing.Size(200, 25)
        Me.MaxPowerTB.TabIndex = 39
        '
        'SeatingCapacityTB
        '
        Me.SeatingCapacityTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.SeatingCapacityTB.Location = New System.Drawing.Point(696, 334)
        Me.SeatingCapacityTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SeatingCapacityTB.Name = "SeatingCapacityTB"
        Me.SeatingCapacityTB.Size = New System.Drawing.Size(200, 25)
        Me.SeatingCapacityTB.TabIndex = 38
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(531, 336)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 19)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Seating Capacity"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(576, 278)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 19)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Max Power"
        '
        'TransmissionTB
        '
        Me.TransmissionTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TransmissionTB.Location = New System.Drawing.Point(696, 159)
        Me.TransmissionTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TransmissionTB.Name = "TransmissionTB"
        Me.TransmissionTB.Size = New System.Drawing.Size(200, 25)
        Me.TransmissionTB.TabIndex = 35
        '
        'FuelTypeTB
        '
        Me.FuelTypeTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.FuelTypeTB.Location = New System.Drawing.Point(696, 219)
        Me.FuelTypeTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FuelTypeTB.Name = "FuelTypeTB"
        Me.FuelTypeTB.Size = New System.Drawing.Size(200, 25)
        Me.FuelTypeTB.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(588, 222)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Fuel Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(560, 164)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 19)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Transmission"
        '
        'EngineTB
        '
        Me.EngineTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.EngineTB.Location = New System.Drawing.Point(696, 36)
        Me.EngineTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EngineTB.Name = "EngineTB"
        Me.EngineTB.Size = New System.Drawing.Size(200, 25)
        Me.EngineTB.TabIndex = 31
        '
        'MileageTB
        '
        Me.MileageTB.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.MileageTB.Location = New System.Drawing.Point(696, 96)
        Me.MileageTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MileageTB.Name = "MileageTB"
        Me.MileageTB.Size = New System.Drawing.Size(200, 25)
        Me.MileageTB.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(603, 98)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 19)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Mileage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(609, 41)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Engine"
        '
        'CarIdTextBox
        '
        Me.CarIdTextBox.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CarIdTextBox.Location = New System.Drawing.Point(147, 42)
        Me.CarIdTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CarIdTextBox.Name = "CarIdTextBox"
        Me.CarIdTextBox.Size = New System.Drawing.Size(200, 25)
        Me.CarIdTextBox.TabIndex = 27
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.Green
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Location = New System.Drawing.Point(743, 513)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(120, 53)
        Me.SaveButton.TabIndex = 26
        Me.SaveButton.Text = "Add Car"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'CarNameTextBox
        '
        Me.CarNameTextBox.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarNameTextBox.Location = New System.Drawing.Point(147, 102)
        Me.CarNameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CarNameTextBox.Name = "CarNameTextBox"
        Me.CarNameTextBox.Size = New System.Drawing.Size(200, 25)
        Me.CarNameTextBox.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Car Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 50)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "CarID"
        '
        'CustomerGB
        '
        Me.CustomerGB.BackColor = System.Drawing.Color.White
        Me.CustomerGB.Controls.Add(Me.GroupBox1)
        Me.CustomerGB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerGB.Location = New System.Drawing.Point(4, 1228)
        Me.CustomerGB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 31)
        Me.CustomerGB.Name = "CustomerGB"
        Me.CustomerGB.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CustomerGB.Size = New System.Drawing.Size(963, 608)
        Me.CustomerGB.TabIndex = 6
        Me.CustomerGB.TabStop = False
        Me.CustomerGB.Text = "Customer Management"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Remove_user_btn)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(947, 570)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Remove_user_btn
        '
        Me.Remove_user_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Remove_user_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remove_user_btn.ForeColor = System.Drawing.Color.White
        Me.Remove_user_btn.Location = New System.Drawing.Point(803, 530)
        Me.Remove_user_btn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Remove_user_btn.Name = "Remove_user_btn"
        Me.Remove_user_btn.Size = New System.Drawing.Size(132, 39)
        Me.Remove_user_btn.TabIndex = 19
        Me.Remove_user_btn.Text = "Remove"
        Me.Remove_user_btn.UseVisualStyleBackColor = False
        Me.Remove_user_btn.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.RegistrationDateDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.CustomerBindingSource2
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(935, 524)
        Me.DataGridView2.TabIndex = 1
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 70
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Width = 70
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Width = 70
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 150
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 170
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        Me.ContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContactNumberDataGridViewTextBoxColumn.Width = 120
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.Width = 70
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.Width = 70
        '
        'RegistrationDateDataGridViewTextBoxColumn
        '
        Me.RegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate"
        Me.RegistrationDateDataGridViewTextBoxColumn.HeaderText = "RegistrationDate"
        Me.RegistrationDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RegistrationDateDataGridViewTextBoxColumn.Name = "RegistrationDateDataGridViewTextBoxColumn"
        Me.RegistrationDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.RegistrationDateDataGridViewTextBoxColumn.Width = 120
        '
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "Customer"
        Me.CustomerBindingSource1.DataSource = Me.ShowroonDataSet
        '
        'SalesRepertGB
        '
        Me.SalesRepertGB.BackColor = System.Drawing.Color.White
        Me.SalesRepertGB.Controls.Add(Me.GroupBox3)
        Me.SalesRepertGB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesRepertGB.Location = New System.Drawing.Point(4, 1871)
        Me.SalesRepertGB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 31)
        Me.SalesRepertGB.Name = "SalesRepertGB"
        Me.SalesRepertGB.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SalesRepertGB.Size = New System.Drawing.Size(963, 577)
        Me.SalesRepertGB.TabIndex = 7
        Me.SalesRepertGB.TabStop = False
        Me.SalesRepertGB.Text = "Sales Report"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView3)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 31)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(947, 539)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.CustomerID, Me.Username, Me.Price, Me.Cart, Me.Ordered, Me.Delivered, Me.Status, Me.MovedOn})
        Me.DataGridView3.DataSource = Me.OrderHistoryBindingSource2
        Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.Size = New System.Drawing.Size(935, 524)
        Me.DataGridView3.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OrderID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "OrderID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 55
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CarID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CarID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'CustomerID
        '
        Me.CustomerID.DataPropertyName = "CustomerID"
        Me.CustomerID.HeaderText = "CustomerID"
        Me.CustomerID.MinimumWidth = 6
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.ReadOnly = True
        Me.CustomerID.Width = 70
        '
        'Username
        '
        Me.Username.DataPropertyName = "Username"
        Me.Username.HeaderText = "Username"
        Me.Username.MinimumWidth = 6
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        Me.Username.Width = 70
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 70
        '
        'Cart
        '
        Me.Cart.DataPropertyName = "Cart"
        Me.Cart.HeaderText = "Cart"
        Me.Cart.MinimumWidth = 6
        Me.Cart.Name = "Cart"
        Me.Cart.ReadOnly = True
        Me.Cart.Width = 30
        '
        'Ordered
        '
        Me.Ordered.DataPropertyName = "Ordered"
        Me.Ordered.HeaderText = "Ordered"
        Me.Ordered.MinimumWidth = 6
        Me.Ordered.Name = "Ordered"
        Me.Ordered.ReadOnly = True
        Me.Ordered.Width = 60
        '
        'Delivered
        '
        Me.Delivered.DataPropertyName = "Delivered"
        Me.Delivered.HeaderText = "Delivered"
        Me.Delivered.MinimumWidth = 6
        Me.Delivered.Name = "Delivered"
        Me.Delivered.ReadOnly = True
        Me.Delivered.Width = 60
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 70
        '
        'MovedOn
        '
        Me.MovedOn.DataPropertyName = "MovedOn"
        Me.MovedOn.HeaderText = "MovedOn"
        Me.MovedOn.MinimumWidth = 6
        Me.MovedOn.Name = "MovedOn"
        Me.MovedOn.ReadOnly = True
        Me.MovedOn.Width = 125
        '
        'OrderHistoryBindingSource1
        '
        Me.OrderHistoryBindingSource1.DataMember = "OrderHistory"
        Me.OrderHistoryBindingSource1.DataSource = Me.ShowroonDataSet
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Car_ShowroomADataSet
        '
        'OrderHistoryBindingSource
        '
        Me.OrderHistoryBindingSource.DataMember = "OrderHistory"
        Me.OrderHistoryBindingSource.DataSource = Me.Car_ShowroomADataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'OrderHistoryTableAdapter
        '
        Me.OrderHistoryTableAdapter.ClearBeforeFill = True
        '
        'InventoryStatusTableAdapter1
        '
        Me.InventoryStatusTableAdapter1.ClearBeforeFill = True
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'OrderHistoryTableAdapter1
        '
        Me.OrderHistoryTableAdapter1.ClearBeforeFill = True
        '
        'Car_WashDataSet
        '
        Me.Car_WashDataSet.DataSetName = "Car_WashDataSet"
        Me.Car_WashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryStatusBindingSource2
        '
        Me.InventoryStatusBindingSource2.DataMember = "InventoryStatus"
        Me.InventoryStatusBindingSource2.DataSource = Me.Car_WashDataSet
        '
        'InventoryStatusTableAdapter2
        '
        Me.InventoryStatusTableAdapter2.ClearBeforeFill = True
        '
        'CustomerBindingSource2
        '
        Me.CustomerBindingSource2.DataMember = "Customer"
        Me.CustomerBindingSource2.DataSource = Me.Car_WashDataSet
        '
        'CustomerTableAdapter2
        '
        Me.CustomerTableAdapter2.ClearBeforeFill = True
        '
        'OrderHistoryBindingSource2
        '
        Me.OrderHistoryBindingSource2.DataMember = "OrderHistory"
        Me.OrderHistoryBindingSource2.DataSource = Me.Car_WashDataSet
        '
        'OrderHistoryTableAdapter2
        '
        Me.OrderHistoryTableAdapter2.ClearBeforeFill = True
        '
        'Admin_Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1311, 703)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Admin_Mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Mainform"
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryStatusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowroonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car_ShowroomADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Car_InventoryGB.ResumeLayout(False)
        Me.Car_InventoryGB.PerformLayout()
        Me.Add_carGB.ResumeLayout(False)
        Me.Add_carGB.PerformLayout()
        CType(Me.CarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerGB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesRepertGB.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderHistoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car_WashDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryStatusBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderHistoryBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CustomerGB As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As Car_ShowroomADataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegistrationDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesRepertGB As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents OrderHistoryBindingSource As BindingSource
    Friend WithEvents OrderHistoryTableAdapter As Car_ShowroomADataSetTableAdapters.OrderHistoryTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Cart As DataGridViewCheckBoxColumn
    Friend WithEvents Ordered As DataGridViewCheckBoxColumn
    Friend WithEvents Delivered As DataGridViewCheckBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents MovedOn As DataGridViewTextBoxColumn
    Friend WithEvents Remove_user_btn As Button
    Friend WithEvents ShowroonDataSet As ShowroonDataSet
    Friend WithEvents InventoryStatusBindingSource1 As BindingSource
    Friend WithEvents InventoryStatusTableAdapter1 As ShowroonDataSetTableAdapters.InventoryStatusTableAdapter
    Friend WithEvents CustomerBindingSource1 As BindingSource
    Friend WithEvents CustomerTableAdapter1 As ShowroonDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents OrderHistoryBindingSource1 As BindingSource
    Friend WithEvents OrderHistoryTableAdapter1 As ShowroonDataSetTableAdapters.OrderHistoryTableAdapter
    Friend WithEvents Car_WashDataSet As Car_WashDataSet
    Friend WithEvents InventoryStatusBindingSource2 As BindingSource
    Friend WithEvents InventoryStatusTableAdapter2 As Car_WashDataSetTableAdapters.InventoryStatusTableAdapter
    Friend WithEvents CustomerBindingSource2 As BindingSource
    Friend WithEvents CustomerTableAdapter2 As Car_WashDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents OrderHistoryBindingSource2 As BindingSource
    Friend WithEvents OrderHistoryTableAdapter2 As Car_WashDataSetTableAdapters.OrderHistoryTableAdapter
End Class
