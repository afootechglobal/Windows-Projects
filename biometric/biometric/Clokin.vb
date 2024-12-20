Public Class Clokin

    Private Sub Clokin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clockin_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        admin_dashboard.Show()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    'Private Sub ClockInNavPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClockInNavPanel.Paint
    '   e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), ClockInNavPanel.ClientRectangle)
    ' End Sub

    ' Private Sub ClockInNavPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClockInNavPanel.Resize
    '   ClockInNavPanel.Invalidate()
    ' End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), Panel2.ClientRectangle)
    End Sub

    Private Sub Panel2_Resize(ByVal sender As Object, ByVal e As System.EventArgs)
        Panel2.Invalidate()
    End Sub
  
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), Panel1.ClientRectangle)
    End Sub

    Private Sub Panel1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Resize
        Panel1.Invalidate()
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), Panel3.ClientRectangle)
    End Sub

    Private Sub Panel3_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.Resize
        Panel3.Invalidate()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelDateTime.Text = "Time " & TimeOfDay & " Date " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

   
End Class