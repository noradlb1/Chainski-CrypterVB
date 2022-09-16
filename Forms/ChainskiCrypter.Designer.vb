Namespace Chainski_Crypter.Forms
	Partial Public Class ChainskiCrypter
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChainskiCrypter))
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.label6 = New System.Windows.Forms.Label()
            Me.txtCmd = New System.Windows.Forms.TextBox()
            Me.btnPayloadBrowse = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.txtPayload = New System.Windows.Forms.TextBox()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnSecondFolderRandom = New System.Windows.Forms.Button()
            Me.txtSecondFolder = New System.Windows.Forms.TextBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.txtFoldername = New System.Windows.Forms.ComboBox()
            Me.btnRegistrynameRandom = New System.Windows.Forms.Button()
            Me.txtRegistryname = New System.Windows.Forms.TextBox()
            Me.btnFoldernameRandom = New System.Windows.Forms.Button()
            Me.btnFillenameRandom = New System.Windows.Forms.Button()
            Me.label4 = New System.Windows.Forms.Label()
            Me.txtFilename = New System.Windows.Forms.TextBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.chkInstall = New System.Windows.Forms.CheckBox()
            Me.groupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnVBC = New System.Windows.Forms.RadioButton()
            Me.btnMsBuild = New System.Windows.Forms.RadioButton()
            Me.btnItself = New System.Windows.Forms.RadioButton()
            Me.btnInstallutil = New System.Windows.Forms.RadioButton()
            Me.btnApplaunch = New System.Windows.Forms.RadioButton()
            Me.groupBox4 = New System.Windows.Forms.GroupBox()
            Me.btnIcon = New System.Windows.Forms.Button()
            Me.btnInformation = New System.Windows.Forms.Button()
            Me.groupBox5 = New System.Windows.Forms.GroupBox()
            Me.btnBuild = New System.Windows.Forms.Button()
            Me.groupBox1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            Me.groupBox4.SuspendLayout()
            Me.groupBox5.SuspendLayout()
            Me.SuspendLayout()
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray
            Me.groupBox1.Controls.Add(Me.checkBox1)
            Me.groupBox1.Controls.Add(Me.label6)
            Me.groupBox1.Controls.Add(Me.txtCmd)
            Me.groupBox1.Controls.Add(Me.btnPayloadBrowse)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.txtPayload)
            Me.groupBox1.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.ForeColor = System.Drawing.Color.Cyan
            Me.groupBox1.Location = New System.Drawing.Point(9, 11)
            Me.groupBox1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.groupBox1.Size = New System.Drawing.Size(422, 100)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Select a file"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(326, 69)
            Me.checkBox1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(15, 14)
            Me.checkBox1.TabIndex = 4
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(5, 66)
            Me.label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(97, 15)
            Me.label6.TabIndex = 3
            Me.label6.Text = "-Command Line:"
            '
            'txtCmd
            '
            Me.txtCmd.BackColor = System.Drawing.SystemColors.WindowFrame
            Me.txtCmd.Enabled = False
            Me.txtCmd.Location = New System.Drawing.Point(106, 64)
            Me.txtCmd.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.txtCmd.Name = "txtCmd"
            Me.txtCmd.Size = New System.Drawing.Size(210, 23)
            Me.txtCmd.TabIndex = 2
            '
            'btnPayloadBrowse
            '
            Me.btnPayloadBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPayloadBrowse.ForeColor = System.Drawing.Color.Cyan
            Me.btnPayloadBrowse.Location = New System.Drawing.Point(326, 24)
            Me.btnPayloadBrowse.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnPayloadBrowse.Name = "btnPayloadBrowse"
            Me.btnPayloadBrowse.Size = New System.Drawing.Size(90, 24)
            Me.btnPayloadBrowse.TabIndex = 0
            Me.btnPayloadBrowse.Text = "Choose File"
            Me.btnPayloadBrowse.UseVisualStyleBackColor = True
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(5, 29)
            Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(57, 15)
            Me.label1.TabIndex = 1
            Me.label1.Text = "-Payload:"
            '
            'txtPayload
            '
            Me.txtPayload.BackColor = System.Drawing.SystemColors.WindowFrame
            Me.txtPayload.Location = New System.Drawing.Point(106, 25)
            Me.txtPayload.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.txtPayload.Name = "txtPayload"
            Me.txtPayload.Size = New System.Drawing.Size(210, 23)
            Me.txtPayload.TabIndex = 0
            '
            'groupBox2
            '
            Me.groupBox2.BackColor = System.Drawing.Color.DarkSlateGray
            Me.groupBox2.Controls.Add(Me.btnSecondFolderRandom)
            Me.groupBox2.Controls.Add(Me.txtSecondFolder)
            Me.groupBox2.Controls.Add(Me.label5)
            Me.groupBox2.Controls.Add(Me.txtFoldername)
            Me.groupBox2.Controls.Add(Me.btnRegistrynameRandom)
            Me.groupBox2.Controls.Add(Me.txtRegistryname)
            Me.groupBox2.Controls.Add(Me.btnFoldernameRandom)
            Me.groupBox2.Controls.Add(Me.btnFillenameRandom)
            Me.groupBox2.Controls.Add(Me.label4)
            Me.groupBox2.Controls.Add(Me.txtFilename)
            Me.groupBox2.Controls.Add(Me.label3)
            Me.groupBox2.Controls.Add(Me.label2)
            Me.groupBox2.Enabled = False
            Me.groupBox2.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.ForeColor = System.Drawing.Color.Cyan
            Me.groupBox2.Location = New System.Drawing.Point(10, 146)
            Me.groupBox2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.groupBox2.Size = New System.Drawing.Size(419, 160)
            Me.groupBox2.TabIndex = 1
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Installation"
            '
            'btnSecondFolderRandom
            '
            Me.btnSecondFolderRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSecondFolderRandom.Location = New System.Drawing.Point(324, 96)
            Me.btnSecondFolderRandom.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnSecondFolderRandom.Name = "btnSecondFolderRandom"
            Me.btnSecondFolderRandom.Size = New System.Drawing.Size(78, 24)
            Me.btnSecondFolderRandom.TabIndex = 10
            Me.btnSecondFolderRandom.Text = "Random"
            Me.btnSecondFolderRandom.UseVisualStyleBackColor = True
            '
            'txtSecondFolder
            '
            Me.txtSecondFolder.BackColor = System.Drawing.SystemColors.WindowFrame
            Me.txtSecondFolder.Location = New System.Drawing.Point(105, 96)
            Me.txtSecondFolder.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.txtSecondFolder.Multiline = True
            Me.txtSecondFolder.Name = "txtSecondFolder"
            Me.txtSecondFolder.Size = New System.Drawing.Size(210, 23)
            Me.txtSecondFolder.TabIndex = 12
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(4, 100)
            Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(90, 15)
            Me.label5.TabIndex = 11
            Me.label5.Text = "-Second folder"
            '
            'txtFoldername
            '
            Me.txtFoldername.BackColor = System.Drawing.SystemColors.WindowFrame
            Me.txtFoldername.FormattingEnabled = True
            Me.txtFoldername.Location = New System.Drawing.Point(105, 65)
            Me.txtFoldername.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.txtFoldername.Name = "txtFoldername"
            Me.txtFoldername.Size = New System.Drawing.Size(210, 23)
            Me.txtFoldername.TabIndex = 9
            '
            'btnRegistrynameRandom
            '
            Me.btnRegistrynameRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRegistrynameRandom.Location = New System.Drawing.Point(324, 124)
            Me.btnRegistrynameRandom.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnRegistrynameRandom.Name = "btnRegistrynameRandom"
            Me.btnRegistrynameRandom.Size = New System.Drawing.Size(78, 24)
            Me.btnRegistrynameRandom.TabIndex = 4
            Me.btnRegistrynameRandom.Text = "Random"
            Me.btnRegistrynameRandom.UseVisualStyleBackColor = True
            '
            'txtRegistryname
            '
            Me.txtRegistryname.BackColor = System.Drawing.SystemColors.WindowFrame
            Me.txtRegistryname.Location = New System.Drawing.Point(105, 124)
            Me.txtRegistryname.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.txtRegistryname.Multiline = True
            Me.txtRegistryname.Name = "txtRegistryname"
            Me.txtRegistryname.Size = New System.Drawing.Size(210, 23)
            Me.txtRegistryname.TabIndex = 7
            '
            'btnFoldernameRandom
            '
            Me.btnFoldernameRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFoldernameRandom.Location = New System.Drawing.Point(324, 65)
            Me.btnFoldernameRandom.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnFoldernameRandom.Name = "btnFoldernameRandom"
            Me.btnFoldernameRandom.Size = New System.Drawing.Size(78, 25)
            Me.btnFoldernameRandom.TabIndex = 3
            Me.btnFoldernameRandom.Text = "Random"
            Me.btnFoldernameRandom.UseVisualStyleBackColor = True
            '
            'btnFillenameRandom
            '
            Me.btnFillenameRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFillenameRandom.Location = New System.Drawing.Point(324, 34)
            Me.btnFillenameRandom.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnFillenameRandom.Name = "btnFillenameRandom"
            Me.btnFillenameRandom.Size = New System.Drawing.Size(78, 24)
            Me.btnFillenameRandom.TabIndex = 2
            Me.btnFillenameRandom.Text = "Random"
            Me.btnFillenameRandom.UseVisualStyleBackColor = True
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(4, 126)
            Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(92, 15)
            Me.label4.TabIndex = 4
            Me.label4.Text = "-Registry name"
            '
            'txtFilename
            '
            Me.txtFilename.BackColor = System.Drawing.SystemColors.WindowFrame
            Me.txtFilename.Location = New System.Drawing.Point(105, 34)
            Me.txtFilename.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.txtFilename.Multiline = True
            Me.txtFilename.Name = "txtFilename"
            Me.txtFilename.Size = New System.Drawing.Size(210, 23)
            Me.txtFilename.TabIndex = 2
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(5, 66)
            Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(81, 15)
            Me.label3.TabIndex = 3
            Me.label3.Text = "-Folder name"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(5, 35)
            Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(65, 15)
            Me.label2.TabIndex = 0
            Me.label2.Text = "-File name"
            '
            'chkInstall
            '
            Me.chkInstall.AutoSize = True
            Me.chkInstall.Location = New System.Drawing.Point(18, 125)
            Me.chkInstall.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.chkInstall.Name = "chkInstall"
            Me.chkInstall.Size = New System.Drawing.Size(15, 14)
            Me.chkInstall.TabIndex = 1
            Me.chkInstall.UseVisualStyleBackColor = True
            '
            'groupBox3
            '
            Me.groupBox3.BackColor = System.Drawing.Color.DarkSlateGray
            Me.groupBox3.Controls.Add(Me.btnVBC)
            Me.groupBox3.Controls.Add(Me.btnMsBuild)
            Me.groupBox3.Controls.Add(Me.btnItself)
            Me.groupBox3.Controls.Add(Me.btnInstallutil)
            Me.groupBox3.Controls.Add(Me.btnApplaunch)
            Me.groupBox3.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox3.ForeColor = System.Drawing.Color.Cyan
            Me.groupBox3.Location = New System.Drawing.Point(9, 320)
            Me.groupBox3.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.groupBox3.Size = New System.Drawing.Size(421, 79)
            Me.groupBox3.TabIndex = 2
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Injection"
            '
            'btnVBC
            '
            Me.btnVBC.AutoSize = True
            Me.btnVBC.Location = New System.Drawing.Point(287, 36)
            Me.btnVBC.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnVBC.Name = "btnVBC"
            Me.btnVBC.Size = New System.Drawing.Size(45, 19)
            Me.btnVBC.TabIndex = 9
            Me.btnVBC.Text = "vbc"
            Me.btnVBC.UseVisualStyleBackColor = True
            '
            'btnMsBuild
            '
            Me.btnMsBuild.AutoSize = True
            Me.btnMsBuild.Location = New System.Drawing.Point(198, 36)
            Me.btnMsBuild.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnMsBuild.Name = "btnMsBuild"
            Me.btnMsBuild.Size = New System.Drawing.Size(71, 19)
            Me.btnMsBuild.TabIndex = 8
            Me.btnMsBuild.Text = "MSBuild"
            Me.btnMsBuild.UseVisualStyleBackColor = True
            '
            'btnItself
            '
            Me.btnItself.AutoSize = True
            Me.btnItself.Location = New System.Drawing.Point(353, 36)
            Me.btnItself.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnItself.Name = "btnItself"
            Me.btnItself.Size = New System.Drawing.Size(54, 19)
            Me.btnItself.TabIndex = 7
            Me.btnItself.Text = "Itself"
            Me.btnItself.UseVisualStyleBackColor = True
            '
            'btnInstallutil
            '
            Me.btnInstallutil.AutoSize = True
            Me.btnInstallutil.Location = New System.Drawing.Point(106, 36)
            Me.btnInstallutil.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnInstallutil.Name = "btnInstallutil"
            Me.btnInstallutil.Size = New System.Drawing.Size(78, 19)
            Me.btnInstallutil.TabIndex = 6
            Me.btnInstallutil.Text = "InstallUtil"
            Me.btnInstallutil.UseVisualStyleBackColor = True
            '
            'btnApplaunch
            '
            Me.btnApplaunch.AutoSize = True
            Me.btnApplaunch.Checked = True
            Me.btnApplaunch.Location = New System.Drawing.Point(15, 36)
            Me.btnApplaunch.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnApplaunch.Name = "btnApplaunch"
            Me.btnApplaunch.Size = New System.Drawing.Size(86, 19)
            Me.btnApplaunch.TabIndex = 5
            Me.btnApplaunch.TabStop = True
            Me.btnApplaunch.Text = "AppLaunch"
            Me.btnApplaunch.UseVisualStyleBackColor = True
            '
            'groupBox4
            '
            Me.groupBox4.BackColor = System.Drawing.Color.DarkSlateGray
            Me.groupBox4.Controls.Add(Me.btnIcon)
            Me.groupBox4.Controls.Add(Me.btnInformation)
            Me.groupBox4.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox4.ForeColor = System.Drawing.Color.Cyan
            Me.groupBox4.Location = New System.Drawing.Point(9, 415)
            Me.groupBox4.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.groupBox4.Name = "groupBox4"
            Me.groupBox4.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.groupBox4.Size = New System.Drawing.Size(421, 84)
            Me.groupBox4.TabIndex = 3
            Me.groupBox4.TabStop = False
            Me.groupBox4.Text = "Assembly"
            '
            'btnIcon
            '
            Me.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnIcon.ForeColor = System.Drawing.Color.Cyan
            Me.btnIcon.Location = New System.Drawing.Point(301, 30)
            Me.btnIcon.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnIcon.Name = "btnIcon"
            Me.btnIcon.Size = New System.Drawing.Size(102, 34)
            Me.btnIcon.TabIndex = 9
            Me.btnIcon.Text = "Icon"
            Me.btnIcon.UseVisualStyleBackColor = True
            '
            'btnInformation
            '
            Me.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnInformation.ForeColor = System.Drawing.Color.Cyan
            Me.btnInformation.Location = New System.Drawing.Point(15, 30)
            Me.btnInformation.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnInformation.Name = "btnInformation"
            Me.btnInformation.Size = New System.Drawing.Size(102, 34)
            Me.btnInformation.TabIndex = 8
            Me.btnInformation.Text = "Information"
            Me.btnInformation.UseVisualStyleBackColor = True
            '
            'groupBox5
            '
            Me.groupBox5.BackColor = System.Drawing.Color.DarkSlateGray
            Me.groupBox5.Controls.Add(Me.btnBuild)
            Me.groupBox5.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox5.ForeColor = System.Drawing.Color.Cyan
            Me.groupBox5.Location = New System.Drawing.Point(9, 501)
            Me.groupBox5.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.groupBox5.Name = "groupBox5"
            Me.groupBox5.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.groupBox5.Size = New System.Drawing.Size(421, 92)
            Me.groupBox5.TabIndex = 4
            Me.groupBox5.TabStop = False
            Me.groupBox5.Text = "Create Payload"
            '
            'btnBuild
            '
            Me.btnBuild.Enabled = False
            Me.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuild.ForeColor = System.Drawing.Color.Cyan
            Me.btnBuild.Location = New System.Drawing.Point(151, 32)
            Me.btnBuild.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.btnBuild.Name = "btnBuild"
            Me.btnBuild.Size = New System.Drawing.Size(115, 36)
            Me.btnBuild.TabIndex = 10
            Me.btnBuild.Text = "Build"
            Me.btnBuild.UseVisualStyleBackColor = True
            '
            'ChainskiCrypter
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.DarkSlateGray
            Me.ClientSize = New System.Drawing.Size(441, 600)
            Me.Controls.Add(Me.chkInstall)
            Me.Controls.Add(Me.groupBox5)
            Me.Controls.Add(Me.groupBox4)
            Me.Controls.Add(Me.groupBox3)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.groupBox2)
            Me.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.DarkSlateGray
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.MaximizeBox = False
            Me.Name = "ChainskiCrypter"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chainski Crypter"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox3.PerformLayout()
            Me.groupBox4.ResumeLayout(False)
            Me.groupBox5.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents btnPayloadBrowse As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private txtPayload As System.Windows.Forms.TextBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private label2 As System.Windows.Forms.Label
		Private WithEvents chkInstall As System.Windows.Forms.CheckBox
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private WithEvents btnRegistrynameRandom As System.Windows.Forms.Button
		Private txtRegistryname As System.Windows.Forms.TextBox
		Private WithEvents btnFoldernameRandom As System.Windows.Forms.Button
		Private WithEvents btnFillenameRandom As System.Windows.Forms.Button
		Private txtFilename As System.Windows.Forms.TextBox
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private WithEvents btnApplaunch As System.Windows.Forms.RadioButton
		Private txtFoldername As System.Windows.Forms.ComboBox
		Private WithEvents btnItself As System.Windows.Forms.RadioButton
		Private WithEvents btnInstallutil As System.Windows.Forms.RadioButton
		Private groupBox4 As System.Windows.Forms.GroupBox
		Private WithEvents btnIcon As System.Windows.Forms.Button
		Private WithEvents btnInformation As System.Windows.Forms.Button
		Private groupBox5 As System.Windows.Forms.GroupBox
		Private WithEvents btnBuild As System.Windows.Forms.Button
		Private WithEvents btnSecondFolderRandom As System.Windows.Forms.Button
		Private txtSecondFolder As System.Windows.Forms.TextBox
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private txtCmd As System.Windows.Forms.TextBox
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private WithEvents btnVBC As System.Windows.Forms.RadioButton
		Private WithEvents btnMsBuild As System.Windows.Forms.RadioButton
	End Class
End Namespace