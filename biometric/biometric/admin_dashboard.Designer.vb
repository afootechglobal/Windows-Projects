﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_dashboard))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.VerificationBtn = New System.Windows.Forms.Button()
        Me.EnrollmentBtn = New System.Windows.Forms.Button()
        Me.AdminBtn = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RegisterNewStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEditUsersRcordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEditStaffRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.LabelDateTime = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.AttendanceBtn = New System.Windows.Forms.Button()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Role_label = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeYourPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClockinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffProfile = New WindowsApplication1.CircleAvatar()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip3.SuspendLayout()
        CType(Me.StaffProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'VerificationBtn
        '
        Me.VerificationBtn.BackColor = System.Drawing.Color.Transparent
        Me.VerificationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VerificationBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VerificationBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.VerificationBtn.FlatAppearance.BorderSize = 0
        Me.VerificationBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.VerificationBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.VerificationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerificationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerificationBtn.Image = CType(resources.GetObject("VerificationBtn.Image"), System.Drawing.Image)
        Me.VerificationBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.VerificationBtn.Location = New System.Drawing.Point(143, 3)
        Me.VerificationBtn.Name = "VerificationBtn"
        Me.VerificationBtn.Size = New System.Drawing.Size(120, 68)
        Me.VerificationBtn.TabIndex = 2
        Me.VerificationBtn.Text = "Verification"
        Me.VerificationBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.VerificationBtn.UseVisualStyleBackColor = False
        '
        'EnrollmentBtn
        '
        Me.EnrollmentBtn.BackColor = System.Drawing.Color.Transparent
        Me.EnrollmentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EnrollmentBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnrollmentBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.EnrollmentBtn.FlatAppearance.BorderSize = 0
        Me.EnrollmentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.EnrollmentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.EnrollmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnrollmentBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentBtn.Image = CType(resources.GetObject("EnrollmentBtn.Image"), System.Drawing.Image)
        Me.EnrollmentBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EnrollmentBtn.Location = New System.Drawing.Point(5, 0)
        Me.EnrollmentBtn.Name = "EnrollmentBtn"
        Me.EnrollmentBtn.Size = New System.Drawing.Size(122, 68)
        Me.EnrollmentBtn.TabIndex = 0
        Me.EnrollmentBtn.Text = "Enrollment"
        Me.EnrollmentBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EnrollmentBtn.UseVisualStyleBackColor = False
        '
        'AdminBtn
        '
        Me.AdminBtn.BackColor = System.Drawing.Color.Transparent
        Me.AdminBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AdminBtn.ContextMenuStrip = Me.ContextMenuStrip1
        Me.AdminBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AdminBtn.FlatAppearance.BorderSize = 0
        Me.AdminBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.AdminBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.AdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminBtn.Image = CType(resources.GetObject("AdminBtn.Image"), System.Drawing.Image)
        Me.AdminBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AdminBtn.Location = New System.Drawing.Point(278, 3)
        Me.AdminBtn.Name = "AdminBtn"
        Me.AdminBtn.Size = New System.Drawing.Size(95, 68)
        Me.AdminBtn.TabIndex = 3
        Me.AdminBtn.Text = "Admin"
        Me.AdminBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AdminBtn.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterNewStaffToolStripMenuItem, Me.ViewEditUsersRcordToolStripMenuItem, Me.ViewEditStaffRecordToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(228, 70)
        '
        'RegisterNewStaffToolStripMenuItem
        '
        Me.RegisterNewStaffToolStripMenuItem.Name = "RegisterNewStaffToolStripMenuItem"
        Me.RegisterNewStaffToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.RegisterNewStaffToolStripMenuItem.Text = "Register New Staff"
        '
        'ViewEditUsersRcordToolStripMenuItem
        '
        Me.ViewEditUsersRcordToolStripMenuItem.Name = "ViewEditUsersRcordToolStripMenuItem"
        Me.ViewEditUsersRcordToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ViewEditUsersRcordToolStripMenuItem.Text = "View / Edit Users Record"
        '
        'ViewEditStaffRecordToolStripMenuItem
        '
        Me.ViewEditStaffRecordToolStripMenuItem.Name = "ViewEditStaffRecordToolStripMenuItem"
        Me.ViewEditStaffRecordToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ViewEditStaffRecordToolStripMenuItem.Text = "View / Edit Staff Record"
        '
        'SettingsBtn
        '
        Me.SettingsBtn.BackColor = System.Drawing.Color.Transparent
        Me.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.SettingsBtn.FlatAppearance.BorderSize = 0
        Me.SettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.SettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsBtn.Image = CType(resources.GetObject("SettingsBtn.Image"), System.Drawing.Image)
        Me.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SettingsBtn.Location = New System.Drawing.Point(513, -3)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(95, 68)
        Me.SettingsBtn.TabIndex = 4
        Me.SettingsBtn.Text = "Settings"
        Me.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SettingsBtn.UseVisualStyleBackColor = False
        '
        'LabelDateTime
        '
        Me.LabelDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDateTime.AutoSize = True
        Me.LabelDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateTime.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelDateTime.Location = New System.Drawing.Point(827, 28)
        Me.LabelDateTime.Name = "LabelDateTime"
        Me.LabelDateTime.Size = New System.Drawing.Size(226, 13)
        Me.LabelDateTime.TabIndex = 5
        Me.LabelDateTime.Text = "Time 00:00:00 PM Date 00 mmm, 0000"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.LogoutBtn)
        Me.Panel1.Controls.Add(Me.AttendanceBtn)
        Me.Panel1.Controls.Add(Me.StaffProfile)
        Me.Panel1.Controls.Add(Me.LabelDateTime)
        Me.Panel1.Controls.Add(Me.SettingsBtn)
        Me.Panel1.Controls.Add(Me.AdminBtn)
        Me.Panel1.Controls.Add(Me.EnrollmentBtn)
        Me.Panel1.Controls.Add(Me.VerificationBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1079, 68)
        Me.Panel1.TabIndex = 1
        '
        'LogoutBtn
        '
        Me.LogoutBtn.BackColor = System.Drawing.Color.Transparent
        Me.LogoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoutBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.LogoutBtn.FlatAppearance.BorderSize = 0
        Me.LogoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LogoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.Image = CType(resources.GetObject("LogoutBtn.Image"), System.Drawing.Image)
        Me.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LogoutBtn.Location = New System.Drawing.Point(626, 0)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(95, 68)
        Me.LogoutBtn.TabIndex = 5
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LogoutBtn.UseVisualStyleBackColor = False
        '
        'AttendanceBtn
        '
        Me.AttendanceBtn.BackColor = System.Drawing.Color.Transparent
        Me.AttendanceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AttendanceBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AttendanceBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AttendanceBtn.FlatAppearance.BorderSize = 0
        Me.AttendanceBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.AttendanceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.AttendanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttendanceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendanceBtn.Image = CType(resources.GetObject("AttendanceBtn.Image"), System.Drawing.Image)
        Me.AttendanceBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AttendanceBtn.Location = New System.Drawing.Point(379, 0)
        Me.AttendanceBtn.Name = "AttendanceBtn"
        Me.AttendanceBtn.Size = New System.Drawing.Size(119, 68)
        Me.AttendanceBtn.TabIndex = 6
        Me.AttendanceBtn.Text = "Attendance"
        Me.AttendanceBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AttendanceBtn.UseVisualStyleBackColor = False
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Role_label)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 538)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1079, 30)
        Me.Guna2CustomGradientPanel1.TabIndex = 2
        '
        'Role_label
        '
        Me.Role_label.AutoSize = True
        Me.Role_label.BackColor = System.Drawing.Color.Transparent
        Me.Role_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Role_label.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Role_label.Location = New System.Drawing.Point(127, 9)
        Me.Role_label.Name = "Role_label"
        Me.Role_label.Size = New System.Drawing.Size(0, 13)
        Me.Role_label.TabIndex = 3
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImage = CType(resources.GetObject("Guna2PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(98, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(27, 23)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Logged in As :"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeYourPasswordToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(217, 26)
        '
        'ChangeYourPasswordToolStripMenuItem
        '
        Me.ChangeYourPasswordToolStripMenuItem.Name = "ChangeYourPasswordToolStripMenuItem"
        Me.ChangeYourPasswordToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ChangeYourPasswordToolStripMenuItem.Text = "Change Your Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1079, 568)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.Location = New System.Drawing.Point(528, 64)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(44, 45)
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1079, 568)
        Me.ShapeContainer2.TabIndex = 3
        Me.ShapeContainer2.TabStop = False
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClockinToolStripMenuItem, Me.AttendanceReportToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(198, 48)
        '
        'ClockinToolStripMenuItem
        '
        Me.ClockinToolStripMenuItem.Name = "ClockinToolStripMenuItem"
        Me.ClockinToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ClockinToolStripMenuItem.Text = "Clock-in / Clock-out"
        '
        'AttendanceReportToolStripMenuItem
        '
        Me.AttendanceReportToolStripMenuItem.Name = "AttendanceReportToolStripMenuItem"
        Me.AttendanceReportToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AttendanceReportToolStripMenuItem.Text = "Attendance Report"
        '
        'StaffProfile
        '
        Me.StaffProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StaffProfile.BackColor = System.Drawing.Color.Transparent
        Me.StaffProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StaffProfile.Image = CType(resources.GetObject("StaffProfile.Image"), System.Drawing.Image)
        Me.StaffProfile.Location = New System.Drawing.Point(776, 18)
        Me.StaffProfile.Name = "StaffProfile"
        Me.StaffProfile.Size = New System.Drawing.Size(35, 35)
        Me.StaffProfile.TabIndex = 3
        Me.StaffProfile.TabStop = False
        '
        'admin_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1079, 568)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "admin_dashboard"
        Me.Text = "Biometric Fingerprint Enrollment and Verification System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip3.ResumeLayout(False)
        CType(Me.StaffProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents VerificationBtn As System.Windows.Forms.Button
    Friend WithEvents EnrollmentBtn As System.Windows.Forms.Button
    Friend WithEvents AdminBtn As System.Windows.Forms.Button
    Friend WithEvents SettingsBtn As System.Windows.Forms.Button
    Friend WithEvents LabelDateTime As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RegisterNewStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewEditUsersRcordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewEditStaffRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Role_label As System.Windows.Forms.Label
    Friend WithEvents LogoutBtn As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ChangeYourPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StaffProfile As WindowsApplication1.CircleAvatar
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents AttendanceBtn As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClockinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
