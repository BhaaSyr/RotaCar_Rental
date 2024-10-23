using RotaCar_Rental.Models;
using RotaCar_Rental.Repository.IRepository;

namespace RotaCar_Rental.Repository
{
	public class FeatureRepository : Repository<Feature>, IFeature
	{
		private ApplicationDbContext _db;
		public FeatureRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}
		public void Update(Feature obj)
		{
			throw new NotImplementedException();
		}
	}
}
