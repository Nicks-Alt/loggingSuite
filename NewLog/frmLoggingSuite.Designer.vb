<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoggingSuite
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoggingSuite))
        Me.lblClock = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.label69 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSchoologyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAbortShutdown = New System.Windows.Forms.Button()
        Me.btnSubmitGoal = New System.Windows.Forms.Button()
        Me.txtSubmitGoal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUpdateCheck = New System.Windows.Forms.Timer(Me.components)
        Me.lstDailyObjectives = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblGoalM = New System.Windows.Forms.Label()
        Me.lstGoalM = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblReminderText = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.yuh = New System.Windows.Forms.Label()
        Me.lblShutdownTimer = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.commentWarning = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.commentWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.Color.Silver
        Me.lblClock.Location = New System.Drawing.Point(45, 30)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(194, 37)
        Me.lblClock.TabIndex = 0
        Me.lblClock.Text = "00:00:00 XX"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.Color.Thistle
        Me.btnRead.FlatAppearance.BorderSize = 0
        Me.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRead.ForeColor = System.Drawing.Color.Black
        Me.btnRead.Location = New System.Drawing.Point(95, 187)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(87, 23)
        Me.btnRead.TabIndex = 2
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Thistle
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(193, 187)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'label69
        '
        Me.label69.AutoSize = True
        Me.label69.BackColor = System.Drawing.Color.Transparent
        Me.label69.Cursor = System.Windows.Forms.Cursors.Default
        Me.label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label69.ForeColor = System.Drawing.Color.Silver
        Me.label69.Location = New System.Drawing.Point(58, 67)
        Me.label69.Name = "label69"
        Me.label69.Size = New System.Drawing.Size(83, 13)
        Me.label69.TabIndex = 5
        Me.label69.Text = "Reminds you at:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(39, 161)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.Thistle
        Me.btnCopy.FlatAppearance.BorderSize = 0
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.ForeColor = System.Drawing.Color.Black
        Me.btnCopy.Location = New System.Drawing.Point(10, 187)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 7
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(573, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenSchoologyToolStripMenuItem, Me.AdminLoginToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenSchoologyToolStripMenuItem
        '
        Me.OpenSchoologyToolStripMenuItem.Name = "OpenSchoologyToolStripMenuItem"
        Me.OpenSchoologyToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.OpenSchoologyToolStripMenuItem.Text = "Open Schoology"
        '
        'AdminLoginToolStripMenuItem
        '
        Me.AdminLoginToolStripMenuItem.Name = "AdminLoginToolStripMenuItem"
        Me.AdminLoginToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AdminLoginToolStripMenuItem.Text = "Admin Login"
        '
        'btnAbortShutdown
        '
        Me.btnAbortShutdown.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAbortShutdown.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAbortShutdown.FlatAppearance.BorderSize = 0
        Me.btnAbortShutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAbortShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbortShutdown.Location = New System.Drawing.Point(0, 260)
        Me.btnAbortShutdown.Name = "btnAbortShutdown"
        Me.btnAbortShutdown.Size = New System.Drawing.Size(573, 22)
        Me.btnAbortShutdown.TabIndex = 11
        Me.btnAbortShutdown.Text = "ABORT SHUTDOWN"
        Me.btnAbortShutdown.UseVisualStyleBackColor = False
        '
        'btnSubmitGoal
        '
        Me.btnSubmitGoal.BackColor = System.Drawing.Color.IndianRed
        Me.btnSubmitGoal.FlatAppearance.BorderSize = 0
        Me.btnSubmitGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitGoal.Location = New System.Drawing.Point(500, 325)
        Me.btnSubmitGoal.Name = "btnSubmitGoal"
        Me.btnSubmitGoal.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmitGoal.TabIndex = 14
        Me.btnSubmitGoal.Text = "Add Goal"
        Me.btnSubmitGoal.UseVisualStyleBackColor = False
        Me.btnSubmitGoal.Visible = False
        '
        'txtSubmitGoal
        '
        Me.txtSubmitGoal.Location = New System.Drawing.Point(380, 327)
        Me.txtSubmitGoal.Name = "txtSubmitGoal"
        Me.txtSubmitGoal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubmitGoal.TabIndex = 15
        Me.txtSubmitGoal.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(112, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 12)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ENTER LOG:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(397, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 12)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "ENTER GOAL:"
        Me.Label2.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'tmrUpdateCheck
        '
        Me.tmrUpdateCheck.Enabled = True
        Me.tmrUpdateCheck.Interval = 10000
        '
        'lstDailyObjectives
        '
        Me.lstDailyObjectives.BackColor = System.Drawing.Color.Silver
        Me.lstDailyObjectives.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstDailyObjectives.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstDailyObjectives.FormattingEnabled = True
        Me.lstDailyObjectives.Location = New System.Drawing.Point(287, 54)
        Me.lstDailyObjectives.Margin = New System.Windows.Forms.Padding(0)
        Me.lstDailyObjectives.Name = "lstDailyObjectives"
        Me.lstDailyObjectives.Size = New System.Drawing.Size(274, 65)
        Me.lstDailyObjectives.TabIndex = 19
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(95, 26)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Thistle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(287, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(274, 24)
        Me.Panel1.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Daily Objectives"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Controls.Add(Me.lblGoalM)
        Me.Panel2.Location = New System.Drawing.Point(287, 145)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(274, 24)
        Me.Panel2.TabIndex = 22
        '
        'lblGoalM
        '
        Me.lblGoalM.AutoSize = True
        Me.lblGoalM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoalM.ForeColor = System.Drawing.Color.Black
        Me.lblGoalM.Location = New System.Drawing.Point(3, 5)
        Me.lblGoalM.Name = "lblGoalM"
        Me.lblGoalM.Size = New System.Drawing.Size(109, 13)
        Me.lblGoalM.TabIndex = 0
        Me.lblGoalM.Text = "Goal Management"
        '
        'lstGoalM
        '
        Me.lstGoalM.BackColor = System.Drawing.Color.Silver
        Me.lstGoalM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstGoalM.ContextMenuStrip = Me.ContextMenuStrip2
        Me.lstGoalM.FormattingEnabled = True
        Me.lstGoalM.Location = New System.Drawing.Point(287, 169)
        Me.lstGoalM.Margin = New System.Windows.Forms.Padding(0)
        Me.lstGoalM.Name = "lstGoalM"
        Me.lstGoalM.Size = New System.Drawing.Size(274, 39)
        Me.lstGoalM.TabIndex = 21
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(95, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripMenuItem1.Text = "Edit"
        '
        'lblReminderText
        '
        Me.lblReminderText.AutoSize = True
        Me.lblReminderText.BackColor = System.Drawing.Color.Transparent
        Me.lblReminderText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReminderText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblReminderText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminderText.ForeColor = System.Drawing.Color.Silver
        Me.lblReminderText.Location = New System.Drawing.Point(144, 67)
        Me.lblReminderText.Name = "lblReminderText"
        Me.lblReminderText.Size = New System.Drawing.Size(68, 13)
        Me.lblReminderText.TabIndex = 23
        Me.lblReminderText.Text = "10:22:00 AM"
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(10, 98)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(258, 57)
        Me.txtInput.TabIndex = 1
        '
        'yuh
        '
        Me.yuh.AutoSize = True
        Me.yuh.BackColor = System.Drawing.Color.Transparent
        Me.yuh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.yuh.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yuh.Location = New System.Drawing.Point(0, 248)
        Me.yuh.Name = "yuh"
        Me.yuh.Size = New System.Drawing.Size(10, 12)
        Me.yuh.TabIndex = 24
        Me.yuh.Text = "π"
        '
        'lblShutdownTimer
        '
        Me.lblShutdownTimer.AutoSize = True
        Me.lblShutdownTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblShutdownTimer.Font = New System.Drawing.Font("Microsoft Yi Baiti", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShutdownTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblShutdownTimer.Location = New System.Drawing.Point(213, 215)
        Me.lblShutdownTimer.Name = "lblShutdownTimer"
        Me.lblShutdownTimer.Size = New System.Drawing.Size(147, 35)
        Me.lblShutdownTimer.TabIndex = 25
        Me.lblShutdownTimer.Text = "00:00:00"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Logging Suite"
        Me.NotifyIcon1.Visible = True
        '
        'commentWarning
        '
        Me.commentWarning.BackColor = System.Drawing.Color.Transparent
        Me.commentWarning.BackgroundImage = CType(resources.GetObject("commentWarning.BackgroundImage"), System.Drawing.Image)
        Me.commentWarning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.commentWarning.Location = New System.Drawing.Point(256, 30)
        Me.commentWarning.Name = "commentWarning"
        Me.commentWarning.Size = New System.Drawing.Size(28, 24)
        Me.commentWarning.TabIndex = 26
        Me.commentWarning.TabStop = False
        Me.commentWarning.Visible = False
        '
        'frmLoggingSuite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.loggingSuite.My.Resources.Resources.background21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(573, 282)
        Me.Controls.Add(Me.commentWarning)
        Me.Controls.Add(Me.lblShutdownTimer)
        Me.Controls.Add(Me.yuh)
        Me.Controls.Add(Me.lblReminderText)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lstGoalM)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lstDailyObjectives)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSubmitGoal)
        Me.Controls.Add(Me.btnSubmitGoal)
        Me.Controls.Add(Me.btnAbortShutdown)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.label69)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoggingSuite"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logging Suite"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.commentWarning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents label69 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCopy As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenSchoologyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAbortShutdown As Button
    Friend WithEvents btnSubmitGoal As Button
    Friend WithEvents txtSubmitGoal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents tmrUpdateCheck As Timer
    Friend WithEvents lstDailyObjectives As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblGoalM As Label
    Friend WithEvents lstGoalM As ListBox
    Friend WithEvents lblReminderText As Label
    Friend WithEvents AdminLoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtInput As TextBox
    Friend WithEvents yuh As Label
    Friend WithEvents lblShutdownTimer As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents commentWarning As PictureBox
End Class
