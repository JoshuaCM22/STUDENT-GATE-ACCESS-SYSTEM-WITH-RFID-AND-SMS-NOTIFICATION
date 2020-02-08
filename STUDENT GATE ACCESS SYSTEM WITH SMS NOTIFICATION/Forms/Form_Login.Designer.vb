<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnForgotPassword = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.ptbIconUsername = New System.Windows.Forms.PictureBox()
        Me.ptbIconPassword = New System.Windows.Forms.PictureBox()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.ptbIconOfSystem = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ptbShowPassword = New System.Windows.Forms.PictureBox()
        CType(Me.ptbIconUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbIconPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        CType(Me.ptbIconOfSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbShowPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(56, 120)
        Me.txtUsername.MaxLength = 12
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(266, 32)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtPassword.Location = New System.Drawing.Point(56, 204)
        Me.txtPassword.MaxLength = 12
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(266, 32)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnForgotPassword
        '
        Me.btnForgotPassword.BackColor = System.Drawing.Color.Black
        Me.btnForgotPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnForgotPassword.FlatAppearance.BorderSize = 0
        Me.btnForgotPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForgotPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForgotPassword.ForeColor = System.Drawing.Color.White
        Me.btnForgotPassword.Location = New System.Drawing.Point(56, 340)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(265, 30)
        Me.btnForgotPassword.TabIndex = 0
        Me.btnForgotPassword.Text = "Forgot Password ?"
        Me.btnForgotPassword.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(137, 82)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(104, 22)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "USERNAME"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(137, 169)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(104, 22)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "PASSWORD"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(208, 279)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(114, 34)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(56, 279)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(113, 34)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'ptbIconUsername
        '
        Me.ptbIconUsername.BackColor = System.Drawing.SystemColors.Window
        Me.ptbIconUsername.BackgroundImage = CType(resources.GetObject("ptbIconUsername.BackgroundImage"), System.Drawing.Image)
        Me.ptbIconUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbIconUsername.ErrorImage = Nothing
        Me.ptbIconUsername.Location = New System.Drawing.Point(55, 120)
        Me.ptbIconUsername.Name = "ptbIconUsername"
        Me.ptbIconUsername.Size = New System.Drawing.Size(32, 32)
        Me.ptbIconUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbIconUsername.TabIndex = 66
        Me.ptbIconUsername.TabStop = False
        '
        'ptbIconPassword
        '
        Me.ptbIconPassword.BackColor = System.Drawing.SystemColors.Window
        Me.ptbIconPassword.BackgroundImage = CType(resources.GetObject("ptbIconPassword.BackgroundImage"), System.Drawing.Image)
        Me.ptbIconPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbIconPassword.ErrorImage = Nothing
        Me.ptbIconPassword.Location = New System.Drawing.Point(55, 204)
        Me.ptbIconPassword.Name = "ptbIconPassword"
        Me.ptbIconPassword.Size = New System.Drawing.Size(32, 32)
        Me.ptbIconPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbIconPassword.TabIndex = 67
        Me.ptbIconPassword.TabStop = False
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Controls.Add(Me.btnMinimize)
        Me.panelTop.Controls.Add(Me.ptbIconOfSystem)
        Me.panelTop.Controls.Add(Me.lblTitle)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(373, 35)
        Me.panelTop.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnClose.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.CLOSEBUTTON
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(342, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 21)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnMinimize.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.MINIMIZEBUTTON
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(313, 7)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(28, 21)
        Me.btnMinimize.TabIndex = 0
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'ptbIconOfSystem
        '
        Me.ptbIconOfSystem.BackColor = System.Drawing.Color.SaddleBrown
        Me.ptbIconOfSystem.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.MYICON
        Me.ptbIconOfSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbIconOfSystem.ErrorImage = Nothing
        Me.ptbIconOfSystem.Location = New System.Drawing.Point(5, 3)
        Me.ptbIconOfSystem.Name = "ptbIconOfSystem"
        Me.ptbIconOfSystem.Size = New System.Drawing.Size(25, 25)
        Me.ptbIconOfSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbIconOfSystem.TabIndex = 135
        Me.ptbIconOfSystem.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(154, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(66, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "LOGIN"
        '
        'ptbShowPassword
        '
        Me.ptbShowPassword.BackColor = System.Drawing.SystemColors.Window
        Me.ptbShowPassword.BackgroundImage = CType(resources.GetObject("ptbShowPassword.BackgroundImage"), System.Drawing.Image)
        Me.ptbShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbShowPassword.ErrorImage = Nothing
        Me.ptbShowPassword.Location = New System.Drawing.Point(289, 204)
        Me.ptbShowPassword.Name = "ptbShowPassword"
        Me.ptbShowPassword.Size = New System.Drawing.Size(29, 32)
        Me.ptbShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbShowPassword.TabIndex = 137
        Me.ptbShowPassword.TabStop = False
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(373, 421)
        Me.ControlBox = False
        Me.Controls.Add(Me.ptbShowPassword)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.ptbIconPassword)
        Me.Controls.Add(Me.ptbIconUsername)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnForgotPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ptbIconUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbIconPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.ptbIconOfSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbShowPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnForgotPassword As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents ptbIconUsername As System.Windows.Forms.PictureBox
    Friend WithEvents ptbIconPassword As System.Windows.Forms.PictureBox
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents ptbIconOfSystem As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents ptbShowPassword As System.Windows.Forms.PictureBox
End Class
