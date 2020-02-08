Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form_Profile ' Created by: Joshua C. Magoliman
    Dim arrImage() As Byte
    Dim gender As String
    Dim gradeLevel As String
    Dim photo As Image = My.Resources.USERICON
    Public photoGetter As Image
    Private Sub Form_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub Reset()
        txtStudentID.Enabled = False
        txtRFID.Enabled = False
        txtSuffix.Enabled = False
        txtLastName.Enabled = False
        txtGivenName.Enabled = False
        txtMiddleName.Enabled = False
        rbMale.Enabled = False
        rbFemale.Enabled = False
        dtpDateOfBirth.Enabled = False
        txtAge.Enabled = False
        txtMiddleName.Enabled = False
        txtContactPerson.Enabled = False
        txtAddress.Enabled = False
        cmbRelationship.Enabled = False
        txtContactNumber.Enabled = False
        rbGrade7.Enabled = False
        rbGrade8.Enabled = False
        rbGrade9.Enabled = False
        rbGrade10.Enabled = False
        btnBrowse.Enabled = False
        btnTakeAPicture.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = True
        btnClose.Text = "CLOSE"
    End Sub
    Public Sub photoValidation()
        If Not IsNothing(photoGetter) Then
            ptbProfile.Image = photoGetter
        End If
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog.Filter = "image file (*.jpg, *.gif, *.bmp, *.png) | *.jpg; *.gif; *.bmp; *.png *.| all files (*.*) | *.*"
        If OpenFileDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            ptbProfile.Image = Image.FromFile(OpenFileDialog.FileName)
        End If
    End Sub
    Private Sub btnTakeAPicture_Click(sender As Object, e As EventArgs) Handles btnTakeAPicture.Click
        Me.Enabled = False
        Form_Camera.btnAddNewStudent.Visible = False
        Form_Camera.btnStudentProfile.Visible = True
        Form_Camera.Reset()
        Form_Camera.Show()
    End Sub
    Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        gender = "1"
    End Sub
    Private Sub rbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbFemale.CheckedChanged
        gender = "2"
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim question As String
        question = MsgBox("Are you sure you want to delete? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If question = vbYes Then
            Try
                con.Open()
                cmd = New MySqlCommand("sp_DeleteExistingStudent", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("param_StudentId", txtStudentID.Text)
                cmd.ExecuteNonQuery()
                MsgBox("SUCCESSFULLY DELETED", MsgBoxStyle.Information, "ATTENTION")
                con.Close()
                Reset()
                Me.Hide()
                photoGetter = Nothing
                Form_StudentRecords.Enabled = True
                Form_StudentRecords.BringToFront()
                Form_StudentRecords.btnBack.Visible = True
                Form_StudentRecords.GetData()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If btnClose.Text = "CANCEL" Then
            Dim question As String
            question = MsgBox("Are you sure you want to cancel ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If question = vbYes Then
                Me.Hide()
                Reset()
                Form_StudentRecords.btnBack.Visible = True
                Form_StudentRecords.Enabled = True
                Form_StudentRecords.BringToFront()
                Form_StudentRecords.GetData()
            End If
        Else
            Me.Hide()
            Reset()
            Form_StudentRecords.btnBack.Visible = True
            Form_StudentRecords.Enabled = True
            Form_StudentRecords.BringToFront()
            Form_StudentRecords.GetData()
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtLastName.Text = "" Then
            MsgBox("No Last Name Found!", MsgBoxStyle.Critical, "Error")
            txtLastName.Focus()
        ElseIf txtGivenName.Text = "" Then
            MsgBox("No Given Name Found!", MsgBoxStyle.Critical, "Error")
            txtGivenName.Focus()
        ElseIf txtMiddleName.Text = "" Then
            MsgBox("No Middle Name Found!", MsgBoxStyle.Critical, "Error")
            txtMiddleName.Focus()
        ElseIf rbMale.Checked = False And rbFemale.Checked = False Then
            MsgBox("No Gender Found!", MsgBoxStyle.Critical, "Error")
        ElseIf dtpDateOfBirth.Value = Date.Now.ToString("dd/MM/yyyy") Then
            MsgBox("Date today is not valid!", MsgBoxStyle.Critical, "Error")
            dtpDateOfBirth.Focus()
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
        Else
            Try
                Dim mstream As New System.IO.MemoryStream()
                ptbProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = mstream.GetBuffer()
                mstream.Close()
                Dim question As String
                question = MsgBox("Are you sure you want to update ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
                If question = vbYes Then
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
                    con.Open()
                    cmd = New MySqlCommand("sp_UpdateExistingStudent", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New MySqlParameter("@param_LastName", txtLastName.Text))
                    cmd.Parameters.Add(New MySqlParameter("@param_GivenName", txtGivenName.Text))
                    cmd.Parameters.Add(New MySqlParameter("@param_MiddleName", txtMiddleName.Text))
                    cmd.Parameters.Add(New MySqlParameter("@param_Suffix", txtSuffix.Text))
                    cmd.Parameters.Add(New MySqlParameter("@param_GenderId", gender))
                    cmd.Parameters.Add(New MySqlParameter("@param_DateOfBirth", dtpDateOfBirth.Value))
                    cmd.Parameters.Add(New MySqlParameter("@param_Age", txtAge.Text))
                    cmd.Parameters.Add(New MySqlParameter("@param_Address", txtAddress.Text))
                    cmd.Parameters.Add(New MySqlParameter("@param_ContactPerson", txtContactPerson.Text))
                    cmd.Parameters.Add(New MySqlParameter("@param_RelationshipId", relationshipValue))
                    cmd.Parameters.Add(New MySqlParameter("@param_ContactNumber", txtContactNumber.Text))
                    cmd.Parameters.Add(New MySqlParameter("@param_GradeLevelId", gradeLevel))
                    cmd.Parameters.Add(New MySqlParameter("@param_Photo", arrImage))
                    cmd.Parameters.Add(New MySqlParameter("@param_StudentId", txtStudentID.Text))
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    con.Close()
                    MsgBox("SUCCESSFULLY UPDATED", MsgBoxStyle.Information, "ATTENTION")
                    Reset()
                    photoGetter = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
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
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        lblTitle.Focus()
        btnEdit.Enabled = False
        txtSuffix.Enabled = True
        txtLastName.Enabled = True
        txtGivenName.Enabled = True
        txtMiddleName.Enabled = True
        rbMale.Enabled = True
        rbFemale.Enabled = True
        dtpDateOfBirth.Enabled = True
        txtAge.Enabled = True
        txtAddress.Enabled = True
        txtContactPerson.Enabled = True
        cmbRelationship.Enabled = True
        txtContactNumber.Enabled = True
        rbGrade7.Enabled = True
        rbGrade8.Enabled = True
        rbGrade9.Enabled = True
        rbGrade10.Enabled = True
        btnBrowse.Enabled = True
        btnTakeAPicture.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnClose.Text = "CANCEL"
    End Sub
    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtGivenName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGivenName.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtMiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddleName.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
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
    Private Sub txtContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactNumber.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class