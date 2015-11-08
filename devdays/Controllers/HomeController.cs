using Microsoft.AspNet.Mvc;

namespace devdays 
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		
		public string Detail()
		{
			return "Detail";
		}
	}
}