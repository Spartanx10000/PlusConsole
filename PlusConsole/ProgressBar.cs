//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusConsole
// Class: ProgressBar.cs
// Description: This class contains the properties and functions for the progress bar.
//--------------------------------------------------------------------------------------------------------------------

using System;

namespace PlusConsole
{
    public class ProgressBar
    {
        private readonly int _total;
        private readonly bool _label;
        private static int _lenght = 50;

        /// <summary>
        /// Specifies the bar color.
        /// </summary>
        public ConsoleColor ProgressBarColor { get; set; }

        /// <summary>
        /// Specifies whether the number of operations is shown.
        /// </summary>
        public bool ShowNumbers { get; set; }

        /// <summary>
        /// Specifies the separator simbol for the numbers.
        /// </summary>
        public string NumbersSeparator { get; set; }

        /// <summary>
        /// Specifies the left simbol use as border for the bar.
        /// </summary>
        public string LeftBorder { get; set; }

        /// <summary>
        /// Specifies the right simbol use as border for the bar.
        /// </summary>
        public string RightBorder { get; set; }

        public ProgressBar(int total, bool label = true)
        {
            this._total = total;
            this._label = label;
            this.ProgressBarColor = ConsoleColor.White;
            this.ShowNumbers = false;
            this.NumbersSeparator = "/";
            this.LeftBorder = "(";
            this.RightBorder = ")";
        }

        public void UpdateProgress(int progress)
        {
            Console.CursorVisible = false;
            ConsoleColor savecolor = Console.BackgroundColor;
            DrawProgressBar(Convert.ToInt32((progress * _lenght) / (double)_total));
            Console.BackgroundColor = savecolor;
            if (_label) 
            { 
                DrawText(progress); 
            }
            if (progress == _total)
            {
                Console.CursorLeft = _lenght + 2;
                Console.WriteLine(" ");
            } 
            Console.CursorVisible = true;
        }

        private void DrawProgressBar(int progress)
        {
            Console.CursorLeft = 0;
            Console.Write(this.LeftBorder);
            Console.CursorLeft = _lenght + 1;
            Console.Write(this.RightBorder);
            Console.CursorLeft = 1;
            for (int i = 1; i <= progress; i++)
            {
                Console.BackgroundColor = this.ProgressBarColor;
                Console.CursorLeft = i;
                Console.Write(" ");
            }
        }

        private void DrawText(int progress)
        {
            Console.CursorLeft = _lenght + 3;
            if (!this.ShowNumbers) 
            { 
                Console.Write(Convert.ToInt32((progress * 100) / (double)_total) + "%    ");
            }
            else 
            { 
                Console.Write(progress.ToString() + " " + this.NumbersSeparator + " " + _total.ToString() + "    ");
            }
        }
    }
}
