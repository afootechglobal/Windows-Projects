Public Class dashboardFormPage
    Private Sub Guna2Button1_Click(sender As System.Object, e As System.EventArgs) Handles Guna2Button1.Click
        activeBtn()
        enrollDashboard.enrollBtn.Checked = True
        getPageForm(enrollmentFormPage)
    End Sub
End Class