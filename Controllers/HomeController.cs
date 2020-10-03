using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutureValue.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "Phil";
            ViewBag.FV = 99999.99;
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
                
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }
    }
}
