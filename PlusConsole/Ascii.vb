'Author: SpartanX10000

Imports System.Text.RegularExpressions

Public Class Ascii

    Private _font As Font

    Public Sub New(Optional type As Figlet = Figlet.Standard)
        Me._font = New Font(type)
    End Sub

    Public Function StringToAscii(ByVal value As String) As String
        Dim ascii As String = String.Empty
        For i As Integer = 1 To _font.Height
            For Each car In value
                ascii += Me.GetCharacter(car, i)
            Next
            ascii += Environment.NewLine
        Next
        Return ascii
    End Function

    Public Function GetCharacter(ByVal value As Char, ByVal line As Integer) As String
        Dim i As Integer = Me._font.CommentLines + ((Convert.ToInt32(value) - 32) * Me._font.Height)
        Dim temp As String = Me._font.FileLines(i + line)
        Dim lineend = temp(temp.Length - 1)
        Dim regex As New Regex("\" & lineend & "{1,2}$")
        temp = regex.Replace(temp, "")
        Return temp.Replace(Me._font.HardBlank, " ")
    End Function

End Class


