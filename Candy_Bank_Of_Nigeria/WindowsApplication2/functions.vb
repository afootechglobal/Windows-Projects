Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D

Module functions
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Function connection()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=bank_app_db")
        Return conn
    End Function

    Public Function ApplyBlur(ByVal image As Image, ByVal blurAmount As Integer) As Image
        Dim blurredImage As New Bitmap(image.Width, image.Height)
        Using g As Graphics = Graphics.FromImage(blurredImage)
            g.SmoothingMode = SmoothingMode.HighQuality
            g.InterpolationMode = InterpolationMode.High
            g.PixelOffsetMode = PixelOffsetMode.HighQuality
            Dim blurRect As New Rectangle(0, 0, image.Width, image.Height)
            g.DrawImage(image, blurRect, blurRect, GraphicsUnit.Pixel)
        End Using
        Return blurredImage
    End Function

    Function countId(ByVal counter_id As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("UPDATE counters_tab SET counter_value=counter_value+1 WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        connection.Close()

        connection.Open()
        command = New MySqlCommand("SELECT counter_value FROM counters_tab WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        reader.Read()
        Dim counter_value = reader("counter_value")
        connection.Close()
        Return counter_value
    End Function

    Function selectPassport(ByVal passport)
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            passport.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
        Return passport
    End Function

    Public Function validateEmail(ByVal emailAddress As String) As Boolean
        Dim email As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function emailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM staff_tab WHERE email_address=@email_address", connection)
        command.Parameters.AddWithValue("@email_address", email)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Public Function vetEmail() As Boolean

        Try
            Dim connection = functions.connection
            Dim userCount As Integer

            connection.Open()
            command = New MySqlCommand("SELECT * FROM staff_tab WHERE email_address=@email_address", connection)
            command.Parameters.AddWithValue("@email_address", adminrecord.email_address_txt.Text)
            userCount = Convert.ToInt32(command.ExecuteScalar())
            connection.Close()

            If (userCount > 0) Then
                MessageBox.Show("Email Address already exists. Please enter a new one.", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If

            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Check Email Failed: " & ex.Message, "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Function customerEmailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM customer_tab WHERE email_address=@email_address", connection)
        command.Parameters.AddWithValue("@email_address", email)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Function updateEmailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM staff_tab WHERE email_address=@email_address AND staff_id!=@staff_id", connection)
        command.Parameters.AddWithValue("@email_address", email)
        command.Parameters.AddWithValue("@staff_id", adminrecord.profile_id.SelectedValue)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Function customerUpdateEmailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM customer_tab WHERE email_address=@email_address AND customer_id!=@customer_id", connection)
        command.Parameters.AddWithValue("@email_address", email)
        command.Parameters.AddWithValue("@customer_id", customerrecordform.profile_id.SelectedValue)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Public Sub goToAdminPortal()
        'overlay.Close()
        'index.Hide()
        adminlogin.Hide()
        adminlogin.email_address_txt.Text = Nothing
        adminlogin.password_txt.Text = Nothing
        adminportal.Show()
    End Sub

    Public Sub goToUserPortal()
        'overlay.Close()
        'index.Hide()
        userlogin.Hide()
        userlogin.email_address_txt.Text = Nothing
        userlogin.password_txt.Text = Nothing
        userportal.Show()
    End Sub

    Public Sub clearFunction()
        adminrecord.full_name_txt.Text = Nothing
        adminrecord.email_address_txt.Text = Nothing
        adminrecord.phone_number_txt.Text = Nothing
        adminrecord.profile_id.Text = "SELECT STAFF....."
        adminrecord.admin_profile_pic.Image = Nothing

        customerrecordform.full_name_txt.Text = Nothing
        customerrecordform.email_address_txt.Text = Nothing
        customerrecordform.phone_number_txt.Text = Nothing
        customerrecordform.profile_id.Text = "SELECT CUSTOMER....."
        customerrecordform.customer_profile_pic.Image = Nothing

        viewloan.full_name_txt.Text = Nothing
        viewloan.email_address_txt.Text = Nothing
        viewloan.phone_number_txt.Text = Nothing
        viewloan.profile_id.Text = "SELECT CUSTOMER....."
        viewloan.loan_amount_txt.Text = Nothing
        viewloan.loan_duration_txt.Text = Nothing
        viewloan.loan_id_txt.Text = Nothing
        viewloan.loan_details_pic_box.Image = Nothing
    End Sub

    Public Sub loanClearFunction()
        userloanrequestform.loanAmount_txt.Text = Nothing
        userloanrequestform.loan_duration.Text = Nothing
    End Sub

    Function getStaffProfile(ByVal staff_id As String)
        Dim connection = functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT * FROM staff_tab WHERE staff_id=@staff_id", connection)
        command.Parameters.AddWithValue("@staff_id", staff_id)
        reader = command.ExecuteReader
        reader.Read()

        Dim fullname = reader("fullname")
        Dim last_login = reader("last_login")
        Dim arrimage() As Byte = reader("passport")
        connection.close()
        Return Tuple.Create(fullname, last_login, arrimage)
    End Function

    Function getCustomerProfile(ByVal customer_id As String)
        Dim connection = functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT a.*, FORMAT(b.account_balance, 2) AS formatted_account_balance, FORMAT(b.loan_balance, 2) AS formatted_loan_balance FROM customer_tab a, account_tab b WHERE a.customer_id=b.customer_id AND a.customer_id=@customer_id", connection)
        command.Parameters.AddWithValue("@customer_id", customer_id)
        reader = command.ExecuteReader
        reader.Read()

        Dim fullname = reader("fullname")
        Dim last_login = reader("last_login")
        Dim account_balance = reader("formatted_account_balance")
        Dim loan_balance = reader("formatted_loan_balance")
        Dim arrimage() As Byte = reader("passport")
        Dim password = reader("password")
        connection.close()
        Return Tuple.Create(fullname, last_login, account_balance, loan_balance, arrimage, password)
    End Function

    Public Sub getStaffID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT a.* FROM staff_tab a WHERE a.role_id<@login_role_id", connection)
        command.Parameters.AddWithValue("@login_role_id", adminlogin.login_role_id)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("staff_id") = ""
        defaultRow("role_id") = 0
        defaultRow("status_id") = 0
        defaultRow("fullname") = "SELECT STAFF....."
        defaultRow("email_address") = ""
        defaultRow("phone_number") = ""
        defaultRow("password") = ""
        defaultRow("created_time") = Now.ToString
        defaultRow("updated_time") = Now.ToString
        defaultRow("otp") = 0
        DT.Rows.InsertAt(defaultRow, 0)

        adminrecord.profile_id.DataSource = DT
        adminrecord.profile_id.DisplayMember = "fullname"
        adminrecord.profile_id.ValueMember = "staff_id"
    End Sub

    Public Sub getCustomerID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT a.*, b.status_name, c.gender_name FROM customer_tab a, setup_status_tab b, setup_gender_tab c WHERE a.status_id=b.status_id AND a.gender_id=c.gender_id;", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("customer_id") = ""
        defaultRow("staff_id") = ""
        defaultRow("status_id") = 0
        defaultRow("gender_id") = 0
        defaultRow("fullname") = "SELECT CUSTOMER....."
        defaultRow("staff_fullname") = ""
        defaultRow("email_address") = ""
        defaultRow("phone_number") = ""
        defaultRow("password") = ""
        defaultRow("created_time") = Now.ToString
        defaultRow("updated_time") = Now.ToString
        defaultRow("otp") = 0
        defaultRow("status_name") = ""
        defaultRow("gender_name") = ""
        DT.Rows.InsertAt(defaultRow, 0)

        customerrecordform.profile_id.DataSource = DT
        customerrecordform.profile_id.DisplayMember = "fullname"
        customerrecordform.profile_id.ValueMember = "customer_id"

        depositform.profile_id.DataSource = DT
        depositform.profile_id.DisplayMember = "fullname"
        depositform.profile_id.ValueMember = "customer_id"

        withdrawform.profile_id.DataSource = DT
        withdrawform.profile_id.DisplayMember = "fullname"
        withdrawform.profile_id.ValueMember = "customer_id"
    End Sub

    Public Sub getRole()
        Dim DT As New DataTable
        Dim connection = functions.connection

        If adminlogin.login_role_id = 3 Then
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_role_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()
        ElseIf adminlogin.login_role_id = 2 Then
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_role_tab WHERE role_id IN(1, 2);", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()
        Else
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_role_tab WHERE role_id IN(1);", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()
        End If

        adminrecord.staff_role_id_combobox.DataSource = DT
        adminrecord.staff_role_id_combobox.DisplayMember = "role_name"
        adminrecord.staff_role_id_combobox.ValueMember = "role_id"
    End Sub

    Function getStatus(ByVal combo As Object)
        Dim DT As New DataTable
        Dim connection = functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT * FROM setup_status_tab;", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()
        combo.DataSource = DT
        combo.DisplayMember = "status_name"
        combo.ValueMember = "status_id"
        Return combo
    End Function

    Public Sub getGender()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM setup_gender_tab;", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        customerrecordform.customer_gender_combobox.DataSource = DT
        customerrecordform.customer_gender_combobox.DisplayMember = "gender_name"
        customerrecordform.customer_gender_combobox.ValueMember = "gender_id"
    End Sub

    Function passportSave(ByVal passportBox)
        Dim arrimage() As Byte
        Dim msstream As New System.IO.MemoryStream()
        passportBox.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        Return arrimage
    End Function

    Public Sub staffRegistration()
        If adminlogin.login_role_id > 1 Then
            Try
                Dim passport = functions.passportSave(adminrecord.admin_profile_pic)
                Dim staff_id = "STF" & Now.ToString("yyyyMMddss") & functions.countId("STF")

                Dim connection = functions.connection
                connection.open()

                query = "INSERT INTO staff_tab (`staff_id`, `role_id`, `status_id`, `fullname`, `email_address`, `phone_number`, `passport`, `password`, `created_time`) VALUES (@staff_id, @role_id, @status_id, @fullname, @email_address, @phone_number, @passport, @password, NOW())"
                Dim Command As New MySqlCommand(query, connection)
                Command.Parameters.AddWithValue("@staff_id", staff_id)
                Command.Parameters.AddWithValue("@role_id", adminrecord.staff_role_id_combobox.SelectedValue)
                Command.Parameters.AddWithValue("@status_id", adminrecord.staff_Status_id_Combobox.SelectedValue)
                Command.Parameters.AddWithValue("@fullname", adminrecord.full_name_txt.Text.ToUpper())
                Command.Parameters.AddWithValue("@email_address", adminrecord.email_address_txt.Text)
                Command.Parameters.AddWithValue("@phone_number", adminrecord.phone_number_txt.Text)
                Command.Parameters.AddWithValue("@passport", passport)
                Command.Parameters.AddWithValue("@password", staff_id)

                reader = command.ExecuteReader
                connection.Close()

                MessageBox.Show("WELCOME! Staff Registration Successfully Saved", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                functions.clearFunction()
                functions.getStaffID()
                functions.staffRecord()

            Catch ex As Exception

                MessageBox.Show("Staff Registration failed: " & ex.Message, "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub customerRegistration()
        Try
            Dim result = functions.getStaffProfile(adminlogin.login_staff_id)

            Dim staff_fullname = result.item1.ToString
            Dim staff_id = adminlogin.login_staff_id

            Dim customer_id = "CUST" & Now.ToString("yyyyMMddss") & functions.countId("CUST")
            Dim account_id = "ACCT" & Now.ToString("yyyyMMddss") & functions.countId("ACCT")

            Dim passport = functions.passportSave(customerrecordform.customer_profile_pic)
            Dim connection = functions.connection

            connection.open()
            query = "INSERT INTO `customer_tab`(`customer_id`, `status_id`, `gender_id`, `staff_id`, `staff_fullname`, `fullname`, `email_address`, `phone_number`, `passport`, `password`, `created_time`) VALUES(@customer_id, @status_id, @gender_id, @staff_id, @staff_fullname, @fullname, @email_address, @phone_number, @passport, @password, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            command.Parameters.AddWithValue("@status_id", customerrecordform.customer_status_id_combobox.SelectedValue)
            command.Parameters.AddWithValue("@gender_id", customerrecordform.customer_gender_combobox.SelectedValue)
            command.Parameters.AddWithValue("@staff_id", staff_id)
            command.Parameters.AddWithValue("@staff_fullname", staff_fullname)
            command.Parameters.AddWithValue("@fullname", customerrecordform.full_name_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@email_address", customerrecordform.email_address_txt.Text)
            command.Parameters.AddWithValue("@phone_number", customerrecordform.phone_number_txt.Text)
            command.Parameters.AddWithValue("@passport", passport)
            command.Parameters.AddWithValue("@password", customer_id)

            reader = command.ExecuteReader
            connection.Close()

            connection.open()
            query = "INSERT INTO `account_tab`(`account_id`, `customer_id`, `account_balance`, `loan_balance`, `created_time`) VALUES(@account_id, @customer_id, 00.0, 00.0, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@account_id", account_id)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            reader = command.ExecuteReader
            connection.Close()

            MessageBox.Show("SUCCESS! Customer Registration Successfully Saved", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Information)
            functions.clearFunction()
            functions.getCustomerID()
            functions.customerRecord()

        Catch ex As Exception
            MessageBox.Show("Customer Registration failed: " & ex.Message, "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub UpdateStaff()
        If adminlogin.login_role_id > 1 Then
            Try
                Dim passport = functions.passportSave(adminrecord.admin_profile_pic)
                Dim connection = functions.connection

                connection.open()
                query = "UPDATE staff_tab SET fullname=@fullname, role_id=@role_id, status_id=@status_id, email_address=@email_address, phone_number=@phone_number, passport=@passport WHERE staff_id=@staff_id"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@staff_id", adminrecord.profile_id.SelectedValue)
                command.Parameters.AddWithValue("@role_id", adminrecord.staff_role_id_combobox.SelectedValue)
                command.Parameters.AddWithValue("@status_id", adminrecord.staff_Status_id_Combobox.SelectedValue)
                command.Parameters.AddWithValue("@fullname", adminrecord.full_name_txt.Text.ToUpper)
                command.Parameters.AddWithValue("@email_address", adminrecord.email_address_txt.Text)
                command.Parameters.AddWithValue("@phone_number", adminrecord.phone_number_txt.Text)
                command.Parameters.AddWithValue("@passport", passport)

                reader = command.ExecuteReader
                connection.Close()

                MessageBox.Show("SUCCESS! Staff Updated Successfully", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                functions.getStaffID()
                functions.staffRecord()

            Catch ex As Exception
                MessageBox.Show("Staff update Unsuccessful: " & ex.Message, "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub UpdateCustomer()
        Try
            Dim passport = functions.passportSave(customerrecordform.customer_profile_pic)
            Dim connection = functions.connection

            connection.open()
            query = "UPDATE customer_tab SET fullname=@fullname, gender_id=@gender_id, status_id=@status_id, email_address=@email_address, phone_number=@phone_number, passport=@passport WHERE customer_id=@customer_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_id", customerrecordform.profile_id.SelectedValue)
            command.Parameters.AddWithValue("@gender_id", customerrecordform.customer_gender_combobox.SelectedValue)
            command.Parameters.AddWithValue("@status_id", customerrecordform.customer_status_id_combobox.SelectedValue)
            command.Parameters.AddWithValue("@fullname", customerrecordform.full_name_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@email_address", customerrecordform.email_address_txt.Text)
            command.Parameters.AddWithValue("@phone_number", customerrecordform.phone_number_txt.Text)
            command.Parameters.AddWithValue("@passport", passport)
            reader = command.ExecuteReader
            connection.Close()

            MessageBox.Show("SUCCESS! Customer Updated Successfully", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Information)
            functions.getCustomerID()
            functions.customerRecord()

        Catch ex As Exception
            MessageBox.Show("Customer update Unsuccessful: " & ex.Message, "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub staffRecord()
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = functions.connection
            Dim command As New MySqlCommand("SELECT a.*, b.status_name, c.role_name FROM staff_tab a, setup_status_tab b, setup_role_tab c WHERE a.status_id = b.status_id AND a.role_id = c.role_id AND a.role_id < @login_role_id;", connection)
            command.Parameters.AddWithValue("@login_role_id", adminlogin.login_role_id)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            adminviewrecord.staff_record_list.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("staff_id").ToString())
                listItem.SubItems.Add(row("fullname").ToString())
                listItem.SubItems.Add(row("email_address").ToString())
                listItem.SubItems.Add(row("phone_number").ToString())
                listItem.SubItems.Add(row("role_name").ToString())
                listItem.SubItems.Add(row("status_name").ToString())
                listItem.SubItems.Add(row("passport").ToString())
                listItem.SubItems.Add(row("created_time").ToString())
                listItem.SubItems.Add(row("updated_time").ToString())
                listItem.SubItems.Add(row("last_login").ToString())

                adminviewrecord.staff_record_list.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub customerRecord()
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = functions.connection
            Dim command As New MySqlCommand("SELECT CONCAT(a.staff_id, ' / ', a.staff_fullname) AS registered_by, a.*, b.status_name, FORMAT(c.account_balance, 2) AS formatted_account_balance, FORMAT(c.loan_balance, 2) AS formatted_loan_balance, d.gender_name FROM customer_tab a, setup_status_tab b, account_tab c, setup_gender_tab d WHERE a.status_id=b.status_id AND a.customer_id=c.customer_id AND a.gender_id=d.gender_id;", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            customerviewrecord.customer_record_list.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("customer_id").ToString())
                listItem.SubItems.Add(row("fullname").ToString())
                listItem.SubItems.Add(row("email_address").ToString())
                listItem.SubItems.Add(row("phone_number").ToString())
                listItem.SubItems.Add(row("formatted_loan_balance").ToString())
                listItem.SubItems.Add(row("passport").ToString())
                listItem.SubItems.Add(row("registered_by").ToString())
                listItem.SubItems.Add(row("created_time").ToString())
                listItem.SubItems.Add(row("formatted_account_balance").ToString())
                listItem.SubItems.Add(row("last_login").ToString())
                listItem.SubItems.Add(row("updated_time").ToString())
                listItem.SubItems.Add(row("gender_name").ToString())
                listItem.SubItems.Add(row("status_name").ToString())

                customerviewrecord.customer_record_list.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function customerLoanSchedule(ByVal customer_id As String, ByVal listview As Object)
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = functions.connection
            Dim command As New MySqlCommand("SELECT a.*, b.month, FORMAT(b.loan_balance, 2) as formatted_loan_balance, FORMAT(b.sub_payment, 2) as formatted_sub_payment, FORMAT(b.interest, 2) as formatted_interest, FORMAT(b.total_repayment, 2) as formatted_total_repayment FROM customer_loan_transaction_tab a, loan_request_tab b WHERE a.transaction_id=b.transaction_id AND a.customer_id=@customer_id;", connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            listview.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("transaction_id").ToString())
                listItem.SubItems.Add(row("month").ToString())
                listItem.SubItems.Add(row("formatted_loan_balance").ToString())
                listItem.SubItems.Add(row("formatted_sub_payment").ToString())
                listItem.SubItems.Add(row("formatted_interest").ToString())
                listItem.SubItems.Add(row("formatted_total_repayment").ToString())
                listItem.SubItems.Add(row("created_time").ToString())

                listview.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return listview
    End Function

    Function system_settings()
        Dim connection = functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT * FROM system_settings_tab", connection)
        reader = command.ExecuteReader
        reader.Read()
        Dim minimum_balance = reader("minimum_balance")
        Dim maximum_loan = reader("maximum_loan")
        Dim minimum_loan = reader("minimum_loan")
        Dim maximum_duration = reader("maximum_duration")
        Dim loan_rate = reader("loan_rate")
        connection.close()
        Return Tuple.Create(minimum_balance, maximum_loan, minimum_loan, maximum_duration, loan_rate)
    End Function

    Public Sub getCustomerLoanID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT a.*, b.* FROM customer_tab a, customer_loan_transaction_tab b WHERE a.customer_id=b.customer_id;", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("customer_id") = ""
        defaultRow("customer_id1") = ""
        defaultRow("staff_id") = ""
        defaultRow("status_id") = 0
        defaultRow("gender_id") = 0
        defaultRow("loan_rate") = 0
        defaultRow("fullname") = "SELECT CUSTOMER....."
        defaultRow("staff_fullname") = ""
        defaultRow("email_address") = ""
        defaultRow("phone_number") = ""
        defaultRow("password") = ""
        defaultRow("otp") = 0
        defaultRow("customer_id") = ""
        defaultRow("transaction_id") = ""
        defaultRow("loan_amount") = 0
        defaultRow("loan_duration") = 0
        defaultRow("created_time") = Now.ToString
        defaultRow("created_time1") = Now.ToString
        defaultRow("updated_time") = Now.ToString
        DT.Rows.InsertAt(defaultRow, 0)

        viewloan.profile_id.DataSource = DT
        viewloan.profile_id.DisplayMember = "fullname"
        viewloan.profile_id.ValueMember = "customer_id"
    End Sub

    Function alphaCheck(ByVal e)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field allows only Letters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return e
    End Function

    Function numCheck(ByVal e)
        If Not Char.IsDigit(e.KeyChar) AndAlso
         Not Char.IsWhiteSpace(e.KeyChar) AndAlso
         Not Char.IsControl(e.KeyChar) AndAlso
         e.KeyChar <> "+"c AndAlso
         e.KeyChar <> "-"c AndAlso
         e.KeyChar <> "("c AndAlso
         e.KeyChar <> ")"c Then
            e.Handled = True
            MessageBox.Show("This field allows only numbers(+, -, (, ))!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return e
    End Function

    Function numTextCheck(ByVal e)
        If Not Char.IsDigit(e.KeyChar) AndAlso
         Not Char.IsWhiteSpace(e.KeyChar) AndAlso
         Not Char.IsControl(e.KeyChar) AndAlso
         e.KeyChar <> "."c AndAlso
         e.KeyChar <> ","c Then
            e.Handled = True
            MessageBox.Show("This field allows only numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return e
    End Function

    Function deposit(ByVal deposit_txt As Double, ByVal customer_id As String, ByVal transaction_type As Integer)
        Try
            Dim connection = functions.connection
            Dim transaction_id = "TRANS" & Now.ToString("yyyyMMddss") & functions.countId("TRANS")

            Dim result = functions.getCustomerProfile(customer_id)
            Dim balance_before As Double = result.item3.ToString
            Dim balance_after = balance_before + deposit_txt

            connection.open()
            query = "INSERT INTO `customer_deposit_transaction_tab`(`customer_id`, `transaction_id`, `balance_before`, `deposit_amount`, `balance_after`, `transaction_type_id`, `created_time`) VALUES (@customer_id, @transaction_id, @balance_before, @deposit_amount, @balance_after, @transaction_type, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            command.Parameters.AddWithValue("@transaction_id", transaction_id)
            command.Parameters.AddWithValue("@balance_before", balance_before)
            command.Parameters.AddWithValue("@deposit_amount", deposit_txt)
            command.Parameters.AddWithValue("@balance_after", balance_after)
            command.Parameters.AddWithValue("@transaction_type", transaction_type)
            reader = command.ExecuteReader
            connection.close()

            connection.open()
            query = "UPDATE account_tab SET account_balance=@balance_after WHERE customer_id=@customer_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            command.Parameters.AddWithValue("@balance_after", balance_after)
            reader = command.ExecuteReader
            connection.close()
            MessageBox.Show("SUCCESS! Deposit has been submitted successfully", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Information)

            functions.allCounts()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Tuple.Create(deposit_txt, customer_id, transaction_type)
    End Function

    Function withdrawal(ByVal withdraw_txt As Double, ByVal customer_id As String, ByVal transaction_type As Integer)
        Try
            Dim connection = functions.connection
            Dim transaction_id = "TRANS" & Now.ToString("yyyyMMddss") & functions.countId("TRANS")

            Dim result = functions.getCustomerProfile(customer_id)
            Dim balance_before As Double = result.item3.ToString
            Dim balance_after = balance_before - withdraw_txt

            connection.open()
            query = "INSERT INTO `customer_deposit_transaction_tab`(`customer_id`, `transaction_id`, `balance_before`, `withdraw_amount`, `balance_after`, `transaction_type_id`, `created_time`) VALUES (@customer_id, @transaction_id, @balance_before, @withdraw_amount, @balance_after, @transaction_type, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            command.Parameters.AddWithValue("@transaction_id", transaction_id)
            command.Parameters.AddWithValue("@balance_before", balance_before)
            command.Parameters.AddWithValue("@withdraw_amount", withdraw_txt)
            command.Parameters.AddWithValue("@balance_after", balance_after)
            command.Parameters.AddWithValue("@transaction_type", transaction_type)
            reader = command.ExecuteReader
            connection.close()

            connection.open()
            query = "UPDATE account_tab SET account_balance=@balance_after WHERE customer_id=@customer_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            command.Parameters.AddWithValue("@balance_after", balance_after)
            reader = command.ExecuteReader
            connection.close()
            MessageBox.Show("SUCCESS! Withdrwawl has been submitted successfully", "Candy Bank Of Nigeria", MessageBoxButtons.OK, MessageBoxIcon.Information)

            functions.allCounts()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Tuple.Create(withdraw_txt, customer_id, transaction_type)
    End Function

    Function customerDepositTransaction(ByVal customer_id As String, ByVal listview_form As Object)
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = functions.connection
            Dim command As New MySqlCommand("SELECT a.transaction_id, a.created_time, FORMAT(a.balance_before, 2) AS formatted_balance_before, FORMAT(a.deposit_amount, 2) AS formatted_deposit_amount, FORMAT(a.withdraw_amount, 2) AS formatted_withdraw_amount, FORMAT(a.balance_after, 2) AS formatted_balance_after, b.fullname, b.customer_id, c.transaction_type_name FROM customer_deposit_transaction_tab a, customer_tab b, setup_transaction_type_tab c WHERE a.customer_id=b.customer_id AND a.transaction_type_id=c.transaction_type_id AND a.customer_id=@customer_id;", connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            listview_form.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("customer_id").ToString())
                listItem.SubItems.Add(row("transaction_id").ToString())
                listItem.SubItems.Add(row("fullname").ToString())
                listItem.SubItems.Add(row("formatted_balance_before").ToString())
                listItem.SubItems.Add(row("formatted_deposit_amount").ToString())
                listItem.SubItems.Add(row("formatted_withdraw_amount").ToString())
                listItem.SubItems.Add(row("formatted_balance_after").ToString())
                listItem.SubItems.Add(row("transaction_type_name").ToString())
                listItem.SubItems.Add(row("created_time").ToString())

                listview_form.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return listview_form
    End Function

    Function allCounts()
        Dim connection = functions.connection
        connection.open()
        query = "SELECT (SELECT COUNT(*) FROM staff_tab) AS total_staff, (SELECT COUNT(*) FROM customer_tab) AS total_customer, (SELECT SUM(loan_balance) FROM account_tab) AS total_loan, (SELECT SUM(account_balance) FROM account_tab) AS total_balance, (SELECT COUNT(*) FROM customer_loan_transaction_tab) AS total_customer_loan, (SELECT COUNT(*) FROM customer_deposit_transaction_tab) AS total_transaction;"
        command = New MySqlCommand(query, connection)
        reader = command.ExecuteReader
        reader.Read()
        Dim total_staff = reader("total_staff")
        Dim total_customer = reader("total_customer")
        Dim total_loan = Convert.ToDouble(reader("total_loan")).ToString("N2")
        Dim total_balance = Convert.ToDouble(reader("total_balance")).ToString("N2")
        Dim total_customer_loan = reader("total_customer_loan")
        Dim total_transaction = reader("total_transaction")
        Return Tuple.Create(total_staff, total_customer, total_loan, total_balance, total_customer_loan, total_transaction)
    End Function


End Module
