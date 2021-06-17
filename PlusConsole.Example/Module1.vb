Module Module1

    Sub Main()

        'Console settings
        Dim widthMax As Integer = 90
        Console.WindowWidth = widthMax
        Console.BufferWidth = widthMax

        'WriteASCII
        PlusConsole.WriteASCII("PlusConsole.")
        PlusConsole.WriteASCII("PlusConsole.", ConsoleColor.Cyan)
        PlusConsole.WriteASCII("PlusConsole.", Figlet.Mini, ConsoleColor.Green)
        PlusConsole.WriteASCII("PlusConsole.", Figlet.Big, ConsoleColor.Yellow)

        Console.WriteLine()

        'Separator
        PlusConsole.Separator()
        PlusConsole.Separator(ConsoleColor.Red)
        PlusConsole.Separator("/"c, ConsoleColor.Green)
        PlusConsole.Separator("#"c, " SAMPLE ")
        PlusConsole.Separator("*"c, " SAMPLE ", TextAlign.Middle)
        PlusConsole.Separator("-"c, " SAMPLE ", TextAlign.Right)
        PlusConsole.Separator("*"c, " SAMPLE ", TextAlign.Middle, ConsoleColor.Blue)

        Console.WriteLine()

        'WriteSection 
        Dim sample1 As New Section("[ SECTION SAMPLE 1 ]")
        sample1.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        sample1.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        PlusConsole.WriteSection(sample1)

        Dim sample2 As New Section("[ SECTION SAMPLE 2 ]", TextAlign.Middle)
        sample2.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        sample2.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        sample2.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        PlusConsole.WriteSection(sample2, ConsoleColor.Blue)

        Dim sample3 As New Section("[ SECTION SAMPLE 3 ]", TextAlign.Right)
        sample3.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        sample3.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        PlusConsole.WriteSection(sample3)

        Dim sample4 As New Section()
        sample4.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        sample4.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        sample4.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        PlusConsole.WriteSection(sample4, ConsoleColor.Yellow)

        Console.WriteLine()

        'WriteError
        PlusConsole.WriteError("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        PlusConsole.WriteError("Sample Error Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")

        Console.WriteLine()

        'WriteSuccess
        PlusConsole.WriteSuccess("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        PlusConsole.WriteSuccess("Sample Success Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")

        Console.WriteLine()

        'WriteWarning
        PlusConsole.WriteWarning("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        PlusConsole.WriteWarning("Sample Warning Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")

        Console.WriteLine()

        'WriteInfo
        PlusConsole.WriteInfo("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        PlusConsole.WriteInfo("Sample Info Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")

        Console.WriteLine()

        'WriteFormat
        PlusConsole.WriteFormat("Hello {0}", "World")
        PlusConsole.WriteFormat("Process End...[{0}]", "OK", ConsoleColor.Green)

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

        'Spinner
        Dim Spinner As New Spinner()
        Spinner.Start()
        'Simulate work
        System.Threading.Thread.Sleep(10000)
        Spinner.Stop()

        Dim Spinner2 As New Spinner("Downloading", ConsoleColor.Yellow)
        Spinner2.Start()
        'Simulate work
        System.Threading.Thread.Sleep(10000)
        Spinner2.Stop()

        Console.WriteLine("Press any key to close the console.")
        Console.ReadKey()

    End Sub

End Module
