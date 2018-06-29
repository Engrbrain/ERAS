using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERAS.Models;
using ERAS.Models.EBOKDailyReport;

namespace ERAS.Controllers
{
    public class OperationsSummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OperationsSummaries
        public ActionResult Index()
        {
            return View(db.OperationsSummaries.ToList());
        }

        // GET: OperationsSummaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OperationsSummary operationsSummary = db.OperationsSummaries.Find(id);
            if (operationsSummary == null)
            {
                return HttpNotFound();
            }
            return View(operationsSummary);
        }

        // GET: OperationsSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OperationsSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,OperationsReport,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] OperationsSummary operationsSummary)
        {
            if (ModelState.IsValid)
            {
                db.OperationsSummaries.Add(operationsSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(operationsSummary);
        }

        // GET: OperationsSummaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OperationsSummary operationsSummary = db.OperationsSummaries.Find(id);
            if (operationsSummary == null)
            {
                return HttpNotFound();
            }
            return View(operationsSummary);
        }

        // POST: OperationsSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,OperationsReport,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] OperationsSummary operationsSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(operationsSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(operationsSummary);
        }

        // GET: OperationsSummaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OperationsSummary operationsSummary = db.OperationsSummaries.Find(id);
            if (operationsSummary == null)
            {
                return HttpNotFound();
            }
            return View(operationsSummary);
        }

        // POST: OperationsSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OperationsSummary operationsSummary = db.OperationsSummaries.Find(id);
            db.OperationsSummaries.Remove(operationsSummary);
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
