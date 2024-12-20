Imports MySql.Data.MySqlClient
Public Class userchangepassword
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        If oldPass_txt.Text = "" Or newPass_txt.Text = "" Or confirmPass_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are Required!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim connection = functions.connection
            Dim result = functions.getCustomerProfile(userlogin.login_customer_id)
            Dim old_password = result.item6.ToString

            If old_password = oldPass_txt.Text Then
                If newPass_txt.Text = confirmPass_txt.Text Then
                    connection.open()
                    query = "UPDATE customer_tab SET password=@password WHERE customer_id=@customer_id"
                    command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@password", newPass_txt.Text)
                    command.Parameters.AddWithValue("@customer_id", userlogin.login_customer_id)
                    reader = command.ExecuteReader
                    connection.Close()
                    MessageBox.Show("SUCCESS! Password has been updated successfully", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    overlay.Close()
                Else
                    MessageBox.Show("ERROR! New Password don't match with Confirmed Password!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("ERROR! Old Password is Incorrect", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class