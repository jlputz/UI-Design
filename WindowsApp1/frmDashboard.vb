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
        DataGridView1.Rows.Add(New String() {"11/7/2019", "Wedding", "Anderson", "Clyde", "999-999-999", "888-888-8888", "clyde@internet.com", "123 Oak St"})
        DataGridView1.Rows.Add(New String() {"11/8/2019", "Wedding", "Putz", "Jared", "999-999-999", "888-888-8888", "jared@internet.com", "124 Oak St"})
    End Sub




    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        tbpCustomer.SelectedTab = tpCustomerInfo
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
        btnCancelNewClient.Visible = False
    End Sub
    Sub hideSettings()
        pnlSettings.Visible = False
    End Sub

    Private Sub btnLayout_Click(sender As Object, e As EventArgs) Handles btnLayout.Click
        'hideClientMenu()
        tbpCustomer.SelectedTab = tpLayout
        hideSettings()
        hideHome()
        DataGridView1.Visible = True
        pnlButtonMover.Height = btnLayout.Height
        pnlButtonMover.Top = btnLayout.Top
    End Sub

    Private Sub btnNewClient_Click(sender As Object, e As EventArgs) Handles btnNewClient.Click
        tbpCustomer.Visible = True
        tbpCustomer.Top = DataGridView1.Top
        DataGridView1.Visible = False

        btnNewClient.Visible = False
        togglePnlButtons()
        btnCancelNewClient.Visible = True
    End Sub

    Private Sub btnCancelNewClient_Click(sender As Object, e As EventArgs) Handles btnCancelNewClient.Click
        If MessageBox.Show("Are you Sure You want To Cancel?", "Cancel? ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            tbpCustomer.Visible = True
            DataGridView1.Visible = True
            tbpCustomer.Top = DataGridView1.Bottom + 3
            btnCancelNewClient.Visible = False
            btnNewClient.Visible = True
            togglePnlButtons()
        End If

    End Sub

    Sub togglePnlButtons()
        cmdEnterCustomerInfo.Visible = Not cmdEnterCustomerInfo.Visible
        cmdEnterEventInfo.Visible = Not cmdEnterEventInfo.Visible
        cmdUpdateTimeline.Visible = Not cmdUpdateTimeline.Visible
        btnFoodSel.Visible = Not btnFoodSel.Visible
        btnBevSel.Visible = Not btnBevSel.Visible
        cmdAddAV.Visible = Not cmdAddAV.Visible
        btnLinensSel.Visible = Not btnLinensSel.Visible
        btnVendorSel.Visible = Not btnVendorSel.Visible

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

    Private Sub TxtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged

    End Sub

    Private Sub lblGuestCount_Click(sender As Object, e As EventArgs) Handles lblGuestCount.Click

    End Sub

    Private Sub chkCeremonyEvent_CheckedChanged(sender As Object, e As EventArgs) Handles chkCeremonyEvent.CheckedChanged
        If chkCeremonyEvent.Checked = True Then
            pnlCeremony.Visible = True
            pnlEventInfo.Top = pnlCeremony.Bottom + 3
        Else
            pnlCeremony.Visible = False
            pnlEventInfo.Top = chkCeremonyEvent.Bottom + 3
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles pnlEventInfo.Paint

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub chkOpenBar_CheckedChanged(sender As Object, e As EventArgs) Handles chkOpenBar.CheckedChanged
        If chkOpenBar.Checked = True Then
            pnlCashBar.Visible = False
        Else
            pnlCashBar.Visible = True
        End If
    End Sub

    Private Sub chkCashBar_CheckedChanged(sender As Object, e As EventArgs) Handles chkCashBar.CheckedChanged
        If chkCashBar.Checked = True Then
            pnlOpenBar.Visible = False
        Else
            pnlOpenBar.Visible = True
        End If
    End Sub

    Private Sub tpMiscInfo_Click(sender As Object, e As EventArgs) Handles tpMiscInfo.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (DataGridView1.CurrentRow.Selected) Then

            txtCustomerName.Text = DataGridView1.SelectedCells(3).Value.ToString()
        End If
    End Sub

    Private Sub BtnVendorSel_Click(sender As Object, e As EventArgs) Handles btnVendorSel.Click

    End Sub
End Class