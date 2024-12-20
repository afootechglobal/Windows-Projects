<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change_pass_form
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
        Me.SubmitButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.confirmPass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newPass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.oldPass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.closeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.SubmitButton)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.confirmPass_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.newPass_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.oldPass_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.closeBtn)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(547, 467)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "CHANGE PASSWORD FORM"
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
        Me.SubmitButton.Location = New System.Drawing.Point(12, 319)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.ShadowDecoration.Parent = Me.SubmitButton
        Me.SubmitButton.Size = New System.Drawing.Size(180, 45)
        Me.SubmitButton.TabIndex = 27
        Me.SubmitButton.Text = "CHANGE PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Confirmed Password"
        '
        'confirmPass_txt
        '
        Me.confirmPass_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.confirmPass_txt.BorderRadius = 5
        Me.confirmPass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmPass_txt.DefaultText = ""
        Me.confirmPass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirmPass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirmPass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmPass_txt.DisabledState.Parent = Me.confirmPass_txt
        Me.confirmPass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmPass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmPass_txt.FocusedState.Parent = Me.confirmPass_txt
        Me.confirmPass_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPass_txt.ForeColor = System.Drawing.Color.Black
        Me.confirmPass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmPass_txt.HoverState.Parent = Me.confirmPass_txt
        Me.confirmPass_txt.Location = New System.Drawing.Point(12, 251)
        Me.confirmPass_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.confirmPass_txt.Name = "confirmPass_txt"
        Me.confirmPass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.confirmPass_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.confirmPass_txt.PlaceholderText = "CONFIRMED PASSWORD"
        Me.confirmPass_txt.SelectedText = ""
        Me.confirmPass_txt.ShadowDecoration.Parent = Me.confirmPass_txt
        Me.confirmPass_txt.Size = New System.Drawing.Size(524, 41)
        Me.confirmPass_txt.TabIndex = 25
        Me.confirmPass_txt.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "New Password"
        '
        'newPass_txt
        '
        Me.newPass_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.newPass_txt.BorderRadius = 5
        Me.newPass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newPass_txt.DefaultText = ""
        Me.newPass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.newPass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.newPass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newPass_txt.DisabledState.Parent = Me.newPass_txt
        Me.newPass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newPass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newPass_txt.FocusedState.Parent = Me.newPass_txt
        Me.newPass_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPass_txt.ForeColor = System.Drawing.Color.Black
        Me.newPass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newPass_txt.HoverState.Parent = Me.newPass_txt
        Me.newPass_txt.Location = New System.Drawing.Point(12, 169)
        Me.newPass_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.newPass_txt.Name = "newPass_txt"
        Me.newPass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.newPass_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.newPass_txt.PlaceholderText = "NEW PASSWORD"
        Me.newPass_txt.SelectedText = ""
        Me.newPass_txt.ShadowDecoration.Parent = Me.newPass_txt
        Me.newPass_txt.Size = New System.Drawing.Size(524, 41)
        Me.newPass_txt.TabIndex = 23
        Me.newPass_txt.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Old Password"
        '
        'oldPass_txt
        '
        Me.oldPass_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.oldPass_txt.BorderRadius = 5
        Me.oldPass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.oldPass_txt.DefaultText = ""
        Me.oldPass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.oldPass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.oldPass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.oldPass_txt.DisabledState.Parent = Me.oldPass_txt
        Me.oldPass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.oldPass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.oldPass_txt.FocusedState.Parent = Me.oldPass_txt
        Me.oldPass_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldPass_txt.ForeColor = System.Drawing.Color.Black
        Me.oldPass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.oldPass_txt.HoverState.Parent = Me.oldPass_txt
        Me.oldPass_txt.Location = New System.Drawing.Point(12, 85)
        Me.oldPass_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.oldPass_txt.Name = "oldPass_txt"
        Me.oldPass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.oldPass_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.oldPass_txt.PlaceholderText = "OLD PASSWORD"
        Me.oldPass_txt.SelectedText = ""
        Me.oldPass_txt.ShadowDecoration.Parent = Me.oldPass_txt
        Me.oldPass_txt.Size = New System.Drawing.Size(524, 41)
        Me.oldPass_txt.TabIndex = 21
        Me.oldPass_txt.UseSystemPasswordChar = True
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
        Me.closeBtn.Location = New System.Drawing.Point(492, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.ShadowDecoration.Parent = Me.closeBtn
        Me.closeBtn.Size = New System.Drawing.Size(55, 40)
        Me.closeBtn.TabIndex = 20
        Me.closeBtn.Text = "X"
        '
        'change_pass_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 467)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "change_pass_form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "change_pass_form"
        Me.TopMost = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents confirmPass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents newPass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents oldPass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SubmitButton As Guna.UI2.WinForms.Guna2Button
End Class
