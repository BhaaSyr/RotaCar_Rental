using Microsoft.AspNetCore.Mvc;
using RotaCar_Rental.Repository.IRepository;
using System.Globalization;

namespace RotaCar_Rental.Areas.Customer.Controllers
{
	[Area("Customer")]
	public class HomeController : Controller
    {
        private IUnitOfWork _unit;
        public HomeController(IUnitOfWork unit) {
        this._unit = unit;
        }
        public IActionResult Index()
        {

            IEnumerable<Car> carsList = _unit.car.GetAll() ;
            return View(carsList);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult services()
        {
            return View();
        }

        public IActionResult ChangeLanguage(string lang)
        {
            if (!string.IsNullOrEmpty(lang)) {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
                lang = "en";
            }
            Response.Cookies.Append("Language",lang);
            return Redirect(Request.GetTypedHeaders().Referer.ToString());

        }


    }
}
