Public Class frmAdministrator

    ' IMPORTANT
    Private Access As New DatabaseControl
    Dim selectedindex As Integer

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
        selectedindex = -1
        ClearEmployeeTextboxes()
        pnlDashboard.SendToBack()
        pnlStaffAttendance.SendToBack()
        pnlManageEmployee.BringToFront()
        pnlSchedules.SendToBack()
        btnEdit.Enabled = False
        btnDelete.Enabled = False
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
        btnCommitAdd.Visible = False
        btnCommitUpdate.Visible = False
        btnCancel.Visible = False
        btnAdd.Enabled = True
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        Try
            Dim gender As String
            selectedindex = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = dgvEmployees.Rows(selectedindex)
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

        btnCommitAdd.Visible = True
        btnCancel.Visible = True

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPosition.Text = ""
        txtAddress.Text = ""
        txtContactNumber.Text = ""
        txtPasscode.Text = ""

        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvEmployees.ClearSelection()
        ClearEmployeeTextboxes()
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        selectedindex = -1
    End Sub

    Private Sub frmAdministrator_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefreshEmployeeTable()
        pnlDashboard.BringToFront()
    End Sub

    Private Sub RefreshEmployeeTable()
        ' Run Query
        Access.ExecuteQuery("SELECT * FROM tblEmployee ORDER BY ID ASC")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        ' Fill DataGridView
        dgvEmployees.DataSource = Access.DbDataTable

        Try
            dgvEmployees.Columns(2).HeaderText = "First Name"
            dgvEmployees.Columns(3).HeaderText = "Last Name"
            dgvEmployees.Columns(7).HeaderText = "Contact Number"
            dgvEmployees.Columns("FirstName").Width = 130
            dgvEmployees.Columns("LastName").Width = 130
            dgvEmployees.Columns("Address").Width = 180
            dgvEmployees.Columns("Position").Width = 130
            dgvEmployees.Columns("ID").Visible = False
            dgvEmployees.Columns("Passcode").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

        btnCommitAdd.Visible = False
        btnCommitUpdate.Visible = False
        btnCancel.Visible = False

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPosition.Text = ""
        txtAddress.Text = ""
        txtContactNumber.Text = ""
        txtPasscode.Text = ""

        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnCommitAdd.Click
        Dim gender As String = ""

        If rbMale.Checked = True Then
            gender &= "Male"
        ElseIf rbFemale.Checked = True Then
            gender &= "Female"
        Else
            gender = ""
            DisplayToastMessage("Please complete the form to continue.", 2)
            Exit Sub
        End If

        If txtPasscode.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or txtPosition.Text = "" Or txtAddress.Text = "" Or gender = "" Or txtContactNumber.Text = "" Then
            DisplayToastMessage("Please complete the form to continue.", 2)
            Exit Sub
        End If

        If Not txtPasscode.Text.Length = 4 Then
            DisplayToastMessage("Invalid passcode. Try again.", 2)
            txtPasscode.Text = ""
            Exit Sub
        End If

        If CheckForAlphaCharacters(txtPasscode.Text) Then
            'do stuff here if it contains letters
            DisplayToastMessage("Invalid passcode. Try again.", 2)
            txtPasscode.Text = ""
            Exit Sub
        End If

        If CheckForDoubleEntryPasscode(txtPasscode.Text) Then
            DisplayToastMessage("Passcode is already taken. Try again.", 2)
            txtPasscode.Text = ""
            Exit Sub
        End If

        AddEmployee(txtPasscode.Text, (txtFirstName.Text).Substring(0, 1).ToUpper & (txtFirstName.Text).Substring(1).ToLower, (txtLastName.Text).Substring(0, 1).ToUpper & (txtLastName.Text).Substring(1).ToLower, txtPosition.Text, txtAddress.Text, gender, txtContactNumber.Text, "Out")
    End Sub

    Private Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Function CheckForDoubleEntryPasscode(Passcode As String)
        Access.ExecuteQuery("SELECT Passcode FROM tblEmployee")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Return False

        For Each R As DataRow In Access.DbDataTable.Rows
            If Passcode = R("Passcode") Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub AddEmployee(Passcode As String, FirstName As String,
                            LastName As String, Position As String,
                            Address As String, Gender As String,
                            ContactNumber As String, Status As String)
        Access.AddParam("@passcode", Passcode)
        Access.AddParam("@firstname", FirstName)
        Access.AddParam("@lastname", LastName)
        Access.AddParam("@position", Position)
        Access.AddParam("@address", Address)
        Access.AddParam("@gender", Gender)
        Access.AddParam("@contact", ContactNumber)
        Access.AddParam("@status", Status)

        Access.ExecuteQuery("INSERT INTO tblEmployee ([Passcode],[FirstName],[LastName],[Position],[Address],[Gender],[ContactNumber],[Status]) " &
                            "VALUES (@passcode,@firstname,@lastname,@position,@address,@gender,@contact,@status)")

        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

        DisplayToastMessage("Employee has been added successfully.", 1)
        RefreshEmployeeTable()
        ClearEmployeeTextboxes()
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub DisplayToastMessage(message As String, type As Integer)
        tmrMessage.Start()

        If type = 1 Then
            ' success message
            lblToastMessage.Text = message
            lblToastMessage.BackColor = Color.FromArgb(38, 109, 204)
            lblToastMessage.Visible = True
        ElseIf type = 2 Then
            ' error message
            lblToastMessage.Text = message
            lblToastMessage.BackColor = Color.Maroon
            lblToastMessage.Visible = True
        End If
    End Sub

    Private Sub tmrMessage_Tick(sender As Object, e As EventArgs) Handles tmrMessage.Tick
        lblToastMessage.Text = ""
        lblToastMessage.Visible = False
        tmrMessage.Stop()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedRow As DataGridViewRow
        Try
            selectedRow = dgvEmployees.Rows(selectedindex)
        Catch ex As Exception
            DisplayToastMessage("Please select the employee you want to delete.", 2)
            Exit Sub
        End Try

        Dim id As String = selectedRow.Cells(0).Value.ToString

        Dim confirm As Integer = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Access.AddParam("@id", id)
            Access.ExecuteQuery("DELETE * FROM tblEmployee WHERE [ID] = @id")
            If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
            DisplayToastMessage("Employee deleted successfully.", 1)

            RefreshEmployeeTable()
            ClearEmployeeTextboxes()
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnCommitUpdate.Visible = True
        btnCancel.Visible = True
        btnAdd.Enabled = False
        btnDelete.Enabled = False

        txtFirstName.ReadOnly = False
        txtLastName.ReadOnly = False
        txtPosition.ReadOnly = False
        txtAddress.ReadOnly = False
        rbMale.AutoCheck = True
        rbFemale.AutoCheck = True
        txtContactNumber.ReadOnly = False
        txtPasscode.ReadOnly = True
    End Sub

    Private Sub btnCommitUpdate_Click(sender As Object, e As EventArgs) Handles btnCommitUpdate.Click

        Dim gender As String = ""

        If rbMale.Checked = True Then
            gender &= "Male"
        ElseIf rbFemale.Checked = True Then
            gender &= "Female"
        Else
            gender = ""
            DisplayToastMessage("Please complete the form to continue.", 2)
            Exit Sub
        End If

        If txtPasscode.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or txtPosition.Text = "" Or txtAddress.Text = "" Or gender = "" Or txtContactNumber.Text = "" Then
            DisplayToastMessage("Please complete the form to continue.", 2)
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow
        Try
            selectedRow = dgvEmployees.Rows(selectedindex)
        Catch ex As Exception
            DisplayToastMessage("Please select the employee you want to update.", 2)
            Exit Sub
        End Try

        Dim id As String = selectedRow.Cells(0).Value.ToString
        Dim confirm As Integer = MessageBox.Show("Are you sure you want to update?", "Confirm", MessageBoxButtons.YesNo)

        If confirm = DialogResult.Yes Then
            UpdateEmployee(txtPasscode.Text, (txtFirstName.Text).Substring(0, 1).ToUpper & (txtFirstName.Text).Substring(1).ToLower, (txtLastName.Text).Substring(0, 1).ToUpper & (txtLastName.Text).Substring(1).ToLower, txtPosition.Text, txtAddress.Text, gender, txtContactNumber.Text)
        End If


    End Sub

    Private Sub UpdateEmployee(Passcode As String, FirstName As String,
                            LastName As String, Position As String,
                            Address As String, Gender As String,
                            ContactNumber As String)
        Access.AddParam("@passcode", Passcode)
        Access.AddParam("@firstname", FirstName)
        Access.AddParam("@lastname", LastName)
        Access.AddParam("@position", Position)
        Access.AddParam("@address", Address)
        Access.AddParam("@gender", Gender)
        Access.AddParam("@contact", ContactNumber)

        Access.ExecuteQuery("UPDATE tblEmployee SET [Passcode]=@passcode,[FirstName]=@firstname,[LastName]=@lastname," &
            "[Position]=@position,[Address]=@address,[Gender]=@gender,[ContactNumber]=@contact" &
            " WHERE [Passcode] = @passcode")

        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

        DisplayToastMessage("Employee has been updated successfully.", 1)
        RefreshEmployeeTable()
        ClearEmployeeTextboxes()
        dgvEmployees.ClearSelection()
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnLoadAttendance_Click(sender As Object, e As EventArgs) Handles btnLoadAttendance.Click

    End Sub
End Class