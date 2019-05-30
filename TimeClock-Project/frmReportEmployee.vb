Public Class frmReportEmployee

    Private Sub frmReportEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'crvEmployee.ReportSource = Application.StartupPath + "\CrystalReportEmployee.rpt"
        crvEmployee.ReportSource = crvEmployee.ReportSource = "C:\\Program Files\RRDev\TimeClock-Celltech\CrystalReportEmployee.rpt"
        crvEmployee.Refresh()
        crvEmployee.RefreshReport()
    End Sub
End Class