﻿Public Class Form35
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox7.Text = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text)
        TextBox2.Text = Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox13.Text)
        If TextBox7.Text <> 0 Then
            TextBox18.BackColor = Color.Green
        Else
            TextBox18.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox8.Text = Val(TextBox9.Text) + Val(TextBox10.Text) + Val(TextBox11.Text) + Val(TextBox12.Text)
        TextBox2.Text = Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox13.Text)
        If TextBox7.Text <> 0 Then
            TextBox19.BackColor = Color.Green
        Else
            TextBox19.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox13.Text = Val(TextBox14.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text)
        TextBox2.Text = Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox13.Text)
        If TextBox7.Text <> 0 Then
            TextBox20.BackColor = Color.Green
        Else
            TextBox20.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form25.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form13.Show()
    End Sub
End Class