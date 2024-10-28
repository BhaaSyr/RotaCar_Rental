using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RotaCar_Rental.Models.ViewModels
{
	public class CarEditVM
	{
		[ValidateNever]
		public Car? Car { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem>? Features { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem>? Location { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem>? maintenanceHistory { get; set; }

		
	}
}
