Imports Chainski_Crypter.Util
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Chainski_Crypter.Forms
	Partial Public Class FormInformation
		Inherits Form

		Private ReadOnly randomFileInfo As RandomFileInfo
		Private ReadOnly randomCharacters As RandomCharacters

		Public Sub New()
			Me.randomCharacters = New RandomCharacters()
			Me.randomFileInfo = New RandomFileInfo(randomCharacters)
			InitializeComponent()
		End Sub

		Private Sub BtnRandom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRandom.Click
			Dim newInfo = randomFileInfo.getRandomFileInfo()
			txtTitle.Text = newInfo.Title
			txtDescription.Text = newInfo.Description
			txtProduct.Text = newInfo.Product
			txtCompany.Text = newInfo.Company
			txtCopyright.Text = newInfo.Copyright
			txtTrademark.Text = newInfo.Trademark
			assemblyMajorVersion.Text = newInfo.MajorVersion
			assemblyMinorVersion.Text = newInfo.MinorVersion
			assemblyBuildPart.Text = newInfo.BuildPart
			assemblyPrivatePart.Text = newInfo.PrivatePart
		End Sub

		Private Sub BtnClone_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClone.Click
			Using openFileDialog = New OpenFileDialog()
				openFileDialog.Filter = "Executable (*.exe)|*.exe"
				If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					Dim fileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(openFileDialog.FileName)

					txtTitle.Text = If(fileVersionInfo.InternalName, String.Empty)
					txtDescription.Text = If(fileVersionInfo.FileDescription, String.Empty)
					txtProduct.Text = If(fileVersionInfo.CompanyName, String.Empty)
					txtCompany.Text = If(fileVersionInfo.ProductName, String.Empty)
					txtCopyright.Text = If(fileVersionInfo.LegalCopyright, String.Empty)
					txtTrademark.Text = If(fileVersionInfo.LegalTrademarks, String.Empty)

					Dim version = fileVersionInfo.FileMajorPart
					assemblyMajorVersion.Text = fileVersionInfo.FileMajorPart.ToString()
					assemblyMinorVersion.Text = fileVersionInfo.FileMinorPart.ToString()
					assemblyBuildPart.Text = fileVersionInfo.FileBuildPart.ToString()
					assemblyPrivatePart.Text = fileVersionInfo.FilePrivatePart.ToString()
				End If
			End Using
		End Sub
	End Class
End Namespace
