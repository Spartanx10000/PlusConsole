![PlusConsole](https://user-images.githubusercontent.com/25779434/71747921-31607600-2e2e-11ea-9375-bc3e26f7be0a.png)

Simple library to improve the presentation of console applications in the .NET/.NET Core Framework

## :mag: Features
- This library is a .NET Standard library built using Visual Studio 2017
- Support both .NET Framework 3.x, 4.x and .NET Core Framework 2.x
- Improve the presentation of the output in console applications
- Allows to implement a progress bar and loading indicator in the console
- Implements a simple way to represent strings of ASCII characters

## :pushpin: Target Applications
This library is aimed at console Applications (.NET/.NET Core)
   
## :wrench: Setup
1. Add the reference to the project.

2. Add the import (VB) or using (C#):
- c#
```csharp
using PlusConsole;
```
- vb
```vbnet
Imports PlusConsole
```
3. (Optional) Specify console settings
- c#
```csharp
int widthMax = 90;
Console.WindowWidth = widthMax;
Console.BufferWidth = widthMax;
```
- vb
```vbnet
Dim widthMax As Integer = 90
Console.WindowWidth = widthMax
Console.BufferWidth = widthMax
```

## :pencil2: Usage

- **WriteASCII**
```vbnet
Plus.WriteASCII("PlusConsole.")
Plus.WriteASCII("PlusConsole.", ConsoleColor.Cyan)
Plus.WriteASCII("PlusConsole.", Figlet.Mini, ConsoleColor.Green)
Plus.WriteASCII("PlusConsole.", Figlet.Big, ConsoleColor.Yellow)      
```
![WriteASCII](https://user-images.githubusercontent.com/25779434/66510459-51340800-ea92-11e9-941a-e28862fd5c1a.png)

- **WriteSection**
```vbnet
Dim sample1 As New Section("[ SECTION SAMPLE 1 ]")
sample1.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
sample1.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
Plus.WriteSection(sample1)

Dim sample2 As New Section("[ SECTION SAMPLE 2 ]", TextAlign.Middle)
sample2.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
sample2.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
sample2.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
Plus.WriteSection(sample2, ConsoleColor.Blue)

Dim sample3 As New Section("[ SECTION SAMPLE 3 ]", TextAlign.Right)
sample3.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
sample3.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
Plus.WriteSection(sample3)

Dim sample4 As New Section()
sample4.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
sample4.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
sample4.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
Plus.WriteSection(sample4, ConsoleColor.Yellow)    
```
![WriteSection](https://user-images.githubusercontent.com/25779434/68891287-c2905780-06dd-11ea-9a77-a9355663cbd8.png)

- **WriteFormat**
```vbnet
Plus.WriteFormat("Hello {0}", "World")
Plus.WriteFormat("Process End...[{0}]", "OK", ConsoleColor.Green)
```
![WriteFormat](https://user-images.githubusercontent.com/25779434/68892433-451a1680-06e0-11ea-8d48-3c0c36d68927.png)

- **Separator**
```vbnet
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
Plus.WriteSuccess("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
Plus.WriteSuccess("Sample Success Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")     
```
![WriteSuccess](https://user-images.githubusercontent.com/25779434/66511664-95c0a300-ea94-11e9-950b-eb1231406c2d.png)

- **WriteError**
```vbnet
Plus.WriteError("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
Plus.WriteError("Sample Error Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentumex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
```
![WriteError](https://user-images.githubusercontent.com/25779434/66511835-f4861c80-ea94-11e9-8f13-e662383bcea4.png)

- **WriteInfo**
```vbnet
Plus.WriteInfo("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
Plus.WriteInfo("Sample Info Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
```
![WriteInfo](https://user-images.githubusercontent.com/25779434/68891703-a214cd00-06de-11ea-962b-fc9b16b3f059.png)

- **WriteWarning**
```vbnet
Plus.WriteWarning("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
Plus.WriteWarning("Sample Warning Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.")
```
![WriteWarning](https://user-images.githubusercontent.com/25779434/68891784-ccff2100-06de-11ea-914d-c7813628e1d1.png)

- **ProgressBar**
```vbnet
'Simulate number of operations
Dim total_operations As Integer = 100

Dim progress1 As New ProgressBar(total_operations, True)
For i As Integer = 1 To total_operations
    'Simulate work
    System.Threading.Thread.Sleep(50)
    progress1.UpdateProgress(i)
Next

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
```
![ProgressBar](https://user-images.githubusercontent.com/25779434/68892653-b0fc7f00-06e0-11ea-9077-d0bb74c6020f.png)

- **Loading**
```vbnet
'Simulate number of operations
Dim total_operations As Integer = 100

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
```
![Loading](https://user-images.githubusercontent.com/25779434/68892957-5dd6fc00-06e1-11ea-92a5-a84d7c3ab15d.png)

## :memo: License
This project is licensed under MIT License.
