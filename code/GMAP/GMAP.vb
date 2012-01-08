Public Class GMAP

    Public mouseDownPoint As Point

    Public modelPath As String
    Public materialPath As String
    Public addonDir As String
    Public fileWriter As IO.StreamWriter

    Public fileVersion As String = ".gmp12"
    Public prgmVersion As String = "GMAP 1.9r2"

    'AddResources Function - Creates force download files for servers
    Private Function AddResources(ByVal directory As String, ByVal extension As String)

        Dim current_dir As String
        Dim current_file As String
        Dim type_filter As String

        If extension = ".mdl" Then
            type_filter = "\models\"
        ElseIf extension = ".vtf" Or extension = ".vmt" Then
            type_filter = "\materials\"
        Else
            Return False
            Exit Function
        End If

        For Each current_dir In System.IO.Directory.GetDirectories(directory)
            For Each current_file In System.IO.Directory.GetFiles(current_dir)
                If System.IO.Path.GetExtension(current_file) = extension Then
                    fileWriter.WriteLine("resource.AddFile(""" + current_file.Substring(InStr(current_file, type_filter)) + """)")
                End If
            Next
            AddResources(current_dir, extension)
        Next
        Return True
    End Function

    'CreateSpawnlist Function - Create spawnlist for clients
    Private Function CreateSpawnlist(ByVal directory As String)

        Dim current_dir As String
        Dim current_file As String

        For Each current_dir In System.IO.Directory.GetDirectories(directory)
            For Each current_file In System.IO.Directory.GetFiles(current_dir)
                If System.IO.Path.GetExtension(current_file) = ".mdl" Then
                    fileWriter.WriteLine("""0""" + vbCrLf + "{" + vbCrLf + """model"" """ + current_file.Substring(InStr(current_file, "\models\")) + """" + vbCrLf + "}")
                End If
            Next
            CreateSpawnlist(current_dir)
        Next
        Return True
    End Function

    '### Choose Model - Button Function
    Private Sub ChooseModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChooseModel.Click

        Dim theFolderBrowser As New FolderBrowserDialog

        theFolderBrowser.Description = "Locate your models..."
        theFolderBrowser.ShowNewFolderButton = True
        theFolderBrowser.RootFolder = System.Environment.SpecialFolder.Desktop
        theFolderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop

        If theFolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then

            modelPath = theFolderBrowser.SelectedPath
            ChooseModelBox.Text = modelPath

        End If

    End Sub

    '### Choose Material - Button Function
    Private Sub ChooseMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChooseMaterial.Click

        Dim theFolderBrowser As New FolderBrowserDialog

        theFolderBrowser.Description = "Locate your materials..."
        theFolderBrowser.ShowNewFolderButton = True
        theFolderBrowser.RootFolder = System.Environment.SpecialFolder.Desktop
        theFolderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop

        If theFolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then

            materialPath = theFolderBrowser.SelectedPath
            ChooseMaterialBox.Text = materialPath

        End If

    End Sub

    '### Create Addon - Button Function
    Private Sub Create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Create.Click

        Dim basePath As String
        Dim modelDir As String
        Dim materialDir As String

        If My.Computer.FileSystem.DirectoryExists(modelPath) = False Then
            MessageBox.Show("The model directory does not exist! Cannot continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If My.Computer.FileSystem.DirectoryExists(materialPath) = False Then
            MessageBox.Show("The material directory does not exist! Cannot continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim theFolderBrowser As New FolderBrowserDialog

        theFolderBrowser.Description = "Where would you like to save your addon?"
        theFolderBrowser.ShowNewFolderButton = True
        theFolderBrowser.RootFolder = System.Environment.SpecialFolder.Desktop
        theFolderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop

        If theFolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then

            basePath = theFolderBrowser.SelectedPath
            addonDir = basePath + "\" + AddonName.Text
            modelDir = addonDir + "\models"
            materialDir = addonDir + "\materials"

            Try
                My.Computer.FileSystem.CreateDirectory(addonDir)
                My.Computer.FileSystem.CreateDirectory(modelDir)
                My.Computer.FileSystem.CreateDirectory(materialDir)
                My.Computer.FileSystem.CopyDirectory(modelPath, modelDir)
                My.Computer.FileSystem.CopyDirectory(materialPath, materialDir)
            Catch ex As Exception
                MessageBox.Show("Error creating/copying directories! The error was:" + vbCrLf + vbCrLf + ex.Message, "FileSystem Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            Dim currentDate As String = Date.Today
            Dim infoFile As String = addonDir + "\info.txt"

            fileWriter = New IO.StreamWriter(infoFile)
            fileWriter.Write("""Addon Info""" & vbCrLf & "{" & vbCrLf & """name"" """ & AddonName.Text & """" & vbCrLf & """version"" """ & Version.Text & """" & vbCrLf & """up_date"" """ & currentDate & """" & vbCrLf & """author_name"" """ & AuthorName.Text & """" & vbCrLf & """author_email"" """ & AuthorEmail.Text & """" & vbCrLf & """author_url"" """ & AuthorURL.Text & """" & vbCrLf & "}")
            fileWriter.Close()

            If ForceDownload.Checked Then

                Dim forceFile As String
                My.Computer.FileSystem.CreateDirectory(addonDir + "\lua\autorun\server")

                forceFile = addonDir + "\lua\autorun\server\client_forcedownloads.lua"
                fileWriter = New IO.StreamWriter(forceFile)
                fileWriter.WriteLine("--Forced client downloads" & vbCrLf & "--Don't like clients downloading from your server? Delete this file!" + vbCrLf, False)
                AddResources(addonDir, ".mdl")
                AddResources(addonDir, ".vmt")
                AddResources(addonDir, ".vtf")
                fileWriter.Close()

            End If

            If Spawnlist.Checked Then

                Dim spawnFile As String
                Dim cleanFile As String
                My.Computer.FileSystem.CreateDirectory(addonDir + "\settings\spawnlist")

                If Not My.Computer.FileSystem.FileExists(addonDir + "\lua\autorun") Then

                    My.Computer.FileSystem.CreateDirectory(addonDir + "\lua\autorun")

                End If

                spawnFile = addonDir + "\settings\spawnlist\" + AddonName.Text + ".txt"
                cleanFile = addonDir + "\lua\autorun\clean_spawnlist.lua"

                fileWriter = New IO.StreamWriter(spawnFile)
                fileWriter.WriteLine("""0""" + vbCrLf + "{" + vbCrLf + """Information""" + vbCrLf + "{" + vbCrLf + """name"" """ + AddonName.Text + """" + vbCrLf + "}" + vbCrLf + """Entries""" + vbCrLf + "{")
                CreateSpawnlist(addonDir)
                fileWriter.WriteLine("}" + vbCrLf + "}")
                fileWriter.Close()

                fileWriter = New IO.StreamWriter(cleanFile)
                fileWriter.WriteLine("--Cleanup old spawnlists" + vbCrLf + vbCrLf + "function spawnlistCleanup()" + vbCrLf + "if CLIENT then" + vbCrLf + "if file.Exists(""../settings/spawnlist/" + AddonName.Text + ".txt"") then" + vbCrLf + "file.Delete(""../settings/spawnlist/" + AddonName.Text + ".txt"")" + vbCrLf + "end" + vbCrLf + "end" + vbCrLf + "end" + vbCrLf + "hook.Add(""InitPostEntity"",""spawnlistCleanup"",spawnlistCleanup);")
                fileWriter.Close()

            End If

            MessageBox.Show("Your addon """ + AddonName.Text + """ has been packaged!", prgmVersion, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("You must choose a root directory for your addon folder!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    '### All MenuStrip functions appear below this point!
    '### ------------------------------------------------

    '### Open Configuration File - MenuStrip Function
    Private Sub OpenConfigToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenConfigToolStripMenuItem.Click

        Dim fileBrowser As New OpenFileDialog

        fileBrowser.Filter = prgmVersion + " Configuration (*" + fileVersion + ")|*" + fileVersion
        fileBrowser.Multiselect = False
        fileBrowser.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        fileBrowser.Title = "Choose a valid configuration file"

        If fileBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim cfgFile = fileBrowser.FileName
            Dim cfgText = System.IO.File.ReadAllText(cfgFile)
            Dim cfgArray = cfgText.Split(",")

            Try
                AddonName.Text = cfgArray(0)
                Version.Text = cfgArray(1)
                AuthorName.Text = cfgArray(2)
                AuthorEmail.Text = cfgArray(3)
                AuthorURL.Text = cfgArray(4)
                ForceDownload.Checked = Boolean.Parse(cfgArray(5))
                Spawnlist.Checked = Boolean.Parse(cfgArray(6))
                ChooseModelBox.Text = cfgArray(7)
                modelPath = cfgArray(7)
                ChooseMaterialBox.Text = cfgArray(8)
                materialPath = cfgArray(8)
            Catch ex As Exception
                MessageBox.Show("There was an error reading the configuration file! The error was:" + vbCrLf + vbCrLf + ex.Message, "FileSystem Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    '### Save Configuration File - MenuStrip Function
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click

        If InStr(AddonName.Text, ",") Then
            MessageBox.Show("Addon name cannot contain the following character:  "",""", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If InStr(Version.Text, ",") Then
            MessageBox.Show("Version number cannot contain the following character: "",""", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If InStr(AuthorName.Text, ",") Then
            MessageBox.Show("Author name cannot contain the following character:  "",""", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If InStr(AuthorEmail.Text, ",") Then
            MessageBox.Show("Author email cannot contain the following character:  "",""", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If InStr(AuthorURL.Text, ",") Then
            MessageBox.Show("Author URL cannot contain the following character:  "",""", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If InStr(ChooseModelBox.Text, ",") Then
            MessageBox.Show("Model path cannot contain the following character:  "",""", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If InStr(ChooseMaterialBox.Text, ",") Then
            MessageBox.Show("Material path cannot contain the following character:  "",""", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cfgPath As String
        Dim cfgFile As String
        Dim theFolderBrowser As New FolderBrowserDialog

        theFolderBrowser.Description = "Where would you like to save this configuration?"
        theFolderBrowser.ShowNewFolderButton = True
        theFolderBrowser.RootFolder = System.Environment.SpecialFolder.Desktop
        theFolderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop

        If theFolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then

            cfgPath = theFolderBrowser.SelectedPath
            cfgFile = cfgPath + "\" + AddonName.Text + "_cfg" + fileVersion

            If modelPath = "" Then
                modelPath = "null"
            End If

            If materialPath = "" Then
                materialPath = "null"
            End If

            Dim cfgWriter As New System.IO.StreamWriter(cfgFile)
            cfgWriter.Write(AddonName.Text + "," + Version.Text + "," + AuthorName.Text + "," + AuthorEmail.Text + "," + AuthorURL.Text + "," + ForceDownload.Checked.ToString + "," + Spawnlist.Checked.ToString + "," + modelPath + "," + materialPath)
            cfgWriter.Close()

        End If

    End Sub

    '### About GMAP - MenuStrip Function
    Private Sub AboutGMAPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutGMAPToolStripMenuItem.Click

        MessageBox.Show(prgmVersion & vbNewLine & vbNewLine & "Made by ntdave71694" & vbNewLine & vbNewLine & "GMAP makes packaging model addons just a *little* bit easier! Too bad I could have packaged 100 addons in the time it took me to make this stupid program ^^" + vbCrLf + vbCrLf + ".gmp** stands for the save file revision. Eg .gmp12 = GMAP Save Revision 1.2", "About GMAP...", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    '### Change Log - MenuStrip Function
    Private Sub ChangeLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeLogToolStripMenuItem.Click
        MessageBox.Show(prgmVersion + vbCrLf + vbCrLf + "Changes in this version:" + vbCrLf + vbCrLf + "-Fixed spawnlist issue" + vbCrLf + "-Included confirmation for a packaged addon" + vbCrLf + "-Combined all writers into a single fileWriter" + vbCrLf + "-UI improvements", prgmVersion + " Change Log", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    '### On Form1 Load, do this
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()

    End Sub

End Class


