Imports MySql.Data.MySqlClient
Public Class Form_Login ' Created by: Joshua C. Magoliman
    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Public Sub Reset()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub
    Private Sub Form_Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Form_Attendance.Show()
            Reset()
            Me.Hide()
        ElseIf e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub ptbShowPassword_MouseHover(sender As Object, e As EventArgs) Handles ptbShowPassword.MouseHover
        txtPassword.PasswordChar = ""
    End Sub
    Private Sub ptbShowPassword_MouseLeave(sender As Object, e As EventArgs) Handles ptbShowPassword.MouseLeave
        txtPassword.PasswordChar = "*"
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim question As String
        question = MsgBox("Are you sure you want to exit the program ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If question = vbYes Then
            Me.Close()
            End
        End If
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("No Username and Password Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtUsername.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("No Password Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtPassword.Focus()
        Else
            lblPassword.Focus()
            LoginMethod()
        End If
    End Sub
    Private Sub LoginMethod()
        Try
            con.Open()
            cmd = New MySqlCommand("sp_Login", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("param_Username", txtUsername.Text)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                If (BCrypt.Net.BCrypt.Verify(txtPassword.Text, dr.Item("Password"))) Then
                    dr.Close()
                    con.Close()
                    Form_ChangePassword.usernameGetter = txtUsername.Text
                    Form_ChangePassword.passwordGetter = txtPassword.Text
                    Me.Hide()
                    Form_Main.Reset()
                    Form_Main.Show()
                Else
                    MsgBox("Incorrect Username And/Or Password!", MsgBoxStyle.Critical, "ATTENTION")
                    txtPassword.Clear()
                    txtPassword.Focus()
                End If
                dr.Close()
                con.Close()
            ElseIf dr.Read = False Then
                dr.Close()
                con.Close()
                MsgBox("Incorrect Username And/Or Password!", MsgBoxStyle.Critical, "ATTENTION")
                Reset()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnLogin_MouseHover(sender As Object, e As EventArgs) Handles btnLogin.MouseHover
        btnLogin.BackColor = Color.Chocolate
        btnLogin.ForeColor = Color.White
    End Sub
    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.SaddleBrown
        btnLogin.ForeColor = Color.White
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Reset()
        Me.Hide()
        Form_Attendance.Show()
        Form_Attendance.Reset()
    End Sub
    Private Sub btnBack_MouseHover(sender As Object, e As EventArgs) Handles btnBack.MouseHover
        btnBack.BackColor = Color.Chocolate
        btnBack.ForeColor = Color.White
    End Sub
    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.SaddleBrown
        btnBack.ForeColor = Color.White
    End Sub
    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Reset()
        Me.Hide()
        Form_ForgotPassword.Show()
        Form_ForgotPassword.Reset()
    End Sub
End Class
