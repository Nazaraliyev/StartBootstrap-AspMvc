using Microsoft.AspNetCore.Mvc;
using StartBootstrap_Asp.Data;
using StartBootstrap_Asp.Models;
using System.Linq;

namespace StartBootstrap_Asp.Areas.Admin.Controllers
{
    [Area("admin")]
    public class BannerController : Controller
    {
        private readonly AppDbContext _context;

        public BannerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.settings.FirstOrDefault());
        }

        public IActionResult Update()
        {
            return View(_context.settings.FirstOrDefault());
        }


        [HttpPost]
        public IActionResult Update(Settings model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                return View(model);
            }
        }
    }
}
