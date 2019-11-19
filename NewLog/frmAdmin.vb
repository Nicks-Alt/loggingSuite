Imports System.IO
Imports System.Data.OleDb

Public Class frmAdmin
    Private currentMonday As Date = Now.AddDays(-(Now.DayOfWeek - DayOfWeek.Monday))
    Private currentUser As String
    Private con As OleDbConnection = frmLoggingSuite.con
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = New Date(Today.Ticks)
        DateTimePicker1.MaxDate = New Date(Now.Ticks)
        DateTimePicker1.MinDate = New Date(Now.Ticks - 6048000000000) ' 6048000000000 ticks is 1 week
        Dim userAdapter As New OleDbDataAdapter("SELECT * FROM Users", con)
        Dim userTable As New DataTable
        userAdapter.Fill(userTable)
        For i = 0 To userTable.Rows.Count - 1
            lstUsers.Items.Add(userTable.Rows(i).Item(0))
        Next
    End Sub

    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged
        If lstUsers.SelectedIndex <> -1 Then
            lstDailyObjectives.Items.Clear()
            lstGoalM.Items.Clear()
            btnViewLog.Enabled = True
            currentUser = lstUsers.SelectedItem.ToString
            Dim objectiveAdapter As New OleDbDataAdapter("SELECT * FROM Objectives WHERE [_UName] LIKE '" + lstUsers.SelectedItem.ToString + "' AND [_MondayDate] LIKE '" + currentMonday.ToShortDateString + "'", con)
            Dim objectiveTable As New DataTable
            objectiveAdapter.Fill(objectiveTable)
            If objectiveTable.Rows.Count = 0 Then
                Dim objectiveInsert As New OleDbCommand("INSERT INTO Objectives (_UName, _MondayDate) VALUES ('" + lstUsers.SelectedItem.ToString + "', '" + currentMonday.ToShortDateString + "')", con)
                objectiveInsert.ExecuteNonQuery()
            End If
            objectiveTable.Rows.Clear()
            objectiveAdapter.Fill(objectiveTable)
            For i = 2 To Now.DayOfWeek + 1
                If objectiveTable.Rows(0).Item(i).ToString = "" AndAlso i < Now.DayOfWeek + 1 Then
                    lstDailyObjectives.Items.Add("Absent.")
                Else
                    lstDailyObjectives.Items.Add(objectiveTable.Rows(0).Item(i).ToString)
                End If
            Next

            Dim goalAdapter As New OleDbDataAdapter("SELECT * FROM Goal WHERE [_UName] LIKE '" + lstUsers.SelectedItem.ToString + "' AND [_MondayDate] LIKE '" + currentMonday.ToShortDateString + "'", con) ' Select the row if it exists
            Dim goalTable As New DataTable
            goalAdapter.Fill(goalTable)
            If goalTable.Rows.Count = 0 Then
                Dim goalInsert As New OleDbCommand("INSERT INTO Goal (_Uname, _MondayDate) VALUES ('" + lstUsers.SelectedItem.ToString + "', '" + currentMonday.ToShortDateString + "')", con) ' Insert a row so its available for updating
                goalInsert.ExecuteNonQuery()
            End If
            goalTable.Rows.Clear()
            goalAdapter.SelectCommand = New OleDbCommand("SELECT [_Entry] FROM Goal WHERE [_UName] LIKE '" + lstUsers.SelectedItem.ToString + "' AND [_MondayDate] LIKE '" + currentMonday.ToShortDateString + "'", con)
            goalAdapter.Fill(goalTable)
            If goalTable.Rows(0).Item(2).ToString <> "" Then
                lstGoalM.Items.Add(goalTable.Rows(0).Item(2).ToString)
            End If
            Dim commentAdapter As New OleDbDataAdapter("SELECT * FROM Comments WHERE [_UName] LIKE '" + lstUsers.SelectedItem.ToString + "' AND [_Read] LIKE '0'", con)
            Dim commentTable As New DataTable
            commentAdapter.Fill(commentTable)
            If commentTable.Rows.Count <> 0 Then
                btnComments.Enabled = True
            Else
                btnComments.Enabled = False
            End If
            Dim logAdapter As New OleDbDataAdapter("SELECT * FROM Logs WHERE [_UName] LIKE '" + lstUsers.SelectedItem.ToString + "' AND [_Monday] LIKE '" + DateTimePicker1.Value.AddDays(-(DateTimePicker1.Value.DayOfWeek - DayOfWeek.Monday)).ToShortDateString + "'", con)
            Dim logTable As New DataTable
            logAdapter.Fill(logTable)
            If logTable.Rows.Count <> 0 Then
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
        'lstUsers_SelectedIndexChanged(Me, New EventArgs)
    End Sub

    Private Sub lstDailyObjectives_DoubleClick(sender As Object, e As EventArgs) Handles lstDailyObjectives.DoubleClick
        MsgBox(lstDailyObjectives.SelectedItem.ToString, MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub frmAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLoggingSuite.Show()
    End Sub

    'Private Sub btnViewLog_Click(sender As Object, e As EventArgs) Handles btnViewLog.Click
    '    If lstUsers.SelectedIndex <> -1 Then
    '        If File.Exists(mainPath + "\Logs.txt") Then
    '            Dim objLogReader As New StreamReader(mainPath + "\Logs.txt")
    '            Try
    '                MsgBox(objLogReader.ReadToEnd().ToString(), MsgBoxStyle.Information, "LOG(" + currentMonday.ToLongDateString + ") | " + lstUsers.SelectedItem.ToString)
    '                objLogReader.Close()
    '            Catch ex As Exception
    '                MsgBox("No log for " + lstUsers.SelectedItem.ToString + " exists.", MsgBoxStyle.Exclamation, "Error.")
    '            End Try
    '        End If
    '    End If
    'End Sub

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
                'Dim objCommentWriter As New IO.StreamWriter("P:\Weekly Logs\" + lstUsers.SelectedItem.ToString + "\" + frmLoggingSuite.currentMonday.ToLongDateString() + "\" + Now.ToLongDateString() + " " + "Comments.txt")
                'objCommentWriter.Write(comment)
                'objCommentWriter.Close()
                Dim objInsertCmd As New OleDbCommand("INSERT INTO Comments (_UName, _Date, _Entry, _Read) VALUES ('" + lstUsers.SelectedItem.ToString + "', '" + Now.ToShortDateString + "', '" + comment + "', '0')", con)
                objInsertCmd.ExecuteNonQuery()
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
        Dim commentAdapter As New OleDbDataAdapter("SELECT * FROM Comments WHERE [_UName] LIKE '" + lstUsers.SelectedItem.ToString + "' AND [_Read] LIKE '0'", con)
        Dim commentTable As New DataTable
        commentAdapter.Fill(commentTable)
        Dim strComments As New List(Of Object)
        For i = 0 To commentTable.Rows.Count - 1 ' Row loop
            strComments.Add(commentTable.Rows(i).Item(2).ToString + " - " + commentTable.Rows(i).Item(3).ToString)
        Next
        Dim displayString As String
        For Each element In strComments
            displayString += element.ToString + Environment.NewLine
        Next
        MsgBox("COMMENTS:" + Environment.NewLine + Environment.NewLine + displayString, MsgBoxStyle.Information, "COMMENTS FOR " + lstUsers.SelectedItem.ToString.ToUpper)
    End Sub

    Private Sub btnViewLog_Click(sender As Object, e As EventArgs) Handles btnViewLog.Click
        'If lstUsers.SelectedIndex <> -1 Then
        '    Dim strLogs As String
        '    Dim logAdapter As New OleDbDataAdapter("SELECT * FROM Logs WHERE [_UName] LIKE '" + lstUsers.SelectedItem.ToString + "' AND [_Monday] LIKE '" + currentMonday.ToShortDateString + "'", con)
        '    Dim logTable As New DataTable
        '    logAdapter.Fill(logTable)       'Zero Based v
        '    currentMonday = DateTimePicker1.Value.AddDays(-(DateTimePicker1.Value.DayOfWeek - DayOfWeek.Monday))
        '    Dim goalAdapter As New OleDbDataAdapter("SELECT * FROM Goal WHERE [_UName] LIKE '" + lstUsers.SelectedItem.ToString + "' AND [_MondayDate] LIKE '" + currentMonday.AddDays(7).ToShortDateString + "'", con)
        '    Dim goalTable As New DataTable
        '    goalAdapter.Fill(goalTable)
        '    strLogs = currentMonday.ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Monday - 1)).ToString + Environment.NewLine + currentMonday.AddDays(1).ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Tuesday - 1)).ToString + Environment.NewLine + currentMonday.AddDays(2).ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Wednesday - 1)).ToString + Environment.NewLine + currentMonday.AddDays(3).ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Thursday - 1)).ToString + Environment.NewLine + currentMonday.AddDays(4).ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Friday - 1)).ToString
        '    If goalTable.Rows.Count <> 0 Then
        '        strLogs += Environment.NewLine + Environment.NewLine + "GOAL FOR NEXT WEEK: " + goalTable.Rows(0).Item(2).ToString
        '    End If
        '    MsgBox(strLogs, vbInformation, "LOGS(" + currentMonday.ToLongDateString + ") | " + lstUsers.SelectedItem.ToString.ToUpper)
        '    currentMonday = Today.AddDays(-(Today.DayOfWeek - DayOfWeek.Monday))
        'End If
        Dim strLogs As String
        Dim logAdapter As New OleDbDataAdapter("SELECT * FROM Logs WHERE [_UName] LIKE '" + lstUsers.SelectedItem.ToString + "' AND [_Monday] LIKE '" + currentMonday.ToShortDateString + "'", con)
        Dim logTable As New DataTable
        logAdapter.Fill(logTable)       'Zero Based v
        currentMonday = DateTimePicker1.Value.AddDays(-(DateTimePicker1.Value.DayOfWeek - DayOfWeek.Monday))
        strLogs = currentMonday.ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Monday - 1)).ToString + Environment.NewLine + currentMonday.AddDays(1).ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Tuesday - 1)).ToString + Environment.NewLine + currentMonday.AddDays(2).ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Wednesday - 1)).ToString + Environment.NewLine + currentMonday.AddDays(3).ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Thursday - 1)).ToString + Environment.NewLine + currentMonday.AddDays(4).ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Friday - 1)).ToString
        MsgBox(strLogs, vbInformation, "LOGS(" + currentMonday.ToLongDateString + ") | " + lstUsers.SelectedItem.ToString.ToUpper)
        currentMonday = Today.AddDays(-(Today.DayOfWeek - DayOfWeek.Monday))
    End Sub
End Class