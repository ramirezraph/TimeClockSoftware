Public Class frmReportAttendance

    Dim searchAtten As DateTime
    Private Const DateFormat As String = "{0:MM\/dd\/yyyy}"

    Public Sub New(dateatten As DateTime)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        searchAtten = dateatten

    End Sub

    Private Sub frmReportAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datesearch As String = String.Format(DateFormat, searchAtten)
        crvAttendance.ReportSource = Application.StartupPath + "\CrystalReportAttendance.rpt"
        crvAttendance.SelectionFormula = "{tblAttendance.Date} = DateTime('" & datesearch & "')"
        crvAttendance.Refresh()
        crvAttendance.RefreshReport()
    End Sub
End Class