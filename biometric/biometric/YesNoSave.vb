Public Class YesNoSave
    Dim count As Integer

    Private Sub YesNoSave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

        For counter = 0 To 80 Step 10
            count = counter
            Me.Opacity = count / 80
            Me.Refresh()
            Threading.Thread.Sleep(60)
        Next counter
    End Sub

    Private Sub YesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesBtn.Click
        If AdminReg.Visible = True Then
            ' Threading.Thread.Sleep(1000)
            For counters = 80 To 0 Step -10
                count = counters
                Me.Opacity = count / 80
                Me.Refresh()
                Threading.Thread.Sleep(60)
            Next counters
            'Me.Dispose()
            AdminReg.Registration()
            Me.Close()
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
            Enrollment.EnrollmentReg()
            Me.Close()
        End If
    End Sub

    Private Sub NoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoButton.Click
        ' Threading.Thread.Sleep(1000)
        For counters = 80 To 0 Step -10
            count = counters
            Me.Opacity = count / 80
            Me.Refresh()
            Threading.Thread.Sleep(60)
        Next counters
        'Me.Dispose()
        Me.Close()
    End Sub

   
End Class