using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.TextReader
{
    public class SmartTextChecker : ITextReader
    {
        private SmartTextReader _smartTextReader = new SmartTextReader();
        public ILogger Logger { get; set; }
        public SmartTextChecker(ILogger logger)
        {
            Logger = logger;
        }
        public char[,] ReadText(string filePath)
        {
            Logger.Log($"Opening file: {filePath}");
            var content = _smartTextReader.ReadText(filePath);
            var linesCount = content.GetLength(0);
            var charsCount = content.GetLength(0) * content.GetLength(1);
            Logger.Log($"Read {linesCount} lines and {charsCount} charachters");
            return content;
        }
    }
}
