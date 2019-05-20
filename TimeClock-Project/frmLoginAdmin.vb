Public Class frmLoginAdmin

    ' IMPORTANT
    Private Access As New DatabaseControl

    Private Sub btnCloseApp_Click(sender As Object, e As EventArgs) Handles btnCloseApp.Click
        End
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
            Access.AddParam("@username", username)
            Access.AddParam("@password", password)
            Access.ExecuteQuery("SELECT * FROM tblAccount WHERE [userlevel]='Administrator' AND [username]=@username AND [password]=@password")
            If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
            For Each R As DataRow In Access.DbDataTable.Rows
                If username = R("username") And password = R("password") And R("userlevel") = "Administrator" Then
                    Me.Hide()
                    Dim frmAdmin As New frmAdministrator(R("name").ToString, R("userlevel"))
                    frmAdmin.Show()
                End If
            Next

            ShowMessage("Incorrect credential. Try again.")
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

    Private Sub frmLoginAdmin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
End Class