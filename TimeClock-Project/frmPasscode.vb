Public Class frmPasscode

    Dim passcode As String

    Private Sub txtFirstNum_TextChanged(sender As Object, e As EventArgs) Handles txtFirstNum.TextChanged
        If txtFirstNum.Text = "" Then
            pnl1Indic.BackColor = Color.FromArgb(26, 26, 26)
        Else
            pnl1Indic.BackColor = Color.FromArgb(156, 231, 230)
        End If
    End Sub

    Private Sub txtSecondNum_TextChanged(sender As Object, e As EventArgs) Handles txtSecondNum.TextChanged
        If txtSecondNum.Text = "" Then
            pnl2Indic.BackColor = Color.FromArgb(26, 26, 26)
        Else
            pnl2Indic.BackColor = Color.FromArgb(156, 231, 230)
        End If
    End Sub

    Private Sub txtThirdNum_TextChanged(sender As Object, e As EventArgs) Handles txtThirdNum.TextChanged
        If txtThirdNum.Text = "" Then
            pnl3Indic.BackColor = Color.FromArgb(26, 26, 26)
        Else
            pnl3Indic.BackColor = Color.FromArgb(156, 231, 230)
        End If
    End Sub

    Private Sub txtFourthNum_TextChanged(sender As Object, e As EventArgs) Handles txtFourthNum.TextChanged
        tmrPasscode.Start()
        If txtFourthNum.Text = "" Then
            pnl4Indic.BackColor = Color.FromArgb(26, 26, 26)
        Else
            pnl4Indic.BackColor = Color.FromArgb(156, 231, 230)
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtFirstNum.Text = "" Then
            txtFirstNum.Text = "1"
        ElseIf txtSecondNum.Text = "" Then
            txtSecondNum.Text = "1"
        ElseIf txtThirdNum.Text = "" Then
            txtThirdNum.Text = "1"
        ElseIf txtFourthNum.Text = "" Then
            txtFourthNum.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtFirstNum.Text = "" Then
            txtFirstNum.Text = "2"
        ElseIf txtSecondNum.Text = "" Then
            txtSecondNum.Text = "2"
        ElseIf txtThirdNum.Text = "" Then
            txtThirdNum.Text = "2"
        ElseIf txtFourthNum.Text = "" Then
            txtFourthNum.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtFirstNum.Text = "" Then
            txtFirstNum.Text = "3"
        ElseIf txtSecondNum.Text = "" Then
            txtSecondNum.Text = "3"
        ElseIf txtThirdNum.Text = "" Then
            txtThirdNum.Text = "3"
        ElseIf txtFourthNum.Text = "" Then
            txtFourthNum.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtFirstNum.Text = "" Then
            txtFirstNum.Text = "4"
        ElseIf txtSecondNum.Text = "" Then
            txtSecondNum.Text = "4"
        ElseIf txtThirdNum.Text = "" Then
            txtThirdNum.Text = "4"
        ElseIf txtFourthNum.Text = "" Then
            txtFourthNum.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtFirstNum.Text = "" Then
            txtFirstNum.Text = "5"
        ElseIf txtSecondNum.Text = "" Then
            txtSecondNum.Text = "5"
        ElseIf txtThirdNum.Text = "" Then
            txtThirdNum.Text = "5"
        ElseIf txtFourthNum.Text = "" Then
            txtFourthNum.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtFirstNum.Text = "" Then
            txtFirstNum.Text = "6"
        ElseIf txtSecondNum.Text = "" Then
            txtSecondNum.Text = "6"
        ElseIf txtThirdNum.Text = "" Then
            txtThirdNum.Text = "6"
        ElseIf txtFourthNum.Text = "" Then
            txtFourthNum.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtFirstNum.Text = "" Then
            txtFirstNum.Text = "7"
        ElseIf txtSecondNum.Text = "" Then
            txtSecondNum.Text = "7"
        ElseIf txtThirdNum.Text = "" Then
            txtThirdNum.Text = "7"
        ElseIf txtFourthNum.Text = "" Then
            txtFourthNum.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtFirstNum.Text = "" Then
            txtFirstNum.Text = "8"
        ElseIf txtSecondNum.Text = "" Then
            txtSecondNum.Text = "8"
        ElseIf txtThirdNum.Text = "" Then
            txtThirdNum.Text = "8"
        ElseIf txtFourthNum.Text = "" Then
            txtFourthNum.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtFirstNum.Text = "" Then
            txtFirstNum.Text = "9"
        ElseIf txtSecondNum.Text = "" Then
            txtSecondNum.Text = "9"
        ElseIf txtThirdNum.Text = "" Then
            txtThirdNum.Text = "9"
        ElseIf txtFourthNum.Text = "" Then
            txtFourthNum.Text = "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtFirstNum.Text = "" Then
            txtFirstNum.Text = "0"
        ElseIf txtSecondNum.Text = "" Then
            txtSecondNum.Text = "0"
        ElseIf txtThirdNum.Text = "" Then
            txtThirdNum.Text = "0"
        ElseIf txtFourthNum.Text = "" Then
            txtFourthNum.Text = "0"
        End If
    End Sub

    Private Sub btnClearPasscode_Click(sender As Object, e As EventArgs) Handles btnClearPasscode.Click
        txtFirstNum.Text = ""
        txtSecondNum.Text = ""
        txtThirdNum.Text = ""
        txtFourthNum.Text = ""
    End Sub

    Private Sub btnDeletePasscode_Click(sender As Object, e As EventArgs) Handles btnDeletePasscode.Click
        If Not txtFourthNum.Text = "" Then
            txtFourthNum.Text = ""
        ElseIf Not txtThirdNum.Text = "" Then
            txtThirdNum.Text = ""
        ElseIf Not txtSecondNum.Text = "" Then
            txtSecondNum.Text = ""
        ElseIf Not txtFirstNum.Text = "" Then
            txtFirstNum.Text = ""
        End If
    End Sub

    Private Sub tmrPasscode_Tick(sender As Object, e As EventArgs) Handles tmrPasscode.Tick
        ' begin passcode validation
        passcode = txtFirstNum.Text & txtSecondNum.Text & txtThirdNum.Text & txtFourthNum.Text
        If passcode = "1234" Then
            txtFirstNum.Text = ""
            txtSecondNum.Text = ""
            txtThirdNum.Text = ""
            txtFourthNum.Text = ""
            Me.Hide()
            frmTimeInOut.Show()
        Else
            tmrMessage.Start()
            txtFirstNum.Text = ""
            txtSecondNum.Text = ""
            txtThirdNum.Text = ""
            txtFourthNum.Text = ""
            lblPasscodeNotFound.Visible = True
        End If
        tmrPasscode.Stop()
    End Sub

    Private Sub tmrMessage_Tick(sender As Object, e As EventArgs) Handles tmrMessage.Tick
        lblPasscodeNotFound.Visible = False
        tmrMessage.Stop()
    End Sub

    Private Sub lblPasscodeNotFound_Click(sender As Object, e As EventArgs) Handles lblPasscodeNotFound.Click
        lblPasscodeNotFound.Visible = False
        tmrMessage.Stop()
    End Sub

    Private Sub btnLoginAdmin_Click(sender As Object, e As EventArgs) Handles btnLoginAdmin.Click
        Me.Hide()
        frmLoginAdmin.Show()
    End Sub

    Private Sub btnLoginAdmin_MouseHover(sender As Object, e As EventArgs) Handles btnLoginAdmin.MouseHover
        btnLoginAdmin.ForeColor = Color.Black
        btnLoginAdmin.BackColor = Color.White
        btnLoginAdmin.FlatAppearance.BorderColor = Color.White
    End Sub

    Private Sub btnLoginAdmin_MouseLeave(sender As Object, e As EventArgs) Handles btnLoginAdmin.MouseLeave
        btnLoginAdmin.ForeColor = Color.White
        btnLoginAdmin.BackColor = Color.Transparent
    End Sub

    Private Sub btnCloseApp_Click(sender As Object, e As EventArgs) Handles btnCloseApp.Click
        Me.Close()
    End Sub

End Class
