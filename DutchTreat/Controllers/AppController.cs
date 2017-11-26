using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("kontakt")]
        public IActionResult Kontakt()
        {
            ViewBag.Title = "Kontaktieren Sie uns";
            return View();
        }

        [HttpGet("info")]
        public IActionResult Info()
        {
            ViewBag.Title = "Über uns";
            return View();
        }

    }
}
