Public Class userviewtransaction

    Private Sub userviewtransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim customer_id = userlogin.login_customer_id
        functions.customerDepositTransaction(customer_id, customer_record_list)
        Dim result = functions.allCounts
        total_customer_count_label_txt.Text = allCounts.item6.ToString
    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Me.Close()
        depositform.Show()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub
End Class