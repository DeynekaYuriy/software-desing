using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.TextReader
{
    public class SmartTextReader : ITextReader
    {

        public char[,] ReadText(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            int numRows = lines.Length;
            int numCols = 0;

            foreach (string line in lines)
            {
                if (line.Length > numCols)
                {
                    numCols = line.Length;
                }
            }

            char[,] result = new char[numRows, numCols];

            for (int i = 0; i < numRows; i++)
            {
                string line = lines[i];
                for (int j = 0; j < numCols; j++)
                {
                    if (j < line.Length)
                    {
                        result[i, j] = line[j];
                    }
                    else
                    {
                        result[i, j] = ' ';
                    }
                }
            }
            return result;
        }

    }
}
