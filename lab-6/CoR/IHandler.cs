using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_6.CoR.Enums;

namespace lab_6.CoR
{
    
    public interface IHandler
    {
        public IHandler SetNext(IHandler handler);
        public void HandleQuestion();
    }
}
