<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userportal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userportal))
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.trans_history_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.change_password_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.request_for_loan_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.deposit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.home_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.loan_balance_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.acct_balance_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.user_last_login_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.user_full_name_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.passporrt = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.user_log_out_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.date_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.time_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.withdraw_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.passporrt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.Controls.Add(Me.withdraw_btn)
        Me.Guna2Panel2.Controls.Add(Me.trans_history_btn)
        Me.Guna2Panel2.Controls.Add(Me.change_password_btn)
        Me.Guna2Panel2.Controls.Add(Me.request_for_loan_btn)
        Me.Guna2Panel2.Controls.Add(Me.deposit_btn)
        Me.Guna2Panel2.Controls.Add(Me.home_btn)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Location = New System.Drawing.Point(-2, 50)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1102, 55)
        Me.Guna2Panel2.TabIndex = 11
        '
        'trans_history_btn
        '
        Me.trans_history_btn.BackColor = System.Drawing.Color.Transparent
        Me.trans_history_btn.BorderColor = System.Drawing.Color.Transparent
        Me.trans_history_btn.BorderRadius = 5
        Me.trans_history_btn.CheckedState.Parent = Me.trans_history_btn
        Me.trans_history_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trans_history_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.trans_history_btn.CustomImages.Parent = Me.trans_history_btn
        Me.trans_history_btn.FillColor = System.Drawing.Color.Transparent
        Me.trans_history_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trans_history_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.trans_history_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.trans_history_btn.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trans_history_btn.HoverState.ForeColor = System.Drawing.Color.White
        Me.trans_history_btn.HoverState.Parent = Me.trans_history_btn
        Me.trans_history_btn.Location = New System.Drawing.Point(564, 11)
        Me.trans_history_btn.Name = "trans_history_btn"
        Me.trans_history_btn.ShadowDecoration.Parent = Me.trans_history_btn
        Me.trans_history_btn.Size = New System.Drawing.Size(161, 33)
        Me.trans_history_btn.TabIndex = 10
        Me.trans_history_btn.Text = "Transaction History"
        '
        'change_password_btn
        '
        Me.change_password_btn.BackColor = System.Drawing.Color.Transparent
        Me.change_password_btn.BorderColor = System.Drawing.Color.Transparent
        Me.change_password_btn.BorderRadius = 5
        Me.change_password_btn.CheckedState.Parent = Me.change_password_btn
        Me.change_password_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.change_password_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.change_password_btn.CustomImages.Parent = Me.change_password_btn
        Me.change_password_btn.FillColor = System.Drawing.Color.Transparent
        Me.change_password_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_password_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.change_password_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.change_password_btn.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_password_btn.HoverState.ForeColor = System.Drawing.Color.White
        Me.change_password_btn.HoverState.Parent = Me.change_password_btn
        Me.change_password_btn.Location = New System.Drawing.Point(747, 11)
        Me.change_password_btn.Name = "change_password_btn"
        Me.change_password_btn.ShadowDecoration.Parent = Me.change_password_btn
        Me.change_password_btn.Size = New System.Drawing.Size(123, 33)
        Me.change_password_btn.TabIndex = 9
        Me.change_password_btn.Text = "Change Password"
        '
        'request_for_loan_btn
        '
        Me.request_for_loan_btn.BackColor = System.Drawing.Color.Transparent
        Me.request_for_loan_btn.BorderColor = System.Drawing.Color.Transparent
        Me.request_for_loan_btn.BorderRadius = 5
        Me.request_for_loan_btn.CheckedState.Parent = Me.request_for_loan_btn
        Me.request_for_loan_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.request_for_loan_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.request_for_loan_btn.CustomImages.Parent = Me.request_for_loan_btn
        Me.request_for_loan_btn.FillColor = System.Drawing.Color.Transparent
        Me.request_for_loan_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.request_for_loan_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.request_for_loan_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.request_for_loan_btn.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.request_for_loan_btn.HoverState.ForeColor = System.Drawing.Color.White
        Me.request_for_loan_btn.HoverState.Parent = Me.request_for_loan_btn
        Me.request_for_loan_btn.Location = New System.Drawing.Point(160, 11)
        Me.request_for_loan_btn.Name = "request_for_loan_btn"
        Me.request_for_loan_btn.ShadowDecoration.Parent = Me.request_for_loan_btn
        Me.request_for_loan_btn.Size = New System.Drawing.Size(147, 33)
        Me.request_for_loan_btn.TabIndex = 8
        Me.request_for_loan_btn.Text = "Request For Loan"
        '
        'deposit_btn
        '
        Me.deposit_btn.BackColor = System.Drawing.Color.Transparent
        Me.deposit_btn.BorderColor = System.Drawing.Color.Transparent
        Me.deposit_btn.BorderRadius = 5
        Me.deposit_btn.CheckedState.Parent = Me.deposit_btn
        Me.deposit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deposit_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.deposit_btn.CustomImages.Parent = Me.deposit_btn
        Me.deposit_btn.FillColor = System.Drawing.Color.Transparent
        Me.deposit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deposit_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.deposit_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.deposit_btn.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deposit_btn.HoverState.ForeColor = System.Drawing.Color.White
        Me.deposit_btn.HoverState.Parent = Me.deposit_btn
        Me.deposit_btn.Location = New System.Drawing.Point(323, 11)
        Me.deposit_btn.Name = "deposit_btn"
        Me.deposit_btn.ShadowDecoration.Parent = Me.deposit_btn
        Me.deposit_btn.Size = New System.Drawing.Size(102, 33)
        Me.deposit_btn.TabIndex = 7
        Me.deposit_btn.Text = "Deposit"
        '
        'home_btn
        '
        Me.home_btn.BackColor = System.Drawing.Color.Transparent
        Me.home_btn.BorderColor = System.Drawing.Color.Transparent
        Me.home_btn.BorderRadius = 5
        Me.home_btn.CheckedState.Parent = Me.home_btn
        Me.home_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.home_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.home_btn.CustomImages.Parent = Me.home_btn
        Me.home_btn.FillColor = System.Drawing.Color.Transparent
        Me.home_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.home_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.home_btn.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home_btn.HoverState.ForeColor = System.Drawing.Color.White
        Me.home_btn.HoverState.Parent = Me.home_btn
        Me.home_btn.Location = New System.Drawing.Point(44, 11)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.ShadowDecoration.Parent = Me.home_btn
        Me.home_btn.Size = New System.Drawing.Size(102, 33)
        Me.home_btn.TabIndex = 6
        Me.home_btn.Text = "Home"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BorderRadius = 5
        Me.Guna2Panel4.Controls.Add(Me.loan_balance_label)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel4.Controls.Add(Me.acct_balance_label)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel4.Controls.Add(Me.user_last_login_label)
        Me.Guna2Panel4.Controls.Add(Me.user_full_name_label)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel4.Controls.Add(Me.passporrt)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.Location = New System.Drawing.Point(-2, 105)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(1298, 76)
        Me.Guna2Panel4.TabIndex = 10
        '
        'loan_balance_label
        '
        Me.loan_balance_label.BackColor = System.Drawing.Color.Transparent
        Me.loan_balance_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_balance_label.ForeColor = System.Drawing.Color.Black
        Me.loan_balance_label.Location = New System.Drawing.Point(498, 40)
        Me.loan_balance_label.Name = "loan_balance_label"
        Me.loan_balance_label.Size = New System.Drawing.Size(65, 17)
        Me.loan_balance_label.TabIndex = 12
        Me.loan_balance_label.Text = "NGN 0.00"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(498, 19)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(76, 17)
        Me.Guna2HtmlLabel6.TabIndex = 11
        Me.Guna2HtmlLabel6.Text = "LoanBalance"
        '
        'acct_balance_label
        '
        Me.acct_balance_label.BackColor = System.Drawing.Color.Transparent
        Me.acct_balance_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acct_balance_label.ForeColor = System.Drawing.Color.Black
        Me.acct_balance_label.Location = New System.Drawing.Point(351, 38)
        Me.acct_balance_label.Name = "acct_balance_label"
        Me.acct_balance_label.Size = New System.Drawing.Size(65, 17)
        Me.acct_balance_label.TabIndex = 10
        Me.acct_balance_label.Text = "NGN 0.00"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(351, 17)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(94, 17)
        Me.Guna2HtmlLabel1.TabIndex = 8
        Me.Guna2HtmlLabel1.Text = "Account Balance"
        '
        'user_last_login_label
        '
        Me.user_last_login_label.BackColor = System.Drawing.Color.Transparent
        Me.user_last_login_label.ForeColor = System.Drawing.Color.Black
        Me.user_last_login_label.Location = New System.Drawing.Point(101, 43)
        Me.user_last_login_label.Name = "user_last_login_label"
        Me.user_last_login_label.Size = New System.Drawing.Size(31, 15)
        Me.user_last_login_label.TabIndex = 7
        Me.user_last_login_label.Text = "XXXX"
        '
        'user_full_name_label
        '
        Me.user_full_name_label.BackColor = System.Drawing.Color.Transparent
        Me.user_full_name_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_full_name_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.user_full_name_label.Location = New System.Drawing.Point(101, 28)
        Me.user_full_name_label.Name = "user_full_name_label"
        Me.user_full_name_label.Size = New System.Drawing.Size(51, 15)
        Me.user_full_name_label.TabIndex = 6
        Me.user_full_name_label.Text = "XXXXXX"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(101, 10)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(93, 17)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "User Dashboard"
        '
        'passporrt
        '
        Me.passporrt.BorderRadius = 5
        Me.passporrt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.passporrt.Image = Global.WindowsApplication2.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Places_user_identity_128
        Me.passporrt.Location = New System.Drawing.Point(28, 9)
        Me.passporrt.Name = "passporrt"
        Me.passporrt.ShadowDecoration.Parent = Me.passporrt
        Me.passporrt.Size = New System.Drawing.Size(68, 59)
        Me.passporrt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passporrt.TabIndex = 4
        Me.passporrt.TabStop = False
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GradientPanel2.BorderRadius = 1
        Me.Guna2GradientPanel2.Controls.Add(Me.user_log_out_btn)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(-5, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(1301, 50)
        Me.Guna2GradientPanel2.TabIndex = 9
        '
        'user_log_out_btn
        '
        Me.user_log_out_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.user_log_out_btn.BorderRadius = 5
        Me.user_log_out_btn.CheckedState.Parent = Me.user_log_out_btn
        Me.user_log_out_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.user_log_out_btn.CustomImages.Parent = Me.user_log_out_btn
        Me.user_log_out_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.user_log_out_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.user_log_out_btn.ForeColor = System.Drawing.Color.White
        Me.user_log_out_btn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.user_log_out_btn.HoverState.Parent = Me.user_log_out_btn
        Me.user_log_out_btn.Location = New System.Drawing.Point(1178, 9)
        Me.user_log_out_btn.Name = "user_log_out_btn"
        Me.user_log_out_btn.ShadowDecoration.Parent = Me.user_log_out_btn
        Me.user_log_out_btn.Size = New System.Drawing.Size(81, 32)
        Me.user_log_out_btn.TabIndex = 0
        Me.user_log_out_btn.Text = "LOG-OUT"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel3.Controls.Add(Me.date_label)
        Me.Guna2Panel3.Controls.Add(Me.time_label)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Location = New System.Drawing.Point(1106, 50)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(187, 55)
        Me.Guna2Panel3.TabIndex = 12
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(12, 1)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(80, 18)
        Me.Guna2HtmlLabel5.TabIndex = 5
        Me.Guna2HtmlLabel5.Text = "Current Time:"
        '
        'date_label
        '
        Me.date_label.BackColor = System.Drawing.Color.Transparent
        Me.date_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_label.Location = New System.Drawing.Point(12, 34)
        Me.date_label.Name = "date_label"
        Me.date_label.Size = New System.Drawing.Size(84, 17)
        Me.date_label.TabIndex = 4
        Me.date_label.Text = "Current Date"
        '
        'time_label
        '
        Me.time_label.BackColor = System.Drawing.Color.Transparent
        Me.time_label.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_label.ForeColor = System.Drawing.Color.Maroon
        Me.time_label.Location = New System.Drawing.Point(12, 19)
        Me.time_label.Name = "time_label"
        Me.time_label.Size = New System.Drawing.Size(77, 18)
        Me.time_label.TabIndex = 3
        Me.time_label.Text = "Current Time"
        '
        'Timer1
        '
        '
        'withdraw_btn
        '
        Me.withdraw_btn.BackColor = System.Drawing.Color.Transparent
        Me.withdraw_btn.BorderColor = System.Drawing.Color.Transparent
        Me.withdraw_btn.BorderRadius = 5
        Me.withdraw_btn.CheckedState.Parent = Me.withdraw_btn
        Me.withdraw_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.withdraw_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.withdraw_btn.CustomImages.Parent = Me.withdraw_btn
        Me.withdraw_btn.FillColor = System.Drawing.Color.Transparent
        Me.withdraw_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withdraw_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.withdraw_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.withdraw_btn.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withdraw_btn.HoverState.ForeColor = System.Drawing.Color.White
        Me.withdraw_btn.HoverState.Parent = Me.withdraw_btn
        Me.withdraw_btn.Location = New System.Drawing.Point(445, 11)
        Me.withdraw_btn.Name = "withdraw_btn"
        Me.withdraw_btn.ShadowDecoration.Parent = Me.withdraw_btn
        Me.withdraw_btn.Size = New System.Drawing.Size(102, 33)
        Me.withdraw_btn.TabIndex = 11
        Me.withdraw_btn.Text = "Withdraw"
        '
        'userportal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.pngtree_d_illustration_of_a_blue_background_bank_building_featuring_spanish_text_picture_image_4791388
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1288, 441)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "userportal"
        Me.Text = "userportal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.passporrt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents trans_history_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents change_password_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents request_for_loan_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deposit_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents home_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loan_balance_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents acct_balance_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents user_last_login_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents user_full_name_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents passporrt As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents user_log_out_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents date_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents time_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents withdraw_btn As Guna.UI2.WinForms.Guna2Button
End Class
