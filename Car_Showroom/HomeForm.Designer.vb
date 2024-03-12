<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.Mainpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.HatchbackPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SedanPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SUVPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MUVPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.Sidebar = New System.Windows.Forms.Panel()
        Me.Profile = New System.Windows.Forms.Button()
        Me.MUVbel = New System.Windows.Forms.Button()
        Me.SUVbel = New System.Windows.Forms.Button()
        Me.Sedanbel = New System.Windows.Forms.Button()
        Me.Hatchbackbel = New System.Windows.Forms.Button()
        Me.Allbel = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Label()
        Me.Registerlink = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Mainpanel.SuspendLayout()
        Me.HatchbackPanel.SuspendLayout()
        Me.SedanPanel.SuspendLayout()
        Me.SUVPanel.SuspendLayout()
        Me.MUVPanel.SuspendLayout()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mainpanel
        '
        Me.Mainpanel.AutoScroll = True
        Me.Mainpanel.Controls.Add(Me.HatchbackPanel)
        Me.Mainpanel.Controls.Add(Me.SedanPanel)
        Me.Mainpanel.Controls.Add(Me.SUVPanel)
        Me.Mainpanel.Controls.Add(Me.MUVPanel)
        Me.Mainpanel.Location = New System.Drawing.Point(201, 37)
        Me.Mainpanel.Name = "Mainpanel"
        Me.Mainpanel.Size = New System.Drawing.Size(780, 507)
        Me.Mainpanel.TabIndex = 43
        '
        'HatchbackPanel
        '
        Me.HatchbackPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.HatchbackPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HatchbackPanel.Controls.Add(Me.GroupBox1)
        Me.HatchbackPanel.Location = New System.Drawing.Point(3, 3)
        Me.HatchbackPanel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.HatchbackPanel.Name = "HatchbackPanel"
        Me.HatchbackPanel.Size = New System.Drawing.Size(752, 456)
        Me.HatchbackPanel.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Size = New System.Drawing.Size(698, 20)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hatchback"
        '
        'SedanPanel
        '
        Me.SedanPanel.AutoScroll = True
        Me.SedanPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.SedanPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SedanPanel.Controls.Add(Me.GroupBox2)
        Me.SedanPanel.Location = New System.Drawing.Point(3, 487)
        Me.SedanPanel.Margin = New System.Windows.Forms.Padding(3, 13, 3, 15)
        Me.SedanPanel.Name = "SedanPanel"
        Me.SedanPanel.Size = New System.Drawing.Size(752, 456)
        Me.SedanPanel.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox2.Size = New System.Drawing.Size(698, 20)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sedan"
        '
        'SUVPanel
        '
        Me.SUVPanel.AutoScroll = True
        Me.SUVPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.SUVPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SUVPanel.Controls.Add(Me.GroupBox3)
        Me.SUVPanel.Location = New System.Drawing.Point(3, 971)
        Me.SUVPanel.Margin = New System.Windows.Forms.Padding(3, 13, 3, 15)
        Me.SUVPanel.Name = "SUVPanel"
        Me.SUVPanel.Size = New System.Drawing.Size(752, 456)
        Me.SUVPanel.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox3.Size = New System.Drawing.Size(698, 20)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SUV"
        '
        'MUVPanel
        '
        Me.MUVPanel.AutoScroll = True
        Me.MUVPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.MUVPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MUVPanel.Controls.Add(Me.GroupBox4)
        Me.MUVPanel.Location = New System.Drawing.Point(3, 1455)
        Me.MUVPanel.Margin = New System.Windows.Forms.Padding(3, 13, 3, 15)
        Me.MUVPanel.Name = "MUVPanel"
        Me.MUVPanel.Size = New System.Drawing.Size(752, 456)
        Me.MUVPanel.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox4.Size = New System.Drawing.Size(698, 20)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MUV"
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.Red
        Me.Exit_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.ForeColor = System.Drawing.Color.White
        Me.Exit_btn.Location = New System.Drawing.Point(953, 9)
        Me.Exit_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(28, 26)
        Me.Exit_btn.TabIndex = 42
        Me.Exit_btn.Text = "X"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Sidebar.BackgroundImage = CType(resources.GetObject("Sidebar.BackgroundImage"), System.Drawing.Image)
        Me.Sidebar.Controls.Add(Me.Profile)
        Me.Sidebar.Controls.Add(Me.MUVbel)
        Me.Sidebar.Controls.Add(Me.SUVbel)
        Me.Sidebar.Controls.Add(Me.Sedanbel)
        Me.Sidebar.Controls.Add(Me.Hatchbackbel)
        Me.Sidebar.Controls.Add(Me.Allbel)
        Me.Sidebar.Controls.Add(Me.Logout)
        Me.Sidebar.Controls.Add(Me.Registerlink)
        Me.Sidebar.Controls.Add(Me.PictureBox1)
        Me.Sidebar.Controls.Add(Me.PictureBox2)
        Me.Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(194, 571)
        Me.Sidebar.TabIndex = 41
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
        'MUVbel
        '
        Me.MUVbel.BackColor = System.Drawing.Color.Transparent
        Me.MUVbel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MUVbel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MUVbel.ForeColor = System.Drawing.Color.White
        Me.MUVbel.Location = New System.Drawing.Point(0, 321)
        Me.MUVbel.Name = "MUVbel"
        Me.MUVbel.Size = New System.Drawing.Size(194, 36)
        Me.MUVbel.TabIndex = 20
        Me.MUVbel.Text = "MUV"
        Me.MUVbel.UseVisualStyleBackColor = False
        '
        'SUVbel
        '
        Me.SUVbel.BackColor = System.Drawing.Color.Transparent
        Me.SUVbel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SUVbel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SUVbel.ForeColor = System.Drawing.Color.White
        Me.SUVbel.Location = New System.Drawing.Point(0, 279)
        Me.SUVbel.Name = "SUVbel"
        Me.SUVbel.Size = New System.Drawing.Size(194, 36)
        Me.SUVbel.TabIndex = 19
        Me.SUVbel.Text = "SUV"
        Me.SUVbel.UseVisualStyleBackColor = False
        '
        'Sedanbel
        '
        Me.Sedanbel.BackColor = System.Drawing.Color.Transparent
        Me.Sedanbel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Sedanbel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Sedanbel.ForeColor = System.Drawing.Color.White
        Me.Sedanbel.Location = New System.Drawing.Point(0, 237)
        Me.Sedanbel.Name = "Sedanbel"
        Me.Sedanbel.Size = New System.Drawing.Size(194, 36)
        Me.Sedanbel.TabIndex = 18
        Me.Sedanbel.Text = "Sedan"
        Me.Sedanbel.UseVisualStyleBackColor = False
        '
        'Hatchbackbel
        '
        Me.Hatchbackbel.BackColor = System.Drawing.Color.Transparent
        Me.Hatchbackbel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Hatchbackbel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Hatchbackbel.ForeColor = System.Drawing.Color.White
        Me.Hatchbackbel.Location = New System.Drawing.Point(0, 195)
        Me.Hatchbackbel.Name = "Hatchbackbel"
        Me.Hatchbackbel.Size = New System.Drawing.Size(194, 36)
        Me.Hatchbackbel.TabIndex = 17
        Me.Hatchbackbel.Text = "Hatchback"
        Me.Hatchbackbel.UseVisualStyleBackColor = False
        '
        'Allbel
        '
        Me.Allbel.BackColor = System.Drawing.Color.Transparent
        Me.Allbel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Allbel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Allbel.ForeColor = System.Drawing.Color.White
        Me.Allbel.Location = New System.Drawing.Point(0, 153)
        Me.Allbel.Name = "Allbel"
        Me.Allbel.Size = New System.Drawing.Size(194, 36)
        Me.Allbel.TabIndex = 16
        Me.Allbel.Text = "All"
        Me.Allbel.UseVisualStyleBackColor = False
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
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(987, 566)
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.Mainpanel)
        Me.Controls.Add(Me.Exit_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Testing"
        Me.Mainpanel.ResumeLayout(False)
        Me.HatchbackPanel.ResumeLayout(False)
        Me.SedanPanel.ResumeLayout(False)
        Me.SUVPanel.ResumeLayout(False)
        Me.MUVPanel.ResumeLayout(False)
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Sidebar As Panel
    Friend WithEvents Profile As Button
    Friend WithEvents MUVbel As Button
    Friend WithEvents SUVbel As Button
    Friend WithEvents Sedanbel As Button
    Friend WithEvents Hatchbackbel As Button
    Friend WithEvents Allbel As Button
    Friend WithEvents Logout As Label
    Friend WithEvents Registerlink As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Mainpanel As FlowLayoutPanel
    Friend WithEvents Exit_btn As Button
    Friend WithEvents HatchbackPanel As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SedanPanel As FlowLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SUVPanel As FlowLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MUVPanel As FlowLayoutPanel
    Friend WithEvents GroupBox4 As GroupBox
End Class
