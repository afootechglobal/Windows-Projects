Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d, ee, f, TOTALPOINT, TOTALCOURSEUNIT, GPA As Double

        If (SDT101_TXT.Text = "") Or (WAP102_TXT.Text = "") Or (MAP103_TXT.Text = "") Or (NS104_TXT.Text = "") Or (SDA105_TXT.Text = "") Or (AGDT106_TXT.Text = "") Then
            MessageBox.Show("Error! Enter Score for all Fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (SDT101_TXT.Text > 100) Or (WAP102_TXT.Text > 100) Or (MAP103_TXT.Text > 100) Or (NS104_TXT.Text > 100) Or (SDA105_TXT.Text > 100) Or (AGDT106_TXT.Text > 100) Then
            MessageBox.Show("Error! Score must not be greater than 100!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf (SDT101_TXT.Text < 0) Or (WAP102_TXT.Text < 0) Or (MAP103_TXT.Text < 0) Or (NS104_TXT.Text < 0) Or (SDA105_TXT.Text < 0) Or (AGDT106_TXT.Text < 0) Then
            MessageBox.Show("Error! Score must not be less than 0!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            If (SDT101_TXT.Text >= 80) And (SDT101_TXT.Text <= 100) Then
                a = 4.0 * 3

            ElseIf (SDT101_TXT.Text >= 60) And (SDT101_TXT.Text <= 79.9) Then
                a = 3.5 * 3
            ElseIf (SDT101_TXT.Text >= 50) And (SDT101_TXT.Text <= 69.9) Then
                a = 3.0 * 3
            ElseIf (SDT101_TXT.Text >= 40) And (SDT101_TXT.Text <= 49.9) Then
                a = 2.5 * 3
            Else
                a = 1.5 * 3
            End If


            If (WAP102_TXT.Text >= 80) And (WAP102_TXT.Text <= 100) Then
                b = 4.0 * 4
            ElseIf (WAP102_TXT.Text >= 60) And (WAP102_TXT.Text <= 79.9) Then
                b = 3.5 * 4
            ElseIf (WAP102_TXT.Text >= 50) And (WAP102_TXT.Text <= 69.9) Then
                b = 3.0 * 4
            ElseIf (WAP102_TXT.Text >= 40) And (WAP102_TXT.Text <= 49.9) Then
                b = 2.5 * 4
            Else
                b = 1.5 * 4
            End If

            If (MAP103_TXT.Text >= 80) And (MAP103_TXT.Text <= 100) Then
                c = 4.0 * 4
            ElseIf (MAP103_TXT.Text >= 60) And (MAP103_TXT.Text <= 79.9) Then
                c = 3.5 * 4
            ElseIf (MAP103_TXT.Text >= 50) And (MAP103_TXT.Text <= 69.9) Then
                c = 3.0 * 4
            ElseIf (MAP103_TXT.Text >= 40) And (MAP103_TXT.Text <= 49.9) Then
                c = 2.5 * 4
            Else
                c = 1.5 * 4
            End If

            If (NS104_TXT.Text >= 80) And (NS104_TXT.Text <= 100) Then
                d = 4.0 * 3
            ElseIf (NS104_TXT.Text >= 60) And (NS104_TXT.Text <= 79.9) Then
                d = 3.5 * 3
            ElseIf (NS104_TXT.Text >= 50) And (NS104_TXT.Text <= 69.9) Then
                d = 3.0 * 3
            ElseIf (NS104_TXT.Text >= 40) And (NS104_TXT.Text <= 49.9) Then
                d = 2.5 * 3
            Else
                d = 1.5 * 3
            End If

            If (SDA105_TXT.Text >= 80) And (SDA105_TXT.Text <= 100) Then
                ee = 4.0 * 3
            ElseIf (SDA105_TXT.Text >= 60) And (SDA105_TXT.Text <= 79.9) Then
                ee = 3.5 * 3
            ElseIf (SDA105_TXT.Text >= 50) And (SDA105_TXT.Text <= 69.9) Then
                ee = 3.0 * 3
            ElseIf (SDA105_TXT.Text >= 40) And (SDA105_TXT.Text <= 49.9) Then
                ee = 2.5 * 3
            Else
                ee = 1.5 * 3
            End If

            If (AGDT106_TXT.Text >= 80) And (AGDT106_TXT.Text <= 100) Then
                f = 4.0 * 3
            ElseIf (AGDT106_TXT.Text >= 60) And (AGDT106_TXT.Text <= 79.9) Then
                f = 3.5 * 3
            ElseIf (AGDT106_TXT.Text >= 50) And (AGDT106_TXT.Text <= 69.9) Then
                f = 3.0 * 3
            ElseIf (AGDT106_TXT.Text >= 40) And (AGDT106_TXT.Text <= 49.9) Then
                f = 2.5 * 3
            Else
                f = 1.5 * 3
            End If


            TOTALPOINT = a + b + c + d + ee + f
            TOTALCOURSEUNIT = 3 + 4 + 4 + 3 + 3 + 3
            GPA = TOTALPOINT / TOTALCOURSEUNIT
            result_txt.Text = GPA.ToString("N2")

            If (GPA >= 3.5) And (GPA <= 4.0) Then
                class_gategory_txt.Text = ("DISTINCTION")
            ElseIf (GPA >= 3.0) And (GPA <= 3.49) Then
                class_gategory_txt.Text = ("UPPER CLASS")
            ElseIf (GPA >= 2.5) And (GPA <= 2.99) Then
                class_gategory_txt.Text = ("LOWER CLASS")
            ElseIf (GPA >= 2.0) And (GPA <= 2.49) Then
                class_gategory_txt.Text = ("PASS")
            Else
                class_gategory_txt.Text = ("CARRY OVER")

            End If

        End If

    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SDT101_TXT.Text = ""
        WAP102_TXT.Text = ""
        MAP103_TXT.Text = ""
        NS104_TXT.Text = ""
        SDA105_TXT.Text = ""
        AGDT106_TXT.Text = ""
        result_txt.Text = ""
        class_gategory_txt.Text = ""
    End Sub

  
    Private Sub SDT101_TXT_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles WAP102_TXT.KeyPress, SDT101_TXT.KeyPress, SDA105_TXT.KeyPress, NS104_TXT.KeyPress, MAP103_TXT.KeyPress, AGDT106_TXT.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            e.Handled = True
            MessageBox.Show("This field allows only Numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot Only Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("This field Required Users to Input a Number or Numbers before a Dot!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    
    
End Class
