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
        private ModelSpektaklDBCtxt db = new ModelSpektaklDBCtxt();
        private ModelKoszykDBCtxt db2 = new ModelKoszykDBCtxt();
        private static int ktory { get; set; }

        // GET: ZarzadzanieKoszykiem
        public ActionResult Index()
        {
            return View(db.Spektakle.ToList());
        }

        // GET: ZarzadzanieKoszykiem/Details/5
        public ActionResult Details(int? id)
        {
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ktory = (int)id;
            ModelSpektakl modelSpektakl = db.Spektakle.Find(id);
            if (modelSpektakl == null)
            {
                return HttpNotFound();
            }
          
           
            return View(modelSpektakl);
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
        public ActionResult Create([Bind(Include = "Id,IDs,Wykonawcy,Picture,Image,DisplayItem,Lokalizacja,Tytuł,Auror,Cena,data")] ModelSpektakl modelSpektakl)
        {
            if (ModelState.IsValid)
            {
                db.Spektakle.Add(modelSpektakl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modelSpektakl);
        }

        // GET: ZarzadzanieKoszykiem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelSpektakl modelSpektakl = db.Spektakle.Find(id);
            if (modelSpektakl == null)
            {
                return HttpNotFound();
            }
            return View(modelSpektakl);
        }

        // POST: ZarzadzanieKoszykiem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IDs,Wykonawcy,Picture,Image,DisplayItem,Lokalizacja,Tytuł,Auror,Cena,data")] ModelSpektakl modelSpektakl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modelSpektakl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modelSpektakl);
        }

        // GET: ZarzadzanieKoszykiem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelSpektakl modelSpektakl = db.Spektakle.Find(id);
            if (modelSpektakl == null)
            {
                return HttpNotFound();
            }
            return View(modelSpektakl);
        }

        // POST: ZarzadzanieKoszykiem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModelSpektakl modelSpektakl = db.Spektakle.Find(id);
            db.Spektakle.Remove(modelSpektakl);
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
        public ActionResult DodajDoKoszyka()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DodajDoKoszyka([Bind(Include = "Id,iloscBiletow,iloscUlgowych,sektor,Miejsce,Rzad,Cena,Tytuł,Auror,Cena,data")] ModelKoszyk modelKoszyk, int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

           /* ModelSpektakl modelSpektakl = db.Spektakle.Find(id);

            if (modelSpektakl == null)
            {
                return HttpNotFound();
            }
            
                 modelKoszyk.DodajSpektakl(modelSpektakl);

    */
            if (ModelState.IsValid)
            {

                db2.Koszyki.Add(modelKoszyk);
                db2.SaveChanges();
                return RedirectToAction("Zamowienie",modelKoszyk);
                
            }

            return View(modelKoszyk);
        }

        

        public ActionResult Zamowienie(int? id,ModelKoszyk modelKoszyk)
        {
            if( ktory == 0 )
            {
                return RedirectToAction("Index");

            }
                

            ModelSpektakl modelSpektakl = db.Spektakle.Find(ktory);
           
            if (modelSpektakl == null)
            {
                return HttpNotFound();
            }

           modelKoszyk.DodajSpektakl(modelSpektakl);
           db2.Koszyki.Add(modelKoszyk);
           db2.SaveChanges();



            return RedirectToAction("Index", "ZarzadzanieZamowieniem", modelKoszyk);
               
            




            //return View(modelKoszyk);
            
        }
        /*public ActionResult przekierowanie()
        {
            ModelKoszyk mkk = db2.Koszyki.First();
            return RedirectToAction("Index", "ZarzadzanieZamowieniem", new
            {

                id = 1,
                otherParam = "Something",
                anotherParam = "OtherStuff",
                mkk
                
            });
        }*/
      



    }
}
