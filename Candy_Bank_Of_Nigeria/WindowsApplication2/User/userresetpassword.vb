﻿Imports MySql.Data.MySqlClient
Public Class userresetpassword
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public customer_id, full_name, email_address As String
    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
        main.Show()
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Close()
        userlogin.Show()
    End Sub

    Private Sub proceed_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceed_btn.Click

        If email_address_txt.Text = "" Then
            MessageBox.Show("Error! Input your Email Address to Continue!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf functions.validateEmail(email_address_txt.Text) = False Then
            MessageBox.Show("Invalid Email Address", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Try
                reader = functions.customerEmailCheck(email_address_txt.Text)
                If reader.HasRows Then
                    customer_id = reader("customer_id")
                    Dim status_id = reader("status_id")
                    full_name = reader("full_name")
                    email_address = reader("email")

                    If status_id = 1 Then
                        Dim otp As String = New Random().Next(100000, 999999).ToString()

                        Dim connection = functions.connection

                        connection.Open()
                        command = New MySqlCommand("UPDATE customer_tab SET otp=@otp WHERE customer_id=@customer_id", connection)
                        command.Parameters.AddWithValue("@customer_id", customer_id)
                        command.Parameters.AddWithValue("@otp", otp)
                        reader = command.ExecuteReader
                        connection.Close()

                        Me.Hide()
                        userfinishresetpassword.Show()
                        overlay.Show()

                    Else
                        MessageBox.Show("ERROR! Account has been Suspended", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Email Address not Found!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class