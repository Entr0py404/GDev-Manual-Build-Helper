Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetVersions()
    End Sub
    'Button_GetNodeJS - Click
    Private Sub Button_GetNodeJS_Click(sender As Object, e As EventArgs) Handles Button_GetNodeJS.Click
        Process.Start("https://nodejs.org/en/")
    End Sub
    'Button_InstallYarn - Click
    Private Sub Button_InstallYarn_Click(sender As Object, e As EventArgs) Handles Button_InstallYarn.Click
        Dim psi As New ProcessStartInfo()
        psi.Verb = "runas" ' aka run as administrator
        psi.FileName = "cmd.exe"
        psi.WorkingDirectory = Application.StartupPath
        psi.UseShellExecute = False
        psi.Arguments = "/k npm install --global yarn"
        Process.Start(psi)
    End Sub
    'Button_InstallGDExporter - Click
    Private Sub Button_InstallGDExporter_Click(sender As Object, e As EventArgs) Handles Button_InstallGDExporter.Click
        Dim psi As New ProcessStartInfo()
        psi.Verb = "runas" ' aka run as administrator
        psi.FileName = "cmd.exe"
        psi.WorkingDirectory = Application.StartupPath
        psi.UseShellExecute = False
        psi.Arguments = "/k npm install -g gdexporter"
        Process.Start(psi)
    End Sub
    'Button_Refresh - Click
    Private Sub Button_Refresh_Click(sender As Object, e As EventArgs) Handles Button_Refresh.Click
        GetVersions()
    End Sub
    'GetVersions()
    Private Sub GetVersions()
        Dim nodeVersion As String = StartProcessAndGetOutput("/c node -v")
        Dim yarnVersion As String = StartProcessAndGetOutput("/c npm view yarn version")
        Dim GDExporterVersion As String = StartProcessAndGetOutput("/c npm view gdexporter version")
        nodeVersion = nodeVersion.Replace("v", "")

        If Not nodeVersion = "" Then
            Label_NodeVersion.Text = "Node Version Installed: " & nodeVersion
            PictureBox_NodeInstalled.Image = My.Resources.tick_icon
            Button_GetNodeJS.Enabled = False
        Else
            Label_NodeVersion.Text = "Node Is Not Installed!"
            PictureBox_NodeInstalled.Image = My.Resources.cross_icon
            Button_InstallYarn.Enabled = False
            Button_InstallGDExporter.Enabled = False
        End If

        If Not yarnVersion = "" Then
            Label_YarnVersion.Text = "Yarn Version Installed: " & yarnVersion
            PictureBox_YarnInstalled.Image = My.Resources.tick_icon
            Button_InstallYarn.Enabled = False
        Else
            Label_YarnVersion.Text = "Yarn Is Not Installed!"
            PictureBox_YarnInstalled.Image = My.Resources.cross_icon
        End If

        If Not GDExporterVersion = "" Then
            Label_GDExportVersion.Text = "GDExport Version Installed: " & GDExporterVersion
            PictureBox_GDExporterInstalled.Image = My.Resources.tick_icon
            Button_InstallGDExporter.Enabled = False
        Else
            Label_GDExportVersion.Text = "GDExport Is Not Installed!"
            PictureBox_GDExporterInstalled.Image = My.Resources.cross_icon
        End If
    End Sub
    'StartProcessAndGetOutput
    Public Function StartProcessAndGetOutput(Process_Arguments As String) As String
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("cmd.exe", Process_Arguments)
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.StartInfo.CreateNoWindow = True
        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using

        Return sOutput
    End Function
End Class