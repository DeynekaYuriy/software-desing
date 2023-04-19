using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab_5.TextReader
{
    public class SmartTextLocker : ITextReader
    {
        private SmartTextReader reader = new();
        private Regex restriction;
        public SmartTextLocker(Regex restriction)
        {
            this.restriction = restriction;
        }

        public char[,] ReadText(string filePath)
        {
            var matches = restriction.Matches(filePath);
            if (matches.Count == 0)
            {
                return reader.ReadText(filePath);

            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
            return new char[0, 0];
        }
    }
}
