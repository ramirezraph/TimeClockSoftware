<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportAttendance
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
        Me.crvAttendance = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvAttendance
        '
        Me.crvAttendance.ActiveViewIndex = -1
        Me.crvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvAttendance.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvAttendance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvAttendance.Location = New System.Drawing.Point(0, 0)
        Me.crvAttendance.Name = "crvAttendance"
        Me.crvAttendance.Size = New System.Drawing.Size(984, 661)
        Me.crvAttendance.TabIndex = 1
        Me.crvAttendance.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReportAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.crvAttendance)
        Me.Name = "frmReportAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvAttendance As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
