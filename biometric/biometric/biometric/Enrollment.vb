Public Class Enrollment

    Private Sub Enrollment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Enrollment_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()
    End Sub


    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()

        fullname_txt.Text = ""
        email_txt.Text = ""
        mobile_txt.Text = ""
        address_txt.Text = ""
        GenderComboBox.Text = Nothing
        UserPictureBox.Image = Nothing

        ' EnrollmentBtn.BackColor = Color.FromArgb(164, 207, 223)
        ' VerificationBtn.BackColor = Color.Transparent
        ' AdminBtn.BackColor = Color.Transparent
        ' LogoutBtn.BackColor = Color.Transparent
    End Sub

    Private Sub selectpassport_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectpassport_button.Click
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            UserPictureBox.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
    End Sub
End Class