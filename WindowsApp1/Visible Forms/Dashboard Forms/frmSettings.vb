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

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class