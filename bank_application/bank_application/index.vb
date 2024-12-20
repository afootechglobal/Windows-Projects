Imports MySql.Data.MySqlClient
Public Class index_form

    Private Sub index_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connection = myfunctions.connection
        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MsgBox("Connection successful.")
            End If
        Catch ex As MySqlException
            MsgBox("Connection failed: " & ex.Message)
            Me.Close()
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub loginUserBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginUserBtn.Click
        overlay.Show()
        userlogin_form.Show()
    End Sub

    Private Sub loginAdminBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginAdminBtn.Click
        overlay.Show()
        adminlogin_form.Show()
    End Sub

End Class
