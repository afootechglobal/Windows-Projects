Public Class admin_dashboard

    Private Sub admin_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub admin_dashboard_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        login.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelDateTime.Text = "Time " & TimeOfDay & " Date " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

    Private Sub EnrollmentBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollmentBtn.Click
        EnrollmentBtn.BackColor = Color.FromArgb(164, 207, 223)
        VerificationBtn.BackColor = Color.Transparent
        AdminBtn.BackColor = Color.Transparent
        SettingsBtn.BackColor = Color.Transparent
        LogoutBtn.BackColor = Color.Transparent

        Dim formodal As New Form
        Try
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal

            Enrollment.ShowDialog()
        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub


    Private Sub VerificationBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificationBtn.Click
        EnrollmentBtn.BackColor = Color.Transparent
        VerificationBtn.BackColor = Color.FromArgb(164, 207, 223)
        AdminBtn.BackColor = Color.Transparent
        SettingsBtn.BackColor = Color.Transparent
        LogoutBtn.BackColor = Color.Transparent

        Dim formodal As New Form
        Try
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal

            verification.ShowDialog()
        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub


    Private Sub AdminBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminBtn.Click
        EnrollmentBtn.BackColor = Color.Transparent
        VerificationBtn.BackColor = Color.Transparent
        AdminBtn.BackColor = Color.FromArgb(164, 207, 223)
        SettingsBtn.BackColor = Color.Transparent
        LogoutBtn.BackColor = Color.Transparent

        ContextMenuStrip1.Show(AdminBtn, New Point(0, AdminBtn.Height))
    End Sub

    Private Sub RegisterNewStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterNewStaffToolStripMenuItem.Click
        Dim formodal As New Form
        Try
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal

            AdminReg.ShowDialog()
        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    Private Sub ViewEditUsersRcordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEditUsersRcordToolStripMenuItem.Click
        Me.Hide()
        UserRecord.Show()
    End Sub

    Private Sub SettingsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsBtn.Click
        EnrollmentBtn.BackColor = Color.Transparent
        VerificationBtn.BackColor = Color.Transparent
        AdminBtn.BackColor = Color.Transparent
        SettingsBtn.BackColor = Color.FromArgb(164, 207, 223)
        LogoutBtn.BackColor = Color.Transparent

        ContextMenuStrip2.Show(SettingsBtn, New Point(0, SettingsBtn.Height))
    End Sub

    Private Sub LogoutBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click
        EnrollmentBtn.BackColor = Color.Transparent
        VerificationBtn.BackColor = Color.Transparent
        AdminBtn.BackColor = Color.Transparent
        LogoutBtn.BackColor = Color.Transparent
        SettingsBtn.BackColor = Color.Transparent

        Dim formodal As New Form
        Try
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal

            QuestionForm.ShowDialog()
        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    Private Sub ChangeYourPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeYourPasswordToolStripMenuItem.Click
        Dim formodal As New Form
        Try
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal

            ChangePassForm.ShowDialog()
        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

 
End Class