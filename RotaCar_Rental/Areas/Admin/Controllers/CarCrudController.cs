﻿using Cars_rental.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RotaCar_Rental.Models.ViewModels;
using RotaCar_Rental.Repository.IRepository;
using RotaCar_Rental.Utility;

namespace RotaCar_Rental.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles =SD.Role_User_Admin)]
    public class CarCrudController : Controller
    {
        private IUnitOfWork _unit;
        public CarCrudController(IUnitOfWork unit)
        {
            this._unit = unit;
        }
        public IActionResult Index()
        {
            IEnumerable<Car> carsList = _unit.car.GetAll();
            return View(carsList);
        }

		public IActionResult Edit(int? id)
		{

			CarEditVM carEditVM = new CarEditVM()
			{
				Location = _unit.location.GetAll().Select(u => new SelectListItem
				{
					Text = u.Street+u.City+u.Zip,
					Value = u.Id.ToString()
				}),
				maintenanceHistory = _unit.maintenanceHistory.GetAll().Select(u => new SelectListItem
				{
					Text = u.Date.ToString()+","+u.Details,
					Value = u.Id.ToString()
				}),
				Features = _unit.feature.GetAll().Select(u => new SelectListItem
				{
					Text = u.Name ,
					Value = u.Id.ToString()
				}),
				Car = new Car()


			};

			if (id == null || id == 0)

			{//create
				return View(carEditVM);
			}
			else
			{//update
				carEditVM.Car = _unit.car.Get(u=>u.Id ==id);
				carEditVM.Car.location = _unit.location.Get(u => u.Id == carEditVM.Car.LocationID);
				carEditVM.Car.Features = _unit.feature.GetAll(u => u.CarID == id).ToList();
				carEditVM.Car.MaintenanceHistory = _unit.maintenanceHistory.GetAll(u => u.CarID == carEditVM.Car.Id).ToList();


				return View(carEditVM);

			}

		}
		[HttpPost]
		public IActionResult Edit(CarEditVM obj, List<IFormFile>? files)
		{

			//obj.attribute.Images = _unitOfWork.Image.GetAll(u => u.attributId == obj.attribute.Id).ToList();
			//obj.Product.attributes = new List<attributes>();
			//obj.Product.attributes.Add(obj.attribute);
			if (ModelState.IsValid)
			{
				if (obj.Car.Id == 0)
				{

					_unit.car.Add(obj.Car);
				}
				else
				{
					_unit.car.Update(obj.Car);

				}
				_unit.Save();

				//string wwwRootPath = _webHostEnvironment.WebRootPath;
				//foreach (var file in files)
				//{
				//	string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
				//	string productPath = Path.Combine(wwwRootPath, @"Images\product");
				//	using (FileStream fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
				//	{
				//		file.CopyTo(fileStream);
				//	}
				//	Image image = new()
				//	{
				//		Image_url = "/Images/product/" + fileName,
				//		attributId = obj.attribute.Id

				//	};

				//	if (obj.attribute.Images == null)
				//		obj.attribute.Images = new List<Image>();
				//	_unitOfWork.Image.Add(image);
				//	obj.attribute.Images.Add(image);

				//}

				
				_unit.Save();
			}
			TempData["success"] = "Car created/updated successfully";
			return RedirectToAction("Index");



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
