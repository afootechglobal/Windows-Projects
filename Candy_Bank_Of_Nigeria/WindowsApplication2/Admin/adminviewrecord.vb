﻿Imports MySql.Data.MySqlClient
Public Class adminviewrecord
    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Me.Close()
        adminrecord.Show()
    End Sub

    Private Sub adminwiewrecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.staffRecord()
        Dim result = functions.allCounts
        total_staff_count_label_txt.Text = allCounts.item1.ToString
    End Sub
End Class