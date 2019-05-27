<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewAttendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCancelForm = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.txtTimeClockIn = New System.Windows.Forms.TextBox()
        Me.cbAMPMClockIn = New System.Windows.Forms.ComboBox()
        Me.cbAMPMClockOut = New System.Windows.Forms.ComboBox()
        Me.txtTimeClockOut = New System.Windows.Forms.TextBox()
        Me.lblCO = New System.Windows.Forms.Label()
        Me.cbAMPMBreakStart = New System.Windows.Forms.ComboBox()
        Me.txtTimeBreakStart = New System.Windows.Forms.TextBox()
        Me.lblBS = New System.Windows.Forms.Label()
        Me.cbAMPMBreakEnd = New System.Windows.Forms.ComboBox()
        Me.txtTimeBreakEnd = New System.Windows.Forms.TextBox()
        Me.lblBE = New System.Windows.Forms.Label()
        Me.txtPasscode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalBreak = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalHour = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSaveNotes = New System.Windows.Forms.Button()
        Me.txtTotalPay = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelForm
        '
        Me.btnCancelForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnCancelForm.FlatAppearance.BorderSize = 0
        Me.btnCancelForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelForm.ForeColor = System.Drawing.Color.White
        Me.btnCancelForm.Location = New System.Drawing.Point(618, 327)
        Me.btnCancelForm.Name = "btnCancelForm"
        Me.btnCancelForm.Size = New System.Drawing.Size(152, 30)
        Me.btnCancelForm.TabIndex = 3
        Me.btnCancelForm.Text = "Cancel"
        Me.btnCancelForm.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(37, 29)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 16)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date:"
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Enabled = False
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(131, 21)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(230, 25)
        Me.dtpDate.TabIndex = 5
        '
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = True
        Me.lblEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee.Location = New System.Drawing.Point(37, 74)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(73, 16)
        Me.lblEmployee.TabIndex = 6
        Me.lblEmployee.Text = "Employee:"
        '
        'txtEmployee
        '
        Me.txtEmployee.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployee.Location = New System.Drawing.Point(131, 69)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.ReadOnly = True
        Me.txtEmployee.Size = New System.Drawing.Size(230, 25)
        Me.txtEmployee.TabIndex = 9
        '
        'lblCI
        '
        Me.lblCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCI.Location = New System.Drawing.Point(50, 111)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(137, 16)
        Me.lblCI.TabIndex = 10
        Me.lblCI.Text = "Clocked In"
        Me.lblCI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTimeClockIn
        '
        Me.txtTimeClockIn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeClockIn.Location = New System.Drawing.Point(50, 133)
        Me.txtTimeClockIn.Name = "txtTimeClockIn"
        Me.txtTimeClockIn.ReadOnly = True
        Me.txtTimeClockIn.Size = New System.Drawing.Size(87, 25)
        Me.txtTimeClockIn.TabIndex = 17
        Me.txtTimeClockIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbAMPMClockIn
        '
        Me.cbAMPMClockIn.Enabled = False
        Me.cbAMPMClockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAMPMClockIn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAMPMClockIn.FormattingEnabled = True
        Me.cbAMPMClockIn.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbAMPMClockIn.Location = New System.Drawing.Point(142, 133)
        Me.cbAMPMClockIn.Name = "cbAMPMClockIn"
        Me.cbAMPMClockIn.Size = New System.Drawing.Size(45, 25)
        Me.cbAMPMClockIn.TabIndex = 18
        '
        'cbAMPMClockOut
        '
        Me.cbAMPMClockOut.Enabled = False
        Me.cbAMPMClockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAMPMClockOut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAMPMClockOut.FormattingEnabled = True
        Me.cbAMPMClockOut.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbAMPMClockOut.Location = New System.Drawing.Point(317, 133)
        Me.cbAMPMClockOut.Name = "cbAMPMClockOut"
        Me.cbAMPMClockOut.Size = New System.Drawing.Size(45, 25)
        Me.cbAMPMClockOut.TabIndex = 21
        '
        'txtTimeClockOut
        '
        Me.txtTimeClockOut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeClockOut.Location = New System.Drawing.Point(225, 133)
        Me.txtTimeClockOut.Name = "txtTimeClockOut"
        Me.txtTimeClockOut.ReadOnly = True
        Me.txtTimeClockOut.Size = New System.Drawing.Size(87, 25)
        Me.txtTimeClockOut.TabIndex = 20
        Me.txtTimeClockOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCO
        '
        Me.lblCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCO.Location = New System.Drawing.Point(225, 111)
        Me.lblCO.Name = "lblCO"
        Me.lblCO.Size = New System.Drawing.Size(137, 16)
        Me.lblCO.TabIndex = 19
        Me.lblCO.Text = "Clocked Out"
        Me.lblCO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbAMPMBreakStart
        '
        Me.cbAMPMBreakStart.Enabled = False
        Me.cbAMPMBreakStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAMPMBreakStart.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAMPMBreakStart.FormattingEnabled = True
        Me.cbAMPMBreakStart.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbAMPMBreakStart.Location = New System.Drawing.Point(142, 195)
        Me.cbAMPMBreakStart.Name = "cbAMPMBreakStart"
        Me.cbAMPMBreakStart.Size = New System.Drawing.Size(45, 25)
        Me.cbAMPMBreakStart.TabIndex = 24
        '
        'txtTimeBreakStart
        '
        Me.txtTimeBreakStart.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeBreakStart.Location = New System.Drawing.Point(50, 195)
        Me.txtTimeBreakStart.Name = "txtTimeBreakStart"
        Me.txtTimeBreakStart.ReadOnly = True
        Me.txtTimeBreakStart.Size = New System.Drawing.Size(87, 25)
        Me.txtTimeBreakStart.TabIndex = 23
        Me.txtTimeBreakStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBS
        '
        Me.lblBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBS.Location = New System.Drawing.Point(50, 173)
        Me.lblBS.Name = "lblBS"
        Me.lblBS.Size = New System.Drawing.Size(137, 16)
        Me.lblBS.TabIndex = 22
        Me.lblBS.Text = "Break Start"
        Me.lblBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbAMPMBreakEnd
        '
        Me.cbAMPMBreakEnd.Enabled = False
        Me.cbAMPMBreakEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAMPMBreakEnd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAMPMBreakEnd.FormattingEnabled = True
        Me.cbAMPMBreakEnd.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbAMPMBreakEnd.Location = New System.Drawing.Point(317, 195)
        Me.cbAMPMBreakEnd.Name = "cbAMPMBreakEnd"
        Me.cbAMPMBreakEnd.Size = New System.Drawing.Size(45, 25)
        Me.cbAMPMBreakEnd.TabIndex = 27
        '
        'txtTimeBreakEnd
        '
        Me.txtTimeBreakEnd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeBreakEnd.Location = New System.Drawing.Point(225, 195)
        Me.txtTimeBreakEnd.Name = "txtTimeBreakEnd"
        Me.txtTimeBreakEnd.ReadOnly = True
        Me.txtTimeBreakEnd.Size = New System.Drawing.Size(87, 25)
        Me.txtTimeBreakEnd.TabIndex = 26
        Me.txtTimeBreakEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBE
        '
        Me.lblBE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBE.Location = New System.Drawing.Point(225, 173)
        Me.lblBE.Name = "lblBE"
        Me.lblBE.Size = New System.Drawing.Size(137, 16)
        Me.lblBE.TabIndex = 25
        Me.lblBE.Text = "Break End"
        Me.lblBE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPasscode
        '
        Me.txtPasscode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasscode.Location = New System.Drawing.Point(491, 74)
        Me.txtPasscode.Name = "txtPasscode"
        Me.txtPasscode.ReadOnly = True
        Me.txtPasscode.Size = New System.Drawing.Size(230, 25)
        Me.txtPasscode.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Passcode:"
        '
        'txtTotalBreak
        '
        Me.txtTotalBreak.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBreak.Location = New System.Drawing.Point(131, 237)
        Me.txtTotalBreak.Name = "txtTotalBreak"
        Me.txtTotalBreak.ReadOnly = True
        Me.txtTotalBreak.Size = New System.Drawing.Size(230, 25)
        Me.txtTotalBreak.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Total Break:"
        '
        'txtTotalHour
        '
        Me.txtTotalHour.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHour.Location = New System.Drawing.Point(131, 280)
        Me.txtTotalHour.Name = "txtTotalHour"
        Me.txtTotalHour.ReadOnly = True
        Me.txtTotalHour.Size = New System.Drawing.Size(230, 25)
        Me.txtTotalHour.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Hours:"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(491, 168)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNote.Size = New System.Drawing.Size(230, 111)
        Me.txtNote.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(397, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "NOTES:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "(optional)"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(491, 27)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(230, 25)
        Me.txtId.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(397, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "ID:"
        '
        'btnSaveNotes
        '
        Me.btnSaveNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnSaveNotes.FlatAppearance.BorderSize = 0
        Me.btnSaveNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveNotes.ForeColor = System.Drawing.Color.White
        Me.btnSaveNotes.Location = New System.Drawing.Point(460, 326)
        Me.btnSaveNotes.Name = "btnSaveNotes"
        Me.btnSaveNotes.Size = New System.Drawing.Size(152, 30)
        Me.btnSaveNotes.TabIndex = 41
        Me.btnSaveNotes.Text = "Save Notes"
        Me.btnSaveNotes.UseVisualStyleBackColor = False
        '
        'txtTotalPay
        '
        Me.txtTotalPay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPay.Location = New System.Drawing.Point(131, 322)
        Me.txtTotalPay.Name = "txtTotalPay"
        Me.txtTotalPay.ReadOnly = True
        Me.txtTotalPay.Size = New System.Drawing.Size(230, 25)
        Me.txtTotalPay.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Total Pay:"
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(491, 120)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(230, 25)
        Me.txtRate.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(397, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Rate:"
        '
        'frmViewAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(804, 380)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalPay)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSaveNotes)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalHour)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalBreak)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPasscode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbAMPMBreakEnd)
        Me.Controls.Add(Me.txtTimeBreakEnd)
        Me.Controls.Add(Me.lblBE)
        Me.Controls.Add(Me.cbAMPMBreakStart)
        Me.Controls.Add(Me.txtTimeBreakStart)
        Me.Controls.Add(Me.lblBS)
        Me.Controls.Add(Me.cbAMPMClockOut)
        Me.Controls.Add(Me.txtTimeClockOut)
        Me.Controls.Add(Me.lblCO)
        Me.Controls.Add(Me.cbAMPMClockIn)
        Me.Controls.Add(Me.txtTimeClockIn)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.txtEmployee)
        Me.Controls.Add(Me.lblEmployee)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnCancelForm)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmViewAttendance"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelForm As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblEmployee As Label
    Friend WithEvents txtEmployee As TextBox
    Friend WithEvents lblCI As Label
    Friend WithEvents txtTimeClockIn As TextBox
    Friend WithEvents cbAMPMClockIn As ComboBox
    Friend WithEvents cbAMPMClockOut As ComboBox
    Friend WithEvents txtTimeClockOut As TextBox
    Friend WithEvents lblCO As Label
    Friend WithEvents cbAMPMBreakStart As ComboBox
    Friend WithEvents txtTimeBreakStart As TextBox
    Friend WithEvents lblBS As Label
    Friend WithEvents cbAMPMBreakEnd As ComboBox
    Friend WithEvents txtTimeBreakEnd As TextBox
    Friend WithEvents lblBE As Label
    Friend WithEvents txtPasscode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalBreak As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalHour As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSaveNotes As Button
    Friend WithEvents txtTotalPay As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label8 As Label
End Class
