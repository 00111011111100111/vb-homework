Public Class Charge
    Private Sub Charge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n = 3

        Account(0) = "admin"
        Password(0) = "admin"
        Account(1) = "1"
        Password(1) = "1"
        Account(2) = "2"
        Password(2) = "2"
        Account(3) = "1351783"
        Password(3) = "1351783"
        q(0) = 1
        q(1) = 2
        q(2) = 3
        q(3) = 4
        q(4) = 5
        q(5) = 6
        w(0) = 1
        w(1) = 2
        w(2) = 3
        w(3) = 4
        w(4) = 5
        w(5) = 6

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ch As Integer
        For k = 0 To 5
            If TextBox1.Text = Account(k) Then
                For v = 0 To 5
                    If TextBox3.Text = q(v) And TextBox4.Text = w(v) Then
                        r(k) = 1
                        MessageBox.Show("Charge Successfully！", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit For
                    Else
                        MessageBox.Show("Wrong Charge Card！", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Next

                ch = 1
            Else
                If (k = n) And (ch = 0) Then
                    MessageBox.Show("Wrong Account!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Next
        ch = 0
    End Sub
End Class