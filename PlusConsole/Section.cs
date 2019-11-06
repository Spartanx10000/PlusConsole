//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusConsole
// Class: Section.cs
// Description: This class contains the structure and information section.
//--------------------------------------------------------------------------------------------------------------------

using System.Collections;

namespace PlusConsole
{
    public class Section
    {
        private char _TopBottomChar = '=';
        private char _LeftRightChar = '|';
        private char _CornersChar = '+';
        private ArrayList _Lines = new ArrayList();

        public string Title { get; set; }
        public TextAlign TitleAlign { get; set; }

        public Section()
        {
            this.Title = string.Empty;
            this.TitleAlign = TextAlign.Left;
        }

        public Section(string title)
        {
            this.Title = title;
            this.TitleAlign = TextAlign.Left;
        }

        public Section(string title, TextAlign align)
        {
            this.Title = title;
            this.TitleAlign = align;
        }

        /// <summary>
        /// Add a new line to the section.
        /// </summary>
        public void AddLine(string value)
        {
            this._Lines.Add(value);
        }

        /// <summary>
        /// Return the lines of the section.
        /// </summary>
        public ArrayList GetLines()
        {
            return this._Lines;
        }

        /// <summary>
        /// Return the char use for the top and bottom border of the section.
        /// </summary>
        public char GetTopBottomBorderChar()
        {
            return this._TopBottomChar;
        }

        /// <summary>
        /// Return the char use for the left and right border of the section.
        /// </summary>
        public char GetLeftRightBorderChar()
        {
            return this._LeftRightChar;
        }

        /// <summary>
        /// Return the char use for the corners border of the section.
        /// </summary>
        public char GetCornersChar()
        {
            return this._CornersChar;
        }
    }
}
