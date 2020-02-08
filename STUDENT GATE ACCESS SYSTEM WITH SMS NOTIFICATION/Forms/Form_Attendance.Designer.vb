<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Attendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Attendance))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.txtYearLevel = New System.Windows.Forms.TextBox()
        Me.lblDayNow = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.lblTitleOfTheSystem = New System.Windows.Forms.Label()
        Me.ptbIconOfSystem = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ptbLogoOfSchool = New System.Windows.Forms.PictureBox()
        Me.panelUpper = New System.Windows.Forms.Panel()
        Me.lblTimeNow = New System.Windows.Forms.Label()
        Me.lblAddressOfSchool = New System.Windows.Forms.Label()
        Me.lblNameOfSchool = New System.Windows.Forms.Label()
        Me.ptbProfile = New System.Windows.Forms.PictureBox()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.gbCenter = New System.Windows.Forms.GroupBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtGetRFId = New System.Windows.Forms.TextBox()
        Me.btnGoToLogin = New System.Windows.Forms.Button()
        Me.panelLower = New System.Windows.Forms.Panel()
        Me.panelTop.SuspendLayout()
        CType(Me.ptbIconOfSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbLogoOfSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelUpper.SuspendLayout()
        CType(Me.ptbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCenter.SuspendLayout()
        Me.panelLower.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblDateToday
        '
        Me.lblDateToday.AutoSize = True
        Me.lblDateToday.BackColor = System.Drawing.Color.Khaki
        Me.lblDateToday.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateToday.ForeColor = System.Drawing.Color.Black
        Me.lblDateToday.Location = New System.Drawing.Point(371, 148)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(233, 47)
        Me.lblDateToday.TabIndex = 78
        Me.lblDateToday.Text = "DATE TODAY"
        '
        'txtYearLevel
        '
        Me.txtYearLevel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtYearLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYearLevel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtYearLevel.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearLevel.ForeColor = System.Drawing.Color.White
        Me.txtYearLevel.Location = New System.Drawing.Point(758, 172)
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.Size = New System.Drawing.Size(560, 57)
        Me.txtYearLevel.TabIndex = 0
        Me.txtYearLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDayNow
        '
        Me.lblDayNow.AutoSize = True
        Me.lblDayNow.BackColor = System.Drawing.Color.Khaki
        Me.lblDayNow.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayNow.ForeColor = System.Drawing.Color.Black
        Me.lblDayNow.Location = New System.Drawing.Point(785, 145)
        Me.lblDayNow.Name = "lblDayNow"
        Me.lblDayNow.Size = New System.Drawing.Size(188, 47)
        Me.lblDayNow.TabIndex = 128
        Me.lblDayNow.Text = "DAY NOW"
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelTop.Controls.Add(Me.lblTitleOfTheSystem)
        Me.panelTop.Controls.Add(Me.ptbIconOfSystem)
        Me.panelTop.Controls.Add(Me.btnMinimize)
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Location = New System.Drawing.Point(-2, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1346, 35)
        Me.panelTop.TabIndex = 132
        '
        'lblTitleOfTheSystem
        '
        Me.lblTitleOfTheSystem.AutoSize = True
        Me.lblTitleOfTheSystem.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleOfTheSystem.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleOfTheSystem.ForeColor = System.Drawing.Color.White
        Me.lblTitleOfTheSystem.Location = New System.Drawing.Point(439, 7)
        Me.lblTitleOfTheSystem.Name = "lblTitleOfTheSystem"
        Me.lblTitleOfTheSystem.Size = New System.Drawing.Size(519, 25)
        Me.lblTitleOfTheSystem.TabIndex = 122
        Me.lblTitleOfTheSystem.Text = "STUDENT GATE ACCESS SYSTEM WITH SMS NOTIFICATION"
        '
        'ptbIconOfSystem
        '
        Me.ptbIconOfSystem.BackColor = System.Drawing.Color.SaddleBrown
        Me.ptbIconOfSystem.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.MYICON
        Me.ptbIconOfSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbIconOfSystem.ErrorImage = Nothing
        Me.ptbIconOfSystem.Location = New System.Drawing.Point(8, 4)
        Me.ptbIconOfSystem.Name = "ptbIconOfSystem"
        Me.ptbIconOfSystem.Size = New System.Drawing.Size(26, 25)
        Me.ptbIconOfSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbIconOfSystem.TabIndex = 66
        Me.ptbIconOfSystem.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnMinimize.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.MINIMIZEBUTTON
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(1249, 7)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 21)
        Me.btnMinimize.TabIndex = 6
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnClose.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.CLOSEBUTTON
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1295, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 21)
        Me.btnClose.TabIndex = 5
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ptbLogoOfSchool
        '
        Me.ptbLogoOfSchool.BackColor = System.Drawing.Color.Transparent
        Me.ptbLogoOfSchool.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.SAINT_FRANCIS_LOGO
        Me.ptbLogoOfSchool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLogoOfSchool.ErrorImage = Nothing
        Me.ptbLogoOfSchool.Location = New System.Drawing.Point(35, 6)
        Me.ptbLogoOfSchool.Name = "ptbLogoOfSchool"
        Me.ptbLogoOfSchool.Size = New System.Drawing.Size(271, 186)
        Me.ptbLogoOfSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbLogoOfSchool.TabIndex = 118
        Me.ptbLogoOfSchool.TabStop = False
        '
        'panelUpper
        '
        Me.panelUpper.BackColor = System.Drawing.Color.Khaki
        Me.panelUpper.Controls.Add(Me.lblTimeNow)
        Me.panelUpper.Controls.Add(Me.lblAddressOfSchool)
        Me.panelUpper.Controls.Add(Me.lblNameOfSchool)
        Me.panelUpper.Controls.Add(Me.ptbLogoOfSchool)
        Me.panelUpper.Controls.Add(Me.lblDayNow)
        Me.panelUpper.Controls.Add(Me.lblDateToday)
        Me.panelUpper.Location = New System.Drawing.Point(-2, 35)
        Me.panelUpper.Name = "panelUpper"
        Me.panelUpper.Size = New System.Drawing.Size(1362, 195)
        Me.panelUpper.TabIndex = 134
        '
        'lblTimeNow
        '
        Me.lblTimeNow.AutoSize = True
        Me.lblTimeNow.BackColor = System.Drawing.Color.Khaki
        Me.lblTimeNow.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeNow.ForeColor = System.Drawing.Color.Black
        Me.lblTimeNow.Location = New System.Drawing.Point(1052, 145)
        Me.lblTimeNow.Name = "lblTimeNow"
        Me.lblTimeNow.Size = New System.Drawing.Size(205, 47)
        Me.lblTimeNow.TabIndex = 130
        Me.lblTimeNow.Text = "TIME NOW"
        '
        'lblAddressOfSchool
        '
        Me.lblAddressOfSchool.AutoSize = True
        Me.lblAddressOfSchool.BackColor = System.Drawing.Color.Transparent
        Me.lblAddressOfSchool.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressOfSchool.ForeColor = System.Drawing.Color.Black
        Me.lblAddressOfSchool.Location = New System.Drawing.Point(473, 98)
        Me.lblAddressOfSchool.Name = "lblAddressOfSchool"
        Me.lblAddressOfSchool.Size = New System.Drawing.Size(695, 33)
        Me.lblAddressOfSchool.TabIndex = 129
        Me.lblAddressOfSchool.Text = "(New Panaderos Street, Santa Ana, Manila, Metro Manila)"
        '
        'lblNameOfSchool
        '
        Me.lblNameOfSchool.AutoSize = True
        Me.lblNameOfSchool.BackColor = System.Drawing.Color.Transparent
        Me.lblNameOfSchool.Font = New System.Drawing.Font("Tahoma", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOfSchool.ForeColor = System.Drawing.Color.Black
        Me.lblNameOfSchool.Location = New System.Drawing.Point(338, 10)
        Me.lblNameOfSchool.Name = "lblNameOfSchool"
        Me.lblNameOfSchool.Size = New System.Drawing.Size(948, 88)
        Me.lblNameOfSchool.TabIndex = 123
        Me.lblNameOfSchool.Text = "SAINT FRANCIS SCHOOL"
        '
        'ptbProfile
        '
        Me.ptbProfile.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ptbProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbProfile.ErrorImage = Nothing
        Me.ptbProfile.Image = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.usericon
        Me.ptbProfile.Location = New System.Drawing.Point(31, 31)
        Me.ptbProfile.Name = "ptbProfile"
        Me.ptbProfile.Size = New System.Drawing.Size(500, 379)
        Me.ptbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbProfile.TabIndex = 64
        Me.ptbProfile.TabStop = False
        '
        'txtStudentId
        '
        Me.txtStudentId.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtStudentId.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentId.ForeColor = System.Drawing.Color.White
        Me.txtStudentId.Location = New System.Drawing.Point(758, 109)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(560, 57)
        Me.txtStudentId.TabIndex = 0
        Me.txtStudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbCenter
        '
        Me.gbCenter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbCenter.BackColor = System.Drawing.Color.Transparent
        Me.gbCenter.Controls.Add(Me.ptbProfile)
        Me.gbCenter.Controls.Add(Me.txtFullName)
        Me.gbCenter.Controls.Add(Me.lblFullName)
        Me.gbCenter.Controls.Add(Me.lblYearLevel)
        Me.gbCenter.Controls.Add(Me.txtStudentId)
        Me.gbCenter.Controls.Add(Me.lblStudentId)
        Me.gbCenter.Controls.Add(Me.txtStatus)
        Me.gbCenter.Controls.Add(Me.txtYearLevel)
        Me.gbCenter.Controls.Add(Me.lblStatus)
        Me.gbCenter.Controls.Add(Me.lblDate)
        Me.gbCenter.Controls.Add(Me.txtTime)
        Me.gbCenter.Controls.Add(Me.lblTime)
        Me.gbCenter.Controls.Add(Me.txtDate)
        Me.gbCenter.Controls.Add(Me.txtGetRFId)
        Me.gbCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbCenter.ForeColor = System.Drawing.Color.Black
        Me.gbCenter.Location = New System.Drawing.Point(-2, 224)
        Me.gbCenter.Name = "gbCenter"
        Me.gbCenter.Size = New System.Drawing.Size(1343, 439)
        Me.gbCenter.TabIndex = 102
        Me.gbCenter.TabStop = False
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.White
        Me.txtFullName.Location = New System.Drawing.Point(758, 46)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(560, 57)
        Me.txtFullName.TabIndex = 142
        Me.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.White
        Me.lblFullName.Location = New System.Drawing.Point(561, 50)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(191, 47)
        Me.lblFullName.TabIndex = 141
        Me.lblFullName.Text = "    NAME   "
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblYearLevel.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearLevel.ForeColor = System.Drawing.Color.White
        Me.lblYearLevel.Location = New System.Drawing.Point(549, 176)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(206, 47)
        Me.lblYearLevel.TabIndex = 141
        Me.lblYearLevel.Text = "YEAR LEVEL"
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblStudentId.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentId.ForeColor = System.Drawing.Color.White
        Me.lblStudentId.Location = New System.Drawing.Point(564, 113)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(188, 47)
        Me.lblStudentId.TabIndex = 141
        Me.lblStudentId.Text = "    ID NO   "
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.White
        Me.txtStatus.Location = New System.Drawing.Point(758, 355)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(560, 57)
        Me.txtStatus.TabIndex = 136
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(583, 359)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(170, 47)
        Me.lblStatus.TabIndex = 135
        Me.lblStatus.Text = "  STATUS "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(579, 237)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(173, 47)
        Me.lblDate.TabIndex = 93
        Me.lblDate.Text = "    DATE   "
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTime.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.White
        Me.txtTime.Location = New System.Drawing.Point(758, 295)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(560, 57)
        Me.txtTime.TabIndex = 0
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(583, 299)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(169, 47)
        Me.lblTime.TabIndex = 84
        Me.lblTime.Text = "    TIME   "
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.White
        Me.txtDate.Location = New System.Drawing.Point(758, 235)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(560, 54)
        Me.txtDate.TabIndex = 0
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGetRFId
        '
        Me.txtGetRFId.BackColor = System.Drawing.Color.Yellow
        Me.txtGetRFId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGetRFId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGetRFId.ForeColor = System.Drawing.Color.Black
        Me.txtGetRFId.Location = New System.Drawing.Point(126, 113)
        Me.txtGetRFId.MaxLength = 10
        Me.txtGetRFId.Name = "txtGetRFId"
        Me.txtGetRFId.Size = New System.Drawing.Size(270, 26)
        Me.txtGetRFId.TabIndex = 149
        Me.txtGetRFId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGoToLogin
        '
        Me.btnGoToLogin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGoToLogin.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.GOTOLOGINFORM
        Me.btnGoToLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGoToLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGoToLogin.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToLogin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnGoToLogin.Location = New System.Drawing.Point(1305, 9)
        Me.btnGoToLogin.Name = "btnGoToLogin"
        Me.btnGoToLogin.Size = New System.Drawing.Size(23, 21)
        Me.btnGoToLogin.TabIndex = 81
        Me.btnGoToLogin.UseVisualStyleBackColor = False
        '
        'panelLower
        '
        Me.panelLower.BackColor = System.Drawing.Color.Khaki
        Me.panelLower.Controls.Add(Me.btnGoToLogin)
        Me.panelLower.Location = New System.Drawing.Point(-2, 660)
        Me.panelLower.Name = "panelLower"
        Me.panelLower.Size = New System.Drawing.Size(1346, 40)
        Me.panelLower.TabIndex = 133
        '
        'Frm_Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1338, 699)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelLower)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.panelUpper)
        Me.Controls.Add(Me.gbCenter)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "Frm_Attendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.ptbIconOfSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbLogoOfSchool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelUpper.ResumeLayout(False)
        Me.panelUpper.PerformLayout()
        CType(Me.ptbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCenter.ResumeLayout(False)
        Me.gbCenter.PerformLayout()
        Me.panelLower.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDateToday As System.Windows.Forms.Label
    Friend WithEvents txtYearLevel As System.Windows.Forms.TextBox
    Friend WithEvents lblDayNow As System.Windows.Forms.Label
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents ptbIconOfSystem As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitleOfTheSystem As System.Windows.Forms.Label
    Friend WithEvents ptbLogoOfSchool As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents panelUpper As System.Windows.Forms.Panel
    Friend WithEvents lblAddressOfSchool As System.Windows.Forms.Label
    Friend WithEvents lblNameOfSchool As System.Windows.Forms.Label
    Friend WithEvents txtStudentId As System.Windows.Forms.TextBox
    Friend WithEvents ptbProfile As System.Windows.Forms.PictureBox
    Friend WithEvents gbCenter As System.Windows.Forms.GroupBox
    Friend WithEvents btnGoToLogin As System.Windows.Forms.Button
    Friend WithEvents panelLower As System.Windows.Forms.Panel
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents lblStudentId As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblTimeNow As System.Windows.Forms.Label
    Friend WithEvents txtGetRFId As System.Windows.Forms.TextBox
End Class
