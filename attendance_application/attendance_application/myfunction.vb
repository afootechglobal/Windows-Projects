Imports System.Threading

Module MyFunction
    ' Timer to fade in the form
    Dim fadeTimer As Timer

    ' Method to start fade-in effect
    Public Sub StartFadeIn(form As Form)
        ' Create and start the fade-in timer
        fadeTimer = New Timer(AddressOf FadeIn, form, 0, 50)
    End Sub

    ' Timer callback to gradually change opacity
    Public Sub FadeIn(ByVal state As Object)
        Dim form As Form = CType(state, Form)
        If form.InvokeRequired Then
            form.Invoke(New MethodInvoker(Sub() FadeIn(state)))
        Else
            If form.Opacity < 1 Then
                form.Opacity += 0.07 ' Increment opacity by 5%
            Else
                fadeTimer.Change(Timeout.Infinite, Timeout.Infinite) ' Stop the timer
            End If
        End If
    End Sub




End Module

