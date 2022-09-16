Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Chainski_Crypter.Forms
	Partial Public Class FormChangeIcon
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub S_Click(ByVal sender As Object, ByVal e As EventArgs) Handles s.Click
			Using openFileDialog = New OpenFileDialog()
				openFileDialog.Filter = "Icon (*.ico)|*.ico"
				If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					txtIcon.Text = openFileDialog.FileName
					pictureIcon.ImageLocation = openFileDialog.FileName
					pictureIcon.BorderStyle = BorderStyle.FixedSingle
				Else
					txtIcon.Text = String.Empty
					pictureIcon.ImageLocation = String.Empty
				End If
			End Using
		End Sub

		Private Sub FormChangeIcon_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace
