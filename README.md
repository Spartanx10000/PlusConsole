# PlusConsole
Simple library to improve the presentation of console applications .NET

**PlusConsole:**
- WriteASCII
- WriteSection
- Separator
- WriteSuccess
- WriteError

# Basic Setup

```vbnet
        Imports PlusConsole
        ...
        ...
        ...
        'Console settings
        Dim width As Integer = 90
        Console.BufferWidth = width
        Console.WindowWidth = width
```

# Basic Usage

- **WriteASCII**
```vbnet

        'WriteASCII
        Plus.WriteASCII("PlusConsole.")
        Plus.WriteASCII("PlusConsole.", ConsoleColor.Cyan)
        Plus.WriteASCII("PlusConsole.", Figlet.Mini, ConsoleColor.Green)
        Plus.WriteASCII("PlusConsole.", Figlet.Big, ConsoleColor.Yellow)
        
```
![WriteASCII](https://user-images.githubusercontent.com/25779434/66510459-51340800-ea92-11e9-941a-e28862fd5c1a.png)

- **WriteSection**
```vbnet

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
        
```
![WriteSection](https://user-images.githubusercontent.com/25779434/66510685-bb4cad00-ea92-11e9-94e9-584fdea99e3f.png)

- **Separator**
```vbnet

        'Separator
        Plus.Separator()
        Plus.Separator(ConsoleColor.Red)
        Plus.Separator("/", ConsoleColor.Green)
        Plus.Separator("#", " SAMPLE ")
        Plus.Separator("*", " SAMPLE ", TextAlign.Middle)
        Plus.Separator("-", " SAMPLE ", TextAlign.Right)
        Plus.Separator("*", " SAMPLE ", TextAlign.Middle, ConsoleColor.Blue)
        
```
![Separator](https://user-images.githubusercontent.com/25779434/66511455-31054880-ea94-11e9-93a7-c076c216e5f2.png)

- **WriteSuccess**
```vbnet

        'WriteSuccess
        Plus.WriteSuccess("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        Plus.WriteSuccess("Sample Success Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        
```
![WriteSuccess](https://user-images.githubusercontent.com/25779434/66511664-95c0a300-ea94-11e9-950b-eb1231406c2d.png)

- **WriteError**
```vbnet

        'WriteError
        Plus.WriteError("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
        Plus.WriteError("Sample Error Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentumex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
  
```
![WriteError](https://user-images.githubusercontent.com/25779434/66511835-f4861c80-ea94-11e9-8f13-e662383bcea4.png)


