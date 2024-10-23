using RotaCar_Rental.Repository.IRepository;
namespace RotaCar_Rental.Repository.IRepository
{
    public interface ILocation :IRepository<Location>
    {
        void Update(Location obj);
    }
}
