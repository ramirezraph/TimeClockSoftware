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

        If CheckForAlphaCharacters(txtPaymentRate.Text) Then
            'do stuff here if it contains letters
            MessageBox.Show("Invalid rate. Try again.")
            Exit Sub
        End If

        Access.AddParam("@rate", txtPaymentRate.Text)
        Access.AddParam("@code", EMP_PASSCODE)
        Access.ExecuteQuery("UPDATE tblEmployee SET Rate=@rate WHERE Passcode=@code")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        Dim message As String = txtPaymentName.Text & "'s rate registered successfuly"
        frmAdministrator.DisplayToastMessage(message, 1)
        frmAdministrator.RefreshPaymentTable()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                Return True
            End If
        Next

        Return False
    End Function
End Class