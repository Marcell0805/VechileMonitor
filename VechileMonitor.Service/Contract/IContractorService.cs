using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VechileMonitor.Domain.Entities;

namespace VechileMonitor.Service.Contract
{
    public  interface IContractorService
    {
        Task<IEnumerable<Contractor>> GetAll();
        Task<IEnumerable<Contractor>> GetSummary();
    }
}
