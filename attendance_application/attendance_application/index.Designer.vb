<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index))
        Me.form_text = New System.Windows.Forms.Label()
        Me.form_container = New Guna.UI2.WinForms.Guna2Panel()
        Me.loginProgressBar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.loginProgressIndicator = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.switchToggle = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.loginTimerLoader = New System.Windows.Forms.Timer(Me.components)
        Me.loginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.password_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.email_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.backgroundImagePicBox = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.form_container.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backgroundImagePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'form_text
        '
        Me.form_text.AutoSize = True
        Me.form_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.form_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.form_text.ForeColor = System.Drawing.Color.SteelBlue
        Me.form_text.Location = New System.Drawing.Point(22, 22)
        Me.form_text.Name = "form_text"
        Me.form_text.Size = New System.Drawing.Size(148, 20)
        Me.form_text.TabIndex = 3
        Me.form_text.Text = "Login to continue"
        '
        'form_container
        '
        Me.form_container.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.form_container.BackColor = System.Drawing.Color.White
        Me.form_container.BorderRadius = 10
        Me.form_container.Controls.Add(Me.loginProgressIndicator)
        Me.form_container.Controls.Add(Me.Label2)
        Me.form_container.Controls.Add(Me.loginBtn)
        Me.form_container.Controls.Add(Me.Label1)
        Me.form_container.Controls.Add(Me.switchToggle)
        Me.form_container.Controls.Add(Me.password_txt)
        Me.form_container.Controls.Add(Me.form_text)
        Me.form_container.Controls.Add(Me.email_txt)
        Me.form_container.Controls.Add(Me.ShapeContainer1)
        Me.form_container.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.form_container.Location = New System.Drawing.Point(377, 38)
        Me.form_container.Name = "form_container"
        Me.form_container.ShadowDecoration.Parent = Me.form_container
        Me.form_container.Size = New System.Drawing.Size(396, 372)
        Me.form_container.TabIndex = 1
        '
        'loginProgressBar
        '
        Me.loginProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.loginProgressBar.Location = New System.Drawing.Point(89, 206)
        Me.loginProgressBar.Name = "loginProgressBar"
        Me.loginProgressBar.ShadowDecoration.Parent = Me.loginProgressBar
        Me.loginProgressBar.Size = New System.Drawing.Size(188, 30)
        Me.loginProgressBar.TabIndex = 9
        Me.loginProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'loginProgressIndicator
        '
        Me.loginProgressIndicator.AutoStart = True
        Me.loginProgressIndicator.BackColor = System.Drawing.Color.Transparent
        Me.loginProgressIndicator.CircleSize = 2.0!
        Me.loginProgressIndicator.Location = New System.Drawing.Point(147, 135)
        Me.loginProgressIndicator.Name = "loginProgressIndicator"
        Me.loginProgressIndicator.Size = New System.Drawing.Size(90, 90)
        Me.loginProgressIndicator.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(115, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Developed by - AfooTECH Global" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(68, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Remenber me"
        '
        'switchToggle
        '
        Me.switchToggle.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.switchToggle.CheckedState.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.switchToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.switchToggle.CheckedState.InnerColor = System.Drawing.Color.White
        Me.switchToggle.CheckedState.Parent = Me.switchToggle
        Me.switchToggle.Location = New System.Drawing.Point(22, 226)
        Me.switchToggle.Name = "switchToggle"
        Me.switchToggle.ShadowDecoration.Parent = Me.switchToggle
        Me.switchToggle.Size = New System.Drawing.Size(40, 20)
        Me.switchToggle.TabIndex = 2
        Me.switchToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.switchToggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.switchToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.switchToggle.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.switchToggle.UncheckedState.Parent = Me.switchToggle
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(396, 372)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Maroon
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 26
        Me.LineShape1.X2 = 78
        Me.LineShape1.Y1 = 53
        Me.LineShape1.Y2 = 53
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(29, 323)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(326, 87)
        Me.Guna2Panel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(56, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Welcome to TrackSmart"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(34, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Student Enrollment | Attendance Application"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(326, 87)
        Me.ShapeContainer2.TabIndex = 11
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Maroon
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 104
        Me.LineShape2.X2 = 210
        Me.LineShape2.Y1 = 11
        Me.LineShape2.Y2 = 11
        '
        'loginTimerLoader
        '
        '
        'loginBtn
        '
        Me.loginBtn.BorderRadius = 20
        Me.loginBtn.CheckedState.Parent = Me.loginBtn
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.CustomImages.Parent = Me.loginBtn
        Me.loginBtn.FillColor = System.Drawing.Color.SteelBlue
        Me.loginBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.loginBtn.HoverState.Parent = Me.loginBtn
        Me.loginBtn.Location = New System.Drawing.Point(22, 270)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.ShadowDecoration.Parent = Me.loginBtn
        Me.loginBtn.Size = New System.Drawing.Size(353, 45)
        Me.loginBtn.TabIndex = 7
        Me.loginBtn.Text = "Log In"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.White
        Me.Guna2PictureBox2.Image = Global.tracksmart_application.My.Resources.Resources.feature
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(29, 38)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(326, 315)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 2
        Me.Guna2PictureBox2.TabStop = False
        '
        'password_txt
        '
        Me.password_txt.BorderColor = System.Drawing.Color.Gray
        Me.password_txt.BorderThickness = 2
        Me.password_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_txt.DefaultText = ""
        Me.password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_txt.DisabledState.Parent = Me.password_txt
        Me.password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_txt.FocusedState.BorderColor = System.Drawing.Color.SteelBlue
        Me.password_txt.FocusedState.Parent = Me.password_txt
        Me.password_txt.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black
        Me.password_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_txt.HoverState.ForeColor = System.Drawing.Color.Transparent
        Me.password_txt.HoverState.Parent = Me.password_txt
        Me.password_txt.HoverState.PlaceholderForeColor = System.Drawing.Color.Transparent
        Me.password_txt.IconLeft = Global.tracksmart_application.My.Resources.Resources.icons8_password_48
        Me.password_txt.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.password_txt.Location = New System.Drawing.Point(22, 168)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(6)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.password_txt.PlaceholderForeColor = System.Drawing.Color.LightGray
        Me.password_txt.PlaceholderText = "Password"
        Me.password_txt.SelectedText = ""
        Me.password_txt.ShadowDecoration.Parent = Me.password_txt
        Me.password_txt.Size = New System.Drawing.Size(353, 40)
        Me.password_txt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.password_txt.TabIndex = 4
        Me.password_txt.TextOffset = New System.Drawing.Point(10, 0)
        Me.password_txt.UseSystemPasswordChar = True
        '
        'email_txt
        '
        Me.email_txt.BorderColor = System.Drawing.Color.Gray
        Me.email_txt.BorderThickness = 2
        Me.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_txt.DefaultText = ""
        Me.email_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.DisabledState.Parent = Me.email_txt
        Me.email_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.FocusedState.BorderColor = System.Drawing.Color.SteelBlue
        Me.email_txt.FocusedState.Parent = Me.email_txt
        Me.email_txt.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black
        Me.email_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.email_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.HoverState.ForeColor = System.Drawing.Color.Transparent
        Me.email_txt.HoverState.Parent = Me.email_txt
        Me.email_txt.HoverState.PlaceholderForeColor = System.Drawing.Color.Transparent
        Me.email_txt.IconLeft = Global.tracksmart_application.My.Resources.Resources.icons8_email_24
        Me.email_txt.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.email_txt.Location = New System.Drawing.Point(25, 86)
        Me.email_txt.Margin = New System.Windows.Forms.Padding(6)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_txt.PlaceholderForeColor = System.Drawing.Color.LightGray
        Me.email_txt.PlaceholderText = "Email Address"
        Me.email_txt.SelectedText = ""
        Me.email_txt.ShadowDecoration.Parent = Me.email_txt
        Me.email_txt.Size = New System.Drawing.Size(353, 40)
        Me.email_txt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.email_txt.TabIndex = 2
        Me.email_txt.TextOffset = New System.Drawing.Point(10, 0)
        '
        'backgroundImagePicBox
        '
        Me.backgroundImagePicBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.backgroundImagePicBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backgroundImagePicBox.Image = Global.tracksmart_application.My.Resources.Resources._360_F_383390104_aTxmmJEIcGe4bPfYjR8lZLcPx5Duc0Y2
        Me.backgroundImagePicBox.Location = New System.Drawing.Point(0, 0)
        Me.backgroundImagePicBox.Name = "backgroundImagePicBox"
        Me.backgroundImagePicBox.ShadowDecoration.Parent = Me.backgroundImagePicBox
        Me.backgroundImagePicBox.Size = New System.Drawing.Size(797, 450)
        Me.backgroundImagePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.backgroundImagePicBox.TabIndex = 0
        Me.backgroundImagePicBox.TabStop = False
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 450)
        Me.Controls.Add(Me.loginProgressBar)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.form_container)
        Me.Controls.Add(Me.backgroundImagePicBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "index"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrackSmart App"
        Me.form_container.ResumeLayout(False)
        Me.form_container.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backgroundImagePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents backgroundImagePicBox As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents email_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents form_text As System.Windows.Forms.Label
    Friend WithEvents password_txt As Guna.UI2.WinForms.Guna2TextBox
    Protected WithEvents form_container As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents switchToggle As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents loginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents loginProgressIndicator As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents loginProgressBar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents loginTimerLoader As System.Windows.Forms.Timer

End Class
