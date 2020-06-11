Public Class Form22
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem
            Case Is = "ayam"
                TextBox1.Text = "Hewan unggas yang biasanya berkokok di pagi hari, biasanya di pelihara sebagai hewan ternak"
            Case Is = "gajah"
                TextBox1.Text = "Salah satu hewab darat terbesar,memiliki gading,belalai dan telinga yang besar"
            Case Is = "jerapah"
                TextBox1.Text = "salah satu hewan teringgi di dunia,memiliki leher dan pemakan tumbuhan"
        End Select
    End Sub

    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("ayam")
        ListBox1.Items.Add("gajah")
        ListBox1.Items.Add("jerapah")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form14.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form23.Show()
    End Sub
End Class