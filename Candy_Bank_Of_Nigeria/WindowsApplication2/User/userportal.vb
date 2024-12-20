Imports MySql.Data.MySqlClient
Imports System.IO
Public Class userportal

    Private Sub user_log_out_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_log_out_btn.Click
        Dim close_validation = MessageBox.Show("Are you sure you want to LOG OUT", "Exit User Dashboard", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close_validation = vbYes Then
            Me.Hide()
            userlogin.Show()
        End If
    End Sub

    Private Sub userportal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        index.Close()
    End Sub

    Private Sub userportal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Guna2Panel4.BackColor = Color.FromArgb(200, 128, 128, 128)
        Guna2Panel3.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel2.BackColor = Color.FromArgb(200, 255, 255, 255)


        ' Start the timer
        Timer1.Interval = 1000 ' Set the timer interval to 1 second
        Timer1.Start()

        ' Set up the labels
        SetupLabels()

        Dim result = functions.getCustomerProfile(userlogin.login_customer_id)
        Dim arrimage() As Byte = result.item5
        user_full_name_label.Text = result.item1.ToString
        user_last_login_label.Text = "Last Login Date:" & " " & result.item2.ToString
        acct_balance_label.Text = "NGN" & " " & result.item3.ToString
        loan_balance_label.Text = "NGN" & " " & result.item4.ToString
        Dim mstream = New MemoryStream(arrimage)
        passporrt.Image = Image.FromStream(mstream)

    End Sub

    ' Set label properties
    Private Sub SetupLabels()
        ' Set up time label properties
        time_label.ForeColor = Color.Maroon
        time_label.Font = New Font("Microsoft Tai Le", 10, FontStyle.Bold)
        time_label.AutoSize = True  ' Set AutoSize to True
        time_label.Height = 20      ' Adjust the height if necessary

        ' Set up date label properties
        date_label.Font = New Font("Microsoft Tai Le", 9, FontStyle.Regular)
        date_label.ForeColor = Color.Black
        date_label.AutoSize = True  ' Set AutoSize to True
        date_label.Height = 30      ' Adjust the height if necessary
    End Sub

    Private Sub request_for_loan_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles request_for_loan_btn.Click
        overlay.Show()
        userloanrequestform.Show()
    End Sub

    Private Sub deposit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deposit_btn.Click
        depositform.Show()
        overlay.Show()
    End Sub

    Private Sub withdraw_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdraw_btn.Click
        withdrawform.Show()
        overlay.Show()
    End Sub

    Private Sub trans_history_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trans_history_btn.Click
        userviewtransaction.Show()
        overlay.Show()
    End Sub

    Private Sub change_password_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles change_password_btn.Click
        userchangepassword.Show()
        overlay.Show()
    End Sub

    Private Sub UpdatePassportInDatabase(ByVal staff_id As String, ByVal passport As Byte())
        Try

            Dim connection = functions.connection
            connection.Open()

            Dim query As String = "UPDATE customer_tab SET passport = @passport, updated_time = @updated_time WHERE customer_id = @customer_id"
            Dim Command = New MySqlCommand(query, connection)

            Command.Parameters.AddWithValue("@passport", passport)
            Command.Parameters.AddWithValue("@updated_time", DateTime.Now)
            Command.Parameters.AddWithValue("@customer_id", userlogin.login_customer_id)

            Dim rowsAffected As Integer = Command.ExecuteNonQuery()


            If rowsAffected > 0 Then
                MessageBox.Show("Picture updated successfully!")
            Else
                MessageBox.Show("Error: Picture could not be updated.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub passporrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passporrt.Click

        functions.selectPassport(passporrt)

        Dim result As DialogResult = MessageBox.Show("Do you want to save this new picture?", "Confirm Update", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Save the updated passport
            Dim updatedImage As Byte() = functions.passportSave(passporrt)
            Dim ValidStaffId As String = userlogin.login_customer_id
            UpdatePassportInDatabase(ValidStaffId, updatedImage)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Update time and date every second
        time_label.Text = DateTime.Now.ToString("hh:mm:ss tt")
        date_label.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy")
    End Sub
End Class