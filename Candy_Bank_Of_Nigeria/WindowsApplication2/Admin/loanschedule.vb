Public Class loanschedule

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Me.Close()
        viewloan.Show()
    End Sub

    Private Sub loanschedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim customer_id = viewloan.profile_id.SelectedValue
        functions.customerLoanSchedule(customer_id, loan_schedule_record_list)
    End Sub
End Class