using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.CoR
{
    public class AskEventArgs
    {
        public string Question;
        public AskEventArgs(string question)
        {
            Question = question;
        }
    }
}
