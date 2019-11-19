Public Class frmClient
    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = frmDashboard.pnlForms.Width - 5
    End Sub


    Private Sub cmdStrollingStations_Click_1(sender As Object, e As EventArgs) Handles cmdStrollingStations.Click
        frmStrollingStations.ShowDialog()
    End Sub

    Private Sub btnLoadClient_Click(sender As Object, e As EventArgs) Handles btnLoadClient.Click

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub btnPrintInvoice_Click(sender As Object, e As EventArgs) Handles btnPrintInvoice.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnAddTimeline_Click(sender As Object, e As EventArgs) Handles btnAddTimeline.Click
        DateTimePicker1.CustomFormat = "hh:mm tt"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.ShowUpDown = True
        If pnlAddTimeline.Visible = True Then
            pnlAddTimeline.Visible = False
        Else
            pnlAddTimeline.Visible = True
        End If


    End Sub
End Class