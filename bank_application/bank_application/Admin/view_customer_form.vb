Imports MySql.Data.MySqlClient
Imports System.IO
Public Class view_customer_form
    Dim reader As MySqlDataReader
    Dim query As String

    Private Sub view_customer_form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myfunctions.getGender()
        myfunctions.getStatus(StatusComboBox)
        myfunctions.getCustomerID()
        Dim result = myfunctions.allCounts
        userCount.Text = allCounts.item2.ToString
    End Sub

    Private Sub recordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recordBtn.Click
        Me.Hide()
        customer_reg_form.Show()
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub selectpassport_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectpassport_button.Click
        myfunctions.selectPassport(CustomerPictureBox)
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        If fullname_txt.Text = "" Or email_txt.Text = "" Or mobile_txt.Text = "" Then
            MessageBox.Show("ERROR! Enter Input for all Fields", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CustomerPictureBox.Image Is Nothing Then
            MessageBox.Show("ERROR! Select a Passport to Continue!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf myfunctions.emailValidate(email_txt.Text) = False Then
            MessageBox.Show("ERROR! Invalid Email Address", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If profile_id.Text = "SELECT CUSTOMER" Then
                reader = myfunctions.customerEmailCheck(email_txt.Text)
                If reader.HasRows Then
                    MessageBox.Show("ERROR! Emaill Address is already Exist, Kindly Enter a new Email Address to Continue!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    myfunctions.customerRegistration()
                End If
            Else
                reader = myfunctions.customerUpdateEmailCheck(email_txt.Text)
                If reader.HasRows Then
                    MessageBox.Show("ERROR! Emaill Address is already Exist, Kindly Enter a new Email Address to Continue!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    myfunctions.UpdateCustomer()
                End If
            End If
        End If
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        myfunctions.clearFunction()
    End Sub

    Private Sub fetchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetchBtn.Click
        If profile_id.Text = "SELECT CUSTOMER" Then
            MessageBox.Show("SELECT CUSTOMER TO CONTINUE!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim connection = myfunctions.connection
                connection.Open()
                query = "SELECT a.*, b.status_name, c.gender_name FROM customer_tab a, setup_status_tab b, setup_gender_tab c WHERE a.status_id=b.status_id AND a.gender_id=c.gender_id AND customer_id=@customer_id;"
                Dim Command = New MySqlCommand(query, connection)
                Command.Parameters.AddWithValue("@customer_id", profile_id.SelectedValue)
                reader = Command.ExecuteReader
                reader.Read()

                Dim arrimage() As Byte

                fullname_txt.Text = reader("fullname")
                email_txt.Text = reader("email")
                mobile_txt.Text = reader("mobile")
                genderComboBox.Text = (reader("gender_name"))
                genderComboBox.SelectedValue = reader("gender_id")
                StatusComboBox.Text = (reader("status_name"))
                StatusComboBox.SelectedValue = reader("status_id")
                arrimage = reader("passport")

                Dim mstream = New MemoryStream(arrimage)
                CustomerPictureBox.Image = Image.FromStream(mstream)
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub fullname_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fullname_txt.KeyPress
        myfunctions.alphaCheck(e)
    End Sub

    Private Sub mobile_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mobile_txt.KeyPress
        myfunctions.numCheck(e)
    End Sub
End Class