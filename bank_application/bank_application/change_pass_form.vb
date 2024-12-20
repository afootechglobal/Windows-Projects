Imports MySql.Data.MySqlClient
Public Class change_pass_form
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        If oldPass_txt.Text = "" Or newPass_txt.Text = "" Or confirmPass_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are Required!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim connection = myfunctions.connection
            Dim result = myfunctions.getCustomerProfile(userlogin_form.login_customer_id)
            Dim old_password = result.item6.ToString

            If old_password = oldPass_txt.Text Then
                If newPass_txt.Text = confirmPass_txt.Text Then
                    connection.open()
                    query = "UPDATE customer_tab SET password=@password WHERE customer_id=@customer_id"
                    Command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@password", newPass_txt.Text)
                    Command.Parameters.AddWithValue("@customer_id", userlogin_form.login_customer_id)
                    reader = Command.ExecuteReader
                    connection.Close()
                    MessageBox.Show("SUCCESS! Password has been updated successfully", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    overlay.Close()
                Else
                    MessageBox.Show("ERROR! New Password don't match with Confirmed Password!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("ERROR! Old Password is Incorrect", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class