<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassForm))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SubmitButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConfirmedPass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NewPass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurrentPass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.CheckBox3)
        Me.Guna2GroupBox1.Controls.Add(Me.CheckBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.CheckBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.CloseButton)
        Me.Guna2GroupBox1.Controls.Add(Me.SubmitButton)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.ConfirmedPass_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.NewPass_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.CurrentPass_txt)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(539, 382)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Change Password"
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.White
        Me.CheckBox2.BackgroundImage = CType(resources.GetObject("CheckBox2.BackgroundImage"), System.Drawing.Image)
        Me.CheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckBox2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CheckBox2.FlatAppearance.BorderSize = 0
        Me.CheckBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CheckBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(470, 186)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(20, 23)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = " "
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.eye5
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CheckBox1.FlatAppearance.BorderSize = 0
        Me.CheckBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CheckBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(470, 102)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(20, 23)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = " "
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BorderRadius = 5
        Me.CloseButton.CheckedState.Parent = Me.CloseButton
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.CustomImages.Parent = Me.CloseButton
        Me.CloseButton.FillColor = System.Drawing.Color.Maroon
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.HoverState.Parent = Me.CloseButton
        Me.CloseButton.Location = New System.Drawing.Point(321, 325)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(180, 45)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.Text = "Close"
        '
        'SubmitButton
        '
        Me.SubmitButton.BorderRadius = 5
        Me.SubmitButton.CheckedState.Parent = Me.SubmitButton
        Me.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubmitButton.CustomImages.Parent = Me.SubmitButton
        Me.SubmitButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.SubmitButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.ForeColor = System.Drawing.Color.White
        Me.SubmitButton.HoverState.Parent = Me.SubmitButton
        Me.SubmitButton.Location = New System.Drawing.Point(30, 325)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.ShadowDecoration.Parent = Me.SubmitButton
        Me.SubmitButton.Size = New System.Drawing.Size(180, 45)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "Submit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Confirmed Password"
        '
        'ConfirmedPass_txt
        '
        Me.ConfirmedPass_txt.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ConfirmedPass_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.ConfirmedPass_txt.BorderRadius = 5
        Me.ConfirmedPass_txt.BorderThickness = 0
        Me.ConfirmedPass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ConfirmedPass_txt.DefaultText = ""
        Me.ConfirmedPass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ConfirmedPass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ConfirmedPass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmedPass_txt.DisabledState.Parent = Me.ConfirmedPass_txt
        Me.ConfirmedPass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmedPass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmedPass_txt.FocusedState.Parent = Me.ConfirmedPass_txt
        Me.ConfirmedPass_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmedPass_txt.ForeColor = System.Drawing.Color.Black
        Me.ConfirmedPass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmedPass_txt.HoverState.Parent = Me.ConfirmedPass_txt
        Me.ConfirmedPass_txt.Location = New System.Drawing.Point(33, 259)
        Me.ConfirmedPass_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.ConfirmedPass_txt.Name = "ConfirmedPass_txt"
        Me.ConfirmedPass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ConfirmedPass_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.ConfirmedPass_txt.PlaceholderText = ""
        Me.ConfirmedPass_txt.SelectedText = ""
        Me.ConfirmedPass_txt.ShadowDecoration.Parent = Me.ConfirmedPass_txt
        Me.ConfirmedPass_txt.Size = New System.Drawing.Size(468, 41)
        Me.ConfirmedPass_txt.TabIndex = 8
        Me.ConfirmedPass_txt.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "New Password"
        '
        'NewPass_txt
        '
        Me.NewPass_txt.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.NewPass_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.NewPass_txt.BorderRadius = 5
        Me.NewPass_txt.BorderThickness = 0
        Me.NewPass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NewPass_txt.DefaultText = ""
        Me.NewPass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NewPass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NewPass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NewPass_txt.DisabledState.Parent = Me.NewPass_txt
        Me.NewPass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NewPass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NewPass_txt.FocusedState.Parent = Me.NewPass_txt
        Me.NewPass_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPass_txt.ForeColor = System.Drawing.Color.Black
        Me.NewPass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NewPass_txt.HoverState.Parent = Me.NewPass_txt
        Me.NewPass_txt.Location = New System.Drawing.Point(30, 177)
        Me.NewPass_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.NewPass_txt.Name = "NewPass_txt"
        Me.NewPass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NewPass_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.NewPass_txt.PlaceholderText = ""
        Me.NewPass_txt.SelectedText = ""
        Me.NewPass_txt.ShadowDecoration.Parent = Me.NewPass_txt
        Me.NewPass_txt.Size = New System.Drawing.Size(468, 41)
        Me.NewPass_txt.TabIndex = 6
        Me.NewPass_txt.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Current Password"
        '
        'CurrentPass_txt
        '
        Me.CurrentPass_txt.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrentPass_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.CurrentPass_txt.BorderRadius = 5
        Me.CurrentPass_txt.BorderThickness = 0
        Me.CurrentPass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CurrentPass_txt.DefaultText = ""
        Me.CurrentPass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CurrentPass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CurrentPass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CurrentPass_txt.DisabledState.Parent = Me.CurrentPass_txt
        Me.CurrentPass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CurrentPass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CurrentPass_txt.FocusedState.Parent = Me.CurrentPass_txt
        Me.CurrentPass_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPass_txt.ForeColor = System.Drawing.Color.Black
        Me.CurrentPass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CurrentPass_txt.HoverState.Parent = Me.CurrentPass_txt
        Me.CurrentPass_txt.Location = New System.Drawing.Point(30, 93)
        Me.CurrentPass_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.CurrentPass_txt.Name = "CurrentPass_txt"
        Me.CurrentPass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CurrentPass_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.CurrentPass_txt.PlaceholderText = ""
        Me.CurrentPass_txt.SelectedText = ""
        Me.CurrentPass_txt.ShadowDecoration.Parent = Me.CurrentPass_txt
        Me.CurrentPass_txt.Size = New System.Drawing.Size(468, 41)
        Me.CurrentPass_txt.TabIndex = 4
        Me.CurrentPass_txt.UseSystemPasswordChar = True
        '
        'CheckBox3
        '
        Me.CheckBox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.White
        Me.CheckBox3.BackgroundImage = CType(resources.GetObject("CheckBox3.BackgroundImage"), System.Drawing.Image)
        Me.CheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckBox3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CheckBox3.FlatAppearance.BorderSize = 0
        Me.CheckBox3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CheckBox3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(470, 268)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(20, 23)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = " "
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'ChangePassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 382)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChangePassForm"
        Me.Text = "ChangePassForm"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CurrentPass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ConfirmedPass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NewPass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SubmitButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
End Class
