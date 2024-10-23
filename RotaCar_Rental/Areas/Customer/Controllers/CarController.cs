using Microsoft.AspNetCore.Mvc;
using RotaCar_Rental.Repository.IRepository;

namespace RotaCar_Rental.Areas.Users.Controllers
{
	[Area("Customer")]
	public class CarController : Controller
    {
        private IUnitOfWork _unit;
        public CarController(IUnitOfWork unit)
        {
            this._unit = unit;
        }
        public IActionResult car()
        {
            return View();
        }
        public IActionResult car_single(int id)
        {
            if (id!=0) {
                
                var car = _unit.car.Get(a=>a.Id ==id,includeProperties: "Features"); 
                //car.Features = _unit.feature.Get()
                return View(car);
            }
            return View();

            
        }
        public IActionResult Pricing()
        {
            return View();
        }
    }
}
