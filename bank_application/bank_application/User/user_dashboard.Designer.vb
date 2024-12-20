<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.loginUserBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.changePassBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.loanHistoryBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.deposit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.requestForLoanBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.loan_bal_txt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.acct_bal_txt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.last_login_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.user_fullname_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.passport = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Panel1.Controls.Add(Me.loginUserBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1035, 82)
        Me.Panel1.TabIndex = 0
        '
        'loginUserBtn
        '
        Me.loginUserBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loginUserBtn.Animated = True
        Me.loginUserBtn.BorderRadius = 5
        Me.loginUserBtn.CheckedState.Parent = Me.loginUserBtn
        Me.loginUserBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginUserBtn.CustomImages.Parent = Me.loginUserBtn
        Me.loginUserBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.loginUserBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.loginUserBtn.ForeColor = System.Drawing.Color.White
        Me.loginUserBtn.HoverState.Parent = Me.loginUserBtn
        Me.loginUserBtn.Image = Global.bank_application.My.Resources.Resources.login1
        Me.loginUserBtn.ImageSize = New System.Drawing.Size(15, 15)
        Me.loginUserBtn.Location = New System.Drawing.Point(927, 21)
        Me.loginUserBtn.Name = "loginUserBtn"
        Me.loginUserBtn.ShadowDecoration.Parent = Me.loginUserBtn
        Me.loginUserBtn.Size = New System.Drawing.Size(96, 40)
        Me.loginUserBtn.TabIndex = 6
        Me.loginUserBtn.Text = "LOG-OUT"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.changePassBtn)
        Me.Panel2.Controls.Add(Me.loanHistoryBtn)
        Me.Panel2.Controls.Add(Me.deposit_btn)
        Me.Panel2.Controls.Add(Me.requestForLoanBtn)
        Me.Panel2.Controls.Add(Me.Guna2Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1035, 70)
        Me.Panel2.TabIndex = 1
        '
        'changePassBtn
        '
        Me.changePassBtn.CheckedState.Parent = Me.changePassBtn
        Me.changePassBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.changePassBtn.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.changePassBtn.CustomImages.Parent = Me.changePassBtn
        Me.changePassBtn.FillColor = System.Drawing.Color.White
        Me.changePassBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.changePassBtn.ForeColor = System.Drawing.Color.Black
        Me.changePassBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.changePassBtn.HoverState.Parent = Me.changePassBtn
        Me.changePassBtn.Location = New System.Drawing.Point(792, 0)
        Me.changePassBtn.Name = "changePassBtn"
        Me.changePassBtn.ShadowDecoration.Parent = Me.changePassBtn
        Me.changePassBtn.Size = New System.Drawing.Size(192, 70)
        Me.changePassBtn.TabIndex = 4
        Me.changePassBtn.Text = "Change Password"
        '
        'loanHistoryBtn
        '
        Me.loanHistoryBtn.CheckedState.Parent = Me.loanHistoryBtn
        Me.loanHistoryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loanHistoryBtn.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.loanHistoryBtn.CustomImages.Parent = Me.loanHistoryBtn
        Me.loanHistoryBtn.FillColor = System.Drawing.Color.White
        Me.loanHistoryBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.loanHistoryBtn.ForeColor = System.Drawing.Color.Black
        Me.loanHistoryBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.loanHistoryBtn.HoverState.Parent = Me.loanHistoryBtn
        Me.loanHistoryBtn.Location = New System.Drawing.Point(594, 0)
        Me.loanHistoryBtn.Name = "loanHistoryBtn"
        Me.loanHistoryBtn.ShadowDecoration.Parent = Me.loanHistoryBtn
        Me.loanHistoryBtn.Size = New System.Drawing.Size(192, 70)
        Me.loanHistoryBtn.TabIndex = 3
        Me.loanHistoryBtn.Text = "My Loan Schedule"
        '
        'deposit_btn
        '
        Me.deposit_btn.CheckedState.Parent = Me.deposit_btn
        Me.deposit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deposit_btn.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.deposit_btn.CustomImages.Parent = Me.deposit_btn
        Me.deposit_btn.FillColor = System.Drawing.Color.White
        Me.deposit_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.deposit_btn.ForeColor = System.Drawing.Color.Black
        Me.deposit_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.deposit_btn.HoverState.Parent = Me.deposit_btn
        Me.deposit_btn.Location = New System.Drawing.Point(396, 0)
        Me.deposit_btn.Name = "deposit_btn"
        Me.deposit_btn.ShadowDecoration.Parent = Me.deposit_btn
        Me.deposit_btn.Size = New System.Drawing.Size(192, 70)
        Me.deposit_btn.TabIndex = 2
        Me.deposit_btn.Text = "Deposit"
        '
        'requestForLoanBtn
        '
        Me.requestForLoanBtn.CheckedState.Parent = Me.requestForLoanBtn
        Me.requestForLoanBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.requestForLoanBtn.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.requestForLoanBtn.CustomImages.Parent = Me.requestForLoanBtn
        Me.requestForLoanBtn.FillColor = System.Drawing.Color.White
        Me.requestForLoanBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.requestForLoanBtn.ForeColor = System.Drawing.Color.Black
        Me.requestForLoanBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.requestForLoanBtn.HoverState.Parent = Me.requestForLoanBtn
        Me.requestForLoanBtn.Location = New System.Drawing.Point(198, 0)
        Me.requestForLoanBtn.Name = "requestForLoanBtn"
        Me.requestForLoanBtn.ShadowDecoration.Parent = Me.requestForLoanBtn
        Me.requestForLoanBtn.Size = New System.Drawing.Size(192, 70)
        Me.requestForLoanBtn.TabIndex = 1
        Me.requestForLoanBtn.Text = "Request for Loan"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2Button1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(192, 70)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Home"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.loan_bal_txt)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel1.Controls.Add(Me.acct_bal_txt)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.last_login_label)
        Me.Guna2Panel1.Controls.Add(Me.user_fullname_label)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.passport)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.FillColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 152)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1035, 100)
        Me.Guna2Panel1.TabIndex = 3
        '
        'loan_bal_txt
        '
        Me.loan_bal_txt.BackColor = System.Drawing.Color.Transparent
        Me.loan_bal_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_bal_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.loan_bal_txt.Location = New System.Drawing.Point(571, 47)
        Me.loan_bal_txt.Name = "loan_bal_txt"
        Me.loan_bal_txt.Size = New System.Drawing.Size(81, 22)
        Me.loan_bal_txt.TabIndex = 8
        Me.loan_bal_txt.Text = "NGN 0.00"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(571, 23)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(86, 18)
        Me.Guna2HtmlLabel7.TabIndex = 7
        Me.Guna2HtmlLabel7.Text = "Loan Balance"
        '
        'acct_bal_txt
        '
        Me.acct_bal_txt.BackColor = System.Drawing.Color.Transparent
        Me.acct_bal_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acct_bal_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.acct_bal_txt.Location = New System.Drawing.Point(380, 47)
        Me.acct_bal_txt.Name = "acct_bal_txt"
        Me.acct_bal_txt.Size = New System.Drawing.Size(81, 22)
        Me.acct_bal_txt.TabIndex = 6
        Me.acct_bal_txt.Text = "NGN 0.00"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(380, 23)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(104, 18)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "Account Balance"
        '
        'last_login_label
        '
        Me.last_login_label.BackColor = System.Drawing.Color.Transparent
        Me.last_login_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_login_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.last_login_label.Location = New System.Drawing.Point(104, 62)
        Me.last_login_label.Name = "last_login_label"
        Me.last_login_label.Size = New System.Drawing.Size(183, 15)
        Me.last_login_label.TabIndex = 4
        Me.last_login_label.Text = "Last Login Date: 2024-11-19 23:44:01"
        '
        'user_fullname_label
        '
        Me.user_fullname_label.BackColor = System.Drawing.Color.Transparent
        Me.user_fullname_label.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_fullname_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.user_fullname_label.Location = New System.Drawing.Point(104, 42)
        Me.user_fullname_label.Name = "user_fullname_label"
        Me.user_fullname_label.Size = New System.Drawing.Size(153, 19)
        Me.user_fullname_label.TabIndex = 3
        Me.user_fullname_label.Text = "FORTUNE TECH GLOBAL"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(104, 23)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(103, 18)
        Me.Guna2HtmlLabel2.TabIndex = 2
        Me.Guna2HtmlLabel2.Text = "User Dashboard"
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
        'user_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1035, 512)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "user_dashboard"
        Me.Text = "User Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents requestForLoanBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents loanHistoryBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deposit_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents last_login_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents user_fullname_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents passport As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents changePassBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents acct_bal_txt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents loan_bal_txt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents loginUserBtn As Guna.UI2.WinForms.Guna2Button
End Class
