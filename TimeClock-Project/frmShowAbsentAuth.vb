Public Class frmShowAbsentAuth

    Private Access As New DatabaseControl

    Dim ID As Integer
    Dim DAY As String
    Dim DATEABSENT As String
    Public Sub New(userid As Integer, dayofweek As String, absentdate As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ID = userid
        DAY = dayofweek
        DATEABSENT = absentdate
    End Sub

    Private Sub btnCommitAbsent_Click(sender As Object, e As EventArgs) Handles btnCommitAbsent.Click
        Dim password As String = txtPassword.Text
        If password = "" Then
            frmAdministrator.DisplayToastMessage("Please type the password.", 2)
        Else
            Access.AddParam("id", ID)
            Access.ExecuteQuery("SELECT * FROM tblAccount WHERE [userlevel]='Administrator' AND [ID]=@id")
            If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
            For Each R As DataRow In Access.DbDataTable.Rows
                If password = R("password") And R("userlevel") = "Administrator" Then
                    ' success
                    GetAbsentees()
                    txtPassword.Text = ""
                    Exit Sub
                End If
            Next

            ' failed
            frmAdministrator.DisplayToastMessage("Invalid credential. Try again.", 2)
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub GetAbsentees()
        Access.AddParam("dayofweek", DAY)
        Access.AddParam("id", ID)
        Access.ExecuteQuery("SELECT * FROM tblTimeCard WHERE [Day]=@dayofweek")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        For Each R As DataRow In Access.DbDataTable.Rows
            Access.AddParam("passcode", R("Passcode"))
            Access.AddParam("date", DATEABSENT)
            Access.ExecuteQuery("SELECT * FROM tblAttendance WHERE [Passcode]=@passcode AND [Date]=@date")
            If Access.DbDataTable.Rows.Count = 0 Then ' employee not in tbl attendance means absent
                'MessageBox.Show(R("Passcode") & " is absent at this day.")
                Dim empname As String = R("FirstName") & " " & R("LastName")
                Access.AddParam("date", DATEABSENT)
                Access.AddParam("passcode", R("Passcode"))
                Access.AddParam("name", empname)
                Access.AddParam("absent", "ABSENT")
                Access.ExecuteQuery("INSERT INTO tblAttendance ([Date],[Passcode],[EmployeeName],[TotalHour],[Notes]) " &
                            "VALUES (@date,@passcode,@name,@absent,@absent)")
                If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
            End If
        Next
        frmAdministrator.RefreshAttendanceTable(DATEABSENT)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtPassword.Text = ""
        Me.Close()
    End Sub
End Class