Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideClientMenu()
        hideSettings()
        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top
        lblDate.Text = Date.Now().DayOfWeek.ToString() & ", " & MonthName(Date.Now().Month) & " " & Date.Now.Day
        clndrHome.Visible = True
        lblDayInfo.Text = "Event at 5pm - Anderson Wedding"
        Me.WindowState = FormWindowState.Maximized
    End Sub




    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        hideSettings()
        hideHome()
        btnNewClient.Visible = True
        DataGridView1.Visible = True
        tbpCustomer.Visible = True
        pnlSettings.Visible = False
        tbpCustomer.Top = DataGridView1.Bottom + 5
        pnlButtonMover.Height = btnClient.Height
        pnlButtonMover.Top = btnClient.Top
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        hideClientMenu()
        hideSettings()

        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top
        clndrHome.Visible = True
        lblDayInfo.Visible = True
    End Sub


    Sub hideClientMenu()
        tbpCustomer.Visible = False
        btnNewClient.Visible = False
        DataGridView1.Visible = False
    End Sub
    Sub hideSettings()
        pnlSettings.Visible = False
    End Sub

    Private Sub btnLayout_Click(sender As Object, e As EventArgs) Handles btnLayout.Click
        hideClientMenu()
        hideSettings()
        hideHome()
        pnlButtonMover.Height = btnLayout.Height
        pnlButtonMover.Top = btnLayout.Top
    End Sub

    Private Sub btnNewClient_Click(sender As Object, e As EventArgs) Handles btnNewClient.Click
        tbpCustomer.Visible = True
        tbpCustomer.Top = DataGridView1.Top
        DataGridView1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        hideClientMenu()
        hideHome()
        pnlSettings.Visible = True
        pnlButtonMover.Height = btnSettings.Height
        pnlButtonMover.Top = btnSettings.Top
    End Sub

    Sub hideHome()
        clndrHome.Visible = False
        lblDayInfo.Visible = False
    End Sub

    Private Sub clndrHome_DateChanged(sender As Object, e As DateRangeEventArgs) Handles clndrHome.DateChanged
        clndrHome.MaxSelectionCount = 1

        Dim EventDate As Date = e.Start

        If EventDate = Date.Today Then
            lblDayInfo.Text = "Event at 5pm - Anderson Wedding"

        Else
            lblDayInfo.Text = "No Events on " + EventDate

        End If
    End Sub
End Class