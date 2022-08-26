using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VechileMonitor.Domain.Entities;

namespace VechileMonitor.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Contractor> Customers { get; set; }

        Task<int> SaveChangesAsync();
    }
}
