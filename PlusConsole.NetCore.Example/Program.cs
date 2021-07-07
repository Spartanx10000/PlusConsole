using System;

namespace PlusConsole.NetCore.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthMax = Console.WindowWidth;
            //Console.WriteLine(widthMax);
            Console.WindowWidth = widthMax;
            Console.BufferWidth = widthMax;

            //WriteASCII
            PlusConsole.WriteASCII("PlusConsole.");
            PlusConsole.WriteASCII("PlusConsole.", ConsoleColor.Cyan);
            PlusConsole.WriteASCII("PlusConsole.", Figlet.Mini, ConsoleColor.Green);
            PlusConsole.WriteASCII("PlusConsole.", Figlet.Big, ConsoleColor.Yellow);

            Console.WriteLine();

            //Separator
            PlusConsole.Separator();
            PlusConsole.Separator(ConsoleColor.Red);
            PlusConsole.Separator('/', ConsoleColor.Green);
            PlusConsole.Separator('#', " SAMPLE ");
            PlusConsole.Separator('*', " SAMPLE ", TextAlign.Middle);
            PlusConsole.Separator('-', " SAMPLE ", TextAlign.Right);
            PlusConsole.Separator('*', " SAMPLE ", TextAlign.Middle, ConsoleColor.Blue);

            Console.WriteLine();

            //WriteSection
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

            Console.WriteLine();

            PlusConsole.WriteError("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            PlusConsole.WriteSuccess("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            PlusConsole.WriteWarning("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            PlusConsole.WriteInfo("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");

            Console.WriteLine();

            //WriteError
            PlusConsole.WriteErrorMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");
            PlusConsole.WriteErrorMessage("Sample Error Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");

            Console.WriteLine();

            //WriteSuccess
            PlusConsole.WriteSuccessMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");
            PlusConsole.WriteSuccessMessage("Sample Success Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");

            Console.WriteLine();

            //WriteWarning
            PlusConsole.WriteWarningMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");
            PlusConsole.WriteWarningMessage("Sample Warning Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");

            Console.WriteLine();

            //WriteInfo
            PlusConsole.WriteInfoMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");
            PlusConsole.WriteInfoMessage("Sample Info Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus posuere condimentum ex, nec cursus augue feugiat vitae. Aliquam fringilla lorem et sodales ullamcorper. Integer sollicitudin urna auctor nulla iaculis ultricies.");

            Console.WriteLine();

            ////WriteFormat
            PlusConsole.WriteFormat("Hello {0}", "World");
            PlusConsole.WriteFormat("Hello {0}",ConsoleColor.Cyan, "World");
            PlusConsole.WriteFormat("Hello {0} {1}", "World",":)");
            PlusConsole.WriteFormat("Process End...[{0}] {1}", ConsoleColor.Green, "OK", "2 Records");
            PlusConsole.WriteFormat("Process End...[{0}] {1}", ConsoleColor.Red, "Error", "404");

            Console.WriteLine();

            //Simulate number of operations
            int total_operations = 100;

            ////Progressbar
            var progress1 = new ProgressBar(total_operations, true);

            for (int i = 1; i <= total_operations; i++)
            {
                //Simulate work
                System.Threading.Thread.Sleep(50);
                progress1.UpdateProgress(i);
            }

            Console.WriteLine();

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

            Console.WriteLine();

            //Spinner
            var spinner = new Spinner();
            spinner.Start();
            //Simulate work
            System.Threading.Thread.Sleep(10000);
            spinner.Stop();

            var spinner2 = new Spinner("Downloading", ConsoleColor.Green);
            spinner2.Start();
            //Simulate work
            System.Threading.Thread.Sleep(10000);
            spinner2.Stop();

            //Table
            var table = new Table();
            table.SetColumns = new string[] { "Column 1", "Column 2", "Column 3" };
            table.AddRow("Row 1 Cell 1", "Row 1 Cell 2", "Row 1 Cell 3");
            table.AddRow("Row 2 Cell 1", "Row 2 Cell 2", "Row 2 Cell 3");
            table.AddRow("Row 3 Cell 1", "Row 3 Cell 2", "Row 3 Cell 3");
            table.WriteTable();

            var table2 = new Table(ConsoleColor.Green);
            table2.SetColumns = new string[] { "Column 1", "Column 2", "Column 3", "Column 4" };
            table2.HeaderAlign = TextAlign.Middle;
            table2.ColumnAlign = TextAlign.Middle;
            table2.AddRow("Row 1 Cell 1", "Row 1 Cell 2", "Row 1 Cell 3", "Row 1 Cell 4");
            table2.AddRow("Row 2 Cell 1", "Row 2 Cell 2", "Row 2 Cell 3", "Row 2 Cell 4");
            table2.AddRow("Row 3 Cell 1", "Row 3 Cell 2", "Row 3 Cell 3", "Row 3 Cell 4");
            table2.WriteTable();

            Console.WriteLine();

            Console.WriteLine("Press any key to close the console.");
            Console.ReadKey();

        }
    }
}
