<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarDisplayCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BalenoPan = New System.Windows.Forms.Panel()
        Me.ViewMoreBtn = New System.Windows.Forms.Button()
        Me.PriceLB = New System.Windows.Forms.Label()
        Me.CarImagePB = New System.Windows.Forms.PictureBox()
        Me.CarNameLB = New System.Windows.Forms.Label()
        Me.BalenoPan.SuspendLayout()
        CType(Me.CarImagePB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BalenoPan
        '
        Me.BalenoPan.BackColor = System.Drawing.Color.White
        Me.BalenoPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BalenoPan.Controls.Add(Me.ViewMoreBtn)
        Me.BalenoPan.Controls.Add(Me.PriceLB)
        Me.BalenoPan.Controls.Add(Me.CarImagePB)
        Me.BalenoPan.Controls.Add(Me.CarNameLB)
        Me.BalenoPan.Location = New System.Drawing.Point(5, 7)
        Me.BalenoPan.Name = "BalenoPan"
        Me.BalenoPan.Size = New System.Drawing.Size(226, 193)
        Me.BalenoPan.TabIndex = 3
        '
        'ViewMoreBtn
        '
        Me.ViewMoreBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ViewMoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewMoreBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMoreBtn.Location = New System.Drawing.Point(144, 164)
        Me.ViewMoreBtn.Name = "ViewMoreBtn"
        Me.ViewMoreBtn.Size = New System.Drawing.Size(78, 23)
        Me.ViewMoreBtn.TabIndex = 19
        Me.ViewMoreBtn.Text = "View More"
        Me.ViewMoreBtn.UseVisualStyleBackColor = False
        '
        'PriceLB
        '
        Me.PriceLB.AutoSize = True
        Me.PriceLB.BackColor = System.Drawing.Color.Transparent
        Me.PriceLB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLB.ForeColor = System.Drawing.Color.Black
        Me.PriceLB.Location = New System.Drawing.Point(0, 166)
        Me.PriceLB.Name = "PriceLB"
        Me.PriceLB.Size = New System.Drawing.Size(144, 15)
        Me.PriceLB.TabIndex = 18
        Me.PriceLB.Text = "Starting from ₹ 6.66 Lakh"
        '
        'CarImagePB
        '
        Me.CarImagePB.Image = Global.Car_Showroom.My.Resources.Resources.Car_blac
        Me.CarImagePB.Location = New System.Drawing.Point(6, 30)
        Me.CarImagePB.Name = "CarImagePB"
        Me.CarImagePB.Size = New System.Drawing.Size(217, 127)
        Me.CarImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarImagePB.TabIndex = 17
        Me.CarImagePB.TabStop = False
        '
        'CarNameLB
        '
        Me.CarNameLB.AutoSize = True
        Me.CarNameLB.BackColor = System.Drawing.Color.Transparent
        Me.CarNameLB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarNameLB.ForeColor = System.Drawing.Color.Black
        Me.CarNameLB.Location = New System.Drawing.Point(3, 10)
        Me.CarNameLB.Name = "CarNameLB"
        Me.CarNameLB.Size = New System.Drawing.Size(136, 17)
        Me.CarNameLB.TabIndex = 16
        Me.CarNameLB.Text = "Maruti Suzuki Baleno"
        '
        'CarDisplayCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BalenoPan)
        Me.Name = "CarDisplayCard"
        Me.Size = New System.Drawing.Size(236, 206)
        Me.BalenoPan.ResumeLayout(False)
        Me.BalenoPan.PerformLayout()
        CType(Me.CarImagePB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BalenoPan As Panel
    Friend WithEvents ViewMoreBtn As Button
    Friend WithEvents PriceLB As Label
    Friend WithEvents CarImagePB As PictureBox
    Friend WithEvents CarNameLB As Label
End Class
