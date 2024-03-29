﻿Public Class frmViewAttendance

    ' IMPORTANT
    Private Access As New DatabaseControl

    Dim S_ID As String
    Dim S_DATE As String
    Dim S_PASSCODE As String
    Dim S_EMPLOYEE As String
    Dim S_POSITION As String
    Dim S_IN As DateTime
    Dim S_OUT As DateTime
    Dim S_BREAKOUT As DateTime
    Dim S_BREAKIN As DateTime
    Dim S_TOTALBREAK As String
    Dim S_TOTALHOUR As String
    Dim S_RATE As String
    Dim S_TOTALPAY As String
    Dim S_NOTE As String

    Private Const DateFormat As String = "{0:MM/dd/yyyy}"

    Public Sub New(sid As String, sdate As String, spasscode As String,
                   semployee As String, sposition As String,
                   sin As DateTime, sout As DateTime, sbreakout As DateTime,
                   sbreakin As DateTime, stotalbreak As String, stotalhour As String,
                   srate As String, stotalpay As String, snote As String)

        S_ID = sid
        S_DATE = sdate
        S_PASSCODE = spasscode
        S_EMPLOYEE = semployee
        S_POSITION = sposition
        S_IN = sin
        S_OUT = sout
        S_BREAKOUT = sbreakout
        S_BREAKIN = sbreakin
        S_TOTALBREAK = stotalbreak
        S_TOTALHOUR = stotalhour
        S_RATE = srate
        S_TOTALPAY = stotalpay
        S_NOTE = snote

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnCancelForm_Click(sender As Object, e As EventArgs) Handles btnCancelForm.Click
        ClearAll()
        Me.Close()
    End Sub

    Private Sub ClearAll()
        txtTimeClockIn.Text = ""
        txtTimeClockOut.Text = ""
        txtTimeBreakStart.Text = ""
        txtTimeBreakEnd.Text = ""
        txtNote.Text = ""
        cbAMPMClockIn.Text = ""
        cbAMPMClockOut.Text = ""
        cbAMPMBreakStart.Text = ""
        cbAMPMBreakEnd.Text = ""
    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmEditAttendance_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dtpDate.Value = S_DATE
        txtEmployee.Text = S_EMPLOYEE
        txtTimeClockIn.Text = S_IN.ToString("hh:mm tt")
        txtTimeClockOut.Text = S_OUT.ToString("hh:mm tt")
        txtTimeBreakStart.Text = S_BREAKOUT.ToString("hh:mm tt")
        txtTimeBreakEnd.Text = S_BREAKIN.ToString("hh:mm tt")
        txtTotalBreak.Text = S_TOTALBREAK
        txtTotalHour.Text = S_TOTALHOUR
        txtId.Text = S_ID
        txtPasscode.Text = S_PASSCODE
        txtRate.Text = S_RATE
        txtTotalPay.Text = S_TOTALPAY
        txtNote.Text = S_NOTE

        If txtTimeClockIn.Text = "12:00 AM" Then
            txtTimeClockIn.Text = ""
        Else
            cbAMPMClockIn.Text = S_IN.ToString("tt")
            txtTimeClockIn.Text = S_IN.ToString("hh:mm")
        End If

        If txtTimeClockOut.Text = "12:00 AM" Then
            txtTimeClockOut.Text = ""
        Else
            cbAMPMClockOut.Text = S_OUT.ToString("tt")
            txtTimeClockOut.Text = S_OUT.ToString("hh:mm")
        End If

        If txtTimeBreakStart.Text = "12:00 AM" Then
            txtTimeBreakStart.Text = ""
        Else
            cbAMPMBreakStart.Text = S_BREAKOUT.ToString("tt")
            txtTimeBreakStart.Text = S_BREAKOUT.ToString("hh:mm")
        End If

        If txtTimeBreakEnd.Text = "12:00 AM" Then
            txtTimeBreakEnd.Text = ""
        Else
            cbAMPMBreakEnd.Text = S_BREAKIN.ToString("tt")
            txtTimeBreakEnd.Text = S_BREAKIN.ToString("hh:mm")
        End If

    End Sub

    Private Sub btnSaveNotes_Click(sender As Object, e As EventArgs) Handles btnSaveNotes.Click
        Dim date1 As DateTime = dtpDate.Value
        Dim date2 As String = String.Format(DateFormat, date1)

        Access.AddParam("@note", txtNote.Text)
        Access.AddParam("@passcode", txtPasscode.Text)
        Access.AddParam("@id", txtId.Text)
        Access.ExecuteQuery("UPDATE tblAttendance SET [Notes]=@note WHERE [Passcode]=@passcode AND [ID]=@id")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

        frmAdministrator.RefreshAttendanceTable(date2)
        frmAdministrator.DisplayToastMessage("Note added successfully.", 1)
        Me.Hide()
    End Sub
End Class