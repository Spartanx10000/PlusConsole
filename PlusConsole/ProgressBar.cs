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
        // Total of operations
        private int _Total;
        // Show label
        private bool _Label;
        // Default bar lenght
        private int _BarLenght = 50;

        public ProgressBar(int total, bool label = true)
        {
            _Total = total;
            _Label = label;
            // Default bar color
            this.ProgressBarColor = ConsoleColor.White;
            // Show numbers 
            this.ShowNumbers = false;
            // Defaut separator for numbers
            this.NumbersSeparator = "/";
            // Default border simbols
            this.LeftBorder = "(";
            this.RightBorder = ")";
        }

        /// <summary>
        /// Specifies the bar color.
        /// </summary>
        public ConsoleColor ProgressBarColor { get; set; }

        /// <summary>
        /// Specifies if numbers are display.
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

        public void UpdateProgress(int pProgress)
        {
            // Hide cursor
            Console.CursorVisible = false;
            // Draw the progress bar
            ConsoleColor savecolor = Console.BackgroundColor;
            DrawProgressBar(Convert.ToInt32((pProgress * _BarLenght) / (double)_Total));
            Console.BackgroundColor = savecolor;
            // Display label
            if (_Label)
                DrawText(pProgress);
            // Jump line when finish
            if (pProgress == _Total)
            {
                Console.CursorLeft = _BarLenght + 2;
                Console.WriteLine(" ");
            }
            // Show cursor 
            Console.CursorVisible = true;
        }

        private void DrawProgressBar(int pProgress)
        {
            // Draw the left border simbol
            Console.CursorLeft = 0;
            Console.Write(this.LeftBorder);
            // Draw the right border simbol
            Console.CursorLeft = _BarLenght + 1;
            Console.Write(this.RightBorder);
            Console.CursorLeft = 1;
            // Draw the progress
            for (int i = 1; i <= pProgress; i++)
            {
                Console.BackgroundColor = this.ProgressBarColor;
                Console.CursorLeft = i;
                Console.Write(" ");
            }
        }

        private void DrawText(int pProgress)
        {
            Console.CursorLeft = _BarLenght + 3;
            if (!this.ShowNumbers)
                // Draw the percent
                Console.Write(Convert.ToInt32((pProgress * 100) / (double)_Total) + "%    ");
            else
                // Draw the numbers
                Console.Write(pProgress.ToString() + " " + this.NumbersSeparator + " " + _Total.ToString() + "    ");
        }
    }
}
