Public Class frmSettings

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmTreausryEmail.ShowDialog()
    End Sub

    Private Sub btnEditBuffet_Click(sender As Object, e As EventArgs) Handles btnEditBuffet.Click
        frmEditBuffetOptions.ShowDialog()
    End Sub

    Private Sub btnEditApps_Click(sender As Object, e As EventArgs) Handles btnEditApps.Click
        frmEditAppetizerOptions.ShowDialog()
    End Sub


#Region "Theme Code"
    Private Sub cbTheme_CheckedChanged(sender As Object, e As EventArgs) Handles cbTheme.CheckedChanged
        If cbTheme.Checked Then
            ApplyLightTheme()
        Else
            ApplyDarkTheme()
        End If
    End Sub
#End Region

End Class