Imports System.Threading

Module MyFunction
    ' Timer to fade in the form
    Dim fadeTimer As Timer

    ' Method to start fade-in effect
    Public Sub startFadeIn(ByVal form As Form)
        ' Create and start the fade-in timer
        fadeTimer = New Timer(AddressOf FadeIn, form, 0, 50)
    End Sub

    ' Timer callback to gradually change opacity
    Public Sub FadeIn(ByVal state As Object)
        Dim form As Form = CType(state, Form)
        If form.InvokeRequired Then
            form.Invoke(New MethodInvoker(Sub() FadeIn(state)))
        Else
            If form.Opacity < 1 Then
                form.Opacity += 0.1 ' Increment opacity by 5%
            Else
                fadeTimer.Change(Timeout.Infinite, Timeout.Infinite) ' Stop the timer
            End If
        End If
    End Sub
    Public Sub closeForm(ByVal newForm As Form)
        newForm.Close()
        overlay.Close()
    End Sub

    Public Sub formModal(ByVal newForm As Form)
        overlay.Show()
        newForm.Show()
    End Sub

    Public Sub activeBtn()
        enrollDashboard.dashboardBtn.Checked = False
        enrollDashboard.enrollBtn.Checked = False
        enrollDashboard.enrollListBtn.Checked = False
        enrollDashboard.verifyBtn.Checked = False
    End Sub

    Public Sub getPageForm(ByVal newForm As Form)
        ' Clear any existing controls in the dashboard panel
        enrollDashboard.dashboardPanel.Controls.Clear()
        ' Configure the new form
        newForm.TopLevel = False
        'panel.FormBorderStyle = FormBorderStyle.None --- to remove form border
        newForm.Dock = DockStyle.Fill
        ' Add the new form to the panel
        enrollDashboard.dashboardPanel.Controls.Add(newForm)
        newForm.Show()
    End Sub

    Public Sub getModalForm(ByVal formPage As Form, ByVal ownerForm As Form)
        Dim formModal As New Form

        Try
            'Dim modal As New formPage
            formModal.StartPosition = FormStartPosition.WindowsDefaultLocation
            formModal.FormBorderStyle = FormBorderStyle.None
            formModal.Opacity = 0.5D
            formModal.BackColor = Color.Black
            formModal.WindowState = FormWindowState.Maximized
            formModal.TopMost = False
            ' formModal.Location = ListViewHitTestLocations
            formModal.ShowInTaskbar = False
            formModal.Show()
            formPage.Owner = formModal
            formPage.ShowDialog()
        Catch ex As Exception
            formModal.Dispose()
        End Try
    End Sub


   







End Module

