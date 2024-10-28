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


		[HttpPost]
		public IActionResult Edit(Car Updatecar)
		{

			_unit.car.Update(Updatecar);
			return View(Updatecar);

		}
		#region API Calls
		[HttpGet]
		public ActionResult GetAll()
		{
			List<Car> objCarList = _unit.car.GetAll().ToList();
			return Json(new { data = objCarList });

		}
		[HttpDelete]
		public IActionResult Delete(int? id)
		{
			var CarToBeDeleted = _unit.car.Get(u => u.Id == id);
			if (CarToBeDeleted == null)
			{
				return Json(new { success = false, message = "Error while deleting" });
			}

			//string productPath = @"images\products\product-" + id;
			//string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, productPath);

			//if (Directory.Exists(finalPath))
			//{
			//    string[] filePaths = Directory.GetFiles(finalPath);
			//    foreach (string filePath in filePaths)
			//    {
			//        System.IO.File.Delete(filePath);
			//    }

			//    Directory.Delete(finalPath);
			//}


			_unit.car.Remove(CarToBeDeleted);
			_unit.Save();

			return Json(new { success = true, message = "Delete Successful" });
		}

		#endregion
	}
}
