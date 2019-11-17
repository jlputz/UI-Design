Public Class frmClient
    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbpCustomer.Width = frmDashboard.pnlForms.Width
    End Sub


    Private Sub cmdStrollingStations_Click_1(sender As Object, e As EventArgs) Handles cmdStrollingStations.Click
        frmStrollingStations.ShowDialog()
    End Sub

    Private Sub btnLoadClient_Click(sender As Object, e As EventArgs) Handles btnLoadClient.Click

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub btnPrintInvoice_Click(sender As Object, e As EventArgs) Handles btnPrintInvoice.Click

    End Sub
End Class