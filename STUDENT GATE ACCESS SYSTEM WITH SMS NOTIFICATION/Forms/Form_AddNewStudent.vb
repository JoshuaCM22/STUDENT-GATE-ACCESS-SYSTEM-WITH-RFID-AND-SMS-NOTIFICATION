Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form_AddNewStudent ' Created by: Joshua C. Magoliman
    Dim arrImage() As Byte
    Dim gender As String
    Dim gradeLevel As String
    Dim photo As Image = My.Resources.USERICON
    Public photoGetter As Image
    Private Sub Form_AddNewStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Public Sub Reset()
        ptbProfile.Image = photo
        txtRFID.Focus()
        txtRFID.Clear()
        txtSuffix.Clear()
        txtLastName.Clear()
        txtGivenName.Clear()
        txtMiddleName.Clear()
        rbMale.Checked = False
        rbFemale.Checked = False
        txtAddress.Clear()
        txtContactPerson.Clear()
        cmbRelationship.Text = ""
        txtContactNumber.Clear()
        rbGrade7.Checked = False
        rbGrade8.Checked = False
        rbGrade9.Checked = False
        rbGrade10.Checked = False
        cmbMonth.Text = "Month"
        cmbDay.Text = "Day"
        txtYear.Text = "Year"
        txtAge.Clear()
        txtSuffix.Enabled = False
        txtLastName.Enabled = False
        txtGivenName.Enabled = False
        txtMiddleName.Enabled = False
        txtAge.Enabled = False
        txtAddress.Enabled = False
        txtContactPerson.Enabled = False
        cmbRelationship.Enabled = False
        txtContactNumber.Enabled = False
        cmbMonth.Enabled = False
        cmbDay.Enabled = False
        txtYear.Enabled = False
        rbMale.Enabled = False
        rbFemale.Enabled = False
        rbGrade7.Enabled = False
        rbGrade8.Enabled = False
        rbGrade9.Enabled = False
        rbGrade10.Enabled = False
        btnTakeAPicture.Enabled = False
        btnAdd.Enabled = False
        btnBrowse.Enabled = False
        txtTwoDigitNumber.Text = "09"
        txtContactNumber.Clear()
        btnClose.Text = "CLOSE"
    End Sub
    Public Sub photoValidation()
        If IsNothing(photoGetter) Then
            ptbProfile.Image = photo
        Else
            ptbProfile.Image = photoGetter
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If btnClose.Text = "CANCEL" Then
            Dim Question As String
            Question = MsgBox("Are you sure you want to cancel ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If Question = vbYes Then
                Me.Hide()
                Reset()
                Form_StudentRecords.btnBack.Visible = True
                Form_StudentRecords.Enabled = True
                Form_StudentRecords.BringToFront()
                Form_StudentRecords.GetData()
            End If
        Else
            Me.Hide()
            Form_StudentRecords.btnBack.Visible = True
            Form_StudentRecords.Enabled = True
            Form_StudentRecords.BringToFront()
            Form_StudentRecords.GetData()
        End If
    End Sub
    Private Sub txtRFID_TextChanged(sender As Object, e As EventArgs) Handles txtRFID.TextChanged
        If txtRFID.Text = "" Then
            btnClose.Text = "CLOSE"
        Else
            btnClose.Text = "CANCEL"
        End If
        txtSuffix.Enabled = True
        txtLastName.Enabled = True
        txtGivenName.Enabled = True
        txtMiddleName.Enabled = True
        txtAge.Enabled = True
        txtAddress.Enabled = True
        txtContactPerson.Enabled = True
        cmbRelationship.Enabled = True
        txtContactNumber.Enabled = True
        cmbMonth.Enabled = True
        cmbDay.Enabled = True
        txtYear.Enabled = True
        rbMale.Enabled = True
        rbFemale.Enabled = True
        rbGrade7.Enabled = True
        rbGrade8.Enabled = True
        rbGrade9.Enabled = True
        rbGrade10.Enabled = True
        btnTakeAPicture.Enabled = True
        btnAdd.Enabled = True
        btnBrowse.Enabled = True
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM tbl_students WHERE RFId = @RFId ", con)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New MySqlParameter("@RFId", txtRFID.Text))
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("This RFId is already taken! Please try another RFID number", MsgBoxStyle.Critical, "Error")
                dr.Close()
                con.Close()
            ElseIf dr.Read = False Then
                dr.Close()
                con.Close()
                Validation()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Validation()
        If txtRFID.Text = "" Then
            MsgBox("No RFID Found!", MsgBoxStyle.Critical, "Error")
            txtRFID.Focus()
        ElseIf txtLastName.Text = "" Then
            MsgBox("No Last Name Found!", MsgBoxStyle.Critical, "Error")
            txtLastName.Focus()
        ElseIf txtGivenName.Text = "" Then
            MsgBox("No Given Name Found!", MsgBoxStyle.Critical, "Error")
            txtGivenName.Focus()
        ElseIf txtMiddleName.Text = "" Then
            MsgBox("No Middle Name Found!", MsgBoxStyle.Critical, "Error")
            txtMiddleName.Focus()
        ElseIf rbMale.Checked = False And rbFemale.Checked = False Then
            MsgBox("No gender Found!", MsgBoxStyle.Critical, "Error")
        ElseIf cmbMonth.Text = "Month" Then
            MsgBox("No Month Found!", MsgBoxStyle.Critical, "Error")
            cmbMonth.Focus()
        ElseIf cmbDay.Text = "Day" Then
            MsgBox("No Day Found!", MsgBoxStyle.Critical, "Error")
            cmbDay.Focus()
        ElseIf txtYear.Text = "Year" Then
            MsgBox("No Year Found!", MsgBoxStyle.Critical, "Error")
            txtYear.Focus()
        ElseIf txtAge.Text = "" Then
            MsgBox("No Age Found!", MsgBoxStyle.Critical, "Error")
            txtAge.Focus()
        ElseIf txtAddress.Text = "" Then
            MsgBox("No Address Found!", MsgBoxStyle.Critical, "Error")
            txtAddress.Focus()
        ElseIf txtContactPerson.Text = "" Then
            MsgBox("No Contact Person Found!", MsgBoxStyle.Critical, "Error")
            txtContactPerson.Focus()
        ElseIf cmbRelationship.Text = "" Then
            MsgBox("No Relationship Found!", MsgBoxStyle.Critical, "Error")
            cmbRelationship.Focus()
        ElseIf txtContactNumber.Text = "" Then
            MsgBox("No Contact Number Found!", MsgBoxStyle.Critical, "Error")
            txtContactNumber.Focus()
        ElseIf rbGrade7.Checked = False And rbGrade8.Checked = False And rbGrade9.Checked = False And rbGrade10.Checked = False Then
            MsgBox("No Grade Level Found!", MsgBoxStyle.Critical, "Error")
        ElseIf ptbProfile.Image Is photo Then
            MsgBox("No Photo Found!", MsgBoxStyle.Critical, "Error")
            btnBrowseClicked()
        Else
            Dim mstream As New System.IO.MemoryStream()
            ptbProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt64
            FileSize = mstream.Length
            mstream.Close()
            Dim combine As String
            combine = cmbMonth.Text & Space(1) + cmbDay.Text + (",") & Space(1) + txtYear.Text
            Dim relationshipValue As String = ""
            If cmbRelationship.Text = "Father" Then
                relationshipValue = "1"
            ElseIf cmbRelationship.Text = "Mother" Then
                relationshipValue = "2"
            ElseIf cmbRelationship.Text = "Elder Brother" Then
                relationshipValue = "3"
            ElseIf cmbRelationship.Text = "Elder Sister" Then
                relationshipValue = "4"
            ElseIf cmbRelationship.Text = "Grand Father" Then
                relationshipValue = "5"
            ElseIf cmbRelationship.Text = "Grand Mother" Then
                relationshipValue = "6"
            ElseIf cmbRelationship.Text = "Uncle" Then
                relationshipValue = "7"
            ElseIf cmbRelationship.Text = "Aunt" Then
                relationshipValue = "8"
            ElseIf cmbRelationship.Text = "Step Father" Then
                relationshipValue = "9"
            ElseIf cmbRelationship.Text = "Step Mother" Then
                relationshipValue = "10"
            End If
            Try
                con.Open()
                cmd = New MySqlCommand("sp_InsertNewStudent", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New MySqlParameter("@param_StudentID", txtStudentID.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_RFId", txtRFID.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_LastName", txtLastName.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_GivenName", txtGivenName.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_MiddleName", txtMiddleName.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_Suffix", txtSuffix.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_GenderId", gender))
                cmd.Parameters.Add(New MySqlParameter("@param_DateOfBirth", Convert.ToDateTime(combine)))
                cmd.Parameters.Add(New MySqlParameter("@param_Age", txtAge.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_Address", txtAddress.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_ContactPerson", txtContactPerson.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_RelationshipId", relationshipValue))
                cmd.Parameters.Add(New MySqlParameter("@param_ContactNumber", txtTwoDigitNumber.Text + txtContactNumber.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_GradeLevelId", gradeLevel))
                cmd.Parameters.Add(New MySqlParameter("@param_Photo", arrImage))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("SUCCESSFULLY ADDED", MsgBoxStyle.Information, "ATTENTION")
                con.Close()
                Reset()
                photoGetter = Nothing
                Form_StudentRecords.GeneratingStudentID()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        Dim todayYear As Integer = Today.Year
        Dim todayDay As Integer = Today.Day
        Dim todayMonth As Integer = Today.Month
        Dim getValueOfYear As Integer = Val(txtYear.Text)
        Dim getValueOfDay As Integer = Val(cmbDay.Text)
        Dim getValueOfMonth As String = cmbMonth.SelectedIndex + 1
        Dim finalOutput As Integer = todayYear - getValueOfYear
        If todayMonth = getValueOfMonth Then
            If todayDay < getValueOfDay Then
                finalOutput -= 1
            End If
        ElseIf todayMonth < getValueOfMonth Then
            finalOutput -= 1
        End If
        txtAge.Text = finalOutput
    End Sub
    Private Sub cmbMonth_Layout(sender As Object, e As LayoutEventArgs) Handles cmbMonth.Layout
        Me.cmbMonth.Text = "Month"
    End Sub
    Private Sub cmbMonth_Click(sender As Object, e As EventArgs) Handles cmbMonth.Click
        Me.cmbMonth.Text = ""
    End Sub
    Private Sub cmbMonth_Leave(sender As Object, e As EventArgs) Handles cmbMonth.Leave
        If cmbMonth.Text = "" Then
            Me.cmbMonth.Text = "Month"
        End If
    End Sub
    Private Sub txtYear_Layout(sender As Object, e As LayoutEventArgs) Handles txtYear.Layout
        Me.txtYear.Text = "Year"
    End Sub
    Private Sub txtYear_Click(sender As Object, e As EventArgs) Handles txtYear.Click
        Me.txtYear.Clear()
    End Sub
    Private Sub txtYear_Leave(sender As Object, e As EventArgs) Handles txtYear.Leave
        If txtYear.Text = "" Then
            Me.txtYear.Text = "Year"
        End If
    End Sub
    Private Sub cmbDay_Layout(sender As Object, e As LayoutEventArgs) Handles cmbDay.Layout
        Me.cmbDay.Text = "Day"
    End Sub
    Private Sub cmbDay_Click(sender As Object, e As EventArgs) Handles cmbDay.Click
        Me.cmbDay.Text = ""
    End Sub
    Private Sub cmbDay_Leave(sender As Object, e As EventArgs) Handles cmbDay.Leave
        If cmbDay.Text = "" Then
            Me.cmbDay.Text = "Day"
        End If
    End Sub
    Private Sub txtAge_Leave(sender As Object, e As EventArgs) Handles txtAge.Leave
        If txtAge.Text = "2019" Then
            Me.txtAge.Clear()
        End If
    End Sub
    Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        gender = "1"
    End Sub
    Private Sub rbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbFemale.CheckedChanged
        gender = "2"
    End Sub
    Private Sub rbGrade7_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrade7.CheckedChanged
        gradeLevel = "1"
    End Sub
    Private Sub rbGrade8_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrade8.CheckedChanged
        gradeLevel = "2"
    End Sub
    Private Sub rbGrade9_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrade9.CheckedChanged
        gradeLevel = "3"
    End Sub
    Private Sub rbGrade10_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrade10.CheckedChanged
        gradeLevel = "4"
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        btnBrowseClicked()
    End Sub
    Private Sub btnBrowseClicked()
        OpenFileDialog.Filter = "image file (*.jpg, *.gif, *.bmp, *.png) | *.jpg; *.gif; *.bmp; *.png *.| all files (*.*) | *.*"
        If OpenFileDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            ptbProfile.Image = Image.FromFile(OpenFileDialog.FileName)
        End If
    End Sub
    Private Sub btnTakeAPicture_Click(sender As Object, e As EventArgs) Handles btnTakeAPicture.Click
        Me.Enabled = False
        Form_Camera.btnAddNewStudent.Visible = True
        Form_Camera.btnStudentProfile.Visible = False
        Form_Camera.Reset()
        Form_Camera.Show()
    End Sub
    Private Sub txtRFID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRFID.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtGivenName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGivenName.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtContactPerson_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactPerson.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactNumber.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtMiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddleName.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cmbMonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbMonth.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cmbDay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDay.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cmbRelationship_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbRelationship.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class

