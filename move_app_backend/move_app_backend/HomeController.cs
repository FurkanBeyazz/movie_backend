﻿using Microsoft.AspNetCore.Mvc;

namespace move_app_backend
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult Index2()
		{
			return View();
		}
	}
}
