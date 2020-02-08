Imports System.IO.Ports
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form_Attendance ' Created by: Joshua C. Magoliman
    Dim SerialPort1 As New System.IO.Ports.SerialPort()
    Dim secs = "00"
    Dim arrImage() As Byte
    Dim studentLogsIdGetter As String = ""
    Dim studentIdGetter As String = ""
    Dim convertedFormatDate = Date.Now.ToString("yyyy-MM-dd")
    Dim strNull As String = ""
    Private Sub Form_Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Public Sub Reset()
        txtGetRFId.Clear()
        txtGetRFId.Focus()
        Timer1.Start()
        lblDateToday.Text = Date.Now.ToString("MMMM dd, yyyy")
        lblDayNow.Text = WeekdayName(Weekday(Now))
        txtStudentId.Enabled = False
        txtFullName.Enabled = False
        txtYearLevel.Enabled = False
        txtDate.Enabled = False
        txtTime.Enabled = False
        txtStatus.Enabled = False
        Dim connectedCOM As String = Form_SettingConnection.portName
        SerialPort1.PortName = connectedCOM
        SerialPort1.BaudRate = 9600
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.Handshake = Handshake.RequestToSend
        SerialPort1.DtrEnable = True
        SerialPort1.RtsEnable = True
        SerialPort1.NewLine = vbCrLf
        btnGoToLogin.Visible = True
    End Sub
    Private Sub Form_Attendance_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Insert Then
            Form_Login.Show()
            Form_Login.txtUsername.Focus()
            Hide()
        ElseIf e.KeyCode = Keys.Escape Then
            btnClose.PerformClick()
        ElseIf e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimeNow.Text = TimeOfDay.ToString("h:mm:ss tt")
        lblDateToday.Text = Date.Now.ToString("MMMM dd, yyyy")
        lblDayNow.Text = WeekdayName(Weekday(Now))
        If Not secs = "100" Then
            secs += 1
        Else
            secs = 1
            txtGetRFId.Text = ""
            txtStudentId.Text = ""
            txtFullName.Text = ""
            txtYearLevel.Text = ""
            txtDate.Text = ""
            txtTime.Text = ""
            txtStatus.Text = ""
            txtStudentId.Enabled = False
            txtFullName.Enabled = False
            txtYearLevel.Enabled = False
            txtDate.Enabled = False
            txtTime.Enabled = False
            txtStatus.Enabled = False
            ptbProfile.Image = My.Resources.USERICON()
            txtGetRFId.Focus()
        End If
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        txtGetRFId.Focus()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim Question As String
        Question = MsgBox("Are you sure you want to exit ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question = vbYes Then
            Me.Close()
            End
        ElseIf Question = vbNo Then
            txtGetRFId.Focus()
        End If
    End Sub
    Private Sub btnGoToLogin_Click(sender As Object, e As EventArgs) Handles btnGoToLogin.Click
        Form_Login.Show()
        Form_Login.txtUsername.Focus()
        Form_Login.txtUsername.Clear()
        Form_Login.txtPassword.Clear()
        Me.Hide()
    End Sub
    Private Sub txtGetRFId_TextChanged(sender As Object, e As EventArgs) Handles txtGetRFId.TextChanged
        Dim inScript As String = " has entered the school in the time of"
        Dim outScript As String = " has left the school in the time of"
        Dim fromScript As String = "From: Saint Francis School"
        Dim greetScript As String = "Good Day Parent/Guardian!"
        Dim fullMessageScript As String = ""
        Dim space As Char = " "
        Dim middleInitialGetter As Char = ""
        Dim suffixGetter As String = ""
        Dim contactNumberGetter As String = ""
        Dim yearLevelGetter As String = ""
        Try
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM tbl_Students WHERE RFId= @RFId", con)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@RFId", txtGetRFId.Text)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                SerialPort1.Open()
                SerialPort1.Write("AT" & vbCrLf)
                SerialPort1.Write("AT+CMGF=1" & vbCrLf)
                txtStudentId.Enabled = True
                txtFullName.Enabled = True
                txtYearLevel.Enabled = True
                txtDate.Enabled = True
                txtTime.Enabled = True
                txtStatus.Enabled = True
                txtStudentId.Text = dr.Item("Id")
                studentIdGetter = dr.Item("Id")
                Dim middleNameGetter = ""
                middleNameGetter = dr.Item("Middle_Name")
                middleInitialGetter = Trim(Mid(middleNameGetter, 1, 1))
                suffixGetter = dr.Item("Suffix")
                If suffixGetter = "" Then
                    txtFullName.Text = dr.Item("Last_Name") + "," + space + dr.Item("Given_Name") + space + middleInitialGetter + "."
                Else
                    txtFullName.Text = dr.Item("Last_Name") + "," + space + dr.Item("Given_Name") + space + middleInitialGetter + "." + space + dr.Item("Suffix") + "."
                End If
                yearLevelGetter = dr.Item("Grade_Level_Id")
                If yearLevelGetter = "1" Then
                    txtYearLevel.Text = "Grade 7"
                ElseIf yearLevelGetter = "2" Then
                    txtYearLevel.Text = "Grade 8"
                ElseIf yearLevelGetter = "3" Then
                    txtYearLevel.Text = "Grade 9"
                ElseIf yearLevelGetter = "4" Then
                    txtYearLevel.Text = "Grade 10"
                End If
                contactNumberGetter = dr.Item("Contact_Number")
                Dim arrImage As Byte() = DirectCast(dr("Photo"), Byte())
                Dim ms As New MemoryStream(arrImage)
                ptbProfile.Image = Image.FromStream(ms)
                con.Dispose()
                con.Close()
                Dim x As String = ""
                con.Open()
                cmd = New MySqlCommand("SELECT * FROM tbl_student_logs WHERE Student_Id = @Student_Id AND Date = @Date AND Time_Out = @Time_Out", con)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@Student_Id", txtStudentId.Text)
                cmd.Parameters.AddWithValue("@Date", convertedFormatDate)
                cmd.Parameters.AddWithValue("@Time_Out", strNull)
                dr = cmd.ExecuteReader()
                If dr.Read = True Then
                    studentLogsIdGetter = dr.Item("Id")
                    txtDate.Text = lblDateToday.Text
                    txtTime.Text = lblTimeNow.Text
                    txtStatus.Text = "OUT"
                    fullMessageScript = greetScript + space + txtFullName.Text + outScript + space + txtTime.Text + "," + space + txtDate.Text + space + "/" + space + lblDayNow.Text + space + fromScript
                    SerialPort1.Write("AT+CMGS=" & Chr(34) & contactNumberGetter & Chr(34) & vbCrLf)
                    SerialPort1.Write(fullMessageScript & Chr(26))
                    SerialPort1.Close()
                    con.Dispose()
                    con.Close()
                    MethodOut()
                ElseIf dr.Read = False Then
                    txtDate.Text = lblDateToday.Text
                    txtTime.Text = lblTimeNow.Text
                    txtStatus.Text = "IN"
                    fullMessageScript = greetScript + space + txtFullName.Text + inScript + space + txtTime.Text + "," + space + txtDate.Text + space + "/" + space + lblDayNow.Text + space + fromScript
                    SerialPort1.Write("AT+CMGS=" & Chr(34) & contactNumberGetter & Chr(34) & vbCrLf)
                    SerialPort1.Write(fullMessageScript & Chr(26))
                    SerialPort1.Close()
                    con.Dispose()
                    con.Close()
                    MethodIn()
                End If
                txtGetRFId.Clear()
                txtGetRFId.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + "AT THE LINE OF" + ex.StackTrace)
        Finally
            con.Dispose()
            con.Close()
        End Try
    End Sub
    Private Sub MethodIn()
        Try
            con.Open()
            cmd = New MySqlCommand("sp_InsertStudentIn", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New MySqlParameter("@param_StudentId", txtStudentId.Text))
            cmd.Parameters.Add(New MySqlParameter("@param_Date", convertedFormatDate))
            cmd.Parameters.Add(New MySqlParameter("@param_Time_In", txtTime.Text))
            cmd.Parameters.Add(New MySqlParameter("@param_Time_Out", strNull))
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message + "AT THE LINE OF" + ex.StackTrace)
        Finally
            con.Dispose()
            con.Close()
        End Try
    End Sub
    Private Sub MethodOut()
        Try
            con.Open()
            cmd = New MySqlCommand("sp_InsertStudentOut", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New MySqlParameter("@param_Time_Out", txtTime.Text))
            cmd.Parameters.Add(New MySqlParameter("@param_StudentId", studentIdGetter))
            cmd.Parameters.Add(New MySqlParameter("@param_Date", convertedFormatDate))
            cmd.Parameters.Add(New MySqlParameter("@param_Id", studentLogsIdGetter))
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message + "AT THE LINE OF" + ex.StackTrace)
        Finally
            con.Dispose()
            con.Close()
        End Try
    End Sub
    Private Sub txtGetRFId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGetRFId.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class