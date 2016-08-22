Public Class Form1

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click

        Dim medicare As Double = 0
        Dim ssecurity As Double = 0

        If tbPrevIn.Text = 0 Then
            tbPrevWith.Text = 0
        End If
        tbTotalIn.Text = CDbl(tbPrevIn.Text) + CDbl(tbCurrIn.Text)
        If CDbl(tbPrevIn.Text) > 0 And CDbl(tbPrevIn.Text) <= 45000 Then
            medicare = CDbl(tbPrevIn.Text) * 0.0145
            ssecurity = CDbl(tbPrevIn.Text) * 0.062
            tbPrevWith.Text = medicare + ssecurity
        ElseIf CDbl(tbPrevIn.Text) > 45000 And CDbl(tbPrevIn.Text) <= 120000 Then
            tbPrevWith.Text = CDbl(tbPrevIn.Text) * 0.0145
        End If

        If CDbl(tbTotalIn.Text) > 0 And CDbl(tbTotalIn.Text) <= 45000 Then
            medicare = CDbl(tbTotalIn.Text) * 0.0145
            ssecurity = CDbl(tbTotalIn.Text) * 0.062
            tbTotalWith.Text = medicare + ssecurity
        ElseIf CDbl(tbTotalIn.Text) > 45000 And CDbl(tbTotalIn.Text) <= 120000 Then
            tbTotalWith.Text = CDbl(tbTotalIn.Text) * 0.0145
        End If
        tbCurrWith.Text = CDbl(tbTotalWith.Text) - CDbl(tbPrevWith.Text)
    End Sub

    Private Sub tbTotalWith_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbTotalWith.TextChanged

    End Sub

    Private Sub tbTotalIn_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbTotalIn.TextChanged

    End Sub
End Class
