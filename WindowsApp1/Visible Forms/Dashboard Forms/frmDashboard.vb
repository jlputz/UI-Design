Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top
        lblDate.Text = Date.Now().DayOfWeek.ToString() & ", " & MonthName(Date.Now().Month) & " " & Date.Now.Day


        initFormsToPanel()






        Me.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub initFormsToPanel()
        'Add frmHome to pnlHome and set this to the visible form 
        frmHome.TopLevel = False
        Me.pnlHome.Controls.Add(frmHome)
        frmHome.Show()
        pnlHome.Visible = True

        'Add frmClient to pnlClient and set form to not visible
        frmClient.TopLevel = False
        Me.pnlClient.Controls.Add(frmClient)
        frmClient.Show()
        pnlClient.Visible = False

        'Add frmLayout to pnlLayout and set form to not visible
        frmLayout.TopLevel = False
        Me.pnlLayout.Controls.Add(frmLayout)
        frmLayout.Show()
        pnlLayout.Visible = False

        'Add frmSettings to pnlSettings and set form to not visible
        frmSettings.TopLevel = False
        Me.pnlSettings.Controls.Add(frmSettings)
        frmSettings.Show()
        pnlSettings.Visible = False
    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click

        pnlClient.Visible = True
        pnlHome.Visible = False
        pnlSettings.Visible = False
        pnlLayout.Visible = False

        pnlButtonMover.Height = btnClient.Height
        pnlButtonMover.Top = btnClient.Top
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top

        pnlClient.Visible = False
        pnlHome.Visible = True
        pnlSettings.Visible = False
        pnlLayout.Visible = False



    End Sub



    Private Sub btnLayout_Click(sender As Object, e As EventArgs) Handles btnLayout.Click

        pnlButtonMover.Height = btnLayout.Height
        pnlButtonMover.Top = btnLayout.Top


        pnlClient.Visible = False
        pnlHome.Visible = False
        pnlSettings.Visible = False
        pnlLayout.Visible = True





    End Sub

    Private Sub btnNewClient_Click(sender As Object, e As EventArgs)
        'tbpCustomer.Visible = True
        'tbpCustomer.Top = GetCustomerInContext.DataGridView1.Top
        frmGetCustomerInContext.DataGridView1.Visible = False

        frmClient.btnNewClient.Visible = False

    End Sub

    Private Sub btnCancelNewClient_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you Sure You want To Cancel?", "Cancel? ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            '   tbpCustomer.Visible = True
            frmGetCustomerInContext.DataGridView1.Visible = True
            '  tbpCustomer.Top = GetCustomerInContext.DataGridView1.Bottom + 3
            'btnCancelNewClient.Visible = False
            frmClient.btnNewClient.Visible = True

        End If

    End Sub





    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        pnlClient.Visible = False
        pnlHome.Visible = False
        pnlSettings.Visible = True
        pnlLayout.Visible = False

        pnlButtonMover.Height = btnSettings.Height
        pnlButtonMover.Top = btnSettings.Top
    End Sub

    Sub hideHome()
        frmHome.clndrHome.Visible = False
        frmHome.lblDayInfo.Visible = False
    End Sub

    Private Sub clndrHome_DateChanged(sender As Object, e As DateRangeEventArgs)
        frmHome.clndrHome.MaxSelectionCount = 1

        Dim EventDate As Date = e.Start

        If EventDate = Date.Today Then
            frmHome.lblDayInfo.Text = "Event at 5pm - Anderson Wedding"

        Else
            frmHome.lblDayInfo.Text = "No Events on " + EventDate

        End If
    End Sub




    Private Sub btnPrintInvoice_Click(sender As Object, e As EventArgs)
        Process.Start("C:\TTInvoice.pdf")
    End Sub

    Private Sub btnPrintBEO_Click(sender As Object, e As EventArgs)
        Process.Start("C:\BEO_mockup.pdf")
    End Sub

    Private Sub btnLoadClient_Click(sender As Object, e As EventArgs)
        frmGetCustomerInContext.ShowDialog()

    End Sub

    Private Sub cmdTraditionalBuffet_Click(sender As Object, e As EventArgs)
        frmBuffetStyle.ShowDialog()
    End Sub

    Private Sub cmdPlatedMeals_Click(sender As Object, e As EventArgs)
        frmPlatedMenu.ShowDialog()
    End Sub

    Private Sub cmdDessert_Click(sender As Object, e As EventArgs)
        frmDesertSelections.ShowDialog()
    End Sub


End Class