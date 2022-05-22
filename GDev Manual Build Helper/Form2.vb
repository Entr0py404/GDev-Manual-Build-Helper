Public Class Form2
    'Button_SelectGameJSONFile - Click
    Private Sub Button_SelectGameJSONFile_Click(sender As Object, e As EventArgs) Handles Button_SelectGameJSONFile.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox_GameJSONFile.Text = OpenFileDialog1.FileName
        End If
    End Sub
    'Button_SelectOutputDirectory - Click
    Private Sub Button_SelectOutputDirectory_Click(sender As Object, e As EventArgs) Handles Button_SelectOutputDirectory.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox_OutputDirectory.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    'Button_Export - Click
    Private Sub Button_Export_Click(sender As Object, e As EventArgs) Handles Button_Export.Click
        If File.Exists(TextBox_GameJSONFile.Text) And Directory.Exists(TextBox_OutputDirectory.Text) Then
            Dim buildOption As String = ""
            If RadioButton_Electron.Checked Then
                buildOption = "-b electron "
            End If
            If RadioButton_Cordova.Checked Then
                buildOption = "-b cordova "
            End If
            If RadioButton_Facebook.Checked Then
                buildOption = "-b facebook "
            End If
            Dim psi As New ProcessStartInfo()
            psi.Verb = "runas" ' aka run as administrator
            psi.FileName = "cmd.exe"
            psi.WorkingDirectory = Application.StartupPath
            psi.UseShellExecute = False
            psi.Arguments = "/k gdexport " & buildOption & " -p " & TextBox_GameJSONFile.Text & " -o " & TextBox_OutputDirectory.Text
            Process.Start(psi)
        End If
    End Sub
    'Panel_GameJSONFile - DragDrop
    Private Sub Panel_GameJSONFile_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_GameJSONFile.DragDrop
        Dim Files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If Files.Length <> 0 Then
            Try
                TextBox_GameJSONFile.Text = Files(0)
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Panel_GameJSONFile - DragEnter
    Private Sub Panel_GameJSONFile_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_GameJSONFile.DragEnter
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And File.Exists(Folders(0)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Panel_OutputDirectory - DragDrop
    Private Sub Panel_OutputDirectory_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_OutputDirectory.DragDrop
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If Folders.Length <> 0 Then
            Try
                TextBox_OutputDirectory.Text = Folders(0)
            Catch ex As Exception
                MsgBox("Problem opening directory.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Panel_OutputDirectory - DragEnter
    Private Sub Panel_OutputDirectory_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_OutputDirectory.DragEnter
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Directory.Exists(Folders(0)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
End Class