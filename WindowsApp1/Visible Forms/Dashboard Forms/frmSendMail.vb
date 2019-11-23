Public Class frmSendMail
    Private Sub cmdSendEmail_Click(sender As Object, e As EventArgs) Handles cmdSendEmail.Click
        MessageBox.Show(CStr(cboReportType.SelectedItem) & " successfully emailed to " & txtRecipientEmail.Text)
    End Sub
End Class