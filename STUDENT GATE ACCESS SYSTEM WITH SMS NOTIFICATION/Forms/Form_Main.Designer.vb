<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Dim panelBottom As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.LogOutbutton = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.ptbHomeIcon = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Homebutton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Studentrecordsbutton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Studentlogsbutton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SMSbutton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCreateAnotherAccount = New System.Windows.Forms.Button()
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Home = New System.Windows.Forms.ToolStripButton()
        Me.Separator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentRecords = New System.Windows.Forms.ToolStripButton()
        Me.Separator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentLogs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ptbMain = New System.Windows.Forms.PictureBox()
        Me.lblAddressOfTheSchool = New System.Windows.Forms.Label()
        Me.lblNameOfTheSchool = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        panelBottom = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.ptbHomeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ptbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBottom
        '
        panelBottom.BackColor = System.Drawing.Color.Black
        panelBottom.CausesValidation = False
        panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        panelBottom.Enabled = False
        panelBottom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        panelBottom.ForeColor = System.Drawing.Color.Transparent
        panelBottom.Location = New System.Drawing.Point(0, 628)
        panelBottom.Name = "panelBottom"
        panelBottom.Size = New System.Drawing.Size(1177, 59)
        panelBottom.TabIndex = 9
        panelBottom.TabStop = False
        panelBottom.UseMnemonic = False
        panelBottom.UseVisualStyleBackColor = False
        '
        'LogOutbutton
        '
        Me.LogOutbutton.BackColor = System.Drawing.Color.SaddleBrown
        Me.LogOutbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogOutbutton.FlatAppearance.BorderSize = 0
        Me.LogOutbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.LogOutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOutbutton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutbutton.ForeColor = System.Drawing.Color.White
        Me.LogOutbutton.Location = New System.Drawing.Point(1041, 645)
        Me.LogOutbutton.Name = "LogOutbutton"
        Me.LogOutbutton.Size = New System.Drawing.Size(100, 28)
        Me.LogOutbutton.TabIndex = 6
        Me.LogOutbutton.Text = "LOG OUT"
        Me.LogOutbutton.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.FlatAppearance.BorderSize = 0
        Me.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Location = New System.Drawing.Point(620, 645)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(163, 28)
        Me.btnChangePassword.TabIndex = 5
        Me.btnChangePassword.Text = "CHANGE PASSWORD"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.ptbHomeIcon)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(-1, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1178, 51)
        Me.Panel1.TabIndex = 10
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.CLOSEBUTTON
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1133, 17)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 21)
        Me.btnClose.TabIndex = 67
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.MINIMIZEBUTTON
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(1087, 17)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 21)
        Me.btnMinimize.TabIndex = 66
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'ptbHomeIcon
        '
        Me.ptbHomeIcon.BackColor = System.Drawing.Color.SaddleBrown
        Me.ptbHomeIcon.BackgroundImage = CType(resources.GetObject("ptbHomeIcon.BackgroundImage"), System.Drawing.Image)
        Me.ptbHomeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHomeIcon.ErrorImage = Nothing
        Me.ptbHomeIcon.Location = New System.Drawing.Point(687, 10)
        Me.ptbHomeIcon.Name = "ptbHomeIcon"
        Me.ptbHomeIcon.Size = New System.Drawing.Size(46, 28)
        Me.ptbHomeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbHomeIcon.TabIndex = 65
        Me.ptbHomeIcon.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(623, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(68, 28)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "HOME"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(126, 6)
        '
        'Homebutton
        '
        Me.Homebutton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Homebutton.Image = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.HOMEBLACK
        Me.Homebutton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Homebutton.Name = "Homebutton"
        Me.Homebutton.Size = New System.Drawing.Size(126, 40)
        Me.Homebutton.Text = "Home"
        Me.Homebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(126, 6)
        '
        'Studentrecordsbutton
        '
        Me.Studentrecordsbutton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Studentrecordsbutton.Image = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.STUDENTRECORDS
        Me.Studentrecordsbutton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Studentrecordsbutton.Name = "Studentrecordsbutton"
        Me.Studentrecordsbutton.Size = New System.Drawing.Size(126, 41)
        Me.Studentrecordsbutton.Text = "Student Records"
        Me.Studentrecordsbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(126, 6)
        '
        'Studentlogsbutton
        '
        Me.Studentlogsbutton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Studentlogsbutton.Image = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.STUDENTLOGS
        Me.Studentlogsbutton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Studentlogsbutton.Name = "Studentlogsbutton"
        Me.Studentlogsbutton.Size = New System.Drawing.Size(126, 40)
        Me.Studentlogsbutton.Text = "Student Logs"
        Me.Studentlogsbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(126, 6)
        '
        'SMSbutton
        '
        Me.SMSbutton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SMSbutton.Image = CType(resources.GetObject("SMSbutton.Image"), System.Drawing.Image)
        Me.SMSbutton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SMSbutton.Name = "SMSbutton"
        Me.SMSbutton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SMSbutton.Size = New System.Drawing.Size(126, 40)
        Me.SMSbutton.Text = "SMS Logs"
        Me.SMSbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.Black
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(126, 6)
        '
        'btnCreateAnotherAccount
        '
        Me.btnCreateAnotherAccount.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCreateAnotherAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCreateAnotherAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateAnotherAccount.FlatAppearance.BorderSize = 0
        Me.btnCreateAnotherAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnCreateAnotherAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateAnotherAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAnotherAccount.ForeColor = System.Drawing.Color.White
        Me.btnCreateAnotherAccount.Location = New System.Drawing.Point(159, 645)
        Me.btnCreateAnotherAccount.Name = "btnCreateAnotherAccount"
        Me.btnCreateAnotherAccount.Size = New System.Drawing.Size(218, 28)
        Me.btnCreateAnotherAccount.TabIndex = 12
        Me.btnCreateAnotherAccount.Text = "CREATE ANOTHER ACCOUNT"
        Me.btnCreateAnotherAccount.UseVisualStyleBackColor = False
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(137, 6)
        '
        'Home
        '
        Me.Home.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home.Image = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.HOMEBLACK
        Me.Home.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(137, 40)
        Me.Home.Text = "Home"
        Me.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(137, 6)
        '
        'StudentRecords
        '
        Me.StudentRecords.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentRecords.Image = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.STUDENTRECORDS
        Me.StudentRecords.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StudentRecords.Name = "StudentRecords"
        Me.StudentRecords.Size = New System.Drawing.Size(137, 41)
        Me.StudentRecords.Text = "Student Records"
        Me.StudentRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Separator3
        '
        Me.Separator3.Name = "Separator3"
        Me.Separator3.Size = New System.Drawing.Size(137, 6)
        '
        'StudentLogs
        '
        Me.StudentLogs.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentLogs.Image = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.STUDENTLOGS
        Me.StudentLogs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StudentLogs.Name = "StudentLogs"
        Me.StudentLogs.Size = New System.Drawing.Size(137, 40)
        Me.StudentLogs.Text = "Student Logs"
        Me.StudentLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(137, 6)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Separator1, Me.Home, Me.Separator2, Me.StudentRecords, Me.Separator3, Me.StudentLogs, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(139, 628)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ptbMain
        '
        Me.ptbMain.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.PIC1
        Me.ptbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbMain.Location = New System.Drawing.Point(206, 199)
        Me.ptbMain.Name = "ptbMain"
        Me.ptbMain.Size = New System.Drawing.Size(920, 391)
        Me.ptbMain.TabIndex = 14
        Me.ptbMain.TabStop = False
        '
        'lblAddressOfTheSchool
        '
        Me.lblAddressOfTheSchool.AutoSize = True
        Me.lblAddressOfTheSchool.BackColor = System.Drawing.Color.Transparent
        Me.lblAddressOfTheSchool.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressOfTheSchool.ForeColor = System.Drawing.Color.Black
        Me.lblAddressOfTheSchool.Location = New System.Drawing.Point(332, 150)
        Me.lblAddressOfTheSchool.Name = "lblAddressOfTheSchool"
        Me.lblAddressOfTheSchool.Size = New System.Drawing.Size(695, 33)
        Me.lblAddressOfTheSchool.TabIndex = 131
        Me.lblAddressOfTheSchool.Text = "(New Panaderos Street, Santa Ana, Manila, Metro Manila)"
        '
        'lblNameOfTheSchool
        '
        Me.lblNameOfTheSchool.AutoSize = True
        Me.lblNameOfTheSchool.BackColor = System.Drawing.Color.Transparent
        Me.lblNameOfTheSchool.Font = New System.Drawing.Font("Tahoma", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOfTheSchool.ForeColor = System.Drawing.Color.Black
        Me.lblNameOfTheSchool.Location = New System.Drawing.Point(191, 62)
        Me.lblNameOfTheSchool.Name = "lblNameOfTheSchool"
        Me.lblNameOfTheSchool.Size = New System.Drawing.Size(948, 88)
        Me.lblNameOfTheSchool.TabIndex = 130
        Me.lblNameOfTheSchool.Text = "SAINT FRANCIS SCHOOL"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1177, 687)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblAddressOfTheSchool)
        Me.Controls.Add(Me.lblNameOfTheSchool)
        Me.Controls.Add(Me.ptbMain)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnCreateAnotherAccount)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.LogOutbutton)
        Me.Controls.Add(panelBottom)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(6, 29)
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ptbHomeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ptbMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogOutbutton As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents ptbHomeIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Homebutton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Studentlogsbutton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Studentrecordsbutton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SMSbutton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCreateAnotherAccount As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Home As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StudentRecords As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StudentLogs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ptbMain As System.Windows.Forms.PictureBox
    Friend WithEvents lblAddressOfTheSchool As System.Windows.Forms.Label
    Friend WithEvents lblNameOfTheSchool As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
