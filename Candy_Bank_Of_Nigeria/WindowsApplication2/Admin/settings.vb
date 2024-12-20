Imports MySql.Data.MySqlClient
Public Class settings
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim result = functions.system_settings

        minimum_balance_txt.Text = Convert.ToDouble(result.item1).ToString
        maximum_loan_txt.Text = Convert.ToDouble(result.item2).ToString
        minimum_loan_txt.Text = Convert.ToDouble(result.item3).ToString
        maximum_duration_txt.Text = Convert.ToDouble(result.item4).ToString
        loan_rate_txt.Text = Convert.ToDouble(result.item5).ToString
    End Sub

    Private Sub update_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_btn.Click

        If minimum_balance_txt.Text = "" Or maximum_loan_txt.Text = "" Or minimum_loan_txt.Text = "" Or maximum_duration_txt.Text = "" Or loan_rate_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are required", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf minimum_balance_txt.Text < 1 Or maximum_loan_txt.Text < 1 Or minimum_loan_txt.Text < 1 Or maximum_duration_txt.Text < 1 Or loan_rate_txt.Text < 1 Then
            MessageBox.Show("ERROR! Invalid input, input can't be less than 1", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim connection = functions.connection

            connection.Open()
            command = New MySqlCommand("UPDATE system_settings_tab SET minimum_balance=@minimum_balance, maximum_loan=@maximum_loan, minimum_loan=@minimum_loan, maximum_duration=@maximum_duration, loan_rate=@loan_rate", connection)
            command.Parameters.AddWithValue("@minimum_balance", Convert.ToDouble(minimum_balance_txt.Text).ToString)
            command.Parameters.AddWithValue("@maximum_loan", Convert.ToDouble(maximum_loan_txt.Text).ToString)
            command.Parameters.AddWithValue("@minimum_loan", Convert.ToDouble(minimum_loan_txt.Text).ToString)
            command.Parameters.AddWithValue("@maximum_duration", Convert.ToDouble(maximum_duration_txt.Text).ToString)
            command.Parameters.AddWithValue("@loan_rate", Convert.ToDouble(loan_rate_txt.Text).ToString)
            reader = command.ExecuteReader
            connection.Close()
            MessageBox.Show("SUCCESS! System Settings Successfully updated", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            overlay.Close()
            adminportal.Show()
        End If
    End Sub

    Private Sub minimun_balance_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles minimum_balance_txt.KeyPress
        functions.numTextCheck(e)
    End Sub

    Private Sub maximum_loan_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles maximum_loan_txt.KeyPress
        functions.numTextCheck(e)
    End Sub

    Private Sub minimum_loan_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles minimum_loan_txt.KeyPress
        functions.numTextCheck(e)
    End Sub

    Private Sub loan_rate_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles loan_rate_txt.KeyPress
        functions.numTextCheck(e)
    End Sub

    Private Sub maximum_duration_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles maximum_duration_txt.KeyPress
        functions.numCheck(e)
    End Sub
End Class