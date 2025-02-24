Public Class logoutForm

    Private Sub Guna2Button1_Click(sender As System.Object, e As System.EventArgs) Handles logoutYesBtn.Click
        Me.Close()
        overlay.Close()
        enrollDashboard.Close()
        index.Show()

    End Sub

    Private Sub Guna2Button2_Click(sender As System.Object, e As System.EventArgs) Handles logoutNoBtn.Click
        closeForm(Me)
    End Sub
End Class