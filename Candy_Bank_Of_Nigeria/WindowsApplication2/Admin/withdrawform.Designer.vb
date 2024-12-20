<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class withdrawform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(withdrawform))
        Me.profile_id = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.trans_history_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.withraw_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.withdraw_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.profile_id.Location = New System.Drawing.Point(10, 46)
        Me.profile_id.Name = "profile_id"
        Me.profile_id.ShadowDecoration.Parent = Me.profile_id
        Me.profile_id.Size = New System.Drawing.Size(447, 36)
        Me.profile_id.TabIndex = 8
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
        Me.clear_btn.Location = New System.Drawing.Point(14, 277)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(102, 40)
        Me.clear_btn.TabIndex = 33
        Me.clear_btn.Text = "CLEAR"
        '
        'trans_history_btn
        '
        Me.trans_history_btn.BackColor = System.Drawing.SystemColors.Control
        Me.trans_history_btn.BorderColor = System.Drawing.Color.Transparent
        Me.trans_history_btn.BorderRadius = 5
        Me.trans_history_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.trans_history_btn.CheckedState.Parent = Me.trans_history_btn
        Me.trans_history_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trans_history_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.trans_history_btn.CustomImages.Parent = Me.trans_history_btn
        Me.trans_history_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trans_history_btn.ForeColor = System.Drawing.Color.White
        Me.trans_history_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.trans_history_btn.HoverState.Parent = Me.trans_history_btn
        Me.trans_history_btn.Location = New System.Drawing.Point(270, 88)
        Me.trans_history_btn.Name = "trans_history_btn"
        Me.trans_history_btn.ShadowDecoration.Parent = Me.trans_history_btn
        Me.trans_history_btn.Size = New System.Drawing.Size(187, 42)
        Me.trans_history_btn.TabIndex = 10
        Me.trans_history_btn.Text = "TRANSACTION HISTORY"
        '
        'withraw_btn
        '
        Me.withraw_btn.BackColor = System.Drawing.SystemColors.Control
        Me.withraw_btn.BorderColor = System.Drawing.Color.Transparent
        Me.withraw_btn.BorderRadius = 5
        Me.withraw_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.withraw_btn.CheckedState.Parent = Me.withraw_btn
        Me.withraw_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.withraw_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.withraw_btn.CustomImages.Parent = Me.withraw_btn
        Me.withraw_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withraw_btn.ForeColor = System.Drawing.Color.White
        Me.withraw_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.withraw_btn.HoverState.Parent = Me.withraw_btn
        Me.withraw_btn.Location = New System.Drawing.Point(379, 277)
        Me.withraw_btn.Name = "withraw_btn"
        Me.withraw_btn.ShadowDecoration.Parent = Me.withraw_btn
        Me.withraw_btn.Size = New System.Drawing.Size(102, 40)
        Me.withraw_btn.TabIndex = 32
        Me.withraw_btn.Text = "WITHDRAW"
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
        Me.close_btn.Location = New System.Drawing.Point(457, 4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(36, 40)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        '
        'withdraw_txt
        '
        Me.withdraw_txt.BorderRadius = 5
        Me.withdraw_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.withdraw_txt.DefaultText = ""
        Me.withdraw_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.withdraw_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.withdraw_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.withdraw_txt.DisabledState.Parent = Me.withdraw_txt
        Me.withdraw_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.withdraw_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.withdraw_txt.FocusedState.Parent = Me.withdraw_txt
        Me.withdraw_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withdraw_txt.ForeColor = System.Drawing.Color.Black
        Me.withdraw_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.withdraw_txt.HoverState.Parent = Me.withdraw_txt
        Me.withdraw_txt.Location = New System.Drawing.Point(14, 229)
        Me.withdraw_txt.Name = "withdraw_txt"
        Me.withdraw_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.withdraw_txt.PlaceholderText = "0.00"
        Me.withdraw_txt.SelectedText = ""
        Me.withdraw_txt.ShadowDecoration.Parent = Me.withdraw_txt
        Me.withdraw_txt.Size = New System.Drawing.Size(467, 38)
        Me.withdraw_txt.TabIndex = 31
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(14, 210)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(126, 17)
        Me.Guna2HtmlLabel2.TabIndex = 30
        Me.Guna2HtmlLabel2.Text = "Withdrawal Amount"
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(499, 48)
        Me.Guna2Panel1.TabIndex = 28
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(45, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(66, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Withdrwal"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources._5409308_middle1
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(38, 43)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 4
        Me.Guna2GroupBox1.Controls.Add(Me.trans_history_btn)
        Me.Guna2GroupBox1.Controls.Add(Me.profile_id)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(14, 55)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(467, 149)
        Me.Guna2GroupBox1.TabIndex = 29
        Me.Guna2GroupBox1.Text = "PROFILE ID"
        '
        'withdrawform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 365)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.withraw_btn)
        Me.Controls.Add(Me.withdraw_txt)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "withdrawform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "withdrawform"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents profile_id As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents trans_history_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents withraw_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents withdraw_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
End Class
