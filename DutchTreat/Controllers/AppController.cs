using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DutchTreat.ViewModels;
using DutchTreat.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IEmailService _mailservice;

        public AppController(IEmailService mailService){
            _mailservice = mailService;
        }


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
            if (ModelState.IsValid) { 
                _mailservice.SendMessage(model);
                ViewBag.UserMessage = "Nachricht gesendet!";
                ModelState.Clear();
            }
            return View();
       }


        [HttpGet("info")]
        public IActionResult Info()
        {
             return View();
        }

    }
}
