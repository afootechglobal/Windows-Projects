Imports MySql.Data.MySqlClient
Imports System.IO
Public Class adminrecord
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub view_rec_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_rec_btn.Click
        Me.Close()
        overlay.Show()
        adminviewrecord.Show()
    End Sub

    Private Sub adminrecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.getStaffID()
        functions.getRole()
        functions.getStatus(staff_Status_id_Combobox)
        Dim result = functions.allCounts
        total_staff_count_label_txt.Text = allCounts.item1.ToString
    End Sub

    Private Sub select_passport_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_passport_btn.Click
        functions.selectPassport(admin_profile_pic)
    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click

        If profile_id.Text = "SELECT STAFF....." Then
            MessageBox.Show("SELECT A STAFF TO CONTINUE!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim connection = functions.connection
                connection.Open()
                query = "SELECT a.*, b.role_name, c.status_name FROM staff_tab a, setup_role_tab b, setup_status_tab c WHERE a.status_id=c.status_id AND a.role_id=b.role_id AND staff_id=@staff_id;"
                Dim Command = New MySqlCommand(query, connection)
                Command.Parameters.AddWithValue("@staff_id", profile_id.SelectedValue)
                reader = Command.ExecuteReader
                reader.Read()

                Dim arrimage() As Byte

                full_name_txt.Text = reader("fullname")
                email_address_txt.Text = reader("email_address")
                phone_number_txt.Text = reader("phone_number")
                staff_role_id_combobox.Text = (reader("role_name"))
                staff_role_id_combobox.SelectedValue = reader("role_id")
                staff_Status_id_Combobox.Text = (reader("status_name"))
                staff_Status_id_Combobox.SelectedValue = reader("status_id")
                arrimage = reader("passport")

                Dim mstream = New MemoryStream(arrimage)
                admin_profile_pic.Image = Image.FromStream(mstream)
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click

        Dim response As DialogResult
        If full_name_txt.Text = "" Or email_address_txt.Text = "" Or phone_number_txt.Text = "" Then
            MessageBox.Show("All Fields are Required!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf validateEmail(email_address_txt.Text) = False Then
            MessageBox.Show("Please Enter a valid Email Address to Continue!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email_address_txt.Text = ""
            email_address_txt.Focus()
            Exit Sub
        ElseIf phone_number_txt.TextLength < 10 Then
            MessageBox.Show("Please Enter a valid Phone Number to Continue!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            phone_number_txt.Text = ""
            phone_number_txt.Focus()
            Exit Sub
        ElseIf admin_profile_pic.Image Is Nothing Then
            MessageBox.Show("Please Select a Passport to Continue!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (profile_id.Text = "SELECT STAFF.....") Then
                response = MessageBox.Show("Are You Sure You Want to Save?", "Candy Bank Of Nigeria", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = vbYes Then
                    If Not functions.vetEmail() Then
                        functions.staffRegistration()

                    End If
                End If

            Else
                response = MessageBox.Show("Are You Sure You Want to update?", "Candy Bank Of Nigeria", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = vbYes Then
                    If updateEmailCheck(email_address_txt.Text) Then
                        MessageBox.Show("This Email Address Already Exists!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    functions.UpdateStaff()
                End If
            End If
        End If
        Dim updatedCounts = functions.allCounts()
        total_staff_count_label_txt.Text = updatedCounts.Item1.ToString

    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        functions.clearFunction()
    End Sub

    Private Sub full_name_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles full_name_txt.KeyPress
        functions.alphaCheck(e)
    End Sub

    Private Sub phone_number_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone_number_txt.KeyPress
        functions.numCheck(e)
    End Sub
End Class