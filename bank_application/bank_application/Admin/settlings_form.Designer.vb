<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settlings_form
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.loan_rate_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.closeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.updateButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.maximum_duration_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.minimum_loan_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.maximum_loan_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.minimum_balance_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.loan_rate_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.closeBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.updateButton)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.maximum_duration_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.minimum_loan_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.maximum_loan_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.minimum_balance_txt)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(576, 521)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "System Settlings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Loan Rate(%)"
        '
        'loan_rate_txt
        '
        Me.loan_rate_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.loan_rate_txt.BorderRadius = 5
        Me.loan_rate_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.loan_rate_txt.DefaultText = ""
        Me.loan_rate_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.loan_rate_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.loan_rate_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_rate_txt.DisabledState.Parent = Me.loan_rate_txt
        Me.loan_rate_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_rate_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_rate_txt.FocusedState.Parent = Me.loan_rate_txt
        Me.loan_rate_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_rate_txt.ForeColor = System.Drawing.Color.Black
        Me.loan_rate_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_rate_txt.HoverState.Parent = Me.loan_rate_txt
        Me.loan_rate_txt.Location = New System.Drawing.Point(15, 389)
        Me.loan_rate_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.loan_rate_txt.Name = "loan_rate_txt"
        Me.loan_rate_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loan_rate_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.loan_rate_txt.PlaceholderText = "0:00"
        Me.loan_rate_txt.SelectedText = ""
        Me.loan_rate_txt.ShadowDecoration.Parent = Me.loan_rate_txt
        Me.loan_rate_txt.Size = New System.Drawing.Size(550, 41)
        Me.loan_rate_txt.TabIndex = 23
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
        Me.closeBtn.Location = New System.Drawing.Point(521, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.ShadowDecoration.Parent = Me.closeBtn
        Me.closeBtn.Size = New System.Drawing.Size(55, 40)
        Me.closeBtn.TabIndex = 22
        Me.closeBtn.Text = "X"
        '
        'updateButton
        '
        Me.updateButton.Animated = True
        Me.updateButton.BorderRadius = 5
        Me.updateButton.CheckedState.Parent = Me.updateButton
        Me.updateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateButton.CustomImages.Parent = Me.updateButton
        Me.updateButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.updateButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateButton.ForeColor = System.Drawing.Color.White
        Me.updateButton.HoverState.Parent = Me.updateButton
        Me.updateButton.Location = New System.Drawing.Point(15, 452)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.ShadowDecoration.Parent = Me.updateButton
        Me.updateButton.Size = New System.Drawing.Size(180, 45)
        Me.updateButton.TabIndex = 21
        Me.updateButton.Text = "UPDATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Maximum Duration"
        '
        'maximum_duration_txt
        '
        Me.maximum_duration_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.maximum_duration_txt.BorderRadius = 5
        Me.maximum_duration_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.maximum_duration_txt.DefaultText = ""
        Me.maximum_duration_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.maximum_duration_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.maximum_duration_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.maximum_duration_txt.DisabledState.Parent = Me.maximum_duration_txt
        Me.maximum_duration_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.maximum_duration_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximum_duration_txt.FocusedState.Parent = Me.maximum_duration_txt
        Me.maximum_duration_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maximum_duration_txt.ForeColor = System.Drawing.Color.Black
        Me.maximum_duration_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximum_duration_txt.HoverState.Parent = Me.maximum_duration_txt
        Me.maximum_duration_txt.Location = New System.Drawing.Point(15, 314)
        Me.maximum_duration_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.maximum_duration_txt.Name = "maximum_duration_txt"
        Me.maximum_duration_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.maximum_duration_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.maximum_duration_txt.PlaceholderText = "0:00"
        Me.maximum_duration_txt.SelectedText = ""
        Me.maximum_duration_txt.ShadowDecoration.Parent = Me.maximum_duration_txt
        Me.maximum_duration_txt.Size = New System.Drawing.Size(550, 41)
        Me.maximum_duration_txt.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Minimum Loan"
        '
        'minimum_loan_txt
        '
        Me.minimum_loan_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.minimum_loan_txt.BorderRadius = 5
        Me.minimum_loan_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.minimum_loan_txt.DefaultText = ""
        Me.minimum_loan_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.minimum_loan_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.minimum_loan_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.minimum_loan_txt.DisabledState.Parent = Me.minimum_loan_txt
        Me.minimum_loan_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.minimum_loan_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minimum_loan_txt.FocusedState.Parent = Me.minimum_loan_txt
        Me.minimum_loan_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimum_loan_txt.ForeColor = System.Drawing.Color.Black
        Me.minimum_loan_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minimum_loan_txt.HoverState.Parent = Me.minimum_loan_txt
        Me.minimum_loan_txt.Location = New System.Drawing.Point(15, 239)
        Me.minimum_loan_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.minimum_loan_txt.Name = "minimum_loan_txt"
        Me.minimum_loan_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.minimum_loan_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.minimum_loan_txt.PlaceholderText = "0:00"
        Me.minimum_loan_txt.SelectedText = ""
        Me.minimum_loan_txt.ShadowDecoration.Parent = Me.minimum_loan_txt
        Me.minimum_loan_txt.Size = New System.Drawing.Size(550, 41)
        Me.minimum_loan_txt.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Maximum Loan"
        '
        'maximum_loan_txt
        '
        Me.maximum_loan_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.maximum_loan_txt.BorderRadius = 5
        Me.maximum_loan_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.maximum_loan_txt.DefaultText = ""
        Me.maximum_loan_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.maximum_loan_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.maximum_loan_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.maximum_loan_txt.DisabledState.Parent = Me.maximum_loan_txt
        Me.maximum_loan_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.maximum_loan_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximum_loan_txt.FocusedState.Parent = Me.maximum_loan_txt
        Me.maximum_loan_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maximum_loan_txt.ForeColor = System.Drawing.Color.Black
        Me.maximum_loan_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximum_loan_txt.HoverState.Parent = Me.maximum_loan_txt
        Me.maximum_loan_txt.Location = New System.Drawing.Point(15, 162)
        Me.maximum_loan_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.maximum_loan_txt.Name = "maximum_loan_txt"
        Me.maximum_loan_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.maximum_loan_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.maximum_loan_txt.PlaceholderText = "0:00"
        Me.maximum_loan_txt.SelectedText = ""
        Me.maximum_loan_txt.ShadowDecoration.Parent = Me.maximum_loan_txt
        Me.maximum_loan_txt.Size = New System.Drawing.Size(550, 41)
        Me.maximum_loan_txt.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Minimum Balance"
        '
        'minimum_balance_txt
        '
        Me.minimum_balance_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.minimum_balance_txt.BorderRadius = 5
        Me.minimum_balance_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.minimum_balance_txt.DefaultText = ""
        Me.minimum_balance_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.minimum_balance_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.minimum_balance_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.minimum_balance_txt.DisabledState.Parent = Me.minimum_balance_txt
        Me.minimum_balance_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.minimum_balance_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minimum_balance_txt.FocusedState.Parent = Me.minimum_balance_txt
        Me.minimum_balance_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimum_balance_txt.ForeColor = System.Drawing.Color.Black
        Me.minimum_balance_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minimum_balance_txt.HoverState.Parent = Me.minimum_balance_txt
        Me.minimum_balance_txt.Location = New System.Drawing.Point(15, 80)
        Me.minimum_balance_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.minimum_balance_txt.Name = "minimum_balance_txt"
        Me.minimum_balance_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.minimum_balance_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.minimum_balance_txt.PlaceholderText = "0:00"
        Me.minimum_balance_txt.SelectedText = ""
        Me.minimum_balance_txt.ShadowDecoration.Parent = Me.minimum_balance_txt
        Me.minimum_balance_txt.Size = New System.Drawing.Size(550, 41)
        Me.minimum_balance_txt.TabIndex = 13
        '
        'settlings_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 521)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "settlings_form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "settlings_form"
        Me.TopMost = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents maximum_duration_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents minimum_loan_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents maximum_loan_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents minimum_balance_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents updateButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents loan_rate_txt As Guna.UI2.WinForms.Guna2TextBox
End Class
