using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.Flyweight
{
    public class MemoryMonitor
    {
        public static void LogCurrentProccessMemory()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Console.WriteLine($"Memory usage: {currentProcess.WorkingSet64.ToSmallestFullSize()}");
        }
    }
}
