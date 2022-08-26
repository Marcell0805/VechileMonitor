using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VechileMonitor.Domain.Entities;
using VehicleMonitorService.Interfaces;

namespace VehicleMonitorService.Implementation
{
    public class VehicleService : IVehicle
    {
        public void AddTruck(Vechile vechileData)
        {
            throw new NotImplementedException();
        }

        public void DeleteTruck(Vechile vechileData)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vechile>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vechile>> GetDetails(int contractorID)
        {
            throw new NotImplementedException();
        }

        public void UpdateTruck(Vechile vechileData)
        {
            throw new NotImplementedException();
        }
    }
}
