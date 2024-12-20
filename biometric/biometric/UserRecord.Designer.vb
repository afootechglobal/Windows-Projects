<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserRecord))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "REG20231224421", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "OGUNLEYE OPEYEMI JAMIU", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.SearchIDCheckBox = New System.Windows.Forms.CheckBox()
        Me.SearchCheckBox = New System.Windows.Forms.CheckBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CircleAvatar1 = New WindowsApplication1.CircleAvatar()
        Me.AddNewUserBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.CircleAvatar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2GroupBox1.Controls.Add(Me.SearchIDCheckBox)
        Me.Guna2GroupBox1.Controls.Add(Me.SearchCheckBox)
        Me.Guna2GroupBox1.Controls.Add(Me.SearchTextBox)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.CircleAvatar1)
        Me.Guna2GroupBox1.Controls.Add(Me.AddNewUserBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.TotalLabel)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.UserListView)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1295, 535)
        Me.Guna2GroupBox1.TabIndex = 2
        Me.Guna2GroupBox1.Text = "Users Record"
        '
        'SearchIDCheckBox
        '
        Me.SearchIDCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchIDCheckBox.AutoSize = True
        Me.SearchIDCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.SearchIDCheckBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchIDCheckBox.Location = New System.Drawing.Point(886, 48)
        Me.SearchIDCheckBox.Name = "SearchIDCheckBox"
        Me.SearchIDCheckBox.Size = New System.Drawing.Size(94, 16)
        Me.SearchIDCheckBox.TabIndex = 21
        Me.SearchIDCheckBox.TabStop = False
        Me.SearchIDCheckBox.Text = "Search by ID"
        Me.SearchIDCheckBox.UseVisualStyleBackColor = False
        '
        'SearchCheckBox
        '
        Me.SearchCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchCheckBox.AutoSize = True
        Me.SearchCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.SearchCheckBox.Checked = True
        Me.SearchCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SearchCheckBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchCheckBox.Location = New System.Drawing.Point(754, 49)
        Me.SearchCheckBox.Name = "SearchCheckBox"
        Me.SearchCheckBox.Size = New System.Drawing.Size(115, 16)
        Me.SearchCheckBox.TabIndex = 20
        Me.SearchCheckBox.TabStop = False
        Me.SearchCheckBox.Text = "Search by Name"
        Me.SearchCheckBox.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SearchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(102, 45)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(639, 25)
        Me.SearchTextBox.TabIndex = 19
        Me.SearchTextBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 12)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Search Here :"
        '
        'CircleAvatar1
        '
        Me.CircleAvatar1.BackColor = System.Drawing.Color.Transparent
        Me.CircleAvatar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CircleAvatar1.Image = CType(resources.GetObject("CircleAvatar1.Image"), System.Drawing.Image)
        Me.CircleAvatar1.Location = New System.Drawing.Point(1255, 3)
        Me.CircleAvatar1.Name = "CircleAvatar1"
        Me.CircleAvatar1.Size = New System.Drawing.Size(32, 32)
        Me.CircleAvatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CircleAvatar1.TabIndex = 17
        Me.CircleAvatar1.TabStop = False
        '
        'AddNewUserBtn
        '
        Me.AddNewUserBtn.CheckedState.Parent = Me.AddNewUserBtn
        Me.AddNewUserBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddNewUserBtn.CustomImages.Parent = Me.AddNewUserBtn
        Me.AddNewUserBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.AddNewUserBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewUserBtn.ForeColor = System.Drawing.Color.White
        Me.AddNewUserBtn.HoverState.Parent = Me.AddNewUserBtn
        Me.AddNewUserBtn.Location = New System.Drawing.Point(1163, 46)
        Me.AddNewUserBtn.Name = "AddNewUserBtn"
        Me.AddNewUserBtn.ShadowDecoration.Parent = Me.AddNewUserBtn
        Me.AddNewUserBtn.Size = New System.Drawing.Size(128, 25)
        Me.AddNewUserBtn.TabIndex = 16
        Me.AddNewUserBtn.Text = "Add New User"
        '
        'TotalLabel
        '
        Me.TotalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.TotalLabel.Location = New System.Drawing.Point(89, 513)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(15, 15)
        Me.TotalLabel.TabIndex = 15
        Me.TotalLabel.Text = "0"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(3, 514)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 12)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total Record :"
        '
        'UserListView
        '
        Me.UserListView.BackColor = System.Drawing.SystemColors.Window
        Me.UserListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.UserListView.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserListView.FullRowSelect = True
        Me.UserListView.GridLines = True
        Me.UserListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.UserListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.UserListView.Location = New System.Drawing.Point(0, 78)
        Me.UserListView.MultiSelect = False
        Me.UserListView.Name = "UserListView"
        Me.UserListView.Size = New System.Drawing.Size(1295, 425)
        Me.UserListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.UserListView.TabIndex = 0
        Me.UserListView.UseCompatibleStateImageBehavior = False
        Me.UserListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "RegNo"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Full Name"
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Email Address"
        Me.ColumnHeader3.Width = 300
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Phone No"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Address"
        Me.ColumnHeader5.Width = 300
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Gender"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Registered By"
        Me.ColumnHeader7.Width = 350
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Registered Date"
        Me.ColumnHeader8.Width = 200
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Action"
        Me.ColumnHeader9.Width = 150
        '
        'UserRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 535)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserRecord"
        Me.Text = "UserRecord"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.CircleAvatar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents UserListView As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddNewUserBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CircleAvatar1 As WindowsApplication1.CircleAvatar
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SearchIDCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SearchCheckBox As System.Windows.Forms.CheckBox
End Class
