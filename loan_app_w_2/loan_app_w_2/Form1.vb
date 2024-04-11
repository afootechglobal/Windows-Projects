Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 275
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim interest, b, principal, total_repayment, total As Double
        Dim amount, month As Double
        Dim total_interest As Double


        If loanamount_txt.Text = "" Then
            MessageBox.Show("Loan Amount Can't be Empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf duration_txt.Text = "" Then
            MessageBox.Show("Duration Can't be Empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf loanamount_txt.Text = "0" Then
            MessageBox.Show("Loan Amount Can't be 0!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf duration_txt.Text = "0" Then
            MessageBox.Show("Duration Can't be 0!")
        Else
            ListBox1.Items.Clear()
            ListBox1.Items.Add("MONTH           " & "AMOUNT " & "              " & "INTEREST" & "               " & "MONTHLY REPAYMENT")

            amount = loanamount_txt.Text
            month = duration_txt.Text
            principal = amount / month
            For b = 1 To month
                interest = (1.5 / 100) * amount
                total = principal + interest
                amount = amount - principal
                total_repayment = total_repayment + total

                ListBox1.Items.Add(b & "                    " & (principal.ToString("N2")) & "              " & (interest.ToString("N2")) & "                " & (total.ToString("N2")))
            Next
            Me.Height = 563
            total_interest = total_repayment - loanamount_txt.Text
            Total_interest_txt.Text = (total_interest.ToString("N2"))
            Total_repayment_txt.Text = (total_repayment.ToString("N2"))



        End If


    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Height = 275
        Total_repayment_txt.Text = ""
        Total_interest_txt.Text = ""
        loanamount_txt.Text = ""
        duration_txt.Text = ""
        ListBox1.Items.Clear()
    End Sub

    Private Sub loanamount_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles loanamount_txt.KeyPress, duration_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("This field allows only Numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot Only Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("This field Required Users to Input a Number or Numbers before a Dot!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

End Class
