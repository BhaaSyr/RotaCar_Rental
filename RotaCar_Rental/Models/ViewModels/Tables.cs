namespace RotaCar_Rental.Models.ViewModels
{
	public class Tables
	{
		public IEnumerable<Car>? Cars { get; set; }
		public IEnumerable<Feature>? Features { get; set; }
		public IEnumerable<Location>? Locations { get; set; }
		public IEnumerable<MaintenanceHistory>? maintenanceHistory { get; set; }
		public IEnumerable<Payment>? Payments { get; set; }
		public IEnumerable<Rental>? Rentals { get; set; }
		public IEnumerable<Review>? Reviews { get; set; }
		
	}
}
