using Cars_rental.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RotaCar_Rental.Models;
using RotaCar_Rental.Models.ViewModels;
using RotaCar_Rental.Repository.IRepository;
using RotaCar_Rental.Utility;

namespace RotaCar_Rental.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles =SD.Role_User_Admin)]
    public class FeatureController : Controller
    {
        private IUnitOfWork _unit;
        public FeatureController(IUnitOfWork unit)
        {
            this._unit = unit;
        }
        public IActionResult Index()
        {
            IEnumerable<Feature> featuresList = _unit.feature.GetAll();
            return View(featuresList);
        }

		public IActionResult Edit(int? id)
		{

			Feature feature = new Feature();

			if (id == null || id == 0)

			{//create
				return View(feature);
			}
			else
			{//update
				feature = _unit.feature.Get(u => u.Id == id);



				return View(feature);

			}

		}
		[HttpPost]
		public IActionResult Edit(Feature obj, List<IFormFile>? files)
		{

			//obj.attribute.Images = _unitOfWork.Image.GetAll(u => u.attributId == obj.attribute.Id).ToList();
			//obj.Product.attributes = new List<attributes>();
			//obj.Product.attributes.Add(obj.attribute);
			if (ModelState.IsValid)
			{
				if (obj.Id == 0)
				{

					_unit.feature.Add(obj);
				}
				else
				{
					_unit.feature.Update(obj);

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
			TempData["success"] = "Feature created/updated successfully";
			return RedirectToAction("Index");



		}
		#region API Calls
		[HttpGet]
		public ActionResult GetAll()
		{
			List<Feature> objFeatureList = _unit.feature.GetAll().ToList();
			return Json(new { data = objFeatureList });

		}
		[HttpDelete]
		public IActionResult Delete(int? id)
		{
			var FeatureToBeDeleted = _unit.feature.Get(u => u.Id == id);
			if (FeatureToBeDeleted == null)
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


			_unit.feature.Remove(FeatureToBeDeleted);
			_unit.Save();

			return Json(new { success = true, message = "Delete Successful" });
		}

		#endregion

	}

}

