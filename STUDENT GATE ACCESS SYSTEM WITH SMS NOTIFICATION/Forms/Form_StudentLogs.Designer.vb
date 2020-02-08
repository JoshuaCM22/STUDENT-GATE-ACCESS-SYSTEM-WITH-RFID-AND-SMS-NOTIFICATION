<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_StudentLogs
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_StudentLogs))
        Me.dgvStudentLogs = New System.Windows.Forms.DataGridView()
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.cmbboxFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ptbIconOfSystem = New System.Windows.Forms.PictureBox()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.dgvStudentLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox.SuspendLayout()
        CType(Me.ptbIconOfSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvStudentLogs
        '
        Me.dgvStudentLogs.AllowUserToAddRows = False
        Me.dgvStudentLogs.AllowUserToResizeColumns = False
        Me.dgvStudentLogs.AllowUserToResizeRows = False
        Me.dgvStudentLogs.BackgroundColor = System.Drawing.Color.Khaki
        Me.dgvStudentLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudentLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStudentLogs.ColumnHeadersHeight = 41
        Me.dgvStudentLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudentLogs.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStudentLogs.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvStudentLogs.Location = New System.Drawing.Point(15, 119)
        Me.dgvStudentLogs.MultiSelect = False
        Me.dgvStudentLogs.Name = "dgvStudentLogs"
        Me.dgvStudentLogs.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.NullValue = "---------"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudentLogs.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvStudentLogs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvStudentLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudentLogs.Size = New System.Drawing.Size(1246, 532)
        Me.dgvStudentLogs.TabIndex = 0
        '
        'groupBox
        '
        Me.groupBox.BackColor = System.Drawing.Color.Transparent
        Me.groupBox.Controls.Add(Me.cmbboxFilter)
        Me.groupBox.Controls.Add(Me.txtSearch)
        Me.groupBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox.ForeColor = System.Drawing.Color.White
        Me.groupBox.Location = New System.Drawing.Point(15, 40)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(403, 69)
        Me.groupBox.TabIndex = 0
        Me.groupBox.TabStop = False
        Me.groupBox.Text = "SEARCH BY :"
        '
        'cmbboxFilter
        '
        Me.cmbboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxFilter.FormattingEnabled = True
        Me.cmbboxFilter.Items.AddRange(New Object() {"None", "Log ID", "Student ID", "Date", "Time-In", "Time-Out"})
        Me.cmbboxFilter.Location = New System.Drawing.Point(14, 28)
        Me.cmbboxFilter.Name = "cmbboxFilter"
        Me.cmbboxFilter.Size = New System.Drawing.Size(138, 24)
        Me.cmbboxFilter.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(158, 28)
        Me.txtSearch.MaxLength = 0
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(235, 22)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1162, 665)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(99, 26)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(1019, 65)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 41)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(561, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(142, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "STUDENT LOGS"
        '
        'ptbIconOfSystem
        '
        Me.ptbIconOfSystem.BackColor = System.Drawing.Color.SaddleBrown
        Me.ptbIconOfSystem.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.MYICON
        Me.ptbIconOfSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbIconOfSystem.ErrorImage = Nothing
        Me.ptbIconOfSystem.Location = New System.Drawing.Point(8, 3)
        Me.ptbIconOfSystem.Name = "ptbIconOfSystem"
        Me.ptbIconOfSystem.Size = New System.Drawing.Size(26, 27)
        Me.ptbIconOfSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbIconOfSystem.TabIndex = 135
        Me.ptbIconOfSystem.TabStop = False
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Controls.Add(Me.btnMinimize)
        Me.panelTop.Controls.Add(Me.ptbIconOfSystem)
        Me.panelTop.Controls.Add(Me.lblTitle)
        Me.panelTop.Location = New System.Drawing.Point(1, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1289, 35)
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
        Me.btnClose.Location = New System.Drawing.Point(1235, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 21)
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
        Me.btnMinimize.Location = New System.Drawing.Point(1189, 8)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 21)
        Me.btnMinimize.TabIndex = 0
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 48)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.LogoutToolStripMenuItem.Text = "logout"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.AboutToolStripMenuItem.Text = "about"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintPreview.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPrintPreview.FlatAppearance.BorderSize = 0
        Me.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintPreview.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPreview.ForeColor = System.Drawing.Color.White
        Me.btnPrintPreview.Location = New System.Drawing.Point(1121, 65)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(138, 41)
        Me.btnPrintPreview.TabIndex = 0
        Me.btnPrintPreview.Text = "PRINT PREVIEW"
        Me.btnPrintPreview.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(18, 662)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(135, 24)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "TOTAL LABEL"
        '
        'Form_StudentLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1278, 701)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvStudentLogs)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_StudentLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvStudentLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        CType(Me.ptbIconOfSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents cmbboxFilter As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvStudentLogs As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents ptbIconOfSystem As System.Windows.Forms.PictureBox
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PRINTBUTTON As System.Windows.Forms.Button
    Friend WithEvents btnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
