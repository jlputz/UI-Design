Public Class frmClient
    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = frmDashboard.pnlForms.Width
    End Sub


    Private Sub cmdStrollingStations_Click_1(sender As Object, e As EventArgs) Handles cmdStrollingStations.Click
        frmStrollingStations.ShowDialog()
    End Sub

    Private Sub btnLoadClient_Click(sender As Object, e As EventArgs) Handles btnLoadClient.Click

    End Sub
End Class