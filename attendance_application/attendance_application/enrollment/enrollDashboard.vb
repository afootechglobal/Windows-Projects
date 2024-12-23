Public Class enrollDashboard

    Private Sub enrollDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        activeBtn()
        switchFormPage(dashboardFormPage)
        dashboardBtn.Checked = True
    End Sub
    Private Sub dashboardBtn_Click_1(sender As System.Object, e As System.EventArgs) Handles dashboardBtn.Click
        activeBtn()
        dashboardBtn.Checked = True
        switchFormPage(dashboardFormPage)
    End Sub
    Private Sub Guna2Button1_Click(sender As System.Object, e As System.EventArgs) Handles enrollBtn.Click
        activeBtn()
        enrollBtn.Checked = True
        switchFormPage(enrollmentFormPage)
    End Sub
    Private Sub Guna2Button2_Click(sender As System.Object, e As System.EventArgs) Handles enrollListBtn.Click
        activeBtn()
        enrollListBtn.Checked = True
    End Sub


End Class