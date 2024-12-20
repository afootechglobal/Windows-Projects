Imports MySql.Data.MySqlClient
Public Class adminlogin
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    ' Login-related fields
    Public login_staff_id As String ' Staff ID of the logged-in user
    Public login_role_id As String  ' Role ID of the logged-in user
    Public login_status_id As String ' Status ID of the logged-in user

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
        main.Show()
    End Sub

    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click

        If email_address_txt.Text = "" Or password_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are required!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf functions.validateEmail(email_address_txt.Text) = False Then
            MessageBox.Show("Invalid Email Address", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim connection = functions.connection

            Try
                connection.Open()
                command = New MySqlCommand("SELECT * FROM staff_tab WHERE email_address=@email_address AND password=@password", connection)
                command.Parameters.AddWithValue("@email_address", email_address_txt.Text)
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
                        command = New MySqlCommand("UPDATE staff_tab SET last_login = NOW() WHERE staff_id=@staff_id", connection)
                        command.Parameters.AddWithValue("@staff_id", login_staff_id)
                        reader = command.ExecuteReader
                        connection.close()

                        MessageBox.Show("WELCOME! Login Successfull!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        functions.goToAdminPortal()


                    Else
                        MessageBox.Show("ERROR! Account has been Suspended", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("ERROR! Invalid login Details!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub forgot_password_label_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles forgot_password_label.LinkClicked
        Me.Hide()
        overlay.Show()
        adminresetpassword.Show()
    End Sub

    Private Sub adminlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class