Imports MySql.Data.MySqlClient
Imports System.IO
Public Class view_loan_form
    Dim reader As MySqlDataReader
    Dim query As String

    Private Sub view_loan_form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myfunctions.getCustomerLoanID()
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub loan_schedule_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_schedule_btn.Click
        Me.Hide()
        loan_schedule_form.Show()
    End Sub

    Private Sub fetchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetchBtn.Click
        If profile_id.Text = "SELECT CUSTOMER" Then
            MessageBox.Show("SELECT CUSTOMER TO CONTINUE!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim connection = myfunctions.connection
                connection.Open()
                query = "SELECT a.*, b.* FROM customer_tab a, customer_loan_transaction_tab b WHERE a.customer_id=b.customer_id AND a.customer_id=@customer_id;"
                Dim Command = New MySqlCommand(query, connection)
                Command.Parameters.AddWithValue("@customer_id", profile_id.SelectedValue)
                reader = Command.ExecuteReader
                reader.Read()

                Dim arrimage() As Byte

                fullname_txt.Text = reader("fullname")
                email_txt.Text = reader("email")
                mobile_txt.Text = reader("mobile")
                loan_id_txt.Text = reader("transaction_id")
                loan_amount_txt.Text = Double.Parse(reader("loan_amount")).ToString("N2")
                loan_duration_txt.Text = reader("loan_duration")
                arrimage = reader("passport")

                Dim mstream = New MemoryStream(arrimage)
                PictureBox.Image = Image.FromStream(mstream)
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class