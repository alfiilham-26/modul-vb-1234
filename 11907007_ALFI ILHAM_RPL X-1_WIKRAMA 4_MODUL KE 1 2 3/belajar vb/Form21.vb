Public Class Form21
    Dim a, b As Integer

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form14.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form22.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        If a > b Then
            MsgBox("nilai terbesar adalah : " & a & vbCrLf & "nilai terkecil adalah : " & b)
        ElseIf a = b Then
            MsgBox("nilai pertama dan kedua sama")
        Else
            MsgBox("nilai terbesar adalah : " & b & vbCrLf & "nilai terkecil adalah : " & a)
        End If
    End Sub
End Class