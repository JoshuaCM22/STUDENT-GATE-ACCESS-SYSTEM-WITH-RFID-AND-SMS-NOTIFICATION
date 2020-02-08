Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class Form_Camera ' Created by: Joshua C. Magoliman
    Public videoCaptureDevice As VideoCaptureDevice
    Dim bitmap As Bitmap
    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        ptbOne.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
    Private Sub Form_Camera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Public Sub Reset()
        ptbTwo.Image = My.Resources.USERICON()
        btnCaptured.Hide()
        btnSaveImage.Hide()
        btnStart.Focus()
    End Sub
    Private Sub Form_Camera_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        videoCaptureDevice.Stop()
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim Question As String
        Question = MsgBox("Are you sure you want to exit ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question = vbYes Then
            Me.Close()
            videoCaptureDevice.Stop()
            End
        End If
    End Sub
    Private Sub btnAddNewStudent_Click(sender As Object, e As EventArgs) Handles btnAddNewStudent.Click
        Me.Hide()
        Form_AddNewStudent.Enabled = True
        Form_AddNewStudent.BringToFront()
        Form_AddNewStudent.lblNameOfSchool.Focus()
        Form_AddNewStudent.photoValidation()
    End Sub
    Private Sub btnStudentProfile_Click(sender As Object, e As EventArgs) Handles btnStudentProfile.Click
        Me.Hide()
        Form_Profile.Enabled = True
        Form_Profile.BringToFront()
        Form_Profile.lblNameOfSchool.Focus()
        Form_Profile.photoValidation()
    End Sub
    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click
        SaveFileDialog.DefaultExt = ".jpg"
        If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            ptbTwo.Image.Save(SaveFileDialog.FileName, Imaging.ImageFormat.Jpeg)
            Form_AddNewStudent.photoGetter = Image.FromFile(SaveFileDialog.FileName)
            Form_Profile.photoGetter = Image.FromFile(SaveFileDialog.FileName)
            ptbTwo.Image = My.Resources.USERICON()
            ptbTwo.BackColor = Color.DimGray
        End If
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim Cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If Cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            videoCaptureDevice = Cameras.VideoDevice
            AddHandler videoCaptureDevice.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            videoCaptureDevice.Start()
            btnStart.Hide()
            btnCaptured.Show()
            btnSaveImage.Show()
        End If
    End Sub
    Private Sub btnCaptured_Click(sender As Object, e As EventArgs) Handles btnCaptured.Click
        ptbTwo.Image = ptbOne.Image
        ptbTwo.BackColor = Color.Black
    End Sub
End Class