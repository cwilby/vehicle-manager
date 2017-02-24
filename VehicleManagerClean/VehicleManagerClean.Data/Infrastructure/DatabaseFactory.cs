using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerClean.Core.Infrastructure;

namespace VehicleManagerClean.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private readonly VehicleDataContext _dataContext;

        public VehicleDataContext GetDataContext()
        {
            return _dataContext ?? new VehicleDataContext();
        }

        public DatabaseFactory()
        {
            _dataContext = new VehicleDataContext();
        }

        protected override void DisposeCore()
        {
            _dataContext?.Dispose();
        }
    }

    public interface IDatabaseFactory
    {
        VehicleDataContext GetDataContext();
    }
}
