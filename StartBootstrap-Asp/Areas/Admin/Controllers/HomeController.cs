﻿using Microsoft.AspNetCore.Mvc;

namespace StartBootstrap_Asp.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
