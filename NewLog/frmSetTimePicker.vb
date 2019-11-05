Public Class frmSetTimePicker
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        frmLoggingSuite.strReminderTime = DateTimePicker1.Value.ToLongTimeString
        Close()
    End Sub

    Private Sub frmSetTimePicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Parse(frmLoggingSuite.strReminderTime)
    End Sub

    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOK_Click(Me, New EventArgs)
        End If
    End Sub
End Class