Public Class customerviewrecord

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Me.Close()
        customerrecordform.Show()
    End Sub

    Private Sub customerviewrecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.customerRecord()
        Dim result = functions.allCounts
        total_customer_count_label_txt.Text = allCounts.item2.ToString
    End Sub
End Class