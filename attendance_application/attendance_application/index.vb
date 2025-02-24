Imports MySql.Data.MySqlClient
Public Class index
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public login_staff_id, login_firstname, login_last_login_time, login_department_id, login_department_name, login_role_id, login_role_name, login_status_id, login_status_name As String
    Private Sub index_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        MyFunction.progressIndicatorHide(loginProgressIndicator, loginProgressBar)

        Me.Opacity = 0 ' Start with fully transparent
        startFadeIn(Me) ' Trigger fade-in effect, passing the current form

        Dim connection = MyFunction.connection
        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MsgBox("Connection successful.")
            End If
        Catch ex As MySqlException
            MsgBox("Connection failed: " & ex.Message)
            Me.Close()
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub Guna2Button1_Click(sender As System.Object, e As System.EventArgs) Handles loginBtn.Click
        If email_txt.Text = "" Or password_txt.Text = "" Then
            email_txt.BorderColor = Color.Red
            password_txt.BorderColor = Color.Red
            MessageBox.Show("ERROR! All fields are required!", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MyFunction.emailValidate(email_txt.Text) = False Then
            email_txt.BorderColor = Color.Red
            MessageBox.Show("Invalid Email Address try again", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            'loginTimerLoader.Start()
            loginBtn.Enabled = False
            loginBtn.Text = "Authenticating..."

            email_txt.BorderColor = Color.Gray
            password_txt.BorderColor = Color.Gray

            Dim connection = MyFunction.connection
            Try
                connection.Open()
                command = New MySqlCommand("SELECT a.*, b.status_name, c.role_name, d.department_name FROM staff_tab a, setup_status_tab b, setup_role_tab c, department_tab d WHERE a.status_id=b.status_id AND a.role_id=c.role_id AND a.department_id=d.department_id AND a.email=@email AND a.password=@password", connection)
                command.Parameters.AddWithValue("@email", email_txt.Text)
                command.Parameters.AddWithValue("@password", MyFunction.hashCodePassword(password_txt.Text))
                reader = command.ExecuteReader
                reader.Read()

                If reader.HasRows Then
                    login_staff_id = reader("staff_id")
                    login_firstname = reader("firstname")
                    'login_lastname = reader("lastname")
                    login_last_login_time = reader("last_login_time")
                    login_status_id = reader("status_id")
                    login_status_name = reader("status_name")
                    login_role_id = reader("role_id")
                    login_role_name = reader("role_name")
                    login_department_id = reader("department_id")
                    login_department_name = reader("department_name")
                    Dim profile_pix_url As String = reader("profile_pix_url").ToString()
                    Dim profile_pix As String = reader("profile_pix").ToString()
                    Dim imagePath As String = profile_pix_url & "/" & profile_pix
                    MyFunction.getPassportPix(imagePath, enrollDashboard.profilePixBox)
                    connection.close()

                    If login_status_id = 1 Then
                        connection.open()
                        command = New MySqlCommand("UPDATE staff_tab SET last_login_time=NOW() WHERE staff_id=@staff_id", connection)
                        command.Parameters.AddWithValue("@staff_id", login_staff_id)
                        reader = command.ExecuteReader
                        connection.close()

                        MyFunction.directToDashboard()
                    Else
                        MessageBox.Show("ERROR! Account has been Suspended", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        loginBtn.Enabled = True
                        loginBtn.Text = "Log In"
                    End If
                Else
                    MessageBox.Show("ERROR! Invalid login parameters!", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    loginBtn.Enabled = True
                    loginBtn.Text = "Log In"
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR! An error occured please try again.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
                loginBtn.Enabled = True
                loginBtn.Text = "Log In"
            End Try
        End If

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles loginTimerLoader.Tick
        MyFunction.loginProgressIndicatorShow(loginProgressBar, loginProgressIndicator, loginTimerLoader)
    End Sub

    Private Sub loginProgressIndicator_Click(sender As System.Object, e As System.EventArgs) Handles loginProgressIndicator.Click

    End Sub
End Class