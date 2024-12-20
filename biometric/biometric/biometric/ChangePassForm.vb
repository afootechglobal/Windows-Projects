Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Security.Cryptography
Public Class ChangePassForm

    Dim connection As MySqlConnection
    Dim connstring As String
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim email As String

    Private Sub ChangePassFormLoad_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

        'staff_id = MyFuctions.staffID
        email = login.email_txt.Text
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

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
        ClearOption()
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        Dim hashcode As ChangePassForm
        hashcode = New ChangePassForm

        If CurrentPass_txt.Text = "" Or NewPass_txt.Text = "" Or ConfirmedPass_txt.Text = "" Then
            MessageBox.Show("All Fields are Required to change your Password!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NewPass_txt.Text <> ConfirmedPass_txt.Text Then
            MessageBox.Show("New and Confirmed password don't Match", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NewPass_txt.Text = ""
            ConfirmedPass_txt.Text = ""
        Else
            connection = MyFuctions.GetSqlConnection
            query = "SELECT * FROM staff_tab WHERE email_address=@email_address AND password=@password"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email_address", email)
            command.Parameters.AddWithValue("@password", hashcode.Md5FromString(CurrentPass_txt.Text))
            reader = command.ExecuteReader
            If reader.Read = True Then
                connection.Close()
                connection.Open()
                query = "UPDATE staff_tab SET password=@password WHERE email_address=@email_address"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@password", hashcode.Md5FromString(NewPass_txt.Text))
                command.Parameters.AddWithValue("@email_address", email)
                command.ExecuteReader()
                Dim response As Integer
                response = MessageBox.Show("Password has been updated successfully!", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If vbOK Then
                    CurrentPass_txt.Text = ""
                    NewPass_txt.Text = ""
                    ConfirmedPass_txt.Text = ""
                End If
                connection.Close()
            Else
                connection.Close()
                MessageBox.Show("The current password don't match the record in our database", "Biometric Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CurrentPass_txt.Text = ""
            End If
        End If


    End Sub

    'Myfucntion code start here...
    Private Sub ClearOption()
        CurrentPass_txt.Text = ""
        NewPass_txt.Text = ""
        ConfirmedPass_txt.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CurrentPass_txt.UseSystemPasswordChar = True
            CheckBox1.BackgroundImage = My.Resources.eye5
            CheckBox1.BackgroundImageLayout = ImageLayout.Stretch
        Else
            CurrentPass_txt.UseSystemPasswordChar = False
            CheckBox1.BackgroundImage = My.Resources.pngwing_com
            CheckBox1.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

   
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            NewPass_txt.UseSystemPasswordChar = True
            CheckBox2.BackgroundImage = My.Resources.eye5
            CheckBox2.BackgroundImageLayout = ImageLayout.Stretch
        Else
            NewPass_txt.UseSystemPasswordChar = False
            CheckBox2.BackgroundImage = My.Resources.pngwing_com
            CheckBox2.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            NewPass_txt.UseSystemPasswordChar = True
            CheckBox3.BackgroundImage = My.Resources.eye5
            CheckBox3.BackgroundImageLayout = ImageLayout.Stretch
        Else
            NewPass_txt.UseSystemPasswordChar = False
            CheckBox3.BackgroundImage = My.Resources.pngwing_com
            CheckBox3.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub
End Class