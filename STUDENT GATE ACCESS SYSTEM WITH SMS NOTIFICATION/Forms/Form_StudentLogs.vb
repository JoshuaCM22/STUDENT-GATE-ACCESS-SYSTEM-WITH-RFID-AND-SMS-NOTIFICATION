Imports MySql.Data.MySqlClient
Public Class Form_StudentLogs ' Created by: Joshua C. Magoliman
    Dim IdGetter As String = ""
    Private Property btnDelete As Object
    Private Sub Form_StudentLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            da = New MySqlDataAdapter("vw_getallstudentlogs", con)
            da.SelectCommand.CommandType = CommandType.TableDirect
            da.Fill(ds)
            dgvStudentLogs.DataSource = ds.Tables(0)
            dgvStudentLogs.Columns(0).Width = 240
            dgvStudentLogs.Columns(1).Width = 240
            dgvStudentLogs.Columns(2).Width = 240
            dgvStudentLogs.Columns(3).Width = 240
            dgvStudentLogs.Columns(4).Width = 240
            da.Update(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        Finally
            con.Close()
        End Try
        txtSearch.Focus()
        lblTotal.Text = "TOTAL LOGS: " + dgvStudentLogs.RowCount.ToString
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        GetData()
        cmbboxFilter.Text = "None"
        txtSearch.Clear()
        Form_Main.Show()
        Form_Main.BringToFront()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim Question As String
        Question = MsgBox("Are you sure you want to exit ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question = vbYes Then
            Me.Close()
            End
        End If
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GetData()
        cmbboxFilter.Text = "None"
        txtSearch.Clear()
    End Sub
    Private Sub dgvStudentLogs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudentLogs.CellClick
        con.Open()
        Dim row As DataGridViewRow = dgvStudentLogs.CurrentRow
        Try
            IdGetter = row.Cells(0).Value.ToString()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Objects.da = New MySqlDataAdapter()
            Objects.dt = New DataTable()
            Objects.ds = New DataSet()
            If txtSearch.Text = "" Then
                GetData()
            ElseIf cmbboxFilter.Text = "Log ID" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentLogsByLogId", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_LogID", txtSearch.Text)
                da.Fill(ds)
                dgvStudentLogs.DataSource = ds.Tables(0)
                dgvStudentLogs.Columns(0).Width = 240
                dgvStudentLogs.Columns(1).Width = 240
                dgvStudentLogs.Columns(2).Width = 240
                dgvStudentLogs.Columns(3).Width = 240
                dgvStudentLogs.Columns(4).Width = 240
            ElseIf cmbboxFilter.Text = "Student ID" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentLogsByStudentId", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_StudentID", txtSearch.Text)
                da.Fill(ds)
                dgvStudentLogs.DataSource = ds.Tables(0)
                dgvStudentLogs.Columns(0).Width = 240
                dgvStudentLogs.Columns(1).Width = 240
                dgvStudentLogs.Columns(2).Width = 240
                dgvStudentLogs.Columns(3).Width = 240
                dgvStudentLogs.Columns(4).Width = 240
            ElseIf cmbboxFilter.Text = "Date" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentLogsByDate", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_Date", txtSearch.Text)
                da.Fill(ds)
                dgvStudentLogs.DataSource = ds.Tables(0)
                dgvStudentLogs.Columns(0).Width = 240
                dgvStudentLogs.Columns(1).Width = 240
                dgvStudentLogs.Columns(2).Width = 240
                dgvStudentLogs.Columns(3).Width = 240
                dgvStudentLogs.Columns(4).Width = 240
            ElseIf cmbboxFilter.Text = "Time-In" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentLogsByTimeIn", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_TimeIn", "%" & txtSearch.Text & "%")
                da.Fill(ds)
                dgvStudentLogs.DataSource = ds.Tables(0)
                dgvStudentLogs.Columns(0).Width = 240
                dgvStudentLogs.Columns(1).Width = 240
                dgvStudentLogs.Columns(2).Width = 240
                dgvStudentLogs.Columns(3).Width = 240
                dgvStudentLogs.Columns(4).Width = 240
            ElseIf cmbboxFilter.Text = "Time-Out" Then
                con.Open()
                da = New MySqlDataAdapter("sp_GetStudentLogsByTimeOut", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("param_TimeOut", "%" & txtSearch.Text & "%")
                da.Fill(ds)
                dgvStudentLogs.DataSource = ds.Tables(0)
                dgvStudentLogs.Columns(0).Width = 240
                dgvStudentLogs.Columns(1).Width = 240
                dgvStudentLogs.Columns(2).Width = 240
                dgvStudentLogs.Columns(3).Width = 240
                dgvStudentLogs.Columns(4).Width = 240
            End If
            IdGetter = ""
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        lblTotal.Text = "TOTAL LOGS: " + dgvStudentLogs.RowCount.ToString
    End Sub
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If cmbboxFilter.Text = "Log ID" Then
            txtSearch.MaxLength = 7
        ElseIf cmbboxFilter.Text = "Student ID" Then
            txtSearch.MaxLength = 6
        ElseIf cmbboxFilter.Text = "Date" Then
            txtSearch.MaxLength = 10
        ElseIf cmbboxFilter.Text = "Time-In" Then
            txtSearch.MaxLength = 11
        ElseIf cmbboxFilter.Text = "Time-Out" Then
            txtSearch.MaxLength = 11
        Else
            txtSearch.MaxLength = 6
        End If
    End Sub
    Private Sub cmbboxFilter_TextChanged(sender As Object, e As EventArgs) Handles cmbboxFilter.TextChanged
        txtSearch.Focus()
    End Sub
    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        If Not dgvStudentLogs.RowCount < 1 Then
            TransferingInfo()
            Form_Print_StudentLogs.ShowDialog()
        End If
    End Sub
    Private Sub TransferingInfo()
        Try
            Dim x As Integer = 0
            While x < dgvStudentLogs.Rows.Count
                With dgvStudentLogs.Rows(x)
                    If Not IsDBNull(.Cells(1).Value) Then
                        con.Close()
                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "INSERT INTO tbl_print_studentlogs (Log_Id, Student_ID, Date, Time_In, Time_Out) values (@LogId, @Student_ID, @Date, @Time_In, @Time_Out); "
                        cmd.Parameters.Add(New MySqlParameter("@LogId", .Cells(0).Value.ToString))
                        cmd.Parameters.Add(New MySqlParameter("@Student_ID", .Cells(1).Value.ToString))
                        cmd.Parameters.Add(New MySqlParameter("@Date", .Cells(2).Value))
                        cmd.Parameters.Add(New MySqlParameter("@Time_In", .Cells(3).Value.ToString))
                        cmd.Parameters.Add(New MySqlParameter("@Time_Out", .Cells(4).Value.ToString))
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        con.Close()
                    End If
                End With
                con.Close()
                x = x + 1
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub
End Class