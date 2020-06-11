Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox2.Text = "Persegi"
        Label1.Text = "Sisi"
        TextBox2.Visible = False
        TextBox2.Text = ""
        Label2.Visible = False
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox1.Text)
        TextBox2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox2.Text = "Persegi Panjang"
        Label1.Text = "Panjang"
        Label2.Text = "lebar"
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        TextBox2.Visible = True
        Label2.Visible = True
        TextBox2.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox2.Text = "Segitiga Siku-Siku"
        Label1.Text = "Alas"
        Label2.Text = "Tinggi"
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text) / 2
        TextBox2.Visible = True
        Label2.Visible = True
        TextBox2.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox2.Text = "Jajar Genjang"
        Label1.Text = "Alas"
        Label2.Text = "Tinggi"
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        TextBox2.Visible = True
        Label2.Visible = True
        TextBox2.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox2.Text = "Lingkaran"
        Label1.Text = "Jari-Jari"
        Label2.Text = "phi"
        TextBox2.Text = "3.14"
        TextBox3.Text = Val(TextBox2.Text) * Val(TextBox1.Text) * 3.14
        TextBox2.Visible = True
        Label2.Visible = True
        TextBox2.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form11.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form10.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Enabled = False
    End Sub
End Class