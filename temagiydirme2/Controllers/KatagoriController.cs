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
    public class KatagoriController : Controller
    {
        private GuvenlikDbEntities3 db= new GuvenlikDbEntities3();
        // GET: Katagori
        public ActionResult Index()
        {
            return View(db.GKatagori.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GKatagori gKatagori = db.GKatagori.Find(id);
            if (gKatagori == null)
            {
                return HttpNotFound();
            }
            return View(gKatagori);
        }
        public ActionResult Create()
        {
            return View();
        }
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KatagoriId,KatagoriAdi")] GKatagori gKatagori)
        {//bu kısımda tüm tablo degerlkerini yazmaank zorudndasın

            if (ModelState.IsValid)
            {
                db.GKatagori.Add(gKatagori);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gKatagori);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GKatagori gKatagori = db.GKatagori.Find(id);
            if (gKatagori == null)
            {
                return HttpNotFound();
            }
            return View(gKatagori);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KatagoriId,KatagoriAdi")]  GKatagori gKatagori)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gKatagori).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gKatagori);
        }

        // GET: GKatagoris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GKatagori gKatagori = db.GKatagori.Find(id);
            if (gKatagori == null)
            {
                return HttpNotFound();
            }
            return View(gKatagori);
        }

        // POST: GKatagoris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GKatagori gKatagori = db.GKatagori.Find(id);
            db.GKatagori.Remove(gKatagori);
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