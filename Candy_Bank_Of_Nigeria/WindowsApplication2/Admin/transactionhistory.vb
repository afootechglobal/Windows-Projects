Public Class transactionhistory

    Private Sub transactionhistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim customer_id = depositform.profile_id.SelectedValue
        functions.customerDepositTransaction(customer_id, user_record_history)
        Dim result = functions.allCounts
        total_trans_count_label_txt.Text = allCounts.item6.ToString

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Me.Close()
        depositform.Show()
    End Sub
End Class