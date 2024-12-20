Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Public Class StaffRecord
    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim staff_id As String

    Private Sub StaffRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()
        FetchStaffRecord()
        FetchRole()
        StatusComboboxLoad()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub selectpassport_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectpassport_button.Click
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            StaffProfile.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
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

        ElseIf StaffProfile.Image Is Nothing Then
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
            Dim formodal As New Form
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            YesNoUpdate.ShowDialog()
            formodal.Dispose()
        End If
    End Sub

    'My Inner Function Start Here....

    Public Function FetchStaffRecord()
        Try
            Dim email As String
            email = login.email_txt.Text
            connection = MyFuctions.GetSqlConnection
            query = "SELECT a.fullname, a.email_address, a.mobile, a.address, a.passport,b.role_name, c.status_name FROM staff_tab a, setup_role_tab b, setup_status_tab c WHERE email_address=@email_address AND a.staff_id = a.staff_id AND a.role_id = b.role_id AND a.status_id = c.status_id;"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email_address", email)
            reader = command.ExecuteReader
            reader.Read()

            fullname_txt.Text = reader("fullname")
            email_txt.Text = reader("email_address")
            mobile_txt.Text = reader("mobile")
            address_txt.Text = reader("address")
            'RoleComboBox.Text = reader("role_name")
            ' StatusComboBox.Text = reader("status_name")

           arrimage = DirectCast(reader("passport"), Byte())
            mstream = New MemoryStream(arrimage)
            StaffProfile.Image = Image.FromStream(mstream)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        connection.Close()
    End Function

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

                Else
                    connection = MyFuctions.GetSqlConnection
                    query = "SELECT * FROM setup_role_tab WHERE role_id IN(3)"
                    Using adapter As New MySqlDataAdapter(query, connection)
                        Dim datatable As New DataTable
                        adapter.Fill(datatable)
                        RoleComboBox.DisplayMember = "role_name"
                        RoleComboBox.ValueMember = "role_id"
                        RoleComboBox.DataSource = datatable
                    End Using
                    Label5.Visible = False
                    RoleComboBox.Visible = False
                    Label6.Visible = False
                    StatusComboBox.Visible = False
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

    Public Function StaffUpdate()
        Dim msstream As New System.IO.MemoryStream()
        StaffProfile.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        Try
            ' staff_id = MyFuctions.staffID
            Dim email As String
            email = login.email_txt.Text

            connection = MyFuctions.GetSqlConnection
            query = "UPDATE staff_tab SET fullname=@fullname,email_address=@email_address,address=@address,role_id=@role_id,status_id=@status_id,passport=@passport,updated_at=NOW() WHERE email_address=@email_address"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email_address", email)
            command.Parameters.AddWithValue("@fullname", fullname_txt.Text)
            '  command.Parameters.AddWithValue("@email_address", email_txt.Text)
            'command.Parameters.AddWithValue("@mobile", mobile_txt.Text)
            command.Parameters.AddWithValue("@address", address_txt.Text)
            command.Parameters.AddWithValue("@role_id", RoleComboBox.SelectedValue)
            command.Parameters.AddWithValue("@status_id", StatusComboBox.SelectedValue)
            command.Parameters.AddWithValue("@passport", msstream.ToArray)
            reader = command.ExecuteReader
            connection.Close()
            RecordUpdate.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    
End Class