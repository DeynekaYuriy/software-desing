using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Structures
{
    public struct ReportProfit
    {
            public string Name { get; set; }
            public Money Price { get; set; }
            public uint Quantity { get; set; }
            public Money ProfitAmount { get; set; }   
    }
}
