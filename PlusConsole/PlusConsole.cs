//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusConsole
// Class: PlusConsole.cs
// Description: This class contains the main functions of the library.
//--------------------------------------------------------------------------------------------------------------------

using System;

namespace PlusConsole
{
    /// <summary>
    /// This class contains the main functions of the PlusConsole library.
    /// </summary>
    public class PlusConsole
    {
        /// <summary>
        /// Write the specified string value with ASCII characters.
        /// </summary>
        public static void WriteASCII(string value)
        {
            Ascii banner = new Ascii();
            string ascii = banner.StringToAscii(value);
            Console.WriteLine(ascii);
        }

        /// <summary>
        /// Write the specified string value with ASCII characters and the specified console color.
        /// </summary>
        public static void WriteASCII(string value, ConsoleColor color)
        {
            ConsoleColor basecolor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            WriteASCII(value);
            Console.ForegroundColor = basecolor;
        }

        /// <summary>
        /// Write the specified string value with ASCII characters of the specified font.
        /// </summary>
        public static void WriteASCII(string value, Figlet font)
        {
            Ascii banner = new Ascii(font);
            string ascii = banner.StringToAscii(value);
            Console.WriteLine(ascii);
        }

        /// <summary>
        /// Write the specified string value with ASCII characters of the specified font and the specified console color.
        /// </summary>
        public static void WriteASCII(string value, Figlet font, ConsoleColor color)
        {
            ConsoleColor basecolor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            WriteASCII(value, font);
            Console.ForegroundColor = basecolor;
        }

        /// <summary>
        /// Write a character line.
        /// </summary>
        public static void Separator()
        {
            char defaultchar = '=';
            Separator(defaultchar);
        }

        /// <summary>
        /// Write a line of the specified character.
        /// </summary>
        public static void Separator(char character)
        {
            Console.WriteLine(new string(character, Console.BufferWidth));
        }

        /// <summary>
        /// Write a line of the specified character with a text.
        /// </summary>
        public static void Separator(char character, string text)
        {
            Console.WriteLine(Utils.TitleAlign(character, text, TextAlign.Left));
        }

        /// <summary>
        /// Write a line of the specified character with a text in the alignment specified.
        /// </summary>
        public static void Separator(char character, string text, TextAlign align)
        {
            Console.WriteLine(Utils.TitleAlign(character, text, align));
        }

        /// <summary>
        /// Write a character line with the console color specified.
        /// </summary>
        public static void Separator(ConsoleColor color)
        {
            ConsoleColor basecolor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Separator();
            Console.ForegroundColor = basecolor;
        }

        /// <summary>
        /// Write a line of the specified character with the console color specified.
        /// </summary>
        public static void Separator(char character, ConsoleColor color)
        {
            ConsoleColor basecolor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Separator(character);
            Console.ForegroundColor = basecolor;
        }

        /// <summary>
        /// Write a line of the specified character with a text and the console color specified.
        /// </summary>
        public static void Separator(char character, string text, ConsoleColor color)
        {
            ConsoleColor basecolor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Separator(character, text);
            Console.ForegroundColor = basecolor;
        }

        /// <summary>
        /// Write a line of the specified character with a text in the alignment specified and the console color specified.
        /// </summary>
        public static void Separator(char character, string text, TextAlign align, ConsoleColor color)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Separator(character, text, align);
            Console.ForegroundColor = prevColor;
        }

