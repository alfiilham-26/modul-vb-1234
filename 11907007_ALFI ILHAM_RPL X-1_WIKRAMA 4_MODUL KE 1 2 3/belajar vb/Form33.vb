Public Class Form33
    Private Sub Form33_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("Sumatera")
            .Add("Kalimantan")
            .Add("Jawa")
            .Add("Sulawesi")
            .Add("Papua")
        End With
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case Is = "Sumatera"
                With ListBox1.Items
                    .Clear()
                    .Add("NAD")
                    .Add("Sumatera Utara")
                    .Add("Sumatera Barat")
                    .Add("Palembang")
                    .Add("Lampung")
                    .Add("Riau")
                End With
            Case Is = "Kalimantan"
                With ListBox1.Items
                    .Clear()
                    .Add("Kalimantan Utara")
                    .Add("kalimantan Tengah")
                    .Add("Kalimantan Selatan")
                    .Add("kalimantan Timur")
                    .Add("Kalimantan Barat")
                End With
            Case Is = "Jawa"
                With ListBox1.Items
                    .Clear()
                    .Add("Jawa Barat")
                    .Add("Banten")
                    .Add("Djogyakarta")
                    .Add("Jawa Timur")
                    .Add("Jawa Tengah")
                    .Add("Jakarta")
                End With
            Case Is = "Sulawesi"
                With ListBox1.Items
                    .Clear()
                    .Add("Sulawesi Utara")
                    .Add("Sulawesi Selatan")
                    .Add("Sulawesi Tenggara")
                End With
            Case Is = "Papua"
                With ListBox1.Items
                    .Clear()
                    .Add("Papua Barat")
                End With
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Pilih Provinsi terlebih dahulu")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedItem = "" Then
            MsgBox("Maaf Pilih provinsi yang ingin anda hapus")
        Else
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form25.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form34.Show()

    End Sub
End Class