<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AddNewStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AddNewStudent))
        Me.btnTakeAPicture = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.ptbProfile = New System.Windows.Forms.PictureBox()
        Me.gbGradeLevels = New System.Windows.Forms.GroupBox()
        Me.lblGrade10 = New System.Windows.Forms.Label()
        Me.lblGrade9 = New System.Windows.Forms.Label()
        Me.lblGrade8 = New System.Windows.Forms.Label()
        Me.lblGrade7 = New System.Windows.Forms.Label()
        Me.rbGrade10 = New System.Windows.Forms.RadioButton()
        Me.rbGrade9 = New System.Windows.Forms.RadioButton()
        Me.rbGrade8 = New System.Windows.Forms.RadioButton()
        Me.rbGrade7 = New System.Windows.Forms.RadioButton()
        Me.gbDetails = New System.Windows.Forms.GroupBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.txtSuffix = New System.Windows.Forms.TextBox()
        Me.lblSuffix = New System.Windows.Forms.Label()
        Me.cmbRelationship = New System.Windows.Forms.ComboBox()
        Me.txtTwoDigitNumber = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.lblRelationship = New System.Windows.Forms.Label()
        Me.txtGivenName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblGivenName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtRFID = New System.Windows.Forms.TextBox()
        Me.lblRFID = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblContactPerson = New System.Windows.Forms.Label()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblAddressOfSchool = New System.Windows.Forms.Label()
        Me.lblNameOfSchool = New System.Windows.Forms.Label()
        Me.ptbLogoOfSchool = New System.Windows.Forms.PictureBox()
        CType(Me.ptbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGradeLevels.SuspendLayout()
        Me.gbDetails.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ptbLogoOfSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTakeAPicture
        '
        Me.btnTakeAPicture.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTakeAPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTakeAPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnTakeAPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTakeAPicture.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTakeAPicture.ForeColor = System.Drawing.Color.Black
        Me.btnTakeAPicture.Location = New System.Drawing.Point(1092, 430)
        Me.btnTakeAPicture.Name = "btnTakeAPicture"
        Me.btnTakeAPicture.Size = New System.Drawing.Size(134, 25)
        Me.btnTakeAPicture.TabIndex = 0
        Me.btnTakeAPicture.Text = "TAKE A PICTURE"
        Me.btnTakeAPicture.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Location = New System.Drawing.Point(935, 430)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(145, 25)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'ptbProfile
        '
        Me.ptbProfile.BackColor = System.Drawing.Color.White
        Me.ptbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbProfile.ErrorImage = Nothing
        Me.ptbProfile.Image = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.USERICON
        Me.ptbProfile.Location = New System.Drawing.Point(935, 214)
        Me.ptbProfile.Name = "ptbProfile"
        Me.ptbProfile.Size = New System.Drawing.Size(291, 198)
        Me.ptbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbProfile.TabIndex = 143
        Me.ptbProfile.TabStop = False
        '
        'gbGradeLevels
        '
        Me.gbGradeLevels.BackColor = System.Drawing.Color.Transparent
        Me.gbGradeLevels.Controls.Add(Me.lblGrade10)
        Me.gbGradeLevels.Controls.Add(Me.lblGrade9)
        Me.gbGradeLevels.Controls.Add(Me.lblGrade8)
        Me.gbGradeLevels.Controls.Add(Me.lblGrade7)
        Me.gbGradeLevels.Controls.Add(Me.rbGrade10)
        Me.gbGradeLevels.Controls.Add(Me.rbGrade9)
        Me.gbGradeLevels.Controls.Add(Me.rbGrade8)
        Me.gbGradeLevels.Controls.Add(Me.rbGrade7)
        Me.gbGradeLevels.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGradeLevels.ForeColor = System.Drawing.Color.Black
        Me.gbGradeLevels.Location = New System.Drawing.Point(974, 472)
        Me.gbGradeLevels.Name = "gbGradeLevels"
        Me.gbGradeLevels.Size = New System.Drawing.Size(236, 95)
        Me.gbGradeLevels.TabIndex = 0
        Me.gbGradeLevels.TabStop = False
        Me.gbGradeLevels.Text = "GRADE LEVEL"
        '
        'lblGrade10
        '
        Me.lblGrade10.AutoSize = True
        Me.lblGrade10.BackColor = System.Drawing.Color.Transparent
        Me.lblGrade10.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade10.ForeColor = System.Drawing.Color.Black
        Me.lblGrade10.Location = New System.Drawing.Point(140, 57)
        Me.lblGrade10.Name = "lblGrade10"
        Me.lblGrade10.Size = New System.Drawing.Size(68, 20)
        Me.lblGrade10.TabIndex = 0
        Me.lblGrade10.Text = "Grade 10"
        '
        'lblGrade9
        '
        Me.lblGrade9.AutoSize = True
        Me.lblGrade9.BackColor = System.Drawing.Color.Transparent
        Me.lblGrade9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade9.ForeColor = System.Drawing.Color.Black
        Me.lblGrade9.Location = New System.Drawing.Point(36, 58)
        Me.lblGrade9.Name = "lblGrade9"
        Me.lblGrade9.Size = New System.Drawing.Size(62, 20)
        Me.lblGrade9.TabIndex = 0
        Me.lblGrade9.Text = "Grade 9"
        '
        'lblGrade8
        '
        Me.lblGrade8.AutoSize = True
        Me.lblGrade8.BackColor = System.Drawing.Color.Transparent
        Me.lblGrade8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade8.ForeColor = System.Drawing.Color.Black
        Me.lblGrade8.Location = New System.Drawing.Point(140, 28)
        Me.lblGrade8.Name = "lblGrade8"
        Me.lblGrade8.Size = New System.Drawing.Size(62, 20)
        Me.lblGrade8.TabIndex = 0
        Me.lblGrade8.Text = "Grade 8"
        '
        'lblGrade7
        '
        Me.lblGrade7.AutoSize = True
        Me.lblGrade7.BackColor = System.Drawing.Color.Transparent
        Me.lblGrade7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade7.ForeColor = System.Drawing.Color.Black
        Me.lblGrade7.Location = New System.Drawing.Point(36, 27)
        Me.lblGrade7.Name = "lblGrade7"
        Me.lblGrade7.Size = New System.Drawing.Size(62, 20)
        Me.lblGrade7.TabIndex = 0
        Me.lblGrade7.Text = "Grade 7"
        '
        'rbGrade10
        '
        Me.rbGrade10.AutoSize = True
        Me.rbGrade10.ForeColor = System.Drawing.Color.White
        Me.rbGrade10.Location = New System.Drawing.Point(122, 61)
        Me.rbGrade10.Name = "rbGrade10"
        Me.rbGrade10.Size = New System.Drawing.Size(14, 13)
        Me.rbGrade10.TabIndex = 0
        Me.rbGrade10.TabStop = True
        Me.rbGrade10.UseVisualStyleBackColor = True
        '
        'rbGrade9
        '
        Me.rbGrade9.AutoSize = True
        Me.rbGrade9.ForeColor = System.Drawing.Color.White
        Me.rbGrade9.Location = New System.Drawing.Point(18, 60)
        Me.rbGrade9.Name = "rbGrade9"
        Me.rbGrade9.Size = New System.Drawing.Size(14, 13)
        Me.rbGrade9.TabIndex = 0
        Me.rbGrade9.TabStop = True
        Me.rbGrade9.UseVisualStyleBackColor = True
        '
        'rbGrade8
        '
        Me.rbGrade8.AutoSize = True
        Me.rbGrade8.ForeColor = System.Drawing.Color.White
        Me.rbGrade8.Location = New System.Drawing.Point(122, 29)
        Me.rbGrade8.Name = "rbGrade8"
        Me.rbGrade8.Size = New System.Drawing.Size(14, 13)
        Me.rbGrade8.TabIndex = 0
        Me.rbGrade8.TabStop = True
        Me.rbGrade8.UseVisualStyleBackColor = True
        '
        'rbGrade7
        '
        Me.rbGrade7.AutoSize = True
        Me.rbGrade7.ForeColor = System.Drawing.Color.White
        Me.rbGrade7.Location = New System.Drawing.Point(18, 28)
        Me.rbGrade7.Name = "rbGrade7"
        Me.rbGrade7.Size = New System.Drawing.Size(14, 13)
        Me.rbGrade7.TabIndex = 0
        Me.rbGrade7.TabStop = True
        Me.rbGrade7.UseVisualStyleBackColor = True
        '
        'gbDetails
        '
        Me.gbDetails.BackColor = System.Drawing.Color.Transparent
        Me.gbDetails.Controls.Add(Me.txtStudentID)
        Me.gbDetails.Controls.Add(Me.lblStudentID)
        Me.gbDetails.Controls.Add(Me.txtSuffix)
        Me.gbDetails.Controls.Add(Me.lblSuffix)
        Me.gbDetails.Controls.Add(Me.cmbRelationship)
        Me.gbDetails.Controls.Add(Me.txtTwoDigitNumber)
        Me.gbDetails.Controls.Add(Me.lblAge)
        Me.gbDetails.Controls.Add(Me.cmbMonth)
        Me.gbDetails.Controls.Add(Me.txtYear)
        Me.gbDetails.Controls.Add(Me.lblDateOfBirth)
        Me.gbDetails.Controls.Add(Me.txtAge)
        Me.gbDetails.Controls.Add(Me.cmbDay)
        Me.gbDetails.Controls.Add(Me.lblFemale)
        Me.gbDetails.Controls.Add(Me.lblMale)
        Me.gbDetails.Controls.Add(Me.rbFemale)
        Me.gbDetails.Controls.Add(Me.txtContactNumber)
        Me.gbDetails.Controls.Add(Me.rbMale)
        Me.gbDetails.Controls.Add(Me.lblRelationship)
        Me.gbDetails.Controls.Add(Me.txtGivenName)
        Me.gbDetails.Controls.Add(Me.txtAddress)
        Me.gbDetails.Controls.Add(Me.lblGivenName)
        Me.gbDetails.Controls.Add(Me.txtLastName)
        Me.gbDetails.Controls.Add(Me.txtRFID)
        Me.gbDetails.Controls.Add(Me.lblRFID)
        Me.gbDetails.Controls.Add(Me.txtMiddleName)
        Me.gbDetails.Controls.Add(Me.lblMiddleName)
        Me.gbDetails.Controls.Add(Me.lblAddress)
        Me.gbDetails.Controls.Add(Me.lblContactNumber)
        Me.gbDetails.Controls.Add(Me.lblContactPerson)
        Me.gbDetails.Controls.Add(Me.txtContactPerson)
        Me.gbDetails.Controls.Add(Me.lblGender)
        Me.gbDetails.Controls.Add(Me.lblLastName)
        Me.gbDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDetails.ForeColor = System.Drawing.Color.Black
        Me.gbDetails.Location = New System.Drawing.Point(12, 259)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(900, 214)
        Me.gbDetails.TabIndex = 146
        Me.gbDetails.TabStop = False
        '
        'txtStudentID
        '
        Me.txtStudentID.BackColor = System.Drawing.Color.White
        Me.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentID.Enabled = False
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.ForeColor = System.Drawing.Color.Black
        Me.txtStudentID.Location = New System.Drawing.Point(94, 22)
        Me.txtStudentID.MaxLength = 6
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(184, 27)
        Me.txtStudentID.TabIndex = 0
        Me.txtStudentID.TabStop = False
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.ForeColor = System.Drawing.Color.Black
        Me.lblStudentID.Location = New System.Drawing.Point(12, 22)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(81, 20)
        Me.lblStudentID.TabIndex = 16
        Me.lblStudentID.Text = "Student ID"
        '
        'txtSuffix
        '
        Me.txtSuffix.BackColor = System.Drawing.Color.White
        Me.txtSuffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSuffix.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuffix.ForeColor = System.Drawing.Color.Black
        Me.txtSuffix.Location = New System.Drawing.Point(567, 22)
        Me.txtSuffix.MaxLength = 10
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(168, 27)
        Me.txtSuffix.TabIndex = 2
        '
        'lblSuffix
        '
        Me.lblSuffix.AutoSize = True
        Me.lblSuffix.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuffix.ForeColor = System.Drawing.Color.Black
        Me.lblSuffix.Location = New System.Drawing.Point(514, 24)
        Me.lblSuffix.Name = "lblSuffix"
        Me.lblSuffix.Size = New System.Drawing.Size(48, 20)
        Me.lblSuffix.TabIndex = 0
        Me.lblSuffix.Text = "Suffix"
        '
        'cmbRelationship
        '
        Me.cmbRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRelationship.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRelationship.FormattingEnabled = True
        Me.cmbRelationship.Items.AddRange(New Object() {"", "Father", "Mother", "Elder Brother", "Elder Sister", "Grand Father", "Grand Mother", "Uncle", "Aunt", "Step Father", "Step Mother"})
        Me.cmbRelationship.Location = New System.Drawing.Point(475, 159)
        Me.cmbRelationship.MaxLength = 9
        Me.cmbRelationship.Name = "cmbRelationship"
        Me.cmbRelationship.Size = New System.Drawing.Size(123, 28)
        Me.cmbRelationship.TabIndex = 14
        '
        'txtTwoDigitNumber
        '
        Me.txtTwoDigitNumber.BackColor = System.Drawing.Color.White
        Me.txtTwoDigitNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTwoDigitNumber.Enabled = False
        Me.txtTwoDigitNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTwoDigitNumber.ForeColor = System.Drawing.Color.Black
        Me.txtTwoDigitNumber.Location = New System.Drawing.Point(733, 158)
        Me.txtTwoDigitNumber.MaxLength = 2
        Me.txtTwoDigitNumber.Multiline = True
        Me.txtTwoDigitNumber.Name = "txtTwoDigitNumber"
        Me.txtTwoDigitNumber.Size = New System.Drawing.Size(33, 27)
        Me.txtTwoDigitNumber.TabIndex = 0
        Me.txtTwoDigitNumber.TabStop = False
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(618, 90)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 20)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Age"
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"Month", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(335, 87)
        Me.cmbMonth.MaxLength = 9
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(98, 28)
        Me.cmbMonth.TabIndex = 8
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.White
        Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYear.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.Color.Black
        Me.txtYear.Location = New System.Drawing.Point(521, 88)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(91, 27)
        Me.txtYear.TabIndex = 10
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfBirth.ForeColor = System.Drawing.Color.Black
        Me.lblDateOfBirth.Location = New System.Drawing.Point(236, 91)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(96, 20)
        Me.lblDateOfBirth.TabIndex = 0
        Me.lblDateOfBirth.Text = "Date of Birth"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.Black
        Me.txtAge.Location = New System.Drawing.Point(653, 88)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(95, 27)
        Me.txtAge.TabIndex = 11
        '
        'cmbDay
        '
        Me.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDay.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Items.AddRange(New Object() {"Day", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDay.Location = New System.Drawing.Point(439, 86)
        Me.cmbDay.MaxLength = 2
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(76, 28)
        Me.cmbDay.TabIndex = 9
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.BackColor = System.Drawing.Color.Transparent
        Me.lblFemale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.ForeColor = System.Drawing.Color.Black
        Me.lblFemale.Location = New System.Drawing.Point(170, 90)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(58, 20)
        Me.lblFemale.TabIndex = 0
        Me.lblFemale.Text = "Female"
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.BackColor = System.Drawing.Color.Transparent
        Me.lblMale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.ForeColor = System.Drawing.Color.Black
        Me.lblMale.Location = New System.Drawing.Point(102, 90)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(43, 20)
        Me.lblMale.TabIndex = 0
        Me.lblMale.Text = "Male"
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFemale.ForeColor = System.Drawing.Color.White
        Me.rbFemale.Location = New System.Drawing.Point(155, 93)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(14, 13)
        Me.rbFemale.TabIndex = 7
        Me.rbFemale.TabStop = True
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BackColor = System.Drawing.Color.White
        Me.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.Location = New System.Drawing.Point(775, 158)
        Me.txtContactNumber.MaxLength = 9
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(110, 27)
        Me.txtContactNumber.TabIndex = 15
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMale.ForeColor = System.Drawing.Color.White
        Me.rbMale.Location = New System.Drawing.Point(86, 93)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(14, 13)
        Me.rbMale.TabIndex = 6
        Me.rbMale.TabStop = True
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'lblRelationship
        '
        Me.lblRelationship.AutoSize = True
        Me.lblRelationship.BackColor = System.Drawing.Color.Transparent
        Me.lblRelationship.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelationship.ForeColor = System.Drawing.Color.Black
        Me.lblRelationship.Location = New System.Drawing.Point(376, 160)
        Me.lblRelationship.Name = "lblRelationship"
        Me.lblRelationship.Size = New System.Drawing.Size(93, 20)
        Me.lblRelationship.TabIndex = 0
        Me.lblRelationship.Text = "Relationship"
        '
        'txtGivenName
        '
        Me.txtGivenName.BackColor = System.Drawing.Color.White
        Me.txtGivenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGivenName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGivenName.ForeColor = System.Drawing.Color.Black
        Me.txtGivenName.Location = New System.Drawing.Point(384, 55)
        Me.txtGivenName.MaxLength = 16
        Me.txtGivenName.Name = "txtGivenName"
        Me.txtGivenName.Size = New System.Drawing.Size(185, 27)
        Me.txtGivenName.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(80, 124)
        Me.txtAddress.MaxLength = 80
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(805, 27)
        Me.txtAddress.TabIndex = 12
        '
        'lblGivenName
        '
        Me.lblGivenName.AutoSize = True
        Me.lblGivenName.BackColor = System.Drawing.Color.Transparent
        Me.lblGivenName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGivenName.ForeColor = System.Drawing.Color.Black
        Me.lblGivenName.Location = New System.Drawing.Point(287, 56)
        Me.lblGivenName.Name = "lblGivenName"
        Me.lblGivenName.Size = New System.Drawing.Size(93, 20)
        Me.lblGivenName.TabIndex = 0
        Me.lblGivenName.Text = "Given Name"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.White
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(93, 57)
        Me.txtLastName.MaxLength = 16
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(185, 27)
        Me.txtLastName.TabIndex = 3
        '
        'txtRFID
        '
        Me.txtRFID.BackColor = System.Drawing.Color.White
        Me.txtRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRFID.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFID.ForeColor = System.Drawing.Color.Black
        Me.txtRFID.Location = New System.Drawing.Point(336, 22)
        Me.txtRFID.MaxLength = 10
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.Size = New System.Drawing.Size(168, 27)
        Me.txtRFID.TabIndex = 1
        '
        'lblRFID
        '
        Me.lblRFID.AutoSize = True
        Me.lblRFID.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFID.ForeColor = System.Drawing.Color.Black
        Me.lblRFID.Location = New System.Drawing.Point(289, 24)
        Me.lblRFID.Name = "lblRFID"
        Me.lblRFID.Size = New System.Drawing.Size(41, 20)
        Me.lblRFID.TabIndex = 0
        Me.lblRFID.Text = "RFID"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BackColor = System.Drawing.Color.White
        Me.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.ForeColor = System.Drawing.Color.Black
        Me.txtMiddleName.Location = New System.Drawing.Point(689, 55)
        Me.txtMiddleName.MaxLength = 16
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(168, 27)
        Me.txtMiddleName.TabIndex = 5
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.ForeColor = System.Drawing.Color.Black
        Me.lblMiddleName.Location = New System.Drawing.Point(581, 55)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(102, 20)
        Me.lblMiddleName.TabIndex = 0
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(11, 124)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(63, 20)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Address"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblContactNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.ForeColor = System.Drawing.Color.Black
        Me.lblContactNumber.Location = New System.Drawing.Point(606, 160)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(122, 20)
        Me.lblContactNumber.TabIndex = 0
        Me.lblContactNumber.Text = "Contact Number"
        '
        'lblContactPerson
        '
        Me.lblContactPerson.AutoSize = True
        Me.lblContactPerson.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactPerson.ForeColor = System.Drawing.Color.Black
        Me.lblContactPerson.Location = New System.Drawing.Point(11, 160)
        Me.lblContactPerson.Name = "lblContactPerson"
        Me.lblContactPerson.Size = New System.Drawing.Size(111, 20)
        Me.lblContactPerson.TabIndex = 0
        Me.lblContactPerson.Text = "Contact Person"
        '
        'txtContactPerson
        '
        Me.txtContactPerson.BackColor = System.Drawing.Color.White
        Me.txtContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactPerson.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPerson.ForeColor = System.Drawing.Color.Black
        Me.txtContactPerson.Location = New System.Drawing.Point(126, 160)
        Me.txtContactPerson.MaxLength = 23
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(242, 27)
        Me.txtContactPerson.TabIndex = 13
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(11, 89)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(59, 20)
        Me.lblGender.TabIndex = 0
        Me.lblGender.Text = "Gender"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.Black
        Me.lblLastName.Location = New System.Drawing.Point(10, 57)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 20)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name"
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.panelTop.Controls.Add(Me.lblTitle)
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1247, 51)
        Me.panelTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblTitle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.lblTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(524, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(216, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.TabStop = False
        Me.lblTitle.Text = "ADD A NEW STUDENT"
        Me.lblTitle.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1138, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        Me.OpenFileDialog.Filter = "jpg and gif(*.jpg;*.gif)|*.jpg;*.gif"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = "jpg|*.jpg|gif|*.gif "
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(6, 25)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(126, 33)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(432, 491)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(134, 69)
        Me.GroupBox3.TabIndex = 148
        Me.GroupBox3.TabStop = False
        '
        'lblAddressOfSchool
        '
        Me.lblAddressOfSchool.AutoSize = True
        Me.lblAddressOfSchool.BackColor = System.Drawing.Color.Transparent
        Me.lblAddressOfSchool.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressOfSchool.ForeColor = System.Drawing.Color.Black
        Me.lblAddressOfSchool.Location = New System.Drawing.Point(398, 157)
        Me.lblAddressOfSchool.Name = "lblAddressOfSchool"
        Me.lblAddressOfSchool.Size = New System.Drawing.Size(695, 33)
        Me.lblAddressOfSchool.TabIndex = 0
        Me.lblAddressOfSchool.Text = "(New Panaderos Street, Santa Ana, Manila, Metro Manila)"
        '
        'lblNameOfSchool
        '
        Me.lblNameOfSchool.AutoSize = True
        Me.lblNameOfSchool.BackColor = System.Drawing.Color.Transparent
        Me.lblNameOfSchool.Font = New System.Drawing.Font("Tahoma", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOfSchool.ForeColor = System.Drawing.Color.Black
        Me.lblNameOfSchool.Location = New System.Drawing.Point(289, 69)
        Me.lblNameOfSchool.Name = "lblNameOfSchool"
        Me.lblNameOfSchool.Size = New System.Drawing.Size(948, 88)
        Me.lblNameOfSchool.TabIndex = 0
        Me.lblNameOfSchool.Text = "SAINT FRANCIS SCHOOL"
        '
        'ptbLogoOfSchool
        '
        Me.ptbLogoOfSchool.BackColor = System.Drawing.Color.Transparent
        Me.ptbLogoOfSchool.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.SAINT_FRANCIS_LOGO
        Me.ptbLogoOfSchool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLogoOfSchool.ErrorImage = Nothing
        Me.ptbLogoOfSchool.Location = New System.Drawing.Point(13, 59)
        Me.ptbLogoOfSchool.Name = "ptbLogoOfSchool"
        Me.ptbLogoOfSchool.Size = New System.Drawing.Size(257, 183)
        Me.ptbLogoOfSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbLogoOfSchool.TabIndex = 153
        Me.ptbLogoOfSchool.TabStop = False
        '
        'Form_AddNewStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1247, 587)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblAddressOfSchool)
        Me.Controls.Add(Me.lblNameOfSchool)
        Me.Controls.Add(Me.ptbLogoOfSchool)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnTakeAPicture)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.ptbProfile)
        Me.Controls.Add(Me.gbGradeLevels)
        Me.Controls.Add(Me.gbDetails)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_AddNewStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ptbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGradeLevels.ResumeLayout(False)
        Me.gbGradeLevels.PerformLayout()
        Me.gbDetails.ResumeLayout(False)
        Me.gbDetails.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ptbLogoOfSchool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTakeAPicture As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents ptbProfile As System.Windows.Forms.PictureBox
    Friend WithEvents gbGradeLevels As System.Windows.Forms.GroupBox
    Friend WithEvents lblGrade10 As System.Windows.Forms.Label
    Friend WithEvents lblGrade9 As System.Windows.Forms.Label
    Friend WithEvents lblGrade8 As System.Windows.Forms.Label
    Friend WithEvents lblGrade7 As System.Windows.Forms.Label
    Friend WithEvents rbGrade10 As System.Windows.Forms.RadioButton
    Friend WithEvents rbGrade9 As System.Windows.Forms.RadioButton
    Friend WithEvents rbGrade8 As System.Windows.Forms.RadioButton
    Friend WithEvents rbGrade7 As System.Windows.Forms.RadioButton
    Friend WithEvents gbDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblFemale As System.Windows.Forms.Label
    Friend WithEvents lblMale As System.Windows.Forms.Label
    Friend WithEvents txtGivenName As System.Windows.Forms.TextBox
    Friend WithEvents lblGivenName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtRFID As System.Windows.Forms.TextBox
    Friend WithEvents lblRFID As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblDateOfBirth As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Button
    Friend WithEvents lblAddressOfSchool As System.Windows.Forms.Label
    Friend WithEvents lblNameOfSchool As System.Windows.Forms.Label
    Friend WithEvents ptbLogoOfSchool As System.Windows.Forms.PictureBox
    Friend WithEvents cmbRelationship As System.Windows.Forms.ComboBox
    Friend WithEvents txtTwoDigitNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblRelationship As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents lblContactPerson As System.Windows.Forms.Label
    Friend WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtSuffix As System.Windows.Forms.TextBox
    Friend WithEvents lblSuffix As System.Windows.Forms.Label
    Public WithEvents rbFemale As System.Windows.Forms.RadioButton
    Public WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
End Class
