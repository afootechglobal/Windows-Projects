Public Class loan_schedule_form

    Private Sub loan_schedule_form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim customer_id = view_loan_form.profile_id.SelectedValue
        myfunctions.customerLoanSchedule(customer_id, loanScheduleRecord)
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Close()
        view_loan_form.Show()
    End Sub

End Class