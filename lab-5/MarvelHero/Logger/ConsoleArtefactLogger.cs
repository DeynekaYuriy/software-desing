using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.MarvelHero.Logger
{
    public class ConsoleArtefactLogger : IArtefactLogger
    {
        public void Added(int count)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Added "+count+" artefacts");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Removed(int count)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Removed "+count+" artefacts");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
