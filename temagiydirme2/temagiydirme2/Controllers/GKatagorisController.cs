using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using temagiydirme2.Models;

namespace temagiydirme2.Controllers
{
    public class GKatagorisController : Controller
    {
        private GuvenlikDbEntities db = new GuvenlikDbEntities();

        // GET: GKatagoris
        public ActionResult Index()
        {
            return View(db.GKatagoris.ToList());
        }

        // GET: GKatagoris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GKatagori gKatagori = db.GKatagoris.Find(id);
            if (gKatagori == null)
            {
                return HttpNotFound();
            }
            return View(gKatagori);
        }

        // GET: GKatagoris/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GKatagoris/Create
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KatagoriId,KatagoriAdi")] GKatagori gKatagori)
        {
            if (ModelState.IsValid)
            {
                db.GKatagoris.Add(gKatagori);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gKatagori);
        }

        // GET: GKatagoris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GKatagori gKatagori = db.GKatagoris.Find(id);
            if (gKatagori == null)
            {
                return HttpNotFound();
            }
            return View(gKatagori);
        }

        // POST: GKatagoris/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KatagoriId,KatagoriAdi")] GKatagori gKatagori)
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
            GKatagori gKatagori = db.GKatagoris.Find(id);
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
            GKatagori gKatagori = db.GKatagoris.Find(id);
            db.GKatagoris.Remove(gKatagori);
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
