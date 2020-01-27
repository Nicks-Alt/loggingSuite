Imports System.Data.OleDb

Public Class frmComments
    Private con As OleDbConnection = frmLoggingSuite.con
    Private commentTable As New DataTable
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide()
    End Sub
    Private Sub lstComments_DoubleClick(sender As Object, e As EventArgs) Handles lstComments.DoubleClick
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        If lstComments.SelectedIndex <> -1 Then
            Dim updateCmd As New OleDbCommand("UPDATE Comments SET [_Read] = '1' WHERE [_CommentID] LIKE '" + commentTable.Rows(lstComments.SelectedIndex).Item(0).ToString + "'", con)
            updateCmd.ExecuteNonQuery()
            con.Close()
            frmLoggingSuite.commentWarning.Visible = False
            MsgBox(commentTable.Rows(lstComments.SelectedIndex).Item(3).ToString, MsgBoxStyle.Information, "Comment #" + (lstComments.SelectedIndex + 1).ToString)
            commentTable.Rows.Clear()
            lstComments.Items.RemoveAt(lstComments.SelectedIndex)

            frmComments_Shown(Me, New EventArgs)
        End If
    End Sub

    Private Sub frmComments_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        Dim commentAdapter As New OleDbDataAdapter("SELECT * FROM Comments WHERE [_UName] LIKE '" + Environment.UserName + "' AND [_Read] LIKE '0'", con)

        commentAdapter.Fill(commentTable)
        con.Close()
        Dim strComments As New List(Of Object)
        For i = 0 To commentTable.Rows.Count - 1 ' Row loop
            strComments.Add("Comment #" + (i + 1).ToString + ": " + Date.Parse(commentTable.Rows(i).Item(2).ToString).ToShortDateString)
        Next
        If lstComments.Items.Count = 0 Then
            lstComments.Items.AddRange(strComments.ToArray())
        End If
    End Sub
End Class