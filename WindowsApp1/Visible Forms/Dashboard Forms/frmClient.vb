﻿Public Class frmClient
    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' tbpCustomer.Width = frmDashboard.pnlClient.Width
    End Sub


    Private Sub cmdStrollingStations_Click_1(sender As Object, e As EventArgs) Handles cmdStrollingStations.Click
        frmStrollingStations.ShowDialog()
    End Sub

    Private Sub btnLoadClient_Click(sender As Object, e As EventArgs) Handles btnLoadClient.Click
        frmGetCustomerInContext.Show()
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

    Private Sub btnAddTimeline_Click(sender As Object, e As EventArgs) Handles btnAddTimeline.Click
        If pnlAddTimeline.Visible = True Then
            pnlAddTimeline.Visible = False
        Else
            pnlAddTimeline.Visible = True
        End If
    End Sub

    Private Sub cmdEmailReports_Click(sender As Object, e As EventArgs) Handles cmdEmailReports.Click
        frmSendMail.ShowDialog()
    End Sub

    Private Sub cmdUploadToGoogleDrive_Click(sender As Object, e As EventArgs) Handles cmdUploadToGoogleDrive.Click
        frmUploadReports.ShowDialog()
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

    Private Sub ChkOpenBar_CheckedChanged(sender As Object, e As EventArgs) Handles chkOpenBar.CheckedChanged
        If chkOpenBar.Checked = True Then
            pnlCashBar.Visible = False
        Else
            pnlCashBar.Visible = True
        End If
    End Sub

    Private Sub ChkCashBar_CheckedChanged(sender As Object, e As EventArgs) Handles chkCashBar.CheckedChanged
        If chkCashBar.Checked = True Then
            pnlOpenBar.Visible = False
        Else
            pnlOpenBar.Visible = True
        End If
    End Sub
End Class