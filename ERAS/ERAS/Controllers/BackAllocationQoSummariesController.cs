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
    public class BackAllocationQoSummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQoSummaries
        public ActionResult Index()
        {
            List<BackAllocationQoSummary> backAllocationQoSummary = new List<BackAllocationQoSummary>();

            backAllocationQoSummary = db.Database.SqlQuery<BackAllocationQoSummary>(
        "usp_GetBackAllocationQoSummary"
        ).ToList();
            return View(backAllocationQoSummary);
        }

        // GET: BackAllocationQoSummaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoSummary backAllocationQoSummary = db.BackAllocationQoSummary.Find(id);
            if (backAllocationQoSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoSummary);
        }

        // GET: BackAllocationQoSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQoSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,Qo,ProdOil")] BackAllocationQoSummary backAllocationQoSummary)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQoSummary.Add(backAllocationQoSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQoSummary);
        }

        // GET: BackAllocationQoSummaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoSummary backAllocationQoSummary = db.BackAllocationQoSummary.Find(id);
            if (backAllocationQoSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoSummary);
        }

        // POST: BackAllocationQoSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,Qo,ProdOil")] BackAllocationQoSummary backAllocationQoSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQoSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQoSummary);
        }

        // GET: BackAllocationQoSummaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoSummary backAllocationQoSummary = db.BackAllocationQoSummary.Find(id);
            if (backAllocationQoSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoSummary);
        }

        // POST: BackAllocationQoSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQoSummary backAllocationQoSummary = db.BackAllocationQoSummary.Find(id);
            db.BackAllocationQoSummary.Remove(backAllocationQoSummary);
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
