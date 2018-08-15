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
    public class BackAllocationQgActualSummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQgActualSummaries
        public ActionResult Index()
        {
            List<BackAllocationQgActualSummary> backAllocationQgActualSummary = new List<BackAllocationQgActualSummary>();

            backAllocationQgActualSummary = db.Database.SqlQuery<BackAllocationQgActualSummary>(
        "usp_GetBackAllocationQgActualSummary"
        ).ToList();
            return View(backAllocationQgActualSummary);
        }

        // GET: BackAllocationQgActualSummaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgActualSummary backAllocationQgActualSummary = db.BackAllocationQgActualSummary.Find(id);
            if (backAllocationQgActualSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgActualSummary);
        }

        // GET: BackAllocationQgActualSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQgActualSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,QgActual")] BackAllocationQgActualSummary backAllocationQgActualSummary)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQgActualSummary.Add(backAllocationQgActualSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQgActualSummary);
        }

        // GET: BackAllocationQgActualSummaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgActualSummary backAllocationQgActualSummary = db.BackAllocationQgActualSummary.Find(id);
            if (backAllocationQgActualSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgActualSummary);
        }

        // POST: BackAllocationQgActualSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,QgActual")] BackAllocationQgActualSummary backAllocationQgActualSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQgActualSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQgActualSummary);
        }

        // GET: BackAllocationQgActualSummaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgActualSummary backAllocationQgActualSummary = db.BackAllocationQgActualSummary.Find(id);
            if (backAllocationQgActualSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgActualSummary);
        }

        // POST: BackAllocationQgActualSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQgActualSummary backAllocationQgActualSummary = db.BackAllocationQgActualSummary.Find(id);
            db.BackAllocationQgActualSummary.Remove(backAllocationQgActualSummary);
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
