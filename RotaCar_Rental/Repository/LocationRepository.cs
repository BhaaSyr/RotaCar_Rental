
using RotaCar_Rental.Repository.IRepository;
using System.Linq.Expressions;

namespace RotaCar_Rental.Repository
{
    public class LocationRepository :Repository<Location>, ILocation
    {

        private ApplicationDbContext _db;
        public LocationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

		public void Update(Location obj)
		{
			throw new NotImplementedException();
		}
	}
}
