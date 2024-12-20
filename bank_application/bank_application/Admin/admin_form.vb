Imports MySql.Data.MySqlClient
Imports System.IO
Public Class admin_form
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub admin_form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myfunctions.getStaffID()
        myfunctions.getRole()
        myfunctions.getStatus(StatusComboBox)
        Dim result = myfunctions.allCounts
        userCount.Text = allCounts.item1.ToString
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub selectpassport_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectpassport_button.Click
        myfunctions.selectPassport(AdminPictureBox)
    End Sub

    Private Sub recordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recordBtn.Click
        admin_reg_form.Show()
        Me.Hide()
    End Sub

    Private Sub fetchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetchBtn.Click
        If profile_id.Text = "SELECT STAFF" Then
            MessageBox.Show("SELECT STAFF TO CONTINUE!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim connection = myfunctions.connection
                connection.Open()
                query = "SELECT a.*, b.role_name, c.status_name FROM staff_tab a, setup_role_tab b, setup_status_tab c WHERE a.status_id=c.status_id AND a.role_id=b.role_id AND staff_id=@staff_id;"
                Dim Command = New MySqlCommand(query, connection)
                Command.Parameters.AddWithValue("@staff_id", profile_id.SelectedValue)
                reader = Command.ExecuteReader
                reader.Read()

                Dim arrimage() As Byte

                fullname_txt.Text = reader("fullname")
                email_txt.Text = reader("email")
                mobile_txt.Text = reader("mobile")
                RoleComboBox.Text = (reader("role_name"))
                RoleComboBox.SelectedValue = reader("role_id")
                StatusComboBox.Text = (reader("status_name"))
                StatusComboBox.SelectedValue = reader("status_id")
                arrimage = reader("passport")

                Dim mstream = New MemoryStream(arrimage)
                AdminPictureBox.Image = Image.FromStream(mstream)
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        If fullname_txt.Text = "" Or email_txt.Text = "" Or mobile_txt.Text = "" Then
            MessageBox.Show("ERROR! Enter Input for all Fields", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf AdminPictureBox.Image Is Nothing Then
            MessageBox.Show("ERROR! Select a Passport to Continue!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf myfunctions.emailValidate(email_txt.Text) = False Then
            MessageBox.Show("ERROR! Invalid Email Address", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If profile_id.Text = "SELECT STAFF" Then
                reader = myfunctions.emailCheck(email_txt.Text)
                If reader.HasRows Then
                    MessageBox.Show("ERROR! Emaill Address is already Exist, Kindly Enter a new Email Address to Continue!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    myfunctions.staffRegistration()
                End If
            Else
                reader = myfunctions.updateEmailCheck(email_txt.Text)
                If reader.HasRows Then
                    MessageBox.Show("ERROR! Emaill Address is already Exist, Kindly Enter a new Email Address to Continue!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    myfunctions.UpdateStaff()
                End If
            End If
        End If
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        myfunctions.clearFunction()
    End Sub

    Private Sub fullname_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fullname_txt.KeyPress
        myfunctions.alphaCheck(e)
    End Sub

    Private Sub mobile_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mobile_txt.KeyPress
        myfunctions.numCheck(e)
    End Sub
End Class