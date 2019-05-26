<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogAccount
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
        Me.lblMyAccount = New System.Windows.Forms.Label()
        Me.pnlTopAccount = New System.Windows.Forms.Panel()
        Me.pbAccountIcon = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cbShowOldPass = New System.Windows.Forms.CheckBox()
        Me.cbShowNewPass = New System.Windows.Forms.CheckBox()
        Me.cbShowConfirmPass = New System.Windows.Forms.CheckBox()
        Me.cbIsChangePass = New System.Windows.Forms.CheckBox()
        Me.pnlTopAccount.SuspendLayout()
        CType(Me.pbAccountIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMyAccount
        '
        Me.lblMyAccount.AutoSize = True
        Me.lblMyAccount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyAccount.Location = New System.Drawing.Point(61, 15)
        Me.lblMyAccount.Name = "lblMyAccount"
        Me.lblMyAccount.Size = New System.Drawing.Size(143, 32)
        Me.lblMyAccount.TabIndex = 49
        Me.lblMyAccount.Text = "My Account"
        '
        'pnlTopAccount
        '
        Me.pnlTopAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlTopAccount.Controls.Add(Me.pbAccountIcon)
        Me.pnlTopAccount.Controls.Add(Me.lblMyAccount)
        Me.pnlTopAccount.Location = New System.Drawing.Point(12, 12)
        Me.pnlTopAccount.Name = "pnlTopAccount"
        Me.pnlTopAccount.Size = New System.Drawing.Size(442, 65)
        Me.pnlTopAccount.TabIndex = 48
        '
        'pbAccountIcon
        '
        Me.pbAccountIcon.Image = Global.TimeClock_Project.My.Resources.Resources.account_icon
        Me.pbAccountIcon.Location = New System.Drawing.Point(18, 12)
        Me.pbAccountIcon.Name = "pbAccountIcon"
        Me.pbAccountIcon.Size = New System.Drawing.Size(40, 40)
        Me.pbAccountIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAccountIcon.TabIndex = 50
        Me.pbAccountIcon.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(150, 180)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(259, 24)
        Me.txtUsername.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Username:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(150, 138)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(259, 24)
        Me.txtName.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Full Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Password:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(147, 227)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(103, 17)
        Me.lblPassword.TabIndex = 57
        Me.lblPassword.Text = "•••••••••••••••••••"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 17)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "- Change Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 17)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "- Account Information:"
        '
        'txtNewPass
        '
        Me.txtNewPass.Enabled = False
        Me.txtNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(193, 360)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewPass.Size = New System.Drawing.Size(205, 24)
        Me.txtNewPass.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "New Password:"
        '
        'txtOldPass
        '
        Me.txtOldPass.Enabled = False
        Me.txtOldPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPass.Location = New System.Drawing.Point(193, 302)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtOldPass.Size = New System.Drawing.Size(205, 24)
        Me.txtOldPass.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 17)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Old Password:"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Enabled = False
        Me.txtConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(193, 416)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmPass.Size = New System.Drawing.Size(205, 24)
        Me.txtConfirmPass.TabIndex = 65
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 418)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 17)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Confirm Password:"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSaveChanges.FlatAppearance.BorderSize = 0
        Me.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveChanges.ForeColor = System.Drawing.Color.White
        Me.btnSaveChanges.Location = New System.Drawing.Point(195, 530)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(158, 37)
        Me.btnSaveChanges.TabIndex = 66
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(359, 530)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(95, 37)
        Me.btnBack.TabIndex = 67
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'cbShowOldPass
        '
        Me.cbShowOldPass.AutoSize = True
        Me.cbShowOldPass.Location = New System.Drawing.Point(193, 332)
        Me.cbShowOldPass.Name = "cbShowOldPass"
        Me.cbShowOldPass.Size = New System.Drawing.Size(107, 17)
        Me.cbShowOldPass.TabIndex = 68
        Me.cbShowOldPass.Text = "Show Password"
        Me.cbShowOldPass.UseVisualStyleBackColor = True
        Me.cbShowOldPass.Visible = False
        '
        'cbShowNewPass
        '
        Me.cbShowNewPass.AutoSize = True
        Me.cbShowNewPass.Location = New System.Drawing.Point(193, 390)
        Me.cbShowNewPass.Name = "cbShowNewPass"
        Me.cbShowNewPass.Size = New System.Drawing.Size(107, 17)
        Me.cbShowNewPass.TabIndex = 69
        Me.cbShowNewPass.Text = "Show Password"
        Me.cbShowNewPass.UseVisualStyleBackColor = True
        Me.cbShowNewPass.Visible = False
        '
        'cbShowConfirmPass
        '
        Me.cbShowConfirmPass.AutoSize = True
        Me.cbShowConfirmPass.Location = New System.Drawing.Point(193, 446)
        Me.cbShowConfirmPass.Name = "cbShowConfirmPass"
        Me.cbShowConfirmPass.Size = New System.Drawing.Size(107, 17)
        Me.cbShowConfirmPass.TabIndex = 70
        Me.cbShowConfirmPass.Text = "Show Password"
        Me.cbShowConfirmPass.UseVisualStyleBackColor = True
        Me.cbShowConfirmPass.Visible = False
        '
        'cbIsChangePass
        '
        Me.cbIsChangePass.AutoSize = True
        Me.cbIsChangePass.ForeColor = System.Drawing.Color.Gold
        Me.cbIsChangePass.Location = New System.Drawing.Point(189, 270)
        Me.cbIsChangePass.Name = "cbIsChangePass"
        Me.cbIsChangePass.Size = New System.Drawing.Size(164, 17)
        Me.cbIsChangePass.TabIndex = 71
        Me.cbIsChangePass.Text = "Check if change password."
        Me.cbIsChangePass.UseVisualStyleBackColor = True
        '
        'frmDialogAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(466, 579)
        Me.Controls.Add(Me.cbIsChangePass)
        Me.Controls.Add(Me.cbShowConfirmPass)
        Me.Controls.Add(Me.cbShowNewPass)
        Me.Controls.Add(Me.cbShowOldPass)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtOldPass)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pnlTopAccount)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDialogAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTopAccount.ResumeLayout(False)
        Me.pnlTopAccount.PerformLayout()
        CType(Me.pbAccountIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMyAccount As Label
    Friend WithEvents pnlTopAccount As Panel
    Friend WithEvents pbAccountIcon As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOldPass As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents cbShowOldPass As CheckBox
    Friend WithEvents cbShowNewPass As CheckBox
    Friend WithEvents cbShowConfirmPass As CheckBox
    Friend WithEvents cbIsChangePass As CheckBox
End Class
