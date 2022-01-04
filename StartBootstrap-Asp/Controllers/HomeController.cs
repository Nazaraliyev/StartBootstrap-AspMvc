using Microsoft.AspNetCore.Mvc;

namespace StartBootstrap_Asp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
