
using RotaCar_Rental.Repository.IRepository;

namespace RotaCar_Rental.Repository
{
    public class ReviewRepository :Repository<Review>,IReview
    {
        private ApplicationDbContext _db;
        public ReviewRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Review obj)
        {
            throw new NotImplementedException();
        }
    }
}
