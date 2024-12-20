Public Class LogoutForm
    Dim count As Integer

    Private Sub QuestionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

        For counter = 0 To 80 Step 10
            count = counter
            Me.Opacity = count / 80
            Me.Refresh()
            Threading.Thread.Sleep(80)
        Next counter
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
        admin_dashboard.Dispose()
        StaffRecord.Dispose()
        login.Show()
        AdminReg.Dispose()
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        ' Threading.Thread.Sleep(1000)
        For counters = 80 To 0 Step -10
            count = counters
            Me.Opacity = count / 80
            Me.Refresh()
            Threading.Thread.Sleep(70)
        Next counters
        'Me.Dispose()
        Me.Close()
    End Sub
End Class