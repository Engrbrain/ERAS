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
    public class BackAllocationQwSummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQwSummaries
        public ActionResult Index()
        {
            List<BackAllocationQwSummary> backAllocationQwSummary = new List<BackAllocationQwSummary>();

            backAllocationQwSummary = db.Database.SqlQuery<BackAllocationQwSummary>(
        "usp_GetBackAllocationQwSummary"
        ).ToList();
            return View(backAllocationQwSummary);
        }

        // GET: BackAllocationQwSummaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQwSummary backAllocationQwSummary = db.BackAllocationQwSummary.Find(id);
            if (backAllocationQwSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQwSummary);
        }

        // GET: BackAllocationQwSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQwSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,Qw")] BackAllocationQwSummary backAllocationQwSummary)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQwSummary.Add(backAllocationQwSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQwSummary);
        }

        // GET: BackAllocationQwSummaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQwSummary backAllocationQwSummary = db.BackAllocationQwSummary.Find(id);
            if (backAllocationQwSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQwSummary);
        }

        // POST: BackAllocationQwSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,Qw")] BackAllocationQwSummary backAllocationQwSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQwSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQwSummary);
        }

        // GET: BackAllocationQwSummaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQwSummary backAllocationQwSummary = db.BackAllocationQwSummary.Find(id);
            if (backAllocationQwSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQwSummary);
        }

        // POST: BackAllocationQwSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQwSummary backAllocationQwSummary = db.BackAllocationQwSummary.Find(id);
            db.BackAllocationQwSummary.Remove(backAllocationQwSummary);
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
