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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
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
        Me.ResetPass_Panel = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ConfirmedPass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.CreatePass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.ResetPass_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Back_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.OTP_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ForgotPass_Panel = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PassProceedBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.BackPassBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ForgotPass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.login_panel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResetPass_Panel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ForgotPass_Panel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(597, 116)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(20, 23)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = " "
        Me.CheckBox1.UseVisualStyleBackColor = False
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
        Me.LoginButton.Image = Global.WindowsApplication1.My.Resources.Resources.login1
        Me.LoginButton.ImageSize = New System.Drawing.Size(15, 15)
        Me.LoginButton.Location = New System.Drawing.Point(13, 233)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.ShadowDecoration.Parent = Me.LoginButton
        Me.LoginButton.Size = New System.Drawing.Size(180, 45)
        Me.LoginButton.TabIndex = 0
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
        Me.CloseButton.Image = Global.WindowsApplication1.My.Resources.Resources.close
        Me.CloseButton.ImageSize = New System.Drawing.Size(15, 15)
        Me.CloseButton.Location = New System.Drawing.Point(441, 233)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(180, 45)
        Me.CloseButton.TabIndex = 0
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
        Me.Pass_txt.TabIndex = 2
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
        Me.email_txt.TabIndex = 1
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
        Me.ForgotPass_Label.TabIndex = 0
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
        'ResetPass_Panel
        '
        Me.ResetPass_Panel.BackColor = System.Drawing.SystemColors.Control
        Me.ResetPass_Panel.BackgroundImage = CType(resources.GetObject("ResetPass_Panel.BackgroundImage"), System.Drawing.Image)
        Me.ResetPass_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResetPass_Panel.Controls.Add(Me.GroupBox3)
        Me.ResetPass_Panel.Location = New System.Drawing.Point(12, 15)
        Me.ResetPass_Panel.Name = "ResetPass_Panel"
        Me.ResetPass_Panel.Size = New System.Drawing.Size(686, 352)
        Me.ResetPass_Panel.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.ConfirmedPass_txt)
        Me.GroupBox3.Controls.Add(Me.PictureBox6)
        Me.GroupBox3.Controls.Add(Me.CreatePass_txt)
        Me.GroupBox3.Controls.Add(Me.PictureBox5)
        Me.GroupBox3.Controls.Add(Me.ResetPass_btn)
        Me.GroupBox3.Controls.Add(Me.Back_btn)
        Me.GroupBox3.Controls.Add(Me.OTP_txt)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Controls.Add(Me.ShapeContainer3)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(637, 312)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'ConfirmedPass_txt
        '
        Me.ConfirmedPass_txt.Animated = True
        Me.ConfirmedPass_txt.BorderColor = System.Drawing.SystemColors.Control
        Me.ConfirmedPass_txt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.ConfirmedPass_txt.BorderThickness = 0
        Me.ConfirmedPass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ConfirmedPass_txt.DefaultText = ""
        Me.ConfirmedPass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ConfirmedPass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ConfirmedPass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmedPass_txt.DisabledState.Parent = Me.ConfirmedPass_txt
        Me.ConfirmedPass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmedPass_txt.FillColor = System.Drawing.SystemColors.Control
        Me.ConfirmedPass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmedPass_txt.FocusedState.Parent = Me.ConfirmedPass_txt
        Me.ConfirmedPass_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ConfirmedPass_txt.ForeColor = System.Drawing.Color.Black
        Me.ConfirmedPass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmedPass_txt.HoverState.Parent = Me.ConfirmedPass_txt
        Me.ConfirmedPass_txt.Location = New System.Drawing.Point(41, 206)
        Me.ConfirmedPass_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ConfirmedPass_txt.Name = "ConfirmedPass_txt"
        Me.ConfirmedPass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ConfirmedPass_txt.PlaceholderText = "Confirmed Password"
        Me.ConfirmedPass_txt.SelectedText = ""
        Me.ConfirmedPass_txt.ShadowDecoration.Parent = Me.ConfirmedPass_txt
        Me.ConfirmedPass_txt.Size = New System.Drawing.Size(580, 27)
        Me.ConfirmedPass_txt.TabIndex = 3
        Me.ConfirmedPass_txt.UseSystemPasswordChar = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.pngwing_com_9_
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(15, 211)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox6.TabIndex = 36
        Me.PictureBox6.TabStop = False
        '
        'CreatePass_txt
        '
        Me.CreatePass_txt.Animated = True
        Me.CreatePass_txt.BorderColor = System.Drawing.SystemColors.Control
        Me.CreatePass_txt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.CreatePass_txt.BorderThickness = 0
        Me.CreatePass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CreatePass_txt.DefaultText = ""
        Me.CreatePass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CreatePass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CreatePass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CreatePass_txt.DisabledState.Parent = Me.CreatePass_txt
        Me.CreatePass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CreatePass_txt.FillColor = System.Drawing.SystemColors.Control
        Me.CreatePass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CreatePass_txt.FocusedState.Parent = Me.CreatePass_txt
        Me.CreatePass_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.CreatePass_txt.ForeColor = System.Drawing.Color.Black
        Me.CreatePass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CreatePass_txt.HoverState.Parent = Me.CreatePass_txt
        Me.CreatePass_txt.Location = New System.Drawing.Point(41, 148)
        Me.CreatePass_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CreatePass_txt.Name = "CreatePass_txt"
        Me.CreatePass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CreatePass_txt.PlaceholderText = "Create Password"
        Me.CreatePass_txt.SelectedText = ""
        Me.CreatePass_txt.ShadowDecoration.Parent = Me.CreatePass_txt
        Me.CreatePass_txt.Size = New System.Drawing.Size(580, 27)
        Me.CreatePass_txt.TabIndex = 2
        Me.CreatePass_txt.UseSystemPasswordChar = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.pngwing_com_9_
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(15, 153)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox5.TabIndex = 34
        Me.PictureBox5.TabStop = False
        '
        'ResetPass_btn
        '
        Me.ResetPass_btn.BorderRadius = 5
        Me.ResetPass_btn.CheckedState.Parent = Me.ResetPass_btn
        Me.ResetPass_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetPass_btn.CustomImages.Parent = Me.ResetPass_btn
        Me.ResetPass_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.ResetPass_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetPass_btn.ForeColor = System.Drawing.Color.White
        Me.ResetPass_btn.HoverState.Parent = Me.ResetPass_btn
        Me.ResetPass_btn.Image = Global.WindowsApplication1.My.Resources.Resources.check
        Me.ResetPass_btn.ImageSize = New System.Drawing.Size(15, 15)
        Me.ResetPass_btn.Location = New System.Drawing.Point(445, 255)
        Me.ResetPass_btn.Name = "ResetPass_btn"
        Me.ResetPass_btn.ShadowDecoration.Parent = Me.ResetPass_btn
        Me.ResetPass_btn.Size = New System.Drawing.Size(180, 45)
        Me.ResetPass_btn.TabIndex = 31
        Me.ResetPass_btn.Text = "Reset Password"
        '
        'Back_btn
        '
        Me.Back_btn.BorderRadius = 5
        Me.Back_btn.CheckedState.Parent = Me.Back_btn
        Me.Back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Back_btn.CustomImages.Parent = Me.Back_btn
        Me.Back_btn.FillColor = System.Drawing.Color.Maroon
        Me.Back_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_btn.ForeColor = System.Drawing.Color.White
        Me.Back_btn.HoverState.Parent = Me.Back_btn
        Me.Back_btn.Image = Global.WindowsApplication1.My.Resources.Resources.back_arrow
        Me.Back_btn.ImageSize = New System.Drawing.Size(15, 15)
        Me.Back_btn.Location = New System.Drawing.Point(12, 255)
        Me.Back_btn.Name = "Back_btn"
        Me.Back_btn.ShadowDecoration.Parent = Me.Back_btn
        Me.Back_btn.Size = New System.Drawing.Size(180, 45)
        Me.Back_btn.TabIndex = 30
        Me.Back_btn.Text = "Back"
        '
        'OTP_txt
        '
        Me.OTP_txt.Animated = True
        Me.OTP_txt.BorderColor = System.Drawing.SystemColors.Control
        Me.OTP_txt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.OTP_txt.BorderThickness = 0
        Me.OTP_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OTP_txt.DefaultText = ""
        Me.OTP_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.OTP_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.OTP_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OTP_txt.DisabledState.Parent = Me.OTP_txt
        Me.OTP_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OTP_txt.FillColor = System.Drawing.SystemColors.Control
        Me.OTP_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OTP_txt.FocusedState.Parent = Me.OTP_txt
        Me.OTP_txt.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OTP_txt.ForeColor = System.Drawing.Color.Black
        Me.OTP_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OTP_txt.HoverState.Parent = Me.OTP_txt
        Me.OTP_txt.Location = New System.Drawing.Point(41, 93)
        Me.OTP_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.OTP_txt.Name = "OTP_txt"
        Me.OTP_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OTP_txt.PlaceholderText = "Enter OTP"
        Me.OTP_txt.SelectedText = ""
        Me.OTP_txt.ShadowDecoration.Parent = Me.OTP_txt
        Me.OTP_txt.Size = New System.Drawing.Size(580, 27)
        Me.OTP_txt.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.pngwing_com_8_
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(15, 98)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape5, Me.LineShape3})
        Me.ShapeContainer3.Size = New System.Drawing.Size(631, 293)
        Me.ShapeContainer3.TabIndex = 32
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ScrollBar
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 10
        Me.LineShape6.X2 = 621
        Me.LineShape6.Y1 = 225
        Me.LineShape6.Y2 = 224
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ScrollBar
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 10
        Me.LineShape5.X2 = 621
        Me.LineShape5.Y1 = 167
        Me.LineShape5.Y2 = 166
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ScrollBar
        Me.LineShape3.Name = "LineShape1"
        Me.LineShape3.X1 = 13
        Me.LineShape3.X2 = 624
        Me.LineShape3.Y1 = 111
        Me.LineShape3.Y2 = 110
        '
        'ForgotPass_Panel
        '
        Me.ForgotPass_Panel.BackColor = System.Drawing.SystemColors.Control
        Me.ForgotPass_Panel.BackgroundImage = CType(resources.GetObject("ForgotPass_Panel.BackgroundImage"), System.Drawing.Image)
        Me.ForgotPass_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ForgotPass_Panel.Controls.Add(Me.GroupBox2)
        Me.ForgotPass_Panel.Location = New System.Drawing.Point(12, 12)
        Me.ForgotPass_Panel.Name = "ForgotPass_Panel"
        Me.ForgotPass_Panel.Size = New System.Drawing.Size(686, 362)
        Me.ForgotPass_Panel.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PassProceedBtn)
        Me.GroupBox2.Controls.Add(Me.BackPassBtn)
        Me.GroupBox2.Controls.Add(Me.ForgotPass_txt)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(637, 312)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(442, 15)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Please provide the Email Address that you used during your account registration "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Reset your Password"
        '
        'PassProceedBtn
        '
        Me.PassProceedBtn.BorderRadius = 5
        Me.PassProceedBtn.CheckedState.Parent = Me.PassProceedBtn
        Me.PassProceedBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PassProceedBtn.CustomImages.Parent = Me.PassProceedBtn
        Me.PassProceedBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.PassProceedBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassProceedBtn.ForeColor = System.Drawing.Color.White
        Me.PassProceedBtn.HoverState.Parent = Me.PassProceedBtn
        Me.PassProceedBtn.Image = Global.WindowsApplication1.My.Resources.Resources.proceed_arrow
        Me.PassProceedBtn.ImageSize = New System.Drawing.Size(15, 15)
        Me.PassProceedBtn.Location = New System.Drawing.Point(445, 245)
        Me.PassProceedBtn.Name = "PassProceedBtn"
        Me.PassProceedBtn.ShadowDecoration.Parent = Me.PassProceedBtn
        Me.PassProceedBtn.Size = New System.Drawing.Size(180, 45)
        Me.PassProceedBtn.TabIndex = 31
        Me.PassProceedBtn.Text = "Proceed"
        '
        'BackPassBtn
        '
        Me.BackPassBtn.BorderRadius = 5
        Me.BackPassBtn.CheckedState.Parent = Me.BackPassBtn
        Me.BackPassBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackPassBtn.CustomImages.Parent = Me.BackPassBtn
        Me.BackPassBtn.FillColor = System.Drawing.Color.Maroon
        Me.BackPassBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackPassBtn.ForeColor = System.Drawing.Color.White
        Me.BackPassBtn.HoverState.Parent = Me.BackPassBtn
        Me.BackPassBtn.Image = Global.WindowsApplication1.My.Resources.Resources.back_arrow
        Me.BackPassBtn.ImageSize = New System.Drawing.Size(15, 15)
        Me.BackPassBtn.Location = New System.Drawing.Point(12, 245)
        Me.BackPassBtn.Name = "BackPassBtn"
        Me.BackPassBtn.ShadowDecoration.Parent = Me.BackPassBtn
        Me.BackPassBtn.Size = New System.Drawing.Size(180, 45)
        Me.BackPassBtn.TabIndex = 30
        Me.BackPassBtn.Text = "Back"
        '
        'ForgotPass_txt
        '
        Me.ForgotPass_txt.Animated = True
        Me.ForgotPass_txt.BorderColor = System.Drawing.SystemColors.Control
        Me.ForgotPass_txt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.ForgotPass_txt.BorderThickness = 0
        Me.ForgotPass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ForgotPass_txt.DefaultText = ""
        Me.ForgotPass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ForgotPass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ForgotPass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ForgotPass_txt.DisabledState.Parent = Me.ForgotPass_txt
        Me.ForgotPass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ForgotPass_txt.FillColor = System.Drawing.SystemColors.Control
        Me.ForgotPass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ForgotPass_txt.FocusedState.Parent = Me.ForgotPass_txt
        Me.ForgotPass_txt.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotPass_txt.ForeColor = System.Drawing.Color.Black
        Me.ForgotPass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ForgotPass_txt.HoverState.Parent = Me.ForgotPass_txt
        Me.ForgotPass_txt.Location = New System.Drawing.Point(41, 125)
        Me.ForgotPass_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.ForgotPass_txt.Name = "ForgotPass_txt"
        Me.ForgotPass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ForgotPass_txt.PlaceholderText = "Enter Your Email Address"
        Me.ForgotPass_txt.SelectedText = ""
        Me.ForgotPass_txt.ShadowDecoration.Parent = Me.ForgotPass_txt
        Me.ForgotPass_txt.Size = New System.Drawing.Size(580, 27)
        Me.ForgotPass_txt.TabIndex = 28
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.pngwing_com_6_
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(16, 132)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 16)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4})
        Me.ShapeContainer2.Size = New System.Drawing.Size(631, 293)
        Me.ShapeContainer2.TabIndex = 32
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ScrollBar
        Me.LineShape4.Name = "LineShape1"
        Me.LineShape4.X1 = 13
        Me.LineShape4.X2 = 624
        Me.LineShape4.Y1 = 142
        Me.LineShape4.Y2 = 141
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
        Me.ResetPass_Panel.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ForgotPass_Panel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PassProceedBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BackPassBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ForgotPass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CreatePass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ResetPass_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Back_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OTP_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ConfirmedPass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
