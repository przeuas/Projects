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
    public class ZarzadzanieUrzytkownikiemController : Controller
    {
        private ModelKlientDBCtxt db = new ModelKlientDBCtxt();

        // GET: ZarzadzanieUrzytkownikiem
        public ActionResult Index()
        {
            return View(db.Klienci.ToList());
        }

        // GET: ZarzadzanieUrzytkownikiem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelKlient modelKlient = db.Klienci.Find(id);
            if (modelKlient == null)
            {
                return HttpNotFound();
            }
            return View(modelKlient);
        }

        // GET: ZarzadzanieUrzytkownikiem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZarzadzanieUrzytkownikiem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Imie,Nazwisko,email,telefon")] ModelKlient modelKlient)
        {
            if (ModelState.IsValid)
            {
                db.Klienci.Add(modelKlient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modelKlient);
        }

        // GET: ZarzadzanieUrzytkownikiem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelKlient modelKlient = db.Klienci.Find(id);
            if (modelKlient == null)
            {
                return HttpNotFound();
            }
            return View(modelKlient);
        }

        // POST: ZarzadzanieUrzytkownikiem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Imie,Nazwisko,email,telefon")] ModelKlient modelKlient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modelKlient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modelKlient);
        }

        // GET: ZarzadzanieUrzytkownikiem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelKlient modelKlient = db.Klienci.Find(id);
            if (modelKlient == null)
            {
                return HttpNotFound();
            }
            return View(modelKlient);
        }

        // POST: ZarzadzanieUrzytkownikiem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModelKlient modelKlient = db.Klienci.Find(id);
            db.Klienci.Remove(modelKlient);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
