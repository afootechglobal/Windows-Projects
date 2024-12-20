Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.IO

Module myfunctions
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Function connection()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=bankproject_db")
        Return conn
    End Function

    Function countId(ByVal mast_count_id As String)
        Dim connection = myfunctions.connection

        connection.Open()
        command = New MySqlCommand("UPDATE master_count_tab SET mast_count_value=mast_count_value+1 WHERE mast_count_id=@mast_count_id", connection)
        command.Parameters.AddWithValue("@mast_count_id", mast_count_id)
        reader = command.ExecuteReader
        connection.Close()

        connection.Open()
        command = New MySqlCommand("SELECT mast_count_value FROM master_count_tab WHERE mast_count_id=@mast_count_id", connection)
        command.Parameters.AddWithValue("@mast_count_id", mast_count_id)
        reader = command.ExecuteReader
        reader.Read()
        Dim counter_value = reader("mast_count_value")
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

    Function emailValidate(ByVal email_address As String) As Boolean
        Dim email As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        If email.IsMatch(email_address) Then
            Return True
        End If
        Return False
    End Function

    Function emailCheck(ByVal email As String)
        Dim connection = myfunctions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM staff_tab WHERE email=@email", connection)
        command.Parameters.AddWithValue("@email", email)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Function customerEmailCheck(ByVal email As String)
        Dim connection = myfunctions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM customer_tab WHERE email=@email", connection)
        command.Parameters.AddWithValue("@email", email)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Function updateEmailCheck(ByVal email As String)
        Dim connection = myfunctions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM staff_tab WHERE email=@email AND staff_id!=@staff_id", connection)
        command.Parameters.AddWithValue("@email", email)
        command.Parameters.AddWithValue("@staff_id", admin_form.profile_id.SelectedValue)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Function customerUpdateEmailCheck(ByVal email As String)
        Dim connection = myfunctions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM customer_tab WHERE email=@email AND customer_id!=@customer_id", connection)
        command.Parameters.AddWithValue("@email", email)
        command.Parameters.AddWithValue("@customer_id", view_customer_form.profile_id.SelectedValue)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Public Sub directToDashboard()
        overlay.Close()
        index_form.Hide()
        adminlogin_form.Hide()
        adminlogin_form.email_txt.Text = ""
        adminlogin_form.password_txt.Text = ""
        admin_dashboard.Show()
    End Sub

    Public Sub directToUserDashboard()
        userlogin_form.Hide()
        overlay.Close()
        index_form.Hide()
        userlogin_form.email_txt.Text = ""
        userlogin_form.password_txt.Text = ""
        user_dashboard.Show()
    End Sub

    Public Sub clearFunction()
        admin_form.fullname_txt.Text = ""
        admin_form.email_txt.Text = ""
        admin_form.mobile_txt.Text = ""
        admin_form.profile_id.Text = "SELECT STAFF"
        admin_form.AdminPictureBox.Image = Nothing

        view_customer_form.fullname_txt.Text = ""
        view_customer_form.email_txt.Text = ""
        view_customer_form.mobile_txt.Text = ""
        view_customer_form.CustomerPictureBox.Image = Nothing
        view_customer_form.profile_id.Text = "SELECT CUSTOMER"
    End Sub

    Public Sub loanClearFunction()
        loan_request_form.loanAmount_txt.Text = ""
        loan_request_form.loan_duration.Text = ""
    End Sub

    Function getStaffProfile(ByVal staff_id As String)
        Dim connection = myfunctions.connection
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
        Dim connection = myfunctions.connection
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
        Dim connection = myfunctions.connection

        connection.Open()
        command = New MySqlCommand("SELECT a.* FROM staff_tab a WHERE a.role_id<@login_role_id", connection)
        command.Parameters.AddWithValue("@login_role_id", adminlogin_form.login_role_id)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("staff_id") = ""
        defaultRow("role_id") = 0
        defaultRow("status_id") = 0
        defaultRow("fullname") = "SELECT STAFF"
        defaultRow("email") = ""
        defaultRow("mobile") = ""
        defaultRow("password") = ""
        defaultRow("otp") = 0
        DT.Rows.InsertAt(defaultRow, 0)

        admin_form.profile_id.DataSource = DT
        admin_form.profile_id.DisplayMember = "fullname"
        admin_form.profile_id.ValueMember = "staff_id"
    End Sub

    Public Sub getCustomerID()
        Dim DT As New DataTable
        Dim connection = myfunctions.connection

        connection.Open()
        command = New MySqlCommand("SELECT a.*, b.status_name, c.gender_name FROM customer_tab a, setup_status_tab b, setup_gender_tab c WHERE a.status_id=b.status_id AND a.gender_id=c.gender_id;", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("customer_id") = ""
        defaultRow("staff_id") = ""
        defaultRow("status_id") = 0
        defaultRow("gender_id") = 0
        defaultRow("fullname") = "SELECT CUSTOMER"
        defaultRow("staff_fullname") = ""
        defaultRow("email") = ""
        defaultRow("mobile") = ""
        defaultRow("password") = ""
        defaultRow("otp") = 0
        defaultRow("status_name") = ""
        defaultRow("gender_name") = ""
        DT.Rows.InsertAt(defaultRow, 0)

        view_customer_form.profile_id.DataSource = DT
        view_customer_form.profile_id.DisplayMember = "fullname"
        view_customer_form.profile_id.ValueMember = "customer_id"

        deposit_form.profile_id.DataSource = DT
        deposit_form.profile_id.DisplayMember = "fullname"
        deposit_form.profile_id.ValueMember = "customer_id"
    End Sub

    Public Sub getRole()
        Dim DT As New DataTable
        Dim connection = myfunctions.connection

        If adminlogin_form.login_role_id = 3 Then
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_role_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()
        ElseIf adminlogin_form.login_role_id = 2 Then
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

        admin_form.RoleComboBox.DataSource = DT
        admin_form.RoleComboBox.DisplayMember = "role_name"
        admin_form.RoleComboBox.ValueMember = "role_id"
    End Sub

    Function getStatus(ByVal combo)
        Dim DT As New DataTable
        Dim connection = myfunctions.connection
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
        Dim connection = myfunctions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM setup_gender_tab;", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        view_customer_form.genderComboBox.DataSource = DT
        view_customer_form.genderComboBox.DisplayMember = "gender_name"
        view_customer_form.genderComboBox.ValueMember = "gender_id"
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
        If adminlogin_form.login_role_id > 1 Then
            Try
                Dim staff_id = "STF" & Now.ToString("yyyyMMddss") & myfunctions.countId("STF")
                Dim passport = myfunctions.passportSave(admin_form.AdminPictureBox)
                Dim connection = myfunctions.connection

                connection.open()
                query = "INSERT INTO `staff_tab`(`staff_id`, `role_id`, `status_id`, `fullname`, `email`, `mobile`, `passport`, `password`, `created_at`) VALUES (@staff_id, @role_id, @status_id, @fullname, @email, @mobile, @passport, @password, NOW())"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@staff_id", staff_id)
                command.Parameters.AddWithValue("@role_id", admin_form.RoleComboBox.SelectedValue)
                command.Parameters.AddWithValue("@status_id", admin_form.StatusComboBox.SelectedValue)
                command.Parameters.AddWithValue("@fullname", admin_form.fullname_txt.Text.ToUpper)
                command.Parameters.AddWithValue("@email", admin_form.email_txt.Text)
                command.Parameters.AddWithValue("@mobile", admin_form.mobile_txt.Text)
                command.Parameters.AddWithValue("@passport", passport)
                command.Parameters.AddWithValue("@password", staff_id)
                reader = command.ExecuteReader
                connection.Close()
                MessageBox.Show("SUCCESS! Staff Registration Successfully Saved", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myfunctions.clearFunction()
                myfunctions.getStaffID()
                myfunctions.staffRecord()
            Catch ex As Exception
                MsgBox("Registration failed: " & ex.Message)
            End Try
        End If
    End Sub

    Public Sub customerRegistration()
        Try
            Dim result = myfunctions.getStaffProfile(adminlogin_form.login_staff_id)

            Dim staff_fullname = result.item1.ToString
            Dim staff_id = adminlogin_form.login_staff_id

            Dim customer_id = "CUST" & Now.ToString("yyyyMMddss") & myfunctions.countId("CUST")
            Dim account_id = "ACT" & Now.ToString("yyyyMMddss") & myfunctions.countId("ACT")
            Dim passport = myfunctions.passportSave(view_customer_form.CustomerPictureBox)
            Dim connection = myfunctions.connection

            connection.open()
            query = "INSERT INTO `customer_tab`(`customer_id`, `status_id`, `gender_id`, `staff_id`, `staff_fullname`, `fullname`, `email`, `mobile`, `passport`, `password`, `created_at`) VALUES(@customer_id, @status_id, @gender_id, @staff_id, @staff_fullname, @fullname, @email, @mobile, @passport, @password, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            command.Parameters.AddWithValue("@status_id", view_customer_form.StatusComboBox.SelectedValue)
            command.Parameters.AddWithValue("@gender_id", view_customer_form.genderComboBox.SelectedValue)
            command.Parameters.AddWithValue("@staff_id", staff_id)
            command.Parameters.AddWithValue("@staff_fullname", staff_fullname)
            command.Parameters.AddWithValue("@fullname", view_customer_form.fullname_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@email", view_customer_form.email_txt.Text)
            command.Parameters.AddWithValue("@mobile", view_customer_form.mobile_txt.Text)
            command.Parameters.AddWithValue("@passport", passport)
            command.Parameters.AddWithValue("@password", customer_id)
            reader = command.ExecuteReader
            connection.Close()

            connection.open()
            query = "INSERT INTO `account_tab`(`account_id`, `customer_id`, `account_balance`, `loan_balance`, `created_at`) VALUES(@account_id, @customer_id, 00.0, 00.0, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@account_id", account_id)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            reader = command.ExecuteReader
            connection.Close()

            MessageBox.Show("SUCCESS! Customer Registration Successfully Saved", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myfunctions.clearFunction()
            myfunctions.getCustomerID()
            myfunctions.customerRecord()
        Catch ex As Exception
            MsgBox("Registration failed: " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateStaff()
        If adminlogin_form.login_role_id > 1 Then
            Try
                Dim passport = myfunctions.passportSave(admin_form.AdminPictureBox)
                Dim connection = myfunctions.connection

                connection.open()
                query = "UPDATE staff_tab SET fullname=@fullname, role_id=@role_id, status_id=@status_id, email=@email, mobile=@mobile, passport=@passport WHERE staff_id=@staff_id"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@staff_id", admin_form.profile_id.SelectedValue)
                command.Parameters.AddWithValue("@role_id", admin_form.RoleComboBox.SelectedValue)
                command.Parameters.AddWithValue("@status_id", admin_form.StatusComboBox.SelectedValue)
                command.Parameters.AddWithValue("@fullname", admin_form.fullname_txt.Text.ToUpper)
                command.Parameters.AddWithValue("@email", admin_form.email_txt.Text)
                command.Parameters.AddWithValue("@mobile", admin_form.mobile_txt.Text)
                command.Parameters.AddWithValue("@passport", passport)
                reader = command.ExecuteReader
                connection.Close()
                MessageBox.Show("SUCCESS! Staff Updated Successfully", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myfunctions.getStaffID()
                myfunctions.staffRecord()
            Catch ex As Exception
                MsgBox("User updated failed: " & ex.ToString)
            End Try
        End If
    End Sub

    Public Sub UpdateCustomer()
        Try
            Dim passport = myfunctions.passportSave(view_customer_form.CustomerPictureBox)
            Dim connection = myfunctions.connection

            connection.open()
            query = "UPDATE customer_tab SET fullname=@fullname, gender_id=@gender_id, status_id=@status_id, email=@email, mobile=@mobile, passport=@passport WHERE customer_id=@customer_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_id", view_customer_form.profile_id.SelectedValue)
            command.Parameters.AddWithValue("@gender_id", view_customer_form.genderComboBox.SelectedValue)
            command.Parameters.AddWithValue("@status_id", view_customer_form.StatusComboBox.SelectedValue)
            command.Parameters.AddWithValue("@fullname", view_customer_form.fullname_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@email", view_customer_form.email_txt.Text)
            command.Parameters.AddWithValue("@mobile", view_customer_form.mobile_txt.Text)
            command.Parameters.AddWithValue("@passport", passport)
            reader = command.ExecuteReader
            connection.Close()
            MessageBox.Show("SUCCESS! Customer Updated Successfully", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myfunctions.getCustomerID()
            myfunctions.customerRecord()
        Catch ex As Exception
            MsgBox("User updated failed: " & ex.ToString)
        End Try
    End Sub

    Public Sub customerRecord()
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = myfunctions.connection
            Dim command As New MySqlCommand("SELECT CONCAT(a.staff_id, ' / ', a.staff_fullname) AS registered_by, a.*, b.status_name, FORMAT(c.account_balance, 2) AS formatted_account_balance, FORMAT(c.loan_balance, 2) AS formatted_loan_balance, d.gender_name FROM customer_tab a, setup_status_tab b, account_tab c, setup_gender_tab d WHERE a.status_id=b.status_id AND a.customer_id=c.customer_id AND a.gender_id=d.gender_id;", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            customer_reg_form.userRecord.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("customer_id").ToString())
                listItem.SubItems.Add(row("fullname").ToString())
                listItem.SubItems.Add(row("email").ToString())
                listItem.SubItems.Add(row("mobile").ToString())
                listItem.SubItems.Add(row("formatted_loan_balance").ToString())
                listItem.SubItems.Add(row("passport").ToString())
                listItem.SubItems.Add(row("registered_by").ToString())
                listItem.SubItems.Add(row("created_at").ToString())
                listItem.SubItems.Add(row("formatted_account_balance").ToString())
                listItem.SubItems.Add(row("last_login").ToString())
                listItem.SubItems.Add(row("updated_at").ToString())
                listItem.SubItems.Add(row("gender_name").ToString())
                listItem.SubItems.Add(row("status_name").ToString())

                customer_reg_form.userRecord.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function customerLoanSchedule(ByVal customer_id As String, ByVal listview As Object)
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = myfunctions.connection
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
                listItem.SubItems.Add(row("created_at").ToString())

                listview.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return listview
    End Function

    Public Sub staffRecord()
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = myfunctions.connection
            Dim command As New MySqlCommand("SELECT a.*, b.status_name, c.role_name FROM staff_tab a, setup_status_tab b, setup_role_tab c WHERE a.status_id = b.status_id AND a.role_id = c.role_id AND a.role_id < @login_role_id;", connection)
            command.Parameters.AddWithValue("@login_role_id", adminlogin_form.login_role_id)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            admin_reg_form.staffRecord.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("staff_id").ToString())
                listItem.SubItems.Add(row("fullname").ToString())
                listItem.SubItems.Add(row("email").ToString())
                listItem.SubItems.Add(row("mobile").ToString())
                listItem.SubItems.Add(row("role_name").ToString())
                listItem.SubItems.Add(row("status_name").ToString())
                listItem.SubItems.Add(row("passport").ToString())
                listItem.SubItems.Add(row("created_at").ToString())
                listItem.SubItems.Add(row("updated_at").ToString())
                listItem.SubItems.Add(row("last_login").ToString())

                admin_reg_form.staffRecord.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function system_settings()
        Dim connection = myfunctions.connection
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
        Dim connection = myfunctions.connection

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
        defaultRow("fullname") = "SELECT CUSTOMER"
        defaultRow("staff_fullname") = ""
        defaultRow("email") = ""
        defaultRow("mobile") = ""
        defaultRow("password") = ""
        defaultRow("otp") = 0
        defaultRow("customer_id") = ""
        defaultRow("transaction_id") = ""
        defaultRow("loan_amount") = 0
        defaultRow("loan_duration") = 0
        defaultRow("created_at") = Now.ToString
        defaultRow("created_at1") = Now.ToString
        DT.Rows.InsertAt(defaultRow, 0)

        view_loan_form.profile_id.DataSource = DT
        view_loan_form.profile_id.DisplayMember = "fullname"
        view_loan_form.profile_id.ValueMember = "customer_id"
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
            MessageBox.Show("This field allows only numbers and valid mobile number symbols (+, -, (, ))!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return e
    End Function

    Function deposit(ByVal deposit_txt As Double, ByVal customer_id As String, ByVal transaction_type As Integer)
        Try
            Dim connection = myfunctions.connection
            Dim transaction_id = "TRN" & Now.ToString("yyyyMMddss") & myfunctions.countId("TRN")

            Dim result = myfunctions.getCustomerProfile(customer_id)
            Dim balance_before As Double = result.item3.ToString
            Dim balance_after = balance_before + deposit_txt

            connection.open()
            query = "INSERT INTO `customer_deposit_tab`(`customer_id`, `transaction_id`, `balance_before`, `deposit_amount`, `balance_after`, `transaction_type_id`, `created_at`) VALUES (@customer_id, @transaction_id, @balance_before, @deposit_amount, @balance_after, @transaction_type, NOW())"
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
            MessageBox.Show("SUCCESS! Deposit has been submitted successfully", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Tuple.Create(deposit_txt, customer_id, transaction_type)
    End Function

    Function customerDepositTransaction(ByVal customer_id As String, ByVal listview_form As Object)
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = myfunctions.connection
            Dim command As New MySqlCommand("SELECT a.transaction_id, a.created_at, FORMAT(a.balance_before, 2) AS formatted_balance_before, FORMAT(a.deposit_amount, 2) AS formatted_deposit_amount, FORMAT(a.balance_after, 2) AS formatted_balance_after, b.fullname, b.customer_id, c.transaction_type_name FROM customer_deposit_tab a, customer_tab b, setup_transaction_type c WHERE a.customer_id=b.customer_id AND a.transaction_type_id=c.transaction_type_id AND a.customer_id=@customer_id;", connection)
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
                listItem.SubItems.Add(row("formatted_balance_after").ToString())
                listItem.SubItems.Add(row("transaction_type_name").ToString())
                listItem.SubItems.Add(row("created_at").ToString())

                listview_form.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return listview_form
    End Function

    Function allCounts()
        Dim connection = myfunctions.connection
        connection.open()
        query = "SELECT (SELECT COUNT(*) FROM staff_tab) AS total_staff, (SELECT COUNT(*) FROM customer_tab) AS total_customer, (SELECT SUM(loan_balance) FROM account_tab) AS total_loan, (SELECT SUM(account_balance) FROM account_tab) AS total_balance;"
        command = New MySqlCommand(query, connection)
        reader = command.ExecuteReader
        reader.Read()
        Dim total_staff = reader("total_staff")
        Dim total_customer = reader("total_customer")
        Dim total_loan = Convert.ToDouble(reader("total_loan")).ToString("N2")
        Dim total_balance = Convert.ToDouble(reader("total_balance")).ToString("N2")
        Return Tuple.Create(total_staff, total_customer, total_loan, total_balance)
    End Function


End Module
