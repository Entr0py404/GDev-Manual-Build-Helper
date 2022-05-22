Public Class Form1
    Dim PackageDirectory As String = ""
    'Form1 - Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
    End Sub
    'Form1 - DragDrop
    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If Folders.Length <> 0 Then
            Try
                PackageDirectory = Folders(0)
                Label_PackageDirectory.Text = PackageDirectory
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Form1 - DragEnter
    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Directory.Exists(Folders(0)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Button_Build - Click
    Private Sub Button_Build_Click(sender As Object, e As EventArgs) Handles Button_Build.Click
        If Directory.Exists(PackageDirectory) Then
            Try
                Dim psi As New ProcessStartInfo()
                psi.Verb = "runas" ' aka run as administrator
                psi.FileName = "cmd.exe"
                psi.WorkingDirectory = PackageDirectory
                psi.UseShellExecute = False

                Dim BuildString As String = ""
                Dim Command_Zip As String = ""
                If CheckBox_Zip.Checked Then
                    Command_Zip = "zip "
                End If

                Dim Command_Installer As String = ""
                If CheckBox_Installer.Checked Then
                    Command_Installer = "nsis "
                End If

                Dim Command_Unpacked As String = ""
                If Not CheckBox_Zip.Checked And Not CheckBox_Installer.Checked Then
                    Command_Installer = "dir"
                End If

                BuildString = $"yarn && yarn build -w {Command_Zip}{Command_Installer}{Command_Unpacked}"

                Console.WriteLine(BuildString)
                psi.Arguments = "/k " & BuildString
                Process.Start(psi)

            Catch ex As Exception
                ' exception raised if user declines the admin prompt
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'GDExporter (ToolStripMenuItem) - Click
    Private Sub GDExporterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GDExporterToolStripMenuItem.Click
        Form2.Show()
        Form2.BringToFront()
    End Sub
    'Verify Needed Programs (ToolStripMenuItem) - Click
    Private Sub VerifyNeededProgramsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerifyNeededProgramsToolStripMenuItem.Click
        Form3.Show()
        Form3.BringToFront()
    End Sub
End Class