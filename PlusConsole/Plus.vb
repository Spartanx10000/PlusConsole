'Author: SpartanX10000
'Project: PlusConsole

Public Class Plus

#Region "WriteASCII"

    ''' <summary>
    ''' Write the specified string value with ASCII characters.
    ''' </summary>
    Public Shared Sub WriteASCII(value As String)
        Dim banner As New Ascii()
        Dim ascii As String = banner.StringToAscii(value)
        Console.WriteLine(ascii)
    End Sub

    ''' <summary>
    ''' Write the specified string value with ASCII characters and the specified console color.
    ''' </summary>
    Public Shared Sub WriteASCII(value As String, color As ConsoleColor)
        Dim basecolor As ConsoleColor = Console.ForegroundColor
        Console.ForegroundColor = color
        WriteASCII(value)
        Console.ForegroundColor = basecolor
    End Sub

    ''' <summary>
    ''' Write the specified string value with ASCII characters of the specified font.
    ''' </summary>
    Public Shared Sub WriteASCII(value As String, font As Figlet)
        Dim banner As New Ascii(font)
        Dim ascii As String = banner.StringToAscii(value)
        Console.WriteLine(ascii)
    End Sub

    ''' <summary>
    ''' Write the specified string value with ASCII characters of the specified font and the specified console color.
    ''' </summary>
    Public Shared Sub WriteASCII(value As String, font As Figlet, color As ConsoleColor)
        Dim basecolor As ConsoleColor = Console.ForegroundColor
        Console.ForegroundColor = color
        WriteASCII(value, font)
        Console.ForegroundColor = basecolor
    End Sub

#End Region

#Region "Separator"

    ''' <summary>
    ''' Write a character line.
    ''' </summary>
    Public Shared Sub Separator()
        Dim defaultchar As Char = "="
        Separator(defaultchar)
    End Sub

    ''' <summary>
    ''' Write a line of the specified character.
    ''' </summary>
    Public Shared Sub Separator(character As String)
        Console.WriteLine(Strings.StrDup(Console.BufferWidth, character))
    End Sub

    ''' <summary>
    ''' Write a line of the specified character with a text.
    ''' </summary>
    Public Shared Sub Separator(character As String, text As String)
        Console.WriteLine(titleAlign(character, text, TextAlign.Left))
    End Sub

    ''' <summary>
    ''' Write a line of the specified character with a text in the alignment specified.
    ''' </summary>
    Public Shared Sub Separator(character As String, text As String, align As TextAlign)
        Console.WriteLine(titleAlign(character, text, align))
    End Sub

    ''' <summary>
    ''' Write a character line with the console color specified.
    ''' </summary>
    Public Shared Sub Separator(color As ConsoleColor)
        Dim basecolor As ConsoleColor = Console.ForegroundColor
        Console.ForegroundColor = color
        Separator()
        Console.ForegroundColor = basecolor
    End Sub

    ''' <summary>
    ''' Write a line of the specified character with the console color specified.
    ''' </summary>
    Public Shared Sub Separator(character As String, color As ConsoleColor)
        Dim basecolor As ConsoleColor = Console.ForegroundColor
        Console.ForegroundColor = color
        Separator(character)
        Console.ForegroundColor = basecolor
    End Sub

    ''' <summary>
    ''' Write a line of the specified character with a text with the console color specified.
    ''' </summary>
    Public Shared Sub Separator(character As String, text As String, color As ConsoleColor)
        Dim basecolor As ConsoleColor = Console.ForegroundColor
        Console.ForegroundColor = color
        Separator(character, text)
        Console.ForegroundColor = basecolor
    End Sub

    ''' <summary>
    ''' Write a line of the specified character with a text in the alignment specified and the console color specified.
    ''' </summary>
    Public Shared Sub Separator(character As String, text As String, align As TextAlign, color As ConsoleColor)
        Dim basecolor As ConsoleColor = Console.ForegroundColor
        Console.ForegroundColor = color
        Separator(character, text, align)
        Console.ForegroundColor = basecolor
    End Sub

#End Region

