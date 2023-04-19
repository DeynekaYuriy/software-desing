using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.TextReader
{
    public interface ITextReader
    {
        public char[,] ReadText(string filePath);
    }
}
