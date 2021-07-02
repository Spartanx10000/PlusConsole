using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlusConsole
{
    internal class Utils
    {
        public static string TitleAlign(char character, string title, TextAlign align)
        {
            string line = string.Empty;
            int width = Console.BufferWidth;
            string value = "[ "+ title +" ]";
            switch (align)
            {
                case TextAlign.Left:
                    int RightOffSet = width - value.Length;
                    line = value + new string(character, RightOffSet);
                    break;
                case TextAlign.Middle:
                    int OffSet = System.Convert.ToInt32(width / 2) - System.Convert.ToInt32(value.Length / 2);
                    line = (new string(character, OffSet) + value + new string(character, OffSet));
                    break;
                case TextAlign.Right:
                    int LeftOffSet = width - value.Length;
                    line = new string(character, LeftOffSet) + value;
                    break;
            }
            return line;
        }

        public static string[] Split(string value, int length)
        {
            int slength = value.Length;
            int rlength;
            string[] lines = new string[((value.Length / length) - 1 + (((value.Length % length) > 0) ? 1 : 0)) + 1];
            for (int i = 0; i <= lines.Length - 1; i++)
            {
                rlength = slength - i * length;
                if (rlength < length)
                    lines[i] = value.Substring((i * length), rlength);
                else
                    lines[i] = value.Substring((i * length), length);
            }
            return lines;
        }

        public static string PadCenter(string value, int length)
        {
            int spaces = length - value.Length;
            int padLeft = spaces / 2 + value.Length;
            return value.PadLeft(padLeft).PadRight(length);
        }
    }
}
