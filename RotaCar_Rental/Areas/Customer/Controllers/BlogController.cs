using Microsoft.AspNetCore.Mvc;
using RotaCar_Rental.Repository.IRepository;

namespace RotaCar_Rental.Areas.Users.Controllers
{
	[Area("Customer")]
	public class BlogController : Controller
    {
        private IUnitOfWork _unit;
        public BlogController(IUnitOfWork unit)
        {
            this._unit = unit;
        }
        public IActionResult blog()
        {
            return View();
        }
        public IActionResult blog_single()
        {
            return View();
        }
    }
}
