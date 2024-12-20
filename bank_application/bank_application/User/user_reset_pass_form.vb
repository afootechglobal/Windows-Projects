Imports MySql.Data.MySqlClient
Public Class user_reset_pass_form
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public customer_id, fullname, email_address As String

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Hide()
        userlogin_form.Show()
    End Sub

    Private Sub proceed_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceed_btn.Click
        If email_txt.Text = "" Then
            MessageBox.Show("Error! Input your Email Address to Continue!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf myfunctions.emailValidate(email_txt.Text) = False Then
            MessageBox.Show("Invalid Email Address", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Try
                reader = myfunctions.customerEmailCheck(email_txt.Text)
                If reader.HasRows Then
                    customer_id = reader("customer_id")
                    Dim status_id = reader("status_id")
                    fullname = reader("fullname")
                    email_address = reader("email")

                    If status_id = 1 Then
                        Dim otp As String = New Random().Next(100000, 999999).ToString()

                        Dim connection = myfunctions.connection

                        connection.Open()
                        command = New MySqlCommand("UPDATE customer_tab SET otp=@otp WHERE customer_id=@customer_id", connection)
                        command.Parameters.AddWithValue("@customer_id", customer_id)
                        Command.Parameters.AddWithValue("@otp", otp)
                        reader = Command.ExecuteReader
                        connection.Close()

                        user_finish_reset_pass.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("ERROR! Account has been Suspended", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Email Address not Found!", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class