<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userlogin_form
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ForgotPass_Label = New System.Windows.Forms.Label()
        Me.loginUserBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.email_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.closeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.GroupBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.closeBtn)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(542, 458)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "User Login"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ForgotPass_Label)
        Me.GroupBox1.Controls.Add(Me.loginUserBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.password_txt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.email_txt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 399)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Login"
        '
        'ForgotPass_Label
        '
        Me.ForgotPass_Label.AutoSize = True
        Me.ForgotPass_Label.BackColor = System.Drawing.SystemColors.Control
        Me.ForgotPass_Label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForgotPass_Label.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotPass_Label.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ForgotPass_Label.Location = New System.Drawing.Point(14, 210)
        Me.ForgotPass_Label.Name = "ForgotPass_Label"
        Me.ForgotPass_Label.Size = New System.Drawing.Size(113, 16)
        Me.ForgotPass_Label.TabIndex = 5
        Me.ForgotPass_Label.Text = "Forgot Password?"
        '
        'loginUserBtn
        '
        Me.loginUserBtn.Animated = True
        Me.loginUserBtn.BorderRadius = 5
        Me.loginUserBtn.CheckedState.Parent = Me.loginUserBtn
        Me.loginUserBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginUserBtn.CustomImages.Parent = Me.loginUserBtn
        Me.loginUserBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.loginUserBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.loginUserBtn.ForeColor = System.Drawing.Color.White
        Me.loginUserBtn.HoverState.Parent = Me.loginUserBtn
        Me.loginUserBtn.Image = Global.bank_application.My.Resources.Resources.login1
        Me.loginUserBtn.ImageSize = New System.Drawing.Size(15, 15)
        Me.loginUserBtn.Location = New System.Drawing.Point(12, 251)
        Me.loginUserBtn.Name = "loginUserBtn"
        Me.loginUserBtn.ShadowDecoration.Parent = Me.loginUserBtn
        Me.loginUserBtn.Size = New System.Drawing.Size(180, 48)
        Me.loginUserBtn.TabIndex = 4
        Me.loginUserBtn.Text = "LOG-IN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PASSWORD"
        '
        'password_txt
        '
        Me.password_txt.BorderRadius = 5
        Me.password_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_txt.DefaultText = ""
        Me.password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_txt.DisabledState.Parent = Me.password_txt
        Me.password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_txt.FocusedState.Parent = Me.password_txt
        Me.password_txt.ForeColor = System.Drawing.Color.Black
        Me.password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_txt.HoverState.Parent = Me.password_txt
        Me.password_txt.Location = New System.Drawing.Point(12, 159)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.password_txt.PlaceholderText = "ENTER YOUR PASSWORD"
        Me.password_txt.SelectedText = ""
        Me.password_txt.ShadowDecoration.Parent = Me.password_txt
        Me.password_txt.Size = New System.Drawing.Size(495, 45)
        Me.password_txt.TabIndex = 2
        Me.password_txt.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EMAIL ADDRESS"
        '
        'email_txt
        '
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
        Me.email_txt.ForeColor = System.Drawing.Color.Black
        Me.email_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.HoverState.Parent = Me.email_txt
        Me.email_txt.Location = New System.Drawing.Point(12, 72)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_txt.PlaceholderText = "ENTER YOUR EMAIL ADDRESS"
        Me.email_txt.SelectedText = ""
        Me.email_txt.ShadowDecoration.Parent = Me.email_txt
        Me.email_txt.Size = New System.Drawing.Size(495, 45)
        Me.email_txt.TabIndex = 0
        '
        'closeBtn
        '
        Me.closeBtn.CheckedState.Parent = Me.closeBtn
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtn.CustomImages.Parent = Me.closeBtn
        Me.closeBtn.FillColor = System.Drawing.Color.Maroon
        Me.closeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.closeBtn.ForeColor = System.Drawing.Color.White
        Me.closeBtn.HoverState.Parent = Me.closeBtn
        Me.closeBtn.Location = New System.Drawing.Point(489, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.ShadowDecoration.Parent = Me.closeBtn
        Me.closeBtn.Size = New System.Drawing.Size(53, 41)
        Me.closeBtn.TabIndex = 0
        Me.closeBtn.Text = "X"
        '
        'userlogin_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 458)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userlogin_form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userlogin_form"
        Me.TopMost = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents email_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents password_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ForgotPass_Label As System.Windows.Forms.Label
    Friend WithEvents loginUserBtn As Guna.UI2.WinForms.Guna2Button
End Class
