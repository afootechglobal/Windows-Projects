﻿Imports MySql.Data.MySqlClient
Public Class finish_reset_pass_form
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand

    Private Sub finish_reset_pass_form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        passLabel.Text = "Dear" & " " & admin_reset_pass_form.fullname & "," & " " & "an OTP has been sent to your registered Email Address" & Environment.NewLine & "(" & admin_reset_pass_form.email_address & ")"
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub proceed_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceed_btn.Click
        If otp_txt.Text = "" Or new_pass_txt.Text = "" Or confirm_pass_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are Required", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If new_pass_txt.Text = confirm_pass_txt.Text Then
                Try
                    Dim connection = myfunctions.connection

                    connection.Open()
                    command = New MySqlCommand("SELECT otp FROM staff_tab WHERE otp=@otp AND staff_id=@staff_id", connection)
                    command.Parameters.AddWithValue("@staff_id", admin_reset_pass_form.staff_id)
                    command.Parameters.AddWithValue("@otp", otp_txt.Text)
                    reader = command.ExecuteReader

                    If reader.HasRows Then
                        connection.close()
                        connection.open()
                        command = New MySqlCommand("UPDATE staff_tab SET password=@password WHERE staff_id=@staff_id", connection)
                        command.Parameters.AddWithValue("@staff_id", admin_reset_pass_form.staff_id)
                        command.Parameters.AddWithValue("@password", new_pass_txt.Text)
                        reader = command.ExecuteReader
                        connection.Close()
                        MessageBox.Show("SUCCESS! Password has been successfully updated", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        adminlogin_form.Show()
                    Else
                        MessageBox.Show("ERROR! OTP not valid", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MessageBox.Show("ERROR! New password and confirm password don't match", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class