

namespace RotaCar_Rental.Models.ViewModels
{
	public class RentalEditVM
	{
		public IEnumerable<Car>? Cars { get; set; }
		public IEnumerable<Rental>? Rentals { get; set; }
		public IEnumerable<AppUser>? Users { get; set; }

	}
}
