<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginAdmin
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
        Me.components = New System.ComponentModel.Container()
        Me.imgAdmin = New System.Windows.Forms.Panel()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPlease = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.btnBackToEmpLogin = New System.Windows.Forms.Label()
        Me.pnlAppbar = New System.Windows.Forms.Panel()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.btnCloseApp = New System.Windows.Forms.Label()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.tmrMessage = New System.Windows.Forms.Timer(Me.components)
        Me.pnlAppbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgAdmin
        '
        Me.imgAdmin.BackgroundImage = Global.TimeClock_Project.My.Resources.Resources.admin_icon
        Me.imgAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgAdmin.Location = New System.Drawing.Point(49, 116)
        Me.imgAdmin.Name = "imgAdmin"
        Me.imgAdmin.Size = New System.Drawing.Size(130, 130)
        Me.imgAdmin.TabIndex = 42
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Maroon
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(-3, 337)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(480, 21)
        Me.lblMessage.TabIndex = 41
        Me.lblMessage.Text = "Sample message here."
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessage.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(224, 261)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(125, 32)
        Me.btnLogin.TabIndex = 40
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(209, 220)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(177, 18)
        Me.txtPassword.TabIndex = 39
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(206, 200)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 17)
        Me.lblPassword.TabIndex = 38
        Me.lblPassword.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(209, 166)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(177, 18)
        Me.txtUsername.TabIndex = 37
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(206, 146)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(70, 17)
        Me.lblUsername.TabIndex = 36
        Me.lblUsername.Text = "Username:"
        '
        'lblPlease
        '
        Me.lblPlease.AutoSize = True
        Me.lblPlease.BackColor = System.Drawing.Color.Transparent
        Me.lblPlease.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlease.Location = New System.Drawing.Point(206, 116)
        Me.lblPlease.Name = "lblPlease"
        Me.lblPlease.Size = New System.Drawing.Size(169, 17)
        Me.lblPlease.TabIndex = 35
        Me.lblPlease.Text = "Please sign in to continue ..."
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblAdmin.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(55, 260)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(123, 20)
        Me.lblAdmin.TabIndex = 34
        Me.lblAdmin.Text = "ADMINISTRATOR"
        '
        'btnBackToEmpLogin
        '
        Me.btnBackToEmpLogin.AutoSize = True
        Me.btnBackToEmpLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnBackToEmpLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToEmpLogin.Location = New System.Drawing.Point(14, 55)
        Me.btnBackToEmpLogin.Name = "btnBackToEmpLogin"
        Me.btnBackToEmpLogin.Size = New System.Drawing.Size(164, 17)
        Me.btnBackToEmpLogin.TabIndex = 33
        Me.btnBackToEmpLogin.Text = "⬅ Back to Employee Login"
        '
        'pnlAppbar
        '
        Me.pnlAppbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlAppbar.Controls.Add(Me.lblAppTitle)
        Me.pnlAppbar.Controls.Add(Me.btnCloseApp)
        Me.pnlAppbar.Controls.Add(Me.lblAppName)
        Me.pnlAppbar.Location = New System.Drawing.Point(-1, -3)
        Me.pnlAppbar.Name = "pnlAppbar"
        Me.pnlAppbar.Size = New System.Drawing.Size(477, 46)
        Me.pnlAppbar.TabIndex = 32
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
        'btnCloseApp
        '
        Me.btnCloseApp.AutoSize = True
        Me.btnCloseApp.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseApp.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.btnCloseApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCloseApp.Location = New System.Drawing.Point(439, 12)
        Me.btnCloseApp.Name = "btnCloseApp"
        Me.btnCloseApp.Size = New System.Drawing.Size(23, 26)
        Me.btnCloseApp.TabIndex = 7
        Me.btnCloseApp.Text = "X"
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
        'tmrMessage
        '
        Me.tmrMessage.Interval = 3000
        '
        'frmLoginAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(476, 357)
        Me.Controls.Add(Me.imgAdmin)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblPlease)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.btnBackToEmpLogin)
        Me.Controls.Add(Me.pnlAppbar)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoginAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLoginAdmin"
        Me.pnlAppbar.ResumeLayout(False)
        Me.pnlAppbar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgAdmin As Panel
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPlease As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents btnBackToEmpLogin As Label
    Friend WithEvents pnlAppbar As Panel
    Friend WithEvents lblAppTitle As Label
    Friend WithEvents btnCloseApp As Label
    Friend WithEvents lblAppName As Label
    Friend WithEvents tmrMessage As Timer
End Class
