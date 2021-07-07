//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusConsole
// Class: Section.cs
// Description: This class contains the structure and information section.
//--------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections;

namespace PlusConsole
{
    public class Section
    {
        private readonly ConsoleColor _prevColor = Console.ForegroundColor;
        private readonly ConsoleColor _foreColor = Console.ForegroundColor;
        private readonly char _topBottomChar = '=';
        private readonly char _leftRightChar = '|';
        private readonly char _cornersChar = '+';
        private readonly string _title;
        private TextAlign _titleAlign = TextAlign.Left;
        private ArrayList _lines = new ArrayList();
        private ArrayList _aligns = new ArrayList();

        public Section()
        {
            this._title = string.Empty;
        }

        public Section(ConsoleColor color)
        {
            this._title = string.Empty;
            this._foreColor = color;
        }

        public Section(string title)
        {
            this._title = title;
        }

        public Section(string title, ConsoleColor color)
        {
            this._title = title;
            this._foreColor = color;
        }

        public Section(string title, TextAlign titleAlign)
        {
            this._title = title;
            this._titleAlign = titleAlign;
        }

        public Section(string title, TextAlign titleAlign, ConsoleColor color)
        {
            this._title = title;
            this._titleAlign = titleAlign;
            this._foreColor = color;
        }

        /// <summary>
        /// Add a new line to the section.
        /// </summary>
        public void AddLine(string value, TextAlign textAlign = TextAlign.Left)
        {
            this._lines.Add(value);
            this._aligns.Add(textAlign);
        }

        /// <summary>
        /// Write the representation of the section information.
        /// </summary>
        public void WriteSection()
        {
            int width = ((Console.BufferWidth % 2) == 0) ? Console.BufferWidth - 2 : Console.BufferWidth - 1;
            int titleWidth = ((_title.Length % 2) == 0) ? _title.Length : _title.Length + 1;
            int OffSet;
            int LeftOffSet;
            int RightOffSet;

            Console.ForegroundColor = _foreColor;

            switch (_titleAlign)
            {
                case TextAlign.Left:
                    RightOffSet = width - _title.Length;
                    Console.WriteLine(_cornersChar.ToString() + _topBottomChar.ToString() + _title + (new string(_topBottomChar, RightOffSet - 3)) + _cornersChar.ToString());
                    break;
                case TextAlign.Middle:
                    OffSet = System.Convert.ToInt32(width / 2) - System.Convert.ToInt32(titleWidth / 2);
                    LeftOffSet = OffSet - 1;
                    RightOffSet = ((_title.Length % 2) == 0) ? OffSet - 1 : OffSet;
                    Console.WriteLine(_cornersChar.ToString() + new string(_topBottomChar, LeftOffSet) + _title + new string(_topBottomChar, RightOffSet) + _cornersChar.ToString());
                    break;
                case TextAlign.Right:
                    LeftOffSet = width - _title.Length;
                    Console.WriteLine(_cornersChar.ToString() + new string(_topBottomChar, LeftOffSet - 3) + _title + _topBottomChar.ToString() + _cornersChar.ToString());
                    break;
                default:
                    Console.WriteLine(_cornersChar.ToString() + (new string(_topBottomChar, width - 2)) + _cornersChar.ToString());
                    break;
            }
            int index = 0;
            foreach (string l in _lines)
            {
                var line = "";
                switch ((TextAlign)_aligns[index])
                {
                    case TextAlign.Right:
                        line = _leftRightChar.ToString() + " " + l.PadLeft(width - 3) + _leftRightChar.ToString();
                        break;
                    case TextAlign.Middle:
                        line = _leftRightChar.ToString() + " " + Utils.PadCenter(l, width - 3) + _leftRightChar.ToString();
                        break;
                    case TextAlign.Left:
                        line = _leftRightChar.ToString() + " " + l.PadRight(width - 3) + _leftRightChar.ToString();
                        break;
                }
                Console.WriteLine(line);
                index++;
            }
            Console.WriteLine(_cornersChar.ToString() + new string(_topBottomChar, width - 2) + _cornersChar.ToString());
            Console.ForegroundColor = _prevColor;
        }


    }
}
