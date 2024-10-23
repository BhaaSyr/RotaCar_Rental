using RotaCar_Rental.Repository.IRepository;
using RotaCar_Rental.Models;

namespace RotaCar_Rental.Repository.IRepository
{
    public interface IMaintenanceHistory : IRepository<MaintenanceHistory>
    {
        void Update(MaintenanceHistory obj);
    }
}
