<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button_Build = New System.Windows.Forms.Button()
        Me.CheckBox_Zip = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Installer = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Unpacked = New System.Windows.Forms.CheckBox()
        Me.Label_DagDrop = New System.Windows.Forms.Label()
        Me.Label_PackageDirectory = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GDExporterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerifyNeededProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Build
        '
        Me.Button_Build.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Build.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Build.FlatAppearance.BorderSize = 0
        Me.Button_Build.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Build.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Build.Location = New System.Drawing.Point(264, 128)
        Me.Button_Build.Name = "Button_Build"
        Me.Button_Build.Size = New System.Drawing.Size(96, 24)
        Me.Button_Build.TabIndex = 6
        Me.Button_Build.Text = "Build"
        Me.Button_Build.UseVisualStyleBackColor = False
        '
        'CheckBox_Zip
        '
        Me.CheckBox_Zip.Location = New System.Drawing.Point(16, 128)
        Me.CheckBox_Zip.Name = "CheckBox_Zip"
        Me.CheckBox_Zip.Size = New System.Drawing.Size(48, 24)
        Me.CheckBox_Zip.TabIndex = 7
        Me.CheckBox_Zip.Text = "Zip"
        Me.CheckBox_Zip.UseVisualStyleBackColor = True
        '
        'CheckBox_Installer
        '
        Me.CheckBox_Installer.Location = New System.Drawing.Point(72, 128)
        Me.CheckBox_Installer.Name = "CheckBox_Installer"
        Me.CheckBox_Installer.Size = New System.Drawing.Size(72, 24)
        Me.CheckBox_Installer.TabIndex = 9
        Me.CheckBox_Installer.Text = "Installer"
        Me.CheckBox_Installer.UseVisualStyleBackColor = True
        '
        'CheckBox_Unpacked
        '
        Me.CheckBox_Unpacked.Checked = True
        Me.CheckBox_Unpacked.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Unpacked.Enabled = False
        Me.CheckBox_Unpacked.Location = New System.Drawing.Point(152, 128)
        Me.CheckBox_Unpacked.Name = "CheckBox_Unpacked"
        Me.CheckBox_Unpacked.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox_Unpacked.TabIndex = 10
        Me.CheckBox_Unpacked.Text = "Unpacked"
        Me.CheckBox_Unpacked.UseVisualStyleBackColor = True
        '
        'Label_DagDrop
        '
        Me.Label_DagDrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DagDrop.Location = New System.Drawing.Point(8, 32)
        Me.Label_DagDrop.Name = "Label_DagDrop"
        Me.Label_DagDrop.Size = New System.Drawing.Size(352, 23)
        Me.Label_DagDrop.TabIndex = 11
        Me.Label_DagDrop.Text = "Drag && Drop Package Directory Here"
        Me.Label_DagDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_PackageDirectory
        '
        Me.Label_PackageDirectory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label_PackageDirectory.Location = New System.Drawing.Point(16, 64)
        Me.Label_PackageDirectory.Name = "Label_PackageDirectory"
        Me.Label_PackageDirectory.Size = New System.Drawing.Size(336, 48)
        Me.Label_PackageDirectory.TabIndex = 13
        Me.Label_PackageDirectory.Text = "Package Directory..."
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.Location = New System.Drawing.Point(8, 56)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(352, 64)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(368, 160)
        Me.ShapeContainer1.TabIndex = 19
        Me.ShapeContainer1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(368, 29)
        Me.MenuStrip1.TabIndex = 87
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GDExporterToolStripMenuItem, Me.VerifyNeededProgramsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(57, 25)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'GDExporterToolStripMenuItem
        '
        Me.GDExporterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GDExporterToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GDExporterToolStripMenuItem.Name = "GDExporterToolStripMenuItem"
        Me.GDExporterToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.GDExporterToolStripMenuItem.Text = "GDExporter"
        '
        'VerifyNeededProgramsToolStripMenuItem
        '
        Me.VerifyNeededProgramsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.VerifyNeededProgramsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.VerifyNeededProgramsToolStripMenuItem.Name = "VerifyNeededProgramsToolStripMenuItem"
        Me.VerifyNeededProgramsToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.VerifyNeededProgramsToolStripMenuItem.Text = "Verify Needed Programs"
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(368, 160)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label_PackageDirectory)
        Me.Controls.Add(Me.Label_DagDrop)
        Me.Controls.Add(Me.CheckBox_Unpacked)
        Me.Controls.Add(Me.CheckBox_Installer)
        Me.Controls.Add(Me.CheckBox_Zip)
        Me.Controls.Add(Me.Button_Build)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDev Manual Build Helper"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Build As Button
    Friend WithEvents CheckBox_Zip As CheckBox
    Friend WithEvents CheckBox_Installer As CheckBox
    Friend WithEvents CheckBox_Unpacked As CheckBox
    Friend WithEvents Label_DagDrop As Label
    Friend WithEvents Label_PackageDirectory As Label
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GDExporterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerifyNeededProgramsToolStripMenuItem As ToolStripMenuItem
End Class
