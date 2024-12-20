Public Class AttendanceReport

    Private Sub ReportPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ReportPanel.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), ReportPanel.ClientRectangle)
    End Sub

    Private Sub ReportPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportPanel.Resize
        Panel1.Invalidate()
    End Sub
End Class