<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label_GameJSONFile = New System.Windows.Forms.Label()
        Me.Label_OutputDirectory = New System.Windows.Forms.Label()
        Me.TextBox_GameJSONFile = New System.Windows.Forms.TextBox()
        Me.TextBox_OutputDirectory = New System.Windows.Forms.TextBox()
        Me.Button_Export = New System.Windows.Forms.Button()
        Me.Button_SelectGameJSONFile = New System.Windows.Forms.Button()
        Me.Button_SelectOutputDirectory = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel_GameJSONFile = New System.Windows.Forms.Panel()
        Me.Panel_OutputDirectory = New System.Windows.Forms.Panel()
        Me.RadioButton_Electron = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Cordova = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Facebook = New System.Windows.Forms.RadioButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel_GameJSONFile.SuspendLayout()
        Me.Panel_OutputDirectory.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_GameJSONFile
        '
        Me.Label_GameJSONFile.AutoSize = True
        Me.Label_GameJSONFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_GameJSONFile.Location = New System.Drawing.Point(8, 8)
        Me.Label_GameJSONFile.Name = "Label_GameJSONFile"
        Me.Label_GameJSONFile.Size = New System.Drawing.Size(99, 13)
        Me.Label_GameJSONFile.TabIndex = 0
        Me.Label_GameJSONFile.Text = "Game JSON File"
        '
        'Label_OutputDirectory
        '
        Me.Label_OutputDirectory.AutoSize = True
        Me.Label_OutputDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_OutputDirectory.Location = New System.Drawing.Point(8, 8)
        Me.Label_OutputDirectory.Name = "Label_OutputDirectory"
        Me.Label_OutputDirectory.Size = New System.Drawing.Size(100, 13)
        Me.Label_OutputDirectory.TabIndex = 1
        Me.Label_OutputDirectory.Text = "Output Directory"
        '
        'TextBox_GameJSONFile
        '
        Me.TextBox_GameJSONFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_GameJSONFile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_GameJSONFile.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_GameJSONFile.Location = New System.Drawing.Point(16, 32)
        Me.TextBox_GameJSONFile.Name = "TextBox_GameJSONFile"
        Me.TextBox_GameJSONFile.Size = New System.Drawing.Size(296, 13)
        Me.TextBox_GameJSONFile.TabIndex = 2
        '
        'TextBox_OutputDirectory
        '
        Me.TextBox_OutputDirectory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_OutputDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_OutputDirectory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_OutputDirectory.Location = New System.Drawing.Point(16, 32)
        Me.TextBox_OutputDirectory.Name = "TextBox_OutputDirectory"
        Me.TextBox_OutputDirectory.Size = New System.Drawing.Size(296, 13)
        Me.TextBox_OutputDirectory.TabIndex = 3
        '
        'Button_Export
        '
        Me.Button_Export.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Export.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Export.FlatAppearance.BorderSize = 0
        Me.Button_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Export.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Export.Location = New System.Drawing.Point(272, 120)
        Me.Button_Export.Name = "Button_Export"
        Me.Button_Export.Size = New System.Drawing.Size(112, 24)
        Me.Button_Export.TabIndex = 4
        Me.Button_Export.Text = "Export"
        Me.Button_Export.UseVisualStyleBackColor = False
        '
        'Button_SelectGameJSONFile
        '
        Me.Button_SelectGameJSONFile.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_SelectGameJSONFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_SelectGameJSONFile.FlatAppearance.BorderSize = 0
        Me.Button_SelectGameJSONFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SelectGameJSONFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SelectGameJSONFile.Location = New System.Drawing.Point(328, 24)
        Me.Button_SelectGameJSONFile.Name = "Button_SelectGameJSONFile"
        Me.Button_SelectGameJSONFile.Size = New System.Drawing.Size(56, 24)
        Me.Button_SelectGameJSONFile.TabIndex = 5
        Me.Button_SelectGameJSONFile.Text = "..."
        Me.Button_SelectGameJSONFile.UseVisualStyleBackColor = False
        '
        'Button_SelectOutputDirectory
        '
        Me.Button_SelectOutputDirectory.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_SelectOutputDirectory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_SelectOutputDirectory.FlatAppearance.BorderSize = 0
        Me.Button_SelectOutputDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SelectOutputDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SelectOutputDirectory.Location = New System.Drawing.Point(328, 24)
        Me.Button_SelectOutputDirectory.Name = "Button_SelectOutputDirectory"
        Me.Button_SelectOutputDirectory.Size = New System.Drawing.Size(56, 24)
        Me.Button_SelectOutputDirectory.TabIndex = 6
        Me.Button_SelectOutputDirectory.Text = "..."
        Me.Button_SelectOutputDirectory.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "json files (*.json)|*.json"
        '
        'Panel_GameJSONFile
        '
        Me.Panel_GameJSONFile.AllowDrop = True
        Me.Panel_GameJSONFile.Controls.Add(Me.Label_GameJSONFile)
        Me.Panel_GameJSONFile.Controls.Add(Me.TextBox_GameJSONFile)
        Me.Panel_GameJSONFile.Controls.Add(Me.Button_SelectGameJSONFile)
        Me.Panel_GameJSONFile.Controls.Add(Me.ShapeContainer1)
        Me.Panel_GameJSONFile.Location = New System.Drawing.Point(0, 0)
        Me.Panel_GameJSONFile.Name = "Panel_GameJSONFile"
        Me.Panel_GameJSONFile.Size = New System.Drawing.Size(392, 56)
        Me.Panel_GameJSONFile.TabIndex = 7
        '
        'Panel_OutputDirectory
        '
        Me.Panel_OutputDirectory.AllowDrop = True
        Me.Panel_OutputDirectory.Controls.Add(Me.Label_OutputDirectory)
        Me.Panel_OutputDirectory.Controls.Add(Me.TextBox_OutputDirectory)
        Me.Panel_OutputDirectory.Controls.Add(Me.Button_SelectOutputDirectory)
        Me.Panel_OutputDirectory.Controls.Add(Me.ShapeContainer2)
        Me.Panel_OutputDirectory.Location = New System.Drawing.Point(0, 56)
        Me.Panel_OutputDirectory.Name = "Panel_OutputDirectory"
        Me.Panel_OutputDirectory.Size = New System.Drawing.Size(392, 56)
        Me.Panel_OutputDirectory.TabIndex = 8
        '
        'RadioButton_Electron
        '
        Me.RadioButton_Electron.Checked = True
        Me.RadioButton_Electron.Location = New System.Drawing.Point(16, 120)
        Me.RadioButton_Electron.Name = "RadioButton_Electron"
        Me.RadioButton_Electron.Size = New System.Drawing.Size(72, 24)
        Me.RadioButton_Electron.TabIndex = 9
        Me.RadioButton_Electron.TabStop = True
        Me.RadioButton_Electron.Text = "Electron"
        Me.RadioButton_Electron.UseVisualStyleBackColor = True
        '
        'RadioButton_Cordova
        '
        Me.RadioButton_Cordova.Location = New System.Drawing.Point(96, 120)
        Me.RadioButton_Cordova.Name = "RadioButton_Cordova"
        Me.RadioButton_Cordova.Size = New System.Drawing.Size(72, 24)
        Me.RadioButton_Cordova.TabIndex = 10
        Me.RadioButton_Cordova.Text = "Cordova"
        Me.RadioButton_Cordova.UseVisualStyleBackColor = True
        '
        'RadioButton_Facebook
        '
        Me.RadioButton_Facebook.Location = New System.Drawing.Point(176, 120)
        Me.RadioButton_Facebook.Name = "RadioButton_Facebook"
        Me.RadioButton_Facebook.Size = New System.Drawing.Size(80, 24)
        Me.RadioButton_Facebook.TabIndex = 11
        Me.RadioButton_Facebook.Text = "Facebook"
        Me.RadioButton_Facebook.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(392, 56)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(312, 24)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape2.CornerRadius = 3
        Me.RectangleShape2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape2.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Size = New System.Drawing.Size(312, 24)
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(392, 56)
        Me.ShapeContainer2.TabIndex = 7
        Me.ShapeContainer2.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(392, 153)
        Me.Controls.Add(Me.RadioButton_Facebook)
        Me.Controls.Add(Me.RadioButton_Cordova)
        Me.Controls.Add(Me.RadioButton_Electron)
        Me.Controls.Add(Me.Panel_OutputDirectory)
        Me.Controls.Add(Me.Panel_GameJSONFile)
        Me.Controls.Add(Me.Button_Export)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDExporter"
        Me.Panel_GameJSONFile.ResumeLayout(False)
        Me.Panel_GameJSONFile.PerformLayout()
        Me.Panel_OutputDirectory.ResumeLayout(False)
        Me.Panel_OutputDirectory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_GameJSONFile As Label
    Friend WithEvents Label_OutputDirectory As Label
    Friend WithEvents TextBox_GameJSONFile As TextBox
    Friend WithEvents TextBox_OutputDirectory As TextBox
    Friend WithEvents Button_Export As Button
    Friend WithEvents Button_SelectGameJSONFile As Button
    Friend WithEvents Button_SelectOutputDirectory As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel_GameJSONFile As Panel
    Friend WithEvents Panel_OutputDirectory As Panel
    Friend WithEvents RadioButton_Electron As RadioButton
    Friend WithEvents RadioButton_Cordova As RadioButton
    Friend WithEvents RadioButton_Facebook As RadioButton
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents ShapeContainer2 As ShapeContainer
    Friend WithEvents RectangleShape2 As RectangleShape
End Class
