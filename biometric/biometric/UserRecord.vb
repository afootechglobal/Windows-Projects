Public Class UserRecord

    Private Sub UserRecord_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()
    End Sub

    Private Sub AddNewUserBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewUserBtn.Click
        MyFuctions.UserEnrollment()
    End Sub

    Private Sub CircleAvatar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CircleAvatar1.Click
        Me.Close()
    End Sub

    Private Sub SearchCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCheckBox.CheckedChanged
        If SearchCheckBox.Checked = True Then
            SearchIDCheckBox.Checked = False
        ElseIf SearchIDCheckBox.Checked = False Then
            SearchCheckBox.Checked = True
        End If
    End Sub

    Private Sub SearchIDCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchIDCheckBox.CheckedChanged
        If SearchIDCheckBox.Checked = True Then
            SearchCheckBox.Checked = False
        ElseIf SearchCheckBox.Checked = False Then
            SearchCheckBox.Checked = True
        End If
    End Sub

End Class