Imports MySql.Data.MySqlClient
Public Class deposit_form
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub deposit_form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myfunctions.getCustomerID()
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        overlay.Close()
        Me.Close()
    End Sub

    Private Sub transBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transBtn.Click
        Me.Hide()
        transaction_form.Show()
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        deposit_txt.Text = ""
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        If profile_id.Text = "SELECT CUSTOMER" Then
            MessageBox.Show("ERROR! Select customer to continue!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf deposit_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are required", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim deposit As Double = Convert.ToDouble(deposit_txt.Text).ToString
            Dim customer_id = profile_id.SelectedValue
            myfunctions.deposit(deposit, customer_id, 1)
        End If
    End Sub
End Class