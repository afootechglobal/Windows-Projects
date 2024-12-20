Imports MySql.Data.MySqlClient
Public Class depositform
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub depositform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.getCustomerID()
    End Sub
    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub trans_history_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trans_history_btn.Click
        Me.Hide()
        overlay.Show()
        transactionhistory.Show()
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        deposit_txt.Text = Nothing
        profile_id.Text = "SELECT CUSTOMER....."
    End Sub

    Private Sub deposit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deposit_btn.Click
        If profile_id.Text = "SELECT CUSTOMER....." Then
            MessageBox.Show("ERROR! Select customer to continue!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf deposit_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are required", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim deposits As Double = Convert.ToDouble(deposit_txt.Text).ToString
            Dim customer_id = profile_id.SelectedValue
            functions.deposit(deposits, customer_id, 1)
            Dim updatedCounts = functions.allCounts()
            adminportal.total_balance_label.Text = "₦" & updatedCounts.Item4.ToString
            userportal.acct_balance_label.Text = "NGN" & updatedCounts.Item4.ToString
           


        End If
    End Sub

    Private Sub deposit_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles deposit_txt.KeyPress
        functions.numTextCheck(e)
    End Sub
End Class