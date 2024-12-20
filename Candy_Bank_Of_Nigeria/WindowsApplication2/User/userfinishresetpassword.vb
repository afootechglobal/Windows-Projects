Imports MySql.Data.MySqlClient
Public Class userfinishresetpassword
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand


    Private Sub userfinishresetpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        passLabel.Text = "Dear" & " " & userresetpassword.full_name & "," & " " & "an OTP has been sent to your registered Email Address" & Environment.NewLine & "(" & userresetpassword.email_address & ")"
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
        main.Show()
    End Sub

    Private Sub proceed_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceed_btn.Click

        If otp_txt.Text = "" Or new_pass_txt.Text = "" Or confirm_pass_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are Required", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If new_pass_txt.Text = confirm_pass_txt.Text Then
                Try
                    Dim connection = functions.connection

                    connection.Open()
                    command = New MySqlCommand("SELECT otp FROM customer_tab WHERE otp=@otp AND customer_id=@customer_id", connection)
                    command.Parameters.AddWithValue("@customer_id", userresetpassword.customer_id)
                    command.Parameters.AddWithValue("@otp", otp_txt.Text)
                    reader = command.ExecuteReader

                    If reader.HasRows Then
                        connection.close()
                        connection.open()
                        command = New MySqlCommand("UPDATE customer_tab SET password=@password WHERE customer_id=@customer_id", connection)
                        command.Parameters.AddWithValue("@customer_id", userresetpassword.customer_id)
                        command.Parameters.AddWithValue("@password", new_pass_txt.Text)
                        reader = command.ExecuteReader
                        connection.Close()
                        MessageBox.Show("SUCCESS! Password  updated successfully", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        overlay.Close()
                        userlogin.Show()
                    Else
                        MessageBox.Show("ERROR! OTP not valid", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MessageBox.Show("ERROR! New password and confirm password don't match", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class