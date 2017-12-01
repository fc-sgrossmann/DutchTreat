using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DutchTreat.ViewModels;
using DutchTreat.Services;
using DutchTreat.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IEmailService _mailservice;
        private readonly IDutchRepository _repository;

        public AppController(IEmailService mailService, IDutchRepository repository){
            _mailservice = mailService;
            _repository = repository;
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


        public IActionResult Shop()
        {
            var results = _repository.GetAllProducts();
            return View(results);
        }

    }
}
