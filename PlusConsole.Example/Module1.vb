Module Module1

    Sub Main()

        'Console settings
        Dim widthMax As Integer = 90
        Console.BufferWidth = widthMax
        Console.WindowWidth = widthMax

        'WriteASCII
        Plus.WriteASCII("PlusConsole.")
        Plus.WriteASCII("PlusConsole.", ConsoleColor.Cyan)
        Plus.WriteASCII("PlusConsole.", Figlet.Mini, ConsoleColor.Green)
        Plus.WriteASCII("PlusConsole.", Figlet.Big, ConsoleColor.Yellow)

        Console.WriteLine()

        'Separator
        Plus.Separator()
        Plus.Separator(ConsoleColor.Red)
        Plus.Separator("/"c, ConsoleColor.Green)
        Plus.Separator("#"c, " SAMPLE ")
        Plus.Separator("*"c, " SAMPLE ", TextAlign.Middle)
        Plus.Separator("-"c, " SAMPLE ", TextAlign.Right)
        Plus.Separator("*"c, " SAMPLE ", TextAlign.Middle, ConsoleColor.Blue)

        Console.WriteLine()

        'WriteSection 
        Dim sample1 As New Section("[ SECTION SAMPLE 1 ]")
        sample1.AddLine("line 1")
        sample1.AddLine("line 2")
        Plus.WriteSection(sample1)

        Dim sample2 As New Section("[ SECTION SAMPLE 2 ]", TextAlign.Middle)
        sample2.AddLine("line 1")
        sample2.AddLine("line 2")
        sample2.AddLine("line 3")
        Plus.WriteSection(sample2, ConsoleColor.Blue)

        Dim sample3 As New Section("[ SECTION SAMPLE 3 ]", TextAlign.Right)
        sample3.AddLine("line 1")
        sample3.AddLine("line 2")
        Plus.WriteSection(sample3)

        Dim sample4 As New Section()
        sample4.AddLine("line 1")
        sample4.AddLine("line 2")
        sample4.AddLine("line 3")
        Plus.WriteSection(sample4, ConsoleColor.Yellow)

        Console.WriteLine()

        'WriteError
        Plus.WriteError("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        Plus.WriteError("Sample Error Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")

        Console.WriteLine()

        'WriteSuccess
        Plus.WriteSuccess("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        Plus.WriteSuccess("Sample Success Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")

        Console.WriteLine()

        'Simulate number of operations
        Dim total_operations As Integer = 100

        'Progressbar
        Dim progress1 As New ProgressBar(total_operations, True)
        For i As Integer = 1 To total_operations
            'Simulate work
            System.Threading.Thread.Sleep(50)
            progress1.UpdateProgress(i)
        Next

        Console.WriteLine()

        Dim progress2 As New ProgressBar(total_operations, True)
        progress2.ShowNumbers = True
        progress2.ProgressBarColor = ConsoleColor.Green
        progress2.LeftBorder = "["
        progress2.RightBorder = "]"
        For i As Integer = 1 To total_operations
            'Simulate work
            System.Threading.Thread.Sleep(50)
            progress2.UpdateProgress(i)
        Next

        Console.WriteLine()

        'Loading
        Dim status1 As New Loading()
        status1.StartLoading()
        For i As Integer = 1 To total_operations
            'Simulate work
            System.Threading.Thread.Sleep(50)
        Next
        status1.StopLoading()

        Dim status2 As New Loading("Uploading", ">")
        status2.StartLoading()
        For i As Integer = 1 To total_operations
            'Simulate work
            System.Threading.Thread.Sleep(50)
        Next
        status2.StopLoading()

        Console.WriteLine("Press any key to close the console.")
        Console.ReadKey()

    End Sub

End Module
