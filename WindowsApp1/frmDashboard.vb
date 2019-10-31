Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideClientMenu()
        '  tbpCustomer.DrawMode = TabDrawMode.OwnerDrawFixed
        '   Me.tbpCustomer.Region = New Region(New RectangleF(Me.tpCustomerInfo.Left, Me.tpEventInfo.Top, Me.TabPage1.Width, Me.TabPage1.Height))
        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top
        lblDate.Text = Date.Now().DayOfWeek.ToString() & "," & MonthName(Date.Now().Month) & " " & Date.Now.Day




    End Sub




    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        tbpCustomer.Visible = True
        Me.tbpCustomer.SelectedTab = Me.tpCustomerInfo
        pnlButtonMover.Height = btnClient.Height
        pnlButtonMover.Top = btnClient.Top
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        hideClientMenu()

        pnlButtonMover.Height = btnHome.Height
        pnlButtonMover.Top = btnHome.Top
    End Sub


    Sub hideClientMenu()
        tbpCustomer.Visible = False
    End Sub


    Private Sub btnLayout_Click(sender As Object, e As EventArgs) Handles btnLayout.Click
        ' hideClientMenu()
        Me.tbpCustomer.SelectedTab = Me.tpLayout
        'hideClientMenu()

        pnlButtonMover.Height = btnLayout.Height
        pnlButtonMover.Top = btnLayout.Top
    End Sub

    Private Sub TpAudioLighting_Click(sender As Object, e As EventArgs) Handles tpAudioLighting.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TpCustomerInfo_Click(sender As Object, e As EventArgs) Handles tpCustomerInfo.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btnChoseFloor.Click

    End Sub

    Private Sub TpLayout_Click(sender As Object, e As EventArgs) Handles tpLayout.Click

    End Sub
End Class