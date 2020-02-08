<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CreateAnotherAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CreateAnotherAccount))
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.chckbox_ShowPassword = New System.Windows.Forms.CheckBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.cmbboxSecretQuestion = New System.Windows.Forms.ComboBox()
        Me.chckbox_ShowSecretAnswer = New System.Windows.Forms.CheckBox()
        Me.txtSecretAnswer = New System.Windows.Forms.TextBox()
        Me.lblSecretAnswer = New System.Windows.Forms.Label()
        Me.lblSecretQuestion = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.groupBox.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(149, 86)
        Me.txtPassword.MaxLength = 12
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(234, 25)
        Me.txtPassword.TabIndex = 3
        '
        'chckbox_ShowPassword
        '
        Me.chckbox_ShowPassword.AutoSize = True
        Me.chckbox_ShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.chckbox_ShowPassword.FlatAppearance.BorderSize = 0
        Me.chckbox_ShowPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckbox_ShowPassword.ForeColor = System.Drawing.Color.Black
        Me.chckbox_ShowPassword.Location = New System.Drawing.Point(149, 117)
        Me.chckbox_ShowPassword.Name = "chckbox_ShowPassword"
        Me.chckbox_ShowPassword.Size = New System.Drawing.Size(118, 21)
        Me.chckbox_ShowPassword.TabIndex = 0
        Me.chckbox_ShowPassword.Text = "Show Password"
        Me.chckbox_ShowPassword.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(149, 48)
        Me.txtUsername.MaxLength = 12
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(234, 25)
        Me.txtUsername.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(74, 86)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(70, 20)
        Me.lblPassword.TabIndex = 32
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(69, 48)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(75, 20)
        Me.lblUsername.TabIndex = 31
        Me.lblUsername.Text = "Username"
        '
        'groupBox
        '
        Me.groupBox.BackColor = System.Drawing.Color.Transparent
        Me.groupBox.Controls.Add(Me.txtPassword)
        Me.groupBox.Controls.Add(Me.chckbox_ShowPassword)
        Me.groupBox.Controls.Add(Me.txtUsername)
        Me.groupBox.Controls.Add(Me.lblPassword)
        Me.groupBox.Controls.Add(Me.lblUsername)
        Me.groupBox.Controls.Add(Me.cmbboxSecretQuestion)
        Me.groupBox.Controls.Add(Me.chckbox_ShowSecretAnswer)
        Me.groupBox.Controls.Add(Me.txtSecretAnswer)
        Me.groupBox.Controls.Add(Me.lblSecretAnswer)
        Me.groupBox.Controls.Add(Me.lblSecretQuestion)
        Me.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.groupBox.Location = New System.Drawing.Point(35, 64)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(435, 292)
        Me.groupBox.TabIndex = 0
        Me.groupBox.TabStop = False
        '
        'cmbboxSecretQuestion
        '
        Me.cmbboxSecretQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxSecretQuestion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxSecretQuestion.FormattingEnabled = True
        Me.cmbboxSecretQuestion.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.cmbboxSecretQuestion.Items.AddRange(New Object() {"", "What is your favorite color?", "What is your contact number?", "When is your birthday?", "What is love for you?", "Where were you born ?", "What is the meaning of life?", "What is your gender?", "What is your civil status in life?", "What is your dream in life?", "What things that makes you happy?", "What things that makes you sad?", "What things that makes you mad?", "What is your job?", "What is your favorite song?", "What is your favorite band?", "What is your favorite singer?"})
        Me.cmbboxSecretQuestion.Location = New System.Drawing.Point(149, 149)
        Me.cmbboxSecretQuestion.Name = "cmbboxSecretQuestion"
        Me.cmbboxSecretQuestion.Size = New System.Drawing.Size(234, 25)
        Me.cmbboxSecretQuestion.TabIndex = 11
        '
        'chckbox_ShowSecretAnswer
        '
        Me.chckbox_ShowSecretAnswer.AutoSize = True
        Me.chckbox_ShowSecretAnswer.BackColor = System.Drawing.Color.Transparent
        Me.chckbox_ShowSecretAnswer.FlatAppearance.BorderSize = 0
        Me.chckbox_ShowSecretAnswer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckbox_ShowSecretAnswer.ForeColor = System.Drawing.Color.Black
        Me.chckbox_ShowSecretAnswer.Location = New System.Drawing.Point(149, 226)
        Me.chckbox_ShowSecretAnswer.Name = "chckbox_ShowSecretAnswer"
        Me.chckbox_ShowSecretAnswer.Size = New System.Drawing.Size(144, 21)
        Me.chckbox_ShowSecretAnswer.TabIndex = 0
        Me.chckbox_ShowSecretAnswer.Text = "Show Secret Answer"
        Me.chckbox_ShowSecretAnswer.UseVisualStyleBackColor = False
        '
        'txtSecretAnswer
        '
        Me.txtSecretAnswer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretAnswer.Location = New System.Drawing.Point(149, 189)
        Me.txtSecretAnswer.MaxLength = 40
        Me.txtSecretAnswer.Name = "txtSecretAnswer"
        Me.txtSecretAnswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSecretAnswer.Size = New System.Drawing.Size(234, 25)
        Me.txtSecretAnswer.TabIndex = 12
        '
        'lblSecretAnswer
        '
        Me.lblSecretAnswer.AutoSize = True
        Me.lblSecretAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblSecretAnswer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretAnswer.ForeColor = System.Drawing.Color.Black
        Me.lblSecretAnswer.Location = New System.Drawing.Point(44, 190)
        Me.lblSecretAnswer.Name = "lblSecretAnswer"
        Me.lblSecretAnswer.Size = New System.Drawing.Size(102, 20)
        Me.lblSecretAnswer.TabIndex = 32
        Me.lblSecretAnswer.Text = "Secret Answer"
        '
        'lblSecretQuestion
        '
        Me.lblSecretQuestion.AutoSize = True
        Me.lblSecretQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblSecretQuestion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretQuestion.ForeColor = System.Drawing.Color.Black
        Me.lblSecretQuestion.Location = New System.Drawing.Point(34, 150)
        Me.lblSecretQuestion.Name = "lblSecretQuestion"
        Me.lblSecretQuestion.Size = New System.Drawing.Size(113, 20)
        Me.lblSecretQuestion.TabIndex = 31
        Me.lblSecretQuestion.Text = "Secret Question"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(283, 387)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(164, 33)
        Me.btnBack.TabIndex = 66
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.Black
        Me.panelTop.Controls.Add(Me.lblTitle)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(509, 58)
        Me.panelTop.TabIndex = 67
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Black
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(95, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(330, 32)
        Me.lblTitle.TabIndex = 63
        Me.lblTitle.Text = "CREATE ANOTHER ACCOUNT"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Black
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(74, 387)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(164, 33)
        Me.btnConfirm.TabIndex = 69
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Form_CreateAnotherAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(509, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.groupBox)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_CreateAnotherAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents chckbox_ShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents cmbboxSecretQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents chckbox_ShowSecretAnswer As System.Windows.Forms.CheckBox
    Friend WithEvents txtSecretAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblSecretAnswer As System.Windows.Forms.Label
    Friend WithEvents lblSecretQuestion As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
