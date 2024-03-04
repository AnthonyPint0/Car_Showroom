<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Register))
        Me.Register_btn = New System.Windows.Forms.Button()
        Me.txtBpassword = New System.Windows.Forms.TextBox()
        Me.txtBusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Loginlink = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Back_Btn = New System.Windows.Forms.Button()
        Me.txtBfirstName = New System.Windows.Forms.TextBox()
        Me.txtBlastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBemail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBaddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBcontactNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.guestL = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Register_btn
        '
        Me.Register_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Register_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_btn.ForeColor = System.Drawing.Color.White
        Me.Register_btn.Location = New System.Drawing.Point(486, 367)
        Me.Register_btn.Name = "Register_btn"
        Me.Register_btn.Size = New System.Drawing.Size(83, 32)
        Me.Register_btn.TabIndex = 0
        Me.Register_btn.Text = "Register"
        Me.Register_btn.UseVisualStyleBackColor = False
        '
        'txtBpassword
        '
        Me.txtBpassword.Location = New System.Drawing.Point(552, 320)
        Me.txtBpassword.Name = "txtBpassword"
        Me.txtBpassword.Size = New System.Drawing.Size(157, 20)
        Me.txtBpassword.TabIndex = 13
        '
        'txtBusername
        '
        Me.txtBusername.Location = New System.Drawing.Point(552, 265)
        Me.txtBusername.Name = "txtBusername"
        Me.txtBusername.Size = New System.Drawing.Size(157, 20)
        Me.txtBusername.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(478, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(477, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(604, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Show Password"
        '
        'ShowPasswordCheckBox
        '
        Me.ShowPasswordCheckBox.AutoSize = True
        Me.ShowPasswordCheckBox.Location = New System.Drawing.Point(693, 299)
        Me.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        Me.ShowPasswordCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ShowPasswordCheckBox.TabIndex = 14
        Me.ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Loginlink)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 454)
        Me.Panel1.TabIndex = 16
        '
        'Loginlink
        '
        Me.Loginlink.AutoSize = True
        Me.Loginlink.BackColor = System.Drawing.Color.Transparent
        Me.Loginlink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginlink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Loginlink.Location = New System.Drawing.Point(238, 422)
        Me.Loginlink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Loginlink.Name = "Loginlink"
        Me.Loginlink.Size = New System.Drawing.Size(140, 16)
        Me.Loginlink.TabIndex = 8
        Me.Loginlink.TabStop = True
        Me.Loginlink.Text = "Already a user? Login!"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(34, 227)
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
        Me.PictureBox1.Location = New System.Drawing.Point(34, 96)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Back_Btn
        '
        Me.Back_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Back_Btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_Btn.ForeColor = System.Drawing.Color.White
        Me.Back_Btn.Location = New System.Drawing.Point(626, 367)
        Me.Back_Btn.Name = "Back_Btn"
        Me.Back_Btn.Size = New System.Drawing.Size(83, 32)
        Me.Back_Btn.TabIndex = 17
        Me.Back_Btn.Text = "Back"
        Me.Back_Btn.UseVisualStyleBackColor = False
        '
        'txtBfirstName
        '
        Me.txtBfirstName.Location = New System.Drawing.Point(550, 39)
        Me.txtBfirstName.Name = "txtBfirstName"
        Me.txtBfirstName.Size = New System.Drawing.Size(157, 20)
        Me.txtBfirstName.TabIndex = 29
        '
        'txtBlastName
        '
        Me.txtBlastName.Location = New System.Drawing.Point(552, 84)
        Me.txtBlastName.Name = "txtBlastName"
        Me.txtBlastName.Size = New System.Drawing.Size(157, 20)
        Me.txtBlastName.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(472, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Last Name"
        '
        'txtBemail
        '
        Me.txtBemail.Location = New System.Drawing.Point(552, 132)
        Me.txtBemail.Name = "txtBemail"
        Me.txtBemail.Size = New System.Drawing.Size(157, 20)
        Me.txtBemail.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(498, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Email"
        '
        'txtBaddress
        '
        Me.txtBaddress.Location = New System.Drawing.Point(551, 180)
        Me.txtBaddress.Name = "txtBaddress"
        Me.txtBaddress.Size = New System.Drawing.Size(157, 20)
        Me.txtBaddress.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(485, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Address"
        '
        'txtBcontactNumber
        '
        Me.txtBcontactNumber.Location = New System.Drawing.Point(551, 221)
        Me.txtBcontactNumber.Name = "txtBcontactNumber"
        Me.txtBcontactNumber.Size = New System.Drawing.Size(157, 20)
        Me.txtBcontactNumber.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(462, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Contact No#"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(473, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "First Name"
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.Red
        Me.Exit_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.ForeColor = System.Drawing.Color.White
        Me.Exit_btn.Location = New System.Drawing.Point(745, 12)
        Me.Exit_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(28, 26)
        Me.Exit_btn.TabIndex = 38
        Me.Exit_btn.Text = "X"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'guestL
        '
        Me.guestL.AutoSize = True
        Me.guestL.BackColor = System.Drawing.Color.Transparent
        Me.guestL.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.guestL.LinkColor = System.Drawing.Color.Blue
        Me.guestL.Location = New System.Drawing.Point(659, 425)
        Me.guestL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.guestL.Name = "guestL"
        Me.guestL.Size = New System.Drawing.Size(120, 17)
        Me.guestL.TabIndex = 9
        Me.guestL.TabStop = True
        Me.guestL.Text = "Continue as Guest"
        '
        'Form_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(786, 452)
        Me.Controls.Add(Me.guestL)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.txtBcontactNumber)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBaddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBemail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBlastName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBfirstName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Back_Btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShowPasswordCheckBox)
        Me.Controls.Add(Me.txtBpassword)
        Me.Controls.Add(Me.txtBusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Register_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Register_btn As Button
    Friend WithEvents txtBpassword As TextBox
    Friend WithEvents txtBusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ShowPasswordCheckBox As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Back_Btn As Button
    Friend WithEvents Loginlink As LinkLabel
    Friend WithEvents txtBfirstName As TextBox
    Friend WithEvents txtBlastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBemail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBaddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBcontactNumber As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Exit_btn As Button
    Friend WithEvents guestL As LinkLabel
End Class
