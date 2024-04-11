Public Class Form1

    Private Sub result_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click
        Dim first_no, second_no As Integer
        first_no = first_no_txt.Text
        second_no = second_no_txt.Text
        result_txt.Text = first_no - second_no
    End Sub
End Class
