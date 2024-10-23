

using RotaCar_Rental.Repository.IRepository;


namespace RotaCar_Rental.Repository
{
    public class PaymentRepository : Repository<Payment>, IPayment
    {

        private ApplicationDbContext _db;
        public PaymentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Payment obj)
        {
            throw new NotImplementedException();
        }
    }
}
