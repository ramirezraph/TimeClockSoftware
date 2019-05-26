Public Class frmDialogAccount

    Dim FULLNAME As String
    Dim PASSWORD As String
    Dim USERNAME As String
    Dim ID As Integer

    ' IMPORTANT
    Private Access As New DatabaseControl

    Public Sub New(name As String, thisid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        FULLNAME = name
        ID = thisid
    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmDialogAccount_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            Dim maskedPass As String = ""
            ' GET ACCOUNT INFFO
            Access.ExecuteQuery("SELECT * FROM tblAccount WHERE ID=1")
            If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

            For Each R As DataRow In Access.DbDataTable.Rows
                FULLNAME = R("name")
                PASSWORD = R("password")
                ID = R("ID")
                USERNAME = R("username")
            Next
            For Each i In PASSWORD
                maskedPass &= "•"
            Next
            txtName.Text = FULLNAME
            lblPassword.Text = maskedPass
            txtUsername.Text = USERNAME
        Catch ex As Exception
            MessageBox.Show("An error occured.")
        End Try

    End Sub

    Private Sub cbShowOldPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowOldPass.CheckedChanged
        If cbShowOldPass.Checked Then
            txtOldPass.PasswordChar = Nothing
        Else
            txtOldPass.PasswordChar = "•"
        End If
    End Sub

    Private Sub cbShowNewPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowNewPass.CheckedChanged
        If cbShowNewPass.Checked Then
            txtNewPass.PasswordChar = Nothing
        Else
            txtNewPass.PasswordChar = "•"
        End If
    End Sub

    Private Sub cbShowConfirmPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowConfirmPass.CheckedChanged
        If cbShowConfirmPass.Checked Then
            txtConfirmPass.PasswordChar = Nothing
        Else
            txtConfirmPass.PasswordChar = "•"
        End If
    End Sub

    Private Sub cbIsChangePass_CheckedChanged(sender As Object, e As EventArgs) Handles cbIsChangePass.CheckedChanged
        If cbIsChangePass.Checked Then
            txtOldPass.Enabled = True
            txtNewPass.Enabled = True
            txtConfirmPass.Enabled = True
            cbShowOldPass.Visible = True
            cbShowNewPass.Visible = True
            cbShowConfirmPass.Visible = True
        Else
            txtOldPass.Enabled = False
            txtNewPass.Enabled = False
            txtConfirmPass.Enabled = False
            cbShowOldPass.Visible = False
            cbShowNewPass.Visible = False
            cbShowConfirmPass.Visible = False
        End If
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Dim confirm As Integer = MessageBox.Show("Are you sure you want to update?", "Confirm", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            If cbIsChangePass.Checked Then

                If String.IsNullOrEmpty(txtOldPass.Text) Then
                    MessageBox.Show("Please complete the form.")
                    Exit Sub
                End If
                If String.IsNullOrEmpty(txtNewPass.Text) Then
                    MessageBox.Show("Please complete the form.")
                    Exit Sub
                End If
                If String.IsNullOrEmpty(txtConfirmPass.Text) Then
                    MessageBox.Show("Please complete the form.")
                    Exit Sub
                End If

                If Not (txtOldPass.Text).Equals(PASSWORD) Then
                        MessageBox.Show("Old password is incorrect.")
                        Exit Sub
                    End If
                    If Not (txtNewPass.Text).Equals(txtConfirmPass.Text) Then
                        MessageBox.Show("Your password does not match.")
                        Exit Sub
                    End If

                    Access.AddParam("@username", txtUsername.Text)
                    Access.AddParam("@name", txtName.Text)
                    Access.AddParam("@newpassword", txtNewPass.Text)
                    Access.ExecuteQuery("UPDATE tblAccount SET [username]=@username,[name]=@name,[password]=@newpassword WHERE ID=1")
                    If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
                    frmAdministrator.GetAccountInfo()
                    frmAdministrator.DisplayToastMessage("Account updated successfully.", 1)
                    Me.Close()
                Else
                    Access.AddParam("@username", txtUsername.Text)
                Access.AddParam("@name", txtName.Text)
                Access.ExecuteQuery("UPDATE tblAccount SET [username]=@username,[name]=@name WHERE ID=1")
                If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
                frmAdministrator.GetAccountInfo()
                frmAdministrator.DisplayToastMessage("Account updated successfully.", 1)
                Me.Close()
            End If
        End If
    End Sub
End Class