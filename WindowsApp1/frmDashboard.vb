Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideClientMenu()
        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top
        tbpCustomer.BackColor = Color.Wheat
    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        tbpCustomer.Visible = True
        pnlButtonMover.Height = btnClient.Height
        pnlButtonMover.Top = btnClient.Top
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        hideClientMenu()
        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top
    End Sub


    Sub hideClientMenu()
        tbpCustomer.Visible = False
    End Sub

    Private Sub btnCusInfo_Click(sender As Object, e As EventArgs)

    End Sub
End Class