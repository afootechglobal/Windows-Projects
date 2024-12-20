Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Public Class AdminReg
    Dim connection As MySqlConnection
    Dim connstring As String
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim staff_id As String

    Private Sub AdminReg_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()
        connection = MyFuctions.GetSqlConnection
        RoleComboboxLoad()
        StatusComboboxLoad()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
        ClearOption()
    End Sub

    Private Sub selectpassport_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectpassport_button.Click
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            UserPictureBox.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        If fullname_txt.Text = "" Or email_txt.Text = "" Or mobile_txt.Text = "" Or address_txt.Text = "" Or RoleComboBox.Text = "Choose..." Or StatusComboBox.Text = "Choose..." Then
            MessageBox.Show("All Fields are Required!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf validateEmail(email_txt.Text) = False Then
            MessageBox.Show("Please Enter a valid Email Address to Continue!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email_txt.Text = ""
            email_txt.Focus()
            Exit Sub
        ElseIf mobile_txt.TextLength < 10 Then
            MessageBox.Show("Please Enter a valid Phone Number to Continue!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mobile_txt.Text = ""
            mobile_txt.Focus()
            Exit Sub
        ElseIf UserPictureBox.Image Is Nothing Then
            MessageBox.Show("Select a Passport to Continue!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            connection = MyFuctions.GetSqlConnection
            query = "SELECT * FROM staff_tab WHERE email_address=@email_address"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email_Address", email_txt.Text)
            reader = command.ExecuteReader
            If reader.HasRows = True Then
                MessageBox.Show("Email Address is already Exist, Kindly Enter a new Email Address to Continue!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                email_txt.Text = ""
            Else
                connection = MyFuctions.GetSqlConnection
                query = "SELECT * FROM staff_tab WHERE mobile=@mobile"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@mobile", mobile_txt.Text)
                reader = command.ExecuteReader
                If reader.HasRows = True Then
                    MessageBox.Show("Phone Number is already Exist, Kindly Enter a new Phone Number to Continue!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mobile_txt.Text = ""
                Else
                    Registration()
                End If
            End If
        End If
    End Sub

    'my function code start here.....

    Public Sub Registration()
        Dim msstream As New System.IO.MemoryStream()
        UserPictureBox.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()
        Try

            staff_id = MyFuctions.staffID

            connection = MyFuctions.GetSqlConnection
            query = "INSERT into staff_tab(staff_id,role_id,status_id,fullname,email_address,mobile,address,passport,created_at) VALUES(@staff_id,@role_id,@status_id,@fullname,@email_address,@mobile,@address,@passport,NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@staff_id", staff_id)
            command.Parameters.AddWithValue("@role_id", RoleComboBox.SelectedValue)
            command.Parameters.AddWithValue("@status_id", StatusComboBox.SelectedValue)
            command.Parameters.AddWithValue("@fullname", fullname_txt.Text)
            command.Parameters.AddWithValue("@email_address", email_txt.Text)
            command.Parameters.AddWithValue("@mobile", mobile_txt.Text)
            command.Parameters.AddWithValue("@address", address_txt.Text)
            command.Parameters.AddWithValue("@passport", arrimage)
            reader = command.ExecuteReader
            connection.Close()
            Dim response As Integer
            response = MessageBox.Show("Record has been saved successfully!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            If response = vbOK Then
                ClearOption()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            ' MessageBox.Show("Image Size is too Bigger, Kindly Reduce the Size to Continue!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RoleComboboxLoad()
        Try
            connection = MyFuctions.GetSqlConnection
            query = "SELECT * FROM setup_role_tab"
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim datatable As New DataTable
                adapter.Fill(datatable)
                RoleComboBox.DisplayMember = "role_name"
                RoleComboBox.ValueMember = "role_id"
                RoleComboBox.DataSource = datatable
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub StatusComboboxLoad()
        Try
            connection = MyFuctions.GetSqlConnection
            query = "SELECT * FROM setup_status_tab"
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim datatable As New DataTable
                adapter.Fill(datatable)
                StatusComboBox.DisplayMember = "status_name"
                StatusComboBox.ValueMember = "status_id"
                StatusComboBox.DataSource = datatable
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearOption()
        fullname_txt.Text = ""
        email_txt.Text = ""
        mobile_txt.Text = ""
        address_txt.Text = ""
        UserPictureBox.Image = Nothing

        'StatusComboBox.Items.Clear()
        ' RoleComboBox.Items.Clear()
    End Sub



End Class