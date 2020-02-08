Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form_StudentRecords ' Created by: Joshua C. Magoliman
    Dim arrImage() As Byte
    Dim Gender As String
    Dim Gradelevel As String
    Private Sub Form_StudentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        cmbboxFilter.Text = "None"
        txtSearch.Clear()
    End Sub
    Public Sub GetData()
        Try
            Objects.da = New MySqlDataAdapter()
            Objects.dt = New DataTable()
            Objects.ds = New DataSet()
            con.Open()
            da = New MySqlDataAdapter("vw_getallstudents", con)
            da.SelectCommand.CommandType = CommandType.TableDirect
            da.Fill(ds)
            dgvStudents.DataSource = ds.Tables(0)
            dgvStudents.Columns(14).Visible = False
            dgvStudents.Columns(0).Width = 200
            dgvStudents.Columns(1).Width = 200
            dgvStudents.Columns(2).Width = 200
            dgvStudents.Columns(3).Width = 200
            dgvStudents.Columns(4).Width = 200
            dgvStudents.Columns(5).Width = 200
            dgvStudents.Columns(6).Width = 100
            dgvStudents.Columns(7).Width = 130
            dgvStudents.Columns(8).Width = 60
            dgvStudents.Columns(9).Width = 400
            dgvStudents.Columns(10).Width = 300
            dgvStudents.Columns(11).Width = 200
            dgvStudents.Columns(12).Width = 200
            dgvStudents.Columns(13).Width = 200
            da.Update(dt)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
        lblTotal.Text = "TOTAL STUDENTS: " + dgvStudents.RowCount.ToString
        txtSearch.Focus()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Objects.da = New MySqlDataAdapter()
            Objects.dt = New DataTable()
            Objects.ds = New DataSet()
            If txtSearch.Text = "" Then
                GetData()
            ElseIf cmbboxFilter.Text = "Student ID" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByStudentId", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_StudentId", txtSearch.Text)
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "RFID" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByRFId", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_RFId", txtSearch.Text)
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "Last Name" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByLastName", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_LastName", "%" & txtSearch.Text & "%")
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "Given Name" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByGivenName", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_GivenName", "%" & txtSearch.Text & "%")
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "Middle Name" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByMiddleName", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_MiddleName", "%" & txtSearch.Text & "%")
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "Suffix" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentBySuffix", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_Suffix", "%" & txtSearch.Text & "%")
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "Gender" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByGender", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_Gender", txtSearch.Text & "%")
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "Date of Birth" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByDateOfBirth", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_DateOfBirth", "%" & txtSearch.Text & "%")
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "Age" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByAge", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_Age", txtSearch.Text)
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "Address" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByAddress", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_Address", "%" & txtSearch.Text & "%")
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "Contact Person" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByContactPerson", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_ContactPerson", "%" & txtSearch.Text & "%")
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "Relationship" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByRelationship", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_Relationship", "%" & txtSearch.Text & "%")
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "Contact Number" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByContactNumber", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_ContactNumber", txtSearch.Text)
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            ElseIf cmbboxFilter.Text = "Grade Level" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentByGradeLevel", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_GradeLevel", "%" & txtSearch.Text & "%")
                da.Fill(ds)
                dgvStudents.DataSource = ds.Tables(0)
                dgvStudents.Columns(0).Width = 200
                dgvStudents.Columns(1).Width = 200
                dgvStudents.Columns(2).Width = 200
                dgvStudents.Columns(3).Width = 200
                dgvStudents.Columns(4).Width = 200
                dgvStudents.Columns(5).Width = 200
                dgvStudents.Columns(6).Width = 100
                dgvStudents.Columns(7).Width = 130
                dgvStudents.Columns(8).Width = 60
                dgvStudents.Columns(9).Width = 400
                dgvStudents.Columns(10).Width = 300
                dgvStudents.Columns(11).Width = 200
                dgvStudents.Columns(12).Width = 200
                dgvStudents.Columns(13).Width = 200
            End If
            con.Close()
            lblTotal.Text = "TOTAL STUDENTS: " + dgvStudents.RowCount.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If cmbboxFilter.Text = "Student ID" Then
            txtSearch.MaxLength = 6
        ElseIf cmbboxFilter.Text = "RFID" Then
            txtSearch.MaxLength = 10
        ElseIf cmbboxFilter.Text = "Last Name" Then
            txtSearch.MaxLength = 16
        ElseIf cmbboxFilter.Text = "Given Name" Then
            txtSearch.MaxLength = 16
        ElseIf cmbboxFilter.Text = "Middle Name" Then
            txtSearch.MaxLength = 16
        ElseIf cmbboxFilter.Text = "Suffix" Then
            txtSearch.MaxLength = 16
        ElseIf cmbboxFilter.Text = "Gender" Then
            txtSearch.MaxLength = 6
        ElseIf cmbboxFilter.Text = "Date of Birth" Then
            txtSearch.MaxLength = 10
        ElseIf cmbboxFilter.Text = "Age" Then
            txtSearch.MaxLength = 2
        ElseIf cmbboxFilter.Text = "Address" Then
            txtSearch.MaxLength = 70
        ElseIf cmbboxFilter.Text = "Contact Person" Then
            txtSearch.MaxLength = 48
        ElseIf cmbboxFilter.Text = "Relationship" Then
            txtSearch.MaxLength = 13
        ElseIf cmbboxFilter.Text = "Contact Number" Then
            txtSearch.MaxLength = 11
        ElseIf cmbboxFilter.Text = "Grade Level" Then
            txtSearch.MaxLength = 8
        ElseIf cmbboxFilter.Text = "None" Then
            txtSearch.MaxLength = 10
        End If
    End Sub
    Private Sub btnAddNewStudent_Click(sender As Object, e As EventArgs) Handles btnAddNewStudent.Click
        GeneratingStudentID()
        Form_AddNewStudent.Show()
        Form_AddNewStudent.Reset()
        btnBack.Visible = False
        Me.Enabled = False
    End Sub
    Public Sub GeneratingStudentID()
        con.Open()
        cmd = New MySqlCommand("Select Max(Id) from tbl_students;", con)
        cmd.CommandType = CommandType.Text
        Dim id As Integer
        Dim value As String
        value = cmd.ExecuteScalar().ToString()
        If String.IsNullOrEmpty(value) Then
            value = "00000"
        End If
        value = value.Substring(0)
        Int32.TryParse(value, id)
        id = id + 1
        value = id.ToString("d5")
        Form_AddNewStudent.txtStudentID.Text = value
        con.Close()
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim Question As String
        Question = MsgBox("Are you sure you want to exit ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question = vbYes Then
            Me.Close()
            End
        End If
    End Sub
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        con.Open()
        Dim row As DataGridViewRow = dgvStudents.CurrentRow
        Try
            Me.Enabled = False
            Form_Profile.Show()
            Form_Profile.lblTitle.Focus()
            btnBack.Visible = False
            Form_Profile.txtStudentID.Text = row.Cells(0).Value.ToString()
            Form_Profile.txtRFID.Text = row.Cells(1).Value.ToString()
            Form_Profile.txtLastName.Text = row.Cells(2).Value.ToString()
            Form_Profile.txtGivenName.Text = row.Cells(3).Value.ToString()
            Form_Profile.txtMiddleName.Text = row.Cells(4).Value.ToString()
            Form_Profile.txtSuffix.Text = row.Cells(5).Value.ToString()
            Dim gettingGender As String
            gettingGender = row.Cells("Gender").Value.ToString
            If gettingGender = "Male" Then
                Form_Profile.rbMale.Checked = True
            ElseIf gettingGender = "Female" Then
                Form_Profile.rbFemale.Checked = True
            End If
            Form_Profile.dtpDateOfBirth.Value = row.Cells(7).Value.ToString()
            Form_Profile.txtAge.Text = row.Cells(8).Value.ToString()
            Form_Profile.txtAddress.Text = row.Cells(9).Value.ToString()
            Form_Profile.txtContactPerson.Text = row.Cells(10).Value.ToString()
            Form_Profile.cmbRelationship.Text = row.Cells(11).Value.ToString()
            Form_Profile.txtContactNumber.Text = row.Cells(12).Value.ToString()
            Dim gettingGradeLevel As String
            gettingGradeLevel = row.Cells(13).Value.ToString()
            If gettingGradeLevel = "Grade 7" Then
                Form_Profile.rbGrade7.Checked = True
            ElseIf gettingGradeLevel = "Grade 8" Then
                Form_Profile.rbGrade8.Checked = True
            ElseIf gettingGradeLevel = "Grade 9" Then
                Form_Profile.rbGrade9.Checked = True
            ElseIf gettingGradeLevel = "Grade 10" Then
                Form_Profile.rbGrade10.Checked = True
            End If
            Dim arrImage As Byte() = row.Cells("Photo").Value
            Dim mstream As New MemoryStream(arrImage)
            Form_Profile.ptbProfile.Image = Image.FromStream(mstream)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Reset()
        cmbboxFilter.Text = "None"
        txtSearch.Clear()
        Form_Main.Show()
        Form_Main.Reset()
    End Sub
    Private Sub cmbboxFilter_TextChanged(sender As Object, e As EventArgs) Handles cmbboxFilter.TextChanged
        txtSearch.Focus()
    End Sub
End Class


