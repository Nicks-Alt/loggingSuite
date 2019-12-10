Public Class frmAdminLogin
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If TextBox1.Text = "#REDACTED#" Then
            frmAdmin.Show()
            frmLoggingSuite.Hide()
            Me.Hide()
        Else
            MsgBox("Incorrect Password. Please try again.", MsgBoxStyle.Exclamation, "Incorrect")
            TextBox1.Clear()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOK_Click(Me, New EventArgs)
        End If
    End Sub
End Class