<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index_form))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.loginAdminBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.loginUserBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.loginAdminBtn)
        Me.Panel2.Controls.Add(Me.loginUserBtn)
        Me.Panel2.Location = New System.Drawing.Point(-2, 200)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1022, 71)
        Me.Panel2.TabIndex = 1
        '
        'loginAdminBtn
        '
        Me.loginAdminBtn.Animated = True
        Me.loginAdminBtn.BorderRadius = 5
        Me.loginAdminBtn.CheckedState.Parent = Me.loginAdminBtn
        Me.loginAdminBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginAdminBtn.CustomImages.Parent = Me.loginAdminBtn
        Me.loginAdminBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.loginAdminBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.loginAdminBtn.ForeColor = System.Drawing.Color.White
        Me.loginAdminBtn.HoverState.Parent = Me.loginAdminBtn
        Me.loginAdminBtn.Location = New System.Drawing.Point(203, 11)
        Me.loginAdminBtn.Name = "loginAdminBtn"
        Me.loginAdminBtn.ShadowDecoration.Parent = Me.loginAdminBtn
        Me.loginAdminBtn.Size = New System.Drawing.Size(180, 48)
        Me.loginAdminBtn.TabIndex = 1
        Me.loginAdminBtn.Text = "LOGIN AS ADMIN"
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
        Me.loginUserBtn.Location = New System.Drawing.Point(14, 11)
        Me.loginUserBtn.Name = "loginUserBtn"
        Me.loginUserBtn.ShadowDecoration.Parent = Me.loginUserBtn
        Me.loginUserBtn.Size = New System.Drawing.Size(180, 48)
        Me.loginUserBtn.TabIndex = 0
        Me.loginUserBtn.Text = "LOGIN AS USER"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-2, 272)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1022, 245)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(938, 124)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME TO AFOOTECH GLOBAL BANK " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "APPLICATION SOFTWARE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.bank_application.My.Resources.Resources.bg_fw
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1022, 200)
        Me.Panel1.TabIndex = 0
        '
        'index_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1019, 513)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "index_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Afootech Global Bank Application Software"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents loginUserBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents loginAdminBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
