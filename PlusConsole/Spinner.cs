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
        private int _counter = 0;
        private bool _active;
        private readonly int _wait = 100;
        private readonly string _label = "Loading";
        private readonly string _steps = @"/-\|";
        private readonly Thread _thread;
        private readonly ConsoleColor _prevColor = Console.ForegroundColor;
        private readonly ConsoleColor _spinnerColor = Console.ForegroundColor;

        public Spinner()
        {
            this._thread = new Thread(Step);
        }

        public Spinner(string labelText, ConsoleColor spinnerColor)
        {
            this._label = labelText;
            this._spinnerColor = spinnerColor;
            this._prevColor = Console.ForegroundColor;
            this._thread = new Thread(Step);
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

        public void Dispose()
        {
            Remove();
        }

        private void Remove()
        {
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
    }

}
