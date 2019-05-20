Public Class frmTimeInOut

    ' IMPORTANT
    Private Access As New DatabaseControl
    Private Const ClockInOutDateFormat As String = "{0:MM\/dd\/yyyy}"
    Private Const ClockInOutTimeFormat As String = "{hh:mm:tt}"

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
        Dim todaysdate As String = String.Format(ClockInOutDateFormat, Date.Now)
        Dim daytoday As String = Date.Now.DayOfWeek.ToString
        ' CHECK SCHEDULE
        Dim todayin As String = ""
        Dim todayout As String = ""
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.AddParam("@day", daytoday)
        Access.ExecuteQuery("SELECT * FROM tblTimeCard WHERE [Passcode]=@passcode AND [Day]=@day")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        If Access.DbDataTable.Rows.Count = 0 Then
            MessageBox.Show("You do not have a schedule for today." & vbCrLf & "NOTE: Please refer to the admin if this is a mistake.")
            Exit Sub
        Else
            For Each R As DataRow In Access.DbDataTable.Rows
                todayin = R("In")
                todayout = R("Out")
                Exit For
            Next
        End If

        ' test value if schedule found
        'MsgBox(todayin)
        'MsgBox(todayout)

        ' CHECK IF SECOND TIME IN
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.AddParam("@date", todaysdate)
        Access.ExecuteQuery("SELECT * FROM tblAttendance WHERE [Passcode]=@passcode AND [Date]=@date")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        If Access.DbDataTable.Rows.Count > 0 Then
            Dim confirm As Integer = MessageBox.Show("You're having a more than 1 time in, please confirm.", "", MessageBoxButtons.YesNo)
            If confirm = DialogResult.Yes Then
                Dim oldtotalhour As TimeSpan
                Dim oldnotes As String = ""
                Dim timein As DateTime
                Dim timeout As DateTime
                Dim pay As String = ""
                For Each R As DataRow In Access.DbDataTable.Rows
                    oldtotalhour = TimeSpan.Parse(R("totalhour"))
                    oldnotes = R("Notes").ToString
                    timein = R("In").ToString
                    timeout = R("Out").ToString
                    pay = R("Pay").ToString
                Next
                Dim newnotes As String = "Time In: " & timein &
                            vbCrLf & "Time Out: " & timeout &
                            vbCrLf & "Hour: " & oldtotalhour.ToString &
                            vbCrLf & "Pay: " & pay.ToString &
                            vbCrLf & "---------------------------------------" &
                            vbCrLf & oldnotes
                Access.AddParam("@in", lblCurrentTime.Text)
                Access.AddParam("@notes", newnotes)
                Access.AddParam("@passcode", EMP_PASSCODE)
                Access.AddParam("@date", todaysdate)
                Access.ExecuteQuery("UPDATE tblAttendance SET [In]=@in,[Notes]=@totalhour WHERE [Passcode]=@passcode AND [Date]=@date")
                If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
                UpdateEmployeeStatus("In", EMP_PASSCODE)

                ' INSERT LOG: passcode, date, employee, time, type
                UpdateLog(EMP_PASSCODE, todaysdate, lblCurrentTime.Text, EMP_NAME, "In")

                MessageBox.Show("Clocked in successfully.")
                timer = 15
                tmrCurrentTime.Stop()
                Me.Hide()
                frmPasscode.Show()
                Exit Sub
            Else
                Exit Sub
            End If
        End If

        ' GET RATE AND SalaryBalance
        Dim Rate As String = ""
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.ExecuteQuery("SELECT * FROM tblEmployee WHERE [Passcode]=@passcode")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        For Each R As DataRow In Access.DbDataTable.Rows
            Try
                If String.IsNullOrEmpty(R("Rate")) Then
                    MessageBox.Show("Hi, your rate is not yet registered. Please refer to the admin.")
                    Exit Sub
                End If
                Rate = R("Rate")
            Catch ex As Exception
                MessageBox.Show("An error occured. HINT: Null values")
                Exit Sub
            End Try
        Next

        ' INSERT ATTENDANCE: date, passcode, empname, position, in, out, lunchin, lunchout, hours, overtime, notes
        Access.AddParam("@date", todaysdate)
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.AddParam("@name", EMP_NAME)
        Access.AddParam("@position", EMP_POSITION)
        Access.AddParam("@in", lblCurrentTime.Text)
        Access.AddParam("@rate", Rate)
        Access.ExecuteQuery("INSERT INTO tblAttendance ([Date],[Passcode],[EmployeeName],[Position],[In],[Rate]) " &
                            "VALUES (@date,@passcode,@name,@position,@in,@rate)")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        UpdateEmployeeStatus("In", EMP_PASSCODE)

        ' CHECK FOR LATE
        GetEmployeeLate()

        ' INSERT LOG: passcode, date, employee, time, type
        UpdateLog(EMP_PASSCODE, todaysdate, lblCurrentTime.Text, EMP_NAME, "In")

        MessageBox.Show("Clocked in successfully.")
        timer = 15
        tmrCurrentTime.Stop()
        Me.Hide()
        frmPasscode.Show()

    End Sub

    Private Sub GetEmployeeLate()
        Dim lategrace As TimeSpan = New TimeSpan(0, 0, 30, 0, 0) ' 30 minutes grace period for lates
        Dim todaysdate As String = String.Format(ClockInOutDateFormat, Date.Now)
        Dim daytoday As String = Date.Now.DayOfWeek.ToString
        ' GET TIME IN SCHEDULE
        'MsgBox(daytoday)
        Dim todayin As String = ""
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.AddParam("@day", daytoday)
        Access.ExecuteQuery("SELECT * FROM tblTimeCard WHERE [Passcode]=@passcode AND [Day]=@day")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        If Access.DbDataTable.Rows.Count = 0 Then
            MessageBox.Show("You do not have a schedule for today." & vbCrLf & "NOTE: Please refer to the admin if this is a mistake.")
            Exit Sub
        Else
            For Each R As DataRow In Access.DbDataTable.Rows
                todayin = R("In")
                Exit For
            Next
        End If

        Dim shouldin As DateTime = Convert.ToDateTime(todayin)
        Dim nowin As DateTime = Convert.ToDateTime(lblCurrentTime.Text)
        Dim schedin As New DateTime(2019, 1, 1, shouldin.Hour, shouldin.Minute, 0)     ' hh:mm:ss tt
        Dim schedin2 As New DateTime(2019, 1, 1, nowin.Hour, nowin.Minute, 0)

        Dim late As TimeSpan = schedin2.Subtract(schedin)
        Dim compare As Integer = TimeSpan.Compare(late, lategrace) ' t1, t2
        'MsgBox(late.ToString) ' check late value
        If compare = 1 Then
            ' 30 minutes and above late
            ' UPDATE Late
            Access.AddParam("@late", late.ToString)
            Access.AddParam("@passcode", EMP_PASSCODE)
            Access.AddParam("@date", todaysdate)
            Access.ExecuteQuery("UPDATE tblAttendance SET [Late]=@late WHERE [Passcode]=@passcode AND [Date]=@date")
            If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show("Late Error") : Exit Sub
        End If
    End Sub

    Private Sub btnClockOut_Click(sender As Object, e As EventArgs) Handles btnClockOut.Click

        Dim todaysdate As String = String.Format(ClockInOutDateFormat, Date.Now)
        Dim strclockin As String = ""
        Dim totalbreak As String = ""
        Dim rate As Double = 0
        Dim pay As Double = 0

        ' CHECK SCHEDULE

        ' GET CLOCK IN TIME AND TOTAL BREAK AND TOTAL HOUR
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.AddParam("@date", todaysdate)
        Access.ExecuteQuery("SELECT * FROM tblAttendance WHERE [Passcode]=@passcode AND [Date]=@date")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        For Each R As DataRow In Access.DbDataTable.Rows
            Try
                rate = R("Rate")
                strclockin = R("In")
                If String.IsNullOrEmpty(R("TotalBreak").ToString) Then
                    totalbreak = "00:00:00"
                Else
                    totalbreak = R("TotalBreak").ToString
                End If
            Catch ex As Exception
                MessageBox.Show("An error occured. HINT: Null values")
                Exit Sub
            End Try
        Next

        ' CALCULATE
        Dim clockout As DateTime
        Dim clockin As DateTime
        Dim hour As TimeSpan
        Dim totalhour As TimeSpan
        clockin = New DateTime
        clockout = New DateTime
        clockin = Convert.ToDateTime(strclockin)
        clockout = Convert.ToDateTime(lblCurrentTime.Text)
        hour = clockout.Subtract(clockin)
        totalhour = hour.Subtract(TimeSpan.Parse(totalbreak))
        pay = Decimal.Round(rate * totalhour.TotalHours, 2, MidpointRounding.AwayFromZero)
        ' Check values
        'MessageBox.Show(hour.ToString & " : " & totalbreak & " = " & totalhour.ToString)

        ' REGISTER OUT
        Access.AddParam("@totalhour", totalhour.ToString)
        Access.AddParam("@out", lblCurrentTime.Text)
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.AddParam("@date", todaysdate)
        Access.AddParam("@pay", pay)
        Access.ExecuteQuery("UPDATE tblAttendance SET [TotalHour]=@totalhour,[Out]=@out,[Pay]='" & pay & "'" &
            " WHERE [Passcode]=@passcode AND [Date]=@date")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

        ' UPDATE SALARY BALANCE
        UpdateSalaryBalance(EMP_PASSCODE, pay)

        ' UPDATE STATUS
        UpdateEmployeeStatus("Out", EMP_PASSCODE)

        ' INSERT LOG: passcode, date, employee, time, type
        UpdateLog(EMP_PASSCODE, todaysdate, lblCurrentTime.Text, EMP_NAME, "Out")

        ' LATE DEDUCTIONS
        SubmitLateDeduction(rate, todaysdate, pay)

        MessageBox.Show("Clocked out successfully.")
        timer = 15
        tmrCurrentTime.Stop()
        Me.Hide()
        frmPasscode.Show()
    End Sub

    Private Sub SubmitLateDeduction(rate As Double, todaysdate As String, paybeforededuction As Double)
        Dim timelate As TimeSpan
        Dim deduction As Double
        Dim deductedpay As Double
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.AddParam("@date", todaysdate)
        Access.ExecuteQuery("SELECT * FROM tblAttendance WHERE [Passcode]=@passcode AND [Date]=@date")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        For Each R As DataRow In Access.DbDataTable.Rows
            Try
                If R("Late") = "" Then
                    timelate = Nothing
                Else
                    timelate = TimeSpan.Parse(R("Late"))
                End If
            Catch ex As Exception

            End Try
        Next
        deduction = (rate / 60) * timelate.TotalMinutes
        'MessageBox.Show(deduction)
        'MessageBox.Show(timelate.TotalMinutes)

        ' DEDUCT PAY
        deductedpay = paybeforededuction - deduction
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.AddParam("@date", todaysdate)
        Access.ExecuteQuery("UPDATE tblAttendance SET [Pay]='" & deductedpay & "',[Deductions]='" & deduction & "'" &
            " WHERE [Passcode]=@passcode AND [Date]=@date")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show("Error on updating deductions.") : Exit Sub
    End Sub

    Private Sub UpdateLog(passcode As String, logdate As DateTime, time As DateTime, employee As String, type As String)
        Access.AddParam("@passcode", passcode)
        Access.AddParam("@date", logdate)
        Access.AddParam("@time", time)
        Access.AddParam("@employee", employee)
        Access.AddParam("@type", type)
        Access.ExecuteQuery("INSERT INTO tblLog ([Passcode],[Date],[Time],[Employee],[Type]) " &
                            "VALUES (@passcode,@date,@time,@employee,@type)")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show("Log update failed." & vbCrLf & Access.Exception) : Exit Sub
    End Sub

    Private Sub UpdateSalaryBalance(passcode As String, balancetobeadded As Double)
        Dim newbalance As Double = 0
        Dim oldbalance As Double = 0
        ' GET OLD BALANCE
        Access.AddParam("@passcode", passcode)
        Access.ExecuteQuery("SELECT * FROM tblEmployee WHERE [Passcode]=@passcode")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        For Each R As DataRow In Access.DbDataTable.Rows
            If Not String.IsNullOrEmpty(R("SalaryBalance").ToString) Then
                oldbalance = R("SalaryBalance")
                Exit For
            End If
        Next
        newbalance = oldbalance + balancetobeadded
        Access.AddParam("@passcode", passcode)
        Access.AddParam("@balance", newbalance)
        Access.ExecuteQuery("UPDATE tblEmployee SET [SalaryBalance]='" & newbalance & "'" &
            " WHERE [Passcode]=@passcode")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
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
        Dim oldbreaktotal As String = ""

        If btnBreak.Text = "Clock Out - Start Break" Then
            ' UPDATE ATTENDANCE - BreakOut
            Access.AddParam("@breakout", lblCurrentTime.Text)
            Access.AddParam("@passcode", EMP_PASSCODE)
            Access.AddParam("@date", todaysdate)
            Access.ExecuteQuery("UPDATE tblAttendance SET [BreakOut]=@breakout" &
                " WHERE [Passcode]=@passcode AND [Date]=@date")
            If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

            ' UPDATE STATUS - break
            UpdateEmployeeStatus("break", EMP_PASSCODE)

            ' INSERT LOG: passcode, date, employee, time, type
            UpdateLog(EMP_PASSCODE, todaysdate, lblCurrentTime.Text, EMP_NAME, "B. Start")

            ' REPORT
            MessageBox.Show("Break started successfully.")
            timer = 15
            tmrCurrentTime.Stop()
            Me.Hide()
            frmPasscode.Show()

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
                    If String.IsNullOrEmpty(R("TotalBreak").ToString) Then
                        oldbreaktotal = "00:00:00"
                    Else
                        oldbreaktotal = R("TotalBreak").ToString
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Sub
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

            newBreakTotal = totalBreakTotal.Add(TimeSpan.Parse(oldbreaktotal))

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

            ' INSERT LOG: passcode, date, employee, time, type
            UpdateLog(EMP_PASSCODE, todaysdate, lblCurrentTime.Text, EMP_NAME, "B. End")

            ' REPORT
            MessageBox.Show("Break ended successfuly.")
            timer = 15
            tmrCurrentTime.Stop()
            Me.Hide()
            frmPasscode.Show()
        End If
    End Sub
End Class