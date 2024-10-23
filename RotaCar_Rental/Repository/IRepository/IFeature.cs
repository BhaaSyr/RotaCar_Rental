using RotaCar_Rental.Models;

namespace RotaCar_Rental.Repository.IRepository
{
	public interface IFeature : IRepository<Feature>
	{
		void Update(Feature obj);
	}
}
