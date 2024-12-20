<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loan_request_form
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
        Me.closeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ClearButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SubmitButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loan_duration = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.loanAmount_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.closeBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.ClearButton)
        Me.Guna2GroupBox1.Controls.Add(Me.SubmitButton)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.loan_duration)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.loanAmount_txt)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(566, 320)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "LOAN REQUEST FORM"
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
        Me.closeBtn.Location = New System.Drawing.Point(511, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.ShadowDecoration.Parent = Me.closeBtn
        Me.closeBtn.Size = New System.Drawing.Size(55, 40)
        Me.closeBtn.TabIndex = 19
        Me.closeBtn.Text = "X"
        '
        'ClearButton
        '
        Me.ClearButton.Animated = True
        Me.ClearButton.BorderRadius = 5
        Me.ClearButton.CheckedState.Parent = Me.ClearButton
        Me.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearButton.CustomImages.Parent = Me.ClearButton
        Me.ClearButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.HoverState.Parent = Me.ClearButton
        Me.ClearButton.Location = New System.Drawing.Point(217, 231)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.ShadowDecoration.Parent = Me.ClearButton
        Me.ClearButton.Size = New System.Drawing.Size(180, 45)
        Me.ClearButton.TabIndex = 18
        Me.ClearButton.Text = "CLEAR"
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
        Me.SubmitButton.Location = New System.Drawing.Point(22, 231)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.ShadowDecoration.Parent = Me.SubmitButton
        Me.SubmitButton.Size = New System.Drawing.Size(180, 45)
        Me.SubmitButton.TabIndex = 17
        Me.SubmitButton.Text = "SUBMIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Loan Duration"
        '
        'loan_duration
        '
        Me.loan_duration.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.loan_duration.BorderRadius = 5
        Me.loan_duration.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.loan_duration.DefaultText = ""
        Me.loan_duration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.loan_duration.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.loan_duration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_duration.DisabledState.Parent = Me.loan_duration
        Me.loan_duration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_duration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_duration.FocusedState.Parent = Me.loan_duration
        Me.loan_duration.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_duration.ForeColor = System.Drawing.Color.Black
        Me.loan_duration.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_duration.HoverState.Parent = Me.loan_duration
        Me.loan_duration.Location = New System.Drawing.Point(22, 163)
        Me.loan_duration.Margin = New System.Windows.Forms.Padding(2)
        Me.loan_duration.Name = "loan_duration"
        Me.loan_duration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loan_duration.PlaceholderForeColor = System.Drawing.Color.Black
        Me.loan_duration.PlaceholderText = "0:00"
        Me.loan_duration.SelectedText = ""
        Me.loan_duration.ShadowDecoration.Parent = Me.loan_duration
        Me.loan_duration.Size = New System.Drawing.Size(524, 41)
        Me.loan_duration.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(19, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Loan Amount"
        '
        'loanAmount_txt
        '
        Me.loanAmount_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.loanAmount_txt.BorderRadius = 5
        Me.loanAmount_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.loanAmount_txt.DefaultText = ""
        Me.loanAmount_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.loanAmount_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.loanAmount_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loanAmount_txt.DisabledState.Parent = Me.loanAmount_txt
        Me.loanAmount_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loanAmount_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loanAmount_txt.FocusedState.Parent = Me.loanAmount_txt
        Me.loanAmount_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loanAmount_txt.ForeColor = System.Drawing.Color.Black
        Me.loanAmount_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loanAmount_txt.HoverState.Parent = Me.loanAmount_txt
        Me.loanAmount_txt.Location = New System.Drawing.Point(22, 88)
        Me.loanAmount_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.loanAmount_txt.Name = "loanAmount_txt"
        Me.loanAmount_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loanAmount_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.loanAmount_txt.PlaceholderText = "0:00"
        Me.loanAmount_txt.SelectedText = ""
        Me.loanAmount_txt.ShadowDecoration.Parent = Me.loanAmount_txt
        Me.loanAmount_txt.Size = New System.Drawing.Size(524, 41)
        Me.loanAmount_txt.TabIndex = 13
        '
        'loan_request_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 320)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loan_request_form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loan_request_form"
        Me.TopMost = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents loan_duration As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents loanAmount_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ClearButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SubmitButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
End Class
