﻿Public Class Welcome

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Sign_in.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Help.Show()

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Charge.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = 0
        While a < 101
            If TextBox1.Text = "" Then
                MessageBox.Show("Input your Account Please", "ERROR1")
                Exit While
            End If
            If TextBox1.Text = Account(a) Then
                If TextBox2.Text = "" Then
                    MessageBox.Show("Input the Password Please", "ERROE3")   'can not get the message with any action
                    Exit While
                ElseIf TextBox2.Text <> Password(a) Then
                    MessageBox.Show("There's no such a Account or with Wrong Password,Please Rewrite or Register a New Account", "ERROE2")
                    Exit While
                ElseIf TextBox2.Text = Password(a) Then
                    Me.Hide()
                    Calcolator.Show()
                    Exit While
                End If
            Else a = a + 1
            End If
            If a = 101 Then
                MessageBox.Show("There's no such a Account or with Wrong Password,Please Rewrite or Register a New Account", "ERROR3")
                Exit While
            End If
        End While


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
