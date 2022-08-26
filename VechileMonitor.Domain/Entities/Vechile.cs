using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechileMonitor.Domain.Entities
{
    public class Vechile
    {
        public int RegisterNo { get; set; }
        public string VechileType { get; set; }
        public string Model { get; set; }
        public decimal VechileWeight { get; set; }
        public string ContractorID { get; set; }
    }
}
