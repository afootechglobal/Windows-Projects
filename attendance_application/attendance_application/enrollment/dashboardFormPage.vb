
Imports System.IO
Public Class dashboardFormPage
    Private Sub Guna2Button1_Click(sender As System.Object, e As System.EventArgs) Handles Guna2Button1.Click
        activeBtn()
        enrollDashboard.enrollBtn.Checked = True
        getPageForm(enrollmentFormPage)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick_1(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ' Format the time as "8:02:04 AM"
        time_label.Text = DateTime.Now.ToString("h:mm:ss tt")

        ' Format the date as "25th December, 2024"
        Dim day As Integer = DateTime.Now.Day
        Dim suffix As String = GetDaySuffix(day)
        date_label.Text = day & suffix & " " & DateTime.Now.ToString("MMMM, yyyy")
    End Sub

    ' Function to determine the suffix for the day (e.g., "st", "nd", "rd", "th")
    Private Function GetDaySuffix(day As Integer) As String
        If day >= 11 And day <= 13 Then
            Return "th"
        End If
        Select Case day Mod 10
            Case 1 : Return "st"
            Case 2 : Return "nd"
            Case 3 : Return "rd"
            Case Else : Return "th"
        End Select
    End Function

    
 
    Private Sub dashboardFormPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cancelField()
    End Sub
End Class