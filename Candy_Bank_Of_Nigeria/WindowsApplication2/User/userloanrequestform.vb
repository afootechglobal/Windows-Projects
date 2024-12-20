Imports MySql.Data.MySqlClient
Public Class userloanrequestform
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
        userportal.Show()
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click

        Dim connection = functions.connection
        If loanAmount_txt.Text = "" Or loan_duration.Text = "" Then
            MessageBox.Show("ERROR! All fields are required", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result = functions.system_settings
            Dim minimum_balance = Double.Parse(result.item1)
            Dim maximum_loan = Double.Parse(result.item2)
            Dim minimum_loan = Double.Parse(result.item3)
            Dim maximum_duration = Double.Parse(result.item4)
            Dim loan_rate = Double.Parse(result.item5)

            result = functions.getCustomerProfile(userlogin.login_customer_id)
            Dim account_balance = Double.Parse(result.item3)
            Dim loan_balance = Double.Parse(result.item4)

            Dim loanamount = Double.Parse(loanAmount_txt.Text)
            Dim duration = Double.Parse(loan_duration.Text)

            If loan_balance > 1 Then
                MessageBox.Show("ERROR! You're not eligible to request for this loan, you have " & loan_balance.ToString("N2") & " " & "loan_balance left, " & "Kindly pay to request for another!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf account_balance < minimum_balance Then
                MessageBox.Show("ERROR! You're not eligible to request for this loan due to low balance. " & "Minimum of " & minimum_balance.ToString("N2") & " " & "required to get this loan!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf loanamount > maximum_loan Then
                MessageBox.Show("ERROR! Maximum of " & maximum_loan.ToString("N2") & " " & "is required", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf loanamount < minimum_loan Then
                MessageBox.Show("ERROR! Minmum of " & minimum_loan.ToString("N2") & " " & "is required", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf duration > maximum_duration Then
                MessageBox.Show("ERROR! Maximum of " & maximum_duration & " " & "months " & "is required", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Dim transaction_id = "TRANS" & Now.ToString("yyyyMMddss") & functions.countId("TRANS")

                connection.open()
                query = "INSERT INTO `customer_loan_transaction_tab`(`customer_id`, `transaction_id`, `loan_amount`, `loan_duration`, `loan_rate`, `created_time`) VALUES(@customer_id, @transaction_id, @loan_amount, @loan_duration, @loan_rate, NOW())"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@customer_id", userlogin.login_customer_id)
                command.Parameters.AddWithValue("@transaction_id", transaction_id)
                command.Parameters.AddWithValue("@loan_amount", loanamount)
                command.Parameters.AddWithValue("@loan_duration", duration)
                command.Parameters.AddWithValue("@loan_rate", loan_rate)
                reader = command.ExecuteReader
                connection.Close()

                connection.open()
                query = "UPDATE account_tab SET loan_balance=@loan_balance WHERE customer_id=@customer_id"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@loan_balance", loanamount)
                command.Parameters.AddWithValue("@customer_id", userlogin.login_customer_id)
                reader = command.ExecuteReader
                connection.Close()

                Dim monthly_balance, interest, total_repayment As Double
                Dim subpayment As Double = loanamount / duration
                For month As Integer = 1 To duration
                    interest = (loan_rate / 100) * loanamount
                    total_repayment = subpayment + interest
                    loanamount = loanamount - subpayment
                    monthly_balance = loanamount + subpayment

                    connection.open()
                    query = "INSERT INTO `loan_request_tab`(`transaction_id`, `month`, `loan_balance`, `sub_payment`, `interest`, `total_repayment`, `created_time`) VALUES(@transaction_id, @month, @loan_balance, @sub_payment, @interest, @total_repayment, NOW())"
                    command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@transaction_id", transaction_id)
                    command.Parameters.AddWithValue("@month", month)
                    command.Parameters.AddWithValue("@loan_balance", monthly_balance)
                    command.Parameters.AddWithValue("@sub_payment", subpayment)
                    command.Parameters.AddWithValue("@interest", interest)
                    command.Parameters.AddWithValue("@total_repayment", total_repayment)
                    reader = command.ExecuteReader
                    connection.Close()
                Next
                MessageBox.Show("SUCCESS! Loan Application Successfully Saved", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                functions.loanClearFunction()
                Dim updatedCounts = functions.allCounts()
                adminportal.total_loan_label.Text = "₦" & updatedCounts.Item5.ToString
                userportal.loan_balance_label.Text = "NGN" & updatedCounts.Item3.ToString
            End If
        End If
    End Sub

End Class