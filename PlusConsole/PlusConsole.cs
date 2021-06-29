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
            ConsoleColor basecolor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Separator(character, text, align);
            Console.ForegroundColor = basecolor;
        }

        /// <summary>
        /// Write a error line.
        /// </summary>
        public static void WriteError(string value)
        {
            Console.WriteLine(value, ConsoleColor.Red);
        }

        /// <summary>
        /// Write a success line.
        /// </summary>
        public static void WriteSuccess(string value)
        {
            Console.WriteLine(value, ConsoleColor.DarkGreen);
        }

        /// <summary>
        /// Write a warning line.
        /// </summary>
        public static void WriteWarning(string value)
        {
            Console.WriteLine(value, ConsoleColor.Yellow);
        }

        /// <summary>
        /// Write a information line.
        /// </summary>
        public static void WriteInfo(string value)
        {
            Console.WriteLine(value, ConsoleColor.Cyan);
        }

        /// <summary>
        /// Write the representation of the error message.
        /// </summary>
        public static void WriteErrorMessage(string msj)
        {
            Section Error = new Section("[   ERROR   ]", TextAlign.Middle, ConsoleColor.Red);
            foreach (string item in Utils.Split(msj, Console.BufferWidth - 6))
            {
                Error.AddLine(item);
            }           
            Error.WriteSection();
        }

        /// <summary>
        /// Write the representation of the error message with the specified title.
        /// </summary>
        public static void WriteErrorMessage(string title, string msj)
        {
            Section Error = new Section("[   " + title + "   ]", TextAlign.Middle, ConsoleColor.Red);
            foreach (string item in Utils.Split(msj, Console.BufferWidth - 6))
            {
                Error.AddLine(item);
            }
            Error.WriteSection();
        }

        /// <summary>
        /// Write the representation of the success message.
        /// </summary>
        public static void WriteSuccessMessage(string msj)
        {
            Section Success = new Section("[   SUCCESS   ]", TextAlign.Middle, ConsoleColor.DarkGreen);
            foreach (string item in Utils.Split(msj, Console.BufferWidth - 6))
            {
                Success.AddLine(item);
            }
            Success.WriteSection();
        }

        /// <summary>
        /// Write the representation of the success message with the specified title.
        /// </summary>
        public static void WriteSuccessMessage(string title, string msj)
        {
            Section Success = new Section("[   " + title + "   ]", TextAlign.Middle, ConsoleColor.DarkGreen);
            foreach (string item in Utils.Split(msj, Console.BufferWidth - 6))
            {
                Success.AddLine(item);
            }
            Success.WriteSection();
        }

        /// <summary>
        /// Write the representation of the warning message.
        /// </summary>
        public static void WriteWarningMessage(string msj)
        {
            Section Warning = new Section("[   WARNING   ]", TextAlign.Middle, ConsoleColor.Yellow);
            foreach (string item in Utils.Split(msj, Console.BufferWidth - 6))
            {
                Warning.AddLine(item);
            }
            Warning.WriteSection();
        }

        /// <summary>
        /// Write the representation of the warning message with the specified title.
        /// </summary>
        public static void WriteWarningMessage(string title, string msj)
        {
            Section Warning = new Section("[   " + title + "   ]", TextAlign.Middle, ConsoleColor.Yellow);
            foreach (string item in Utils.Split(msj, Console.BufferWidth - 6))
            {
                Warning.AddLine(item);
            }
            Warning.WriteSection();
        }

        /// <summary>
        /// Write the representation of the info message.
        /// </summary>
        public static void WriteInfoMessage(string msj)
        {
            Section Info = new Section("[   INFO   ]", TextAlign.Middle, ConsoleColor.Cyan);
            foreach (string item in Utils.Split(msj, Console.BufferWidth - 6))
            {
                Info.AddLine(item);
            }
            Info.WriteSection();
        }

        /// <summary>
        /// Write the representation of the info message with the specified title.
        /// </summary>
        public static void WriteInfoMessage(string title, string msj)
        {
            Section Info = new Section("[   " + title + "   ]", TextAlign.Middle, ConsoleColor.Cyan);
            foreach (string item in Utils.Split(msj, Console.BufferWidth - 6))
            {
                Info.AddLine(item);
            }
            Info.WriteSection();
        }

        /// <summary>
        /// Write the representation of the format string.
        /// </summary>
        public static void WriteFormat(string format, string item)
        {
            int lenght = format.Length;
            for (int i = 0; i < lenght; i++)
            {
                if (format[i] != '{')
                {
                    Console.Write(format[i]);
                }
                else
                {
                    if (format[i + 1] == '0' && format[i + 2] == '}')
                    {
                        i += 2;
                        Console.Write(item);
                    }
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Write the representation of the format string.
        /// </summary>
        public static void WriteFormat(string format, string item, ConsoleColor color)
        {
            ConsoleColor baseColor = Console.ForegroundColor;
            int lenght = format.Length;
            for (int i = 0; i < lenght; i++)
            {
                if (format[i] != '{')
                {
                    Console.Write(format[i]);
                }
                else
                {
                    if (format[i + 1] == '0' && format[i + 2] == '}')
                    {
                        i += 2;
                        Console.ForegroundColor = color;
                        Console.Write(item);
                        Console.ForegroundColor = baseColor;
                    }
                }
            }
            Console.WriteLine();
        }

    }
}
