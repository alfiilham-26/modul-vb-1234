﻿Public Class Form23
    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Januari")
        ComboBox1.Items.Add("Februari")
        ComboBox1.Items.Add("Maret")
        ComboBox1.Items.Add("April")
        ComboBox1.Items.Add("Mei")
        ComboBox1.Items.Add("Juni")
        ComboBox1.Items.Add("Juli")
        ComboBox1.Items.Add("Agustus")
        ComboBox1.Items.Add("September")
        ComboBox1.Items.Add("Oktober")
        ComboBox1.Items.Add("November")
        ComboBox1.Items.Add("Desember")
        ComboBox2.Items.Add("2001")
        ComboBox2.Items.Add("2002")
        ComboBox2.Items.Add("2003")
        ComboBox2.Items.Add("2004")
        ComboBox2.Items.Add("2005")
        ComboBox2.Items.Add("2006")
        ComboBox2.Items.Add("2007")
        ComboBox2.Items.Add("2008")
        ComboBox2.Items.Add("2009")
        ComboBox2.Items.Add("2010")
        ComboBox2.Items.Add("2011")
        ComboBox2.Items.Add("2012")
        ComboBox2.Items.Add("2013")
        ComboBox2.Items.Add("2014")
        ComboBox2.Items.Add("2015")
        ComboBox2.Items.Add("2016")
        ComboBox2.Items.Add("2017")
        ComboBox2.Items.Add("2018")
        ComboBox2.Items.Add("2019")
        ComboBox2.Items.Add("2022")
        ComboBox2.Items.Add("2001")
        ComboBox2.Items.Add("2002")
        ComboBox2.Items.Add("2003")
        ComboBox2.Items.Add("2004")
        ComboBox2.Items.Add("2005")
        ComboBox2.Items.Add("2006")
        ComboBox2.Items.Add("2007")
        ComboBox2.Items.Add("2008")
        ComboBox2.Items.Add("2009")
        ComboBox2.Items.Add("2010")
        ComboBox2.Items.Add("2011")
        ComboBox2.Items.Add("2012")
        ComboBox2.Items.Add("2013")
        ComboBox2.Items.Add("2014")
        ComboBox2.Items.Add("2015")
        ComboBox2.Items.Add("2016")
        ComboBox2.Items.Add("2017")
        ComboBox2.Items.Add("2018")
        ComboBox2.Items.Add("2019")
        ComboBox2.Items.Add("2022")
        ComboBox3.Items.Add("islam")
        ComboBox3.Items.Add("kristen")
        ComboBox3.Items.Add("hindu")
        ComboBox3.Items.Add("budha")
        ComboBox3.Items.Add("kong hu cu")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label11.Text = Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox6.Text) + Val(TextBox6.Text)
        Label12.Text = Val(Label11.Text) / 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form14.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("maap programnya baru sampe sini", vbCritical)
    End Sub
End Class