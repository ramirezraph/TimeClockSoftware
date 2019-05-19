<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditAttendance
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEditAttendance = New System.Windows.Forms.Button()
        Me.btnSaveEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCancelForm
        '
        Me.btnCancelForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnCancelForm.FlatAppearance.BorderSize = 0
        Me.btnCancelForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelForm.ForeColor = System.Drawing.Color.White
        Me.btnCancelForm.Location = New System.Drawing.Point(640, 300)
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
        Me.dtpDate.Location = New System.Drawing.Point(132, 25)
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
        Me.txtEmployee.Enabled = False
        Me.txtEmployee.Location = New System.Drawing.Point(132, 73)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.ReadOnly = True
        Me.txtEmployee.Size = New System.Drawing.Size(230, 22)
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
        Me.txtTimeClockIn.Enabled = False
        Me.txtTimeClockIn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeClockIn.Location = New System.Drawing.Point(50, 133)
        Me.txtTimeClockIn.Name = "txtTimeClockIn"
        Me.txtTimeClockIn.ReadOnly = True
        Me.txtTimeClockIn.Size = New System.Drawing.Size(87, 25)
        Me.txtTimeClockIn.TabIndex = 17
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
        Me.txtTimeClockOut.Enabled = False
        Me.txtTimeClockOut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeClockOut.Location = New System.Drawing.Point(225, 133)
        Me.txtTimeClockOut.Name = "txtTimeClockOut"
        Me.txtTimeClockOut.ReadOnly = True
        Me.txtTimeClockOut.Size = New System.Drawing.Size(87, 25)
        Me.txtTimeClockOut.TabIndex = 20
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
        Me.txtTimeBreakStart.Enabled = False
        Me.txtTimeBreakStart.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeBreakStart.Location = New System.Drawing.Point(50, 195)
        Me.txtTimeBreakStart.Name = "txtTimeBreakStart"
        Me.txtTimeBreakStart.ReadOnly = True
        Me.txtTimeBreakStart.Size = New System.Drawing.Size(87, 25)
        Me.txtTimeBreakStart.TabIndex = 23
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
        Me.txtTimeBreakEnd.Enabled = False
        Me.txtTimeBreakEnd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeBreakEnd.Location = New System.Drawing.Point(225, 195)
        Me.txtTimeBreakEnd.Name = "txtTimeBreakEnd"
        Me.txtTimeBreakEnd.ReadOnly = True
        Me.txtTimeBreakEnd.Size = New System.Drawing.Size(87, 25)
        Me.txtTimeBreakEnd.TabIndex = 26
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
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(492, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(230, 22)
        Me.TextBox1.TabIndex = 29
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
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(132, 245)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(230, 22)
        Me.TextBox2.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Total Break:"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(132, 284)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(230, 22)
        Me.TextBox3.TabIndex = 33
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
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(492, 121)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(230, 111)
        Me.TextBox4.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(397, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "NOTES:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "(optional)"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(492, 31)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(230, 22)
        Me.TextBox5.TabIndex = 38
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
        'btnEditAttendance
        '
        Me.btnEditAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnEditAttendance.FlatAppearance.BorderSize = 0
        Me.btnEditAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditAttendance.ForeColor = System.Drawing.Color.White
        Me.btnEditAttendance.Location = New System.Drawing.Point(482, 300)
        Me.btnEditAttendance.Name = "btnEditAttendance"
        Me.btnEditAttendance.Size = New System.Drawing.Size(152, 30)
        Me.btnEditAttendance.TabIndex = 39
        Me.btnEditAttendance.Text = "Edit"
        Me.btnEditAttendance.UseVisualStyleBackColor = False
        '
        'btnSaveEdit
        '
        Me.btnSaveEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnSaveEdit.FlatAppearance.BorderSize = 0
        Me.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveEdit.ForeColor = System.Drawing.Color.White
        Me.btnSaveEdit.Location = New System.Drawing.Point(482, 300)
        Me.btnSaveEdit.Name = "btnSaveEdit"
        Me.btnSaveEdit.Size = New System.Drawing.Size(152, 30)
        Me.btnSaveEdit.TabIndex = 41
        Me.btnSaveEdit.Text = "Save"
        Me.btnSaveEdit.UseVisualStyleBackColor = False
        Me.btnSaveEdit.Visible = False
        '
        'frmEditAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(804, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSaveEdit)
        Me.Controls.Add(Me.btnEditAttendance)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Name = "frmEditAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Attendance"
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEditAttendance As Button
    Friend WithEvents btnSaveEdit As Button
End Class
