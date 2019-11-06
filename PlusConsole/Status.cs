//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusConsole
// Class: ProgressBar.cs
// Description: This class contains the properties and functions for the status.
//--------------------------------------------------------------------------------------------------------------------

using System;

namespace PlusConsole
{
    public class Status
    {
        private string _LoadingMsj;
        private string _Mark;
        private int _Pos = 1;

        public Status(string message = "Loading", string mark = ".")
        {
            _LoadingMsj = message;
            _Mark = mark;
            // Default color
            this.Color = Console.ForegroundColor;
        }

        public ConsoleColor Color { get; set; }

        public void UpdateProcess()
        {
            while (true)
            {
                // Hide cursor to improve visuals
                Console.CursorVisible = false;
                // Show the loading status
                DrawLoading();
                // Sleep the thread
                System.Threading.Thread.Sleep(100);
                // show cursor 
                Console.CursorVisible = true;
            }
        }

        public void EndProcess()
        {
            // Hide cursor to improve visuals
            Console.CursorVisible = false;
            // clear the loading status
            for (int i = 1; i <= _LoadingMsj.Length + 3; i++)
            {
                Console.CursorLeft = i;
                Console.Write(" ");
            }
            Console.CursorLeft = 0;
            // show cursor 
            Console.CursorVisible = true;
        }

        private void DrawLoading()
        {
            Console.ForegroundColor = this.Color;
            // Show message
            Console.CursorLeft = 1;
            Console.Write(_LoadingMsj);
            // Show animation
            if (_Pos < 4)
            {
                Console.CursorLeft = _LoadingMsj.Length + _Pos;
                Console.Write(_Mark);
            }
            // Reset animation
            if (_Pos == 4)
            {
                Console.CursorLeft = (_LoadingMsj.Length + _Pos) - 1;
                Console.Write(" ");
                Console.CursorLeft = (_LoadingMsj.Length + _Pos) - 2;
                Console.Write(" ");
                Console.CursorLeft = (_LoadingMsj.Length + _Pos) - 3;
                Console.Write(" ");
                _Pos = 1;
            }
            else
            {
                _Pos += 1;
            }
        }

    }
}
