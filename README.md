<p align="center">
   
   ![PlusConsole](https://user-images.githubusercontent.com/25779434/129614681-3cf7bc78-e393-4091-89f4-b70c4a7ba327.png)
</p>


<p align="center">
   <a href="https://github.com/Spartanx10000/PlusConsole/releases">
      <img alt="GitHub release (latest by date)" src="https://img.shields.io/github/v/release/Spartanx10000/PlusConsole">
   </a>
   <a href="https://github.com/Spartanx10000/PlusConsole/blob/master/LICENSE">
      <img alt="License" src="https://img.shields.io/github/license/Spartanx10000/PlusConsole">
   </a>
   
</p>

Simple library to improve the presentation of .NET console applications.

## :mag: Features
- This library is a .NET Standard project built using Visual Studio 2019
- Improve the presentation of the output in console applications
- Figlet fonts 
- Progress bar
- Spinner indicator
- Table

## :pushpin: Target Frameworks
- .NET Framework 3.5
- .NET Framework 4.0
- .NET Framework 4.5
- .NET Standard 2.0
- .NET Core 2.1
- .NET Core 3.1
- .NET 5.0

   
## :wrench: Setup
1. Add the reference (Dll) to the project.

2. Add the using (C#):
```csharp
using PlusConsole;
```

3. (Optional) Specify console settings
```csharp
int widthMax = 90;
Console.WindowWidth = widthMax;
Console.BufferWidth = widthMax;
```

## :pencil2: Usage

- **WriteASCII**
```csharp
PlusConsole.WriteASCII("PlusConsole.");
PlusConsole.WriteASCII("PlusConsole.", ConsoleColor.Cyan);
PlusConsole.WriteASCII("PlusConsole.", Figlet.Mini, ConsoleColor.Green);
PlusConsole.WriteASCII("PlusConsole.", Figlet.Big, ConsoleColor.Yellow);     
```
![WriteASCII](https://user-images.githubusercontent.com/25779434/66510459-51340800-ea92-11e9-941a-e28862fd5c1a.png)

- **WriteFormat**
```csharp
PlusConsole.WriteFormat("Hello {0}", "World");
PlusConsole.WriteFormat("Hello {0}",ConsoleColor.Cyan, "World");
PlusConsole.WriteFormat("Hello {0} {1}", "World",":)");
PlusConsole.WriteFormat("Process End...[{0}] {1}", ConsoleColor.Green, "OK", "2 Records");
PlusConsole.WriteFormat("Process End...[{0}] {1}", ConsoleColor.Red, "Error", "404");
```
![Format](https://user-images.githubusercontent.com/25779434/124818566-6d473080-df28-11eb-98e9-9615473ef685.png)

- **Separator**
```csharp
PlusConsole.Separator();
PlusConsole.Separator(ConsoleColor.Red);
PlusConsole.Separator('/', ConsoleColor.Green);
PlusConsole.Separator('#', " SAMPLE ");
PlusConsole.Separator('*', " SAMPLE ", TextAlign.Middle);
PlusConsole.Separator('-', " SAMPLE ", TextAlign.Right);
PlusConsole.Separator('*', " SAMPLE ", TextAlign.Middle, ConsoleColor.Blue);     
```
![Separator](https://user-images.githubusercontent.com/25779434/66511455-31054880-ea94-11e9-93a7-c076c216e5f2.png)

- **WriteError, WriteSuccess, WriteWarning, WriteInfo**
```csharp
PlusConsole.WriteError("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
PlusConsole.WriteSuccess("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
PlusConsole.WriteWarning("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
PlusConsole.WriteInfo("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");     
```
![Messages](https://user-images.githubusercontent.com/25779434/124818673-8e0f8600-df28-11eb-8c01-37a1c58b0962.png)

- **WriteSuccessMessage**
```csharp
PlusConsole.WriteSuccessMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");
PlusConsole.WriteSuccessMessage("Sample Success Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");
```
![WriteSuccess](https://user-images.githubusercontent.com/25779434/66511664-95c0a300-ea94-11e9-950b-eb1231406c2d.png)

- **WriteErrorMessage**
```csharp
PlusConsole.WriteErrorMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");
PlusConsole.WriteErrorMessage("Sample Error Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");
```
![WriteError](https://user-images.githubusercontent.com/25779434/66511835-f4861c80-ea94-11e9-8f13-e662383bcea4.png)

- **WriteInfoMessage**
```csharp
PlusConsole.WriteInfoMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");
PlusConsole.WriteInfoMessage("Sample Info Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");
```
![WriteInfo](https://user-images.githubusercontent.com/25779434/68891703-a214cd00-06de-11ea-962b-fc9b16b3f059.png)

- **WriteWarningMessage**
```csharp
PlusConsole.WriteWarningMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");
PlusConsole.WriteWarningMessage("Sample Warning Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");
```
![WriteWarning](https://user-images.githubusercontent.com/25779434/68891784-ccff2100-06de-11ea-914d-c7813628e1d1.png)

- **Section**
```csharp
var sample1 = new Section("[ SECTION SAMPLE 1 ]");
sample1.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
sample1.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
sample1.WriteSection();

var sample2 = new Section("[ SECTION SAMPLE 2 ]", TextAlign.Middle, ConsoleColor.Blue);
sample2.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
sample2.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", TextAlign.Middle);
sample2.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", TextAlign.Right);
sample2.WriteSection();

var sample3 = new Section("[ SECTION SAMPLE 3 ]", TextAlign.Right);
sample3.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
sample3.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
sample3.WriteSection();

var sample4 = new Section(ConsoleColor.Yellow);
sample4.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
sample4.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
sample4.AddLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
sample4.WriteSection();
```
![Section](https://user-images.githubusercontent.com/25779434/124818876-ca42e680-df28-11eb-8d58-0e2f465ff762.png)

- **ProgressBar**
```csharp
//Simulate number of operations
int total_operations = 100;

var progress1 = new ProgressBar(total_operations, true);

for (int i = 1; i <= total_operations; i++)
{
   //Simulate work
   System.Threading.Thread.Sleep(50);
   progress1.UpdateProgress(i);
}

var progress2 = new ProgressBar(total_operations, true);
progress2.ShowNumbers = true;
progress2.ProgressBarColor = ConsoleColor.Green;
progress2.LeftBorder = "[";
progress2.RightBorder = "]";

for (int i = 1; i <= total_operations; i++)
{
   //Simulate work
   System.Threading.Thread.Sleep(50);
   progress2.UpdateProgress(i);
}
```
![ProgressBar](https://user-images.githubusercontent.com/25779434/68892653-b0fc7f00-06e0-11ea-9077-d0bb74c6020f.png)

- **Spinner**
```csharp
var spinner = new Spinner();
spinner.Start();
//Simulate work
System.Threading.Thread.Sleep(10000);
spinner.Stop();

var spinner2 = new Spinner("Downloading", ConsoleColor.Red);
spinner2.Start();
//Simulate work
System.Threading.Thread.Sleep(10000);
spinner2.Stop();
```
![Loading](https://user-images.githubusercontent.com/25779434/68892957-5dd6fc00-06e1-11ea-92a5-a84d7c3ab15d.png)

- **Table**
```csharp
var table = new Table();
table.SetColumns = new string[] {"Column 1", "Column 2", "Column 3"};
table.AddRow("Row 1 Cell 1", "Row 1 Cell 2", "Row 1 Cell 3");
table.AddRow("Row 2 Cell 1", "Row 2 Cell 2", "Row 2 Cell 3");
table.AddRow("Row 3 Cell 1", "Row 3 Cell 2", "Row 3 Cell 3");
table.WriteTable();

var table2 = new Table(ConsoleColor.Green);
table2.SetColumns = new string[] {"Column 1", "Column 2", "Column 3", "Column 4"};
table2.HeaderAlign = TextAlign.Middle;
table2.ColumnAlign = TextAlign.Middle;
table2.AddRow("Row 1 Cell 1", "Row 1 Cell 2", "Row 1 Cell 3", "Row 1 Cell 4");
table2.AddRow("Row 2 Cell 1", "Row 2 Cell 2", "Row 2 Cell 3", "Row 2 Cell 4");
table2.AddRow("Row 3 Cell 1", "Row 3 Cell 2", "Row 3 Cell 3", "Row 3 Cell 4");
table2.WriteTable();
```
![Table](https://user-images.githubusercontent.com/25779434/124819070-02e2c000-df29-11eb-9ef1-d7ebaa9e4dc9.png)

## :memo: License
This project is licensed under MIT License.
