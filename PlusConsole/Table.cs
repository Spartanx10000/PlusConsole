//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusConsole
// Class: Table.cs
// Description: This class contains the properties and functions for the table.
//--------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusConsole
{
    public class Table
    {
        private readonly ConsoleColor _prevColor;
        private readonly ConsoleColor _foreColor;
        private TextAlign _headerAlign = TextAlign.Left;
        private TextAlign _columnAlign = TextAlign.Left;
        private string[] _columnHeaders;
        private List<int> _lengths;
        private readonly List<string[]> _rows = new List<string[]>();

        public TextAlign HeaderAlign
        {
            set { this._headerAlign = value; }
        }

        public TextAlign ColumnAlign
        {
            set { this._columnAlign = value; }
        }

        public string[] SetColumns
        {
            set { 
                this._columnHeaders = value;
                this._lengths = _columnHeaders.Select(x => x.Length).ToList();
            }
        }

        public Table()
        {
            this._foreColor = Console.ForegroundColor;
            this._prevColor = Console.ForegroundColor;
        }

        public Table(ConsoleColor color)
        {
            this._foreColor = color;
            this._prevColor = Console.ForegroundColor;
        }

        public Table(params string[] columnHeaders)
        {
            this._columnHeaders = columnHeaders;
            this._lengths = columnHeaders.Select(x => x.Length).ToList();
            this._foreColor = Console.ForegroundColor;
            this._prevColor = Console.ForegroundColor;
        }

        public Table(ConsoleColor color, params string[] columnHeaders)
        {
            this._columnHeaders = columnHeaders;
            this._lengths = columnHeaders.Select(x => x.Length).ToList();
            this._foreColor = color;
            this._prevColor = Console.ForegroundColor;
        } 

        public void AddRow(params object[] row)
        {
            if (row.Length != _columnHeaders.Length)
            {
                throw new Exception($"The number of cells(" + row.Length + ") in the added row is not equal to the number of columns(" + _columnHeaders.Length + ").");
            }
            _rows.Add(row.Select(x => x.ToString()).ToArray());
            for (int i = 0; i < _columnHeaders.Length; i++)
            {            
                if (_rows.Last()[i].Length > _lengths[i])
                {
                    _lengths[i] = _rows.Last()[i].Length;
                }
            }
        }

        public void WriteTable()
        {
            Console.ForegroundColor = _foreColor;

            _lengths.ForEach(l => Console.Write("+=" + new string('=', l) + '='));
            Console.WriteLine("+");

            string line = "";
            for (int i = 0; i < _columnHeaders.Length; i++)
            {
                switch (_headerAlign)
                {
                    case TextAlign.Right:
                        line += "| " + _columnHeaders[i].PadLeft(_lengths[i]) + ' ';
                        break;
                    case TextAlign.Middle:
                        line += "| " + PadCenter(_columnHeaders[i], _lengths[i]) + ' ';
                        break;
                    case TextAlign.Left:
                        line += "| " + _columnHeaders[i].PadRight(_lengths[i]) + ' ';
                        break;
                }
            }
            Console.WriteLine(line + "|");
            _lengths.ForEach(l => Console.Write("+-" + new string('-', l) + '-'));
            Console.WriteLine("+");

            foreach (var row in _rows)
            {
                line = "";
                for (int i = 0; i < row.Length; i++)
                {
                    switch (_columnAlign)
                    {
                        case TextAlign.Right:
                            line += "| " + row[i].PadLeft(_lengths[i]) + ' ';
                            break;
                        case TextAlign.Middle:
                            line += "| " + PadCenter(row[i], _lengths[i]) + ' ';
                            break;
                        case TextAlign.Left:
                            line += "| " + row[i].PadRight(_lengths[i]) + ' ';
                            break;
                    }
                }
                Console.WriteLine(line + "|");
            }

            _lengths.ForEach(l => Console.Write("+=" + new string('=', l) + '='));
            Console.WriteLine("+");

            Console.ForegroundColor = _prevColor;
        }

        private static string PadCenter(string str, int length)
        {
            int spaces = length - str.Length;
            int padLeft = spaces / 2 + str.Length;
            return str.PadLeft(padLeft).PadRight(length);
        }
    }
}
