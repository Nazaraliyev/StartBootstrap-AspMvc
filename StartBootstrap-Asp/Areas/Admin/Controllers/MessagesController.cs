using Microsoft.AspNetCore.Mvc;

namespace StartBootstrap_Asp.Areas.Admin.Controllers
{
    [Area("admin")]
    public class MessagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
