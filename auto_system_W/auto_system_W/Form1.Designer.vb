<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.clear_button = New System.Windows.Forms.Button()
        Me.save_button = New System.Windows.Forms.Button()
        Me.RegistrationPanel = New System.Windows.Forms.Panel()
        Me.MyGroupBox4 = New auto_system_W.myGroupBox()
        Me.recordcount_label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mastercount_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MyGroupBox1 = New auto_system_W.myGroupBox()
        Me.delete_button = New System.Windows.Forms.Button()
        Me.fetchprofile_button = New System.Windows.Forms.Button()
        Me.profile_id = New System.Windows.Forms.ComboBox()
        Me.MyGroupBox2 = New auto_system_W.myGroupBox()
        Me.phoneno_label = New System.Windows.Forms.Label()
        Me.email_label = New System.Windows.Forms.Label()
        Me.fullname_label = New System.Windows.Forms.Label()
        Me.phoneno_txt = New System.Windows.Forms.TextBox()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.fullname_txt = New System.Windows.Forms.TextBox()
        Me.MyGroupBox3 = New auto_system_W.myGroupBox()
        Me.passport = New System.Windows.Forms.PictureBox()
        Me.selectpassport_button = New System.Windows.Forms.Button()
        Me.Activation_panel = New System.Windows.Forms.Panel()
        Me.Activation_panel_okay = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RECORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Record_Panel = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FileBack = New System.Windows.Forms.Button()
        Me.DeletePanel = New System.Windows.Forms.Panel()
        Me.DeleteOkay = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SaveUpdated_Panel = New System.Windows.Forms.Panel()
        Me.SaveToolOkay = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.RegistrationPanel.SuspendLayout()
        Me.MyGroupBox4.SuspendLayout()
        Me.MyGroupBox1.SuspendLayout()
        Me.MyGroupBox2.SuspendLayout()
        Me.MyGroupBox3.SuspendLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Activation_panel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Record_Panel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeletePanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaveUpdated_Panel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clear_button
        '
        Me.clear_button.BackColor = System.Drawing.Color.LightPink
        Me.clear_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_button.FlatAppearance.BorderSize = 0
        Me.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_button.Location = New System.Drawing.Point(24, 368)
        Me.clear_button.Name = "clear_button"
        Me.clear_button.Size = New System.Drawing.Size(192, 49)
        Me.clear_button.TabIndex = 23
        Me.clear_button.Text = "CLEAR"
        Me.clear_button.UseVisualStyleBackColor = False
        '
        'save_button
        '
        Me.save_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.save_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save_button.FlatAppearance.BorderSize = 0
        Me.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_button.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.save_button.Location = New System.Drawing.Point(256, 368)
        Me.save_button.Name = "save_button"
        Me.save_button.Size = New System.Drawing.Size(192, 49)
        Me.save_button.TabIndex = 24
        Me.save_button.Text = "SUBMIT"
        Me.save_button.UseVisualStyleBackColor = False
        '
        'RegistrationPanel
        '
        Me.RegistrationPanel.Controls.Add(Me.MyGroupBox4)
        Me.RegistrationPanel.Controls.Add(Me.clear_button)
        Me.RegistrationPanel.Controls.Add(Me.save_button)
        Me.RegistrationPanel.Controls.Add(Me.MyGroupBox1)
        Me.RegistrationPanel.Controls.Add(Me.MyGroupBox2)
        Me.RegistrationPanel.Controls.Add(Me.MyGroupBox3)
        Me.RegistrationPanel.Location = New System.Drawing.Point(-3, 27)
        Me.RegistrationPanel.Name = "RegistrationPanel"
        Me.RegistrationPanel.Size = New System.Drawing.Size(681, 505)
        Me.RegistrationPanel.TabIndex = 25
        '
        'MyGroupBox4
        '
        Me.MyGroupBox4.BorderColour = System.Drawing.Color.Lavender
        Me.MyGroupBox4.Controls.Add(Me.recordcount_label)
        Me.MyGroupBox4.Controls.Add(Me.Label2)
        Me.MyGroupBox4.Controls.Add(Me.mastercount_label)
        Me.MyGroupBox4.Controls.Add(Me.Label1)
        Me.MyGroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyGroupBox4.Location = New System.Drawing.Point(469, 289)
        Me.MyGroupBox4.Name = "MyGroupBox4"
        Me.MyGroupBox4.Size = New System.Drawing.Size(185, 128)
        Me.MyGroupBox4.TabIndex = 25
        Me.MyGroupBox4.TabStop = False
        Me.MyGroupBox4.Text = "COUNT STATITICS"
        '
        'recordcount_label
        '
        Me.recordcount_label.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.recordcount_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recordcount_label.ForeColor = System.Drawing.Color.DarkRed
        Me.recordcount_label.Location = New System.Drawing.Point(42, 98)
        Me.recordcount_label.Name = "recordcount_label"
        Me.recordcount_label.Size = New System.Drawing.Size(51, 19)
        Me.recordcount_label.TabIndex = 32
        Me.recordcount_label.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "-RECORD COUNT"
        '
        'mastercount_label
        '
        Me.mastercount_label.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.mastercount_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mastercount_label.ForeColor = System.Drawing.Color.DarkRed
        Me.mastercount_label.Location = New System.Drawing.Point(40, 46)
        Me.mastercount_label.Name = "mastercount_label"
        Me.mastercount_label.Size = New System.Drawing.Size(51, 19)
        Me.mastercount_label.TabIndex = 30
        Me.mastercount_label.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "-MASTER COUNT"
        '
        'MyGroupBox1
        '
        Me.MyGroupBox1.BorderColour = System.Drawing.Color.Lavender
        Me.MyGroupBox1.Controls.Add(Me.delete_button)
        Me.MyGroupBox1.Controls.Add(Me.fetchprofile_button)
        Me.MyGroupBox1.Controls.Add(Me.profile_id)
        Me.MyGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyGroupBox1.Location = New System.Drawing.Point(24, 39)
        Me.MyGroupBox1.Name = "MyGroupBox1"
        Me.MyGroupBox1.Size = New System.Drawing.Size(424, 112)
        Me.MyGroupBox1.TabIndex = 20
        Me.MyGroupBox1.TabStop = False
        Me.MyGroupBox1.Text = "PROFILE ID"
        '
        'delete_button
        '
        Me.delete_button.BackColor = System.Drawing.Color.LightPink
        Me.delete_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete_button.FlatAppearance.BorderSize = 0
        Me.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_button.Location = New System.Drawing.Point(138, 66)
        Me.delete_button.Name = "delete_button"
        Me.delete_button.Size = New System.Drawing.Size(70, 37)
        Me.delete_button.TabIndex = 2
        Me.delete_button.Text = "DELETE"
        Me.delete_button.UseVisualStyleBackColor = False
        '
        'fetchprofile_button
        '
        Me.fetchprofile_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.fetchprofile_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fetchprofile_button.FlatAppearance.BorderSize = 0
        Me.fetchprofile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fetchprofile_button.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.fetchprofile_button.Location = New System.Drawing.Point(8, 65)
        Me.fetchprofile_button.Name = "fetchprofile_button"
        Me.fetchprofile_button.Size = New System.Drawing.Size(112, 39)
        Me.fetchprofile_button.TabIndex = 1
        Me.fetchprofile_button.Text = "FETCH PROFILE"
        Me.fetchprofile_button.UseVisualStyleBackColor = False
        '
        'profile_id
        '
        Me.profile_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profile_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.profile_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile_id.FormattingEnabled = True
        Me.profile_id.Location = New System.Drawing.Point(8, 24)
        Me.profile_id.Name = "profile_id"
        Me.profile_id.Size = New System.Drawing.Size(409, 32)
        Me.profile_id.TabIndex = 0
        '
        'MyGroupBox2
        '
        Me.MyGroupBox2.BorderColour = System.Drawing.Color.Lavender
        Me.MyGroupBox2.Controls.Add(Me.phoneno_label)
        Me.MyGroupBox2.Controls.Add(Me.email_label)
        Me.MyGroupBox2.Controls.Add(Me.fullname_label)
        Me.MyGroupBox2.Controls.Add(Me.phoneno_txt)
        Me.MyGroupBox2.Controls.Add(Me.email_txt)
        Me.MyGroupBox2.Controls.Add(Me.fullname_txt)
        Me.MyGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyGroupBox2.Location = New System.Drawing.Point(24, 173)
        Me.MyGroupBox2.Name = "MyGroupBox2"
        Me.MyGroupBox2.Size = New System.Drawing.Size(424, 172)
        Me.MyGroupBox2.TabIndex = 21
        Me.MyGroupBox2.TabStop = False
        Me.MyGroupBox2.Text = "REGISTRATION PANEL"
        '
        'phoneno_label
        '
        Me.phoneno_label.AutoSize = True
        Me.phoneno_label.BackColor = System.Drawing.SystemColors.Window
        Me.phoneno_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneno_label.Location = New System.Drawing.Point(16, 128)
        Me.phoneno_label.Name = "phoneno_label"
        Me.phoneno_label.Size = New System.Drawing.Size(95, 13)
        Me.phoneno_label.TabIndex = 5
        Me.phoneno_label.Text = "PHONE NUMBER"
        '
        'email_label
        '
        Me.email_label.AutoSize = True
        Me.email_label.BackColor = System.Drawing.SystemColors.Window
        Me.email_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_label.Location = New System.Drawing.Point(16, 85)
        Me.email_label.Name = "email_label"
        Me.email_label.Size = New System.Drawing.Size(39, 13)
        Me.email_label.TabIndex = 4
        Me.email_label.Text = "EMAIL"
        '
        'fullname_label
        '
        Me.fullname_label.AutoSize = True
        Me.fullname_label.BackColor = System.Drawing.SystemColors.Window
        Me.fullname_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname_label.Location = New System.Drawing.Point(16, 44)
        Me.fullname_label.Name = "fullname_label"
        Me.fullname_label.Size = New System.Drawing.Size(64, 13)
        Me.fullname_label.TabIndex = 3
        Me.fullname_label.Text = "FULLNAME"
        '
        'phoneno_txt
        '
        Me.phoneno_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.phoneno_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneno_txt.Location = New System.Drawing.Point(8, 116)
        Me.phoneno_txt.Multiline = True
        Me.phoneno_txt.Name = "phoneno_txt"
        Me.phoneno_txt.Size = New System.Drawing.Size(409, 38)
        Me.phoneno_txt.TabIndex = 2
        '
        'email_txt
        '
        Me.email_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.email_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_txt.Location = New System.Drawing.Point(8, 73)
        Me.email_txt.Multiline = True
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(409, 38)
        Me.email_txt.TabIndex = 1
        '
        'fullname_txt
        '
        Me.fullname_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fullname_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname_txt.Location = New System.Drawing.Point(8, 30)
        Me.fullname_txt.Multiline = True
        Me.fullname_txt.Name = "fullname_txt"
        Me.fullname_txt.Size = New System.Drawing.Size(409, 38)
        Me.fullname_txt.TabIndex = 0
        '
        'MyGroupBox3
        '
        Me.MyGroupBox3.BorderColour = System.Drawing.Color.Lavender
        Me.MyGroupBox3.Controls.Add(Me.passport)
        Me.MyGroupBox3.Controls.Add(Me.selectpassport_button)
        Me.MyGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyGroupBox3.Location = New System.Drawing.Point(469, 39)
        Me.MyGroupBox3.Name = "MyGroupBox3"
        Me.MyGroupBox3.Size = New System.Drawing.Size(185, 232)
        Me.MyGroupBox3.TabIndex = 22
        Me.MyGroupBox3.TabStop = False
        Me.MyGroupBox3.Text = "PROFILE PICTURE"
        '
        'passport
        '
        Me.passport.BackColor = System.Drawing.SystemColors.Menu
        Me.passport.BackgroundImage = CType(resources.GetObject("passport.BackgroundImage"), System.Drawing.Image)
        Me.passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.passport.Location = New System.Drawing.Point(6, 19)
        Me.passport.Name = "passport"
        Me.passport.Size = New System.Drawing.Size(173, 150)
        Me.passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passport.TabIndex = 26
        Me.passport.TabStop = False
        '
        'selectpassport_button
        '
        Me.selectpassport_button.BackColor = System.Drawing.Color.LightSteelBlue
        Me.selectpassport_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selectpassport_button.FlatAppearance.BorderSize = 0
        Me.selectpassport_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectpassport_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectpassport_button.Location = New System.Drawing.Point(6, 174)
        Me.selectpassport_button.Name = "selectpassport_button"
        Me.selectpassport_button.Size = New System.Drawing.Size(173, 48)
        Me.selectpassport_button.TabIndex = 25
        Me.selectpassport_button.Text = "SELECT PASSPORT"
        Me.selectpassport_button.UseVisualStyleBackColor = False
        '
        'Activation_panel
        '
        Me.Activation_panel.BackColor = System.Drawing.SystemColors.ControlText
        Me.Activation_panel.Controls.Add(Me.Activation_panel_okay)
        Me.Activation_panel.Controls.Add(Me.Label3)
        Me.Activation_panel.Controls.Add(Me.PictureBox2)
        Me.Activation_panel.Location = New System.Drawing.Point(-3, 27)
        Me.Activation_panel.Name = "Activation_panel"
        Me.Activation_panel.Size = New System.Drawing.Size(681, 505)
        Me.Activation_panel.TabIndex = 26
        '
        'Activation_panel_okay
        '
        Me.Activation_panel_okay.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Activation_panel_okay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Activation_panel_okay.FlatAppearance.BorderSize = 0
        Me.Activation_panel_okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Activation_panel_okay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Activation_panel_okay.Location = New System.Drawing.Point(189, 358)
        Me.Activation_panel_okay.Name = "Activation_panel_okay"
        Me.Activation_panel_okay.Size = New System.Drawing.Size(280, 47)
        Me.Activation_panel_okay.TabIndex = 2
        Me.Activation_panel_okay.Text = "OKAY"
        Me.Activation_panel_okay.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(8, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(661, 41)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "REGISTRATION SUCCESSFULLY SAVED"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(189, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(280, 253)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.HeaderPanel.Controls.Add(Me.MenuStrip1)
        Me.HeaderPanel.Location = New System.Drawing.Point(-3, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(680, 36)
        Me.HeaderPanel.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(680, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RECORDToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'RECORDToolStripMenuItem
        '
        Me.RECORDToolStripMenuItem.Name = "RECORDToolStripMenuItem"
        Me.RECORDToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.RECORDToolStripMenuItem.Text = "RECORD"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.SAVEToolStripMenuItem.Text = "SAVE"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'Record_Panel
        '
        Me.Record_Panel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Record_Panel.Controls.Add(Me.DataGridView1)
        Me.Record_Panel.Controls.Add(Me.FileBack)
        Me.Record_Panel.Location = New System.Drawing.Point(-3, -26)
        Me.Record_Panel.Name = "Record_Panel"
        Me.Record_Panel.Size = New System.Drawing.Size(681, 505)
        Me.Record_Panel.TabIndex = 27
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(681, 381)
        Me.DataGridView1.TabIndex = 2
        '
        'FileBack
        '
        Me.FileBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FileBack.FlatAppearance.BorderSize = 0
        Me.FileBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FileBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileBack.Location = New System.Drawing.Point(285, 455)
        Me.FileBack.Name = "FileBack"
        Me.FileBack.Size = New System.Drawing.Size(114, 38)
        Me.FileBack.TabIndex = 1
        Me.FileBack.Text = "BACK"
        Me.FileBack.UseVisualStyleBackColor = True
        '
        'DeletePanel
        '
        Me.DeletePanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.DeletePanel.Controls.Add(Me.DeleteOkay)
        Me.DeletePanel.Controls.Add(Me.Label4)
        Me.DeletePanel.Controls.Add(Me.PictureBox3)
        Me.DeletePanel.Location = New System.Drawing.Point(-3, -14)
        Me.DeletePanel.Name = "DeletePanel"
        Me.DeletePanel.Size = New System.Drawing.Size(681, 505)
        Me.DeletePanel.TabIndex = 28
        '
        'DeleteOkay
        '
        Me.DeleteOkay.BackColor = System.Drawing.SystemColors.ControlDark
        Me.DeleteOkay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteOkay.FlatAppearance.BorderSize = 0
        Me.DeleteOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteOkay.Location = New System.Drawing.Point(189, 387)
        Me.DeleteOkay.Name = "DeleteOkay"
        Me.DeleteOkay.Size = New System.Drawing.Size(280, 47)
        Me.DeleteOkay.TabIndex = 2
        Me.DeleteOkay.Text = "OKAY"
        Me.DeleteOkay.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(2, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(677, 49)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "PROFILE SUCCESSFULLY DELETED"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(189, 80)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(280, 253)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'SaveUpdated_Panel
        '
        Me.SaveUpdated_Panel.BackColor = System.Drawing.SystemColors.ControlText
        Me.SaveUpdated_Panel.Controls.Add(Me.SaveToolOkay)
        Me.SaveUpdated_Panel.Controls.Add(Me.Label5)
        Me.SaveUpdated_Panel.Controls.Add(Me.PictureBox4)
        Me.SaveUpdated_Panel.Location = New System.Drawing.Point(0, -6)
        Me.SaveUpdated_Panel.Name = "SaveUpdated_Panel"
        Me.SaveUpdated_Panel.Size = New System.Drawing.Size(686, 505)
        Me.SaveUpdated_Panel.TabIndex = 30
        '
        'SaveToolOkay
        '
        Me.SaveToolOkay.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SaveToolOkay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveToolOkay.FlatAppearance.BorderSize = 0
        Me.SaveToolOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveToolOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveToolOkay.Location = New System.Drawing.Point(189, 387)
        Me.SaveToolOkay.Name = "SaveToolOkay"
        Me.SaveToolOkay.Size = New System.Drawing.Size(280, 47)
        Me.SaveToolOkay.TabIndex = 2
        Me.SaveToolOkay.Text = "OKAY"
        Me.SaveToolOkay.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MV Boli", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(-6, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(687, 49)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "PROFILE SUCCESSFULLY UPDATED"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(189, 80)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(280, 253)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(675, 476)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.RegistrationPanel)
        Me.Controls.Add(Me.SaveUpdated_Panel)
        Me.Controls.Add(Me.DeletePanel)
        Me.Controls.Add(Me.Activation_panel)
        Me.Controls.Add(Me.Record_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AUTO SYSTEM"
        Me.RegistrationPanel.ResumeLayout(False)
        Me.MyGroupBox4.ResumeLayout(False)
        Me.MyGroupBox4.PerformLayout()
        Me.MyGroupBox1.ResumeLayout(False)
        Me.MyGroupBox2.ResumeLayout(False)
        Me.MyGroupBox2.PerformLayout()
        Me.MyGroupBox3.ResumeLayout(False)
        CType(Me.passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Activation_panel.ResumeLayout(False)
        Me.Activation_panel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Record_Panel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeletePanel.ResumeLayout(False)
        Me.DeletePanel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaveUpdated_Panel.ResumeLayout(False)
        Me.SaveUpdated_Panel.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyGroupBox2 As auto_system_W.myGroupBox
    Friend WithEvents clear_button As System.Windows.Forms.Button
    Friend WithEvents save_button As System.Windows.Forms.Button
    Friend WithEvents MyGroupBox4 As auto_system_W.myGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents recordcount_label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mastercount_label As System.Windows.Forms.Label
    Friend WithEvents profile_id As System.Windows.Forms.ComboBox
    Friend WithEvents fetchprofile_button As System.Windows.Forms.Button
    Friend WithEvents delete_button As System.Windows.Forms.Button
    Friend WithEvents MyGroupBox1 As auto_system_W.myGroupBox
    Friend WithEvents RegistrationPanel As System.Windows.Forms.Panel
    Friend WithEvents Activation_panel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RECORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Activation_panel_okay As System.Windows.Forms.Button
    Friend WithEvents Record_Panel As System.Windows.Forms.Panel
    Friend WithEvents FileBack As System.Windows.Forms.Button
    Friend WithEvents DeletePanel As System.Windows.Forms.Panel
    Friend WithEvents DeleteOkay As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents fullname_txt As System.Windows.Forms.TextBox
    Friend WithEvents phoneno_txt As System.Windows.Forms.TextBox
    Friend WithEvents email_txt As System.Windows.Forms.TextBox
    Friend WithEvents phoneno_label As System.Windows.Forms.Label
    Friend WithEvents email_label As System.Windows.Forms.Label
    Friend WithEvents SAVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveUpdated_Panel As System.Windows.Forms.Panel
    Friend WithEvents SaveToolOkay As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents fullname_label As System.Windows.Forms.Label
    Friend WithEvents MyGroupBox3 As auto_system_W.myGroupBox
    Friend WithEvents passport As System.Windows.Forms.PictureBox
    Friend WithEvents selectpassport_button As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
