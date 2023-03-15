using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Currency
    {
        public string Name { get; }
        public char Sign { get; }

        public Currency(string name, char sign)
        {
            Name = name;
            Sign = sign;
        }
    }
}
