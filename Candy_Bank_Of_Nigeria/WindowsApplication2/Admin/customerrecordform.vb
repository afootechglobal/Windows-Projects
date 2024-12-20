Imports MySql.Data.MySqlClient
Imports System.IO
Public Class customerrecordform
    Dim reader As MySqlDataReader
    Dim query As String
    Private Sub customerrecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.getGender()
        functions.getStatus(customer_status_id_combobox)
        functions.getCustomerID()
        Dim result = functions.allCounts
        total_customer_count_label_txt.Text = allCounts.item2.ToString
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub view_rec_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_rec_btn.Click
        Me.Hide()
        overlay.Show()
        customerviewrecord.Show()
    End Sub

    Private Sub select_passport_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_passport_btn.Click
        functions.selectPassport(customer_profile_pic)
    End Sub

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click

        If full_name_txt.Text = "" Or email_address_txt.Text = "" Or phone_number_txt.Text = "" Then
            MessageBox.Show("ERROR! Enter Input for all Fields", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf customer_profile_pic.Image Is Nothing Then
            MessageBox.Show("ERROR! Select a Passport to Continue!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf functions.validateEmail(email_address_txt.Text) = False Then
            MessageBox.Show("ERROR! Invalid Email Address", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If profile_id.Text = "SELECT CUSTOMER....." Then
                reader = functions.customerEmailCheck(email_address_txt.Text)
                If reader.HasRows Then
                    MessageBox.Show("ERROR! Emaill Address is already Exist, Kindly Enter a new Email Address to Continue!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    functions.customerRegistration()
                End If
            Else
                reader = functions.customerUpdateEmailCheck(email_address_txt.Text)
                If reader.HasRows Then
                    MessageBox.Show("ERROR! Emaill Address is already Exist, Kindly Enter a new Email Address to Continue!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    functions.UpdateCustomer()
                End If
            End If
        End If
        Dim updatedCounts = functions.allCounts()
        total_customer_count_label_txt.Text = updatedCounts.Item1.ToString
    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click

        If profile_id.Text = "SELECT CUSTOMER....." Then
            MessageBox.Show("SELECT CUSTOMER TO CONTINUE!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim connection = functions.connection
                connection.Open()
                query = "SELECT a.*, b.status_name, c.gender_name FROM customer_tab a, setup_status_tab b, setup_gender_tab c WHERE a.status_id=b.status_id AND a.gender_id=c.gender_id AND customer_id=@customer_id;"
                Dim Command = New MySqlCommand(query, connection)
                Command.Parameters.AddWithValue("@customer_id", profile_id.SelectedValue)
                reader = Command.ExecuteReader
                reader.Read()

                Dim arrimage() As Byte

                full_name_txt.Text = reader("fullname")
                email_address_txt.Text = reader("email_address")
                phone_number_txt.Text = reader("phone_number")
                customer_gender_combobox.Text = (reader("gender_name"))
                customer_gender_combobox.SelectedValue = reader("gender_id")
                customer_status_id_combobox.Text = (reader("status_name"))
                customer_status_id_combobox.SelectedValue = reader("status_id")
                arrimage = reader("passport")

                Dim mstream = New MemoryStream(arrimage)
                customer_profile_pic.Image = Image.FromStream(mstream)
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub full_name_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles full_name_txt.KeyPress
        functions.alphaCheck(e)
    End Sub

    Private Sub phone_number_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone_number_txt.KeyPress
        functions.numCheck(e)
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        functions.clearFunction()
    End Sub

End Class