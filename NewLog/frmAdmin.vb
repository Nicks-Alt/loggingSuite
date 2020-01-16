Imports System.IO
Imports System.Data.OleDb

Public Class frmAdmin
    Private currentMonday As Date = Now.AddDays(-(Now.DayOfWeek - DayOfWeek.Monday))
    Private currentUser As String
    Private con As OleDbConnection = frmLoggingSuite.con
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        DateTimePicker1.Value = New Date(Today.Ticks)
        DateTimePicker1.MaxDate = New Date(Now.Ticks)
        DateTimePicker1.MinDate = New Date(Now.Ticks - 6048000000000) ' 6048000000000 ticks is 1 week
        Dim userAdapter As New OleDbDataAdapter("SELECT * FROM Users", con)
        Dim userTable As New DataTable
        userAdapter.Fill(userTable)
        For i = 0 To userTable.Rows.Count - 1
            lstUsers.Items.Add(userTable.Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
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
        con.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        currentMonday = DateTimePicker1.Value.AddDays(-(DateTimePicker1.Value.DayOfWeek - DayOfWeek.Monday))
        'lstUsers_SelectedIndexChanged(Me, New EventArgs)
    End Sub

    Private Sub lstDailyObjectives_DoubleClick(sender As Object, e As EventArgs) Handles lstDailyObjectives.DoubleClick
        If lstDailyObjectives.SelectedIndex <> -1 Then
            MsgBox(lstDailyObjectives.SelectedItem.ToString, MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub frmAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If frmLoggingSuite.blnIsAdmin = False Then
            frmLoggingSuite.Show()
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
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        Dim comment As String = InputBox("Enter comment for " + lstUsers.SelectedItem.ToString(), "Adding comment...", " ")
        Dim blnCancel As Boolean
        Do
            If comment <> "" Then
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
        con.Close()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If lstUsers.SelectedIndex = -1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnComments_Click(sender As Object, e As EventArgs) Handles btnComments.Click
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
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
        con.Close()
    End Sub

    Private Sub btnViewLog_Click(sender As Object, e As EventArgs) Handles btnViewLog.Click
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        Dim strLogs As String
        Dim logAdapter As New OleDbDataAdapter("SELECT * FROM Logs WHERE [_UName] LIKE '" + lstUsers.SelectedItem.ToString + "' AND [_Monday] LIKE '" + currentMonday.ToShortDateString + "'", con)
        Dim logTable As New DataTable
        logAdapter.Fill(logTable)       'Zero Based v
        currentMonday = DateTimePicker1.Value.AddDays(-(DateTimePicker1.Value.DayOfWeek - DayOfWeek.Monday))
        strLogs = currentMonday.ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Monday - 1)).ToString + Environment.NewLine + currentMonday.AddDays(1).ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Tuesday - 1)).ToString + Environment.NewLine + currentMonday.AddDays(2).ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Wednesday - 1)).ToString + Environment.NewLine + currentMonday.AddDays(3).ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Thursday - 1)).ToString + Environment.NewLine + currentMonday.AddDays(4).ToLongDateString + ": " + logTable.Rows(0).Item(2 + (DayOfWeek.Friday - 1)).ToString
        MsgBox(strLogs, vbInformation, "LOGS(" + currentMonday.ToLongDateString + ") | " + lstUsers.SelectedItem.ToString.ToUpper)
        currentMonday = Today.AddDays(-(Today.DayOfWeek - DayOfWeek.Monday))
        con.Close()
    End Sub

    Private Sub UpdatePermissionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePermissionsToolStripMenuItem.Click
        Dim getCurrentRank As String
        con.Open()
        Dim sqlforRank As New OleDbDataAdapter("SELECT IsAdmin FROM Users WHERE [_Name] = '" + lstUsers.SelectedItem.ToString() + "'", con)
        Dim rankTable As New DataTable
        sqlforRank.Fill(rankTable)
        con.Close()
        If rankTable.Rows(0).ItemArray(0) = "False" Then
            getCurrentRank = "User"
        Else
            getCurrentRank = "Admin"
        End If
        Dim input As String = InputBox("Enter new Permissions for " + lstUsers.SelectedItem.ToString() + "." + Environment.NewLine + Environment.NewLine + "CURRENT RANK: " + getCurrentRank + Environment.NewLine + "0: User" + Environment.NewLine + "1: Admin")
        If input = "1" Then
            con.Open()
            Dim sqlCommand As New OleDbCommand("UPDATE Users SET IsAdmin = True WHERE [_Name] = '" + lstUsers.SelectedItem.ToString() + "'", con)
            sqlCommand.ExecuteNonQuery()
            con.Close()
        ElseIf input = "0" Then
            con.Open()
            Dim sqlCommand As New OleDbCommand("UPDATE Users SET IsAdmin = False WHERE [_Name] = '" + lstUsers.SelectedItem.ToString() + "'", con)
            sqlCommand.ExecuteNonQuery()
            con.Close()
        ElseIf input <> "" Then
            MsgBox("You did not enter 0 or 1. Please enter 0 if you would like to change the user to a regular user, and 1 to an admin.")
        End If
    End Sub

    'Private Sub cmsEditObj_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsEditObj.Opening
    '    If lstDailyObjectives.SelectedIndex = -1 Then
    '        e.Cancel = True
    '    End If
    'End Sub
    Private Sub SaveObjectives()
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        Try
            Dim objectiveCmd As New OleDbCommand
            objectiveCmd.Connection = con
            If lstDailyObjectives.Items.Count = 1 Then
                objectiveCmd.CommandText = "UPDATE Objectives SET [_MondayObj] = '" + lstDailyObjectives.Items.Item(0).ToString
            ElseIf lstDailyObjectives.Items.Count = 2 Then
                objectiveCmd.CommandText = "UPDATE Objectives SET [_MondayObj] = '" + lstDailyObjectives.Items.Item(0).ToString + "', [_TuesdayObj] = '" + lstDailyObjectives.Items.Item(1).ToString()
            ElseIf lstDailyObjectives.Items.Count = 3 Then
                objectiveCmd.CommandText = "UPDATE Objectives SET [_MondayObj] = '" + lstDailyObjectives.Items.Item(0).ToString + "', [_TuesdayObj] = '" + lstDailyObjectives.Items.Item(1).ToString() + "', [_WednesdayObj] = '" + lstDailyObjectives.Items.Item(2).ToString
            ElseIf lstDailyObjectives.Items.Count = 4 Then
                objectiveCmd.CommandText = "UPDATE Objectives SET [_MondayObj] = '" + lstDailyObjectives.Items.Item(0).ToString + "', [_TuesdayObj] = '" + lstDailyObjectives.Items.Item(1).ToString() + "', [_WednesdayObj] = '" + lstDailyObjectives.Items.Item(2).ToString + "', [_ThursdayObj] = '" + lstDailyObjectives.Items.Item(3).ToString
            ElseIf lstDailyObjectives.Items.Count = 5 Then
                objectiveCmd.CommandText = "UPDATE Objectives SET [_MondayObj] = '" + lstDailyObjectives.Items.Item(0).ToString + "', [_TuesdayObj] = '" + lstDailyObjectives.Items.Item(1).ToString() + "', [_WednesdayObj] = '" + lstDailyObjectives.Items.Item(2).ToString + "', [_ThursdayObj] = '" + lstDailyObjectives.Items.Item(3).ToString + "', [_FridayObj] = '" + lstDailyObjectives.Items.Item(4).ToString
            End If
            objectiveCmd.CommandText += "' WHERE [_UName] LIKE '" + Environment.UserName + "' AND [_MondayDate] LIKE '" + currentMonday.ToShortDateString + "'"
            objectiveCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error when saving objectives to the database. Make sure it is not readonly." + Environment.NewLine + Environment.NewLine + "Exception Text:" + Environment.NewLine + ex.Message, MsgBoxStyle.Critical, "ERROR")
            ForceClose()
        End Try
        con.Close()
    End Sub
    Private Sub SaveGoal()
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        Dim goalCmd As New OleDbCommand("UPDATE Goal SET [_Entry] = '" + lstGoalM.Items.Item(0).ToString + "' WHERE [_UName] LIKE '" + Environment.UserName + "' AND [_MondayDate] LIKE '" + currentMonday.ToShortDateString + "'", con)
        goalCmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub ForceClose()
        Shell("taskkill /pid " + Process.GetCurrentProcess().Id.ToString + " /f /t")
    End Sub

    'Private Sub cmsEditGoal_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsEditGoal.Opening
    '    If lstGoalM.SelectedIndex = -1 Then
    '        e.Cancel = True
    '    End If
    'End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click, EditObj.Click
        Dim strEditedItem As String = InputBox("Editing: " & Environment.NewLine & Environment.NewLine & lstDailyObjectives.SelectedItem.ToString(), "Editing Item #" + (lstDailyObjectives.SelectedIndex + 1).ToString(), lstDailyObjectives.SelectedItem.ToString)
        If strEditedItem <> "" Then
            lstDailyObjectives.Items.Insert(lstDailyObjectives.SelectedIndex, strEditedItem)
            lstDailyObjectives.Items.RemoveAt(lstDailyObjectives.SelectedIndex)
            SaveObjectives()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click, EditGoal.Click
        Dim strEditedItem As String = InputBox("Editing: " & Environment.NewLine & Environment.NewLine & lstGoalM.SelectedItem.ToString(), "Editing Goal", lstGoalM.SelectedItem.ToString)
        If strEditedItem <> "" Then
            lstGoalM.Items.Insert(lstGoalM.SelectedIndex, strEditedItem)
            lstGoalM.Items.RemoveAt(lstGoalM.SelectedIndex)
            SaveGoal()
        End If
    End Sub

    Private Sub lstDailyObjectives_SelectedIndexChanged(sender As Object, e As MouseEventArgs) Handles lstDailyObjectives.MouseDown
        'ContextMenuStrip1.Parent = lstDailyObjectives
        If e.Button = MouseButtons.Right And lstDailyObjectives.SelectedIndex = -1 Then
            ContextMenuStrip1.Items(1).Enabled = False
            ContextMenuStrip1.Items(2).Enabled = False
            ContextMenuStrip1.Show()
        ElseIf e.Button = MouseButtons.Right And lstDailyObjectives.SelectedIndex <> -1 Then
            ContextMenuStrip1.Items(1).Enabled = True
            ContextMenuStrip1.Items(2).Enabled = False
            ContextMenuStrip1.Show()
        End If
    End Sub

    Private Sub lstGoalM_MouseDown(sender As Object, e As MouseEventArgs) Handles lstGoalM.MouseDown
        'ContextMenuStrip1.Parent = lstGoalM
        If e.Button = MouseButtons.Right And lstGoalM.SelectedIndex = -1 Then
            ContextMenuStrip1.Items(1).Enabled = False
            ContextMenuStrip1.Items(2).Enabled = False
            ContextMenuStrip1.Show()
        ElseIf e.Button = MouseButtons.Right And lstGoalM.SelectedIndex <> -1 Then
            ContextMenuStrip1.Items(1).Enabled = False
            ContextMenuStrip1.Items(2).Enabled = True
            ContextMenuStrip1.Show()
        End If
    End Sub
End Class