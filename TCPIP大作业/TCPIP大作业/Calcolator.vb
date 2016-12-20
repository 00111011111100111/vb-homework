Public Class Calcolator
    Private Sub Calcolator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DToolStripMenuItem.Click

    End Sub

    Private Sub RechargeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RechargeToolStripMenuItem.Click
    End Sub

    Private Sub BackToTheWelcomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToTheWelcomeToolStripMenuItem.Click
        Me.Hide()
        Welcome.Show()
    End Sub

    Private Sub CloseCompleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseCompleteToolStripMenuItem.Click
        Me.Hide()
    End Sub
End Class