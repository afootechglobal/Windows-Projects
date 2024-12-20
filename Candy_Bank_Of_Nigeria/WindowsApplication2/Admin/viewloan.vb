Imports MySql.Data.MySqlClient
Imports System.IO
Public Class viewloan
    Dim reader As MySqlDataReader
    Dim query As String

    Private Sub viewloan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.getCustomerLoanID()
        Dim result = functions.allCounts
        total_loan_count_label_txt.Text = allCounts.item5.ToString
    End Sub
    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub loan_schedule_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_schedule_btn.Click
        Me.Hide()
        overlay.Show()
        loanschedule.Show()
    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click

        If profile_id.Text = "SELECT CUSTOMER....." Then
            MessageBox.Show("SELECT CUSTOMER TO CONTINUE!", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim connection = functions.connection
                connection.Open()
                query = "SELECT a.*, b.* FROM customer_tab a, customer_loan_transaction_tab b WHERE a.customer_id=b.customer_id AND a.customer_id=@customer_id;"
                Dim Command = New MySqlCommand(query, connection)
                Command.Parameters.AddWithValue("@customer_id", profile_id.SelectedValue)
                reader = Command.ExecuteReader
                reader.Read()

                'MsgBox(reader("customer_id"))

                Dim arrimage() As Byte

                full_name_txt.Text = reader("fullname")
                email_address_txt.Text = reader("email_address")
                phone_number_txt.Text = reader("phone_number")
                loan_id_txt.Text = reader("transaction_id")
                loan_amount_txt.Text = Double.Parse(reader("loan_amount")).ToString("N2")
                loan_duration_txt.Text = reader("loan_duration")
                arrimage = reader("passport")

                Dim mstream = New MemoryStream(arrimage)
                loan_details_pic_box.Image = Image.FromStream(mstream)
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        functions.clearFunction()
    End Sub
End Class