
using Microsoft.EntityFrameworkCore;
using RotaCar_Rental.Repository.IRepository;
using System.Linq.Expressions;


namespace RotaCar_Rental.Repository
{
    public class CarRepository : Repository<Car> ,ICar
    {
        private ApplicationDbContext _db;

       
        public CarRepository(ApplicationDbContext db) :base(db) 
        {
            _db = db;
            
        }

        public void Update(Car carData)
        {
            throw new NotImplementedException();
        }
    }
}
