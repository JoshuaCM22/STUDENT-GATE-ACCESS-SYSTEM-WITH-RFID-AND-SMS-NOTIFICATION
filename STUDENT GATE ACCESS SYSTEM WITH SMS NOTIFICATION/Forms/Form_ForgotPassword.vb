Imports MySql.Data.MySqlClient
Public Class Form_ForgotPassword ' Created by: Joshua C. Magoliman
    Dim usernameGetter As String
    Private Sub Form_ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Public Sub Reset()
        usernameGetter = ""
        txtUsername.Focus()
        txtSecretAnswer.PasswordChar = "*"
        txtUsername.Clear()
        cmbboxSecretQuestion.Text = ""
        txtSecretAnswer.Clear()
    End Sub
    Private Sub Form_ForgotPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSubmit.PerformClick()
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Reset()
        Form_Login.Show()
        Me.Hide()
    End Sub
    Private Sub btnShowPassword_MouseHover(sender As Object, e As EventArgs) Handles btnSubmit.MouseHover
        btnSubmit.BackColor = Color.SaddleBrown
        btnSubmit.ForeColor = Color.White
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtUsername.Text = "" And cmbboxSecretQuestion.Text = "" And txtSecretAnswer.Text = "" Then
            MsgBox("Fill up account details", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtUsername.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "Error")
            txtUsername.Focus()
        ElseIf cmbboxSecretQuestion.Text = "" Then
            MsgBox("No Secret Question Found!", MsgBoxStyle.Critical, "Error")
            cmbboxSecretQuestion.Focus()
        ElseIf txtSecretAnswer.Text = "" Then
            MsgBox("No Secret Answer Found!", MsgBoxStyle.Critical, "Error")
            txtSecretAnswer.Focus()
        Else
            Try
                con.Open()
                cmd = New MySqlCommand("SELECT * FROM tbl_Users WHERE Username=@Username AND BINARY Secret_Question = @SecretQuestion", con)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Add(New MySqlParameter("@Username", txtUsername.Text))
                cmd.Parameters.Add(New MySqlParameter("@SecretQuestion", cmbboxSecretQuestion.Text))
                dr = cmd.ExecuteReader()
                If dr.Read = True Then
                    If (BCrypt.Net.BCrypt.Verify(txtSecretAnswer.Text, dr.Item("Secret_Answer"))) Then
                        Form_SetANewPassword.userIDGetter = dr.Item("ID")
                        con.Close()
                        dr.Close()
                        Reset()
                        Me.Hide()
                        Form_SetANewPassword.Show()
                    Else
                        MsgBox("Your details is incorrect!", MsgBoxStyle.Critical, "ATTENTION")
                        txtSecretAnswer.Clear()
                        txtSecretAnswer.Focus()
                        dr.Close()
                        con.Close()
                    End If
                ElseIf dr.Read = False Then
                    MsgBox("Your details is incorrect!", MsgBoxStyle.Critical, "Error")
                    con.Close()
                    dr.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
            End Try
        End If
    End Sub
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        Try
            If usernameGetter = "" Then
                con.Close()
                con.Open()
                cmd = New MySqlCommand("SELECT * FROM tbl_Users WHERE Username=@Username", con)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Add(New MySqlParameter("@Username", txtUsername.Text))
                dr = cmd.ExecuteReader()
                If dr.Read = True Then
                    cmbboxSecretQuestion.Text = dr.Item("Secret_Question")
                    usernameGetter = txtUsername.Text
                End If
            ElseIf usernameGetter = txtUsername.Text Then
                con.Open()
                cmd = New MySqlCommand("SELECT * FROM tbl_Users WHERE Username=@Username", con)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Add(New MySqlParameter("@Username", txtUsername.Text))
                dr = cmd.ExecuteReader
                While dr.Read()
                    cmbboxSecretQuestion.Text = dr.Item("Secret_Question")
                    usernameGetter = txtUsername.Text
                End While
            ElseIf usernameGetter <> txtUsername.Text Then
                cmbboxSecretQuestion.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            con.Close()
        End Try
    End Sub
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtSecretAnswer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSecretAnswer.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtShowPassword_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub chckboxSecretAnswer_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxSecretAnswer.CheckedChanged
        If chckboxSecretAnswer.Checked = False Then
            txtSecretAnswer.PasswordChar = "*"
        Else
            txtSecretAnswer.PasswordChar = ""
        End If
        lblTitleOfTheSystem.Focus()
    End Sub
End Class