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
    public class BackAllocationQgPotentialSummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQgPotentialSummaries
        public ActionResult Index()
        {
            List<BackAllocationQgPotentialSummary> backAllocationQgPotentialSummary = new List<BackAllocationQgPotentialSummary>();

            backAllocationQgPotentialSummary = db.Database.SqlQuery<BackAllocationQgPotentialSummary>(
        "usp_GetBackAllocationQgPotentialSummary"
        ).ToList();
            return View(backAllocationQgPotentialSummary);
        }

        // GET: BackAllocationQgPotentialSummaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgPotentialSummary backAllocationQgPotentialSummary = db.BackAllocationQgPotentialSummary.Find(id);
            if (backAllocationQgPotentialSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgPotentialSummary);
        }

        // GET: BackAllocationQgPotentialSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQgPotentialSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,QgPotential")] BackAllocationQgPotentialSummary backAllocationQgPotentialSummary)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQgPotentialSummary.Add(backAllocationQgPotentialSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQgPotentialSummary);
        }

        // GET: BackAllocationQgPotentialSummaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgPotentialSummary backAllocationQgPotentialSummary = db.BackAllocationQgPotentialSummary.Find(id);
            if (backAllocationQgPotentialSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgPotentialSummary);
        }

        // POST: BackAllocationQgPotentialSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,QgPotential")] BackAllocationQgPotentialSummary backAllocationQgPotentialSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQgPotentialSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQgPotentialSummary);
        }

        // GET: BackAllocationQgPotentialSummaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgPotentialSummary backAllocationQgPotentialSummary = db.BackAllocationQgPotentialSummary.Find(id);
            if (backAllocationQgPotentialSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgPotentialSummary);
        }

        // POST: BackAllocationQgPotentialSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQgPotentialSummary backAllocationQgPotentialSummary = db.BackAllocationQgPotentialSummary.Find(id);
            db.BackAllocationQgPotentialSummary.Remove(backAllocationQgPotentialSummary);
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
