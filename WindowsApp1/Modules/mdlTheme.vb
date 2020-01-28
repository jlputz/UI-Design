Module mdlTheme
    Dim darkLogoBackColor = frmDashboard.PictureBox1.BackColor
    Dim darkFormForeColor = frmDashboard.ForeColor
    Dim darkFormBackColor = frmDashboard.BackColor
    Dim darkGeneralBtnForeColor = frmDashboard.btnExit.ForeColor
    Dim darkGeneralBtnBackColor = frmDashboard.btnExit.BackColor
    'Dim darkPanelBtnForeColor = frmDashboard.btnHome.ForeColor
    'Dim darkPanelBtnBackColor = frmDashboard.btnHome.BackColor
    Dim darkLblForeColor = frmDashboard.lblNotifs.ForeColor
    Dim darkLblBackColor = frmDashboard.lblNotifs.BackColor

    Dim lightLogoBackColor = Color.White
    Dim lightFormForeColor = Color.Black
    Dim lightFormBackColor = Color.White
    Dim lightGeneralBtnForeColor = Color.Black
    Dim lightGeneralBtnBackColor = Color.White
    Dim lightPanelBtnForeColor = Color.Black
    Dim lightPanelBtnBackColor = Color.White
    Dim lightLblForeColor = Color.Black
    Dim lightLblBackColor = Color.White

    Sub ApplyDarkTheme()

    End Sub

    Sub ApplyLightTheme()
        frmDashboard.PictureBox1.BackColor = lightLogoBackColor
        frmDashboard.BackColor = lightFormBackColor
        frmDashboard.ForeColor = lightFormForeColor


    End Sub
End Module
