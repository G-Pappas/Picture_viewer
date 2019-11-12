﻿Public Class Form1

    Private Sub showButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showButton.Click


        ' Show the Open File dialog. If the user clicks OK, load the
        ' picture that the user chose.

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click

        'Clear picture

        PictureBox1.Image = Nothing

    End Sub

    Private Sub backgroundButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backgroundButton.Click

        'Change bg colour

        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub closeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click

        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub


End Class
