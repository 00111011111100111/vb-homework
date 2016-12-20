Public Class Sign_in
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = 0
        While a < 101
            If Account(a) = TextBox1.Text Then
                MessageBox.Show("the Account have been registered! ")
                Exit While
            Else a = a + 1
            End If
            If a = 101 Then
                b = b + 1
            End If
            If b = 101 Then
                MessageBox.Show("Server is Full! Can not Register Now! ", "")
                Exit While
            Else
                If a = 101 Then
                    If TextBox2.Text = TextBox3.Text Then
                        Account(b) = TextBox1.Text
                        Password(b) = TextBox2.Text
                        MessageBox.Show("successfully registered!", "")
                        Me.Hide()
                        Exit While
                    Else
                        MessageBox.Show("Rewrite Your Password again", "")
                        Exit While
                    End If
                End If
            End If


        End While

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class