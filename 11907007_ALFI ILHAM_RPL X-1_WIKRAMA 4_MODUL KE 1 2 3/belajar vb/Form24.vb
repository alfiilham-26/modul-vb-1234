Public Class Form24
    Dim A, b As Integer

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form25.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form26.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A = TextBox1.Text
        b = TextBox2.Text
        If A > b Then
            MsgBox("nilai a terbesar")
        ElseIf A = b Then
            MsgBox("nilai a dan b sama")
        Else
            MsgBox("nilai b terbesar")
        End If
    End Sub
End Class