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
    public class BackAllocationQlinkSummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQlinkSummaries
        public ActionResult Index()
        {
            List<BackAllocationQlinkSummary> backAllocationQlinkSummary = new List<BackAllocationQlinkSummary>();

            backAllocationQlinkSummary = db.Database.SqlQuery<BackAllocationQlinkSummary>(
        "usp_GetBackAllocationQlinkSummary"
        ).ToList();
            return View(backAllocationQlinkSummary);
        }

        // GET: BackAllocationQlinkSummaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlinkSummary backAllocationQlinkSummary = db.BackAllocationQlinkSummary.Find(id);
            if (backAllocationQlinkSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlinkSummary);
        }

        // GET: BackAllocationQlinkSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQlinkSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,ProdOil,TotalQlink")] BackAllocationQlinkSummary backAllocationQlinkSummary)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQlinkSummary.Add(backAllocationQlinkSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQlinkSummary);
        }

        // GET: BackAllocationQlinkSummaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlinkSummary backAllocationQlinkSummary = db.BackAllocationQlinkSummary.Find(id);
            if (backAllocationQlinkSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlinkSummary);
        }

        // POST: BackAllocationQlinkSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,ProdOil,TotalQlink")] BackAllocationQlinkSummary backAllocationQlinkSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQlinkSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQlinkSummary);
        }

        // GET: BackAllocationQlinkSummaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlinkSummary backAllocationQlinkSummary = db.BackAllocationQlinkSummary.Find(id);
            if (backAllocationQlinkSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlinkSummary);
        }

        // POST: BackAllocationQlinkSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQlinkSummary backAllocationQlinkSummary = db.BackAllocationQlinkSummary.Find(id);
            db.BackAllocationQlinkSummary.Remove(backAllocationQlinkSummary);
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
