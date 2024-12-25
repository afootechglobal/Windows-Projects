Public Class enrollDashboard

    Private Sub enrollDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        activeBtn()
        getPageForm(dashboardFormPage)
        dashboardBtn.Checked = True
    End Sub
    Private Sub dashboardBtn_Click_1(sender As System.Object, e As System.EventArgs) Handles dashboardBtn.Click
        activeBtn()
        dashboardBtn.Checked = True
        getPageForm(dashboardFormPage)
    End Sub
    Private Sub Guna2Button1_Click(sender As System.Object, e As System.EventArgs) Handles enrollBtn.Click
        activeBtn()
        enrollBtn.Checked = True
        getPageForm(enrollmentFormPage)
    End Sub
    Private Sub Guna2Button2_Click(sender As System.Object, e As System.EventArgs) Handles enrollListBtn.Click
        formModal(enrollListView)
        'getModalForm(New enrollListFormPage(), Me)
    End Sub

    Private Sub verifyBtn_Click(sender As System.Object, e As System.EventArgs) Handles verifyBtn.Click
        activeBtn()
        verifyBtn.Checked = True
        getPageForm(verificationFormPage)
    End Sub

    Private Sub Guna2Button3_Click(sender As System.Object, e As System.EventArgs) Handles Guna2Button3.Click
        formModal(logoutForm)
    End Sub
End Class