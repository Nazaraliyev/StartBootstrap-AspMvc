using Microsoft.AspNetCore.Mvc;

namespace StartBootstrap_Asp.Areas.Admin.Controllers
{
    [Area("admin")]
    public class BannerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
