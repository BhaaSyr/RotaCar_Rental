using Cars_rental.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RotaCar_Rental.Repository.IRepository;
using RotaCar_Rental.Utility;

namespace RotaCar_Rental.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles =SD.Role_User_Admin)]
    public class MaintenanceHisturyController : Controller
    {
        private IUnitOfWork _unit;
        public MaintenanceHisturyController(IUnitOfWork unit)
        {
            this._unit = unit;
        }
        public IActionResult Index()
        {
            IEnumerable<Car> carsList = _unit.car.GetAll();
            return View(carsList);
        }

        public IActionResult Edit(int id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var selectedCar = _unit.car.Get(a => a.Id == id);


            return View(selectedCar);

        }
        
	}
}
