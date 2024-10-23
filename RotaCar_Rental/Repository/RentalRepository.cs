

using RotaCar_Rental.Repository.IRepository;

namespace RotaCar_Rental.Repository
{
    public class RentalRepository : Repository<Rental>, IRental
    {
        private ApplicationDbContext _db;
        public RentalRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Rental obj)
        {
            throw new NotImplementedException();
        }
    }
}
