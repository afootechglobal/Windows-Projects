Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Public Class login
    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim staff_id As String

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection = MyFuctions.GetSqlConnection
        ForgotPass_Panel.Hide()
        login_panel.Show()
        ResetPass_Panel.Hide()
    End Sub

    'Password hashing code......
    Public Function Md5FromString(ByVal source As String) As String
        Dim Bytes() As Byte
        Dim sb As New StringBuilder()
        If String.IsNullOrEmpty(source) Then
            Throw New ArgumentNullException
        End If
        Bytes = Encoding.Default.GetBytes(source)
        Bytes = MD5.Create().ComputeHash(Bytes)
        For x As Integer = 0 To Bytes.Length - 1
            sb.Append(Bytes(x).ToString("x2"))
        Next
        Return sb.ToString
    End Function

    Private Sub Clear_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        Dim hashcode As login
        hashcode = New login
        If email_txt.Text = "" Or Pass_txt.Text = "" Then
            MessageBox.Show("All Fields are Required!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf validateEmail(email_txt.Text) = False Then
            MessageBox.Show("Please Enter a valid Email Address to Continue!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email_txt.Text = ""
            email_txt.Focus()
            Exit Sub
        Else
            connection = MyFuctions.GetSqlConnection
            query = "SELECT email_address, password FROM staff_tab WHERE email_address=@email_address AND password=@password"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email_address", email_txt.Text)
            command.Parameters.AddWithValue("@password", hashcode.Md5FromString(Pass_txt.Text))
            reader = command.ExecuteReader
            If reader.HasRows = True Then
                admin_dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Email Address or Password is Invalid!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ForgotPass_Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForgotPass_Label.Click
        ForgotPass_Panel.Show()
        login_panel.Hide()
        ResetPass_Panel.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Pass_txt.UseSystemPasswordChar = True
            CheckBox1.BackgroundImage = My.Resources.eye5
            CheckBox1.BackgroundImageLayout = ImageLayout.Stretch
        Else
            Pass_txt.UseSystemPasswordChar = False
            CheckBox1.BackgroundImage = My.Resources.pngwing_com
            CheckBox1.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        login_panel.Show()
        ForgotPass_Panel.Hide()
        ResetPass_Panel.Hide()
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        login_panel.Hide()
        ResetPass_Panel.Show()
        ForgotPass_Panel.Hide()
    End Sub

    Private Sub Guna2Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button4.Click
        ResetPass_Panel.Hide()
        ForgotPass_Panel.Show()
        login_panel.Hide()
    End Sub

   
End Class
