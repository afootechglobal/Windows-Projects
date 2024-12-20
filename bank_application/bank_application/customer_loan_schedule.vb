Public Class customer_loan_schedule

    Private Sub customer_loan_schedule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim customer_id = userlogin_form.login_customer_id
        myfunctions.customerLoanSchedule(customer_id, loanScheduleRecord)
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub
End Class