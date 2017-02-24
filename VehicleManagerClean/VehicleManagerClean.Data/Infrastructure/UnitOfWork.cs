using VehicleManagerClean.Core.Infrastructure;

namespace VehicleManagerClean.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory _databaseFactory;
        private VehicleDataContext _dataContext;

        protected VehicleDataContext DataContext => _dataContext ?? (_dataContext = _databaseFactory.GetDataContext());

        public void Commit()
        {
            DataContext.SaveChanges();
        }

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
        }
    }
}
