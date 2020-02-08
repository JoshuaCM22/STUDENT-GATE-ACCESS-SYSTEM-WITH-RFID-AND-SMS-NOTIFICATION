<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SetANewPassword
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
        Dim panelTop As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_SetANewPassword))
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtConfirmNewPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmNewPassword = New System.Windows.Forms.Label()
        Me.groupbox = New System.Windows.Forms.GroupBox()
        Me.chckbox_ShowPassword2 = New System.Windows.Forms.CheckBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        panelTop = New System.Windows.Forms.Button()
        Me.groupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        panelTop.BackColor = System.Drawing.Color.Black
        panelTop.CausesValidation = False
        panelTop.Dock = System.Windows.Forms.DockStyle.Top
        panelTop.Enabled = False
        panelTop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        panelTop.ForeColor = System.Drawing.Color.White
        panelTop.Location = New System.Drawing.Point(0, 0)
        panelTop.Name = "panelTop"
        panelTop.Size = New System.Drawing.Size(547, 54)
        panelTop.TabIndex = 0
        panelTop.TabStop = False
        panelTop.UseMnemonic = False
        panelTop.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.Black
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.FlatAppearance.BorderSize = 0
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Location = New System.Drawing.Point(95, 351)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(173, 33)
        Me.btnChangePassword.TabIndex = 4
        Me.btnChangePassword.Text = "CONFIRM"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(299, 351)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(164, 33)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtConfirmNewPassword
        '
        Me.txtConfirmNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmNewPassword.Location = New System.Drawing.Point(199, 131)
        Me.txtConfirmNewPassword.MaxLength = 12
        Me.txtConfirmNewPassword.Name = "txtConfirmNewPassword"
        Me.txtConfirmNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmNewPassword.Size = New System.Drawing.Size(234, 25)
        Me.txtConfirmNewPassword.TabIndex = 2
        Me.txtConfirmNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblConfirmNewPassword
        '
        Me.lblConfirmNewPassword.AutoSize = True
        Me.lblConfirmNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmNewPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmNewPassword.ForeColor = System.Drawing.Color.Black
        Me.lblConfirmNewPassword.Location = New System.Drawing.Point(35, 132)
        Me.lblConfirmNewPassword.Name = "lblConfirmNewPassword"
        Me.lblConfirmNewPassword.Size = New System.Drawing.Size(161, 20)
        Me.lblConfirmNewPassword.TabIndex = 0
        Me.lblConfirmNewPassword.Text = "Confirm New Password"
        '
        'groupbox
        '
        Me.groupbox.BackColor = System.Drawing.Color.Transparent
        Me.groupbox.Controls.Add(Me.chckbox_ShowPassword2)
        Me.groupbox.Controls.Add(Me.lblNewPassword)
        Me.groupbox.Controls.Add(Me.txtNewPassword)
        Me.groupbox.Controls.Add(Me.lblConfirmNewPassword)
        Me.groupbox.Controls.Add(Me.txtConfirmNewPassword)
        Me.groupbox.Location = New System.Drawing.Point(30, 61)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(483, 255)
        Me.groupbox.TabIndex = 0
        Me.groupbox.TabStop = False
        '
        'chckbox_ShowPassword2
        '
        Me.chckbox_ShowPassword2.AutoSize = True
        Me.chckbox_ShowPassword2.BackColor = System.Drawing.Color.Transparent
        Me.chckbox_ShowPassword2.FlatAppearance.BorderSize = 0
        Me.chckbox_ShowPassword2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckbox_ShowPassword2.ForeColor = System.Drawing.Color.Black
        Me.chckbox_ShowPassword2.Location = New System.Drawing.Point(199, 174)
        Me.chckbox_ShowPassword2.Name = "chckbox_ShowPassword2"
        Me.chckbox_ShowPassword2.Size = New System.Drawing.Size(118, 21)
        Me.chckbox_ShowPassword2.TabIndex = 0
        Me.chckbox_ShowPassword2.Text = "Show Password"
        Me.chckbox_ShowPassword2.UseVisualStyleBackColor = False
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.Black
        Me.lblNewPassword.Location = New System.Drawing.Point(92, 86)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(104, 20)
        Me.lblNewPassword.TabIndex = 0
        Me.lblNewPassword.Text = "New Password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(200, 86)
        Me.txtNewPassword.MaxLength = 12
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(234, 25)
        Me.txtNewPassword.TabIndex = 1
        Me.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Black
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(139, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(270, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "SET A NEW PASSWORD"
        '
        'Form_SetANewPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(547, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(panelTop)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.groupbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_SetANewPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupbox.ResumeLayout(False)
        Me.groupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtConfirmNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmNewPassword As System.Windows.Forms.Label
    Friend WithEvents groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents chckbox_ShowPassword2 As System.Windows.Forms.CheckBox
End Class
