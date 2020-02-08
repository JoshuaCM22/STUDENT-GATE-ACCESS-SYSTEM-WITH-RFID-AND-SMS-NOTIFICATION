<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_StudentRecords
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_StudentRecords))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.cmbboxFilter = New System.Windows.Forms.ComboBox()
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ptbIconOfSystem = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAddNewStudent = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.ptbIconOfSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(188, 28)
        Me.txtSearch.MaxLength = 0
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(219, 22)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        Me.OpenFileDialog.Filter = "jpg and gif(*.jpg;*.gif)|*.jpg;*.gif"
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToResizeColumns = False
        Me.dgvStudents.AllowUserToResizeRows = False
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.Khaki
        Me.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudents.ColumnHeadersHeight = 41
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudents.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudents.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvStudents.Location = New System.Drawing.Point(21, 145)
        Me.dgvStudents.MultiSelect = False
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.NullValue = "---------"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(1245, 503)
        Me.dgvStudents.TabIndex = 0
        '
        'cmbboxFilter
        '
        Me.cmbboxFilter.BackColor = System.Drawing.Color.White
        Me.cmbboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxFilter.FormattingEnabled = True
        Me.cmbboxFilter.Items.AddRange(New Object() {"None", "Student ID", "RFID", "Last Name", "Given Name", "Middle Name", "Suffix", "Gender", "Date of Birth", "Age", "Address", "Contact Person", "Relationship", "Contact Number", "Grade Level"})
        Me.cmbboxFilter.Location = New System.Drawing.Point(14, 28)
        Me.cmbboxFilter.Name = "cmbboxFilter"
        Me.cmbboxFilter.Size = New System.Drawing.Size(157, 24)
        Me.cmbboxFilter.TabIndex = 0
        '
        'groupBox
        '
        Me.groupBox.BackColor = System.Drawing.Color.Transparent
        Me.groupBox.Controls.Add(Me.cmbboxFilter)
        Me.groupBox.Controls.Add(Me.txtSearch)
        Me.groupBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox.ForeColor = System.Drawing.Color.White
        Me.groupBox.Location = New System.Drawing.Point(21, 57)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(423, 69)
        Me.groupBox.TabIndex = 0
        Me.groupBox.TabStop = False
        Me.groupBox.Text = "SEARCH BY :"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = "jpg|*.jpg|gif|*.gif "
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1167, 663)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(99, 26)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelTop.Controls.Add(Me.btnMinimize)
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Controls.Add(Me.ptbIconOfSystem)
        Me.panelTop.Controls.Add(Me.lblTitle)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1287, 37)
        Me.panelTop.TabIndex = 0
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
        Me.btnMinimize.Location = New System.Drawing.Point(1200, 7)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 21)
        Me.btnMinimize.TabIndex = 0
        Me.btnMinimize.UseVisualStyleBackColor = False
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
        Me.btnClose.Location = New System.Drawing.Point(1246, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 21)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ptbIconOfSystem
        '
        Me.ptbIconOfSystem.BackColor = System.Drawing.Color.SaddleBrown
        Me.ptbIconOfSystem.BackgroundImage = Global.STUDENT_GATE_ACCESS_SYSTEM_WITH_SMS_NOTIFICATION.My.Resources.Resources.MYICON
        Me.ptbIconOfSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbIconOfSystem.ErrorImage = Nothing
        Me.ptbIconOfSystem.Location = New System.Drawing.Point(8, 5)
        Me.ptbIconOfSystem.Name = "ptbIconOfSystem"
        Me.ptbIconOfSystem.Size = New System.Drawing.Size(26, 27)
        Me.ptbIconOfSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbIconOfSystem.TabIndex = 134
        Me.ptbIconOfSystem.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(554, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(177, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "STUDENT RECORDS"
        '
        'btnAddNewStudent
        '
        Me.btnAddNewStudent.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnAddNewStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewStudent.FlatAppearance.BorderSize = 0
        Me.btnAddNewStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnAddNewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewStudent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewStudent.ForeColor = System.Drawing.Color.White
        Me.btnAddNewStudent.Location = New System.Drawing.Point(1082, 93)
        Me.btnAddNewStudent.Name = "btnAddNewStudent"
        Me.btnAddNewStudent.Size = New System.Drawing.Size(184, 33)
        Me.btnAddNewStudent.TabIndex = 0
        Me.btnAddNewStudent.Text = "ADD A NEW STUDENT"
        Me.btnAddNewStudent.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(24, 663)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(135, 24)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "TOTAL LABEL"
        '
        'Form_StudentRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1287, 701)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnAddNewStudent)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.groupBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_StudentRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.ptbIconOfSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmbboxFilter As System.Windows.Forms.ComboBox
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents ptbIconOfSystem As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAddNewStudent As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
