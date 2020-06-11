Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call nama()
    End Sub
    Sub nama()
        Dim a As String
        a = InputBox("Ketikkan Nama Anda", "Informasi")
        TextBox1.Text = a
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Nama : " & TextBox1.Text & vbCrLf & "Alamat : " & TextBox2.Text & vbCrLf & "Tanggal lahir : " & TextBox3.Text & "-" & TextBox4.Text & "-" & TextBox5.Text, vbInformation, "informasi Tentang Anda")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Call nama()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form10.Show()
    End Sub
End Class