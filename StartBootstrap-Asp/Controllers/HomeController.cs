using Microsoft.AspNetCore.Mvc;
using StartBootstrap_Asp.Data;
using StartBootstrap_Asp.ViewModel;
using System.Linq;

namespace StartBootstrap_Asp.Controllers
{
    public class HomeController : Controller
    {
		private readonly AppDbContext _context;

		public HomeController(AppDbContext context)
		{
			_context = context;
		}
        public IActionResult Index()
        {
            VmHome model = new VmHome()
            {
                sosialMedia = _context.sosialMedias.ToList(),
                portfolios = _context.portfolios.Take(6).ToList(),
                settings = _context.settings.FirstOrDefault()

            };
            return View(model);
        }
    }
}
