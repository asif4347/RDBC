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
    public class RoutineChemistryLabsController : Controller
    {
        private BloodDbContext db = new BloodDbContext();

        // GET: RoutineChemistryLabs
        public ActionResult Index()
        {
            return View(db.RoutineChemistryLabs.ToList());
        }

        // GET: RoutineChemistryLabs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoutineChemistryLab routineChemistryLab = db.RoutineChemistryLabs.Find(id);
            if (routineChemistryLab == null)
            {
                return HttpNotFound();
            }
            return View(routineChemistryLab);
        }

        // GET: RoutineChemistryLabs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoutineChemistryLabs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Address,Contact,Result,isDelivered,ReferedBy,TestRequested,Payment")] RoutineChemistryLab routineChemistryLab)
        {
            if (ModelState.IsValid)
            {
                db.RoutineChemistryLabs.Add(routineChemistryLab);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(routineChemistryLab);
        }

        // GET: RoutineChemistryLabs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoutineChemistryLab routineChemistryLab = db.RoutineChemistryLabs.Find(id);
            if (routineChemistryLab == null)
            {
                return HttpNotFound();
            }
            return View(routineChemistryLab);
        }

        // POST: RoutineChemistryLabs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Address,Contact,Result,isDelivered,ReferedBy,TestRequested,Payment")] RoutineChemistryLab routineChemistryLab)
        {
            if (ModelState.IsValid)
            {
                db.Entry(routineChemistryLab).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(routineChemistryLab);
        }

        // GET: RoutineChemistryLabs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoutineChemistryLab routineChemistryLab = db.RoutineChemistryLabs.Find(id);
            if (routineChemistryLab == null)
            {
                return HttpNotFound();
            }
            return View(routineChemistryLab);
        }

        // POST: RoutineChemistryLabs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RoutineChemistryLab routineChemistryLab = db.RoutineChemistryLabs.Find(id);
            db.RoutineChemistryLabs.Remove(routineChemistryLab);
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
