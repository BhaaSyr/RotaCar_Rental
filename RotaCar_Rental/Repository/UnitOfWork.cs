

using RotaCar_Rental;
using RotaCar_Rental.Repository;
using RotaCar_Rental.Repository.IRepository;

namespace Cars_rental.Repository
{
    public class UnitOfWork : IUnitOfWork
    { 
        private ApplicationDbContext _db;


        public ILocation location { get; private set; }

        public IPayment payment { get; private set; }

        public IRental rental { get; private set; }

        public IReview review { get; private set; }
		public IFeature feature { get; private set; }

		public IMaintenanceHistory maintenanceHistory { get; private set; }

        public ICar car { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            car = new CarRepository(db);
            location = new LocationRepository(db);
            review = new ReviewRepository(db);
            payment = new PaymentRepository(db);
            rental = new RentalRepository(db);
            maintenanceHistory = new MaintenanceHistoryRepository(db);
            feature = new FeatureRepository(db);

        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
