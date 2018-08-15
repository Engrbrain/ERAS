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
    public class BackAllocationBPLDsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationBPLDs
        public ActionResult Index()
        {
            return View(db.BackAllocationBPLD.ToList());
        }

        // GET: BackAllocationBPLDs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationBPLD backAllocationBPLD = db.BackAllocationBPLD.Find(id);
            if (backAllocationBPLD == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationBPLD);
        }

        // GET: BackAllocationBPLDs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationBPLDs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,BPLD,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] BackAllocationBPLD backAllocationBPLD)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationBPLD.Add(backAllocationBPLD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationBPLD);
        }

        // GET: BackAllocationBPLDs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationBPLD backAllocationBPLD = db.BackAllocationBPLD.Find(id);
            if (backAllocationBPLD == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationBPLD);
        }

        // POST: BackAllocationBPLDs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,BPLD,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] BackAllocationBPLD backAllocationBPLD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationBPLD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationBPLD);
        }

        // GET: BackAllocationBPLDs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationBPLD backAllocationBPLD = db.BackAllocationBPLD.Find(id);
            if (backAllocationBPLD == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationBPLD);
        }

        // POST: BackAllocationBPLDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationBPLD backAllocationBPLD = db.BackAllocationBPLD.Find(id);
            db.BackAllocationBPLD.Remove(backAllocationBPLD);
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
