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
    public class ZarzadzanieZamowieniemController : Controller
    {
        private ModelZamowienieDBCtxt db = new ModelZamowienieDBCtxt();
        
        //private ModelKoszykDBCtxt db2 = new ModelKoszykDBCtxt();

        public ActionResult Index(ModelKoszyk modelKoszyk)
        {
            int id = modelKoszyk.DajSpektakl().Id;
            ModelSpektaklDBCtxt db = new ModelSpektaklDBCtxt();
            modelKoszyk.DodajSpektakl(db.Spektakle.Find(id));

            
        

            ModelZamowienie modelZamowienie = new ModelZamowienie();
            modelZamowienie.ID = 1;
            modelZamowienie.DodajKoszyk(modelKoszyk);
          //  db.Zamowienia.Add(modelZamowienie);

          //  db.SaveChanges();
            return View(modelZamowienie);//(db.Zamowienia.ToList());

        }
        // GET: ZarzadzanieZamowieniem
       /* public ActionResult Index()
        {
            ModelZamowienie mz = new ModelZamowienie();
            ModelKoszyk m = db2.Koszyki.Find(1);
            mz.modelKoszyk = m;
            db.Zamowienia.Add(mz);



            return View(db.Zamowienia.ToList());
        }*/

        // GET: ZarzadzanieZamowieniem/Details/5
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

        // GET: ZarzadzanieZamowieniem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZarzadzanieZamowieniem/Create
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

        // GET: ZarzadzanieZamowieniem/Edit/5
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

        // POST: ZarzadzanieZamowieniem/Edit/5
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

        // GET: ZarzadzanieZamowieniem/Delete/5
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

        // POST: ZarzadzanieZamowieniem/Delete/5
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
