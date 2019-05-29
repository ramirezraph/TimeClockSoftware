Public Class PrintPayslip

    Private Const DateFormat As String = "{0:MM/dd/yyyy}"

    Dim EMP_NAME As String
    Dim EMP_POS As String
    Dim EMP_SALARY As Double

    Public Sub New(name As String, pos As String, salary As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        EMP_NAME = name
        EMP_POS = pos
        Try
            EMP_SALARY = Convert.ToDouble(salary)
        Catch ex As Exception
            EMP_SALARY = 0
        End Try

    End Sub

    Private Sub PrintDocumentPayslip_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentPayslip.PrintPage
        Dim myImage As New Bitmap(Me.Width, Me.Height)
        Dim PrintSize As Size = e.MarginBounds.Size
        Dim scale As Double = 1
        Me.DrawToBitmap(myImage, New Rectangle(Point.Empty, Me.Size))
        PrintSize.Width *= 0.96 'convert to pixels
        PrintSize.Height *= 0.96
        If myImage.Width > PrintSize.Width Then
            'Form is to big. Scale it down.
            scale = PrintSize.Width / myImage.Width
            e.Graphics.ScaleTransform(scale, scale)
        End If
        If (myImage.Height * scale) > PrintSize.Height Then
            'The form is still to big. Scale it again.
            scale = PrintSize.Height / (myImage.Height * scale)
            e.Graphics.ScaleTransform(scale, scale)
        End If
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        e.Graphics.DrawImage(myImage, e.MarginBounds.Location)
        myImage.Dispose()
    End Sub

    Private Sub PrintPayslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim todaysdate As String = String.Format(DateFormat, Date.Now)
        lblName.Text = EMP_NAME
        lblPosition.Text = EMP_POS
        lblSalary.Text = EMP_SALARY.ToString("N2")
        lblDate.Text = todaysdate
        CalculateTaxes()
    End Sub

    Private Sub CalculateTaxes()
        Try
            Dim salary = Convert.ToDouble(lblSalary.Text)
            Dim pagibigtax As Double
            Dim ssstax As Double
            Dim philtax As Double
            Dim netsalary As Double
            ' SSS
            ssstax = (salary * 0.11) * 0.363

            ' PAGIBIG
            If salary > 1500 Then
                pagibigtax = salary * 0.2
            Else
                pagibigtax = salary * 0.1
            End If

            ' PhilHealth
            philtax = (salary * 0.0275) / 2

            netsalary = salary - (ssstax + pagibigtax + philtax)

            lblSSS.Text = ssstax.ToString("N2")
            lblPagIbig.Text = pagibigtax.ToString("N2")
            lblPhilHealth.Text = philtax.ToString("N2")
            lblNetSalary.Text = netsalary.ToString("N2")
        Catch ex As Exception
            MessageBox.Show("Incomplete Information.")
        End Try
    End Sub

    Private Sub PrintPayslip_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.P AndAlso (e.Control AndAlso e.Alt) Then
            If PrintPreviewDialogPayslip.ShowDialog = Windows.Forms.DialogResult.OK Then
                PrintDocumentPayslip.Print()
            End If
        End If
    End Sub
End Class