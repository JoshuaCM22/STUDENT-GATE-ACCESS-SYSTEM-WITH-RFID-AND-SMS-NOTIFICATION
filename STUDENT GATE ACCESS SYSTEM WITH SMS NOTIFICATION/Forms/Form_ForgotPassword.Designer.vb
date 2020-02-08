<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ForgotPassword))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblTitleOfTheSystem = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblSecretQuestion = New System.Windows.Forms.Label()
        Me.lblSecretAnswer = New System.Windows.Forms.Label()
        Me.txtSecretAnswer = New System.Windows.Forms.TextBox()
        Me.chckboxSecretAnswer = New System.Windows.Forms.CheckBox()
        Me.cmbboxSecretQuestion = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.ptbIconOfSystem = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.ptbIconOfSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(356, 401)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 28)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(148, 314)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(162, 30)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblTitleOfTheSystem
        '
        Me.lblTitleOfTheSystem.AutoSize = True
        Me.lblTitleOfTheSystem.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblTitleOfTheSystem.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleOfTheSystem.ForeColor = System.Drawing.Color.White
        Me.lblTitleOfTheSystem.Location = New System.Drawing.Point(143, 5)
        Me.lblTitleOfTheSystem.Name = "lblTitleOfTheSystem"
        Me.lblTitleOfTheSystem.Size = New System.Drawing.Size(196, 25)
        Me.lblTitleOfTheSystem.TabIndex = 0
        Me.lblTitleOfTheSystem.Text = "FORGOT PASSWORD ?"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(57, 50)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(75, 20)
        Me.lblUsername.TabIndex = 41
        Me.lblUsername.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(135, 47)
        Me.txtUsername.MaxLength = 12
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(240, 25)
        Me.txtUsername.TabIndex = 1
        '
        'lblSecretQuestion
        '
        Me.lblSecretQuestion.AutoSize = True
        Me.lblSecretQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblSecretQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSecretQuestion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretQuestion.ForeColor = System.Drawing.Color.Black
        Me.lblSecretQuestion.Location = New System.Drawing.Point(19, 92)
        Me.lblSecretQuestion.Name = "lblSecretQuestion"
        Me.lblSecretQuestion.Size = New System.Drawing.Size(113, 20)
        Me.lblSecretQuestion.TabIndex = 43
        Me.lblSecretQuestion.Text = "Secret Question"
        '
        'lblSecretAnswer
        '
        Me.lblSecretAnswer.AutoSize = True
        Me.lblSecretAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblSecretAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSecretAnswer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretAnswer.ForeColor = System.Drawing.Color.Black
        Me.lblSecretAnswer.Location = New System.Drawing.Point(30, 132)
        Me.lblSecretAnswer.Name = "lblSecretAnswer"
        Me.lblSecretAnswer.Size = New System.Drawing.Size(102, 20)
        Me.lblSecretAnswer.TabIndex = 44
        Me.lblSecretAnswer.Text = "Secret Answer"
        '
        'txtSecretAnswer
        '
        Me.txtSecretAnswer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretAnswer.Location = New System.Drawing.Point(135, 129)
        Me.txtSecretAnswer.MaxLength = 40
        Me.txtSecretAnswer.Name = "txtSecretAnswer"
        Me.txtSecretAnswer.Size = New System.Drawing.Size(240, 25)
        Me.txtSecretAnswer.TabIndex = 3
        '
        'chckboxSecretAnswer
        '
        Me.chckboxSecretAnswer.AutoSize = True
        Me.chckboxSecretAnswer.BackColor = System.Drawing.Color.Transparent
        Me.chckboxSecretAnswer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckboxSecretAnswer.ForeColor = System.Drawing.Color.Black
        Me.chckboxSecretAnswer.Location = New System.Drawing.Point(136, 165)
        Me.chckboxSecretAnswer.Name = "chckboxSecretAnswer"
        Me.chckboxSecretAnswer.Size = New System.Drawing.Size(144, 21)
        Me.chckboxSecretAnswer.TabIndex = 0
        Me.chckboxSecretAnswer.Text = "Show Secret Answer"
        Me.chckboxSecretAnswer.UseVisualStyleBackColor = False
        '
        'cmbboxSecretQuestion
        '
        Me.cmbboxSecretQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxSecretQuestion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxSecretQuestion.FormattingEnabled = True
        Me.cmbboxSecretQuestion.Items.AddRange(New Object() {"", "What is your favorite color?", "What is your contact number?", "When is your birthday?", "What is love for you?", "Where were you born ?", "What is the meaning of life?", "What is your gender?", "What is your civil status in life?", "What is your dream in life?", "What things that makes you happy?", "What things that makes you sad?", "What things that makes you mad?", "What is your job?", "What is your favorite song?", "What is your favorite band?", "What is your favorite singer?"})
        Me.cmbboxSecretQuestion.Location = New System.Drawing.Point(135, 89)
        Me.cmbboxSecretQuestion.MaxLength = 40
        Me.cmbboxSecretQuestion.Name = "cmbboxSecretQuestion"
        Me.cmbboxSecretQuestion.Size = New System.Drawing.Size(240, 25)
        Me.cmbboxSecretQuestion.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbboxSecretQuestion)
        Me.GroupBox1.Controls.Add(Me.chckboxSecretAnswer)
        Me.GroupBox1.Controls.Add(Me.txtSecretAnswer)
        Me.GroupBox1.Controls.Add(Me.lblSecretAnswer)
        Me.GroupBox1.Controls.Add(Me.lblSecretQuestion)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 222)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelTop.Controls.Add(Me.ptbIconOfSystem)
        Me.panelTop.Controls.Add(Me.btnMinimize)
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(461, 42)
        Me.panelTop.TabIndex = 137
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
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
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
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1295, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 21)
        Me.btnClose.TabIndex = 5
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelBottom.Controls.Add(Me.Button1)
        Me.panelBottom.Controls.Add(Me.Button2)
        Me.panelBottom.Location = New System.Drawing.Point(0, 391)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(461, 51)
        Me.panelBottom.TabIndex = 138
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button1.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.MINIMIZEBUTTON
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1249, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 21)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button2.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.CLOSEBUTTON
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1295, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 21)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form_ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(460, 438)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTitleOfTheSystem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.panelBottom)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        CType(Me.ptbIconOfSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblTitleOfTheSystem As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblSecretQuestion As System.Windows.Forms.Label
    Friend WithEvents lblSecretAnswer As System.Windows.Forms.Label
    Friend WithEvents txtSecretAnswer As System.Windows.Forms.TextBox
    Friend WithEvents chckboxSecretAnswer As System.Windows.Forms.CheckBox
    Friend WithEvents cmbboxSecretQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents panelBottom As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents ptbIconOfSystem As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
