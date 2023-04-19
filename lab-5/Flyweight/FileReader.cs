using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.Flyweight
{
    public class FileReader
    {
        public static Line[] ReadFile(string filename)
        {
            string[] strLines = File.ReadAllLines(filename);
            Line[] lines = new Line[strLines.Length];
            for (int i = 0; i < strLines.Length; i++)
            {
                lines[i] = new Line(strLines[i], i);
            }
            return lines;
        }
    }
}
