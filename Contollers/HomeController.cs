using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using LeapYear.Models;

namespace LeapYear.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
