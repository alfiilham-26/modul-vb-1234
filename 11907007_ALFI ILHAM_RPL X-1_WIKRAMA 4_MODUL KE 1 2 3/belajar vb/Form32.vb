Public Class Form32
    Dim s1, s2, s3, s4, s5 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call goldar()
        Call sya()
        MsgBox("NIS : " & TextBox1.Text & vbCrLf & "Nama lengkap : " & TextBox3.Text & vbCrLf & "Alamat : " & TextBox4.Text & vbCrLf & "Tanggal Lahir : " & DateTimePicker1.Value & vbCrLf & "Agama : " & ComboBox1.Text & vbCrLf & "Golongan Darah : " & gol & vbCrLf & "Persyaratan : " & vbCrLf & s1 & vbCrLf & s2 & vbCrLf & s3 & vbCrLf & s4 & vbCrLf & s5)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form25.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form33.Show()

    End Sub

    Dim gol As String
    Private Sub Program_6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("Islam")
            .Add("Kristen")
            .Add("Budha")
            .Add("Hindu")
            .Add("Kong hu cu")
            .Add("Wibu")
        End With
    End Sub

    Sub goldar()
        If RadioButton1.Checked = True Then
            gol = "A"

        ElseIf RadioButton2.Checked = True Then
            gol = "B"

        ElseIf RadioButton3.Checked = True Then
            gol = "AB"

        ElseIf RadioButton4.Checked = True Then
            gol = "O"
        End If
    End Sub

    Sub sya()
        If CheckBox1.Checked = True Then
            s1 = CheckBox1.Text & ":" & "ADA"
        Else
            s1 = CheckBox1.Text & ":" & "BELUM ADA"
        End If
        If CheckBox2.Checked = True Then
            s2 = CheckBox2.Text & ":" & "ADA"
        Else
            s2 = CheckBox2.Text & ":" & "BELUM ADA"
        End If
        If CheckBox3.Checked = True Then
            s3 = CheckBox3.Text & ":" & "ADA"
        Else
            s3 = CheckBox3.Text & ":" & "BELUM ADA"
        End If
        If CheckBox4.Checked = True Then
            s4 = CheckBox4.Text & ":" & "ADA"
        Else
            s4 = CheckBox4.Text & ":" & "BELUM ADA"
        End If
        If CheckBox5.Checked = True Then
            s5 = CheckBox5.Text & ":" & "ADA"
        Else
            s5 = CheckBox5.Text & ":" & "BELUM ADA"
        End If
    End Sub
End Class