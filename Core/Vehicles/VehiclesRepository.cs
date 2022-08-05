using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Vehicles
{
    interface VehiclesRepository
    {
        Task<int> AddAsync(Vehicle vehicle);

        Task
    }
}
