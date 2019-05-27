<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasscode
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
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.btnCloseApp = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblAMPM = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtFirstNum = New System.Windows.Forms.TextBox()
        Me.pnl1Indic = New System.Windows.Forms.Panel()
        Me.pnl2Indic = New System.Windows.Forms.Panel()
        Me.txtSecondNum = New System.Windows.Forms.TextBox()
        Me.pnl3Indic = New System.Windows.Forms.Panel()
        Me.txtThirdNum = New System.Windows.Forms.TextBox()
        Me.pnl4Indic = New System.Windows.Forms.Panel()
        Me.txtFourthNum = New System.Windows.Forms.TextBox()
        Me.btnLoginAdmin = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btnDeletePasscode = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnClearPasscode = New System.Windows.Forms.Button()
        Me.tmrPasscode = New System.Windows.Forms.Timer(Me.components)
        Me.lblPasscodeNotFound = New System.Windows.Forms.Label()
        Me.tmrMessage = New System.Windows.Forms.Timer(Me.components)
        Me.imgEmployeeIcon = New System.Windows.Forms.Panel()
        Me.tmrCurrentTime = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.BackColor = System.Drawing.Color.Transparent
        Me.lblAppName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.Location = New System.Drawing.Point(12, 4)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(157, 40)
        Me.lblAppName.TabIndex = 0
        Me.lblAppName.Text = "Celltech"
        '
        'lblAppTitle
        '
        Me.lblAppTitle.AutoSize = True
        Me.lblAppTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblAppTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppTitle.Location = New System.Drawing.Point(21, 42)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(116, 15)
        Me.lblAppTitle.TabIndex = 1
        Me.lblAppTitle.Text = "Time Clock Software"
        '
        'btnCloseApp
        '
        Me.btnCloseApp.AutoSize = True
        Me.btnCloseApp.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseApp.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.btnCloseApp.Location = New System.Drawing.Point(450, 4)
        Me.btnCloseApp.Name = "btnCloseApp"
        Me.btnCloseApp.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btnCloseApp.Size = New System.Drawing.Size(32, 30)
        Me.btnCloseApp.TabIndex = 2
        Me.btnCloseApp.Text = "X"
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(172, 84)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(201, 86)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "10:54"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAMPM
        '
        Me.lblAMPM.AutoSize = True
        Me.lblAMPM.BackColor = System.Drawing.Color.Transparent
        Me.lblAMPM.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAMPM.Location = New System.Drawing.Point(345, 101)
        Me.lblAMPM.Name = "lblAMPM"
        Me.lblAMPM.Size = New System.Drawing.Size(58, 37)
        Me.lblAMPM.TabIndex = 4
        Me.lblAMPM.Text = "AM"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(187, 161)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(186, 21)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "December 12, 2019"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFirstNum
        '
        Me.txtFirstNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txtFirstNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstNum.Enabled = False
        Me.txtFirstNum.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstNum.ForeColor = System.Drawing.SystemColors.Info
        Me.txtFirstNum.Location = New System.Drawing.Point(84, 223)
        Me.txtFirstNum.Multiline = True
        Me.txtFirstNum.Name = "txtFirstNum"
        Me.txtFirstNum.Size = New System.Drawing.Size(73, 69)
        Me.txtFirstNum.TabIndex = 6
        Me.txtFirstNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnl1Indic
        '
        Me.pnl1Indic.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnl1Indic.Location = New System.Drawing.Point(84, 292)
        Me.pnl1Indic.Name = "pnl1Indic"
        Me.pnl1Indic.Size = New System.Drawing.Size(73, 6)
        Me.pnl1Indic.TabIndex = 10
        '
        'pnl2Indic
        '
        Me.pnl2Indic.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnl2Indic.Location = New System.Drawing.Point(163, 292)
        Me.pnl2Indic.Name = "pnl2Indic"
        Me.pnl2Indic.Size = New System.Drawing.Size(73, 6)
        Me.pnl2Indic.TabIndex = 12
        '
        'txtSecondNum
        '
        Me.txtSecondNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txtSecondNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSecondNum.Enabled = False
        Me.txtSecondNum.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecondNum.ForeColor = System.Drawing.SystemColors.Info
        Me.txtSecondNum.Location = New System.Drawing.Point(163, 223)
        Me.txtSecondNum.Multiline = True
        Me.txtSecondNum.Name = "txtSecondNum"
        Me.txtSecondNum.Size = New System.Drawing.Size(73, 69)
        Me.txtSecondNum.TabIndex = 11
        Me.txtSecondNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnl3Indic
        '
        Me.pnl3Indic.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnl3Indic.Location = New System.Drawing.Point(242, 292)
        Me.pnl3Indic.Name = "pnl3Indic"
        Me.pnl3Indic.Size = New System.Drawing.Size(73, 6)
        Me.pnl3Indic.TabIndex = 14
        '
        'txtThirdNum
        '
        Me.txtThirdNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txtThirdNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtThirdNum.Enabled = False
        Me.txtThirdNum.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThirdNum.ForeColor = System.Drawing.SystemColors.Info
        Me.txtThirdNum.Location = New System.Drawing.Point(242, 223)
        Me.txtThirdNum.Multiline = True
        Me.txtThirdNum.Name = "txtThirdNum"
        Me.txtThirdNum.Size = New System.Drawing.Size(73, 69)
        Me.txtThirdNum.TabIndex = 13
        Me.txtThirdNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnl4Indic
        '
        Me.pnl4Indic.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnl4Indic.Location = New System.Drawing.Point(321, 292)
        Me.pnl4Indic.Name = "pnl4Indic"
        Me.pnl4Indic.Size = New System.Drawing.Size(73, 6)
        Me.pnl4Indic.TabIndex = 16
        '
        'txtFourthNum
        '
        Me.txtFourthNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txtFourthNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFourthNum.Enabled = False
        Me.txtFourthNum.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFourthNum.ForeColor = System.Drawing.SystemColors.Info
        Me.txtFourthNum.Location = New System.Drawing.Point(321, 223)
        Me.txtFourthNum.Multiline = True
        Me.txtFourthNum.Name = "txtFourthNum"
        Me.txtFourthNum.Size = New System.Drawing.Size(73, 69)
        Me.txtFourthNum.TabIndex = 15
        Me.txtFourthNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLoginAdmin
        '
        Me.btnLoginAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginAdmin.Font = New System.Drawing.Font("Segoe UI", 7.75!)
        Me.btnLoginAdmin.Location = New System.Drawing.Point(340, 8)
        Me.btnLoginAdmin.Name = "btnLoginAdmin"
        Me.btnLoginAdmin.Size = New System.Drawing.Size(75, 23)
        Me.btnLoginAdmin.TabIndex = 17
        Me.btnLoginAdmin.Text = "ADMIN"
        Me.btnLoginAdmin.UseVisualStyleBackColor = False
        Me.btnLoginAdmin.Visible = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.SystemColors.Control
        Me.btn1.Location = New System.Drawing.Point(87, 330)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(98, 58)
        Me.btn1.TabIndex = 18
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn2.FlatAppearance.BorderSize = 0
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.SystemColors.Control
        Me.btn2.Location = New System.Drawing.Point(191, 330)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(98, 58)
        Me.btn2.TabIndex = 19
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn3.FlatAppearance.BorderSize = 0
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.SystemColors.Control
        Me.btn3.Location = New System.Drawing.Point(295, 330)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(98, 58)
        Me.btn3.TabIndex = 20
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn6.FlatAppearance.BorderSize = 0
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.SystemColors.Control
        Me.btn6.Location = New System.Drawing.Point(295, 394)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(98, 58)
        Me.btn6.TabIndex = 23
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn5.FlatAppearance.BorderSize = 0
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.SystemColors.Control
        Me.btn5.Location = New System.Drawing.Point(191, 394)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(98, 58)
        Me.btn5.TabIndex = 22
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn4.FlatAppearance.BorderSize = 0
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.SystemColors.Control
        Me.btn4.Location = New System.Drawing.Point(87, 394)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(98, 58)
        Me.btn4.TabIndex = 21
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn9.FlatAppearance.BorderSize = 0
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.SystemColors.Control
        Me.btn9.Location = New System.Drawing.Point(295, 458)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(98, 58)
        Me.btn9.TabIndex = 26
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn8.FlatAppearance.BorderSize = 0
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.SystemColors.Control
        Me.btn8.Location = New System.Drawing.Point(191, 458)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(98, 58)
        Me.btn8.TabIndex = 25
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn7.FlatAppearance.BorderSize = 0
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.SystemColors.Control
        Me.btn7.Location = New System.Drawing.Point(87, 458)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(98, 58)
        Me.btn7.TabIndex = 24
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btnDeletePasscode
        '
        Me.btnDeletePasscode.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnDeletePasscode.FlatAppearance.BorderSize = 0
        Me.btnDeletePasscode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePasscode.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePasscode.ForeColor = System.Drawing.Color.Crimson
        Me.btnDeletePasscode.Location = New System.Drawing.Point(295, 522)
        Me.btnDeletePasscode.Name = "btnDeletePasscode"
        Me.btnDeletePasscode.Size = New System.Drawing.Size(98, 58)
        Me.btnDeletePasscode.TabIndex = 29
        Me.btnDeletePasscode.Text = "X"
        Me.btnDeletePasscode.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn0.FlatAppearance.BorderSize = 0
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.SystemColors.Control
        Me.btn0.Location = New System.Drawing.Point(191, 522)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(98, 58)
        Me.btn0.TabIndex = 28
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnClearPasscode
        '
        Me.btnClearPasscode.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnClearPasscode.FlatAppearance.BorderSize = 0
        Me.btnClearPasscode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearPasscode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearPasscode.ForeColor = System.Drawing.Color.Gold
        Me.btnClearPasscode.Location = New System.Drawing.Point(87, 522)
        Me.btnClearPasscode.Name = "btnClearPasscode"
        Me.btnClearPasscode.Size = New System.Drawing.Size(98, 58)
        Me.btnClearPasscode.TabIndex = 27
        Me.btnClearPasscode.Text = "CLEAR"
        Me.btnClearPasscode.UseVisualStyleBackColor = False
        '
        'tmrPasscode
        '
        Me.tmrPasscode.Interval = 500
        '
        'lblPasscodeNotFound
        '
        Me.lblPasscodeNotFound.BackColor = System.Drawing.Color.Maroon
        Me.lblPasscodeNotFound.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasscodeNotFound.Location = New System.Drawing.Point(0, 646)
        Me.lblPasscodeNotFound.Name = "lblPasscodeNotFound"
        Me.lblPasscodeNotFound.Size = New System.Drawing.Size(485, 15)
        Me.lblPasscodeNotFound.TabIndex = 30
        Me.lblPasscodeNotFound.Text = "Passcode not found. Try again."
        Me.lblPasscodeNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPasscodeNotFound.Visible = False
        '
        'tmrMessage
        '
        Me.tmrMessage.Interval = 1000
        '
        'imgEmployeeIcon
        '
        Me.imgEmployeeIcon.BackColor = System.Drawing.Color.Transparent
        Me.imgEmployeeIcon.BackgroundImage = Global.TimeClock_Project.My.Resources.Resources.attendanceicon
        Me.imgEmployeeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgEmployeeIcon.Location = New System.Drawing.Point(87, 97)
        Me.imgEmployeeIcon.Name = "imgEmployeeIcon"
        Me.imgEmployeeIcon.Size = New System.Drawing.Size(100, 100)
        Me.imgEmployeeIcon.TabIndex = 31
        '
        'tmrCurrentTime
        '
        Me.tmrCurrentTime.Interval = 1000
        '
        'frmPasscode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.TimeClock_Project.My.Resources.Resources.frmpasscodebg
        Me.ClientSize = New System.Drawing.Size(484, 661)
        Me.Controls.Add(Me.imgEmployeeIcon)
        Me.Controls.Add(Me.lblPasscodeNotFound)
        Me.Controls.Add(Me.btnDeletePasscode)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnClearPasscode)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnLoginAdmin)
        Me.Controls.Add(Me.pnl4Indic)
        Me.Controls.Add(Me.txtFourthNum)
        Me.Controls.Add(Me.pnl3Indic)
        Me.Controls.Add(Me.txtThirdNum)
        Me.Controls.Add(Me.pnl2Indic)
        Me.Controls.Add(Me.txtSecondNum)
        Me.Controls.Add(Me.pnl1Indic)
        Me.Controls.Add(Me.txtFirstNum)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblAMPM)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnCloseApp)
        Me.Controls.Add(Me.lblAppTitle)
        Me.Controls.Add(Me.lblAppName)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPasscode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Clock Software"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAppName As Label
    Friend WithEvents lblAppTitle As Label
    Friend WithEvents btnCloseApp As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblAMPM As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents pnl1Indic As Panel
    Friend WithEvents pnl2Indic As Panel
    Friend WithEvents txtSecondNum As TextBox
    Friend WithEvents pnl3Indic As Panel
    Friend WithEvents txtThirdNum As TextBox
    Friend WithEvents pnl4Indic As Panel
    Friend WithEvents txtFourthNum As TextBox
    Friend WithEvents btnLoginAdmin As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnDeletePasscode As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnClearPasscode As Button
    Friend WithEvents tmrPasscode As Timer
    Friend WithEvents lblPasscodeNotFound As Label
    Friend WithEvents tmrMessage As Timer
    Friend WithEvents imgEmployeeIcon As Panel
    Friend WithEvents tmrCurrentTime As Timer
End Class
