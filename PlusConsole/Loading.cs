//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusConsole
// Class: Loading.cs
// Description: This class contains the functions for the Loading status.
//--------------------------------------------------------------------------------------------------------------------

using System;
using System.Threading;

namespace PlusConsole
{
    public class Loading
    {
        private static Status obj;
        private static Thread t1;
        private static ConsoleColor prevcolor;

        public Loading()
        {
            obj = new Status();
            t1 = new Thread(obj.UpdateProcess);
        }

        public Loading(string message, string mark)
        {
            obj = new Status(message, mark);
            t1 = new Thread(obj.UpdateProcess);
        }

        public Loading(string message, string mark, ConsoleColor color)
        {
            obj = new Status(message, mark);
            obj.Color = color;
            t1 = new Thread(obj.UpdateProcess);
        }

        public void StartLoading()
        {
            prevcolor = Console.ForegroundColor;
            t1.Start();
        }

        public void StopLoading()
        {
            t1.Abort();
            Console.ForegroundColor = prevcolor;
            obj.EndProcess();
        }

    }
}
