Public Class enrollListView

    Private Sub Guna2Button2_Click(sender As System.Object, e As System.EventArgs) Handles closeEnrollBtn.Click
        closeForm(Me)
    End Sub

    Private Sub Guna2Button1_Click(sender As System.Object, e As System.EventArgs) Handles viewEnrollListbtn.Click
        activeBtn()
        enrollDashboard.enrollListBtn.Checked = True
        getPageForm(enrollListFormPage)
        closeForm(Me)
    End Sub
End Class