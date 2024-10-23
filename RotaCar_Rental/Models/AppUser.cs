using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotaCar_Rental.Models
{
	public class AppUser:IdentityUser
	{
		public string DriverLicenseNumber { get; set; }

		public DateTime DriverLicenseIssueDate { get; set; }

		public DateTime DriverLicenseExpiryDate { get; set; }

	}
}
