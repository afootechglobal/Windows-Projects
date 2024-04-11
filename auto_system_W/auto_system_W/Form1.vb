Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Public Class Form1
    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim connstring As String
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim user_id As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connection to database
        connstring = "server=localhost;userid=root;password=;database=auto_system_db"
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        mastercountrecord()
        load_profile_id()

    End Sub

    Private Sub mastercountrecord()
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        query = "SELECT count(*) FROM users_tab"
        command = New MySqlCommand(query, connection)
        mastercount_label.Text = command.ExecuteScalar
        connection.Close()
    End Sub

    Private Sub load_profile_id()
        Try
            connection = New MySqlConnection
            connection.ConnectionString = connstring
            connection.Open()
            query = "SELECT * FROM users_tab"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim name = reader.GetString("full_name")
                profile_id.Items.Add(name)
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub counter_user(ByVal counter_id, ByVal counter_value)
        'counter query
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        query = "UPDATE counters_tab SET counter_value=@counter_value WHERE counter_id=@counter_id"
        command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        command.Parameters.AddWithValue("@counter_value", counter_value)
        reader = command.ExecuteReader
        reader.Read()
        connection.Close()
    End Sub
 
    Private Sub Registration()
        ' insertion query code

        'allow passport to save
        'passport.Image.Save(mstream, passport.Image.RawFormat)
        Dim msstream As New System.IO.MemoryStream()
        passport.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()


        Dim counter_value As Integer
        Dim TimeID As String
        ' Dim command As MySqlCommand
        Try
            connection = New MySqlConnection
            connection.ConnectionString = connstring
            connection.Open()
            query = "SELECT counter_value FROM counters_tab WHERE counter_id='USER'"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@counter_id", counter_value)
            reader = command.ExecuteReader
            reader.Read()
            counter_value = reader("counter_value")
            connection.Close()

            counter_value = counter_value + 1
            TimeID = Now.ToString("yyyyMMddss")
            Call counter_user("USER", counter_value)
            user_id = "USER" + TimeID + counter_value.ToString

            connection = New MySqlConnection
            connection.ConnectionString = connstring
            connection.Open()
            query = "INSERT into users_tab (user_id,full_name,email_address,phone_number,passport,date) VALUES(@user_id,@full_name,@email_address,@phone_number,@passport,NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@user_id", user_id)
            command.Parameters.AddWithValue("@full_name", fullname_txt.Text)
            command.Parameters.AddWithValue("@email_address", email_txt.Text)
            command.Parameters.AddWithValue("@phone_number", phoneno_txt.Text)
            command.Parameters.AddWithValue("@passport", arrimage)
            reader = command.ExecuteReader
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Image Size is too Bigger, Kindly Reduce the Size to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        recordcount_label.Text += 1
    End Sub

    Private Sub Updated()
        'allow passport to save

        Dim msstream As New System.IO.MemoryStream()
        passport.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()

        query = "UPDATE users_tab SET full_Name=@full_name,Email_Address=@Email_Address,Phone_Number=@Phone_Number,Passport=@Passport,date=NOW() WHERE user_id=@user_id"
        command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@user_id", profile_id.SelectedValue)
        command.Parameters.AddWithValue("@full_name", fullname_txt.Text)
        command.Parameters.AddWithValue("@email_address", email_txt.Text)
        command.Parameters.AddWithValue("@phone_number", phoneno_txt.Text)
        command.Parameters.AddWithValue("@Passport", msstream.ToArray)
        reader = command.ExecuteReader
        connection.Close()
    End Sub

    Private Sub fetchprofile_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetchprofile_button.Click
        If profile_id.Text = "" Then
            MessageBox.Show("Profile ID Can't be Empty!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                connection = New MySqlConnection
                connection.ConnectionString = connstring
                connection.Open()
                query = "SELECT * FROM users_tab WHERE user_id=@user_id"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@user_id", profile_id.SelectedValue)
                reader = command.ExecuteReader
                reader.Read()

                fullname_txt.Text = reader("full_name")
                email_txt.Text = reader("email_address")
                phoneno_txt.Text = reader("phone_number")
                arrimage = reader("passport")

                mstream = New MemoryStream(arrimage)
                passport.Image = Image.FromStream(mstream)
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            Finally
                'connection.Close()
            End Try
            connection.Close()
        End If
    End Sub

    Private Sub l(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profile_id.Click
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        query = "SELECT * FROM users_tab"
        command = New MySqlCommand(query, connection)
        DT.Load(command.ExecuteReader)
        profile_id.DataSource = DT
        profile_id.DisplayMember = "full_name"
        profile_id.ValueMember = "user_id"
        connection.Close()
    End Sub

    Private Sub delete_profile()
        Try
            connection = New MySqlConnection
            connection.ConnectionString = connstring
            connection.Open()
            query = "DELETE FROM users_tab WHERE user_id=@user_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@user_id", profile_id.SelectedValue)
            reader = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        Finally
            'connection.Close()
        End Try
        connection.Close()

    End Sub

    Private Sub selectpassport_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectpassport_button.Click
        passportimage()
    End Sub

    Private Sub passportimage()
         'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            passport.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
    End Sub

    Private Sub fullname_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fullname_txt.TextChanged
        If fullname_txt.Text = "" Then
            fullname_label.Visible = True
        Else
            fullname_label.Visible = False
        End If
    End Sub

    Private Sub email_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_txt.TextChanged
        If email_txt.Text = "" Then
            email_label.Visible = True
        Else
            email_label.Visible = False
        End If
    End Sub

    Private Sub phoneno_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles phoneno_txt.TextChanged
        If phoneno_txt.Text = "" Then
            phoneno_label.Visible = True
        Else
            phoneno_label.Visible = False
        End If
    End Sub

    Private Sub save_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_button.Click
        Dim response As Integer
        If fullname_txt.Text = "" Or email_txt.Text = "" Or phoneno_txt.Text = "" Then
            MessageBox.Show("All Fields are Required!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf validateEmail(email_txt.Text) = False Then
            MessageBox.Show("Please Enter a valid Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email_txt.Text = ""
            email_txt.Focus()
            Exit Sub
        ElseIf phoneno_txt.TextLength < 10 Then
            MessageBox.Show("Please Enter a valid Phone Number to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            phoneno_txt.Text = ""
            phoneno_txt.Focus()
            Exit Sub
        ElseIf passport.Image Is Nothing Then
            MessageBox.Show("Please Select a Passport to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (profile_id.SelectedValue = Nothing) Then
                response = MessageBox.Show("Are You Sure You Want to Save?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If response = vbYes Then
                    connection = New MySqlConnection
                    connection.ConnectionString = connstring
                    connection.Open()
                    query = "SELECT count(*) FROM users_tab WHERE Email_Address=@Email_Address"
                    command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Email_Address", email_txt.Text)
                    Dim count As Integer
                    count = Convert.ToInt32(command.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Email Address is already Exist, Kindly Enter a new Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else
                            Registration()
                        Activationpanel()
                        End If
                    End If
            Else
                response = MessageBox.Show("Are You Sure You Want to update?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If response = vbYes Then
                    Updated()
                    Savemenustrip()
                End If
            End If
                End If

    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Dim response As Integer
        response = MessageBox.Show("Are You Sure You Want to Exit?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If response = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub fullname_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fullname_txt.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field allows only Letters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub phoneno_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phoneno_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field allows only Numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub email_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles email_txt.KeyPress
        If e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot Only Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("A Dot before letters is not Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEToolStripMenuItem.Click
        Dim response As Integer
        If fullname_txt.Text = "" Or email_txt.Text = "" Or phoneno_txt.Text = "" Then
            MessageBox.Show("All Fields are Required!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf validateEmail(email_txt.Text) = False Then
            MessageBox.Show("Please Enter a valid Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email_txt.Text = ""
            email_txt.Focus()
            Exit Sub
        ElseIf phoneno_txt.TextLength < 10 Then
            MessageBox.Show("Please Enter a valid Phone Number to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            phoneno_txt.Text = ""
            phoneno_txt.Focus()
            Exit Sub
        ElseIf passport.Image Is Nothing Then
            MessageBox.Show("Please Select a Passport to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (profile_id.SelectedValue = Nothing) Then
                response = MessageBox.Show("Are You Sure You Want to Save?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If response = vbYes Then
                    connection = New MySqlConnection
                    connection.ConnectionString = connstring
                    connection.Open()
                    query = "SELECT count(*) FROM users_tab WHERE Email_Address=@Email_Address"
                    command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Email_Address", email_txt.Text)
                    Dim count As Integer
                    count = Convert.ToInt32(command.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Email Address is already Exist, Kindly Enter a new Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else

                        Registration()
                        Activationpanel()
                    End If
                End If
            Else
                response = MessageBox.Show("Are You Sure You Want to update?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If response = vbYes Then
                    Updated()
                    Savemenustrip()
                End If
            End If
        End If

    End Sub

    Private Sub Activation_panel_okay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Activation_panel_okay.Click
        PanelOkay()
        clear()
        mastercountrecord()
    End Sub

    Private Sub delete_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_button.Click
        Dim response As Integer
        If profile_id.Text = "" Then
            MessageBox.Show("Profile ID Can't be Empty!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            response = MessageBox.Show("Are You Sure You Want to Delete?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If response = vbYes Then
                delete_profile()
                DeleteProfile()

            End If
        End If
    End Sub

    Private Sub clear_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_button.Click
        clear()
    End Sub

    Private Sub DeleteOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteOkay.Click
        PanelOkay()
        clear()
        mastercountrecord()
    End Sub

    Public Function validateEmail(ByVal emailAddress) As Boolean
        Dim email As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})")
        If email.IsMatch(emailAddress) Then
            Return True
        End If
    End Function

    Private Sub RECORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECORDToolStripMenuItem.Click
        Recordmenustrip()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM auto_system_db.users_tab", connection)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub FileBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileBack.Click
        PanelOkay()
    End Sub

    Private Sub SaveToolOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolOkay.Click
        PanelOkay()
        clear()
        mastercountrecord()
    End Sub

    Private Sub Activationpanel()
        Activation_panel.Visible = True
        Record_Panel.Visible = False
        RegistrationPanel.Visible = False
        FILEToolStripMenuItem.Visible = False
        DeletePanel.Visible = False
        SaveUpdated_Panel.Visible = False
    End Sub

    Private Sub PanelOkay()
        Activation_panel.Visible = False
        Record_Panel.Visible = False
        DeletePanel.Visible = False
        RegistrationPanel.Visible = True
        FILEToolStripMenuItem.Visible = True
        SaveUpdated_Panel.Visible = False
    End Sub

    Private Sub Recordmenustrip()
        Activation_panel.Visible = False
        Record_Panel.Visible = True
        DeletePanel.Visible = False
        RegistrationPanel.Visible = False
        FILEToolStripMenuItem.Visible = False
        SaveUpdated_Panel.Visible = False
    End Sub

    Private Sub Savemenustrip()
        Activation_panel.Visible = False
        Record_Panel.Visible = False
        DeletePanel.Visible = False
        RegistrationPanel.Visible = False
        FILEToolStripMenuItem.Visible = False
        SaveUpdated_Panel.Visible = True
    End Sub

    Private Sub DeleteProfile()
        DeletePanel.Visible = True
        Activation_panel.Visible = False
        Record_Panel.Visible = False
        RegistrationPanel.Visible = False
        FILEToolStripMenuItem.Visible = False
        SaveUpdated_Panel.Visible = False
    End Sub

    Private Sub clear()
        fullname_txt.Text = Nothing
        email_txt.Text = Nothing
        phoneno_txt.Text = Nothing
        profile_id.Text = Nothing
        passport.Image = Nothing
    End Sub



End Class



