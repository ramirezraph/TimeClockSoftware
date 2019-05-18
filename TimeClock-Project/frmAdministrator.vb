Public Class frmAdministrator

    ' IMPORTANT
    Private Access As New DatabaseControl

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
        dgvEmployees.ClearSelection()
        ClearEmployeeTextboxes()
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

    Private Sub dgvEmployees_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.RowEnter
        txtFirstName.ReadOnly = True
        txtLastName.ReadOnly = True
        txtPosition.ReadOnly = True
        txtAddress.ReadOnly = True
        txtContactNumber.ReadOnly = True
        txtPasscode.ReadOnly = True
        rbMale.AutoCheck = False
        rbFemale.AutoCheck = False
        btnSave.Visible = False
        btnCancel.Visible = False
        Try
            Dim index As Integer
            Dim gender As String
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = dgvEmployees.Rows(index)
            ' first name
            txtFirstName.Text = selectedRow.Cells(2).Value.ToString
            ' last name
            txtLastName.Text = selectedRow.Cells(3).Value.ToString
            ' position
            txtPosition.Text = selectedRow.Cells(4).Value.ToString
            ' address
            txtAddress.Text = selectedRow.Cells(5).Value.ToString
            ' contact number
            txtContactNumber.Text = selectedRow.Cells(7).Value.ToString
            ' passcode
            txtPasscode.Text = selectedRow.Cells(1).Value.ToString
            ' gender
            gender = selectedRow.Cells(6).Value.ToString
            If gender = "Male" Then
                rbMale.Checked = True
                rbFemale.Checked = False
            ElseIf gender = "Female" Then
                rbMale.Checked = False
                rbFemale.Checked = True
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured.")
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        dgvEmployees.ClearSelection()
        txtFirstName.ReadOnly = False
        txtLastName.ReadOnly = False
        txtPosition.ReadOnly = False
        txtAddress.ReadOnly = False
        rbMale.AutoCheck = True
        rbFemale.AutoCheck = True
        rbMale.Checked = False
        rbFemale.Checked = False
        txtContactNumber.ReadOnly = False
        txtPasscode.ReadOnly = False

        btnSave.Visible = True
        btnCancel.Visible = True

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPosition.Text = ""
        txtAddress.Text = ""
        txtContactNumber.Text = ""
        txtPasscode.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvEmployees.ClearSelection()
    End Sub

    Private Sub frmAdministrator_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' Run Query
        Access.ExecuteQuery("SELECT * FROM tblEmployee ORDER BY ID ASC")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        ' Fill DataGridView
        dgvEmployees.DataSource = Access.DbDataTable

        Try
            dgvEmployees.Columns(2).HeaderText = "First Name"
            dgvEmployees.Columns(3).HeaderText = "Last Name"
            dgvEmployees.Columns(7).HeaderText = "Contact Number"
            dgvEmployees.Columns("ID").Visible = False
            dgvEmployees.Columns("Passcode").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        pnlDashboard.BringToFront()
    End Sub

    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        Dim t As TextBox = sender
        SearchEmployee(t.Text.ToLower)

    End Sub

    Private Sub SearchEmployee(Name As String)
        ' Add Param and Run Query
        Access.AddParam("@name", "%" & Name & "%")
        Access.ExecuteQuery("SELECT * FROM tblEmployee WHERE FirstName LIKE @name OR LastName LIKE @name ORDER BY ID ASC")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

        ' Fill DataGridView
        dgvEmployees.DataSource = Access.DbDataTable
    End Sub

    Private Sub ClearEmployeeTextboxes()
        txtFirstName.ReadOnly = True
        txtLastName.ReadOnly = True
        txtPosition.ReadOnly = True
        txtAddress.ReadOnly = True
        rbMale.AutoCheck = False
        rbFemale.AutoCheck = False
        rbMale.Checked = False
        rbFemale.Checked = False
        txtContactNumber.ReadOnly = True
        txtPasscode.ReadOnly = True

        btnSave.Visible = False
        btnCancel.Visible = False

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPosition.Text = ""
        txtAddress.Text = ""
        txtContactNumber.Text = ""
        txtPasscode.Text = ""
    End Sub
End Class