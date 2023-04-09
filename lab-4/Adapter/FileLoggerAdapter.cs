using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Adapter
{
    public class FileLoggerAdapter : Logger
    {
        private FileLogger _fileLogger;
        public FileLoggerAdapter(string _filePath)
        {
            _fileLogger = new FileLogger(_filePath);
        }
        public override void Log(string message)
        {
            _fileLogger.Log(message);
        }
        public override void Error(string message)
        {
            _fileLogger.Error(message);
        }
        public override void Warn(string message)
        {
            _fileLogger.Warn(message);
        }
    }
}
