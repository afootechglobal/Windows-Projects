Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Module MyFuctions

    Dim counter_value As Integer
    Dim TimeID As String
    Dim command As MySqlCommand
    Dim connection As MySqlConnection
    Dim connstring As String
    Dim reader As MySqlDataReader
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim staff_id As String

    Public Function GetSqlConnection() As MySqlConnection
        Dim connstring As String = "server=localhost;user id=root;password=;database=biometric"
        Dim connection As New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        Return connection
    End Function

    Public Function validateEmail(ByVal emailAddress) As Boolean
        Dim email As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})")
        If email.IsMatch(emailAddress) Then
            Return True
        End If
    End Function

    Public Sub counter_user(ByVal counter_id, ByVal counter_value)
        'counter query
        connection = MyFuctions.GetSqlConnection
        query = "UPDATE counter_tab SET counter_value=@counter_value WHERE counter_id=@counter_id"
        command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        command.Parameters.AddWithValue("@counter_value", counter_value)
        reader = command.ExecuteReader
        reader.Read()
        connection.Close()
    End Sub

    Public Function staffID()
        connection = MyFuctions.GetSqlConnection
        query = "SELECT counter_value FROM counter_tab WHERE counter_id='STF'"
        command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@counter_id", counter_value)
        reader = command.ExecuteReader
        reader.Read()
        counter_value = reader("counter_value")
        connection.Close()

        counter_value = counter_value + 1
        TimeID = Now.ToString("yyyyMMddss")
        Call counter_user("STF", counter_value)
        staff_id = "STF" + TimeID + counter_value.ToString
        Return staff_id
    End Function

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



End Module
