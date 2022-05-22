<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Button_InstallGDExporter = New System.Windows.Forms.Button()
        Me.PictureBox_GDExporterInstalled = New System.Windows.Forms.PictureBox()
        Me.Button_Refresh = New System.Windows.Forms.Button()
        Me.Button_GetNodeJS = New System.Windows.Forms.Button()
        Me.Button_InstallYarn = New System.Windows.Forms.Button()
        Me.PictureBox_YarnInstalled = New System.Windows.Forms.PictureBox()
        Me.PictureBox_NodeInstalled = New System.Windows.Forms.PictureBox()
        Me.Label_YarnVersion = New System.Windows.Forms.Label()
        Me.Label_NodeVersion = New System.Windows.Forms.Label()
        Me.Label_GDExportVersion = New System.Windows.Forms.Label()
        CType(Me.PictureBox_GDExporterInstalled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_YarnInstalled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_NodeInstalled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_InstallGDExporter
        '
        Me.Button_InstallGDExporter.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_InstallGDExporter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_InstallGDExporter.FlatAppearance.BorderSize = 0
        Me.Button_InstallGDExporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_InstallGDExporter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_InstallGDExporter.Location = New System.Drawing.Point(232, 120)
        Me.Button_InstallGDExporter.Name = "Button_InstallGDExporter"
        Me.Button_InstallGDExporter.Size = New System.Drawing.Size(128, 24)
        Me.Button_InstallGDExporter.TabIndex = 27
        Me.Button_InstallGDExporter.Text = "Install GDExporter"
        Me.Button_InstallGDExporter.UseVisualStyleBackColor = False
        '
        'PictureBox_GDExporterInstalled
        '
        Me.PictureBox_GDExporterInstalled.Location = New System.Drawing.Point(8, 56)
        Me.PictureBox_GDExporterInstalled.Name = "PictureBox_GDExporterInstalled"
        Me.PictureBox_GDExporterInstalled.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_GDExporterInstalled.TabIndex = 25
        Me.PictureBox_GDExporterInstalled.TabStop = False
        '
        'Button_Refresh
        '
        Me.Button_Refresh.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Refresh.FlatAppearance.BorderSize = 0
        Me.Button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Refresh.Location = New System.Drawing.Point(8, 88)
        Me.Button_Refresh.Name = "Button_Refresh"
        Me.Button_Refresh.Size = New System.Drawing.Size(104, 24)
        Me.Button_Refresh.TabIndex = 24
        Me.Button_Refresh.Text = "Refresh"
        Me.Button_Refresh.UseVisualStyleBackColor = False
        '
        'Button_GetNodeJS
        '
        Me.Button_GetNodeJS.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_GetNodeJS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_GetNodeJS.FlatAppearance.BorderSize = 0
        Me.Button_GetNodeJS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_GetNodeJS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_GetNodeJS.Location = New System.Drawing.Point(8, 120)
        Me.Button_GetNodeJS.Name = "Button_GetNodeJS"
        Me.Button_GetNodeJS.Size = New System.Drawing.Size(104, 24)
        Me.Button_GetNodeJS.TabIndex = 23
        Me.Button_GetNodeJS.Text = "Get Node.js"
        Me.Button_GetNodeJS.UseVisualStyleBackColor = False
        '
        'Button_InstallYarn
        '
        Me.Button_InstallYarn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_InstallYarn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_InstallYarn.FlatAppearance.BorderSize = 0
        Me.Button_InstallYarn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_InstallYarn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_InstallYarn.Location = New System.Drawing.Point(120, 120)
        Me.Button_InstallYarn.Name = "Button_InstallYarn"
        Me.Button_InstallYarn.Size = New System.Drawing.Size(104, 24)
        Me.Button_InstallYarn.TabIndex = 22
        Me.Button_InstallYarn.Text = "Install Yarn"
        Me.Button_InstallYarn.UseVisualStyleBackColor = False
        '
        'PictureBox_YarnInstalled
        '
        Me.PictureBox_YarnInstalled.Location = New System.Drawing.Point(8, 32)
        Me.PictureBox_YarnInstalled.Name = "PictureBox_YarnInstalled"
        Me.PictureBox_YarnInstalled.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_YarnInstalled.TabIndex = 21
        Me.PictureBox_YarnInstalled.TabStop = False
        '
        'PictureBox_NodeInstalled
        '
        Me.PictureBox_NodeInstalled.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox_NodeInstalled.Name = "PictureBox_NodeInstalled"
        Me.PictureBox_NodeInstalled.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_NodeInstalled.TabIndex = 20
        Me.PictureBox_NodeInstalled.TabStop = False
        '
        'Label_YarnVersion
        '
        Me.Label_YarnVersion.AutoSize = True
        Me.Label_YarnVersion.Location = New System.Drawing.Point(32, 32)
        Me.Label_YarnVersion.Name = "Label_YarnVersion"
        Me.Label_YarnVersion.Size = New System.Drawing.Size(115, 13)
        Me.Label_YarnVersion.TabIndex = 19
        Me.Label_YarnVersion.Text = "Yarn Version Installed: "
        '
        'Label_NodeVersion
        '
        Me.Label_NodeVersion.AutoSize = True
        Me.Label_NodeVersion.Location = New System.Drawing.Point(32, 8)
        Me.Label_NodeVersion.Name = "Label_NodeVersion"
        Me.Label_NodeVersion.Size = New System.Drawing.Size(119, 13)
        Me.Label_NodeVersion.TabIndex = 18
        Me.Label_NodeVersion.Text = "Node Version Installed: "
        '
        'Label_GDExportVersion
        '
        Me.Label_GDExportVersion.AutoSize = True
        Me.Label_GDExportVersion.Location = New System.Drawing.Point(32, 56)
        Me.Label_GDExportVersion.Name = "Label_GDExportVersion"
        Me.Label_GDExportVersion.Size = New System.Drawing.Size(148, 13)
        Me.Label_GDExportVersion.TabIndex = 26
        Me.Label_GDExportVersion.Text = "GDExporter Version Installed: "
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(369, 153)
        Me.Controls.Add(Me.Button_InstallGDExporter)
        Me.Controls.Add(Me.PictureBox_GDExporterInstalled)
        Me.Controls.Add(Me.Button_Refresh)
        Me.Controls.Add(Me.Button_GetNodeJS)
        Me.Controls.Add(Me.Button_InstallYarn)
        Me.Controls.Add(Me.PictureBox_YarnInstalled)
        Me.Controls.Add(Me.PictureBox_NodeInstalled)
        Me.Controls.Add(Me.Label_YarnVersion)
        Me.Controls.Add(Me.Label_NodeVersion)
        Me.Controls.Add(Me.Label_GDExportVersion)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verify Needed Programs"
        CType(Me.PictureBox_GDExporterInstalled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_YarnInstalled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_NodeInstalled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_InstallGDExporter As Button
    Friend WithEvents PictureBox_GDExporterInstalled As PictureBox
    Friend WithEvents Button_Refresh As Button
    Friend WithEvents Button_GetNodeJS As Button
    Friend WithEvents Button_InstallYarn As Button
    Friend WithEvents PictureBox_YarnInstalled As PictureBox
    Friend WithEvents PictureBox_NodeInstalled As PictureBox
    Friend WithEvents Label_YarnVersion As Label
    Friend WithEvents Label_NodeVersion As Label
    Friend WithEvents Label_GDExportVersion As Label
End Class
