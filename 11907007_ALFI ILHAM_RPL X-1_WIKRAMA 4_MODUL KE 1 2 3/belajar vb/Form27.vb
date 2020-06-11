Public Class Form27
    Sub itung()
        Label3.Text = ListBox2.Items.Count & "Item"
    End Sub

    Sub nambah()
        With ListBox1.Items
            .Add("Nasi Goreng")
            .Add("Nasi Kucing")
            .Add("Nasi Padang")
            .Add("Mie Goreng")
        End With
        itung()
    End Sub

    Private Sub Program_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call nambah()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Pilih pesanan anda")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
        itung()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedItem = "" Then
            MsgBox("Pilih makanan yang anda ingin hilangkan")
        Else
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            itung()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        nambah()
        itung()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form25.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form29.Show()
    End Sub
End Class