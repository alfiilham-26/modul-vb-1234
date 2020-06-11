Public Class Form34
    Private Sub Form34_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("Direktur")
            .Add("Manajer")
            .Add("Sekretaris")
            .Add("Wibu")
        End With
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = (Val(TextBox3.Text) + Val(TextBox4.Text)) - (Val(TextBox5.Text) * Val(TextBox3.Text))
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Derektur" Then
            TextBox3.Text = 10000000
            TextBox4.Text = 2500000
            TextBox5.Text = 0.1
        ElseIf ComboBox1.Text = "Manajer" Then
            TextBox3.Text = 70000000
            TextBox4.Text = 2000000
            TextBox5.Text = 0.1
        ElseIf ComboBox1.Text = "Sekretaris" Then
            TextBox3.Text = 40000000
            TextBox4.Text = 1000000
            TextBox5.Text = 0.1
        ElseIf ComboBox1.Text = "Wibu" Then
            TextBox3.Text = 9999999
            TextBox4.Text = 8900000
            TextBox5.Text = 0.99
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form25.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form35.Show()

    End Sub
End Class