<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_form))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SubmitButton = New Guna.UI2.WinForms.Guna2Button()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.selectpassport_button = New System.Windows.Forms.Button()
        Me.AdminPictureBox = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.email_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RoleComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mobile_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fullname_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fetchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.profile_id = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.recordBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.userCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.closeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AdminPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.GroupBox4)
        Me.Guna2GroupBox1.Controls.Add(Me.GroupBox3)
        Me.Guna2GroupBox1.Controls.Add(Me.GroupBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.GroupBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.Panel2)
        Me.Guna2GroupBox1.Controls.Add(Me.closeBtn)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(762, 653)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Admin Record"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Controls.Add(Me.SubmitButton)
        Me.GroupBox4.Controls.Add(Me.CloseButton)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(529, 473)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(221, 169)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'SubmitButton
        '
        Me.SubmitButton.Animated = True
        Me.SubmitButton.BorderRadius = 5
        Me.SubmitButton.CheckedState.Parent = Me.SubmitButton
        Me.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubmitButton.CustomImages.Parent = Me.SubmitButton
        Me.SubmitButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.SubmitButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.ForeColor = System.Drawing.Color.White
        Me.SubmitButton.HoverState.Parent = Me.SubmitButton
        Me.SubmitButton.Location = New System.Drawing.Point(17, 22)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.ShadowDecoration.Parent = Me.SubmitButton
        Me.SubmitButton.Size = New System.Drawing.Size(180, 45)
        Me.SubmitButton.TabIndex = 2
        Me.SubmitButton.Text = "SUBMIT"
        '
        'CloseButton
        '
        Me.CloseButton.Animated = True
        Me.CloseButton.BorderRadius = 5
        Me.CloseButton.CheckedState.Parent = Me.CloseButton
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.CustomImages.Parent = Me.CloseButton
        Me.CloseButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.HoverState.Parent = Me.CloseButton
        Me.CloseButton.Location = New System.Drawing.Point(17, 91)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(180, 45)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "CLEAR"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Controls.Add(Me.selectpassport_button)
        Me.GroupBox3.Controls.Add(Me.AdminPictureBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(529, 212)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(221, 255)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Passport"
        '
        'selectpassport_button
        '
        Me.selectpassport_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.selectpassport_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selectpassport_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.selectpassport_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectpassport_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectpassport_button.Location = New System.Drawing.Point(17, 195)
        Me.selectpassport_button.Name = "selectpassport_button"
        Me.selectpassport_button.Size = New System.Drawing.Size(187, 48)
        Me.selectpassport_button.TabIndex = 26
        Me.selectpassport_button.Text = "SELECT PASSPORT"
        Me.selectpassport_button.UseVisualStyleBackColor = False
        '
        'AdminPictureBox
        '
        Me.AdminPictureBox.BackgroundImage = CType(resources.GetObject("AdminPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.AdminPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdminPictureBox.Location = New System.Drawing.Point(17, 31)
        Me.AdminPictureBox.Name = "AdminPictureBox"
        Me.AdminPictureBox.ShadowDecoration.Parent = Me.AdminPictureBox
        Me.AdminPictureBox.Size = New System.Drawing.Size(187, 160)
        Me.AdminPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AdminPictureBox.TabIndex = 0
        Me.AdminPictureBox.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.email_txt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.StatusComboBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.RoleComboBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.mobile_txt)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.fullname_txt)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 429)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Staff Information"
        '
        'email_txt
        '
        Me.email_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.email_txt.BorderRadius = 5
        Me.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_txt.DefaultText = ""
        Me.email_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.DisabledState.Parent = Me.email_txt
        Me.email_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.FocusedState.Parent = Me.email_txt
        Me.email_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_txt.ForeColor = System.Drawing.Color.Black
        Me.email_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.HoverState.Parent = Me.email_txt
        Me.email_txt.Location = New System.Drawing.Point(20, 123)
        Me.email_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.email_txt.PlaceholderText = "EMAIL ADDRESS"
        Me.email_txt.SelectedText = ""
        Me.email_txt.ShadowDecoration.Parent = Me.email_txt
        Me.email_txt.Size = New System.Drawing.Size(468, 41)
        Me.email_txt.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Status"
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusComboBox.ForeColor = System.Drawing.Color.Black
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Location = New System.Drawing.Point(20, 342)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(468, 38)
        Me.StatusComboBox.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Staff Role"
        '
        'RoleComboBox
        '
        Me.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoleComboBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleComboBox.ForeColor = System.Drawing.Color.Black
        Me.RoleComboBox.FormattingEnabled = True
        Me.RoleComboBox.Location = New System.Drawing.Point(20, 268)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.Size = New System.Drawing.Size(468, 38)
        Me.RoleComboBox.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mobile"
        '
        'mobile_txt
        '
        Me.mobile_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.mobile_txt.BorderRadius = 5
        Me.mobile_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mobile_txt.DefaultText = ""
        Me.mobile_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.mobile_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.mobile_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mobile_txt.DisabledState.Parent = Me.mobile_txt
        Me.mobile_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mobile_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mobile_txt.FocusedState.Parent = Me.mobile_txt
        Me.mobile_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobile_txt.ForeColor = System.Drawing.Color.Black
        Me.mobile_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mobile_txt.HoverState.Parent = Me.mobile_txt
        Me.mobile_txt.Location = New System.Drawing.Point(20, 196)
        Me.mobile_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.mobile_txt.Name = "mobile_txt"
        Me.mobile_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mobile_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.mobile_txt.PlaceholderText = "MOBILE NO"
        Me.mobile_txt.SelectedText = ""
        Me.mobile_txt.ShadowDecoration.Parent = Me.mobile_txt
        Me.mobile_txt.Size = New System.Drawing.Size(468, 41)
        Me.mobile_txt.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Email Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "FullName"
        '
        'fullname_txt
        '
        Me.fullname_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.fullname_txt.BorderRadius = 5
        Me.fullname_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fullname_txt.DefaultText = ""
        Me.fullname_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fullname_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fullname_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname_txt.DisabledState.Parent = Me.fullname_txt
        Me.fullname_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname_txt.FocusedState.Parent = Me.fullname_txt
        Me.fullname_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname_txt.ForeColor = System.Drawing.Color.Black
        Me.fullname_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname_txt.HoverState.Parent = Me.fullname_txt
        Me.fullname_txt.Location = New System.Drawing.Point(20, 53)
        Me.fullname_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.fullname_txt.Name = "fullname_txt"
        Me.fullname_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullname_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.fullname_txt.PlaceholderText = "FULLNAME"
        Me.fullname_txt.SelectedText = ""
        Me.fullname_txt.ShadowDecoration.Parent = Me.fullname_txt
        Me.fullname_txt.Size = New System.Drawing.Size(468, 41)
        Me.fullname_txt.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.fetchBtn)
        Me.GroupBox1.Controls.Add(Me.profile_id)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 103)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PROFILE ID"
        '
        'fetchBtn
        '
        Me.fetchBtn.Animated = True
        Me.fetchBtn.BorderRadius = 5
        Me.fetchBtn.CheckedState.Parent = Me.fetchBtn
        Me.fetchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fetchBtn.CustomImages.Parent = Me.fetchBtn
        Me.fetchBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.fetchBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.fetchBtn.ForeColor = System.Drawing.Color.White
        Me.fetchBtn.HoverState.Parent = Me.fetchBtn
        Me.fetchBtn.Location = New System.Drawing.Point(15, 59)
        Me.fetchBtn.Name = "fetchBtn"
        Me.fetchBtn.ShadowDecoration.Parent = Me.fetchBtn
        Me.fetchBtn.Size = New System.Drawing.Size(125, 32)
        Me.fetchBtn.TabIndex = 4
        Me.fetchBtn.Text = "FETCH"
        '
        'profile_id
        '
        Me.profile_id.BackColor = System.Drawing.Color.Transparent
        Me.profile_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.profile_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.profile_id.FocusedColor = System.Drawing.Color.Empty
        Me.profile_id.FocusedState.Parent = Me.profile_id
        Me.profile_id.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.profile_id.ForeColor = System.Drawing.Color.Black
        Me.profile_id.FormattingEnabled = True
        Me.profile_id.HoverState.Parent = Me.profile_id
        Me.profile_id.ItemHeight = 30
        Me.profile_id.ItemsAppearance.Parent = Me.profile_id
        Me.profile_id.Location = New System.Drawing.Point(12, 17)
        Me.profile_id.Name = "profile_id"
        Me.profile_id.ShadowDecoration.Parent = Me.profile_id
        Me.profile_id.Size = New System.Drawing.Size(714, 36)
        Me.profile_id.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.recordBtn)
        Me.Panel2.Controls.Add(Me.userCount)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(762, 47)
        Me.Panel2.TabIndex = 2
        '
        'recordBtn
        '
        Me.recordBtn.Animated = True
        Me.recordBtn.BorderRadius = 5
        Me.recordBtn.CheckedState.Parent = Me.recordBtn
        Me.recordBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.recordBtn.CustomImages.Parent = Me.recordBtn
        Me.recordBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.recordBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.recordBtn.ForeColor = System.Drawing.Color.White
        Me.recordBtn.HoverState.Parent = Me.recordBtn
        Me.recordBtn.Location = New System.Drawing.Point(22, 7)
        Me.recordBtn.Name = "recordBtn"
        Me.recordBtn.ShadowDecoration.Parent = Me.recordBtn
        Me.recordBtn.Size = New System.Drawing.Size(125, 32)
        Me.recordBtn.TabIndex = 7
        Me.recordBtn.Text = "VIEW RECORD"
        '
        'userCount
        '
        Me.userCount.AutoSize = True
        Me.userCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userCount.ForeColor = System.Drawing.Color.Maroon
        Me.userCount.Location = New System.Drawing.Point(707, 17)
        Me.userCount.Name = "userCount"
        Me.userCount.Size = New System.Drawing.Size(14, 13)
        Me.userCount.TabIndex = 6
        Me.userCount.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(608, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "TOTAL STAFF"
        '
        'closeBtn
        '
        Me.closeBtn.CheckedState.Parent = Me.closeBtn
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtn.CustomImages.Parent = Me.closeBtn
        Me.closeBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.closeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.closeBtn.ForeColor = System.Drawing.Color.White
        Me.closeBtn.HoverState.Parent = Me.closeBtn
        Me.closeBtn.Location = New System.Drawing.Point(707, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.ShadowDecoration.Parent = Me.closeBtn
        Me.closeBtn.Size = New System.Drawing.Size(55, 40)
        Me.closeBtn.TabIndex = 0
        Me.closeBtn.Text = "X"
        '
        'admin_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(762, 653)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admin_form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_form"
        Me.TopMost = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.AdminPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents SubmitButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents selectpassport_button As System.Windows.Forms.Button
    Friend WithEvents AdminPictureBox As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RoleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mobile_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fullname_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents fetchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents profile_id As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents userCount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents email_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents recordBtn As Guna.UI2.WinForms.Guna2Button
End Class
