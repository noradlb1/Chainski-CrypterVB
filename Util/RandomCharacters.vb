Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Chainski_Crypter.Util
	Public Class RandomCharacters
		Private ReadOnly random As New Random()
		Private Const alphabet As String = "asdfghjklqwertyuiopmnbvcxz"

		Public Function getRandomCharacters(ByVal length As Integer) As String
			Dim sb = New StringBuilder()
			For i As Integer = 1 To length
				Dim randomCharacterPosition = random.Next(0, alphabet.Length)
				sb.Append(alphabet.Chars(randomCharacterPosition))
			Next i
			Return sb.ToString()
		End Function
	End Class
End Namespace
