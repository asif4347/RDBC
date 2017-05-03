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
    public class SpecialChemistryLabsController : Controller
    {
        private BloodDbContext db = new BloodDbContext();

        // GET: SpecialChemistryLabs
        public ActionResult Index()
        {
            return View(db.SpecialChemistryLabs.ToList());
        }

        // GET: SpecialChemistryLabs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpecialChemistryLab specialChemistryLab = db.SpecialChemistryLabs.Find(id);
            if (specialChemistryLab == null)
            {
                return HttpNotFound();
            }
            return View(specialChemistryLab);
        }

        // GET: SpecialChemistryLabs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SpecialChemistryLabs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Address,Contact,Result,isDelivered,ReferedBy,TestRequested,Payment")] SpecialChemistryLab specialChemistryLab)
        {
            if (ModelState.IsValid)
            {
                db.SpecialChemistryLabs.Add(specialChemistryLab);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(specialChemistryLab);
        }

        // GET: SpecialChemistryLabs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpecialChemistryLab specialChemistryLab = db.SpecialChemistryLabs.Find(id);
            if (specialChemistryLab == null)
            {
                return HttpNotFound();
            }
            return View(specialChemistryLab);
        }

        // POST: SpecialChemistryLabs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Address,Contact,Result,isDelivered,ReferedBy,TestRequested,Payment")] SpecialChemistryLab specialChemistryLab)
        {
            if (ModelState.IsValid)
            {
                db.Entry(specialChemistryLab).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(specialChemistryLab);
        }

        // GET: SpecialChemistryLabs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpecialChemistryLab specialChemistryLab = db.SpecialChemistryLabs.Find(id);
            if (specialChemistryLab == null)
            {
                return HttpNotFound();
            }
            return View(specialChemistryLab);
        }

        // POST: SpecialChemistryLabs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SpecialChemistryLab specialChemistryLab = db.SpecialChemistryLabs.Find(id);
            db.SpecialChemistryLabs.Remove(specialChemistryLab);
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
