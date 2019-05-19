Public Class frmTimeInOut

    ' IMPORTANT
    Private Access As New DatabaseControl
    Private Const ClockInOutDateFormat As String = "{0:MM\/dd\/yyyy}"

    Dim EMP_PASSCODE As String
    Dim EMP_NAME As String
    Dim EMP_STATUS As String
    Dim EMP_POSITION As String
    Private Const DateFormat As String = "{0:dd MMM}"
    Dim timer As Integer = 15

    Public Sub New(name As String, status As String, position As String, passcode As String)

        ' This call is required by the designer.
        InitializeComponent()

        EMP_NAME = name
        EMP_STATUS = status
        EMP_POSITION = position
        EMP_PASSCODE = passcode
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        timer = 15
        tmrCurrentTime.Stop()

        Me.Hide()
        frmPasscode.Show()
    End Sub

    Private Sub frmTimeInOut_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        timer = 15
        tmrCurrentTime.Start()
        If Not String.IsNullOrEmpty(EMP_NAME) And Not String.IsNullOrEmpty(EMP_STATUS) Then
            If TimeOfDay.ToString("tt") = "AM" Then
                lblGreetings.Text = "Good morning, " & EMP_NAME
            Else
                lblGreetings.Text = "Good afternoon, " & EMP_NAME
            End If
            If EMP_STATUS.ToLower = "break" Then
                lblStatus.Text = "You are currently on " & EMP_STATUS.ToLower & "."
            Else
                lblStatus.Text = "You are currently clocked " & EMP_STATUS.ToLower & "."
            End If
            RefreshCurrentDateTime()

            If EMP_STATUS.ToLower = "in" Then
                btnClockIn.Enabled = False
                btnClockIn.BackColor = Color.FromArgb(241, 241, 241)
                btnClockIn.ForeColor = Color.Black

                btnClockOut.Enabled = True
                btnClockOut.BackColor = Color.FromArgb(56, 89, 225)
                btnClockOut.ForeColor = Color.White

                btnBreak.Enabled = True
                btnBreak.BackColor = Color.FromArgb(56, 89, 225)
                btnBreak.ForeColor = Color.White
                btnBreak.Text = "Clock Out - Start Break"
            ElseIf EMP_STATUS.ToLower = "out" Then
                btnClockIn.Enabled = True
                btnClockIn.BackColor = Color.FromArgb(56, 89, 225)
                btnClockIn.ForeColor = Color.White

                btnClockOut.Enabled = False
                btnClockOut.BackColor = Color.FromArgb(241, 241, 241)
                btnClockOut.ForeColor = Color.Black

                btnBreak.Enabled = False
                btnClockOut.BackColor = Color.FromArgb(241, 241, 241)
                btnClockOut.ForeColor = Color.Black
            ElseIf EMP_STATUS.ToLower = "break" Then
                btnClockIn.Enabled = False
                btnClockIn.BackColor = Color.FromArgb(241, 241, 241)
                btnClockIn.ForeColor = Color.Black

                btnClockOut.Enabled = False
                btnClockOut.BackColor = Color.FromArgb(241, 241, 241)
                btnClockOut.ForeColor = Color.Black

                btnBreak.Enabled = True
                btnBreak.BackColor = Color.FromArgb(56, 89, 225)
                btnBreak.ForeColor = Color.White
                btnBreak.Text = "Clock Out - End Break"
            End If

        End If
    End Sub

    Private Sub tmrCurrentTime_Tick(sender As Object, e As EventArgs) Handles tmrCurrentTime.Tick
        RefreshCurrentDateTime()
        timer -= 1
        lblTimer.Text = timer
        If timer <= 3 Then
            lblTimer.ForeColor = Color.FromArgb(246, 80, 80)
        Else
            lblTimer.ForeColor = Color.White
        End If
        If timer = 0 Then
            tmrCurrentTime.Stop()
            timer = 15
            Me.Hide()
            frmPasscode.Show()
        End If
    End Sub



    Private Sub RefreshCurrentDateTime()
        Dim todaysdate As String = String.Format(DateFormat, Date.Now)
        lblCurrentTime.Text = TimeOfDay.ToString("h:mm tt")
        Dim dayofweek As Integer = DateTime.Now.DayOfWeek
        If dayofweek = 0 Then
            lblDateToday.Text = "Sunday, " & todaysdate
        ElseIf dayofweek = 1 Then
            lblDateToday.Text = "Monday, " & todaysdate
        ElseIf dayofweek = 2 Then
            lblDateToday.Text = "Tuesday, " & todaysdate
        ElseIf dayofweek = 3 Then
            lblDateToday.Text = "Wednesday, " & todaysdate
        ElseIf dayofweek = 4 Then
            lblDateToday.Text = "Thursday, " & todaysdate
        ElseIf dayofweek = 5 Then
            lblDateToday.Text = "Friday, " & todaysdate
        ElseIf dayofweek = 6 Then
            lblDateToday.Text = "Saturday, " & todaysdate
        End If
        tmrCurrentTime.Start()
    End Sub

    Private Sub btnClockIn_Click(sender As Object, e As EventArgs) Handles btnClockIn.Click
        ' Check Schedule

        ' DATA: date, passcode, empname, position, in, out, lunchin, lunchout, hours, overtime, notes
        Dim todaysdate As String = String.Format(ClockInOutDateFormat, Date.Now)
        Access.AddParam("@date", todaysdate)
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.AddParam("@name", EMP_NAME)
        Access.AddParam("@position", EMP_POSITION)
        Access.AddParam("@in", lblCurrentTime.Text)
        Access.ExecuteQuery("INSERT INTO tblAttendance ([Date],[Passcode],[EmployeeName],[Position],[In]) " &
                            "VALUES (@date,@passcode,@name,@position,@in)")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        UpdateEmployeeStatus("In", EMP_PASSCODE)

        MessageBox.Show("Clocked in successfully.")
        Me.Hide()
        frmPasscode.Show()

    End Sub

    Private Sub btnClockOut_Click(sender As Object, e As EventArgs) Handles btnClockOut.Click

        Dim todaysdate As String = String.Format(ClockInOutDateFormat, Date.Now)
        Dim strclockin As String = ""

        ' GET CLOCK IN TIME
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.AddParam("@date", todaysdate)
        Access.ExecuteQuery("SELECT * FROM tblAttendance WHERE [Passcode]=@passcode AND [Date]=@date")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        For Each R As DataRow In Access.DbDataTable.Rows
            Try
                strclockin = R("In")
            Catch ex As Exception
                MessageBox.Show("An error occured. HINT: Null values")
                Exit Sub
            End Try
        Next

        ' CALCULATE
        Dim clockout As DateTime
        Dim clockin As DateTime
        Dim totalHour As TimeSpan
        clockin = New DateTime
        clockout = New DateTime
        clockin = Convert.ToDateTime(strclockin)
        clockout = Convert.ToDateTime(lblCurrentTime.Text)
        totalHour = clockout.Subtract(clockin)

        ' REGISTER OUT
        Access.AddParam("@totalhour", totalHour.ToString)
        Access.AddParam("@out", lblCurrentTime.Text)
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.AddParam("@date", todaysdate)
        Access.ExecuteQuery("UPDATE tblAttendance SET [TotalHour]=@totalhour,[Out]=@out" &
            " WHERE [Passcode]=@passcode AND [Date]=@date")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

        ' UPDATE STATUS
        UpdateEmployeeStatus("Out", EMP_PASSCODE)

        MessageBox.Show("Clocked out successfully.")
        Me.Hide()
        frmPasscode.Show()

    End Sub

    Private Sub UpdateEmployeeStatus(status As String, passcode As String)
        Access.AddParam("@status", status)
        Access.AddParam("@passcode", passcode)
        Access.ExecuteQuery("UPDATE tblEmployee SET [Status]=@status" &
            " WHERE [Passcode] = @passcode")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
    End Sub

    Private Sub btnBreak_Click(sender As Object, e As EventArgs) Handles btnBreak.Click
        Dim addedbreak As Integer = 0
        Dim totalBreak As Integer = 0
        Dim todaysdate As String = String.Format(ClockInOutDateFormat, Date.Now)
        Dim oldbreaktotal As TimeSpan

        If btnBreak.Text = "Clock Out - Start Break" Then
            ' UPDATE ATTENDANCE - BreakOut
            Access.AddParam("@breakout", lblCurrentTime.Text)
            Access.AddParam("@passcode", EMP_PASSCODE)
            Access.AddParam("@date", todaysdate)
            Access.ExecuteQuery("UPDATE tblAttendance SET [BreakOut]=@breakout" &
                " WHERE [Passcode]=@passcode AND [Date]=@date")
            If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
            MessageBox.Show("Break started successfully.")
            ' UPDATE STATUS - break
            UpdateEmployeeStatus("break", EMP_PASSCODE)
        ElseIf btnBreak.Text = "Clock Out - End Break" Then
            Dim strstartbreak As String = ""
            ' GET CLOCK IN TIME
            Access.AddParam("@passcode", EMP_PASSCODE)
            Access.AddParam("@date", todaysdate)
            Access.ExecuteQuery("SELECT * FROM tblAttendance WHERE [Passcode]=@passcode AND [Date]=@date")
            If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
            For Each R As DataRow In Access.DbDataTable.Rows
                Try
                    strstartbreak = R("BreakOut")
                    oldbreaktotal = R("TotalBreak")
                Catch ex As Exception
                    oldbreaktotal = TimeSpan.Zero
                End Try
            Next

            ' CALCULATE TotalBreak
            Dim startbreak As DateTime
            Dim endbreak As DateTime
            Dim totalBreakTotal As TimeSpan
            Dim newBreakTotal As TimeSpan

            startbreak = New DateTime
            endbreak = New DateTime
            startbreak = Convert.ToDateTime(strstartbreak)
            endbreak = Convert.ToDateTime(lblCurrentTime.Text)
            totalBreakTotal = endbreak.Subtract(startbreak)

            newBreakTotal = totalBreakTotal.Add(oldbreaktotal)

            ' UPDATE ATTENDANCE - BreakIn
            Access.AddParam("@breakin", lblCurrentTime.Text)
            Access.AddParam("@totalbreak", newBreakTotal.ToString)
            Access.AddParam("@passcode", EMP_PASSCODE)
            Access.AddParam("@date", todaysdate)
            Access.ExecuteQuery("UPDATE tblAttendance SET [BreakOut]=@breakin, [TotalBreak]=@totalbreak, [BreakIn]='0:00:00 AM'" &
                " WHERE [Passcode]=@passcode AND [Date]=@date")
            If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

            ' RESET ATTENDACE - BreakIn/Out
            Access.AddParam("@passcode", EMP_PASSCODE)
            Access.AddParam("@date", todaysdate)
            Access.ExecuteQuery("UPDATE tblAttendance SET [BreakOut]='0:00:00 AM', [BreakIn]='0:00:00 AM'" &
                " WHERE [Passcode]=@passcode AND [Date]=@date")
            If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

            ' UPDATE STATUS - break
            UpdateEmployeeStatus("In", EMP_PASSCODE)

            MessageBox.Show("Break ended successfuly.")
        End If
    End Sub
End Class