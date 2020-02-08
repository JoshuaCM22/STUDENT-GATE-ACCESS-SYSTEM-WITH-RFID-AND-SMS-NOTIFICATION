Imports System.Management
Imports System.Threading
Public Class Form_SettingConnection ' Created by: Joshua C. Magoliman
    Dim receiveData As String = ""
    Dim modemName As String = ""
    Public portName As String = ""
    Public Function ModemsConnected() As String
        Dim modems As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher( _
            "root\CIMV2", _
            "SELECT * FROM Win32_POTSModem")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Status") = "OK" Then
                    modems = modems & (queryObj("AttachedTo") & " - " & queryObj("Description") & "***")
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("an error occurred while querying for WMI data: " & ex.Message)
        End Try
        Return modems
    End Function
    Private Sub serialport1_datareceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim datain As String = ""
        Dim numbytes As Integer = SerialPort1.BytesToRead
        For i As Integer = 1 To numbytes
            datain &= Chr(SerialPort1.ReadChar)
        Next
        Test(datain)
    End Sub
    Private Sub Test(ByVal indata As String)
        receiveData &= indata
    End Sub
    Private Sub Form_Connecting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub Reset()
        Dim ports() As String
        ports = Split(ModemsConnected(), "***")
        For i As Integer = 0 To ports.Length - 2
            cmbStickModem.Items.Add(ports(i))
        Next
    End Sub
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If cmbStickModem.Text = "" Then
            MsgBox("NO BROADBAND STICK MODEM FOUND!", MsgBoxStyle.Critical, "ATTENTION")
        Else
            Dim strToFind As String = "Mobile"
            Dim strToCheck As String = modemName
            Dim FoundIt = InStr(1, strToCheck, strToFind)
            If FoundIt <> 0 Then
                Processing()
            Else
                MsgBox("PLEASE CHOOSE A VALID BROADBAND STICK MODEM!", MsgBoxStyle.Critical, "ATTENTION")
            End If
        End If
    End Sub
    Private Sub Processing()
        Try
            With SerialPort1
                .PortName = portName
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Handshake = IO.Ports.Handshake.None
                .RtsEnable = True
                .ReceivedBytesThreshold = 1
                .NewLine = vbCr
                .ReadTimeout = 1000
                .Open()
            End With
            If SerialPort1.IsOpen Then
                Me.SerialPort1.Close()
                Form_Attendance.Show()
                Form_Attendance.txtGetRFId.Focus()
                Me.Hide()
            Else
                MsgBox("Serial Port is not open!", MsgBoxStyle.Critical, "ATTENTION")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub cmbStickModem_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbStickModem.SelectedValueChanged
        modemName = Trim(Mid(cmbStickModem.Text, 1))
        portName = Trim(Mid(cmbStickModem.Text, 1, 5))
    End Sub
End Class