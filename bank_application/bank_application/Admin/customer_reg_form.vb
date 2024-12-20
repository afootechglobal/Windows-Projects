Imports MySql.Data.MySqlClient
Public Class customer_reg_form

    Private Sub recordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recordBtn.Click
        Me.Hide()
        view_customer_form.Show()
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub customer_reg_form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myfunctions.customerRecord()
    End Sub
End Class