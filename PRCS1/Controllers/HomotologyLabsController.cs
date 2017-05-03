using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PRCS.Models;
using PRCS1.Models;

namespace PRCS1.Controllers
{
    public class HomotologyLabsController : Controller
    {
        private BloodDbContext db = new BloodDbContext();

        // GET: HomotologyLabs
        public ActionResult Index()
        {
            return View(db.HomotologyLabs.ToList());
        }

        // GET: HomotologyLabs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomotologyLab homotologyLab = db.HomotologyLabs.Find(id);
            if (homotologyLab == null)
            {
                return HttpNotFound();
            }
            return View(homotologyLab);
        }

        // GET: HomotologyLabs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomotologyLabs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Address,Contact,Result,isDelivered,ReferedBy,TestRequested,Payment")] HomotologyLab homotologyLab)
        {
            if (ModelState.IsValid)
            {
                db.HomotologyLabs.Add(homotologyLab);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(homotologyLab);
        }

        // GET: HomotologyLabs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomotologyLab homotologyLab = db.HomotologyLabs.Find(id);
            if (homotologyLab == null)
            {
                return HttpNotFound();
            }
            return View(homotologyLab);
        }

        // POST: HomotologyLabs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Address,Contact,Result,isDelivered,ReferedBy,TestRequested,Payment")] HomotologyLab homotologyLab)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homotologyLab).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(homotologyLab);
        }

        // GET: HomotologyLabs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomotologyLab homotologyLab = db.HomotologyLabs.Find(id);
            if (homotologyLab == null)
            {
                return HttpNotFound();
            }
            return View(homotologyLab);
        }

        // POST: HomotologyLabs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomotologyLab homotologyLab = db.HomotologyLabs.Find(id);
            db.HomotologyLabs.Remove(homotologyLab);
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
