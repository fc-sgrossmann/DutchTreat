using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DutchTreat.ViewModels;

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
            return View();
        }

        [HttpPost("kontakt")]
        public IActionResult Kontakt(KontaktViewModel model)
        {
            return View();
        }


        [HttpGet("info")]
        public IActionResult Info()
        {
             return View();
        }

    }
}
