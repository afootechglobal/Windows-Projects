<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.login_panel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LoginButton = New Guna.UI2.WinForms.Guna2Button()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Pass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.email_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ForgotPass_Label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ForgotPass_Panel = New System.Windows.Forms.Panel()
        Me.ResetPass_Panel = New System.Windows.Forms.Panel()
        Me.login_panel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'login_panel
        '
        Me.login_panel.BackColor = System.Drawing.SystemColors.Control
        Me.login_panel.BackgroundImage = CType(resources.GetObject("login_panel.BackgroundImage"), System.Drawing.Image)
        Me.login_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.login_panel.Controls.Add(Me.GroupBox1)
        Me.login_panel.Location = New System.Drawing.Point(12, 12)
        Me.login_panel.Name = "login_panel"
        Me.login_panel.Size = New System.Drawing.Size(686, 362)
        Me.login_panel.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.LoginButton)
        Me.GroupBox1.Controls.Add(Me.CloseButton)
        Me.GroupBox1.Controls.Add(Me.Pass_txt)
        Me.GroupBox1.Controls.Add(Me.email_txt)
        Me.GroupBox1.Controls.Add(Me.ForgotPass_Label)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 312)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'LoginButton
        '
        Me.LoginButton.BorderRadius = 5
        Me.LoginButton.CheckedState.Parent = Me.LoginButton
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton.CustomImages.Parent = Me.LoginButton
        Me.LoginButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.HoverState.Parent = Me.LoginButton
        Me.LoginButton.Location = New System.Drawing.Point(13, 233)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.ShadowDecoration.Parent = Me.LoginButton
        Me.LoginButton.Size = New System.Drawing.Size(180, 45)
        Me.LoginButton.TabIndex = 31
        Me.LoginButton.Text = "Log-In"
        '
        'CloseButton
        '
        Me.CloseButton.BorderRadius = 5
        Me.CloseButton.CheckedState.Parent = Me.CloseButton
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.CustomImages.Parent = Me.CloseButton
        Me.CloseButton.FillColor = System.Drawing.Color.Maroon
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.HoverState.Parent = Me.CloseButton
        Me.CloseButton.Location = New System.Drawing.Point(441, 233)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(180, 45)
        Me.CloseButton.TabIndex = 30
        Me.CloseButton.Text = "Close"
        '
        'Pass_txt
        '
        Me.Pass_txt.Animated = True
        Me.Pass_txt.BorderColor = System.Drawing.SystemColors.Control
        Me.Pass_txt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Pass_txt.BorderThickness = 0
        Me.Pass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Pass_txt.DefaultText = ""
        Me.Pass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Pass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Pass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Pass_txt.DisabledState.Parent = Me.Pass_txt
        Me.Pass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Pass_txt.FillColor = System.Drawing.SystemColors.Control
        Me.Pass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pass_txt.FocusedState.Parent = Me.Pass_txt
        Me.Pass_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass_txt.ForeColor = System.Drawing.Color.Black
        Me.Pass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pass_txt.HoverState.Parent = Me.Pass_txt
        Me.Pass_txt.Location = New System.Drawing.Point(41, 115)
        Me.Pass_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pass_txt.Name = "Pass_txt"
        Me.Pass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Pass_txt.PlaceholderText = "Enter Your Password"
        Me.Pass_txt.SelectedText = ""
        Me.Pass_txt.ShadowDecoration.Parent = Me.Pass_txt
        Me.Pass_txt.Size = New System.Drawing.Size(580, 27)
        Me.Pass_txt.TabIndex = 29
        Me.Pass_txt.UseSystemPasswordChar = True
        '
        'email_txt
        '
        Me.email_txt.Animated = True
        Me.email_txt.BorderColor = System.Drawing.SystemColors.Control
        Me.email_txt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.email_txt.BorderThickness = 0
        Me.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_txt.DefaultText = ""
        Me.email_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.DisabledState.Parent = Me.email_txt
        Me.email_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.FillColor = System.Drawing.SystemColors.Control
        Me.email_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.FocusedState.Parent = Me.email_txt
        Me.email_txt.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_txt.ForeColor = System.Drawing.Color.Black
        Me.email_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.HoverState.Parent = Me.email_txt
        Me.email_txt.Location = New System.Drawing.Point(41, 48)
        Me.email_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_txt.PlaceholderText = "Enter Your Email Address"
        Me.email_txt.SelectedText = ""
        Me.email_txt.ShadowDecoration.Parent = Me.email_txt
        Me.email_txt.Size = New System.Drawing.Size(580, 27)
        Me.email_txt.TabIndex = 28
        '
        'ForgotPass_Label
        '
        Me.ForgotPass_Label.AutoSize = True
        Me.ForgotPass_Label.BackColor = System.Drawing.SystemColors.Control
        Me.ForgotPass_Label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForgotPass_Label.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotPass_Label.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ForgotPass_Label.Location = New System.Drawing.Point(12, 167)
        Me.ForgotPass_Label.Name = "ForgotPass_Label"
        Me.ForgotPass_Label.Size = New System.Drawing.Size(113, 16)
        Me.ForgotPass_Label.TabIndex = 27
        Me.ForgotPass_Label.Text = "Forgot Password?"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(15, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 25)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(15, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(631, 293)
        Me.ShapeContainer1.TabIndex = 32
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ScrollBar
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 9
        Me.LineShape2.X2 = 621
        Me.LineShape2.Y1 = 136
        Me.LineShape2.Y2 = 135
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ScrollBar
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 13
        Me.LineShape1.X2 = 624
        Me.LineShape1.Y1 = 67
        Me.LineShape1.Y2 = 66
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.eye5
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckBox1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.CheckBox1.FlatAppearance.BorderSize = 0
        Me.CheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control
        Me.CheckBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(597, 116)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(20, 23)
        Me.CheckBox1.TabIndex = 33
        Me.CheckBox1.Text = " "
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'ForgotPass_Panel
        '
        Me.ForgotPass_Panel.BackColor = System.Drawing.SystemColors.Control
        Me.ForgotPass_Panel.BackgroundImage = CType(resources.GetObject("ForgotPass_Panel.BackgroundImage"), System.Drawing.Image)
        Me.ForgotPass_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ForgotPass_Panel.Location = New System.Drawing.Point(12, 12)
        Me.ForgotPass_Panel.Name = "ForgotPass_Panel"
        Me.ForgotPass_Panel.Size = New System.Drawing.Size(686, 362)
        Me.ForgotPass_Panel.TabIndex = 1
        '
        'ResetPass_Panel
        '
        Me.ResetPass_Panel.BackColor = System.Drawing.SystemColors.Control
        Me.ResetPass_Panel.BackgroundImage = CType(resources.GetObject("ResetPass_Panel.BackgroundImage"), System.Drawing.Image)
        Me.ResetPass_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResetPass_Panel.Location = New System.Drawing.Point(12, 15)
        Me.ResetPass_Panel.Name = "ResetPass_Panel"
        Me.ResetPass_Panel.Size = New System.Drawing.Size(686, 352)
        Me.ResetPass_Panel.TabIndex = 2
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(710, 386)
        Me.Controls.Add(Me.login_panel)
        Me.Controls.Add(Me.ResetPass_Panel)
        Me.Controls.Add(Me.ForgotPass_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biometric Fingerprint Enrollment and Verification System"
        Me.login_panel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents login_panel As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LoginButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Pass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents email_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ForgotPass_Label As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ForgotPass_Panel As System.Windows.Forms.Panel
    Friend WithEvents ResetPass_Panel As System.Windows.Forms.Panel

End Class
