using System;
using VehicleManagerClean.Core.Domain;
using VehicleManagerClean.Core.Infrastructure;

namespace VehicleManagerClean.Core.Repository
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
    }
}