<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageEmployeeSchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvTimeCard = New System.Windows.Forms.DataGridView()
        Me.pnlTopSched = New System.Windows.Forms.Panel()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBackSched = New System.Windows.Forms.Button()
        Me.btnCreateSched = New System.Windows.Forms.Button()
        Me.btnEditSched = New System.Windows.Forms.Button()
        Me.btnRemoveSched = New System.Windows.Forms.Button()
        Me.pnlEditSched = New System.Windows.Forms.Panel()
        Me.txtBreakDurationEdit = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtEditHours = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEditOut = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpEditIn = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCommitEditSched = New System.Windows.Forms.Button()
        Me.btnCancelEdit = New System.Windows.Forms.Button()
        Me.txtDayEdit = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.pnlAddSched = New System.Windows.Forms.Panel()
        Me.btnAddSchedCalculate = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBreakDurationAdd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbDayOfWeek = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHoursAddSched = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpAddOut = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpAddIn = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCommitAddSched = New System.Windows.Forms.Button()
        Me.btnCancelAddSched = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSchedEditCalculate = New System.Windows.Forms.Button()
        CType(Me.dgvTimeCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSched.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditSched.SuspendLayout()
        Me.pnlAddSched.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTimeCard
        '
        Me.dgvTimeCard.AllowUserToAddRows = False
        Me.dgvTimeCard.AllowUserToDeleteRows = False
        Me.dgvTimeCard.AllowUserToResizeColumns = False
        Me.dgvTimeCard.AllowUserToResizeRows = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.dgvTimeCard.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvTimeCard.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.dgvTimeCard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTimeCard.ColumnHeadersHeight = 25
        Me.dgvTimeCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTimeCard.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvTimeCard.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvTimeCard.Location = New System.Drawing.Point(12, 111)
        Me.dgvTimeCard.MultiSelect = False
        Me.dgvTimeCard.Name = "dgvTimeCard"
        Me.dgvTimeCard.ReadOnly = True
        Me.dgvTimeCard.RowHeadersVisible = False
        Me.dgvTimeCard.RowHeadersWidth = 60
        Me.dgvTimeCard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTimeCard.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTimeCard.RowTemplate.Height = 35
        Me.dgvTimeCard.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTimeCard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTimeCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTimeCard.Size = New System.Drawing.Size(776, 327)
        Me.dgvTimeCard.TabIndex = 6
        '
        'pnlTopSched
        '
        Me.pnlTopSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlTopSched.Controls.Add(Me.lblEmployeeName)
        Me.pnlTopSched.Controls.Add(Me.Label1)
        Me.pnlTopSched.Controls.Add(Me.PictureBox1)
        Me.pnlTopSched.Controls.Add(Me.lblPayment)
        Me.pnlTopSched.Location = New System.Drawing.Point(12, 12)
        Me.pnlTopSched.Name = "pnlTopSched"
        Me.pnlTopSched.Size = New System.Drawing.Size(776, 65)
        Me.pnlTopSched.TabIndex = 48
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeName.Location = New System.Drawing.Point(557, 28)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(106, 17)
        Me.lblEmployeeName.TabIndex = 52
        Me.lblEmployeeName.Text = "Raphael Ramirez"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(460, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Employee Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TimeClock_Project.My.Resources.Resources.schedule_icon
        Me.PictureBox1.Location = New System.Drawing.Point(18, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPayment.Location = New System.Drawing.Point(57, 16)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(207, 32)
        Me.lblPayment.TabIndex = 49
        Me.lblPayment.Text = "Manage Schedule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Schedules:"
        '
        'btnBackSched
        '
        Me.btnBackSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnBackSched.FlatAppearance.BorderSize = 0
        Me.btnBackSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackSched.ForeColor = System.Drawing.Color.White
        Me.btnBackSched.Location = New System.Drawing.Point(572, 446)
        Me.btnBackSched.Name = "btnBackSched"
        Me.btnBackSched.Size = New System.Drawing.Size(207, 27)
        Me.btnBackSched.TabIndex = 54
        Me.btnBackSched.Text = "Back"
        Me.btnBackSched.UseVisualStyleBackColor = False
        '
        'btnCreateSched
        '
        Me.btnCreateSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCreateSched.FlatAppearance.BorderSize = 0
        Me.btnCreateSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateSched.ForeColor = System.Drawing.Color.White
        Me.btnCreateSched.Location = New System.Drawing.Point(371, 83)
        Me.btnCreateSched.Name = "btnCreateSched"
        Me.btnCreateSched.Size = New System.Drawing.Size(146, 22)
        Me.btnCreateSched.TabIndex = 55
        Me.btnCreateSched.Text = "Create"
        Me.btnCreateSched.UseVisualStyleBackColor = False
        '
        'btnEditSched
        '
        Me.btnEditSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnEditSched.FlatAppearance.BorderSize = 0
        Me.btnEditSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditSched.ForeColor = System.Drawing.Color.White
        Me.btnEditSched.Location = New System.Drawing.Point(523, 83)
        Me.btnEditSched.Name = "btnEditSched"
        Me.btnEditSched.Size = New System.Drawing.Size(121, 22)
        Me.btnEditSched.TabIndex = 56
        Me.btnEditSched.Text = "Edit"
        Me.btnEditSched.UseVisualStyleBackColor = False
        '
        'btnRemoveSched
        '
        Me.btnRemoveSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnRemoveSched.FlatAppearance.BorderSize = 0
        Me.btnRemoveSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveSched.ForeColor = System.Drawing.Color.White
        Me.btnRemoveSched.Location = New System.Drawing.Point(650, 83)
        Me.btnRemoveSched.Name = "btnRemoveSched"
        Me.btnRemoveSched.Size = New System.Drawing.Size(121, 22)
        Me.btnRemoveSched.TabIndex = 57
        Me.btnRemoveSched.Text = "Remove"
        Me.btnRemoveSched.UseVisualStyleBackColor = False
        '
        'pnlEditSched
        '
        Me.pnlEditSched.Controls.Add(Me.btnSchedEditCalculate)
        Me.pnlEditSched.Controls.Add(Me.Label15)
        Me.pnlEditSched.Controls.Add(Me.txtBreakDurationEdit)
        Me.pnlEditSched.Controls.Add(Me.Label12)
        Me.pnlEditSched.Controls.Add(Me.Label44)
        Me.pnlEditSched.Controls.Add(Me.txtEditHours)
        Me.pnlEditSched.Controls.Add(Me.Label5)
        Me.pnlEditSched.Controls.Add(Me.dtpEditOut)
        Me.pnlEditSched.Controls.Add(Me.Label4)
        Me.pnlEditSched.Controls.Add(Me.dtpEditIn)
        Me.pnlEditSched.Controls.Add(Me.Label2)
        Me.pnlEditSched.Controls.Add(Me.btnCommitEditSched)
        Me.pnlEditSched.Controls.Add(Me.btnCancelEdit)
        Me.pnlEditSched.Controls.Add(Me.txtDayEdit)
        Me.pnlEditSched.Controls.Add(Me.Label43)
        Me.pnlEditSched.Location = New System.Drawing.Point(0, 0)
        Me.pnlEditSched.Name = "pnlEditSched"
        Me.pnlEditSched.Size = New System.Drawing.Size(801, 105)
        Me.pnlEditSched.TabIndex = 58
        Me.pnlEditSched.Visible = False
        '
        'txtBreakDurationEdit
        '
        Me.txtBreakDurationEdit.Location = New System.Drawing.Point(117, 67)
        Me.txtBreakDurationEdit.Name = "txtBreakDurationEdit"
        Me.txtBreakDurationEdit.Size = New System.Drawing.Size(115, 22)
        Me.txtBreakDurationEdit.TabIndex = 68
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Break Duration:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(21, 11)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(102, 17)
        Me.Label44.TabIndex = 63
        Me.Label44.Text = "EDIT SCHEDULE"
        '
        'txtEditHours
        '
        Me.txtEditHours.Location = New System.Drawing.Point(374, 67)
        Me.txtEditHours.Name = "txtEditHours"
        Me.txtEditHours.ReadOnly = True
        Me.txtEditHours.Size = New System.Drawing.Size(121, 22)
        Me.txtEditHours.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(327, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Hours:"
        '
        'dtpEditOut
        '
        Me.dtpEditOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEditOut.Location = New System.Drawing.Point(404, 39)
        Me.dtpEditOut.Name = "dtpEditOut"
        Me.dtpEditOut.ShowUpDown = True
        Me.dtpEditOut.Size = New System.Drawing.Size(89, 22)
        Me.dtpEditOut.TabIndex = 60
        Me.dtpEditOut.Value = New Date(2019, 5, 28, 12, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(368, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Out:"
        '
        'dtpEditIn
        '
        Me.dtpEditIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEditIn.Location = New System.Drawing.Point(265, 39)
        Me.dtpEditIn.Name = "dtpEditIn"
        Me.dtpEditIn.ShowUpDown = True
        Me.dtpEditIn.Size = New System.Drawing.Size(89, 22)
        Me.dtpEditIn.TabIndex = 58
        Me.dtpEditIn.Value = New Date(2019, 5, 28, 12, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "In:"
        '
        'btnCommitEditSched
        '
        Me.btnCommitEditSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCommitEditSched.FlatAppearance.BorderSize = 0
        Me.btnCommitEditSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommitEditSched.ForeColor = System.Drawing.Color.White
        Me.btnCommitEditSched.Location = New System.Drawing.Point(645, 24)
        Me.btnCommitEditSched.Name = "btnCommitEditSched"
        Me.btnCommitEditSched.Size = New System.Drawing.Size(144, 25)
        Me.btnCommitEditSched.TabIndex = 56
        Me.btnCommitEditSched.Text = "Commit"
        Me.btnCommitEditSched.UseVisualStyleBackColor = False
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnCancelEdit.FlatAppearance.BorderSize = 0
        Me.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelEdit.ForeColor = System.Drawing.Color.White
        Me.btnCancelEdit.Location = New System.Drawing.Point(645, 55)
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(144, 25)
        Me.btnCancelEdit.TabIndex = 55
        Me.btnCancelEdit.Text = "Cancel"
        Me.btnCancelEdit.UseVisualStyleBackColor = False
        '
        'txtDayEdit
        '
        Me.txtDayEdit.Location = New System.Drawing.Point(58, 39)
        Me.txtDayEdit.Name = "txtDayEdit"
        Me.txtDayEdit.ReadOnly = True
        Me.txtDayEdit.Size = New System.Drawing.Size(173, 22)
        Me.txtDayEdit.TabIndex = 11
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(21, 42)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(29, 13)
        Me.Label43.TabIndex = 10
        Me.Label43.Text = "Day:"
        '
        'pnlAddSched
        '
        Me.pnlAddSched.Controls.Add(Me.btnAddSchedCalculate)
        Me.pnlAddSched.Controls.Add(Me.Label14)
        Me.pnlAddSched.Controls.Add(Me.Label13)
        Me.pnlAddSched.Controls.Add(Me.txtBreakDurationAdd)
        Me.pnlAddSched.Controls.Add(Me.Label11)
        Me.pnlAddSched.Controls.Add(Me.cbDayOfWeek)
        Me.pnlAddSched.Controls.Add(Me.Label6)
        Me.pnlAddSched.Controls.Add(Me.txtHoursAddSched)
        Me.pnlAddSched.Controls.Add(Me.Label7)
        Me.pnlAddSched.Controls.Add(Me.dtpAddOut)
        Me.pnlAddSched.Controls.Add(Me.Label8)
        Me.pnlAddSched.Controls.Add(Me.dtpAddIn)
        Me.pnlAddSched.Controls.Add(Me.Label9)
        Me.pnlAddSched.Controls.Add(Me.btnCommitAddSched)
        Me.pnlAddSched.Controls.Add(Me.btnCancelAddSched)
        Me.pnlAddSched.Controls.Add(Me.Label10)
        Me.pnlAddSched.Location = New System.Drawing.Point(0, 0)
        Me.pnlAddSched.Name = "pnlAddSched"
        Me.pnlAddSched.Size = New System.Drawing.Size(801, 105)
        Me.pnlAddSched.TabIndex = 64
        Me.pnlAddSched.Visible = False
        '
        'btnAddSchedCalculate
        '
        Me.btnAddSchedCalculate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddSchedCalculate.FlatAppearance.BorderSize = 0
        Me.btnAddSchedCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSchedCalculate.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnAddSchedCalculate.Location = New System.Drawing.Point(499, 41)
        Me.btnAddSchedCalculate.Name = "btnAddSchedCalculate"
        Me.btnAddSchedCalculate.Size = New System.Drawing.Size(88, 46)
        Me.btnAddSchedCalculate.TabIndex = 69
        Me.btnAddSchedCalculate.Text = "Calculate"
        Me.btnAddSchedCalculate.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(237, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "(hh:mm:ss)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(256, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(216, 13)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "NOTE: Put the In and Out value carefully."
        '
        'txtBreakDurationAdd
        '
        Me.txtBreakDurationAdd.Location = New System.Drawing.Point(116, 69)
        Me.txtBreakDurationAdd.Name = "txtBreakDurationAdd"
        Me.txtBreakDurationAdd.Size = New System.Drawing.Size(115, 22)
        Me.txtBreakDurationAdd.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Break Duration:"
        '
        'cbDayOfWeek
        '
        Me.cbDayOfWeek.FormattingEnabled = True
        Me.cbDayOfWeek.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.cbDayOfWeek.Location = New System.Drawing.Point(69, 42)
        Me.cbDayOfWeek.Name = "cbDayOfWeek"
        Me.cbDayOfWeek.Size = New System.Drawing.Size(162, 21)
        Me.cbDayOfWeek.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 17)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "CREATE SCHEDULE"
        '
        'txtHoursAddSched
        '
        Me.txtHoursAddSched.Location = New System.Drawing.Point(360, 69)
        Me.txtHoursAddSched.Name = "txtHoursAddSched"
        Me.txtHoursAddSched.ReadOnly = True
        Me.txtHoursAddSched.Size = New System.Drawing.Size(122, 22)
        Me.txtHoursAddSched.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(313, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Hours:"
        '
        'dtpAddOut
        '
        Me.dtpAddOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpAddOut.Location = New System.Drawing.Point(394, 41)
        Me.dtpAddOut.Name = "dtpAddOut"
        Me.dtpAddOut.ShowUpDown = True
        Me.dtpAddOut.Size = New System.Drawing.Size(89, 22)
        Me.dtpAddOut.TabIndex = 60
        Me.dtpAddOut.Value = New Date(2019, 5, 28, 12, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(358, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Out:"
        '
        'dtpAddIn
        '
        Me.dtpAddIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpAddIn.Location = New System.Drawing.Point(260, 41)
        Me.dtpAddIn.Name = "dtpAddIn"
        Me.dtpAddIn.ShowUpDown = True
        Me.dtpAddIn.Size = New System.Drawing.Size(89, 22)
        Me.dtpAddIn.TabIndex = 58
        Me.dtpAddIn.Value = New Date(2019, 5, 28, 12, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(237, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "In:"
        '
        'btnCommitAddSched
        '
        Me.btnCommitAddSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCommitAddSched.Enabled = False
        Me.btnCommitAddSched.FlatAppearance.BorderSize = 0
        Me.btnCommitAddSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommitAddSched.ForeColor = System.Drawing.Color.White
        Me.btnCommitAddSched.Location = New System.Drawing.Point(645, 24)
        Me.btnCommitAddSched.Name = "btnCommitAddSched"
        Me.btnCommitAddSched.Size = New System.Drawing.Size(144, 25)
        Me.btnCommitAddSched.TabIndex = 56
        Me.btnCommitAddSched.Text = "Commit"
        Me.btnCommitAddSched.UseVisualStyleBackColor = False
        '
        'btnCancelAddSched
        '
        Me.btnCancelAddSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnCancelAddSched.FlatAppearance.BorderSize = 0
        Me.btnCancelAddSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelAddSched.ForeColor = System.Drawing.Color.White
        Me.btnCancelAddSched.Location = New System.Drawing.Point(645, 55)
        Me.btnCancelAddSched.Name = "btnCancelAddSched"
        Me.btnCancelAddSched.Size = New System.Drawing.Size(144, 25)
        Me.btnCancelAddSched.TabIndex = 55
        Me.btnCancelAddSched.Text = "Cancel"
        Me.btnCancelAddSched.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Day:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(238, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "(hh:mm:ss)"
        '
        'btnSchedEditCalculate
        '
        Me.btnSchedEditCalculate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSchedEditCalculate.FlatAppearance.BorderSize = 0
        Me.btnSchedEditCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedEditCalculate.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSchedEditCalculate.Location = New System.Drawing.Point(512, 39)
        Me.btnSchedEditCalculate.Name = "btnSchedEditCalculate"
        Me.btnSchedEditCalculate.Size = New System.Drawing.Size(88, 46)
        Me.btnSchedEditCalculate.TabIndex = 70
        Me.btnSchedEditCalculate.Text = "Calculate"
        Me.btnSchedEditCalculate.UseVisualStyleBackColor = False
        '
        'frmManageEmployeeSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 479)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRemoveSched)
        Me.Controls.Add(Me.btnEditSched)
        Me.Controls.Add(Me.btnCreateSched)
        Me.Controls.Add(Me.btnBackSched)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlTopSched)
        Me.Controls.Add(Me.dgvTimeCard)
        Me.Controls.Add(Me.pnlEditSched)
        Me.Controls.Add(Me.pnlAddSched)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManageEmployeeSchedule"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvTimeCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSched.ResumeLayout(False)
        Me.pnlTopSched.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditSched.ResumeLayout(False)
        Me.pnlEditSched.PerformLayout()
        Me.pnlAddSched.ResumeLayout(False)
        Me.pnlAddSched.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTimeCard As DataGridView
    Friend WithEvents pnlTopSched As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBackSched As Button
    Friend WithEvents btnCreateSched As Button
    Friend WithEvents btnEditSched As Button
    Friend WithEvents btnRemoveSched As Button
    Friend WithEvents pnlEditSched As Panel
    Friend WithEvents txtDayEdit As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents btnCommitEditSched As Button
    Friend WithEvents btnCancelEdit As Button
    Friend WithEvents dtpEditIn As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpEditOut As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEditHours As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents pnlAddSched As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHoursAddSched As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpAddOut As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpAddIn As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCommitAddSched As Button
    Friend WithEvents btnCancelAddSched As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cbDayOfWeek As ComboBox
    Friend WithEvents txtBreakDurationAdd As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBreakDurationEdit As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnAddSchedCalculate As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSchedEditCalculate As Button
End Class
