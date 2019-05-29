<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportEmployee
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
        Me.crvEmployee = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvEmployee
        '
        Me.crvEmployee.ActiveViewIndex = -1
        Me.crvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvEmployee.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvEmployee.Location = New System.Drawing.Point(0, 0)
        Me.crvEmployee.Name = "crvEmployee"
        Me.crvEmployee.Size = New System.Drawing.Size(984, 661)
        Me.crvEmployee.TabIndex = 0
        Me.crvEmployee.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReportEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.crvEmployee)
        Me.Name = "frmReportEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvEmployee As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
