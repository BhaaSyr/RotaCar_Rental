using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RotaCar_Rental.Models.ViewModels;
using RotaCar_Rental.Repository.IRepository;
using RotaCar_Rental.Utility;

namespace RotaCar_Rental.Areas.Admin.Controllers { 

 [Area("Admin")]
[Authorize(Roles = SD.Role_User_Admin)]
	public class DashboardController : Controller
	{
		private IUnitOfWork _unit;
		public DashboardController(IUnitOfWork unit)
		{
			this._unit = unit;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Tables()
		{
			Tables tables = new Tables();
			tables.Cars = _unit.car.GetAll();
			tables.Rentals = _unit.rental.GetAll();
			tables.Payments = _unit.payment.GetAll();
			tables.Features = _unit.feature.GetAll();
			tables.maintenanceHistory = _unit.maintenanceHistory.GetAll();
			tables.Reviews = _unit.review.GetAll();
			tables.Locations = _unit.location.GetAll();
			return View(tables);
		}
	}
}
