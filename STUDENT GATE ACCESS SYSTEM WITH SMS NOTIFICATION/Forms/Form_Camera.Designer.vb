<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Camera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Camera))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ptbTwo = New System.Windows.Forms.PictureBox()
        Me.ptbOne = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCaptured = New System.Windows.Forms.Button()
        Me.btnSaveImage = New System.Windows.Forms.Button()
        Me.panel = New System.Windows.Forms.Panel()
        Me.btnStudentProfile = New System.Windows.Forms.Button()
        Me.btnAddNewStudent = New System.Windows.Forms.Button()
        CType(Me.ptbTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = "jpg|*.jpg|gif|*.gif "
        '
        'ptbTwo
        '
        Me.ptbTwo.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ptbTwo.Location = New System.Drawing.Point(757, 152)
        Me.ptbTwo.Name = "ptbTwo"
        Me.ptbTwo.Size = New System.Drawing.Size(465, 383)
        Me.ptbTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbTwo.TabIndex = 1
        Me.ptbTwo.TabStop = False
        '
        'ptbOne
        '
        Me.ptbOne.BackColor = System.Drawing.Color.Black
        Me.ptbOne.Location = New System.Drawing.Point(33, 77)
        Me.ptbOne.Name = "ptbOne"
        Me.ptbOne.Size = New System.Drawing.Size(674, 580)
        Me.ptbOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbOne.TabIndex = 0
        Me.ptbOne.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1258, 47)
        Me.Panel1.TabIndex = 6
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnMinimize.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.MINIMIZEBUTTON
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(1161, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(45, 21)
        Me.btnMinimize.TabIndex = 137
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.CLOSEBUTTON
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1212, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(34, 21)
        Me.btnClose.TabIndex = 136
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(292, 7)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(94, 33)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnCaptured
        '
        Me.btnCaptured.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCaptured.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.CAMERA
        Me.btnCaptured.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCaptured.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCaptured.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnCaptured.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaptured.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaptured.ForeColor = System.Drawing.Color.Black
        Me.btnCaptured.Location = New System.Drawing.Point(292, 7)
        Me.btnCaptured.Name = "btnCaptured"
        Me.btnCaptured.Size = New System.Drawing.Size(94, 44)
        Me.btnCaptured.TabIndex = 8
        Me.btnCaptured.UseVisualStyleBackColor = False
        '
        'btnSaveImage
        '
        Me.btnSaveImage.BackColor = System.Drawing.Color.Black
        Me.btnSaveImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveImage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveImage.ForeColor = System.Drawing.Color.White
        Me.btnSaveImage.Location = New System.Drawing.Point(937, 555)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(115, 33)
        Me.btnSaveImage.TabIndex = 9
        Me.btnSaveImage.Text = "SAVE IMAGE"
        Me.btnSaveImage.UseVisualStyleBackColor = False
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Black
        Me.panel.Controls.Add(Me.btnStart)
        Me.panel.Controls.Add(Me.btnCaptured)
        Me.panel.Location = New System.Drawing.Point(33, 612)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(674, 60)
        Me.panel.TabIndex = 10
        '
        'btnStudentProfile
        '
        Me.btnStudentProfile.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentProfile.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentProfile.Location = New System.Drawing.Point(1147, 665)
        Me.btnStudentProfile.Name = "btnStudentProfile"
        Me.btnStudentProfile.Size = New System.Drawing.Size(99, 26)
        Me.btnStudentProfile.TabIndex = 58
        Me.btnStudentProfile.Text = "BACK"
        Me.btnStudentProfile.UseVisualStyleBackColor = False
        '
        'btnAddNewStudent
        '
        Me.btnAddNewStudent.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddNewStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewStudent.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewStudent.Location = New System.Drawing.Point(1147, 665)
        Me.btnAddNewStudent.Name = "btnAddNewStudent"
        Me.btnAddNewStudent.Size = New System.Drawing.Size(99, 26)
        Me.btnAddNewStudent.TabIndex = 59
        Me.btnAddNewStudent.Text = "BACK"
        Me.btnAddNewStudent.UseVisualStyleBackColor = False
        '
        'Frm_Camera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1258, 703)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAddNewStudent)
        Me.Controls.Add(Me.btnStudentProfile)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.btnSaveImage)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ptbTwo)
        Me.Controls.Add(Me.ptbOne)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Camera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ptbTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ptbTwo As System.Windows.Forms.PictureBox
    Friend WithEvents ptbOne As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnCaptured As System.Windows.Forms.Button
    Friend WithEvents btnSaveImage As System.Windows.Forms.Button
    Friend WithEvents panel As System.Windows.Forms.Panel
    Friend WithEvents btnStudentProfile As System.Windows.Forms.Button
    Friend WithEvents btnAddNewStudent As System.Windows.Forms.Button
End Class
