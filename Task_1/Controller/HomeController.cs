﻿using Microsoft.AspNetCore.Mvc;

namespace Task_1
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
