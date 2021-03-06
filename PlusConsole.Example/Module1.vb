﻿Module Module1

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
        sample1.WriteSection()

        Dim sample2 As New Section("[ SECTION SAMPLE 2 ]", TextAlign.Middle, ConsoleColor.Blue)
        sample2.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        sample2.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", TextAlign.Middle)
        sample2.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", TextAlign.Right)
        sample2.WriteSection()

        Dim sample3 As New Section("[ SECTION SAMPLE 3 ]", TextAlign.Right)
        sample3.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        sample3.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        sample3.WriteSection()

        Dim sample4 As New Section(ConsoleColor.Yellow)
        sample4.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        sample4.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        sample4.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        sample4.WriteSection()

        Console.WriteLine()

        PlusConsole.WriteError("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        PlusConsole.WriteSuccess("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        PlusConsole.WriteWarning("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
        PlusConsole.WriteInfo("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")

        Console.WriteLine()

        'WriteErrorMessage
        PlusConsole.WriteErrorMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        PlusConsole.WriteErrorMessage("Sample Error Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")

        Console.WriteLine()

        'WriteSuccessMessage
        PlusConsole.WriteSuccessMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        PlusConsole.WriteSuccessMessage("Sample Success Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")

        Console.WriteLine()

        'WriteWarningMessage
        PlusConsole.WriteWarningMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        PlusConsole.WriteWarningMessage("Sample Warning Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")

        Console.WriteLine()

        'WriteInfoMessage
        PlusConsole.WriteInfoMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        PlusConsole.WriteInfoMessage("Sample Info Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")

        Console.WriteLine()

        'WriteFormat
        PlusConsole.WriteFormat("Hello {0}", "World")
        PlusConsole.WriteFormat("Hello {0}", ConsoleColor.Cyan, "World")
        PlusConsole.WriteFormat("Hello {0} {1}", "World", ":)")
        PlusConsole.WriteFormat("Process End...[{0}] {1}", ConsoleColor.Green, "OK", "2 Records")
        PlusConsole.WriteFormat("Process End...[{0}] {1}", ConsoleColor.Red, "Error", "404")

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

        'Table
        Dim table = New Table()
        table.SetColumns = New String() {"Column 1", "Column 2", "Column 3"}
        table.AddRow("Row 1 Cell 1", "Row 1 Cell 2", "Row 1 Cell 3")
        table.AddRow("Row 2 Cell 1", "Row 2 Cell 2", "Row 2 Cell 3")
        table.AddRow("Row 3 Cell 1", "Row 3 Cell 2", "Row 3 Cell 3")
        table.WriteTable()

        Dim table2 = New Table(ConsoleColor.Green)
        table2.SetColumns = New String() {"Column 1", "Column 2", "Column 3", "Column 4"}
        table2.HeaderAlign = TextAlign.Middle
        table2.ColumnAlign = TextAlign.Middle
        table2.AddRow("Row 1 Cell 1", "Row 1 Cell 2", "Row 1 Cell 3", "Row 1 Cell 4")
        table2.AddRow("Row 2 Cell 1", "Row 2 Cell 2", "Row 2 Cell 3", "Row 2 Cell 4")
        table2.AddRow("Row 3 Cell 1", "Row 3 Cell 2", "Row 3 Cell 3", "Row 3 Cell 4")
        table2.WriteTable()

        Console.WriteLine()

        Console.WriteLine("Press any key to close the console.")
        Console.ReadKey()

    End Sub

End Module