#Region "WriteSection"

    ''' <summary>
    ''' Write the representation of the section information.
    ''' </summary>
    Public Shared Sub WriteSection(section As Section)
        Dim width As Integer = IIf((Console.BufferWidth Mod 2) = 0, Console.BufferWidth - 2, Console.BufferWidth - 1)
        Dim titleWidth As Integer = IIf((section.Title.Length Mod 2) = 0, section.Title.Length, section.Title.Length + 1)
        Select Case section.TitleAlign
            Case TextAlign.Left
                Dim RightOffSet As Integer = width - section.Title.Length
                Console.WriteLine(section.GetCornersChar & section.GetTopBottomBorderChar & section.Title & StrDup(RightOffSet - 3, section.GetTopBottomBorderChar) & section.GetCornersChar)
            Case TextAlign.Middle
                Dim OffSet As Integer = CInt(width / 2) - CInt(titleWidth / 2)
                Dim LeftOffSet As Integer = OffSet - 1
                Dim RightOffSet As Integer = IIf((section.Title.Length Mod 2) = 0, OffSet - 1, OffSet)
                Console.WriteLine(section.GetCornersChar & StrDup(LeftOffSet, section.GetTopBottomBorderChar) & section.Title & StrDup(RightOffSet, section.GetTopBottomBorderChar) & section.GetCornersChar)
            Case TextAlign.Right
                Dim LeftOffSet As Integer = width - section.Title.Length
                Console.WriteLine(section.GetCornersChar & StrDup(LeftOffSet - 3, section.GetTopBottomBorderChar) & section.Title & section.GetTopBottomBorderChar & section.GetCornersChar)
            Case Else
                Console.WriteLine(section.GetCornersChar & StrDup(width - 2, section.GetTopBottomBorderChar) & section.GetCornersChar)
        End Select
        For Each line As String In section.GetLines
            Dim RightOffSet As Integer = width - line.Length
            Dim value = section.GetLeftRightBorderChar & " " & line & StrDup(RightOffSet - 3, " ") & section.GetLeftRightBorderChar
            Console.WriteLine(value)
        Next
        Console.WriteLine(section.GetCornersChar & StrDup(width - 2, section.GetTopBottomBorderChar) & section.GetCornersChar)
    End Sub

    ''' <summary>
    ''' Write the representation of the section information the specified console color.
    ''' </summary>
    Public Shared Sub WriteSection(section As Section, color As ConsoleColor)
        Dim basecolor As ConsoleColor = Console.ForegroundColor
        Console.ForegroundColor = color
        WriteSection(section)
        Console.ForegroundColor = basecolor
    End Sub

#End Region

#Region "WriteError"

    ''' <summary>
    ''' Write the representation of the error message.
    ''' </summary>
    Public Shared Sub WriteError(msj As String)
        Dim Info As New Section("[   ERROR   ]", TextAlign.Middle)
        For Each item As String In Split(msj, Console.BufferWidth - 6)
            Info.AddLine(item)
        Next
        WriteSection(Info, ConsoleColor.Red)
    End Sub

    ''' <summary>
    ''' Write the representation of the error message with the specified title.
    ''' </summary>
    Public Shared Sub WriteError(title As String, msj As String)
        Dim Info As New Section("[   " & title & "   ]", TextAlign.Middle)
        For Each item As String In Split(msj, Console.BufferWidth - 6)
            Info.AddLine(item)
        Next
        WriteSection(Info, ConsoleColor.Red)
    End Sub

#End Region

#Region "WriteSuccess"

    ''' <summary>
    ''' Write the representation of the success message.
    ''' </summary>
    Public Shared Sub WriteSuccess(msj As String)
        Dim Info As New Section("[   SUCCESS   ]", TextAlign.Middle)
        For Each item As String In Split(msj, Console.BufferWidth - 6)
            Info.AddLine(item)
        Next
        WriteSection(Info, ConsoleColor.DarkGreen)
    End Sub

    ''' <summary>
    ''' Write the representation of the success message with the specified title.
    ''' </summary>
    Public Shared Sub WriteSuccess(title As String, msj As String)
        Dim Info As New Section("[   " & title & "   ]", TextAlign.Middle)
        For Each item As String In Split(msj, Console.BufferWidth - 6)
            Info.AddLine(item)
        Next
        WriteSection(Info, ConsoleColor.DarkGreen)
    End Sub

#End Region

#Region "Others"

    Private Shared Function titleAlign(character As String, title As String, align As TextAlign) As String
        Dim value As String = String.Empty
        Dim width As Integer = Console.BufferWidth
        Select Case align
            Case TextAlign.Left
                Dim RightOffSet As Integer = width - title.Length
                value = title & StrDup(RightOffSet, character)
            Case TextAlign.Middle
                Dim OffSet As Integer = CInt(width / 2) - CInt(title.Length / 2)
                value = (StrDup(OffSet, character) & title & StrDup(OffSet, character))
            Case TextAlign.Right
                Dim LeftOffSet As Integer = width - title.Length
                value = StrDup(LeftOffSet, character) & title
        End Select
        Return value
    End Function

    Private Shared Function Split(ByVal value As String, ByVal size As Integer) As String()
        Dim slength As Integer = value.Length
        Dim rlength As Integer
        Dim lines As String() = New String(((value.Length \ size) - 1 + IIf((value.Length Mod size) > 0, 1, 0))) {}
        For i As Integer = 0 To lines.Length - 1
            rlength = slength - i * size
            If rlength < size Then
                lines(i) = value.Substring((i * size), rlength)
            Else
                lines(i) = value.Substring((i * size), size)
            End If
        Next i
        Return lines
    End Function

#End Region

End Class
