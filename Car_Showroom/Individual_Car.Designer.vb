<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Individual_Car
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Individual_Car))
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.Sidebar = New System.Windows.Forms.Panel()
        Me.Login_info1 = New System.Windows.Forms.Button()
        Me.MPVbel = New System.Windows.Forms.Button()
        Me.MUVbel = New System.Windows.Forms.Button()
        Me.SUVbel = New System.Windows.Forms.Button()
        Me.Sedanbel = New System.Windows.Forms.Button()
        Me.Hatchbackbel = New System.Windows.Forms.Button()
        Me.Allbel = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Label()
        Me.Registerlink = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.Red
        Me.Exit_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.ForeColor = System.Drawing.Color.White
        Me.Exit_btn.Location = New System.Drawing.Point(950, 12)
        Me.Exit_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(28, 26)
        Me.Exit_btn.TabIndex = 41
        Me.Exit_btn.Text = "X"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Sidebar.BackgroundImage = CType(resources.GetObject("Sidebar.BackgroundImage"), System.Drawing.Image)
        Me.Sidebar.Controls.Add(Me.Login_info1)
        Me.Sidebar.Controls.Add(Me.MPVbel)
        Me.Sidebar.Controls.Add(Me.MUVbel)
        Me.Sidebar.Controls.Add(Me.SUVbel)
        Me.Sidebar.Controls.Add(Me.Sedanbel)
        Me.Sidebar.Controls.Add(Me.Hatchbackbel)
        Me.Sidebar.Controls.Add(Me.Allbel)
        Me.Sidebar.Controls.Add(Me.Logout)
        Me.Sidebar.Controls.Add(Me.Registerlink)
        Me.Sidebar.Controls.Add(Me.PictureBox1)
        Me.Sidebar.Controls.Add(Me.PictureBox2)
        Me.Sidebar.Location = New System.Drawing.Point(0, -1)
        Me.Sidebar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(194, 571)
        Me.Sidebar.TabIndex = 40
        '
        'Login_info1
        '
        Me.Login_info1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Login_info1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Login_info1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Login_info1.ForeColor = System.Drawing.Color.White
        Me.Login_info1.Location = New System.Drawing.Point(4, 508)
        Me.Login_info1.Name = "Login_info1"
        Me.Login_info1.Size = New System.Drawing.Size(188, 36)
        Me.Login_info1.TabIndex = 22
        Me.Login_info1.Text = "Guest"
        Me.Login_info1.UseVisualStyleBackColor = False
        '
        'MPVbel
        '
        Me.MPVbel.BackColor = System.Drawing.Color.Transparent
        Me.MPVbel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MPVbel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MPVbel.ForeColor = System.Drawing.Color.White
        Me.MPVbel.Location = New System.Drawing.Point(0, 363)
        Me.MPVbel.Name = "MPVbel"
        Me.MPVbel.Size = New System.Drawing.Size(194, 36)
        Me.MPVbel.TabIndex = 21
        Me.MPVbel.Text = "MPV"
        Me.MPVbel.UseVisualStyleBackColor = False
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
        'Individual_Car
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 568)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Individual_Car"
        Me.Text = "Form1"
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Exit_btn As Button
    Friend WithEvents Sidebar As Panel
    Friend WithEvents Login_info1 As Button
    Friend WithEvents MPVbel As Button
    Friend WithEvents MUVbel As Button
    Friend WithEvents SUVbel As Button
    Friend WithEvents Sedanbel As Button
    Friend WithEvents Hatchbackbel As Button
    Friend WithEvents Allbel As Button
    Friend WithEvents Logout As Label
    Friend WithEvents Registerlink As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
