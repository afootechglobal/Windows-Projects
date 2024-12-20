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
        FetchRole()
        StatusComboboxLoad()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
        ClearOption()

        admin_dashboard.AllBtnTransparent()
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
        If fullname_txt.Text = "" Or email_txt.Text = "" Or mobile_txt.Text = "" Or address_txt.Text = "" Then
            Dim formodal As New Form
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            EmptyMBox.ShowDialog()
            formodal.Dispose()

        ElseIf validateEmail(email_txt.Text) = False Then
            Dim formodal As New Form
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            EmailValidation.ShowDialog()
            formodal.Dispose()
            email_txt.Text = ""
            email_txt.Focus()
            Exit Sub

        ElseIf mobile_txt.TextLength < 10 Then
            Dim formodal As New Form
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            PhoneNoVerification.ShowDialog()
            formodal.Dispose()
            mobile_txt.Text = ""
            mobile_txt.Focus()
            Exit Sub

        ElseIf UserPictureBox.Image Is Nothing Then
            Dim formodal As New Form
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            PassportSelect.ShowDialog()
            formodal.Dispose()
        Else
            connection = MyFuctions.GetSqlConnection
            query = "SELECT * FROM staff_tab WHERE email_address=@email_address"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email_Address", email_txt.Text)
            reader = command.ExecuteReader
            If reader.HasRows = True Then
                Dim formodal As New Form
                Dim modal As New Enrollment
                formodal.FormBorderStyle = FormBorderStyle.None
                formodal.Opacity = 0.5
                formodal.BackColor = Color.Black
                formodal.WindowState = FormWindowState.Maximized
                formodal.Show()
                modal.Owner = formodal
                EmailExist.ShowDialog()
                formodal.Dispose()
                email_txt.Text = ""
            Else
                connection = MyFuctions.GetSqlConnection
                query = "SELECT * FROM staff_tab WHERE mobile=@mobile"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@mobile", mobile_txt.Text)
                reader = command.ExecuteReader
                If reader.HasRows = True Then
                    Dim formodal As New Form
                    Dim modal As New Enrollment
                    formodal.FormBorderStyle = FormBorderStyle.None
                    formodal.Opacity = 0.5
                    formodal.BackColor = Color.Black
                    formodal.WindowState = FormWindowState.Maximized
                    formodal.Show()
                    modal.Owner = formodal
                    PhoneExist.ShowDialog()
                    formodal.Dispose()
                    mobile_txt.Text = ""
                Else
                    Dim formodal As New Form
                    Dim modal As New Enrollment
                    formodal.FormBorderStyle = FormBorderStyle.None
                    formodal.Opacity = 0.5
                    formodal.BackColor = Color.Black
                    formodal.WindowState = FormWindowState.Maximized
                    formodal.Show()
                    modal.Owner = formodal
                    YesNoSave.ShowDialog()
                    formodal.Dispose()
                    ' Registration()
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
            RecordSave.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function FetchRole()
        Try
            Dim email As String
            email = login.email_txt.Text

            connection = MyFuctions.GetSqlConnection
            query = "SELECT role_id FROM staff_tab WHERE email_address=@email_address;"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email_address", email)
            reader = command.ExecuteReader

            If reader.HasRows Then
                reader.Read()
                Dim roleId As Integer = Convert.ToInt32(reader("role_id"))
                connection.Close()
                'connection = MyFuctions.GetSqlConnection

                If roleId = 1 Then
                    connection = MyFuctions.GetSqlConnection
                    query = "SELECT * FROM setup_role_tab WHERE role_id IN(1,2,3)"
                    Using adapter As New MySqlDataAdapter(query, connection)
                        Dim datatable As New DataTable
                        adapter.Fill(datatable)
                        RoleComboBox.DisplayMember = "role_name"
                        RoleComboBox.ValueMember = "role_id"
                        RoleComboBox.DataSource = datatable
                    End Using

                ElseIf roleId = 2 Then
                    connection = MyFuctions.GetSqlConnection
                    query = "SELECT * FROM setup_role_tab WHERE role_id IN(2,3)"
                    Using adapter As New MySqlDataAdapter(query, connection)
                        Dim datatable As New DataTable
                        adapter.Fill(datatable)
                        RoleComboBox.DisplayMember = "role_name"
                        RoleComboBox.ValueMember = "role_id"
                        RoleComboBox.DataSource = datatable
                    End Using
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try

    End Function

    Public Sub StatusComboboxLoad()
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

    Public Sub ClearOption()
        fullname_txt.Text = ""
        email_txt.Text = ""
        mobile_txt.Text = ""
        address_txt.Text = ""
        UserPictureBox.Image = Nothing
    End Sub



End Class