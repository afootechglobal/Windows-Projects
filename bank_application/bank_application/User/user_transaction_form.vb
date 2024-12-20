Public Class user_transaction_form

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Close()
        user_deposit_form.Show()
    End Sub

    Private Sub user_transaction_form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim customer_id = userlogin_form.login_customer_id
        myfunctions.customerDepositTransaction(customer_id, userRecord)
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub
End Class