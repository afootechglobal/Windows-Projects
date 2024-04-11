Public Class Form1
   
    Private Sub calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click
        Dim first_number, second_number, result As Double
        first_number = first_no_txt.Text
        second_number = second_no_txt.Text
        result = first_number + second_number
        result_txt.Text = +result

    End Sub
End Class
