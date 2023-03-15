﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Structures
{
    public struct ReportSubmission
    {
        public string Name { get; set; }
        public uint Quantity { get; set; }
        public string Unit { get; set; }
        public DateTime Date { get; set; }
    }
}
