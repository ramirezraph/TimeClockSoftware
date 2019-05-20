Public Class frmManageEmployeeSchedule

    ' IMPORTANT
    Private Access As New DatabaseControl

    Dim PASSCODE As String
    Dim FIRSTNAME As String
    Dim LASTNAME As String
    Dim DAY As String
    Dim TIME As TimeSpan
    Dim TIMEIN As String
    Dim TIMEOUT As String
    Dim selectedindex As Integer
    Public Sub New(schedpasscode As String, schedfname As String, schedlname As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PASSCODE = schedpasscode
        FIRSTNAME = schedfname
        LASTNAME = schedlname
    End Sub

    Private Sub frmManageEmployeeSchedule_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadSchedule()
    End Sub

    Private Sub LoadSchedule()
        lblEmployeeName.Text = FIRSTNAME & " " & LASTNAME
        Access.AddParam("@passcode", PASSCODE)
        Access.ExecuteQuery("SELECT * FROM tblTimeCard WHERE [Passcode]=@passcode")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        ' Fill DataGridView
        dgvTimeCard.DataSource = Access.DbDataTable
        dgvTimeCard.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvTimeCard.Columns(1).Visible = False
        dgvTimeCard.Columns(2).Visible = False
        dgvTimeCard.Columns(3).Visible = False
        dgvTimeCard.Columns(0).Width = 100
        dgvTimeCard.Columns(4).Width = 200
        dgvTimeCard.Columns(6).Width = 200
        dgvTimeCard.Columns(7).Width = 200
        dgvTimeCard.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvTimeCard.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvTimeCard.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvTimeCard.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvTimeCard.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvTimeCard.Columns(6).DefaultCellStyle.Format = "hh:mm tt"
        dgvTimeCard.Columns(7).DefaultCellStyle.Format = "hh:mm tt"
        dgvTimeCard.Columns(8).Visible = False
    End Sub

    Private Sub frmManageEmployeeSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBackSched_Click(sender As Object, e As EventArgs) Handles btnBackSched.Click
        Me.Close()
    End Sub

    Private Sub btnEditSched_Click(sender As Object, e As EventArgs) Handles btnEditSched.Click
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvTimeCard.Rows(selectedindex)
        txtDayEdit.Text = selectedRow.Cells(4).Value.ToString
        txtEditHours.Text = selectedRow.Cells(5).Value.ToString
        dtpEditIn.Value = selectedRow.Cells(6).Value
        dtpEditOut.Value = selectedRow.Cells(7).Value
        txtBreakDurationEdit.Text = selectedRow.Cells(8).Value

        pnlEditSched.Visible = True
        pnlEditSched.BringToFront()
        btnBackSched.Enabled = False
    End Sub

    Private Sub btnCancelEdit_Click(sender As Object, e As EventArgs) Handles btnCancelEdit.Click
        HideEditPanel()
        btnBackSched.Enabled = True
    End Sub

    Private Sub HideEditPanel()
        pnlEditSched.Visible = False
        pnlEditSched.SendToBack()
        btnCommitEditSched.Enabled = False
    End Sub

    Private Sub HideAddPanel()
        pnlAddSched.Visible = False
        pnlAddSched.SendToBack()
        btnCommitAddSched.Enabled = False
    End Sub

    Private Sub dgvTimeCard_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTimeCard.RowEnter
        selectedindex = e.RowIndex
        HideEditPanel()
        HideAddPanel()
        btnBackSched.Enabled = True
    End Sub

    Private Sub btnCommitAddSched_Click(sender As Object, e As EventArgs) Handles btnCommitAddSched.Click
        ' Check if Day Exists
        Access.AddParam("@passcode", PASSCODE)
        Access.AddParam("@day", cbDayOfWeek.SelectedItem)
        Access.ExecuteQuery("SELECT * FROM tblTimeCard WHERE [Passcode]=@passcode AND [Day]=@day")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        For Each R As DataRow In Access.DbDataTable.Rows
            If R("Day") = cbDayOfWeek.SelectedItem Then
                MsgBox("The selected day already exists in a schedule")
                Exit Sub
            End If
        Next
        If txtBreakDurationAdd.Text = "" Then
            txtBreakDurationAdd.Text = "00:00"
        End If
        ' Add to Sched
        Access.AddParam("@passcode", PASSCODE)
        Access.AddParam("@fname", FIRSTNAME)
        Access.AddParam("@lname", LASTNAME)
        Access.AddParam("@day", cbDayOfWeek.SelectedItem.ToString)
        Access.AddParam("@time", txtHoursAddSched.Text)
        Access.AddParam("@in", dtpAddIn.Value.ToString)
        Access.AddParam("@out", dtpAddOut.Value.ToString)
        Access.AddParam("@break", txtBreakDurationAdd.Text)
        Access.ExecuteQuery("INSERT INTO tblTimeCard ([Passcode],[FirstName],[LastName],[Day],[Time],[In],[Out],[BreakDuration]) " &
                            "VALUES (@passcode,@fname,@lname,@day,@time,@in,@out,@break)")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        MessageBox.Show("Schedule created successfully.")
        HideAddPanel()
        LoadSchedule()
        btnBackSched.Enabled = True
    End Sub

    Private Sub btnCancelAddSched_Click(sender As Object, e As EventArgs) Handles btnCancelAddSched.Click
        ' cancel add sched
        HideAddPanel()
        btnBackSched.Enabled = True
    End Sub

    Private Sub btnCreateSched_Click(sender As Object, e As EventArgs) Handles btnCreateSched.Click
        pnlAddSched.Visible = True
        pnlAddSched.BringToFront()
        btnBackSched.Enabled = False

        cbDayOfWeek.SelectedIndex = 0
        txtHoursAddSched.Text = ""
        txtBreakDurationAdd.Text = ""
        btnCommitAddSched.Enabled = False
    End Sub

    Private Sub dtpAddIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpAddIn.ValueChanged
        ' Calculate
        Dim timein As DateTime = dtpAddIn.Value
        Dim timeout As DateTime = dtpAddOut.Value
        Dim hours As TimeSpan = timeout.Subtract(timein)
        txtHoursAddSched.Text = hours.ToString
        btnCommitAddSched.Enabled = False
    End Sub

    Private Sub dtpAddOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpAddOut.ValueChanged
        ' Calculate
        Dim timein As DateTime = dtpAddIn.Value
        Dim timeout As DateTime = dtpAddOut.Value
        Dim hours As TimeSpan = timeout.Subtract(timein)
        txtHoursAddSched.Text = hours.ToString
        btnCommitAddSched.Enabled = False
    End Sub

    Private Sub btnAddSchedCalculate_Click(sender As Object, e As EventArgs) Handles btnAddSchedCalculate.Click
        Try
            Dim break As TimeSpan
            ' Calculate
            Dim timein As DateTime = dtpAddIn.Value
            Dim timeout As DateTime = dtpAddOut.Value
            Dim hours As TimeSpan = timeout.Subtract(timein)
            break = Nothing
            If Not txtBreakDurationAdd.Text = "" Then
                break = TimeSpan.Parse(txtBreakDurationAdd.Text)
            End If
            Dim lasthourvalue As TimeSpan = hours.Subtract(break)

            txtHoursAddSched.Text = lasthourvalue.ToString
            btnCommitAddSched.Enabled = True
        Catch ex As Exception
            txtBreakDurationAdd.Text = ""
            MessageBox.Show("Invalid value format. Please check.")
        End Try
    End Sub

    Private Sub txtBreakDurationAdd_TextChanged(sender As Object, e As EventArgs) Handles txtBreakDurationAdd.TextChanged
        btnCommitAddSched.Enabled = False
    End Sub

    Private Sub dtpEditIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpEditIn.ValueChanged
        ' Calculate
        Dim timein As DateTime = dtpEditIn.Value
        Dim timeout As DateTime = dtpEditOut.Value
        Dim hours As TimeSpan = timeout.Subtract(timein)
        txtEditHours.Text = hours.ToString
        btnCommitEditSched.Enabled = False
    End Sub

    Private Sub dtpEditOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpEditOut.ValueChanged
        ' Calculate
        Dim timein As DateTime = dtpEditIn.Value
        Dim timeout As DateTime = dtpEditOut.Value
        Dim hours As TimeSpan = timeout.Subtract(timein)
        txtEditHours.Text = hours.ToString
        btnCommitEditSched.Enabled = False
    End Sub

    Private Sub txtBreakDurationEdit_TextChanged(sender As Object, e As EventArgs) Handles txtBreakDurationEdit.TextChanged
        btnCommitEditSched.Enabled = False
    End Sub

    Private Sub btnSchedEditCalculate_Click(sender As Object, e As EventArgs) Handles btnSchedEditCalculate.Click
        Try
            Dim break As TimeSpan
            ' Calculate
            Dim timein As DateTime = dtpEditIn.Value
            Dim timeout As DateTime = dtpEditOut.Value
            Dim hours As TimeSpan = timeout.Subtract(timein)
            break = Nothing
            If Not txtBreakDurationEdit.Text = "" Then
                break = TimeSpan.Parse(txtBreakDurationEdit.Text)
            End If
            Dim lasthourvalue As TimeSpan = hours.Subtract(break)

            txtEditHours.Text = lasthourvalue.ToString
            btnCommitEditSched.Enabled = True
        Catch ex As Exception
            txtBreakDurationEdit.Text = ""
            MessageBox.Show("Invalid value format. Please check.")
        End Try
    End Sub

    Private Sub btnCommitEditSched_Click(sender As Object, e As EventArgs) Handles btnCommitEditSched.Click
        'MsgBox(txtDayEdit.Text)
        ' Update to Sched
        Access.AddParam("@in", dtpEditIn.Value.ToString)
        Access.AddParam("@out", dtpEditOut.Value.ToString)
        Access.AddParam("@time", txtEditHours.Text)
        Access.AddParam("@break", txtBreakDurationEdit.Text)
        Access.AddParam("@passcode", PASSCODE)
        Access.AddParam("@day", txtDayEdit.Text)
        Access.ExecuteQuery("UPDATE tblTimeCard SET [In]=@in,[Out]=@out,[Time]=@time,[BreakDuration]=@break" &
            " WHERE [Passcode]=@passcode AND [Day]=@day")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        LoadSchedule()
        MessageBox.Show("Schedule updated successfully.")
        HideEditPanel()
        btnBackSched.Enabled = True
    End Sub

    Private Sub btnRemoveSched_Click(sender As Object, e As EventArgs) Handles btnRemoveSched.Click
        Dim confirm As Integer = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Dim selectedRow As DataGridViewRow
            selectedRow = dgvTimeCard.Rows(selectedindex)
            Dim id = selectedRow.Cells(1).Value
            Access.AddParam("@id", id)
            Access.ExecuteQuery("DELETE * FROM tblTimeCard WHERE [ID] = " & id)
            If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
            LoadSchedule()
            MessageBox.Show("Schedule deleted successfully.")
        End If
    End Sub
End Class