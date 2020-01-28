Imports Microsoft.Office.Interop.Visio

Public Class frmLayout

    Dim currentPage As Page
    Dim currentStencil As Document
    Dim stencilWindow As Window

    Dim dirPath As New IO.DirectoryInfo(My.Application.Info.DirectoryPath)
    'Dim arrFileInfo As IO.FileInfo() = dirPath.GetFiles("NewEvent\*.vsdx")
    Dim FileInfo As IO.FileInfo
    Private Sub frmLayout_Load(sender As Object, e As EventArgs) Handles Me.Load
        'For Each FileInfo In arrFileInfo
        '    cmbNew.Items.Add(Strings.Left(FileInfo.Name, FileInfo.Name.Length - 5))
        'Next

        'arrFileInfo = dirPath.GetFiles("SampleTemplates\*.vsdx")
        'For Each FileInfo In arrFileInfo
        '    cmbExisting.Items.Add(Strings.Left(FileInfo.Name, FileInfo.Name.Length - 5))
        'Next
        Me.Location = frmClient.Location

        Dim intWindowWidth As Integer = frmClient.Size.Width
        Dim intWindowHeight As Integer = frmClient.Size.Height
        Dim dblScaleFactor As Double = 0.75

        Dim minSize As Size = New Size(1000, 1000)



        AxDrawingControl1.Height = intWindowHeight * 0.75
        AxDrawingControl1.Width = intWindowWidth * 0.75

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim intWindowWidth As Integer = frmDashboard.Size.Width
        Dim intWindowHeight As Integer = frmDashboard.Size.Height
        Dim dblScaleFactor As Double = 0.75

        Dim minSize As Size = New Size(1000, 1000)



        AxDrawingControl1.Height = intWindowHeight * 0.75
        AxDrawingControl1.Width = intWindowWidth * 0.75

        'If Not cmbNew.Text = "" Then
        '    AxDrawingControl1.Src = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "NewEvent\" & cmbNew.Text & ".vsdx")
        '    currentPage = AxDrawingControl1.Document.Pages(1)

        '    Dim stencilPath As String
        '    stencilPath = System.IO.Path.Combine(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Tables.vssx"))


        '    Try

        '        currentStencil = AxDrawingControl1.Document.Application.Documents.OpenEx(stencilPath, VisOpenSaveArgs.visOpenDocked)
        '        stencilWindow = currentPage.Document.OpenStencilWindow

        '        'StatusStrip1.Refresh()
        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try

        'ElseIf Not cmbExisting.Text = "" Then
        '    AxDrawingControl1.Src = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "SampleTemplates\" & cmbExisting.Text & ".vsdx")
        '    currentPage = AxDrawingControl1.Document.Pages(1)

        '    Dim stencilPath As String
        '    stencilPath = System.IO.Path.Combine(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Tables.vssx"))


        '    Try

        '        currentStencil = AxDrawingControl1.Document.Application.Documents.OpenEx(stencilPath, VisOpenSaveArgs.visOpenDocked)
        '        stencilWindow = currentPage.Document.OpenStencilWindow

        '        'StatusStrip1.Refresh()
        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try
        'Else

        '    MsgBox("Please select a layout")
        '    cmbNew.DroppedDown = True
        'End If
    End Sub

    Private Sub frmLayout_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim intWindowWidth As Integer = Me.Size.Width
        Dim intWindowHeight As Integer = Me.Size.Height
        Dim dblScaleFactor As Double = 0.75

        Dim minSize As Size = New Size(1000, 1000)



        AxDrawingControl1.Height = intWindowHeight * 0.75
        AxDrawingControl1.Width = intWindowWidth * 0.75
    End Sub
End Class