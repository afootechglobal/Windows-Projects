Public Class Form1

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim today, tomonth, toyear As Integer
        Dim DaysInMonth As Integer


        today = Date.Now.Day
        tomonth = Date.Now.Month
        toyear = Date.Now.Year

        If birthday_txt.Text = "" Or birthmonth_txt.Text = "" Or birthyear_txt.Text = "" Then
            MessageBox.Show("Error! Enter Input for all Fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (birthmonth_txt.Text > 12) Or (birthmonth_txt.Text <= 0) Then
            MessageBox.Show("Error! Invalid Date, Kindly Enter Another Date to Continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
       
        Else

            DaysInMonth = System.DateTime.DaysInMonth(birthyear_txt.Text, birthmonth_txt.Text)

            If (birthmonth_txt.Text = 1 Or 2 Or 3 Or 4 Or 5 Or 6 Or 7 Or 8 Or 9 Or 10 Or 11 Or 12) And (birthday_txt.Text > DaysInMonth Or birthday_txt.Text <= 0) Then
                MessageBox.Show("Error! Invalid Date, Kindly Enter Another Date to Continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf birthday_txt.Text = "" Or birthmonth_txt.Text = "" Or birthyear_txt.Text = "" Then
                MessageBox.Show("Error! Enter Input for all Fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                If (birthmonth_txt.Text > 12) Or (birthmonth_txt.Text <= 0) Then
                    MessageBox.Show("Error! Invalid Date, Kindly Enter Another Date to Continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf (birthyear_txt.Text > toyear) Or (birthyear_txt.Text <= 0) Then
                    MessageBox.Show("Error! Invalid Date, Kindly Enter Another Date to Continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf (birthyear_txt.Text = toyear) And (birthmonth_txt.Text > tomonth) Then
                    MessageBox.Show("Error! Invalid Date, Kindly Enter Another Date to Continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf (birthyear_txt.Text = toyear) And (birthday_txt.Text > today) And (birthmonth_txt.Text = tomonth) Then
                    MessageBox.Show("Error! Invalid Date, Kindly Enter Another Date to Continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                

                Else


                    If (birthmonth_txt.Text = tomonth) And (birthday_txt.Text > today) Then
                        resultyear_txt.Text = toyear - birthyear_txt.Text - 1
                    ElseIf (birthmonth_txt.Text > tomonth) And (birthday_txt.Text < today) Then
                        resultyear_txt.Text = toyear - birthyear_txt.Text - 1
                    ElseIf (birthmonth_txt.Text > tomonth) And (birthday_txt.Text > today) Then
                        resultyear_txt.Text = toyear - birthyear_txt.Text - 1
                    ElseIf (birthday_txt.Text = today) And (birthmonth_txt.Text > tomonth) Then
                        resultyear_txt.Text = toyear - birthyear_txt.Text - 1
                    Else : resultyear_txt.Text = toyear - birthyear_txt.Text
                    End If

                    If (tomonth > birthmonth_txt.Text) And (birthday_txt.Text > today) Then
                        resultmonth_txt.Text = tomonth - birthmonth_txt.Text - 1
                    ElseIf (birthday_txt.Text > today) And (tomonth = birthmonth_txt.Text) Then
                        resultmonth_txt.Text = 12 - 1
                    ElseIf (birthday_txt.Text < today) And (birthmonth_txt.Text > tomonth) Then
                        resultmonth_txt.Text = tomonth + 12 - birthmonth_txt.Text
                    ElseIf (birthmonth_txt.Text > tomonth) And (birthday_txt.Text > today) Then
                        resultmonth_txt.Text = tomonth + 12 - birthmonth_txt.Text - 1
                    ElseIf (birthday_txt.Text = today) And (birthmonth_txt.Text > tomonth) Then
                        resultmonth_txt.Text = tomonth + 12 - birthmonth_txt.Text
                    Else : resultmonth_txt.Text = tomonth - birthmonth_txt.Text
                    End If

                    If (birthday_txt.Text < today) And (birthmonth_txt.Text > tomonth) Then
                        resultday_txt.Text = today - birthday_txt.Text
                    ElseIf (birthday_txt.Text > today) And (birthmonth_txt.Text < tomonth) Then
                        resultday_txt.Text = DaysInMonth - birthday_txt.Text + today - 1
                    ElseIf (birthday_txt.Text > today) And (birthmonth_txt.Text = tomonth) Then
                        resultday_txt.Text = DaysInMonth - birthday_txt.Text + today - 1
                    ElseIf (birthday_txt.Text > today) And (birthmonth_txt.Text > tomonth) Then
                        resultday_txt.Text = DaysInMonth - birthday_txt.Text + today - 1
                    ElseIf (birthday_txt.Text > today) Then
                        resultday_txt.Text = birthday_txt.Text - today
                    Else : resultday_txt.Text = today - birthday_txt.Text
                    End If
                End If
            End If
        End If
    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        birthday_txt.Text = ""
        birthmonth_txt.Text = ""
        birthyear_txt.Text = ""
        resultyear_txt.Text = ""
        resultmonth_txt.Text = ""
        resultday_txt.Text = ""
    End Sub

    Private Sub birthday_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles birthyear_txt.KeyPress, birthmonth_txt.KeyPress, birthday_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("This field allows only Numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.Handled = Not e.KeyChar = "." Then
            e.Handled = True
            MessageBox.Show("Dot is Not Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class
