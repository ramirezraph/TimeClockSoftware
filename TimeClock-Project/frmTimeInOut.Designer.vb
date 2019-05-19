<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeInOut
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlAppbar = New System.Windows.Forms.Panel()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.pbUserImage = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.lbldDateToday = New System.Windows.Forms.Label()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.lbldCurrentTime = New System.Windows.Forms.Label()
        Me.lblGreetings = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnClockIn = New System.Windows.Forms.Button()
        Me.btnClockOut = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tmrCurrentTime = New System.Windows.Forms.Timer(Me.components)
        Me.btnBreak = New System.Windows.Forms.Button()
        Me.pnlAppbar.SuspendLayout()
        CType(Me.pbUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAppbar
        '
        Me.pnlAppbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlAppbar.Controls.Add(Me.lblTimer)
        Me.pnlAppbar.Controls.Add(Me.lblAppTitle)
        Me.pnlAppbar.Controls.Add(Me.lblAppName)
        Me.pnlAppbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlAppbar.Name = "pnlAppbar"
        Me.pnlAppbar.Size = New System.Drawing.Size(486, 46)
        Me.pnlAppbar.TabIndex = 33
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(440, 7)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(44, 30)
        Me.lblTimer.TabIndex = 11
        Me.lblTimer.Text = "15"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAppTitle
        '
        Me.lblAppTitle.AutoSize = True
        Me.lblAppTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblAppTitle.Location = New System.Drawing.Point(178, 20)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(105, 13)
        Me.lblAppTitle.TabIndex = 10
        Me.lblAppTitle.Text = "Time Clock Software"
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.BackColor = System.Drawing.Color.Transparent
        Me.lblAppName.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.Location = New System.Drawing.Point(10, 9)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(173, 29)
        Me.lblAppName.TabIndex = 9
        Me.lblAppName.Text = "Lorem Ipsum"
        '
        'pbUserImage
        '
        Me.pbUserImage.BackColor = System.Drawing.Color.Transparent
        Me.pbUserImage.Image = Global.TimeClock_Project.My.Resources.Resources.attendanceicon
        Me.pbUserImage.Location = New System.Drawing.Point(0, 82)
        Me.pbUserImage.Name = "pbUserImage"
        Me.pbUserImage.Size = New System.Drawing.Size(486, 171)
        Me.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUserImage.TabIndex = 34
        Me.pbUserImage.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblDateToday)
        Me.Panel1.Controls.Add(Me.lbldDateToday)
        Me.Panel1.Controls.Add(Me.lblCurrentTime)
        Me.Panel1.Controls.Add(Me.lbldCurrentTime)
        Me.Panel1.Location = New System.Drawing.Point(0, 615)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 46)
        Me.Panel1.TabIndex = 35
        '
        'lblDateToday
        '
        Me.lblDateToday.AutoSize = True
        Me.lblDateToday.BackColor = System.Drawing.Color.Transparent
        Me.lblDateToday.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateToday.Location = New System.Drawing.Point(92, 11)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(133, 25)
        Me.lblDateToday.TabIndex = 14
        Me.lblDateToday.Text = "Friday, May 19"
        '
        'lbldDateToday
        '
        Me.lbldDateToday.AutoSize = True
        Me.lbldDateToday.BackColor = System.Drawing.Color.Transparent
        Me.lbldDateToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldDateToday.ForeColor = System.Drawing.Color.Silver
        Me.lbldDateToday.Location = New System.Drawing.Point(19, 16)
        Me.lbldDateToday.Name = "lbldDateToday"
        Me.lbldDateToday.Size = New System.Drawing.Size(72, 15)
        Me.lbldDateToday.TabIndex = 13
        Me.lbldDateToday.Text = "Date Today:"
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentTime.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.Location = New System.Drawing.Point(388, 11)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(80, 25)
        Me.lblCurrentTime.TabIndex = 12
        Me.lblCurrentTime.Text = "8:54 AM"
        '
        'lbldCurrentTime
        '
        Me.lbldCurrentTime.AutoSize = True
        Me.lbldCurrentTime.BackColor = System.Drawing.Color.Transparent
        Me.lbldCurrentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldCurrentTime.ForeColor = System.Drawing.Color.Silver
        Me.lbldCurrentTime.Location = New System.Drawing.Point(304, 16)
        Me.lbldCurrentTime.Name = "lbldCurrentTime"
        Me.lbldCurrentTime.Size = New System.Drawing.Size(81, 15)
        Me.lbldCurrentTime.TabIndex = 11
        Me.lbldCurrentTime.Text = "Current Time:"
        '
        'lblGreetings
        '
        Me.lblGreetings.BackColor = System.Drawing.Color.Transparent
        Me.lblGreetings.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreetings.Location = New System.Drawing.Point(0, 256)
        Me.lblGreetings.Name = "lblGreetings"
        Me.lblGreetings.Size = New System.Drawing.Size(486, 32)
        Me.lblGreetings.TabIndex = 36
        Me.lblGreetings.Text = "Good afternoon, John Doe"
        Me.lblGreetings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(0, 288)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(486, 17)
        Me.lblStatus.TabIndex = 37
        Me.lblStatus.Text = "You are currently clocked out"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClockIn
        '
        Me.btnClockIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnClockIn.FlatAppearance.BorderSize = 0
        Me.btnClockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClockIn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClockIn.ForeColor = System.Drawing.Color.White
        Me.btnClockIn.Location = New System.Drawing.Point(118, 329)
        Me.btnClockIn.Name = "btnClockIn"
        Me.btnClockIn.Size = New System.Drawing.Size(250, 90)
        Me.btnClockIn.TabIndex = 38
        Me.btnClockIn.Text = "CLOCK IN"
        Me.btnClockIn.UseVisualStyleBackColor = False
        '
        'btnClockOut
        '
        Me.btnClockOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnClockOut.Enabled = False
        Me.btnClockOut.FlatAppearance.BorderSize = 0
        Me.btnClockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClockOut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClockOut.ForeColor = System.Drawing.Color.Black
        Me.btnClockOut.Location = New System.Drawing.Point(118, 425)
        Me.btnClockOut.Name = "btnClockOut"
        Me.btnClockOut.Size = New System.Drawing.Size(250, 60)
        Me.btnClockOut.TabIndex = 39
        Me.btnClockOut.Text = "CLOCK OUT"
        Me.btnClockOut.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(118, 557)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(250, 40)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'tmrCurrentTime
        '
        Me.tmrCurrentTime.Interval = 1000
        '
        'btnBreak
        '
        Me.btnBreak.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnBreak.Enabled = False
        Me.btnBreak.FlatAppearance.BorderSize = 0
        Me.btnBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBreak.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBreak.ForeColor = System.Drawing.Color.Black
        Me.btnBreak.Location = New System.Drawing.Point(118, 491)
        Me.btnBreak.Name = "btnBreak"
        Me.btnBreak.Size = New System.Drawing.Size(250, 40)
        Me.btnBreak.TabIndex = 41
        Me.btnBreak.Text = "BREAK"
        Me.btnBreak.UseVisualStyleBackColor = False
        '
        'frmTimeInOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TimeClock_Project.My.Resources.Resources.frmpasscodebg
        Me.ClientSize = New System.Drawing.Size(484, 661)
        Me.Controls.Add(Me.btnBreak)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClockOut)
        Me.Controls.Add(Me.btnClockIn)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblGreetings)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbUserImage)
        Me.Controls.Add(Me.pnlAppbar)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTimeInOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Clock Software"
        Me.pnlAppbar.ResumeLayout(False)
        Me.pnlAppbar.PerformLayout()
        CType(Me.pbUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAppbar As Panel
    Friend WithEvents lblAppTitle As Label
    Friend WithEvents lblAppName As Label
    Friend WithEvents pbUserImage As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbldCurrentTime As Label
    Friend WithEvents lblCurrentTime As Label
    Friend WithEvents lblDateToday As Label
    Friend WithEvents lbldDateToday As Label
    Friend WithEvents lblGreetings As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnClockIn As Button
    Friend WithEvents btnClockOut As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tmrCurrentTime As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents btnBreak As Button
End Class
