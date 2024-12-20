Imports MySql.Data.MySqlClient
Public Class settlings_form
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub settlings_form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result = myfunctions.system_settings
        minimum_balance_txt.Text = Convert.ToDouble(result.item1).ToString("N2")
        maximum_loan_txt.Text = Convert.ToDouble(result.item2).ToString("N2")
        minimum_loan_txt.Text = Convert.ToDouble(result.item3).ToString("N2")
        maximum_duration_txt.Text = Convert.ToDouble(result.item4).ToString()
        loan_rate_txt.Text = Convert.ToDouble(result.item5).ToString()
    End Sub

    Private Sub updateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateButton.Click
        If minimum_balance_txt.Text = "" Or maximum_loan_txt.Text = "" Or minimum_loan_txt.Text = "" Or maximum_duration_txt.Text = "" Or loan_rate_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are required", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf minimum_balance_txt.Text < 1 Or maximum_loan_txt.Text < 1 Or minimum_loan_txt.Text < 1 Or maximum_duration_txt.Text < 1 Or loan_rate_txt.Text < 1 Then
            MessageBox.Show("ERROR! Invalid inputs, input can't be less than 1", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim connection = myfunctions.connection

            connection.Open()
            command = New MySqlCommand("UPDATE system_settings_tab SET minimum_balance=@minimum_balance, maximum_loan=@maximum_loan, minimum_loan=@minimum_loan, maximum_duration=@maximum_duration, loan_rate=@loan_rate", connection)
            command.Parameters.AddWithValue("@minimum_balance", Convert.ToDouble(minimum_balance_txt.Text).ToString)
            command.Parameters.AddWithValue("@maximum_loan", Convert.ToDouble(maximum_loan_txt.Text).ToString)
            command.Parameters.AddWithValue("@minimum_loan", Convert.ToDouble(minimum_loan_txt.Text).ToString)
            command.Parameters.AddWithValue("@maximum_duration", Convert.ToDouble(maximum_duration_txt.Text).ToString)
            command.Parameters.AddWithValue("@loan_rate", Convert.ToDouble(loan_rate_txt.Text).ToString)
            reader = command.ExecuteReader
            connection.Close()
            MessageBox.Show("SUCCESS! Settings Successfully updated", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub minimum_balance_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles minimum_loan_txt.KeyPress, minimum_balance_txt.KeyPress, maximum_loan_txt.KeyPress, maximum_duration_txt.KeyPress, loan_rate_txt.KeyPress
        'myfunctions.numCheck(e)
    End Sub
End Class