using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class ZarzadzanieKoszykiemController : Controller
    {
        private ModelKoszykDBCtxt db = new ModelKoszykDBCtxt();
        private ModelSpektaklDBCtxt db1 = new ModelSpektaklDBCtxt();

       
        // GET: ZarzadzanieKoszykiem
        public ActionResult Index()
        {
            return View(db.Koszyki.ToList());
        }

        // GET: ZarzadzanieKoszykiem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            ModelKoszyk modelKoszyk = db.Koszyki.Find(id);
            if (modelKoszyk == null)
            {
                return HttpNotFound();
            }
            return View(modelKoszyk);
        }

        // GET: ZarzadzanieKoszykiem/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: ZarzadzanieKoszykiem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,iloscBiletow,iloscUlgowych,Miejsce,Rzad,Cena")] ModelKoszyk modelKoszyk)
        {
            if (ModelState.IsValid)
            {
                db.Koszyki.Add(modelKoszyk);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modelKoszyk);
        }

        // GET: ZarzadzanieKoszykiem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelKoszyk modelKoszyk = db.Koszyki.Find(id);
            if (modelKoszyk == null)
            {
                return HttpNotFound();
            }
            return View(modelKoszyk);
        }

        // POST: ZarzadzanieKoszykiem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,iloscBiletow,iloscUlgowych,Miejsce,Rzad,Cena")] ModelKoszyk modelKoszyk)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modelKoszyk).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modelKoszyk);
        }

        // GET: ZarzadzanieKoszykiem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelKoszyk modelKoszyk = db.Koszyki.Find(id);
            if (modelKoszyk == null)
            {
                return HttpNotFound();
            }
            return View(modelKoszyk);
        }

        // POST: ZarzadzanieKoszykiem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModelKoszyk modelKoszyk = db.Koszyki.Find(id);
            db.Koszyki.Remove(modelKoszyk);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Spektakl()
        {
            return View("Spektakl",new ModelSpektakl());
        }
        public ActionResult Repertuar()
        {
           
            return View("Repertuar", new ModelRepertuar());
        }
        public ActionResult UtworzSpektakl()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UtworzSpektakl([Bind(Include = "IDs,Lokalizacja,Wykonawcy,Tytuł,Auror,Cena,data")] ModelSpektakl modelspk)
        {
            if (ModelState.IsValid)
            {
                db1.Spektakle.Add(modelspk);
                db1.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modelspk);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //obsluga obrazkow

        public ActionResult CreateImg()

        {

            return View();

        }
    }
}
