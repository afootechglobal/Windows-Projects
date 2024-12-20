Public Class user_deposit_form

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        If deposit_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are required", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim deposit As Double = Convert.ToDouble(deposit_txt.Text).ToString
            Dim customer_id = userlogin_form.login_customer_id
            myfunctions.deposit(deposit, customer_id, 2)
        End If
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        deposit_txt.Text = ""
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub transBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transBtn.Click
        Me.Hide()
        user_transaction_form.Show()
    End Sub
End Class