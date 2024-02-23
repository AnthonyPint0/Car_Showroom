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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Mainform))
        Me.Mainpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.Sidebar = New System.Windows.Forms.Panel()
        Me.Profile = New System.Windows.Forms.Button()
        Me.Settings = New System.Windows.Forms.Button()
        Me.Employee_Management = New System.Windows.Forms.Button()
        Me.Sales_Reports = New System.Windows.Forms.Button()
        Me.Customer_Management = New System.Windows.Forms.Button()
        Me.Car_Inventory = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Label()
        Me.Registerlink = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mainpanel
        '
        Me.Mainpanel.AutoScroll = True
        Me.Mainpanel.BackColor = System.Drawing.Color.White
        Me.Mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mainpanel.Location = New System.Drawing.Point(213, 52)
        Me.Mainpanel.Name = "Mainpanel"
        Me.Mainpanel.Size = New System.Drawing.Size(740, 501)
        Me.Mainpanel.TabIndex = 43
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.Red
        Me.Exit_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.ForeColor = System.Drawing.Color.White
        Me.Exit_btn.Location = New System.Drawing.Point(949, 7)
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
        Me.Sidebar.Controls.Add(Me.Settings)
        Me.Sidebar.Controls.Add(Me.Employee_Management)
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
        'Settings
        '
        Me.Settings.BackColor = System.Drawing.Color.Transparent
        Me.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Settings.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Settings.ForeColor = System.Drawing.Color.White
        Me.Settings.Location = New System.Drawing.Point(0, 359)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(194, 36)
        Me.Settings.TabIndex = 20
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = False
        '
        'Employee_Management
        '
        Me.Employee_Management.BackColor = System.Drawing.Color.Transparent
        Me.Employee_Management.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Employee_Management.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Employee_Management.ForeColor = System.Drawing.Color.White
        Me.Employee_Management.Location = New System.Drawing.Point(0, 311)
        Me.Employee_Management.Name = "Employee_Management"
        Me.Employee_Management.Size = New System.Drawing.Size(194, 36)
        Me.Employee_Management.TabIndex = 19
        Me.Employee_Management.Text = "Employee Management"
        Me.Employee_Management.UseVisualStyleBackColor = False
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
        Me.Customer_Management.Location = New System.Drawing.Point(0, 199)
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
        'Admin_Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(983, 570)
        Me.Controls.Add(Me.Mainpanel)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Mainform"
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Mainpanel As FlowLayoutPanel
    Friend WithEvents Exit_btn As Button
    Friend WithEvents Sidebar As Panel
    Friend WithEvents Profile As Button
    Friend WithEvents Settings As Button
    Friend WithEvents Employee_Management As Button
    Friend WithEvents Sales_Reports As Button
    Friend WithEvents Customer_Management As Button
    Friend WithEvents Car_Inventory As Button
    Friend WithEvents Logout As Label
    Friend WithEvents Registerlink As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
