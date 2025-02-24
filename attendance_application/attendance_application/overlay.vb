Public Class overlay
    Private Sub overlay_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dashboardProgressBar.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles enrollListTimerLoader.Tick
        MyFunction.dashboardFormProgressIndicatorShow(enrollListView, dashboardProgressBar, dashboardProgressIndicator, enrollListTimerLoader)
    End Sub

    
    Private Sub logoutTimerLoader_Tick(sender As System.Object, e As System.EventArgs) Handles logoutTimerLoader.Tick
        MyFunction.dashboardFormProgressIndicatorShow(logoutForm, dashboardProgressBar, dashboardProgressIndicator, logoutTimerLoader)
    End Sub
End Class