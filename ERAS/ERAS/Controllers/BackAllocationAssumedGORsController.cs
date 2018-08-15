using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERAS.Models;
using ERAS.Models.EBOKTranformedData;

namespace ERAS.Controllers
{
    public class BackAllocationAssumedGORsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationAssumedGORs
        public ActionResult Index()
        {
            return View(db.FlowParameter.ToList());
        }

        // GET: BackAllocationAssumedGORs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationAssumedGOR backAllocationAssumedGOR = db.FlowParameter.Find(id);
            if (backAllocationAssumedGOR == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationAssumedGOR);
        }

        // GET: BackAllocationAssumedGORs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationAssumedGORs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Well,IndicatorDate,AssumedGOR,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] BackAllocationAssumedGOR backAllocationAssumedGOR)
        {
            if (ModelState.IsValid)
            {
                db.FlowParameter.Add(backAllocationAssumedGOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationAssumedGOR);
        }

        // GET: BackAllocationAssumedGORs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationAssumedGOR backAllocationAssumedGOR = db.FlowParameter.Find(id);
            if (backAllocationAssumedGOR == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationAssumedGOR);
        }

        // POST: BackAllocationAssumedGORs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Well,IndicatorDate,AssumedGOR,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] BackAllocationAssumedGOR backAllocationAssumedGOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationAssumedGOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationAssumedGOR);
        }

        // GET: BackAllocationAssumedGORs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationAssumedGOR backAllocationAssumedGOR = db.FlowParameter.Find(id);
            if (backAllocationAssumedGOR == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationAssumedGOR);
        }

        // POST: BackAllocationAssumedGORs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationAssumedGOR backAllocationAssumedGOR = db.FlowParameter.Find(id);
            db.FlowParameter.Remove(backAllocationAssumedGOR);
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
