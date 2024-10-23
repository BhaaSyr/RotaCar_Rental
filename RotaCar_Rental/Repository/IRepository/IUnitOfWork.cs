

namespace RotaCar_Rental.Repository.IRepository
{
    public interface IUnitOfWork
    {

        
            ICar car { get; }
            ILocation location { get; }
            IPayment payment { get; }
            IRental rental { get; }
            IReview review { get; }
		    IFeature feature { get; }
		    IMaintenanceHistory maintenanceHistory { get; }
            

            void Save();
        
    }
}
