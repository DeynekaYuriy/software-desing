using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Adapter
{
    public class FileLogger
    {
        private FileWriter _fileWriter;
        public FileLogger(string filePath)
        {
            _fileWriter = new FileWriter(filePath);
        }
        public void Log(string message)
        {
            _fileWriter.WriteLine("Log: " + message);
        }
        public void Error(string message)
        {
            _fileWriter.WriteLine("Error: " + message);
        }
        public void Warn(string message)
        {
            _fileWriter.WriteLine("Warning: " + message);
        }
    }
}
