Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class adminportal
    Public login_staff_id As String ' Staff ID of the logged-in user

    Private Sub admin_log_out_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_log_out_btn.Click
        Dim close_validation = MessageBox.Show("Are you sure you want to LOG OUT", "Exit Admin Dashboard", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close_validation = vbYes Then
            Me.Hide()
            adminlogin.Show()
        End If
    End Sub

    Private Sub adminportal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        index.Close()

    End Sub

    Private Sub adminportal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Set the background color with transparency
        Guna2Panel4.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel2.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel3.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel5.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel6.BackColor = Color.FromArgb(200, 255, 255, 255)

        ' Start the timer
        Timer1.Interval = 1000 ' Set the timer interval to 1 second
        Timer1.Start()

        ' Set up the labels
        SetupLabels()

        Dim result = functions.getStaffProfile(adminlogin.login_staff_id)
        Dim arrimage() As Byte = result.item3
        staff_full_name_label_txt.Text = result.item1.ToString
        last_login_label_txt.Text = "Last Login Date:" & " " & result.item2.ToString
        Dim mstream = New MemoryStream(arrimage)
        passporrt.Image = Image.FromStream(mstream)

        Dim allCounts = functions.allCounts()
        total_admin_label.Text = allCounts.item1.ToString
        total_customer_label.Text = allCounts.item2.ToString
        total_loan_label.Text = allCounts.item5.ToString
        total_balance_label.Text = "₦" & allCounts.item4.ToString

       

        If adminlogin.login_role_id <= 1 Then
            view_admin_btn.Hide()
            view_customer_btn.Location = New Point(0, 62)
            view_loan_btn.Location = New Point(0, 124)
            deposit_btn.Location = New Point(0, 186)
            settings_btn.Location = New Point(0, 248)
        End If
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

    Private Sub view_admin_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_admin_btn.Click
        index.Hide()
        main.Hide()
        overlay.Show()
        adminrecord.Show()
    End Sub

    Private Sub view_customer_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_customer_btn.Click
        overlay.Show()
        customerrecordform.Show()
    End Sub

    Private Sub deposit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deposit_btn.Click
        overlay.Show()
        depositform.Show()
    End Sub

    Private Sub withdraw_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdraw_btn.Click
        overlay.Show()
        withdrawform.Show()
    End Sub

    Private Sub view_loan_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_loan_btn.Click
        overlay.Show()
        viewloan.Show()
    End Sub

    Private Sub settings_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings_btn.Click
        overlay.Show()
        settings.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Update time and date every second
        time_label.Text = DateTime.Now.ToString("hh:mm:ss tt")
        date_label.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy")
    End Sub

    Private Sub UpdatePassportInDatabase(ByVal staff_id As String, ByVal passport As Byte())
        Try

            Dim connection = functions.connection
            connection.Open()

            Dim query As String = "UPDATE staff_tab SET passport = @passport, updated_time = @updated_time WHERE staff_id = @staff_id"
            Dim Command = New MySqlCommand(query, connection)

            Command.Parameters.AddWithValue("@passport", passport)
            Command.Parameters.AddWithValue("@updated_time", DateTime.Now)
            Command.Parameters.AddWithValue("@staff_id", adminlogin.login_staff_id)

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
            Dim ValidStaffId As String = adminlogin.login_staff_id
            UpdatePassportInDatabase(ValidStaffId, updatedImage)
        End If
    End Sub
End Class