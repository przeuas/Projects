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
    public class ZarzazanieZamowieniemController : Controller
    {
        private ModelZamowienieDBCtxt db = new ModelZamowienieDBCtxt();

        // GET: ZarzazanieZamowieniem
        public ActionResult Index()
        {
            return View(db.Zamowienia.ToList());
        }

        // GET: ZarzazanieZamowieniem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelZamowienie modelZamowienie = db.Zamowienia.Find(id);
            if (modelZamowienie == null)
            {
                return HttpNotFound();
            }
            return View(modelZamowienie);
        }

        // GET: ZarzazanieZamowieniem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZarzazanieZamowieniem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,data")] ModelZamowienie modelZamowienie)
        {
            if (ModelState.IsValid)
            {
                db.Zamowienia.Add(modelZamowienie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modelZamowienie);
        }

        // GET: ZarzazanieZamowieniem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelZamowienie modelZamowienie = db.Zamowienia.Find(id);
            if (modelZamowienie == null)
            {
                return HttpNotFound();
            }
            return View(modelZamowienie);
        }

        // POST: ZarzazanieZamowieniem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,data")] ModelZamowienie modelZamowienie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modelZamowienie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modelZamowienie);
        }

        // GET: ZarzazanieZamowieniem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelZamowienie modelZamowienie = db.Zamowienia.Find(id);
            if (modelZamowienie == null)
            {
                return HttpNotFound();
            }
            return View(modelZamowienie);
        }

        // POST: ZarzazanieZamowieniem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModelZamowienie modelZamowienie = db.Zamowienia.Find(id);
            db.Zamowienia.Remove(modelZamowienie);
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
