Public Class frmComments
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide()
    End Sub
    Private Sub lstComments_DoubleClick(sender As Object, e As EventArgs) Handles lstComments.DoubleClick
        If lstComments.SelectedIndex <> -1 Then
            Dim sr As New IO.StreamReader("P:\Weekly Logs\" + Environment.UserName + "\" + frmLoggingSuite.currentMonday.ToLongDateString() + "\" + frmLoggingSuite.commentFileNames.Item(lstComments.SelectedIndex).Name)
            MsgBox(sr.ReadToEnd, MsgBoxStyle.Information, "Comments")
            sr.Close()
            If IO.Directory.Exists("P:\Weekly Logs\" + Environment.UserName + "\" + frmLoggingSuite.currentMonday.ToLongDateString() + "\Comments") = False Then
                IO.Directory.CreateDirectory("P:\Weekly Logs\" + Environment.UserName + "\" + frmLoggingSuite.currentMonday.ToLongDateString() + "\Comments")
            End If
            Try
                IO.File.Move(frmLoggingSuite.commentFileNames.Item(lstComments.SelectedIndex).FullName, "P:\Weekly Logs\" + Environment.UserName + "\" + frmLoggingSuite.currentMonday.ToLongDateString() + "\Comments\" + frmLoggingSuite.commentFileNames.Item(lstComments.SelectedIndex).Name) ' Delete file to save space since it is already viewed
            Catch ex As IO.FileNotFoundException
                IO.File.Move(frmLoggingSuite.commentFileNames.Item(lstComments.SelectedIndex).FullName, "P:\Weekly Logs\" + Environment.UserName + "\" + frmLoggingSuite.currentMonday.AddDays(-7).ToLongDateString() + "\Comments\" + frmLoggingSuite.commentFileNames.Item(lstComments.SelectedIndex).Name) ' Delete file to save space since it is already viewed
            Catch ex As IO.IOException
                IO.File.Delete("P:\Weekly Logs\" + Environment.UserName + "\" + frmLoggingSuite.currentMonday.ToLongDateString() + "\Comments\" + frmLoggingSuite.commentFileNames.Item(lstComments.SelectedIndex).Name)
                IO.File.Move(frmLoggingSuite.commentFileNames.Item(lstComments.SelectedIndex).FullName, "P:\Weekly Logs\" + Environment.UserName + "\" + frmLoggingSuite.currentMonday.ToLongDateString() + "\Comments\" + frmLoggingSuite.commentFileNames.Item(lstComments.SelectedIndex).Name) ' Delete file to save space since it is already viewed
            End Try
            frmLoggingSuite.commentWarning.Visible = False
            frmLoggingSuite.commentFileNames.RemoveAt(lstComments.SelectedIndex)
            lstComments.Items.RemoveAt(lstComments.SelectedIndex)
        End If
    End Sub

    Private Sub frmComments_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim i As Integer
        For Each item In lstComments.Items

            ' Wont let me change the name of the file
        Next
    End Sub
End Class