Public Class frmSettings



#Region "Theme Code"
    Dim defFormBackColor As Color = frmDashboard.BackColor
    Dim defFormForeColor As Color = frmDashboard.ForeColor
    Dim defButtonBackColor As Color = defFormBackColor
    Dim defButtonForeColor As Color = Color.Wheat

    'Figure out how to loop through all of the forms without already having instantiated them or throwing them into an array.
    Private Sub applyLightTheme()

    End Sub

    Private Sub applyDarkTheme()

    End Sub

    Private Sub cbTheme_CheckedChanged(sender As Object, e As EventArgs) Handles cbTheme.CheckedChanged
        If cbTheme.Checked Then
            applyLightTheme()
        Else
            applyDarkTheme()
        End If
    End Sub

#End Region

End Class