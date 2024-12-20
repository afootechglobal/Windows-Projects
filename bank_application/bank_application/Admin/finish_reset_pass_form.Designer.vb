<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class finish_reset_pass_form
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
        Me.passLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.confirm_pass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.new_pass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.proceed_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.otp_txt = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.Guna2GroupBox1.TabIndex = 3
        Me.Guna2GroupBox1.Text = "Finish Reset Password Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.passLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.confirm_pass_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.new_pass_txt)
        Me.GroupBox1.Controls.Add(Me.proceed_btn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.otp_txt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 399)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admin Login"
        '
        'passLabel
        '
        Me.passLabel.AutoSize = True
        Me.passLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.passLabel.ForeColor = System.Drawing.Color.Black
        Me.passLabel.Location = New System.Drawing.Point(23, 33)
        Me.passLabel.Name = "passLabel"
        Me.passLabel.Size = New System.Drawing.Size(24, 19)
        Me.passLabel.TabIndex = 10
        Me.passLabel.Text = "OTP"
        Me.passLabel.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "CONFIRM PASSWORD"
        '
        'confirm_pass_txt
        '
        Me.confirm_pass_txt.BorderRadius = 5
        Me.confirm_pass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirm_pass_txt.DefaultText = ""
        Me.confirm_pass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirm_pass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirm_pass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirm_pass_txt.DisabledState.Parent = Me.confirm_pass_txt
        Me.confirm_pass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirm_pass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirm_pass_txt.FocusedState.Parent = Me.confirm_pass_txt
        Me.confirm_pass_txt.ForeColor = System.Drawing.Color.Black
        Me.confirm_pass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirm_pass_txt.HoverState.Parent = Me.confirm_pass_txt
        Me.confirm_pass_txt.Location = New System.Drawing.Point(12, 271)
        Me.confirm_pass_txt.Name = "confirm_pass_txt"
        Me.confirm_pass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.confirm_pass_txt.PlaceholderText = "CREATE NEW PASSWORD"
        Me.confirm_pass_txt.SelectedText = ""
        Me.confirm_pass_txt.ShadowDecoration.Parent = Me.confirm_pass_txt
        Me.confirm_pass_txt.Size = New System.Drawing.Size(495, 45)
        Me.confirm_pass_txt.TabIndex = 8
        Me.confirm_pass_txt.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CREATE NEW PASSWORD"
        '
        'new_pass_txt
        '
        Me.new_pass_txt.BorderRadius = 5
        Me.new_pass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.new_pass_txt.DefaultText = ""
        Me.new_pass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.new_pass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.new_pass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.new_pass_txt.DisabledState.Parent = Me.new_pass_txt
        Me.new_pass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.new_pass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.new_pass_txt.FocusedState.Parent = Me.new_pass_txt
        Me.new_pass_txt.ForeColor = System.Drawing.Color.Black
        Me.new_pass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.new_pass_txt.HoverState.Parent = Me.new_pass_txt
        Me.new_pass_txt.Location = New System.Drawing.Point(12, 192)
        Me.new_pass_txt.Name = "new_pass_txt"
        Me.new_pass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.new_pass_txt.PlaceholderText = "CREATE NEW PASSWORD"
        Me.new_pass_txt.SelectedText = ""
        Me.new_pass_txt.ShadowDecoration.Parent = Me.new_pass_txt
        Me.new_pass_txt.Size = New System.Drawing.Size(495, 45)
        Me.new_pass_txt.TabIndex = 6
        Me.new_pass_txt.UseSystemPasswordChar = True
        '
        'proceed_btn
        '
        Me.proceed_btn.Animated = True
        Me.proceed_btn.BorderRadius = 5
        Me.proceed_btn.CheckedState.Parent = Me.proceed_btn
        Me.proceed_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.proceed_btn.CustomImages.Parent = Me.proceed_btn
        Me.proceed_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.proceed_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.proceed_btn.ForeColor = System.Drawing.Color.White
        Me.proceed_btn.HoverState.Parent = Me.proceed_btn
        Me.proceed_btn.Image = Global.bank_application.My.Resources.Resources.login1
        Me.proceed_btn.ImageSize = New System.Drawing.Size(15, 15)
        Me.proceed_btn.Location = New System.Drawing.Point(12, 335)
        Me.proceed_btn.Name = "proceed_btn"
        Me.proceed_btn.ShadowDecoration.Parent = Me.proceed_btn
        Me.proceed_btn.Size = New System.Drawing.Size(180, 48)
        Me.proceed_btn.TabIndex = 5
        Me.proceed_btn.Text = "Submit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OTP"
        '
        'otp_txt
        '
        Me.otp_txt.BorderRadius = 5
        Me.otp_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.otp_txt.DefaultText = ""
        Me.otp_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.otp_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.otp_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.otp_txt.DisabledState.Parent = Me.otp_txt
        Me.otp_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.otp_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.otp_txt.FocusedState.Parent = Me.otp_txt
        Me.otp_txt.ForeColor = System.Drawing.Color.Black
        Me.otp_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.otp_txt.HoverState.Parent = Me.otp_txt
        Me.otp_txt.Location = New System.Drawing.Point(12, 113)
        Me.otp_txt.Name = "otp_txt"
        Me.otp_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.otp_txt.PlaceholderText = "ENTER OTP"
        Me.otp_txt.SelectedText = ""
        Me.otp_txt.ShadowDecoration.Parent = Me.otp_txt
        Me.otp_txt.Size = New System.Drawing.Size(495, 45)
        Me.otp_txt.TabIndex = 0
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
        'finish_reset_pass_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 458)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "finish_reset_pass_form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "finish_reset_pass_form"
        Me.TopMost = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents proceed_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents otp_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents passLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents confirm_pass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents new_pass_txt As Guna.UI2.WinForms.Guna2TextBox
End Class
