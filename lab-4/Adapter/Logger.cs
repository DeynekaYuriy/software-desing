using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Adapter
{
    public class Logger
    {
        public virtual void Log(string message)
        {
            Console.WriteLine(message);
        }
        public virtual void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public virtual void Warn(string message) {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
