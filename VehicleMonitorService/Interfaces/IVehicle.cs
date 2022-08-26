using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VechileMonitor.Domain.Entities;

namespace VehicleMonitorService.Interfaces
{
    public interface IVehicle
    {
        Task<IEnumerable<Vechile>> GetAll();
        Task<IEnumerable<Vechile>> GetDetails(int contractorID);
        void AddTruck(Vechile vechileData);
        void UpdateTruck(Vechile vechileData);
        void DeleteTruck(Vechile vechileData);
    }
}
