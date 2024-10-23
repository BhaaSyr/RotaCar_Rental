

using RotaCar_Rental.Models;
using RotaCar_Rental.Repository.IRepository;
using System.Linq.Expressions;


namespace RotaCar_Rental.Repository
{
    public class MaintenanceHistoryRepository : Repository<MaintenanceHistory>, IMaintenanceHistory
    {
        private ApplicationDbContext _db;
        public MaintenanceHistoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

		public void Update(MaintenanceHistory obj)
		{
			throw new NotImplementedException();
		}
	}
}
