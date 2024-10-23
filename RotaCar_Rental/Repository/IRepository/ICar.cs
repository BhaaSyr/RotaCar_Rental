using RotaCar_Rental.Repository.IRepository;
namespace RotaCar_Rental.Repository.IRepository
{
    public interface ICar : IRepository<Car>
    {
       
     
        void Update( Car carData);



    }
}
