using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RotaCar_Rental.Repository.IRepository;

namespace RotaCar_Rental.Areas.Customer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ApiPostController : ControllerBase
	{
		private readonly IUnitOfWork _unit;
		public ApiPostController(IUnitOfWork unit) { 
			this._unit = unit;
		}
		[Produces("application/json")]
		[HttpGet("search")]
		public async Task<IActionResult> Search()
		{
			try
			{
				string term = HttpContext.Request.Query["term"].ToString();
				var locationName = _unit.location.GetAll(a=>a.Name.Contains(term)).Select(a=>a.Name).ToList();
				return Ok(locationName);
			}
			catch (Exception)
			{

				return BadRequest();
			}


		}

	}
}
