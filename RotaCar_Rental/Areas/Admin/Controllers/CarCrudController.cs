using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Edit(int id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var selectedCar = _unit.car.Get(a => a.Id == id);


            return View(selectedCar);

        }
        [HttpPost]
        public IActionResult Edit(Car Updatecar)
        {

            _unit.car.Update(Updatecar);
            return View(Updatecar);

        }
    }
}
