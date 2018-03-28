using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proj.Models;


namespace Proj.Controllers
{
    public class HomeController : Controller
    {
        MedGenContext db;
        public HomeController(MedGenContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Patients.ToList());
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult MainPage()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Anketa()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Anketa(Man man)
        {
            db.People.Add(man);
            db.SaveChanges();
            return View();
        }
    }
}
