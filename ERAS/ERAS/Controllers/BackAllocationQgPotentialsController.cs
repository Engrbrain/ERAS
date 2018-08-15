using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERAS.Models;
using ERAS.Models.EBOKOutputData;

namespace ERAS.Controllers
{
    public class BackAllocationQgPotentialsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQgPotentials
        public ActionResult Index()
        {
            List<BackAllocationQgPotential> backAllocationQgPotential = new List<BackAllocationQgPotential>();

            backAllocationQgPotential = db.Database.SqlQuery<BackAllocationQgPotential>(
        "usp_GetBackAllocationQgPotential"
        ).ToList();
            return View(backAllocationQgPotential);
        }

        // GET: BackAllocationQgPotentials/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgPotential backAllocationQgPotential = db.BackAllocationQgPotential.Find(id);
            if (backAllocationQgPotential == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgPotential);
        }

        // GET: BackAllocationQgPotentials/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQgPotentials/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,QgPotential")] BackAllocationQgPotential backAllocationQgPotential)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQgPotential.Add(backAllocationQgPotential);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQgPotential);
        }

        // GET: BackAllocationQgPotentials/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgPotential backAllocationQgPotential = db.BackAllocationQgPotential.Find(id);
            if (backAllocationQgPotential == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgPotential);
        }

        // POST: BackAllocationQgPotentials/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,QgPotential")] BackAllocationQgPotential backAllocationQgPotential)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQgPotential).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQgPotential);
        }

        // GET: BackAllocationQgPotentials/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgPotential backAllocationQgPotential = db.BackAllocationQgPotential.Find(id);
            if (backAllocationQgPotential == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgPotential);
        }

        // POST: BackAllocationQgPotentials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQgPotential backAllocationQgPotential = db.BackAllocationQgPotential.Find(id);
            db.BackAllocationQgPotential.Remove(backAllocationQgPotential);
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
