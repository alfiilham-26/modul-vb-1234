Public Class Form29
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Sorry makanan tidah boleh kosong")
        Else

            If ListBox1.Items.Contains(TextBox1.Text) Then
                MsgBox("Sorry makanan sudah ada")

            Else
                ListBox1.Items.Add(TextBox1.Text)
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Maaf pilih dahulu makanan yang ingin anda hapus")

        Else
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form25.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form30.Show()

    End Sub
End Class