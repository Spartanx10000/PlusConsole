'Author: SpartanX10000

Imports System.IO
Imports System.Reflection

Public Class Font

    Public Property Id As String
    Public Property HardBlank As String
    Public Property Height As Integer
    Public Property BaseLine As Integer
    Public Property MaxLenght As Integer
    Public Property OldLayout As Integer
    Public Property CommentLines As Integer
    Public Property PrintDirection As Integer
    Public Property FullLayout As Integer
    Public Property CodeTagCount As Integer
    Public Property FileLines As List(Of String)
    Public Property FontType As Figlet

    Public Sub New(Optional type As Figlet = Figlet.Standard)
        Me.FontType = type
        Me.LoadFont()
    End Sub

    Private Sub LoadLines(ByVal fileLines As List(Of String))
        Me.FileLines = fileLines
        Dim firstLine As String = Me.FileLines.First()
        Dim lineContent As String() = firstLine.Split(" "c)
        Me.Id = lineContent.First().Remove(lineContent.First().Length - 1)
        If Me.Id = "flf2a" Then
            Me.HardBlank = lineContent.First().Last().ToString()
            Me.Height = CInt(lineContent.GetValue(1))
            Me.BaseLine = CInt(lineContent.GetValue(2))
            Me.MaxLenght = CInt(lineContent.GetValue(3))
            Me.OldLayout = CInt(lineContent.GetValue(4))
            Me.CommentLines = CInt(lineContent.GetValue(5))
            Me.PrintDirection = CInt(lineContent.GetValue(6))
            Me.FullLayout = CInt(lineContent.GetValue(7))
            Me.CodeTagCount = CInt(lineContent.GetValue(8))
        End If
    End Sub

    Private Sub LoadFont()
        Using stream As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Me.GetFontResourceName(Me.FontType))
            Me.FontStream(stream)
        End Using
    End Sub

    Private Sub FontStream(ByVal stream As Stream)
        Dim fileLines = New List(Of String)()
        Using reader = New StreamReader(stream)
            While Not reader.EndOfStream
                fileLines.Add(reader.ReadLine())
            End While
        End Using
        LoadLines(fileLines)
    End Sub

    Private Function GetFontResourceName(fontType As Figlet) As String
        Dim baseName As String = "PlusConsole."
        Dim resourceName As String = String.Empty
        Select Case fontType
            Case Figlet.Standard
                resourceName = "standard.flf"
            Case Figlet.Big
                resourceName = "big.flf"
            Case Figlet.Mini
                resourceName = "mini.flf"
            Case Figlet.Banner
                resourceName = "banner.flf"
        End Select
        Return baseName & resourceName
    End Function

End Class




