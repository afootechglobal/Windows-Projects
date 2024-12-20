Public Class transaction_form

    Private Sub transaction_form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim customer_id = deposit_form.profile_id.SelectedValue
        myfunctions.customerDepositTransaction(customer_id, userRecord)
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Close()
        deposit_form.Show()
    End Sub


End Class