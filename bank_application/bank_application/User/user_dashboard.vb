Imports MySql.Data.MySqlClient
Imports System.IO
Public Class user_dashboard

    Private Sub user_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim result = myfunctions.getCustomerProfile(userlogin_form.login_customer_id)
        Dim arrimage() As Byte = result.item5
        user_fullname_label.Text = result.item1.ToString
        last_login_label.Text = "Last Login Date:" & " " & result.item2.ToString
        acct_bal_txt.Text = "NGN" & " " & result.item3.ToString
        loan_bal_txt.Text = "NGN" & " " & result.item4.ToString
        Dim mstream = New MemoryStream(arrimage)
        passport.Image = Image.FromStream(mstream)
    End Sub

    Private Sub user_dashboard_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        index_form.Show()
    End Sub

    Private Sub requestForLoanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles requestForLoanBtn.Click
        overlay.Show()
        loan_request_form.Show()
    End Sub

    Private Sub loginUserBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginUserBtn.Click
        Dim closeValidation = MessageBox.Show("Are you sure you want to Logout?", "Logout Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeValidation = vbYes Then
            Me.Close()
            index_form.Show()
            userlogin_form.Show()
            overlay.Show()
        End If
    End Sub

    Private Sub deposit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deposit_btn.Click
        user_deposit_form.Show()
        overlay.Show()
    End Sub

    Private Sub loanHistoryBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loanHistoryBtn.Click
        customer_loan_schedule.Show()
        overlay.Show()
    End Sub

    Private Sub changePassBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changePassBtn.Click
        change_pass_form.Show()
        overlay.Show()
    End Sub

End Class