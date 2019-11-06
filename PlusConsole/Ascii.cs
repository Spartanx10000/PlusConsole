//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusConsole
// Class: Ascii.cs
// Description: This class contains the functions to work with ASCII.
//--------------------------------------------------------------------------------------------------------------------

using System;
using System.Text.RegularExpressions;

namespace PlusConsole
{
    public class Ascii
    {
        private Font _font;

        public Ascii(Figlet type = Figlet.Standard)
        {
            this._font = new Font(type);
        }

        public string StringToAscii(string value)
        {
            string ascii = string.Empty;
            for (int i = 1; i <= _font.Height; i++)
            {
                foreach (var car in value)
                    ascii += this.GetCharacter(car, i);
                ascii += Environment.NewLine;
            }
            return ascii;
        }

        public string GetCharacter(char value, int line)
        {
            int i = this._font.CommentLines + ((Convert.ToInt32(value) - 32) * this._font.Height);
            string temp = this._font.FileLines[i + line];
            var lineend = temp[temp.Length - 1];
            Regex regex = new Regex(@"\" + lineend + "{1,2}$");
            temp = regex.Replace(temp, "");
            return temp.Replace(this._font.HardBlank, " ");
        }
    }
}
