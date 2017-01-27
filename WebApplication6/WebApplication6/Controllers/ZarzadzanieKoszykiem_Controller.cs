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
    public class ZarzadzanieKoszykiem_Controller : Controller
    {
        private ModelSpektaklDBCtxt db = new ModelSpektaklDBCtxt();

        // GET: ZarzadzanieKoszykiem_
        public ActionResult Index()
        {
            return View(db.Spektakle.ToList());
        }

        // GET: ZarzadzanieKoszykiem_/Details/5
        public ActionResult Details(int? id)
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

        // GET: ZarzadzanieKoszykiem_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZarzadzanieKoszykiem_/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IDs,Wykonawcy,Lokalizacja,Tytuł,Auror,Cena,data")] ModelSpektakl modelSpektakl)
        {
            if (ModelState.IsValid)
            {
                db.Spektakle.Add(modelSpektakl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modelSpektakl);
        }

        // GET: ZarzadzanieKoszykiem_/Edit/5
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

        // POST: ZarzadzanieKoszykiem_/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IDs,Wykonawcy,Lokalizacja,Tytuł,Auror,Cena,data")] ModelSpektakl modelSpektakl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modelSpektakl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modelSpektakl);
        }

        // GET: ZarzadzanieKoszykiem_/Delete/5
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

        // POST: ZarzadzanieKoszykiem_/Delete/5
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
        //zarzadzanie obrazkami
        public ActionResult FileUpload(HttpPostedFileBase file)
        {

            if (file != null)
            {
                
                string ImageName = System.IO.Path.GetFileName(file.FileName);
                string physicalPath = Server.MapPath("~/images/" + ImageName);

               
                //save new record in database
                ModelSpektakl newRecord = new ModelSpektakl();
                newRecord.Tytuł = Request.Form["fname"];
                newRecord.Wykonawcy = Request.Form["lname"];
                newRecord.ImgUrl = ImageName;
                db.Spektakle.Add(newRecord);
                db.SaveChanges();

            }
        
            //Display records
                return RedirectToAction("../home/Display/");
            }

            public ActionResult Display()
            {
                return View();
            }
        }

        
}
