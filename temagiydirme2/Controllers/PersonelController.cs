using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using temagiydirme2.Models;


namespace temagiydirme2.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
       
        private GuvenlikDbEntities3 db = new GuvenlikDbEntities3();
        // GET: Katagori
        public ActionResult Index()
        {
            return View(db.GPersonel.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GPersonel gPersonel = db.GPersonel.Find(id);
            if (gPersonel == null)
            {
                return HttpNotFound();
            }
            return View(gPersonel);
        }
        public ActionResult Create()
        {
            return View();
        }
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonelId,PerAdSoyad,PerMail,PerTel,PerAdres")] GPersonel gPersonel)
        {//bu kısımda tüm tablo degerlkerini yazmaank zorudndasın

            if (ModelState.IsValid)
            {
                db.GPersonel.Add(gPersonel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gPersonel);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GPersonel gPersonel = db.GPersonel.Find(id);
            if (gPersonel == null)
            {
                return HttpNotFound();
            }
            return View(gPersonel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonelId,PerAdSoyad,PerMail,PerTel,PerAdres")] GPersonel gPersonel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gPersonel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gPersonel);
        }

        // GET: GKatagoris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GPersonel gPersonel = db.GPersonel.Find(id);
            if (gPersonel == null)
            {
                return HttpNotFound();
            }
            return View(gPersonel);
        }

        // POST: GKatagoris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GPersonel gPersonel = db.GPersonel.Find(id);
            db.GPersonel.Remove(gPersonel);
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