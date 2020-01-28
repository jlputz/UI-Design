Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top
        lblDate.Text = Date.Now().DayOfWeek.ToString() & ", " & MonthName(Date.Now().Month) & " " & Date.Now.Day

        setUpForms()

        Me.WindowState = FormWindowState.Maximized

    End Sub



    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click

        pnlLayout.Visible = False
        pnlHome.Visible = False
        pnlSettings.Visible = False
        pnlClient.Visible = True

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

        pnlLayout.Visible = False
        pnlHome.Visible = True
        pnlSettings.Visible = False
        pnlClient.Visible = False


        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top


    End Sub



    Private Sub btnLayout_Click(sender As Object, e As EventArgs) Handles btnLayout.Click


        pnlLayout.Visible = True
        pnlHome.Visible = False
        pnlSettings.Visible = False
        pnlClient.Visible = False

        pnlButtonMover.Height = btnLayout.Height
        pnlButtonMover.Top = btnLayout.Top

    End Sub




    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        pnlLayout.Visible = False
        pnlHome.Visible = False
        pnlSettings.Visible = True
        pnlClient.Visible = False


        pnlButtonMover.Height = btnSettings.Height
        pnlButtonMover.Top = btnSettings.Top
    End Sub

    Sub setUpForms()
        frmHome.TopLevel = False
        Me.pnlHome.Controls.Add(frmHome)
        frmHome.Show()
        pnlHome.Visible = True


        frmClient.TopLevel = False
        Me.pnlClient.Controls.Add(frmClient)
        frmClient.Show()
        pnlClient.Visible = False


        frmSettings.TopLevel = False
        Me.pnlSettings.Controls.Add(frmSettings)
        frmSettings.Show()
        pnlSettings.Visible = False


        frmLayout.TopLevel = False
        Me.pnlLayout.Controls.Add(frmLayout)
        frmLayout.Show()
        pnlLayout.Visible = False

    End Sub

    Private Sub pnlLayout_Paint(sender As Object, e As PaintEventArgs) Handles pnlLayout.Paint

    End Sub
End Class