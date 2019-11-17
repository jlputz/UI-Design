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

    Private Sub cmdTraditionalBuffet_Click(sender As Object, e As EventArgs) Handles cmdTraditionalBuffet.Click
        frmBuffetStyle.ShowDialog()
    End Sub

    Private Sub cmdPlatedMeals_Click(sender As Object, e As EventArgs) Handles cmdPlatedMeals.Click
        frmPlatedMenu.ShowDialog()
    End Sub

    Private Sub cmdDessert_Click(sender As Object, e As EventArgs) Handles cmdDessert.Click
        frmDesertSelections.ShowDialog()
    End Sub

    Private Sub cmdHorsD_Click(sender As Object, e As EventArgs) Handles cmdHorsD.Click
        frmHorsD.ShowDialog()
    End Sub

    Private Sub cmdAfterglow_Click(sender As Object, e As EventArgs) Handles cmdAfterglow.Click
        frmAfterglow.ShowDialog()
    End Sub
End Class