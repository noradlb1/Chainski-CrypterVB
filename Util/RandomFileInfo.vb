Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Chainski_Crypter.Util
	Public Class RandomFileInfo
		Private ReadOnly random As New Random()
		Private ReadOnly randomCharacters As RandomCharacters
		Private lastIndex As Integer

		Public Sub New(ByVal randomCharacters As RandomCharacters)
			Me.randomCharacters = randomCharacters
		End Sub

		Public Function getRandomFileInfo() As PremadeFileInfo
			Const numWords As Integer = 2
			Const randomVersionUpper As Integer = 10
			Const randomVersionLower As Integer = 0
			If random.Next(0, 7) = 0 Then ' 1 in 7 chance to generate random words
				Return New PremadeFileInfo() With {.Title = randomWords(numWords), .Description = randomWords(numWords), .Product = randomWords(numWords), .Company = randomWords(numWords), .Copyright = randomWords(numWords), .Trademark = randomWords(numWords), .MajorVersion = random.Next(randomVersionLower, randomVersionUpper).ToString(), .MinorVersion = random.Next(randomVersionLower, randomVersionUpper).ToString(), .BuildPart = random.Next(randomVersionLower, randomVersionUpper).ToString(), .PrivatePart = random.Next(randomVersionLower, randomVersionUpper).ToString()}
			End If

			Dim newIndex = lastIndex
			Do ' Make sure we don't give the same file 2 times in a row
				newIndex = random.Next(0, premadeFileInfoList.Count - 1)
			Loop While newIndex = lastIndex

			lastIndex = newIndex
			Return premadeFileInfoList(newIndex)
		End Function

		Private Function randomWords(ByVal numberOfWords As Integer) As String
			Dim generatedWords = New List(Of String)()
			For i As Integer = 0 To numberOfWords - 1
				generatedWords.Add(Me.randomCharacters.getRandomCharacters(random.Next(5, 10)))
			Next i

			Return String.Join(" ", generatedWords)
		End Function

		Private ReadOnly premadeFileInfoList As New List(Of PremadeFileInfo)() From {{ New PremadeFileInfo() With {.Title = "chome_exe", .Description = "Google Chrome", .Product = "Google Chrome", .Company = "Google Inc.", .Copyright = "Copyright 2017 Google Inc. All rights reserved.", .Trademark = "", .MajorVersion = "67", .MinorVersion = "0", .BuildPart = "3396", .PrivatePart = "99"} }, { New PremadeFileInfo() With {.Title = "vlc", .Description = "VLC media player", .Product = "VLC media player", .Company = "VideoLAN", .Copyright = "Copyright © 1996-2018 VideoLAN and VLC Author", .Trademark = "VLC media player, VideoLAN and x264 are registered trademarks from VideoLAN", .MajorVersion = "3", .MinorVersion = "0", .BuildPart = "3", .PrivatePart = "0"} }, { New PremadeFileInfo() With {.Title = "HWMonitor.exe", .Description = "HWMonitor", .Product = "CPUID Hardware Monitor", .Company = "CPUID", .Copyright = "(c)2008-2018 CPUID.  All rights reserved.", .Trademark = "", .MajorVersion = "1", .MinorVersion = "3", .BuildPart = "4", .PrivatePart = "0"} }, { New PremadeFileInfo() With {.Title = "CamtasiaStudio.exe", .Description = "TechSmith Camtasia 2018", .Product = "Camtasia", .Company = "TechSmith Corporation", .Copyright = "Copyright © 2011-2018 TechSmith Corporation. All rights reserved.", .Trademark = "18", .MajorVersion = "0", .MinorVersion = "0", .BuildPart = "31", .PrivatePart = "0"} }}
	End Class
End Namespace
