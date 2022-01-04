using Microsoft.AspNetCore.Mvc;

namespace StartBootstrap_Asp.Areas.Admin.Controllers
{
	[Area("admin")]
	public class LoginController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}
	}
}
