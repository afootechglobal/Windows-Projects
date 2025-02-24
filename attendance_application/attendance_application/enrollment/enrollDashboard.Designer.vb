<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enrollDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(enrollDashboard))
        Me.dashboardContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.mainContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.pageLoaderContainer = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.dashboardProgressBar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.dashboardProgressIndicator = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.verifyBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.enrollListBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.enrollBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.dashboardBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.departmentNameLbl = New System.Windows.Forms.Label()
        Me.userRoleNameLbl = New System.Windows.Forms.Label()
        Me.userNameLbl = New System.Windows.Forms.Label()
        Me.profilePixBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.topSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dashboardPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.dashboardTimerLoader = New System.Windows.Forms.Timer(Me.components)
        Me.enrollTimerLoader = New System.Windows.Forms.Timer(Me.components)
        Me.verifyTimerLoader = New System.Windows.Forms.Timer(Me.components)
        Me.dashboardContainer.SuspendLayout()
        Me.mainContainer.SuspendLayout()
        Me.pageLoaderContainer.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.profilePixBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dashboardContainer
        '
        Me.dashboardContainer.BackColor = System.Drawing.Color.AliceBlue
        Me.dashboardContainer.Controls.Add(Me.mainContainer)
        Me.dashboardContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboardContainer.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dashboardContainer.Location = New System.Drawing.Point(0, 0)
        Me.dashboardContainer.Name = "dashboardContainer"
        Me.dashboardContainer.ShadowDecoration.Parent = Me.dashboardContainer
        Me.dashboardContainer.Size = New System.Drawing.Size(1221, 749)
        Me.dashboardContainer.TabIndex = 0
        '
        'mainContainer
        '
        Me.mainContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainContainer.BackColor = System.Drawing.Color.AntiqueWhite
        Me.mainContainer.Controls.Add(Me.pageLoaderContainer)
        Me.mainContainer.Controls.Add(Me.Guna2GradientPanel1)
        Me.mainContainer.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.mainContainer.Controls.Add(Me.dashboardPanel)
        Me.mainContainer.CustomBorderThickness = New System.Windows.Forms.Padding(20)
        Me.mainContainer.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.mainContainer.Location = New System.Drawing.Point(42, 12)
        Me.mainContainer.Name = "mainContainer"
        Me.mainContainer.ShadowDecoration.Parent = Me.mainContainer
        Me.mainContainer.Size = New System.Drawing.Size(1134, 713)
        Me.mainContainer.TabIndex = 1
        '
        'pageLoaderContainer
        '
        Me.pageLoaderContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pageLoaderContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pageLoaderContainer.Controls.Add(Me.dashboardProgressBar)
        Me.pageLoaderContainer.Controls.Add(Me.dashboardProgressIndicator)
        Me.pageLoaderContainer.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pageLoaderContainer.Location = New System.Drawing.Point(118, 97)
        Me.pageLoaderContainer.Name = "pageLoaderContainer"
        Me.pageLoaderContainer.ShadowDecoration.Parent = Me.pageLoaderContainer
        Me.pageLoaderContainer.Size = New System.Drawing.Size(1013, 613)
        Me.pageLoaderContainer.TabIndex = 4
        '
        'dashboardProgressBar
        '
        Me.dashboardProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dashboardProgressBar.Location = New System.Drawing.Point(350, 158)
        Me.dashboardProgressBar.Name = "dashboardProgressBar"
        Me.dashboardProgressBar.ShadowDecoration.Parent = Me.dashboardProgressBar
        Me.dashboardProgressBar.Size = New System.Drawing.Size(300, 30)
        Me.dashboardProgressBar.TabIndex = 26
        Me.dashboardProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'dashboardProgressIndicator
        '
        Me.dashboardProgressIndicator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dashboardProgressIndicator.BackColor = System.Drawing.Color.Transparent
        Me.dashboardProgressIndicator.CircleSize = 2.0!
        Me.dashboardProgressIndicator.Location = New System.Drawing.Point(446, 217)
        Me.dashboardProgressIndicator.Name = "dashboardProgressIndicator"
        Me.dashboardProgressIndicator.Size = New System.Drawing.Size(90, 90)
        Me.dashboardProgressIndicator.TabIndex = 25
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Guna2GradientPanel1.BorderRadius = 20
        Me.Guna2GradientPanel1.Controls.Add(Me.verifyBtn)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2GradientPanel1.Controls.Add(Me.enrollListBtn)
        Me.Guna2GradientPanel1.Controls.Add(Me.enrollBtn)
        Me.Guna2GradientPanel1.Controls.Add(Me.dashboardBtn)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 150)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(86, 470)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'verifyBtn
        '
        Me.verifyBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.verifyBtn.CheckedState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verifyBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.verifyBtn.CheckedState.Image = Global.tracksmart_application.My.Resources.Resources.icons8_fingerprint_48__4_
        Me.verifyBtn.CheckedState.Parent = Me.verifyBtn
        Me.verifyBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.verifyBtn.CustomImages.Parent = Me.verifyBtn
        Me.verifyBtn.FillColor = System.Drawing.Color.White
        Me.verifyBtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verifyBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.verifyBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.verifyBtn.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verifyBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.verifyBtn.HoverState.Image = Global.tracksmart_application.My.Resources.Resources.icons8_fingerprint_48__4_1
        Me.verifyBtn.HoverState.Parent = Me.verifyBtn
        Me.verifyBtn.Image = Global.tracksmart_application.My.Resources.Resources.icons8_fingerprint_48__3_1
        Me.verifyBtn.ImageOffset = New System.Drawing.Point(16, -10)
        Me.verifyBtn.ImageSize = New System.Drawing.Size(35, 35)
        Me.verifyBtn.Location = New System.Drawing.Point(7, 283)
        Me.verifyBtn.Name = "verifyBtn"
        Me.verifyBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.verifyBtn.PressedDepth = 10
        Me.verifyBtn.ShadowDecoration.Parent = Me.verifyBtn
        Me.verifyBtn.Size = New System.Drawing.Size(72, 69)
        Me.verifyBtn.TabIndex = 6
        Me.verifyBtn.Text = "Verification"
        Me.verifyBtn.TextOffset = New System.Drawing.Point(-10, 20)
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Guna2Button3.CheckedState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Guna2Button3.CheckedState.Image = Global.tracksmart_application.My.Resources.Resources.icons8_logout_481
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.White
        Me.Guna2Button3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Guna2Button3.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Guna2Button3.HoverState.Image = Global.tracksmart_application.My.Resources.Resources.icons8_logout_48
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Image = Global.tracksmart_application.My.Resources.Resources.icons8_logout_48__1_
        Me.Guna2Button3.ImageOffset = New System.Drawing.Point(14, -10)
        Me.Guna2Button3.ImageSize = New System.Drawing.Size(35, 35)
        Me.Guna2Button3.Location = New System.Drawing.Point(6, 376)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.PressedColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Guna2Button3.PressedDepth = 10
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(72, 69)
        Me.Guna2Button3.TabIndex = 5
        Me.Guna2Button3.Text = "Log Out"
        Me.Guna2Button3.TextOffset = New System.Drawing.Point(-10, 20)
        '
        'enrollListBtn
        '
        Me.enrollListBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.enrollListBtn.CheckedState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrollListBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.enrollListBtn.CheckedState.Image = Global.tracksmart_application.My.Resources.Resources.icons8_list_48__3_
        Me.enrollListBtn.CheckedState.Parent = Me.enrollListBtn
        Me.enrollListBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enrollListBtn.CustomImages.Parent = Me.enrollListBtn
        Me.enrollListBtn.FillColor = System.Drawing.Color.White
        Me.enrollListBtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrollListBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.enrollListBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.enrollListBtn.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrollListBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.enrollListBtn.HoverState.Image = Global.tracksmart_application.My.Resources.Resources.icons8_list_48__3_1
        Me.enrollListBtn.HoverState.Parent = Me.enrollListBtn
        Me.enrollListBtn.Image = Global.tracksmart_application.My.Resources.Resources.icons8_todo_list_48
        Me.enrollListBtn.ImageOffset = New System.Drawing.Point(16, -10)
        Me.enrollListBtn.ImageSize = New System.Drawing.Size(35, 35)
        Me.enrollListBtn.Location = New System.Drawing.Point(7, 194)
        Me.enrollListBtn.Name = "enrollListBtn"
        Me.enrollListBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.enrollListBtn.PressedDepth = 10
        Me.enrollListBtn.ShadowDecoration.Parent = Me.enrollListBtn
        Me.enrollListBtn.Size = New System.Drawing.Size(72, 69)
        Me.enrollListBtn.TabIndex = 4
        Me.enrollListBtn.Text = "Enroll List"
        Me.enrollListBtn.TextOffset = New System.Drawing.Point(-10, 20)
        '
        'enrollBtn
        '
        Me.enrollBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.enrollBtn.CheckedState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrollBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.enrollBtn.CheckedState.Image = Global.tracksmart_application.My.Resources.Resources.icons8_fingerprint_48__1_
        Me.enrollBtn.CheckedState.Parent = Me.enrollBtn
        Me.enrollBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enrollBtn.CustomImages.Parent = Me.enrollBtn
        Me.enrollBtn.FillColor = System.Drawing.Color.White
        Me.enrollBtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrollBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.enrollBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.enrollBtn.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrollBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.enrollBtn.HoverState.Image = Global.tracksmart_application.My.Resources.Resources.icons8_fingerprint_48__1_1
        Me.enrollBtn.HoverState.Parent = Me.enrollBtn
        Me.enrollBtn.Image = Global.tracksmart_application.My.Resources.Resources.icons8_fingerprint_48__2_
        Me.enrollBtn.ImageOffset = New System.Drawing.Point(16, -10)
        Me.enrollBtn.ImageSize = New System.Drawing.Size(35, 35)
        Me.enrollBtn.Location = New System.Drawing.Point(7, 105)
        Me.enrollBtn.Name = "enrollBtn"
        Me.enrollBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.enrollBtn.PressedDepth = 10
        Me.enrollBtn.ShadowDecoration.Parent = Me.enrollBtn
        Me.enrollBtn.Size = New System.Drawing.Size(72, 69)
        Me.enrollBtn.TabIndex = 3
        Me.enrollBtn.Text = "Enrollment"
        Me.enrollBtn.TextOffset = New System.Drawing.Point(-10, 20)
        '
        'dashboardBtn
        '
        Me.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.dashboardBtn.CheckedState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.dashboardBtn.CheckedState.Image = Global.tracksmart_application.My.Resources.Resources.icons8_dashboard_layout_48__1_
        Me.dashboardBtn.CheckedState.Parent = Me.dashboardBtn
        Me.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboardBtn.CustomImages.Parent = Me.dashboardBtn
        Me.dashboardBtn.FillColor = System.Drawing.Color.White
        Me.dashboardBtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dashboardBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.dashboardBtn.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.dashboardBtn.HoverState.Image = Global.tracksmart_application.My.Resources.Resources.icons8_dashboard_layout_48__1_1
        Me.dashboardBtn.HoverState.Parent = Me.dashboardBtn
        Me.dashboardBtn.Image = Global.tracksmart_application.My.Resources.Resources.icons8_dashboard_layout_48
        Me.dashboardBtn.ImageOffset = New System.Drawing.Point(16, -10)
        Me.dashboardBtn.ImageSize = New System.Drawing.Size(35, 35)
        Me.dashboardBtn.Location = New System.Drawing.Point(7, 17)
        Me.dashboardBtn.Name = "dashboardBtn"
        Me.dashboardBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dashboardBtn.PressedDepth = 10
        Me.dashboardBtn.ShadowDecoration.Parent = Me.dashboardBtn
        Me.dashboardBtn.Size = New System.Drawing.Size(72, 69)
        Me.dashboardBtn.TabIndex = 2
        Me.dashboardBtn.Text = "Dashboard"
        Me.dashboardBtn.TextOffset = New System.Drawing.Point(-10, 20)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 2
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Guna2CustomGradientPanel1.BorderRadius = 15
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.departmentNameLbl)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.userRoleNameLbl)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.userNameLbl)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.profilePixBox)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.topSearch)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(3, 16)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1128, 70)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'departmentNameLbl
        '
        Me.departmentNameLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.departmentNameLbl.AutoSize = True
        Me.departmentNameLbl.BackColor = System.Drawing.Color.White
        Me.departmentNameLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.departmentNameLbl.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentNameLbl.ForeColor = System.Drawing.Color.Gray
        Me.departmentNameLbl.Location = New System.Drawing.Point(947, 30)
        Me.departmentNameLbl.Name = "departmentNameLbl"
        Me.departmentNameLbl.Size = New System.Drawing.Size(30, 11)
        Me.departmentNameLbl.TabIndex = 3
        Me.departmentNameLbl.Text = "Xxxx"
        '
        'userRoleNameLbl
        '
        Me.userRoleNameLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userRoleNameLbl.AutoSize = True
        Me.userRoleNameLbl.BackColor = System.Drawing.Color.White
        Me.userRoleNameLbl.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userRoleNameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.userRoleNameLbl.Location = New System.Drawing.Point(947, 47)
        Me.userRoleNameLbl.Name = "userRoleNameLbl"
        Me.userRoleNameLbl.Size = New System.Drawing.Size(30, 11)
        Me.userRoleNameLbl.TabIndex = 2
        Me.userRoleNameLbl.Text = "Xxxx"
        '
        'userNameLbl
        '
        Me.userNameLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userNameLbl.AutoSize = True
        Me.userNameLbl.BackColor = System.Drawing.Color.White
        Me.userNameLbl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameLbl.Location = New System.Drawing.Point(947, 10)
        Me.userNameLbl.Name = "userNameLbl"
        Me.userNameLbl.Size = New System.Drawing.Size(38, 16)
        Me.userNameLbl.TabIndex = 1
        Me.userNameLbl.Text = "Xxxx"
        '
        'profilePixBox
        '
        Me.profilePixBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.profilePixBox.BackColor = System.Drawing.Color.White
        Me.profilePixBox.Image = Global.tracksmart_application.My.Resources.Resources.images__1_
        Me.profilePixBox.Location = New System.Drawing.Point(887, 10)
        Me.profilePixBox.Name = "profilePixBox"
        Me.profilePixBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.profilePixBox.ShadowDecoration.Parent = Me.profilePixBox
        Me.profilePixBox.Size = New System.Drawing.Size(48, 47)
        Me.profilePixBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profilePixBox.TabIndex = 1
        Me.profilePixBox.TabStop = False
        '
        'topSearch
        '
        Me.topSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.topSearch.BackColor = System.Drawing.Color.Transparent
        Me.topSearch.BorderColor = System.Drawing.Color.White
        Me.topSearch.BorderRadius = 20
        Me.topSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.topSearch.DefaultText = ""
        Me.topSearch.DisabledState.BorderColor = System.Drawing.Color.White
        Me.topSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.topSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.topSearch.DisabledState.Parent = Me.topSearch
        Me.topSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.topSearch.FillColor = System.Drawing.Color.WhiteSmoke
        Me.topSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.topSearch.FocusedState.Parent = Me.topSearch
        Me.topSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.topSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.topSearch.HoverState.Parent = Me.topSearch
        Me.topSearch.IconLeft = Global.tracksmart_application.My.Resources.Resources.icons8_search_50
        Me.topSearch.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.topSearch.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.topSearch.Location = New System.Drawing.Point(440, 17)
        Me.topSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.topSearch.Name = "topSearch"
        Me.topSearch.Padding = New System.Windows.Forms.Padding(10)
        Me.topSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.topSearch.PlaceholderText = "Type here to search"
        Me.topSearch.SelectedText = ""
        Me.topSearch.ShadowDecoration.Parent = Me.topSearch
        Me.topSearch.Size = New System.Drawing.Size(425, 40)
        Me.topSearch.TabIndex = 1
        Me.topSearch.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TrackSmart"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.White
        Me.Guna2PictureBox2.Image = Global.tracksmart_application.My.Resources.Resources.image
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(25, 10)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 0
        Me.Guna2PictureBox2.TabStop = False
        '
        'dashboardPanel
        '
        Me.dashboardPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dashboardPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dashboardPanel.Location = New System.Drawing.Point(118, 94)
        Me.dashboardPanel.Name = "dashboardPanel"
        Me.dashboardPanel.ShadowDecoration.Parent = Me.dashboardPanel
        Me.dashboardPanel.Size = New System.Drawing.Size(1016, 619)
        Me.dashboardPanel.TabIndex = 3
        '
        'dashboardTimerLoader
        '
        '
        'enrollTimerLoader
        '
        '
        'verifyTimerLoader
        '
        '
        'enrollDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 749)
        Me.Controls.Add(Me.dashboardContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "enrollDashboard"
        Me.Text = "TrackSmart - Enrollment Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.dashboardContainer.ResumeLayout(False)
        Me.mainContainer.ResumeLayout(False)
        Me.pageLoaderContainer.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.profilePixBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dashboardContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents mainContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents topSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents profilePixBox As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents userRoleNameLbl As System.Windows.Forms.Label
    Friend WithEvents userNameLbl As System.Windows.Forms.Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dashboardBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents enrollListBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents enrollBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashboardPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents verifyBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents departmentNameLbl As System.Windows.Forms.Label
    Friend WithEvents dashboardProgressBar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents dashboardProgressIndicator As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents dashboardTimerLoader As System.Windows.Forms.Timer
    Friend WithEvents pageLoaderContainer As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents enrollTimerLoader As System.Windows.Forms.Timer
    Friend WithEvents verifyTimerLoader As System.Windows.Forms.Timer
End Class
