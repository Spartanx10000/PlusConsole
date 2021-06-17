//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusConsole
// Class: PlusConsole.cs
// Description: This class contains the main functions of the library.
//https://weblog.west-wind.com/posts/2020/Jul/10/A-NET-Console-Color-Helper
//https://github.com/deinsoftware/colorify
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
            Console.WriteLine(titleAlign(character, text, TextAlign.Left));
        }

        /// <summary>
        /// Write a line of the specified character with a text in the alignment specified.
        /// </summary>
        public static void Separator(char character, string text, TextAlign align)
        {
            Console.WriteLine(titleAlign(character, text, align));
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
        /// Write a line of the specified character with a text with the console color specified.
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
        /// Write the representation of the section information.
        /// </summary>
        public static void WriteSection(Section section)
        {
            int width = ((Console.BufferWidth % 2) == 0) ? Console.BufferWidth - 2 : Console.BufferWidth - 1;
            int titleWidth = ((section.Title.Length % 2) == 0) ? section.Title.Length : section.Title.Length + 1;
            int OffSet;
            int LeftOffSet;
            int RightOffSet;

            switch (section.TitleAlign)
            {
                case TextAlign.Left:
                    RightOffSet = width - section.Title.Length;
                    Console.WriteLine(section.GetCornersChar().ToString() + section.GetTopBottomBorderChar().ToString() + section.Title + (new string(section.GetTopBottomBorderChar(),RightOffSet - 3)) + section.GetCornersChar().ToString());
                    break;
                case TextAlign.Middle:
                    OffSet = System.Convert.ToInt32(width / 2) - System.Convert.ToInt32(titleWidth / 2);
                    LeftOffSet = OffSet - 1;
                    RightOffSet = ((section.Title.Length % 2) == 0) ? OffSet - 1 : OffSet;
                    Console.WriteLine(section.GetCornersChar().ToString() + new string(section.GetTopBottomBorderChar(), LeftOffSet) + section.Title + new string(section.GetTopBottomBorderChar(), RightOffSet) + section.GetCornersChar().ToString());
                    break;
                case TextAlign.Right:
                    LeftOffSet = width - section.Title.Length;
                    Console.WriteLine(section.GetCornersChar().ToString() + new string(section.GetTopBottomBorderChar(), LeftOffSet - 3) + section.Title + section.GetTopBottomBorderChar().ToString() + section.GetCornersChar().ToString());
                    break;
                default:
                    Console.WriteLine(section.GetCornersChar().ToString() + (new string(section.GetTopBottomBorderChar(), width - 2)) + section.GetCornersChar().ToString());
                    break;
            }

            foreach (string line in section.GetLines())
            {
                int lineOffSet = width - line.Length;
                var value = section.GetLeftRightBorderChar().ToString() + " " + line + new string(' ', lineOffSet - 3) + section.GetLeftRightBorderChar().ToString();
                Console.WriteLine(value);
            }
            Console.WriteLine(section.GetCornersChar().ToString() + new string(section.GetTopBottomBorderChar(), width - 2) + section.GetCornersChar().ToString());
        }

        /// <summary>
        /// Write the representation of the section information the specified console color.
        /// </summary>
        public static void WriteSection(Section section, ConsoleColor color)
        {
            ConsoleColor basecolor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            WriteSection(section);
            Console.ForegroundColor = basecolor;
        }

        /// <summary>
        /// Write the representation of the error message.
        /// </summary>
        public static void WriteError(string msj)
        {
            Section Info = new Section("[   ERROR   ]", TextAlign.Middle);
            foreach (string item in Split(msj, Console.BufferWidth - 6))
            {
                Info.AddLine(item);
            }           
            WriteSection(Info, ConsoleColor.Red);
        }

        /// <summary>
        /// Write the representation of the error message with the specified title.
        /// </summary>
        public static void WriteError(string title, string msj)
        {
            Section Info = new Section("[   " + title + "   ]", TextAlign.Middle);
            foreach (string item in Split(msj, Console.BufferWidth - 6))
            {
                Info.AddLine(item);
            }              
            WriteSection(Info, ConsoleColor.Red);
        }

        /// <summary>
        /// Write the representation of the success message.
        /// </summary>
        public static void WriteSuccess(string msj)
        {
            Section Info = new Section("[   SUCCESS   ]", TextAlign.Middle);
            foreach (string item in Split(msj, Console.BufferWidth - 6))
            {
                Info.AddLine(item);
            }           
            WriteSection(Info, ConsoleColor.DarkGreen);
        }

        /// <summary>
        /// Write the representation of the success message with the specified title.
        /// </summary>
        public static void WriteSuccess(string title, string msj)
        {
            Section Info = new Section("[   " + title + "   ]", TextAlign.Middle);
            foreach (string item in Split(msj, Console.BufferWidth - 6))
            {
                Info.AddLine(item);
            }               
            WriteSection(Info, ConsoleColor.DarkGreen);
        }

        /// <summary>
        /// Write the representation of the warning message.
        /// </summary>
        public static void WriteWarning(string msj)
        {
            Section Info = new Section("[   WARNING   ]", TextAlign.Middle);
            foreach (string item in Split(msj, Console.BufferWidth - 6))
            {
                Info.AddLine(item);
            }
            WriteSection(Info, ConsoleColor.Yellow);
        }

        /// <summary>
        /// Write the representation of the warning message with the specified title.
        /// </summary>
        public static void WriteWarning(string title, string msj)
        {
            Section Info = new Section("[   " + title + "   ]", TextAlign.Middle);
            foreach (string item in Split(msj, Console.BufferWidth - 6))
            {
                Info.AddLine(item);
            }
            WriteSection(Info, ConsoleColor.Yellow);
        }

        /// <summary>
        /// Write the representation of the info message.
        /// </summary>
        public static void WriteInfo(string msj)
        {
            Section Info = new Section("[   INFO   ]", TextAlign.Middle);
            foreach (string item in Split(msj, Console.BufferWidth - 6))
            {
                Info.AddLine(item);
            }
            WriteSection(Info, ConsoleColor.Cyan);
        }

        /// <summary>
        /// Write the representation of the info message with the specified title.
        /// </summary>
        public static void WriteInfo(string title, string msj)
        {
            Section Info = new Section("[   " + title + "   ]", TextAlign.Middle);
            foreach (string item in Split(msj, Console.BufferWidth - 6))
            {
                Info.AddLine(item);
            }
            WriteSection(Info, ConsoleColor.Cyan);
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

        private static string titleAlign(char character, string title, TextAlign align)
        {
            string value = string.Empty;
            int width = Console.BufferWidth;
            switch (align)
            {
                case TextAlign.Left:
                        int RightOffSet = width - title.Length;
                        value = title + new string(character,RightOffSet);
                        break;
                case TextAlign.Middle:
                        int OffSet = System.Convert.ToInt32(width / 2) - System.Convert.ToInt32(title.Length / 2);
                        value = (new string(character, OffSet) + title + new string(character, OffSet));
                        break;
                case TextAlign.Right:
                        int LeftOffSet = width - title.Length;
                        value = new string(character, LeftOffSet) + title;
                        break;
            }
            return value;
        }

        private static string[] Split(string value, int size)
        {
            int slength = value.Length;
            int rlength;
            string[] lines = new string[((value.Length / size) - 1 + (((value.Length % size) > 0) ? 1 : 0)) + 1];
            for (int i = 0; i <= lines.Length - 1; i++)
            {
                rlength = slength - i * size;
                if (rlength < size)
                    lines[i] = value.Substring((i * size), rlength);
                else
                    lines[i] = value.Substring((i * size), size);
            }
            return lines;
        }
    }
}
