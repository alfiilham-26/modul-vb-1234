Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) Or TextBox1.Text = "" Then
            MsgBox("Nomor Harus Diisi Dengan Angka", vbCritical)
            TextBox1.Text = ""
        ElseIf (val(TextBox6.Text) < val(TextBox5.text)) Then
            MsgBox("maaf pulsa anda tidak cukup", vbCritical)
        Else
            TextBox7.Text = Val(TextBox7.Text) + Val(TextBox5.Text)
            TextBox6.Text = Val(TextBox8.Text) - Val(TextBox7.Text)
            TextBox1.Text = ""
            TextBox2.Text = ""
            MsgBox("Pesan Berhasil Terikirim", MsgBoxStyle.Information & MsgBoxStyle.OkOnly, "Pesan Terikirim")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Label3.Text = "Karakter : " & Len(TextBox2.Text)
        TextBox5.Text = (Val(TextBox4.Text) * Len(TextBox2.Text)) + Val(TextBox3.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox5.Text = TextBox3.Text
        Button1.Enabled = True
        TextBox6.Text = Val(TextBox6.Text) + Val(TextBox8.Text)
        TextBox7.Text = Val(TextBox8.Text) - Val(TextBox7.Text)


    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form10.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("MAAF PROGRAMNYA BARU SAMPI SINI", vbInformation)
    End Sub
End Class