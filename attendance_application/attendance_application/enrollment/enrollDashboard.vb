Public Class enrollDashboard

    Private Sub enrollDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MyFunction.progressIndicatorHide(dashboardProgressIndicator, dashboardProgressBar)
        activeBtn()
        getPageForm(dashboardFormPage)
        dashboardBtn.Checked = True
        index.loginBtn.Enabled = True

        'Dim result = MyFunction.getStaffLoginDetails(index.login_staff_id, index.login_department_id)
        userNameLbl.Text = index.login_firstname
        departmentNameLbl.Text = index.login_department_name
        userRoleNameLbl.Text = index.login_role_name
        'Dim arrimage() As Byte = result.item3
        ' last_login_label.Text = "Last Login Date:" & " " & result.item2.ToString
        ' Dim mstream = New MemoryStream(arrimage)
        ' passport.Image = Image.FromStream(mstream)


    End Sub
    Private Sub dashboardBtn_Click_1(sender As System.Object, e As System.EventArgs) Handles dashboardBtn.Click
        activeBtn()
        dashboardBtn.Checked = True
        pageLoaderContainer.Show()
        dashboardTimerLoader.Start()
        'getPageForm(dashboardFormPage)
    End Sub
    Private Sub Guna2Button1_Click(sender As System.Object, e As System.EventArgs) Handles enrollBtn.Click
        activeBtn()
        enrollBtn.Checked = True
        pageLoaderContainer.Show()
        verificationFormPage.StopCapture()
        enrollmentFormPage.StartCapture()
        'StartCapture()

        enrollTimerLoader.Start()
        'getPageForm(enrollmentFormPage)
    End Sub
    Private Sub Guna2Button2_Click(sender As System.Object, e As System.EventArgs) Handles enrollListBtn.Click
        overlay.formLoaderContainer.Show()
        overlay.enrollListTimerLoader.Start()
        'formModal(enrollListView)
    End Sub

    Private Sub verifyBtn_Click(sender As System.Object, e As System.EventArgs) Handles verifyBtn.Click
        activeBtn()
        verifyBtn.Checked = True
        pageLoaderContainer.Show()
        enrollmentFormPage.StopCapture()
        verificationFormPage.StartCapture()
        verifyTimerLoader.Start()
        'getPageForm(verificationFormPage)
    End Sub

    Private Sub Guna2Button3_Click(sender As System.Object, e As System.EventArgs) Handles Guna2Button3.Click
        overlay.formLoaderContainer.Show()
        overlay.logoutTimerLoader.Start()
        ' formModal(logoutForm)
    End Sub

    Private Sub dashboardTimerLoader_Tick(sender As System.Object, e As System.EventArgs) Handles dashboardTimerLoader.Tick
        MyFunction.dashboardPageProgressIndicatorShow(dashboardFormPage, dashboardProgressBar, dashboardProgressIndicator, dashboardTimerLoader)
    End Sub

    Private Sub enrollTimerLoader_Tick(sender As System.Object, e As System.EventArgs) Handles enrollTimerLoader.Tick
        MyFunction.dashboardPageProgressIndicatorShow(enrollmentFormPage, dashboardProgressBar, dashboardProgressIndicator, enrollTimerLoader)
    End Sub

    Private Sub verifyTimerLoader_Tick(sender As System.Object, e As System.EventArgs) Handles verifyTimerLoader.Tick
        MyFunction.dashboardPageProgressIndicatorShow(verificationFormPage, dashboardProgressBar, dashboardProgressIndicator, verifyTimerLoader)
    End Sub

    Private Sub pageLoaderContainer_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pageLoaderContainer.Paint

    End Sub
End Class