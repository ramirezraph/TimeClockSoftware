Public Class frmEditAttendance
    Private Sub btnCancelForm_Click(sender As Object, e As EventArgs) Handles btnCancelForm.Click
        Me.Close()
    End Sub

    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click

    End Sub

    Private Sub btnEditAttendance_Click(sender As Object, e As EventArgs) Handles btnEditAttendance.Click
        btnEditAttendance.Visible = False
        btnSaveEdit.Visible = True
    End Sub
End Class