Imports MySql.Data.MySqlClient
Public Class Form_Print_StudentLogs ' Created by: Joshua C. Magoliman
    Public Sub DeletingAllPrintPreview()
        Try
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "TRUNCATE tbl_print_studentlogs;"
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Form_Print_StudentLogs_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        DeletingAllPrintPreview()
    End Sub

    Private Sub Form_Print_StudentLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class