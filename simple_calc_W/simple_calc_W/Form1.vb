Public Class Form1

    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim op As String

    Private Sub Button_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click, Button9.Click, Button8.Click, Button3.Click, Button20.Click, Button2.Click, Button14.Click, Button13.Click, Button10.Click, Button1.Click
        Dim b As Button = sender
        If TextBox_Result.Text = "0" Then
            TextBox_Result.Text = b.Text
        Else
            TextBox_Result.Text = TextBox_Result.Text + b.Text
        End If
    End Sub

   

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If Not (TextBox_Result.Text.Contains(".")) Then
            TextBox_Result.Text += "."
        End If
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox_Result.Text = "0"
        Label1.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox_Result.Text = "0"
        Label1.Text = ""

    End Sub


    Private Sub operators(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click, Button4.Click, Button12.Click, Button17.Click
        Dim ops As Button = sender
        f = Val(TextBox_Result.Text)
        Label1.Text = Val(f)
        TextBox_Result.Text = ""
        op = ops.Text
        Label1.Text = Label1.Text + " " + op
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        s = Val(TextBox_Result.Text)
        If op = "+" Then
            a = f + s
            TextBox_Result.Text = a
            Label1.Text = f & " " & op & " " & s
        ElseIf op = "-" Then
            a = f - s
            TextBox_Result.Text = a
            Label1.Text = f & " " & op & " " & s
        ElseIf op = "*" Then
            a = f * s
            TextBox_Result.Text = a
            Label1.Text = f & " " & op & " " & s
        Else
            a = f / s
            TextBox_Result.Text = a
            Label1.Text = f & " " & op & " " & s
        End If
    End Sub


    
    
   
   
   
End Class
