<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.BrowseOutputButton = New System.Windows.Forms.Button()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BrowseMapButton = New System.Windows.Forms.Button()
        Me.MapTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BrowseSourceButton = New System.Windows.Forms.Button()
        Me.SourceTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TexturesCheckBox = New System.Windows.Forms.CheckBox()
        Me.ModelsCheckBox = New System.Windows.Forms.CheckBox()
        Me.SoundsCheckBox = New System.Windows.Forms.CheckBox()
        Me.IncludeGroupBox = New System.Windows.Forms.GroupBox()
        Me.LogTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SettingsGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.IncludeGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingsGroupBox
        '
        Me.SettingsGroupBox.Controls.Add(Me.BrowseOutputButton)
        Me.SettingsGroupBox.Controls.Add(Me.OutputTextBox)
        Me.SettingsGroupBox.Controls.Add(Me.Label3)
        Me.SettingsGroupBox.Controls.Add(Me.BrowseMapButton)
        Me.SettingsGroupBox.Controls.Add(Me.MapTextBox)
        Me.SettingsGroupBox.Controls.Add(Me.Label2)
        Me.SettingsGroupBox.Controls.Add(Me.BrowseSourceButton)
        Me.SettingsGroupBox.Controls.Add(Me.SourceTextBox)
        Me.SettingsGroupBox.Controls.Add(Me.Label1)
        Me.SettingsGroupBox.Location = New System.Drawing.Point(12, 31)
        Me.SettingsGroupBox.Name = "SettingsGroupBox"
        Me.SettingsGroupBox.Padding = New System.Windows.Forms.Padding(10)
        Me.SettingsGroupBox.Size = New System.Drawing.Size(718, 129)
        Me.SettingsGroupBox.TabIndex = 1
        Me.SettingsGroupBox.TabStop = False
        Me.SettingsGroupBox.Text = "General"
        '
        'BrowseOutputButton
        '
        Me.BrowseOutputButton.Location = New System.Drawing.Point(592, 57)
        Me.BrowseOutputButton.Name = "BrowseOutputButton"
        Me.BrowseOutputButton.Size = New System.Drawing.Size(105, 23)
        Me.BrowseOutputButton.TabIndex = 5
        Me.BrowseOutputButton.Text = "Browse..."
        Me.BrowseOutputButton.UseVisualStyleBackColor = True
        '
        'OutputTextBox
        '
        Me.OutputTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Pk3Creator.My.MySettings.Default, "Destination", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.OutputTextBox.Location = New System.Drawing.Point(95, 55)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.Size = New System.Drawing.Size(491, 22)
        Me.OutputTextBox.TabIndex = 4
        Me.OutputTextBox.Text = Global.Pk3Creator.My.MySettings.Default.Destination
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Output dir:"
        '
        'BrowseMapButton
        '
        Me.BrowseMapButton.Location = New System.Drawing.Point(592, 86)
        Me.BrowseMapButton.Name = "BrowseMapButton"
        Me.BrowseMapButton.Size = New System.Drawing.Size(105, 23)
        Me.BrowseMapButton.TabIndex = 8
        Me.BrowseMapButton.Text = "Browse..."
        Me.BrowseMapButton.UseVisualStyleBackColor = True
        '
        'MapTextBox
        '
        Me.MapTextBox.Location = New System.Drawing.Point(95, 85)
        Me.MapTextBox.Name = "MapTextBox"
        Me.MapTextBox.Size = New System.Drawing.Size(491, 22)
        Me.MapTextBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Map file:"
        '
        'BrowseSourceButton
        '
        Me.BrowseSourceButton.Location = New System.Drawing.Point(592, 28)
        Me.BrowseSourceButton.Name = "BrowseSourceButton"
        Me.BrowseSourceButton.Size = New System.Drawing.Size(105, 23)
        Me.BrowseSourceButton.TabIndex = 2
        Me.BrowseSourceButton.Text = "Browse..."
        Me.BrowseSourceButton.UseVisualStyleBackColor = True
        '
        'SourceTextBox
        '
        Me.SourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Pk3Creator.My.MySettings.Default, "Source", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SourceTextBox.Location = New System.Drawing.Point(95, 28)
        Me.SourceTextBox.Name = "SourceTextBox"
        Me.SourceTextBox.Size = New System.Drawing.Size(491, 22)
        Me.SourceTextBox.TabIndex = 1
        Me.SourceTextBox.Text = Global.Pk3Creator.My.MySettings.Default.Source
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source dir:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(747, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(125, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(604, 660)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(126, 46)
        Me.GoButton.TabIndex = 2
        Me.GoButton.Text = "Go!"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Map files|*.map"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 672)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(586, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Visible = False
        '
        'TexturesCheckBox
        '
        Me.TexturesCheckBox.AutoSize = True
        Me.TexturesCheckBox.Checked = True
        Me.TexturesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TexturesCheckBox.Location = New System.Drawing.Point(95, 28)
        Me.TexturesCheckBox.Name = "TexturesCheckBox"
        Me.TexturesCheckBox.Size = New System.Drawing.Size(85, 21)
        Me.TexturesCheckBox.TabIndex = 9
        Me.TexturesCheckBox.Text = "Textures"
        Me.TexturesCheckBox.UseVisualStyleBackColor = True
        '
        'ModelsCheckBox
        '
        Me.ModelsCheckBox.AutoSize = True
        Me.ModelsCheckBox.Checked = True
        Me.ModelsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ModelsCheckBox.Location = New System.Drawing.Point(186, 28)
        Me.ModelsCheckBox.Name = "ModelsCheckBox"
        Me.ModelsCheckBox.Size = New System.Drawing.Size(75, 21)
        Me.ModelsCheckBox.TabIndex = 10
        Me.ModelsCheckBox.Text = "Models"
        Me.ModelsCheckBox.UseVisualStyleBackColor = True
        '
        'SoundsCheckBox
        '
        Me.SoundsCheckBox.AutoSize = True
        Me.SoundsCheckBox.Checked = True
        Me.SoundsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SoundsCheckBox.Location = New System.Drawing.Point(267, 28)
        Me.SoundsCheckBox.Name = "SoundsCheckBox"
        Me.SoundsCheckBox.Size = New System.Drawing.Size(78, 21)
        Me.SoundsCheckBox.TabIndex = 11
        Me.SoundsCheckBox.Text = "Sounds"
        Me.SoundsCheckBox.UseVisualStyleBackColor = True
        '
        'IncludeGroupBox
        '
        Me.IncludeGroupBox.Controls.Add(Me.TexturesCheckBox)
        Me.IncludeGroupBox.Controls.Add(Me.SoundsCheckBox)
        Me.IncludeGroupBox.Controls.Add(Me.ModelsCheckBox)
        Me.IncludeGroupBox.Location = New System.Drawing.Point(12, 166)
        Me.IncludeGroupBox.Name = "IncludeGroupBox"
        Me.IncludeGroupBox.Padding = New System.Windows.Forms.Padding(10)
        Me.IncludeGroupBox.Size = New System.Drawing.Size(718, 66)
        Me.IncludeGroupBox.TabIndex = 12
        Me.IncludeGroupBox.TabStop = False
        Me.IncludeGroupBox.Text = "Include"
        '
        'LogTextBox
        '
        Me.LogTextBox.Location = New System.Drawing.Point(13, 28)
        Me.LogTextBox.Multiline = True
        Me.LogTextBox.Name = "LogTextBox"
        Me.LogTextBox.ReadOnly = True
        Me.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.LogTextBox.Size = New System.Drawing.Size(692, 375)
        Me.LogTextBox.TabIndex = 13
        Me.LogTextBox.WordWrap = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LogTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 238)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Size = New System.Drawing.Size(718, 416)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output log"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 718)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.IncludeGroupBox)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.SettingsGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pk3 Creator"
        Me.SettingsGroupBox.ResumeLayout(False)
        Me.SettingsGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.IncludeGroupBox.ResumeLayout(False)
        Me.IncludeGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SettingsGroupBox As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GoButton As Button
    Friend WithEvents BrowseOutputButton As Button
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BrowseMapButton As Button
    Friend WithEvents MapTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BrowseSourceButton As Button
    Friend WithEvents SourceTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents SoundsCheckBox As CheckBox
    Friend WithEvents ModelsCheckBox As CheckBox
    Friend WithEvents TexturesCheckBox As CheckBox
    Friend WithEvents IncludeGroupBox As GroupBox
    Friend WithEvents LogTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
