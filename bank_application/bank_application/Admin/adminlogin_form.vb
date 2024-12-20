Imports MySql.Data.MySqlClient
Public Class adminlogin_form
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public login_staff_id, login_role_id, login_status_id As String

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub loginUserBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginUserBtn.Click
        If email_txt.Text = "" Or password_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are required!", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf myfunctions.emailValidate(email_txt.Text) = False Then
            MessageBox.Show("Invalid Email Address", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim connection = myfunctions.connection

            Try
                connection.Open()
                command = New MySqlCommand("SELECT * FROM staff_tab WHERE email=@email AND password=@password", connection)
                command.Parameters.AddWithValue("@email", email_txt.Text)
                command.Parameters.AddWithValue("@password", password_txt.Text)
                reader = command.ExecuteReader
                reader.Read()

                If reader.HasRows Then
                    login_staff_id = reader("staff_id")
                    login_status_id = reader("status_id")
                    login_role_id = reader("role_id")
                    connection.close()

                    If login_status_id = 1 Then
                        connection.open()
                        command = New MySqlCommand("UPDATE staff_tab SET last_login=NOW() WHERE staff_id=@staff_id", connection)
                        command.Parameters.AddWithValue("@staff_id", login_staff_id)
                        reader = command.ExecuteReader
                        connection.close()
                        myfunctions.directToDashboard()
                    Else
                        MessageBox.Show("ERROR! Account has been Suspended", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("ERROR! Invalid login parameters!", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub ForgotPass_Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForgotPass_Label.Click
        Me.Hide()
        admin_reset_pass_form.Show()
    End Sub
End Class