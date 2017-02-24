using System.Data.Entity;
using VehicleManagerClean.Core.Domain;

namespace VehicleManagerClean.Data.Infrastructure
{
    public class VehicleDataContext : DbContext
    {
        public VehicleDataContext() : base("Vehicle")
        {

        }

        public IDbSet<Vehicle> Vehicles { get; set; }
    }
}
