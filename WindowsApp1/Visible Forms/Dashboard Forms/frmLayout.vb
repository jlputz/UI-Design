Imports Microsoft.Office.Interop.Visio

Public Class frmLayout

    Dim currentPage As Page
    Dim currentStencil As Document
    Dim stencilWindow As Window

    Dim dirPath As New IO.DirectoryInfo(My.Application.Info.DirectoryPath)
    Dim arrFileInfo As IO.FileInfo() = dirPath.GetFiles("NewEvent\*.vsdx")
    Dim FileInfo As IO.FileInfo
    Private Sub frmLayout_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each FileInfo In arrFileInfo
            cmbNew.Items.Add(Strings.Left(FileInfo.Name, FileInfo.Name.Length - 5))
        Next

        arrFileInfo = dirPath.GetFiles("SampleTemplates\*.vsdx")
        For Each FileInfo In arrFileInfo
            cmbExisting.Items.Add(Strings.Left(FileInfo.Name, FileInfo.Name.Length - 5))
        Next
    End Sub
End Class