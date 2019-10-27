Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideClientMenu()
        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top
        lblDate.Text = Date.Now().DayOfWeek.ToString() & "," & MonthName(Date.Now().Month) & " " & Date.Now.Day

    End Sub




    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        tbpCustomer.Visible = True
        pnlButtonMover.Height = btnClient.Height
        pnlButtonMover.Top = btnClient.Top
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        hideClientMenu()
        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top
    End Sub


    Sub hideClientMenu()
        tbpCustomer.Visible = False
    End Sub


    Private Sub btnLayout_Click(sender As Object, e As EventArgs) Handles btnLayout.Click
        hideClientMenu()
        pnlButtonMover.Height = btnLayout.Height
        pnlButtonMover.Top = btnLayout.Top
    End Sub
End Class