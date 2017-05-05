Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class Form1

    Private SrcDir As String
    Private OutputDir As String
    Private MapFile As String
    Private OutputFolderName As String
    Private OutputPath As String
    Private OutTexturesDir As String
    Private OutSoundsDir As String
    Private IncludeTextures As Boolean
    Private IncludeModels As Boolean
    Private IncludeSounds As Boolean
    Private MissingLogFile As String

    Class ProgressState
        Property Log As String
    End Class

    Private Sub BrowseSourceButton_Click(sender As Object, e As EventArgs) Handles BrowseSourceButton.Click

        FolderBrowserDialog1.ShowNewFolderButton = False
        FolderBrowserDialog1.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If Not String.IsNullOrEmpty(My.Settings.Source) Then
            If My.Computer.FileSystem.DirectoryExists(My.Settings.Source) Then
                FolderBrowserDialog1.SelectedPath = My.Settings.Source
            End If
        End If

        If FolderBrowserDialog1.ShowDialog(Me) = DialogResult.OK Then
            SourceTextBox.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.Save()
        End If
    End Sub

    Private Sub BrowseOutputButton_Click(sender As Object, e As EventArgs) Handles BrowseOutputButton.Click

        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If Not String.IsNullOrEmpty(My.Settings.Destination) Then
            If My.Computer.FileSystem.DirectoryExists(My.Settings.Destination) Then
                FolderBrowserDialog1.SelectedPath = My.Settings.Destination
            End If
        End If

        If FolderBrowserDialog1.ShowDialog(Me) = DialogResult.OK Then
            OutputTextBox.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.Save()
        End If
    End Sub

    Private Sub BrowseMapButton_Click(sender As Object, e As EventArgs) Handles BrowseMapButton.Click

        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            MapTextBox.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click

        LogTextBox.Clear()
        LogTextBox.MaxLength = Integer.MaxValue

        SrcDir = SourceTextBox.Text
        OutputDir = OutputTextBox.Text
        MapFile = MapTextBox.Text
        OutputFolderName = IO.Path.GetFileNameWithoutExtension(MapFile) & ".pk3"
        OutputPath = IO.Path.Combine(OutputDir, OutputFolderName)
        OutTexturesDir = IO.Path.Combine(OutputPath, "textures")
        OutSoundsDir = IO.Path.Combine(OutputPath, "sound")
        IncludeModels = ModelsCheckBox.Checked
        IncludeTextures = TexturesCheckBox.Checked
        IncludeSounds = SoundsCheckBox.Checked
        MissingLogFile = IO.Path.Combine(OutputDir, OutputFolderName & ".missing.txt")

        If String.IsNullOrEmpty(SrcDir) Then
            MessageBox.Show("Choose source directory", "Bad source directory", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not My.Computer.FileSystem.DirectoryExists(SrcDir) Then
            MessageBox.Show("Source directory not exists", "Bad source directory", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrEmpty(OutputDir) Then
            MessageBox.Show("Choose output directory", "Bad output directory", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not My.Computer.FileSystem.DirectoryExists(OutputDir) Then
            MessageBox.Show("Output directory not exists", "Bad output directory", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrEmpty(MapFile) Then
            MessageBox.Show("Choose map file", "Bad map file", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not My.Computer.FileSystem.FileExists(MapFile) Then
            MessageBox.Show("Map file not exists", "Bad map file", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If My.Computer.FileSystem.DirectoryExists(OutputPath) Then

            If MessageBox.Show(String.Format("Output folder {0} already exists in output directory. All files will be deleted. Use it anyway?", OutputFolderName), "Output folder already exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        End If

        SettingsGroupBox.Enabled = False
        IncludeGroupBox.Enabled = False
        GoButton.Enabled = False
        ProgressBar1.Visible = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        'example .map file
        '
        '// entity 0
        '{
        '"eyeadaptation_scale" "1.0"
        '"eyeadaptation_sky" "1.0"
        '"exposure" "20"
        '"_minlight" "0.0001"
        '"gridsize" "32 32 48"
        '"_BLAminvertexlight" "10"
        '"atmosphere" "T=SNOW,B=5 10,C=0.5,G=0.5 2,BV=50 50,GV=100 100,W=1 1.5,D=4000"
        '"classname" "worldspawn"
        '"_BLAminlight" "10"
        '"_BLAmingridlight" "10"
        '"_color" "0.8 0.8 0.9"
        '"message" "Deadly Xmas"
        '"mapcoordsmaxs" "4608 -3584"
        '"mapcoordsmins" "-1792 2816"
        '// brush 0
        '{
        '( -1472 640 -80 ) ( -1472 -896 -80 ) ( -1472 -896 -112 ) common/clip 0 16 0 0.500000 0.500000 0 0 0
        '( 2648 2624 -80 ) ( 920 2624 -80 ) ( 920 2624 -112 ) common/clip -48 16 0 0.500000 0.500000 0 0 0
        '( 4288 -816 -80 ) ( 4288 720 -80 ) ( 4288 720 -112 ) common/clip 0 16 0 0.500000 0.500000 0 0 0
        '( 904 -3328 -80 ) ( 2632 -3328 -80 ) ( 2632 -3328 -112 ) common/clip -48 16 0 0.500000 0.500000 0 0 0
        '( 952 -736 392 ) ( 952 800 392 ) ( 2680 800 392 ) common/clip -48 0 0 0.500000 0.500000 0 0 0
        '( 2648 768 276 ) ( 920 768 276 ) ( 920 -768 276 ) common/clip -48 0 0 0.500000 0.500000 0 0 0
        '}
        '}
        '// entity 312
        '{
        '"model" "models/multiplayer/ctf/backpack_dropped_blue.md3"
        '"classname" "team_CTF_blueflag"
        '"origin" "1512 1312 0"
        '"scriptname" "flagspecops"
        '}
        '// entity 413
        '{
        '"classname" "target_speaker"
        '"origin" "2646 1698 76"
        '"spawnflags" "1"
        '"noise" "sound/q3tc/light_hum1.wav"
        '"volume" "200"
        '"radius" "768"
        '}

        Dim textureFiles As New HashSet(Of String)
        Dim soundFiles As New HashSet(Of String)
        Dim modelFiles As New HashSet(Of String)
        Dim mapName = IO.Path.GetFileNameWithoutExtension(MapFile)

        If My.Computer.FileSystem.DirectoryExists(OutputPath) Then

            My.Computer.FileSystem.DeleteDirectory(OutputPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If

        My.Computer.FileSystem.CreateDirectory(OutputPath)

        If IO.Directory.Exists(IO.Path.Combine(SrcDir, "levelshots")) Then
            Dim levelshotFiles = My.Computer.FileSystem.GetFiles(IO.Path.Combine(SrcDir, "levelshots"), FileIO.SearchOption.SearchTopLevelOnly, mapName & ".*")

            If levelshotFiles.Count > 0 Then

                Dim levelshotsOutDir = IO.Path.Combine(OutputPath, "levelshots")

                IO.Directory.CreateDirectory(levelshotsOutDir)

                For Each lshot In levelshotFiles
                    Trace.WriteLine(IO.Path.Combine(levelshotsOutDir, IO.Path.GetFileName(lshot)))
                    IO.File.Copy(lshot, IO.Path.Combine(levelshotsOutDir, IO.Path.GetFileName(lshot)))
                Next
            End If
        End If

        Using sr As New IO.StreamReader(MapFile)

            Dim line As String
            'Dim commonRegexp As New Regex(".+\s(\S+\/\S+)\s.+")
            Dim commonRegexp As New Regex(".+\s(\S+\/\S+)\s*.*")
            'Dim isFileRegexp As New Regex(".+\..+$")
            Dim commonMatch As Match
            Dim propertyName As String = String.Empty
            Dim propertyValue As String = String.Empty

            While sr.Peek() >= 0

                line = sr.ReadLine().Trim()

                propertyName = String.Empty
                propertyValue = String.Empty

                If line.StartsWith("//") Then
                    ' ignore comments
                    Continue While
                End If
                If (line = "{") OrElse (line = "}") Then
                    ' begin/end entity
                    Continue While
                End If
                If line.StartsWith("""") AndAlso (line.IndexOf("""", 1) > -1) Then

                    propertyName = line.Substring(1, line.IndexOf("""", 1) - 1)
                    propertyValue = line.Substring(line.IndexOf("""", 1) + 1).Replace("""", "").Trim()

                ElseIf line.StartsWith("(") Then

                    propertyName = "brush"
                    propertyValue = line
                End If

                Select Case True
                    Case IncludeModels AndAlso (propertyName = "model" OrElse propertyName = "model_lod1" OrElse propertyName = "model_lod2" OrElse propertyName = "model_lod3") AndAlso propertyValue.StartsWith("models/")
                        modelFiles.Add(propertyValue.Substring(7, propertyValue.Length - 7).Replace("/", IO.Path.DirectorySeparatorChar))
                    Case IncludeSounds AndAlso (propertyName = "noise") AndAlso propertyValue.StartsWith("sound/")
                        soundFiles.Add(propertyValue.Substring(6, propertyValue.Length - 6).Replace("/", IO.Path.DirectorySeparatorChar))
                    Case IncludeTextures AndAlso (propertyName = "brush")
                        ' brushes
                        commonMatch = commonRegexp.Match(propertyValue)
                        If commonMatch.Success Then
                            textureFiles.Add(commonMatch.Groups(1).Value.Replace("/", IO.Path.DirectorySeparatorChar))
                        End If
                End Select
            End While
        End Using

        For Each model In modelFiles

            Dim srcFile = IO.Path.Combine(SrcDir, "models", model)
            Dim outFileToCreate = IO.Path.Combine(OutputPath, "models", model)
            Dim outDirName = IO.Path.GetDirectoryName(outFileToCreate)

            If IO.File.Exists(srcFile) Then
                If Not IO.Directory.Exists(outDirName) Then
                    IO.Directory.CreateDirectory(outDirName)
                End If

                IO.File.Copy(srcFile, outFileToCreate)
            Else
                LogOutput(String.Format("Missing: {0}", srcFile))
            End If
        Next
        For Each sound In soundFiles

            Dim srcFile = IO.Path.Combine(SrcDir, "sound", sound)
            Dim outFileToCreate = IO.Path.Combine(OutputPath, "sound", sound)
            Dim outDirName = IO.Path.GetDirectoryName(outFileToCreate)

            If IO.File.Exists(srcFile) Then

                If Not IO.Directory.Exists(outDirName) Then
                    IO.Directory.CreateDirectory(outDirName)
                End If

                IO.File.Copy(srcFile, outFileToCreate)
            Else
                LogOutput(String.Format("Missing: {0}", srcFile))
            End If
        Next
        For Each texture In textureFiles

            Dim srcFileWithoutExt = IO.Path.Combine(SrcDir, "textures", texture)
            Dim srcFileNameWithoutExt = IO.Path.GetFileName(texture)
            Dim srcTextureFolder = IO.Path.GetDirectoryName(srcFileWithoutExt & ".ext")
            Dim outFileWithoutExt = IO.Path.Combine(OutputPath, "textures", texture)
            Dim outDirName = IO.Path.GetDirectoryName(outFileWithoutExt & ".ext") ' add .ext to cheat GetDirectoryName

            If IO.Directory.Exists(srcTextureFolder) Then

                Dim files = My.Computer.FileSystem.GetFiles(srcTextureFolder, FileIO.SearchOption.SearchTopLevelOnly, srcFileNameWithoutExt & ".*")

                If files.Count > 0 Then
                    For Each t In files
                        If Not IO.Directory.Exists(outDirName) Then
                            IO.Directory.CreateDirectory(outDirName)
                        End If
                        IO.File.Copy(t, IO.Path.Combine(outDirName, IO.Path.GetFileName(t)))
                    Next
                Else
                    LogOutput(String.Format("Missing: {0}", srcFileWithoutExt))
                End If
            Else
                LogOutput(String.Format("Missing: {0}", srcFileWithoutExt))
            End If
        Next
    End Sub

    Private Sub LogOutput(text As String)

        BackgroundWorker1.ReportProgress(0, New ProgressState With {.Log = text})
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        ProgressBar1.Visible = False
        SettingsGroupBox.Enabled = True
        IncludeGroupBox.Enabled = True
        GoButton.Enabled = True

        If e.Error IsNot Nothing Then
            MessageBox.Show("Operation has been interrupted by error: " & vbCrLf & e.Error.ToString(), "Error - Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.Cancelled Then
            MessageBox.Show("Operation has been interrupted by user", "Interrupted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Operation completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Dim f As New AboutBox1()
        f.ShowDialog(Me)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        Dim obj As ProgressState = e.UserState

        If Not String.IsNullOrEmpty(obj.Log) Then
            LogTextBox.AppendText(obj.Log & vbCrLf)
        End If
    End Sub
End Class
