Public Class Form1

   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose One..."
        ComboBox1.Items.Add("INITIAL PRESSURE (P1)")
        ComboBox1.Items.Add("FINAL PRESSURE (P2)")
        ComboBox1.Items.Add("INITIAL VOLUME (V1)")
        ComboBox1.Items.Add("FINAL VOLUME (V2)")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result, a As Double
        If ComboBox1.Text = "Choose One..." Then
            MessageBox.Show("Opps! Choose Operation to Continue!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf initial_pressure_txt.Text = "" Or final_pressure_txt.Text = "" Or initial_volume_txt.Text = "" Or final_volume_txt.Text = "" Then
            MessageBox.Show("Error! Enter Input for all Fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If ComboBox1.Text = "INITIAL PRESSURE (P1)" Then
                a = final_pressure_txt.Text * final_volume_txt.Text
                result = a / initial_volume_txt.Text
                result_txt.Text = result.ToString("N2")
            ElseIf ComboBox1.Text = "FINAL PRESSURE (P2)" Then
                a = initial_pressure_txt.Text * initial_volume_txt.Text
                result = a / final_volume_txt.Text
                result_txt.Text = result.ToString("N2")
            ElseIf ComboBox1.Text = "INITIAL VOLUME (V1)" Then
                a = final_pressure_txt.Text * final_volume_txt.Text
                result = a / initial_pressure_txt.Text
                result_txt.Text = result.ToString("N2")
            ElseIf ComboBox1.Text = "FINAL VOLUME (V2)" Then
                a = initial_pressure_txt.Text * initial_volume_txt.Text
                result = a / final_pressure_txt.Text
                result_txt.Text = result.ToString("N2")
            End If
        End If





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        initial_pressure_txt.Text = ""
        final_pressure_txt.Text = ""
        initial_volume_txt.Text = ""
        final_volume_txt.Text = ""
        result_txt.Text = ""
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

End Class
