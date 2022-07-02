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
    public class MusteriController : Controller
    {
     
      private GuvenlikDbEntities3 db = new GuvenlikDbEntities3();
       // private GuvenlikDbEntities db = new GuvenlikDbEntities();
        // GET: Musteri
        public ActionResult Index()
        {
            return View(db.GMusteri.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GMusteri gMusteri = db.GMusteri.Find(id);
            if (gMusteri == null)
            {
                return HttpNotFound();
            }
            return View(gMusteri);
        }

        public ActionResult Create()
        {
            return View();
        }
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MusteriId,AdSoyad,Mail,Telefon,Adres")] GMusteri  gMusteri)
        {//bu kısımda tüm tablo degerlkerini yazmaank zorudndasın

            if (ModelState.IsValid)
            {
                db.GMusteri.Add(gMusteri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gMusteri);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GMusteri gMusteri = db.GMusteri.Find(id);
            if (gMusteri == null)
            {
                return HttpNotFound();
            }
            return View(gMusteri);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MusteriId,AdSoyad,Mail,Telefon,Adres")] GMusteri gMusteri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gMusteri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gMusteri);
        }

        // GET: GKatagoris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GMusteri gMusteri = db.GMusteri.Find(id);
            if (gMusteri == null)
            {
                return HttpNotFound();
            }
            return View(gMusteri);
        }

        // POST: GKatagoris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GMusteri gMusteri = db.GMusteri.Find(id);
            db.GMusteri.Remove(gMusteri);
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
