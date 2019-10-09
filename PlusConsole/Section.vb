'Author: SpartanX10000

Public Class Section

    Private _TopBottomChar As Char = "="
    Private _LeftRightChar As Char = "|"
    Private _CornersChar As Char = "+"
    Private _Lines As New ArrayList()

    Public Property Title As String
    Public Property TitleAlign As TextAlign

    Public Sub New()
        Me.Title = String.Empty
        Me.TitleAlign = Nothing
    End Sub

    Public Sub New(title As String)
        Me.Title = title
        Me.TitleAlign = TextAlign.Left
    End Sub

    Public Sub New(title As String, align As TextAlign)
        Me.Title = title
        Me.TitleAlign = align
    End Sub

    ''' <summary>
    ''' Add a new line to the section.
    ''' </summary>
    Public Sub AddLine(value As String)
        Me._Lines.Add(value)
    End Sub

    ''' <summary>
    ''' Return the lines of the section.
    ''' </summary>
    Public Function GetLines() As ArrayList
        Return Me._Lines
    End Function

    ''' <summary>
    ''' Return the char use for the top and bottom border of the section.
    ''' </summary>
    Public Function GetTopBottomBorderChar() As Char
        Return Me._TopBottomChar
    End Function

    ''' <summary>
    ''' Return the char use for the left and right border of the section.
    ''' </summary>
    Public Function GetLeftRightBorderChar() As Char
        Return Me._LeftRightChar
    End Function

    ''' <summary>
    ''' Return the char use for the corners border of the section.
    ''' </summary>
    Public Function GetCornersChar() As Char
        Return Me._CornersChar
    End Function

End Class



