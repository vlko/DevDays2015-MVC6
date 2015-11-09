using Microsoft.AspNet.Mvc;

namespace devdays 
{
	[Route("[controller]")]
	public class HomeController : Controller
	{
		[Route("/")]
		public IActionResult Index()
		{
			return View();
		}
		
		[Route("[action]")]
		public string Detail()
		{
			return "Detail";
		}
	}
}