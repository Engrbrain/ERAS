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
    public class BackAllocationGasAllocationSummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationGasAllocationSummaries
        public ActionResult Index()
        {
            List<BackAllocationGasAllocationSummary> backAllocationGasAllocationSummary = new List<BackAllocationGasAllocationSummary>();

            backAllocationGasAllocationSummary = db.Database.SqlQuery<BackAllocationGasAllocationSummary>(
        "usp_GetBackAllocationGasAllocationSummary"
        ).ToList();
            return View(backAllocationGasAllocationSummary);
        }

        // GET: BackAllocationGasAllocationSummaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationGasAllocationSummary backAllocationGasAllocationSummary = db.BackAllocationGasAllocationSummary.Find(id);
            if (backAllocationGasAllocationSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationGasAllocationSummary);
        }

        // GET: BackAllocationGasAllocationSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationGasAllocationSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,GasAllocation,ActualGasProduced,GasDifference")] BackAllocationGasAllocationSummary backAllocationGasAllocationSummary)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationGasAllocationSummary.Add(backAllocationGasAllocationSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationGasAllocationSummary);
        }

        // GET: BackAllocationGasAllocationSummaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationGasAllocationSummary backAllocationGasAllocationSummary = db.BackAllocationGasAllocationSummary.Find(id);
            if (backAllocationGasAllocationSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationGasAllocationSummary);
        }

        // POST: BackAllocationGasAllocationSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,GasAllocation,ActualGasProduced,GasDifference")] BackAllocationGasAllocationSummary backAllocationGasAllocationSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationGasAllocationSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationGasAllocationSummary);
        }

        // GET: BackAllocationGasAllocationSummaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationGasAllocationSummary backAllocationGasAllocationSummary = db.BackAllocationGasAllocationSummary.Find(id);
            if (backAllocationGasAllocationSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationGasAllocationSummary);
        }

        // POST: BackAllocationGasAllocationSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationGasAllocationSummary backAllocationGasAllocationSummary = db.BackAllocationGasAllocationSummary.Find(id);
            db.BackAllocationGasAllocationSummary.Remove(backAllocationGasAllocationSummary);
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
