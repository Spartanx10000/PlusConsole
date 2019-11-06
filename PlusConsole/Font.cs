//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusConsole
// Class: Font.cs
// Description: This class contains the structure and functions to load figlet fonts.
//--------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PlusConsole
{
    public class Font
    {
        public string Id { get; set; }
        public string HardBlank { get; set; }
        public int Height { get; set; }
        public int BaseLine { get; set; }
        public int MaxLenght { get; set; }
        public int OldLayout { get; set; }
        public int CommentLines { get; set; }
        public int PrintDirection { get; set; }
        public int FullLayout { get; set; }
        public int CodeTagCount { get; set; }
        public List<string> FileLines { get; set; }
        public Figlet FontType { get; set; }

        public Font(Figlet type = Figlet.Standard)
        {
            this.FontType = type;
            this.LoadFont();
        }

        private void LoadLines(List<string> fileLines)
        {
            this.FileLines = fileLines;
            string firstLine = this.FileLines.First();
            string[] lineContent = firstLine.Split(' ');
            this.Id = lineContent.First().Remove(lineContent.First().Length - 1);
            if (this.Id == "flf2a")
            {
                this.HardBlank = lineContent.First().Last().ToString();
                this.Height = System.Convert.ToInt32(lineContent.GetValue(1));
                this.BaseLine = System.Convert.ToInt32(lineContent.GetValue(2));
                this.MaxLenght = System.Convert.ToInt32(lineContent.GetValue(3));
                this.OldLayout = System.Convert.ToInt32(lineContent.GetValue(4));
                this.CommentLines = System.Convert.ToInt32(lineContent.GetValue(5));
                this.PrintDirection = System.Convert.ToInt32(lineContent.GetValue(6));
                this.FullLayout = System.Convert.ToInt32(lineContent.GetValue(7));
                this.CodeTagCount = System.Convert.ToInt32(lineContent.GetValue(8));
            }
        }

        private void LoadFont()
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(this.GetFontResourceName(this.FontType)))
            {
                this.FontStream(stream);
            }
        }

        private void FontStream(Stream stream)
        {
            var fileLines = new List<string>();
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    fileLines.Add(reader.ReadLine());
                }                   
            }
            LoadLines(fileLines);
        }

        private string GetFontResourceName(Figlet fontType)
        {
            string baseName = "PlusConsole.";
            string resourceName = string.Empty;
            switch (fontType)
            {
                case Figlet.Standard:
                    resourceName = "Fonts.standard.flf";
                    break;
                case Figlet.Big:
                    resourceName = "Fonts.big.flf";
                    break;
                case Figlet.Mini:
                    resourceName = "Fonts.mini.flf";
                    break;
                case Figlet.Banner:
                    resourceName = "Fonts.banner.flf";
                    break;
            }
            return baseName + resourceName;
        }
    }
}
