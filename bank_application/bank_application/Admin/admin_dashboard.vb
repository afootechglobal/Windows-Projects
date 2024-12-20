Imports MySql.Data.MySqlClient
Imports System.IO

Public Class admin_dashboard

    Private Sub admin_dashboard_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        index_form.Show()
    End Sub

    Private Sub admin_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Guna2Panel2.FillColor = Color.FromArgb(230, 255, 255, 255)
        Guna2Panel1.FillColor = Color.FromArgb(230, 255, 255, 255)
        Guna2Panel3.FillColor = Color.FromArgb(230, 255, 255, 255)

        Dim result = myfunctions.getStaffProfile(adminlogin_form.login_staff_id)
        Dim arrimage() As Byte = result.item3
        staff_fullname_label.Text = result.item1.ToString
        last_login_label.Text = "Last Login Date:" & " " & result.item2.ToString
        Dim mstream = New MemoryStream(arrimage)
        passport.Image = Image.FromStream(mstream)

        Dim allCounts = myfunctions.allCounts()
        total_admin_label.Text = allCounts.item1.ToString
        total_customer_label.Text = allCounts.item2.ToString
        total_loan_label.Text = allCounts.item3.ToString
        total_balance_label.Text = allCounts.item4.ToString

        If adminlogin_form.login_role_id <= 1 Then
            view_admin_btn.Hide()
            view_customer_btn.Location = New Point(0, 62)
            view_loan_btn.Location = New Point(0, 124)
            deposit_btn.Location = New Point(0, 186)
            settings_btn.Location = New Point(0, 248)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time_label.Text = TimeOfDay
        date_label.Text = Today.ToString("dddd, MMMM dd, yyyy")
    End Sub

    Private Sub view_admin_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_admin_btn.Click
        overlay.Show()
        admin_form.Show()
    End Sub

    Private Sub view_customer_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_customer_btn.Click
        overlay.Show()
        view_customer_form.Show()
    End Sub

    Private Sub view_loan_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_loan_btn.Click
        overlay.Show()
        view_loan_form.Show()
    End Sub

    Private Sub deposit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deposit_btn.Click
        overlay.Show()
        deposit_form.Show()
    End Sub

    Private Sub settings_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings_btn.Click
        overlay.Show()
        settlings_form.Show()
    End Sub

    Private Sub logoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logoutBtn.Click
        Dim closeValidation = MessageBox.Show("Are you sure you want to Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeValidation = vbYes Then
            Me.Close()
            index_form.Show()
            adminlogin_form.Show()
            overlay.Show()
        End If
    End Sub
End Class