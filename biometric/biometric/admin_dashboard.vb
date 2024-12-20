Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Public Class admin_dashboard
    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim staff_id As String
    Dim count As Integer

    Private Sub admin_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For counter = 0 To 30 Step 10
            count = counter
            Me.Opacity = count / 30
            Me.Refresh()
            Threading.Thread.Sleep(30)

            StaffProfilePic()
            Role()
            Restriction()
        Next counter
    End Sub

    Private Sub admin_dashboard_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        login.Close()
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
        AttendanceBtn.BackColor = Color.Transparent

        MyFuctions.UserEnrollment()
    End Sub

    Private Sub VerificationBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificationBtn.Click
        EnrollmentBtn.BackColor = Color.Transparent
        VerificationBtn.BackColor = Color.FromArgb(164, 207, 223)
        AdminBtn.BackColor = Color.Transparent
        SettingsBtn.BackColor = Color.Transparent
        LogoutBtn.BackColor = Color.Transparent
        AttendanceBtn.BackColor = Color.Transparent

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
        AttendanceBtn.BackColor = Color.Transparent
        SettingsBtn.BackColor = Color.Transparent
        LogoutBtn.BackColor = Color.Transparent

        ContextMenuStrip1.Show(AdminBtn, New Point(0, AdminBtn.Height))
    End Sub

    Private Sub AttendanceBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendanceBtn.Click
        EnrollmentBtn.BackColor = Color.Transparent
        VerificationBtn.BackColor = Color.Transparent
        AdminBtn.BackColor = Color.Transparent
        SettingsBtn.BackColor = Color.Transparent
        LogoutBtn.BackColor = Color.Transparent
        AttendanceBtn.BackColor = Color.FromArgb(164, 207, 223)

        ContextMenuStrip3.Show(AttendanceBtn, New Point(0, AttendanceBtn.Height))
    End Sub

    Public Sub RegisterNewStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterNewStaffToolStripMenuItem.Click
        MyFuctions.AdminRegistration()
    End Sub

    Private Sub ViewEditUsersRcordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEditUsersRcordToolStripMenuItem.Click
        Dim formodal As New Form
        Dim modal As New Enrollment
        formodal.FormBorderStyle = FormBorderStyle.None
        formodal.Opacity = 0.5
        formodal.BackColor = Color.Black
        formodal.WindowState = FormWindowState.Maximized
        formodal.Show()
        modal.Owner = formodal
        UserRecord.ShowDialog()
        formodal.Dispose()
    End Sub

    Private Sub SettingsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsBtn.Click
        EnrollmentBtn.BackColor = Color.Transparent
        VerificationBtn.BackColor = Color.Transparent
        AdminBtn.BackColor = Color.Transparent
        SettingsBtn.BackColor = Color.FromArgb(164, 207, 223)
        LogoutBtn.BackColor = Color.Transparent
        AttendanceBtn.BackColor = Color.Transparent

        ContextMenuStrip2.Show(SettingsBtn, New Point(0, SettingsBtn.Height))
    End Sub

    Private Sub LogoutBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click
        EnrollmentBtn.BackColor = Color.Transparent
        VerificationBtn.BackColor = Color.Transparent
        AdminBtn.BackColor = Color.Transparent
        LogoutBtn.BackColor = Color.Transparent
        SettingsBtn.BackColor = Color.Transparent
        AttendanceBtn.BackColor = Color.Transparent

        Dim formodal As New Form
        Try
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal

            LogoutForm.ShowDialog()
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

    Private Sub StaffProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffProfile.Click
        Dim formodal As New Form
        Try
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal

            StaffRecord.ShowDialog()
        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    'Inner Function Start Here....

    Public Function StaffProfilePic()
        Try
            Dim email As String
            email = login.email_txt.Text
            connection = MyFuctions.GetSqlConnection
            query = "SELECT passport FROM staff_tab WHERE email_address=@email_address"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email_address", email)
            reader = command.ExecuteReader
            reader.Read()
            arrimage = reader("passport")

            mstream = New MemoryStream(arrimage)
            StaffProfile.Image = Image.FromStream(mstream)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        connection.Close()
    End Function

    Public Function Role()
        Try
            Dim email As String
            email = login.email_txt.Text
            connection = MyFuctions.GetSqlConnection
            query = "SELECT a.role_name, b.fullname FROM setup_role_tab a, staff_tab b WHERE email_address=@email_address AND b.role_id=a.role_id AND a.role_id=b.role_id;"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email_address", email)
            reader = command.ExecuteReader
            reader.Read()
            Role_label.Text = reader("role_name") & " / " & reader("fullname")
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        connection.Close()
    End Function

    Public Function Restriction()
        Try
            Dim email As String
            email = login.email_txt.Text

            connection = MyFuctions.GetSqlConnection
            query = "SELECT role_id FROM staff_tab WHERE email_address=@email_address;"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email_address", email)
            reader = command.ExecuteReader

            If reader.HasRows Then
                reader.Read()
                Dim roleId As Integer = Convert.ToInt32(reader("role_id"))
                connection.Close()
                connection = MyFuctions.GetSqlConnection
                If roleId = 3 Then
                    AdminBtn.Hide()
                    SettingsBtn.Location = New Point(290, 0)
                    AttendanceBtn.Location = New Point(195, 0)
                    LogoutBtn.Location = New Point(384, 0)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Function

    Public Function AllBtnTransparent()
        EnrollmentBtn.BackColor = Color.Transparent
        VerificationBtn.BackColor = Color.Transparent
        AdminBtn.BackColor = Color.Transparent
        SettingsBtn.BackColor = Color.Transparent
        LogoutBtn.BackColor = Color.Transparent
    End Function

    Private Sub ClockinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClockinToolStripMenuItem.Click
        Clokin.Show()
    End Sub

    Private Sub AttendanceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendanceReportToolStripMenuItem.Click
        AttendanceReport.Show()
    End Sub

   
End Class