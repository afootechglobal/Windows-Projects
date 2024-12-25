<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logoutForm
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.logoutNoBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.logoutYesBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.logoutNoBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.logoutYesBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(428, 352)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "LOG-OUT"
        Me.Guna2GroupBox1.TextOffset = New System.Drawing.Point(50, 0)
        '
        'logoutNoBtn
        '
        Me.logoutNoBtn.AutoRoundedCorners = True
        Me.logoutNoBtn.BackColor = System.Drawing.Color.White
        Me.logoutNoBtn.BorderRadius = 21
        Me.logoutNoBtn.CheckedState.Parent = Me.logoutNoBtn
        Me.logoutNoBtn.CustomImages.Parent = Me.logoutNoBtn
        Me.logoutNoBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.logoutNoBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutNoBtn.ForeColor = System.Drawing.Color.White
        Me.logoutNoBtn.HoverState.Parent = Me.logoutNoBtn
        Me.logoutNoBtn.Location = New System.Drawing.Point(273, 280)
        Me.logoutNoBtn.Name = "logoutNoBtn"
        Me.logoutNoBtn.ShadowDecoration.Parent = Me.logoutNoBtn
        Me.logoutNoBtn.Size = New System.Drawing.Size(107, 44)
        Me.logoutNoBtn.TabIndex = 3
        Me.logoutNoBtn.Text = "NO"
        '
        'logoutYesBtn
        '
        Me.logoutYesBtn.AutoRoundedCorners = True
        Me.logoutYesBtn.BackColor = System.Drawing.Color.White
        Me.logoutYesBtn.BorderRadius = 21
        Me.logoutYesBtn.CheckedState.Parent = Me.logoutYesBtn
        Me.logoutYesBtn.CustomImages.Parent = Me.logoutYesBtn
        Me.logoutYesBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.logoutYesBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutYesBtn.ForeColor = System.Drawing.Color.White
        Me.logoutYesBtn.HoverState.Parent = Me.logoutYesBtn
        Me.logoutYesBtn.Location = New System.Drawing.Point(46, 280)
        Me.logoutYesBtn.Name = "logoutYesBtn"
        Me.logoutYesBtn.ShadowDecoration.Parent = Me.logoutYesBtn
        Me.logoutYesBtn.Size = New System.Drawing.Size(107, 44)
        Me.logoutYesBtn.TabIndex = 2
        Me.logoutYesBtn.Text = "YES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(42, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Are you sure you want to log-out?"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.attendance_application.My.Resources.Resources.icons8_logout_483
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(15, 5)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(41, 30)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2PictureBox1.TabIndex = 4
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.White
        Me.Guna2CirclePictureBox1.Image = Global.attendance_application.My.Resources.Resources.question
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(138, 71)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(133, 132)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'logoutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 352)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "logoutForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "logoutForm"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logoutNoBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents logoutYesBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
