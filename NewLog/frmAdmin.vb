Imports System.IO

Public Class frmAdmin
    Private currentMonday As Date = Now.AddDays(-(Now.DayOfWeek - DayOfWeek.Monday))
    Private currentUser As String
    Private mainPath As String = "P:\Weekly Logs\" + currentUser + "\" + currentMonday.ToLongDateString
    Private Sub GetDirs()
        Dim paths As String() = Directory.GetDirectories("P:\Weekly Logs\")
        Dim i = 0
        For Each path In paths
            paths(i) = path.Substring(path.LastIndexOf("\") + 1, path.Length - path.LastIndexOf("\") - 1)
            i += 1
        Next
        lstUsers.Items.AddRange(paths)
    End Sub
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDirs()
        DateTimePicker1.Value = New Date(Today.Ticks)
        DateTimePicker1.MaxDate = New Date(Now.Ticks)
        DateTimePicker1.MinDate = New Date(Now.Ticks - 6048000000000) ' 6048000000000 ticks is 1 week
    End Sub

    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged
        If lstUsers.SelectedIndex <> -1 Then
            btnViewLog.Enabled = True
            currentUser = lstUsers.SelectedItem.ToString
            mainPath = "P:" + "\Weekly Logs\" + currentUser + "\" + currentMonday.ToLongDateString
            If File.Exists(mainPath + "\Objectives.txt") Then
                Dim objReader As New StreamReader(mainPath + "\Objectives.txt")
                Try
                    lstDailyObjectives.Items.Clear()
                    Dim rawObj As String = objReader.ReadToEnd
                    lstDailyObjectives.Items.AddRange(rawObj.Split(Char.Parse("π")))
                    objReader.Close()
                Catch ex As Exception
                    lstDailyObjectives.Items.Clear()
                    objReader.Close()
                End Try
            Else
                lstDailyObjectives.Items.Clear()
            End If
            If File.Exists(mainPath + "\Goal.txt") Then
                Dim goalReader As New StreamReader(mainPath + "\Goal.txt")
                Try
                    lstGoalM.Items.Clear()
                    Dim rawGoal As String = goalReader.ReadLine
                    lstGoalM.Items.Add(rawGoal)
                    goalReader.Close()
                Catch ex As Exception
                    lstGoalM.Items.Clear()
                    goalReader.Close()
                End Try
            Else
                lstGoalM.Items.Clear()
            End If
            If File.Exists(mainPath + "\" + Now.ToLongDateString + " Comments.txt") Then
                btnComments.Enabled = True
            Else
                btnComments.Enabled = False
            End If
            If File.Exists(mainPath + "\Logs.txt") Then
                btnViewLog.Enabled = True
            Else
                btnViewLog.Enabled = False
            End If
        Else
            lstDailyObjectives.Items.Clear()
            lstGoalM.Items.Clear()
            btnViewLog.Enabled = False
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        currentMonday = DateTimePicker1.Value.AddDays(-(DateTimePicker1.Value.DayOfWeek - DayOfWeek.Monday))
        lstUsers_SelectedIndexChanged(Me, New EventArgs)
    End Sub

    Private Sub lstDailyObjectives_DoubleClick(sender As Object, e As EventArgs) Handles lstDailyObjectives.DoubleClick
        MsgBox(lstDailyObjectives.SelectedItem.ToString, MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub frmAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLoggingSuite.Show()
    End Sub

    Private Sub btnViewLog_Click(sender As Object, e As EventArgs) Handles btnViewLog.Click
        If lstUsers.SelectedIndex <> -1 Then
            If File.Exists(mainPath + "\Logs.txt") Then
                Dim objLogReader As New StreamReader(mainPath + "\Logs.txt")
                Try
                    MsgBox(objLogReader.ReadToEnd().ToString(), MsgBoxStyle.Information, "LOG(" + currentMonday.ToLongDateString + ") | " + lstUsers.SelectedItem.ToString)
                    objLogReader.Close()
                Catch ex As Exception
                    MsgBox("No log for " + lstUsers.SelectedItem.ToString + " exists.", MsgBoxStyle.Exclamation, "Error.")
                End Try
            End If
        End If
    End Sub

    Private Sub lstGoalM_Leave(sender As Object, e As EventArgs) Handles lstGoalM.Leave
        lstGoalM.SelectedIndex = -1
    End Sub

    Private Sub lstDailyObjectives_Leave(sender As Object, e As EventArgs) Handles lstDailyObjectives.Leave
        lstDailyObjectives.SelectedIndex = -1
    End Sub

    Private Sub lstGoalM_DoubleClick(sender As Object, e As EventArgs) Handles lstGoalM.DoubleClick
        MsgBox(lstGoalM.SelectedItem.ToString, MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim comment As String = InputBox("Enter comment for " + lstUsers.SelectedItem.ToString(), "Adding comment...", " ")
        Dim blnCancel As Boolean
        Do
            If comment <> "" Then
                Dim objCommentWriter As New IO.StreamWriter("P:\Weekly Logs\" + lstUsers.SelectedItem.ToString + "\" + frmLoggingSuite.currentMonday.ToLongDateString() + "\" + Now.ToLongDateString() + " " + "Comments.txt")
                objCommentWriter.Write(comment)
                objCommentWriter.Close()
                blnCancel = True
                btnComments.Enabled = True
            Else
                If MsgBox("Are you sure you want to cancel?", vbYesNo, "Cancel?") = MsgBoxResult.Yes Then
                    blnCancel = True
                Else
                    blnCancel = False
                End If
            End If
        Loop Until blnCancel
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If lstUsers.SelectedIndex = -1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnComments_Click(sender As Object, e As EventArgs) Handles btnComments.Click
        Dim sr As New IO.StreamReader(mainPath + "\" + Now.ToLongDateString + " Comments.txt")
        MsgBox(sr.ReadToEnd, MsgBoxStyle.Information, "Viewing Comments.")
        sr.Close()
    End Sub
End Class