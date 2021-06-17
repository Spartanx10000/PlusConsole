//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusConsole
// Class: Spinner.cs
// Description: This class contains the properties and functions for the spinner.
//--------------------------------------------------------------------------------------------------------------------

using System;
using System.Threading;

namespace PlusConsole
{
    public class Spinner : IDisposable
    {
        private string _label = "Loading";
        private const string _steps = @"/-\|";
        private int _counter = 0;
        private static ConsoleColor _prevColor;
        private readonly int _wait = 100;
        private bool _active;
        private readonly Thread _thread;
        private static ConsoleColor _spinnerColor;

        public Spinner()
        {
            _spinnerColor = ConsoleColor.Green;
            _prevColor = Console.ForegroundColor;
            _thread = new Thread(Step);
        }

        public Spinner(string labelText, ConsoleColor spinnerColor)
        {
            _label = labelText;
            _spinnerColor = spinnerColor;
            _prevColor = Console.ForegroundColor;
            _thread = new Thread(Step);
        }

        public void Start()
        {
            _active = true;
            if (!_thread.IsAlive)
            {
                _thread.Start();
            }          
        }

        public void Stop()
        {
            _active = false;
            Remove();
        }

        private void Remove()
        {
            // Hide cursor to improve visuals
            Console.CursorVisible = false;
            for (int i = 1; i <= _label.Length + 3; i++)
            {
                Console.CursorLeft = i;
                Console.Write(" ");
            }
            Console.CursorLeft = 0; 
            Console.CursorVisible = true;
            Console.ForegroundColor = _prevColor;
        }

        private void Step()
        {
            while (_active)
            {
                Draw(_steps[++_counter % _steps.Length]);
                Thread.Sleep(_wait);
            }
        }

        private void Draw(char c)
        {
            Console.CursorVisible = false;
            Console.CursorLeft = 1;
            Console.ForegroundColor = _spinnerColor;
            Console.Write(_label);
            Console.CursorLeft = _label.Length + 2;
            Console.Write(c);
            Console.CursorVisible = true;
        }

        public void Dispose()
        {
            Remove();
        }
    }

}
