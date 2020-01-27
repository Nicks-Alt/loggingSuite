<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.cmsUpdatePerms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdatePermissionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstDailyObjectives = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblGoalM = New System.Windows.Forms.Label()
        Me.lstGoalM = New System.Windows.Forms.ListBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnViewLog = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditObj = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditGoal = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnComments = New System.Windows.Forms.Button()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsEditGoal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsEditObj = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsUpdatePerms.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.cmsEditGoal.SuspendLayout()
        Me.cmsEditObj.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstUsers
        '
        Me.lstUsers.ContextMenuStrip = Me.cmsUpdatePerms
        Me.lstUsers.Dock = System.Windows.Forms.DockStyle.Right
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Location = New System.Drawing.Point(499, 0)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(133, 263)
        Me.lstUsers.TabIndex = 0
        '
        'cmsUpdatePerms
        '
        Me.cmsUpdatePerms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdatePermissionsToolStripMenuItem})
        Me.cmsUpdatePerms.Name = "cmsUpdatePerms"
        Me.cmsUpdatePerms.Size = New System.Drawing.Size(179, 26)
        '
        'UpdatePermissionsToolStripMenuItem
        '
        Me.UpdatePermissionsToolStripMenuItem.Name = "UpdatePermissionsToolStripMenuItem"
        Me.UpdatePermissionsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.UpdatePermissionsToolStripMenuItem.Text = "Update Permissions"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Thistle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(6, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 24)
        Me.Panel1.TabIndex = 22
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
        'lstDailyObjectives
        '
        Me.lstDailyObjectives.BackColor = System.Drawing.Color.Silver
        Me.lstDailyObjectives.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstDailyObjectives.FormattingEnabled = True
        Me.lstDailyObjectives.Location = New System.Drawing.Point(6, 36)
        Me.lstDailyObjectives.Margin = New System.Windows.Forms.Padding(0)
        Me.lstDailyObjectives.Name = "lstDailyObjectives"
        Me.lstDailyObjectives.Size = New System.Drawing.Size(492, 78)
        Me.lstDailyObjectives.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Controls.Add(Me.lblGoalM)
        Me.Panel2.Location = New System.Drawing.Point(6, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(492, 24)
        Me.Panel2.TabIndex = 24
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
        Me.lstGoalM.FormattingEnabled = True
        Me.lstGoalM.Location = New System.Drawing.Point(6, 159)
        Me.lstGoalM.Margin = New System.Windows.Forms.Padding(0)
        Me.lstGoalM.Name = "lstGoalM"
        Me.lstGoalM.Size = New System.Drawing.Size(492, 39)
        Me.lstGoalM.TabIndex = 23
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 220)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'btnViewLog
        '
        Me.btnViewLog.Enabled = False
        Me.btnViewLog.FlatAppearance.BorderSize = 0
        Me.btnViewLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewLog.Location = New System.Drawing.Point(378, 214)
        Me.btnViewLog.Name = "btnViewLog"
        Me.btnViewLog.Size = New System.Drawing.Size(115, 36)
        Me.btnViewLog.TabIndex = 26
        Me.btnViewLog.Text = "View Log"
        Me.btnViewLog.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditObj, Me.EditGoal})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(154, 70)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AddToolStripMenuItem.Text = "Add Comment"
        '
        'EditObj
        '
        Me.EditObj.Name = "EditObj"
        Me.EditObj.Size = New System.Drawing.Size(153, 22)
        Me.EditObj.Text = "Edit Objective"
        '
        'EditGoal
        '
        Me.EditGoal.Name = "EditGoal"
        Me.EditGoal.Size = New System.Drawing.Size(153, 22)
        Me.EditGoal.Text = "Edit Goal"
        '
        'btnComments
        '
        Me.btnComments.Enabled = False
        Me.btnComments.FlatAppearance.BorderSize = 0
        Me.btnComments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComments.Location = New System.Drawing.Point(243, 214)
        Me.btnComments.Name = "btnComments"
        Me.btnComments.Size = New System.Drawing.Size(115, 36)
        Me.btnComments.TabIndex = 27
        Me.btnComments.Text = "View Comments"
        Me.btnComments.UseVisualStyleBackColor = True
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripMenuItem1.Text = "Edit"
        '
        'cmsEditGoal
        '
        Me.cmsEditGoal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cmsEditGoal.Name = "ContextMenuStrip1"
        Me.cmsEditGoal.Size = New System.Drawing.Size(95, 26)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'cmsEditObj
        '
        Me.cmsEditObj.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.cmsEditObj.Name = "ContextMenuStrip1"
        Me.cmsEditObj.Size = New System.Drawing.Size(95, 26)
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.loggingSuite.My.Resources.Resources.background21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 263)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.btnComments)
        Me.Controls.Add(Me.btnViewLog)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lstUsers)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lstGoalM)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lstDailyObjectives)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdmin"
        Me.Opacity = 0.8R
        Me.Text = "Admin Panel"
        Me.cmsUpdatePerms.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.cmsEditGoal.ResumeLayout(False)
        Me.cmsEditObj.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstUsers As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lstDailyObjectives As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblGoalM As Label
    Friend WithEvents lstGoalM As ListBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnViewLog As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnComments As Button
    Friend WithEvents cmsUpdatePerms As ContextMenuStrip
    Friend WithEvents UpdatePermissionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditObj As ToolStripMenuItem
    Friend WithEvents EditGoal As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents cmsEditGoal As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsEditObj As ContextMenuStrip
End Class
