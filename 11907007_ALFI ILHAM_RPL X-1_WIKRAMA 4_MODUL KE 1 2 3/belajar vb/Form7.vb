Public Class Form7
    Private Sub Textbox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.OrangeRed
    End Sub
    Private Sub Textbox1_lostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub
    Private Sub Textbox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        TextBox2.BackColor = Color.OrangeRed
    End Sub
    Private Sub Textbox2_lostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox2.BackColor = Color.White
    End Sub
    Private Sub Textbox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        TextBox3.BackColor = Color.OrangeRed
    End Sub
    Private Sub Textbox3_lostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        TextBox3.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Maaf Nis Harus Angka", vbCritical)
            TextBox1.Text = ""
            TextBox1.Focus()
        Else
            MsgBox("Nis : " & TextBox1.Text & vbCrLf & "Nama : " & TextBox2.Text & vbCrLf & "Hoby : " & TextBox3.Text, vbInformation)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form10.Show()
    End Sub
End Class