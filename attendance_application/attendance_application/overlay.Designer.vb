<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class overlay
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
        Me.formLoaderContainer = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.dashboardProgressBar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.dashboardProgressIndicator = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.enrollListTimerLoader = New System.Windows.Forms.Timer(Me.components)
        Me.logoutTimerLoader = New System.Windows.Forms.Timer(Me.components)
        Me.formLoaderContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'formLoaderContainer
        '
        Me.formLoaderContainer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.formLoaderContainer.Controls.Add(Me.dashboardProgressBar)
        Me.formLoaderContainer.Controls.Add(Me.dashboardProgressIndicator)
        Me.formLoaderContainer.Location = New System.Drawing.Point(294, 107)
        Me.formLoaderContainer.Name = "formLoaderContainer"
        Me.formLoaderContainer.ShadowDecoration.Parent = Me.formLoaderContainer
        Me.formLoaderContainer.Size = New System.Drawing.Size(411, 196)
        Me.formLoaderContainer.TabIndex = 0
        '
        'dashboardProgressBar
        '
        Me.dashboardProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dashboardProgressBar.Location = New System.Drawing.Point(55, 20)
        Me.dashboardProgressBar.Name = "dashboardProgressBar"
        Me.dashboardProgressBar.ShadowDecoration.Parent = Me.dashboardProgressBar
        Me.dashboardProgressBar.Size = New System.Drawing.Size(300, 30)
        Me.dashboardProgressBar.TabIndex = 28
        Me.dashboardProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'dashboardProgressIndicator
        '
        Me.dashboardProgressIndicator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dashboardProgressIndicator.BackColor = System.Drawing.Color.Transparent
        Me.dashboardProgressIndicator.CircleSize = 2.0!
        Me.dashboardProgressIndicator.Location = New System.Drawing.Point(165, 86)
        Me.dashboardProgressIndicator.Name = "dashboardProgressIndicator"
        Me.dashboardProgressIndicator.Size = New System.Drawing.Size(90, 90)
        Me.dashboardProgressIndicator.TabIndex = 27
        '
        'enrollListTimerLoader
        '
        '
        'logoutTimerLoader
        '
        '
        'overlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1042, 490)
        Me.Controls.Add(Me.formLoaderContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "overlay"
        Me.Opacity = 0.5R
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "overlay"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.formLoaderContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents formLoaderContainer As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents dashboardProgressBar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents dashboardProgressIndicator As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents enrollListTimerLoader As System.Windows.Forms.Timer
    Friend WithEvents logoutTimerLoader As System.Windows.Forms.Timer
End Class
