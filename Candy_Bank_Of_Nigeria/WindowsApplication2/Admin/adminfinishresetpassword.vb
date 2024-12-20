Imports MySql.Data.MySqlClient
Public Class adminfinishresetpassword
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
        main.Show()
    End Sub

    Private Sub proceed_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceed_btn.Click

        If otp_txt.Text = "" Or new_password_txt.Text = "" Or confirm_password_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are Required", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If new_password_txt.Text = confirm_password_txt.Text Then
                Try
                    Dim connection = functions.connection

                    connection.Open()
                    command = New MySqlCommand("SELECT otp FROM staff_tab WHERE otp=@otp AND staff_id=@staff_id", connection)
                    command.Parameters.AddWithValue("@staff_id", adminresetpassword.staff_id)
                    command.Parameters.AddWithValue("@otp", otp_txt.Text)
                    reader = command.ExecuteReader

                    If reader.HasRows Then
                        connection.close()
                        connection.open()
                        command = New MySqlCommand("UPDATE staff_tab SET password=@password WHERE staff_id=@staff_id", connection)
                        command.Parameters.AddWithValue("@staff_id", adminresetpassword.staff_id)
                        command.Parameters.AddWithValue("@password", new_password_txt.Text)
                        reader = command.ExecuteReader
                        connection.Close()
                        MessageBox.Show("SUCCESS! Password Updated Successfully", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        overlay.Close()
                        adminlogin.Show()
                    Else
                        MessageBox.Show("ERROR! OTP not valid", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MessageBox.Show("ERROR! New Password And Confirm Password Do Not Match", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub adminfinishresetpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        password_label.Text = "Dear" & " " & adminresetpassword.fullname & "," & " " & "an OTP has been sent to your registered Email Address" & Environment.NewLine & "(" & adminresetpassword.email_address & ")"
    End Sub

    Private Sub otp_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles otp_txt.KeyPress
        functions.numCheck(e)
    End Sub
End Class