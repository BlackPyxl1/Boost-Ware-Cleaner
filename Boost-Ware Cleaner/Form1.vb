Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tempFolderName As String = My.Computer.FileSystem.SpecialDirectories.Temp

        Dim tempFolder As IO.DirectoryInfo = New IO.DirectoryInfo(tempFolderName)

        Dim di As New IO.DirectoryInfo(tempFolderName)
        di.Delete(True)
    End Sub
End Class
