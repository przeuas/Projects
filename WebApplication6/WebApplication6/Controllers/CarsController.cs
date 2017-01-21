using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class CarsController : Controller
    {
        private CarDBCtxt baza = new CarDBCtxt();
            
        // GET: Cars
        public ActionResult Index()
        {
            ViewData["tytyl"] = "Tytuł";
            ViewData["liczba"] = 1;

            ViewBag.tytul2 = "Tytyuł2";
            ViewBag.liczba2 = 2;

            //Car obiekt = new Car();
            //obiekt.Id = 22;

            return View(baza.Cars.ToList());
        }
        public ActionResult jakisContoler(string id1,string id2)
        {
            ViewBag.id1 = id1;
            ViewBag.id2 = id2;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="Id,Brand,Model,Price,Bought,Sold")]Car car)
        {
            if (ModelState.IsValid)
            {
                baza.Cars.Add(car);
                baza.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }

    }

}