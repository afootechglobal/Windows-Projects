Public Class Form1

    Dim fistnumber As Double
    Dim secondnumber As Double
    Dim a As Double
    Dim op As String
    Dim n As Int64

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub age_calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles age_calc_btn.Click
        age_calc_panel.Show()
        afoo_gp_panel.Hide()
        boyle_law_panel.Hide()
        loan_app_panel.Hide()
        scientific_calc_panel.Hide()
    End Sub

    Private Sub gp_calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gp_calc_btn.Click
        afoo_gp_panel.Show()
        age_calc_panel.Hide()
        boyle_law_panel.Hide()
        loan_app_panel.Hide()
        scientific_calc_panel.Hide()
    End Sub

    Private Sub boyles_law_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boyles_law_btn.Click
        boyle_law_panel.Show()
        age_calc_panel.Hide()
        afoo_gp_panel.Hide()
        loan_app_panel.Hide()
        scientific_calc_panel.Hide()
    End Sub

    Private Sub loan_app_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_app_btn.Click
        loan_app_panel.Show()
        age_calc_panel.Hide()
        afoo_gp_panel.Hide()
        boyle_law_panel.Hide()
        scientific_calc_panel.Hide()
    End Sub

    Private Sub sci_calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sci_calc_btn.Click
        scientific_calc_panel.Show()
        age_calc_panel.Hide()
        afoo_gp_panel.Hide()
        boyle_law_panel.Hide()
        loan_app_panel.Hide()
    End Sub




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

    Private Sub birthday_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles birthyear_txt.KeyPress, birthmonth_txt.KeyPress, birthday_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("This field allows only Numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.Handled = Not e.KeyChar = "." Then
            e.Handled = True
            MessageBox.Show("Dot is Not Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        birthday_txt.Text = ""
        birthmonth_txt.Text = ""
        birthyear_txt.Text = ""
        resultyear_txt.Text = ""
        resultmonth_txt.Text = ""
        resultday_txt.Text = ""
    End Sub



    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
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

    Private Sub WAP102_TXT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles WAP102_TXT.KeyPress, SDT101_TXT.KeyPress, SDA105_TXT.KeyPress, NS104_TXT.KeyPress, MAP103_TXT.KeyPress, AGDT106_TXT.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("This field allows only Numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot Only Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("This field Required Users to Input a Number or Numbers before a Dot!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        SDT101_TXT.Text = ""
        WAP102_TXT.Text = ""
        MAP103_TXT.Text = ""
        NS104_TXT.Text = ""
        SDA105_TXT.Text = ""
        AGDT106_TXT.Text = ""
        result_txt.Text = ""
        class_gategory_txt.Text = ""
    End Sub


    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click, Button50.Click, Button49.Click, Button45.Click, Button44.Click, Button43.Click, Button39.Click, Button38.Click, Button37.Click, Button33.Click
        Dim b As Button = sender
        If TextBox_Result.Text = "0" Then
            TextBox_Result.Text = b.Text
        Else
            TextBox_Result.Text = TextBox_Result.Text + b.Text
        End If
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        If Not (TextBox_Result.Text.Contains(".")) Then
            TextBox_Result.Text += "."
        End If
    End Sub

    Private Sub operators(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click, Button42.Click, Button36.Click, Button23.Click
        Dim ops As Button = sender
        fistnumber = Val(TextBox_Result.Text)
        Label28.Text = Val(TextBox_Result.Text)
        TextBox_Result.Text = ""
        op = ops.Text
        Label28.Text = Label28.Text + " " + op
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        secondnumber = Val(TextBox_Result.Text)
        If op = "+" Then
            a = fistnumber + secondnumber
            TextBox_Result.Text = a
            Label28.Text = fistnumber & " " & op & " " & secondnumber
        ElseIf op = "-" Then
            a = fistnumber - secondnumber
            TextBox_Result.Text = a
            Label28.Text = fistnumber & " " & op & " " & secondnumber
        ElseIf op = "*" Then
            a = fistnumber * secondnumber
            TextBox_Result.Text = a
            Label28.Text = fistnumber & " " & op & " " & secondnumber
        ElseIf op = "/" Then
            If secondnumber = 0 Then
                TextBox_Result.Text = "Error!"
                Label28.Text = ""
            Else
                a = fistnumber / secondnumber
                TextBox_Result.Text = a
                Label28.Text = fistnumber & " " & op & " " & secondnumber
            End If
        ElseIf op = "Mod" Then
            a = fistnumber Mod secondnumber
            TextBox_Result.Text = a
            Label28.Text = fistnumber & op & secondnumber
        Else : op = "Exp"
            a = fistnumber ^ secondnumber
            TextBox_Result.Text = a
            Label28.Text = ""
        End If
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If TextBox_Result.Text.Length > 0 Then
            TextBox_Result.Text = TextBox_Result.Text.Remove(TextBox_Result.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        TextBox_Result.Text = "0"
        Label28.Text = ""
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        TextBox_Result.Text = "0"
        Label28.Text = ""
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        a = Val(Math.Sqrt(TextBox_Result.Text))
        TextBox_Result.Text = a
        Label28.Text = ""
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        a = Math.Cos(TextBox_Result.Text)
        TextBox_Result.Text = a
        Label28.Text = ""
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        If Int64.TryParse(TextBox_Result.Text, n) Then
            TextBox_Result.Text = Convert.ToString(n, 2)
        Else
            TextBox_Result.Text = ""
        End If
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        a = Val(Math.Tan(TextBox_Result.Text))
        TextBox_Result.Text = a
        Label28.Text = ""
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        a = Val(Math.Log(TextBox_Result.Text))
        TextBox_Result.Text = a
        Label28.Text = ""
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        a = Val(Math.Sin(TextBox_Result.Text))
        TextBox_Result.Text = a
        Label28.Text = ""
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Dim ops As Button = sender
        fistnumber = Val(TextBox_Result.Text)
        Label28.Text = TextBox_Result.Text
        TextBox_Result.Text = ""
        op = ops.Text
        Label28.Text = Label1.Text + " " + op
    End Sub



    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        Dim ops As Button = sender
        fistnumber = Val(TextBox_Result.Text)
        Label28.Text = TextBox_Result.Text
        TextBox_Result.Text = ""
        op = ops.Text
        Label28.Text = Label1.Text + " " + op
    End Sub

   
   
    Private Sub scientific_calc_panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles scientific_calc_panel.Paint
        ComboBox2.Text = "Choose One..."
    End Sub
   
    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Dim convert As Double
        
        If ComboBox2.Text = "Choose One..." Then
            MessageBox.Show("Kindly Select a Unit Conversion to Continue!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Error! Enter Field to Continue!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If ComboBox2.Text = "Celsius to Fehrenheit" Then
                convert = (9 / 5 * TextBox2.Text) + 32
                TextBox_Conversion_txt.Text = convert.ToString("N2") & "  Fehrenheit"
            ElseIf ComboBox2.Text = "Miles to Kilometres" Then
                convert = TextBox2.Text / 1.609344
                TextBox_Conversion_txt.Text = convert.ToString("N2") & " Kilometres"
            ElseIf ComboBox2.Text = "Fehrenheit to Celsius" Then
                convert = (5 / 9 * TextBox2.Text) - 32
                TextBox_Conversion_txt.Text = convert.ToString("N2") & "  Celsius"
            ElseIf ComboBox2.Text = "Kilometres to Miles" Then
                convert = TextBox2.Text / 1.609344
                TextBox_Conversion_txt.Text = convert.ToString("N2") & " Miles"
            ElseIf ComboBox2.Text = "Centimetre to Metres" Then
                convert = TextBox2.Text * 0.01
                TextBox_Conversion_txt.Text = convert.ToString("N2") & " Meters"

            End If
        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("This field allows only Numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    
    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        TextBox_Conversion_txt.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        ComboBox2.Text = "Choose One..."
    End Sub

   
   
  
    Private Sub boyle_law_panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles boyle_law_panel.Paint
        ComboBox1.Text = "Choose One..."
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Dim result, a As Double
        If ComboBox1.Text = "Choose One..." Then
            MessageBox.Show("Opps! Choose Operation to Continue!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf initial_pressure_txt.Text = "" Or final_pressure_txt.Text = "" Or initial_volume_txt.Text = "" Or final_volume_txt.Text = "" Then
            MessageBox.Show("Error! Enter Input for all Fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If ComboBox1.Text = "INITIAL PRESSURE (P1)" Then
                a = final_pressure_txt.Text * final_volume_txt.Text
                result = a / initial_volume_txt.Text
                result_text.Text = result.ToString("N2")
            ElseIf ComboBox1.Text = "FINAL PRESSURE (P2)" Then
                a = initial_pressure_txt.Text * initial_volume_txt.Text
                result = a / final_volume_txt.Text
                result_text.Text = result.ToString("N2")
            ElseIf ComboBox1.Text = "INITIAL VOLUME (V1)" Then
                a = final_pressure_txt.Text * final_volume_txt.Text
                result = a / initial_pressure_txt.Text
                result_text.Text = result.ToString("N2")
            ElseIf ComboBox1.Text = "FINAL VOLUME (V2)" Then
                a = initial_pressure_txt.Text * initial_volume_txt.Text
                result = a / final_pressure_txt.Text
                result_text.Text = result.ToString("N2")
            End If
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim find As String
        find = ComboBox1.Text
        initial_pressure_txt.Enabled = True
        initial_volume_txt.Enabled = True
        final_pressure_txt.Enabled = True
        final_volume_txt.Enabled = True

        initial_pressure_txt.Text = ""
        initial_volume_txt.Text = ""
        final_pressure_txt.Text = ""
        final_volume_txt.Text = ""

        initial_pressure_txt.BackColor = Color.White
        initial_volume_txt.BackColor = Color.White
        final_pressure_txt.BackColor = Color.White
        final_volume_txt.BackColor = Color.White


        If find = "INITIAL PRESSURE (P1)" Then
            initial_pressure_txt.Text = "?"
            initial_pressure_txt.Enabled = False
            initial_pressure_txt.BackColor = Color.LightSteelBlue
        ElseIf find = "FINAL PRESSURE (P2)" Then
            final_pressure_txt.Text = "?"
            final_pressure_txt.Enabled = False
            final_pressure_txt.BackColor = Color.LightSteelBlue
        ElseIf find = "INITIAL VOLUME (V1)" Then
            initial_volume_txt.Text = "?"
            initial_volume_txt.Enabled = False
            initial_volume_txt.BackColor = Color.LightSteelBlue
        ElseIf find = "FINAL VOLUME (V2)" Then
            final_volume_txt.Text = "?"
            final_volume_txt.Enabled = False
            final_volume_txt.BackColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        initial_pressure_txt.Text = ""
        final_pressure_txt.Text = ""
        initial_volume_txt.Text = ""
        final_volume_txt.Text = ""
        result_text.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Text = "Choose One..."
        initial_pressure_txt.Enabled = True
        initial_pressure_txt.BackColor = Color.White
        initial_volume_txt.Enabled = True
        initial_volume_txt.BackColor = Color.White
        final_pressure_txt.Enabled = True
        final_pressure_txt.BackColor = Color.White
        final_volume_txt.Enabled = True
        final_volume_txt.BackColor = Color.White
    End Sub

   
  
    Private Sub initial_pressure_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles initial_volume_txt.KeyPress, initial_pressure_txt.KeyPress, final_volume_txt.KeyPress, final_pressure_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("This field allows only Numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot Only Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("This field Required Users to Input a Number or Numbers before a Dot!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click

        Dim interest, b, principal, total_repayment, total As Double
        Dim amount, month As Double
        Dim total_interest As Double


        If loanamount_txt.Text = "" Then
            MessageBox.Show("Loan Amount Can't be Empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf duration_txt.Text = "" Then
            MessageBox.Show("Duration Can't be Empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf loanamount_txt.Text = "0" Then
            MessageBox.Show("Loan Amount Can't be 0!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf duration_txt.Text = "0" Then
            MessageBox.Show("Duration Can't be 0!")
        Else
            ListBox1.Items.Clear()
            ListBox1.Items.Add("MONTH           " & "AMOUNT " & "              " & "INTEREST" & "               " & "MONTHLY REPAYMENT")

            amount = loanamount_txt.Text
            month = duration_txt.Text
            principal = amount / month
            For b = 1 To month
                interest = (1.5 / 100) * amount
                total = principal + interest
                amount = amount - principal
                total_repayment = total_repayment + total

                ListBox1.Items.Add(b & "                    " & (principal.ToString("N2")) & "              " & (interest.ToString("N2")) & "                " & (total.ToString("N2")))
            Next
            Me.Height = 563
            total_interest = total_repayment - loanamount_txt.Text
            Total_interest_txt.Text = (total_interest.ToString("N2"))
            Total_repayment_txt.Text = (total_repayment.ToString("N2"))
        End If
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        Total_repayment_txt.Text = ""
        Total_interest_txt.Text = ""
        loanamount_txt.Text = ""
        duration_txt.Text = ""
        ListBox1.Items.Clear()
    End Sub

    Private Sub loanamount_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles loanamount_txt.KeyPress, duration_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("This field allows only Numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot Only Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("This field Required Users to Input a Number or Numbers before a Dot!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    
 
   
   
End Class
