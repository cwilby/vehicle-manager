using VehicleManagerClean.Core.Domain;
using VehicleManagerClean.Core.Repository;
using VehicleManagerClean.Data.Infrastructure;

namespace VehicleManagerClean.Data.Repository
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
