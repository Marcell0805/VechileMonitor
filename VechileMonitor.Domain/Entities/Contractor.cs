using System.Collections.Generic;

namespace VechileMonitor.Domain.Entities
{
    public class Contractor 
    {
        public int ContractorID { get; set; }
        public string ContractorName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
