<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logoutBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.settings_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.deposit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.view_loan_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.view_customer_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.view_admin_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.last_login_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.staff_fullname_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.passport = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.date_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.time_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.total_balance_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.total_loan_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.total_customer_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.total_admin_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Panel1.Controls.Add(Me.logoutBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1252, 81)
        Me.Panel1.TabIndex = 0
        '
        'logoutBtn
        '
        Me.logoutBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logoutBtn.Animated = True
        Me.logoutBtn.BorderRadius = 5
        Me.logoutBtn.CheckedState.Parent = Me.logoutBtn
        Me.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutBtn.CustomImages.Parent = Me.logoutBtn
        Me.logoutBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.logoutBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.logoutBtn.ForeColor = System.Drawing.Color.White
        Me.logoutBtn.HoverState.Parent = Me.logoutBtn
        Me.logoutBtn.Image = Global.bank_application.My.Resources.Resources.login1
        Me.logoutBtn.ImageSize = New System.Drawing.Size(15, 15)
        Me.logoutBtn.Location = New System.Drawing.Point(1140, 24)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.ShadowDecoration.Parent = Me.logoutBtn
        Me.logoutBtn.Size = New System.Drawing.Size(96, 40)
        Me.logoutBtn.TabIndex = 5
        Me.logoutBtn.Text = "LOG-OUT"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.settings_btn)
        Me.Panel2.Controls.Add(Me.deposit_btn)
        Me.Panel2.Controls.Add(Me.view_loan_btn)
        Me.Panel2.Controls.Add(Me.view_customer_btn)
        Me.Panel2.Controls.Add(Me.view_admin_btn)
        Me.Panel2.Controls.Add(Me.Guna2Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(230, 417)
        Me.Panel2.TabIndex = 1
        '
        'settings_btn
        '
        Me.settings_btn.Animated = True
        Me.settings_btn.CheckedState.Parent = Me.settings_btn
        Me.settings_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settings_btn.CustomImages.Parent = Me.settings_btn
        Me.settings_btn.FillColor = System.Drawing.Color.Gray
        Me.settings_btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.settings_btn.ForeColor = System.Drawing.Color.White
        Me.settings_btn.HoverState.Parent = Me.settings_btn
        Me.settings_btn.Location = New System.Drawing.Point(0, 310)
        Me.settings_btn.Name = "settings_btn"
        Me.settings_btn.ShadowDecoration.Parent = Me.settings_btn
        Me.settings_btn.Size = New System.Drawing.Size(230, 60)
        Me.settings_btn.TabIndex = 9
        Me.settings_btn.Text = "Settings"
        '
        'deposit_btn
        '
        Me.deposit_btn.Animated = True
        Me.deposit_btn.CheckedState.Parent = Me.deposit_btn
        Me.deposit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deposit_btn.CustomImages.Parent = Me.deposit_btn
        Me.deposit_btn.FillColor = System.Drawing.Color.Gray
        Me.deposit_btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.deposit_btn.ForeColor = System.Drawing.Color.White
        Me.deposit_btn.HoverState.Parent = Me.deposit_btn
        Me.deposit_btn.Location = New System.Drawing.Point(0, 248)
        Me.deposit_btn.Name = "deposit_btn"
        Me.deposit_btn.ShadowDecoration.Parent = Me.deposit_btn
        Me.deposit_btn.Size = New System.Drawing.Size(230, 60)
        Me.deposit_btn.TabIndex = 8
        Me.deposit_btn.Text = "Deposit"
        '
        'view_loan_btn
        '
        Me.view_loan_btn.Animated = True
        Me.view_loan_btn.CheckedState.Parent = Me.view_loan_btn
        Me.view_loan_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_loan_btn.CustomImages.Parent = Me.view_loan_btn
        Me.view_loan_btn.FillColor = System.Drawing.Color.Gray
        Me.view_loan_btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.view_loan_btn.ForeColor = System.Drawing.Color.White
        Me.view_loan_btn.HoverState.Parent = Me.view_loan_btn
        Me.view_loan_btn.Location = New System.Drawing.Point(0, 186)
        Me.view_loan_btn.Name = "view_loan_btn"
        Me.view_loan_btn.ShadowDecoration.Parent = Me.view_loan_btn
        Me.view_loan_btn.Size = New System.Drawing.Size(230, 60)
        Me.view_loan_btn.TabIndex = 7
        Me.view_loan_btn.Text = "View loan"
        '
        'view_customer_btn
        '
        Me.view_customer_btn.Animated = True
        Me.view_customer_btn.CheckedState.Parent = Me.view_customer_btn
        Me.view_customer_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_customer_btn.CustomImages.Parent = Me.view_customer_btn
        Me.view_customer_btn.FillColor = System.Drawing.Color.Gray
        Me.view_customer_btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.view_customer_btn.ForeColor = System.Drawing.Color.White
        Me.view_customer_btn.HoverState.Parent = Me.view_customer_btn
        Me.view_customer_btn.Location = New System.Drawing.Point(0, 124)
        Me.view_customer_btn.Name = "view_customer_btn"
        Me.view_customer_btn.ShadowDecoration.Parent = Me.view_customer_btn
        Me.view_customer_btn.Size = New System.Drawing.Size(230, 60)
        Me.view_customer_btn.TabIndex = 6
        Me.view_customer_btn.Text = "View Customers"
        '
        'view_admin_btn
        '
        Me.view_admin_btn.Animated = True
        Me.view_admin_btn.CheckedState.Parent = Me.view_admin_btn
        Me.view_admin_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_admin_btn.CustomImages.Parent = Me.view_admin_btn
        Me.view_admin_btn.FillColor = System.Drawing.Color.Gray
        Me.view_admin_btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.view_admin_btn.ForeColor = System.Drawing.Color.White
        Me.view_admin_btn.HoverState.Parent = Me.view_admin_btn
        Me.view_admin_btn.Location = New System.Drawing.Point(0, 62)
        Me.view_admin_btn.Name = "view_admin_btn"
        Me.view_admin_btn.ShadowDecoration.Parent = Me.view_admin_btn
        Me.view_admin_btn.Size = New System.Drawing.Size(230, 60)
        Me.view_admin_btn.TabIndex = 5
        Me.view_admin_btn.Text = "View Admin"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Gray
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(230, 60)
        Me.Guna2Button1.TabIndex = 4
        Me.Guna2Button1.Text = "Dashboard"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.last_login_label)
        Me.Guna2Panel1.Controls.Add(Me.staff_fullname_label)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.passport)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(246, 93)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(759, 100)
        Me.Guna2Panel1.TabIndex = 2
        '
        'last_login_label
        '
        Me.last_login_label.BackColor = System.Drawing.Color.Transparent
        Me.last_login_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_login_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.last_login_label.Location = New System.Drawing.Point(104, 62)
        Me.last_login_label.Name = "last_login_label"
        Me.last_login_label.Size = New System.Drawing.Size(18, 15)
        Me.last_login_label.TabIndex = 4
        Me.last_login_label.Text = "xxx"
        '
        'staff_fullname_label
        '
        Me.staff_fullname_label.BackColor = System.Drawing.Color.Transparent
        Me.staff_fullname_label.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staff_fullname_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.staff_fullname_label.Location = New System.Drawing.Point(104, 42)
        Me.staff_fullname_label.Name = "staff_fullname_label"
        Me.staff_fullname_label.Size = New System.Drawing.Size(30, 19)
        Me.staff_fullname_label.TabIndex = 3
        Me.staff_fullname_label.Text = "XXX"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(104, 23)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(112, 18)
        Me.Guna2HtmlLabel2.TabIndex = 2
        Me.Guna2HtmlLabel2.Text = "Admin Dashboard"
        '
        'passport
        '
        Me.passport.BackgroundImage = Global.bank_application.My.Resources.Resources.friends
        Me.passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.passport.BorderRadius = 5
        Me.passport.Location = New System.Drawing.Point(18, 16)
        Me.passport.Name = "passport"
        Me.passport.ShadowDecoration.Parent = Me.passport
        Me.passport.Size = New System.Drawing.Size(69, 67)
        Me.passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passport.TabIndex = 1
        Me.passport.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.Controls.Add(Me.date_label)
        Me.Guna2Panel2.Controls.Add(Me.time_label)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(1020, 93)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(216, 100)
        Me.Guna2Panel2.TabIndex = 3
        '
        'date_label
        '
        Me.date_label.BackColor = System.Drawing.Color.Transparent
        Me.date_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.date_label.Location = New System.Drawing.Point(12, 67)
        Me.date_label.Name = "date_label"
        Me.date_label.Size = New System.Drawing.Size(63, 15)
        Me.date_label.TabIndex = 2
        Me.date_label.Text = "Current Date"
        '
        'time_label
        '
        Me.time_label.BackColor = System.Drawing.Color.Transparent
        Me.time_label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_label.ForeColor = System.Drawing.Color.Maroon
        Me.time_label.Location = New System.Drawing.Point(12, 37)
        Me.time_label.Name = "time_label"
        Me.time_label.Size = New System.Drawing.Size(65, 23)
        Me.time_label.TabIndex = 1
        Me.time_label.Text = "00:00:00"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 13)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(79, 18)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Current Time"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel7)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel6)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(246, 201)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(990, 286)
        Me.Guna2Panel3.TabIndex = 4
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel7.BorderRadius = 5
        Me.Guna2Panel7.Controls.Add(Me.total_balance_label)
        Me.Guna2Panel7.Controls.Add(Me.Guna2HtmlLabel12)
        Me.Guna2Panel7.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2Panel7.Location = New System.Drawing.Point(740, 22)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.Size = New System.Drawing.Size(225, 116)
        Me.Guna2Panel7.TabIndex = 3
        '
        'total_balance_label
        '
        Me.total_balance_label.BackColor = System.Drawing.Color.Transparent
        Me.total_balance_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_balance_label.ForeColor = System.Drawing.Color.White
        Me.total_balance_label.Location = New System.Drawing.Point(15, 39)
        Me.total_balance_label.Name = "total_balance_label"
        Me.total_balance_label.Size = New System.Drawing.Size(14, 26)
        Me.total_balance_label.TabIndex = 4
        Me.total_balance_label.Text = "0"
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel12.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(15, 15)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(112, 18)
        Me.Guna2HtmlLabel12.TabIndex = 3
        Me.Guna2HtmlLabel12.Text = "TOTAL BALANCE"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel6.BorderRadius = 5
        Me.Guna2Panel6.Controls.Add(Me.total_loan_label)
        Me.Guna2Panel6.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Guna2Panel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2Panel6.Location = New System.Drawing.Point(500, 22)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(225, 116)
        Me.Guna2Panel6.TabIndex = 2
        '
        'total_loan_label
        '
        Me.total_loan_label.BackColor = System.Drawing.Color.Transparent
        Me.total_loan_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_loan_label.ForeColor = System.Drawing.Color.White
        Me.total_loan_label.Location = New System.Drawing.Point(15, 39)
        Me.total_loan_label.Name = "total_loan_label"
        Me.total_loan_label.Size = New System.Drawing.Size(14, 26)
        Me.total_loan_label.TabIndex = 4
        Me.total_loan_label.Text = "0"
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(15, 15)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(86, 18)
        Me.Guna2HtmlLabel10.TabIndex = 3
        Me.Guna2HtmlLabel10.Text = "TOTAL LOAN"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel5.BorderRadius = 5
        Me.Guna2Panel5.Controls.Add(Me.total_customer_label)
        Me.Guna2Panel5.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2Panel5.Location = New System.Drawing.Point(258, 22)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(225, 116)
        Me.Guna2Panel5.TabIndex = 1
        '
        'total_customer_label
        '
        Me.total_customer_label.BackColor = System.Drawing.Color.Transparent
        Me.total_customer_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_customer_label.ForeColor = System.Drawing.Color.White
        Me.total_customer_label.Location = New System.Drawing.Point(15, 39)
        Me.total_customer_label.Name = "total_customer_label"
        Me.total_customer_label.Size = New System.Drawing.Size(14, 26)
        Me.total_customer_label.TabIndex = 4
        Me.total_customer_label.Text = "0"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(15, 15)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(136, 18)
        Me.Guna2HtmlLabel8.TabIndex = 3
        Me.Guna2HtmlLabel8.Text = "TOTAL CUSTOMERS"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BorderRadius = 5
        Me.Guna2Panel4.Controls.Add(Me.total_admin_label)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2Panel4.Location = New System.Drawing.Point(18, 22)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(225, 116)
        Me.Guna2Panel4.TabIndex = 0
        '
        'total_admin_label
        '
        Me.total_admin_label.BackColor = System.Drawing.Color.Transparent
        Me.total_admin_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_admin_label.ForeColor = System.Drawing.Color.White
        Me.total_admin_label.Location = New System.Drawing.Point(15, 39)
        Me.total_admin_label.Name = "total_admin_label"
        Me.total_admin_label.Size = New System.Drawing.Size(14, 26)
        Me.total_admin_label.TabIndex = 4
        Me.total_admin_label.Text = "0"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(15, 15)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(93, 18)
        Me.Guna2HtmlLabel5.TabIndex = 3
        Me.Guna2HtmlLabel5.Text = "TOTAL ADMIN"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'admin_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.bank_application.My.Resources.Resources.bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1252, 498)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "admin_dashboard"
        Me.Text = "Admin Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel7.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents time_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents date_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents passport As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents last_login_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents staff_fullname_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents total_admin_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents total_loan_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents total_customer_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents total_balance_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents logoutBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents view_loan_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents view_customer_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents view_admin_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deposit_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents settings_btn As Guna.UI2.WinForms.Guna2Button
End Class
