using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERAS.Models;
using ERAS.Models.EBOKOutputData;

namespace ERAS.Controllers
{
    public class BackAllocationActualGORSummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationActualGORSummaries
        public ActionResult Index(DateTime StartDate, DateTime EndDate)
        {
            List<BackAllocationActualGORSummary> backAllocationActualGORSummary = new List<BackAllocationActualGORSummary>();

            backAllocationActualGORSummary = db.Database.SqlQuery<BackAllocationActualGORSummary>(
        "exec dbo.[usp_GetBackAllocationActualGORSummary]@StartDate,@EndDate",
       new SqlParameter("@StartDate", StartDate),
       new SqlParameter("@EndDate", EndDate)
        ).ToList();
            return View(backAllocationActualGORSummary);
        }

        // GET: BackAllocationActualGORSummaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationActualGORSummary backAllocationActualGORSummary = db.BackAllocationActualGORSummary.Find(id);
            if (backAllocationActualGORSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationActualGORSummary);
        }

        // GET: BackAllocationActualGORSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationActualGORSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,ActualGOR")] BackAllocationActualGORSummary backAllocationActualGORSummary)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationActualGORSummary.Add(backAllocationActualGORSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationActualGORSummary);
        }

        // GET: BackAllocationActualGORSummaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationActualGORSummary backAllocationActualGORSummary = db.BackAllocationActualGORSummary.Find(id);
            if (backAllocationActualGORSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationActualGORSummary);
        }

        // POST: BackAllocationActualGORSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,ActualGOR")] BackAllocationActualGORSummary backAllocationActualGORSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationActualGORSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationActualGORSummary);
        }

        // GET: BackAllocationActualGORSummaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationActualGORSummary backAllocationActualGORSummary = db.BackAllocationActualGORSummary.Find(id);
            if (backAllocationActualGORSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationActualGORSummary);
        }

        // POST: BackAllocationActualGORSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationActualGORSummary backAllocationActualGORSummary = db.BackAllocationActualGORSummary.Find(id);
            db.BackAllocationActualGORSummary.Remove(backAllocationActualGORSummary);
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
