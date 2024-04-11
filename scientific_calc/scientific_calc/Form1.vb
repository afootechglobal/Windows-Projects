Public Class Form1
    Dim fistnumber As Double
    Dim secondnumber As Double
    Dim a As Double
    Dim op As String
    Dim n As Int64
   
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button3.Click, Button24.Click, Button18.Click, Button17.Click, Button16.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        Dim b As Button = sender
        If TextBox_Result.Text = "0" Then
            TextBox_Result.Text = b.Text
        Else
            TextBox_Result.Text = TextBox_Result.Text + b.Text
        End If
    End Sub

    Private Sub operators(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, Button9.Click, Button21.Click, Button15.Click
        Dim ops As Button = sender
        fistnumber = Val(TextBox_Result.Text)
        Label1.Text = fistnumber
        TextBox_Result.Text = ""

        If (TextBox_Result.Text = "") Then
            op = ops.Text
            Label1.Text = Label1.Text + " " + op
            '  Else
            '    op = ops.Text
            '   Label1.Text = fistnumber + " " + op

        End If
       
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If Not (TextBox_Result.Text.Contains(".")) Then
            TextBox_Result.Text += "."
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        TextBox_Result.Text = "0"
        Label1.Text = ""
    End Sub

    
    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        TextBox_Result.Text = "0"
        Label1.Text = ""
    End Sub

    
   

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        secondnumber = Val(TextBox_Result.Text)
        If op = "+" Then
            a = fistnumber + secondnumber
            TextBox_Result.Text = a
            Label1.Text = fistnumber & " " & op & " " & secondnumber
        ElseIf op = "-" Then
            a = fistnumber - secondnumber
            TextBox_Result.Text = a
            Label1.Text = fistnumber & " " & op & " " & secondnumber
        ElseIf op = "*" Then
            a = fistnumber * secondnumber
            TextBox_Result.Text = a
            Label1.Text = fistnumber & " " & op & " " & secondnumber
        ElseIf op = "/" Then
            If secondnumber = 0 Then
                TextBox_Result.Text = "Error!"
                Label1.Text = ""
            Else
                a = fistnumber / secondnumber
                TextBox_Result.Text = a
                Label1.Text = fistnumber & " " & op & " " & secondnumber
            End If
        ElseIf op = "Mod" Then
            a = fistnumber Mod secondnumber
            TextBox_Result.Text = a
            Label1.Text = fistnumber & op & secondnumber
        Else : op = "Exp"
            a = fistnumber ^ secondnumber
            TextBox_Result.Text = a
            Label1.Text = ""
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Int64.TryParse(TextBox_Result.Text, n) Then
            TextBox_Result.Text = Convert.ToString(n, 2)
        Else
            TextBox_Result.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        a = Val(Math.Sin(TextBox_Result.Text))
        TextBox_Result.Text = a
        Label1.Text = ""
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        a = Val(Math.Cos(TextBox_Result.Text))
        TextBox_Result.Text = a
        Label1.Text = ""
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        a = Val(Math.Tan(TextBox_Result.Text))
        TextBox_Result.Text = a
        Label1.Text = ""
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        a = Val(Math.Log(TextBox_Result.Text))
        TextBox_Result.Text = a
        Label1.Text = ""
    End Sub

    
    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        a = Val(Math.Sqrt(TextBox_Result.Text))
        TextBox_Result.Text = a
        Label1.Text = ""
    End Sub

    
    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If TextBox_Result.Text.Length > 0 Then
            TextBox_Result.Text = TextBox_Result.Text.Remove(TextBox_Result.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        a = Convert.ToDouble(TextBox_Result.Text) / Convert.ToDouble(100)
        TextBox_Result.Text = System.Convert.ToString(a)
    End Sub

   
    Private Sub ScientificToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Width = 392
        Me.Height = 417
        TextBox_Result.Width = 374
        TextBox_Result.Height = 52


    End Sub

    Private Sub StandardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandardToolStripMenuItem.Click
        Me.Width = 262
        TextBox_Result.Width = 246
        TextBox_Result.Height = 52

    End Sub

    
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 262
        TextBox_Result.Width = 246
        TextBox_Result.Height = 52
        ComboBox1.Text = "Choose One..."
        ComboBox1.Items.Add("Celsius to Fehrenheit")
        ComboBox1.Items.Add("Fehrenheit to Celsius")
        ComboBox1.Items.Add("Miles to Kilometres")
        ComboBox1.Items.Add("Kilometres to Miles")
        ComboBox1.Items.Add("Centimetre to Metres")

    End Sub


    Private Sub UnitConversionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Width = 838
        Me.Height = 417
        TextBox_Result.Width = 374
        TextBox_Result.Height = 52

    End Sub

   
    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Dim convert As Double

        If ComboBox1.Text = "Choose One..." Then
            MessageBox.Show("Kindly Select a Unit Conversion to Continue!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Error! Enter Field to Continue!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If ComboBox1.Text = "Celsius to Fehrenheit" Then
                convert = (9 / 5 * TextBox2.Text) + 32
                TextBox_Conversion_txt.Text = convert.ToString("N2") & "  Fehrenheit"
            ElseIf ComboBox1.Text = "Miles to Kilometres" Then
                convert = TextBox2.Text / 1.609344
                TextBox_Conversion_txt.Text = convert.ToString("N2") & " Kilometres"
            ElseIf ComboBox1.Text = "Fehrenheit to Celsius" Then
                convert = (5 / 9 * TextBox2.Text) - 32
                TextBox_Conversion_txt.Text = convert.ToString("N2") & "  Celsius"
            ElseIf ComboBox1.Text = "Kilometres to Miles" Then
                convert = TextBox2.Text / 1.609344
                TextBox_Conversion_txt.Text = convert.ToString("N2") & " Miles"
            ElseIf ComboBox1.Text = "Centimetre to Metres" Then
                convert = TextBox2.Text * 0.01
                TextBox_Conversion_txt.Text = convert.ToString("N2") & " Meters"
            End If
            End If
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        TextBox_Conversion_txt.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Text = "Choose One..."
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("This filed allows only Numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


   
End Class
