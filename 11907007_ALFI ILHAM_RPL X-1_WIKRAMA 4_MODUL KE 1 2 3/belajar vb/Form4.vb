﻿Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = TextBox1.Text + " " + TextBox2.Text + " " + TextBox3.Text
        TextBox4.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form10.Show()
    End Sub
End Class