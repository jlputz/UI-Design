Public Class frmHome
    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbUpcoming.Text = "11/24 - Event at 5pm - Anderson Wedding" + vbCrLf

        rtbUpcoming.AppendText("11/25 - Event at 2pm - Putz Wedding" + vbCrLf)
        rtbUpcoming.AppendText("12/11 - Event at 4pm - Lovas Company Event" + vbCrLf)

    End Sub
End Class