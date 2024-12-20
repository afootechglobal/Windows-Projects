<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewloan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewloan))
        Me.loan_details_pic_box = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.profile_id = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.loan_id_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.fetch_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.total_loan_count_label_txt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.loan_schedule_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.loan_duration_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.loan_amount_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.phone_number_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.email_address_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.full_name_txt = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.loan_details_pic_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'loan_details_pic_box
        '
        Me.loan_details_pic_box.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Places_user_identity_128
        Me.loan_details_pic_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.loan_details_pic_box.BorderRadius = 5
        Me.loan_details_pic_box.Location = New System.Drawing.Point(9, 54)
        Me.loan_details_pic_box.Name = "loan_details_pic_box"
        Me.loan_details_pic_box.ShadowDecoration.Parent = Me.loan_details_pic_box
        Me.loan_details_pic_box.Size = New System.Drawing.Size(167, 209)
        Me.loan_details_pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loan_details_pic_box.TabIndex = 0
        Me.loan_details_pic_box.TabStop = False
        '
        'profile_id
        '
        Me.profile_id.BackColor = System.Drawing.Color.Transparent
        Me.profile_id.BorderRadius = 5
        Me.profile_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profile_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.profile_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.profile_id.FocusedColor = System.Drawing.Color.Empty
        Me.profile_id.FocusedState.Parent = Me.profile_id
        Me.profile_id.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile_id.ForeColor = System.Drawing.Color.Black
        Me.profile_id.FormattingEnabled = True
        Me.profile_id.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.profile_id.HoverState.Parent = Me.profile_id
        Me.profile_id.ItemHeight = 30
        Me.profile_id.ItemsAppearance.Parent = Me.profile_id
        Me.profile_id.Location = New System.Drawing.Point(9, 46)
        Me.profile_id.Name = "profile_id"
        Me.profile_id.ShadowDecoration.Parent = Me.profile_id
        Me.profile_id.Size = New System.Drawing.Size(560, 36)
        Me.profile_id.TabIndex = 8
        '
        'loan_id_txt
        '
        Me.loan_id_txt.BorderRadius = 5
        Me.loan_id_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.loan_id_txt.DefaultText = ""
        Me.loan_id_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.loan_id_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.loan_id_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_id_txt.DisabledState.Parent = Me.loan_id_txt
        Me.loan_id_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_id_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_id_txt.FocusedState.Parent = Me.loan_id_txt
        Me.loan_id_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_id_txt.ForeColor = System.Drawing.Color.Black
        Me.loan_id_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_id_txt.HoverState.Parent = Me.loan_id_txt
        Me.loan_id_txt.Location = New System.Drawing.Point(12, 365)
        Me.loan_id_txt.Name = "loan_id_txt"
        Me.loan_id_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loan_id_txt.PlaceholderText = "TOTAL INTEREST"
        Me.loan_id_txt.SelectedText = ""
        Me.loan_id_txt.ShadowDecoration.Parent = Me.loan_id_txt
        Me.loan_id_txt.Size = New System.Drawing.Size(351, 38)
        Me.loan_id_txt.TabIndex = 24
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.SystemColors.Control
        Me.clear_btn.BorderColor = System.Drawing.Color.Transparent
        Me.clear_btn.BorderRadius = 5
        Me.clear_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.clear_btn.CheckedState.Parent = Me.clear_btn
        Me.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.clear_btn.CustomImages.Parent = Me.clear_btn
        Me.clear_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.clear_btn.HoverState.Parent = Me.clear_btn
        Me.clear_btn.Location = New System.Drawing.Point(9, 90)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(126, 33)
        Me.clear_btn.TabIndex = 16
        Me.clear_btn.Text = "CLEAR"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 4
        Me.Guna2GroupBox1.Controls.Add(Me.clear_btn)
        Me.Guna2GroupBox1.Controls.Add(Me.fetch_btn)
        Me.Guna2GroupBox1.Controls.Add(Me.profile_id)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(11, 98)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(578, 132)
        Me.Guna2GroupBox1.TabIndex = 26
        Me.Guna2GroupBox1.Text = "PROFILE ID"
        '
        'fetch_btn
        '
        Me.fetch_btn.BackColor = System.Drawing.SystemColors.Control
        Me.fetch_btn.BorderColor = System.Drawing.Color.Transparent
        Me.fetch_btn.BorderRadius = 5
        Me.fetch_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.fetch_btn.CheckedState.Parent = Me.fetch_btn
        Me.fetch_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fetch_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.fetch_btn.CustomImages.Parent = Me.fetch_btn
        Me.fetch_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetch_btn.ForeColor = System.Drawing.Color.White
        Me.fetch_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fetch_btn.HoverState.Parent = Me.fetch_btn
        Me.fetch_btn.Location = New System.Drawing.Point(440, 90)
        Me.fetch_btn.Name = "fetch_btn"
        Me.fetch_btn.ShadowDecoration.Parent = Me.fetch_btn
        Me.fetch_btn.Size = New System.Drawing.Size(129, 33)
        Me.fetch_btn.TabIndex = 10
        Me.fetch_btn.Text = "FETCH"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(15, 348)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(43, 15)
        Me.Guna2HtmlLabel8.TabIndex = 23
        Me.Guna2HtmlLabel8.Text = "Loan ID"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.Controls.Add(Me.total_loan_count_label_txt)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel2.Controls.Add(Me.loan_schedule_btn)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(604, 43)
        Me.Guna2Panel2.TabIndex = 25
        '
        'total_loan_count_label_txt
        '
        Me.total_loan_count_label_txt.BackColor = System.Drawing.Color.Transparent
        Me.total_loan_count_label_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_loan_count_label_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.total_loan_count_label_txt.Location = New System.Drawing.Point(529, 10)
        Me.total_loan_count_label_txt.Name = "total_loan_count_label_txt"
        Me.total_loan_count_label_txt.Size = New System.Drawing.Size(11, 17)
        Me.total_loan_count_label_txt.TabIndex = 7
        Me.total_loan_count_label_txt.Text = "0"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(438, 12)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(80, 15)
        Me.Guna2HtmlLabel2.TabIndex = 6
        Me.Guna2HtmlLabel2.Text = "TOTAL LOAN"
        '
        'loan_schedule_btn
        '
        Me.loan_schedule_btn.BackColor = System.Drawing.Color.Silver
        Me.loan_schedule_btn.BorderColor = System.Drawing.Color.Transparent
        Me.loan_schedule_btn.BorderRadius = 5
        Me.loan_schedule_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.loan_schedule_btn.CheckedState.Parent = Me.loan_schedule_btn
        Me.loan_schedule_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loan_schedule_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.loan_schedule_btn.CustomImages.Parent = Me.loan_schedule_btn
        Me.loan_schedule_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_schedule_btn.ForeColor = System.Drawing.Color.White
        Me.loan_schedule_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loan_schedule_btn.HoverState.Parent = Me.loan_schedule_btn
        Me.loan_schedule_btn.Location = New System.Drawing.Point(13, 7)
        Me.loan_schedule_btn.Name = "loan_schedule_btn"
        Me.loan_schedule_btn.ShadowDecoration.Parent = Me.loan_schedule_btn
        Me.loan_schedule_btn.Size = New System.Drawing.Size(131, 30)
        Me.loan_schedule_btn.TabIndex = 4
        Me.loan_schedule_btn.Text = "LOAN SCHEDULE"
        '
        'loan_duration_txt
        '
        Me.loan_duration_txt.BorderRadius = 5
        Me.loan_duration_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.loan_duration_txt.DefaultText = ""
        Me.loan_duration_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.loan_duration_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.loan_duration_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_duration_txt.DisabledState.Parent = Me.loan_duration_txt
        Me.loan_duration_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_duration_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_duration_txt.FocusedState.Parent = Me.loan_duration_txt
        Me.loan_duration_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_duration_txt.ForeColor = System.Drawing.Color.Black
        Me.loan_duration_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_duration_txt.HoverState.Parent = Me.loan_duration_txt
        Me.loan_duration_txt.Location = New System.Drawing.Point(12, 303)
        Me.loan_duration_txt.Name = "loan_duration_txt"
        Me.loan_duration_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loan_duration_txt.PlaceholderText = "LOAN DURATION"
        Me.loan_duration_txt.SelectedText = ""
        Me.loan_duration_txt.ShadowDecoration.Parent = Me.loan_duration_txt
        Me.loan_duration_txt.Size = New System.Drawing.Size(351, 38)
        Me.loan_duration_txt.TabIndex = 22
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.close_btn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(604, 48)
        Me.Guna2Panel1.TabIndex = 24
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(44, 13)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(90, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "LOAN DETAIL"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources._5409308_middle2
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(38, 43)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.Animated = True
        Me.close_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.close_btn.BorderRadius = 19
        Me.close_btn.CheckedState.Parent = Me.close_btn
        Me.close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_btn.CustomImages.Parent = Me.close_btn
        Me.close_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.Color.White
        Me.close_btn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.close_btn.HoverState.Parent = Me.close_btn
        Me.close_btn.Location = New System.Drawing.Point(563, 4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(36, 40)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        '
        'loan_amount_txt
        '
        Me.loan_amount_txt.BorderRadius = 5
        Me.loan_amount_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.loan_amount_txt.DefaultText = ""
        Me.loan_amount_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.loan_amount_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.loan_amount_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_amount_txt.DisabledState.Parent = Me.loan_amount_txt
        Me.loan_amount_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_amount_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_amount_txt.FocusedState.Parent = Me.loan_amount_txt
        Me.loan_amount_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_amount_txt.ForeColor = System.Drawing.Color.Black
        Me.loan_amount_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_amount_txt.HoverState.Parent = Me.loan_amount_txt
        Me.loan_amount_txt.Location = New System.Drawing.Point(12, 241)
        Me.loan_amount_txt.Name = "loan_amount_txt"
        Me.loan_amount_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loan_amount_txt.PlaceholderText = "LOAN AMOUNT"
        Me.loan_amount_txt.SelectedText = ""
        Me.loan_amount_txt.ShadowDecoration.Parent = Me.loan_amount_txt
        Me.loan_amount_txt.Size = New System.Drawing.Size(351, 38)
        Me.loan_amount_txt.TabIndex = 21
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(15, 225)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(75, 15)
        Me.Guna2HtmlLabel6.TabIndex = 14
        Me.Guna2HtmlLabel6.Text = "Loan Amount"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(15, 103)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(76, 15)
        Me.Guna2HtmlLabel5.TabIndex = 11
        Me.Guna2HtmlLabel5.Text = "Email Address"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(15, 286)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(78, 15)
        Me.Guna2HtmlLabel7.TabIndex = 20
        Me.Guna2HtmlLabel7.Text = "Loan Duration"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(15, 164)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(83, 15)
        Me.Guna2HtmlLabel3.TabIndex = 10
        Me.Guna2HtmlLabel3.Text = "Phone Number"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(15, 41)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(53, 15)
        Me.Guna2HtmlLabel4.TabIndex = 9
        Me.Guna2HtmlLabel4.Text = "FullName"
        '
        'phone_number_txt
        '
        Me.phone_number_txt.BorderRadius = 5
        Me.phone_number_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phone_number_txt.DefaultText = ""
        Me.phone_number_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.phone_number_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.phone_number_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phone_number_txt.DisabledState.Parent = Me.phone_number_txt
        Me.phone_number_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phone_number_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phone_number_txt.FocusedState.Parent = Me.phone_number_txt
        Me.phone_number_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone_number_txt.ForeColor = System.Drawing.Color.Black
        Me.phone_number_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phone_number_txt.HoverState.Parent = Me.phone_number_txt
        Me.phone_number_txt.Location = New System.Drawing.Point(13, 181)
        Me.phone_number_txt.Name = "phone_number_txt"
        Me.phone_number_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.phone_number_txt.PlaceholderText = "PHONE NUMBER"
        Me.phone_number_txt.SelectedText = ""
        Me.phone_number_txt.ShadowDecoration.Parent = Me.phone_number_txt
        Me.phone_number_txt.Size = New System.Drawing.Size(351, 38)
        Me.phone_number_txt.TabIndex = 8
        '
        'email_address_txt
        '
        Me.email_address_txt.BorderRadius = 5
        Me.email_address_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_address_txt.DefaultText = ""
        Me.email_address_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email_address_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email_address_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_address_txt.DisabledState.Parent = Me.email_address_txt
        Me.email_address_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_address_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_address_txt.FocusedState.Parent = Me.email_address_txt
        Me.email_address_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_address_txt.ForeColor = System.Drawing.Color.Black
        Me.email_address_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_address_txt.HoverState.Parent = Me.email_address_txt
        Me.email_address_txt.Location = New System.Drawing.Point(13, 120)
        Me.email_address_txt.Name = "email_address_txt"
        Me.email_address_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_address_txt.PlaceholderText = "EMAIL ADDRESS"
        Me.email_address_txt.SelectedText = ""
        Me.email_address_txt.ShadowDecoration.Parent = Me.email_address_txt
        Me.email_address_txt.Size = New System.Drawing.Size(351, 38)
        Me.email_address_txt.TabIndex = 7
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BorderRadius = 4
        Me.Guna2GroupBox3.Controls.Add(Me.loan_details_pic_box)
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(404, 236)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(185, 279)
        Me.Guna2GroupBox3.TabIndex = 28
        Me.Guna2GroupBox3.Text = "Passport"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 4
        Me.Guna2GroupBox2.Controls.Add(Me.loan_id_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2GroupBox2.Controls.Add(Me.loan_duration_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.loan_amount_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GroupBox2.Controls.Add(Me.phone_number_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.email_address_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.full_name_txt)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(13, 236)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(375, 417)
        Me.Guna2GroupBox2.TabIndex = 27
        Me.Guna2GroupBox2.Text = "Customer Information"
        '
        'full_name_txt
        '
        Me.full_name_txt.BorderRadius = 5
        Me.full_name_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.full_name_txt.DefaultText = ""
        Me.full_name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.full_name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.full_name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.full_name_txt.DisabledState.Parent = Me.full_name_txt
        Me.full_name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.full_name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.full_name_txt.FocusedState.Parent = Me.full_name_txt
        Me.full_name_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.full_name_txt.ForeColor = System.Drawing.Color.Black
        Me.full_name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.full_name_txt.HoverState.Parent = Me.full_name_txt
        Me.full_name_txt.Location = New System.Drawing.Point(13, 58)
        Me.full_name_txt.Name = "full_name_txt"
        Me.full_name_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.full_name_txt.PlaceholderText = "FULLNAME"
        Me.full_name_txt.SelectedText = ""
        Me.full_name_txt.ShadowDecoration.Parent = Me.full_name_txt
        Me.full_name_txt.Size = New System.Drawing.Size(351, 38)
        Me.full_name_txt.TabIndex = 6
        '
        'viewloan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 668)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2GroupBox3)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "viewloan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "viewloan"
        Me.TopMost = True
        CType(Me.loan_details_pic_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents loan_details_pic_box As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents profile_id As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents loan_id_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents fetch_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents total_loan_count_label_txt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents loan_schedule_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents loan_duration_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents loan_amount_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents phone_number_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents email_address_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents full_name_txt As Guna.UI2.WinForms.Guna2TextBox
End Class
