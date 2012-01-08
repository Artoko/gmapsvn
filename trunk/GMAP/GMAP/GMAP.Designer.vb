<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GMAP
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutGMAPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForceDownload = New System.Windows.Forms.CheckBox()
        Me.AddonName = New System.Windows.Forms.TextBox()
        Me.AddonNameLabel = New System.Windows.Forms.Label()
        Me.AuthorNameLabel = New System.Windows.Forms.Label()
        Me.AuthorURL = New System.Windows.Forms.TextBox()
        Me.AuthorName = New System.Windows.Forms.TextBox()
        Me.Version = New System.Windows.Forms.TextBox()
        Me.AuthorURLLabel = New System.Windows.Forms.Label()
        Me.AuthorEmailLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.AuthorEmail = New System.Windows.Forms.TextBox()
        Me.Spawnlist = New System.Windows.Forms.CheckBox()
        Me.ChooseModelLabel = New System.Windows.Forms.Label()
        Me.ChooseMaterialLabel = New System.Windows.Forms.Label()
        Me.ChooseMaterial = New System.Windows.Forms.Button()
        Me.ChooseModel = New System.Windows.Forms.Button()
        Me.ChooseMaterialBox = New System.Windows.Forms.TextBox()
        Me.ChooseModelBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Create = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(293, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenConfigToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenConfigToolStripMenuItem
        '
        Me.OpenConfigToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OpenConfigToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OpenConfigToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OpenConfigToolStripMenuItem.Name = "OpenConfigToolStripMenuItem"
        Me.OpenConfigToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.OpenConfigToolStripMenuItem.Text = "Open Config..."
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SaveAsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save Config To..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutGMAPToolStripMenuItem, Me.ChangeLogToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutGMAPToolStripMenuItem
        '
        Me.AboutGMAPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AboutGMAPToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutGMAPToolStripMenuItem.Name = "AboutGMAPToolStripMenuItem"
        Me.AboutGMAPToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AboutGMAPToolStripMenuItem.Text = "About GMAP"
        '
        'ChangeLogToolStripMenuItem
        '
        Me.ChangeLogToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChangeLogToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ChangeLogToolStripMenuItem.Name = "ChangeLogToolStripMenuItem"
        Me.ChangeLogToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ChangeLogToolStripMenuItem.Text = "Change Log"
        '
        'ForceDownload
        '
        Me.ForceDownload.AutoSize = True
        Me.ForceDownload.Location = New System.Drawing.Point(15, 186)
        Me.ForceDownload.Name = "ForceDownload"
        Me.ForceDownload.Size = New System.Drawing.Size(196, 17)
        Me.ForceDownload.TabIndex = 6
        Me.ForceDownload.Text = "Force Client Downloads (for servers)"
        Me.ForceDownload.UseVisualStyleBackColor = True
        '
        'AddonName
        '
        Me.AddonName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.AddonName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.AddonName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddonName.ForeColor = System.Drawing.Color.White
        Me.AddonName.Location = New System.Drawing.Point(90, 35)
        Me.AddonName.MaxLength = 100
        Me.AddonName.Name = "AddonName"
        Me.AddonName.Size = New System.Drawing.Size(191, 20)
        Me.AddonName.TabIndex = 1
        Me.AddonName.Text = "My Addon"
        '
        'AddonNameLabel
        '
        Me.AddonNameLabel.AutoSize = True
        Me.AddonNameLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddonNameLabel.Location = New System.Drawing.Point(12, 38)
        Me.AddonNameLabel.Name = "AddonNameLabel"
        Me.AddonNameLabel.Size = New System.Drawing.Size(72, 13)
        Me.AddonNameLabel.TabIndex = 100
        Me.AddonNameLabel.Text = "Addon Name:"
        '
        'AuthorNameLabel
        '
        Me.AuthorNameLabel.AutoSize = True
        Me.AuthorNameLabel.Location = New System.Drawing.Point(12, 101)
        Me.AuthorNameLabel.Name = "AuthorNameLabel"
        Me.AuthorNameLabel.Size = New System.Drawing.Size(72, 13)
        Me.AuthorNameLabel.TabIndex = 100
        Me.AuthorNameLabel.Text = "Author Name:"
        '
        'AuthorURL
        '
        Me.AuthorURL.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AuthorURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AuthorURL.ForeColor = System.Drawing.Color.White
        Me.AuthorURL.Location = New System.Drawing.Point(101, 142)
        Me.AuthorURL.Name = "AuthorURL"
        Me.AuthorURL.Size = New System.Drawing.Size(180, 20)
        Me.AuthorURL.TabIndex = 5
        Me.AuthorURL.Text = "n/a"
        '
        'AuthorName
        '
        Me.AuthorName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AuthorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AuthorName.ForeColor = System.Drawing.Color.White
        Me.AuthorName.Location = New System.Drawing.Point(101, 98)
        Me.AuthorName.Name = "AuthorName"
        Me.AuthorName.Size = New System.Drawing.Size(180, 20)
        Me.AuthorName.TabIndex = 3
        Me.AuthorName.Text = "n/a"
        '
        'Version
        '
        Me.Version.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Version.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Version.ForeColor = System.Drawing.Color.White
        Me.Version.Location = New System.Drawing.Point(90, 58)
        Me.Version.Name = "Version"
        Me.Version.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Version.Size = New System.Drawing.Size(46, 20)
        Me.Version.TabIndex = 2
        Me.Version.Text = "1.0.0"
        '
        'AuthorURLLabel
        '
        Me.AuthorURLLabel.AutoSize = True
        Me.AuthorURLLabel.Location = New System.Drawing.Point(12, 145)
        Me.AuthorURLLabel.Name = "AuthorURLLabel"
        Me.AuthorURLLabel.Size = New System.Drawing.Size(83, 13)
        Me.AuthorURLLabel.TabIndex = 100
        Me.AuthorURLLabel.Text = "Author Website:"
        '
        'AuthorEmailLabel
        '
        Me.AuthorEmailLabel.AutoSize = True
        Me.AuthorEmailLabel.Location = New System.Drawing.Point(12, 123)
        Me.AuthorEmailLabel.Name = "AuthorEmailLabel"
        Me.AuthorEmailLabel.Size = New System.Drawing.Size(69, 13)
        Me.AuthorEmailLabel.TabIndex = 100
        Me.AuthorEmailLabel.Text = "Author Email:"
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(12, 61)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(45, 13)
        Me.VersionLabel.TabIndex = 100
        Me.VersionLabel.Text = "Version:"
        '
        'AuthorEmail
        '
        Me.AuthorEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AuthorEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AuthorEmail.ForeColor = System.Drawing.Color.White
        Me.AuthorEmail.Location = New System.Drawing.Point(101, 120)
        Me.AuthorEmail.Name = "AuthorEmail"
        Me.AuthorEmail.Size = New System.Drawing.Size(180, 20)
        Me.AuthorEmail.TabIndex = 4
        Me.AuthorEmail.Text = "n/a"
        '
        'Spawnlist
        '
        Me.Spawnlist.AutoSize = True
        Me.Spawnlist.Location = New System.Drawing.Point(15, 209)
        Me.Spawnlist.Name = "Spawnlist"
        Me.Spawnlist.Size = New System.Drawing.Size(105, 17)
        Me.Spawnlist.TabIndex = 7
        Me.Spawnlist.Text = "Create Spawnlist"
        Me.Spawnlist.UseVisualStyleBackColor = True
        '
        'ChooseModelLabel
        '
        Me.ChooseModelLabel.AutoSize = True
        Me.ChooseModelLabel.Location = New System.Drawing.Point(12, 248)
        Me.ChooseModelLabel.Name = "ChooseModelLabel"
        Me.ChooseModelLabel.Size = New System.Drawing.Size(44, 13)
        Me.ChooseModelLabel.TabIndex = 100
        Me.ChooseModelLabel.Text = "Models:"
        '
        'ChooseMaterialLabel
        '
        Me.ChooseMaterialLabel.AutoSize = True
        Me.ChooseMaterialLabel.Location = New System.Drawing.Point(12, 270)
        Me.ChooseMaterialLabel.Name = "ChooseMaterialLabel"
        Me.ChooseMaterialLabel.Size = New System.Drawing.Size(52, 13)
        Me.ChooseMaterialLabel.TabIndex = 100
        Me.ChooseMaterialLabel.Text = "Materials:"
        '
        'ChooseMaterial
        '
        Me.ChooseMaterial.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChooseMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChooseMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChooseMaterial.ForeColor = System.Drawing.Color.White
        Me.ChooseMaterial.Location = New System.Drawing.Point(215, 265)
        Me.ChooseMaterial.Name = "ChooseMaterial"
        Me.ChooseMaterial.Size = New System.Drawing.Size(66, 23)
        Me.ChooseMaterial.TabIndex = 11
        Me.ChooseMaterial.Text = "Choose..."
        Me.ChooseMaterial.UseVisualStyleBackColor = False
        '
        'ChooseModel
        '
        Me.ChooseModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChooseModel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChooseModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChooseModel.ForeColor = System.Drawing.Color.White
        Me.ChooseModel.Location = New System.Drawing.Point(215, 243)
        Me.ChooseModel.Name = "ChooseModel"
        Me.ChooseModel.Size = New System.Drawing.Size(66, 23)
        Me.ChooseModel.TabIndex = 9
        Me.ChooseModel.Text = "Choose..."
        Me.ChooseModel.UseVisualStyleBackColor = False
        '
        'ChooseMaterialBox
        '
        Me.ChooseMaterialBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.ChooseMaterialBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChooseMaterialBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChooseMaterialBox.ForeColor = System.Drawing.Color.White
        Me.ChooseMaterialBox.Location = New System.Drawing.Point(70, 267)
        Me.ChooseMaterialBox.Name = "ChooseMaterialBox"
        Me.ChooseMaterialBox.Size = New System.Drawing.Size(139, 20)
        Me.ChooseMaterialBox.TabIndex = 10
        Me.ChooseMaterialBox.Text = "C:\"
        '
        'ChooseModelBox
        '
        Me.ChooseModelBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ChooseModelBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.ChooseModelBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChooseModelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChooseModelBox.ForeColor = System.Drawing.Color.White
        Me.ChooseModelBox.Location = New System.Drawing.Point(70, 245)
        Me.ChooseModelBox.Name = "ChooseModelBox"
        Me.ChooseModelBox.Size = New System.Drawing.Size(139, 20)
        Me.ChooseModelBox.TabIndex = 8
        Me.ChooseModelBox.Text = "C:\"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Label1.Size = New System.Drawing.Size(245, 64)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "GMAP assumes you have created your model and material directories in the correct " & _
            "structure. It will NOT organize your files into working order! If you don't do t" & _
            "his correctly, your addon may not work."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Create
        '
        Me.Create.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Create.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Create.Font = New System.Drawing.Font("Lucida Console", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Create.ForeColor = System.Drawing.Color.White
        Me.Create.Location = New System.Drawing.Point(24, 378)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(245, 44)
        Me.Create.TabIndex = 12
        Me.Create.Text = "Create my addon >:D"
        Me.Create.UseVisualStyleBackColor = False
        '
        'GMAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(293, 437)
        Me.Controls.Add(Me.Create)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChooseModelBox)
        Me.Controls.Add(Me.ChooseMaterialBox)
        Me.Controls.Add(Me.ChooseModel)
        Me.Controls.Add(Me.ChooseMaterial)
        Me.Controls.Add(Me.ChooseMaterialLabel)
        Me.Controls.Add(Me.ChooseModelLabel)
        Me.Controls.Add(Me.Spawnlist)
        Me.Controls.Add(Me.AuthorEmail)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.AuthorEmailLabel)
        Me.Controls.Add(Me.AuthorURLLabel)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.AuthorName)
        Me.Controls.Add(Me.AuthorURL)
        Me.Controls.Add(Me.AuthorNameLabel)
        Me.Controls.Add(Me.AddonNameLabel)
        Me.Controls.Add(Me.AddonName)
        Me.Controls.Add(Me.ForceDownload)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GMAP"
        Me.Text = "GMod Model Addon Packager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutGMAPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForceDownload As System.Windows.Forms.CheckBox
    Friend WithEvents AddonName As System.Windows.Forms.TextBox
    Friend WithEvents AddonNameLabel As System.Windows.Forms.Label
    Friend WithEvents AuthorNameLabel As System.Windows.Forms.Label
    Friend WithEvents AuthorURL As System.Windows.Forms.TextBox
    Friend WithEvents AuthorName As System.Windows.Forms.TextBox
    Friend WithEvents Version As System.Windows.Forms.TextBox
    Friend WithEvents AuthorURLLabel As System.Windows.Forms.Label
    Friend WithEvents AuthorEmailLabel As System.Windows.Forms.Label
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents AuthorEmail As System.Windows.Forms.TextBox
    Friend WithEvents Spawnlist As System.Windows.Forms.CheckBox
    Friend WithEvents ChooseModelLabel As System.Windows.Forms.Label
    Friend WithEvents ChooseMaterialLabel As System.Windows.Forms.Label
    Friend WithEvents ChooseMaterial As System.Windows.Forms.Button
    Friend WithEvents ChooseModel As System.Windows.Forms.Button
    Friend WithEvents ChooseMaterialBox As System.Windows.Forms.TextBox
    Friend WithEvents ChooseModelBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Create As System.Windows.Forms.Button
    Friend WithEvents OpenConfigToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
