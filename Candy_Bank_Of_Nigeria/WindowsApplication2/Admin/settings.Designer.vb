<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.update_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.loan_rate_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.maximum_duration_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.minimum_loan_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.minimum_balance_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.maximum_loan_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'update_btn
        '
        Me.update_btn.BackColor = System.Drawing.SystemColors.Control
        Me.update_btn.BorderColor = System.Drawing.Color.Transparent
        Me.update_btn.BorderRadius = 5
        Me.update_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.update_btn.CheckedState.Parent = Me.update_btn
        Me.update_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.update_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.update_btn.CustomImages.Parent = Me.update_btn
        Me.update_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.ForeColor = System.Drawing.Color.White
        Me.update_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.update_btn.HoverState.Parent = Me.update_btn
        Me.update_btn.Location = New System.Drawing.Point(342, 383)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.ShadowDecoration.Parent = Me.update_btn
        Me.update_btn.Size = New System.Drawing.Size(111, 41)
        Me.update_btn.TabIndex = 34
        Me.update_btn.Text = "UPDATE"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(16, 253)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(102, 15)
        Me.Guna2HtmlLabel2.TabIndex = 33
        Me.Guna2HtmlLabel2.Text = "Maximun Duration"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(16, 321)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(73, 15)
        Me.Guna2HtmlLabel6.TabIndex = 32
        Me.Guna2HtmlLabel6.Text = "Loan Rate(%)"
        '
        'loan_rate_txt
        '
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
        Me.loan_rate_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_rate_txt.ForeColor = System.Drawing.Color.Black
        Me.loan_rate_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_rate_txt.HoverState.Parent = Me.loan_rate_txt
        Me.loan_rate_txt.Location = New System.Drawing.Point(14, 338)
        Me.loan_rate_txt.Name = "loan_rate_txt"
        Me.loan_rate_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loan_rate_txt.PlaceholderText = "0.00"
        Me.loan_rate_txt.SelectedText = ""
        Me.loan_rate_txt.ShadowDecoration.Parent = Me.loan_rate_txt
        Me.loan_rate_txt.Size = New System.Drawing.Size(439, 38)
        Me.loan_rate_txt.TabIndex = 31
        '
        'maximum_duration_txt
        '
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
        Me.maximum_duration_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maximum_duration_txt.ForeColor = System.Drawing.Color.Black
        Me.maximum_duration_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximum_duration_txt.HoverState.Parent = Me.maximum_duration_txt
        Me.maximum_duration_txt.Location = New System.Drawing.Point(14, 276)
        Me.maximum_duration_txt.Name = "maximum_duration_txt"
        Me.maximum_duration_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.maximum_duration_txt.PlaceholderText = "0.00"
        Me.maximum_duration_txt.SelectedText = ""
        Me.maximum_duration_txt.ShadowDecoration.Parent = Me.maximum_duration_txt
        Me.maximum_duration_txt.Size = New System.Drawing.Size(439, 38)
        Me.maximum_duration_txt.TabIndex = 30
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(16, 123)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(85, 15)
        Me.Guna2HtmlLabel5.TabIndex = 29
        Me.Guna2HtmlLabel5.Text = "Maximum Loan"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(16, 190)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(83, 15)
        Me.Guna2HtmlLabel3.TabIndex = 28
        Me.Guna2HtmlLabel3.Text = "Minimum Loan"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(16, 61)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(97, 15)
        Me.Guna2HtmlLabel4.TabIndex = 27
        Me.Guna2HtmlLabel4.Text = "Minimum Balance"
        '
        'minimum_loan_txt
        '
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
        Me.minimum_loan_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimum_loan_txt.ForeColor = System.Drawing.Color.Black
        Me.minimum_loan_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minimum_loan_txt.HoverState.Parent = Me.minimum_loan_txt
        Me.minimum_loan_txt.Location = New System.Drawing.Point(14, 207)
        Me.minimum_loan_txt.Name = "minimum_loan_txt"
        Me.minimum_loan_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.minimum_loan_txt.PlaceholderText = "0.00"
        Me.minimum_loan_txt.SelectedText = ""
        Me.minimum_loan_txt.ShadowDecoration.Parent = Me.minimum_loan_txt
        Me.minimum_loan_txt.Size = New System.Drawing.Size(439, 38)
        Me.minimum_loan_txt.TabIndex = 26
        '
        'minimum_balance_txt
        '
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
        Me.minimum_balance_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimum_balance_txt.ForeColor = System.Drawing.Color.Black
        Me.minimum_balance_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minimum_balance_txt.HoverState.Parent = Me.minimum_balance_txt
        Me.minimum_balance_txt.Location = New System.Drawing.Point(14, 78)
        Me.minimum_balance_txt.Name = "minimum_balance_txt"
        Me.minimum_balance_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.minimum_balance_txt.PlaceholderText = "0.00"
        Me.minimum_balance_txt.SelectedText = ""
        Me.minimum_balance_txt.ShadowDecoration.Parent = Me.minimum_balance_txt
        Me.minimum_balance_txt.Size = New System.Drawing.Size(439, 38)
        Me.minimum_balance_txt.TabIndex = 24
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(45, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(129, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "SYSTEM SETTINGS"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources._5409308_middle1
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 2)
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
        Me.close_btn.Location = New System.Drawing.Point(424, 4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(36, 40)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        '
        'maximum_loan_txt
        '
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
        Me.maximum_loan_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maximum_loan_txt.ForeColor = System.Drawing.Color.Black
        Me.maximum_loan_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximum_loan_txt.HoverState.Parent = Me.maximum_loan_txt
        Me.maximum_loan_txt.Location = New System.Drawing.Point(14, 146)
        Me.maximum_loan_txt.Name = "maximum_loan_txt"
        Me.maximum_loan_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.maximum_loan_txt.PlaceholderText = "0.00"
        Me.maximum_loan_txt.SelectedText = ""
        Me.maximum_loan_txt.ShadowDecoration.Parent = Me.maximum_loan_txt
        Me.maximum_loan_txt.Size = New System.Drawing.Size(439, 38)
        Me.maximum_loan_txt.TabIndex = 25
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.close_btn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(463, 48)
        Me.Guna2Panel1.TabIndex = 23
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 448)
        Me.Controls.Add(Me.update_btn)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.loan_rate_txt)
        Me.Controls.Add(Me.maximum_duration_txt)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.minimum_loan_txt)
        Me.Controls.Add(Me.minimum_balance_txt)
        Me.Controls.Add(Me.maximum_loan_txt)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "settings"
        Me.TopMost = True
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents update_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents loan_rate_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents maximum_duration_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents minimum_loan_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents minimum_balance_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents maximum_loan_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
