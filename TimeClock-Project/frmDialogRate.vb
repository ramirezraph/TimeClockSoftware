Public Class frmDialogRate
    Dim EMP_NAME As String
    Dim EMP_POSITION As String
    Dim EMP_PASSCODE As String
    Dim EMP_RATE As String

    ' IMPORTANT
    Private Access As New DatabaseControl

    Public Sub New(passcode As String, name As String, position As String, rate As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        EMP_NAME = name
        EMP_POSITION = position
        EMP_RATE = rate
        EMP_PASSCODE = passcode
    End Sub

    Private Sub frmDialogRate_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtPaymentName.Text = EMP_NAME
        txtPaymentPosition.Text = EMP_POSITION
        txtPaymentRate.Text = EMP_RATE
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Access.AddParam("@passcode", EMP_PASSCODE)
        Access.AddParam("@rate", txtPaymentRate.Text)
        Access.ExecuteQuery("UPDATE tblEmployee SET [Rate]=@rate WHERE [Passcode]=@passcode")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        Me.Hide()
        Dim message As String = txtPaymentName.Text & " rate added successfuly"
        frmAdministrator.DisplayToastMessage(message, 1)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class