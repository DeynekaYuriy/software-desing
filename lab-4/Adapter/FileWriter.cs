using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Adapter
{
    public class FileWriter
    {
        public string FilePath { get; set; }
        public FileWriter(string filePath)
        {
            FilePath = filePath;
        }
        public void Write(string text)
        {
            File.AppendAllText(FilePath, text);
        }
        public void WriteLine(string text)
        {
            File.AppendAllText(FilePath, text + Environment.NewLine);

        }
    }
}
