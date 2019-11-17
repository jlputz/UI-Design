Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top
        lblDate.Text = Date.Now().DayOfWeek.ToString() & ", " & MonthName(Date.Now().Month) & " " & Date.Now.Day

        btnHome.PerformClick()

        Me.WindowState = FormWindowState.Maximized
        GetCustomerInContext.DataGridView1.Rows.Add(New String() {"11/7/2019", "Wedding", "Anderson", "Clyde", "999-999-9999", "888-888-8888", "clyde@internet.com", "123 Oak St"})
        GetCustomerInContext.DataGridView1.Rows.Add(New String() {"11/8/2019", "Wedding", "Putz", "Jared", "999-999-9999", "888-888-8888", "jared@internet.com", "124 Oak St"})
        'getDataFromDGV()
    End Sub



    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        SettingsForm.Close()
        HomeForm.Close()
        LayoutForm.Close()
        ClientForm.TopLevel = False
        ClientForm.TopMost = True
        Me.pnlForms.Controls.Add(ClientForm)
        ClientForm.Show()

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

        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top
        SettingsForm.Close()
        ClientForm.Close()
        LayoutForm.Close()
        HomeForm.TopLevel = False
        HomeForm.TopMost = True
        Me.pnlForms.Controls.Add(HomeForm)
        HomeForm.Show()


    End Sub






    Private Sub btnLayout_Click(sender As Object, e As EventArgs) Handles btnLayout.Click


        SettingsForm.Close()
        ClientForm.Close()
        HomeForm.Close()
        LayoutForm.TopLevel = False
        ClientForm.TopMost = True
        Me.pnlForms.Controls.Add(LayoutForm)
        LayoutForm.Show()

        pnlButtonMover.Height = btnLayout.Height
        pnlButtonMover.Top = btnLayout.Top

    End Sub

    Private Sub btnNewClient_Click(sender As Object, e As EventArgs)
        'tbpCustomer.Visible = True
        'tbpCustomer.Top = GetCustomerInContext.DataGridView1.Top
        GetCustomerInContext.DataGridView1.Visible = False

        ClientForm.btnNewClient.Visible = False
        togglePnlButtons()
        'btnCancelNewClient.Visible = True
    End Sub

    Private Sub btnCancelNewClient_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you Sure You want To Cancel?", "Cancel? ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            '   tbpCustomer.Visible = True
            GetCustomerInContext.DataGridView1.Visible = True
            '  tbpCustomer.Top = GetCustomerInContext.DataGridView1.Bottom + 3
            'btnCancelNewClient.Visible = False
            ClientForm.btnNewClient.Visible = True
            togglePnlButtons()
        End If

    End Sub

    Sub togglePnlButtons()
        ' cmdEnterCustomerInfo.Visible = Not cmdEnterCustomerInfo.Visible

        'cmdUpdateTimeline.Visible = Not cmdUpdateTimeline.Visible

        'btnBevSel.Visible = Not btnBevSel.Visible
        'cmdAddAV.Visible = Not cmdAddAV.Visible
        'btnLinensSel.Visible = Not btnLinensSel.Visible
        'btnVendorSel.Visible = Not btnVendorSel.Visible

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        ClientForm.Close()
        HomeForm.Close()
        LayoutForm.Close()
        SettingsForm.TopLevel = False
        SettingsForm.TopMost = True
        Me.pnlForms.Controls.Add(SettingsForm)
        SettingsForm.Show()

        pnlButtonMover.Height = btnSettings.Height
        pnlButtonMover.Top = btnSettings.Top
    End Sub

    Sub hideHome()
        HomeForm.clndrHome.Visible = False
        HomeForm.lblDayInfo.Visible = False
    End Sub

    Private Sub clndrHome_DateChanged(sender As Object, e As DateRangeEventArgs)
        HomeForm.clndrHome.MaxSelectionCount = 1

        Dim EventDate As Date = e.Start

        If EventDate = Date.Today Then
            HomeForm.lblDayInfo.Text = "Event at 5pm - Anderson Wedding"

        Else
            HomeForm.lblDayInfo.Text = "No Events on " + EventDate

        End If
    End Sub



    Private Sub chkCeremonyEvent_CheckedChanged(sender As Object, e As EventArgs)
        'If chkCeremonyEvent.Checked = True Then
        '  pnlCeremony.Visible = True
        '   pnlEventInfo.Top = pnlCeremony.Bottom + 3
        'Else
        '  pnlCeremony.Visible = False
        '   pnlEventInfo.Top = chkCeremonyEvent.Bottom + 3
        'End If
    End Sub


    Private Sub chkOpenBar_CheckedChanged(sender As Object, e As EventArgs)
        'If chkOpenBar.Checked = True Then
        '    pnlCashBar.Visible = False
        'Else
        '   pnlCashBar.Visible = True
        'End If
    End Sub

    Private Sub chkCashBar_CheckedChanged(sender As Object, e As EventArgs)
        'If chkCashBar.Checked = True Then
        '    pnlOpenBar.Visible = False
        'Else
        '   pnlOpenBar.Visible = True
        'End If
    End Sub

    Private Sub tpMiscInfo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        getDataFromDGV()
    End Sub

    Sub getDataFromDGV()
        If (GetCustomerInContext.DataGridView1.CurrentRow.Selected) Then

            '  txtCustomerName.Text = GetCustomerInContext.DataGridView1.SelectedCells(3).Value.ToString() + " " + GetCustomerInContext.DataGridView1.SelectedCells(2).Value.ToString()

        End If
    End Sub

    Private Sub btnPrintInvoice_Click(sender As Object, e As EventArgs)
        Process.Start("C:\TTInvoice.pdf")
    End Sub

    Private Sub btnPrintBEO_Click(sender As Object, e As EventArgs)
        Process.Start("C:\BEO_mockup.pdf")
    End Sub

    Private Sub btnLoadClient_Click(sender As Object, e As EventArgs)
        GetCustomerInContext.ShowDialog()
        getDataFromDGV()
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