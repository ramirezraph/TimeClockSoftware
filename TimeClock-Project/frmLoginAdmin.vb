Public Class frmLoginAdmin
    Private Sub btnCloseApp_Click(sender As Object, e As EventArgs) Handles btnCloseApp.Click
        Me.Close()
    End Sub

    Private Sub btnBackToEmpLogin_Click(sender As Object, e As EventArgs) Handles btnBackToEmpLogin.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
        Me.Hide()
        frmPasscode.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        If username = "" Or password = "" Then
            ShowMessage("Please complete the form.")
        Else
            If username = "admin" And password = "123" Then
                Me.Hide()
                frmAdministrator.Show()
            Else
                ShowMessage("Incorrect username or password. Try again.")
                txtPassword.Text = ""
            End If
        End If
    End Sub
    Private Sub ShowMessage(msg As String)
        tmrMessage.Start()
        lblMessage.Visible = True
        lblMessage.Text = msg
    End Sub

    Private Sub tmrMessage_Tick(sender As Object, e As EventArgs) Handles tmrMessage.Tick
        lblMessage.Visible = False
        tmrMessage.Stop()
    End Sub
End Class