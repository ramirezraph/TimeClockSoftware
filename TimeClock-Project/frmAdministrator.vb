Public Class frmAdministrator

    ' drop down menu item functionalities
    Dim btnNavButtonIsActive = False
    Private Sub OpenMenuItem1()
        pnlDropDownBtn1.BringToFront()
        pnlDropDownBtn1.Visible = True
        btnNavButtonIsActive = True
    End Sub
    Private Sub HideMenuItem1()
        pnlDropDownBtn1.Visible = False
        btnNavButtonIsActive = False
    End Sub
    ' end

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Close()
    End Sub

    Private Sub btnDropdownIcon_Click(sender As Object, e As EventArgs) Handles btnDropdownIcon.Click
        If btnNavButtonIsActive = False Then
            OpenMenuItem1()
        Else
            HideMenuItem1()
        End If
    End Sub

    Private Sub menuItemHideMenu1_Click(sender As Object, e As EventArgs) Handles menuItemHideMenu1.Click
        HideMenuItem1()
    End Sub

    Private Sub menuItemLogout_Click(sender As Object, e As EventArgs) Handles menuItemLogout.Click
        HideMenuItem1()
        Me.Hide()
        frmPasscode.Show()
    End Sub

    Private Sub menuItemAppSettings_Click(sender As Object, e As EventArgs) Handles menuItemAppSettings.Click

    End Sub

    Private Sub menuItmAccount_Click(sender As Object, e As EventArgs) Handles menuItmAccount.Click

    End Sub

    Private Sub frmAdministrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TimeClockProjectDataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.TblEmployeeTableAdapter.Fill(Me.TimeClockProjectDataSet.tblEmployee)
        pnlDashboard.BringToFront()
    End Sub

    Private Sub btnMenuDashboard_Click(sender As Object, e As EventArgs) Handles btnMenuDashboard.Click
        pnlDashboard.BringToFront()
        pnlStaffAttendance.SendToBack()
        pnlManageEmployee.SendToBack()
        pnlSchedules.SendToBack()

    End Sub

    Private Sub btnMenuAttendance_Click(sender As Object, e As EventArgs) Handles btnMenuAttendance.Click
        pnlDashboard.SendToBack()
        pnlStaffAttendance.BringToFront()
        pnlManageEmployee.SendToBack()
        pnlSchedules.SendToBack()
    End Sub

    Private Sub btnManageEmployee_Click(sender As Object, e As EventArgs) Handles btnManageEmployee.Click
        pnlDashboard.SendToBack()
        pnlStaffAttendance.SendToBack()
        pnlManageEmployee.BringToFront()
        pnlSchedules.SendToBack()
    End Sub

    Private Sub btnScheduling_Click(sender As Object, e As EventArgs) Handles btnScheduling.Click
        pnlDashboard.SendToBack()
        pnlStaffAttendance.SendToBack()
        pnlManageEmployee.SendToBack()
        pnlSchedules.BringToFront()
    End Sub
End Class