Imports MySql.Data.MySqlClient
Public Class userlogin
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public login_customer_id, login_status_id As String

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
                command = New MySqlCommand("SELECT * FROM customer_tab WHERE email_address=@email_address AND password=@password", connection)
                command.Parameters.AddWithValue("@email_address", email_address_txt.Text)
                command.Parameters.AddWithValue("@password", password_txt.Text)
                reader = command.ExecuteReader
                reader.Read()

                If reader.HasRows Then
                    login_customer_id = reader("customer_id")
                    login_status_id = reader("status_id")
                    connection.close()

                    If login_status_id = 1 Then
                        connection.open()
                        command = New MySqlCommand("UPDATE customer_tab SET last_login=NOW() WHERE customer_id=@customer_id", connection)
                        command.Parameters.AddWithValue("@customer_id", login_customer_id)
                        reader = command.ExecuteReader
                        connection.close()

                        MessageBox.Show("WELCOME! Login Successfull!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        functions.goToUserPortal()
                    Else
                        MessageBox.Show("ERROR! Account has been Suspended", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("ERROR! Invalid login parameters!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        'Me.Close()
        'userportal.Show()
    End Sub

    Private Sub forgot_password_label_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles forgot_password_label.LinkClicked
        Me.Close()
        overlay.Show()
        userresetpassword.Show()
    End Sub

    Private Sub userlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class