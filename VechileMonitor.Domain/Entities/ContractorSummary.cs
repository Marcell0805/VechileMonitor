using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechileMonitor.Domain.Entities
{
    public class ContractorSummary
    {
        public string ContractorName { get; set; }
        public string VechilesCount { get; set; }
        public string TonsTotal { get; set; }
    }
}
