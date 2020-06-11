Public Class Form17
    Dim type, fasi As String

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        type = RadioButton2.Text
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        type = RadioButton3.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = type
        If CheckBox1.Checked = True Then
            ListBox1.Items.Add(CheckBox1.Text)
        End If
        If CheckBox2.Checked = True Then
            ListBox1.Items.Add(CheckBox2.Text)
        End If
        If CheckBox3.Checked = True Then
            ListBox1.Items.Add(CheckBox3.Text)
        End If
        If CheckBox4.Checked = True Then
            ListBox1.Items.Add(CheckBox4.Text)
        End If
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form14.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form18.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        type = RadioButton1.Text
    End Sub
End Class