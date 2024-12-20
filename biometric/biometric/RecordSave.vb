Public Class RecordSave
    Dim count As Integer

    Private Sub RecordSave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

        For counter = 0 To 80 Step 10
            count = counter
            Me.Opacity = count / 80
            Me.Refresh()
            Threading.Thread.Sleep(60)
        Next counter

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        If AdminReg.Visible = True Then
            ' Threading.Thread.Sleep(1000)
            For counters = 80 To 0 Step -10
                count = counters
                Me.Opacity = count / 80
                Me.Refresh()
                Threading.Thread.Sleep(60)
            Next counters
            'Me.Dispose()
            Me.Close()
            AdminReg.ClearOption()
        End If

        If Enrollment.Visible = True Then
            ' Threading.Thread.Sleep(1000)
            For counters = 80 To 0 Step -10
                count = counters
                Me.Opacity = count / 80
                Me.Refresh()
                Threading.Thread.Sleep(60)
            Next counters
            'Me.Dispose()
            Me.Close()
            Enrollment.ClearOption()
            Enrollment.LabelCount.Text = "Fingerprint Samples Needed: 4"
        End If
    End Sub
End Class