Public Class verification

    Private Sub verification_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()
    End Sub
   
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()

        fullname_txt.Text = ""
        email_txt.Text = ""
        mobile_txt.Text = ""
        address_txt.Text = ""
        gender_txt.Text = Nothing
        UserPictureBox.Image = Nothing
        FptPictureBox.Image = Nothing
    End Sub
End Class