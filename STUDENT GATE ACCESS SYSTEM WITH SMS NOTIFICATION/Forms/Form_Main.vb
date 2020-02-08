Public Class Form_Main ' Created by: Joshua C. Magoliman
    Dim num As Integer = 1
    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
        Timer1.Start()
    End Sub
    Public Sub Reset()
        lblNameOfTheSchool.Focus()
    End Sub
    Private Sub StudentRecords_Click(sender As Object, e As EventArgs) Handles StudentRecords.Click
        Form_StudentRecords.Show()
        Form_StudentRecords.GetData()
        Me.Hide()
    End Sub
    Private Sub StudentLogs_Click(sender As Object, e As EventArgs) Handles StudentLogs.Click
        Form_StudentLogs.Show()
        Form_StudentLogs.GetData()
        Me.Hide()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim question As String
        question = MsgBox("Are you sure you want to exit ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If question = vbYes Then
            Me.Close()
            End
        End If
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnCreateAnotherAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAnotherAccount.Click
        Form_CreateAnotherAccount.Show()
        Form_CreateAnotherAccount.Reset()
        Me.Enabled = False
    End Sub
    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Form_ChangePassword.Show()
        Form_ChangePassword.Reset()
        Me.Enabled = False
    End Sub
    Private Sub LogOutbutton_Click(sender As Object, e As EventArgs) Handles LogOutbutton.Click
        Dim question As String
        question = MsgBox("Are you sure you want to logout ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ATTENTION")
        If question = vbYes Then
            Me.Hide()
            Form_Login.Show()
            Form_Login.Reset()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case num
            Case 1
                ptbMain.BackgroundImage = My.Resources.PIC1
                num = 2
            Case 2
                ptbMain.BackgroundImage = My.Resources.PIC2
                num = 3
            Case 3
                ptbMain.BackgroundImage = My.Resources.PIC3
                num = 4
            Case 4
                ptbMain.BackgroundImage = My.Resources.PIC4
                num = 5
            Case 5
                ptbMain.BackgroundImage = My.Resources.PIC5
                num = 6
            Case 6
                ptbMain.BackgroundImage = My.Resources.PIC6
                num = 7
            Case 7
                ptbMain.BackgroundImage = My.Resources.PIC7
                num = 8
            Case 8
                ptbMain.BackgroundImage = My.Resources.PIC8
                num = 9
            Case 9
                ptbMain.BackgroundImage = My.Resources.PIC9
                num = 10
            Case 10
                ptbMain.BackgroundImage = My.Resources.PIC10
                num = 11
            Case 11
                ptbMain.BackgroundImage = My.Resources.PIC11
                num = 12
            Case 12
                ptbMain.BackgroundImage = My.Resources.PIC12
                num = 13
            Case 13
                ptbMain.BackgroundImage = My.Resources.PIC13
                num = 14
            Case 14
                ptbMain.BackgroundImage = My.Resources.PIC14
                num = 15
            Case 15
                ptbMain.BackgroundImage = My.Resources.PIC15
                num = 16
                If num = 16 Then
                    num = 1
                End If
        End Select
    End Sub
End Class