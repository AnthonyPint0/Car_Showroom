<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Login))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.Clear_user_btn = New System.Windows.Forms.Button()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.Login_btn = New System.Windows.Forms.Button()
        Me.Password_txt = New System.Windows.Forms.TextBox()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.guestL = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!)
        Me.Label4.Location = New System.Drawing.Point(552, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 27)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Admin Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(598, 244)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Show Password"
        '
        'ShowPasswordCheckBox
        '
        Me.ShowPasswordCheckBox.AutoSize = True
        Me.ShowPasswordCheckBox.Location = New System.Drawing.Point(702, 244)
        Me.ShowPasswordCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        Me.ShowPasswordCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ShowPasswordCheckBox.TabIndex = 19
        Me.ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'Clear_user_btn
        '
        Me.Clear_user_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Clear_user_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_user_btn.ForeColor = System.Drawing.Color.White
        Me.Clear_user_btn.Location = New System.Drawing.Point(648, 357)
        Me.Clear_user_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Clear_user_btn.Name = "Clear_user_btn"
        Me.Clear_user_btn.Size = New System.Drawing.Size(99, 32)
        Me.Clear_user_btn.TabIndex = 18
        Me.Clear_user_btn.Text = "Clear"
        Me.Clear_user_btn.UseVisualStyleBackColor = False
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.Red
        Me.Exit_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.ForeColor = System.Drawing.Color.White
        Me.Exit_btn.Location = New System.Drawing.Point(777, 23)
        Me.Exit_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(28, 26)
        Me.Exit_btn.TabIndex = 17
        Me.Exit_btn.Text = "X"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'Login_btn
        '
        Me.Login_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Login_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_btn.ForeColor = System.Drawing.Color.White
        Me.Login_btn.Location = New System.Drawing.Point(516, 357)
        Me.Login_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Login_btn.Name = "Login_btn"
        Me.Login_btn.Size = New System.Drawing.Size(83, 32)
        Me.Login_btn.TabIndex = 16
        Me.Login_btn.Text = "Login"
        Me.Login_btn.UseVisualStyleBackColor = False
        '
        'Password_txt
        '
        Me.Password_txt.Location = New System.Drawing.Point(536, 267)
        Me.Password_txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Password_txt.Name = "Password_txt"
        Me.Password_txt.Size = New System.Drawing.Size(182, 20)
        Me.Password_txt.TabIndex = 15
        '
        'username_txt
        '
        Me.username_txt.Location = New System.Drawing.Point(536, 171)
        Me.username_txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(182, 20)
        Me.username_txt.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(445, 271)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(445, 171)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Username"
        '
        'guestL
        '
        Me.guestL.AutoSize = True
        Me.guestL.BackColor = System.Drawing.Color.Transparent
        Me.guestL.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.guestL.LinkColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.guestL.Location = New System.Drawing.Point(695, 444)
        Me.guestL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.guestL.Name = "guestL"
        Me.guestL.Size = New System.Drawing.Size(107, 17)
        Me.guestL.TabIndex = 22
        Me.guestL.TabStop = True
        Me.guestL.Text = "Customer Login"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 480)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(40, 246)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(315, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 115)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Admin_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(828, 477)
        Me.Controls.Add(Me.guestL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShowPasswordCheckBox)
        Me.Controls.Add(Me.Clear_user_btn)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Login_btn)
        Me.Controls.Add(Me.Password_txt)
        Me.Controls.Add(Me.username_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ShowPasswordCheckBox As CheckBox
    Friend WithEvents Clear_user_btn As Button
    Friend WithEvents Exit_btn As Button
    Friend WithEvents Login_btn As Button
    Friend WithEvents Password_txt As TextBox
    Friend WithEvents username_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents guestL As LinkLabel
End Class
