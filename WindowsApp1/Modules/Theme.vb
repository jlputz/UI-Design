Module Theme



    Sub applyLightTheme()
        Dim darkBckground = Color.FromArgb(41, 44, 51)
        For Each frm As Form In My.Application.OpenForms
            For Each ctrl As Control In frm.Controls
                If ctrl.BackColor = darkBckground Then
                    ctrl.BackColor = Color.White
                    ctrl.ForeColor = Color.Black
                    frm.BackColor = Color.White
                End If

            Next
        Next

    End Sub

End Module