        /// <summary>
        /// Write a error line.
        /// </summary>
        public static void WriteError(string value)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ForegroundColor = prevColor;
        }

        /// <summary>
        /// Write a success line.
        /// </summary>
        public static void WriteSuccess(string value)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(value);
            Console.ForegroundColor = prevColor;
        }

        /// <summary>
        /// Write a warning line.
        /// </summary>
        public static void WriteWarning(string value)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
            Console.ForegroundColor = prevColor;
        }

        /// <summary>
        /// Write a information line.
        /// </summary>
        public static void WriteInfo(string value)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(value);
            Console.ForegroundColor = prevColor;
        }

        /// <summary>
        /// Write the representation of the error message.
        /// </summary>
        public static void WriteErrorMessage(string message)
        {
            var Error = new Section("[   ERROR   ]", TextAlign.Middle, ConsoleColor.Red);
            foreach (string item in Utils.Split(message, Console.BufferWidth - 6))
            {
                Error.AddLine(item);
            }           
            Error.WriteSection();
        }

        /// <summary>
        /// Write the representation of the error message with the specified title.
        /// </summary>
        public static void WriteErrorMessage(string title, string message)
        {
            var Error = new Section("[   " + title + "   ]", TextAlign.Middle, ConsoleColor.Red);
            foreach (string item in Utils.Split(message, Console.BufferWidth - 6))
            {
                Error.AddLine(item);
            }
            Error.WriteSection();
        }

        /// <summary>
        /// Write the representation of the success message.
        /// </summary>
        public static void WriteSuccessMessage(string message)
        {
            var Success = new Section("[   SUCCESS   ]", TextAlign.Middle, ConsoleColor.DarkGreen);
            foreach (string item in Utils.Split(message, Console.BufferWidth - 6))
            {
                Success.AddLine(item);
            }
            Success.WriteSection();
        }

        /// <summary>
        /// Write the representation of the success message with the specified title.
        /// </summary>
        public static void WriteSuccessMessage(string title, string message)
        {
            var Success = new Section("[   " + title + "   ]", TextAlign.Middle, ConsoleColor.DarkGreen);
            foreach (string item in Utils.Split(message, Console.BufferWidth - 6))
            {
                Success.AddLine(item);
            }
            Success.WriteSection();
        }

        /// <summary>
        /// Write the representation of the warning message.
        /// </summary>
        public static void WriteWarningMessage(string message)
        {
            var Warning = new Section("[   WARNING   ]", TextAlign.Middle, ConsoleColor.Yellow);
            foreach (string item in Utils.Split(message, Console.BufferWidth - 6))
            {
                Warning.AddLine(item);
            }
            Warning.WriteSection();
        }

        /// <summary>
        /// Write the representation of the warning message with the specified title.
        /// </summary>
        public static void WriteWarningMessage(string title, string message)
        {
            var Warning = new Section("[   " + title + "   ]", TextAlign.Middle, ConsoleColor.Yellow);
            foreach (string item in Utils.Split(message, Console.BufferWidth - 6))
            {
                Warning.AddLine(item);
            }
            Warning.WriteSection();
        }

        /// <summary>
        /// Write the representation of the info message.
        /// </summary>
        public static void WriteInfoMessage(string message)
        {
            var Info = new Section("[   INFO   ]", TextAlign.Middle, ConsoleColor.Cyan);
            foreach (string item in Utils.Split(message, Console.BufferWidth - 6))
            {
                Info.AddLine(item);
            }
            Info.WriteSection();
        }

        /// <summary>
        /// Write the representation of the info message with the specified title.
        /// </summary>
        public static void WriteInfoMessage(string title, string message)
        {
            var Info = new Section("[   " + title + "   ]", TextAlign.Middle, ConsoleColor.Cyan);
            foreach (string item in Utils.Split(message, Console.BufferWidth - 6))
            {
                Info.AddLine(item);
            }
            Info.WriteSection();
        }

        /// <summary>
        /// Write the representation of the format string.
        /// </summary>
        public static void WriteFormat(string format, params string[] items)
        {
            int lenght = format.Length;
            int index = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (format[i] != '{')
                {
                    Console.Write(format[i]);
                }
                else
                {
                    if ((int)char.GetNumericValue(format[i + 1]) == index && format[i + 2] == '}')
                    {
                            i += 2;
                            Console.Write(items[index]);
                            index++;
                    }
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Write the representation of the format string with values highlight in the specifies color.
        /// </summary>
        public static void WriteFormat(string format, ConsoleColor color, params string[] items)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            int lenght = format.Length;
            int index = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (format[i] != '{')
                {
                    Console.Write(format[i]);
                }
                else
                {
                    if ((int)char.GetNumericValue(format[i + 1]) == index && format[i + 2] == '}')
                    {
                        i += 2;
                        Console.ForegroundColor = color;
                        Console.Write(items[index]);
                        Console.ForegroundColor = prevColor;
                        index++;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
